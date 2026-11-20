using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static partial class ZillePlaytest
    {
        private static readonly string EventsReportPath =
            @"C:\Users\iwo\.gemini\antigravity\brain\92cf9b04-fe39-43f2-a000-fd1a073e796e\scratch\playtest_events_report.txt";

        private static readonly string EventsScratchDir =
            @"C:\Users\iwo\.gemini\antigravity\brain\92cf9b04-fe39-43f2-a000-fd1a073e796e\scratch";

        private class EventsAuditReport
        {
            public readonly StringBuilder Lines = new StringBuilder();
            public int Pass;
            public int Warn;
            public int Fail;

            public void Header(string title)
            {
                string bar = new string('=', 72);
                Lines.AppendLine();
                Lines.AppendLine(bar);
                Lines.AppendLine(title);
                Lines.AppendLine(bar);
                MelonLogger.Msg("[AUTOTEST EVENTS] " + title);
            }

            public void LogPass(string check, string detail = "")
            {
                Pass++;
                string msg = string.IsNullOrEmpty(detail) ? $"[PASS] {check}" : $"[PASS] {check} :: {detail}";
                Lines.AppendLine(msg);
                MelonLogger.Msg("[AUTOTEST EVENTS] " + msg);
            }

            public void LogWarn(string check, string detail = "")
            {
                Warn++;
                string msg = string.IsNullOrEmpty(detail) ? $"[WARN] {check}" : $"[WARN] {check} :: {detail}";
                Lines.AppendLine(msg);
                MelonLogger.Warning("[AUTOTEST EVENTS] " + msg);
            }

            public void LogFail(string check, string detail = "")
            {
                Fail++;
                string msg = string.IsNullOrEmpty(detail) ? $"[FAIL] {check}" : $"[FAIL] {check} :: {detail}";
                Lines.AppendLine(msg);
                MelonLogger.Error("[AUTOTEST EVENTS] " + msg);
            }

            public void LogInfo(string detail)
            {
                Lines.AppendLine("[INFO] " + detail);
                MelonLogger.Msg("[AUTOTEST EVENTS] [INFO] " + detail);
            }

            public void Flush()
            {
                try
                {
                    if (!Directory.Exists(EventsScratchDir)) Directory.CreateDirectory(EventsScratchDir);
                    var sb = new StringBuilder();
                    sb.AppendLine($"Great Zille Solution - Autonomous Events, Portraits, Decisions, Reports & Saves Report");
                    sb.AppendLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    sb.AppendLine($"SUMMARY: PASS={Pass}, WARN={Warn}, FAIL={Fail}");
                    sb.Append(Lines.ToString());
                    sb.AppendLine();
                    sb.AppendLine($"FINAL RESULT: {(Fail == 0 ? "ALL CHECKS PASSED" : $"{Fail} CHECK(S) FAILED")} (PASS={Pass}, WARN={Warn}, FAIL={Fail})");
                    File.WriteAllText(EventsReportPath, sb.ToString(), Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MelonLogger.Error("[AUTOTEST EVENTS] Flush report failed: " + ex.Message);
                }
            }
        }

        private static readonly (string DbName, string TitlePath)[] AllModScenes = new[]
        {
            ("Turn_Zille_DerdiaInvestigation", "Zille/DerdiaInvestigation"),
            ("Turn_Zille_WarPlanning", "Zille/WarPlanning"),
            ("Turn_Zille_WarLogisticsDispute", "Zille/WarLogisticsDispute"),
            ("Turn_Zille_WarBriefing", "Zille/WarCouncil_Briefing"),
            ("Turn_Zille_MaveNortusHQ", "Zille/MaveNortusHQ"),
            ("Turn_Zille_WarBalconySpeech", "Zille/WarBalconySpeech"),
            ("Turn_Zille_Op1AftermathCouncil", "Zille/Op1AftermathCouncil"),
            ("Turn_Zille_DerdiaTalks", "Zille/DerdiaTalks"),
            ("Turn_Zille_DerdiaStateVisit", "Zille/DerdiaStateVisit"),
            ("Turn_Zille_LespiaTalks", "Zille/LespiaTalks"),
            ("Turn_Zille_RumburgTalks", "Zille/RumburgTalks"),
            ("Turn_Zille_WarPreNegotiationsBriefing", "Zille/WarPreNegotiationsBriefing"),
            ("Turn_Zille_WarSmolakFinalParley", "Zille/WarSmolakFinalParley"),
            ("Turn_Zille_WarPeaceTreaty", "Zille/WarPeaceTreaty"),
            ("Turn_Zille_HomeFrontCrisis", "Zille/HomeFrontCrisis"),
            ("Turn_Zille_ZilleLiberation", "Zille/ZilleLiberation"),
            ("Turn_Zille_ExileEpilogue", "Zille/ExileEpilogue")
        };

        private static readonly string[] AuditProfiles = new[]
        {
            "P1_Baseline_Op1",
            "P2_Purged_DeadCouncil",
            "P3_Op1_DecisiveVictory_VinaDead",
            "P4_Op2_TotalRepayment_Stalemate",
            "P5_Op2_TacticalDefeat_CollapseWarning",
            "P6_TotalFiasco_Collapse_Exile",
            "P7_EarlyWar_Turn3_Turn4_ArtSword",
            "P8_HomeFrontCrisis_HighAN"
        };

        public static IEnumerator RunAutonomousEventsAndSavesSuiteCoroutine()
        {
            Application.runInBackground = true;
            var rep = new EventsAuditReport();
            rep.Header("STAGE 0: Boot & Entering Rizia Session");

            try
            {
                MelonLogger.Msg("[AUTOTEST EVENTS] Suite started. Waiting for Main Menu or Rizia...");
            }
            catch { }

            // Wait for Main Menu or Rizia
            float bootWait = 0f;
            while (bootWait < 60f)
            {
                var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                if (string.Equals(sc.name, "Main Menu", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(sc.name, "Rizia", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                yield return new WaitForSeconds(0.5f);
                bootWait += 0.5f;
            }
            yield return new WaitForSeconds(4.0f);

            var initSc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if (string.Equals(initSc.name, "Main Menu", StringComparison.OrdinalIgnoreCase))
            {
                rep.LogInfo("Main Menu detected -> waiting for MainMenuPanel & retrying OnContinueClick() until Rizia loads...");
                float w = 0f;
                while (w < 50f)
                {
                    var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                    if (!string.Equals(sc.name, "Main Menu", StringComparison.OrdinalIgnoreCase)
                        && !string.Equals(sc.name, "Initialize", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    var mm = UnityEngine.Object.FindObjectOfType<MainMenuPanel>();
                    var pm0 = PersistenceManager.Instance ?? UnityEngine.Object.FindObjectOfType<PersistenceManager>();
                    int sfCount = pm0?.AllSaveFiles != null ? pm0.AllSaveFiles.Count : -1;
                    bool showing = false;
                    try { showing = mm != null && mm.IsShowing(); } catch { }
                    rep.LogInfo($"Main Menu poll w={w:0}s mm={(mm != null)} showing={showing} allSaveFiles={sfCount}");
                    if (mm != null && showing)
                    {
                        try { mm.OnContinueClick(); } catch (Exception ex) { rep.LogWarn("OnContinueClick", ex.Message); }
                    }
                    yield return new WaitForSeconds(3.0f);
                    w += 3.0f;
                }
                yield return new WaitForSeconds(3.0f);
            }

            var activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if (string.Equals(activeScene.name, "Main Menu", StringComparison.OrdinalIgnoreCase)
                || string.Equals(activeScene.name, "Initialize", StringComparison.OrdinalIgnoreCase))
            {
                rep.LogFail("Scene Boot", $"Timed out still in scene '{activeScene.name}'");
                rep.Flush();
                Application.Quit();
                yield break;
            }
            rep.LogPass("Scene Boot", $"Loaded active game scene '{activeScene.name}'");

            // Ensure registration
            try
            {
                ZilleDialogueSystem.EnsureAllConversationsRegistered();
                ZilleDialogueSystem.InjectAllVanillaConversationPatches();
                WarOperationZilleManager.RegisterNativeZilleEntities();
                ZilleDecisions.EnsureRegistered();
                ZilleReportsAndSituations.EnsureRegisteredAndSynced();
                rep.LogPass("Subsystem Registration", "Conversations, vanilla patches, decisions, and reports/situations registered cleanly.");
            }
            catch (Exception ex)
            {
                rep.LogFail("Subsystem Registration", ex.ToString());
            }

            yield return new WaitForSeconds(0.5f);

            // =========================================================================
            // STAGE 1: Static/Lua Graph, Dead-End, Lore & Vanilla Patch Audit (8 profiles)
            // =========================================================================
            rep.Header("STAGE 1: All 17 Scenes, 8 Lua Profiles, Dead-End, Lore & Vanilla Patch Audit");
            try
            {
                RunStage1Audit(rep);
            }
            catch (Exception ex)
            {
                rep.LogFail("Stage 1 Exception", ex.ToString());
            }

            // =========================================================================
            // STAGE 2: Live ConversationPanel Portraits, Mechanics, Decisions & Epilogue
            // =========================================================================
            rep.Header("STAGE 2: Live ConversationPanel Portraits & Gameplay Chains");
            yield return RunStage2LiveUiAndChainsCoroutine(rep);

            // =========================================================================
            // STAGE 3: Real Savegames Across Turns (Read-Only)
            // =========================================================================
            rep.Header("STAGE 3: Multi-Turn Real Savegame Compatibility (Read-Only)");
            yield return RunStage3RealSavesCoroutine(rep);

            rep.Flush();
            MelonLogger.Msg($"[AUTOTEST EVENTS] Finished! PASS={rep.Pass}, WARN={rep.Warn}, FAIL={rep.Fail}. Report saved to: {EventsReportPath}");
            yield return new WaitForSeconds(1.0f);
            Application.Quit();
        }

        private static void ApplyAuditProfile(string profileName)
        {
            // Reset character & political state cleanly
            string[] clearBoolVars = new[]
            {
                "QueenMother_Estela_Dead", "RiziaDLC.Estela_Dead", "RiziaDLC.Estela_EarlyExile",
                "RiziaDLC.Vina_FuneralHappened", "RiziaDLC.Vina_Dead", "RiziaDLC.Vina_Escapes",
                "RiziaDLC.Vina_EarlyExile", "RiziaDLC.Vina_Hostage", "RiziaDLC.Vina_InPales",
                "RiziaDLC.AxelVina_Married_Official", "RiziaDLC.BirthdayGathering_VinaExiled",
                "RiziaDLC.Hugo_Exiled", "RiziaDLC.Hugo_Dead",
                "RiziaDLC.Lucita_Arrested", "RiziaDLC.Lucita_Executed", "RiziaDLC.Lucita_Dead",
                "RiziaDLC.Titus_Dead", "RiziaDLC.Titus_Betrayal", "RiziaDLC.Titus_Arrested",
                "RiziaDLC.Sal_Arrested", "RiziaDLC.Sal_Executed", "RiziaDLC.Sal_Dead",
                "RiziaDLC.Laurento_Arrested", "RiziaDLC.Carlos_Dead", "RiziaDLC.Manus_Dead",
                "RiziaDLC.Azaro_HasPowerToCoup", "RiziaDLC.Ending_Coup_Azaro",
                "RiziaDLC.Epilogue_Exile_Forced", "RiziaDLC.Epilogue_Exile_CoupWarning",
                "RiziaDLC.ZilleReturn_Success", "RiziaDLC.Zille_Sazon_Rebelled",
                "Zille_Parley_Refused", "Zille_Azaro_Coup_Collapse", "Zille_ExileEpilogue_Done",
                "Zille_PeaceTreaty_Signed", "Zille_Rep_TreatyDone", "Zille_Negotiations_Done",
                "Zille_Liberation_Done", "Zille_HomeFrontCrisis_Done",
                "Turn04_Derdia_Suspicious", "Zille_Derdia_Alliance", "Zille_Lespia_Accepted",
                "Zille_Rumburg_Accepted", "Zille_Rebellion_Suppressed",
                "Zille_Op1_Negotiations_Unlocked", "Zille_Op2_Unlocked",
                "Zille_IndependentBuffer_Agreed", "Zille_War_Active",
                "Zille_EarlyWar_Triggered", "Zille_War_Early"
            };
            foreach (var v in clearBoolVars) DialogueHelper.SetVariable(v, false);

            DialogueHelper.SetVariable("RiziaDLC.Turn", 8);
            DialogueHelper.SetVariable("RiziaDLC.Resources_Energy", 4);
            DialogueHelper.SetVariable("RiziaDLC.Resources_Budget", 6);
            DialogueHelper.SetVariable("RiziaDLC.Resources_Authority", 5);
            DialogueHelper.SetVariable("RiziaDLC.Resources_Military_Equipment", 1200);

            ZilleCampaignState.MilitarySentimentLevel = 2;
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1;
            ZilleCampaignState.CurrentOperationNumber = 1;
            ZilleCampaignState.CurrentPhaseNumber = 1;
            ZilleCampaignState.Outcome = ZilleWarOutcome.None;
            ZilleCampaignState.Phase1Finished = false;
            ZilleCampaignState.Operation1Finished = false;
            ZilleCampaignState.Op1CouncilAvailable = false;
            ZilleCampaignState.Op1CouncilCompleted = false;
            ZilleCampaignState.TotalRepaymentUnlocked = false;
            ZilleCampaignState.IsBrenasLost = false;
            ZilleCampaignState.IsIndependentZilleAgreed = false;
            ZilleCampaignState.IsNavalBlockadeActive = false;
            ZilleCampaignState.IsLespiaPactAccepted = false;
            ZilleCampaignState.IsRumburgMunitionsActive = false;
            ZilleCampaignState.IsDerdiaHybridSupportActive = false;
            ZilleCampaignState.SmolakPressureScore = 30;
            ZilleCampaignState.AnLegitimacyScore = 60;
            ZilleCampaignState.LogisticsRoute = "Azaro";
            ZilleCampaignState.ZilleCityCaptured = false;
            ZilleCampaignState.CapZilleCity = false;

            DialogueHelper.SetVariable("Zille_War_Active", true);

            switch (profileName)
            {
                case "P1_Baseline_Op1":
                    ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanArk);
                    ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1;
                    ZilleCampaignState.SmolakPressureScore = 40;
                    break;

                case "P2_Purged_DeadCouncil":
                    DialogueHelper.SetVariable("QueenMother_Estela_Dead", true);
                    DialogueHelper.SetVariable("RiziaDLC.Estela_Dead", true);
                    DialogueHelper.SetVariable("RiziaDLC.Vina_InPales", true);
                    DialogueHelper.SetVariable("RiziaDLC.Hugo_Exiled", true);
                    DialogueHelper.SetVariable("RiziaDLC.Titus_Dead", true);
                    DialogueHelper.SetVariable("RiziaDLC.Lucita_Arrested", true);
                    DialogueHelper.SetVariable("RiziaDLC.Sal_Dead", true);
                    ZilleCampaignState.Outcome = ZilleWarOutcome.DecisiveVictory;
                    ZilleCampaignState.Phase1Finished = true;
                    ZilleCampaignState.Operation1Finished = true;
                    ZilleCampaignState.Op1CouncilAvailable = true;
                    ZilleCampaignState.ZilleCityCaptured = true;
                    ZilleCampaignState.CapZilleCity = true;
                    DialogueHelper.SetVariable("Zille_PeaceTreaty_Signed", true);
                    break;

                case "P3_Op1_DecisiveVictory_VinaDead":
                    DialogueHelper.SetVariable("RiziaDLC.Vina_Dead", true);
                    DialogueHelper.SetVariable("RiziaDLC.Vina_FuneralHappened", true);
                    DialogueHelper.SetVariable("Zille_Derdia_Alliance", true);
                    DialogueHelper.SetVariable("Zille_Lespia_Accepted", true);
                    DialogueHelper.SetVariable("Zille_Rumburg_Accepted", true);
                    DialogueHelper.SetVariable("Zille_PeaceTreaty_Signed", true);
                    ZilleCampaignState.IsDerdiaHybridSupportActive = true;
                    ZilleCampaignState.IsLespiaPactAccepted = true;
                    ZilleCampaignState.IsRumburgMunitionsActive = true;
                    ZilleCampaignState.SmolakPressureScore = 120;
                    ZilleCampaignState.Outcome = ZilleWarOutcome.DecisiveVictory;
                    ZilleCampaignState.Operation1Finished = true;
                    ZilleCampaignState.Op1CouncilAvailable = true;
                    ZilleCampaignState.ZilleCityCaptured = true;
                    ZilleCampaignState.CapZilleCity = true;
                    DialogueHelper.SetVariable("Zille_Op1_Outcome", (int)ZilleWarOutcome.DecisiveVictory);
                    DialogueHelper.SetVariable("Zille_Negotiations_Outcome", "DecisiveVictory");
                    break;

                case "P4_Op2_TotalRepayment_Stalemate":
                    ZilleCampaignState.CurrentOperationNumber = 2;
                    ZilleCampaignState.CurrentPhaseNumber = 2;
                    ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2_TotalRepayment;
                    ZilleCampaignState.Phase1Finished = true;
                    ZilleCampaignState.Operation1Finished = true;
                    ZilleCampaignState.Op1CouncilCompleted = true;
                    ZilleCampaignState.TotalRepaymentUnlocked = true;
                    ZilleCampaignState.Outcome = ZilleWarOutcome.BloodyStalemate;
                    ZilleCampaignState.IsIndependentZilleAgreed = true;
                    DialogueHelper.SetVariable("Zille_Op2_Unlocked", true);
                    DialogueHelper.SetVariable("Zille_Negotiations_Outcome", "BloodyStalemate");
                    DialogueHelper.SetVariable("Zille_IndependentBuffer_Agreed", true);
                    break;

                case "P5_Op2_TacticalDefeat_CollapseWarning":
                    ZilleCampaignState.CurrentOperationNumber = 2;
                    ZilleCampaignState.CurrentPhaseNumber = 2;
                    ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2_TotalRepayment;
                    ZilleCampaignState.Outcome = ZilleWarOutcome.TacticalDefeat;
                    DialogueHelper.SetVariable("RiziaDLC.Azaro_HasPowerToCoup", true);
                    DialogueHelper.SetVariable("Zille_Negotiations_Outcome", "TacticalDefeat");
                    break;

                case "P6_TotalFiasco_Collapse_Exile":
                    ZilleCampaignState.CurrentOperationNumber = 2;
                    ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2_TotalRepayment;
                    ZilleCampaignState.Outcome = ZilleWarOutcome.TotalFiasco;
                    ZilleCampaignState.IsBrenasLost = true;
                    DialogueHelper.SetVariable("Zille_Parley_Refused", true);
                    DialogueHelper.SetVariable("Zille_Azaro_Coup_Collapse", true);
                    DialogueHelper.SetVariable("RiziaDLC.Ending_Coup_Azaro", true);
                    DialogueHelper.SetVariable("RiziaDLC.Epilogue_Exile_Forced", true);
                    DialogueHelper.SetVariable("RiziaDLC.Epilogue_Exile_CoupWarning", true);
                    DialogueHelper.SetVariable("RiziaDLC.Vina_Escapes", true);
                    DialogueHelper.SetVariable("Zille_Negotiations_Outcome", "TotalFiasco");
                    break;

                case "P7_EarlyWar_Turn3_Turn4_ArtSword":
                    DialogueHelper.SetVariable("RiziaDLC.Turn", 4);
                    DialogueHelper.SetVariable("Turn04_Derdia_Suspicious", true);
                    DialogueHelper.SetVariable("Zille_EarlyWar_Triggered", true);
                    DialogueHelper.SetVariable("Zille_War_Early", true);
                    ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanSword);
                    ZilleCampaignState.MilitarySentimentLevel = 2;
                    ZilleCampaignState.SmolakPressureScore = 65;
                    ZilleCampaignState.IsDerdiaHybridSupportActive = true;
                    break;

                case "P8_HomeFrontCrisis_HighAN":
                    DialogueHelper.SetVariable("RiziaDLC.Resources_Energy", -2);
                    DialogueHelper.SetVariable("RiziaDLC.Resources_Military_Equipment", 400);
                    DialogueHelper.SetVariable("RiziaDLC.Zille_Sazon_Rebelled", true);
                    ZilleCampaignState.SmolakPressureScore = 8;
                    ZilleCampaignState.AnLegitimacyScore = 15;
                    break;
            }

            ZilleCampaignState.SyncToLua();
            ZilleReportsAndSituations.SyncVariables();
        }

        private static Conversation FindConversationInDb(DialogueDatabase db, string dbName, string titlePath)
        {
            if (db == null) return null;
            var c = db.GetConversation(titlePath);
            if (c != null) return c;
            c = db.GetConversation(dbName);
            if (c != null) return c;
            string shortKey = dbName.Replace("Turn_Zille_", "");
            if (db.conversations != null)
            {
                for (int i = 0; i < db.conversations.Count; i++)
                {
                    var conv = db.conversations[i];
                    if (conv == null || string.IsNullOrEmpty(conv.Title)) continue;
                    if (conv.Title.EndsWith("/" + shortKey, StringComparison.OrdinalIgnoreCase)
                        || string.Equals(conv.Title, shortKey, StringComparison.OrdinalIgnoreCase))
                        return conv;
                }
            }
            return null;
        }

        private static void RunStage1Audit(EventsAuditReport rep)
        {
            var db = DialogueManager.masterDatabase;
            if (db == null)
            {
                rep.LogFail("DialogueDatabase", "DialogueManager.masterDatabase is null!");
                return;
            }

            int foundCustom = 0;
            int valdezHits = 0, dastHits = 0, harryingHits = 0, sireHits = 0, highWiserHits = 0;
            int brassHits = 0, mahoganyHits = 0;
            Regex sireRegex = new Regex(@"\bSire\b", RegexOptions.IgnoreCase);

            foreach (var scene in AllModScenes)
            {
                var conv = FindConversationInDb(db, scene.DbName, scene.TitlePath);
                if (conv == null)
                {
                    rep.LogFail($"Missing Conversation [{scene.DbName}]", $"Could not find '{scene.TitlePath}' or '{scene.DbName}' in masterDatabase.");
                    continue;
                }
                foundCustom++;

                int entryCount = conv.dialogueEntries != null ? conv.dialogueEntries.Count : 0;
                if (entryCount <= 1)
                {
                    rep.LogFail($"Empty Conversation [{scene.DbName}]", $"Only {entryCount} entries found.");
                    continue;
                }

                var entryById = new Dictionary<int, DialogueEntry>();
                for (int i = 0; i < conv.dialogueEntries.Count; i++)
                {
                    var e = conv.dialogueEntries[i];
                    if (e != null) entryById[e.id] = e;
                }

                // Scan lore / grammar / AI-ism text quality across every node
                foreach (var kv in entryById)
                {
                    var e = kv.Value;
                    string combined = (e.DialogueText ?? "") + "\n" + (e.MenuText ?? "");
                    if (string.IsNullOrWhiteSpace(combined)) continue;

                    if (combined.IndexOf("Valdez", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        valdezHits++;
                        rep.LogFail($"Lore Violation 'Valdez' in {conv.Title} node {e.id}", combined.Substring(0, Math.Min(100, combined.Length)));
                    }
                    if (combined.IndexOf("For Dast", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        dastHits++;
                        rep.LogFail($"Lore Violation 'For Dast' in {conv.Title} node {e.id}", combined.Substring(0, Math.Min(100, combined.Length)));
                    }
                    if (combined.IndexOf("harrying", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        harryingHits++;
                        rep.LogFail($"Grammar Typo 'harrying' in {conv.Title} node {e.id}", combined.Substring(0, Math.Min(100, combined.Length)));
                    }
                    if (combined.IndexOf("High Wiser", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        highWiserHits++;
                        rep.LogFail($"Title Typo 'High Wiser' in {conv.Title} node {e.id}", combined.Substring(0, Math.Min(100, combined.Length)));
                    }
                    if (sireRegex.IsMatch(combined))
                    {
                        sireHits++;
                        rep.LogFail($"Wrong Royal Address 'Sire' in {conv.Title} node {e.id}", combined.Substring(0, Math.Min(100, combined.Length)));
                    }
                    if (combined.IndexOf("brass", StringComparison.OrdinalIgnoreCase) >= 0) brassHits++;
                    if (combined.IndexOf("mahogany", StringComparison.OrdinalIgnoreCase) >= 0) mahoganyHits++;
                }

                // Traverse graph under all 8 Lua state profiles
                int deadEndsFound = 0;
                int brokenLinks = 0;
                int startOpeningsTotal = 0;

                foreach (var prof in AuditProfiles)
                {
                    ApplyAuditProfile(prof);

                    if (!entryById.TryGetValue(0, out var startNode))
                    {
                        rep.LogFail($"Missing Start Node 0 [{conv.Title}]", $"Profile={prof}");
                        break;
                    }

                    var visited = new HashSet<int>();
                    var queue = new Queue<DialogueEntry>();
                    visited.Add(0);
                    queue.Enqueue(startNode);

                    while (queue.Count > 0)
                    {
                        var cur = queue.Dequeue();
                        if (cur.outgoingLinks == null || cur.outgoingLinks.Count == 0)
                            continue; // Natural leaf ending

                        int validChildren = 0;
                        for (int li = 0; li < cur.outgoingLinks.Count; li++)
                        {
                            var lnk = cur.outgoingLinks[li];
                            if (lnk == null) continue;
                            if (lnk.destinationConversationID != conv.id && lnk.destinationConversationID > 0)
                            {
                                // Cross-conversation link: count as valid exit
                                validChildren++;
                                continue;
                            }
                            if (!entryById.TryGetValue(lnk.destinationDialogueID, out var dest))
                            {
                                brokenLinks++;
                                rep.LogFail($"Broken Link [{conv.Title}]", $"prof={prof} from node {cur.id} -> missing dest {lnk.destinationDialogueID}");
                                continue;
                            }

                            bool condOk = string.IsNullOrWhiteSpace(dest.conditionsString);
                            if (!condOk)
                            {
                                try { condOk = Lua.IsTrue(dest.conditionsString); }
                                catch (Exception lex)
                                {
                                    rep.LogWarn($"Lua Cond Eval [{conv.Title}] node {dest.id}", $"{lex.Message} :: cond='{dest.conditionsString}'");
                                    condOk = false;
                                }
                            }

                            if (condOk)
                            {
                                validChildren++;
                                if (cur.id == 0) startOpeningsTotal++;
                                if (visited.Add(dest.id))
                                    queue.Enqueue(dest);
                            }
                        }

                        if (cur.id > 0 && validChildren == 0)
                        {
                            deadEndsFound++;
                            rep.LogFail($"DEAD-END Node [{conv.Title}]", $"prof={prof} node={cur.id} ('{cur.Title}') has {cur.outgoingLinks.Count} outgoingLinks, 0 pass Lua conditions!");
                        }
                    }
                }

                if (startOpeningsTotal == 0)
                {
                    rep.LogFail($"Unreachable Scene Start [{conv.Title}]", "Node 0 had 0 valid openings across all 8 audit profiles!");
                }
                else if (deadEndsFound == 0 && brokenLinks == 0)
                {
                    rep.LogPass($"Scene Graph & Text [{conv.Title}]", $"entries={entryCount}, 0 dead-ends, 0 broken links across 8 profiles.");
                }
            }

            if (foundCustom == AllModScenes.Length)
                rep.LogPass("All 17 Mod Conversations Present", $"{foundCustom}/{AllModScenes.Length} scenes verified in masterDatabase.");
            else
                rep.LogFail("Mod Conversations Count", $"Only {foundCustom}/{AllModScenes.Length} present.");

            if (valdezHits == 0 && dastHits == 0 && harryingHits == 0 && sireHits == 0 && highWiserHits == 0)
                rep.LogPass("Lore, Grammar & Address Scan", $"0 violations across all 17 scenes (brass occurrences={brassHits}, mahogany occurrences={mahoganyHits}).");

            // Check vanilla conversation patches (Referendum/Handback interrupt & 426_Exile Azaro collapse branch)
            int interruptPatches = 0;
            int exilePatches = 0;
            if (db.conversations != null)
            {
                for (int i = 0; i < db.conversations.Count; i++)
                {
                    var c = db.conversations[i];
                    if (c?.dialogueEntries == null) continue;
                    string t = c.Title ?? "";
                    bool isRefOrNeg = t.IndexOf("ZilleReferendum", StringComparison.OrdinalIgnoreCase) >= 0
                                   || t.IndexOf("ZilleHandback", StringComparison.OrdinalIgnoreCase) >= 0
                                   || t.IndexOf("ZilleReturnedSpeech", StringComparison.OrdinalIgnoreCase) >= 0
                                   || t.IndexOf("ZilleNegotiations", StringComparison.OrdinalIgnoreCase) >= 0;
                    bool isExile = t.IndexOf("Exile", StringComparison.OrdinalIgnoreCase) >= 0
                                && !t.StartsWith("Zille/", StringComparison.OrdinalIgnoreCase)
                                && !t.StartsWith("Turn_Zille_", StringComparison.OrdinalIgnoreCase);

                    if (!isRefOrNeg && !isExile) continue;

                    for (int ei = 0; ei < c.dialogueEntries.Count; ei++)
                    {
                        var e = c.dialogueEntries[ei];
                        if (e == null) continue;
                        string txt = e.DialogueText ?? "";
                        string cnd = e.conditionsString ?? "";
                        if (isRefOrNeg && (txt.IndexOf("INTERRUPT", StringComparison.OrdinalIgnoreCase) >= 0 || cnd.Contains("Zille_War_Active")))
                        {
                            interruptPatches++;
                        }
                        if (isExile && (cnd.Contains("Ending_Coup_Azaro") || cnd.Contains("Zille_Azaro_Coup_Collapse") || txt.IndexOf("Kyrute", StringComparison.OrdinalIgnoreCase) >= 0))
                        {
                            exilePatches++;
                        }
                    }
                }
            }

            if (interruptPatches > 0)
                rep.LogPass("Vanilla Zille Interrupt Patches", $"Detected {interruptPatches} war-interrupt entries/conditions across vanilla Referendum/Handback/Negotiation scenes.");
            else
                rep.LogWarn("Vanilla Zille Interrupt Patches", "0 matching entries detected (check vanilla conversation titles in DialogueDatabase).");

            if (exilePatches > 0)
                rep.LogPass("Vanilla Exile Epilogue Patch", $"Detected {exilePatches} Azaro collapse/Kyrute entries/conditions inside vanilla Exile conversation(s).");
            else
                rep.LogWarn("Vanilla Exile Epilogue Patch", "0 matching entries detected in vanilla Exile conversation.");
        }

        private static IEnumerator RunStage2LiveUiAndChainsCoroutine(EventsAuditReport rep)
        {
            // Helper to test ConversationPanel portraits
            IEnumerator CheckPortraits(string label, string profile, string dbName, string titlePath, string[] mustHave, string[] mustNotHave)
            {
                try { DialogueManager.StopConversation(); } catch { }
                try { Panels.Instance?.ConversationPanel?.Hide(); } catch { }
                yield return null;

                ApplyAuditProfile(profile);

                bool invoked = false;
                try
                {
                    if (dbName == "Turn_Zille_WarBriefing")
                        WarOperationZilleManager.TriggerZilleWarBriefingConversation();
                    else
                        WarOperationZilleManager.TriggerConversation(dbName, titlePath);
                    invoked = true;
                }
                catch (Exception ex)
                {
                    rep.LogFail($"Portrait Launch [{label}]", ex.Message);
                }

                if (!invoked) yield break;

                yield return null;
                yield return null;
                yield return new WaitForSeconds(0.30f);

                var convPanel = Panels.Instance?.ConversationPanel ?? UnityEngine.Object.FindObjectOfType<ConversationPanel>();
                if (convPanel == null || !DialogueManager.isConversationActive)
                {
                    rep.LogFail($"Portrait Panel Active [{label}]", $"isConvActive={DialogueManager.isConversationActive}, panelNull={convPanel == null}");
                    try { DialogueManager.StopConversation(); } catch { }
                    yield break;
                }

                var activeNames = new List<string>();
                try
                {
                    var comps = convPanel.GetComponentsInChildren<TemplateConversant>(false);
                    if (comps != null)
                    {
                        for (int i = 0; i < comps.Length; i++)
                        {
                            var tc = comps[i];
                            if (tc == null || !tc.gameObject.activeInHierarchy) continue;
                            var cd = tc.GetCharacterData();
                            string cname = cd != null
                                ? (!string.IsNullOrEmpty(cd.CharacterName) ? cd.CharacterName : cd.NameInDatabase)
                                : tc.name;
                            if (!string.IsNullOrEmpty(cname)) activeNames.Add(cname);
                        }
                    }
                }
                catch (Exception ex)
                {
                    rep.LogWarn($"Portrait Read [{label}]", ex.Message);
                }

                string joined = string.Join(", ", activeNames);
                bool ok = activeNames.Count > 0 && activeNames.Count < 12;
                var errors = new List<string>();
                if (!ok) errors.Add($"unexpected count={activeNames.Count}");

                if (mustHave != null)
                {
                    foreach (var req in mustHave)
                    {
                        bool found = activeNames.Exists(n => n.IndexOf(req, StringComparison.OrdinalIgnoreCase) >= 0);
                        if (!found) { ok = false; errors.Add($"missing '{req}'"); }
                    }
                }
                if (mustNotHave != null)
                {
                    foreach (var ban in mustNotHave)
                    {
                        bool leaked = activeNames.Exists(n => n.IndexOf(ban, StringComparison.OrdinalIgnoreCase) >= 0);
                        if (leaked) { ok = false; errors.Add($"GHOST PORTRAIT '{ban}'"); }
                    }
                }

                if (label.Contains("ExileEpilogue"))
                {
                    yield return SaveUiShotCoroutine("pt_events_exile_epilogue.png");
                }

                try { DialogueManager.StopConversation(); } catch { }
                try { convPanel.Hide(); } catch { }
                yield return null;

                if (ok)
                    rep.LogPass($"Live Portraits [{label}]", $"count={activeNames.Count} [{joined}]");
                else
                    rep.LogFail($"Live Portraits [{label}]", $"issues=[{string.Join("; ", errors)}] actual=[{joined}]");
            }

            // 2A. Live ConversationPanel Portrait Checks
            yield return CheckPortraits("DerdiaInvestigation_Baseline", "P1_Baseline_Op1", "Turn_Zille_DerdiaInvestigation", "Zille/DerdiaInvestigation",
                new[] { "Laurento", "Titus" }, new[] { "Smolak", "Estela", "Vina", "Manus", "Sal", "Azmal" });

            yield return CheckPortraits("DerdiaStateVisit_Baseline", "P1_Baseline_Op1", "Turn_Zille_DerdiaStateVisit", "Zille/DerdiaStateVisit",
                new[] { "Azmal" }, new[] { "Smolak", "Estela", "Lucita", "Sal" });

            yield return CheckPortraits("WarPlanning_Baseline", "P1_Baseline_Op1", "Turn_Zille_WarPlanning", "Zille/WarPlanning",
                new[] { "Hugo", "Laurento", "Lucita" }, new[] { "Smolak", "Vina", "Manus", "Sal", "Azmal" });

            yield return CheckPortraits("WarPlanning_PurgedCouncil", "P2_Purged_DeadCouncil", "Turn_Zille_WarPlanning", "Zille/WarPlanning",
                new[] { "Laurento", "Elena", "Carlos" }, new[] { "Hugo", "Titus", "Lucita", "Smolak", "Vina", "Estela" });

            yield return CheckPortraits("WarBriefing_Baseline", "P1_Baseline_Op1", "Turn_Zille_WarBriefing", "Zille/WarCouncil_Briefing",
                new[] { "Hugo", "Lucita", "Titus" }, new[] { "Smolak", "Estela", "Vina", "Azmal" });

            yield return CheckPortraits("ZilleLiberation_BaselineVictory", "P3_Op1_DecisiveVictory_VinaDead", "Turn_Zille_ZilleLiberation", "Zille/ZilleLiberation",
                new[] { "Estela" }, new[] { "Vina", "Smolak", "Azmal" });

            yield return CheckPortraits("ZilleLiberation_Purged", "P2_Purged_DeadCouncil", "Turn_Zille_ZilleLiberation", "Zille/ZilleLiberation",
                new[] { "Laurento", "Manus" }, new[] { "Vina", "Estela", "Hugo", "Titus", "Lucita", "Smolak" });

            yield return CheckPortraits("SmolakFinalParley_Op2", "P4_Op2_TotalRepayment_Stalemate", "Turn_Zille_WarSmolakFinalParley", "Zille/WarSmolakFinalParley",
                new[] { "Smolak" }, new[] { "Estela", "Vina", "Hugo" });

            yield return CheckPortraits("ExileEpilogue_Collapse", "P6_TotalFiasco_Collapse_Exile", "Turn_Zille_ExileEpilogue", "Zille/ExileEpilogue",
                new[] { "Vina", "Manus" }, new[] { "Smolak", "Hugo", "Titus", "Lucita" });

            // 2B. Smolak Suspicion Score -> Deployment Preset & Zille_Sit_Smolak*
            try
            {
                ApplyAuditProfile("P1_Baseline_Op1");

                ZilleCampaignState.SmolakPressureScore = 1;
                ZilleCampaignState.SyncToLua();
                ZilleDeployment.RefreshFromCampaign();
                ZilleReportsAndSituations.SyncVariables();
                string pMin = ZilleCampaignState.GetSmolakSuspicionPreset(false);
                bool sMin = DialogueHelper.GetBoolVariable("Zille_Sit_SmolakMinimal");

                ZilleCampaignState.SmolakPressureScore = 4;
                ZilleCampaignState.SyncToLua();
                ZilleDeployment.RefreshFromCampaign();
                ZilleReportsAndSituations.SyncVariables();
                string pMed = ZilleCampaignState.GetSmolakSuspicionPreset(false);
                bool sMed = DialogueHelper.GetBoolVariable("Zille_Sit_SmolakSuspicious");

                ZilleCampaignState.SmolakPressureScore = 8;
                ZilleCampaignState.SyncToLua();
                ZilleDeployment.RefreshFromCampaign();
                ZilleReportsAndSituations.SyncVariables();
                string pHigh = ZilleCampaignState.GetSmolakSuspicionPreset(false);
                bool sHigh = DialogueHelper.GetBoolVariable("Zille_Sit_SmolakPrepared");

                if (pMin == "minimal" && sMin && pMed == "suspicious" && sMed && pHigh == "prepared" && sHigh)
                    rep.LogPass("Smolak Suspicion System", $"1->{pMin}(Sit={sMin}), 4->{pMed}(Sit={sMed}), 8->{pHigh}(Sit={sHigh})");
                else
                    rep.LogFail("Smolak Suspicion System", $"1->{pMin}(Sit={sMin}), 4->{pMed}(Sit={sMed}), 8->{pHigh}(Sit={sHigh})");
            }
            catch (Exception ex)
            {
                rep.LogFail("Smolak Suspicion System", ex.Message);
            }

            // 2C. Variant Ark vs Sword, Op 1 Losses, Post-Op1 Council & Op 2 Total Repayment Transition
            try
            {
                ApplyAuditProfile("P7_EarlyWar_Turn3_Turn4_ArtSword");
                ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanArk);
                ZilleCampaignState.SyncToLua();
                string v1 = DialogueHelper.GetStringVariable("Zille_Operation_Variant");

                ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanSword);
                ZilleCampaignState.SyncToLua();
                string v2 = DialogueHelper.GetStringVariable("Zille_Operation_Variant");

                ZilleCampaignState.RecordZilleLosses(1, 7, 19);
                int p1Dead = DialogueHelper.GetIntVariable("Zille_Phase1_PlayerDead");
                int e1Dead = DialogueHelper.GetIntVariable("Zille_Phase1_EnemyDead");

                // Save/Reload Lua board state check (does not throw outside 3D map)
                ZilleWarTable.SavePhaseBoardState();
                bool reloadRes = ZilleWarTable.ReloadSavedBoardStateFromLua();

                // Op 1 Victory -> optional negotiations unlocked
                WarOperationZilleManager.ResolvePostOperation1Flow(ZilleWarOutcome.DecisiveVictory, "Test Op1 Victory");
                bool op1Neg = ZilleCampaignState.Op1CouncilAvailable;

                // Op 1 Stalemate -> Transition to Operation II: Total Repayment
                ZilleCampaignState.TransitionToTotalRepayment();
                ZilleCampaignState.SyncToLua();
                bool op2Active = ZilleCampaignState.CurrentOperationNumber == 2
                              && ZilleCampaignState.TotalRepaymentUnlocked
                              && DialogueHelper.GetBoolVariable("Zille_TotalRepayment_Unlocked");

                if (v1 == "PlanArk" && v2 == "PlanSword" && p1Dead == 7 && e1Dead == 19 && op1Neg && op2Active)
                    rep.LogPass("Op1 Variants (Ark/Sword) -> Op2 Total Repayment", $"variants=({v1},{v2}), phase1Losses=({p1Dead}/{e1Dead}), boardReload={reloadRes}, op1Council={op1Neg}, op2Unlocked={op2Active}");
                else
                    rep.LogFail("Op1 Variants (Ark/Sword) -> Op2 Total Repayment", $"variants=({v1},{v2}), phase1Losses=({p1Dead}/{e1Dead}), op1Council={op1Neg}, op2Unlocked={op2Active}");
            }
            catch (Exception ex)
            {
                rep.LogFail("Op1 -> Op2 Progression", ex.ToString());
            }

            // 2D. Live Response Selection: Peace Treaty Flag & Lose/Exile Collapse Flow
            DialogueEntry signEntry = null;
            try
            {
                DialogueManager.StopConversation();
                ApplyAuditProfile("P3_Op1_DecisiveVictory_VinaDead");
                DialogueHelper.SetVariable("Zille_PeaceTreaty_Signed", false);
                DialogueHelper.SetVariable("Zille_Rep_TreatyDone", false);
                DialogueHelper.SetVariable("Zille_Negotiations_Done", false);

                var db = DialogueManager.masterDatabase;
                var treatyConv = FindConversationInDb(db, "Turn_Zille_WarPeaceTreaty", "Zille/WarPeaceTreaty");
                if (treatyConv?.dialogueEntries != null)
                {
                    for (int i = 0; i < treatyConv.dialogueEntries.Count; i++)
                    {
                        var e = treatyConv.dialogueEntries[i];
                        if (e != null && !string.IsNullOrEmpty(e.Title) && e.Title.StartsWith("Sign_", StringComparison.OrdinalIgnoreCase))
                        {
                            signEntry = e;
                            break;
                        }
                    }
                }
                if (signEntry != null)
                    WarOperationZilleManager.TriggerConversation("Turn_Zille_WarPeaceTreaty", "Zille/WarPeaceTreaty");
                else
                    rep.LogFail("Peace Treaty Live Signing", "No Sign_* entry found in Turn_Zille_WarPeaceTreaty.");
            }
            catch (Exception ex)
            {
                rep.LogFail("Peace Treaty Live Signing Setup", ex.ToString());
                signEntry = null;
            }

            if (signEntry != null)
            {
                yield return new WaitForSeconds(0.15f);
                try
                {
                    var resp = new Response(FormattedText.Parse(signEntry.MenuText ?? signEntry.DialogueText ?? "Sign"), signEntry);
                    DialogueManager.conversationView?.OnSelectedResponse(DialogueManager.conversationView, new SelectedResponseEventArgs(resp));
                }
                catch (Exception ex)
                {
                    rep.LogFail("Peace Treaty OnSelectedResponse", ex.ToString());
                }
                yield return new WaitForSeconds(0.15f);
                try
                {
                    bool signed = DialogueHelper.GetBoolVariable("Zille_PeaceTreaty_Signed");
                    bool repDone = DialogueHelper.GetBoolVariable("Zille_Rep_TreatyDone");
                    bool negDone = DialogueHelper.GetBoolVariable("Zille_Negotiations_Done");
                    DialogueManager.StopConversation();
                    try { Panels.Instance?.ConversationPanel?.Hide(); } catch { }

                    if (signed && repDone && negDone)
                        rep.LogPass("Peace Treaty Live Signing", $"Sign entry '{signEntry.Title}' set Zille_PeaceTreaty_Signed=true, Rep_TreatyDone=true, Negotiations_Done=true.");
                    else
                        rep.LogFail("Peace Treaty Live Signing", $"signed={signed}, repDone={repDone}, negDone={negDone}");
                }
                catch (Exception ex)
                {
                    rep.LogFail("Peace Treaty Live Signing Check", ex.ToString());
                    try { DialogueManager.StopConversation(); } catch { }
                }
            }

            yield return null;

            // 2E. Lose Condition: Refuse_Parley_Collapse -> TriggerSmolakParley -> ExileEpilogue
            DialogueEntry refuseEntry = null;
            bool refuseCondEval = false;
            try
            {
                ApplyAuditProfile("P5_Op2_TacticalDefeat_CollapseWarning");
                var db = DialogueManager.masterDatabase;
                var parleyConv = FindConversationInDb(db, "Turn_Zille_WarSmolakFinalParley", "Zille/WarSmolakFinalParley");
                if (parleyConv?.dialogueEntries != null)
                {
                    for (int i = 0; i < parleyConv.dialogueEntries.Count; i++)
                    {
                        var e = parleyConv.dialogueEntries[i];
                        if (e != null && e.Title == "Refuse_Parley_Collapse")
                        {
                            refuseEntry = e;
                            break;
                        }
                    }
                }
                if (refuseEntry != null)
                {
                    refuseCondEval = string.IsNullOrWhiteSpace(refuseEntry.conditionsString) || Lua.IsTrue(refuseEntry.conditionsString);
                    WarOperationZilleManager.TriggerConversation("Turn_Zille_WarSmolakFinalParley", "Zille/WarSmolakFinalParley");
                }
                else
                {
                    rep.LogFail("Refuse Parley Collapse -> Exile Epilogue Flow", "Node Refuse_Parley_Collapse missing from Turn_Zille_WarSmolakFinalParley.");
                }
            }
            catch (Exception ex)
            {
                rep.LogFail("Refuse Parley Collapse Setup", ex.ToString());
                refuseEntry = null;
            }

            if (refuseEntry != null)
            {
                yield return new WaitForSeconds(0.15f);
                try
                {
                    var resp = new Response(FormattedText.Parse(refuseEntry.MenuText ?? "Refuse Parley"), refuseEntry);
                    DialogueManager.conversationView?.OnSelectedResponse(DialogueManager.conversationView, new SelectedResponseEventArgs(resp));
                }
                catch (Exception ex)
                {
                    rep.LogFail("Refuse Parley OnSelectedResponse", ex.ToString());
                }
                yield return new WaitForSeconds(0.15f);
                bool parleyRef = false, azaroCollapse = false, endCoup = false, forcedExile = false, outcomeFiasco = false;
                try
                {
                    DialogueManager.StopConversation();
                    try { Panels.Instance?.ConversationPanel?.Hide(); } catch { }
                    parleyRef = DialogueHelper.GetBoolVariable("Zille_Parley_Refused");
                    azaroCollapse = DialogueHelper.GetBoolVariable("Zille_Azaro_Coup_Collapse");
                    endCoup = DialogueHelper.GetBoolVariable("RiziaDLC.Ending_Coup_Azaro");
                    forcedExile = DialogueHelper.GetBoolVariable("RiziaDLC.Epilogue_Exile_Forced");
                    outcomeFiasco = ZilleCampaignState.Outcome == ZilleWarOutcome.TotalFiasco && ZilleCampaignState.IsBrenasLost;
                    WarOperationZilleManager.TriggerSmolakParley();
                }
                catch (Exception ex)
                {
                    rep.LogFail("Refuse Parley Collapse Routing", ex.ToString());
                }
                yield return new WaitForSeconds(0.25f);
                try
                {
                    string activeConv = DialogueManager.lastConversationStarted ?? "";
                    bool launchedExile = DialogueManager.isConversationActive && (activeConv.IndexOf("Exile", StringComparison.OrdinalIgnoreCase) >= 0);
                    DialogueManager.StopConversation();
                    try { Panels.Instance?.ConversationPanel?.Hide(); } catch { }

                    if (refuseCondEval && parleyRef && azaroCollapse && forcedExile && outcomeFiasco && launchedExile)
                        rep.LogPass("Refuse Parley Collapse -> Exile Epilogue Flow", $"cond={refuseCondEval}, parleyRefused={parleyRef}, azaroCollapse={azaroCollapse}, exile={forcedExile}, fiasco={outcomeFiasco}, routedTo='{activeConv}' (coupNote={endCoup})");
                    else
                        rep.LogFail("Refuse Parley Collapse -> Exile Epilogue Flow", $"cond={refuseCondEval}, parleyRef={parleyRef}, azaro={azaroCollapse}, coup={endCoup}, exile={forcedExile}, fiasco={outcomeFiasco}, activeConv='{activeConv}'");
                }
                catch (Exception ex)
                {
                    rep.LogFail("Refuse Parley Collapse Verification", ex.ToString());
                    try { DialogueManager.StopConversation(); } catch { }
                }
            }

            // 2F. Decisions UI & Reports/Situations Registry
            try
            {
                ApplyAuditProfile("P7_EarlyWar_Turn3_Turn4_ArtSword");
                ZilleDecisions.EnsureRegistered();
                int decCount = ZilleDecisions.AllDecisions.Count;
                int openOk = 0;
                foreach (var d in ZilleDecisions.AllDecisions)
                {
                    ZilleDecisions.OpenDecision(d);
                    if (d.Options != null && d.Options.Count >= 2) openOk++;
                    ZilleDecisions.CloseModal();
                }

                var sits = EntityDataManager.situationsData ?? EntityDataManager.SituationsData;
                var reps = EntityDataManager.reportsData ?? EntityDataManager.ReportsData;
                int modSits = 0, modReps = 0;
                if (sits != null)
                {
                    for (int i = 0; i < sits.Count; i++)
                        if (sits[i]?.NameInDatabase != null && (sits[i].NameInDatabase.StartsWith("Sit_Zille") || sits[i].NameInDatabase.StartsWith("Sit_Smolak") || sits[i].NameInDatabase.StartsWith("Sit_Derdia") || sits[i].NameInDatabase.StartsWith("Sit_Lespia") || sits[i].NameInDatabase.StartsWith("Sit_Rumburg") || sits[i].NameInDatabase.StartsWith("Sit_Bff")))
                            modSits++;
                }
                if (reps != null)
                {
                    for (int i = 0; i < reps.Count; i++)
                    {
                        string rn = reps[i]?.NameInDatabase;
                        if (rn != null && (rn.StartsWith("Rep_Zille") || rn.StartsWith("Rep_Derdia") || rn.StartsWith("Rep_Brenas") || rn.StartsWith("Rep_Kyrute") || rn.StartsWith("Rep_Wraclawitz") || rn.StartsWith("Rep_Gulf") || rn.StartsWith("Rep_MaveNortus")))
                            modReps++;
                    }
                }

                if (decCount >= 5 && openOk == decCount && modSits >= 30 && modReps >= 40)
                    rep.LogPass("Decisions, Situations & Reports Registry", $"Decisions={openOk}/{decCount}, Situations(mod)={modSits}, Reports(mod)={modReps}");
                else
                    rep.LogWarn("Decisions, Situations & Reports Registry", $"Decisions={openOk}/{decCount}, Situations(mod)={modSits}, Reports(mod)={modReps}");
            }
            catch (Exception ex)
            {
                rep.LogFail("Decisions/Reports/Situations Audit", ex.ToString());
                try { ZilleDecisions.CloseModal(); } catch { }
            }
        }

        private static IEnumerator RunStage3RealSavesCoroutine(EventsAuditReport rep)
        {
            var pm = PersistenceManager.Instance ?? UnityEngine.Object.FindObjectOfType<PersistenceManager>();
            if (pm == null || pm.AllSaveFiles == null)
            {
                rep.LogFail("Stage 3 Real Saves", "PersistenceManager or AllSaveFiles is null.");
                yield break;
            }

            int[] targetTurns = new[] { 3, 4, 6, 8, 9, 11 };
            var chosenSaves = new List<SaveFile>();

            foreach (int t in targetTurns)
            {
                SaveFile pick = null;
                for (int i = 0; i < pm.AllSaveFiles.Count; i++)
                {
                    var sf = pm.AllSaveFiles[i];
                    if (sf?.saveData == null) continue;
                    if (sf.saveData.currentStoryPack != "StoryPack_Rizia") continue;
                    if (sf.saveData.turnNo != t) continue;
                    if (!string.IsNullOrEmpty(sf.fileName) && sf.fileName.StartsWith("Autosave_", StringComparison.OrdinalIgnoreCase)) continue;
                    // Prefer Divine Nature or Main (well-formed TurnSaves)
                    if (pick == null
                        || string.Equals(sf.saveData.campaignName, "Divine Nature", StringComparison.OrdinalIgnoreCase)
                        || (pick.saveData.campaignName != "Divine Nature" && string.Equals(sf.saveData.campaignName, "Main", StringComparison.OrdinalIgnoreCase)))
                    {
                        pick = sf;
                    }
                }
                if (pick != null) chosenSaves.Add(pick);
                else rep.LogWarn($"Turn {t} Save Discovery", "No StoryPack_Rizia save found for this turn.");
            }

            foreach (var sf in chosenSaves)
            {
                int expectedTurn = sf.saveData.turnNo;
                string saveName = sf.fileName;
                string campaign = sf.saveData.campaignName;
                rep.LogInfo($"Loading read-only save '{saveName}' (Campaign='{campaign}', Turn={expectedTurn})...");

                bool loadInvoked = false;
                try
                {
                    pm.LoadSaveFile(sf);
                    loadInvoked = true;
                }
                catch (Exception ex)
                {
                    rep.LogFail($"Load Save [T{expectedTurn}]", ex.Message);
                }
                if (!loadInvoked) continue;

                yield return new WaitForSeconds(1.0f);
                float wait = 1.0f;
                while (wait < 25f)
                {
                    var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                    string activeFn = pm.activeSaveFile?.fileName ?? "";
                    if (string.Equals(sc.name, "Rizia", StringComparison.OrdinalIgnoreCase) && (string.Equals(activeFn, saveName, StringComparison.OrdinalIgnoreCase) || wait > 12f))
                        break;
                    yield return new WaitForSeconds(0.5f);
                    wait += 0.5f;
                }
                yield return new WaitForSeconds(2.5f);

                try
                {
                    ZilleDialogueSystem.EnsureAllConversationsRegistered();
                    ZilleDialogueSystem.InjectAllVanillaConversationPatches();
                    WarOperationZilleManager.RegisterNativeZilleEntities();
                    ZilleDecisions.EnsureRegistered();
                    ZilleReportsAndSituations.EnsureRegisteredAndSynced();
                    ZilleCampaignState.SyncFromLua(resetMissing: true);
                }
                catch (Exception ex)
                {
                    rep.LogFail($"Post-Load Sync [T{expectedTurn}]", ex.ToString());
                    continue;
                }

                int actualTurn = ZilleCampaignState.GetCurrentTurn();
                // Non-persistent Lua roundtrip sanity test
                ZilleCampaignState.SyncToLua();
                ZilleCampaignState.SyncFromLua();

                // Inspect active Token instances (Porte Drazon, Zille, Valenqiris, etc.) via TokenInteractionPanel
                var tokens = UnityEngine.Object.FindObjectsOfType<Token>();
                var tip = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();
                var modButtonsFound = new List<string>();
                int tokensChecked = 0;

                if (tokens != null && tip != null)
                {
                    for (int ti = 0; ti < tokens.Length; ti++)
                    {
                        var tok = tokens[ti];
                        if (tok == null || !tok.gameObject.activeInHierarchy) continue;
                        string tname = "";
                        try { tname = tok.GetTokenDataEntityName() ?? tok.name; } catch { tname = tok.name; }
                        if (tname.IndexOf("PorteDrazon", StringComparison.OrdinalIgnoreCase) < 0
                            && tname.IndexOf("Zille", StringComparison.OrdinalIgnoreCase) < 0
                            && tname.IndexOf("MaveNortus", StringComparison.OrdinalIgnoreCase) < 0
                            && tname.IndexOf("Sallabes", StringComparison.OrdinalIgnoreCase) < 0
                            && tname.IndexOf("Valenqiris", StringComparison.OrdinalIgnoreCase) < 0)
                            continue;

                        tokensChecked++;
                        try
                        {
                            tip.gameObject.SetActive(true);
                            tip.Setup(tok);
                        }
                        catch (Exception tex)
                        {
                            rep.LogWarn($"Token Setup [T{expectedTurn} {tname}]", tex.Message);
                        }
                        yield return null;
                        try
                        {
                            if (tip.instantiatedInteractionButtons != null)
                            {
                                for (int bi = 0; bi < tip.instantiatedInteractionButtons.Count; bi++)
                                {
                                    var btn = tip.instantiatedInteractionButtons[bi];
                                    string btitle = btn?.titleText?.text ?? "";
                                    if (btitle.Contains("MOD") || btitle.Contains("DECISION"))
                                        modButtonsFound.Add($"{tname}=>'{btitle}'");
                                }
                            }
                        }
                        catch { }
                    }
                    try { tip.Hide(); } catch { }
                }

                if (actualTurn != expectedTurn)
                {
                    rep.LogFail($"Save [T{expectedTurn}] Turn Mismatch", $"expectedTurn={expectedTurn}, actualTurn={actualTurn}, activeFile='{pm.activeSaveFile?.fileName}'");
                }
                else if (expectedTurn == 3 && modButtonsFound.Exists(b => b.Contains("A Royal Proclamation of War") || b.Contains("Wartime Home Front") || b.Contains("Homecoming in Zille City") || b.Contains("Exile in Kyrute")))
                {
                    rep.LogFail($"Save [T{expectedTurn}] Premature Button Leak", string.Join(" | ", modButtonsFound));
                }
                else
                {
                    rep.LogPass($"Real Save [Turn {expectedTurn}] ({saveName})",
                        $"loadedTurn={actualTurn}, tokensChecked={tokensChecked}, modButtons=[{(modButtonsFound.Count > 0 ? string.Join(" | ", modButtonsFound) : "none active")}]");
                }
            }
        }
    }
}
