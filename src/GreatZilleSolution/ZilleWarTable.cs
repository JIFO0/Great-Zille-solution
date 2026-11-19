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
        public const float VanillaSeaTileScale = 0.2761f;

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
            public string PaintSig;
            public Material Instance;
        }

        /// <summary>When set, province masks drop to 25% opacity and the editor will not move them.</summary>
        public static bool LayoutLocked { get; set; } = false;

        private static Transform _root;
        private static readonly Dictionary<int, PlaneBackup> _planes = new Dictionary<int, PlaneBackup>();
        private static readonly Dictionary<int, TileBackup> _tiles = new Dictionary<int, TileBackup>();
        private static float _nextTick = 0f;
        private static float _nextFind = 0f;
        private static bool _loggedApplied = false;
        private static string _lastDeployKey = "none";
        private static int _lastSelectedTokenId = 0;
        private static string _lastBattleSig = "";
        private static bool _boardRefreshRequested = false;
        private static bool _variantDirty = false;

        public static void RequestBoardRefresh() => _boardRefreshRequested = true;

        public static void NotifyVariantChanged()
        {
            _variantDirty = true;
            _roadsSig = null;
            _nextTick = 0f;
        }
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
                if (_root != null)
                {
                    HighlightUnderCursor();
                    if (!_holdLoop)
                    {
                        _holdLoop = true;
                        MelonCoroutines.Start(HoldPropsAfterScripts());
                    }
                }
                if (Time.unscaledTime < _nextTick) return;
                _nextTick = Time.unscaledTime + 0.25f;

                ZilleProfiler.BeginTick();
                try
                {

                if (_root == null)
                {
                    if (Time.unscaledTime < _nextFind) return;
                    _nextFind = Time.unscaledTime + 0.5f;
                    _root = FindWarMapRoot();
                    if (_root == null) return;
                    _chromeTries = 0;
                    _planes.Clear(); _tiles.Clear(); _liveTileMap.Clear(); _loggedApplied = false; _citySpawned.Clear();
                    _propsNudged = false; _propHolds.Clear(); _enlarged.Clear(); _tokenScale.Clear(); _zonePushed.Clear(); _roadsSig = null; _deploymentReady = false; _tilesAdopted = false; _raycastLayer = int.MinValue; _garrisonsPlaced = false; _framed = false; _frontFilled = false; _poolReady = false; _pointsGranted = false; _bannerCleared = false; _palesColorsRead = false; _colorAttempted = false; _tileMgr = null; _tokenMgr = null; _flowMgr = null; _battleMgr = null; _cachedWarCam = null; _liveTiles = null; _clutterHidden = false; _peaksDone = false; _captionCache.Clear(); _nextCaptionScan = 0f; _rayInput = false; _lit = null; _hoverHitLogged = false; _victoryShown = false; _enemySince = 0f; _lastEnemyActivity = 0f; _lastActionTurn = -1;
                    ResetBattleStatusTracking();
                    PurgeStaleWarManagerEntries(destroyAllTokens: false);
                    MelonLogger.Msg($"[ZTABLE] War map instance found: '{_root.name}' (id {_root.gameObject.GetInstanceID()}), applying Zille skin...");
                }

                if (!_loggedApplied)
                {
                    ZilleMapLayoutManager.EnsureTexturesLoaded();
                    int p = ApplyPlanes(_root);
                    int t = ApplyTiles(_root);
                    SanitizeTileManagerAndAdjacencies();
                    EnsureCityTokens();
                    ApplyCityLabels();
                    EnsureEnemyGarrisons();
                    AdoptGameTiles();
                    EnsureDeploymentState();
                    FrameZille();
                    DrawSupplyLines();
                    AimTileRaycaster();
                    WakeTileRaycaster();
                    SyncMountainMarkers();
                    HideTableClutter();
                    HideProfileChrome();
                    HidePoliticalLeftovers();
                    if (p > 0 || t > 0)
                    {
                        _loggedApplied = true;
                        MelonLogger.Msg($"[ZTABLE] Zille skin applied: {p}/6 map pages, {t} province tiles.");
                        Diagnose("after-apply");
                        RefreshBoard();
                    }
                }
                else
                {
                    if (_variantDirty)
                    {
                        _variantDirty = false;
                        ApplyVariantOnLiveBoard();
                    }
                    bool dep = DeploymentPanelOpen();
                    string depKey = dep ? DeployPaintKey() : "none";
                    var sel = SelectedUnit();
                    int selId = sel != null ? sel.GetInstanceID() : 0;
                    string battleSig = BattlePaintSig();
                    if (depKey != _lastDeployKey || selId != _lastSelectedTokenId || battleSig != _lastBattleSig || _boardRefreshRequested)
                    {
                        _lastDeployKey = depKey;
                        _lastSelectedTokenId = selId;
                        _lastBattleSig = battleSig;
                        _boardRefreshRequested = false;
                        RefreshBoard();
                    }

                    if (!ScenarioStarted)
                    {
                        EnsureCityTokens();
                        if (!_garrisonsPlaced) EnsureEnemyGarrisons();
                        ApplyCityLabels();
                    }

                    CleanupDeadStatusEffectIcons();
                    EnsureActionPoints();
                    EnsureZilleCameraBounds();
                    CheckCityVictory();
                    GrayUnavailableAbilities();
                    SyncZoneMarkers();
                    ScaleTokens();
                }
            }
            finally
            {
                ZilleProfiler.EndTick();
            }
        }
        catch (Exception ex)
        {
            MelonLogger.Warning($"[ZTABLE] Tick error: {ex.Message}\n{ex.StackTrace}");
        }
    }

        /// <summary>Puts every touched renderer/tile back to vanilla Pales state.</summary>
        public class SavedTileState
        {
            public string TileNumber;
            public string Allegiance;
            public int FortLevel;
            public string UnitTypeName;
            public WarToken.WarAllegiance UnitAllegiance;
            public bool HasToken;
        }

        private static readonly List<SavedTileState> _phaseSavedState = new List<SavedTileState>();

        public static void SavePhaseBoardState()
        {
            _phaseSavedState.Clear();
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;

            foreach (var td in cfg.Tiles)
            {
                if (td == null || string.IsNullOrEmpty(td.TileNumber)) continue;
                var wt = FindLiveTile(td.TileNumber);
                var state = new SavedTileState
                {
                    TileNumber = td.TileNumber,
                    Allegiance = td.Allegiance,
                    FortLevel = td.FortLevel
                };

                if (wt != null)
                {
                    var tok = wt.GetCurrentToken();
                    if (tok != null && !tok.IsDead())
                    {
                        var ut = tok.GetWarUnitTypeData();
                        if (ut != null && !IsCityUnit(ut))
                        {
                            state.HasToken = true;
                            state.UnitTypeName = ut.name;
                            state.UnitAllegiance = tok.GetTokenAllegiance();
                        }
                    }
                }
                _phaseSavedState.Add(state);
            }
            MelonLogger.Msg($"[ZTABLE] Saved board state for Phase transition: {_phaseSavedState.Count} tiles.");
        }

        public static bool RestorePhaseBoardState()
        {
            if (_phaseSavedState == null || _phaseSavedState.Count == 0) return false;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return false;

            SanitizeTileManagerAndAdjacencies();

            var mgr = TokenMgr() ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            if (mgr == null) return false;
            if (mgr.instantiatedWarTokens != null)
            {
                for (int i = mgr.instantiatedWarTokens.Count - 1; i >= 0; i--)
                {
                    var tok = mgr.instantiatedWarTokens[i];
                    if (tok == null || tok.Pointer == IntPtr.Zero || tok.gameObject == null || tok.IsDead())
                        mgr.instantiatedWarTokens.RemoveAt(i);
                }
            }

            var types = UnitTypes();
            int restoredTokens = 0;

            foreach (var state in _phaseSavedState)
            {
                var td = cfg.Tiles.Find(t => t != null && t.TileNumber == state.TileNumber);
                if (td != null)
                {
                    td.Allegiance = state.Allegiance;
                    td.FortLevel = state.FortLevel;
                }
                var wt = FindLiveTile(state.TileNumber);
                if (wt != null)
                {
                    var alleg = ToAllegiance(state.Allegiance);
                    wt.SetTileAllegiance(alleg, false);
                    if (state.FortLevel > 0) wt.ChangeWarTileFortLevelStat(state.FortLevel);

                    if (state.HasToken && !string.IsNullOrEmpty(state.UnitTypeName))
                    {
                        WarUnitTypeData ut = null;
                        for (int i = 0; i < types.Count; i++)
                        {
                            if (types[i] != null && types[i].name == state.UnitTypeName)
                            {
                                ut = types[i];
                                break;
                            }
                        }

                        if (ut != null && wt.GetCurrentToken() == null)
                        {
                            try
                            {
                                int dep = ut.UnitDeployedCount;
                                mgr.DeployToken(ut, wt, state.UnitAllegiance);
                                if (state.UnitAllegiance == WarToken.WarAllegiance.Enemy)
                                {
                                    ut.UnitDeployedCount = dep;
                                }
                                else if (state.UnitAllegiance == WarToken.WarAllegiance.Player)
                                {
                                    if (ut.UnitTotalCount > 0) ut.UnitTotalCount = ut.UnitTotalCount - 1;
                                    ut.UnitDeployedCount = dep + 1;
                                }
                                restoredTokens++;
                            }
                            catch (Exception ex)
                            {
                                MelonLogger.Warning($"[ZTABLE] Failed to restore token {state.UnitTypeName} on tile {state.TileNumber}: {ex.Message}");
                            }
                        }
                    }
                }
            }
            MelonLogger.Msg($"[ZTABLE] Restored Phase board state ({restoredTokens} units placed onto frontline).");
            return true;
        }

        public static void CleanupAllWarUIAndMarkers()
        {
            try
            {
                try { Panels.Instance?.WarHUDPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarTurnPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarActionHoverPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarContextualHoverPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarTokenSelectionPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarTokenIndicatorPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarDeploymentPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarPlayerActionsPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarBattlePanel?.HideAllBattles(); } catch { }
                try { Panels.Instance?.WarObjectivePanel?.gameObject.SetActive(false); } catch { }
                try { Panels.Instance?.WarInfoTextPanel?.Hide(); } catch { }
                try { Panels.Instance?.WarFloatingTextPanel?.gameObject.SetActive(false); } catch { }
                try { Panels.Instance?.WarTokenStatusEffectsPanel?.RemoveAllInstances(); } catch { }

                void DestroyTemplateInstances<T>() where T : Component
                {
                    var items = Resources.FindObjectsOfTypeAll<T>();
                    if (items == null) return;
                    for (int i = 0; i < items.Length; i++)
                    {
                        var it = items[i];
                        if (it == null || it.gameObject == null || !it.gameObject.scene.IsValid()) continue;
                        string n = it.gameObject.name ?? "";
                        if (n.IndexOf("Template", StringComparison.OrdinalIgnoreCase) >= 0 && !n.Contains("(Clone)"))
                        {
                            it.gameObject.SetActive(false);
                            continue;
                        }
                        UnityEngine.Object.Destroy(it.gameObject);
                    }
                }

                DestroyTemplateInstances<TemplateTileStatusEffect>();
                DestroyTemplateInstances<TemplateTokenStatusEffect>();
                DestroyTemplateInstances<TemplateWarTokenUnitStats>();
                DestroyTemplateInstances<TemplateWarTokenCityStats>();
                DestroyTemplateInstances<TemplateWarObjectiveIndicator>();
                DestroyTemplateInstances<TemplateBattle>();
                DestroyTemplateInstances<TemplateBattleTokenStat>();
                DestroyTemplateInstances<TemplateSupporterStats>();
            }
            catch { }
        }

        public static void Restore()
        {
            try
            {
                DestroyClonedTiles();
                foreach (var kv in _planes)
                {
                    var pb = kv.Value;
                    if (pb.Rend != null)
                    {
                        if (pb.Shared != null) pb.Rend.sharedMaterial = pb.Shared;
                        if (pb.Instance != null) UnityEngine.Object.Destroy(pb.Instance);
                    }
                }

                // Clean up sticky objective indicators (Issue #6)
                try
                {
                    var indicators = Resources.FindObjectsOfTypeAll<TemplateWarObjectiveIndicator>();
                    if (indicators != null)
                    {
                        for (int i = 0; i < indicators.Length; i++)
                        {
                            var ind = indicators[i];
                            if (ind != null && ind.gameObject != null) ind.gameObject.SetActive(false);
                        }
                    }
                }
                catch { }

                // Clean up fort levels and mountain/cube primitives from tiles
                foreach (var kv in _tiles)
                {
                    var tb = kv.Value;
                    if (tb.Instance != null) { UnityEngine.Object.Destroy(tb.Instance); tb.Instance = null; }
                    if (tb.Tile == null) continue;
                    try { tb.Tile.ChangeWarTileFortLevelStat(0); } catch { }
                    for (int i = tb.Tile.transform.childCount - 1; i >= 0; i--)
                    {
                        var child = tb.Tile.transform.GetChild(i);
                        if (child == null) continue;
                        string cName = child.name;
                        if (cName.StartsWith("Zille") || cName.Contains("Mountain") || cName.Contains("Cube"))
                        {
                            UnityEngine.Object.Destroy(child.gameObject);
                        }
                    }
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

                if (_root != null)
                {
                    var roads = _root.Find("ZilleRoads");
                    if (roads != null) UnityEngine.Object.Destroy(roads.gameObject);
                }

                _cityLabelsApplied = false;
                _chromeHidden = false;
                _politicalHidden = false;
                _battleContestedTiles.Clear();
                _pendingContestedTiles.Clear();
                _tileWorldCenters.Clear();
                _cachedScreenCenters.Clear();

                PurgeStaleWarManagerEntries(destroyAllTokens: true);
                CleanupAllWarUIAndMarkers();

                if (_savedVirtualCamPos.Count > 0)
                {
                    foreach (var kv in _savedVirtualCamPos)
                    {
                        try { if (kv.Value.t != null) kv.Value.t.position = kv.Value.pos; } catch { }
                    }
                    _savedVirtualCamPos.Clear();
                }

                MelonLogger.Msg($"[ZTABLE] Restored vanilla Pales table ({_planes.Count} pages, {_tiles.Count} tiles).");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[ZTABLE] Restore error: {ex.Message}");
            }
            finally
            {
                ShowProfileChrome();
                _planes.Clear(); _tiles.Clear(); _liveTileMap.Clear(); _root = null; _loggedApplied = false; _palesColorsRead = false; _colorAttempted = false; _tileMgr = null; _tokenMgr = null; _flowMgr = null; _battleMgr = null; _cachedWarCam = null;
                _tilesAdopted = false;
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

        private static readonly Dictionary<string, WarTile> _liveTileMap = new Dictionary<string, WarTile>(StringComparer.OrdinalIgnoreCase);

        public static void ClearLiveTileCache()
        {
            _liveTileMap.Clear();
        }

        public static void RebuildLiveTileCache()
        {
            _liveTileMap.Clear();
            if (_root == null) return;
            var tiles = _root.GetComponentsInChildren<WarTile>(true);
            if (tiles == null) return;
            for (int i = 0; i < tiles.Length; i++)
            {
                var t = tiles[i];
                if (t != null && t.gameObject != null)
                {
                    string name = t.gameObject.name;
                    if (name.StartsWith("Tile_"))
                    {
                        string num = name.Substring(5);
                        _liveTileMap[num] = t;
                    }
                    _liveTileMap[name] = t;
                }
            }
            if (_gridIds != null)
            {
                _tileByGridId = new WarTile[_gridIds.Count];
                for (int i = 1; i < _gridIds.Count; i++)
                {
                    string id = _gridIds[i];
                    string num = id.StartsWith("ZilleTile_") ? id.Substring("ZilleTile_".Length) : id;
                    _tileByGridId[i] = FindLiveTile(num);
                }
            }
        }

        private static byte[] _gridBytes;
        private static List<string> _gridIds;
        private static WarTile[] _tileByGridId;
        private static bool _gridLoaded;

        public static void EnsureProvinceGridLoaded()
        {
            if (_gridLoaded && _tileByGridId != null) return;
            try
            {
                string dir = ZilleMapLayoutManager.ResolveRegionsDir();
                if (string.IsNullOrEmpty(dir) || !Directory.Exists(dir))
                {
                    dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mods", "GreatZilleAssets", "regions");
                }
                string binPath = Path.Combine(dir, "zille_province_id_grid.bin");
                string jsonPath = Path.Combine(dir, "zille_province_ids.json");
                if (!File.Exists(binPath) || !File.Exists(jsonPath))
                {
                    MelonLogger.Warning($"[ZTABLE] Province ID grid files not found in {dir}");
                    return;
                }

                _gridBytes = File.ReadAllBytes(binPath);
                string json = File.ReadAllText(jsonPath);
                _gridIds = System.Text.Json.JsonSerializer.Deserialize<List<string>>(json);

                if (_gridIds != null)
                {
                    _tileByGridId = new WarTile[_gridIds.Count];
                    for (int i = 1; i < _gridIds.Count; i++)
                    {
                        string id = _gridIds[i];
                        string num = id.StartsWith("ZilleTile_") ? id.Substring("ZilleTile_".Length) : id;
                        _tileByGridId[i] = FindLiveTile(num);
                    }
                }
                _gridLoaded = _gridBytes != null && _gridBytes.Length == 1536 * 1024 && _tileByGridId != null;
                MelonLogger.Msg($"[ZTABLE] Loaded province ID grid: {_gridBytes.Length} bytes, {_tileByGridId.Length} province entries mapped.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[ZTABLE] Error loading province ID grid: {ex.Message}");
            }
        }

        public static WarTile GetProvinceAt(Camera cam, Vector2 screenPos)
        {
            if (_root == null) return null;
            if (!_gridLoaded || _tileByGridId == null) EnsureProvinceGridLoaded();
            if (_gridBytes == null || _tileByGridId == null) return null;
            if (cam == null) cam = WarCamera();
            if (cam == null) return null;

            var ray = cam.ScreenPointToRay(new Vector3(screenPos.x, screenPos.y, 0f));
            Vector3 normal = _root.TransformDirection(Vector3.forward);
            var plane = new Plane(normal, _root.position);
            if (!plane.Raycast(ray, out float dist)) return null;

            Vector3 local = _root.InverseTransformPoint(ray.GetPoint(dist));
            float px = (local.x - MapLeft) / PxToWorld;
            float py = (MapTop - local.y) / PxToWorld;

            int gx = (int)(px / 8f);
            int gy = (int)(py / 8f);
            if (gx < 0 || gx >= 1536 || gy < 0 || gy >= 1024) return null;

            int idx = gy * 1536 + gx;
            byte provIdx = _gridBytes[idx];
            if (provIdx > 0 && provIdx < _tileByGridId.Length)
            {
                var cand = _tileByGridId[provIdx];
                if (cand != null && cand.gameObject != null && cand.gameObject.activeInHierarchy)
                {
                    var td = TileDataOf(cand);
                    if (td != null && td.IsDisabled) return null;
                    return cand;
                }
            }
            return null;
        }

        public static WarTile FindLiveTile(string tileNumber)
        {
            if (_root == null || string.IsNullOrEmpty(tileNumber)) return null;
            if (_liveTileMap.TryGetValue(tileNumber, out var cached) && cached != null && cached.gameObject != null)
                return cached;

            if (_liveTileMap.Count == 0)
            {
                RebuildLiveTileCache();
                if (_liveTileMap.TryGetValue(tileNumber, out cached) && cached != null && cached.gameObject != null)
                    return cached;
            }

            string goName = "Tile_" + tileNumber;
            if (_liveTileMap.TryGetValue(goName, out cached) && cached != null && cached.gameObject != null)
                return cached;

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

        private static bool _derdiaAllegianceLogged;

        public static WarToken.WarAllegiance ToAllegiance(string name)
        {
            if (name == "Rizia" || name == "Player" || name == "Derdia") return WarToken.WarAllegiance.Player;
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
            data.isCoastalArtilleryTile = td.HasCoastalArtillery;
            data.isAntiAirTile = td.HasNoAirZone;
            data.isInitialDeploymentTile = ((td.Allegiance == "Rizia" || td.Allegiance == "Derdia") && !td.IsSea) || td.IsNavalStart;
            data.isBorderTile = td.IsBorder;
            if (td.IsImpassable) data.tileDefenceType = WarTile.TileDefenceType.None;
            else if (td.IsCity) data.tileDefenceType = WarTile.TileDefenceType.City;
            else if (td.FortLevel >= 2) data.tileDefenceType = WarTile.TileDefenceType.FortifiedDefencePoint;
            else if (td.FortLevel > 0 || td.Terrain == "hills") data.tileDefenceType = WarTile.TileDefenceType.DefencePoint;
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

        private static WarTile[] _liveTiles;
        private static float _nextTileScan;

        private static int ApplyTiles(Transform root)
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return 0;

            if (_liveTiles == null || Time.unscaledTime >= _nextTileScan)
            {
                _liveTiles = root.GetComponentsInChildren<WarTile>(true);
                _nextTileScan = Time.unscaledTime + 2f;
            }
            var tiles = _liveTiles;
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
            bool deploying = !ScenarioStarted && DeploymentPanelOpen();
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

                // Provinces in the Zille layout stay visible if not disabled.
                if (td.IsDisabled)
                {
                    if (wt.adjacentWarTiles != null && wt.adjacentWarTiles.Count > 0)
                        wt.adjacentWarTiles = new Il2CppSystem.Collections.Generic.List<WarTile>();
                    if (wt.gameObject.activeSelf) wt.gameObject.SetActive(false);
                    continue;
                }
                else
                {
                    if (!wt.gameObject.activeSelf) wt.gameObject.SetActive(true);
                }

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
                        var m = tb.Instance;
                        if (m == null) { m = rend.material; tb.Instance = m; }
                        if (m != null && m.HasProperty("_Tile_Texture"))
                        {
                            var ct = m.GetTexture("_Tile_Texture");
                            if (ct == null || ct.GetInstanceID() != mask.GetInstanceID()) m.SetTexture("_Tile_Texture", mask);
                        }
                        if (m != null && m.HasProperty("_Opacity"))
                        {
                            float opacity = LayoutLocked ? 0.25f : EnemyLandOpacity(td);
                            if (Mathf.Abs(m.GetFloat("_Opacity") - opacity) > 0.02f)
                                m.SetFloat("_Opacity", opacity);
                        }
                    }
                }

                if (wt.IsReinforcementTile() != td.IsReinforcementTile)
                    wt.SetIsReinforcementTile(td.IsReinforcementTile);

                // Re-push whenever the inspector changes allegiance, a city, an airfield or a fort,
                // so F10 edits show up on the table without leaving the theatre.
                string sig = td.Allegiance + "|" + td.FortLevel + "|" + td.IsCity + "|" + td.IsAirfield + "|" + td.Terrain + "|" + td.IsSea
                    + "|" + td.HasCoastalArtillery + "|" + td.HasNoAirZone + "|" + td.HasNoNavalLanding + "|" + td.IsNavalStart + "|" + td.IsBorder;
                if (tb.PushedSig != sig)
                {
                    try
                    {
                        if (!ScenarioStarted || !tb.GameplayPushed)
                        {
                            var curTok = wt.GetCurrentToken();
                            var data = new WarTileData();
                            FillWarTileData(td, data);
                            wt.Setup(data, data.startingAllegiance);
                            if (curTok != null) wt.SetCurrentWarToken(curTok);
                            if (td.FortLevel > 0) wt.ChangeWarTileFortLevelStat(td.FortLevel);
                            wt.ChangeWarTileEnemyAirfieldStat(td.IsAirfield && td.Allegiance != "Rizia");
                            wt.ChangeWarTileCoastalArtilleryStat(td.HasCoastalArtillery);
                            wt.ChangeWarTileAntiAirStat(td.HasNoAirZone);
                            wt.SetTileNavalBlockedBy(NavalBlock(td));
                            wt.SetIsReinforcementTile(td.IsReinforcementTile);
                            tb.GameplayPushed = true;
                        }
                        else
                        {
                            var alleg = ToAllegiance(td.Allegiance);
                            wt.SetTileAllegiance(alleg, false);
                        }
                        tb.PushedAllegiance = td.Allegiance;
                        tb.PushedSig = sig;
                    }
                    catch (Exception ex)
                    {
                        if (_warnedMissing.Add("setup:" + td.TileNumber))
                            MelonLogger.Warning($"[ZTABLE] Setup {td.Name}: {ex.Message}");
                    }
                }

                int tokenId = 0;
                var living = wt.GetCurrentToken();
                if (living != null) tokenId = living.GetInstanceID();
                string paint = tokenId + "|" + (IsMainFight(wt) ? "F" : "") + "|" + (deploying ? "D:" + DeployPaintKey() : "B");
                if (tb.PaintSig != paint || !_palesColorsRead)
                {
                    TintTile(wt, td);
                    if (_palesColorsRead) tb.PaintSig = paint;
                }
                ShowTile(wt, td);

                // adjacency: only active neighbours (disabled neighbours are blocked by operation border)
                if (td.AdjacentIds != null)
                {
                    var cur = wt.adjacentWarTiles;
                    bool needs = !tb.AdjApplied || cur == null || cur.Count != CountResolved(td, resolved);
                    if (needs)
                    {
                        var list = new Il2CppSystem.Collections.Generic.List<WarTile>();
                        if (!td.IsImpassable && !td.IsDisabled)
                        {
                            foreach (var aid in td.AdjacentIds)
                            {
                                if (resolved.TryGetValue(aid, out var nb) && nb != null)
                                {
                                    var nbTd = TileDataOf(nb);
                                    if (nbTd != null && nbTd.IsDisabled) continue;
                                    list.Add(nb);
                                }
                            }
                        }
                        wt.adjacentWarTiles = list;
                        tb.AdjApplied = true;
                    }
                }
                ok++;
            }
            return ok;
        }

        private static readonly List<WarTile> _clonedTiles = new List<WarTile>();

        /// <summary>
        /// Vanilla Pales has Tile_1..100 and Tile_S1..S33. v14 land runs to 129 and sea to S57.
        /// Extra land provinces are clones of a land tile. Extra sea provinces are clones of a sea tile.
        /// </summary>
        private static void EnsureClonedTiles(ZilleMapConfig cfg, Dictionary<string, WarTile> byName)
        {
            WarTile landTemplate = null;
            WarTile seaTemplate = null;
            foreach (var kv in byName)
            {
                if (kv.Key == "Tile_1") landTemplate = kv.Value;
                else if (landTemplate == null && IsLandTileObject(kv.Key)) landTemplate = kv.Value;
                if (kv.Key == "Tile_S1") seaTemplate = kv.Value;
                else if (seaTemplate == null && kv.Key.StartsWith("Tile_S", StringComparison.Ordinal)) seaTemplate = kv.Value;
            }
            if (landTemplate == null && _warnedMissing.Add("no-land-template"))
                MelonLogger.Warning("[ZTABLE] No land Tile_1..100 to clone Tile_101-Tile_129 from.");
            if (seaTemplate == null && _warnedMissing.Add("no-sea-template"))
                MelonLogger.Warning("[ZTABLE] No sea Tile_S1..S33 to clone Tile_S34-Tile_S57 from.");
            Transform landParent = landTemplate != null ? landTemplate.transform.parent : null;
            Transform seaParent = seaTemplate != null ? seaTemplate.transform.parent : null;
            if (landParent == null && seaParent == null) return;

            var seen = new HashSet<string>();
            byName.Clear();
            int dupes = 0;
            AbsorbTiles(landParent, byName, seen, ref dupes);
            if (seaParent != null && seaParent != landParent)
                AbsorbTiles(seaParent, byName, seen, ref dupes);
            if (dupes > 0 && _warnedMissing.Add("duplicate-tiles"))
                MelonLogger.Msg("[ZTABLE] Removed " + dupes + " duplicate provinces.");

            int landCloned = 0, seaCloned = 0;
            foreach (var td in cfg.Tiles)
            {
                if (string.IsNullOrEmpty(td.TileNumber)) continue;
                string goName = "Tile_" + td.TileNumber;
                if (byName.ContainsKey(goName)) continue;
                bool sea = td.IsSea || td.TileNumber.StartsWith("S", StringComparison.Ordinal);
                WarTile template = sea ? seaTemplate : landTemplate;
                Transform parent = sea ? seaParent : landParent;
                if (template == null || parent == null) continue;
                var clone = UnityEngine.Object.Instantiate(template.gameObject, parent);
                clone.name = goName;
                clone.SetActive(true);
                float s = td.WorldScale <= 0f ? (sea ? VanillaSeaTileScale : VanillaLandTileScale) : td.WorldScale;
                clone.transform.localScale = new Vector3(s, s, s);
                var rend = clone.GetComponentInChildren<Renderer>(true);
                if (rend != null && rend.sharedMaterial != null)
                {
                    rend.material = new Material(rend.sharedMaterial);
                }
                var wt = clone.GetComponent<WarTile>();
                if (wt == null)
                {
                    UnityEngine.Object.Destroy(clone);
                    continue;
                }
                wt.adjacentWarTiles = new Il2CppSystem.Collections.Generic.List<WarTile>();
                byName[goName] = wt;
                _clonedTiles.Add(wt);
                RegisterLiveTile(wt);
                if (sea) seaCloned++; else landCloned++;
            }
            if (landCloned + seaCloned > 0)
            {
                string landFrom = landTemplate != null ? landTemplate.gameObject.name : "(none)";
                string seaFrom = seaTemplate != null ? seaTemplate.gameObject.name : "(none)";
                MelonLogger.Msg("[ZTABLE] Cloned " + landCloned + " land tiles Tile_101-Tile_129 from " + landFrom
                    + " and " + seaCloned + " sea tiles Tile_S34-Tile_S57 from " + seaFrom + ".");
            }
        }

        private static bool IsLandTileObject(string name)
        {
            if (string.IsNullOrEmpty(name) || !name.StartsWith("Tile_", StringComparison.Ordinal)) return false;
            if (name.StartsWith("Tile_S", StringComparison.Ordinal)) return false;
            string rest = name.Substring("Tile_".Length);
            if (rest.Length == 0) return false;
            for (int i = 0; i < rest.Length; i++)
                if (rest[i] < '0' || rest[i] > '9') return false;
            return true;
        }

        private static void AbsorbTiles(Transform parent, Dictionary<string, WarTile> byName, HashSet<string> seen, ref int dupes)
        {
            if (parent == null) return;
            var live = parent.GetComponentsInChildren<WarTile>(true);
            if (live == null) return;
            for (int i = 0; i < live.Length; i++)
            {
                var existing = live[i];
                if (existing == null) continue;
                string n = existing.gameObject.name ?? "";
                if (!seen.Add(n))
                {
                    UnityEngine.Object.Destroy(existing.gameObject);
                    dupes++;
                    continue;
                }
                byName[n] = existing;
            }
        }

        private static void RegisterLiveTile(WarTile wt)
        {
            if (wt == null) return;
            var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
            if (mgr == null) return;
            var list = mgr.allTiles;
            if (list == null)
            {
                list = new Il2CppSystem.Collections.Generic.List<WarTile>();
                mgr.allTiles = list;
            }
            int id = wt.GetInstanceID();
            for (int j = 0; j < list.Count; j++)
                if (list[j] != null && list[j].GetInstanceID() == id) return;
            list.Add(wt);
        }

        private static void DestroyClonedTiles()
        {
            if (_clonedTiles.Count == 0) return;
            var doomed = new HashSet<int>();
            int n = 0;
            for (int i = 0; i < _clonedTiles.Count; i++)
            {
                var wt = _clonedTiles[i];
                if (wt == null) continue;
                doomed.Add(wt.GetInstanceID());
                _tiles.Remove(wt.GetInstanceID());
                UnityEngine.Object.Destroy(wt.gameObject);
                n++;
            }
            _clonedTiles.Clear();
            var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
            var list = mgr != null ? mgr.allTiles : null;
            if (list != null)
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    var w = list[i];
                    if (w == null || doomed.Contains(w.GetInstanceID())) list.RemoveAt(i);
                }
            }
            if (n > 0)
                MelonLogger.Msg("[ZTABLE] Removed " + n + " cloned Zille provinces from the Pales table.");
        }

        /// <summary>
        /// Purges stale or cross-session tokens, battles, tiles and status icons from persistent Managers.Instance singletons.
        /// When leaving War Theatre (destroyAllTokens=true), removes ALL live war tokens so they cannot leak into the next campaign/phase.
        /// </summary>
        public static void PurgeStaleWarManagerEntries(bool destroyAllTokens)
        {
            try
            {
                int purgedTokens = 0;
                var tokMgr = TokenMgr() ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (tokMgr != null)
                {
                    try { tokMgr.DeselectAllTokens(); } catch { }
                    if (tokMgr.instantiatedWarTokens != null)
                    {
                        var tList = tokMgr.instantiatedWarTokens;
                        for (int i = tList.Count - 1; i >= 0; i--)
                        {
                            var tk = tList[i];
                            bool invalid = destroyAllTokens || tk == null || tk.Pointer == IntPtr.Zero || tk.gameObject == null;
                            if (!invalid)
                            {
                                try
                                {
                                    if (tk.IsDead()) invalid = true;
                                    else
                                    {
                                        var cur = tk.GetCurrentWarTile();
                                        if (_root != null && !IsLiveTile(cur)) invalid = true;
                                    }
                                }
                                catch { invalid = true; }
                            }
                            if (invalid)
                            {
                                if (destroyAllTokens && tk != null && tk.Pointer != IntPtr.Zero && tk.gameObject != null)
                                {
                                    try
                                    {
                                        if (!tk.IsDead() && !IsCityToken(tk) && tk.GetTokenAllegiance() == WarToken.WarAllegiance.Player)
                                        {
                                            var ut = tk.GetWarUnitTypeData();
                                            if (ut != null && !IsCityUnit(ut))
                                                ut.UnitTotalCount = ut.UnitTotalCount + 1;
                                        }
                                    }
                                    catch { }
                                }
                                try { if (tk != null && tk.Pointer != IntPtr.Zero && tk.gameObject != null) UnityEngine.Object.Destroy(tk.gameObject); } catch { }
                                tList.RemoveAt(i);
                                purgedTokens++;
                            }
                        }
                    }
                    if (destroyAllTokens)
                    {
                        try { tokMgr.bombedPlayerTokens?.Clear(); } catch { }
                        try { tokMgr.enemyTokenActions?.Clear(); } catch { }
                        try { tokMgr.navyAttackTargets?.Clear(); } catch { }
                    }
                }

                var tileMgr = TileMgr() ?? UnityEngine.Object.FindObjectOfType<WarTileManager>();
                if (tileMgr != null && tileMgr.allTiles != null)
                {
                    if (destroyAllTokens)
                    {
                        tileMgr.allTiles.Clear();
                        try { tileMgr.allEnabledTileRenderers?.Clear(); } catch { }
                    }
                    else
                    {
                        SanitizeTileManagerAndAdjacencies(tileMgr);
                    }
                }

                var bm = BattleMgr() ?? UnityEngine.Object.FindObjectOfType<WarBattleManager>();
                if (bm != null && bm.GetCurrentBattles() != null)
                {
                    var bList = bm.GetCurrentBattles();
                    if (destroyAllTokens)
                    {
                        bList.Clear();
                    }
                    else
                    {
                        for (int i = bList.Count - 1; i >= 0; i--)
                        {
                            var b = bList[i];
                            bool bad = b == null || b.isBattleOver;
                            if (!bad)
                            {
                                try
                                {
                                    bad = b.attacker == null || b.defender == null
                                        || b.attacker.IsDead() || b.defender.IsDead()
                                        || (_root != null && (!IsLiveTile(b.attacker.GetCurrentWarTile()) || !IsLiveTile(b.defender.GetCurrentWarTile())));
                                }
                                catch { bad = true; }
                            }
                            if (bad) bList.RemoveAt(i);
                        }
                    }
                }

                var slMgr = UnityEngine.Object.FindObjectOfType<WarSupplyLineManager>();
                if (slMgr != null && destroyAllTokens)
                {
                    if (slMgr.instantiatedMapLines != null)
                    {
                        for (int i = slMgr.instantiatedMapLines.Count - 1; i >= 0; i--)
                        {
                            var ml = slMgr.instantiatedMapLines[i];
                            if (ml != null && ml.gameObject != null) UnityEngine.Object.Destroy(ml.gameObject);
                        }
                        slMgr.instantiatedMapLines.Clear();
                    }
                }

                if (destroyAllTokens)
                {
                    try { Panels.Instance?.WarTokenStatusEffectsPanel?.RemoveAllInstances(); } catch { }
                    try
                    {
                        var allUnits = Resources.FindObjectsOfTypeAll<WarUnitTypeData>();
                        if (allUnits != null)
                        {
                            for (int i = 0; i < allUnits.Length; i++)
                                if (allUnits[i] != null && !IsCityUnit(allUnits[i]))
                                    allUnits[i].UnitDeployedCount = 0;
                        }
                    }
                    catch { }
                    var flow = FlowMgr() ?? UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                    if (flow != null)
                    {
                        try { flow.isDisplayingEnemyMoves = false; } catch { }
                    }
                }
                else
                {
                    CleanupDeadStatusEffectIcons();
                }
                if (destroyAllTokens) ResetBattleStatusTracking();

                if (purgedTokens > 0)
                    MelonLogger.Msg($"[ZTABLE] Purged {purgedTokens} stale/previous-session WarTokens from WarTokenManager.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[ZTABLE] PurgeStaleWarManagerEntries: {ex.Message}");
            }
        }

        private static bool IsLiveTile(WarTile wt)
        {
            if (wt == null) return false;
            try
            {
                if (wt.Pointer == IntPtr.Zero) return false;
                var go = wt.gameObject;
                if (go == null) return false;
                if (_root != null && !wt.transform.IsChildOf(_root)) return false;
                return true;
            }
            catch { return false; }
        }

        private static void SanitizeTileManagerAndAdjacencies(WarTileManager mgr = null)
        {
            if (mgr == null) mgr = TileMgr() ?? UnityEngine.Object.FindObjectOfType<WarTileManager>();
            if (mgr != null && mgr.allTiles != null)
            {
                var list = mgr.allTiles;
                var seen = new HashSet<int>();
                int purged = 0;
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    var w = list[i];
                    if (!IsLiveTile(w) || !w.gameObject.activeInHierarchy || !seen.Add(w.GetInstanceID()))
                    {
                        list.RemoveAt(i);
                        purged++;
                    }
                }
                if (purged > 0)
                    MelonLogger.Msg($"[ZTABLE] Purged {purged} stale/dead/duplicate entries from WarTileManager.allTiles ({list.Count} live remain).");
            }
            if (mgr != null && mgr.allEnabledTileRenderers != null)
            {
                var rlist = mgr.allEnabledTileRenderers;
                for (int i = rlist.Count - 1; i >= 0; i--)
                {
                    var r = rlist[i];
                    if (r == null || r.Pointer == IntPtr.Zero || r.gameObject == null)
                        rlist.RemoveAt(i);
                }
            }
            if (_root != null)
            {
                var tiles = _root.GetComponentsInChildren<WarTile>(true);
                if (tiles != null)
                {
                    for (int i = 0; i < tiles.Length; i++)
                    {
                        var wt = tiles[i];
                        if (!IsLiveTile(wt) || wt.adjacentWarTiles == null) continue;
                        var adj = wt.adjacentWarTiles;
                        for (int j = adj.Count - 1; j >= 0; j--)
                        {
                            var nb = adj[j];
                            if (!IsLiveTile(nb) || !nb.gameObject.activeInHierarchy)
                            {
                                adj.RemoveAt(j);
                                continue;
                            }
                            var nbTd = TileDataOf(nb);
                            if (nbTd != null && nbTd.IsDisabled)
                                adj.RemoveAt(j);
                        }
                    }
                }
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
        public static bool ScenarioStarted { get; set; }

        private static readonly HashSet<int> _phaseStartPlayerIds = new HashSet<int>();
        private static readonly HashSet<int> _phaseStartEnemyIds = new HashSet<int>();

        private static void SnapshotPhaseStartTokens()
        {
            _phaseStartPlayerIds.Clear();
            _phaseStartEnemyIds.Clear();
            var mgr = TokenMgr() ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            var list = mgr != null ? mgr.GetWarTokens() : null;
            if (list == null) return;
            for (int i = 0; i < list.Count; i++)
            {
                var tok = list[i];
                if (tok == null || tok.Pointer == IntPtr.Zero || tok.IsDead() || IsCityToken(tok)) continue;
                int id = tok.GetInstanceID();
                var alleg = tok.GetTokenAllegiance();
                if (alleg == WarToken.WarAllegiance.Player) _phaseStartPlayerIds.Add(id);
                else if (alleg == WarToken.WarAllegiance.Enemy) _phaseStartEnemyIds.Add(id);
            }
            MelonLogger.Msg($"[ZTABLE] Snapshotted phase start tokens: Player={_phaseStartPlayerIds.Count}, Enemy={_phaseStartEnemyIds.Count}");
        }

        public static void CaptureZillePhaseCasualties()
        {
            if (_phaseStartPlayerIds.Count == 0 && _phaseStartEnemyIds.Count == 0) return;
            var mgr = TokenMgr() ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            var aliveIds = new HashSet<int>();
            var list = mgr != null ? mgr.GetWarTokens() : null;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var tok = list[i];
                    if (tok == null || tok.Pointer == IntPtr.Zero || tok.IsDead()) continue;
                    aliveIds.Add(tok.GetInstanceID());
                }
            }
            int pLost = 0;
            foreach (int id in _phaseStartPlayerIds) if (!aliveIds.Contains(id)) pLost++;
            int eLost = 0;
            foreach (int id in _phaseStartEnemyIds) if (!aliveIds.Contains(id)) eLost++;
            ZilleCampaignState.RecordZilleLosses(ZilleCampaignState.CurrentPhaseNumber, pLost, eLost);
        }

        /// <summary>The Pales Start button calls OnInitialDeploymentFinished. After that, deployment rules stop.</summary>
        public static void MarkOperationBegun()
        {
            ScenarioStarted = true;
            _enemyTurnActive = false;
            _enemyTurnObserved = false;
            _enemySince = 0f;
            _pointsGranted = false;
            try
            {
                if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (_tokenMgr != null) _tokenMgr.SetAllTokenActions();
            }
            catch { }
            SnapshotPhaseStartTokens();
            RefreshBoard();
            EnsurePlayerActionsPanelVisible();
        }

        private static void ApplyVariantOnLiveBoard()
        {
            if (_root == null) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;

            _liveTiles = null;
            _tilesAdopted = false;
            _roadsSig = null;
            _citySpawned.Clear();
            _cityLabelsApplied = false;
            _captionCache.Clear();
            _nextCaptionScan = 0f;
            _nextCityTry = 0f;
            _garrisonsPlaced = false;

            // Clear tokens sitting on tiles that are now disabled in this variant
            var tm = TokenMgr();
            foreach (var td in cfg.Tiles)
            {
                if (td == null || !td.IsDisabled) continue;
                var wt = FindLiveTile(td.TileNumber);
                if (wt == null) continue;
                try
                {
                    var tok = wt.GetCurrentToken();
                    if (tok != null)
                    {
                        wt.SetCurrentWarToken(null);
                        if (tm != null) tm.DestroyToken(tok);
                        else UnityEngine.Object.Destroy(tok.gameObject);
                    }
                }
                catch { }
            }

            foreach (var tb in _tiles.Values)
            {
                if (tb != null)
                {
                    tb.AdjApplied = false;
                    tb.PaintSig = null;
                    tb.PushedSig = null;
                }
            }

            int t = ApplyTiles(_root);
            _tilesAdopted = false;
            AdoptGameTiles();
            EnsureCityTokens();
            ApplyCityLabels(true);
            if (!ScenarioStarted)
                EnsureEnemyGarrisons();
            DrawSupplyLines();
            RefreshBoard();
            MelonLogger.Msg($"[ZTABLE] Live variant applied ({ZilleCampaignState.CurrentVariant}): {t} tiles updated.");
        }

        public static void InvalidateLiveTiles()
        {
            foreach (var tb in _tiles.Values) tb.PushedSig = null;
            _roadsSig = null;
            _variantDirty = true;
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
            if (m != null && m.HasProperty("_Opacity")) m.SetFloat("_Opacity", 1f);
        }

        private struct PalesWash
        {
            public bool Ok;
            public Color Tile, Gradient;
            public bool GradientOn, GradientClear, Pulse;
        }

        private struct PalesEdge
        {
            public bool Ok;
            public Color Color;
            public bool On, Gradient, Pulse;
        }

        private static bool _palesColorsRead;
        private static bool _colorAttempted;
        private static PalesWash _washDeploy, _washRefund, _washFriendly, _washEnemy, _washSea, _washBattle, _washBlocked, _washSelected;
        private static PalesEdge _edgeHover, _edgeBattle, _edgeMove, _edgePlain;

        /// <summary>Reads the wash and outline colours serialized on the Pales tile manager. The states below are the ones that manager already names.</summary>
        private static void CachePalesColors()
        {
            if (_palesColorsRead) return;
            var mgr = TileMgr();
            if (mgr != null)
            {
                try
                {
                    _washDeploy = FromWash(mgr.deploymentBackgroundColor);
                    _washRefund = FromWash(mgr.refundableBackgroundColor);
                    _washFriendly = FromWash(mgr.friendlyBackgroundColor);
                    _washEnemy = FromWash(mgr.enemyBackgroundColor);
                    _washSea = FromWash(mgr.emptySeaBackgroundColor);
                    _washBattle = FromWash(mgr.battleBackgroundColor);
                    _washBlocked = FromWash(mgr.notInteractableBackgroundColor);
                    _washSelected = FromWash(mgr.selectedBackgroundColor);
                    _edgeHover = FromEdge(mgr.highlightedOutlineColor);
                    _edgeBattle = FromEdge(mgr.battleOutlineColor);
                    _edgeMove = FromEdge(mgr.selectedOutlineColor);
                    _edgePlain = FromEdge(mgr.defaultOutlineColor);
                    _palesColorsRead = _washDeploy.Ok && _washFriendly.Ok && _washEnemy.Ok;
                    if (_palesColorsRead)
                    {
                        if (_washBattle.Ok)
                        {
                            _washBattle.Tile = new Color(_washBattle.Tile.r, _washBattle.Tile.g, _washBattle.Tile.b, Mathf.Max(_washBattle.Tile.a, 0.28f));
                            _washBattle.Gradient = new Color(_washBattle.Gradient.r, _washBattle.Gradient.g, _washBattle.Gradient.b, Mathf.Max(_washBattle.Gradient.a, 0.35f));
                        }
                        if (_edgeBattle.Ok)
                        {
                            _edgeBattle.Color = new Color(_edgeBattle.Color.r, _edgeBattle.Color.g, _edgeBattle.Color.b, Mathf.Max(_edgeBattle.Color.a, 1.0f));
                            _edgeBattle.On = true;
                        }
                        MelonLogger.Msg($"[ZTABLE] Edge colors cached: battle=({_edgeBattle.Color.r:0.00},{_edgeBattle.Color.g:0.00},{_edgeBattle.Color.b:0.00},{_edgeBattle.Color.a:0.00},pulse={_edgeBattle.Pulse},grad={_edgeBattle.Gradient}) move=({_edgeMove.Color.r:0.00},{_edgeMove.Color.g:0.00},{_edgeMove.Color.b:0.00},{_edgeMove.Color.a:0.00},pulse={_edgeMove.Pulse},grad={_edgeMove.Gradient})");
                        if (_washEnemy.Ok)
                        {
                            _washEnemy.Tile = new Color(_washEnemy.Tile.r, _washEnemy.Tile.g, _washEnemy.Tile.b, 0.20f);
                            _washEnemy.Gradient = new Color(_washEnemy.Gradient.r, _washEnemy.Gradient.g, _washEnemy.Gradient.b, 0.22f);
                        }
                        if (_washFriendly.Ok)
                        {
                            _washFriendly.Tile = new Color(_washFriendly.Tile.r, _washFriendly.Tile.g, _washFriendly.Tile.b, 0.18f);
                            _washFriendly.Gradient = new Color(_washFriendly.Gradient.r, _washFriendly.Gradient.g, _washFriendly.Gradient.b, 0.20f);
                        }
                        MelonLogger.Msg("[ZTABLE] Province colours taken from the Pales tile manager. Friendly " + _washFriendly.Tile + ", enemy " + _washEnemy.Tile + ", sea " + _washSea.Tile + ".");
                        RefreshBoard();
                    }
                }
                catch { }
            }

            if (!_palesColorsRead)
            {
                // Fallback palette matching Rizia, Wehlen and sea
                _washFriendly = new PalesWash { Ok = true, Tile = new Color(0.85f, 0.72f, 0.42f, 0.25f), Gradient = new Color(0.9f, 0.8f, 0.5f, 0.3f), GradientOn = true };
                _washEnemy = new PalesWash { Ok = true, Tile = new Color(0.72f, 0.25f, 0.25f, 0.25f), Gradient = new Color(0.8f, 0.3f, 0.3f, 0.3f), GradientOn = true };
                _washSea = new PalesWash { Ok = true, Tile = new Color(0.18f, 0.35f, 0.48f, 0.25f), Gradient = new Color(0.2f, 0.4f, 0.5f, 0.3f), GradientOn = true };
                _washDeploy = new PalesWash { Ok = true, Tile = new Color(0.3f, 0.8f, 0.3f, 0.35f), Gradient = new Color(0.4f, 0.9f, 0.4f, 0.4f), GradientOn = true };
                _washRefund = new PalesWash { Ok = true, Tile = new Color(0.8f, 0.2f, 0.2f, 0.35f), Gradient = new Color(0.9f, 0.3f, 0.3f, 0.4f), GradientOn = true };
                _washSelected = new PalesWash { Ok = true, Tile = new Color(0.95f, 0.85f, 0.3f, 0.4f), Gradient = new Color(1.0f, 0.9f, 0.4f, 0.5f), GradientOn = true };
                _washBlocked = new PalesWash { Ok = true, Tile = new Color(0.3f, 0.3f, 0.3f, 0.15f), Gradient = new Color(0.4f, 0.4f, 0.4f, 0.15f) };
                _washBattle = new PalesWash { Ok = true, Tile = new Color(0.9f, 0.1f, 0.1f, 0.15f), Gradient = new Color(1.0f, 0.2f, 0.2f, 0.2f) };
                _edgeHover = new PalesEdge { Ok = true, On = true, Color = new Color(1f, 1f, 0.8f, 0.8f) };
                _edgeBattle = new PalesEdge { Ok = true, On = true, Color = new Color(1f, 0.2f, 0.2f, 0.8f) };
                _edgeMove = new PalesEdge { Ok = true, On = true, Color = new Color(0.4f, 0.9f, 0.4f, 0.8f) };
                _edgePlain = new PalesEdge { Ok = true, On = false, Color = new Color(0.5f, 0.5f, 0.5f, 0.2f) };
                _palesColorsRead = true;
            }
        }

        private static PalesWash FromWash(WarTileManager.WarTileBackgroundColor src)
        {
            return new PalesWash
            {
                Ok = true,
                Tile = src.tileColor,
                Gradient = src.gradientColor,
                GradientOn = src.gradientToggle,
                GradientClear = src.gradientIsTransparent,
                Pulse = src.gradientPulseToggle
            };
        }

        private static PalesEdge FromEdge(WarTileManager.WarTileOutlineColor src)
        {
            return new PalesEdge
            {
                Ok = true,
                Color = src.outlineColor,
                On = src.outlineToggle,
                Gradient = src.outlineGradientToggle,
                Pulse = src.outlineGradientPulseToggle
            };
        }

        private static WarTileManager _tileMgr;
        private static float _nextFindTileTime;

        private static WarTileManager TileMgr()
        {
            if (_tileMgr != null && _tileMgr.gameObject != null) return _tileMgr;
            if (Time.unscaledTime < _nextFindTileTime) return null;
            _nextFindTileTime = Time.unscaledTime + 1.0f;
            try { _tileMgr = UnityEngine.Object.FindObjectOfType<WarTileManager>(); } catch { }
            return _tileMgr;
        }

        private static void TintTile(WarTile wt, ZilleTileData td)
        {
            CachePalesColors();
            SyncOwnership(wt, td);
            var rend = wt.GetWarTileRenderer();
            if (rend == null) return;
            if (!_palesColorsRead)
            {
                var mgr = TileMgr();
                if (mgr != null)
                    try { mgr.SetTileColor(rend, wt.GetCurrentToken(), wt); } catch { }
                return;
            }
            TileBackup tb = null;
            _tiles.TryGetValue(wt.GetInstanceID(), out tb);
            var m = tb != null && tb.Instance != null ? tb.Instance : rend.material;
            if (tb != null && tb.Instance == null) tb.Instance = m;
            if (m == null || !m.HasProperty("_Tile_Colour")) return;
            bool deploying = !ScenarioStarted && DeploymentPanelOpen();
            var token = wt.GetCurrentToken();
            bool occupied = token != null;
            bool fighting = IsMainFight(wt);
            bool hovered = wt == _hoverTile;
            bool anyAttention = _hoverTile != null || SelectedUnit() != null;

            PalesWash wash;
            PalesEdge edge = _edgePlain;
            edge.On = false;
            // Deployment colours are chosen below. This branch used to paint every naval-start sea
            // orange and return, so a ship never turned illegal water the refund red and a land unit
            // never left the sea the sea colour.
            if (td.IsSea && !fighting && !deploying)
            {
                if (occupied && token.GetTokenAllegiance() == WarToken.WarAllegiance.Player)
                    wash = _washFriendly;
                else if (occupied && token.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy)
                    wash = _washEnemy;
                else
                    wash = _washSea;
                if (CanMoveOnto(wt) && _edgeMove.Ok)
                {
                    edge = _edgeMove;
                    edge.On = true;
                }
                if (hovered && _edgeHover.Ok)
                {
                    edge = _edgeHover;
                    edge.On = true;
                }
            }
            else if (fighting)
            {
                wash = _washBattle;
                if (_edgeBattle.Ok)
                {
                    edge = _edgeBattle;
                    edge.Color = new Color(edge.Color.r, edge.Color.g, edge.Color.b, Mathf.Max(edge.Color.a, 1.0f));
                    edge.On = true;
                }
            }
            else if (deploying)
            {
                // The whole board follows the unit chosen in the list. Hover never changes the fill,
                // or the game's hover painter leaves one province orange after the cursor leaves.
                var pick = DeploymentPick();
                bool landDrop = !td.IsSea && !td.IsCity && (td.Allegiance == "Rizia" || td.Allegiance == "Derdia");
                bool shipDrop = td.IsSea && td.IsNavalStart;
                // Enemy land stays the default grey. Sea stays sea-coloured. Only a picked-up
                // player unit is the refund red, and only a legal drop is orange.
                if (occupied && token.GetTokenAllegiance() == WarToken.WarAllegiance.Player)
                    wash = _washRefund;
                else if (pick == DeployKind.Land && landDrop)
                    wash = _washDeploy;
                else if (pick == DeployKind.Naval && shipDrop)
                    wash = _washDeploy;
                else if (td.IsSea)
                    wash = _washSea;
                else if (td.Allegiance == "Rizia" || td.Allegiance == "Derdia")
                    wash = _washFriendly;
                else if (td.Allegiance == "Wehlen")
                    wash = _washEnemy;
                else
                    wash = _washBlocked;
                if (occupied && anyAttention && token.GetTokenAllegiance() != WarToken.WarAllegiance.Enemy)
                {
                    edge = _edgeHover.Ok ? _edgeHover : new PalesEdge { Ok = true, On = true };
                    edge.Color = Color.white;
                    edge.On = true;
                    edge.Gradient = false;
                    edge.Pulse = false;
                }
                if (hovered && _edgeHover.Ok)
                {
                    edge = _edgeHover;
                    edge.On = true;
                }
            }
            else
            {
                if (td.IsSea)
                {
                    if (token != null && token.GetTokenAllegiance() == WarToken.WarAllegiance.Player) wash = _washFriendly;
                    else if (token != null && token.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy) wash = _washEnemy;
                    else wash = _washSea;
                }
                else if (token != null && token.GetTokenAllegiance() == WarToken.WarAllegiance.Player)
                {
                    wash = _washFriendly;
                    if (td.Allegiance != "Rizia")
                    {
                        td.Allegiance = "Rizia";
                        wt.SetTileAllegiance(WarToken.WarAllegiance.Player, false);
                    }
                }
                else if (token != null && token.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy)
                {
                    wash = _washEnemy;
                    if (td.Allegiance != "Wehlen" && !td.IsImpassable)
                    {
                        td.Allegiance = "Wehlen";
                        wt.SetTileAllegiance(WarToken.WarAllegiance.Enemy, false);
                    }
                }
                else if (td.Allegiance == "Rizia" || td.Allegiance == "Derdia") wash = _washFriendly;
                else if (td.Allegiance == "Wehlen") wash = _washEnemy;
                else wash = _washBlocked;
                if (CanMoveOnto(wt) && _edgeMove.Ok)
                {
                    edge = _edgeMove;
                    edge.On = true;
                    if (!_moveEdgeLogged)
                    {
                        _moveEdgeLogged = true;
                        MelonLogger.Msg("[ZTABLE] Move range outline on " + wt.gameObject.name + ".");
                    }
                }
                if (hovered && _edgeHover.Ok)
                {
                    edge = _edgeHover;
                    edge.On = true;
                }
            }
            if (occupied && _washSelected.Ok && token == SelectedUnit())
                wash = _washSelected;
            else if (!deploying && !fighting && CanMoveOnto(wt))
            {
                var sel = SelectedUnit();
                if (sel != null && sel.GetTokenAllegiance() == WarToken.WarAllegiance.Player && !sel.IsMovementLocked())
                {
                    wash.Tile = new Color(
                        Mathf.Lerp(wash.Tile.r, 1f, 0.28f),
                        Mathf.Lerp(wash.Tile.g, 1f, 0.28f),
                        Mathf.Lerp(wash.Tile.b, 1f, 0.28f),
                        Mathf.Max(wash.Tile.a, 0.28f));
                    if (wash.GradientOn)
                    {
                        wash.Gradient = new Color(
                            Mathf.Lerp(wash.Gradient.r, 1f, 0.28f),
                            Mathf.Lerp(wash.Gradient.g, 1f, 0.28f),
                            Mathf.Lerp(wash.Gradient.b, 1f, 0.28f),
                            Mathf.Max(wash.Gradient.a, 0.28f));
                    }
                }
            }
            WriteWash(m, wash);
            WriteEdge(m, edge);
            if (m.HasProperty("_Highlight_Toggle")) m.SetFloat("_Highlight_Toggle", 0f);
        }

        private enum DeployKind { None, Land, Naval }

        /// <summary>Which side-list unit is armed. Empty until the player clicks one, so legal provinces stay grey or sea-coloured.</summary>
        private static DeployKind DeploymentPick()
        {
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (panel == null || !panel.IsShowing() || !panel.IsDeploymentUnitSelected()) return DeployKind.None;
                var ut = panel.GetSelectedUnitTypeData();
                if (ut == null) return DeployKind.None;
                if (ut.unitType == WarUnitTypeData.UnitType.NavalUnit) return DeployKind.Naval;
                if (ut.unitType == WarUnitTypeData.UnitType.LandUnit) return DeployKind.Land;
                return DeployKind.None;
            }
            catch { return DeployKind.None; }
        }

        private static string DeployPaintKey()
        {
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (panel == null || !panel.IsDeploymentUnitSelected()) return "none";
                var ut = panel.GetSelectedUnitTypeData();
                return ut == null ? "none" : ut.unitType + ":" + ut.GetInstanceID();
            }
            catch { return "none"; }
        }

        /// <summary>Rewrites every deployment province after the game's own hover paint, so a colour cannot stick to the cursor.</summary>
        private static void RepaintDeployment()
        {
            if (!DeploymentPanelOpen() || _tiles.Count == 0) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;
            foreach (var tb in _tiles.Values)
            {
                if (tb?.Tile == null) continue;
                var td = DataForTile(tb.Tile, cfg);
                if (td != null) TintTile(tb.Tile, td);
            }
        }

        private static ZilleTileData DataForTile(WarTile wt, ZilleMapConfig cfg)
        {
            string name = wt.gameObject != null ? wt.gameObject.name : "";
            if (name.StartsWith("Tile_", StringComparison.Ordinal)) name = name.Substring(5);
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                if (td != null && td.TileNumber == name) return td;
            }
            return null;
        }

        private static bool DeploymentPanelOpen()
        {
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                return panel != null && panel.IsShowing();
            }
            catch { return false; }
        }

        /// <summary>A player unit sitting on the board during deployment can be picked back up. Cities cannot.</summary>
        public static bool IsDeploymentRefund(WarTile tile)
        {
            if (!DeploymentPanelOpen() || tile == null) return false;
            WarToken token = null;
            try { token = tile.GetCurrentToken(); } catch { return false; }
            if (token == null || CityToken(token)) return false;
            try { return token.GetTokenAllegiance() == WarToken.WarAllegiance.Player; }
            catch { return false; }
        }

        private static bool CityToken(WarToken token)
        {
            if (token == null) return false;
            try
            {
                var ut = token.GetWarUnitTypeData();
                return ut != null && ut.unitType == WarUnitTypeData.UnitType.City;
            }
            catch { return false; }
        }

        private static int _selFrame = -1;
        private static WarToken _selCache;
        private static WarTokenManager _tokenMgr;
        private static float _nextFindTokenTime;

        public static WarTokenManager TokenMgr()
        {
            if (_tokenMgr != null && _tokenMgr.gameObject != null) return _tokenMgr;
            if (Time.unscaledTime < _nextFindTokenTime) return null;
            _nextFindTokenTime = Time.unscaledTime + 1.0f;
            try { _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>(); } catch { }
            return _tokenMgr;
        }

        public static WarToken SelectedUnit()
        {
            int frame = Time.frameCount;
            if (_selFrame == frame) return _selCache;
            _selFrame = frame;
            _selCache = null;
            try
            {
                var tm = TokenMgr();
                var sel = tm != null ? tm.GetSelectedWarToken() : null;
                if (sel != null)
                {
                    var ut = sel.GetWarUnitTypeData();
                    if (ut != null && ut.unitType == WarUnitTypeData.UnitType.City) sel = null;
                }
                _selCache = sel;
                return sel;
            }
            catch { return null; }
        }

        /// <summary>The province belongs to whoever is standing on it. A city marker does not capture land.</summary>
        private static void SyncOwnership(WarTile wt, ZilleTileData td)
        {
            if (wt == null || td == null || td.IsSea) return;
            WarToken tok = null;
            try { tok = wt.GetCurrentToken(); } catch { return; }
            if (tok == null) return;
            try
            {
                var ut = tok.GetWarUnitTypeData();
                if (ut != null && ut.unitType == WarUnitTypeData.UnitType.City) return;
                var alleg = tok.GetTokenAllegiance();
                if (alleg != WarToken.WarAllegiance.Player && alleg != WarToken.WarAllegiance.Enemy) return;
                string want = alleg == WarToken.WarAllegiance.Player ? "Rizia" : "Wehlen";
                if (td.Allegiance == want) return;
                td.Allegiance = want;
                wt.SetTileAllegiance(alleg, false);
            }
            catch { }
        }

        /// <summary>Supporters sit next to a fight. Only the attacker and the defender turn the province red, and only while both are still in it.</summary>
        private static bool IsMainFight(WarTile wt)
        {
            if (wt == null) return false;
            try
            {
                var battle = wt.GetCurrentBattle();
                if (BattleLive(battle) && (battle.IsTileMainBelligerentTile(wt)
                    || (battle.attacker != null && !battle.attacker.IsDead() && battle.attacker.GetCurrentWarTile() == wt)
                    || (battle.defender != null && !battle.defender.IsDead() && battle.defender.GetCurrentWarTile() == wt)))
                    return true;

                var tok = wt.GetCurrentToken();
                if (tok != null && !tok.IsDead())
                {
                    var tb = tok.GetCurrentBattle();
                    if (BattleLive(tb) && (tb.IsTileMainBelligerentTile(wt)
                        || (tb.attacker != null && !tb.attacker.IsDead() && tb.attacker.GetCurrentWarTile() == wt)
                        || (tb.defender != null && !tb.defender.IsDead() && tb.defender.GetCurrentWarTile() == wt)))
                        return true;
                }

                var bm = BattleMgr();
                var battles = bm != null ? bm.GetCurrentBattles() : null;
                if (battles != null)
                {
                    for (int i = 0; i < battles.Count; i++)
                    {
                        var b = battles[i];
                        if (!BattleLive(b)) continue;
                        if (b.IsTileMainBelligerentTile(wt)
                            || (b.attacker != null && !b.attacker.IsDead() && b.attacker.GetCurrentWarTile() == wt)
                            || (b.defender != null && !b.defender.IsDead() && b.defender.GetCurrentWarTile() == wt))
                            return true;
                    }
                }
                return false;
            }
            catch { return false; }
        }

        private static string BattlePaintSig()
        {
            try
            {
                var bm = BattleMgr();
                var battles = bm != null ? bm.GetCurrentBattles() : null;
                if (battles == null || battles.Count == 0) return "";
                var sb = new System.Text.StringBuilder();
                for (int i = 0; i < battles.Count; i++)
                {
                    var b = battles[i];
                    if (!BattleLive(b)) continue;
                    var at = b.attacker != null ? b.attacker.GetCurrentWarTile() : null;
                    var dt = b.defender != null ? b.defender.GetCurrentWarTile() : null;
                    sb.Append(at != null ? at.GetInstanceID() : 0).Append(':').Append(dt != null ? dt.GetInstanceID() : 0).Append(';');
                }
                return sb.ToString();
            }
            catch { return ""; }
        }

        /// <summary>A fight is live until vanilla marks isBattleOver true.</summary>
        public static bool BattleLive(WarBattleManager.WarBattle battle)
        {
            if (battle == null) return false;
            try
            {
                if (battle.isBattleOver) return false;
                if (battle.attacker == null || battle.defender == null) return false;
                if (battle.attacker.IsDead() || battle.defender.IsDead()) return false;
                return true;
            }
            catch { return false; }
        }

        /// <summary>Hovering a friendly unit is Support only while that unit is still in a fight. A finished battle must not keep the prompt.</summary>
        public static bool LiveSupport(WarTile tile)
        {
            if (BattleLive(BattleOn(tile))) return true;
            var sel = SelectedUnit();
            WarTile selTile = null;
            try { selTile = sel != null ? sel.GetCurrentWarTile() : null; } catch { }
            if (BattleLive(BattleOn(selTile))) return true;
            WarToken token = null;
            try { token = tile != null ? tile.GetCurrentToken() : null; } catch { }
            WarTile tokenTile = null;
            try { tokenTile = token != null ? token.GetCurrentWarTile() : null; } catch { }
            return BattleLive(BattleOn(tokenTile));
        }

        private static WarBattleManager.WarBattle BattleOn(WarTile tile)
        {
            if (tile == null) return null;
            try { return tile.GetCurrentBattle(); }
            catch { return null; }
        }

        private static WarBattleManager.WarBattle BattleInvolvingTile(WarTile tile)
        {
            if (tile == null) return null;
            var direct = BattleOn(tile);
            if (BattleLive(direct)) return direct;
            try
            {
                var tok = tile.GetCurrentToken();
                if (tok == null) return null;
                var bm = BattleMgr();
                var battles = bm != null ? bm.GetCurrentBattles() : null;
                if (battles == null) return null;
                for (int i = 0; i < battles.Count; i++)
                {
                    var b = battles[i];
                    if (b == null || b.isBattleOver || !BattleLive(b)) continue;
                    if (b.attacker == tok || b.defender == tok) return b;
                    if (b.attackersSupporters != null)
                        for (int s = 0; s < b.attackersSupporters.Count; s++)
                            if (b.attackersSupporters[s] == tok) return b;
                    if (b.defendersSupporters != null)
                        for (int s = 0; s < b.defendersSupporters.Count; s++)
                            if (b.defendersSupporters[s] == tok) return b;
                }
            }
            catch { }
            return null;
        }

        public static bool FortifyArmed { get; private set; }

        public static void ArmFortify() => FortifyArmed = true;

        public static void ClearFortify() => FortifyArmed = false;

        private static PalesWash DerdiaWash()
        {
            return _washFriendly;
        }

        public static bool IsImpassableTile(WarTile wt)
        {
            var td = TileDataOf(wt);
            return td != null && td.IsImpassable;
        }

        public static bool CanMoveOnto(WarTile wt)
        {
            if (IsImpassableTile(wt)) return false;
            var sel = SelectedUnit();
            if (sel == null || wt == null) return false;
            try
            {
                var occ = Occupant(wt);
                if (occ != null && occ != sel && !CanOverrun(sel, occ)) return false;
                if (wt.IsTileSelectedTokensTile()) return false;
                var ut = sel.GetWarUnitTypeData();
                if (ut == null) return false;
                if (!ut.CanMoveToTileType(wt.GetTileType())) return false;
                if (ut.unitType != WarUnitTypeData.UnitType.NavalUnit && CanFastMoveOnRoad(sel, wt))
                    return true;
                int range = ut.unitType == WarUnitTypeData.UnitType.NavalUnit ? 2 : 1;
                var start = sel.GetCurrentWarTile();
                return IsWithinTileRange(start, wt, range, ut);
            }
            catch { return false; }
        }

        private static bool IsWithinTileRange(WarTile start, WarTile target, int maxRange, WarUnitTypeData ut)
        {
            if (start == null || target == null || start == target || maxRange <= 0) return false;
            if (maxRange == 1)
            {
                var adj = start.adjacentWarTiles;
                if (adj != null && adj.Contains(target)) return true;
                var adjT = target.adjacentWarTiles;
                if (adjT != null && adjT.Contains(start)) return true;
                return target.IsTileAdjacentToSelectedToken(1);
            }
            var visited = new HashSet<int> { start.GetInstanceID() };
            var queue = new Queue<(WarTile tile, int dist)>();
            queue.Enqueue((start, 0));
            while (queue.Count > 0)
            {
                var (cur, d) = queue.Dequeue();
                if (d >= maxRange) continue;
                var adj = cur.adjacentWarTiles;
                if (adj == null) continue;
                for (int i = 0; i < adj.Count; i++)
                {
                    var nb = adj[i];
                    if (nb == null) continue;
                    if (nb == target) return true;
                    int id = nb.GetInstanceID();
                    if (visited.Contains(id)) continue;
                    if (IsImpassableTile(nb)) continue;
                    if (ut != null && !ut.CanMoveToTileType(nb.GetTileType())) continue;
                    visited.Add(id);
                    queue.Enqueue((nb, d + 1));
                }
            }
            return target.IsTileAdjacentToSelectedToken(maxRange);
        }

        private static HashSet<string> ComputeSuppliedTileIds(string allegiance)
        {
            var supplied = new HashSet<string>();
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || string.IsNullOrEmpty(allegiance)) return supplied;

            var byId = new Dictionary<string, ZilleTileData>();
            var queue = new Queue<ZilleTileData>();
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var t = cfg.Tiles[i];
                if (t == null || string.IsNullOrEmpty(t.Id)) continue;
                byId[t.Id] = t;
            }

            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var t = cfg.Tiles[i];
                if (t == null || t.IsDisabled || t.IsImpassable || t.IsSea) continue;
                if (t.Allegiance != allegiance) continue;
                if (!t.IsSupplyHub && !t.IsCity && !t.IsPort) continue;
                var wt = !string.IsNullOrEmpty(t.TileNumber) ? FindLiveTile(t.TileNumber) : null;
                if (wt != null && wt.isSupplyLineConnectionBroken) continue;
                if (supplied.Add(t.Id)) queue.Enqueue(t);
            }

            while (queue.Count > 0)
            {
                var cur = queue.Dequeue();
                if (cur.RoadToIds == null) continue;
                for (int i = 0; i < cur.RoadToIds.Count; i++)
                {
                    string nbId = cur.RoadToIds[i];
                    if (string.IsNullOrEmpty(nbId) || supplied.Contains(nbId)) continue;
                    if (!byId.TryGetValue(nbId, out var nb) || nb == null) continue;
                    if (nb.IsDisabled || nb.IsImpassable || nb.IsSea) continue;
                    if (nb.Allegiance != allegiance) continue;
                    var wtNb = !string.IsNullOrEmpty(nb.TileNumber) ? FindLiveTile(nb.TileNumber) : null;
                    if (wtNb != null && wtNb.isSupplyLineConnectionBroken) continue;
                    supplied.Add(nbId);
                    queue.Enqueue(nb);
                }
            }
            return supplied;
        }

        public static bool IsTileSuppliedForAllegiance(WarTile wt, string allegiance)
        {
            if (wt == null || string.IsNullOrEmpty(allegiance)) return false;
            var td = TileDataOf(wt);
            if (td == null || string.IsNullOrEmpty(td.Id)) return false;
            if (td.RoadToIds == null || td.RoadToIds.Count == 0) return false;
            return ComputeSuppliedTileIds(allegiance).Contains(td.Id);
        }

        public static bool IsTileSuppliedForCurrentAllegiance(WarTile wt)
        {
            if (wt == null) return false;
            var td = TileDataOf(wt);
            if (td == null) return false;
            string alleg = td.Allegiance;
            if (alleg != "Rizia" && alleg != "Wehlen") return false;
            return IsTileSuppliedForAllegiance(wt, alleg);
        }

        public static bool IsTileConnectedOnSupplyLine(WarSupplyLine supplyLine, WarTile tile, bool checkAll)
        {
            if (tile == null) return false;
            if (!checkAll && supplyLine != null && supplyLine.Tiles != null)
            {
                bool inLine = false;
                for (int i = 0; i < supplyLine.Tiles.Count; i++)
                {
                    if (supplyLine.Tiles[i] == tile) { inLine = true; break; }
                }
                if (!inLine) return false;
            }
            return IsTileSuppliedForCurrentAllegiance(tile);
        }

        public static bool CanFastMoveOnRoad(WarToken token, WarTile targetTile)
        {
            if (token == null || targetTile == null) return false;
            try
            {
                if (token.IsDead() || token.IsMovementLocked()) return false;
                var ut = token.GetWarUnitTypeData();
                if (ut == null || ut.unitType == WarUnitTypeData.UnitType.NavalUnit) return false;
                if (!ut.CanMoveToTileType(targetTile.GetTileType())) return false;

                var startTile = token.GetCurrentWarTile();
                if (startTile == null || startTile == targetTile) return false;

                var startTd = TileDataOf(startTile);
                var targetTd = TileDataOf(targetTile);
                if (startTd == null || targetTd == null) return false;
                if (startTd.RoadToIds == null || targetTd.RoadToIds == null) return false;

                string alleg = token.GetTokenAllegiance() == WarToken.WarAllegiance.Player ? "Rizia" : "Wehlen";
                var supplied = ComputeSuppliedTileIds(alleg);
                if (!supplied.Contains(startTd.Id) || !supplied.Contains(targetTd.Id)) return false;

                var occTarget = Occupant(targetTile);
                if (occTarget != null && occTarget != token && !CanOverrun(token, occTarget)) return false;

                var cfg = ZilleMapLayoutManager.CurrentConfig;
                if (cfg?.Tiles == null) return false;
                var byId = new Dictionary<string, ZilleTileData>();
                for (int i = 0; i < cfg.Tiles.Count; i++)
                {
                    var t = cfg.Tiles[i];
                    if (t != null && !string.IsNullOrEmpty(t.Id)) byId[t.Id] = t;
                }

                // 1-step or 2-step along connected road edges through friendly supplied tiles
                for (int i = 0; i < startTd.RoadToIds.Count; i++)
                {
                    string midId = startTd.RoadToIds[i];
                    if (midId == targetTd.Id) return true;
                    if (!supplied.Contains(midId)) continue;
                    if (!byId.TryGetValue(midId, out var midTd) || midTd == null || midTd.RoadToIds == null) continue;
                    var midWt = !string.IsNullOrEmpty(midTd.TileNumber) ? FindLiveTile(midTd.TileNumber) : null;
                    if (midWt != null)
                    {
                        var midOcc = Occupant(midWt);
                        if (midOcc != null && midOcc.GetTokenAllegiance() != token.GetTokenAllegiance()) continue;
                    }
                    if (midTd.RoadToIds.Contains(targetTd.Id)) return true;
                }
            }
            catch { }
            return false;
        }

        public static bool IsCityToken(WarToken tok)
        {
            if (tok == null) return false;
            try { if (tok.IsCity()) return true; } catch { }
            try { if (IsCityUnit(tok.GetWarUnitTypeData())) return true; } catch { }
            try
            {
                var tile = tok.GetCurrentWarTile();
                var td = TileDataOf(tile);
                if (td != null && td.IsCity) return true;
            }
            catch { }
            return false;
        }

        /// <summary>A bombed or overrun enemy is not holding the province. Entering it plays their fall. Cities can never be overrun.</summary>
        public static bool CanOverrun(WarToken mover, WarToken occupier)
        {
            if (mover == null || occupier == null || occupier == mover) return false;
            if (IsCityToken(occupier)) return false;
            try
            {
                if (occupier.GetTokenAllegiance() == mover.GetTokenAllegiance()) return false;
                if (occupier.IsDead() || occupier.IsBombed() || occupier.IsOrganizationDepleted() || IsOverrun(occupier)) return true;
                var effects = occupier.currentTokenStatusEffects;
                if (effects == null) return false;
                for (int i = 0; i < effects.Count; i++)
                {
                    var effect = effects[i];
                    if (effect == WarToken.WarTokenStatusEffectType.Bombed
                        || effect == WarToken.WarTokenStatusEffectType.DepletedOrganization)
                        return true;
                }
            }
            catch { }
            return false;
        }

        public static bool IsOverrun(WarToken token)
        {
            if (token == null) return false;
            try
            {
                if (token.IsOrganizationDepleted()) return true;
                var effects = token.currentTokenStatusEffects;
                if (effects != null)
                {
                    for (int i = 0; i < effects.Count; i++)
                    {
                        if (effects[i] == WarToken.WarTokenStatusEffectType.DepletedOrganization)
                            return true;
                    }
                }
            }
            catch { }
            return false;
        }

        public static bool CanReachTile(WarToken sel, WarTile target)
        {
            if (sel == null || target == null) return false;
            try
            {
                var ut = sel.GetWarUnitTypeData();
                if (ut == null) return false;
                if (!ut.CanMoveToTileType(target.GetTileType())) return false;
                int range = ut.unitType == WarUnitTypeData.UnitType.NavalUnit ? 2 : 1;
                return IsWithinTileRange(sel.GetCurrentWarTile(), target, range, ut);
            }
            catch { return false; }
        }

        /// <summary>The figure the province is actually holding, including one the tile pointer lost after a fight.</summary>
        private static WarToken Occupant(WarTile tile)
        {
            if (tile == null) return null;
            WarToken occ = null;
            try { occ = tile.GetCurrentToken(); } catch { }
            try { if (occ != null && occ.IsDead()) occ = null; } catch { }
            if (occ != null) return occ;
            return Claimant(tile, null);
        }

        /// <summary>A living unit whose own tile is this province, even when the province no longer points back at them.</summary>
        private static WarToken Claimant(WarTile tile, WarToken ignore)
        {
            if (tile == null) return null;
            try
            {
                if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                var tokens = _tokenMgr != null ? _tokenMgr.GetWarTokens() : null;
                if (tokens == null) return null;
                for (int i = 0; i < tokens.Count; i++)
                {
                    var token = tokens[i];
                    if (token == null || token == ignore) continue;
                    try
                    {
                        if (token.IsDead()) continue;
                        if (token.GetCurrentWarTile() == tile) return token;
                    }
                    catch { }
                }
            }
            catch { }
            return null;
        }

        /// <summary>Deployment does not spend action points. A move, attack or strike does, and zero means the turn is over.</summary>
        public static bool TurnHasPoints()
        {
            if (!ScenarioStarted || DeploymentPanelOpen()) return true;
            try
            {
                var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                return flow == null || flow.GetCurrentActionPoints() > 0;
            }
            catch { return true; }
        }

        /// <summary>Wehlen land is a touch more transparent than Rizian land, so the two washes do not read as the same solid.</summary>
        private static float EnemyLandOpacity(ZilleTileData td)
        {
            if (td != null && !td.IsSea && td.Allegiance == "Wehlen") return 0.82f;
            return 1f;
        }

        private static readonly int _propTileColour = Shader.PropertyToID("_Tile_Colour");
        private static readonly int _propGradientToggle = Shader.PropertyToID("_Gradient_Toggle");
        private static readonly int _propGradientIsTransparent = Shader.PropertyToID("_Gradient_Is_Transparent");
        private static readonly int _propGradientColour = Shader.PropertyToID("_Gradient_Colour");
        private static readonly int _propGradientPulseToggle = Shader.PropertyToID("_Gradient_Pulse_Toggle");
        private static readonly int _propOutlineToggle = Shader.PropertyToID("_Outline_Toggle");
        private static readonly int _propOutlineColour = Shader.PropertyToID("_Outline_Colour");
        private static readonly int _propOutlineGradientToggle = Shader.PropertyToID("_Outline_Gradient_Toggle");
        private static readonly int _propOutlineGradientPulseToggle = Shader.PropertyToID("_Outline_Gradient_Pulse_Toggle");
        private static readonly int _propHighlightToggle = Shader.PropertyToID("_Highlight_Toggle");

        private static void WriteWash(Material m, PalesWash wash)
        {
            if (!wash.Ok) return;
            m.SetColor(_propTileColour, wash.Tile);
            SetFlag(m, _propGradientToggle, wash.GradientOn);
            SetFlag(m, _propGradientIsTransparent, wash.GradientClear);
            m.SetColor(_propGradientColour, wash.Gradient);
            SetFlag(m, _propGradientPulseToggle, wash.Pulse);
        }

        private static void WriteEdge(Material m, PalesEdge edge)
        {
            SetFlag(m, _propOutlineToggle, edge.Ok && edge.On);
            if (edge.Ok) m.SetColor(_propOutlineColour, edge.Color);
            SetFlag(m, _propOutlineGradientToggle, edge.Ok && edge.Gradient);
            SetFlag(m, _propOutlineGradientPulseToggle, edge.Ok && edge.Pulse);
        }

        private static void SetFlag(Material m, int propId, bool on)
        {
            m.SetFloat(propId, on ? 1f : 0f);
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

        private static readonly Dictionary<string, WarUnitTypeData> _matchedUnits = new Dictionary<string, WarUnitTypeData>();
        private static readonly HashSet<string> _unmatchedLogged = new HashSet<string>();

        /// <summary>
        /// Maps a v13 deployment id onto a real WarUnitTypeData. Specific kinds are matched before plain infantry.
        /// A miss is logged once and that entry is skipped. There is no silent fallback to infantry.
        /// </summary>
        public static WarUnitTypeData MatchDeploymentUnit(string unitId, IList<WarUnitTypeData> extra)
        {
            if (string.IsNullOrEmpty(unitId)) return null;
            if (_matchedUnits.TryGetValue(unitId, out var cached) && cached != null) return cached;
            if (!DeploymentRule(unitId, out var needles, out var avoid, out bool naval)) return null;

            var pool = new List<WarUnitTypeData>();
            var seen = new HashSet<string>();
            void Take(WarUnitTypeData u)
            {
                if (u == null || string.IsNullOrEmpty(u.name) || !seen.Add(u.name)) return;
                pool.Add(u);
            }
            if (extra != null)
                for (int i = 0; i < extra.Count; i++) Take(extra[i]);
            var known = UnitTypes();
            for (int i = 0; i < known.Count; i++) Take(known[i]);
            if (pool.Count == 0) return null;

            WarUnitTypeData found = null;
            for (int i = 0; i < pool.Count; i++)
            {
                var u = pool[i];
                if (naval && u.unitType != WarUnitTypeData.UnitType.NavalUnit) continue;
                if (!naval && u.unitType != WarUnitTypeData.UnitType.LandUnit) continue;
                string blob = UnitBlob(u);
                bool blocked = false;
                for (int a = 0; a < avoid.Length; a++)
                    if (blob.Contains(avoid[a])) { blocked = true; break; }
                if (blocked) continue;
                for (int n = 0; n < needles.Length; n++)
                {
                    if (!blob.Contains(needles[n])) continue;
                    found = u;
                    break;
                }
                if (found != null) break;
            }
            if (found == null)
            {
                if (_unmatchedLogged.Add(unitId))
                    MelonLogger.Warning("[ZilleMap] Unit type '" + unitId + "' has no WarUnitTypeData equivalent; those entries were skipped.");
                return null;
            }
            _matchedUnits[unitId] = found;
            MelonLogger.Msg("[ZilleMap] Unit type '" + unitId + "' -> '" + found.name + "' (" + UnitLabel(found) + ", " + found.unitType + ").");
            return found;
        }

        private static string UnitBlob(WarUnitTypeData u)
        {
            string unitName = "";
            string proper = "";
            try { unitName = u.unitName ?? ""; } catch { }
            try { proper = u.UnitName ?? ""; } catch { }
            string kind = "";
            try { kind = u.unitType.ToString(); } catch { }
            return (u.name + " " + unitName + " " + proper + " " + kind).ToLowerInvariant();
        }

        private static bool DeploymentRule(string unitId, out string[] needles, out string[] avoid, out bool naval)
        {
            avoid = Array.Empty<string>();
            naval = false;
            switch (unitId)
            {
                case "mountain_infantry":
                    needles = new[] { "mountain", "alpine", "highland" };
                    return true;
                case "mechanized_infantry":
                    needles = new[] { "mechan", "motor", "apc", "support", "infantry" };
                    avoid = new[] { "mountain", "militia", "para" };
                    return true;
                case "paratroopers":
                    needles = new[] { "paratroop", "airborne", "para" };
                    return true;
                case "militia":
                    needles = new[] { "militia", "irregular", "partisan" };
                    return true;
                case "tanks":
                    needles = new[] { "tank", "panzer", "armor", "armour" };
                    avoid = new[] { "infantry", "anti" };
                    return true;
                case "submarine":
                    needles = new[] { "submarine", "u-boat", "uboat" };
                    naval = true;
                    return true;
                case "destroyer":
                    needles = new[] { "destroyer", "militaryship", "ship" };
                    avoid = new[] { "submarine", "flagship" };
                    naval = true;
                    return true;
                case "flagship":
                    needles = new[] { "flagship", "battleship", "dreadnought" };
                    naval = true;
                    return true;
                case "infantry":
                    needles = new[] { "infantry" };
                    avoid = new[] { "mountain", "mechan", "motor", "para", "militia" };
                    return true;
                default:
                    needles = Array.Empty<string>();
                    return false;
            }
        }

        public static void QueueDeployment(Il2CppSystem.Collections.Generic.List<WarTokenData> tokens, IList<WarUnitTypeData> pool)
        {
            ZilleDeployment.RefreshFromCampaign();
            if (tokens == null) return;
            int queued = 0;
            var seen = new HashSet<string>();
            for (int i = 0; i < ZilleDeployment.Units.Count; i++)
            {
                var entry = ZilleDeployment.Units[i];
                if (entry == null || string.IsNullOrEmpty(entry.TileNumber) || !seen.Add(entry.TileNumber)) continue;
                var ut = MatchDeploymentUnit(entry.UnitType, pool);
                if (ut == null) continue;
                var tok = new WarTokenData();
                tok.startingTileName = entry.TileNumber;
                tok.guid = "wehlen_" + entry.UnitType + "_" + entry.TileNumber;
                tok.allegiance = WarToken.WarAllegiance.Enemy;
                tok.unitType = ut;
                tokens.Add(tok);
                queued++;
            }
            MelonLogger.Msg("[WAR ENGINE] Wehlen deployment '" + ZilleDeployment.Preset + "': " + queued + " tokens queued.");
        }

        /// <summary>
        /// Puts a unit on a live province. DeployToken is what the deployment box uses.
        /// SpawnWarToken is the story-script path, used when deployment is already closed.
        /// </summary>
        /// <summary>
        /// Ensure tile has standard BoxCollider matching vanilla Pales so WarTileRaycaster detects it flawlessly.
        /// </summary>
        private static void EnsureTileCollider(WarTile wt)
        {
            if (wt == null) return;
            // Clean up any custom MeshColliders that disrupt PhysX raycasts
            var meshes = wt.GetComponentsInChildren<MeshCollider>(true);
            if (meshes != null)
            {
                for (int i = 0; i < meshes.Length; i++)
                    if (meshes[i] != null) UnityEngine.Object.Destroy(meshes[i]);
            }

            // Ensure BoxCollider exists and is sized to prevent adjacent overlaps
            var box = wt.GetComponent<BoxCollider>();
            if (box == null) box = wt.gameObject.AddComponent<BoxCollider>();
            box.size = new Vector3(0.92f, 0.92f, 0.2f);
            box.center = Vector3.zero;
            box.enabled = true;

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
                if (ray != null)
                {
                    try
                    {
                        int mask = ray.raycastLayerMask.value;
                        if (mask != 0 && mask != ~0)
                        {
                            for (int i = 0; i < 32; i++)
                            {
                                if ((mask & (1 << i)) != 0) { _raycastLayer = i; break; }
                            }
                        }
                    }
                    catch { }
                }
                if (_raycastLayer < 0)
                {
                    var sample = UnityEngine.GameObject.Find("Tile_1");
                    if (sample != null) _raycastLayer = sample.layer;
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
            if (_root == null || _tilesAdopted) return;
            var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
            if (mgr == null) return;
            // Il2Cpp exposes the private list as a property. AccessTools.Field never finds it, which left the list empty.
            var list = mgr.allTiles;
            if (list == null)
            {
                list = new Il2CppSystem.Collections.Generic.List<WarTile>();
                mgr.allTiles = list;
            }
            SanitizeTileManagerAndAdjacencies(mgr);
            var tiles = _root.GetComponentsInChildren<WarTile>(true);
            var have = new HashSet<int>();
            for (int j = 0; j < list.Count; j++)
                if (IsLiveTile(list[j])) have.Add(list[j].GetInstanceID());
            int added = 0;
            for (int i = 0; i < tiles.Length; i++)
            {
                var wt = tiles[i];
                if (!IsLiveTile(wt) || !wt.gameObject.activeInHierarchy) continue;
                int id = wt.GetInstanceID();
                if (!have.Add(id)) continue;
                list.Add(wt);
                added++;
            }
            int want = 0;
            var cfgTiles = ZilleMapLayoutManager.CurrentConfig?.Tiles;
            if (cfgTiles != null)
            {
                for (int i = 0; i < cfgTiles.Count; i++)
                    if (cfgTiles[i] != null && !cfgTiles[i].IsDisabled) want++;
            }
            if (want > 0 && list.Count >= want)
            {
                _tilesAdopted = true;
                MelonLogger.Msg("[ZTABLE] Pales tile manager now owns " + list.Count + " Zille provinces (hover, hold to deploy, refund).");
            }
            else if (added > 0 && _warnedMissing.Add("adopt-partial"))
                MelonLogger.Msg("[ZTABLE] Registered " + added + " provinces on the tile manager (" + list.Count + " so far).");
            RebuildLiveTileCache();
        }

        private static bool _clutterHidden;

        /// <summary>The figurine box and headphones sit on the map. The deployment menu is the side panel, so these props go away.</summary>
        private static void HideTableClutter()
        {
            if (_clutterHidden) return;
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
                RunScripted(() => mgr.DeployToken(ut, wt, WarToken.WarAllegiance.Player));
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

        public struct UnitLedgerSnapshot
        {
            public bool Active;
            public WarUnitTypeData Unit;
            public int Total, Deployed, Dead, OnMission;
        }

        public static UnitLedgerSnapshot CaptureEnemyLedger(WarUnitTypeData ut, WarToken.WarAllegiance allegiance)
        {
            if (ut == null || allegiance != WarToken.WarAllegiance.Enemy) return default;
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !SkinEnabled) return default;
            try
            {
                return new UnitLedgerSnapshot
                {
                    Active = true,
                    Unit = ut,
                    Total = ut.UnitTotalCount,
                    Deployed = ut.UnitDeployedCount,
                    Dead = ut.UnitDeadCount,
                    OnMission = ut.UnitOnMissionCount
                };
            }
            catch { return default; }
        }

        public static void RestoreEnemyLedger(UnitLedgerSnapshot snap)
        {
            if (!snap.Active || snap.Unit == null) return;
            try
            {
                if (snap.Unit.UnitTotalCount != snap.Total) snap.Unit.UnitTotalCount = snap.Total;
                if (snap.Unit.UnitDeployedCount != snap.Deployed) snap.Unit.UnitDeployedCount = snap.Deployed;
                if (snap.Unit.UnitDeadCount != snap.Dead) snap.Unit.UnitDeadCount = snap.Dead;
                if (snap.Unit.UnitOnMissionCount != snap.OnMission) snap.Unit.UnitOnMissionCount = snap.OnMission;
            }
            catch { }
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
                    var snap = enemy ? CaptureEnemyLedger(ut, WarToken.WarAllegiance.Enemy) : default;
                    RunScripted(() => mgr.DeployToken(ut, wt, alleg));
                    // Enemy garrisons share the unit asset with the player's pool. Put every ledger counter back.
                    RestoreEnemyLedger(snap);
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
                if (td.IsDisabled) continue;
                if (!ZilleMapLayoutManager.IsScenarioCity(td.Name)) continue;
                td.IsCity = true;
                if (string.IsNullOrEmpty(td.TileNumber) || _citySpawned.Contains(td.TileNumber)) continue;
                bool enemy = td.Allegiance != "Rizia";
                var city = enemy ? (enemyCity ?? playerCity) : (playerCity ?? enemyCity);
                string msg = PlaceUnit(td, city, enemy);
                if (!msg.StartsWith("Postawiono"))
                {
                    _nextCityTry = Time.unscaledTime + 0.5f;
                    return;
                }
                _citySpawned.Add(td.TileNumber);
                _cityLabels[td.TileNumber] = CityCaption(td);
                MelonLogger.Msg("[ZTABLE] City: " + msg);
            }
        }

        private static readonly Dictionary<string, string> _cityLabels = new Dictionary<string, string>();

        /// <summary>The star label is the city unit's own name. Arces is only the template, so rewrite it to the city.</summary>
        private static float _nextCaptionScan;
        private static readonly List<Il2CppTMPro.TMP_Text> _captionCache = new List<Il2CppTMPro.TMP_Text>();

        private static string CityCaption(ZilleTileData td)
        {
            if (td == null) return "";
            return !string.IsNullOrEmpty(td.CityName) ? td.CityName : (td.Name ?? "");
        }

        private static bool _cityLabelsApplied = false;

        private static void ApplyCityLabels(bool force = false)
        {
            if (_cityLabelsApplied && !force) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;
            if (Time.unscaledTime >= _nextCaptionScan)
            {
                _nextCaptionScan = Time.unscaledTime + 2.0f;
                _captionCache.Clear();
                Il2CppTMPro.TMP_Text[] all = null;
                try { all = UnityEngine.Object.FindObjectsOfType<Il2CppTMPro.TMP_Text>(); } catch { return; }
                if (all == null) return;
                for (int i = 0; i < all.Length; i++)
                {
                    var label = all[i];
                    if (label == null || !CaptionBelongsToCity(label, cfg)) continue;
                    _captionCache.Add(label);
                }
            }
            int updated = 0;
            for (int i = 0; i < _captionCache.Count; i++)
            {
                var label = _captionCache[i];
                if (label == null) continue;
                string want = CaptionForLabel(label, cfg);
                if (string.IsNullOrEmpty(want) || label.text == want) continue;
                label.text = want;
                updated++;
            }
            try
            {
                var indicators = UnityEngine.Object.FindObjectsOfType<TemplateWarObjectiveIndicator>();
                if (indicators != null)
                {
                    for (int i = 0; i < indicators.Length; i++)
                    {
                        var ind = indicators[i];
                        if (ind == null) continue;
                        var tok = ind.CurrentCityToken;
                        var tile = tok != null ? tok.GetCurrentWarTile() : null;
                        DialogueInjectionPatches.UpdateObjectiveIndicatorTitle(ind, tok, tile);
                    }
                }
            }
            catch { }
            if (_captionCache.Count > 0)
                _cityLabelsApplied = true;
        }

        private static bool CaptionBelongsToCity(Il2CppTMPro.TMP_Text label, ZilleMapConfig cfg)
        {
            string cur = label.text ?? "";
            bool template = cur.IndexOf("Arces", StringComparison.OrdinalIgnoreCase) >= 0
                || cur.StartsWith("Capture", StringComparison.OrdinalIgnoreCase);
            if (!template && !IsCityCaption(cur, cfg)) return false;
            var canvas = label.canvas;
            if (canvas != null && canvas.renderMode != RenderMode.WorldSpace && !template)
            {
                WarToken parent = null;
                try { parent = label.GetComponentInParent<WarToken>(); } catch { }
                if (parent == null) return false;
            }
            return !string.IsNullOrEmpty(CaptionForLabel(label, cfg));
        }

        private static string CaptionForLabel(Il2CppTMPro.TMP_Text label, ZilleMapConfig cfg)
        {
            WarToken tok = null;
            try { tok = label.GetComponentInParent<WarToken>(); } catch { }
            if (tok != null)
            {
                try
                {
                    if (tok.IsCity())
                    {
                        var td = TileDataOf(tok.GetCurrentWarTile());
                        if (td != null && td.IsCity) return CityCaption(td);
                    }
                }
                catch { }
            }
            string world = CaptionFor(label.transform.position, cfg);
            if (!string.IsNullOrEmpty(world)) return world;
            return CaptionOnScreen(label, cfg);
        }

        /// <summary>The nameplate is a screen-space label floating above the star, not a child of the province.</summary>
        private static string CaptionOnScreen(Il2CppTMPro.TMP_Text label, ZilleMapConfig cfg)
        {
            Camera cam = null;
            try { cam = Camera.main; } catch { return null; }
            if (cam == null) return null;
            Vector3 sp = label.transform.position;
            string best = null;
            float bestD = 90f * 90f;
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                if (td == null || !td.IsCity) continue;
                var live = FindLiveTile(td.TileNumber);
                if (live == null) continue;
                Vector3 w = cam.WorldToScreenPoint(live.transform.position);
                if (w.z < 0f) continue;
                float dx = w.x - sp.x;
                float dy = w.y - sp.y;
                float d = dx * dx + dy * dy;
                if (d >= bestD) continue;
                bestD = d;
                best = CityCaption(td);
            }
            return best;
        }

        private static bool IsCityCaption(string cur, ZilleMapConfig cfg)
        {
            if (string.IsNullOrEmpty(cur)) return false;
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                if (td == null || !td.IsCity) continue;
                string name = CityCaption(td);
                if (name.Length > 0 && string.Equals(cur, name, StringComparison.Ordinal)) return true;
            }
            return false;
        }

        private static string CaptionFor(Vector3 pos, ZilleMapConfig cfg)
        {
            string best = null;
            float bestD = 1.4f * 1.4f;
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                if (td == null || !td.IsCity) continue;
                var live = FindLiveTile(td.TileNumber);
                if (live == null) continue;
                float d = (live.transform.position - pos).sqrMagnitude;
                if (d >= bestD) continue;
                bestD = d;
                best = CityCaption(td);
            }
            return best;
        }

        private static string _roadsSig;

        /// <summary>Pales draws a road as a supply line on the table, not as a mesh we invent.</summary>
        public static Il2CppSystem.Collections.Generic.List<WarSupplyLine> BuildSupplyLines()
        {
            var lines = new Il2CppSystem.Collections.Generic.List<WarSupplyLine>();
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return lines;
            var byId = new Dictionary<string, ZilleTileData>();
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var tile = cfg.Tiles[i];
                if (tile != null && !string.IsNullOrEmpty(tile.Id)) byId[tile.Id] = tile;
            }
            var seen = new HashSet<string>();
            foreach (var t in cfg.Tiles)
            {
                if (t == null || t.IsDisabled || t.IsImpassable || t.IsSea) continue;
                if (t.RoadToIds == null || string.IsNullOrEmpty(t.TileNumber)) continue;
                foreach (var id in t.RoadToIds)
                {
                    string key = string.CompareOrdinal(t.Id, id) < 0 ? t.Id + "|" + id : id + "|" + t.Id;
                    if (!seen.Add(key)) continue;
                    if (!byId.TryGetValue(id, out var other) || other == null) continue;
                    if (other.IsDisabled || other.IsImpassable || other.IsSea || string.IsNullOrEmpty(other.TileNumber)) continue;
                    var line = new WarSupplyLine();
                    line.tileNames = new Il2CppSystem.Collections.Generic.List<string>();
                    line.tileNames.Add(t.TileNumber);
                    line.tileNames.Add(other.TileNumber);
                    lines.Add(line);
                }
            }
            return lines;
        }

        private static void ClearManagerSupplyLines(WarSupplyLineManager mgr)
        {
            if (mgr == null) return;
            try
            {
                var inst = mgr.instantiatedMapLines;
                if (inst != null)
                {
                    for (int i = inst.Count - 1; i >= 0; i--)
                    {
                        var l = inst[i];
                        if (l != null && l.gameObject != null)
                            UnityEngine.Object.Destroy(l.gameObject);
                    }
                    inst.Clear();
                }
            }
            catch { }
            try
            {
                var container = mgr.mapLineContainer;
                var tmpl = mgr.templateMapLine;
                if (container != null)
                {
                    for (int i = container.childCount - 1; i >= 0; i--)
                    {
                        var ch = container.GetChild(i);
                        if (ch == null) continue;
                        if (tmpl != null && ch.gameObject == tmpl.gameObject) continue;
                        UnityEngine.Object.Destroy(ch.gameObject);
                    }
                }
            }
            catch { }
        }

        private static void DrawSupplyLines()
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || _root == null) return;
            var byId = new Dictionary<string, ZilleTileData>();
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var tile = cfg.Tiles[i];
                if (tile != null && !string.IsNullOrEmpty(tile.Id)) byId[tile.Id] = tile;
            }
            var sb = new StringBuilder();
            sb.Append(ZilleCampaignState.CurrentVariant).Append(':');
            foreach (var t in cfg.Tiles)
            {
                if (t == null || t.IsDisabled || t.IsImpassable || t.IsSea || t.RoadToIds == null) continue;
                foreach (var id in t.RoadToIds)
                {
                    if (!byId.TryGetValue(id, out var other) || other == null || other.IsDisabled || other.IsImpassable || other.IsSea) continue;
                    if (string.CompareOrdinal(t.Id, id) < 0) sb.Append(t.Id).Append('>').Append(id).Append(';');
                }
            }
            string sig = sb.ToString();
            if (sig == _roadsSig) return;
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
            ClearManagerSupplyLines(mgr);
            var lines = BuildSupplyLines();
            int ready = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                var line = lines[i];
                if (line?.tileNames == null || line.tileNames.Count < 2) continue;
                var a = FindLiveTile(line.tileNames[0]);
                var b = FindLiveTile(line.tileNames[1]);
                if (a == null || b == null || !a.gameObject.activeInHierarchy || !b.gameObject.activeInHierarchy) continue;
                var pair = new Il2CppSystem.Collections.Generic.List<WarTile>();
                pair.Add(a);
                pair.Add(b);
                line.Tiles = pair;
                ready++;
            }
            if (ready == 0) { _roadsSig = sig; return; }
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
                int shown = PaintLiveSupplyLines(mgr);
                if (shown == 0) shown = DrawWithTemplate(lines);
                _roadsSig = sig;
                MelonLogger.Msg($"[ZTABLE] Pales supply lines on the map: {shown} (active edges: {ready}).");
                return;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] SetupSupplyLines: " + ex.Message);
            }
            DrawWithTemplate(lines);
            _roadsSig = sig;
        }

        /// <summary>The manager's segments stay grey until they take the alignment scroll material. Both province dots stay visible.</summary>
        private static int PaintLiveSupplyLines(WarSupplyLineManager mgr)
        {
            if (mgr == null || mgr.instantiatedMapLines == null) return 0;
            var riziaSupplied = ComputeSuppliedTileIds("Rizia");
            var wehlenSupplied = ComputeSuppliedTileIds("Wehlen");
            int n = 0;
            var list = mgr.instantiatedMapLines;
            for (int i = 0; i < list.Count; i++)
            {
                var line = list[i];
                if (line == null || !line.gameObject.scene.IsValid()) continue;
                WarSupplyLine supply = null;
                try { supply = line.GetCurrentSupplyLine(); } catch { }
                if (supply == null || supply.Tiles == null || supply.Tiles.Count < 2) continue;
                if (!line.gameObject.activeSelf) line.gameObject.SetActive(true);
                PaintSupplyLineVisual(line.gameObject, supply.Tiles[0], supply.Tiles[1], riziaSupplied, wehlenSupplied);
                n++;
            }
            return n;
        }

        private static TemplateMapLineSection.SupplyLineSectionAlignmentState SegmentAlignment(
            WarTile a, WarTile b, HashSet<string> riziaSupplied, HashSet<string> wehlenSupplied)
        {
            var tdA = TileDataOf(a);
            var tdB = TileDataOf(b);
            if (tdA != null && tdB != null)
            {
                if (riziaSupplied.Contains(tdA.Id) && riziaSupplied.Contains(tdB.Id))
                    return TemplateMapLineSection.SupplyLineSectionAlignmentState.Player;
                if (wehlenSupplied.Contains(tdA.Id) && wehlenSupplied.Contains(tdB.Id))
                    return TemplateMapLineSection.SupplyLineSectionAlignmentState.Enemy;
            }
            return TemplateMapLineSection.SupplyLineSectionAlignmentState.Inactive;
        }

        private static bool IsRoadEndpointOrHub(ZilleTileData td)
        {
            if (td == null) return false;
            return td.IsSupplyHub || td.IsCity || td.IsPort || (td.RoadToIds != null && td.RoadToIds.Count <= 1);
        }

        private static void PaintSupplyLineVisual(
            GameObject holder, WarTile a, WarTile b, HashSet<string> riziaSupplied, HashSet<string> wehlenSupplied)
        {
            if (holder == null) return;
            var state = SegmentAlignment(a, b, riziaSupplied, wehlenSupplied);
            var tdA = TileDataOf(a);
            var tdB = TileDataOf(b);
            bool startOrigin = IsRoadEndpointOrHub(tdA);
            bool endOrigin = IsRoadEndpointOrHub(tdB);
            var sections = holder.GetComponentsInChildren<TemplateMapLineSection>(true);
            for (int i = 0; i < sections.Length; i++)
            {
                var section = sections[i];
                if (section == null) continue;
                try { section.ApplyMapLineSettings(state); } catch { }
                EnableSectionDots(section, a, b, startOrigin, endOrigin, state);
            }
        }

        private static void ApplyDotSettings(
            MeshRenderer dot, WarTile tile, TemplateMapLineSection.MapLineSettings settings, bool isOrigin)
        {
            if (dot == null) return;
            if (!dot.gameObject.activeSelf) dot.gameObject.SetActive(true);
            dot.enabled = true;
            if (tile != null)
            {
                var tp = tile.transform.position;
                dot.transform.position = new Vector3(tp.x, tp.y + 0.008f, tp.z);
                dot.gameObject.layer = tile.gameObject.layer;
            }
            if (settings == null) return;
            float w = isOrigin ? settings.originDotWidth : settings.dotWidth;
            if (w <= 0.0001f) w = isOrigin ? 0.032f : 0.018f;
            dot.transform.localScale = new Vector3(w, w, w);
            Texture2D tex = isOrigin ? settings.originOpacityMap : settings.opacityMap;
            var mat = dot.material;
            if (tex != null && mat != null && mat.HasProperty(TemplateMapLineSection.dotOpacityMapReference))
                mat.SetTexture(TemplateMapLineSection.dotOpacityMapReference, tex);
        }

        private static void EnableSectionDots(
            TemplateMapLineSection section,
            WarTile a,
            WarTile b,
            bool startOrigin = false,
            bool endOrigin = false,
            TemplateMapLineSection.SupplyLineSectionAlignmentState state = TemplateMapLineSection.SupplyLineSectionAlignmentState.Player)
        {
            if (section == null) return;
            try
            {
                if (section.lineRenderer != null && a != null && b != null)
                {
                    var pa = a.transform.position;
                    var pb = b.transform.position;
                    section.lineRenderer.SetPosition(0, new Vector3(pa.x, pa.y + 0.005f, pa.z));
                    section.lineRenderer.SetPosition(1, new Vector3(pb.x, pb.y + 0.005f, pb.z));
                }
                TemplateMapLineSection.MapLineSettings settings = null;
                try { settings = section.GetMapLineSettings(state); } catch { }
                ApplyDotSettings(section.startDotMeshRenderer, a, settings, startOrigin);
                ApplyDotSettings(section.endDotMeshRenderer, b, settings, endOrigin);
            }
            catch { }
        }

        public static void UpdateSupplyStatesAndRoadVisuals()
        {
            try
            {
                var riziaSupplied = ComputeSuppliedTileIds("Rizia");
                var wehlenSupplied = ComputeSuppliedTileIds("Wehlen");

                foreach (var tb in _tiles.Values)
                {
                    var wt = tb != null ? tb.Tile : null;
                    if (wt == null) continue;
                    var td = TileDataOf(wt);
                    if (td == null) continue;
                    bool hasRoad = td.RoadToIds != null && td.RoadToIds.Count > 0;
                    bool supplied = hasRoad && (
                        (td.Allegiance == "Rizia" && riziaSupplied.Contains(td.Id)) ||
                        (td.Allegiance == "Wehlen" && wehlenSupplied.Contains(td.Id)));
                    try { wt.SetSuppliedState(supplied); } catch { }
                }

                var mgr = UnityEngine.Object.FindObjectOfType<WarSupplyLineManager>();
                if (mgr != null && mgr.instantiatedMapLines != null)
                {
                    var list = mgr.instantiatedMapLines;
                    for (int i = 0; i < list.Count; i++)
                    {
                        var line = list[i];
                        if (line == null || !line.gameObject.scene.IsValid()) continue;
                        var supply = line.GetCurrentSupplyLine();
                        if (supply?.Tiles == null || supply.Tiles.Count < 2) continue;
                        PaintSupplyLineVisual(line.gameObject, supply.Tiles[0], supply.Tiles[1], riziaSupplied, wehlenSupplied);
                    }
                }

                if (_root != null)
                {
                    var holder = _root.Find("ZilleSupplyLines");
                    if (holder != null)
                    {
                        var mapLines = holder.GetComponentsInChildren<TemplateMapLine>(true);
                        for (int i = 0; i < mapLines.Length; i++)
                        {
                            var ml = mapLines[i];
                            if (ml == null) continue;
                            var supply = ml.GetCurrentSupplyLine();
                            if (supply?.Tiles == null || supply.Tiles.Count < 2) continue;
                            PaintSupplyLineVisual(ml.gameObject, supply.Tiles[0], supply.Tiles[1], riziaSupplied, wehlenSupplied);
                        }
                    }
                }
            }
            catch { }
        }

        /// <summary>The connection check inserts each tile's supply-line list. A null list aborts every road.</summary>
        private static void EnsureTileSupplyLists()
        {
            WarTile[] tiles = null;
            try { tiles = UnityEngine.Object.FindObjectsOfType<WarTile>(); } catch { return; }
            if (tiles == null) return;
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
                UpdateSupplyStatesAndRoadVisuals();
                MelonLogger.Msg("[ZTABLE] Pales map lines drawn: " + n + ".");
            }
            return n;
        }

        private static bool _linePaintLogged;

        /// <summary>Unconnected roads stay on the grey inactive material. Pales paints a live line in the player/enemy colour, and the shader scrolls that colour.</summary>
        private static void PaintPlayerLines(GameObject holder)
        {
            if (holder == null) return;
            var sections = holder.GetComponentsInChildren<TemplateMapLineSection>(true);
            var state = TemplateMapLineSection.SupplyLineSectionAlignmentState.Player;
            for (int i = 0; i < sections.Length; i++)
            {
                var section = sections[i];
                if (section == null) continue;
                try { section.ApplyMapLineSettings(state); } catch { }
                EnableSectionDots(section, null, null, false, false, state);
            }
        }

        private static bool _framed;
        private static readonly Dictionary<int, (Transform t, Vector3 pos)> _savedVirtualCamPos = new Dictionary<int, (Transform t, Vector3 pos)>();

        /// <summary>The war camera opens on the newspaper. Expand MapCamera bounds for Zille, move virtual cameras over Zille, and frame Tile_35 (Zille City).</summary>
        private static void FrameZille()
        {
            if (_framed || _root == null) return;
            var tile = FindLiveTile("35");
            if (tile == null) return;
            try
            {
                var cam = UnityEngine.Object.FindObjectOfType<MapCamera>();
                Vector3 min = new Vector3(1.72f, -2f, 0.02f);
                Vector3 max = new Vector3(2.25f, 4f, 0.55f);
                var b = new Bounds((min + max) * 0.5f, max - min);
                if (cam != null)
                {
                    try { cam.SetBounds(b); } catch { }
                    try { cam.ToggleCameraCentered(false); } catch { }

                    // Move war CinemachineVirtualCameras from Pales/Morella (~X=1.05, Z=-0.67) to Zille (~Tile_35)
                    Vector3 zilleCamPos = tile.transform.position + new Vector3(-0.27f, 0.77f, -0.58f);
                    var allMb = UnityEngine.Object.FindObjectsOfType<MonoBehaviour>();
                    int movedVcams = 0;
                    if (allMb != null)
                    {
                        for (int i = 0; i < allMb.Length; i++)
                        {
                            var mb = allMb[i];
                            if (mb == null || mb.gameObject == null || !mb.gameObject.scene.IsValid()) continue;
                            string tn = "";
                            try { tn = mb.GetIl2CppType().Name; } catch { continue; }
                            if (!tn.Contains("CinemachineVirtualCamera")) continue;
                            string gName = mb.gameObject.name ?? "";
                            bool isMapVcam = mb.transform.IsChildOf(cam.transform.parent ?? cam.transform)
                                || gName.IndexOf("War", StringComparison.OrdinalIgnoreCase) >= 0
                                || gName.IndexOf("Map", StringComparison.OrdinalIgnoreCase) >= 0
                                || (mb.transform.position.x > 0.7f && mb.transform.position.x < 1.5f && mb.transform.position.z < -0.2f);
                            if (!isMapVcam) continue;
                            int id = mb.transform.GetInstanceID();
                            if (!_savedVirtualCamPos.ContainsKey(id))
                                _savedVirtualCamPos[id] = (mb.transform, mb.transform.position);
                            Vector3 dst = zilleCamPos;
                            if (mb.transform.position.y > 0.3f) dst.y = mb.transform.position.y;
                            MelonLogger.Msg($"[ZTABLE] Moving vcam '{gName}' {mb.transform.position} -> {dst}");
                            mb.transform.position = dst;
                            movedVcams++;
                        }
                    }
                    MelonLogger.Msg($"[ZTABLE] Repositioned {movedVcams} virtual camera(s) to Zille.");
                }
                var scroller = UnityEngine.Object.FindObjectOfType<MapScroller>();
                if (scroller != null)
                {
                    try { scroller.SetBounds(b); } catch { }
                    try { scroller.transform.position = new Vector3(tile.transform.position.x, scroller.transform.position.y, tile.transform.position.z); } catch { }
                    try { scroller.GoToTarget(tile.transform); } catch { }
                }
                var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
                if (mgr != null) mgr.LookAtTile(tile);
                _framed = true;
                MelonLogger.Msg($"[ZTABLE] Camera framed on Zille (MapCamera + MapScroller bounds & vcams moved to Tile_35@{tile.transform.position}).");
            }
            catch (Exception ex)
            {
                _framed = true;
                MelonLogger.Warning("[ZTABLE] Frame: " + ex.Message);
            }
        }

        private static void EnsureZilleCameraBounds()
        {
            if (_root == null) return;
            try
            {
                Vector3 min = new Vector3(1.72f, -2f, 0.02f);
                Vector3 max = new Vector3(2.25f, 4f, 0.55f);
                var b = new Bounds((min + max) * 0.5f, max - min);
                var cam = UnityEngine.Object.FindObjectOfType<MapCamera>();
                if (cam != null) { try { cam.SetBounds(b); } catch { } }
                var scroller = UnityEngine.Object.FindObjectOfType<MapScroller>();
                if (scroller != null) { try { scroller.SetBounds(b); } catch { } }
            }
            catch { }
        }

        public static bool EditMode { get; set; }

        /// <summary>Edit mode keeps the table and the authoring panels, and puts the invasion UI away.</summary>
        public static void SuppressInvasionChrome()
        {
            try
            {
                var deploy = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (deploy != null && deploy.IsShowing()) deploy.Hide();
            }
            catch { }
            try
            {
                var hud = Panels.Instance != null ? Panels.Instance.WarHUDPanel : null;
                if (hud != null && hud.gameObject.activeSelf) hud.Hide();
            }
            catch { }
        }

        public static bool NativeDeploymentOpen()
        {
            if (EditMode) return false;
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
                if (ray.mainCamera == null) ray.mainCamera = cam;
            }
            catch { }
        }

        private static bool _rayInput;
        private static Renderer _lit;
        private static bool _hoverHitLogged;
        private static bool _rayMissLogged;

        private static Vector2 _lastMouse;
        private static bool _haveMouse;

        /// <summary>Lights the province under the cursor using fast physics and vanilla raycaster.</summary>
        private static void HighlightUnderCursor()
        {
            ZilleProfiler.BeginHighlight();
            try
            {
                if (EnemyMayAct())
                {
                    if (_hoverTile != null)
                    {
                        try { _hoverTile.OnTileExit(); } catch { }
                        _hoverTile = null;
                    }
                    HideHoldRing();
                    return;
                }
                var cam = WarCamera();
                if (cam == null) return;
                var pos = CursorPos();
                bool moved = !_haveMouse || (pos - _lastMouse).sqrMagnitude > 1f;
                bool holding = _pressSeen || ButtonHeld() || RightPressed();
                if (!moved && !holding)
                {
                    if (_hoverTile != null)
                        TrackHold(_hoverTile);
                    return;
                }
                _haveMouse = true;
                _lastMouse = pos;
                WarTile tile = ProvinceUnderCursor(cam, pos);
                Renderer next = tile != null ? tile.GetWarTileRenderer() : null;
                if (!_hoverHitLogged && tile != null)
                {
                    _hoverHitLogged = true;
                    MelonLogger.Msg("[ZTABLE] Cursor is over province " + tile.gameObject.name + ".");
                }
                else if (!_hoverHitLogged && !_rayMissLogged && tile == null)
                {
                    _rayMissLogged = true;
                    MelonLogger.Warning("[ZTABLE] No province under the cursor. Camera: " + cam.transform.position + ".");
                }
                var previous = _hoverTile;
                TrackHold(tile);
                if (tile != previous)
                {
                    _hoverTile = tile;
                    if (previous != null) RepaintTile(previous);
                    if (tile != null) RepaintTile(tile);
                    var mgr = TileMgr();
                    if (mgr != null && tile != null)
                        try { mgr.SetHoveredWarTile(tile); } catch { }
                    var hoverBattle = BattleInvolvingTile(tile);
                    try
                    {
                        var bm = BattleMgr();
                        if (bm != null) bm.SetHoveredBattle(hoverBattle);
                    }
                    catch { }
                    SyncBattleStatsUI(hoverBattle);
                    PresentUnitChrome();
                }
                _lit = next;
            }
            finally
            {
                ZilleProfiler.EndHighlight();
            }
        }

        private static WarTile _gameHover;

        /// <summary>HoverRaycast's tile, kept after Update wipes the field. Null when the cursor is not on one of our provinces.</summary>
        public static void NoteGameHover(WarTile tile)
        {
            if (tile != null && (tile.gameObject == null || !_tiles.ContainsKey(tile.GetInstanceID())))
                tile = null;
            _gameHover = tile;
        }

        /// <summary>Pixel-perfect province detection via baked ID grid.</summary>
        public static WarTile FindTileUnderCursor(Camera cam, Vector2 pos)
        {
            return GetProvinceAt(cam, pos);
        }

        /// <summary>The province the game is highlighting. Falls back to baked ID grid if not yet updated.</summary>
        private static WarTile ProvinceUnderCursor(Camera cam, Vector2 pos)
        {
            if (_gameHover != null && _gameHover.gameObject != null && _gameHover.gameObject.activeInHierarchy)
                return _gameHover;

            return GetProvinceAt(cam, pos);
        }

        private static Vector3 _lastCamPos;
        private static Quaternion _lastCamRot;
        private static readonly Dictionary<int, Vector2> _cachedScreenCenters = new Dictionary<int, Vector2>();
        private static readonly Dictionary<int, Vector3> _tileWorldCenters = new Dictionary<int, Vector3>();
        private static float _nextScreenReproject;

        /// <summary>The visible hex is the renderer centre nearest the pointer. Screen positions are cached and only recomputed on camera move.</summary>
        private static WarTile TileUnderPointer(Camera cam, Vector2 pos)
        {
            if (cam == null || _tiles.Count == 0) return null;

            bool camMoved = (cam.transform.position - _lastCamPos).sqrMagnitude > 0.01f
                         || Quaternion.Angle(cam.transform.rotation, _lastCamRot) > 0.2f
                         || _cachedScreenCenters.Count != _tiles.Count;

            if (camMoved && Time.unscaledTime >= _nextScreenReproject)
            {
                _nextScreenReproject = Time.unscaledTime + 0.033f;
                _lastCamPos = cam.transform.position;
                _lastCamRot = cam.transform.rotation;
                _cachedScreenCenters.Clear();
                foreach (var kv in _tiles)
                {
                    var tb = kv.Value;
                    var wt = tb != null ? tb.Tile : null;
                    if (wt == null || !wt.gameObject.activeInHierarchy) continue;
                    int id = kv.Key;
                    if (!_tileWorldCenters.TryGetValue(id, out var worldCenter))
                    {
                        var rend = wt.GetWarTileRenderer();
                        worldCenter = rend != null ? rend.bounds.center : wt.transform.position;
                        _tileWorldCenters[id] = worldCenter;
                    }
                    var center = cam.WorldToScreenPoint(worldCenter);
                    if (center.z > 0f)
                    {
                        _cachedScreenCenters[id] = new Vector2(center.x, center.y);
                    }
                }
            }

            WarTile best = null;
            float bestD = 140f * 140f;
            foreach (var kv in _cachedScreenCenters)
            {
                float d = (kv.Value - pos).sqrMagnitude;
                if (d < bestD)
                {
                    if (_tiles.TryGetValue(kv.Key, out var tb) && tb != null && tb.Tile != null)
                    {
                        bestD = d;
                        best = tb.Tile;
                    }
                }
            }
            return best;
        }

        private static int _paintedSel;



        private static void RepaintTile(WarTile wt)
        {
            if (wt == null) return;
            var td = TileDataOf(wt);
            if (td != null) TintTile(wt, td);
        }

        /// <summary>A hover or a click turns the white border on for every province that already holds a unit, not only the one under the cursor.</summary>
        private static void RepaintOccupied()
        {
            foreach (var tb in _tiles.Values)
            {
                var wt = tb.Tile;
                if (wt == null || wt.GetCurrentToken() == null) continue;
                var td = TileDataOf(wt);
                if (td != null) TintTile(wt, td);
            }
        }

        private static readonly Dictionary<int, ZilleTileData> _tileDataCache = new Dictionary<int, ZilleTileData>();
        private static readonly Dictionary<string, ZilleTileData> _tileDataByNum = new Dictionary<string, ZilleTileData>();

        public static void ClearTileDataCache()
        {
            _tileDataCache.Clear();
            _tileDataByNum.Clear();
        }

        public static ZilleTileData TileDataOf(WarTile wt)
        {
            if (wt == null || wt.gameObject == null) return null;
            int id = wt.GetInstanceID();
            if (_tileDataCache.TryGetValue(id, out var cached)) return cached;

            string name = wt.gameObject.name ?? "";
            if (name.StartsWith("Tile_")) name = name.Substring("Tile_".Length);
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return null;

            if (_tileDataByNum.Count == 0)
            {
                for (int i = 0; i < cfg.Tiles.Count; i++)
                {
                    var item = cfg.Tiles[i];
                    if (item != null && !string.IsNullOrEmpty(item.TileNumber))
                        _tileDataByNum[item.TileNumber] = item;
                }
            }

            if (_tileDataByNum.TryGetValue(name, out var data))
            {
                _tileDataCache[id] = data;
                return data;
            }
            return null;
        }

        private static WarTile _hoverTile;
        private static WarTile _heldTile;
        private static float _heldFor;
        private static bool _committed;
        private static bool _pressSeen;
        /// <summary>
        /// A click selects the unit under the cursor, except during deployment. Deploy, move, attack and refund
        /// run only after the mouse has been held for 0.8s, which is also how long the ring takes to fill.
        /// </summary>
        private static void TrackHold(WarTile tile)
        {
            if (EnemyMayAct())
            {
                HideHoldRing();
                _heldTile = null;
                _pressSeen = false;
                _committed = false;
                return;
            }
            if (tile != _hoverTile)
            {
                _hoverTile = tile;
                if (tile != null)
                {
                    HidePromptUnlessLegal(tile);
                }
            }
            if (RightPressed())
            {
                DeselectCurrentUnit();
                return;
            }
            bool down = ButtonHeld();
            // One missed frame used to wipe the clock and turn a hold into a click.
            if (!down && _pressSeen)
            {
                if (_upSince < 0f) _upSince = Time.unscaledTime;
                if (Time.unscaledTime - _upSince < 0.12f) down = true;
            }
            else
                _upSince = -1f;
            // The press edge is easy to miss. A held button is enough to start the clock.
            if (down && !_pressSeen)
            {
                _pressSeen = true;
                _committed = false;
                _holdStartedAt = Time.unscaledTime;
                _heldTile = tile;
                _holdCursor = CursorPos();
            }
            if (!down)
            {
                float elapsed = _pressSeen ? Time.unscaledTime - _holdStartedAt : 0f;
                WarTile released = _heldTile;
                bool tap = _pressSeen && !_committed && released != null && elapsed < HoldSeconds;
                if (elapsed > 0f) HideHoldRing();
                else ClearHoldFill();
                try
                {
                    var ray = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
                    if (ray != null) ray.mouseButtonHoldTimer = 0f;
                }
                catch { }
                _heldTile = null;
                _heldFor = 0f;
                _committed = false;
                _pressSeen = false;
                _upSince = -1f;
                if (tap) SelectTokenOn(released);
                return;
            }
            if (!_pressSeen || _committed) return;
            var cursor = CursorPos();
            // A shaky cursor stays on the province where the hold began. Sliding onto
            // another province, far enough to be deliberate, starts that province's clock.
            if (tile != null && _heldTile != null && tile != _heldTile
                && (cursor - _holdCursor).sqrMagnitude > 50f * 50f)
            {
                _heldTile = tile;
                _holdStartedAt = Time.unscaledTime;
                _holdCursor = cursor;
                HideHoldRing();
            }
            else if (_heldTile == null)
                _heldTile = tile;
            var held = _heldTile;
            if (held == null || !Holdable(held)) return;
            _heldFor = Time.unscaledTime - _holdStartedAt;
            // The ring fills from seconds / WarActionHoldTime, and at 1 it commits and hides the
            // label. Stay under that line until our own clock finishes, or the prompt vanishes early
            // and the action is rejected because the gate is still closed.
            float cap = GameHoldSeconds();
            // A still cursor counts even when one frame's sample misses the province. Leaving
            // and coming back was only forcing that sample to match again.
            bool parked = (cursor - _holdCursor).sqrMagnitude < 48f * 48f;
            WarTile target = tile != null && Holdable(tile) ? tile : held;
            bool finished = _heldFor >= HoldSeconds && target != null && (tile == held || parked);
            float shown = Mathf.Clamp01(_heldFor / HoldSeconds) * cap;
            if (!finished)
            {
                ShowHoldRing(target, shown);
                return;
            }
            _committed = true;
            CommitHeldTile(target);
            HideHoldRing();
            RefreshBoard();
        }

        private static float _holdStartedAt;
        private static float _upSince = -1f;
        private static Vector2 _holdCursor;
        private static WarTileRaycaster _raycaster;
        private static System.Reflection.MethodInfo _submitPressed;

        private static bool ButtonHeld()
        {
            var mouse = UnityEngine.InputSystem.Mouse.current;
            if (mouse != null && (mouse.leftButton.isPressed || mouse.leftButton.wasPressedThisFrame)) return true;
            return LegacyDown(0) || LegacyPressed(0);
        }

        private static bool RightPressed()
        {
            var mouse = UnityEngine.InputSystem.Mouse.current;
            return (mouse != null && mouse.rightButton.wasPressedThisFrame) || LegacyPressed(1);
        }

        private static bool GameSubmitHeld()
        {
            try
            {
                if (_raycaster == null) _raycaster = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
                if (_raycaster == null) return false;
                if (_submitPressed == null)
                    _submitPressed = HarmonyLib.AccessTools.Method(typeof(WarTileRaycaster), "IsSubmitButtonPressed");
                return _submitPressed != null && (bool)_submitPressed.Invoke(_raycaster, null);
            }
            catch { return false; }
        }

        public static Vector2 CursorPos()
        {
            var mouse = UnityEngine.InputSystem.Mouse.current;
            if (mouse != null) return mouse.position.ReadValue();
            return UnityEngine.Input.mousePosition;
        }

        private static bool LegacyDown(int button)
        {
            try { return UnityEngine.Input.GetMouseButton(button); }
            catch { return false; }
        }

        private static bool LegacyPressed(int button)
        {
            try { return UnityEngine.Input.GetMouseButtonDown(button); }
            catch { return false; }
        }

        /// <summary>
        /// The game's own timer fills the ring and then tries to deploy on its own clock.
        /// That attempt is blocked, so the circle closes and the unit stays in the list. Hold the game's
        /// timer at zero until our ring finishes, and paint the ring again after the game has touched it.
        /// </summary>
        private static WarTileRaycaster _cachedRaycaster;

        public static void FreezeGameHold()
        {
            if (!_pressSeen || _committed || _heldFor <= 0f || _heldFor >= HoldSeconds) return;
            try
            {
                if (_cachedRaycaster == null) _cachedRaycaster = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
                if (_cachedRaycaster != null) _cachedRaycaster.mouseButtonHoldTimer = 0f;
            }
            catch { }
            if (_heldTile == null) return;
            float cap = GameHoldSeconds();
            float shown = Mathf.Min(Mathf.Clamp01(_heldFor / HoldSeconds) * cap, cap * 0.98f);
            ShowHoldRing(_heldTile, shown);
        }

        private static float _gameHoldSeconds;

        /// <summary>Seconds the stock ring needs before it treats the hold as finished. Ours still lasts <see cref="HoldSeconds"/>.</summary>
        private static float GameHoldSeconds()
        {
            if (_gameHoldSeconds > 0.05f) return _gameHoldSeconds;
            try
            {
                var ray = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
                var cfg = ray != null ? ray.warConfiguration : null;
                if (cfg != null && cfg.WarActionHoldTime > 0.05f)
                {
                    _gameHoldSeconds = cfg.WarActionHoldTime;
                    MelonLogger.Msg("[ZTABLE] Stock hold is " + _gameHoldSeconds.ToString("0.00") + "s. The ring still fills for " + HoldSeconds.ToString("0.0") + "s.");
                    return _gameHoldSeconds;
                }
            }
            catch (Exception ex)
            {
                if (_warnedMissing.Add("hold-time"))
                    MelonLogger.Warning("[ZTABLE] hold time: " + ex.GetBaseException().Message);
            }
            return HoldSeconds;
        }

        private static void RefreshBoard()
        {
            UpdateSupplyStatesAndRoadVisuals();
            bool canUnlock = ScenarioStarted && !EditMode && !IsEnemyTurnActive();
            foreach (var tb in _tiles.Values)
            {
                var wt = tb.Tile;
                if (wt == null) continue;
                if (canUnlock && !BattleLive(BattleOn(wt)))
                    UnlockTile(wt);
                var td = TileDataOf(wt);
                if (td != null) TintTile(wt, td);
            }
        }


        private static bool _holdRingLogged;

        public const float HoldSeconds = 0.8f;

        /// <summary>True only while a finished hold, or a scripted garrison, is allowed to deploy or move.</summary>
        public static bool CommitAllowed => _commitGate || _scriptedDeploy;

        private static bool _commitGate;
        private static bool _scriptedDeploy;

        public static void RunScripted(Action action)
        {
            if (action == null) return;
            bool prev = _scriptedDeploy;
            _scriptedDeploy = true;
            try { action(); }
            finally { _scriptedDeploy = prev; }
        }

        /// <summary>
        /// The ring has finished and the cursor is still on this province.
        /// Stock deployment only accepts an opening-front tile unless the province is marked
        /// as a reinforcement drop, so a legal hold on the rest of Rizia has to borrow that flag
        /// for the one call that places the unit.
        /// </summary>
        private static void CommitHeldTile(WarTile tile)
        {
            if (tile == null) return;
            _commitGate = true;
            bool armed = false;
            bool wasReinforcement = false;
            try
            {
                var ray = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
                if (ray != null)
                {
                    ray.raycastedWarTile = tile;
                    ray.mouseButtonHoldTimer = 0f;
                }
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (IsDeploymentRefund(tile))
                {
                    RefundDeployedUnit(tile, panel);
                }
                else if (panel != null && panel.IsShowing() && panel.IsDeploymentUnitSelected()
                    && tile.GetCurrentToken() == null && DeploymentTarget(tile))
                {
                    if (!IsZilleFrontTile(tile))
                    {
                        wasReinforcement = tile.IsReinforcementTile();
                        tile.SetIsReinforcementTile(true);
                        armed = true;
                    }
                    var unit = panel.GetSelectedUnitTypeData();
                    if (unit != null)
                    {
                        int beforeDeployed = unit.UnitDeployedCount;
                        int beforeListCount = panel.deployedTokensToTile != null ? panel.deployedTokensToTile.Count : 0;
                        panel.DeployToken(unit, tile);

                        bool deployedByVanilla = unit.UnitDeployedCount > beforeDeployed ||
                            (panel.deployedTokensToTile != null && panel.deployedTokensToTile.Count > beforeListCount);

                        // Direct verification & robust fallback ONLY if vanilla completely failed:
                        if (!deployedByVanilla && tile.GetCurrentToken() == null)
                        {
                            MelonLogger.Msg($"[ZTABLE] Vanilla DeployToken did not place token on {tile.name}. Executing robust fallback deployment...");
                            var tm = TokenMgr();
                            if (tm != null)
                            {
                                tm.DeployToken(unit, tile, WarToken.WarAllegiance.Player);
                            }
                            try
                            {
                                var deployedList = panel.deployedTokensToTile;
                                if (deployedList != null)
                                {
                                    var entry = new WarDeploymentPanel.DeployedTokenToTile();
                                    entry.tile = tile;
                                    entry.unitTypeData = unit;
                                    deployedList.Add(entry);
                                }
                                if (unit.UnitDeployedCount <= beforeDeployed)
                                {
                                    unit.UnitDeployedCount = beforeDeployed + 1;
                                }
                                if (unit.UnitTotalCount > 0) unit.UnitTotalCount = unit.UnitTotalCount - 1;
                                panel.UpdateDeployingUnitCount();
                                if (unit.UnitTotalCount <= 0)
                                {
                                    panel.CancelUnitDeployment();
                                }
                            }
                            catch (Exception ex)
                            {
                                MelonLogger.Warning($"[ZTABLE] Deployed list fallback update: {ex.Message}");
                            }
                        }
                    }
                }
                else if (!TurnHasPoints())
                {
                    MelonLogger.Msg("[ZTABLE] Hold finished on " + tile.gameObject.name + " with no action points left.");
                }
                else
                {
                    var sel = SelectedUnit();
                    var actType = tile.GetTileActionType();
                    var oldTile = sel != null ? sel.GetCurrentWarTile() : null;

                    if (!OverrunFallen(tile))
                    {
                        tile.OnTileEnter();
                        tile.OnTileCommitAction();
                    }

                    // Direct fallback for movement if vanilla tile.OnTileCommitAction didn't move the unit
                    if (actType == WarTile.TileActionType.Move && sel != null && sel.GetCurrentWarTile() != tile)
                    {
                        MelonLogger.Msg($"[ZTABLE] Executing direct movement fallback for {sel.name} -> {tile.name}");
                        try
                        {
                            sel.Move(tile, false);
                            var flow = FlowMgr();
                            if (flow != null && flow.GetCurrentActionPoints() > 0)
                            {
                                flow.SpendActionPoints(1);
                            }
                        }
                        catch (Exception ex)
                        {
                            MelonLogger.Warning($"[ZTABLE] Direct move fallback exception: {ex.Message}");
                        }
                    }
                }
                var now = tile.GetCurrentToken();
                MelonLogger.Msg("[ZTABLE] Hold finished on " + tile.gameObject.name + ". Token now: " + (now != null ? now.name : "none") + ".");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] hold: " + ex.GetBaseException().Message);
            }
            finally
            {
                if (armed)
                    try { tile.SetIsReinforcementTile(wasReinforcement); } catch { }
                _commitGate = false;
            }
        }

        private static void SelectTokenOn(WarTile tile)
        {
            if (tile == null || DeploymentPanelOpen()) return;
            WarToken token = null;
            try { token = tile.GetCurrentToken(); } catch { return; }
            if (token == null) return;
            try
            {
                // The defender sits on the tile you attack. Selecting them drops your unit and the attack never starts.
                if (token.GetTokenAllegiance() != WarToken.WarAllegiance.Player) return;
                var action = tile.GetTileActionType();
                if (action == WarTile.TileActionType.Attack || action == WarTile.TileActionType.Move
                    || action == WarTile.TileActionType.Deploy || action == WarTile.TileActionType.Refund)
                    return;
                var ut = token.GetWarUnitTypeData();
                if (ut != null && ut.unitType == WarUnitTypeData.UnitType.City) return;
                if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (_tokenMgr == null) return;
                _tokenMgr.SelectToken(token);
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] select: " + ex.GetBaseException().Message);
            }
        }

        private static bool _ringOpen;

        private static void ShowHoldRing(WarTile tile, float progress)
        {
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarActionHoverPanel : null;
                if (panel == null) return;
                if (panel.currentWarTile != tile)
                {
                    panel.Setup(tile);
                }
                if (!_ringOpen)
                {
                    panel.Show();
                    _ringOpen = true;
                }
                panel.UpdateWarActionMissclickTimer(tile, progress);
                if (panel.holdTimerProgressImage != null)
                {
                    panel.holdTimerProgressImage.fillAmount = Mathf.Clamp01(_heldFor / HoldSeconds);
                }
                if (!_holdRingLogged)
                {
                    _holdRingLogged = true;
                    MelonLogger.Msg("[ZTABLE] Hold ring uses the Pales action timer.");
                }
            }
            catch (Exception ex)
            {
                if (!_holdRingLogged)
                {
                    _holdRingLogged = true;
                    MelonLogger.Warning("[ZTABLE] hold ring: " + ex.GetBaseException().Message);
                }
            }
        }

        private static void HideHoldRing()
        {
            try
            {
                ClearHoldFill();
                var panel = Panels.Instance != null ? Panels.Instance.WarActionHoverPanel : null;
                if (panel != null) panel.Hide();
                _ringOpen = false;
            }
            catch { _ringOpen = false; }
        }

        /// <summary>A cancelled hold must not leave its arc on the next province.</summary>
        private static void ClearHoldFill()
        {
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarActionHoverPanel : null;
                var image = panel != null ? panel.holdTimerProgressImage : null;
                if (image != null) image.fillAmount = 0f;
            }
            catch { }
        }

        public static void LatePass()
        {
            ZilleProfiler.BeginLatePass();
            try
            {
                if (!_pressSeen || _committed || _heldFor <= 0f) ClearHoldFill();
                ThrottleSweepBattles();
                ThrottleRepairOccupants();
                WatchEnemyTurn();
            }
            finally
            {
                ZilleProfiler.EndLatePass();
            }
        }

        private static float _nextBattleSweepTime;
        private static void ThrottleSweepBattles()
        {
            if (_tiles.Count == 0) return;
            if (Time.unscaledTime < _nextBattleSweepTime) return;
            _nextBattleSweepTime = Time.unscaledTime + 0.35f;
            SweepFinishedBattles();
        }

        private static float _nextRepairTime;
        private static void ThrottleRepairOccupants()
        {
            if (DeploymentPanelOpen() || !ScenarioStarted || _tiles.Count == 0) return;
            if (Time.unscaledTime < _nextRepairTime) return;
            _nextRepairTime = Time.unscaledTime + 1.5f;

            try
            {
                if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                var tokens = _tokenMgr != null ? _tokenMgr.GetWarTokens() : null;
                if (tokens == null || tokens.Count == 0) return;

                for (int i = 0; i < tokens.Count; i++)
                {
                    var token = tokens[i];
                    if (token == null || token.IsDead()) continue;
                    var tile = token.GetCurrentWarTile();
                    if (tile != null && tile.GetCurrentToken() != token)
                    {
                        var cur = tile.GetCurrentToken();
                        if (cur == null || cur.IsDead())
                        {
                            tile.SetCurrentWarToken(token);
                            UnlockTile(tile);
                        }
                    }
                }
            }
            catch { }
        }

        private static void UpdateStatusEffectPositions()
        {
            // Native Cinemachine hooks in TemplateTokenStatusEffect maintain screen position natively.
        }

        private static readonly Dictionary<long, WarTile> _battleContestedTiles = new Dictionary<long, WarTile>();
        private static readonly Dictionary<int, WarTile> _pendingContestedTiles = new Dictionary<int, WarTile>();
        private static readonly Dictionary<int, WarTile> _committedAttackTiles = new Dictionary<int, WarTile>();

        public static void RecordBattleContestedTile(WarBattleManager.WarBattle battle, WarToken attacker, WarToken defender, WarTile tile)
        {
            if (tile == null) return;
            if (battle != null) _battleContestedTiles[battle.Pointer.ToInt64()] = tile;
            if (defender != null) _pendingContestedTiles[defender.GetInstanceID()] = tile;
            if (attacker != null) _committedAttackTiles[attacker.GetInstanceID()] = tile;
        }

        public static void RecordDefenderStartingTile(WarToken attacker, WarToken defender, WarTile tile)
        {
            if (tile == null) return;
            if (defender != null) _pendingContestedTiles[defender.GetInstanceID()] = tile;
            if (attacker != null) _committedAttackTiles[attacker.GetInstanceID()] = tile;
        }

        public static void RecordCommittedAttackTile(WarToken attacker, WarTile targetTile)
        {
            if (attacker == null || targetTile == null) return;
            _committedAttackTiles[attacker.GetInstanceID()] = targetTile;
        }

        private static void TrackContestedTile(WarBattleManager.WarBattle battle, WarTile tile)
        {
            if (battle == null) return;
            long bKey = battle.Pointer.ToInt64();
            if (_battleContestedTiles.ContainsKey(bKey)) return;

            if (battle.defender != null)
            {
                int defId = battle.defender.GetInstanceID();
                if (_pendingContestedTiles.TryGetValue(defId, out var pt) && pt != null)
                {
                    _battleContestedTiles[bKey] = pt;
                    return;
                }
            }
            if (battle.attacker != null)
            {
                int atkId = battle.attacker.GetInstanceID();
                if (_committedAttackTiles.TryGetValue(atkId, out var ct) && ct != null)
                {
                    _battleContestedTiles[bKey] = ct;
                    return;
                }
            }
            if (tile != null)
            {
                _battleContestedTiles[bKey] = tile;
            }
        }

        private static bool _enemyTurnActive;

        private static WarFlowManager _flowMgr;
        private static float _nextFindFlowTime;

        public static WarFlowManager FlowMgr()
        {
            if (_flowMgr != null && _flowMgr.gameObject != null) return _flowMgr;
            if (Time.unscaledTime < _nextFindFlowTime) return null;
            _nextFindFlowTime = Time.unscaledTime + 1.0f;
            try { _flowMgr = UnityEngine.Object.FindObjectOfType<WarFlowManager>(); } catch { }
            return _flowMgr;
        }

        public static bool IsEnemyTurnActive()
        {
            if (_enemyTurnActive) return true;
            try
            {
                var flow = FlowMgr();
                return flow != null && flow.IsDisplayingEnemyMoves();
            }
            catch { return false; }
        }

        /// <summary>The enemy phase calls the same commit the player's click uses. Blocking it leaves the turn on Enemy Turn forever.</summary>
        public static bool EnemyMayAct()
        {
            return IsEnemyTurnActive();
        }

        public static bool IsAnyTokenMoving()
        {
            try
            {
                var tm = TokenMgr();
                if (tm != null)
                {
                    var tokens = tm.instantiatedWarTokens;
                    if (tokens != null)
                    {
                        for (int i = 0; i < tokens.Count; i++)
                        {
                            var t = tokens[i];
                            if (t != null && !t.IsDead() && t.IsMoving()) return true;
                        }
                    }
                }
                var flow = FlowMgr();
                if (flow != null && flow.isDisplayingEnemyMoves) return true;
            }
            catch { }
            return false;
        }

        /// <summary>A fight that has already started has to finish even though the player is not holding the mouse.</summary>
        public static bool BattleMayResolve(WarTile tile)
        {
            if (tile == null) return false;
            try
            {
                var battle = tile.GetCurrentBattle();
                if (battle != null && !battle.isBattleOver)
                {
                    TrackContestedTile(battle, tile);
                    return true;
                }
                return false;
            }
            catch { return false; }
        }

        private static float _enemySince;
        private static float _lastEnemyActivity;
        private static bool _enemyRunning;
        private static bool _enemyTurnObserved;

        /// <summary>
        /// Sequence: Player clicks End Turn -> Battles Resolve -> Enemy Moves -> Player Turn resumes.
        /// Native WarFlowManager handles the turn; our watchdog resets activity on each enemy move/animation so busy turns finish naturally while real hangs recover cleanly.
        /// </summary>
        private static void WatchEnemyTurn()
        {
            var flow = FlowMgr();
            if (flow == null) return;

            bool isEnemy = flow.IsDisplayingEnemyMoves();
            bool anyMoving = IsAnyTokenMoving();
            if (isEnemy)
            {
                float now = Time.unscaledTime;
                if (_enemySince <= 0f) _enemySince = now;
                if (_lastEnemyActivity <= 0f || anyMoving) _lastEnemyActivity = now;
                _enemyTurnObserved = true;
                _enemyTurnActive = true;

                // Watchdog safety: recover if idle for > 8s with no token moving, OR hard cap at 35s
                bool idleHang = !anyMoving && (now - _lastEnemyActivity > 8.0f);
                bool hardTimeout = now - _enemySince > 35.0f;
                if (idleHang || hardTimeout)
                {
                    LogEnemyTurnStuckDetails(idleHang ? "EnemyTurn idle watchdog (8s no movement)" : "EnemyTurn hard watchdog (35s)");
                    HandTurnBack(flow);
                }
            }
            else
            {
                if (_enemyTurnObserved)
                {
                    // Native EnemyTurn just finished cleanly!
                    _enemyTurnObserved = false;
                    _enemySince = 0f;
                    _lastEnemyActivity = 0f;
                    HandTurnBack(flow);
                }
                else if (_enemyTurnActive && !AnyLiveBattle() && _enemySince > 0f && Time.unscaledTime - _enemySince > 1.5f)
                {
                    // Enemy phase had no pending moves or battles to display; return turn to player
                    _enemySince = 0f;
                    _lastEnemyActivity = 0f;
                    HandTurnBack(flow);
                }
                else if (_enemyTurnActive && _enemySince > 0f && Time.unscaledTime - _enemySince > 35.0f)
                {
                    // Watchdog fallback if battles hang > 35s
                    LogEnemyTurnStuckDetails("Enemy phase battle watchdog (35s)");
                    _enemySince = 0f;
                    _lastEnemyActivity = 0f;
                    HandTurnBack(flow);
                }
            }
        }

        private static void LogEnemyTurnStuckDetails(string reason)
        {
            var sb = new StringBuilder();
            sb.Append($"[ZTABLE] {reason}: ");
            try
            {
                var tm = TokenMgr();
                var tokens = tm != null ? tm.instantiatedWarTokens : null;
                if (tokens != null)
                {
                    int mov = 0;
                    for (int i = 0; i < tokens.Count; i++)
                    {
                        var t = tokens[i];
                        if (t == null || t.IsDead()) continue;
                        if (t.IsMoving())
                        {
                            mov++;
                            sb.Append($"moving={t.name}@{t.GetCurrentWarTile()?.name} ");
                        }
                    }
                    if (mov == 0) sb.Append("moving=0 ");
                }
                var bm = BattleMgr();
                var battles = bm != null ? bm.GetCurrentBattles() : null;
                if (battles != null)
                {
                    sb.Append($"battles={battles.Count} [");
                    for (int i = 0; i < battles.Count; i++)
                    {
                        var b = battles[i];
                        if (b == null) { sb.Append("null "); continue; }
                        sb.Append($"({b.attacker?.name}(dead={b.attacker?.IsDead()}) vs {b.defender?.name}(dead={b.defender?.IsDead()}) over={b.isBattleOver}) ");
                    }
                    sb.Append("]");
                }
            }
            catch { }
            MelonLogger.Warning(sb.ToString());
        }

        public static bool IsFlowEnemyMoving()
        {
            if (_enemyTurnActive || _enemyRunning) return true;
            try
            {
                var flow = FlowMgr();
                return flow != null && flow.IsDisplayingEnemyMoves();
            }
            catch { return false; }
        }

        public static bool AnyLiveBattle()
        {
            foreach (var tb in _tiles.Values)
            {
                var wt = tb != null ? tb.Tile : null;
                if (wt == null) continue;
                try
                {
                    if (BattleLive(wt.GetCurrentBattle())) return true;
                }
                catch { }
            }
            return false;
        }

        private static void HandTurnBack(WarFlowManager flow)
        {
            try
            {
                if (flow != null) flow.isDisplayingEnemyMoves = false;
                if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (_tokenMgr != null)
                {
                    // Clean up null/dead/destroyed tokens to prevent NullReferenceException in vanilla ResetTokenMovements!
                    if (_tokenMgr.instantiatedWarTokens != null)
                    {
                        var list = _tokenMgr.instantiatedWarTokens;
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            var tok = list[i];
                            if (tok == null || tok.Pointer == IntPtr.Zero || tok.gameObject == null || tok.IsDead())
                            {
                                list.RemoveAt(i);
                            }
                        }
                    }

                    OnBeginPlayerHalfTurn();
                    try { _tokenMgr.ResetTokenMovements(); } catch { }
                    // NEVER call ResetPlayerTokens() here as it erases the player's board units!
                    var tokens = _tokenMgr.instantiatedWarTokens;
                    if (tokens != null)
                    {
                        for (int i = 0; i < tokens.Count; i++)
                        {
                            var t = tokens[i];
                            if (t == null || t.IsDead()) continue;
                            if (t.GetTokenAllegiance() == WarToken.WarAllegiance.Player)
                            {
                                if (t.IsMovementLocked() && !IsDepletedProtectionActive(t) && !t.IsOrganizationDepleted())
                                {
                                    try { t.RemoveTokenStatusEffect(WarToken.WarTokenStatusEffectType.MovementLocked); } catch { }
                                }
                            }
                        }
                    }
                    try { _tokenMgr.SetAllTokenActions(); } catch { }
                }

                SweepFinishedBattles();
                UnlockAllTiles();
                RefreshAllTokenStatusEffects();
                RefreshBoard();

                if (flow != null)
                {
                    int want = Math.Max(3, flow.ActionPointsPerTurn > 0 ? flow.ActionPointsPerTurn : 5);
                    flow.currentActionPoints = want;
                    flow.PlayerTurn();
                    MelonLogger.Msg($"[ZTABLE] Player turn resumed after Wehlen actions. Granted {want} action points.");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] Could not resume the player turn: " + ex.GetBaseException().Message);
            }
            finally
            {
                _enemyRunning = false;
                _enemyTurnActive = false;
                _enemyTurnObserved = false;
                if (flow != null) flow.isDisplayingEnemyMoves = false;
            }
        }

        /// <summary>Hovering another Rizian unit is support only while a fight is still going.</summary>
        public static bool AllySupportTarget(WarTile tile)
        {
            if (tile == null || DeploymentPanelOpen() || !LiveSupport(tile)) return false;
            WarToken token = null;
            try { token = tile.GetCurrentToken(); } catch { return false; }
            var sel = SelectedUnit();
            if (token == null || sel == null || token == sel) return false;
            try
            {
                return token.GetTokenAllegiance() == WarToken.WarAllegiance.Player
                    && sel.GetTokenAllegiance() == WarToken.WarAllegiance.Player;
            }
            catch { return false; }
        }

        /// <summary>
        /// The allegiance change walks each supply line's tile list and throws when that list was never built.
        /// A thrown change aborts the battle before it can end, so the enemy phase never reaches its moves.
        /// </summary>
        public static Il2CppSystem.Collections.Generic.List<WarSupplyLine> SanitizeSupplyLines(Il2CppSystem.Collections.Generic.List<WarSupplyLine> lines)
        {
            if (lines == null) lines = new Il2CppSystem.Collections.Generic.List<WarSupplyLine>();
            for (int i = lines.Count - 1; i >= 0; i--)
            {
                WarSupplyLine line = null;
                try { line = lines[i]; } catch { lines.RemoveAt(i); continue; }
                if (line == null) { lines.RemoveAt(i); continue; }
                bool ready = false;
                try { ready = line.Tiles != null && line.Tiles.Count >= 2; } catch { }
                if (!ready)
                {
                    try { line.SetupTiles(); } catch { }
                    try { ready = line.Tiles != null && line.Tiles.Count >= 2; } catch { }
                }
                if (!ready) lines.RemoveAt(i);
            }
            return lines;
        }

        private static void SweepFinishedBattles()
        {
            var doomed = new List<WarBattleManager.WarBattle>();
            foreach (var tb in _tiles.Values)
            {
                var wt = tb != null ? tb.Tile : null;
                if (wt == null) continue;
                WarBattleManager.WarBattle battle = null;
                try { battle = wt.GetCurrentBattle(); } catch { continue; }
                if (battle == null) continue;
                bool over = false;
                try { over = battle.isBattleOver || battle.attacker == null || battle.defender == null || battle.attacker.IsDead() || battle.defender.IsDead(); }
                catch { over = true; }
                if (over && !doomed.Contains(battle)) doomed.Add(battle);
            }
            try
            {
                var bm = BattleMgr();
                var curList = bm != null ? bm.GetCurrentBattles() : null;
                if (curList != null)
                {
                    for (int i = curList.Count - 1; i >= 0; i--)
                    {
                        var b = curList[i];
                        if (b == null) { curList.RemoveAt(i); continue; }
                        bool over = false;
                        try { over = b.isBattleOver || b.attacker == null || b.defender == null || b.attacker.IsDead() || b.defender.IsDead(); }
                        catch { over = true; }
                        if (over && !doomed.Contains(b)) doomed.Add(b);
                    }
                }
            }
            catch { }
            for (int i = 0; i < doomed.Count; i++) FinishBattle(doomed[i]);
        }

        private static int _turnEpoch = 0;
        private static bool _inEnemyHalfTurn = false;
        private static int _bypassDepletedGuardDepth = 0;
        private static readonly Dictionary<int, int> _depletedExpiresEpoch = new Dictionary<int, int>();
        private static readonly Dictionary<long, bool> _battleTurnWinners = new Dictionary<long, bool>();
        private static readonly HashSet<long> _settledBattles = new HashSet<long>();

        public static bool IsBypassingDepletedGuard => _bypassDepletedGuardDepth > 0;

        public static void ResetBattleStatusTracking()
        {
            _turnEpoch = 0;
            _inEnemyHalfTurn = false;
            _bypassDepletedGuardDepth = 0;
            _depletedExpiresEpoch.Clear();
            _battleTurnWinners.Clear();
            _settledBattles.Clear();
        }

        public static void OnBeginEnemyHalfTurn()
        {
            if (!_inEnemyHalfTurn)
            {
                _inEnemyHalfTurn = true;
                _turnEpoch++;
                ExpireFinishedDepletedStatuses();
            }
        }

        public static void OnBeginPlayerHalfTurn()
        {
            if (_inEnemyHalfTurn)
            {
                _inEnemyHalfTurn = false;
                _turnEpoch++;
                ExpireFinishedDepletedStatuses();
            }
        }

        public static void RegisterDepletedToken(WarToken tok)
        {
            if (tok == null || IsBypassingDepletedGuard) return;
            try
            {
                if (tok.IsDead() || IsCityToken(tok)) return;
                int id = tok.GetInstanceID();
                // Lasts 1 full turn (2 half-turns: current + next opposing/own turn) before recovery
                int expiresAt = _turnEpoch + 2;
                if (!_depletedExpiresEpoch.TryGetValue(id, out int cur) || cur < expiresAt)
                {
                    _depletedExpiresEpoch[id] = expiresAt;
                    MelonLogger.Msg($"[ZTABLE] DepletedOrganization active on {tok.name} until epoch {expiresAt} (cur={_turnEpoch}).");
                }
            }
            catch { }
        }

        public static bool IsDepletedProtectionActive(WarToken tok)
        {
            if (IsBypassingDepletedGuard || tok == null) return false;
            try
            {
                if (tok.IsDead() || IsCityToken(tok)) return false;
                if (_depletedExpiresEpoch.TryGetValue(tok.GetInstanceID(), out int exp))
                    return _turnEpoch < exp;
            }
            catch { }
            return false;
        }

        public static void ClearDepletedStatus(WarToken tok, bool ensureMinOrg)
        {
            if (tok == null) return;
            _bypassDepletedGuardDepth++;
            try
            {
                int id = tok.GetInstanceID();
                _depletedExpiresEpoch.Remove(id);
                if (!tok.IsDead())
                {
                    try { tok.RemoveTokenStatusEffect(WarToken.WarTokenStatusEffectType.DepletedOrganization); } catch { }
                    try { tok.RemoveTokenStatusEffect(WarToken.WarTokenStatusEffectType.MovementLocked); } catch { }
                    if (ensureMinOrg && tok.GetRemainingOrganization() <= 0)
                    {
                        try { tok.remainingOrganization = 1; } catch { }
                        if (tok.GetRemainingOrganization() <= 0)
                        {
                            try { tok.HealDamage(1); } catch { }
                        }
                    }
                }
                try { Panels.Instance?.WarTokenStatusEffectsPanel?.Remove(tok, WarToken.WarTokenStatusEffectType.DepletedOrganization); } catch { }
            }
            catch { }
            finally
            {
                _bypassDepletedGuardDepth--;
            }
        }

        public static void ExpireFinishedDepletedStatuses()
        {
            if (_depletedExpiresEpoch.Count == 0) return;
            try
            {
                var mgr = _tokenMgr ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                var tokens = mgr != null ? mgr.instantiatedWarTokens : null;
                var byId = new Dictionary<int, WarToken>();
                if (tokens != null)
                {
                    for (int i = 0; i < tokens.Count; i++)
                    {
                        var t = tokens[i];
                        if (t != null && t.Pointer != IntPtr.Zero && !t.IsDead())
                            byId[t.GetInstanceID()] = t;
                    }
                }

                var toExpire = new List<int>();
                var toDrop = new List<int>();
                foreach (var kv in _depletedExpiresEpoch)
                {
                    if (!byId.TryGetValue(kv.Key, out var tok) || tok == null)
                    {
                        toDrop.Add(kv.Key);
                        continue;
                    }
                    if (_turnEpoch >= kv.Value)
                        toExpire.Add(kv.Key);
                }

                for (int i = 0; i < toDrop.Count; i++)
                    _depletedExpiresEpoch.Remove(toDrop[i]);

                for (int i = 0; i < toExpire.Count; i++)
                {
                    if (byId.TryGetValue(toExpire[i], out var tok) && tok != null)
                    {
                        ClearDepletedStatus(tok, ensureMinOrg: true);
                        MelonLogger.Msg($"[ZTABLE] Cleared DepletedOrganization after 1 turn on {tok.name} (epoch={_turnEpoch}).");
                    }
                }
            }
            catch { }
        }

        public static void RecordBattleTurnResult(WarBattleManager bm, WarBattleManager.WarBattle battle)
        {
            if (battle == null) return;
            try
            {
                var res = bm != null ? bm.GetBattleTurnResult(battle) : null;
                if (res != null)
                {
                    _battleTurnWinners[battle.Pointer.ToInt64()] = res.isAttackerWinner;
                    WarToken winner = res.isAttackerWinner ? battle.attacker : battle.defender;
                    if (winner != null && !winner.IsDead())
                    {
                        if (winner.IsOrganizationDepleted() || IsOverrun(winner))
                            ClearDepletedStatus(winner, ensureMinOrg: true);
                    }
                }
            }
            catch { }
        }

        public static bool IsBattleWinner(WarToken tok)
        {
            if (tok == null || tok.IsDead()) return false;
            try
            {
                WarBattleManager.WarBattle b = null;
                try { b = tok.GetCurrentBattle(); } catch { }
                if (b == null)
                {
                    var bm = BattleMgr();
                    var cur = bm != null ? bm.GetCurrentBattles() : null;
                    if (cur != null)
                    {
                        for (int i = 0; i < cur.Count; i++)
                        {
                            var cb = cur[i];
                            if (cb != null && (cb.attacker == tok || cb.defender == tok)) { b = cb; break; }
                        }
                    }
                }
                if (b == null) return false;
                bool atkWon = AttackerWon(b);
                if (b.attacker == tok && atkWon && (b.defender == null || b.defender.IsDead() || b.defender.IsOrganizationDepleted() || tok.GetRemainingOrganization() > 0))
                    return true;
                if (b.defender == tok && !atkWon && (b.attacker == null || b.attacker.IsDead() || b.attacker.IsOrganizationDepleted() || tok.GetRemainingOrganization() > 0))
                    return true;
            }
            catch { }
            return false;
        }

        /// <summary>The fight is over. Vanilla has animated the retreat and advance; synchronize the conquered province.</summary>
        public static void FinishBattle(WarBattleManager.WarBattle battle)
        {
            if (battle == null) return;
            long bKey = battle.Pointer.ToInt64();
            if (!_settledBattles.Add(bKey)) return;

            WarTile atkSource = null;
            try { if (battle.attacker != null) atkSource = battle.attacker.GetCurrentWarTile(); } catch { }
            WarTile defSource = null;
            try { if (battle.defender != null) defSource = battle.defender.GetCurrentWarTile(); } catch { }

            WarTile focusTile = defSource ?? atkSource;
            if (focusTile != null) ShowEnemyMove(focusTile);

            try { AdvanceAttacker(battle); }
            catch (Exception ex) { MelonLogger.Warning("[ZTABLE] battle advance: " + ex.GetBaseException().Message); }
            ClearBattle(battle);
            try { _battleContestedTiles.Remove(bKey); } catch { }

            if (atkSource != null) { UnlockTile(atkSource); RepaintTile(atkSource); }
            if (defSource != null) { UnlockTile(defSource); RepaintTile(defSource); }
            RefreshBoard();
            RefreshAllTokenStatusEffects();
        }

        private static void AdvanceAttacker(WarBattleManager.WarBattle battle)
        {
            var atk = battle.attacker;
            if (atk == null) return;
            try { if (atk.IsDead()) return; } catch { return; }

            long bKey = battle.Pointer.ToInt64();
            WarTile contestedTile = null;
            if (_battleContestedTiles.TryGetValue(bKey, out var ct) && ct != null)
            {
                contestedTile = ct;
            }

            var def = battle.defender;
            var sourceTile = atk.GetCurrentWarTile();

            if (contestedTile == null && def != null)
            {
                if (_pendingContestedTiles.TryGetValue(def.GetInstanceID(), out var pt) && pt != null)
                    contestedTile = pt;
            }

            if (contestedTile == null)
            {
                if (_committedAttackTiles.TryGetValue(atk.GetInstanceID(), out var cat) && cat != null)
                    contestedTile = cat;
            }

            if (contestedTile == null)
            {
                foreach (var tb in _tiles.Values)
                {
                    var wt = tb != null ? tb.Tile : null;
                    if (wt == null || wt == sourceTile) continue;
                    if (wt.GetCurrentBattle() == battle)
                    {
                        contestedTile = wt;
                        break;
                    }
                }
            }

            // If defender retreated elsewhere, defRetreatTile != contestedTile.
            // If defender had nowhere to retreat (or died in place), defRetreatTile == contestedTile — do NOT clear contestedTile!
            var defRetreatTile = def != null ? def.GetCurrentWarTile() : null;

            if (contestedTile == null && sourceTile != null)
            {
                var adj = sourceTile.adjacentWarTiles;
                if (adj != null)
                {
                    for (int i = 0; i < adj.Count; i++)
                    {
                        var at = adj[i];
                        if (at == null || at == sourceTile || at == defRetreatTile) continue;
                        var tdAdj = TileDataOf(at);
                        if (tdAdj != null && tdAdj.Allegiance == "Wehlen")
                        {
                            contestedTile = at;
                            break;
                        }
                    }
                }
            }

            bool atkWon = AttackerWon(battle);
            WarToken winner = atkWon ? atk : def;
            WarToken loser = atkWon ? def : atk;

            // A unit that WON a battle must NEVER receive DepletedOrganization!
            if (winner != null && !winner.IsDead())
            {
                if (winner.IsOrganizationDepleted() || IsOverrun(winner))
                    ClearDepletedStatus(winner, ensureMinOrg: true);
            }

            if (!atkWon)
            {
                MelonLogger.Msg("[ZTABLE] Attacker lost the battle: " + (atk != null ? atk.name : "null"));
                if (atk != null && !atk.IsDead() && atk.gameObject != null && atk.gameObject.activeInHierarchy
                    && (atk.IsOrganizationDepleted() || atk.GetRemainingOrganization() <= 0))
                {
                    atk.AddTokenStatusEffect(WarToken.WarTokenStatusEffectType.DepletedOrganization);
                    atk.AddTokenStatusEffect(WarToken.WarTokenStatusEffectType.MovementLocked);
                    RegisterDepletedToken(atk);
                    try { Panels.Instance?.WarTokenStatusEffectsPanel?.Add(atk, WarToken.WarTokenStatusEffectType.DepletedOrganization); } catch { }
                }
                return;
            }

            // Attacker won! Check if defending unit is a city!
            bool isCityBattle = def != null && IsCityToken(def);
            if (isCityBattle)
            {
                // A city NEVER disappears, gets overrun, or dies.
                // It heals to full health and switches allegiance to the captor!
                var newAlleg = atk.GetTokenAllegiance();
                def.SetTokenAllegiance(newAlleg);
                var cityUt = def.GetWarUnitTypeData();
                if (cityUt != null) def.remainingOrganization = cityUt.organization;
                ClearDepletedStatus(def, ensureMinOrg: true);
                _bypassDepletedGuardDepth++;
                try { def.RemoveAllTokenStatusEffect(); }
                finally { _bypassDepletedGuardDepth--; }

                if (contestedTile != null)
                {
                    var ctd = TileDataOf(contestedTile);
                    if (ctd != null)
                    {
                        ctd.Allegiance = newAlleg == WarToken.WarAllegiance.Player ? "Rizia" : "Wehlen";
                        contestedTile.SetTileAllegiance(newAlleg, false);
                        SyncOwnership(contestedTile, ctd);
                        TintTile(contestedTile, ctd);
                    }
                    contestedTile.SetCurrentWarToken(def);
                }
                MelonLogger.Msg("[ZTABLE] City " + def.name + " captured by " + newAlleg + " and healed to full organization!");
                return;
            }

            // Attacker won non-city battle! Only mark truly depleted defeated defender (org <= 0) as overrun for 1 turn
            if (loser != null && !loser.IsDead() && loser.gameObject != null && loser.gameObject.activeInHierarchy
                && loser.GetCurrentWarTile() != null && (loser.IsOrganizationDepleted() || loser.GetRemainingOrganization() <= 0))
            {
                loser.AddTokenStatusEffect(WarToken.WarTokenStatusEffectType.DepletedOrganization);
                loser.AddTokenStatusEffect(WarToken.WarTokenStatusEffectType.MovementLocked);
                RegisterDepletedToken(loser);
                try { Panels.Instance?.WarTokenStatusEffectsPanel?.Add(loser, WarToken.WarTokenStatusEffectType.DepletedOrganization); } catch { }
                MelonLogger.Msg("[ZTABLE] Defeated defender marked as overrun (1 turn): " + loser.name);
            }

            if (contestedTile == null) return;

            var ut = atk.GetWarUnitTypeData();
            if (ut != null && !ut.CanMoveToTileType(contestedTile.GetTileType())) return;

            // If defender lost and had nowhere to retreat (still sitting on contestedTile), kill it with full death animation & SFX
            if (def != null && !def.IsDead() && def.GetCurrentWarTile() == contestedTile)
            {
                KillUnit(def, contestedTile);
            }

            // Clear contestedTile's reference if it still points to defender
            if (contestedTile.GetCurrentToken() == def)
            {
                try { contestedTile.SetCurrentWarToken(null); } catch { }
            }

            // Move attacker smoothly into the contested province
            if (atk.GetCurrentWarTile() != contestedTile)
            {
                try { atk.Move(contestedTile, true, WarToken.TokenAnimationType.BattleWin, null); }
                catch { try { atk.Move(contestedTile, true); } catch { } }
                try
                {
                    var audioMgr = Managers.Instance?.AudioManager ?? UnityEngine.Object.FindObjectOfType<AudioManager>();
                    if (audioMgr != null)
                    {
                        audioMgr.PlayWarSFX(atk.GetTokenAllegiance() == WarToken.WarAllegiance.Player
                            ? AudioManager.WarSFXTrackName.War_FriendlyUnitTakeTerritory
                            : AudioManager.WarSFXTrackName.War_EnemyUnitTakeTerritory);
                    }
                }
                catch { }
            }
            try { contestedTile.SetCurrentWarToken(atk); } catch { }
            if (sourceTile != null && sourceTile != contestedTile && sourceTile.GetCurrentToken() == atk)
            {
                try { sourceTile.SetCurrentWarToken(null); } catch { }
            }

            var td = TileDataOf(contestedTile);
            if (td != null)
            {
                var alleg = atk.GetTokenAllegiance();
                td.Allegiance = alleg == WarToken.WarAllegiance.Player ? "Rizia" : "Wehlen";
                contestedTile.SetTileAllegiance(alleg, false);
                SyncOwnership(contestedTile, td);
                TintTile(contestedTile, td);
            }

            UnlockTile(contestedTile);
            if (sourceTile != null) UnlockTile(sourceTile);

            MelonLogger.Msg("[ZTABLE] Attacker successfully took contested province " + contestedTile.gameObject.name + ".");
        }

        public static void OnUnitMovedToTile(WarToken token, WarTile targetTile)
        {
            if (token == null || targetTile == null) return;
            try
            {
                var td = TileDataOf(targetTile);
                if (td == null || td.IsSea) return;
                var alleg = token.GetTokenAllegiance();
                if (alleg == WarToken.WarAllegiance.Player)
                {
                    td.Allegiance = "Rizia";
                    targetTile.SetTileAllegiance(WarToken.WarAllegiance.Player, false);
                }
                else if (alleg == WarToken.WarAllegiance.Enemy)
                {
                    td.Allegiance = "Wehlen";
                    targetTile.SetTileAllegiance(WarToken.WarAllegiance.Enemy, false);
                }
                UnlockTile(targetTile);
                TintTile(targetTile, td);
            }
            catch { }
        }

        private static WarBattleManager _battleMgr;
        private static float _nextFindBattleTime;

        public static WarBattleManager BattleMgr()
        {
            if (_battleMgr != null && _battleMgr.gameObject != null) return _battleMgr;
            if (Time.unscaledTime < _nextFindBattleTime) return null;
            _nextFindBattleTime = Time.unscaledTime + 1.0f;
            try { _battleMgr = UnityEngine.Object.FindObjectOfType<WarBattleManager>(); } catch { }
            return _battleMgr;
        }

        private static bool AttackerWon(WarBattleManager.WarBattle battle)
        {
            if (battle == null) return false;
            try
            {
                var bm = BattleMgr();
                if (bm != null)
                {
                    var res = bm.GetBattleTurnResult(battle);
                    if (res != null) return res.isAttackerWinner;
                }
            }
            catch { }
            if (_battleTurnWinners.TryGetValue(battle.Pointer.ToInt64(), out bool recordedWin))
                return recordedWin;
            var def = battle.defender;
            var atk = battle.attacker;
            bool defOut = def == null || def.IsDead() || def.IsOrganizationDepleted() || def.GetRemainingOrganization() <= 0;
            bool atkOut = atk == null || atk.IsDead() || atk.IsOrganizationDepleted() || atk.GetRemainingOrganization() <= 0;
            if (defOut && !atkOut) return true;
            if (atkOut && !defOut) return false;
            if (battle.totalAttack != battle.totalDefence)
                return battle.totalAttack > battle.totalDefence;
            return defOut;
        }

        private static void ClearBattle(WarBattleManager.WarBattle battle)
        {
            try { battle.isBattleOver = true; } catch { }
            ClearTokenBattle(battle.attacker, battle);
            ClearTokenBattle(battle.defender, battle);
            ClearSupportBattles(battle.attackersSupporters, battle);
            ClearSupportBattles(battle.defendersSupporters, battle);
            foreach (var tb in _tiles.Values)
            {
                var wt = tb != null ? tb.Tile : null;
                if (wt == null) continue;
                try
                {
                    var curB = wt.GetCurrentBattle();
                    if (curB == battle || (curB != null && curB.isBattleOver))
                    {
                        wt.SetCurrentBattle(null);
                        UnlockTile(wt);
                        RepaintTile(wt);
                    }
                }
                catch { }
            }
            try
            {
                var bm = BattleMgr();
                var curList = bm != null ? bm.GetCurrentBattles() : null;
                if (curList != null)
                {
                    for (int i = curList.Count - 1; i >= 0; i--)
                    {
                        if (curList[i] == battle || curList[i] == null) curList.RemoveAt(i);
                    }
                }
            }
            catch { }
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarBattlePanel : null;
                if (panel != null) panel.RemoveBattle(battle);
            }
            catch { }
        }

        private static void ClearTokenBattle(WarToken token, WarBattleManager.WarBattle battle)
        {
            if (token == null) return;
            try
            {
                if (token.GetCurrentBattle() == battle) token.SetCurrentBattle(null);
            }
            catch { }
        }

        private static void ClearSupportBattles(Il2CppSystem.Collections.Generic.List<WarToken> tokens, WarBattleManager.WarBattle battle)
        {
            if (tokens == null) return;
            try
            {
                for (int i = 0; i < tokens.Count; i++) ClearTokenBattle(tokens[i], battle);
            }
            catch { }
        }

        /// <summary>
        /// One pickup returns one unit. The stock refund both adds a unit to the pool and
        /// removes one from the deployed count, so the list was gaining two.
        /// </summary>
        private static void RefundDeployedUnit(WarTile tile, WarDeploymentPanel panel)
        {
            var token = tile.GetCurrentToken();
            if (token == null) return;
            WarUnitTypeData ut = null;
            try { ut = token.GetWarUnitTypeData(); } catch { }
            if (panel != null && ut != null)
            {
                int beforeDeployed = ut.UnitDeployedCount;
                try { panel.RefundToken(ut); }
                catch (Exception ex) { MelonLogger.Warning("[ZTABLE] refund: " + ex.GetBaseException().Message); }

                var list = panel.deployedTokensToTile;
                if (list != null)
                {
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        var entry = list[i];
                        if (entry != null && entry.tile == tile) list.RemoveAt(i);
                    }
                }

                if (ut.UnitDeployedCount >= beforeDeployed && beforeDeployed > 0)
                {
                    ut.UnitDeployedCount = beforeDeployed - 1;
                }
                try { panel.UpdateDeployingUnitCount(); } catch { }
            }
            if (tile.GetCurrentToken() != null)
            {
                try { tile.SetCurrentWarToken(null); } catch { }
                UnityEngine.Object.Destroy(token.gameObject);
            }
            MelonLogger.Msg("[ZTABLE] Refunded " + (ut != null ? (ut.UnitName ?? ut.name) : "unit") + " from " + tile.gameObject.name + ".");
        }

        /// <summary>A bombed or overrun enemy falls, then the selected unit takes the province. One figure stays.</summary>
        private static bool OverrunFallen(WarTile tile)
        {
            var sel = SelectedUnit();
            if (sel == null || tile == null) return false;
            var occ = Occupant(tile);
            if (occ == null || occ == sel || !CanOverrun(sel, occ)) return false;

            var sourceTile = sel.GetCurrentWarTile();

            // Kill overrun / bombed enemy with full native death sequence and Pales overrun SFX
            try
            {
                var audioMgr = Managers.Instance?.AudioManager ?? UnityEngine.Object.FindObjectOfType<AudioManager>();
                if (audioMgr != null)
                {
                    audioMgr.PlayWarSFX(occ.GetTokenAllegiance() == WarToken.WarAllegiance.Player
                        ? AudioManager.WarSFXTrackName.War_FriendlyUnitDestroyed
                        : AudioManager.WarSFXTrackName.War_EnemyUnitDestroyed);
                    audioMgr.PlayWarSFX(sel.GetTokenAllegiance() == WarToken.WarAllegiance.Player
                        ? AudioManager.WarSFXTrackName.War_FriendlyUnitTakeTerritory
                        : AudioManager.WarSFXTrackName.War_EnemyUnitTakeTerritory);
                }
            }
            catch { }
            KillUnit(occ, tile);

            // Move selected unit onto the tile with Overrun animation
            try
            {
                if (sel.GetCurrentWarTile() != tile)
                {
                    sel.Move(tile, true, WarToken.TokenAnimationType.Overrun, null);
                }
            }
            catch
            {
                try { sel.Move(tile, true); } catch { }
            }
            try { tile.SetCurrentWarToken(sel); } catch { }
            if (sourceTile != null && sourceTile != tile && sourceTile.GetCurrentToken() == sel)
            {
                try { sourceTile.SetCurrentWarToken(null); } catch { }
            }

            var td = TileDataOf(tile);
            if (td != null)
            {
                var alleg = sel.GetTokenAllegiance();
                td.Allegiance = alleg == WarToken.WarAllegiance.Player ? "Rizia" : "Wehlen";
                tile.SetTileAllegiance(alleg, false);
                SyncOwnership(tile, td);
                TintTile(tile, td);
            }

            UnlockTile(tile);
            if (sourceTile != null) UnlockTile(sourceTile);

            try
            {
                var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (flow != null && flow.GetCurrentActionPoints() > 0) flow.SpendActionPoints(1);
            }
            catch { }
            try
            {
                if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (_tokenMgr != null) _tokenMgr.SetAllTokenActions();
            }
            catch { }

            MelonLogger.Msg("[ZTABLE] Overran and eliminated enemy on " + tile.gameObject.name + ".");
            return true;
        }

        public static void KillUnit(WarToken token, WarTile tile = null)
        {
            if (token == null) return;
            try
            {
                if (IsCityToken(token))
                {
                    MelonLogger.Msg("[ZTABLE] Protected city token from destruction: " + (token.gameObject != null ? token.gameObject.name : "city"));
                    return;
                }

                if (tile == null)
                {
                    try { tile = token.GetCurrentWarTile(); } catch { }
                }
                if (tile != null)
                {
                    try
                    {
                        if (tile.GetCurrentToken() == token)
                            tile.SetCurrentWarToken(null);
                    }
                    catch { }
                }

                // Immediately clean up status effect indicators so nothing sticks to screen
                try
                {
                    var panel = Panels.Instance != null ? Panels.Instance.WarTokenStatusEffectsPanel : null;
                    if (panel != null) panel.RemoveAllForToken(token);
                }
                catch { }

                // Play death particle effects, animation, and SFX (Pales style)
                bool isNaval = false;
                try
                {
                    var ut = token.GetWarUnitTypeData();
                    isNaval = ut != null && ut.unitType == WarUnitTypeData.UnitType.NavalUnit;
                }
                catch { }
                try
                {
                    try
                    {
                        var audioMgr = Managers.Instance?.AudioManager ?? UnityEngine.Object.FindObjectOfType<AudioManager>();
                        if (audioMgr != null)
                        {
                            audioMgr.PlayWarSFX(token.GetTokenAllegiance() == WarToken.WarAllegiance.Player
                                ? AudioManager.WarSFXTrackName.War_FriendlyUnitDestroyed
                                : AudioManager.WarSFXTrackName.War_EnemyUnitDestroyed);
                        }
                    }
                    catch { }
                    if (token.animator == null)
                    {
                        try { token.animator = token.GetComponentInChildren<UnityEngine.Animator>(); } catch { }
                    }
                    if (token.animationEvents != null)
                    {
                        token.animationEvents.DustSlamParticle();
                        token.animationEvents.SmokeStart();
                    }
                    token.PlayTokenAnimation(WarToken.TokenAnimationType.Death, null);
                    token.isDead = true;
                }
                catch (Exception aex)
                {
                    token.isDead = true;
                    MelonLogger.Warning("[ZTABLE] PlayTokenAnimation error: " + aex.Message);
                }

                // Delayed destroy so death animation plays in full
                float delay = 1.4f;
                try { if (token.deathAnimationDelay > 0.1f) delay = token.deathAnimationDelay; } catch { }
                if (isNaval) MelonCoroutines.Start(SinkNavalToken(token, delay));
                MelonCoroutines.Start(DelayedDestroyToken(token, delay));

                MelonLogger.Msg("[ZTABLE] Unit playing death animation sequence: " + (token.gameObject != null ? token.gameObject.name : "token"));
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] KillUnit exception: " + ex.Message);
            }
        }

        private static IEnumerator SinkNavalToken(WarToken token, float duration)
        {
            if (token == null || token.transform == null) yield break;
            float elapsed = 0f;
            float dur = Mathf.Max(0.8f, duration * 0.9f);
            Vector3 startPos = token.transform.position;
            Quaternion startRot = token.transform.rotation;
            while (elapsed < dur)
            {
                if (token == null || token.gameObject == null) yield break;
                elapsed += Time.deltaTime;
                float t = Mathf.Clamp01(elapsed / dur);
                token.transform.position = startPos + new Vector3(0f, -0.045f * t, 0f);
                token.transform.rotation = startRot * Quaternion.Euler(18f * t, 0f, 12f * t);
                yield return null;
            }
        }

        private static IEnumerator DelayedDestroyToken(WarToken token, float delay)
        {
            yield return new WaitForSeconds(delay);
            if (token != null && token.gameObject != null)
            {
                try
                {
                    var mgr = _tokenMgr ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                    if (mgr != null) mgr.DestroyToken(token);
                    else token.Kill(false);
                }
                catch
                {
                    try { UnityEngine.Object.Destroy(token.gameObject); } catch { }
                }
            }
        }

        private static void UnlockTile(WarTile tile)
        {
            if (tile == null) return;
            try { if (tile.IsLocked()) tile.SetLockState(false); } catch { }
            try { if (tile.IsActionLocked()) tile.SetActionLockState(false); } catch { }
        }

        public static void UnlockAllTiles()
        {
            foreach (var tb in _tiles.Values)
            {
                var wt = tb?.Tile;
                if (wt == null) continue;
                try
                {
                    if (wt.IsLocked()) wt.SetLockState(false);
                    if (wt.IsActionLocked()) wt.SetActionLockState(false);
                }
                catch { }
            }
        }

        public static void CleanupDeadStatusEffectIcons(WarToken specificDead = null)
        {
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarTokenStatusEffectsPanel : null;
                if (panel == null) return;
                if (specificDead != null)
                {
                    try { panel.RemoveAllForToken(specificDead); } catch { }
                }
                var list = panel.instantiatedWarTokenStatusEffects;
                if (list == null || list.Count == 0) return;

                for (int i = list.Count - 1; i >= 0; i--)
                {
                    var eff = list[i];
                    if (eff == null || eff.Pointer == IntPtr.Zero || eff.gameObject == null)
                    {
                        list.RemoveAt(i);
                        continue;
                    }
                    WarToken tok = null;
                    bool dead = false;
                    try
                    {
                        tok = eff.currentWarToken;
                        if (tok == null || tok.Pointer == IntPtr.Zero || tok.gameObject == null || !tok.gameObject.activeInHierarchy || tok.IsDead())
                            dead = true;
                        else if (specificDead != null && tok == specificDead)
                            dead = true;
                    }
                    catch { dead = true; }

                    if (dead)
                    {
                        try { UnityEngine.Object.Destroy(eff.gameObject); } catch { }
                        list.RemoveAt(i);
                        continue;
                    }

                    // Also strip DepletedOrganization icon ONLY if protection has expired and the living unit recovered organization
                    try
                    {
                        if (!IsDepletedProtectionActive(tok) && !tok.IsOrganizationDepleted() && !IsOverrun(tok))
                        {
                            panel.Remove(tok, WarToken.WarTokenStatusEffectType.DepletedOrganization);
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }

        public static void RefreshAllTokenStatusEffects()
        {
            try
            {
                CleanupDeadStatusEffectIcons();
                var panel = Panels.Instance != null ? Panels.Instance.WarTokenStatusEffectsPanel : null;
                if (panel == null) return;
                var mgr = _tokenMgr ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                var tokens = mgr != null ? mgr.instantiatedWarTokens : null;
                if (tokens == null) return;

                var existingTokens = new HashSet<IntPtr>();
                var list = panel.instantiatedWarTokenStatusEffects;
                if (list != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        var eff = list[i];
                        if (eff != null && eff.currentWarToken != null)
                        {
                            existingTokens.Add(eff.currentWarToken.Pointer);
                        }
                    }
                }

                for (int i = 0; i < tokens.Count; i++)
                {
                    var t = tokens[i];
                    if (t == null || t.IsDead() || t.gameObject == null || !t.gameObject.activeInHierarchy) continue;
                    if (t.IsOrganizationDepleted() || IsOverrun(t))
                    {
                        if (!existingTokens.Contains(t.Pointer))
                        {
                            panel.Add(t, WarToken.WarTokenStatusEffectType.DepletedOrganization);
                        }
                    }
                }
            }
            catch { }
        }

        /// <summary>After a fight the winner can be standing on the province without being its token, so clicks miss and other units walk in.</summary>
        private static void RepairOccupants()
        {
            if (DeploymentPanelOpen() || !ScenarioStarted || _tiles.Count == 0) return;
            if (AnyLiveBattle()) return;
            try
            {
                if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                var tokens = _tokenMgr != null ? _tokenMgr.GetWarTokens() : null;
                if (tokens == null) return;
                foreach (var tb in _tiles.Values)
                {
                    var tile = tb != null ? tb.Tile : null;
                    if (tile == null) continue;
                    WarBattleManager.WarBattle battle = null;
                    try { battle = tile.GetCurrentBattle(); } catch { }
                    if (BattleLive(battle)) continue;
                    var here = new List<WarToken>();
                    for (int i = 0; i < tokens.Count; i++)
                    {
                        var token = tokens[i];
                        if (token == null) continue;
                        try
                        {
                            if (token.IsDead()) continue;
                            if (token.GetCurrentWarTile() == tile) here.Add(token);
                        }
                        catch { }
                    }
                    if (here.Count == 0)
                    {
                        try
                        {
                            var cur = tile.GetCurrentToken();
                            if (cur != null && cur.IsDead()) tile.SetCurrentWarToken(null);
                        }
                        catch { }
                        continue;
                    }
                    WarToken keep = null;
                    try { keep = tile.GetCurrentToken(); } catch { }
                    if (keep == null || !here.Contains(keep) || keep.IsDead())
                    {
                        keep = here[0];
                        for (int i = 0; i < here.Count; i++)
                        {
                            if (!here[i].IsDead()) { keep = here[i]; break; }
                        }
                    }
                    try { if (tile.GetCurrentToken() != keep) tile.SetCurrentWarToken(keep); } catch { }
                    UnlockTile(tile);
                }
            }
            catch { }
        }

        public static void MarkEnemyTurnStarted()
        {
            _enemyTurnActive = true;
            _enemySince = Time.unscaledTime;
            _lastEnemyActivity = Time.unscaledTime;
        }

        /// <summary>Camera smoothly centers on the province where combat or movement takes place.</summary>
        private static WarTile _lastCameraFocusTile;
        private static float _lastCameraFocusTime;

        public static void ShowEnemyMove(WarTile tile)
        {
            if (tile == null) return;
            _lastEnemyActivity = Time.unscaledTime;
            if (tile == _lastCameraFocusTile && Time.unscaledTime - _lastCameraFocusTime < 0.15f) return;
            _lastCameraFocusTile = tile;
            _lastCameraFocusTime = Time.unscaledTime;
            try
            {
                var mapCam = UnityEngine.Object.FindObjectOfType<MapCamera>();
                if (mapCam != null) mapCam.SetFollowTarget(null);
                var camMgr = Managers.Instance?.CameraManager ?? UnityEngine.Object.FindObjectOfType<CameraManager>();
                if (camMgr != null)
                {
                    try { camMgr.GoToWarTileCentered(tile); } catch { }
                }
                var scroller = UnityEngine.Object.FindObjectOfType<MapScroller>();
                if (scroller != null)
                {
                    try { scroller.GoToTarget(tile.transform); } catch { }
                }
                var mgr = TileMgr() ?? UnityEngine.Object.FindObjectOfType<WarTileManager>();
                if (mgr != null) mgr.LookAtTile(tile);
            }
            catch { }
            MelonLogger.Msg("[ZTABLE] Camera followed action to " + (tile.gameObject != null ? tile.gameObject.name : "tile") + ".");
        }

        public static void FocusBattleCamera(WarBattleManager.WarBattle battle)
        {
            if (battle == null) return;
            try
            {
                WarTile focus = null;
                long bKey = battle.Pointer.ToInt64();
                if (_battleContestedTiles.TryGetValue(bKey, out var ct) && ct != null)
                    focus = ct;
                if (focus == null && battle.defender != null)
                {
                    try { focus = battle.defender.GetCurrentWarTile(); } catch { }
                }
                if (focus == null && battle.attacker != null)
                {
                    try { focus = battle.attacker.GetCurrentWarTile(); } catch { }
                }
                if (focus != null) ShowEnemyMove(focus);
            }
            catch { }
        }

        private static void DeselectCurrentUnit()
        {
            try
            {
                var tokens = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (tokens != null) tokens.DeselectAllTokens();
            }
            catch { }
            try
            {
                var ray = UnityEngine.Object.FindObjectOfType<WarTileRaycaster>();
                if (ray != null) ray.ResetTouchSelection();
            }
            catch { }
            try
            {
                var icon = Panels.Instance != null ? Panels.Instance.WarTokenIndicatorPanel : null;
                if (icon != null) icon.Hide();
                ClearFortify();
                RepaintOccupied();
            }
            catch { }
        }

        private static bool _abilitiesLogged;

        /// <summary>Ensures the bottom war actions panel (airstrikes, air support, paratroopers, marines, fortify) stays visible during player turn.</summary>
        public static void EnsurePlayerActionsPanelVisible()
        {
            if (!ScenarioStarted || EditMode || DeploymentPanelOpen()) return;
            try
            {
                var flow = FlowMgr();
                if (flow != null && (flow.IsDisplayingEnemyMoves() || IsEnemyTurnActive())) return;

                var panel = Panels.Instance != null ? Panels.Instance.WarPlayerActionsPanel : UnityEngine.Object.FindObjectOfType<WarPlayerActionsPanel>();
                if (panel == null)
                {
                    var all = Resources.FindObjectsOfTypeAll<WarPlayerActionsPanel>();
                    if (all != null && all.Length > 0) panel = all[0];
                }
                if (panel == null) return;

                if (!panel.gameObject.activeSelf || !panel.isShowing)
                {
                    panel.gameObject.SetActive(true);
                    if (flow != null)
                    {
                        try { flow.UpdateWarPlayerActionsValues(); } catch { }
                        try { panel.Setup(flow.warActionPanelValues); } catch { }
                    }
                    try { panel.Show(); } catch { }
                }
            }
            catch { }
        }

        /// <summary>Bombers, fighters, paratroopers and marines stay gray until the player actually has them and they are off cooldown.</summary>
        private static void GrayUnavailableAbilities()
        {
            if (!ScenarioStarted) return;
            SyncBattleStatsUI();
            EnsurePlayerActionsPanelVisible();
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarPlayerActionsPanel : UnityEngine.Object.FindObjectOfType<WarPlayerActionsPanel>();
                if (panel == null || !panel.isActiveAndEnabled) return;
                var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                int strikeCd = flow != null ? flow.currentAirStrikeCooldown : 0;
                int airCd = flow != null ? flow.currentAirSupportCooldown : 0;
                bool strike = false;
                bool air = false;
                try { strike = flow != null && flow.CanPlayerAirStrike() && flow.GetAirStrikeCount() > 0 && strikeCd <= 0; } catch { }
                try { air = flow != null && flow.CanPlayerAirSupport() && (UnitPool("fighter") > 0 || UnitPool("air") > 0) && airCd <= 0; } catch { }
                LockAbility(panel.bombButtonData, strike);
                LockAbility(panel.airSupportButtonData, air);
                UpdateCooldownDisplay(panel.bombButtonData, strikeCd);
                UpdateCooldownDisplay(panel.airSupportButtonData, airCd);
                LockAbility(panel.paratrooperButtonData, UnitPool("paratroop") > 0);
                LockAbility(panel.navalInvasionButtonData, UnitPool("marine") > 0);
                if (!_abilitiesLogged)
                {
                    _abilitiesLogged = true;
                    MelonLogger.Msg("[ZTABLE] Ability buttons follow planes, paratroopers and marines on hand.");
                }
            }
            catch (Exception ex)
            {
                if (!_abilitiesLogged)
                {
                    _abilitiesLogged = true;
                    MelonLogger.Warning("[ZTABLE] abilities: " + ex.GetBaseException().Message);
                }
            }
        }

        private static int UnitPool(string name)
        {
            var ut = FindUnit(u =>
            {
                if (u == null) return false;
                string n = (u.name + " " + (u.UnitName ?? "")).ToLowerInvariant();
                return n.Contains(name);
            }, name);
            if (ut == null) return 0;
            return Math.Max(0, ut.UnitTotalCount);
        }

        /// <summary>
        /// OnTileEnter draws the action label from the game's own guess. Drop it when that guess is not a real action,
        /// so "Move" does not sit on a province the selected unit cannot enter.
        /// </summary>
        private static bool _moveEdgeLogged;

        private static bool Holdable(WarTile tile)
        {
            if (tile == null) return false;
            try
            {
                var action = tile.GetTileActionType();
                if (action != WarTile.TileActionType.None && action != WarTile.TileActionType.Select) return true;
            }
            catch { }
            return DeploymentTarget(tile);
        }

        /// <summary>A province the selected deployment unit is allowed to land on, even if the game's action guess says otherwise.</summary>
        public static bool IsDeploymentTarget(WarTile tile) => DeploymentTarget(tile);

        /// <summary>All Rizian and Derdian land (non-city) and naval start waters are valid deployment territories in Zille.</summary>
        public static bool IsZilleDeploymentTile(WarTile tile)
        {
            var td = TileDataOf(tile);
            if (td == null) return false;
            return ((td.Allegiance == "Rizia" || td.Allegiance == "Derdia") && !td.IsSea && !td.IsCity) || td.IsNavalStart;
        }

        /// <summary>Only the Rizian land that touches Wehlen has to be filled before Start.</summary>
        public static bool IsZilleFrontTile(WarTile tile)
        {
            var td = TileDataOf(tile);
            return td != null && td.IsBorder && !td.IsSea && !td.IsCity && td.Allegiance == "Rizia";
        }

        private static bool DeploymentTarget(WarTile tile)
        {
            var td = TileDataOf(tile);
            if (td == null) return false;
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (panel == null || !panel.IsShowing() || !panel.IsDeploymentUnitSelected()) return false;
                var unit = panel.GetSelectedUnitTypeData();
                if (unit == null || tile.GetCurrentToken() != null) return false;
                if (unit.unitType == WarUnitTypeData.UnitType.NavalUnit) return td.IsNavalStart;
                if (unit.unitType == WarUnitTypeData.UnitType.LandUnit) return (td.Allegiance == "Rizia" || td.Allegiance == "Derdia") && !td.IsSea && !td.IsCity;
            }
            catch { }
            return false;
        }

        private static void HidePromptUnlessLegal(WarTile tile)
        {
            if (tile == null || _ringOpen) return;
            try
            {
                var action = tile.GetTileActionType();
                var panel = Panels.Instance != null ? Panels.Instance.WarActionHoverPanel : null;
                if (panel == null) return;
                if (action != WarTile.TileActionType.None && action != WarTile.TileActionType.Select)
                {
                    panel.Setup(tile);
                    panel.Show();
                    ClearHoldFill();
                    return;
                }
                panel.Hide();
            }
            catch { }
        }

        public static void LockAbility(WarPlayerActionsPanel.WarPlayerActionButtonData data, bool available)
        {
            if (data == null) return;
            if (data.toggle != null)
            {
                data.toggle.interactable = available;
                if (!available && data.toggle.isOn) data.toggle.isOn = false;
            }
            if (data.canvasGroup != null)
            {
                data.canvasGroup.alpha = available ? 1f : 0.35f;
                data.canvasGroup.interactable = available;
                data.canvasGroup.blocksRaycasts = available;
            }
        }

        public static void UpdateCooldownDisplay(WarPlayerActionsPanel.WarPlayerActionButtonData data, int cd)
        {
            if (data == null) return;
            try
            {
                if (cd <= 0)
                {
                    if (data.cooldownValue != null)
                    {
                        data.cooldownValue.text = string.Empty;
                        data.cooldownValue.gameObject.SetActive(false);
                    }
                    if (data.cooldownBackground != null)
                    {
                        data.cooldownBackground.gameObject.SetActive(false);
                    }
                }
                else
                {
                    if (data.cooldownValue != null)
                    {
                        data.cooldownValue.gameObject.SetActive(true);
                        data.cooldownValue.text = cd.ToString();
                    }
                    if (data.cooldownBackground != null)
                    {
                        data.cooldownBackground.gameObject.SetActive(true);
                    }
                }
            }
            catch { }
        }

        private static int _chromeTries;
        private static bool _chromeHidden;
        private static bool _politicalHidden;
        private static bool _victoryShown;

        /// <summary>Royal decrees sit on the campaign's right edge and come back when a war turn ends. Keep that column closed for the whole operation.</summary>
        private static void HidePoliticalLeftovers()
        {
            if (_politicalHidden || !ScenarioStarted || DeploymentPanelOpen()) return;
            try { Panels.Instance?.HideAllRightPanels(); } catch { }
            Il2CppTMPro.TMP_Text[] all = null;
            try { all = UnityEngine.Object.FindObjectsOfType<Il2CppTMPro.TMP_Text>(); } catch { return; }
            if (all == null) return;
            for (int i = 0; i < all.Length; i++)
            {
                var label = all[i];
                if (label == null || !label.isActiveAndEnabled) continue;
                string s = label.text ?? "";
                if (s.Length == 0 || s.Length > 90) continue;
                bool decree = s.IndexOf("Resilient", StringComparison.OrdinalIgnoreCase) >= 0
                    || s.IndexOf("Armored", StringComparison.OrdinalIgnoreCase) >= 0
                    || s.IndexOf("Armoured", StringComparison.OrdinalIgnoreCase) >= 0
                    || s.IndexOf("Rail", StringComparison.OrdinalIgnoreCase) >= 0;
                if (!decree) continue;
                var button = label.GetComponentInParent<UnityEngine.UI.Button>();
                var target = button != null ? button.transform.parent != null ? button.transform.parent.gameObject : button.gameObject : label.gameObject;
                if (!target.activeSelf) continue;
                target.SetActive(false);
                MelonLogger.Msg("[ZTABLE] Hid political control '" + s + "' during the war.");
            }
            _politicalHidden = true;
        }

        /// <summary>The operation ends once every scenario city is in Rizian hands.</summary>
        /// <summary>
        /// Evaluates current city control across Brenas, Zille, and Wehlen to compute the 5 war outcomes.
        /// </summary>
        /// <summary>
        /// Evaluates current city control across Brenas, Zille, and Wehlen to compute the 5 war outcomes.
        /// </summary>
        public static ZilleWarOutcome EvaluateTableOutcome(out string summary)
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null)
            {
                summary = "Config missing";
                return ZilleWarOutcome.BloodyStalemate;
            }

            int brenasTotal = 0, brenasHeld = 0;
            int zilleTotal = 0, zilleHeld = 0;
            int wehlenDeepHeld = 0;
            bool zilleCityHeld = false;
            bool wiktranyHeld = false, munatHeld = false, nantaHeld = false;
            bool rotslaHeld = false, grodzizgHeld = false, kratsnaHeld = false, isorHeld = false;

            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                if (td == null || !td.IsCity) continue;

                var wt = FindLiveTile(td.TileNumber);
                WarToken tok = null;
                try { tok = wt != null ? wt.GetCurrentToken() : null; } catch { }

                bool heldByPlayer = (td.Allegiance == "Rizia" && (tok == null || tok.GetTokenAllegiance() != WarToken.WarAllegiance.Enemy))
                                    || (tok != null && tok.GetTokenAllegiance() == WarToken.WarAllegiance.Player);

                string name = td.Name ?? "";

                // Brenas cities (Home territory)
                if (name == "Mave Nortus" || name == "Dapalle" || name == "Marbelas")
                {
                    brenasTotal++;
                    if (heldByPlayer) brenasHeld++;
                }
                // Zille peninsula cities
                else if (name == "Zille City" || name == "Wiktrany" || name == "Munat" || name == "Nanta")
                {
                    zilleTotal++;
                    if (heldByPlayer)
                    {
                        zilleHeld++;
                        if (name == "Zille City") zilleCityHeld = true;
                        else if (name == "Wiktrany") wiktranyHeld = true;
                        else if (name == "Munat") munatHeld = true;
                        else if (name == "Nanta") nantaHeld = true;
                    }
                }
                // Deep Wehlen / Frontier cities
                else if (name == "Grodzizg" || name == "Kratsna" || name == "Rotsla" || name == "Isor")
                {
                    if (heldByPlayer)
                    {
                        wehlenDeepHeld++;
                        if (name == "Grodzizg") grodzizgHeld = true;
                        else if (name == "Kratsna") kratsnaHeld = true;
                        else if (name == "Rotsla") rotslaHeld = true;
                        else if (name == "Isor") isorHeld = true;
                    }
                }
            }

            int brenasLost = Math.Max(0, brenasTotal - brenasHeld);

            // Record captured state in campaign
            ZilleCampaignState.ZilleCityCaptured = zilleCityHeld;
            ZilleCampaignState.CapZilleCity = zilleCityHeld;
            ZilleCampaignState.CapWiktrany = wiktranyHeld;
            ZilleCampaignState.CapMunat = munatHeld;
            ZilleCampaignState.CapNanta = nantaHeld;
            ZilleCampaignState.CapRotsla = rotslaHeld;
            ZilleCampaignState.CapGrodzizg = grodzizgHeld;
            ZilleCampaignState.CapKratsna = kratsnaHeld;
            ZilleCampaignState.CapIsor = isorHeld;
            ZilleCampaignState.CapTotalCount = zilleHeld + wehlenDeepHeld;
            if (ZilleCampaignState.CurrentPhaseNumber == 1)
                ZilleCampaignState.Phase1CitiesCaptured = zilleHeld + wehlenDeepHeld;
            else
                ZilleCampaignState.Phase2CitiesCaptured = zilleHeld + wehlenDeepHeld;

            try
            {
                DialogueHelper.SetVariable("Zille_Cities_Held", zilleHeld);
                DialogueHelper.SetVariable("Zille_Brenas_Lost", brenasLost);
                DialogueHelper.SetVariable("Zille_City_Held", zilleCityHeld);
                ZilleCampaignState.SyncToLua();
            }
            catch { }

            // 1. Total Fiasco: Enemy captured >= 2 Brenas cities
            if (brenasLost >= 2)
            {
                summary = $"Total Fiasco: Brenas collapsed ({brenasLost} cities lost to Wehlen).";
                return ZilleWarOutcome.TotalFiasco;
            }

            // 2. Overwhelming Triumph: Zille City held, at least 3 Zille cities held, Brenas secure, plus deep Wehlen target captured!
            if (brenasLost == 0 && zilleCityHeld && zilleHeld >= 3 && wehlenDeepHeld >= 1)
            {
                summary = $"Overwhelming Triumph: Zille liberated + deep Wehlen target captured ({zilleHeld}/4 Zille cities, {wehlenDeepHeld} deep targets)!";
                return ZilleWarOutcome.OverwhelmingTriumph;
            }

            // 3. Decisive Victory: Zille City held, at least 3 Zille cities held (majority, at most 1 minor city left), Brenas secure
            if (brenasLost == 0 && zilleCityHeld && zilleHeld >= 3)
            {
                summary = $"Decisive Victory: Zille reclaimed ({zilleHeld}/4 cities held including Zille City)!";
                return ZilleWarOutcome.DecisiveVictory;
            }

            // 4. Tactical Defeat: Brenas held, but zero gains in Wehlen/Zille, or 1 Brenas city lost without gains
            if ((brenasLost == 0 && zilleHeld == 0 && wehlenDeepHeld == 0) || (brenasLost == 1 && zilleHeld == 0 && wehlenDeepHeld == 0))
            {
                summary = $"Tactical Defeat: Zero territorial gains achieved in Zille (Status Quo failure).";
                return ZilleWarOutcome.TacticalDefeat;
            }

            // 5. Bloody Stalemate: Partial gains (1-2 cities, or Zille City not held)
            summary = $"Bloody Stalemate: Partial capture ({zilleHeld}/4 Zille cities, Zille City held: {zilleCityHeld}, Brenas lost: {brenasLost}).";
            return ZilleWarOutcome.BloodyStalemate;
        }

        private static float _nextVictoryCheckTime;
        public static void CheckCityVictory(bool force = false)
        {
            if ((_victoryShown && !force) || !ScenarioStarted || DeploymentPanelOpen()) return;
            if (!force && Time.unscaledTime < _nextVictoryCheckTime) return;
            _nextVictoryCheckTime = Time.unscaledTime + 2.0f;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;

            var outcome = EvaluateTableOutcome(out string summary);

            // Total Fiasco: Brenas collapsed
            if (outcome == ZilleWarOutcome.TotalFiasco)
            {
                CaptureZillePhaseCasualties();
                _victoryShown = true;
                MelonLogger.Error($"[ZTABLE] Hex Campaign Collapse detected! Outcome: {outcome} ({summary})");
                try { WarOperationZilleManager.TriggerOutcome(outcome, summary); } catch { }
                try { DialogueHelper.ShowAlert($"Catastrophic Defeat: {summary}"); } catch { }
                try { WarOperationZilleManager.TriggerSmolakParley(); } catch { }
                return;
            }

            // Phase 1 handling
            if (ZilleCampaignState.CurrentPhaseNumber == 1)
            {
                if (outcome == ZilleWarOutcome.DecisiveVictory || outcome == ZilleWarOutcome.OverwhelmingTriumph)
                {
                    CaptureZillePhaseCasualties();
                    _victoryShown = true;
                    MelonLogger.Msg($"[ZTABLE] Early Decisive Victory achieved in Phase I! Outcome: {outcome} ({summary})");
                    try { WarOperationZilleManager.TriggerOutcome(outcome, summary); } catch { }
                    try { DialogueHelper.ShowAlert($"Decisive Victory: {summary}"); } catch { }
                }
                else if (force)
                {
                    // Phase I ended -> save board, mark Phase 1 complete, and transition civilian map to Mave Nortus Field HQ!
                    CaptureZillePhaseCasualties();
                    MelonLogger.Msg($"[ZTABLE] Phase I complete ({summary}). Preparing Mave Nortus Field HQ event...");
                    SavePhaseBoardState();
                    ZilleCampaignState.Phase1Finished = true;
                    ZilleCampaignState.MaveNortusHQAvailable = true;
                    ZilleCampaignState.MaveNortusHQCompleted = false;
                    ZilleCampaignState.Phase2EventUnlocked = false;
                    ZilleCampaignState.SyncToLua();
                    try { DialogueHelper.ShowAlert("Phase I Complete: Phase II briefings await at Mave Nortus Field HQ."); } catch { }
                    try { WarOperationZilleManager.PreparePostPhase1CivilianEvents(); } catch { }
                }
                return;
            }

            // Phase 2 handling
            if (outcome == ZilleWarOutcome.DecisiveVictory || outcome == ZilleWarOutcome.OverwhelmingTriumph)
            {
                CaptureZillePhaseCasualties();
                _victoryShown = true;
                MelonLogger.Msg($"[ZTABLE] Hex Campaign Victory achieved! Outcome: {outcome} ({summary})");
                try { WarOperationZilleManager.TriggerOutcome(outcome, summary); } catch { }
                try { DialogueHelper.ShowAlert($"Zille Operation Victory: {summary}"); } catch { }
            }
            else if (force)
            {
                CaptureZillePhaseCasualties();
                _victoryShown = true;
                MelonLogger.Msg($"[ZTABLE] Phase II concluded without full victory. Outcome: {outcome} ({summary}). Initiating peace parley...");
                try { WarOperationZilleManager.TriggerOutcome(outcome, summary); } catch { }
                try { DialogueHelper.ShowAlert($"Armistice Talks: {summary}"); } catch { }
                try { WarOperationZilleManager.TriggerSmolakParley(); } catch { }
            }
        }

        private static bool _unitChromeLogged;
        private static WarToken _statsToken;
        private static WarToken _iconToken;

        private static void HideProfileChrome()
        {
            if (_chromeHidden || _chromeTries > 10) return;
            _chromeTries++;
            int hidden = 0;
            var profiles = Resources.FindObjectsOfTypeAll<ProfileHUDPanel>();
            if (profiles != null)
            {
                for (int i = 0; i < profiles.Length; i++)
                {
                    var hud = profiles[i];
                    if (hud == null || !hud.gameObject.scene.IsValid() || !hud.gameObject.activeSelf) continue;
                    hud.gameObject.SetActive(false);
                    hidden++;
                }
            }
            var cornerPanels = Resources.FindObjectsOfTypeAll<BottomLeftPanel>();
            if (cornerPanels != null)
            {
                for (int i = 0; i < cornerPanels.Length; i++)
                {
                    var box = cornerPanels[i];
                    if (box == null || !box.gameObject.scene.IsValid() || !box.gameObject.activeSelf) continue;
                    box.gameObject.SetActive(false);
                    hidden++;
                }
            }
            var portraits = Resources.FindObjectsOfTypeAll<PortraitPanel>();
            if (portraits != null)
            {
                for (int i = 0; i < portraits.Length; i++)
                {
                    var p = portraits[i];
                    if (p == null || !p.gameObject.scene.IsValid()) continue;
                    var frame = p.transform.parent;
                    bool framed = frame != null && frame.GetComponent<UnityEngine.UI.Image>() != null && frame.childCount <= 6;
                    var target = framed && frame != null ? frame.gameObject : p.gameObject;
                    if (target.activeSelf)
                    {
                        target.SetActive(false);
                        hidden++;
                    }
                }
            }
            if (hidden > 0)
            {
                _chromeHidden = true;
                _chromeTries = 9999;
                MelonLogger.Msg("[ZTABLE] Profile chrome hidden.");
            }
        }

        public static void ShowProfileChrome()
        {
            var cornerPanels = Resources.FindObjectsOfTypeAll<BottomLeftPanel>();
            if (cornerPanels != null)
            {
                for (int i = 0; i < cornerPanels.Length; i++)
                {
                    var box = cornerPanels[i];
                    if (box == null || !box.gameObject.scene.IsValid()) continue;
                    if (!box.gameObject.activeSelf) box.gameObject.SetActive(true);
                }
            }
            var all = Resources.FindObjectsOfTypeAll<ProfileHUDPanel>();
            if (all != null)
            {
                for (int i = 0; i < all.Length; i++)
                {
                    var hud = all[i];
                    if (hud == null || !hud.gameObject.scene.IsValid()) continue;
                    if (!hud.gameObject.activeSelf) hud.gameObject.SetActive(true);
                }
            }
            var portraits = Resources.FindObjectsOfTypeAll<PortraitPanel>();
            if (portraits != null)
            {
                for (int i = 0; i < portraits.Length; i++)
                {
                    var p = portraits[i];
                    if (p == null || !p.gameObject.scene.IsValid()) continue;
                    if (!p.gameObject.activeSelf) p.gameObject.SetActive(true);
                    var frame = p.transform.parent;
                    if (frame != null && !frame.gameObject.activeSelf) frame.gameObject.SetActive(true);
                }
            }
            _chromeTries = 0;
            _chromeHidden = false;
        }

        /// <summary>Hover shows the Pales stat card. The unit symbol stays only while the unit is selected and the cursor is elsewhere.</summary>
        private static void PresentUnitChrome()
        {
            try
            {
                var stats = Panels.Instance != null ? Panels.Instance.WarTokenUnitStatsPanel : null;
                var icon = Panels.Instance != null ? Panels.Instance.WarTokenIndicatorPanel : null;
                var hovered = _hoverTile != null ? _hoverTile.GetCurrentToken() : null;
                if (hovered != null)
                {
                    var ut = hovered.GetWarUnitTypeData();
                    if (ut != null && ut.unitType == WarUnitTypeData.UnitType.City) hovered = null;
                }
                if (hovered != _statsToken)
                {
                    if (stats != null) stats.HideAll();
                    if (hovered != null && stats != null) stats.Show(hovered);
                    if (hovered != null && icon != null) icon.Hide();
                    _statsToken = hovered;
                }

                var sel = SelectedUnit();
                bool hoveringSelected = sel != null && hovered == sel;
                var wantIcon = sel != null && !hoveringSelected ? sel : null;
                if (wantIcon != _iconToken && icon != null)
                {
                    if (wantIcon != null)
                    {
                        icon.Setup(wantIcon);
                        icon.Show();
                    }
                    else icon.Hide();
                    _iconToken = wantIcon;
                }
                if (!_unitChromeLogged && (hovered != null || sel != null))
                {
                    _unitChromeLogged = true;
                    MelonLogger.Msg("[ZTABLE] Unit hover uses the Pales stat card.");
                }
            }
            catch (Exception ex)
            {
                if (!_unitChromeLogged)
                {
                    _unitChromeLogged = true;
                    MelonLogger.Warning("[ZTABLE] unit chrome: " + ex.GetBaseException().Message);
                }
            }
        }

        private static readonly HashSet<int> _battleLockedIds = new HashSet<int>();
        private static float _nextBattleUiSync;
        private static int _lastLoggedBattleCount = -1;

        /// <summary>True when a mobile unit is currently attacking, defending, or supporting inside an active battle.</summary>
        public static bool IsTokenEngagedInBattle(WarToken tok, out bool isSupporter)
        {
            isSupporter = false;
            if (tok == null || tok.IsDead() || IsCityToken(tok)) return false;
            try
            {
                var cb = tok.GetCurrentBattle();
                if (cb != null && !cb.isBattleOver && BattleLive(cb))
                {
                    if (cb.attackersSupporters != null && cb.attackersSupporters.Contains(tok)) isSupporter = true;
                    if (cb.defendersSupporters != null && cb.defendersSupporters.Contains(tok)) isSupporter = true;
                    return true;
                }
            }
            catch { }

            var bm = BattleMgr();
            var battles = bm != null ? bm.GetCurrentBattles() : null;
            if (battles == null) return false;
            for (int i = 0; i < battles.Count; i++)
            {
                var b = battles[i];
                if (b == null || b.isBattleOver || !BattleLive(b)) continue;
                if (b.attacker == tok || b.defender == tok) return true;
                if (b.attackersSupporters != null && b.attackersSupporters.Contains(tok)) { isSupporter = true; return true; }
                if (b.defendersSupporters != null && b.defendersSupporters.Contains(tok)) { isSupporter = true; return true; }
            }
            return false;
        }

        public static bool IsTokenEngagedInBattle(WarToken tok) => IsTokenEngagedInBattle(tok, out _);

        /// <summary>Ensures every active attacker, defender, and supporter carries the MovementLocked status tag while its battle is live.</summary>
        public static void SyncBattleMovementLocks()
        {
            try
            {
                var bm = BattleMgr();
                var battles = bm != null ? bm.GetCurrentBattles() : null;
                var liveTokens = new Dictionary<int, WarToken>();

                if (battles != null)
                {
                    for (int i = 0; i < battles.Count; i++)
                    {
                        var b = battles[i];
                        if (b == null || b.isBattleOver || !BattleLive(b)) continue;
                        void Collect(WarToken t)
                        {
                            if (t == null || t.IsDead() || IsCityToken(t)) return;
                            liveTokens[t.GetInstanceID()] = t;
                        }
                        Collect(b.attacker);
                        Collect(b.defender);
                        if (b.attackersSupporters != null)
                            for (int s = 0; s < b.attackersSupporters.Count; s++) Collect(b.attackersSupporters[s]);
                        if (b.defendersSupporters != null)
                            for (int s = 0; s < b.defendersSupporters.Count; s++) Collect(b.defendersSupporters[s]);
                    }
                }

                var effPanel = Panels.Instance != null ? Panels.Instance.WarTokenStatusEffectsPanel : null;
                foreach (var kv in liveTokens)
                {
                    var tok = kv.Value;
                    _battleLockedIds.Add(kv.Key);
                    bool hasEff = false;
                    try { hasEff = tok.IsMovementLocked(); } catch { }
                    if (!hasEff)
                    {
                        try { tok.AddTokenStatusEffect(WarToken.WarTokenStatusEffectType.MovementLocked); } catch { }
                    }
                    try { effPanel?.Add(tok, WarToken.WarTokenStatusEffectType.MovementLocked); } catch { }
                }

                if (_battleLockedIds.Count > 0)
                {
                    var allTokens = UnityEngine.Object.FindObjectsOfType<WarToken>();
                    var removeIds = new List<int>();
                    foreach (int id in _battleLockedIds)
                    {
                        if (liveTokens.ContainsKey(id)) continue;
                        removeIds.Add(id);
                        if (allTokens != null)
                        {
                            for (int i = 0; i < allTokens.Length; i++)
                            {
                                var tok = allTokens[i];
                                if (tok != null && tok.GetInstanceID() == id && !tok.IsDead()
                                    && !IsDepletedProtectionActive(tok) && !tok.IsOrganizationDepleted())
                                {
                                    try { tok.RemoveTokenStatusEffect(WarToken.WarTokenStatusEffectType.MovementLocked); } catch { }
                                    try { effPanel?.Remove(tok, WarToken.WarTokenStatusEffectType.MovementLocked); } catch { }
                                    break;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < removeIds.Count; i++) _battleLockedIds.Remove(removeIds[i]);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] SyncBattleMovementLocks: " + ex.Message);
            }
        }

        public static void ClearBattleMovementLockTracking()
        {
            _battleLockedIds.Clear();
        }

        /// <summary>Ensures WarBattlePanel and its TemplateBattle both-sides stats widget stay populated, updated, and positioned on screen for every active battle.</summary>
        public static void SyncBattleStatsUI(WarBattleManager.WarBattle hoveredBattle = null)
        {
            if (!ScenarioStarted || EditMode) return;
            if (hoveredBattle == null && Time.unscaledTime < _nextBattleUiSync) return;
            _nextBattleUiSync = Time.unscaledTime + 0.15f;

            try
            {
                var bm = BattleMgr();
                var battles = bm != null ? bm.GetCurrentBattles() : null;
                var panel = Panels.Instance != null ? Panels.Instance.WarBattlePanel : UnityEngine.Object.FindObjectOfType<WarBattlePanel>();
                if (panel == null) return;

                int liveCount = 0;
                if (battles != null)
                {
                    for (int i = 0; i < battles.Count; i++)
                    {
                        var b = battles[i];
                        if (b != null && !b.isBattleOver && BattleLive(b)) liveCount++;
                    }
                }

                if (liveCount == 0)
                {
                    if (_lastLoggedBattleCount != 0)
                    {
                        _lastLoggedBattleCount = 0;
                        try { panel.HideAllBattles(); } catch { }
                    }
                    return;
                }

                if (!panel.gameObject.activeSelf) panel.gameObject.SetActive(true);
                if (panel.container != null && !panel.container.gameObject.activeSelf) panel.container.gameObject.SetActive(true);

                var inst = panel.instantiatedBattles;
                static bool SameBattle(WarBattleManager.WarBattle a, WarBattleManager.WarBattle b)
                {
                    if (a == null || b == null) return false;
                    if (a.Pointer == b.Pointer) return true;
                    return a.attacker == b.attacker && a.defender == b.defender;
                }

                // Prune duplicate or dead TemplateBattle widgets first
                if (inst != null)
                {
                    var seen = new List<WarBattleManager.WarBattle>();
                    var toRemove = new List<TemplateBattle>();
                    for (int j = 0; j < inst.Count; j++)
                    {
                        var tb = inst[j];
                        if (tb == null || tb.currentBattle == null || tb.currentBattle.isBattleOver || !BattleLive(tb.currentBattle))
                        {
                            if (tb != null) toRemove.Add(tb);
                            continue;
                        }
                        bool dup = false;
                        for (int k = 0; k < seen.Count; k++)
                        {
                            if (SameBattle(seen[k], tb.currentBattle)) { dup = true; break; }
                        }
                        if (dup) toRemove.Add(tb);
                        else seen.Add(tb.currentBattle);
                    }
                    for (int j = 0; j < toRemove.Count; j++)
                    {
                        try { panel.RemoveBattle(toRemove[j]); } catch { }
                    }
                }

                for (int i = 0; i < battles.Count; i++)
                {
                    var b = battles[i];
                    if (b == null || b.isBattleOver || !BattleLive(b)) continue;

                    bool exists = false;
                    inst = panel.instantiatedBattles;
                    if (inst != null)
                    {
                        for (int j = 0; j < inst.Count; j++)
                        {
                            var tb = inst[j];
                            if (tb != null && SameBattle(tb.currentBattle, b))
                            {
                                exists = true;
                                break;
                            }
                        }
                    }
                    if (!exists)
                    {
                        try { panel.Setup(b); } catch (Exception ex) { MelonLogger.Warning("[ZTABLE BATTLE-UI] Setup: " + ex.Message); }
                    }
                }

                try { bm.UpdateAllBattleStats(); } catch { }
                try { panel.UpdateAllBattles(battles); } catch { }

                if (hoveredBattle == null && _hoverTile != null)
                    hoveredBattle = BattleInvolvingTile(_hoverTile);

                if (hoveredBattle != null && !hoveredBattle.isBattleOver && BattleLive(hoveredBattle))
                {
                    try { panel.ShowBattle(hoveredBattle); } catch { }
                }

                // Ensure every live TemplateBattle instance actually renders over its contested tile
                inst = panel.instantiatedBattles;
                Camera cam = WarCamera();
                var supporterTokensWithStat = new HashSet<IntPtr>();
                if (inst != null)
                {
                    for (int j = 0; j < inst.Count; j++)
                    {
                        var tb = inst[j];
                        if (tb == null || tb.currentBattle == null || tb.currentBattle.isBattleOver || !BattleLive(tb.currentBattle)) continue;
                        if (!tb.gameObject.activeSelf) tb.gameObject.SetActive(true);
                        int expectedSupporters = (tb.currentBattle.attackersSupporters != null ? tb.currentBattle.attackersSupporters.Count : 0)
                                               + (tb.currentBattle.defendersSupporters != null ? tb.currentBattle.defendersSupporters.Count : 0);
                        int actualStats = tb.instantiatedBattleTokenStats != null ? tb.instantiatedBattleTokenStats.Count : 0;
                        if (actualStats != expectedSupporters)
                        {
                            try { tb.Setup(tb.currentBattle); } catch { }
                        }
                        bool isHovered = hoveredBattle != null && SameBattle(tb.currentBattle, hoveredBattle);
                        try
                        {
                            if (isHovered) tb.Show();
                            else tb.Hide();
                        }
                        catch { }
                        try
                        {
                            if (tb.canvasGroup != null && tb.canvasGroup.alpha < 0.99f)
                                tb.canvasGroup.alpha = 1f;
                        }
                        catch { }

                        if (cam != null && tb.panelRect != null && tb.canvasRect != null)
                        {
                            Vector3 worldPos = tb.currentBattle.defender != null ? tb.currentBattle.defender.transform.position
                                             : (tb.currentBattle.attacker != null ? tb.currentBattle.attacker.transform.position : Vector3.zero);
                            if (bm != null)
                            {
                                try
                                {
                                    var cpos = bm.GetBattleCenterPosition(tb.currentBattle);
                                    if (cpos != Vector3.zero) worldPos = cpos;
                                }
                                catch { }
                            }
                            if (worldPos != Vector3.zero)
                            {
                                Vector3 sp = cam.WorldToScreenPoint(worldPos + new Vector3(0f, 0.035f, 0f));
                                if (sp.z > 0.01f)
                                {
                                    var parentCanvas = tb.GetComponentInParent<Canvas>();
                                    Camera uiCam = parentCanvas != null && parentCanvas.renderMode != RenderMode.ScreenSpaceOverlay ? parentCanvas.worldCamera : null;
                                    if (RectTransformUtility.ScreenPointToLocalPointInRectangle(tb.canvasRect, new Vector2(sp.x, sp.y), uiCam, out Vector2 lp))
                                    {
                                        tb.panelRect.anchoredPosition = lp;
                                    }
                                }
                            }
                        }

                        // Keep support value badges visible at all times and offset slightly right so they never replace/cover the lock icon
                        if (tb.instantiatedBattleTokenStats != null)
                        {
                            for (int s = 0; s < tb.instantiatedBattleTokenStats.Count; s++)
                            {
                                var stat = tb.instantiatedBattleTokenStats[s];
                                if (stat == null) continue;
                                if (!stat.gameObject.activeSelf) stat.gameObject.SetActive(true);
                                var tok = stat.currentToken;
                                if (tok != null && !tok.IsDead())
                                {
                                    supporterTokensWithStat.Add(tok.Pointer);
                                    if (cam != null && stat.panelRect != null && stat.canvasRect != null)
                                    {
                                        Vector3 sp = cam.WorldToScreenPoint(tok.transform.position);
                                        if (sp.z > 0.01f)
                                        {
                                            var pCanvas = stat.GetComponentInParent<Canvas>();
                                            Camera uiCam = pCanvas != null && pCanvas.renderMode != RenderMode.ScreenSpaceOverlay ? pCanvas.worldCamera : null;
                                            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(stat.canvasRect, new Vector2(sp.x, sp.y), uiCam, out Vector2 lp))
                                            {
                                                stat.panelRect.anchoredPosition = lp + stat.offset + new Vector2(20f, 0f);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // Shift the lock status-effect icon slightly left on supporting units so both icons remain visible side-by-side
                if (supporterTokensWithStat.Count > 0 && cam != null)
                {
                    var effPanel = Panels.Instance != null ? Panels.Instance.WarTokenStatusEffectsPanel : null;
                    var effList = effPanel != null ? effPanel.instantiatedWarTokenStatusEffects : null;
                    if (effList != null)
                    {
                        for (int e = 0; e < effList.Count; e++)
                        {
                            var eff = effList[e];
                            if (eff == null || eff.currentWarToken == null) continue;
                            if (!supporterTokensWithStat.Contains(eff.currentWarToken.Pointer)) continue;
                            if (!eff.gameObject.activeSelf) eff.gameObject.SetActive(true);
                            if (eff.panelRect != null && eff.canvasRect != null)
                            {
                                Vector3 sp = cam.WorldToScreenPoint(eff.currentWarToken.transform.position);
                                if (sp.z > 0.01f)
                                {
                                    var pCanvas = eff.GetComponentInParent<Canvas>();
                                    Camera uiCam = pCanvas != null && pCanvas.renderMode != RenderMode.ScreenSpaceOverlay ? pCanvas.worldCamera : null;
                                    if (RectTransformUtility.ScreenPointToLocalPointInRectangle(eff.canvasRect, new Vector2(sp.x, sp.y), uiCam, out Vector2 lp))
                                    {
                                        eff.panelRect.anchoredPosition = lp + eff.offset + new Vector2(-20f, 0f);
                                    }
                                }
                            }
                        }
                    }
                }

                if (_lastLoggedBattleCount != liveCount)
                {
                    _lastLoggedBattleCount = liveCount;
                    int tbCount = inst != null ? inst.Count : 0;
                    string sampleInfo = "none";
                    if (inst != null && inst.Count > 0 && inst[0] != null)
                    {
                        var first = inst[0];
                        Vector2 ap = first.panelRect != null ? first.panelRect.anchoredPosition : Vector2.zero;
                        Vector2 sd = first.panelRect != null ? first.panelRect.sizeDelta : Vector2.zero;
                        Vector3 sc = first.panelRect != null ? first.panelRect.localScale : Vector3.zero;
                        float al = first.canvasGroup != null ? first.canvasGroup.alpha : -1f;
                        var pCanvas = panel.GetComponentInParent<Canvas>();
                        string cMode = pCanvas != null ? pCanvas.renderMode.ToString() : "null";
                        sampleInfo = $"active={first.gameObject.activeInHierarchy}, canvas={cMode}, pos=({ap.x:0.0},{ap.y:0.0}), size=({sd.x:0},{sd.y:0}), scale=({sc.x:0.0},{sc.y:0.0}), alpha={al:0.00}, atk={first.currentBattle?.totalAttack}, def={first.currentBattle?.totalDefence}";
                    }
                    MelonLogger.Msg($"[ZTABLE BATTLE-UI] liveBattles={liveCount}, panelActive={panel.gameObject.activeInHierarchy}, templateCount={tbCount}, first=[{sampleInfo}]");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE BATTLE-UI] SyncBattleStatsUI: " + ex.Message);
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

        private static int _lastActionTurn = -1;

        /// <summary>This save starts the operation on zero action points, so the turn opens already finished. The budget has to be written before Start, and the banner the game shows at zero has to be dismissed once the turn actually has moves.</summary>
        private static void EnsureActionPoints()
        {
            var flow = FlowMgr();
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

            int curTurn = flow.GetCurrentWarTurn();
            if (curTurn != _lastActionTurn)
            {
                _lastActionTurn = curTurn;
                _pointsGranted = false;
                _bannerCleared = false;
            }

            // NEVER grant action points during enemy moves, combat or enemy turn!
            if (IsEnemyTurnActive() || flow.IsDisplayingEnemyMoves() || _enemyRunning) return;

            if (!_pointsGranted)
            {
                try { flow.currentActionPoints = want; } catch { }
                _pointsGranted = true;
                MelonLogger.Msg($"[ZTABLE] Action points for player turn {curTurn}: {want}.");
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

        public static bool IsPlayerUnit(WarUnitTypeData u)
        {
            if (u == null || u.IsCity() || IsAirUnit(u)) return false;
            var a = u.unitAlignment;
            if (a == WarUnitTypeData.UnitAlignment.RizianArmy ||
                a == WarUnitTypeData.UnitAlignment.HouseToras ||
                a == WarUnitTypeData.UnitAlignment.HouseAzaro ||
                a == WarUnitTypeData.UnitAlignment.HouseSazon)
                return true;

            string alignStr = a.ToString();
            return alignStr.IndexOf("GoldenGuard", StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private static bool IsPlayerSideUnitIncludingAir(WarUnitTypeData u)
        {
            if (u == null || u.IsCity()) return false;
            var a = u.unitAlignment;
            if (a == WarUnitTypeData.UnitAlignment.RizianArmy ||
                a == WarUnitTypeData.UnitAlignment.HouseToras ||
                a == WarUnitTypeData.UnitAlignment.HouseAzaro ||
                a == WarUnitTypeData.UnitAlignment.HouseSazon)
                return true;

            string alignStr = a.ToString();
            return alignStr.IndexOf("GoldenGuard", StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private static bool IsDeployablePanelUnit(WarUnitTypeData u)
        {
            if (!IsPlayerUnit(u)) return false;
            string n = (u.name + " " + (u.UnitName ?? "")).ToLowerInvariant();
            // Paratroopers and Marines are ability-only special units (Paradrop / Naval Invasion), never placed from Deployment Panel
            if (n.Contains("paratroop") || n.Contains("airborne")) return false;
            if (n.Contains("marine") && !n.Contains("submarine")) return false;
            return true;
        }

        private static int ResolveStateMilitaryCount(WarUnitTypeData u)
        {
            string n = (u.name + " " + (u.UnitName ?? "")).ToLowerInvariant();
            if (n.Contains("bomber")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Bomber_Total");
            if (n.Contains("fighter")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Fighter_Total");
            if (n.Contains("flagship")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Flagship_Total");
            if (n.Contains("submarine")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Submarine_Total");
            if (n.Contains("militaryship") || n.Contains("ship") || n.Contains("destroyer") || n.Contains("battleship"))
                return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Ship_Total");
            if (n.Contains("azaro")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Azaro_Total");
            if (n.Contains("sazon")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Sazon_Total");
            if (n.Contains("toras")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Toras_Total");
            if (n.Contains("golden")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_GoldenGuard_Total");
            if (n.Contains("mercenary")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Mercenary_Total");
            if (n.Contains("tank") || n.Contains("armor")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Tank_Total");
            if (n.Contains("support")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Support_Total");
            if (n.Contains("mountain")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Mountaineer_Total");
            if (n.Contains("paratroop")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Paratrooper_Total");
            if (n.Contains("marine")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Marine_Total");
            if (n.Contains("militia")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Militia_Total");
            if (n.Contains("infantry")) return DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Infantry_Total");
            return u.UnitTotalCount;
        }

        private struct PreZilleLedgerEntry
        {
            public int Avail;
            public int Deployed;
        }

        private static readonly Dictionary<string, PreZilleLedgerEntry> _preZilleLedger = new Dictionary<string, PreZilleLedgerEntry>();
        private static bool _hasPreZilleLedger = false;

        /// <summary>Captures Rizia's reserve & Pales-deployed unit counts BEFORE entering the Zille table or queuing Wehlen tokens.</summary>
        public static void SnapshotPreZilleMilitaryLedger()
        {
            if (_hasPreZilleLedger) return;
            var all = Resources.FindObjectsOfTypeAll<WarUnitTypeData>();
            if (all == null || all.Length == 0) return;

            _preZilleLedger.Clear();
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < all.Length; i++)
            {
                var u = all[i];
                if (!IsPlayerSideUnitIncludingAir(u) || string.IsNullOrEmpty(u.name)) continue;
                int avail = Math.Max(0, ResolveStateMilitaryCount(u));
                int dep = Math.Max(0, u.UnitDeployedCount);
                _preZilleLedger[u.name] = new PreZilleLedgerEntry { Avail = avail, Deployed = dep };
                if (avail > 0 || dep > 0)
                    sb.Append($"{u.name}={avail}(dep={dep}) ");
            }
            _hasPreZilleLedger = true;
            MelonLogger.Msg($"[ZTABLE] Snapshotted pre-Zille Rizia arsenal: {sb}");
        }

        public static void ResetPreZilleMilitaryLedger()
        {
            _hasPreZilleLedger = false;
            _preZilleLedger.Clear();
        }

        /// <summary>Ensures player unit pool strictly reflects state military recruitment ledger (minus units already deployed here or in Pales).</summary>
        public static void EnsurePlayerPool()
        {
            var all = Resources.FindObjectsOfTypeAll<WarUnitTypeData>();
            if (all == null || all.Length == 0) return;

            // Count living non-city player units already placed on the live Zille board right now
            var boardDeployed = new Dictionary<string, int>();
            try
            {
                var tm = TokenMgr() ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                var tokens = tm != null ? tm.GetWarTokens() : null;
                if (tokens != null)
                {
                    for (int i = 0; i < tokens.Count; i++)
                    {
                        var tok = tokens[i];
                        if (tok == null || tok.IsDead() || IsCityToken(tok)) continue;
                        if (tok.GetTokenAllegiance() != WarToken.WarAllegiance.Player) continue;
                        var ut = tok.GetWarUnitTypeData();
                        if (ut == null || string.IsNullOrEmpty(ut.name)) continue;
                        boardDeployed.TryGetValue(ut.name, out int cur);
                        boardDeployed[ut.name] = cur + 1;
                    }
                }
            }
            catch { }

            MelonLogger.Msg($"[ZTABLE] EnsurePlayerPool entry: hasPreLedger={_hasPreZilleLedger}, Lua Inf={DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Infantry_Total")}, Budg={DialogueHelper.GetIntVariable("RiziaDLC.Resources_Budget")}");

            for (int i = 0; i < all.Length; i++)
            {
                var u = all[i];
                if (!IsPlayerSideUnitIncludingAir(u)) continue;
                int rawUtTotal = u.UnitTotalCount;
                int rawUtDead = u.UnitDeadCount;
                int rawUtDep = u.UnitDeployedCount;
                int rawUtMiss = u.UnitOnMissionCount;

                int onZilleBoard = 0;
                if (!string.IsNullOrEmpty(u.name)) boardDeployed.TryGetValue(u.name, out onZilleBoard);

                int baseAvail = Math.Max(0, ResolveStateMilitaryCount(u));
                int baseDep = Math.Max(0, rawUtDep);
                if (_hasPreZilleLedger && !string.IsNullOrEmpty(u.name) && _preZilleLedger.TryGetValue(u.name, out var snap))
                {
                    baseAvail = snap.Avail;
                    baseDep = snap.Deployed;
                }

                int exactCount = Math.Max(0, baseAvail - onZilleBoard);
                int exactDep = Math.Max(0, baseDep + onZilleBoard);
                if (u.UnitTotalCount != exactCount) u.UnitTotalCount = exactCount;
                if (u.UnitDeployedCount != exactDep) u.UnitDeployedCount = exactDep;
                MelonLogger.Msg($"[ZTABLE] State ledger '{u.name}' ({u.UnitName}) align={u.unitAlignment}: avail={u.UnitTotalCount} (saveBase={baseAvail}, palesDep={baseDep}, zilleBoard={onZilleBoard}, rawTotal={rawUtTotal}, dead={rawUtDead}, miss={rawUtMiss})");
            }

            // Rebuild WarDeploymentPanel.availableDeploymentUnits cleanly from state inventory
            var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
            if (panel != null)
            {
                if (panel.availableDeploymentUnits == null)
                    panel.availableDeploymentUnits = new Il2CppSystem.Collections.Generic.List<WarUnitTypeData>();

                panel.availableDeploymentUnits.Clear();
                var added = new HashSet<string>();

                for (int i = 0; i < all.Length; i++)
                {
                    var u = all[i];
                    if (!IsDeployablePanelUnit(u)) continue;
                    if (u.UnitTotalCount <= 0) continue;

                    if (added.Add(u.name))
                    {
                        panel.availableDeploymentUnits.Add(u);
                        MelonLogger.Msg($"[ZTABLE] Deployment panel unit '{u.name}' ({u.UnitName}): {u.UnitTotalCount}.");
                    }
                }

                try { panel.Setup(); } catch { }
                try { panel.UpdateDeployingUnitCount(); } catch { }
            }
        }

        /// <summary>The native Start button stays locked until every Rizian border province has a land unit. Place them through the deployment panel so the count and the refund list stay honest.</summary>
        private static void FillFrontlineFromPanel()
        {
            if (ZilleCampaignState.CurrentPhaseNumber == 2) return;
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
                    RunScripted(() => panel.DeployToken(infantry, wt));
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

        /// <summary>Places the selected v13 Wehlen preset. One unit per province, never on a city, never on a Rizia ship sea.</summary>
        private static void PlaceV13Deployment()
        {
            if (ZilleCampaignState.CurrentPhaseNumber == 2)
            {
                _garrisonsPlaced = true;
                return;
            }
            ZilleDeployment.RefreshFromCampaign();
            if (ZilleDeployment.Units.Count == 0)
            {
                if (_warnedMissing.Add("no-deployment"))
                    MelonLogger.Warning("[ZTABLE] No Wehlen deployment units loaded.");
                _garrisonsPlaced = true;
                return;
            }
            if (UnitTypes().Count == 0) return;
            int placed = 0, occupied = 0, unmatched = 0, missingTile = 0, skipped = 0;
            for (int i = 0; i < ZilleDeployment.Units.Count; i++)
            {
                var entry = ZilleDeployment.Units[i];
                ZilleTileData td = null;
                var tiles = ZilleMapLayoutManager.CurrentConfig?.Tiles;
                if (tiles != null)
                {
                    for (int t = 0; t < tiles.Count; t++)
                        if (tiles[t].TileNumber == entry.TileNumber) { td = tiles[t]; break; }
                }
                if (td == null || td.IsDisabled || td.IsCity || ZilleDeployment.IsForbiddenCity(td.TileNumber))
                {
                    skipped++;
                    continue;
                }
                var wt = FindLiveTile(td.TileNumber);
                if (wt == null)
                {
                    missingTile++;
                    continue;
                }
                if (wt.GetCurrentToken() != null)
                {
                    occupied++;
                    continue;
                }
                var ut = MatchDeploymentUnit(entry.UnitType, null);
                if (ut == null)
                {
                    unmatched++;
                    continue;
                }
                string msg = PlaceUnit(td, ut, true);
                if (msg.StartsWith("Postawiono")) placed++;
            }
            if (missingTile > ZilleDeployment.Units.Count / 2) return;
            _garrisonsPlaced = true;
            MelonLogger.Msg("[ZTABLE] Wehlen deployment '" + ZilleDeployment.Preset + "': placed " + placed
                + ", already occupied " + occupied + ", unmatched " + unmatched
                + ", tile missing " + missingTile + ", skipped " + skipped + ".");
        }

        /// <summary>Wehlen units sit on the border the way Pales garrisons do, without stacking on a city star.</summary>
        private static void EnsureEnemyGarrisons()
        {
            if (_garrisonsPlaced || _root == null) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            RemoveEnemyFromRizianStart(cfg);
            if (cfg != null && !string.IsNullOrEmpty(cfg.Version) && cfg.Version.StartsWith("v14"))
            {
                PlaceV13Deployment();
                return;
            }
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

        private static void RemoveEnemyFromRizianStart(ZilleMapConfig cfg)
        {
            var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            if (mgr == null || cfg?.Tiles == null) return;
            int removed = 0;
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                bool ours = (td.Allegiance == "Rizia" && !td.IsSea) || td.IsNavalStart;
                if (!ours) continue;
                var wt = FindLiveTile(td.TileNumber);
                var tok = wt != null ? wt.GetCurrentToken() : null;
                if (tok == null || tok.GetTokenAllegiance() != WarToken.WarAllegiance.Enemy) continue;
                try
                {
                    mgr.DestroyToken(tok);
                    removed++;
                }
                catch { }
            }
            if (removed > 0)
                MelonLogger.Msg("[ZTABLE] Enemy units taken off the Rizian start: " + removed + ".");
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


        private static bool _peaksDone;

        /// <summary>Clean up any mountain marker primitives from tiles.</summary>
        private static void SyncMountainMarkers()
        {
            if (_peaksDone) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;
            bool live = false;
            foreach (var td in cfg.Tiles)
            {
                if (string.IsNullOrEmpty(td.TileNumber)) continue;
                var tile = FindLiveTile(td.TileNumber);
                if (tile == null) continue;
                live = true;
                Transform peak = tile.transform.Find("ZilleMountain");
                if (peak != null)
                {
                    UnityEngine.Object.Destroy(peak.gameObject);
                }
            }
            if (live) _peaksDone = true;
        }

        private static readonly Dictionary<int, float> _tokenScale = new Dictionary<int, float>();

        /// <summary>Units and ordinary cities grow a little. Zille and Kratsna grow a lot.</summary>
        private static float _nextScale;

        private static void ScaleTokens()
        {
            if (Time.unscaledTime < _nextScale) return;
            _nextScale = Time.unscaledTime + 1.5f;
            if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            var tokens = _tokenMgr != null ? _tokenMgr.GetWarTokens() : null;
            if (tokens == null || tokens.Count == 0) return;
            for (int i = 0; i < tokens.Count; i++)
            {
                var tok = tokens[i];
                if (tok == null || !tok.gameObject.scene.IsValid()) continue;
                int id = tok.GetInstanceID();
                float want = 1.22f;
                bool city = false;
                try { city = tok.IsCity(); } catch { }
                if (city)
                {
                    string name = "";
                    try
                    {
                        var td = TileDataOf(tok.GetCurrentWarTile());
                        name = CityCaption(td);
                    }
                    catch { }
                    want = name.IndexOf("Zille", StringComparison.OrdinalIgnoreCase) >= 0
                        || name.IndexOf("Kratsna", StringComparison.OrdinalIgnoreCase) >= 0
                        ? 2.35f : 1.48f;
                }
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
            if (EditMode || ScenarioStarted) return;
            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow == null) return;
            try
            {
                if (!_deploymentReady && ZilleCampaignState.CurrentPhaseNumber == 1)
                {
                    try { flow.currentWarTurn = 0; } catch { }
                }
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
            EnsurePlayerActionsPanelVisible();
            _barStatus = "Scenariusz wystartowal.";
            MelonLogger.Msg("[ZTABLE] Play: deployment finished, operation started.");
        }

        private static Camera _cachedWarCam;
        private static float _nextCamCheck;

        /// <summary>The camera that is actually framing the war table, not whichever one is tagged Main.</summary>
        public static Camera WarCamera()
        {
            if (_cachedWarCam != null && _cachedWarCam.enabled && _cachedWarCam.gameObject.activeInHierarchy)
            {
                if (Time.unscaledTime < _nextCamCheck) return _cachedWarCam;
            }
            _nextCamCheck = Time.unscaledTime + 1.0f;
            if (_root == null) return Camera.main;

            Vector3 probe = _root.position;
            var centerTile = FindLiveTile("35");
            if (centerTile != null) probe = centerTile.transform.position;

            Camera bestCam = null;
            float bestScore = -1f;
            var cams = Camera.allCameras;
            for (int i = 0; i < cams.Length; i++)
            {
                var c = cams[i];
                if (c == null || !c.enabled || !c.gameObject.activeInHierarchy) continue;
                var vp = c.WorldToViewportPoint(probe);
                if (vp.z <= 0.05f) continue;
                float score = 0f;
                if (vp.x >= 0f && vp.x <= 1f && vp.y >= 0f && vp.y <= 1f) score += 2000f;
                if (c.GetComponent<MapCamera>() != null || c.GetComponentInParent<MapCamera>() != null) score += 500f;
                if (c == Camera.main) score += 100f;
                score += c.pixelWidth;
                if (score > bestScore) { bestScore = score; bestCam = c; }
            }
            _cachedWarCam = bestCam != null ? bestCam : Camera.main;
            return _cachedWarCam;
        }

        private static float _nextPropSearchTime;

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
                if (Time.unscaledTime < _nextPropSearchTime) return;
                _nextPropSearchTime = Time.unscaledTime + 2.0f;
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
                if (h.localOffset != Vector3.zero)
                {
                    h.t.localPosition = h.baseLocal + h.localOffset;
                    continue;
                }
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
            var wait = new WaitForSeconds(0.04f);
            while (true)
            {
                if (_propHolds.Count > 0) HoldProps();
                yield return wait;
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

        private static bool _advEditOpen = false;
        private static bool _roadChain = false;
        private static int _editUnitIdx = 0;
        private static bool _editUnitEnemy = false;

        private static Rect AdvEditPanelRect()
        {
            var bar = MapEditBarRect();
            float w = 640f;
            float h = 230f;
            return new Rect(bar.x, bar.y - h - 6f, w, h);
        }

        public static void HandleMapEdit(Event e)
        {
            if (ScenarioStarted) return;
            if (e == null || _root == null || !SkinEnabled) return;
            if (ZilleWarMapEditorUI.AnyOpen) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || cfg.Tiles.Count == 0) return;

            var bar = MapEditBarRect();
            bool overBar = bar.Contains(e.mousePosition) || (_advEditOpen && AdvEditPanelRect().Contains(e.mousePosition));
            if ((e.type == EventType.MouseMove || e.type == EventType.MouseDrag) && !overBar)
                _hover = HitTile(e);
            if (e.type == EventType.MouseDown && e.button == 0 && !overBar && e.mousePosition.x > 280f)
            {
                int hit = HitTile(e);
                if (hit >= 0)
                {
                    if ((_roadArm || _roadChain) && _mapSel >= 0 && _mapSel < cfg.Tiles.Count && hit != _mapSel)
                    {
                        ZilleMapLayoutManager.ToggleRoad(cfg.Tiles[_mapSel], cfg.Tiles[hit]);
                        InvalidateRoads();
                        RequestApply();
                        if (_roadArm) _roadArm = false;
                        _mapSel = hit;
                        e.Use();
                    }
                    else
                        _mapSel = hit;
                }
            }
            if (_mapSel >= 0 && _mapSel < cfg.Tiles.Count && e.shift && e.type == EventType.MouseDrag && e.button == 0 && !overBar)
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
            if (_root == null || !SkinEnabled || ScenarioStarted || ZilleWarMapEditorUI.AnyOpen || NativeDeploymentOpen()) return;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null || cfg.Tiles.Count == 0) return;
            if (_mapSel < 0 || _mapSel >= cfg.Tiles.Count) _mapSel = 0;
            var td = cfg.Tiles[_mapSel];
            var bar = MapEditBarRect();
            GUI.Box(bar, GUIContent.none);
            string hint = (_roadArm || _roadChain) ? "Kliknij druga prowincje, aby polaczyc droga." : (td.Terrain == "mountains" ? "Gora. " : "") + "Shift+przeciagnij przesuwa.";
            GUI.Label(new Rect(bar.x + 8, bar.y + 4, 200, 18), "<b>" + td.Name + "</b>");
            GUI.Label(new Rect(bar.x + 8, bar.y + 24, 200, 16), "<size=10>" + hint + "</size>");
            float x = bar.x + 210f;
            float y = bar.y + 12f;
            if (GUI.Button(new Rect(x, y, 64, 26), td.Allegiance == "Rizia" ? "[Rizia]" : "Rizia"))
                SetAllegiance(td, "Rizia");
            if (GUI.Button(new Rect(x + 68, y, 70, 26), td.Allegiance == "Wehlen" ? "[Wehlen]" : "Wehlen"))
                SetAllegiance(td, "Wehlen");
            if (GUI.Button(new Rect(x + 142, y, 60, 26), td.Allegiance == "Empty" ? "[Puste]" : "Puste"))
                SetAllegiance(td, "Empty");
            if (GUI.Button(new Rect(x + 206, y, 56, 26), td.Terrain == "mountains" ? "[Gora]" : "Gora"))
            {
                td.Terrain = td.Terrain == "mountains" ? "plains" : "mountains";
                RequestApply();
            }
            if (GUI.Button(new Rect(x + 266, y, 62, 26), _roadArm ? "[Droga]" : "Droga"))
            {
                _roadArm = !_roadArm;
                if (_roadArm) _roadChain = false;
            }
            if (GUI.Button(new Rect(x + 332, y, 68, 26), _advEditOpen ? "[Zaaw.]" : "+ Zaaw."))
                _advEditOpen = !_advEditOpen;
            if (GUI.Button(new Rect(x + 404, y, 62, 26), "Zapisz"))
                _barStatus = ZilleMapLayoutManager.SaveConfig() ? "Zapisane." : "Zapis nieudany.";
            if (GUI.Button(new Rect(x + 470, y, 66, 26), "Wczytaj"))
                _barStatus = ZilleMapLayoutManager.ReloadSavedLayout() ? "Wczytane." : "Brak zapisu.";
            if (GUI.Button(new Rect(x + 540, y, 56, 26), ScenarioStarted ? "[Gra]" : "Graj"))
                StartScenario();

            if (_advEditOpen)
                DrawAdvancedEditPanel(td, cfg);
            else if (!string.IsNullOrEmpty(_barStatus))
                GUI.Label(new Rect(bar.x + 8, bar.y - 18, 420, 16), "<size=10>" + _barStatus + "</size>");
        }

        private static void DrawAdvancedEditPanel(ZilleTileData td, ZilleMapConfig cfg)
        {
            var r = AdvEditPanelRect();
            GUI.Box(r, "<b>Zaawansowany Edytor: " + td.Name + " (" + td.TileNumber + ")</b>");
            float x = r.x + 10f;
            float y = r.y + 26f;

            // Row 1: Province & City properties
            if (GUI.Button(new Rect(x, y, 90f, 24f), td.IsCity ? "[Miasto]" : "Miasto"))
            {
                td.IsCity = !td.IsCity;
                if (td.IsCity && string.IsNullOrEmpty(td.CityName)) td.CityName = td.Name;
                if (td.IsCity) td.IsSupplyHub = true;
                _citySpawned.Clear();
                InvalidateRoads();
                RequestApply();
            }
            if (GUI.Button(new Rect(x + 96f, y, 95f, 24f), td.IsSupplyHub ? "[Hub drogi]" : "Hub drogi"))
            {
                td.IsSupplyHub = !td.IsSupplyHub;
                InvalidateRoads();
                RefreshBoard();
            }
            if (GUI.Button(new Rect(x + 197f, y, 75f, 24f), td.IsPort ? "[Port]" : "Port"))
            {
                td.IsPort = !td.IsPort;
                InvalidateRoads();
                RefreshBoard();
            }
            if (GUI.Button(new Rect(x + 278f, y, 82f, 24f), $"Fort: {td.FortLevel}"))
            {
                td.FortLevel = (td.FortLevel + 1) % 3;
                RequestApply();
            }
            if (GUI.Button(new Rect(x + 366f, y, 80f, 24f), td.IsSea ? "[Morze]" : "Morze"))
            {
                td.IsSea = !td.IsSea;
                if (td.IsSea) td.Allegiance = "EmptySea";
                else if (td.Allegiance == "EmptySea") td.Allegiance = "Empty";
                RequestApply();
            }
            if (GUI.Button(new Rect(x + 452f, y, 92f, 24f), td.IsImpassable ? "[Blokada]" : "Blokada"))
            {
                td.IsImpassable = !td.IsImpassable;
                RequestApply();
            }

            // Row 2: Units spawner on selected province
            y += 32f;
            GUI.Label(new Rect(x, y, 90f, 22f), "<b>Jednostka:</b>");
            if (GUI.Button(new Rect(x + 88f, y, 86f, 24f), _editUnitEnemy ? "Wehlen" : "Rizia"))
                _editUnitEnemy = !_editUnitEnemy;

            var types = UnitTypes();
            if (types.Count > 0)
            {
                _editUnitIdx = Mathf.Clamp(_editUnitIdx, 0, types.Count - 1);
                if (GUI.Button(new Rect(x + 180f, y, 26f, 24f), "<"))
                    _editUnitIdx = (_editUnitIdx + types.Count - 1) % types.Count;
                var ut = types[_editUnitIdx];
                string uName = ut != null ? (ut.UnitName ?? ut.name ?? "?") : "?";
                GUI.Label(new Rect(x + 210f, y + 2f, 150f, 22f), uName);
                if (GUI.Button(new Rect(x + 364f, y, 26f, 24f), ">"))
                    _editUnitIdx = (_editUnitIdx + 1) % types.Count;

                if (GUI.Button(new Rect(x + 396f, y, 112f, 24f), "+ Dodaj jednostke"))
                {
                    var wt = FindLiveTile(td.TileNumber);
                    if (wt != null && ut != null)
                    {
                        var existing = Occupant(wt);
                        if (existing != null && !IsCityToken(existing)) KillUnit(existing, wt);
                        _barStatus = PlaceUnit(td, ut, _editUnitEnemy);
                        RefreshBoard();
                    }
                }
            }
            if (GUI.Button(new Rect(x + 514f, y, 110f, 24f), "Usun jednostke"))
            {
                var wt = FindLiveTile(td.TileNumber);
                var existing = wt != null ? Occupant(wt) : null;
                if (existing != null && !IsCityToken(existing))
                {
                    KillUnit(existing, wt);
                    _barStatus = $"Usunieto jednostke z {td.Name}.";
                }
            }

            // Row 3: Road editing & chaining
            y += 32f;
            GUI.Label(new Rect(x, y, 60f, 22f), "<b>Drogi:</b>");
            if (GUI.Button(new Rect(x + 64f, y, 125f, 24f), _roadChain ? "[Lancuch drog: ON]" : "Lancuch drog: OFF"))
            {
                _roadChain = !_roadChain;
                if (_roadChain) _roadArm = false;
            }
            if (GUI.Button(new Rect(x + 195f, y, 130f, 24f), "Odlacz wszystkie"))
            {
                if (td.RoadToIds != null && td.RoadToIds.Count > 0)
                {
                    var copy = new List<string>(td.RoadToIds);
                    for (int i = 0; i < copy.Count; i++)
                    {
                        for (int j = 0; j < cfg.Tiles.Count; j++)
                        {
                            if (cfg.Tiles[j].Id == copy[i])
                            {
                                ZilleMapLayoutManager.ToggleRoad(td, cfg.Tiles[j]);
                                break;
                            }
                        }
                    }
                    InvalidateRoads();
                    RequestApply();
                    _barStatus = $"Wyczyszczono drogi dla {td.Name}.";
                }
            }
            if (!string.IsNullOrEmpty(_barStatus))
                GUI.Label(new Rect(x + 335f, y + 2f, 290f, 22f), "<size=11>" + _barStatus + "</size>");

            // Row 4+: Connected road list with [X] disconnect buttons
            y += 30f;
            if (td.RoadToIds == null || td.RoadToIds.Count == 0)
            {
                GUI.Label(new Rect(x, y, 400f, 20f), "<size=11>Brak polaczen drogowych. Wlacz 'Droga' lub 'Lancuch drog' i kliknij cel.</size>");
            }
            else
            {
                float rx = x;
                float ry = y;
                int shown = 0;
                for (int i = 0; i < td.RoadToIds.Count && shown < 12; i++)
                {
                    string rid = td.RoadToIds[i];
                    ZilleTileData other = null;
                    for (int j = 0; j < cfg.Tiles.Count; j++)
                        if (cfg.Tiles[j].Id == rid) { other = cfg.Tiles[j]; break; }
                    if (other == null) continue;
                    string label = other.Name + " [X]";
                    if (GUI.Button(new Rect(rx, ry, 148f, 22f), label))
                    {
                        ZilleMapLayoutManager.ToggleRoad(td, other);
                        InvalidateRoads();
                        RequestApply();
                        break;
                    }
                    rx += 154f;
                    shown++;
                    if (rx + 148f > r.x + r.width - 8f)
                    {
                        rx = x;
                        ry += 26f;
                    }
                }
            }
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
            if (_tokenMgr == null) _tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            var tokens = _tokenMgr != null ? _tokenMgr.GetWarTokens() : null;
            if (tokens == null) return false;
            var byId = new Dictionary<string, ZilleTileData>();
            for (int i = 0; i < cfg.Tiles.Count; i++)
                if (!string.IsNullOrEmpty(cfg.Tiles[i].Id)) byId[cfg.Tiles[i].Id] = cfg.Tiles[i];
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                if (td.IsSea || td.IsCity || td.Allegiance != "Rizia") continue;
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

        private static bool TileHasLandUnit(ZilleTileData td, Il2CppSystem.Collections.Generic.List<WarToken> tokens)
        {
            var wt = FindLiveTile(td.TileNumber);
            if (wt == null || tokens == null) return false;
            var at = wt.transform.position;
            for (int i = 0; i < tokens.Count; i++)
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

        private static WarTile.TileNavalBlockedBy NavalBlock(ZilleTileData td)
        {
            if (td == null || !td.HasNoNavalLanding) return WarTile.TileNavalBlockedBy.None;
            return td.Allegiance == "Wehlen" ? WarTile.TileNavalBlockedBy.Enemy : WarTile.TileNavalBlockedBy.Player;
        }

        private static void ApplyZoneToTile(ZilleTileData td)
        {
            var wt = FindLiveTile(td.TileNumber);
            if (wt == null) return;
            var mgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
            if (mgr != null)
            {
                try { mgr.SetTileCoastalArtillery(wt, td.HasCoastalArtillery); } catch { }
                try { mgr.SetTileAntiAir(wt, td.HasNoAirZone); } catch { }
            }
            try { wt.ChangeWarTileCoastalArtilleryStat(td.HasCoastalArtillery); } catch { }
            try { wt.ChangeWarTileAntiAirStat(td.HasNoAirZone); } catch { }
            try { wt.SetTileNavalBlockedBy(NavalBlock(td)); } catch { }
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
            var cam = WarCamera();
            var cfgHit = ZilleMapLayoutManager.CurrentConfig;
            if (cam != null && e != null && cfgHit?.Tiles != null)
            {
                Vector2 screenPos = new Vector2(e.mousePosition.x, Screen.height - e.mousePosition.y);
                var wt = GetProvinceAt(cam, screenPos);
                if (wt != null)
                {
                    var tdHit = TileDataOf(wt);
                    if (tdHit != null)
                    {
                        for (int i = 0; i < cfgHit.Tiles.Count; i++)
                            if (cfgHit.Tiles[i] == tdHit) return i;
                    }
                }
            }
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

    public static class ZilleProfiler
    {
        private static readonly System.Diagnostics.Stopwatch _swHighlight = new System.Diagnostics.Stopwatch();
        private static readonly System.Diagnostics.Stopwatch _swLatePass = new System.Diagnostics.Stopwatch();
        private static readonly System.Diagnostics.Stopwatch _swTick = new System.Diagnostics.Stopwatch();
        private static readonly System.Diagnostics.Stopwatch _swOnGUI = new System.Diagnostics.Stopwatch();
        private static readonly System.Diagnostics.Stopwatch _swStatus = new System.Diagnostics.Stopwatch();

        public static double HighlightMs;
        public static double LatePassMs;
        public static double TickMs;
        public static double OnGUIMs;
        public static double StatusMs;

        private static float _nextReportTime;
        private static int _frameCount;
        private static float _fpsAccum;

        public static void BeginHighlight() => _swHighlight.Restart();
        public static void EndHighlight() { _swHighlight.Stop(); HighlightMs = _swHighlight.Elapsed.TotalMilliseconds; }

        public static void BeginLatePass() => _swLatePass.Restart();
        public static void EndLatePass() { _swLatePass.Stop(); LatePassMs = _swLatePass.Elapsed.TotalMilliseconds; }

        public static void BeginTick() => _swTick.Restart();
        public static void EndTick() { _swTick.Stop(); TickMs = _swTick.Elapsed.TotalMilliseconds; }

        public static void BeginOnGUI() => _swOnGUI.Restart();
        public static void EndOnGUI() { _swOnGUI.Stop(); OnGUIMs = _swOnGUI.Elapsed.TotalMilliseconds; }

        public static void BeginStatus() => _swStatus.Restart();
        public static void EndStatus() { _swStatus.Stop(); StatusMs = _swStatus.Elapsed.TotalMilliseconds; }

        public static void ReportFrame(float dt)
        {
            _frameCount++;
            _fpsAccum += dt;
            if (Time.unscaledTime >= _nextReportTime)
            {
                _nextReportTime = Time.unscaledTime + 5.0f;
                float fps = _frameCount > 0 && _fpsAccum > 0 ? _frameCount / _fpsAccum : 0f;
                _frameCount = 0;
                _fpsAccum = 0f;
                MelonLogger.Msg($"[PERF] FPS: {fps:0.0} | LatePass: {LatePassMs:0.00}ms | Highlight: {HighlightMs:0.00}ms | StatusEffects: {StatusMs:0.00}ms | Tick: {TickMs:0.00}ms | OnGUI: {OnGUIMs:0.00}ms");
            }
        }

        public static void ForceReport()
        {
            float fps = Time.smoothDeltaTime > 0.0001f ? 1.0f / Time.smoothDeltaTime : 0f;
            MelonLogger.Msg($"[PERF REPORT] FPS: {fps:0.0} | LatePass: {LatePassMs:0.00}ms | Highlight: {HighlightMs:0.00}ms | StatusEffects: {StatusMs:0.00}ms | Tick: {TickMs:0.00}ms | OnGUI: {OnGUIMs:0.00}ms");
        }
    }
}
