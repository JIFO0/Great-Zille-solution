using System;
using System.Collections;
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
            public bool GameplayPushed;
            public string PushedAllegiance;
            public string PushedSig;
        }

        /// <summary>When set, province masks drop to 25% opacity and the editor will not move them.</summary>
        public static bool LayoutLocked { get; set; } = false;

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
                if (_root != null) HighlightUnderCursor();
                if (Time.unscaledTime < _nextTick) return;
                _nextTick = Time.unscaledTime + 0.25f;

                if (_root == null)
                {
                    if (Time.unscaledTime < _nextFind) return;
                    _nextFind = Time.unscaledTime + 0.5f;
                    _root = FindWarMapRoot();
                    if (_root == null) return;
                    _planes.Clear(); _tiles.Clear(); _loggedApplied = false; _citySpawned.Clear();
                    _propsNudged = false; _propHolds.Clear(); _enlarged.Clear(); _tokenScale.Clear(); _zonePushed.Clear(); _roadsSig = null; _deploymentReady = false; _tilesAdopted = false; _raycastLayer = int.MinValue; _garrisonsPlaced = false; _framed = false; _frontFilled = false; _poolReady = false; _pointsGranted = false; _bannerCleared = false; _rayInput = false; _lit = null; _hoverHitLogged = false;
                    MelonLogger.Msg($"[ZTABLE] War map instance found: '{_root.name}' (id {_root.gameObject.GetInstanceID()}), applying Zille skin...");
                }

                ZilleMapLayoutManager.EnsureTexturesLoaded();
                int p = ApplyPlanes(_root);
                int t = ApplyTiles(_root);
                EnsureCityTokens();
                ApplyCityLabels();
                EnsureEnemyGarrisons();
                AdoptGameTiles();
                EnsureDeploymentState();
                FrameZille();
                DrawSupplyLines();
                FillFrontlineFromPanel();
                AimTileRaycaster();
                WakeTileRaycaster();
                EnsureActionPoints();
                ScaleTokens();
                SyncZoneMarkers();
                HideTableClutter();
                SyncMountainMarkers();
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
                var pageCols = r.GetComponents<Collider>();
                for (int c = 0; c < pageCols.Length; c++)
                    if (pageCols[c] != null) pageCols[c].enabled = false;
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
                FillWarTileData(td, data);
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
            if (name == "Rizia" || name == "Player") return WarToken.WarAllegiance.Player;
            if (name == "EmptySea" || name == "Sea") return WarToken.WarAllegiance.EmptySea;
            return WarToken.WarAllegiance.Enemy;
        }

        /// <summary>
        /// Pales-style tile data. Mountains use GroundType.Mountain (the crossing penalty). Hills are defence points.
        /// Cities stay cities even when fortified. Sea is open water. The mask shader tints the province; it does not
        /// paint over the map.
        /// </summary>
        public static void FillWarTileData(ZilleTileData td, WarTileData data)
        {
            data.tileName = td.TileNumber;
            data.tileType = td.IsSea ? WarTile.TileType.Sea : WarTile.TileType.Land;
            data.groundType = td.Terrain == "mountains" ? WarTile.GroundType.Mountain : WarTile.GroundType.Default;
            data.startingAllegiance = ToAllegiance(td.Allegiance);
            data.fortLevel = td.FortLevel;
            data.isShoreTile = td.IsSea || td.IsCoastal || td.IsPort;
            data.isEnemyAirfield = td.IsAirfield;
            data.isInitialDeploymentTile = td.Allegiance == "Rizia" && !td.IsSea;
            data.isBorderTile = td.IsBorder;
            if (td.IsCity) data.tileDefenceType = WarTile.TileDefenceType.City;
            else if (td.FortLevel >= 2) data.tileDefenceType = WarTile.TileDefenceType.FortifiedDefencePoint;
            else if (td.Terrain == "hills") data.tileDefenceType = WarTile.TileDefenceType.DefencePoint;
            else if (td.IsCitySurroundings) data.tileDefenceType = WarTile.TileDefenceType.CitySurroundings;
            else data.tileDefenceType = WarTile.TileDefenceType.None;
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
            EnsureClonedTiles(cfg, byName);

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
                Vector3 world = root.TransformPoint(new Vector3(lp.x, lp.y, tb.RootZ)) + root.up * 0.003f;
                if ((wt.transform.position - world).sqrMagnitude > 1e-10f) wt.transform.position = world;
                EnsureTileCollider(wt);

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
                        if (m != null && m.HasProperty("_Opacity"))
                        {
                            float opacity = LayoutLocked ? 0.25f : 0.6f;
                            if (Mathf.Abs(m.GetFloat("_Opacity") - opacity) > 0.02f)
                                m.SetFloat("_Opacity", opacity);
                        }
                    }
                }

                if (wt.IsReinforcementTile() != td.IsReinforcementTile)
                    wt.SetIsReinforcementTile(td.IsReinforcementTile);

                // Re-push whenever the inspector changes allegiance, a city, an airfield or a fort,
                // so F10 edits show up on the table without leaving the theatre.
                string sig = td.Allegiance + "|" + td.FortLevel + "|" + td.IsCity + "|" + td.IsAirfield + "|" + td.Terrain + "|" + td.IsSea;
                if (tb.PushedSig != sig)
                {
                    try
                    {
                        var data = new WarTileData();
                        FillWarTileData(td, data);
                        wt.Setup(data, data.startingAllegiance);
                        if (td.FortLevel > 0) wt.ChangeWarTileFortLevelStat(td.FortLevel);
                        wt.ChangeWarTileEnemyAirfieldStat(td.IsAirfield && td.Allegiance != "Rizia");
                        wt.SetIsReinforcementTile(td.IsReinforcementTile);
                        tb.GameplayPushed = true;
                        tb.PushedAllegiance = td.Allegiance;
                        tb.PushedSig = sig;
                    }
                    catch (Exception ex)
                    {
                        if (_warnedMissing.Add("setup:" + td.TileNumber))
                            MelonLogger.Warning($"[ZTABLE] Setup {td.Name}: {ex.Message}");
                    }
                }

                TintTile(wt, td);
                ShowTile(wt, td);

                // adjacency: only Zille neighbours (vanilla neighbours are Pales tiles that are disabled in this operation)
                if (td.AdjacentIds != null)
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
            return ok;
        }

        /// <summary>
        /// Vanilla Pales has Tile_1..100 and Tile_S1..S33. v12 sea runs to S52, so the extra sea provinces
        /// are clones of a real sea tile, renamed, and then placed like the rest.
        /// </summary>
        private static void EnsureClonedTiles(ZilleMapConfig cfg, Dictionary<string, WarTile> byName)
        {
            WarTile template = null;
            foreach (var kv in byName)
            {
                if (kv.Key.StartsWith("Tile_S", StringComparison.Ordinal)) { template = kv.Value; break; }
            }
            if (template == null) return;
            var parent = template.transform.parent;
            foreach (var td in cfg.Tiles)
            {
                if (string.IsNullOrEmpty(td.TileNumber)) continue;
                string goName = "Tile_" + td.TileNumber;
                if (byName.ContainsKey(goName)) continue;
                var clone = UnityEngine.Object.Instantiate(template.gameObject, parent);
                clone.name = goName;
                clone.SetActive(true);
                var wt = clone.GetComponent<WarTile>();
                if (wt == null)
                {
                    UnityEngine.Object.Destroy(clone);
                    continue;
                }
                wt.adjacentWarTiles = new Il2CppSystem.Collections.Generic.List<WarTile>();
                byName[goName] = wt;
                MelonLogger.Msg($"[ZTABLE] Cloned missing province {goName} ({td.Name}).");
            }
        }

        private static int CountResolved(ZilleTileData td, Dictionary<string, WarTile> resolved)
        {
            int c = 0;
            foreach (var aid in td.AdjacentIds) if (resolved.ContainsKey(aid)) c++;
            return c;
        }

        // ================================================================== units, cities, table props

        private static readonly List<WarUnitTypeData> _unitTypes = new List<WarUnitTypeData>();
        private static readonly HashSet<string> _citySpawned = new HashSet<string>();
        private static bool _propsNudged;
        private static readonly List<(Transform t, Vector3 baseLocal, Vector3 localOffset, bool above)> _propHolds = new List<(Transform, Vector3, Vector3, bool)>();
        private static readonly HashSet<int> _enlarged = new HashSet<int>();
        private static bool _deploymentReady;
        public static bool ScenarioStarted { get; private set; }

        /// <summary>The Pales Start button calls OnInitialDeploymentFinished. After that, deployment rules stop.</summary>
        public static void MarkOperationBegun() => ScenarioStarted = true;

        public static void InvalidateLiveTiles()
        {
            foreach (var tb in _tiles.Values) tb.PushedSig = null;
            _roadsSig = null;
            RequestApply();
        }

        /// <summary>Re-applied every LateUpdate so a follow script cannot put the box and headphones back on the map.</summary>
        private static bool _holdLoop;

        public static void HoldProps()
        {
            if (_propHolds.Count == 0) return;
            for (int i = 0; i < _propHolds.Count; i++)
            {
                var h = _propHolds[i];
                if (h.t == null) continue;
                var want = h.baseLocal + h.localOffset;
                if ((h.t.localPosition - want).sqrMagnitude > 1e-8f)
                    h.t.localPosition = want;
            }
        }

        public static IReadOnlyList<WarUnitTypeData> UnitTypes()
        {
            if (_unitTypes.Count > 0 && _unitTypes[0] != null) return _unitTypes;
            _unitTypes.Clear();
            WarUnitTypeData[] all = null;
            try { all = Resources.FindObjectsOfTypeAll<WarUnitTypeData>(); } catch { }
            if (all == null) return _unitTypes;
            var seen = new HashSet<string>();
            for (int i = 0; i < all.Length; i++)
            {
                var u = all[i];
                if (u == null || string.IsNullOrEmpty(u.name) || !seen.Add(u.name)) continue;
                _unitTypes.Add(u);
            }
            _unitTypes.Sort((a, b) => string.Compare(a.name, b.name, StringComparison.Ordinal));
            return _unitTypes;
        }

        public static string UnitLabel(WarUnitTypeData ut)
        {
            if (ut == null) return "(brak)";
            string nice = ut.name;
            try { if (!string.IsNullOrEmpty(ut.UnitName)) nice = ut.UnitName; } catch { }
            return nice;
        }

        public static bool IsCityUnit(WarUnitTypeData ut) => ut != null && ut.unitType == WarUnitTypeData.UnitType.City;
        public static bool IsAirUnit(WarUnitTypeData ut) => ut != null && ut.unitType == WarUnitTypeData.UnitType.AirUnit;
        public static bool IsTroopUnit(WarUnitTypeData ut) => ut != null && (ut.unitType == WarUnitTypeData.UnitType.LandUnit || ut.unitType == WarUnitTypeData.UnitType.NavalUnit);

        /// <summary>Copies the F10 canvas position onto the live map (full-res pixels the table actually uses).</summary>
        public static void CommitEditorPosition(ZilleTileData tile)
        {
            if (tile == null) return;
            tile.MapPxX = tile.NormalizedX * 12288f;
            tile.MapPxY = tile.NormalizedY * 8192f;
            RequestApply();
        }

        /// <summary>Setup can switch a sea tile off. Put the mask and the renderer back.</summary>
        private static void ShowTile(WarTile wt, ZilleTileData td)
        {
            if (wt == null || !td.IsSea) return;
            if (!wt.gameObject.activeSelf) wt.gameObject.SetActive(true);
            var renderers = wt.GetComponentsInChildren<Renderer>(true);
            for (int i = 0; i < renderers.Length; i++)
            {
                var r = renderers[i];
                if (r == null) continue;
                if (!r.gameObject.activeSelf) r.gameObject.SetActive(true);
                r.enabled = true;
            }
            if (!ZilleMapLayoutManager.LoadedTextures.TryGetValue(td.TextureFile, out var mask) || mask == null) return;
            wt.warTileTexture = mask;
            var rend = wt.GetWarTileRenderer();
            if (rend == null) return;
            var m = rend.material;
            if (m != null && m.HasProperty("_Tile_Texture")) m.SetTexture("_Tile_Texture", mask);
            if (m != null && m.HasProperty("_Opacity")) m.SetFloat("_Opacity", 0.6f);
        }

        private static void TintTile(WarTile wt, ZilleTileData td)
        {
            var rend = wt.GetWarTileRenderer();
            if (rend == null) return;
            var m = rend.material;
            if (m == null || !m.HasProperty("_Tile_Colour")) return;
            // Match the Pales table: player land is orange, enemy land is gray-blue, sea stays a pale wash.
            // Skip a tile the game is outlining so the hover state can show through.
            if (wt.IsHoveringOverTile()) return;
            if (m.HasProperty("_Highlight_Toggle") && m.GetFloat("_Highlight_Toggle") > 0.5f)
                return;
            Color c = td.IsSea ? new Color(0.78f, 0.86f, 0.92f, 0.42f)
                : td.Allegiance == "Rizia" ? new Color(0.93f, 0.48f, 0.22f, 0.62f)
                : td.Allegiance == "Wehlen" ? new Color(0.45f, 0.55f, 0.68f, 0.55f)
                : new Color(1f, 1f, 1f, 0f);
            var cur = m.GetColor("_Tile_Colour");
            if (Mathf.Abs(cur.r - c.r) + Mathf.Abs(cur.g - c.g) + Mathf.Abs(cur.b - c.b) + Mathf.Abs(cur.a - c.a) > 0.03f)
                m.SetColor("_Tile_Colour", c);
        }

        public static WarUnitTypeData FindUnit(Func<WarUnitTypeData, bool> match, string preferName)
        {
            var types = UnitTypes();
            WarUnitTypeData any = null;
            WarUnitTypeData named = null;
            for (int i = 0; i < types.Count; i++)
            {
                var u = types[i];
                if (u == null || (match != null && !match(u))) continue;
                if (any == null) any = u;
                if (!string.IsNullOrEmpty(preferName))
                {
                    string n = (u.name + " " + (u.UnitName ?? "")).ToLowerInvariant();
                    if (n.Contains(preferName)) { named = u; break; }
                }
            }
            return named ?? any;
        }

        /// <summary>
        /// Puts a unit on a live province. DeployToken is what the deployment box uses.
        /// SpawnWarToken is the story-script path, used when deployment is already closed.
        /// </summary>
        /// <summary>
        /// Pales hover samples the mask at the raycast UV. A box we added has no UVs, so the province never lights up
        /// and the hold-to-deploy timer never starts. Keep the mesh collider and drop the box.
        /// </summary>
        private static void EnsureTileCollider(WarTile wt)
        {
            if (wt == null) return;
            var meshes = wt.GetComponentsInChildren<MeshCollider>(true);
            if (meshes == null || meshes.Length == 0)
            {
                var filter = wt.GetComponent<MeshFilter>() ?? wt.GetComponentInChildren<MeshFilter>(true);
                if (filter != null && filter.sharedMesh != null)
                {
                    var mesh = filter.gameObject.GetComponent<MeshCollider>();
                    if (mesh == null) mesh = filter.gameObject.AddComponent<MeshCollider>();
                    mesh.sharedMesh = filter.sharedMesh;
                    mesh.convex = false;
                    mesh.enabled = true;
                    meshes = wt.GetComponentsInChildren<MeshCollider>(true);
                }
            }
            if (meshes != null)
            {
                for (int i = 0; i < meshes.Length; i++)
                    if (meshes[i] != null) meshes[i].enabled = true;
            }
            var boxes = wt.GetComponents<BoxCollider>();
            if (boxes != null && meshes != null && meshes.Length > 0)
            {
                for (int i = 0; i < boxes.Length; i++)
                    if (boxes[i] != null) UnityEngine.Object.Destroy(boxes[i]);
            }
            AlignTileRaycastLayer(wt);
        }

        private static int _raycastLayer = int.MinValue;

        private static void AlignTileRaycastLayer(WarTile wt)
        {
            if (wt == null) return;
            if (_raycastLayer == int.MinValue)
            {
                _raycastLayer = -1;
                var ray = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
                var field = ray != null ? HarmonyLib.AccessTools.Field(typeof(WarTileRaycaster), "raycastLayerMask") : null;
                if (field != null)
                {
                    int mask = ((LayerMask)field.GetValue(ray)).value;
                    if (mask != 0 && mask != ~0)
                    {
                        for (int i = 0; i < 32; i++)
                        {
                            if ((mask & (1 << i)) != 0) { _raycastLayer = i; break; }
                        }
                    }
                }
            }
            if (_raycastLayer < 0) return;
            if (wt.gameObject.layer == _raycastLayer) return;
            var transforms = wt.GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < transforms.Length; i++)
                if (transforms[i] != null) transforms[i].gameObject.layer = _raycastLayer;
        }

        private static bool _tilesAdopted;

        /// <summary>The Pales hover, hold-to-place and refund path only sees tiles the war tile manager registered.</summary>
        private static void AdoptGameTiles()
        {
            if (_root == null) return;
            var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
            if (mgr == null) return;
            // Il2Cpp exposes the private list as a property. AccessTools.Field never finds it, which left the list empty.
            var list = mgr.allTiles;
            if (list == null)
            {
                list = new Il2CppSystem.Collections.Generic.List<WarTile>();
                mgr.allTiles = list;
            }
            if (list.Count >= 40)
            {
                _tilesAdopted = true;
                return;
            }
            var tiles = _root.GetComponentsInChildren<WarTile>(true);
            for (int i = 0; i < tiles.Length; i++)
            {
                var wt = tiles[i];
                if (wt == null || !wt.gameObject.activeInHierarchy) continue;
                int id = wt.GetInstanceID();
                bool has = false;
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] != null && list[j].GetInstanceID() == id) { has = true; break; }
                }
                if (!has) list.Add(wt);
            }
            if (list.Count >= 40 && !_tilesAdopted)
            {
                _tilesAdopted = true;
                MelonLogger.Msg("[ZTABLE] Pales tile manager now owns " + list.Count + " Zille provinces (hover, hold to deploy, refund).");
            }
        }

        private static bool _clutterHidden;

        /// <summary>The figurine box and headphones sit on the map. The deployment menu is the side panel, so these props go away.</summary>
        private static void HideTableClutter()
        {
            Renderer[] rends = null;
            try { rends = UnityEngine.Object.FindObjectsOfType<Renderer>(); } catch { return; }
            if (rends == null) return;
            int hidden = 0;
            var done = new HashSet<int>();
            foreach (var r in rends)
            {
                if (r == null || r.gameObject == null || !r.gameObject.scene.IsValid()) continue;
                string low = (r.gameObject.name ?? "").ToLowerInvariant();
                bool box = low.Contains("tokenbox") || low.Contains("token_box");
                bool phones = low.Contains("headphone") || low.Contains("headset") || low.Contains("earcup") || low.Contains("mo_headphone");
                if (!box && !phones) continue;
                Transform t = r.transform;
                if (box)
                {
                    while (t.parent != null && (t.parent.name ?? "").ToLowerInvariant().Contains("tokenbox"))
                        t = t.parent;
                }
                if (!done.Add(t.GetInstanceID())) continue;
                if (t.gameObject.activeSelf)
                {
                    t.gameObject.SetActive(false);
                    hidden++;
                }
            }
            if (hidden > 0 && !_clutterHidden)
            {
                _clutterHidden = true;
                MelonLogger.Msg("[ZTABLE] Hid the figurine box and headphones.");
            }
        }

        /// <summary>Drops the unit selected in the side menu onto a Rizian province.</summary>
        public static bool TryDeployOnTile(ZilleTileData td)
        {
            if (ScenarioStarted || td == null || td.IsSea || td.Allegiance != "Rizia") return false;
            var wt = FindLiveTile(td.TileNumber);
            if (wt == null) return false;
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
                if (panel == null || !panel.IsDeploymentUnitSelected()) return false;
                var ut = panel.selectedUnitTypeData;
                if (ut == null) return false;
                var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (mgr == null) return false;
                mgr.DeployToken(ut, wt, WarToken.WarAllegiance.Player);
                _barStatus = "Deploy: " + (ut.UnitName ?? ut.name) + " na " + td.Name;
                MelonLogger.Msg("[ZTABLE] Rizian " + (ut.UnitName ?? ut.name) + " on " + td.Name);
                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] Side deploy: " + ex.Message);
                return false;
            }
        }

        public static string PlaceUnit(ZilleTileData tile, WarUnitTypeData ut, bool enemy)
        {
            if (tile == null || ut == null) return "Wybierz region i jednostke.";
            var wt = FindLiveTile(tile.TileNumber);
            var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            if (mgr == null) return "WarTokenManager nie jest zaladowany. Wejdz do teatru.";
            var alleg = enemy ? WarToken.WarAllegiance.Enemy : WarToken.WarAllegiance.Player;
            string side = enemy ? "wroga" : "twoja";
            try
            {
                if (wt != null)
                {
                    int pool = enemy ? ut.UnitDeployedCount : 0;
                    mgr.DeployToken(ut, wt, alleg);
                    // Enemy garrisons share the unit asset with the player's pool. Put the count back.
                    if (enemy) ut.UnitDeployedCount = pool;
                    return $"Postawiono ({side}): {UnitLabel(ut)} na {tile.Name}.";
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] DeployToken: " + ex.Message);
                return "Nie udalo sie postawic jednostki: " + ex.Message;
            }
            return "Tile_" + tile.TileNumber + " nie jest na stole.";
        }

        /// <summary>
        /// Pales spawns enemy reinforcements on a later war turn: EvaluateEnemyReinforcements looks for a
        /// tile flagged SetIsReinforcementTile, otherwise SpawnEnemyReinforcementTokenOnSupplyLine walks a supply line.
        /// This flags the province and asks the vanilla spawner, then places the unit directly if the pool is empty.
        /// </summary>
        public static string SpawnReinforcement(ZilleTileData tile, WarUnitTypeData ut)
        {
            if (tile == null) return "Wybierz region.";
            tile.IsReinforcementTile = true;
            var wt = FindLiveTile(tile.TileNumber);
            if (wt != null) wt.SetIsReinforcementTile(true);
            var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            string vanilla = "";
            if (mgr != null && ut != null)
            {
                try
                {
                    mgr.SpawnEnemyReinforcementTokenOnSupplyLine(ut.name);
                    vanilla = " Gra sprobowala tez fali na linii zaopatrzenia.";
                }
                catch (Exception ex)
                {
                    vanilla = " Linia zaopatrzenia: " + ex.Message;
                }
            }
            string placed = ut == null ? "Brak typu jednostki." : PlaceUnit(tile, ut, true);
            return placed + vanilla;
        }

        private static float _nextCityTry;

        private static void EnsureCityTokens()
        {
            if (Time.unscaledTime < _nextCityTry) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || _root == null) return;
            var wom = UnityEngine.Object.FindObjectOfType<WarOperationManager>();
            if (wom == null || wom.currentOperation == null) return;
            var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            if (mgr == null) return;
            var playerCity = FindUnit(IsCityUnit, "rizia");
            var enemyCity = FindUnit(IsCityUnit, "arces");
            if (playerCity == null && enemyCity == null)
            {
                if (_warnedMissing.Add("no-city-unit"))
                    MelonLogger.Warning("[ZTABLE] No city unit type in memory, city markers were not spawned.");
                return;
            }
            foreach (var td in cfg.Tiles)
            {
                if (!ZilleMapLayoutManager.IsScenarioCity(td.Name)) continue;
                td.IsCity = true;
                if (string.IsNullOrEmpty(td.TileNumber) || _citySpawned.Contains(td.TileNumber)) continue;
                bool enemy = td.Allegiance != "Rizia";
                var city = enemy ? (enemyCity ?? playerCity) : (playerCity ?? enemyCity);
                string msg = PlaceUnit(td, city, enemy);
                if (!msg.StartsWith("Postawiono"))
                {
                    _nextCityTry = Time.unscaledTime + 2f;
                    if (_warnedMissing.Add("city-retry"))
                        MelonLogger.Warning("[ZTABLE] City retry: " + msg);
                    return;
                }
                _citySpawned.Add(td.TileNumber);
                _cityLabels[td.TileNumber] = td.Name;
                MelonLogger.Msg("[ZTABLE] City: " + msg);
            }
        }

        private static readonly Dictionary<string, string> _cityLabels = new Dictionary<string, string>();

        /// <summary>The star label is the city unit's own name. Arces is only the template, so rewrite it to the province.</summary>
        private static void ApplyCityLabels()
        {
            if (_cityLabels.Count == 0) return;
            WarToken[] tokens = null;
            try { tokens = UnityEngine.Object.FindObjectsOfType<WarToken>(); } catch { return; }
            if (tokens == null) return;
            foreach (var kv in _cityLabels)
            {
                var tile = FindLiveTile(kv.Key);
                if (tile == null) continue;
                string want = "Capture " + kv.Value;
                for (int i = 0; i < tokens.Length; i++)
                {
                    var tok = tokens[i];
                    if (tok == null) continue;
                    if ((tok.transform.position - tile.transform.position).sqrMagnitude > 0.08f) continue;
                    var texts = tok.GetComponentsInChildren<Il2CppTMPro.TMP_Text>(true);
                    for (int n = 0; n < texts.Length; n++)
                    {
                        var label = texts[n];
                        if (label == null) continue;
                        string cur = label.text ?? "";
                        if (cur == want) continue;
                        if (cur.IndexOf("Arces", StringComparison.OrdinalIgnoreCase) >= 0 || cur.StartsWith("Capture", StringComparison.Ordinal))
                            label.text = want;
                    }
                }
            }
        }

        private static string _roadsSig;

        /// <summary>Pales draws a road as a supply line on the table, not as a mesh we invent.</summary>
        public static Il2CppSystem.Collections.Generic.List<WarSupplyLine> BuildSupplyLines()
        {
            var lines = new Il2CppSystem.Collections.Generic.List<WarSupplyLine>();
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return lines;
            var seen = new HashSet<string>();
            foreach (var t in cfg.Tiles)
            {
                if (t.RoadToIds == null || string.IsNullOrEmpty(t.TileNumber)) continue;
                foreach (var id in t.RoadToIds)
                {
                    string key = string.CompareOrdinal(t.Id, id) < 0 ? t.Id + "|" + id : id + "|" + t.Id;
                    if (!seen.Add(key)) continue;
                    ZilleTileData other = null;
                    for (int i = 0; i < cfg.Tiles.Count; i++)
                        if (cfg.Tiles[i].Id == id) { other = cfg.Tiles[i]; break; }
                    if (other == null || string.IsNullOrEmpty(other.TileNumber)) continue;
                    var line = new WarSupplyLine();
                    line.tileNames = new Il2CppSystem.Collections.Generic.List<string>();
                    line.tileNames.Add(t.TileNumber);
                    line.tileNames.Add(other.TileNumber);
                    lines.Add(line);
                }
            }
            return lines;
        }

        private static void DrawSupplyLines()
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || _root == null) return;
            var sb = new StringBuilder();
            foreach (var t in cfg.Tiles)
            {
                if (t.RoadToIds == null) continue;
                foreach (var id in t.RoadToIds)
                    if (string.CompareOrdinal(t.Id, id) < 0) sb.Append(t.Id).Append('>').Append(id).Append(';');
            }
            string sig = sb.ToString();
            if (sig == _roadsSig) return;
            if (sig.Length == 0) { _roadsSig = sig; return; }
            var oldCubes = _root.Find("ZilleRoads");
            if (oldCubes != null) UnityEngine.Object.Destroy(oldCubes.gameObject);
            var oldLines = _root.Find("ZilleSupplyLines");
            if (oldLines != null) UnityEngine.Object.Destroy(oldLines.gameObject);
            DestroyNamed("ZilleSupply_");
            var mgr = UnityEngine.Object.FindObjectOfType<WarSupplyLineManager>();
            if (mgr == null)
            {
                if (_warnedMissing.Add("supply-api"))
                    MelonLogger.Warning("[ZTABLE] WarSupplyLineManager is not in the scene yet.");
                return;
            }
            var lines = BuildSupplyLines();
            int ready = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                var line = lines[i];
                if (line?.tileNames == null || line.tileNames.Count < 2) continue;
                try { line.SetupTiles(); } catch { }
                if (line.Tiles == null || line.Tiles.Count < 2)
                {
                    var a = FindLiveTile(line.tileNames[0]);
                    var b = FindLiveTile(line.tileNames[1]);
                    if (a == null || b == null) continue;
                    var pair = new Il2CppSystem.Collections.Generic.List<WarTile>();
                    pair.Add(a);
                    pair.Add(b);
                    line.Tiles = pair;
                }
                if (line.Tiles != null && line.Tiles.Count >= 2) ready++;
            }
            if (ready == 0) return;
            EnsureTileSupplyLists();
            try
            {
                var wom = UnityEngine.Object.FindObjectOfType<WarOperationManager>();
                var live = wom != null ? wom.GetCurrentOperation() : null;
                if (live != null && live.warOperationData != null)
                    live.warOperationData.supplyLines = lines;
            }
            catch { }
            try
            {
                mgr.SetupSupplyLines(lines);
                _roadsSig = sig;
                MelonLogger.Msg($"[ZTABLE] Pales supply manager drew {ready} roads.");
                return;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] SetupSupplyLines: " + ex.Message);
            }
            if (DrawWithTemplate(lines) > 0)
            {
                _roadsSig = sig;
            }
        }

        /// <summary>The connection check inserts each tile's supply-line list. A null list aborts every road.</summary>
        private static void EnsureTileSupplyLists()
        {
            if (_root == null) return;
            var tiles = _root.GetComponentsInChildren<WarTile>(true);
            for (int i = 0; i < tiles.Length; i++)
            {
                var wt = tiles[i];
                if (wt == null) continue;
                if (wt.adjacentWarTiles == null)
                    wt.adjacentWarTiles = new Il2CppSystem.Collections.Generic.List<WarTile>();
                if (wt.GetCurrentSupplyLines() == null)
                    wt.SetSupplyLines(new Il2CppSystem.Collections.Generic.List<WarSupplyLine>());
            }
        }

        /// <summary>Same animated line the supply manager instantiates, used when its connection walk rejects the graph.</summary>
        private static int DrawWithTemplate(Il2CppSystem.Collections.Generic.List<WarSupplyLine> lines)
        {
            TemplateMapLine template = null;
            TemplateMapLine[] all = null;
            try { all = Resources.FindObjectsOfTypeAll<TemplateMapLine>(); } catch { }
            if (all != null)
            {
                for (int i = 0; i < all.Length; i++)
                    if (all[i] != null) { template = all[i]; break; }
            }
            if (template == null || _root == null)
            {
                MelonLogger.Warning("[ZTABLE] No Pales supply-line template in the scene.");
                return 0;
            }
            var holder = new GameObject("ZilleSupplyLines");
            holder.transform.SetParent(_root, false);
            int n = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                var line = lines[i];
                if (line?.Tiles == null || line.Tiles.Count < 2) continue;
                var go = UnityEngine.Object.Instantiate(template.gameObject, holder.transform);
                go.name = "ZilleSupply_" + i;
                go.SetActive(true);
                var mapLine = go.GetComponent<TemplateMapLine>();
                if (mapLine == null) continue;
                try { mapLine.Setup(line); n++; }
                catch (Exception ex)
                {
                    MelonLogger.Warning("[ZTABLE] TemplateMapLine.Setup: " + ex.Message);
                    UnityEngine.Object.Destroy(go);
                }
            }
            if (n > 0)
            {
                PaintPlayerLines(holder);
                MelonLogger.Msg("[ZTABLE] Pales map lines drawn: " + n + ".");
            }
            return n;
        }

        /// <summary>Unconnected roads stay on the grey inactive material. Pales paints a live line in the player colour.</summary>
        private static void PaintPlayerLines(GameObject holder)
        {
            var method = HarmonyLib.AccessTools.Method(typeof(TemplateMapLineSection), "ApplyMapLineSettings");
            if (method == null || holder == null) return;
            var sections = holder.GetComponentsInChildren<TemplateMapLineSection>(true);
            var state = TemplateMapLineSection.SupplyLineSectionAlignmentState.Player;
            for (int i = 0; i < sections.Length; i++)
            {
                if (sections[i] == null) continue;
                try { method.Invoke(sections[i], new object[] { state }); } catch { }
            }
        }

        private static bool _framed;

        /// <summary>The war camera opens on the newspaper. Frame the Zille city the way LookAtTile frames a Pales province.</summary>
        private static void FrameZille()
        {
            if (_framed || _root == null) return;
            var tile = FindLiveTile("35");
            if (tile == null) return;
            try
            {
                var cam = UnityEngine.Object.FindObjectOfType<MapCamera>();
                if (cam != null) cam.SetFollowTarget(tile.transform);
                var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
                if (mgr != null) mgr.LookAtTile(tile);
                _framed = true;
                MelonLogger.Msg("[ZTABLE] Camera framed on Zille.");
            }
            catch (Exception ex)
            {
                _framed = true;
                MelonLogger.Warning("[ZTABLE] Frame: " + ex.Message);
            }
        }

        public static bool NativeDeploymentOpen()
        {
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (panel != null && panel.IsShowing()) return true;
            }
            catch { }
            return ScenarioStarted && HasLiveMap;
        }

        private static bool _garrisonsPlaced;
        private static bool _poolReady;
        private static bool _frontFilled;
        private static bool _pointsGranted;
        private static bool _bannerCleared;

        /// <summary>Pales paints a province from the tile manager. Our own colour was covering that wash.</summary>
        private static void PaintWithPalesColors()
        {
            if (_root == null) return;
            var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
            if (mgr == null) return;
            var tiles = _root.GetComponentsInChildren<WarTile>(true);
            for (int i = 0; i < tiles.Length; i++)
            {
                var wt = tiles[i];
                if (wt == null || !wt.gameObject.activeInHierarchy) continue;
                var rend = wt.GetWarTileRenderer();
                if (rend == null) continue;
                try { mgr.SetTileColor(rend, wt.GetCurrentToken(), wt); } catch { }
            }
        }

        /// <summary>The hover ray uses the war table camera. After we frame Zille it must be that camera, or the province never lights up.</summary>
        private static void AimTileRaycaster()
        {
            var ray = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
            if (ray == null) return;
            var cam = WarCamera();
            if (cam == null) return;
            try
            {
                if (ray.mainCamera != cam) ray.mainCamera = cam;
            }
            catch { }
        }

        private static bool _rayInput;
        private static Renderer _lit;
        private static bool _hoverHitLogged;

        /// <summary>Lights the province under the cursor with the Pales highlight, even when the stock ray misses the mask.</summary>
        private static void HighlightUnderCursor()
        {
            var cam = WarCamera();
            var mouse = UnityEngine.InputSystem.Mouse.current;
            if (cam == null || mouse == null) return;
            var pos = mouse.position.ReadValue();
            var ray = cam.ScreenPointToRay(new Vector3(pos.x, pos.y, 0f));
            RaycastHit[] hits = null;
            try { hits = Physics.RaycastAll(ray, 40f); } catch { return; }
            Renderer next = null;
            WarTile tile = null;
            float best = float.MaxValue;
            if (hits != null)
            {
                for (int i = 0; i < hits.Length; i++)
                {
                    var col = hits[i].collider;
                    if (col == null || hits[i].distance >= best) continue;
                    var wt = col.GetComponentInParent<WarTile>();
                    if (wt == null) continue;
                    var sampleRend = wt.GetWarTileRenderer();
                    var tex = sampleRend != null ? sampleRend.material.GetTexture("_Tile_Texture") as Texture2D : null;
                    if (tex != null && tex.isReadable)
                    {
                        var sample = tex.GetPixelBilinear(hits[i].textureCoord.x, hits[i].textureCoord.y);
                        if (sample.a < 0.5f) continue;
                    }
                    best = hits[i].distance;
                    tile = wt;
                    next = wt.GetWarTileRenderer();
                }
            }
            if (!_hoverHitLogged && tile != null)
            {
                _hoverHitLogged = true;
                MelonLogger.Msg("[ZTABLE] Cursor is over province " + tile.gameObject.name + ".");
            }
            TrackHold(tile);
            if (next == _lit) return;
            var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
            if (mgr == null) return;
            if (_lit != null)
            {
                try { mgr.SetTileHighlightState(_lit, false); } catch { }
            }
            if (next != null)
            {
                try { mgr.SetTileHighlightState(next, true); } catch { }
                if (tile != null)
                {
                    try { mgr.SetHoveredWarTile(tile); } catch { }
                }
            }
            _lit = next;
        }

        private static WarTile _hoverTile;
        private static WarTile _heldTile;
        private static float _heldFor;
        private static bool _committed;
        private static System.Reflection.MethodInfo _clickTile;

        /// <summary>
        /// The Pales raycaster commits a deploy or a unit action after the mouse has rested on a province.
        /// Injected presses are short, so this watches the same button and then calls that raycaster action.
        /// </summary>
        private static void TrackHold(WarTile tile)
        {
            if (tile != _hoverTile)
            {
                if (_hoverTile != null)
                {
                    try { _hoverTile.OnTileExit(); } catch { }
                }
                _hoverTile = tile;
                if (tile != null)
                {
                    try { tile.OnTileEnter(); } catch { }
                }
            }
            var mouse = UnityEngine.InputSystem.Mouse.current;
            bool down = mouse != null && mouse.leftButton.isPressed;
            if (!down || tile == null)
            {
                _heldTile = null;
                _heldFor = 0f;
                _committed = false;
                return;
            }
            if (_heldTile != tile)
            {
                _heldTile = tile;
                _heldFor = 0f;
                _committed = false;
            }
            _heldFor += Time.unscaledDeltaTime;
            if (_committed || _heldFor < 0.05f) return;
            _committed = true;
            try
            {
                var ray = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
                if (_clickTile == null)
                    _clickTile = HarmonyLib.AccessTools.Method(typeof(WarTileRaycaster), "OnClickWarTile");
                if (ray != null && _clickTile != null) _clickTile.Invoke(ray, null);
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] hold: " + ex.GetBaseException().Message);
            }
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (panel != null && panel.IsShowing() && panel.IsDeploymentUnitSelected() && tile.GetCurrentToken() == null)
                {
                    var unit = panel.GetSelectedUnitTypeData();
                    if (unit != null)
                    {
                        panel.DeployToken(unit, tile);
                        MelonLogger.Msg("[ZTABLE] Held deploy of " + unit.UnitName + " on " + tile.gameObject.name + ".");
                    }
                }
                else
                {
                    tile.OnTileCommitAction();
                    MelonLogger.Msg("[ZTABLE] Held tile action on " + tile.gameObject.name + ".");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] hold commit: " + ex.GetBaseException().Message);
            }
        }


        /// <summary>The hover and the click both come from the raycaster's input subscription, which only starts with the war fragment.</summary>
        private static void WakeTileRaycaster()
        {
            if (_rayInput) return;
            var ray = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
            if (ray == null) return;
            var method = HarmonyLib.AccessTools.Method(typeof(WarTileRaycaster), "OnStartWarFragment");
            if (method == null) return;
            try
            {
                method.Invoke(ray, null);
                _rayInput = true;
                MelonLogger.Msg("[ZTABLE] War tile raycaster input started.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] raycaster input: " + ex.GetBaseException().Message);
            }
        }

        /// <summary>This save starts the operation on zero action points, so the turn opens already finished. The budget has to be written before Start, and the banner the game shows at zero has to be dismissed once the turn actually has moves.</summary>
        private static void EnsureActionPoints()
        {
            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow == null) return;
            const int want = 5;
            try
            {
                var cfg = flow.warConfiguration;
                string varName = cfg != null ? cfg.ActionPointsPerTurnVariable : null;
                if (!string.IsNullOrEmpty(varName))
                    DialogueHelper.SetVariable(varName, want);
                flow.ActionPointsPerTurn = want;
            }
            catch { }
            if (!ScenarioStarted) return;
            if (!_pointsGranted)
            {
                if (flow.GetCurrentActionPoints() <= 0)
                    try { flow.currentActionPoints = want; } catch { }
                _pointsGranted = true;
                MelonLogger.Msg("[ZTABLE] Action points for the turn: " + flow.GetCurrentActionPoints() + ".");
            }
            if (_bannerCleared || flow.GetCurrentActionPoints() <= 0) return;
            var info = UnityEngine.Object.FindObjectOfType<WarInfoTextPanel>();
            if (info == null) return;
            try
            {
                info.Hide();
                _bannerCleared = true;
                MelonLogger.Msg("[ZTABLE] Out-of-moves banner hidden; the turn still has action points.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] info banner: " + ex.GetBaseException().Message);
            }
        }

        /// <summary>A previous deploy shared the player's unit asset and saved infantry and tanks at zero. The Pales screen needs a real pool.</summary>
        public static void EnsurePlayerPool()
        {
            if (_poolReady) return;
            FloorUnit("infantry", 8);
            FloorUnit("tank", 1);
            _poolReady = true;
        }

        private static void FloorUnit(string name, int want)
        {
            var ut = FindUnit(u => u != null && u.unitType == WarUnitTypeData.UnitType.LandUnit, name);
            if (ut == null) return;
            int available = ut.UnitTotalCount - ut.UnitDeployedCount;
            if (available >= want) return;
            ut.UnitDeployedCount = 0;
            if (ut.UnitTotalCount < want) ut.UnitTotalCount = want;
            MelonLogger.Msg("[ZTABLE] " + name + " pool set to " + ut.UnitTotalCount + ".");
        }

        /// <summary>The native Start button stays locked until every Rizian border province has a land unit. Place them through the deployment panel so the count and the refund list stay honest.</summary>
        private static void FillFrontlineFromPanel()
        {
            if (_frontFilled || _root == null) return;
            var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
            if (panel == null || !panel.IsShowing()) return;
            var infantry = FindUnit(u => u != null && u.unitType == WarUnitTypeData.UnitType.LandUnit, "infantry");
            if (infantry == null) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;
            int placed = 0;
            foreach (var td in cfg.Tiles)
            {
                if (td == null || td.IsSea || td.IsCity || td.Allegiance != "Rizia" || !td.IsBorder) continue;
                var wt = FindLiveTile(td.TileNumber);
                if (wt == null || wt.GetCurrentToken() != null) continue;
                try
                {
                    panel.DeployToken(infantry, wt);
                    placed++;
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning("[ZTABLE] Front deploy " + td.Name + ": " + ex.Message);
                }
            }
            try { panel.UpdateDeployingUnitCount(); } catch { }
            _frontFilled = true;
            MelonLogger.Msg("[ZTABLE] Frontline land units placed through the Pales panel: " + placed + ".");
        }

        /// <summary>Wehlen units sit on the border the way Pales garrisons do, without stacking on a city star.</summary>
        private static void EnsureEnemyGarrisons()
        {
            if (_garrisonsPlaced || _root == null) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;
            var infantry = FindUnit(u => u != null && u.unitType == WarUnitTypeData.UnitType.LandUnit, "infantry");
            var tank = FindUnit(u => u != null && u.unitType == WarUnitTypeData.UnitType.LandUnit, "tank");
            var support = FindUnit(u => u != null && u.unitType == WarUnitTypeData.UnitType.LandUnit, "support");
            if (infantry == null || UnityEngine.Object.FindObjectOfType<WarTokenManager>() == null) return;
            int placed = 0;
            int infantryLeft = 14;
            int tanksLeft = 2;
            int supportLeft = 2;
            var byId = new Dictionary<string, ZilleTileData>();
            foreach (var t in cfg.Tiles)
                if (!string.IsNullOrEmpty(t.Id)) byId[t.Id] = t;
            foreach (var td in cfg.Tiles)
            {
                if (td.IsSea || td.Allegiance == "Rizia" || td.IsCity || string.IsNullOrEmpty(td.TileNumber)) continue;
                bool facesRizia = false;
                if (td.AdjacentIds != null)
                {
                    foreach (var id in td.AdjacentIds)
                        if (byId.TryGetValue(id, out var other) && other.Allegiance == "Rizia" && !other.IsSea)
                            facesRizia = true;
                }
                if (!facesRizia) continue;
                var wt = FindLiveTile(td.TileNumber);
                if (wt == null || wt.GetCurrentToken() != null) continue;
                WarUnitTypeData ut;
                if (tanksLeft > 0)
                {
                    ut = tank ?? infantry;
                    tanksLeft--;
                }
                else if (infantryLeft > 0)
                {
                    ut = infantry;
                    infantryLeft--;
                }
                else if (supportLeft > 0)
                {
                    ut = support ?? infantry;
                    supportLeft--;
                }
                else continue;
                string msg = PlaceUnit(td, ut, true);
                if (!msg.StartsWith("Postawiono")) continue;
                placed++;
            }
            _garrisonsPlaced = true;
            MelonLogger.Msg("[ZTABLE] Wehlen garrisons on the map: " + placed + ".");
        }

        public static void InvalidateRoads() => _roadsSig = null;

        private static void DestroyNamed(string prefix)
        {
            var all = UnityEngine.Object.FindObjectsOfType<TemplateMapLineSection>();
            if (all == null) return;
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i] == null || all[i].gameObject == null) continue;
                if ((all[i].gameObject.name ?? "").StartsWith(prefix))
                    UnityEngine.Object.Destroy(all[i].gameObject);
            }
        }

        private static TemplateMapLineSection PalesLineTemplate()
        {
            var mgr = UnityEngine.Object.FindObjectOfType<WarSupplyLineManager>();
            if (mgr != null)
            {
                object boxed = HarmonyLib.AccessTools.Property(typeof(WarSupplyLineManager), "templateMapLineSection")?.GetValue(mgr)
                    ?? HarmonyLib.AccessTools.Field(typeof(WarSupplyLineManager), "templateMapLineSection")?.GetValue(mgr);
                if (boxed is TemplateMapLineSection fromMgr && fromMgr.gameObject.scene.IsValid())
                    return fromMgr;
            }
            var all = Resources.FindObjectsOfTypeAll<TemplateMapLineSection>();
            TemplateMapLineSection scene = null;
            TemplateMapLineSection any = null;
            if (all != null)
            {
                for (int i = 0; i < all.Length; i++)
                {
                    if (all[i] == null) continue;
                    if ((all[i].gameObject.name ?? "").StartsWith("ZilleSupply_")) continue;
                    if (any == null) any = all[i];
                    if (all[i].gameObject.scene.IsValid()) { scene = all[i]; break; }
                }
            }
            return scene != null ? scene : any;
        }

        private static Texture2D _roadTex;

        private static void DrawCyanRoad(Transform holder, Vector3 from, Vector3 to)
        {
            var go = new GameObject("road");
            go.transform.SetParent(holder, false);
            var lr = go.AddComponent<LineRenderer>();
            lr.useWorldSpace = true;
            lr.positionCount = 2;
            // The table sits on world Y. A small lift keeps the stroke on top of the map art.
            lr.SetPosition(0, new Vector3(from.x, from.y + 0.03f, from.z));
            lr.SetPosition(1, new Vector3(to.x, to.y + 0.03f, to.z));
            lr.startWidth = lr.endWidth = 0.013f;
            var cyan = new Color(0.25f, 0.95f, 0.90f, 1f);
            lr.startColor = lr.endColor = cyan;
            lr.alignment = LineAlignment.View;
            lr.numCapVertices = 4;
            lr.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
            lr.receiveShadows = false;
            lr.sortingOrder = 40;
            var shader = Shader.Find("Sprites/Default");
            if (shader == null) shader = Shader.Find("Unlit/Color");
            if (shader == null) shader = Shader.Find("UI/Default");
            if (shader == null) return;
            var mat = new Material(shader);
            if (_roadTex == null)
            {
                _roadTex = new Texture2D(1, 1, TextureFormat.RGBA32, false);
                _roadTex.SetPixel(0, 0, Color.white);
                _roadTex.Apply();
            }
            mat.mainTexture = _roadTex;
            mat.color = cyan;
            if (mat.HasProperty("_Color")) mat.SetColor("_Color", cyan);
            lr.material = mat;
        }

        private static TemplateMapLineSection _lineTemplate;

        private static (System.Reflection.MethodInfo method, UnityEngine.Object target) SupplyLineDraw()
        {
            System.Reflection.MethodInfo found = null;
            Type[] types = null;
            try { types = typeof(WarTile).Assembly.GetTypes(); }
            catch (System.Reflection.ReflectionTypeLoadException ex) { types = ex.Types; }
            if (types == null) return (null, null);
            for (int i = 0; i < types.Length && found == null; i++)
            {
                var t = types[i];
                if (t == null) continue;
                var methods = t.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static);
                for (int m = 0; m < methods.Length; m++)
                {
                    if (methods[m].Name != "SetupSupplyLine") continue;
                    var ps = methods[m].GetParameters();
                    if (ps.Length == 3 && ps[0].ParameterType == typeof(WarTile) && ps[1].ParameterType == typeof(WarTile))
                    {
                        found = methods[m];
                        break;
                    }
                }
            }
            if (found == null || found.IsStatic) return (found, null);
            UnityEngine.Object target = null;
            var behaviours = UnityEngine.Object.FindObjectsOfType<MonoBehaviour>();
            for (int i = 0; i < behaviours.Length; i++)
            {
                if (behaviours[i] != null && behaviours[i].GetType().Name == found.DeclaringType.Name)
                {
                    target = behaviours[i];
                    break;
                }
            }
            return (found, target);
        }


        private static Material _peakMat;

        /// <summary>A small peak on every province marked mountains, so the Gora button is visible on the table.</summary>
        private static void SyncMountainMarkers()
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;
            foreach (var td in cfg.Tiles)
            {
                if (td.IsSea || string.IsNullOrEmpty(td.TileNumber)) continue;
                var tile = FindLiveTile(td.TileNumber);
                if (tile == null) continue;
                Transform peak = tile.transform.Find("ZilleMountain");
                bool want = td.Terrain == "mountains";
                if (!want)
                {
                    if (peak != null) UnityEngine.Object.Destroy(peak.gameObject);
                    continue;
                }
                if (peak != null) continue;
                var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                go.name = "ZilleMountain";
                var col = go.GetComponent<Collider>();
                if (col != null) UnityEngine.Object.Destroy(col);
                go.transform.SetParent(tile.transform, false);
                go.transform.localPosition = new Vector3(0f, 0f, -0.05f);
                go.transform.localScale = new Vector3(0.045f, 0.045f, 0.07f);
                if (_peakMat == null)
                {
                    var sh = Shader.Find("Unlit/Color");
                    if (sh == null) sh = Shader.Find("Sprites/Default");
                    if (sh != null)
                    {
                        _peakMat = new Material(sh);
                        _peakMat.color = new Color(0.55f, 0.52f, 0.48f, 1f);
                    }
                }
                var rend = go.GetComponent<Renderer>();
                if (rend != null && _peakMat != null) rend.sharedMaterial = _peakMat;
            }
        }

        private static readonly Dictionary<int, float> _tokenScale = new Dictionary<int, float>();

        /// <summary>Units and ordinary cities grow a little. Zille and Kratsna grow a lot.</summary>
        private static void ScaleTokens()
        {
            WarToken[] tokens = null;
            try { tokens = UnityEngine.Object.FindObjectsOfType<WarToken>(); } catch { return; }
            if (tokens == null) return;
            for (int i = 0; i < tokens.Length; i++)
            {
                var tok = tokens[i];
                if (tok == null || !tok.gameObject.scene.IsValid()) continue;
                int id = tok.GetInstanceID();
                float want = 1.22f;
                string caption = TokenCaption(tok);
                if (caption.IndexOf("Zille", StringComparison.OrdinalIgnoreCase) >= 0
                    || caption.IndexOf("Kratsna", StringComparison.OrdinalIgnoreCase) >= 0)
                    want = 2.35f;
                else if (caption.StartsWith("Capture", StringComparison.OrdinalIgnoreCase))
                    want = 1.48f;
                _tokenScale.TryGetValue(id, out float have);
                if (have <= 0f) have = 1f;
                if (Mathf.Abs(have - want) < 0.02f) continue;
                tok.transform.localScale *= want / have;
                _tokenScale[id] = want;
            }
        }

        private static string TokenCaption(WarToken tok)
        {
            var texts = tok.GetComponentsInChildren<Il2CppTMPro.TMP_Text>(true);
            for (int n = 0; n < texts.Length; n++)
            {
                var label = texts[n];
                if (label == null) continue;
                string cur = label.text ?? "";
                if (cur.Length > 0) return cur;
            }
            return tok.gameObject.name ?? "";
        }

        private static void EnsureDeploymentState()
        {
            if (ScenarioStarted) return;
            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow == null) return;
            try
            {
                if (flow.GetWarState() != WarFlowManager.WarState.InitialDeployment)
                {
                    flow.SetWarState(WarFlowManager.WarState.InitialDeployment);
                    if (!_deploymentReady)
                    {
                        _deploymentReady = true;
                        MelonLogger.Msg("[ZTABLE] War state held at initial deployment until Graj.");
                    }
                }
            }
            catch (Exception ex)
            {
                if (_warnedMissing.Add("deploy-state"))
                    MelonLogger.Warning("[ZTABLE] Deployment state: " + ex.Message);
            }
        }

        public static void StartScenario()
        {
            ScenarioStarted = true;
            _deploymentReady = true;
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
                if (panel != null) panel.OnBeginOperationClick();
            }
            catch (Exception ex) { MelonLogger.Warning("[ZTABLE] Begin operation: " + ex.Message); }
            try
            {
                var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (flow != null)
                {
                    flow.OnInitialDeploymentFinished();
                    flow.SetWarState(WarFlowManager.WarState.Operation);
                }
            }
            catch (Exception ex) { MelonLogger.Warning("[ZTABLE] Start scenario: " + ex.Message); }
            _barStatus = "Scenariusz wystartowal.";
            MelonLogger.Msg("[ZTABLE] Play: deployment finished, operation started.");
        }

        /// <summary>The camera that is actually framing the war table, not whichever one is tagged Main.</summary>
        private static Camera WarCamera()
        {
            if (_root == null) return Camera.main;
            Camera bestCam = null;
            float bestScore = -1f;
            var cams = Camera.allCameras;
            for (int i = 0; i < cams.Length; i++)
            {
                var c = cams[i];
                if (c == null || !c.enabled || !c.gameObject.activeInHierarchy) continue;
                var vp = c.WorldToViewportPoint(_root.position);
                if (vp.z <= 0.05f) continue;
                float score = 0f;
                if (vp.x > 0f && vp.x < 1f && vp.y > 0f && vp.y < 1f) score += 1000f;
                score += c.pixelWidth;
                if (score > bestScore) { bestScore = score; bestCam = c; }
            }
            return bestCam != null ? bestCam : Camera.main;
        }

        /// <summary>
        /// Keeps the figurine box above the frame and the headphones past the left edge.
        /// Re-checked every tick because the war camera eases in after the table appears.
        /// </summary>
        private static void NudgeTableProps()
        {
            if (_root == null) return;
            var cam = WarCamera();
            if (cam == null) return;
            if (_propHolds.Count == 0)
            {
                Renderer[] rends = null;
                try { rends = UnityEngine.Object.FindObjectsOfType<Renderer>(); } catch { return; }
                var moved = new HashSet<int>();
                var noted = new StringBuilder();
                foreach (var r in rends)
                {
                    if (r == null || r.gameObject == null || !r.gameObject.scene.IsValid() || !r.gameObject.activeInHierarchy) continue;
                    string low = (r.gameObject.name ?? "").ToLowerInvariant();
                    bool box = low.Contains("tokenbox") || low.Contains("token_box");
                    bool phones = low.Contains("headphone") || low.Contains("headset") || low.Contains("earcup") || low.Contains("mo_headphone");
                    if (!box && !phones) continue;
                    Transform t = r.transform;
                    if (box)
                    {
                        while (t.parent != null && (t.parent.name ?? "").ToLowerInvariant().Contains("tokenbox"))
                            t = t.parent;
                    }
                    if (!moved.Add(t.GetInstanceID())) continue;
                    foreach (var b in t.GetComponentsInChildren<Behaviour>())
                        if (b != null && b.GetType().Name == "Animator") b.enabled = false;
                    _propHolds.Add((t, t.localPosition, Vector3.zero, box));
                    noted.Append(t.name).Append(" ");
                }
                if (_propHolds.Count == 0)
                {
                    if (_warnedMissing.Add("props-missing"))
                        MelonLogger.Msg("[ZTABLE] Token box / headphones not found yet.");
                    return;
                }
                MelonLogger.Msg("[ZTABLE] Props held: " + noted);
                if (!_holdLoop)
                {
                    _holdLoop = true;
                    MelonCoroutines.Start(HoldPropsAfterScripts());
                }
            }
            for (int i = 0; i < _propHolds.Count; i++)
            {
                var h = _propHolds[i];
                if (h.t == null) continue;
                if (!TryClearance(h.t, cam, h.above, out Vector3 localDelta)) continue;
                h.localOffset += localDelta;
                h.t.localPosition = h.baseLocal + h.localOffset;
                _propHolds[i] = h;
                if (_warnedMissing.Add(h.above ? "parked-box" : "parked-phones"))
                    MelonLogger.Msg("[ZTABLE] Parked " + h.t.name + (h.above ? " above the map." : " left of the map."));
            }
        }

        /// <summary>Runs after the table's own LateUpdate, which otherwise puts the box back on the map.</summary>
        private static IEnumerator HoldPropsAfterScripts()
        {
            while (true)
            {
                yield return new WaitForEndOfFrame();
                HoldProps();
            }
        }

        /// <summary>Extra local move so the box clears the top of the view, or the headphones clear the left.</summary>
        private static bool TryClearance(Transform t, Camera cam, bool above, out Vector3 localDelta)
        {
            localDelta = Vector3.zero;
            var renderers = t.GetComponentsInChildren<Renderer>();
            if (renderers == null || renderers.Length == 0) return false;
            bool any = false;
            Bounds b = default;
            for (int i = 0; i < renderers.Length; i++)
            {
                if (renderers[i] == null || !renderers[i].enabled) continue;
                if (!any) { b = renderers[i].bounds; any = true; }
                else b.Encapsulate(renderers[i].bounds);
            }
            if (!any) return false;
            Vector3 centerVp = cam.WorldToViewportPoint(b.center);
            if (centerVp.z <= 0.05f) return false;
            Vector3 ext = b.extents;
            float extreme = above ? float.MaxValue : float.MinValue;
            for (int sx = -1; sx <= 1; sx += 2)
            for (int sy = -1; sy <= 1; sy += 2)
            for (int sz = -1; sz <= 1; sz += 2)
            {
                var vp = cam.WorldToViewportPoint(b.center + new Vector3(sx * ext.x, sy * ext.y, sz * ext.z));
                if (vp.z <= 0f) continue;
                if (above) { if (vp.y < extreme) extreme = vp.y; }
                else if (vp.x > extreme) extreme = vp.x;
            }
            float target = above ? 1.55f : -0.35f;
            float deltaVp = target - extreme;
            if (above && deltaVp <= 0.02f) return false;
            if (!above && deltaVp >= -0.02f) return false;
            Vector3 from = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, centerVp.z));
            Vector3 to = above
                ? cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f + deltaVp, centerVp.z))
                : cam.ViewportToWorldPoint(new Vector3(0.5f + deltaVp, 0.5f, centerVp.z));
            Vector3 worldDelta = to - from;
            localDelta = t.parent != null ? t.parent.InverseTransformVector(worldDelta) : worldDelta;
            return localDelta.sqrMagnitude > 1e-8f;
        }

        // ================================================================== edit on the live table

        private static int _mapSel = -1;

        public static void HandleMapEdit(Event e)
        {
            if (ScenarioStarted) return;
            if (e == null || _root == null || !SkinEnabled) return;
            if (ZilleWarMapEditorUI.AnyOpen) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || cfg.Tiles.Count == 0) return;

            var bar = MapEditBarRect();
            bool overBar = bar.Contains(e.mousePosition);
            if ((e.type == EventType.MouseMove || e.type == EventType.MouseDrag) && !overBar)
                _hover = HitTile(e);
            if (e.type == EventType.MouseDown && e.button == 0 && !overBar && e.mousePosition.x > 280f)
            {
                int hit = HitTile(e);
                if (hit >= 0)
                {
                    if (_roadArm && _mapSel >= 0 && _mapSel < cfg.Tiles.Count && hit != _mapSel)
                    {
                        ZilleMapLayoutManager.ToggleRoad(cfg.Tiles[_mapSel], cfg.Tiles[hit]);
                        _roadArm = false;
                        _mapSel = hit;
                        e.Use();
                    }
                    else
                        _mapSel = hit;
                }
            }
            if (_mapSel >= 0 && _mapSel < cfg.Tiles.Count && e.shift && e.type == EventType.MouseDrag && e.button == 0)
            {
                if (TryMouseToMapPx(e, out float px, out float py))
                {
                    var td = cfg.Tiles[_mapSel];
                    td.MapPxX = px;
                    td.MapPxY = py;
                    td.NormalizedX = Mathf.Clamp01(px / 12288f);
                    td.NormalizedY = Mathf.Clamp01(py / 8192f);
                    RequestApply();
                    e.Use();
                }
            }
        }

        public static void DrawMapEditBar()
        {
            if (_root == null || !SkinEnabled || ZilleWarMapEditorUI.AnyOpen || NativeDeploymentOpen()) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || cfg.Tiles.Count == 0) return;
            if (_mapSel < 0 || _mapSel >= cfg.Tiles.Count) _mapSel = 0;
            var td = cfg.Tiles[_mapSel];
            var bar = MapEditBarRect();
            GUI.Box(bar, GUIContent.none);
            string hint = _roadArm ? "Kliknij druga prowincje, aby polaczyc droga." : (td.Terrain == "mountains" ? "Gora. " : "") + "Shift+przeciagnij przesuwa.";
            GUI.Label(new Rect(bar.x + 8, bar.y + 4, 200, 18), "<b>" + td.Name + "</b>");
            GUI.Label(new Rect(bar.x + 8, bar.y + 24, 200, 16), "<size=10>" + hint + "</size>");
            float x = bar.x + 210f;
            float y = bar.y + 12f;
            if (GUI.Button(new Rect(x, y, 72, 26), td.Allegiance == "Rizia" ? "[Rizia]" : "Rizia"))
                SetAllegiance(td, "Rizia");
            if (GUI.Button(new Rect(x + 76, y, 78, 26), td.Allegiance == "Wehlen" ? "[Wehlen]" : "Wehlen"))
                SetAllegiance(td, "Wehlen");
            if (GUI.Button(new Rect(x + 158, y, 68, 26), td.Allegiance == "Empty" ? "[Puste]" : "Puste"))
                SetAllegiance(td, "Empty");
            if (GUI.Button(new Rect(x + 230, y, 64, 26), td.Terrain == "mountains" ? "[Gora]" : "Gora"))
            {
                td.Terrain = td.Terrain == "mountains" ? "plains" : "mountains";
                RequestApply();
            }
            if (GUI.Button(new Rect(x + 298, y, 70, 26), _roadArm ? "[Droga]" : "Droga"))
                _roadArm = !_roadArm;
            if (GUI.Button(new Rect(x + 372, y, 72, 26), "Zapisz"))
                _barStatus = ZilleMapLayoutManager.SaveConfig() ? "Zapisane." : "Zapis nieudany.";
            if (GUI.Button(new Rect(x + 448, y, 78, 26), "Wczytaj"))
                _barStatus = ZilleMapLayoutManager.ReloadSavedLayout() ? "Wczytane." : "Brak zapisu.";
            if (GUI.Button(new Rect(x + 530, y, 70, 26), ScenarioStarted ? "[Gra]" : "Graj"))
                StartScenario();
            if (!string.IsNullOrEmpty(_barStatus))
                GUI.Label(new Rect(bar.x + 8, bar.y - 18, 420, 16), "<size=10>" + _barStatus + "</size>");
        }

        public static ZilleTileData SelectedProvince
        {
            get
            {
                var cfg = ZilleMapLayoutManager.CurrentConfig;
                if (cfg?.Tiles == null || cfg.Tiles.Count == 0) return null;
                if (_mapSel < 0 || _mapSel >= cfg.Tiles.Count) _mapSel = 0;
                return cfg.Tiles[_mapSel];
            }
        }

        private static bool _frontlineOpen;
        private static float _nextFrontline;

        private static void DrawDeploymentChrome(ZilleMapConfig cfg)
        {
            if (Time.unscaledTime >= _nextFrontline)
            {
                _nextFrontline = Time.unscaledTime + 0.4f;
                _frontlineOpen = FrontlineMissingLandUnit(cfg);
            }
            if (!ScenarioStarted)
            {
                var banner = new Rect(Screen.width * 0.5f - 110f, 18f, 220f, 28f);
                var prev = GUI.backgroundColor;
                GUI.backgroundColor = new Color(0.08f, 0.07f, 0.06f, 0.92f);
                GUI.Box(banner, "OPERATION START");
                if (_frontlineOpen)
                {
                    var warn = new Rect(Screen.width * 0.5f - 210f, MapEditBarRect().y - 32f, 420f, 26f);
                    GUI.backgroundColor = new Color(0.55f, 0.08f, 0.08f, 0.92f);
                    GUI.Box(warn, "All frontline tiles must have a land unit.");
                }
                GUI.backgroundColor = new Color(0.12f, 0.12f, 0.13f, 0.95f);
                if (GUI.Button(new Rect(Screen.width - 168f, Screen.height - 64f, 140f, 36f), "Start"))
                    StartScenario();
                GUI.backgroundColor = prev;
            }
        }

        private static bool FrontlineMissingLandUnit(ZilleMapConfig cfg)
        {
            if (cfg?.Tiles == null) return false;
            WarToken[] tokens = null;
            try { tokens = UnityEngine.Object.FindObjectsOfType<WarToken>(); } catch { return false; }
            var byId = new Dictionary<string, ZilleTileData>();
            for (int i = 0; i < cfg.Tiles.Count; i++)
                if (!string.IsNullOrEmpty(cfg.Tiles[i].Id)) byId[cfg.Tiles[i].Id] = cfg.Tiles[i];
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                if (td.IsSea || td.Allegiance != "Rizia") continue;
                bool front = false;
                if (td.AdjacentIds != null)
                {
                    for (int a = 0; a < td.AdjacentIds.Count; a++)
                    {
                        if (!byId.TryGetValue(td.AdjacentIds[a], out var nb) || nb.IsSea) continue;
                        if (nb.Allegiance != "Rizia") { front = true; break; }
                    }
                }
                if (!front) continue;
                if (!TileHasLandUnit(td, tokens)) return true;
            }
            return false;
        }

        private static bool TileHasLandUnit(ZilleTileData td, WarToken[] tokens)
        {
            var wt = FindLiveTile(td.TileNumber);
            if (wt == null || tokens == null) return false;
            var at = wt.transform.position;
            for (int i = 0; i < tokens.Length; i++)
            {
                var tok = tokens[i];
                if (tok == null) continue;
                if ((tok.transform.position - at).sqrMagnitude > 0.0035f) continue;
                string cap = TokenCaption(tok);
                if (cap.StartsWith("Capture", StringComparison.OrdinalIgnoreCase)) continue;
                return true;
            }
            return false;
        }

        public static void ToggleZone(ZilleTileData td, string zone)
        {
            if (td == null) return;
            if (zone == "coast") td.HasCoastalArtillery = !td.HasCoastalArtillery;
            else if (zone == "air") td.HasNoAirZone = !td.HasNoAirZone;
            else if (zone == "naval") td.HasNoNavalLanding = !td.HasNoNavalLanding;
            ApplyZoneToTile(td);
            ZilleMapLayoutManager.SaveConfig();
        }

        private static void ApplyZoneToTile(ZilleTileData td)
        {
            var wt = FindLiveTile(td.TileNumber);
            if (wt == null) return;
            TryInvokeTileFlag("SetTileCoastalArtillery", wt, td.HasCoastalArtillery);
            TryInvokeTileFlag("SetTileAntiAir", wt, td.HasNoAirZone);
            if (td.HasNoNavalLanding) TryBlockNavalLanding(wt);
        }

        private static bool _zoneInvokeLogged;

        private static object FindBehaviour(Type t)
        {
            MonoBehaviour[] all = null;
            try { all = UnityEngine.Object.FindObjectsOfType<MonoBehaviour>(); } catch { return null; }
            if (all == null) return null;
            for (int i = 0; i < all.Length; i++)
                if (all[i] != null && all[i].GetType() == t) return all[i];
            return null;
        }

        private static void TryInvokeTileFlag(string method, WarTile wt, bool on)
        {
            Type[] types = null;
            try { types = typeof(WarTile).Assembly.GetTypes(); }
            catch (System.Reflection.ReflectionTypeLoadException ex) { types = ex.Types; }
            if (types == null) return;
            for (int i = 0; i < types.Length; i++)
            {
                var t = types[i];
                if (t == null) continue;
                var methods = t.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static);
                for (int m = 0; m < methods.Length; m++)
                {
                    var info = methods[m];
                    if (info.Name != method) continue;
                    var ps = info.GetParameters();
                    if (ps.Length != 2 || ps[1].ParameterType != typeof(bool)) continue;
                    if (ps[0].ParameterType != typeof(WarTile) && ps[0].ParameterType != typeof(string)) continue;
                    object target = null;
                    if (!info.IsStatic)
                    {
                        target = t == typeof(WarTile) ? wt : FindBehaviour(t);
                        if (target == null) continue;
                    }
                    object first = ps[0].ParameterType == typeof(string) ? wt.gameObject.name : (object)wt;
                    try
                    {
                        info.Invoke(target, new object[] { first, on });
                        if (_zoneInvokeLogged) return;
                        _zoneInvokeLogged = true;
                        MelonLogger.Msg("[ZTABLE] Zone API " + t.Name + "." + method);
                        return;
                    }
                    catch (Exception ex)
                    {
                        MelonLogger.Warning("[ZTABLE] " + method + ": " + ex.Message);
                    }
                }
            }
        }

        private static void TryBlockNavalLanding(WarTile wt)
        {
            Type[] types = null;
            try { types = typeof(WarTile).Assembly.GetTypes(); }
            catch (System.Reflection.ReflectionTypeLoadException ex) { types = ex.Types; }
            if (types == null) return;
            Type enumType = null;
            for (int i = 0; i < types.Length; i++)
                if (types[i] != null && types[i].Name == "TileNavalBlockedBy") { enumType = types[i]; break; }
            if (enumType == null || !enumType.IsEnum) return;
            object value = null;
            foreach (var name in Enum.GetNames(enumType))
            {
                if (name.IndexOf("Both", StringComparison.OrdinalIgnoreCase) >= 0
                    || name.IndexOf("All", StringComparison.OrdinalIgnoreCase) >= 0
                    || name.IndexOf("Player", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    value = Enum.Parse(enumType, name);
                    break;
                }
            }
            if (value == null) return;
            for (int i = 0; i < types.Length; i++)
            {
                var t = types[i];
                if (t == null) continue;
                var methods = t.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                for (int m = 0; m < methods.Length; m++)
                {
                    if (methods[m].Name != "SetTileNavalBlockedBy") continue;
                    var ps = methods[m].GetParameters();
                    if (ps.Length != 1 || ps[0].ParameterType != enumType) continue;
                    object target = t == typeof(WarTile) ? wt : FindBehaviour(t);
                    if (target == null) continue;
                    try { methods[m].Invoke(target, new object[] { value }); } catch { }
                    return;
                }
            }
        }

        private static void SyncZoneMarkers()
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                var wt = FindLiveTile(td.TileNumber);
                if (wt == null) continue;
                if (td.HasCoastalArtillery || td.HasNoAirZone || td.HasNoNavalLanding)
                {
                    string pushed = td.TileNumber
                        + (td.HasCoastalArtillery ? "c" : "")
                        + (td.HasNoAirZone ? "a" : "")
                        + (td.HasNoNavalLanding ? "n" : "");
                    if (_zonePushed.Add(pushed)) ApplyZoneToTile(td);
                }
                PlaceZoneMarker(wt.transform, "ZilleZoneCoast", td.HasCoastalArtillery, new Color(0.15f, 0.35f, 0.75f, 1f), new Vector3(0.04f, 0f, 0.02f));
                PlaceZoneMarker(wt.transform, "ZilleZoneAir", td.HasNoAirZone, new Color(0.75f, 0.18f, 0.18f, 1f), new Vector3(-0.04f, 0f, 0.02f));
                PlaceZoneMarker(wt.transform, "ZilleZoneNaval", td.HasNoNavalLanding, new Color(0.85f, 0.85f, 0.9f, 1f), new Vector3(0f, 0f, -0.04f));
            }
        }

        private static Material _zoneMat;
        private static readonly HashSet<string> _zonePushed = new HashSet<string>();

        private static void PlaceZoneMarker(Transform tile, string name, bool on, Color color, Vector3 local)
        {
            var existing = tile.Find(name);
            if (!on)
            {
                if (existing != null) UnityEngine.Object.Destroy(existing.gameObject);
                return;
            }
            if (existing != null) return;
            var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.name = name;
            var col = go.GetComponent<Collider>();
            if (col != null) UnityEngine.Object.Destroy(col);
            go.transform.SetParent(tile, false);
            go.transform.localPosition = local;
            go.transform.localScale = new Vector3(0.18f, 0.18f, 0.08f);
            var sh = Shader.Find("Unlit/Color");
            if (sh == null) sh = Shader.Find("Sprites/Default");
            if (sh == null) return;
            var mat = new Material(sh);
            mat.color = color;
            var rend = go.GetComponent<Renderer>();
            if (rend != null) rend.sharedMaterial = mat;
            if (_zoneMat == null) _zoneMat = mat;
        }

        private static void DrawDeployHint(ZilleMapConfig cfg)
        {
            if (ScenarioStarted || _hover < 0 || _hover >= cfg.Tiles.Count) return;
            var td = cfg.Tiles[_hover];
            if (td.IsSea || td.Allegiance != "Rizia") return;
            var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
            if (panel == null || !panel.IsDeploymentUnitSelected()) return;
            var e = Event.current;
            if (e == null) return;
            var r = new Rect(e.mousePosition.x + 18f, e.mousePosition.y - 34f, 92f, 28f);
            var prev = GUI.backgroundColor;
            GUI.backgroundColor = new Color(0.05f, 0.05f, 0.05f, 0.94f);
            GUI.Box(r, "Deploy");
            GUI.backgroundColor = prev;
        }

        private static void StylePalesLine(TemplateMapLineSection line)
        {
            if (line == null) return;
            var cyan = new Color(0.45f, 0.93f, 0.90f, 0.95f);
            var renderers = line.GetComponentsInChildren<LineRenderer>(true);
            for (int i = 0; i < renderers.Length; i++)
            {
                var lr = renderers[i];
                if (lr == null) continue;
                lr.startColor = lr.endColor = cyan;
                lr.startWidth = lr.endWidth = 0.006f;
                lr.alignment = LineAlignment.View;
            }
        }

        private static bool _roadArm;
        private static int _hover = -1;
        private static string _barStatus = "";

        private static Rect MapEditBarRect() => new Rect(Screen.width * 0.5f - 420f, Screen.height - 78f, 820f, 52f);

        private static void SetAllegiance(ZilleTileData td, string allegiance)
        {
            td.Allegiance = allegiance;
            RequestApply();
        }

        private static int HitTile(Event e)
        {
            int rayHit = HitTileByCollider(e);
            if (rayHit >= 0) return rayHit;
            if (!TryMouseToMapPx(e, out float px, out float py)) return -1;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            int best = -1;
            float bestD = 560f * 560f;
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var t = cfg.Tiles[i];
                if (t.IsSea) continue;
                float dx = t.MapPxX - px;
                float dy = t.MapPxY - py;
                float d = dx * dx + dy * dy;
                if (d < bestD) { bestD = d; best = i; }
            }
            return best;
        }

        private static int HitTileByCollider(Event e)
        {
            var cam = WarCamera();
            if (cam == null || e == null) return -1;
            var ray = cam.ScreenPointToRay(new Vector3(e.mousePosition.x, Screen.height - e.mousePosition.y, 0f));
            RaycastHit[] hits = null;
            try { hits = Physics.RaycastAll(ray, 40f); } catch { return -1; }
            if (hits == null || hits.Length == 0) return -1;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return -1;
            float best = float.MaxValue;
            int found = -1;
            for (int h = 0; h < hits.Length; h++)
            {
                var col = hits[h].collider;
                if (col == null) continue;
                var wt = col.GetComponentInParent<WarTile>();
                if (wt == null) continue;
                string num = wt.gameObject.name.StartsWith("Tile_") ? wt.gameObject.name.Substring("Tile_".Length) : "";
                for (int i = 0; i < cfg.Tiles.Count; i++)
                {
                    if (cfg.Tiles[i].TileNumber != num || cfg.Tiles[i].IsSea) continue;
                    if (hits[h].distance < best) { best = hits[h].distance; found = i; }
                }
            }
            return found;
        }

        private static bool TryMouseToMapPx(Event e, out float px, out float py)
        {
            px = py = 0f;
            var cam = WarCamera();
            if (cam == null || _root == null) return false;
            var ray = cam.ScreenPointToRay(new Vector3(e.mousePosition.x, Screen.height - e.mousePosition.y, 0f));
            Vector3 normal = _root.TransformDirection(Vector3.forward);
            var plane = new Plane(normal, _root.position);
            if (!plane.Raycast(ray, out float dist)) return false;
            Vector3 local = _root.InverseTransformPoint(ray.GetPoint(dist));
            px = (local.x - MapLeft) / PxToWorld;
            py = (MapTop - local.y) / PxToWorld;
            return true;
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
            if (LayoutLocked && PlacementMode)
            {
                if (e.type == EventType.KeyDown)
                    _placementMsg = "Uklad zablokowany. Odblokuj go w inspektorze regionu.";
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
