using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MelonLoader;

namespace GreatZilleSolution
{
    /// <summary>
    /// Wehlen's three v13 starting setups. Default is suspicious.
    /// Switch by writing {"deployment":"minimal"|"suspicious"|"prepared"} to
    /// Mods/GreatZilleAssets/zille_scenario.json and restarting the game.
    /// </summary>
    public static class ZilleDeployment
    {
        public static string Preset { get; private set; } = "suspicious";
        public static string PresetSource { get; private set; } = "";
        public static readonly List<ZilleDeploymentUnit> Units = new List<ZilleDeploymentUnit>();
        private static string _assetsDir = "";
        private static string _regionsDir = "";
        private static bool _campaignOverride;
        private static string _campaignPreset = "";

        private static readonly HashSet<string> CityNumbers = new HashSet<string>
        {
            "2", "9", "11", "28", "35", "71", "94"
        };

        private static readonly HashSet<string> ShipSeas = new HashSet<string>
        {
            "S26", "S30", "S31", "S32", "S37", "S56", "S57"
        };

        public static bool IsNavalType(string unitType)
        {
            return unitType == "submarine" || unitType == "destroyer" || unitType == "flagship";
        }

        public static bool IsForbiddenCity(string tileNumber)
        {
            return !string.IsNullOrEmpty(tileNumber) && CityNumbers.Contains(tileNumber);
        }

        /// <summary>Wehlen's opening army follows the campaign when no scenario file pins a preset.</summary>
        public static void RefreshFromCampaign()
        {
            string next = PresetFromCampaign();
            if (next == Preset && Units.Count > 0 && PresetSource == "campaign") return;
            _campaignOverride = true;
            _campaignPreset = next;
            try { Load(_assetsDir, _regionsDir); }
            finally { _campaignOverride = false; }
            MelonLogger.Msg("[ZilleMap] Wehlen deployment '" + Preset + "' follows the campaign.");
        }

        private static string PresetFromCampaign()
        {
            try
            {
                if (ZilleCampaignState.IsTwoFrontWarThreat()) return "minimal";
                int tanks = DialogueHelper.GetIntVariable("Military_Expanded_Tanks");
                int infantry = DialogueHelper.GetIntVariable("Military_Expanded_Infantry");
                if (ZilleCampaignState.IsLespiaPactAccepted || ZilleCampaignState.IsDerdiaHybridSupportActive || tanks + infantry >= 2)
                    return "prepared";
            }
            catch { }
            return "suspicious";
        }

        public static void Load(string primaryAssetsDir, string regionsDir)
        {
            Units.Clear();
            Preset = "suspicious";
            PresetSource = "";
            _assetsDir = primaryAssetsDir ?? "";
            _regionsDir = regionsDir ?? "";
            string scenario = _campaignOverride ? null : FindScenario(primaryAssetsDir, regionsDir);
            if (_campaignOverride && (_campaignPreset == "minimal" || _campaignPreset == "suspicious" || _campaignPreset == "prepared"))
            {
                Preset = _campaignPreset;
                PresetSource = "campaign";
            }
            else if (scenario != null)
            {
                string chosen = ReadPreset(scenario);
                if (chosen == "minimal" || chosen == "suspicious" || chosen == "prepared")
                {
                    Preset = chosen;
                    PresetSource = scenario;
                }
                else
                {
                    MelonLogger.Warning("[ZilleMap] " + scenario + " has no usable deployment. Using 'suspicious'. Write {\"deployment\":\"minimal\"|\"suspicious\"|\"prepared\"}.");
                }
            }

            string file = FindPack(regionsDir, Preset);
            if (file == null)
            {
                MelonLogger.Warning("[ZilleMap] deployment_" + Preset + ".json was not found. Wehlen starts with no preset units.");
                LogHowToSwitch(primaryAssetsDir);
                return;
            }

            int skippedCity = 0, skippedDup = 0, skippedRule = 0, flagships = 0, land = 0, naval = 0;
            var seen = new HashSet<string>();
            try
            {
                using var doc = JsonDocument.Parse(File.ReadAllText(file));
                if (!doc.RootElement.TryGetProperty("deployment", out var arr) || arr.ValueKind != JsonValueKind.Array)
                {
                    MelonLogger.Warning("[ZilleMap] " + file + " has no deployment list.");
                    LogHowToSwitch(primaryAssetsDir);
                    return;
                }
                foreach (var e in arr.EnumerateArray())
                {
                    string pid = JsonStr(e, "province_id");
                    string name = JsonStr(e, "province_name");
                    string kind = JsonStr(e, "unit_type");
                    if (string.IsNullOrEmpty(pid) || !pid.StartsWith("ZilleTile_", StringComparison.Ordinal) || string.IsNullOrEmpty(kind))
                    {
                        skippedRule++;
                        continue;
                    }
                    string number = pid.Substring("ZilleTile_".Length);
                    if (!seen.Add(number))
                    {
                        skippedDup++;
                        continue;
                    }
                    if (CityNumbers.Contains(number) || ShipSeas.Contains(number))
                    {
                        if (CityNumbers.Contains(number)) skippedCity++;
                        else skippedRule++;
                        continue;
                    }
                    bool navalKind = IsNavalType(kind);
                    if (navalKind && !number.StartsWith("S", StringComparison.Ordinal))
                    {
                        skippedRule++;
                        continue;
                    }
                    if (!navalKind && number.StartsWith("S", StringComparison.Ordinal))
                    {
                        skippedRule++;
                        continue;
                    }
                    if (kind == "flagship" && flagships >= 1)
                    {
                        skippedRule++;
                        continue;
                    }
                    var tile = FindTile(number);
                    if (tile != null)
                    {
                        if (tile.IsCity || tile.IsNavalStart)
                        {
                            if (tile.IsCity) skippedCity++;
                            else skippedRule++;
                            continue;
                        }
                        if (!navalKind && (tile.IsSea || tile.Allegiance != "Wehlen"))
                        {
                            skippedRule++;
                            continue;
                        }
                        if (navalKind && !tile.IsSea)
                        {
                            skippedRule++;
                            continue;
                        }
                    }
                    if (kind == "flagship") flagships++;
                    Units.Add(new ZilleDeploymentUnit
                    {
                        ProvinceId = pid,
                        ProvinceName = name ?? "",
                        UnitType = kind,
                        TileNumber = number
                    });
                    if (navalKind) naval++; else land++;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error("[ZilleMap] Deployment read failed: " + ex.Message);
                Units.Clear();
                return;
            }

            MelonLogger.Msg("[ZilleMap] Deployment '" + Preset + "': " + Units.Count
                + " units (" + land + " land, " + naval + " naval), " + flagships
                + " flagship. Cities skipped: " + skippedCity
                + ". Duplicate provinces skipped: " + skippedDup
                + ". Rule skips: " + skippedRule + ".");
            LogHowToSwitch(primaryAssetsDir);
        }

        private static void LogHowToSwitch(string primaryAssetsDir)
        {
            string where = Path.Combine(string.IsNullOrEmpty(primaryAssetsDir) ? "Mods/GreatZilleAssets" : primaryAssetsDir, "zille_scenario.json");
            if (string.IsNullOrEmpty(PresetSource))
                MelonLogger.Msg("[ZilleMap] Deployment preset 'suspicious' (default). To switch, write {\"deployment\":\"minimal\"|\"suspicious\"|\"prepared\"} to " + where + " and restart.");
            else
                MelonLogger.Msg("[ZilleMap] Deployment preset '" + Preset + "' from " + PresetSource + ". To switch, edit that file and restart.");
        }

        private static ZilleTileData FindTile(string number)
        {
            var tiles = ZilleMapLayoutManager.CurrentConfig?.Tiles;
            if (tiles == null) return null;
            string id = "tile_" + number.ToLowerInvariant();
            for (int i = 0; i < tiles.Count; i++)
            {
                var t = tiles[i];
                if (t.Id == id || t.TileNumber == number) return t;
            }
            return null;
        }

        private static string FindScenario(string primary, string regionsDir)
        {
            var paths = new List<string>();
            if (!string.IsNullOrEmpty(primary)) paths.Add(Path.Combine(primary, "zille_scenario.json"));
            if (!string.IsNullOrEmpty(regionsDir))
            {
                string pack = Path.GetDirectoryName(regionsDir.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
                if (!string.IsNullOrEmpty(pack)) paths.Add(Path.Combine(pack, "zille_scenario.json"));
            }
            for (int i = 0; i < paths.Count; i++)
                if (File.Exists(paths[i])) return paths[i];
            return null;
        }

        private static string ReadPreset(string path)
        {
            try
            {
                using var doc = JsonDocument.Parse(File.ReadAllText(path));
                if (doc.RootElement.TryGetProperty("deployment", out var p) && p.ValueKind == JsonValueKind.String)
                    return (p.GetString() ?? "").Trim().ToLowerInvariant();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZilleMap] Could not read " + path + ": " + ex.Message);
            }
            return "";
        }

        private static string FindPack(string regionsDir, string preset)
        {
            string name = "deployment_" + preset + ".json";
            if (!string.IsNullOrEmpty(regionsDir))
            {
                string local = Path.Combine(regionsDir, "deployments", name);
                if (File.Exists(local)) return local;
            }
            string repo = Path.Combine(@"c:\Projects\Great Zille solution\maps\zille\v14\regions", "deployments", name);
            if (File.Exists(repo)) return repo;
            return null;
        }

        private static string JsonStr(JsonElement e, string name)
        {
            if (!e.TryGetProperty(name, out var p) || p.ValueKind != JsonValueKind.String) return "";
            return p.GetString() ?? "";
        }
    }
}
