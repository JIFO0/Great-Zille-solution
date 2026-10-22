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

        private static void DetermineAssetDirectories()
        {
            string suzerainModAssets = Path.Combine(Application.dataPath, "..", "Mods", "GreatZilleAssets");
            string projectAssets = @"c:\Projects\Great Zille solution\assets";

            if (Directory.Exists(suzerainModAssets))
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
            try
            {
                if (File.Exists(_configFilePath))
                {
                    string json = File.ReadAllText(_configFilePath);
                    var cfg = JsonSerializer.Deserialize<ZilleMapConfig>(json);
                    if (cfg != null && cfg.Tiles != null && cfg.Tiles.Count > 0)
                    {
                        CurrentConfig = cfg;
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
            SaveConfig();
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

            // Fallback if composite doesn't exist yet: load 01 preview or 01 full
            if (MapBackgroundTexture == null)
            {
                string bgPreview = Path.Combine(_primaryAssetsDir, "map", "T_Map_Zille_01_preview.png");
                string bgFull = Path.Combine(_primaryAssetsDir, "map", "T_Map_Zille_01.png");
                if (File.Exists(bgPreview)) MapBackgroundTexture = LoadTextureFromFile(bgPreview);
                else if (File.Exists(bgFull)) MapBackgroundTexture = LoadTextureFromFile(bgFull);
                FullMapTexture = MapBackgroundTexture;
            }

            // 2. Also load all 6 individual map grid tiles (01..06) for modular 3D map tile meshes
            for (int t = 1; t <= 6; t++)
            {
                string tPrev = Path.Combine(_primaryAssetsDir, "map", $"T_Map_Zille_0{t}_preview.png");
                string tFull = Path.Combine(_primaryAssetsDir, "map", $"T_Map_Zille_0{t}.png");
                string usePath = File.Exists(tPrev) ? tPrev : tFull;
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

            // 3. Load Region tiles (Frame 41..45)
            string regDir = Path.Combine(_primaryAssetsDir, "regions");
            if (Directory.Exists(regDir))
            {
                for (int i = 41; i <= 45; i++)
                {
                    string fname = $"Frame {i}.png";
                    string fpath = Path.Combine(regDir, fname);
                    if (File.Exists(fpath))
                    {
                        var tex = LoadTextureFromFile(fpath);
                        if (tex != null)
                        {
                            LoadedTextures[fname] = tex;
                        }
                    }
                    else
                    {
                        MelonLogger.Warning($"[ZilleMap] Tile file missing: {fpath}");
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
                bool success = ImageConversion.LoadImage(tex, fileData);
                if (success && tex.width > 2)
                {
                    tex.filterMode = FilterMode.Bilinear;
                    tex.wrapMode = TextureWrapMode.Clamp;
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
