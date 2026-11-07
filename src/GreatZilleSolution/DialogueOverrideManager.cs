using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    /// <summary>
    /// Runtime manager that loads and applies dialogue, decision, report, and situation
    /// modifications made in the Great Zille HTML Editor directly into the live game engine.
    /// Reads from Mods/GreatZilleAssets/mod_dialogue_overrides.json.
    /// </summary>
    public static class DialogueOverrideManager
    {
        private static bool _overridesApplied = false;
        private static string _cachedOverridesPath = null;
        private static DateTime _lastLoadedTime = DateTime.MinValue;

        public static string GetOverridesFilePath()
        {
            if (!string.IsNullOrEmpty(_cachedOverridesPath) && File.Exists(_cachedOverridesPath))
                return _cachedOverridesPath;

            var candidates = new List<string>
            {
                Path.Combine(Application.dataPath, "..", "Mods", "GreatZilleAssets", "mod_dialogue_overrides.json"),
                Path.Combine(Directory.GetCurrentDirectory(), "Mods", "GreatZilleAssets", "mod_dialogue_overrides.json"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mods", "GreatZilleAssets", "mod_dialogue_overrides.json"),
                Path.Combine(Directory.GetCurrentDirectory(), "assets", "mod_dialogue_overrides.json"),
                @"C:\Program Files (x86)\Steam\steamapps\common\Suzerain\Mods\GreatZilleAssets\mod_dialogue_overrides.json"
            };

            foreach (var path in candidates)
            {
                try
                {
                    if (File.Exists(path))
                    {
                        _cachedOverridesPath = Path.GetFullPath(path);
                        return _cachedOverridesPath;
                    }
                }
                catch { }
            }

            // Default target path
            string defaultPath = Path.Combine(Application.dataPath, "..", "Mods", "GreatZilleAssets", "mod_dialogue_overrides.json");
            return defaultPath;
        }

        public static void ApplyAllOverrides(bool forceReload = false)
        {
            try
            {
                string filePath = GetOverridesFilePath();
                if (!File.Exists(filePath))
                {
                    return;
                }

                var writeTime = File.GetLastWriteTime(filePath);
                if (_overridesApplied && !forceReload && writeTime <= _lastLoadedTime)
                {
                    return;
                }

                MelonLogger.Msg($"[DIALOGUE OVERRIDES] Loading narrative modifications from: {filePath}");
                string jsonText = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(jsonText)) return;

                using var doc = JsonDocument.Parse(jsonText);
                var root = doc.RootElement;

                // 1. Apply Conversation Overrides
                if (root.TryGetProperty("conversations", out var convsArray) && convsArray.ValueKind == JsonValueKind.Array)
                {
                    ApplyConversationOverrides(convsArray);
                }

                // 2. Apply Decision Overrides
                if (root.TryGetProperty("decisions", out var decsArray) && decsArray.ValueKind == JsonValueKind.Array)
                {
                    ApplyDecisionOverrides(decsArray);
                }

                // 3. Apply Report Overrides
                if (root.TryGetProperty("reports", out var repsArray) && repsArray.ValueKind == JsonValueKind.Array)
                {
                    ApplyReportOverrides(repsArray);
                }

                // 4. Apply Situation Overrides
                if (root.TryGetProperty("situations", out var sitsArray) && sitsArray.ValueKind == JsonValueKind.Array)
                {
                    ApplySituationOverrides(sitsArray);
                }

                _lastLoadedTime = writeTime;
                _overridesApplied = true;
                MelonLogger.Msg("[DIALOGUE OVERRIDES] All overrides applied successfully to game database!");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DIALOGUE OVERRIDES] ApplyAllOverrides error: {ex.Message}");
            }
        }

        private static void ApplyConversationOverrides(JsonElement convsArray)
        {
            var db = DialogueManager.masterDatabase;
            if (db == null) return;

            int count = 0;
            foreach (var convElem in convsArray.EnumerateArray())
            {
                try
                {
                    int convId = -1;
                    string title = "";
                    if (convElem.TryGetProperty("id", out var idProp))
                    {
                        if (idProp.ValueKind == JsonValueKind.Number) convId = idProp.GetInt32();
                        else if (idProp.ValueKind == JsonValueKind.String && int.TryParse(idProp.GetString(), out int parsed)) convId = parsed;
                    }
                    if (convElem.TryGetProperty("title", out var titleProp))
                    {
                        title = titleProp.GetString() ?? "";
                    }

                    Conversation targetConv = null;
                    if (convId > 0) targetConv = db.GetConversation(convId);
                    if (targetConv == null && !string.IsNullOrEmpty(title)) targetConv = db.GetConversation(title);

                    if (targetConv == null) continue;

                    if (convElem.TryGetProperty("entries", out var entriesArray) && entriesArray.ValueKind == JsonValueKind.Array)
                    {
                        foreach (var entryElem in entriesArray.EnumerateArray())
                        {
                            int entryId = -1;
                            if (entryElem.TryGetProperty("id", out var eidProp)) entryId = eidProp.GetInt32();
                            if (entryId < 0) continue;

                            var entry = targetConv.GetDialogueEntry(entryId);
                            bool isNew = false;
                            if (entry == null)
                            {
                                entry = new DialogueEntry();
                                entry.id = entryId;
                                entry.conversationID = targetConv.id;
                                entry.fields = new Il2CppSystem.Collections.Generic.List<Field>();
                                entry.outgoingLinks = new Il2CppSystem.Collections.Generic.List<Link>();
                                isNew = true;
                            }

                            if (entryElem.TryGetProperty("actorId", out var aProp) && aProp.ValueKind == JsonValueKind.Number)
                            {
                                entry.ActorID = aProp.GetInt32();
                                SetOrAddField(entry, "Actor", entry.ActorID.ToString(), FieldType.Actor);
                            }

                            if (entryElem.TryGetProperty("dialogueText", out var dtProp) && dtProp.ValueKind == JsonValueKind.String)
                            {
                                string text = dtProp.GetString() ?? "";
                                entry.DialogueText = text;
                                SetOrAddField(entry, "Dialogue Text", text, FieldType.Text);
                                SetOrAddField(entry, "en", text, FieldType.Localization);
                            }

                            if (entryElem.TryGetProperty("menuText", out var mtProp) && mtProp.ValueKind == JsonValueKind.String)
                            {
                                string menu = mtProp.GetString() ?? "";
                                entry.MenuText = menu;
                                SetOrAddField(entry, "Menu Text", menu, FieldType.Text);
                                SetOrAddField(entry, "Menu Text en", menu, FieldType.Localization);
                            }

                            if (entryElem.TryGetProperty("conditions", out var condProp) && condProp.ValueKind == JsonValueKind.String)
                            {
                                string cond = condProp.GetString() ?? "";
                                entry.conditionsString = cond;
                                SetOrAddField(entry, "Conditions", cond, FieldType.Text);
                            }

                            if (entryElem.TryGetProperty("userScript", out var usProp) && usProp.ValueKind == JsonValueKind.String)
                            {
                                string script = usProp.GetString() ?? "";
                                entry.userScript = script;
                                SetOrAddField(entry, "Script", script, FieldType.Text);
                            }

                            if (entryElem.TryGetProperty("outgoing", out var outArr) && outArr.ValueKind == JsonValueKind.Array)
                            {
                                entry.outgoingLinks.Clear();
                                foreach (var outId in outArr.EnumerateArray())
                                {
                                    if (outId.ValueKind == JsonValueKind.Number)
                                    {
                                        var link = new Link(targetConv.id, entry.id, targetConv.id, outId.GetInt32());
                                        link.priority = ConditionPriority.Normal;
                                        entry.outgoingLinks.Add(link);
                                    }
                                }
                            }

                            if (isNew)
                            {
                                targetConv.dialogueEntries.Add(entry);
                            }
                        }
                    }

                    count++;
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning($"[DIALOGUE OVERRIDES] Error overriding conversation: {ex.Message}");
                }
            }

            if (count > 0)
            {
                MelonLogger.Msg($"[DIALOGUE OVERRIDES] Successfully patched {count} conversations in masterDatabase!");
            }
        }

        private static void ApplyDecisionOverrides(JsonElement decsArray)
        {
            try
            {
                var allDecisions = EntityDataManager.AllDecisionsData ?? EntityDataManager.DecisionsData;
                if (allDecisions == null) return;

                int patched = 0;
                foreach (var decElem in decsArray.EnumerateArray())
                {
                    string id = decElem.TryGetProperty("id", out var idProp) ? (idProp.GetString() ?? "") : "";
                    if (string.IsNullOrEmpty(id)) continue;

                    DecisionData match = null;
                    for (int i = 0; i < allDecisions.Count; i++)
                    {
                        var d = allDecisions[i];
                        if (d != null && (d.NameInDatabase == id || d.Id == id))
                        {
                            match = d;
                            break;
                        }
                    }

                    if (match == null || match.DecisionProperties == null) continue;

                    if (decElem.TryGetProperty("title", out var titleProp) && titleProp.ValueKind == JsonValueKind.String)
                    {
                        match.DecisionProperties.Title = titleProp.GetString();
                    }
                    if (decElem.TryGetProperty("description", out var descProp) && descProp.ValueKind == JsonValueKind.String)
                    {
                        match.DecisionProperties.Description = descProp.GetString();
                    }

                    // Options override
                    if (decElem.TryGetProperty("options", out var optsElem) && optsElem.ValueKind == JsonValueKind.Array && match.DecisionProperties.Options != null)
                    {
                        int optIdx = 0;
                        foreach (var optElem in optsElem.EnumerateArray())
                        {
                            if (optIdx < match.DecisionProperties.Options.Count)
                            {
                                var opt = match.DecisionProperties.Options[optIdx];
                                if (opt != null)
                                {
                                    if (optElem.TryGetProperty("text", out var tProp)) opt.Text = tProp.GetString() ?? "";
                                    if (optElem.TryGetProperty("condition", out var cProp)) opt.Condition = cProp.GetString() ?? "";
                                    if (optElem.TryGetProperty("instruction", out var iProp)) opt.Instruction = iProp.GetString() ?? "";
                                }
                            }
                            optIdx++;
                        }
                    }

                    patched++;
                }

                if (patched > 0)
                {
                    MelonLogger.Msg($"[DIALOGUE OVERRIDES] Successfully patched {patched} decisions in EntityDataManager!");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DIALOGUE OVERRIDES] Error overriding decisions: {ex.Message}");
            }
        }

        private static void ApplyReportOverrides(JsonElement repsArray)
        {
            try
            {
                var allReports = EntityDataManager.ReportsData;
                if (allReports == null) return;

                int patched = 0;
                foreach (var repElem in repsArray.EnumerateArray())
                {
                    string id = repElem.TryGetProperty("id", out var idProp) ? (idProp.GetString() ?? "") : "";
                    if (string.IsNullOrEmpty(id)) continue;

                    ReportData match = null;
                    for (int i = 0; i < allReports.Count; i++)
                    {
                        var r = allReports[i];
                        if (r != null && (r.NameInDatabase == id || r.Id == id))
                        {
                            match = r;
                            break;
                        }
                    }

                    if (match == null || match.ReportProperties == null) continue;

                    if (repElem.TryGetProperty("title", out var titleProp) && titleProp.ValueKind == JsonValueKind.String)
                        match.ReportProperties.Title = titleProp.GetString();
                    if (repElem.TryGetProperty("description", out var descProp) && descProp.ValueKind == JsonValueKind.String)
                        match.ReportProperties.Description = descProp.GetString();
                    if (repElem.TryGetProperty("condition", out var condProp) && condProp.ValueKind == JsonValueKind.String)
                        match.ReportProperties.IsEnabledVariable = condProp.GetString();

                    patched++;
                }

                if (patched > 0)
                {
                    MelonLogger.Msg($"[DIALOGUE OVERRIDES] Successfully patched {patched} reports in EntityDataManager!");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DIALOGUE OVERRIDES] Error overriding reports: {ex.Message}");
            }
        }

        private static void ApplySituationOverrides(JsonElement sitsArray)
        {
            try
            {
                var allSituations = EntityDataManager.SituationsData;
                if (allSituations == null) return;

                int patched = 0;
                foreach (var sitElem in sitsArray.EnumerateArray())
                {
                    string id = sitElem.TryGetProperty("id", out var idProp) ? (idProp.GetString() ?? "") : "";
                    if (string.IsNullOrEmpty(id)) continue;

                    SituationData match = null;
                    for (int i = 0; i < allSituations.Count; i++)
                    {
                        var s = allSituations[i];
                        if (s != null && (s.NameInDatabase == id || s.Id == id))
                        {
                            match = s;
                            break;
                        }
                    }

                    if (match == null || match.SituationProperties == null) continue;

                    if (sitElem.TryGetProperty("title", out var titleProp) && titleProp.ValueKind == JsonValueKind.String)
                        match.SituationProperties.Title = titleProp.GetString();
                    if (sitElem.TryGetProperty("description", out var descProp) && descProp.ValueKind == JsonValueKind.String)
                        match.SituationProperties.Description = descProp.GetString();
                    if (sitElem.TryGetProperty("condition", out var condProp) && condProp.ValueKind == JsonValueKind.String)
                        match.SituationProperties.IsEnabledVariable = condProp.GetString();

                    patched++;
                }

                if (patched > 0)
                {
                    MelonLogger.Msg($"[DIALOGUE OVERRIDES] Successfully patched {patched} situations in EntityDataManager!");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DIALOGUE OVERRIDES] Error overriding situations: {ex.Message}");
            }
        }

        private static void SetOrAddField(DialogueEntry entry, string fieldTitle, string fieldValue, FieldType type)
        {
            if (entry == null || entry.fields == null) return;
            for (int i = 0; i < entry.fields.Count; i++)
            {
                var f = entry.fields[i];
                if (f != null && f.title == fieldTitle)
                {
                    f.value = fieldValue;
                    return;
                }
            }
            entry.fields.Add(new Field(fieldTitle, fieldValue, type));
        }
    }
}
