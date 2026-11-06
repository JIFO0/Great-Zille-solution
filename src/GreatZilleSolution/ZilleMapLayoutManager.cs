using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using MelonLoader;
using UnityEngine;

namespace GreatZilleSolution
{
    public static class ZilleMapLayoutManager
    {
        private static string _primaryAssetsDir = "";
        private static string _configFilePath = "";
        private static bool _texturesLoaded = false;
        
        public static ZilleMapConfig CurrentConfig { get; set; } = new ZilleMapConfig();
        public static Dictionary<string, Texture2D> LoadedTextures { get; } = new Dictionary<string, Texture2D>();
        public static Dictionary<int, Texture2D> GridMapTiles { get; } = new Dictionary<int, Texture2D>();
        public static Texture2D MapBackgroundTexture { get; private set; }
        public static Texture2D FullMapTexture { get; private set; }

        public static void Initialize()
        {
            DetermineAssetDirectories();
            LoadConfig();
            // Note: Textures are loaded lazily via EnsureTexturesLoaded() once Unity Graphics is active!
        }

        public static void EnsureTexturesLoaded()
        {
            if (_texturesLoaded && MapBackgroundTexture != null && LoadedTextures.Count > 0)
                return;

            LoadAllTextures();
        }

        public static readonly string[] PossibleRepoDirs = new[]
        {
            @"c:\Github\Great-Zille-solution",
            @"c:\Projects\Great Zille solution"
        };

        private static void DetermineAssetDirectories()
        {
            string suzerainModAssets = Path.Combine(Application.dataPath, "..", "Mods", "GreatZilleAssets");

            if (Directory.Exists(suzerainModAssets))
            {
                _primaryAssetsDir = Path.GetFullPath(suzerainModAssets);
            }
            else
            {
                bool foundRepo = false;
                foreach (var repo in PossibleRepoDirs)
                {
                    string pAssets = Path.Combine(repo, "assets");
                    if (Directory.Exists(pAssets))
                    {
                        _primaryAssetsDir = Path.GetFullPath(pAssets);
                        foundRepo = true;
                        break;
                    }
                }
                if (!foundRepo)
                {
                    _primaryAssetsDir = Path.GetFullPath(suzerainModAssets);
                    try { Directory.CreateDirectory(_primaryAssetsDir); } catch { }
                }
            }

            _configFilePath = Path.Combine(_primaryAssetsDir, "zille_tiles_layout.json");
            MelonLogger.Msg($"[ZilleMap] Asset directory resolved to: {_primaryAssetsDir}");
            MelonLogger.Msg($"[ZilleMap] Config file path: {_configFilePath}");
        }

        public static void LoadConfig()
        {
            try
            {
                if (File.Exists(_configFilePath))
                {
                    string json = File.ReadAllText(_configFilePath);
                    var cfg = JsonSerializer.Deserialize<ZilleMapConfig>(json);
                    if (cfg != null && cfg.Tiles != null && cfg.Tiles.Count > 0)
                    {
                        CurrentConfig = cfg;
                        if (CurrentConfig.Orders == null) CurrentConfig.Orders = new List<ZilleUnitOrder>();
                        if (CurrentConfig.Tiles != null)
                            foreach (var t in CurrentConfig.Tiles)
                                if (t.AdjacentIds == null) t.AdjacentIds = new List<string>();
                        EnsurePlacementDefaults(CurrentConfig);
                        MelonLogger.Msg($"[ZilleMap] Loaded layout with {CurrentConfig.Tiles.Count} tiles from config.");
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZilleMap] Failed to read {_configFilePath}: {ex.Message}");
            }

            if (CurrentConfig?.Tiles == null || CurrentConfig.Tiles.Count == 0)
            {
                MelonLogger.Msg("[ZilleMap] Generating default 4-city tactical layout for Zille...");
                CurrentConfig = CreateDefaultConfig();
                EnsurePlacementDefaults(CurrentConfig);
                SaveConfig();
            }

            bool fresh = CurrentConfig == null || CurrentConfig.Tiles == null || CurrentConfig.Tiles.Count < 40
                || string.IsNullOrEmpty(CurrentConfig.Version) || !CurrentConfig.Version.StartsWith("v14")
                || !CitiesNamed(CurrentConfig);
            if (fresh)
                TryUpgradeToV14();
            else
                ImportRoadsIfMissing(CurrentConfig);
            bool v14 = CurrentConfig != null && !string.IsNullOrEmpty(CurrentConfig.Version) && CurrentConfig.Version.StartsWith("v14");
            if (!v14)
                MarkNavalStarts(CurrentConfig);
            RecomputeFrontline(CurrentConfig);
            if (fresh && !v14)
                MelonLogger.Warning("[ZilleMap] v14 province pack was not found. Looked in Mods/GreatZilleAssets/regions and c:\\Projects\\Great Zille solution\\maps\\zille\\v14\\regions.");
            LogV14Summary(CurrentConfig);
            LogAdjacencyFile(ResolveRegionsDir());
            ZilleDeployment.Load(_primaryAssetsDir, ResolveRegionsDir());
        }

        /// <summary>
        /// A few sea provinces directly north of the current Rizian land become the naval deployment row.
        /// Recomputed from the saved allegiance, so a later edit of the coast moves the row with it.
        /// </summary>
        public static void MarkNavalStarts(ZilleMapConfig cfg)
        {
            if (cfg?.Tiles == null) return;
            var byId = new Dictionary<string, ZilleTileData>();
            foreach (var t in cfg.Tiles)
            {
                t.IsNavalStart = false;
                if (!string.IsNullOrEmpty(t.Id)) byId[t.Id] = t;
            }
            var ranked = new List<ZilleTileData>();
            foreach (var sea in cfg.Tiles)
            {
                if (!sea.IsSea || sea.AdjacentIds == null || sea.MapPxY < 0f) continue;
                bool northOfRizia = false;
                foreach (var id in sea.AdjacentIds)
                {
                    if (!byId.TryGetValue(id, out var land) || land.IsSea || land.Allegiance != "Rizia") continue;
                    if (land.MapPxY < 0f) continue;
                    if (sea.MapPxY < land.MapPxY - 8f) northOfRizia = true;
                }
                if (northOfRizia) ranked.Add(sea);
            }
            ranked.Sort((a, b) => a.MapPxY.CompareTo(b.MapPxY));
            int kept = 0;
            for (int i = 0; i < ranked.Count && kept < 5; i++)
            {
                ranked[i].IsNavalStart = true;
                kept++;
            }
            if (kept > 0)
                MelonLogger.Msg("[ZilleMap] Rizian naval starts north of the coast: " + kept + ".");
        }

        /// <summary>
        /// The front is Rizian land that touches Wehlen land. The imported flag followed region names and marked the wrong provinces.
        /// </summary>
        public static void RecomputeFrontline(ZilleMapConfig cfg)
        {
            if (cfg?.Tiles == null) return;
            var byId = new Dictionary<string, ZilleTileData>();
            foreach (var t in cfg.Tiles)
            {
                t.IsBorder = false;
                if (!string.IsNullOrEmpty(t.Id)) byId[t.Id] = t;
            }
            int n = 0;
            foreach (var t in cfg.Tiles)
            {
                if (t.IsSea || t.IsCity || t.Allegiance != "Rizia" || t.AdjacentIds == null) continue;
                foreach (var id in t.AdjacentIds)
                {
                    if (!byId.TryGetValue(id, out var other) || other.IsSea || other.Allegiance == "Rizia") continue;
                    t.IsBorder = true;
                    n++;
                    break;
                }
            }
            MelonLogger.Msg("[ZilleMap] Frontline is the Rizian land touching Wehlen: " + n + ".");
        }

        /// <summary>Reads the saved file and puts it back on the live table. Does not rebuild provinces.</summary>
        public static bool ReloadSavedLayout()
        {
            if (string.IsNullOrEmpty(_configFilePath) || !File.Exists(_configFilePath)) return false;
            try
            {
                var cfg = JsonSerializer.Deserialize<ZilleMapConfig>(File.ReadAllText(_configFilePath));
                if (cfg?.Tiles == null || cfg.Tiles.Count == 0) return false;
                CurrentConfig = cfg;
                if (CurrentConfig.Orders == null) CurrentConfig.Orders = new List<ZilleUnitOrder>();
                foreach (var t in CurrentConfig.Tiles)
                {
                    if (t.AdjacentIds == null) t.AdjacentIds = new List<string>();
                    if (t.RoadToIds == null) t.RoadToIds = new List<string>();
                }
                ImportRoadsIfMissing(CurrentConfig);
                ZilleWarTable.InvalidateLiveTiles();
                MelonLogger.Msg($"[ZilleMap] Reloaded saved layout ({CurrentConfig.Tiles.Count} tiles, version {CurrentConfig.Version}).");
                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZilleMap] Reload failed: {ex.Message}");
                return false;
            }
        }

        // Southern foothold, plus the two cities the player holds: Mave Nortus and Dapalle.
        private static readonly HashSet<string> RizianStrip = new HashSet<string>
        {
            "Celle Vaz", "Celle Vaz East",
            "Marbelas", "Marbelas Northeast",
            "Brivane", "Brivane East", "Brivane Southwest", "Brivane South",
            "Morsa Southeast",
            "Mave Nortus", "Dapalle"
        };

        // City markers are placed on these provinces. Mave Nortus and Dapalle are Rizian; the rest are Wehlen.
        public static readonly string[] ScenarioCities =
        {
            "Zille City", "Kratsna", "Wiktrany", "Mave Nortus", "Munat", "Nanta", "Isor", "Dapalle", "Grodzizg"
        };

        public static bool IsScenarioCity(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;
            for (int i = 0; i < ScenarioCities.Length; i++)
                if (ScenarioCities[i] == name) return true;
            return false;
        }

        /// <summary>A v13 save from before city labels stored the province name only. Those layouts rebuild once.</summary>
        private static bool CitiesNamed(ZilleMapConfig cfg)
        {
            if (cfg?.Tiles == null) return false;
            int cities = 0;
            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var t = cfg.Tiles[i];
                if (t == null || !t.IsCity) continue;
                cities++;
                if (string.IsNullOrEmpty(t.CityName)) return false;
            }
            return cities > 0;
        }

        public static void ApplyPoliticalControl(ZilleMapConfig cfg)
        {
            if (cfg?.Tiles == null) return;
            var byId = new Dictionary<string, ZilleTileData>();
            foreach (var t in cfg.Tiles)
                if (!string.IsNullOrEmpty(t.Id)) byId[t.Id] = t;
            int ours = 0;
            foreach (var t in cfg.Tiles)
            {
                if (t.IsSea) { t.Allegiance = "EmptySea"; t.IsBorder = false; continue; }
                bool rizia = RizianStrip.Contains(t.Name ?? "");
                t.Allegiance = rizia ? "Rizia" : "Wehlen";
                for (int c = 0; c < ScenarioCities.Length; c++)
                    if (t.Name == ScenarioCities[c]) { t.IsCity = true; break; }
                t.IsBorder = false;
                if (rizia) ours++;
            }
            foreach (var t in cfg.Tiles)
            {
                if (t.Allegiance != "Rizia" || t.AdjacentIds == null) continue;
                foreach (var id in t.AdjacentIds)
                {
                    if (byId.TryGetValue(id, out var other) && !other.IsSea && other.Allegiance != "Rizia")
                    {
                        t.IsBorder = true;
                        break;
                    }
                }
            }
            MelonLogger.Msg($"[ZilleMap] Political control: {ours} Rizian provinces on the southern strip, the rest of the land is Wehlen.");
        }

        /// <summary>
        /// Replaces a saved layout with the v14 province partition (masks, adjacency, owners, forts,
        /// terrain, roads) the first time that data is on disk. A saved layout already marked v14 is left alone.
        /// </summary>
        private static void TryUpgradeToV14()
        {
            if (CurrentConfig != null && CurrentConfig.Tiles != null && CurrentConfig.Tiles.Count > 40
                && !string.IsNullOrEmpty(CurrentConfig.Version) && CurrentConfig.Version.StartsWith("v14")
                && CitiesNamed(CurrentConfig))
                return;
            MelonLogger.Msg("[ZilleMap] Saved layout is " + (CurrentConfig?.Version ?? "empty")
                + " (" + (CurrentConfig?.Tiles?.Count ?? 0) + " tiles). Building v14.");
            var built = TryBuildV14();
            if (built == null) return;
            if (CurrentConfig?.Orders != null && CurrentConfig.Orders.Count > 0)
                built.Orders = CurrentConfig.Orders;
            CurrentConfig = built;
            SaveConfig();
        }

        public const float V12FootprintPx = 980f;

        public static ZilleTileData FindByName(string name)
        {
            if (CurrentConfig?.Tiles == null || string.IsNullOrEmpty(name)) return null;
            for (int i = 0; i < CurrentConfig.Tiles.Count; i++)
                if (CurrentConfig.Tiles[i].Name == name) return CurrentConfig.Tiles[i];
            return null;
        }

        private static string ResolveRegionsDir()
        {
            string local = Path.Combine(_primaryAssetsDir ?? "", "regions");
            if (IsV14Manifest(Path.Combine(local, "provinces_manifest.json"))) return local;
            foreach (var repo in PossibleRepoDirs)
            {
                string r = Path.Combine(repo, @"maps\zille\v14\regions");
                if (IsV14Manifest(Path.Combine(r, "provinces_manifest.json"))) return r;
            }
            return null;
        }

        private static bool IsV14Manifest(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return false;
            try
            {
                using var doc = JsonDocument.Parse(File.ReadAllText(path));
                if (!doc.RootElement.TryGetProperty("provinces", out var provinces) || provinces.ValueKind != JsonValueKind.Array)
                    return false;
                return provinces.GetArrayLength() >= 180;
            }
            catch
            {
                return false;
            }
        }

        private static string ResolveMapDir()
        {
            // The v14 pages replace every older grid, including assets/map and a copied v13 pack.
            foreach (var repo in PossibleRepoDirs)
            {
                string r = Path.Combine(repo, @"maps\zille\v14\map");
                if (File.Exists(Path.Combine(r, "T_Map_Zille_01.png"))) return r;
            }
            string local = Path.Combine(_primaryAssetsDir ?? "", "map");
            if (File.Exists(Path.Combine(local, "T_Map_Zille_01.png"))) return local;
            return null;
        }

        private static ZilleMapConfig TryBuildV14()
        {
            try
            {
                string dir = ResolveRegionsDir();
                if (dir == null) return null;
                string manifestPath = Path.Combine(dir, "provinces_manifest.json");
                string adjacencyPath = Path.Combine(dir, "provinces_adjacency.json");
                using var manifest = JsonDocument.Parse(File.ReadAllText(manifestPath));
                JsonDocument adjacency = null;
                if (File.Exists(adjacencyPath))
                    adjacency = JsonDocument.Parse(File.ReadAllText(adjacencyPath));

                var cfg = new ZilleMapConfig
                {
                    MapTitle = "Great Zille Theatre of War",
                    Version = "v14.0",
                    BackgroundTexture = "T_Map_Zille_Full_Composite.png",
                    Tiles = new List<ZilleTileData>(),
                    Orders = new List<ZilleUnitOrder>()
                };

                var byProvince = new Dictionary<string, ZilleTileData>();
                var provinces = manifest.RootElement.GetProperty("provinces");
                foreach (var p in provinces.EnumerateArray())
                {
                    string pid = Str(p, "id");
                    if (string.IsNullOrEmpty(pid) || !pid.StartsWith("ZilleTile_")) continue;
                    string number = pid.Substring("ZilleTile_".Length);
                    bool sea = Str(p, "type") == "sea";
                    string region = Str(p, "region");
                    string terrain = Str(p, "terrain");
                    bool city = Bool(p, "is_city");
                    float cx = Num(p, "tile_center_x");
                    float cy = Num(p, "tile_center_y");
                    string owner = Str(p, "owner");
                    string allegiance = (sea || owner == "neutral") ? "EmptySea"
                        : owner == "Rizia" ? "Rizia"
                        : owner == "Derdia" ? "Derdia"
                        : "Wehlen";
                    bool impassable = Bool(p, "impassable");
                    string fortKind = Str(p, "fort");
                    if (string.IsNullOrEmpty(fortKind)) fortKind = "none";
                    int fort = fortKind == "heavy" ? 2 : fortKind == "light" ? 1 : 0;
                    string display = Str(p, "name");

                    var tile = new ZilleTileData
                    {
                        Id = "tile_" + number.ToLowerInvariant(),
                        Name = display,
                        TextureFile = string.IsNullOrEmpty(Str(p, "png_file")) ? pid + ".png" : Str(p, "png_file"),
                        NormalizedX = cx / 12288f,
                        NormalizedY = cy / 8192f,
                        Width = 60f,
                        Height = 60f,
                        Allegiance = allegiance,
                        FortLevel = fort,
                        FortKind = fortKind,
                        DefenseLine = Str(p, "defense_line"),
                        IsPort = Bool(p, "is_port"),
                        IsSupplyHub = city && (display == "Wiktrany" || display == "Zille City" || display == "Kratsna"),
                        IsReinforcementTile = display == "Kratsna" || display == "Grodzizg",
                        IsSea = sea,
                        IsImpassable = impassable,
                        IsCity = city,
                        CityName = city ? Str(p, "city_name") : "",
                        IsCoastal = Bool(p, "is_coastal"),
                        IsNavalStart = Bool(p, "rizia_ship_placement"),
                        Region = region,
                        Terrain = terrain,
                        RoadClass = string.IsNullOrEmpty(Str(p, "road_class")) ? "none" : Str(p, "road_class"),
                        HasMainRoad = Bool(p, "has_main_road"),
                        HasRailway = Bool(p, "has_railway"),
                        TileNumber = number,
                        MapPxX = cx,
                        MapPxY = cy,
                        WorldScale = V12FootprintPx * ZilleWarTable.PlaneWorld / 4096f,
                        AdjacentIds = new List<string>()
                    };
                    cfg.Tiles.Add(tile);
                    byProvince[pid] = tile;
                }

                int roadLinks = 0;
                if (adjacency != null && adjacency.RootElement.TryGetProperty("provinces", out var adjRoot))
                {
                    foreach (var entry in adjRoot.EnumerateObject())
                    {
                        if (!byProvince.TryGetValue(entry.Name, out var tile)) continue;
                        if (!entry.Value.TryGetProperty("neighbours", out var nbs)) continue;
                        var seen = new HashSet<string>();
                        foreach (var nb in nbs.EnumerateArray())
                        {
                            string nid = Str(nb, "id");
                            if (!byProvince.TryGetValue(nid, out var other)) continue;
                            if (tile.IsImpassable || other.IsImpassable) continue;
                            if (seen.Add(other.Id)) tile.AdjacentIds.Add(other.Id);
                            if (Bool(nb, "road_link"))
                            {
                                tile.RoadLinkCount++;
                                roadLinks++;
                                if (tile.RoadToIds == null) tile.RoadToIds = new List<string>();
                                if (!tile.RoadToIds.Contains(other.Id)) tile.RoadToIds.Add(other.Id);
                            }
                        }
                    }
                }
                else
                {
                    foreach (var p in provinces.EnumerateArray())
                    {
                        string pid = Str(p, "id");
                        if (!byProvince.TryGetValue(pid, out var tile)) continue;
                        if (!p.TryGetProperty("neighbours", out var nbs)) continue;
                        foreach (var nb in nbs.EnumerateArray())
                        {
                            if (nb.ValueKind != JsonValueKind.String) continue;
                            if (byProvince.TryGetValue(nb.GetString(), out var other)
                                && !tile.IsImpassable && !other.IsImpassable && !tile.AdjacentIds.Contains(other.Id))
                                tile.AdjacentIds.Add(other.Id);
                        }
                    }
                }

                int mountains = 0, borders = 0;
                foreach (var tile in cfg.Tiles)
                {
                    if (tile.Terrain == "mountains") mountains++;
                    if (tile.IsSea || tile.Region != "Brenas") continue;
                    for (int i = 0; i < tile.AdjacentIds.Count; i++)
                    {
                        var other = cfg.Tiles.Find(t => t.Id == tile.AdjacentIds[i]);
                        if (other != null && !other.IsSea && (other.Region == "Zille" || other.Region == "Wehlen"))
                        {
                            tile.IsBorder = true;
                            borders++;
                            break;
                        }
                    }
                }
                foreach (var tile in cfg.Tiles)
                {
                    if (tile.IsSea || tile.IsCity || tile.Terrain == "mountains" || tile.Terrain == "hills") continue;
                    for (int i = 0; i < tile.AdjacentIds.Count; i++)
                    {
                        var other = cfg.Tiles.Find(t => t.Id == tile.AdjacentIds[i]);
                        if (other != null && other.IsCity && !other.IsSea)
                        {
                            tile.IsCitySurroundings = true;
                            break;
                        }
                    }
                }

                adjacency?.Dispose();
                int landCount = 0, seaCount = 0, heavy = 0, light = 0;
                foreach (var t in cfg.Tiles)
                {
                    if (t.IsSea) seaCount++; else landCount++;
                    if (t.FortLevel >= 2) heavy++;
                    else if (t.FortLevel == 1) light++;
                }
                MelonLogger.Msg($"[ZilleMap] Built v14 theatre: {cfg.Tiles.Count} provinces ({landCount} land, {seaCount} sea), {mountains} mountain, {borders} Brenas border flags, {roadLinks / 2} road crossings, forts {heavy} heavy and {light} light.");
                return cfg.Tiles.Count > 0 ? cfg : null;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZilleMap] v14 build failed: {ex.Message}");
                return null;
            }
        }

        private static void LogV14Summary(ZilleMapConfig cfg)
        {
            if (cfg?.Tiles == null || string.IsNullOrEmpty(cfg.Version) || !cfg.Version.StartsWith("v14")) return;
            int land = 0, sea = 0, rizia = 0, wehlen = 0, derdia = 0, neutral = 0, heavy = 0, light = 0, impassable = 0;
            var ships = new List<string>();
            foreach (var t in cfg.Tiles)
            {
                if (t.IsSea) sea++; else land++;
                if (t.Allegiance == "Rizia") rizia++;
                else if (t.Allegiance == "Derdia") derdia++;
                else if (t.IsSea || t.Allegiance == "EmptySea") neutral++;
                else wehlen++;
                if (t.FortLevel >= 2) heavy++;
                else if (t.FortLevel == 1) light++;
                if (t.IsImpassable) impassable++;
                if (t.IsNavalStart && !string.IsNullOrEmpty(t.TileNumber)) ships.Add(t.TileNumber);
            }
            ships.Sort(CompareTileNumber);
            MelonLogger.Msg($"[ZilleMap] Loaded v14 theatre: {cfg.Tiles.Count} provinces ({land} land, {sea} sea). Owners: Rizia {rizia}, Wehlen {wehlen}, Derdia {derdia}, neutral seas {neutral}.");
            MelonLogger.Msg("[ZilleMap] Derdia has no WarAllegiance. Those " + derdia + " provinces stay marked Derdia in the layout and are sent to the table as Enemy, so Rizia can attack them. They are not Wehlen.");
            MelonLogger.Msg("[ZilleMap] Impassable provinces: " + impassable + ". Yol (Tile_129) has 0 movement links and cannot be entered or selected.");
            MelonLogger.Msg("[ZilleMap] Lespia territorial waters stay off the board: the northern seas were pulled back, and the strip is not a province.");
            MelonLogger.Msg("[ZilleMap] Rizia ship seas: " + (ships.Count == 0 ? "(none)" : string.Join(" ", ships)) + ".");
            MelonLogger.Msg($"[ZilleMap] Forts: {heavy} heavy, {light} light.");
        }

        private static int CompareTileNumber(string a, string b)
        {
            bool aSea = !string.IsNullOrEmpty(a) && a[0] == 'S';
            bool bSea = !string.IsNullOrEmpty(b) && b[0] == 'S';
            int aNum = 0, bNum = 0;
            int.TryParse(aSea ? a.Substring(1) : a, out aNum);
            int.TryParse(bSea ? b.Substring(1) : b, out bNum);
            int c = aSea.CompareTo(bSea);
            if (c != 0) return c;
            return aNum.CompareTo(bNum);
        }

        private static void LogAdjacencyFile(string dir)
        {
            if (string.IsNullOrEmpty(dir)) return;
            string path = Path.Combine(dir, "provinces_adjacency.json");
            if (!File.Exists(path)) return;
            try
            {
                using var doc = JsonDocument.Parse(File.ReadAllText(path));
                if (!doc.RootElement.TryGetProperty("provinces", out var root)) return;
                var edgeType = new Dictionary<string, string>();
                foreach (var entry in root.EnumerateObject())
                {
                    if (!entry.Value.TryGetProperty("neighbours", out var nbs)) continue;
                    foreach (var nb in nbs.EnumerateArray())
                    {
                        string other = Str(nb, "id");
                        if (string.IsNullOrEmpty(other)) continue;
                        string a = entry.Name;
                        string key = string.CompareOrdinal(a, other) < 0 ? a + "|" + other : other + "|" + a;
                        if (edgeType.ContainsKey(key)) continue;
                        string typ = Str(nb, "type");
                        edgeType[key] = string.IsNullOrEmpty(typ) ? "land" : typ;
                    }
                }
                int land = 0, sea = 0, coastal = 0, strait = 0;
                foreach (var typ in edgeType.Values)
                {
                    if (typ == "land") land++;
                    else if (typ == "sea") sea++;
                    else if (typ == "coastal") coastal++;
                    else if (typ == "strait") strait++;
                }
                MelonLogger.Msg($"[ZilleMap] Adjacency {edgeType.Count} ({land} land, {sea} sea, {coastal} coastal, {strait} strait).");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZilleMap] Adjacency log: " + ex.Message);
            }
        }

        private static string Str(JsonElement e, string name)
        {
            if (!e.TryGetProperty(name, out var p) || p.ValueKind != JsonValueKind.String) return "";
            return p.GetString() ?? "";
        }

        private static bool Bool(JsonElement e, string name)
        {
            return e.TryGetProperty(name, out var p) && p.ValueKind == JsonValueKind.True;
        }

        private static float Num(JsonElement e, string name)
        {
            if (!e.TryGetProperty(name, out var p) || p.ValueKind != JsonValueKind.Number) return 0f;
            return (float)p.GetDouble();
        }

        // ---- Game tile identity & placement -------------------------------------------------------------
        // Suzerain looks tiles up with string.Format("Tile_{0}", tileName), so every tile referenced by operation
        // data (includedTileNames, WarTileData.tileName, WarTokenData.startingTileName) must be a real tile NUMBER.
        // We re-purpose five vanilla Pales tile objects (Tile_1..Tile_5) and move/re-texture them onto the Zille map.
        private static readonly Dictionary<string, (string num, float px, float py, float scale)> DefaultPlacement =
            new Dictionary<string, (string, float, float, float)>
            {
                // map pixel coordinates are FULL-RES (12288 x 8192). These are PLACEHOLDERS to be refined with tools/placement.
                { "tile_zille",    ("1", 7680f, 5640f, 0.26f) },
                { "tile_nanta",    ("2", 7320f, 2820f, 0.26f) },
                { "tile_munat",    ("3", 9480f, 1320f, 0.26f) },
                { "tile_wiktrany", ("4", 9240f, 3960f, 0.26f) },
                { "tile_brenas",   ("5", 8400f, 7200f, 0.26f) },
            };

        public static void EnsurePlacementDefaults(ZilleMapConfig cfg)
        {
            if (cfg == null || cfg.Tiles == null) return;
            int fallbackNum = 1;
            var used = new HashSet<string>();
            foreach (var t in cfg.Tiles) if (!string.IsNullOrEmpty(t.TileNumber)) used.Add(t.TileNumber);
            foreach (var t in cfg.Tiles)
            {
                DefaultPlacement.TryGetValue(t.Id ?? "", out var d);
                if (string.IsNullOrEmpty(t.TileNumber))
                {
                    string n = d.num;
                    while (string.IsNullOrEmpty(n) || used.Contains(n)) n = (fallbackNum++).ToString();
                    t.TileNumber = n; used.Add(n);
                }
                if (t.MapPxX < 0f || t.MapPxY < 0f)
                {
                    t.MapPxX = d.num != null ? d.px : 6144f;
                    t.MapPxY = d.num != null ? d.py : 4096f;
                    t.WorldScale = d.num != null ? d.scale : 0.26f;
                }
            }
        }

        /// <summary>Next vanilla WarTile suffix that this layout does not already claim ("1".."100", then "S1".."S33").</summary>
        public static string NextFreeTileNumber()
        {
            var used = new HashSet<string>();
            if (CurrentConfig?.Tiles != null)
                foreach (var t in CurrentConfig.Tiles)
                    if (!string.IsNullOrEmpty(t.TileNumber)) used.Add(t.TileNumber);
            for (int i = 1; i <= 100; i++)
            {
                string n = i.ToString();
                if (!used.Contains(n)) return n;
            }
            for (int i = 1; i <= 33; i++)
            {
                string n = "S" + i;
                if (!used.Contains(n)) return n;
            }
            return null;
        }

        /// <summary>
        /// Claims one unused vanilla province tile and drops it beside <paramref name="anchorId"/> (or the last tile).
        /// offsetIndex spaces a batch so they do not stack. Returns null when every vanilla tile number is taken.
        /// </summary>
        public static ZilleTileData AddProvinceNear(string anchorId, int offsetIndex)
        {
            if (CurrentConfig == null) CurrentConfig = CreateDefaultConfig();
            if (CurrentConfig.Tiles == null) CurrentConfig.Tiles = new List<ZilleTileData>();
            if (CurrentConfig.Orders == null) CurrentConfig.Orders = new List<ZilleUnitOrder>();
            EnsurePlacementDefaults(CurrentConfig);

            string num = NextFreeTileNumber();
            if (num == null) return null;

            ZilleTileData anchor = null;
            if (!string.IsNullOrEmpty(anchorId))
                anchor = CurrentConfig.Tiles.Find(t => t.Id == anchorId);
            if (anchor == null && CurrentConfig.Tiles.Count > 0)
                anchor = CurrentConfig.Tiles[CurrentConfig.Tiles.Count - 1];

            float ax = anchor != null && anchor.MapPxX >= 0f ? anchor.MapPxX : 6144f;
            float ay = anchor != null && anchor.MapPxY >= 0f ? anchor.MapPxY : 4096f;
            int col = offsetIndex % 4;
            int row = offsetIndex / 4;
            float px = Mathf.Clamp(ax + 480f * (col + 1), 200f, 12000f);
            float py = Mathf.Clamp(ay + 480f * row, 200f, 8000f);

            string id = "tile_" + num;
            if (CurrentConfig.Tiles.Exists(t => t.Id == id)) id = "tile_extra_" + num;

            var tile = new ZilleTileData
            {
                Id = id,
                Name = "Province " + num,
                TextureFile = $"Frame {41 + (CurrentConfig.Tiles.Count % 5)}.png",
                NormalizedX = Mathf.Clamp01(px / 12288f),
                NormalizedY = Mathf.Clamp01(py / 8192f),
                Width = 80f,
                Height = 80f,
                Allegiance = "Contested",
                TileNumber = num,
                MapPxX = px,
                MapPxY = py,
                WorldScale = num.StartsWith("S") ? 0.28f : (anchor != null && anchor.WorldScale > 0.03f ? anchor.WorldScale : 0.22f),
                AdjacentIds = new List<string>()
            };
            if (anchor != null)
            {
                tile.AdjacentIds.Add(anchor.Id);
                if (anchor.AdjacentIds == null) anchor.AdjacentIds = new List<string>();
                if (!anchor.AdjacentIds.Contains(tile.Id)) anchor.AdjacentIds.Add(tile.Id);
            }
            CurrentConfig.Tiles.Add(tile);
            MelonLogger.Msg($"[ZilleMap] Added province {tile.Id} as Tile_{num} at ({px:F0},{py:F0}) scale {tile.WorldScale:F3}.");
            return tile;
        }

        public static bool RemoveProvinceAt(int index)
        {
            var tiles = CurrentConfig?.Tiles;
            if (tiles == null || index < 0 || index >= tiles.Count || tiles.Count <= 1) return false;
            string removeId = tiles[index].Id;
            string num = tiles[index].TileNumber;
            tiles.RemoveAt(index);
            foreach (var t in tiles)
                if (t.AdjacentIds != null) t.AdjacentIds.Remove(removeId);
            if (!string.IsNullOrEmpty(num)) ZilleWarTable.DeactivateLiveTile(num);
            return true;
        }

        /// <summary>Maps a Zille layout id ("tile_zille") to the in-game tile name/number ("1").</summary>
        public static string GameTileName(string zilleId)
        {
            if (CurrentConfig?.Tiles != null)
            {
                foreach (var t in CurrentConfig.Tiles)
                    if (t.Id == zilleId && !string.IsNullOrEmpty(t.TileNumber)) return t.TileNumber;
            }
            return DefaultPlacement.TryGetValue(zilleId ?? "", out var d) ? d.num : zilleId;
        }

        private static void ImportRoadsIfMissing(ZilleMapConfig cfg)
        {
            if (cfg?.Tiles == null) return;
            foreach (var t in cfg.Tiles)
                if (t.RoadToIds == null) t.RoadToIds = new List<string>();
            bool any = false;
            foreach (var t in cfg.Tiles)
                if (t.RoadToIds.Count > 0) { any = true; break; }
            if (any) return;
            try
            {
                string dir = ResolveRegionsDir();
                if (dir == null) return;
                string adjacencyPath = Path.Combine(dir, "provinces_adjacency.json");
                if (!File.Exists(adjacencyPath)) return;
                using var adjacency = JsonDocument.Parse(File.ReadAllText(adjacencyPath));
                if (!adjacency.RootElement.TryGetProperty("provinces", out var adjRoot)) return;
                var byProvince = new Dictionary<string, ZilleTileData>();
                foreach (var t in cfg.Tiles)
                    if (!string.IsNullOrEmpty(t.TileNumber)) byProvince["ZilleTile_" + t.TileNumber] = t;
                int n = 0;
                foreach (var entry in adjRoot.EnumerateObject())
                {
                    if (!byProvince.TryGetValue(entry.Name, out var tile)) continue;
                    if (!entry.Value.TryGetProperty("neighbours", out var nbs)) continue;
                    foreach (var nb in nbs.EnumerateArray())
                    {
                        if (!Bool(nb, "road_link")) continue;
                        string nid = Str(nb, "id");
                        if (!byProvince.TryGetValue(nid, out var other)) continue;
                        if (!tile.RoadToIds.Contains(other.Id)) tile.RoadToIds.Add(other.Id);
                        if (other.RoadToIds != null && !other.RoadToIds.Contains(tile.Id)) other.RoadToIds.Add(tile.Id);
                        tile.HasMainRoad = true;
                        other.HasMainRoad = true;
                        n++;
                    }
                }
                if (n > 0) MelonLogger.Msg($"[ZilleMap] Imported {n} road ends onto the saved layout.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZilleMap] Road import: " + ex.Message);
            }
        }

        public static void ToggleRoad(ZilleTileData a, ZilleTileData b)
        {
            if (a == null || b == null || a == b) return;
            if (a.RoadToIds == null) a.RoadToIds = new List<string>();
            if (b.RoadToIds == null) b.RoadToIds = new List<string>();
            bool on = a.RoadToIds.Contains(b.Id);
            if (on)
            {
                a.RoadToIds.Remove(b.Id);
                b.RoadToIds.Remove(a.Id);
            }
            else
            {
                a.RoadToIds.Add(b.Id);
                b.RoadToIds.Add(a.Id);
                if (!a.AdjacentIds.Contains(b.Id)) a.AdjacentIds.Add(b.Id);
                if (!b.AdjacentIds.Contains(a.Id)) b.AdjacentIds.Add(a.Id);
            }
            a.HasMainRoad = a.RoadToIds.Count > 0;
            b.HasMainRoad = b.RoadToIds.Count > 0;
            ZilleWarTable.RequestApply();
        }

        public static bool SaveConfig()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(CurrentConfig, options);
                
                File.WriteAllText(_configFilePath, json);

                foreach (var repo in PossibleRepoDirs)
                {
                    string projectPath = Path.Combine(repo, @"assets\zille_tiles_layout.json");
                    if (Path.GetFullPath(_configFilePath) != Path.GetFullPath(projectPath))
                    {
                        try
                        {
                            string pDir = Path.GetDirectoryName(projectPath);
                            if (Directory.Exists(pDir))
                                File.WriteAllText(projectPath, json);
                        }
                        catch { }
                    }
                }

                MelonLogger.Msg($"[ZilleMap] Saved tile layout successfully ({CurrentConfig.Tiles.Count} tiles).");
                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZilleMap] Failed to save config: {ex.Message}");
                return false;
            }
        }

        public static void LoadAllTextures()
        {
            MelonLogger.Msg("[ZilleMap] Starting texture loading pipeline (DirectX/GPU active)...");
            
            // v14 redrew the base map, so a missing page must not silently keep the v13 art.
            string mapDir = ResolveMapDir();
            string compositePath = mapDir == null ? null : Path.Combine(mapDir, "T_Map_Zille_Full_Composite.png");
            if (compositePath != null && File.Exists(compositePath))
            {
                MapBackgroundTexture = LoadTextureFromFile(compositePath);
                FullMapTexture = MapBackgroundTexture;
            }

            if (MapBackgroundTexture == null && mapDir != null)
            {
                string bgFull = Path.Combine(mapDir, "T_Map_Zille_01.png");
                if (File.Exists(bgFull))
                {
                    MapBackgroundTexture = LoadTextureFromFile(bgFull);
                    FullMapTexture = MapBackgroundTexture;
                }
            }
            if (mapDir == null)
                MelonLogger.Warning("[ZilleMap] v14 map textures missing (T_Map_Zille_01.png). The base map changed; v13 pages are not used.");

            // 2. Also load all 6 individual map grid tiles (01..06) for modular 3D map tile meshes
            for (int t = 1; t <= 6; t++)
            {
                if (mapDir == null) break;
                string tFull = Path.Combine(mapDir, $"T_Map_Zille_0{t}.png");
                if (!File.Exists(tFull)) continue;
                var tex = LoadTextureFromFile(tFull);
                if (tex != null) GridMapTiles[t] = tex;
            }
            if (mapDir == null)
                MelonLogger.Msg("[ZilleMap] Loaded 0/6 individual map grid tiles.");
            else
                MelonLogger.Msg($"[ZilleMap] Map textures from {mapDir}. Loaded {GridMapTiles.Count}/6 individual map grid tiles.");

            // Fallback: If map background still null, create fallback tactical grid
            if (MapBackgroundTexture == null)
            {
                MelonLogger.Warning("[ZilleMap] Creating fallback procedural tactical map background...");
                MapBackgroundTexture = CreateFallbackMapTexture();
            }

            // 3. Province masks. Each PNG is a 512 mask (red interior, green outline, transparent outside)
            //    drawn by the Pales tile shader, so the map art stays visible underneath.
            var wanted = new HashSet<string>();
            if (CurrentConfig?.Tiles != null)
            {
                foreach (var t in CurrentConfig.Tiles)
                    if (!string.IsNullOrEmpty(t.TextureFile)) wanted.Add(t.TextureFile);
            }
            if (wanted.Count == 0)
            {
                for (int i = 41; i <= 45; i++) wanted.Add($"Frame {i}.png");
            }
            string regDir = ResolveRegionsDir() ?? Path.Combine(_primaryAssetsDir, "regions");
            foreach (var fname in wanted)
            {
                string fpath = Path.Combine(regDir, fname);
                if (!File.Exists(fpath))
                {
                    foreach (var repo in PossibleRepoDirs)
                    {
                        string candidate = Path.Combine(repo, @"maps\zille\v14\regions", fname);
                        if (File.Exists(candidate)) { fpath = candidate; break; }
                    }
                }
                if (!File.Exists(fpath))
                {
                    MelonLogger.Warning($"[ZilleMap] Tile file missing: {fname}");
                    continue;
                }
                var tex = LoadTextureFromFile(fpath);
                if (tex != null) LoadedTextures[fname] = tex;
            }

            _texturesLoaded = true;
            MelonLogger.Msg($"[ZilleMap] Texture loading complete. Loaded {LoadedTextures.Count} region tiles. Background={(MapBackgroundTexture != null ? $"{MapBackgroundTexture.width}x{MapBackgroundTexture.height}" : "NULL")}");
        }

        public static Texture2D LoadTextureFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MelonLogger.Error($"[ZilleMap] File not found: {filePath}");
                    return null;
                }

                byte[] fileData = File.ReadAllBytes(filePath);
                if (fileData == null || fileData.Length == 0)
                {
                    MelonLogger.Error($"[ZilleMap] File is empty: {filePath}");
                    return null;
                }

                // Standard uncompressed RGBA texture container for ImageConversion
                Texture2D tex = new Texture2D(2, 2, TextureFormat.RGBA32, false);
                // Big map pages are never read back on the CPU -> mark non-readable (halves RAM). Region masks stay readable.
                bool bigMap = fileData.Length > 600000;
                bool success = ImageConversion.LoadImage(tex, fileData, bigMap);
                if (success && tex.width > 2)
                {
                    tex.filterMode = FilterMode.Bilinear;          // same as the vanilla T_Map_Pales_* import settings
                    tex.wrapMode = TextureWrapMode.Clamp;
                    tex.anisoLevel = 1;
                    // Without this Unity destroys script-created textures on the next scene load (UnloadUnusedAssets),
                    // which is why the old code re-read all PNGs at every scene change.
                    tex.hideFlags = HideFlags.HideAndDontSave;
                    tex.name = Path.GetFileName(filePath);
                    MelonLogger.Msg($"[ZilleMap] Successfully loaded: {tex.name} ({tex.width}x{tex.height}, {fileData.Length} bytes)");
                    return tex;
                }
                else
                {
                    MelonLogger.Error($"[ZilleMap] ImageConversion.LoadImage returned FALSE for: {filePath}");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZilleMap] Exception loading texture {filePath}: {ex.Message}");
            }
            return null;
        }

        private static Texture2D CreateFallbackMapTexture()
        {
            Texture2D tex = new Texture2D(512, 512, TextureFormat.RGBA32, false);
            Color parchment = new Color(0.18f, 0.17f, 0.15f, 1f);
            Color grid = new Color(0.26f, 0.24f, 0.20f, 1f);
            Color[] pixels = new Color[512 * 512];

            for (int y = 0; y < 512; y++)
            {
                for (int x = 0; x < 512; x++)
                {
                    bool isLine = (x % 64 == 0) || (y % 64 == 0);
                    pixels[y * 512 + x] = isLine ? grid : parchment;
                }
            }
            tex.SetPixels(pixels);
            tex.Apply();
            return tex;
        }

        public static ZilleMapConfig CreateDefaultConfig()
        {
            var cfg = new ZilleMapConfig();
            
            // 1. Zille Capital (West)
            cfg.Tiles.Add(new ZilleTileData
            {
                Id = "tile_zille",
                Name = "Zille (Capital)",
                TextureFile = "Frame 41.png",
                NormalizedX = 0.28f,
                NormalizedY = 0.48f,
                Width = 95f,
                Height = 95f,
                Allegiance = "Wehlen",
                FortLevel = 2,
                IsSupplyHub = true,
                AdjacentIds = new List<string> { "tile_wiktrany", "tile_munat" }
            });

            // 2. Munat Port (North Deepwater Port)
            cfg.Tiles.Add(new ZilleTileData
            {
                Id = "tile_munat",
                Name = "Munat (Deepwater Port)",
                TextureFile = "Frame 44.png",
                NormalizedX = 0.45f,
                NormalizedY = 0.22f,
                Width = 85f,
                Height = 85f,
                Allegiance = "Wehlen",
                IsPort = true,
                AdjacentIds = new List<string> { "tile_zille", "tile_wiktrany" }
            });

            // 3. Wiktrany (Central Logistics Hub)
            cfg.Tiles.Add(new ZilleTileData
            {
                Id = "tile_wiktrany",
                Name = "Wiktrany (Logistics Hub)",
                TextureFile = "Frame 43.png",
                NormalizedX = 0.52f,
                NormalizedY = 0.50f,
                Width = 90f,
                Height = 90f,
                Allegiance = "Wehlen",
                IsSupplyHub = true,
                AdjacentIds = new List<string> { "tile_zille", "tile_munat", "tile_nanta", "tile_brenas" }
            });

            // 4. Nanta (East Outpost & Fuel Depot)
            cfg.Tiles.Add(new ZilleTileData
            {
                Id = "tile_nanta",
                Name = "Nanta (East Gate)",
                TextureFile = "Frame 42.png",
                NormalizedX = 0.74f,
                NormalizedY = 0.44f,
                Width = 85f,
                Height = 85f,
                Allegiance = "Wehlen",
                AdjacentIds = new List<string> { "tile_wiktrany", "tile_brenas" }
            });

            // 5. Brenas Border / Staging Ground (South)
            cfg.Tiles.Add(new ZilleTileData
            {
                Id = "tile_brenas",
                Name = "Brenas Border (Rizia Staging)",
                TextureFile = "Frame 45.png",
                NormalizedX = 0.60f,
                NormalizedY = 0.78f,
                Width = 80f,
                Height = 80f,
                Allegiance = "Rizia",
                AdjacentIds = new List<string> { "tile_wiktrany", "tile_nanta" }
            });

            return cfg;
        }
    }
}
