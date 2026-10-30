using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        /// <summary>True when the live layout came from maps/zille/v11/regions/provinces_manifest.json. Neighbours are not copied.</summary>
        public static bool UsingProvinceManifest { get; private set; }

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

        private static bool IsV11Pack(string dir)
        {
            return !string.IsNullOrEmpty(dir)
                && File.Exists(Path.Combine(dir, "map", "T_Map_Zille_01.png"))
                && File.Exists(Path.Combine(dir, "regions", "provinces_manifest.json"));
        }

        private static string FindV11Pack()
        {
            string mod = Path.GetFullPath(Path.Combine(Application.dataPath, "..", "Mods", "GreatZilleAssets"));
            string[] named =
            {
                mod,
                Path.Combine(mod, "v11"),
                Path.Combine(mod, "maps", "zille", "v11"),
                @"c:\Projects\Great Zille solution\maps\zille\v11",
            };
            foreach (var dir in named)
                if (IsV11Pack(dir)) return Path.GetFullPath(dir);

            string cursor = Path.GetFullPath(Path.Combine(Application.dataPath, ".."));
            for (int i = 0; i < 8 && !string.IsNullOrEmpty(cursor); i++)
            {
                string pack = Path.Combine(cursor, "maps", "zille", "v11");
                if (IsV11Pack(pack)) return Path.GetFullPath(pack);
                var parent = Directory.GetParent(cursor);
                if (parent == null) break;
                cursor = parent.FullName;
            }
            return null;
        }

        private static void DetermineAssetDirectories()
        {
            string suzerainModAssets = Path.Combine(Application.dataPath, "..", "Mods", "GreatZilleAssets");
            string projectAssets = @"c:\Projects\Great Zille solution\assets";
            string v11 = FindV11Pack();

            if (!string.IsNullOrEmpty(v11))
            {
                _primaryAssetsDir = v11;
            }
            else if (Directory.Exists(suzerainModAssets))
            {
                _primaryAssetsDir = Path.GetFullPath(suzerainModAssets);
            }
            else if (Directory.Exists(projectAssets))
            {
                _primaryAssetsDir = Path.GetFullPath(projectAssets);
            }
            else
            {
                _primaryAssetsDir = Path.GetFullPath(suzerainModAssets);
                try { Directory.CreateDirectory(_primaryAssetsDir); } catch { }
            }

            _configFilePath = Path.Combine(_primaryAssetsDir, "zille_tiles_layout.json");
            MelonLogger.Msg($"[ZilleMap] Asset directory resolved to: {_primaryAssetsDir}");
            MelonLogger.Msg($"[ZilleMap] Config file path: {_configFilePath}");
        }

        public static void LoadConfig()
        {
            UsingProvinceManifest = false;
            if (TryLoadProvinceManifest())
                return;

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
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZilleMap] Failed to read {_configFilePath}: {ex.Message}");
            }

            MelonLogger.Msg("[ZilleMap] Generating default 4-city tactical layout for Zille...");
            CurrentConfig = CreateDefaultConfig();
            EnsurePlacementDefaults(CurrentConfig);
            SaveConfig();
        }

        private static bool TryLoadProvinceManifest()
        {
            string path = Path.Combine(_primaryAssetsDir, "regions", "provinces_manifest.json");
            if (!File.Exists(path)) return false;
            try
            {
                var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var file = JsonSerializer.Deserialize<ProvinceManifestFile>(File.ReadAllText(path), opts);
                if (file?.Provinces == null || file.Provinces.Count == 0) return false;

                float footprint = file.TileSizeMap > 1f ? file.TileSizeMap : 980f;
                float world = footprint * ZilleWarTable.PxToWorld;
                var cfg = new ZilleMapConfig
                {
                    MapTitle = "Great Zille Theatre of War",
                    Version = "v11",
                    BackgroundTexture = "T_Map_Zille_Full_Composite.png",
                    Tiles = new List<ZilleTileData>(),
                    Orders = new List<ZilleUnitOrder>()
                };

                foreach (var p in file.Provinces)
                {
                    if (p == null || string.IsNullOrEmpty(p.Id)) continue;
                    string number = p.Id.StartsWith("ZilleTile_", StringComparison.Ordinal)
                        ? p.Id.Substring("ZilleTile_".Length)
                        : p.Id;
                    float size = p.TileSizeMap > 1f ? p.TileSizeMap : footprint;
                    float cx = p.TileCenterX;
                    float cy = p.TileCenterY;
                    if (cx == 0f && cy == 0f)
                    {
                        cx = p.TileX + size * 0.5f;
                        cy = p.TileY + size * 0.5f;
                    }
                    string tex = string.IsNullOrEmpty(p.PngFile) ? p.Id + ".png" : Path.GetFileName(p.PngFile);
                    string allegiance = p.Region == "Brenas" ? "Rizia" : (p.Type == "sea" ? "Contested" : "Wehlen");
                    cfg.Tiles.Add(new ZilleTileData
                    {
                        Id = p.Id,
                        Name = string.IsNullOrEmpty(p.Name) ? p.Id : p.Name,
                        TextureFile = tex,
                        NormalizedX = Mathf.Clamp01(cx / 12288f),
                        NormalizedY = Mathf.Clamp01(cy / 8192f),
                        Width = 48f,
                        Height = 48f,
                        Allegiance = allegiance,
                        TileNumber = number,
                        MapPxX = cx,
                        MapPxY = cy,
                        WorldScale = size * ZilleWarTable.PxToWorld,
                        AdjacentIds = null
                    });
                }

                if (cfg.Tiles.Count == 0) return false;
                CurrentConfig = cfg;
                UsingProvinceManifest = true;
                MelonLogger.Msg($"[ZilleMap] Loaded {cfg.Tiles.Count} provinces from {path}. Footprint {footprint:F0}px, world scale {world:F4}. Neighbours were not applied.");
                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZilleMap] Failed to read province manifest {path}: {ex.Message}");
                return false;
            }
        }

        // ---- Game tile identity & placement -------------------------------------------------------------
        // Suzerain looks tiles up with string.Format("Tile_{0}", tileName), so every tile referenced by operation
        // data (includedTileNames, WarTileData.tileName, WarTokenData.startingTileName) must be a real tile NUMBER.
        // The v11 manifest reuses the vanilla WarTile objects (Tile_1..100 and Tile_S1..S33) by number.
        // The five entries below are only the fallback when that manifest is not installed.
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

                string city = zilleId switch
                {
                    "tile_zille" => "Zille City",
                    "tile_munat" => "Munat",
                    "tile_nanta" => "Nanta",
                    "tile_wiktrany" => "Wiktrany",
                    "tile_brenas" => "Dapalle",
                    _ => null
                };
                if (city != null)
                {
                    foreach (var t in CurrentConfig.Tiles)
                        if (t.Name == city && !string.IsNullOrEmpty(t.TileNumber)) return t.TileNumber;
                }
            }
            return DefaultPlacement.TryGetValue(zilleId ?? "", out var d) ? d.num : zilleId;
        }

        public static bool SaveConfig()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(CurrentConfig, options);
                
                File.WriteAllText(_configFilePath, json);

                string projectPath = @"c:\Projects\Great Zille solution\assets\zille_tiles_layout.json";
                if (Path.GetFullPath(_configFilePath) != Path.GetFullPath(projectPath))
                {
                    try
                    {
                        string pDir = Path.GetDirectoryName(projectPath);
                        if (!Directory.Exists(pDir)) Directory.CreateDirectory(pDir);
                        File.WriteAllText(projectPath, json);
                    }
                    catch { }
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
            
            // 1. Load the COMPLETE 6-tile stitched composite map (3072x2048, 3x2 grid)
            string compositePath = Path.Combine(_primaryAssetsDir, "map", "T_Map_Zille_Full_Composite.png");
            if (File.Exists(compositePath))
            {
                MapBackgroundTexture = LoadTextureFromFile(compositePath);
                FullMapTexture = MapBackgroundTexture;
            }

            // Fallback if composite doesn't exist yet: load 01 full or 01 preview
            if (MapBackgroundTexture == null)
            {
                string bgFull = Path.Combine(_primaryAssetsDir, "map", "T_Map_Zille_01.png");
                string bgPreview = Path.Combine(_primaryAssetsDir, "map", "T_Map_Zille_01_preview.png");
                if (File.Exists(bgFull)) MapBackgroundTexture = LoadTextureFromFile(bgFull);
                else if (File.Exists(bgPreview)) MapBackgroundTexture = LoadTextureFromFile(bgPreview);
                FullMapTexture = MapBackgroundTexture;
            }

            // 2. Also load all 6 individual map grid tiles (01..06) for modular 3D map tile meshes
            for (int t = 1; t <= 6; t++)
            {
                string tFull = Path.Combine(_primaryAssetsDir, "map", $"T_Map_Zille_0{t}.png");
                string tPrev = Path.Combine(_primaryAssetsDir, "map", $"T_Map_Zille_0{t}_preview.png");
                string usePath = File.Exists(tFull) ? tFull : tPrev;
                if (File.Exists(usePath))
                {
                    var tex = LoadTextureFromFile(usePath);
                    if (tex != null) GridMapTiles[t] = tex;
                }
            }
            MelonLogger.Msg($"[ZilleMap] Loaded {GridMapTiles.Count}/6 individual map grid tiles.");

            // Fallback: If map background still null, create fallback tactical grid
            if (MapBackgroundTexture == null)
            {
                MelonLogger.Warning("[ZilleMap] Creating fallback procedural tactical map background...");
                MapBackgroundTexture = CreateFallbackMapTexture();
            }

            // 3. Load province masks. v11 uses ZilleTile_N.png / ZilleTile_SN.png; older packs used Frame 41..45.
            string regDir = Path.Combine(_primaryAssetsDir, "regions");
            if (Directory.Exists(regDir))
            {
                string[] zilleTiles = Directory.GetFiles(regDir, "ZilleTile_*.png");
                if (zilleTiles != null && zilleTiles.Length > 0)
                {
                    for (int i = 0; i < zilleTiles.Length; i++)
                    {
                        var tex = LoadTextureFromFile(zilleTiles[i]);
                        if (tex != null) LoadedTextures[Path.GetFileName(zilleTiles[i])] = tex;
                    }
                }
                else
                {
                    for (int i = 41; i <= 45; i++)
                    {
                        string fname = $"Frame {i}.png";
                        string fpath = Path.Combine(regDir, fname);
                        if (File.Exists(fpath))
                        {
                            var tex = LoadTextureFromFile(fpath);
                            if (tex != null) LoadedTextures[fname] = tex;
                        }
                        else
                        {
                            MelonLogger.Warning($"[ZilleMap] Tile file missing: {fpath}");
                        }
                    }
                }
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

        private sealed class ProvinceManifestFile
        {
            [JsonPropertyName("tile_size_map")] public float TileSizeMap { get; set; }
            [JsonPropertyName("provinces")] public List<ProvinceManifestEntry> Provinces { get; set; }
        }

        private sealed class ProvinceManifestEntry
        {
            [JsonPropertyName("id")] public string Id { get; set; }
            [JsonPropertyName("name")] public string Name { get; set; }
            [JsonPropertyName("type")] public string Type { get; set; }
            [JsonPropertyName("region")] public string Region { get; set; }
            [JsonPropertyName("tile_x")] public float TileX { get; set; }
            [JsonPropertyName("tile_y")] public float TileY { get; set; }
            [JsonPropertyName("tile_center_x")] public float TileCenterX { get; set; }
            [JsonPropertyName("tile_center_y")] public float TileCenterY { get; set; }
            [JsonPropertyName("tile_size_map")] public float TileSizeMap { get; set; }
            [JsonPropertyName("png_file")] public string PngFile { get; set; }
        }
    }
}
