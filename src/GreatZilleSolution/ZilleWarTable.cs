using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MelonLoader;
using UnityEngine;
using Il2Cpp;

namespace GreatZilleSolution
{
    /// <summary>
    /// Re-skins the vanilla Pales war table ("Map_Rizia_PalesWar") so it shows the Zille map and Zille provinces.
    ///
    /// How the vanilla table is built (verified against storypack_rizia_assets_all_*.bundle, see docs/ZILLE_MAP_INTEGRATION.md):
    ///  * Map_Rizia_PalesWar has 6 quad children "Pales Map_01 ".."Pales Map_06" (3x2 grid, each 0.666 wide, centres at
    ///    x = -0.166 / 0.5 / 1.166, y = 0.3471 / -0.3185). Material MA_MapPales_0N, texture property "_Diffuse" (4096x4096, no mips,
    ///    bilinear, clamp, sRGB), _AlphaClip = 1 with threshold 0.5 (alpha 0 pixels are discarded).
    ///  * "Tile Map/Tile_N" holds 133 WarTile objects (N = 1..100 and S1..S33). The game finds them with string.Format("Tile_{0}", name).
    ///    Each tile is a unit quad (scale 0.1543 land / 0.2761 sea) using material MA_PalesTile / shader S_IndividualTile whose
    ///    "_Tile_Texture" is a 512x512 red/green MASK (R = interior, G = outline falloff). The shader does all the colouring
    ///    (tint, outline, gradient, pulse, highlight) - the red/green image is NOT meant to be seen directly.
    ///
    /// Therefore: swap "_Diffuse" on per-renderer material INSTANCES (the shared Pales assets are never modified, so the Pales war
    /// keeps working untouched), move/re-texture a few WarTile objects, and never touch any tile colour property.
    /// </summary>
    public static class ZilleWarTable
    {
        // ---- geometry of the vanilla table in Map_Rizia_PalesWar local space ----
        public const float PlaneWorld = 0.666f;                 // width of one 4096px map page
        public const float MapLeft = -0.166f - PlaneWorld / 2f; // x of the left edge of the 3x2 grid
        public const float MapTop = 0.3471f + PlaneWorld / 2f;  // y of the top edge
        public const float PxToWorld = PlaneWorld / 4096f;      // 1 full-res map pixel in local units
        public const float VanillaLandTileScale = 0.1543f;

        /// <summary>When true the Zille skin is (re)applied to whatever war map is alive. Set by EnterZilleWarTheatre.</summary>
        public static bool SkinEnabled { get; set; } = false;

        private class PlaneBackup { public Renderer Rend; public Material Shared; public Material Instance; }
        private class TileBackup
        {
            public WarTile Tile; public Vector3 LocalPos; public Vector3 LocalScale; public Texture2D Tex;
            public Il2CppSystem.Collections.Generic.List<WarTile> Adj; public float RootZ; public bool AdjApplied;
            public bool OrigActive; public bool OrigActiveStored;
        }

        private static Transform _root;
        private static readonly Dictionary<int, PlaneBackup> _planes = new Dictionary<int, PlaneBackup>();
        private static readonly Dictionary<int, TileBackup> _tiles = new Dictionary<int, TileBackup>();
        private static float _nextTick = 0f;
        private static float _nextFind = 0f;
        private static bool _loggedApplied = false;
        private static readonly HashSet<string> _warnedMissing = new HashSet<string>();

        // ================================================================== public API

        public static void Tick()
        {
            try
            {
                if (!SkinEnabled)
                {
                    if (_planes.Count > 0 || _tiles.Count > 0) Restore();
                    return;
                }
                if (Time.unscaledTime < _nextTick) return;
                _nextTick = Time.unscaledTime + 0.25f;

                if (_root == null)
                {
                    if (Time.unscaledTime < _nextFind) return;
                    _nextFind = Time.unscaledTime + 0.5f;
                    _root = FindWarMapRoot();
                    if (_root == null) return;
                    _planes.Clear(); _tiles.Clear(); _loggedApplied = false;
                    MelonLogger.Msg($"[ZTABLE] War map instance found: '{_root.name}' (id {_root.gameObject.GetInstanceID()}), applying Zille skin...");
                }

                ZilleMapLayoutManager.EnsureTexturesLoaded();
                int p = ApplyPlanes(_root);
                int t = ApplyTiles(_root);
                if (!_loggedApplied && (p > 0 || t > 0))
                {
                    _loggedApplied = true;
                    MelonLogger.Msg($"[ZTABLE] Zille skin applied: {p}/6 map pages, {t} province tiles.");
                    Diagnose("after-apply");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[ZTABLE] Tick error: {ex.Message}\n{ex.StackTrace}");
            }
        }

        /// <summary>Puts every touched renderer/tile back to vanilla Pales state.</summary>
        public static void Restore()
        {
            try
            {
                foreach (var kv in _planes)
                {
                    var pb = kv.Value;
                    if (pb.Rend != null)
                    {
                        if (pb.Shared != null) pb.Rend.sharedMaterial = pb.Shared;
                        if (pb.Instance != null) UnityEngine.Object.Destroy(pb.Instance);
                    }
                }
                foreach (var kv in _tiles)
                {
                    var tb = kv.Value;
                    if (tb.Tile == null) continue;
                    tb.Tile.transform.localPosition = tb.LocalPos;
                    tb.Tile.transform.localScale = tb.LocalScale;
                    tb.Tile.warTileTexture = tb.Tex;
                    tb.Tile.adjacentWarTiles = tb.Adj;
                    if (tb.OrigActiveStored && tb.Tile.gameObject.activeSelf != tb.OrigActive)
                        tb.Tile.gameObject.SetActive(tb.OrigActive);
                    var r = tb.Tile.GetWarTileRenderer();
                    if (r != null && r.material != null && r.material.HasProperty("_Tile_Texture") && tb.Tex != null)
                        r.material.SetTexture("_Tile_Texture", tb.Tex);
                }
                MelonLogger.Msg($"[ZTABLE] Restored vanilla Pales table ({_planes.Count} pages, {_tiles.Count} tiles).");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[ZTABLE] Restore error: {ex.Message}");
            }
            finally
            {
                _planes.Clear(); _tiles.Clear(); _root = null; _loggedApplied = false;
            }
        }

        // ================================================================== discovery

        private static Transform FindWarMapRoot()
        {
            var rends = Resources.FindObjectsOfTypeAll<Renderer>();
            if (rends == null) return null;
            for (int i = 0; i < rends.Length; i++)
            {
                var r = rends[i];
                if (r == null || r.gameObject == null) continue;
                if (!IsMapPlaneName(r.gameObject.name)) continue;
                // skip prefab assets that live in memory: only real scene instances have a valid scene
                if (!r.gameObject.scene.IsValid()) continue;
                var t = r.transform;
                for (int up = 0; up < 6 && t != null; up++)
                {
                    if (t.name.StartsWith("Map_Rizia_PalesWar", StringComparison.OrdinalIgnoreCase)) return t;
                    t = t.parent;
                }
                return r.transform.parent;   // fallback: parent of the page
            }
            return null;
        }

        private static bool IsMapPlaneName(string n)
        {
            if (string.IsNullOrEmpty(n)) return false;
            n = n.Trim();
            if (!n.StartsWith("Pales Map_", StringComparison.OrdinalIgnoreCase)) return false;
            return PlaneIndex(n) >= 1;
        }

        private static int PlaneIndex(string n)
        {
            n = n.Trim();
            if (n.Length < 12) return -1;
            return int.TryParse(n.Substring("Pales Map_".Length), out int idx) && idx >= 1 && idx <= 6 ? idx : -1;
        }

        // ================================================================== map pages

        private static int ApplyPlanes(Transform root)
        {
            int ok = 0;
            var rends = root.GetComponentsInChildren<Renderer>(true);
            for (int i = 0; i < rends.Length; i++)
            {
                var r = rends[i];
                if (r == null) continue;
                int idx = PlaneIndex(r.gameObject.name);
                if (idx < 1) continue;
                if (!ZilleMapLayoutManager.GridMapTiles.TryGetValue(idx, out var tex) || tex == null) continue;

                int rid = r.GetInstanceID();
                if (!_planes.TryGetValue(rid, out var pb))
                {
                    pb = new PlaneBackup { Rend = r, Shared = r.sharedMaterial };
                    // r.material clones the shared material for THIS renderer only -> Pales assets stay untouched
                    pb.Instance = r.material;
                    _planes[rid] = pb;
                }
                var mat = pb.Instance != null ? pb.Instance : r.material;
                if (mat == null || !mat.HasProperty("_Diffuse")) continue;
                var cur = mat.GetTexture("_Diffuse");
                if (cur == null || cur.GetInstanceID() != tex.GetInstanceID())
                    mat.SetTexture("_Diffuse", tex);
                ok++;
            }
            return ok;
        }

        // ================================================================== provinces

        public static Vector2 MapPxToLocal(float px, float py) => new Vector2(MapLeft + px * PxToWorld, MapTop - py * PxToWorld);

        public static bool HasLiveMap => _root != null;

        public static void RequestApply() { _nextTick = 0f; }

        public static WarTile FindLiveTile(string tileNumber)
        {
            if (_root == null || string.IsNullOrEmpty(tileNumber)) return null;
            var tiles = _root.GetComponentsInChildren<WarTile>(true);
            string goName = "Tile_" + tileNumber;
            if (tiles == null) return null;
            for (int i = 0; i < tiles.Length; i++)
                if (tiles[i] != null && tiles[i].gameObject.name == goName) return tiles[i];
            return null;
        }

        /// <summary>Turns a borrowed vanilla tile off immediately. Restore() puts its original active state back.</summary>
        public static void DeactivateLiveTile(string tileNumber)
        {
            var wt = FindLiveTile(tileNumber);
            if (wt == null) return;
            int id = wt.GetInstanceID();
            if (!_tiles.TryGetValue(id, out var tb))
            {
                tb = new TileBackup { Tile = wt, OrigActive = wt.gameObject.activeSelf, OrigActiveStored = true, LocalPos = wt.transform.localPosition, LocalScale = wt.transform.localScale };
                _tiles[id] = tb;
            }
            else if (!tb.OrigActiveStored)
            {
                tb.OrigActive = wt.gameObject.activeSelf;
                tb.OrigActiveStored = true;
            }
            if (wt.gameObject.activeSelf) wt.gameObject.SetActive(false);
        }

        /// <summary>Pushes allegiance, fort level and reinforcement flag onto the live WarTile once (not every frame).</summary>
        public static string PushTileSetup(ZilleTileData td)
        {
            if (td == null) return "No province selected.";
            if (_root == null) return "War map is not loaded. Open the Zille theatre first (F6).";
            var wt = FindLiveTile(td.TileNumber);
            if (wt == null) return $"Tile_{td.TileNumber} is not on this map.";
            try
            {
                var data = new WarTileData();
                data.tileName = td.TileNumber;
                data.startingAllegiance = ToAllegiance(td.Allegiance);
                data.fortLevel = td.FortLevel;
                data.isShoreTile = td.IsPort;
                data.isEnemyAirfield = td.IsAirfield;
                data.isInitialDeploymentTile = td.Allegiance == "Rizia";
                data.isBorderTile = td.Allegiance == "Rizia";
                if (td.FortLevel >= 2) data.tileDefenceType = WarTile.TileDefenceType.FortifiedDefencePoint;
                wt.Setup(data, data.startingAllegiance);
                wt.SetIsReinforcementTile(td.IsReinforcementTile);
                if (td.FortLevel > 0) wt.ChangeWarTileFortLevelStat(td.FortLevel);
                RememberInOperation(td.TileNumber, data);
                RequestApply();
                return $"{td.Name} written onto Tile_{td.TileNumber} ({td.Allegiance}).";
            }
            catch (Exception ex)
            {
                return "Setup failed: " + ex.Message;
            }
        }

        public static WarToken.WarAllegiance ToAllegiance(string name)
        {
            if (name == "Rizia") return WarToken.WarAllegiance.Player;
            return WarToken.WarAllegiance.Enemy;
        }

        private static void RememberInOperation(string tileNumber, WarTileData data)
        {
            try
            {
                var wom = Managers.Instance?.WarOperationManager ?? UnityEngine.Object.FindObjectOfType<WarOperationManager>();
                var op = wom?.currentOperation?.warOperationData;
                if (op == null || op.includedTileNames == null) return;
                if (op.operationNameInDatabase != "Operation_Zille_1") return;
                bool listed = false;
                for (int i = 0; i < op.includedTileNames.Count; i++)
                    if (op.includedTileNames[i] == tileNumber) { listed = true; break; }
                if (!listed) op.includedTileNames.Add(tileNumber);
                if (op.tileData != null && op.tileData.Count > 0 && op.tileData[0]?.tiles != null)
                {
                    var tiles = op.tileData[0].tiles;
                    bool has = false;
                    for (int i = 0; i < tiles.Count; i++)
                        if (tiles[i] != null && tiles[i].tileName == tileNumber) { has = true; break; }
                    if (!has) tiles.Add(data);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] Could not register tile on the live operation: " + ex.Message);
            }
        }

        private static int ApplyTiles(Transform root)
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return 0;

            var tiles = root.GetComponentsInChildren<WarTile>(true);
            if (tiles == null || tiles.Length == 0) return 0;
            var byName = new Dictionary<string, WarTile>();
            for (int i = 0; i < tiles.Length; i++)
            {
                var wt = tiles[i];
                if (wt != null) byName[wt.gameObject.name] = wt;
            }

            // 1. resolve config -> WarTile
            var resolved = new Dictionary<string, WarTile>();
            foreach (var td in cfg.Tiles)
            {
                string goName = "Tile_" + td.TileNumber;
                if (byName.TryGetValue(goName, out var wt)) resolved[td.Id] = wt;
                else if (_warnedMissing.Add(goName))
                    MelonLogger.Warning($"[ZTABLE] WarTile '{goName}' (for {td.Id}) not found under '{root.name}' (found {byName.Count} tiles).");
            }

            int ok = 0;
            foreach (var td in cfg.Tiles)
            {
                if (!resolved.TryGetValue(td.Id, out var wt)) continue;
                int id = wt.GetInstanceID();
                if (!_tiles.TryGetValue(id, out var tb))
                {
                    tb = new TileBackup
                    {
                        Tile = wt,
                        LocalPos = wt.transform.localPosition,
                        LocalScale = wt.transform.localScale,
                        Tex = wt.warTileTexture,
                        Adj = wt.adjacentWarTiles,
                        RootZ = root.InverseTransformPoint(wt.transform.position).z,
                        OrigActive = wt.gameObject.activeSelf,
                        OrigActiveStored = true
                    };
                    _tiles[id] = tb;
                }

                // Provinces in the Zille layout stay visible. Original active state is restored with the Pales skin.
                if (!wt.gameObject.activeSelf) wt.gameObject.SetActive(true);

                // position: map pixels -> root local -> world
                var lp = MapPxToLocal(td.MapPxX, td.MapPxY);
                Vector3 world = root.TransformPoint(new Vector3(lp.x, lp.y, tb.RootZ));
                if ((wt.transform.position - world).sqrMagnitude > 1e-10f) wt.transform.position = world;

                // scale: express desired root-space scale through the tile's own local scale
                Vector3 rootRight = root.InverseTransformVector(wt.transform.TransformVector(Vector3.right));
                float curRoot = rootRight.magnitude;
                if (curRoot > 1e-6f)
                {
                    float want = td.WorldScale <= 0f ? VanillaLandTileScale : td.WorldScale;
                    var target = wt.transform.localScale * (want / curRoot);
                    if ((wt.transform.localScale - target).sqrMagnitude > 1e-10f) wt.transform.localScale = target;
                }

                // mask texture (shader does the look!)
                if (ZilleMapLayoutManager.LoadedTextures.TryGetValue(td.TextureFile, out var mask) && mask != null)
                {
                    if (wt.warTileTexture == null || wt.warTileTexture.GetInstanceID() != mask.GetInstanceID())
                        wt.warTileTexture = mask;
                    var rend = wt.GetWarTileRenderer();
                    if (rend != null)
                    {
                        var m = rend.material;
                        if (m != null && m.HasProperty("_Tile_Texture"))
                        {
                            var ct = m.GetTexture("_Tile_Texture");
                            if (ct == null || ct.GetInstanceID() != mask.GetInstanceID()) m.SetTexture("_Tile_Texture", mask);
                        }
                    }
                }

                if (wt.IsReinforcementTile() != td.IsReinforcementTile)
                    wt.SetIsReinforcementTile(td.IsReinforcementTile);

                // Adjacency stays untouched until a reviewed neighbour list is supplied.
                if (td.AdjacentIds != null && td.AdjacentIds.Count > 0)
                {
                    var cur = wt.adjacentWarTiles;
                    bool needs = !tb.AdjApplied || cur == null || cur.Count != CountResolved(td, resolved);
                    if (needs)
                    {
                        var list = new Il2CppSystem.Collections.Generic.List<WarTile>();
                        foreach (var aid in td.AdjacentIds)
                            if (resolved.TryGetValue(aid, out var nb) && nb != null) list.Add(nb);
                        wt.adjacentWarTiles = list;
                        tb.AdjApplied = true;
                    }
                }
                ok++;
            }

            if (ZilleMapLayoutManager.UsingProvinceManifest)
                HideUnusedVanillaTiles(cfg);
            return ok;
        }

        /// <summary>
        /// The Pales table has Tile_1..100 and Tile_S1..S33. Provinces that are not in the Zille manifest
        /// are switched off so the old Pales shapes do not stay on the Zille map. Restore() turns them back on.
        /// </summary>
        private static void HideUnusedVanillaTiles(ZilleMapConfig cfg)
        {
            var used = new HashSet<string>();
            if (cfg?.Tiles != null)
                foreach (var td in cfg.Tiles)
                    if (!string.IsNullOrEmpty(td.TileNumber)) used.Add(td.TileNumber);
            for (int i = 1; i <= 100; i++)
            {
                string n = i.ToString();
                if (!used.Contains(n)) DeactivateLiveTile(n);
            }
            for (int i = 1; i <= 33; i++)
            {
                string n = "S" + i;
                if (!used.Contains(n)) DeactivateLiveTile(n);
            }
        }

        private static int CountResolved(ZilleTileData td, Dictionary<string, WarTile> resolved)
        {
            int c = 0;
            foreach (var aid in td.AdjacentIds) if (resolved.ContainsKey(aid)) c++;
            return c;
        }

        // ================================================================== placement tool (F4)

        public static bool PlacementMode { get; set; } = false;
        private static int _sel = 0;
        private static string _placementMsg = "";

        private static ZilleTileData Selected()
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || cfg.Tiles.Count == 0) return null;
            if (_sel < 0 || _sel >= cfg.Tiles.Count) _sel = 0;
            return cfg.Tiles[_sel];
        }

        /// <summary>Called from Core.OnGUI for every GUI event. Handles keyboard / mouse of the placement tool.</summary>
        public static void HandlePlacementEvent(Event e)
        {
            if (e == null) return;
            if (e.type == EventType.KeyDown && e.keyCode == KeyCode.F4)
            {
                PlacementMode = !PlacementMode;
                _placementMsg = PlacementMode ? "Placement mode ON" : "Placement mode OFF";
                MelonLogger.Msg("[ZTABLE] " + _placementMsg);
                return;
            }
            if (!PlacementMode || _root == null) return;
            var td = Selected();
            if (td == null) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;

            if (e.type == EventType.KeyDown)
            {
                float step = e.shift ? 120f : (e.control ? 6f : 30f);   // full-res map pixels
                float sstep = e.shift ? 0.03f : 0.005f;
                switch (e.keyCode)
                {
                    case KeyCode.Tab: _sel = (_sel + 1) % cfg.Tiles.Count; e.Use(); break;
                    case KeyCode.P: PlaceAtMouse(td, e); e.Use(); break;
                    case KeyCode.LeftArrow: td.MapPxX -= step; e.Use(); break;
                    case KeyCode.RightArrow: td.MapPxX += step; e.Use(); break;
                    case KeyCode.UpArrow: td.MapPxY -= step; e.Use(); break;
                    case KeyCode.DownArrow: td.MapPxY += step; e.Use(); break;
                    case KeyCode.Equals: case KeyCode.KeypadPlus: case KeyCode.PageUp: td.WorldScale += sstep; e.Use(); break;
                    case KeyCode.Minus: case KeyCode.KeypadMinus: case KeyCode.PageDown: td.WorldScale = Mathf.Max(0.03f, td.WorldScale - sstep); e.Use(); break;
                    case KeyCode.S:
                        if (e.control)
                        {
                            bool ok = ZilleMapLayoutManager.SaveConfig();
                            _placementMsg = ok ? "Layout SAVED to zille_tiles_layout.json" : "SAVE FAILED (see log)";
                            LogPlacement();
                            e.Use();
                        }
                        break;
                }
            }
        }

        /// <summary>Move the selected province under the mouse cursor (key P).</summary>
        private static void PlaceAtMouse(ZilleTileData td, Event e)
        {
            var cam = Camera.main;
            if (cam == null) return;
            var ray = cam.ScreenPointToRay(new Vector3(e.mousePosition.x, Screen.height - e.mousePosition.y, 0f));
            Vector3 normal = _root.TransformDirection(Vector3.forward);
            var plane = new Plane(normal, _root.position);
            if (plane.Raycast(ray, out float dist))
            {
                Vector3 local = _root.InverseTransformPoint(ray.GetPoint(dist));
                td.MapPxX = (local.x - MapLeft) / PxToWorld;
                td.MapPxY = (MapTop - local.y) / PxToWorld;
                _placementMsg = $"{td.Name}: placed at px ({td.MapPxX:F0},{td.MapPxY:F0})";
                LogPlacement();
            }
        }

        private static void LogPlacement()
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            var sb = new StringBuilder("[ZTABLE] placement: ");
            foreach (var t in cfg.Tiles) sb.Append($"{t.Id}=Tile_{t.TileNumber}@({t.MapPxX:F0},{t.MapPxY:F0}) s={t.WorldScale:F3}; ");
            MelonLogger.Msg(sb.ToString());
        }

        public static void DrawPlacementHud()
        {
            if (!PlacementMode) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;
            var cam = Camera.main;

            // labels over every province
            if (cam != null && _root != null)
            {
                var tiles = _root.GetComponentsInChildren<WarTile>(true);
                for (int i = 0; i < cfg.Tiles.Count; i++)
                {
                    var td = cfg.Tiles[i];
                    foreach (var wt in tiles)
                    {
                        if (wt == null || wt.gameObject.name != "Tile_" + td.TileNumber) continue;
                        Vector3 sp = cam.WorldToScreenPoint(wt.transform.position);
                        if (sp.z < 0) break;
                        bool sel = i == _sel;
                        DrawLabel(new Rect(sp.x - 90, Screen.height - sp.y - 13, 180, 26), (sel ? "> " : "") + td.Name, sel ? Color.yellow : Color.white, 15);
                        break;
                    }
                }
            }

            var s = Selected();
            string txt = "ZILLE PLACEMENT (F4 off)\n" +
                         $"Selected [{_sel + 1}/{cfg.Tiles.Count}]: {s?.Name}  (Tile_{s?.TileNumber})\n" +
                         $"px = ({s?.MapPxX:F0}, {s?.MapPxY:F0})   scale = {s?.WorldScale:F3}\n" +
                         "TAB next | P = place at mouse cursor | arrows move (Shift fast, Ctrl fine)\n" +
                         "= / - scale (Shift big) | CTRL+S save\n" + _placementMsg;
            DrawLabel(new Rect(Screen.width / 2f - 330, 50, 660, 130), txt, Color.white, 15);
        }

        private static GUIStyle _labelStyle;
        private static void DrawLabel(Rect r, string text, Color fg, int size)
        {
            var prev = GUI.color;
            GUI.color = new Color(0f, 0f, 0f, 0.88f);
            GUI.DrawTexture(r, Texture2D.whiteTexture);
            GUI.color = Color.white;
            if (_labelStyle == null)
            {
                _labelStyle = new GUIStyle(GUI.skin.label);
                _labelStyle.alignment = TextAnchor.MiddleCenter;
                _labelStyle.fontStyle = FontStyle.Bold;
                _labelStyle.wordWrap = false;
            }
            _labelStyle.fontSize = size;
            _labelStyle.normal.textColor = fg;
            GUI.Label(r, text, _labelStyle);
            GUI.color = prev;
        }

        // ================================================================== diagnostics (F8)

        public static void Diagnose(string reason)
        {
            var sb = new StringBuilder();
            void L(string s) { sb.AppendLine(s); }
            try
            {
                L($"===== ZILLE TABLE DIAGNOSTIC ({reason}) {DateTime.Now:HH:mm:ss} =====");
                L($"SkinEnabled={SkinEnabled}  CurrentTheatre={WarOperationZilleManager.CurrentTheatre}  textures: grid={ZilleMapLayoutManager.GridMapTiles.Count} regions={ZilleMapLayoutManager.LoadedTextures.Count}");

                var rends = Resources.FindObjectsOfTypeAll<Renderer>();
                L($"-- renderers in memory: {rends?.Length}");
                int shown = 0;
                for (int i = 0; rends != null && i < rends.Length; i++)
                {
                    var r = rends[i];
                    if (r == null || r.gameObject == null) continue;
                    string n = r.gameObject.name;
                    bool plane = IsMapPlaneName(n);
                    bool other = n.IndexOf("PalesReferenceMap", StringComparison.OrdinalIgnoreCase) >= 0 || n.IndexOf("PalesWarMapBackground", StringComparison.OrdinalIgnoreCase) >= 0 || n.IndexOf("TableMarble", StringComparison.OrdinalIgnoreCase) >= 0;
                    if (!plane && !other) continue;
                    var m = r.sharedMaterial;
                    string tex = "-";
                    if (m != null && m.HasProperty("_Diffuse")) { var t = m.GetTexture("_Diffuse"); tex = t == null ? "null" : $"{t.name} {t.width}x{t.height}"; }
                    string path = GetPath(r.transform);
                    L($"   [{(r.gameObject.scene.IsValid() ? "SCENE" : "asset")}] '{n}' path={path} activeInHierarchy={r.gameObject.activeInHierarchy} enabled={r.enabled} mat='{m?.name}' shader='{m?.shader?.name}' _Diffuse={tex} pos={r.transform.position} lscale={r.transform.localScale}");
                    if (++shown > 40) break;
                }

                // ---- MapManager / MapContainer / MapConfiguration state: is the war map loading at all? ----
                try
                {
                    var mm = UnityEngine.Object.FindObjectOfType<MapManager>();
                    L($"-- MapManager: {(mm == null ? "NOT FOUND" : "found")} currentType={mm?.GetCurrentMapType()} loaded={(mm?.CurrentlyLoadedMap == null ? "null" : mm.CurrentlyLoadedMap.name)} cfg={mm?.GetCurrentMapConfiguration()?.name}");
                    var cfgs = Resources.FindObjectsOfTypeAll<MapConfiguration>();
                    for (int i = 0; cfgs != null && i < cfgs.Length; i++)
                        L($"   MapConfiguration '{cfgs[i].name}' type={cfgs[i].mapType} assetKey={cfgs[i].mapAssetReference?.RuntimeKey}");
                    var conts = Resources.FindObjectsOfTypeAll<MapContainer>();
                    for (int i = 0; conts != null && i < conts.Length; i++)
                        L($"   MapContainer '{conts[i].name}' path={GetPath(conts[i].transform)} active={conts[i].gameObject.activeInHierarchy} done={conts[i].IsDoneLoading} childCount={conts[i].transform.childCount}");
                }
                catch (Exception ex) { L("map-manager diag error: " + ex.Message); }

                try
                {
                    var all = Resources.FindObjectsOfTypeAll<Transform>();
                    int n = 0;
                    L($"-- scene transforms whose name contains 'Map_' or 'PalesWar' or 'Tile Map' ({all?.Length} total transforms):");
                    for (int i = 0; all != null && i < all.Length; i++)
                    {
                        var tr = all[i];
                        if (tr == null || !tr.gameObject.scene.IsValid()) continue;
                        string nm = tr.name;
                        if (nm.Contains("Map_") || nm.Contains("PalesWar") || nm == "Tile Map" || nm.StartsWith("Environments") || nm == "War")
                        {
                            L($"   {GetPath(tr)} active={tr.gameObject.activeSelf}/{tr.gameObject.activeInHierarchy} pos={tr.position} children={tr.childCount}");
                            if (++n > 60) break;
                        }
                    }
                    for (int s = 0; s < UnityEngine.SceneManagement.SceneManager.sceneCount; s++)
                    {
                        var sc = UnityEngine.SceneManagement.SceneManager.GetSceneAt(s);
                        L($"   scene[{s}] '{sc.name}' loaded={sc.isLoaded} roots={sc.rootCount}");
                    }
                }
                catch (Exception ex) { L("transform diag error: " + ex.Message); }

                var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
                L($"-- WarTileManager: {(mgr == null ? "NOT FOUND" : "found")}, allTiles={mgr?.allTiles?.Count}");
                if (_root != null)
                {
                    var tiles = _root.GetComponentsInChildren<WarTile>(true);
                    int active = 0; for (int i = 0; i < tiles.Length; i++) if (tiles[i].gameObject.activeSelf) active++;
                    L($"-- root '{_root.name}' pos={_root.position} rot={_root.rotation.eulerAngles} lscale={_root.localScale}; WarTiles={tiles.Length}, activeSelf={active}");
                    var cfg = ZilleMapLayoutManager.CurrentConfig;
                    if (cfg?.Tiles != null)
                        foreach (var td in cfg.Tiles)
                        {
                            WarTile found = null;
                            for (int i = 0; i < tiles.Length; i++) if (tiles[i].gameObject.name == "Tile_" + td.TileNumber) { found = tiles[i]; break; }
                            if (found == null) { L($"   {td.Id} -> Tile_{td.TileNumber}: NOT FOUND"); continue; }
                            var rr = found.GetWarTileRenderer();
                            var mt = rr?.material; string mtex = "-";
                            if (mt != null && mt.HasProperty("_Tile_Texture")) { var t = mt.GetTexture("_Tile_Texture"); mtex = t == null ? "null" : t.name; }
                            L($"   {td.Id} -> Tile_{td.TileNumber}: active={found.gameObject.activeSelf} localPos={found.transform.localPosition} worldPos={found.transform.position} lscale={found.transform.localScale} lossy={found.transform.lossyScale} warTileTexture={found.warTileTexture?.name} _Tile_Texture={mtex} adj={found.adjacentWarTiles?.Count} shader='{mt?.shader?.name}'");
                        }
                }
                else L("-- no war map root cached (map not loaded or skin disabled)");

                var cam = Camera.main;
                if (cam != null) L($"-- Camera.main '{cam.name}' pos={cam.transform.position} rot={cam.transform.rotation.eulerAngles} fov={cam.fieldOfView} ortho={cam.orthographic}");
            }
            catch (Exception ex) { L("DIAG ERROR: " + ex.Message + "\n" + ex.StackTrace); }

            string text = sb.ToString();
            MelonLogger.Msg("\n" + text);
            try
            {
                string dir = Path.Combine(Application.dataPath, "..", "Mods", "GreatZilleAssets");
                Directory.CreateDirectory(dir);
                File.AppendAllText(Path.Combine(dir, "ztable_diag.txt"), text + "\n");
            }
            catch { }
        }

        private static string GetPath(Transform t)
        {
            var parts = new List<string>();
            for (int i = 0; i < 8 && t != null; i++) { parts.Add(t.name); t = t.parent; }
            parts.Reverse();
            return string.Join("/", parts);
        }
    }
}
