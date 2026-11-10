using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public enum ActiveWarTheatre
    {
        None,
        Civilian,
        Pales,
        Zille
    }

    public static class WarOperationZilleManager
    {
        public const string OPERATION_PHASE_1_ID = "OP_Zille_RighteousSword";
        public const string OPERATION_PHASE_2_ID = "OP_Zille_TotalRepayment";

        public static ActiveWarTheatre CurrentTheatre { get; set; } = ActiveWarTheatre.None;

        public static GameObject SpawnedZilleWarToken => _spawnedZilleWarToken;
        public static Vector3 TokenBasePos { get; set; } = new Vector3(0.4673f, 0.08f, 0.8262f);
        public static bool IsTokenHovered { get; set; } = false;
        public static bool PendingZilleTokenSpawnAfterBriefing { get; set; } = false;

        private static GameObject _spawnedZilleWarToken = null;
        private static Texture _originalPalesTexture = null;
        private static readonly List<Vector3> _originalTilePositions = new List<Vector3>();
        private static readonly List<Vector3> _originalTileScales = new List<Vector3>();
        private static bool _tilesConfiguredForZille = false;
        private static float _theatreEnteredAt = -1000f;

        private static bool _transitionScheduled = false;
        private static float _transitionTimer = 0f;

        private static bool _customOperationConfigured = false;
        private static WarOperation _zilleWarOp = null;

        public static void InitializeStaffPlan(ZilleStaffPlan plan)
        {
            ZilleCampaignState.PlanType = ZillePlanType.Staff;
            ZilleCampaignState.StaffPlan = plan;
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1;
            ZilleCampaignState.CurrentPhaseNumber = 1;
            ZilleCampaignState.StaffVictoryPoints = 0;

            MelonLogger.Msg("============================================================");
            MelonLogger.Msg($"[WAR ENGINE] Initializing Staff-Led Zille Campaign: Plan {plan}");
            MelonLogger.Msg("============================================================");

            ZilleCampaignState.ApplyGeopoliticalShifts();
            if (ZilleCampaignState.IsTwoFrontWarThreat()) CalculateUnitReserves();
            ZilleCampaignState.SyncToLua();
        }

        public static void InitializeRomulusPlan(ZilleRomulusPlan plan)
        {
            ZilleCampaignState.PlanType = ZillePlanType.Romulus;
            ZilleCampaignState.RomulusPlan = plan;
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1;
            ZilleCampaignState.CurrentPhaseNumber = 1;

            MelonLogger.Msg("============================================================");
            MelonLogger.Msg($"[WAR ENGINE] Initializing Player-Controlled Romulus Campaign: Plan {plan}");
            MelonLogger.Msg("============================================================");

            ZilleCampaignState.ApplyGeopoliticalShifts();
            if (ZilleCampaignState.IsTwoFrontWarThreat()) CalculateUnitReserves();
            ZilleCampaignState.SyncToLua();
        }

        public static void TriggerOutcome(ZilleWarOutcome outcome, string summary = "")
        {
            ZilleCampaignState.Outcome = outcome;
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Completed_Outcome;
            MelonLogger.Msg($"[WAR ENGINE] Zille Campaign Outcome set to: {outcome} ({summary})");

            try
            {
                DialogueHelper.SetVariable("Zille_War_Outcome", (int)outcome);

                switch (outcome)
                {
                    case ZilleWarOutcome.TotalFiasco:
                        ZilleCampaignState.IsBrenasLost = true;
                        DialogueHelper.SetVariable("ZilleReturn_Success", false);
                        DialogueHelper.SetVariable("ZilleReferendum_Lost", true);
                        DialogueHelper.SetVariable("Brenas_Lost_To_Wehlen", true);
                        DialogueHelper.SetVariable("Country_MilitaryCoupHappens", true);
                        break;
                    case ZilleWarOutcome.TacticalDefeat:
                        DialogueHelper.SetVariable("ZilleReturn_Success", false);
                        DialogueHelper.SetVariable("ZilleReferendum_Lost", true);
                        break;
                    case ZilleWarOutcome.BloodyStalemate:
                        DialogueHelper.SetVariable("ZilleReturn_Success", false);
                        DialogueHelper.SetVariable("Zille_Stalemate", true);
                        break;
                    case ZilleWarOutcome.DecisiveVictory:
                        DialogueHelper.SetVariable("ZilleReturn_Success", true);
                        DialogueHelper.SetVariable("_Zille_OwnState", 1);
                        DialogueHelper.SetVariable("Zille_PromisedToHouseToras", true);
                        DialogueHelper.SetVariable("Diplomacy_Wehlen_Hostile", true);
                        break;
                    case ZilleWarOutcome.OverwhelmingTriumph:
                        DialogueHelper.SetVariable("ZilleReturn_Success", true);
                        DialogueHelper.SetVariable("_Zille_OwnState", 1);
                        DialogueHelper.SetVariable("Zille_PromisedToHouseToras", true);
                        DialogueHelper.SetVariable("Diplomacy_Wehlen_Hostile", true);
                        DialogueHelper.SetVariable("Grodzizg_FreeCity", true);
                        break;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"Error setting outcome flags: {ex.Message}");
            }

            ZilleCampaignState.SyncToLua();
        }

        public static ZilleWarOutcome ResolveStaffPhase(ZilleStaffPlan plan, int phase)
        {
            int score = 0;
            try
            {
                int pp = DialogueHelper.GetIntVariable("Country_Military_PowerProjection");
                int equipment = DialogueHelper.GetIntVariable("Resources_Military_Equipment");
                int energy = DialogueHelper.GetIntVariable("Resources_Energy");

                score += pp;
                score += Math.Min(3, equipment / 2);

                switch (plan)
                {
                    case ZilleStaffPlan.Hawk:
                        if (DialogueHelper.GetBoolVariable("Policy_RD_Order_BomberPlaneFactory_Completed")) score += 2;
                        if (energy >= 3) score += 1;
                        break;
                    case ZilleStaffPlan.Sword:
                        if (DialogueHelper.GetIntVariable("Army_Unit_Tank_Total") >= 2) score += 2;
                        if (!DialogueHelper.GetBoolVariable("Country_HouseAzaro_Enemy")) score += 1;
                        break;
                    case ZilleStaffPlan.Ark:
                        int fleet = DialogueHelper.GetIntVariable("Army_Unit_Battleship_Total") + DialogueHelper.GetIntVariable("Army_Unit_Submarine_Total");
                        if (fleet >= 2) score += 2;
                        if (ZilleCampaignState.IsNavalBlockadeActive) score += 1;
                        break;
                    case ZilleStaffPlan.Spear:
                        if (DialogueHelper.GetBoolVariable("Policy_Order_GoldenGuard_Expanded")) score += 2;
                        if (DialogueHelper.GetBoolVariable("Policy_RD_Order_BuildMaveNortusIntelHub_Completed")) score += 1;
                        break;
                }

                string logistics = DialogueHelper.GetStringVariable("Zille_War_Logistics");
                if (logistics == "Sazon" || logistics == "Azaro") score += 1;

                if (ZilleCampaignState.IsLespiaPactAccepted) score += 2;
                if (ZilleCampaignState.IsDerdiaHybridSupportActive) score += 1;

                if (ZilleCampaignState.IsTwoFrontWarThreat()) score -= 3;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"ResolveStaffPhase calculation error: {ex.Message}");
            }

            ZilleCampaignState.StaffVictoryPoints += score;
            MelonLogger.Msg($"[WAR ENGINE] Staff Phase {phase} resolved for Plan {plan}. Phase score: {score}, Total Staff VP: {ZilleCampaignState.StaffVictoryPoints}");

            ZilleWarOutcome outcome = ZilleWarOutcome.BloodyStalemate;
            int totalVp = ZilleCampaignState.StaffVictoryPoints;
            if (totalVp <= 3) outcome = ZilleWarOutcome.TotalFiasco;
            else if (totalVp <= 6) outcome = ZilleWarOutcome.TacticalDefeat;
            else if (totalVp <= 10) outcome = ZilleWarOutcome.BloodyStalemate;
            else if (totalVp <= 14) outcome = ZilleWarOutcome.DecisiveVictory;
            else outcome = ZilleWarOutcome.OverwhelmingTriumph;

            return outcome;
        }

        public static void InitializeOperation(ZilleOperationPath path)
        {
            ZilleCampaignState.ChosenPath = path;
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1_RighteousSword;

            MelonLogger.Msg("============================================================");
            MelonLogger.Msg($"[WAR ENGINE] Initializing Zille Campaign: Phase 1 (Righteous Sword)");
            MelonLogger.Msg($"[WAR ENGINE] Doctrine Selected: {path}");
            MelonLogger.Msg("============================================================");

            ZilleCampaignState.ApplyGeopoliticalShifts();

            if (ZilleCampaignState.IsTwoFrontWarThreat())
            {
                MelonLogger.Warning("[WAR ENGINE] WARNING: Two-Front War Active! Pales theatre has committed royal assets.");
                CalculateUnitReserves();
            }

            ZilleCampaignState.SyncToLua();
        }

        public static void AdvanceToPhase2()
        {
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2_TotalRepayment;
            MelonLogger.Msg("[WAR ENGINE] Advancing to Phase 2: Total Repayment. Encirclement of Wehlen forces.");
            ZilleCampaignState.SyncToLua();
        }

        public static void TriggerVictory()
        {
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Completed_Victory;
            MelonLogger.Msg("[WAR ENGINE] VICTORY IN ZILLE! Crown forces secured the territory.");

            try
            {
                DialogueHelper.SetVariable("ZilleReturn_Success", true);
                DialogueHelper.SetVariable("_Zille_OwnState", 1);
                DialogueHelper.SetVariable("Zille_PromisedToHouseToras", true);
                DialogueHelper.SetVariable("Diplomacy_Wehlen_Hostile", true);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"Error setting victory flags: {ex.Message}");
            }

            ZilleCampaignState.SyncToLua();
        }

        public static void TriggerCatastrophicDefeat(bool motherDied, bool brenasLost)
        {
            ZilleCampaignState.IsMotherCaptured = motherDied;
            ZilleCampaignState.IsBrenasLost = brenasLost;
            ZilleCampaignState.CurrentPhase = brenasLost ? ZilleOperationPhase.Defeat_BrenasLost : ZilleOperationPhase.Defeat_MotherCaptured;

            MelonLogger.Error("============================================================");
            MelonLogger.Error($"[WAR ENGINE] CATASTROPHIC DEFEAT IN ZILLE!");
            if (motherDied) MelonLogger.Error("[WAR ENGINE] Queen Mother Estela captured and killed by Smolak's troops!");
            if (brenasLost) MelonLogger.Error("[WAR ENGINE] Province of Brenas ceded to Wehlen!");
            MelonLogger.Error("============================================================");

            try
            {
                DialogueHelper.SetVariable("ZilleReturn_Success", false);
                DialogueHelper.SetVariable("ZilleReferendum_Lost", true);
                if (brenasLost) DialogueHelper.SetVariable("Brenas_Lost_To_Wehlen", true);
                if (motherDied) DialogueHelper.SetVariable("QueenMother_Estela_Dead", true);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"Error setting defeat flags: {ex.Message}");
            }

            ZilleCampaignState.SyncToLua();
        }

        public static void CalculateUnitReserves()
        {
            int totalBattalions = 8;
            try
            {
                totalBattalions += DialogueHelper.GetIntVariable("Military_Expanded_Infantry") * 2;
                totalBattalions += DialogueHelper.GetIntVariable("Military_Expanded_Tanks") * 2;
            }
            catch { }

            int palesTokens = 0;
            if (ZilleCampaignState.IsTwoFrontWarThreat())
            {
                palesTokens = 5;
            }

            ZilleCampaignState.UnitsCommittedToPales = palesTokens;
            ZilleCampaignState.UnitsCommittedToZille = Math.Max(1, totalBattalions - palesTokens);

            MelonLogger.Msg($"[WAR ENGINE] Unit Allocation: Total={totalBattalions}, Pales={palesTokens}, Available for Zille={ZilleCampaignState.UnitsCommittedToZille}");
        }

        // ================= REGISTER NATIVE SUZERAIN ENTITIES =================

        private static Il2CppSystem.Collections.Generic.List<T> GetEntityBackingList<T>(string fieldName)
        {
            try
            {
                string capName = char.ToUpper(fieldName[0]) + fieldName.Substring(1);
                var propDirect = typeof(EntityDataManager).GetProperty(capName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                if (propDirect != null)
                {
                    var val = propDirect.GetValue(null) as Il2CppSystem.Collections.Generic.List<T>;
                    if (val != null) return val;
                }
                var propAll = typeof(EntityDataManager).GetProperty("All" + capName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                if (propAll != null)
                {
                    var val = propAll.GetValue(null) as Il2CppSystem.Collections.Generic.List<T>;
                    if (val != null) return val;
                }
                var field = typeof(EntityDataManager).GetField(fieldName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                if (field != null)
                {
                    var val = field.GetValue(null) as Il2CppSystem.Collections.Generic.List<T>;
                    if (val != null) return val;
                }
            }
            catch { }
            return null;
        }

        private static AppBundleProperties CreateRiziaBundleProps()
        {
            var props = new AppBundleProperties("StoryPack_Rizia");
            if (props.StoryPacks == null)
            {
                props.StoryPacks = new Il2CppSystem.Collections.Generic.List<string>();
            }
            if (!props.StoryPacks.Contains("StoryPack_Rizia"))
            {
                props.StoryPacks.Add("StoryPack_Rizia");
            }
            return props;
        }

        public static void RegisterNativeZilleEntities()
        {
            try
            {
                // 1. Ensure Conversation is registered in PixelCrushers masterDatabase
                EnsureWarCouncilConversationRegistered();

                // 2. Register ConversationData for Porte Drazon in EntityDataManager
                var allConvList = EntityDataManager.AllConversationsData ?? GetEntityBackingList<ConversationData>("conversationsData");

                ConversationData cd = null;
                if (allConvList != null)
                {
                    for (int i = 0; i < allConvList.Count; i++)
                    {
                        var c = allConvList[i];
                        if (c != null && c.NameInDatabase == "Turn_Zille_WarBriefing")
                        {
                            cd = c;
                            break;
                        }
                    }
                }

                if (cd == null)
                {
                    cd = new ConversationData();
                    cd.Id = "Conv_Zille_RoyalBriefing";
                    cd.NameInDatabase = "Turn_Zille_WarBriefing";
                    cd.Path = "Rizia/Conversations";
                    cd.IsWIP = false;
                    cd.Notes = "";
                    cd.AssignedTokenProperties = new AssignedTokenProperties();
                    cd.AssignedTokenProperties.AssignedToken = "Rizia_City_PorteDrazon";
                    cd.StoryFragmentProperties = new StoryFragmentProperties();
                    cd.StoryFragmentProperties.IsDone = false;
                    cd.StoryFragmentProperties.StoryFragmentCondition = "";
                    cd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
                    cd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
                    cd.ConversationProperties = new ConversationProperties();
                    cd.ConversationProperties.Title = "A royal briefing before the invasion of Zille";
                    cd.ConversationProperties.Subtitle = "Council Chambers, Palas Rezna";
                    cd.ConversationProperties.Dialogue = "Zille/WarCouncil_Briefing";
                    cd.ConversationProperties.TypeString = "SecurityAndOrder";
                    cd.ConversationProperties.IsOnStart = false;
                    cd.AppBundleProperties = CreateRiziaBundleProps();
                    cd.TagsProperties = new TagsProperties();

                    if (allConvList != null) allConvList.Add(cd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'A royal briefing before the invasion of Zille' to EntityDataManager.AllConversationsData!");
                }

                // Register all 6 custom Great Zille scenes in EntityDataManager
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarBalconySpeech", "Turn_Zille_WarBalconySpeech", "A Royal Proclamation of War", "Palas Rezna Balcony", "Zille/WarBalconySpeech");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarLogisticsDispute", "Turn_Zille_WarLogisticsDispute", "Supply Lines of Brenas: Azaro vs Sazon", "Ministry of War, Porte Drazon", "Zille/WarLogisticsDispute");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarPreNegotiations", "Turn_Zille_WarPreNegotiationsBriefing", "Pre-Negotiations Briefing & Foreign Hotlines", "War Room & Communications Cabinet", "Zille/PreNegotiationsBriefing");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarSmolakParley", "Turn_Zille_WarSmolakFinalParley", "Frontline Parley with Wiktor Smolak", "Neutral Military Pavilion, Zille Border", "Zille/SmolakFinalParley");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty", "The Treaty of Zille", "Treaty Pavilion", "Zille/PeaceTreaty");

                // 3. Register WarFragmentData for Zille invasion in EntityDataManager
                var allWarList = EntityDataManager.AllWarFragmentsData ?? GetEntityBackingList<WarFragmentData>("warFragmentData");

                WarFragmentData wfd = null;
                if (allWarList != null)
                {
                    for (int i = 0; i < allWarList.Count; i++)
                    {
                        var w = allWarList[i];
                        if (w != null && w.NameInDatabase == "WarFragment_Zille_1_1")
                        {
                            wfd = w;
                            break;
                        }
                    }
                }

                if (wfd == null)
                {
                    wfd = new WarFragmentData();
                    wfd.Id = "WarFragment_Zille_1_1";
                    wfd.NameInDatabase = "WarFragment_Zille_1_1";
                    wfd.Path = "Rizia/War Fragments";
                    wfd.IsWIP = false;
                    wfd.Notes = "";
                    wfd.AssignedTokenProperties = new AssignedTokenProperties();
                    wfd.AssignedTokenProperties.AssignedToken = "Rizia_Event_InvasionOfZille";
                    wfd.StoryFragmentProperties = new StoryFragmentProperties();
                    wfd.StoryFragmentProperties.IsDone = false;
                    wfd.StoryFragmentProperties.StoryFragmentCondition = "";
                    wfd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
                    wfd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
                    wfd.WarFragmentProperties = new WarFragmentProperties();
                    wfd.WarFragmentProperties.Operation = "Operation_Zille_1";
                    wfd.WarFragmentProperties.HubWarFragmentTitle = "Operation: Righteous Sword - Phase I";
                    wfd.WarFragmentProperties.HubWarFragmentSubtitle = "Invasion of Zille";
                    wfd.AppBundleProperties = CreateRiziaBundleProps();

                    if (allWarList != null) allWarList.Add(wfd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'Operation: Righteous Sword - Phase I' to EntityDataManager.AllWarFragmentsData!");
                }
                else
                {
                    if (wfd.StoryFragmentProperties != null)
                    {
                        if (wfd.StoryFragmentProperties.StoryFragmentCondition == null) wfd.StoryFragmentProperties.StoryFragmentCondition = "";
                        if (wfd.StoryFragmentProperties.OnStoryFragmentBeginInstruction == null) wfd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
                        if (wfd.StoryFragmentProperties.OnStoryFragmentEndInstruction == null) wfd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
                    }
                    if (wfd.WarFragmentProperties != null)
                    {
                        wfd.WarFragmentProperties.Operation = "Operation_Zille_1";
                        wfd.WarFragmentProperties.HubWarFragmentTitle = "Operation: Righteous Sword - Phase I";
                        wfd.WarFragmentProperties.HubWarFragmentSubtitle = "Invasion of Zille";
                    }
                }

                // 4. Register MapTokenData for Rizia_Event_InvasionOfZille into backing list mapTokensData
                var allTokenList = GetEntityBackingList<MapTokenData>("mapTokensData") ?? EntityDataManager.MapTokensData;

                MapTokenData zilleMtd = null;
                if (allTokenList != null)
                {
                    for (int i = 0; i < allTokenList.Count; i++)
                    {
                        var t = allTokenList[i];
                        if (t != null && t.NameInDatabase == "Rizia_Event_InvasionOfZille")
                        {
                            zilleMtd = t;
                            break;
                        }
                    }
                }

                if (zilleMtd == null)
                {
                    zilleMtd = new MapTokenData();
                    zilleMtd.Id = "Rizia_Event_InvasionOfZille";
                    zilleMtd.NameInDatabase = "Rizia_Event_InvasionOfZille";
                    zilleMtd.Path = "Rizia/Tokens";
                    zilleMtd.IsWIP = false;
                    zilleMtd.Notes = "";
                    zilleMtd.MapTokenProperties = new MapTokenProperties();
                    zilleMtd.MapTokenProperties.Title = "Invasion of Zille";
                    zilleMtd.MapTokenProperties.Subtitle = "Military Operation";
                    zilleMtd.MapTokenProperties.ImagePath = "";
                    zilleMtd.MapTokenProperties.SoundEffect = "";
                    zilleMtd.MapTokenProperties.Type = "Event";
                    zilleMtd.MapTokenProperties.IsTokenEnabled = true;
                    zilleMtd.StatusEffectsProperties = new StatusEffectsProperties();
                    zilleMtd.StatusEffectsProperties.HasNewStatusEffect = false;
                    zilleMtd.StatusEffectsProperties.StatusEffects = new Il2CppSystem.Collections.Generic.List<string>();
                    zilleMtd.StatusEffectsProperties.ConditionalStatusEffectGroups = new Il2CppSystem.Collections.Generic.List<string>();
                    zilleMtd.DescriptionProperties = new DescriptionProperties();
                    zilleMtd.DescriptionProperties.Description = "Military Operation";
                    zilleMtd.AppBundleProperties = CreateRiziaBundleProps();

                    if (allTokenList != null) allTokenList.Add(zilleMtd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'Rizia_Event_InvasionOfZille' to EntityDataManager backing mapTokensData!");
                }

                // 5. Register dedicated OperationData for Operation_Zille_1 into backing list operationData
                var allOps = GetEntityBackingList<OperationData>("operationData") ?? EntityDataManager.OperationData;

                OperationData zilleOp = null;
                if (allOps != null)
                {
                    for (int i = 0; i < allOps.Count; i++)
                    {
                        var op = allOps[i];
                        if (op != null && (op.NameInDatabase == "Operation_Zille_1" || op.Id == "Operation_Zille_1"))
                        {
                            zilleOp = op;
                            break;
                        }
                    }
                }

                if (zilleOp == null)
                {
                    zilleOp = new OperationData();
                    zilleOp.Id = "Operation_Zille_1";
                    zilleOp.NameInDatabase = "Operation_Zille_1";
                    zilleOp.Path = "Rizia/Operations";
                    zilleOp.IsWIP = false;
                    zilleOp.Notes = "";
                    zilleOp.OperationProperties = new OperationProperties();
                    zilleOp.OperationProperties.OperationName = "Operation: Righteous Sword";
                    zilleOp.OperationProperties.OperationStartCondition = "";
                    zilleOp.OperationProperties.IsOperationFinishedEarly = "";
                    zilleOp.OperationProperties.ResultConditionalInstruction = "";
                    zilleOp.OperationProperties.WinReport = "Report_Zille_Conclusion";
                    zilleOp.OperationProperties.LoseReport = "Report_Zille_Conclusion";
                    zilleOp.OperationProperties.Phases = new Il2CppSystem.Collections.Generic.List<string>();
                    zilleOp.OperationProperties.Phases.Add("WarFragment_Zille_1_1");
                    zilleOp.OperationProperties.ResultVariable = "War_Zille_Result";
                    zilleOp.OperationProperties.TotalEnemyDeadVariable = "War_Zille_TotalEnemyDead";
                    zilleOp.OperationProperties.TotalPlayerDeadVariable = "War_Zille_TotalPlayerDead";
                    zilleOp.OperationProperties.IsTutorial = false;
                    zilleOp.OperationProperties.IsFinished = false;
                    zilleOp.AppBundleProperties = CreateRiziaBundleProps();

                    if (allOps != null) allOps.Add(zilleOp);
                    MelonLogger.Msg("[WAR ENGINE] Added dedicated 'Operation_Zille_1' (Operation: Righteous Sword) to EntityDataManager backing operationData!");
                }
                else
                {
                    if (zilleOp.OperationProperties != null)
                    {
                        if (zilleOp.OperationProperties.OperationStartCondition == null) zilleOp.OperationProperties.OperationStartCondition = "";
                        if (zilleOp.OperationProperties.IsOperationFinishedEarly == null) zilleOp.OperationProperties.IsOperationFinishedEarly = "";
                        if (zilleOp.OperationProperties.ResultConditionalInstruction == null) zilleOp.OperationProperties.ResultConditionalInstruction = "";
                        zilleOp.OperationProperties.WinReport = "Report_Zille_Conclusion";
                        zilleOp.OperationProperties.LoseReport = "Report_Zille_Conclusion";
                        if (zilleOp.OperationProperties.Phases != null && !zilleOp.OperationProperties.Phases.Contains("WarFragment_Zille_1_1"))
                        {
                            zilleOp.OperationProperties.Phases.Add("WarFragment_Zille_1_1");
                        }
                    }
                }

                // Clean up any previous injection into Operation_1 (so Pales is completely separate)
                if (allOps != null)
                {
                    for (int i = 0; i < allOps.Count; i++)
                    {
                        var op = allOps[i];
                        if (op != null && (op.NameInDatabase == "Operation_1" || op.Id == "Operation_1"))
                        {
                            if (op.OperationProperties?.Phases != null && op.OperationProperties.Phases.Contains("WarFragment_Zille_1_1"))
                            {
                                op.OperationProperties.Phases.Remove("WarFragment_Zille_1_1");
                            }
                            break;
                        }
                    }
                }

                // 6. Register both story fragments into GameFlowManager.enabledNotDoneStoryFragments
                var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                if (gfm != null)
                {
                    var enabledFrags = gfm.GetEnabledNotDoneStoryFragments();
                    if (enabledFrags != null)
                    {
                        if (cd != null && !enabledFrags.Contains(cd))
                        {
                            enabledFrags.Add(cd);
                            MelonLogger.Msg("[WAR ENGINE] Registered Turn_Zille_WarBriefing into GameFlowManager.enabledNotDoneStoryFragments!");
                        }
                        if (wfd != null && !enabledFrags.Contains(wfd))
                        {
                            enabledFrags.Add(wfd);
                            MelonLogger.Msg("[WAR ENGINE] Registered WarFragment_Zille_1_1 into GameFlowManager.enabledNotDoneStoryFragments!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] RegisterNativeZilleEntities error: {ex.Message}");
            }
        }

        // ================= FOCUS PORTE DRAZON BRIEFING EVENT =================

        public static bool FocusPorteDrazonBriefing()
        {
            RegisterNativeZilleEntities();

            try
            {
                // 1. Move camera & focus on Porte Drazon token
                Token porteToken = null;
                var allTokens = Resources.FindObjectsOfTypeAll<Token>();
                if (allTokens != null)
                {
                    for (int i = 0; i < allTokens.Length; i++)
                    {
                        var t = allTokens[i];
                        if (t != null && t.gameObject != null)
                        {
                            string n = t.gameObject.name ?? "";
                            string e = t.GetTokenDataEntityName() ?? "";
                            if (n.Contains("PorteDrazon") || n.Contains("Porte Drazon") || e.Contains("PorteDrazon"))
                            {
                                porteToken = t;
                                break;
                            }
                        }
                    }
                }

                var tokenMgr = Managers.Instance?.TokenManager ?? UnityEngine.Object.FindObjectOfType<TokenManager>();
                if (tokenMgr != null && porteToken != null)
                {
                    tokenMgr.SelectToken(porteToken);
                    var tip = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();
                    if (tip != null)
                    {
                        tip.gameObject.SetActive(true);
                        tip.Setup(porteToken);
                        tip.Show();
                    }
                    DialogueHelper.ShowAlert("[Porte Drazon] Wybierz event 'A royal briefing before the invasion of Zille' aby rozpoczac narade.");
                    return true;
                }

                // Fallback: If token not found, start conversation directly
                return TriggerZilleWarBriefingConversation();
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] FocusPorteDrazonBriefing failed: {ex.Message}");
                return TriggerZilleWarBriefingConversation();
            }
        }

        // ================= SPAWN / FOCUS WAR EVENT AT ZILLE =================

        public static bool SpawnZilleWarEventToken()
        {
            RegisterNativeZilleEntities();

            try
            {
                TokenManager tokenMgr = Managers.Instance?.TokenManager ?? UnityEngine.Object.FindObjectOfType<TokenManager>();

                Vector3 zilleWarPos = BorderEventPosition();
                TokenBasePos = zilleWarPos;

                // 1. First, search for existing cloned InvasionOfZille Event Variant
                if (_spawnedZilleWarToken == null)
                {
                    _spawnedZilleWarToken = GameObject.Find("InvasionOfZille Event Variant");
                    if (_spawnedZilleWarToken == null)
                    {
                        var allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
                        for (int i = 0; i < allObjs.Length; i++)
                        {
                            if (allObjs[i] != null && allObjs[i].name == "InvasionOfZille Event Variant")
                            {
                                _spawnedZilleWarToken = allObjs[i];
                                break;
                            }
                        }
                    }
                }

                // 2. If not found, clone InvasionOfPales Event Variant to get the exact identical war pawn!
                if (_spawnedZilleWarToken == null)
                {
                    GameObject palesWarTemplate = GameObject.Find("InvasionOfPales Event Variant");
                    if (palesWarTemplate == null)
                    {
                        var allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
                        for (int i = 0; i < allObjs.Length; i++)
                        {
                            if (allObjs[i] != null && allObjs[i].name == "InvasionOfPales Event Variant")
                            {
                                palesWarTemplate = allObjs[i];
                                break;
                            }
                        }
                    }

                    if (palesWarTemplate != null)
                    {
                        // Ensure Pales template remains untouched and inactive in Turn 2!
                        palesWarTemplate.SetActive(false);

                        Transform parent = palesWarTemplate.transform.parent;
                        _spawnedZilleWarToken = UnityEngine.Object.Instantiate(palesWarTemplate, parent);
                        _spawnedZilleWarToken.name = "InvasionOfZille Event Variant";
                        _spawnedZilleWarToken.transform.position = zilleWarPos;
                        _spawnedZilleWarToken.transform.rotation = palesWarTemplate.transform.rotation;
                        _spawnedZilleWarToken.transform.localScale = palesWarTemplate.transform.localScale;
                        _spawnedZilleWarToken.layer = palesWarTemplate.layer;

                        var allTrans = _spawnedZilleWarToken.GetComponentsInChildren<Transform>(true);
                        for (int i = 0; i < allTrans.Length; i++)
                        {
                            if (allTrans[i] != null) allTrans[i].gameObject.layer = palesWarTemplate.layer;
                        }

                        _spawnedZilleWarToken.SetActive(true);
                        palesWarTemplate.SetActive(false); // Double ensure Pales template stays hidden in Turn 2!
                        MelonLogger.Msg($"[WAR ENGINE] Successfully instantiated separate InvasionOfZille Event Variant at {zilleWarPos} (Pales marker untouched)!");
                    }
                }

                    if (_spawnedZilleWarToken != null)
                    {
                        _spawnedZilleWarToken.transform.position = zilleWarPos;
                        _spawnedZilleWarToken.SetActive(true);
                        MatchTokenHeight(_spawnedZilleWarToken, _borderAnchor);

                    // Fetch or verify zilleMtd from EntityDataManager
                    MapTokenData zilleMtd = null;
                    var tokenList = EntityDataManager.MapTokensData;
                    if (tokenList != null)
                    {
                        for (int i = 0; i < tokenList.Count; i++)
                        {
                            if (tokenList[i] != null && tokenList[i].NameInDatabase == "Rizia_Event_InvasionOfZille")
                            {
                                zilleMtd = tokenList[i];
                                break;
                            }
                        }
                    }

                    var tok = _spawnedZilleWarToken.GetComponent<Token>();
                    if (tok != null)
                    {
                        tok.tokenDataEntityName = "Rizia_Event_InvasionOfZille";
                        tok.tokenType = Token.TokenType.Event;
                        if (zilleMtd != null) tok.tokenData = zilleMtd;
                        tok.gameObject.SetActive(true);
                        tok.Setup();

                        if (Managers.Instance?.Tokens != null && !Managers.Instance.Tokens.Contains(tok))
                        {
                            Managers.Instance.Tokens.Add(tok);
                        }

                    }

                    DialogueHelper.ShowAlert("[Zille] War token and Operation Righteous Sword Phase I are active in Zille.");
                    return true;
                }

                MelonLogger.Warning("[WAR ENGINE] Could not find or instantiate InvasionOfZille Event Variant.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] SpawnZilleWarEventToken failed: {ex.Message}\n{ex.StackTrace}");
            }
            return false;
        }

        /// <summary>Prepares Operation_Zille_1 so the pawn's own Suzerain button can play the Pales deployment intro.</summary>
        public static void ArmNativeZilleDeployment()
        {
            EnsureWarSave();
            SetupCustomZilleOperation();
            ZilleWarTable.SkinEnabled = true;
            MelonLogger.Msg("[WAR ENGINE] Armed native Zille deployment. The operation button keeps the Pales intro.");
        }

        /// <summary>SetupWarFragment dies without a war save, which is why the event click never plays the Pales intro.</summary>
        public static void EnsureWarSave()
        {
            try
            {
                var file = PersistenceManager.Instance != null ? PersistenceManager.Instance.activeSaveFile : null;
                var save = file != null ? file.saveData : null;
                if (save == null)
                {
                    MelonLogger.Warning("[WAR ENGINE] No active save file, so the Pales intro cannot store the war.");
                    return;
                }
                var cur = save.warSaveData;
                if (cur == null)
                {
                    cur = new WarSaveData();
                    cur.warFragmentName = "WarFragment_Zille_1_1";
                    save.warSaveData = cur;
                    MelonLogger.Msg("[WAR ENGINE] Created war save data on the active campaign.");
                }
                if (cur.warTokenSaveData == null) cur.warTokenSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarTokenSaveData>();
                if (cur.warBattleSaveData == null) cur.warBattleSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarBattleSaveData>();
                if (cur.warObjectiveSaveData == null) cur.warObjectiveSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarObjectiveSaveData>();
                if (cur.warTileSaveData == null) cur.warTileSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarTileSaveData>();
                if (cur.tileAllegianceChangeSaveData == null) cur.tileAllegianceChangeSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.TileAllegianceChangeSaveData>();
                if (cur.warStartBattleEventSaveData == null) cur.warStartBattleEventSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarStartBattleEventSaveData>();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[WAR ENGINE] War save: " + ex.Message);
            }
        }

        private static Token _borderAnchor;

        private static Vector3 BorderEventPosition()
        {
            var zille = FindCityToken("zille");
            // Bronaz is the Rizian province that touches Zille. Porte Drazon is the capital, far past that border.
            var rizia = FindCityToken("bronaz") ?? FindCityToken("brenas") ?? FindCityToken("iza");
            _borderAnchor = rizia ?? zille;
            Vector3 zillePos = zille != null ? zille.transform.position : new Vector3(0.4673f, 0.02f, 0.8262f);
            if (rizia != null && zille != null)
            {
                var p = Vector3.Lerp(zillePos, rizia.transform.position, 0.5f);
                p.y = rizia.transform.position.y;
                MelonLogger.Msg($"[WAR ENGINE] Event marker on the Zille–Rizia border at {p} (midpoint of {zille.name} and {rizia.name}).");
                return p;
            }
            var fallback = zillePos + new Vector3(0f, 0f, -0.04f);
            MelonLogger.Msg($"[WAR ENGINE] Event marker south of Zille at {fallback}.");
            return fallback;
        }

        private static Token FindCityToken(string needle)
        {
            Token[] tokens = null;
            try { tokens = UnityEngine.Object.FindObjectsOfType<Token>(); } catch { return null; }
            if (tokens == null) return null;
            needle = needle.ToLowerInvariant();
            for (int i = 0; i < tokens.Length; i++)
            {
                var t = tokens[i];
                if (t == null) continue;
                string name = t.gameObject.name ?? "";
                string blob = (name + " " + (t.tokenDataEntityName ?? "")).ToLowerInvariant();
                if (blob.Contains("event") || blob.Contains("invasion")) continue;
                if (blob.Contains(needle)) return t;
            }
            return null;
        }

        /// <summary>Puts the pawn's collider at the same height as a city token the player can already click.</summary>
        private static void MatchTokenHeight(GameObject go, Token reference)
        {
            if (go == null) return;
            if (reference == null)
            {
                MelonLogger.Warning("[WAR ENGINE] No city token to copy the event height from.");
                return;
            }
            var refCol = reference.GetComponentInChildren<Collider>();
            var cols = go.GetComponentsInChildren<Collider>(true);
            float refY = refCol != null ? refCol.bounds.center.y : reference.transform.position.y;
            float myY = refY;
            if (cols != null && cols.Length > 0 && cols[0] != null) myY = cols[0].bounds.center.y;
            float dy = refY - myY;
            if (Mathf.Abs(dy) > 0.002f)
                go.transform.position += new Vector3(0f, dy, 0f);
            MelonLogger.Msg($"[WAR ENGINE] Event hitbox matched to {reference.name}. Collider center {go.transform.position}.");
        }

        /// <summary>Drops the pawn so the bottom of its collider sits on the map, not above the province.</summary>
        private static void SeatTokenOnMap(GameObject go, float mapY)
        {
            if (go == null) return;
            var cols = go.GetComponentsInChildren<Collider>(true);
            float minY = float.MaxValue;
            bool any = false;
            for (int i = 0; i < cols.Length; i++)
            {
                var c = cols[i];
                if (c == null) continue;
                any = true;
                if (c.bounds.min.y < minY) minY = c.bounds.min.y;
            }
            if (!any)
            {
                var p = go.transform.position;
                go.transform.position = new Vector3(p.x, mapY, p.z);
                return;
            }
            float dy = minY - mapY;
            if (Mathf.Abs(dy) > 0.004f)
                go.transform.position -= new Vector3(0f, dy, 0f);
            MelonLogger.Msg($"[WAR ENGINE] Event hitbox seated. Bottom was {minY:F3}, map Y {mapY:F3}, now {go.transform.position}.");
        }

        // ================= HOVER AND CLICK RAYCAST INTERACTION =================

        public static void UpdateEventTokenInteractions()
        {
            // Native EventSystem & Suzerain TokenManager handle hover, click, and tooltips via MapTokenData.
        }

        // ================= NATIVE DIALOGUE ENGINE INJECTION =================

        private static void RegisterAdditionalConversationData(Il2CppSystem.Collections.Generic.List<ConversationData> allConvList, string id, string nameInDb, string title, string subtitle, string dialogue)
        {
            if (allConvList == null) return;
            for (int i = 0; i < allConvList.Count; i++)
            {
                if (allConvList[i] != null && allConvList[i].NameInDatabase == nameInDb) return;
            }
            var cd = new ConversationData();
            cd.Id = id;
            cd.NameInDatabase = nameInDb;
            cd.Path = "Rizia/Conversations";
            cd.IsWIP = false;
            cd.Notes = "";
            cd.AssignedTokenProperties = new AssignedTokenProperties();
            cd.AssignedTokenProperties.AssignedToken = "Rizia_City_PorteDrazon";
            cd.StoryFragmentProperties = new StoryFragmentProperties();
            cd.StoryFragmentProperties.IsDone = false;
            cd.StoryFragmentProperties.StoryFragmentCondition = "";
            cd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
            cd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
            cd.ConversationProperties = new ConversationProperties();
            cd.ConversationProperties.Title = title;
            cd.ConversationProperties.Subtitle = subtitle;
            cd.ConversationProperties.Dialogue = dialogue;
            cd.ConversationProperties.TypeString = "SecurityAndOrder";
            cd.ConversationProperties.IsOnStart = false;
            cd.AppBundleProperties = CreateRiziaBundleProps();
            cd.TagsProperties = new TagsProperties();
            allConvList.Add(cd);
            MelonLogger.Msg($"[WAR ENGINE] Added '{title}' ({nameInDb}) to EntityDataManager.AllConversationsData!");
        }

        public static bool EnsureWarCouncilConversationRegistered()
        {
            try
            {
                var db = DialogueManager.masterDatabase;
                if (db == null)
                {
                    MelonLogger.Warning("[WAR ENGINE] DialogueManager.masterDatabase not ready yet.");
                    return false;
                }

                ZilleDialogueSystem.EnsureAllConversationsRegistered();
                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] EnsureWarCouncilConversationRegistered error: {ex.Message}");
                return false;
            }
        }

        public static bool TriggerZilleWarBriefingConversation()
        {
            MelonLogger.Msg("[WAR ENGINE] Launching native Royal War Council Briefing via ConversationPanel...");
            EnsureWarCouncilConversationRegistered();

            try
            {
                var convPanel = Panels.Instance?.ConversationPanel ?? UnityEngine.Object.FindObjectOfType<ConversationPanel>();
                if (convPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<ConversationPanel>();
                    if (allPanels != null && allPanels.Length > 0) convPanel = allPanels[0];
                }

                if (convPanel != null)
                {
                    Panels.Instance?.TokenInteractionPanel?.Hide();
                    Panels.Instance?.HideAllRightPanels();
                    Panels.Instance?.HideAllCenterPanels();
                    Managers.Instance?.GameFlowManager?.OnStoryFragmentStart();

                    convPanel.isWarConversation = false;
                    convPanel.isMinimizable = false;
                    convPanel.gameObject.SetActive(true);
                    if (convPanel.inputBlockerPanel != null)
                    {
                        convPanel.inputBlockerPanel.gameObject.SetActive(true);
                    }

                    ConversationData cd = null;
                    var convList = EntityDataManager.AllConversationsData ?? EntityDataManager.ConversationsData;
                    if (convList != null)
                    {
                        for (int i = 0; i < convList.Count; i++)
                        {
                            var c = convList[i];
                            if (c != null && (c.NameInDatabase == "Turn_Zille_WarBriefing" || c.NameInDatabase == "Zille/WarCouncil_Briefing"))
                            {
                                cd = c;
                                break;
                            }
                        }
                    }

                    if (cd == null)
                    {
                        cd = new ConversationData();
                        cd.Id = "Conv_Zille_RoyalBriefing";
                        cd.NameInDatabase = "Turn_Zille_WarBriefing";
                        cd.Path = "Rizia/Conversations";
                        cd.IsWIP = false;
                        cd.Notes = "";
                        cd.AssignedTokenProperties = new AssignedTokenProperties();
                        cd.AssignedTokenProperties.AssignedToken = "Rizia_City_PorteDrazon";
                        cd.StoryFragmentProperties = new StoryFragmentProperties();
                        cd.StoryFragmentProperties.IsDone = false;
                        cd.StoryFragmentProperties.StoryFragmentCondition = "";
                        cd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
                        cd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
                        cd.ConversationProperties = new ConversationProperties();
                        cd.ConversationProperties.Title = "A royal briefing before the invasion of Zille";
                        cd.ConversationProperties.Subtitle = "Council Chambers, Palas Rezna";
                        cd.ConversationProperties.Dialogue = "Zille/WarCouncil_Briefing";
                        cd.ConversationProperties.TypeString = "SecurityAndOrder";
                        cd.ConversationProperties.IsOnStart = false;
                        cd.AppBundleProperties = CreateRiziaBundleProps();
                        cd.TagsProperties = new TagsProperties();
                        if (convList != null) convList.Add(cd);
                    }

                    System.Action onFinish = () => {
                        try
                        {
                            var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                            if (gfm != null && cd != null)
                            {
                                gfm.FinishStoryFragment(cd, null);
                            }
                            Panels.Instance?.ShowHUD();

                            if (PendingZilleTokenSpawnAfterBriefing)
                            {
                                PendingZilleTokenSpawnAfterBriefing = false;
                                SpawnZilleWarEventToken();
                            }
                        }
                        catch (Exception ex)
                        {
                            MelonLogger.Warning($"[WAR ENGINE] OnFinish briefing error: {ex.Message}");
                        }
                    };

                    if (cd != null)
                    {
                        convPanel.Setup(cd, onFinish, false);
                    }
                    else
                    {
                        convPanel.ForceStartConversation("Zille/WarCouncil_Briefing");
                    }

                    if (!DialogueManager.isConversationActive)
                    {
                        MelonLogger.Msg("[WAR ENGINE] Starting conversation 'Zille/WarCouncil_Briefing' via DialogueManager...");
                        DialogueManager.StartConversation("Zille/WarCouncil_Briefing");
                    }

                    // Populate conversant portraits for Titus, Lucita, Hugo, Elena, and Laurento in ConversationPanel
                    var chars = EntityDataManager.CharactersData;
                    if (chars != null)
                    {
                        for (int i = 0; i < chars.Count; i++)
                        {
                            var ch = chars[i];
                            if (ch == null) continue;
                            string cName = ch.CharacterName ?? ch.NameInDatabase ?? "";
                            if (cName.IndexOf("Titus", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                cName.IndexOf("Lucita", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                cName.IndexOf("Hugo", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                cName.IndexOf("Elena", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                cName.IndexOf("Laurento", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                convPanel.AddConversant(ch);
                            }
                        }
                    }

                    convPanel.Show();
                    MelonLogger.Msg("[WAR ENGINE] Native ConversationPanel opened for Zille War Council!");
                    return true;
                }
                else
                {
                    MelonLogger.Warning("[WAR ENGINE] ConversationPanel not found, using DialogueManager fallback.");
                    DialogueManager.StartConversation("Zille/WarCouncil_Briefing");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] DialogueManager.StartConversation failed: {ex.Message}");
                return false;
            }
        }

        // ================= SCHEDULED THEATRE TRANSITION =================

        public static void ScheduleWarTheatreTransition()
        {
            _transitionScheduled = true;
            _transitionTimer = 0.5f;
        }

        public static void CheckScheduledTransition(float deltaTime)
        {
            if (!_transitionScheduled) return;

            _transitionTimer -= deltaTime;
            if (_transitionTimer <= 0f)
            {
                _transitionScheduled = false;
                EnterZilleWarTheatre();
            }
        }

        // ================= NATIVE 3D ZILLE WAR THEATRE =================

        public static WarOperation SetupCustomZilleOperation()
        {
            if (_customOperationConfigured && _zilleWarOp != null && _zilleWarOp.gameObject != null)
            {
                return _zilleWarOp;
            }

            try
            {
                var palesOps = GameObject.Find("Pales Operations Container");
                if (palesOps == null)
                {
                    var allContainers = Resources.FindObjectsOfTypeAll<GameObject>();
                    for (int i = 0; i < allContainers.Length; i++)
                    {
                        if (allContainers[i] != null && allContainers[i].name == "Pales Operations Container")
                        {
                            palesOps = allContainers[i];
                            break;
                        }
                    }
                }

                if (palesOps == null) return null;

                palesOps.SetActive(true);

                // 1. Find Operation_1 template
                GameObject op1Obj = null;
                GameObject zilleOpObj = null;
                for (int i = 0; i < palesOps.transform.childCount; i++)
                {
                    var child = palesOps.transform.GetChild(i);
                    if (child == null) continue;
                    if (child.name == "Operation_1") op1Obj = child.gameObject;
                    else if (child.name == "Operation_Zille_1") zilleOpObj = child.gameObject;
                }

                if (op1Obj == null)
                {
                    var allOps = Resources.FindObjectsOfTypeAll<GameObject>();
                    for (int i = 0; i < allOps.Length; i++)
                    {
                        if (allOps[i] != null && allOps[i].name == "Operation_1")
                        {
                            op1Obj = allOps[i];
                            break;
                        }
                    }
                }

                if (op1Obj == null) return null;

                var palesWarOp = op1Obj.GetComponent<WarOperation>();
                if (palesWarOp == null) return null;

                // 2. Instantiate or get Operation_Zille_1
                if (zilleOpObj == null)
                {
                    zilleOpObj = UnityEngine.Object.Instantiate(op1Obj, palesOps.transform);
                    zilleOpObj.name = "Operation_Zille_1";
                    MelonLogger.Msg("[WAR ENGINE] Instantiated new Operation_Zille_1 GameObject under Pales Operations Container!");
                }

                var zilleWarOp = zilleOpObj.GetComponent<WarOperation>();
                if (zilleWarOp == null)
                {
                    zilleWarOp = zilleOpObj.AddComponent<WarOperation>();
                }

                // 3. Clone and configure WarOperationData ScriptableObject
                WarOperationData zilleOpData = null;
                if (palesWarOp.warOperationData != null)
                {
                    zilleOpData = ScriptableObject.Instantiate(palesWarOp.warOperationData);
                }
                else
                {
                    zilleOpData = ScriptableObject.CreateInstance<WarOperationData>();
                }

                zilleOpData.name = "Operation_Zille_1_Data";
                zilleOpData.operationNameInDatabase = "Operation_Zille_1";

                // Configure included tile names
                var config = ZilleMapLayoutManager.CurrentConfig;
                zilleOpData.includedTileNames = new Il2CppSystem.Collections.Generic.List<string>();
                if (config != null && config.Tiles != null)
                {
                    for (int i = 0; i < config.Tiles.Count; i++)
                    {
                        zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName(config.Tiles[i].Id));
                    }
                }
                else
                {
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_zille"));
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_munat"));
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_wiktrany"));
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_nanta"));
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_brenas"));
                }

                // Every layout province, including ones added from the theatre menu, becomes real tile data.
                zilleOpData.tileData = new Il2CppSystem.Collections.Generic.List<ConditionalWarTileData>();
                var condTileData = new ConditionalWarTileData();
                condTileData.condition = "";
                condTileData.tiles = new Il2CppSystem.Collections.Generic.List<WarTileData>();
                if (config != null && config.Tiles != null)
                {
                    for (int i = 0; i < config.Tiles.Count; i++)
                    {
                        var src = config.Tiles[i];
                        var wtd = new WarTileData();
                        ZilleWarTable.FillWarTileData(src, wtd);
                        if (string.IsNullOrEmpty(wtd.tileName))
                            wtd.tileName = ZilleMapLayoutManager.GameTileName(src.Id);
                        condTileData.tiles.Add(wtd);
                    }
                }
                zilleOpData.tileData.Add(condTileData);

                // Extract City Unit Type from Pales operation template
                WarUnitTypeData cityUnitType = null;
                if (palesWarOp.warOperationData?.playerCityTokens != null && palesWarOp.warOperationData.playerCityTokens.Count > 0)
                {
                    var c = palesWarOp.warOperationData.playerCityTokens[0];
                    if (c?.tokens != null && c.tokens.Count > 0) cityUnitType = c.tokens[0].unitType;
                }
                if (cityUnitType == null && palesWarOp.warOperationData?.enemyCityTokens != null && palesWarOp.warOperationData.enemyCityTokens.Count > 0)
                {
                    var c = palesWarOp.warOperationData.enemyCityTokens[0];
                    if (c?.tokens != null && c.tokens.Count > 0) cityUnitType = c.tokens[0].unitType;
                }

                // Configure Player Cities (Brenas staging base)
                zilleOpData.playerCityTokens = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                if (cityUnitType != null)
                {
                    var playerCities = new ConditionalWarTokenData();
                    playerCities.condition = "";
                    playerCities.tokens = new Il2CppSystem.Collections.Generic.List<WarTokenData>();

                    if (config?.Tiles != null)
                    {
                        for (int i = 0; i < config.Tiles.Count; i++)
                        {
                            var src = config.Tiles[i];
                            if (!src.IsCity || src.Allegiance != "Rizia" || string.IsNullOrEmpty(src.TileNumber)) continue;
                            if (!ZilleMapLayoutManager.IsScenarioCity(src.Name)) continue;
                            var token = new WarTokenData();
                            token.startingTileName = src.TileNumber;
                            token.guid = "city_" + src.Id;
                            token.allegiance = WarToken.WarAllegiance.Player;
                            token.unitType = cityUnitType;
                            playerCities.tokens.Add(token);
                        }
                    }
                    if (playerCities.tokens.Count > 0)
                        zilleOpData.playerCityTokens.Add(playerCities);
                }

                // Configure Enemy Cities (Zille, Munat, Wiktrany, Nanta)
                zilleOpData.enemyCityTokens = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                if (cityUnitType != null)
                {
                    var enemyCities = new ConditionalWarTokenData();
                    enemyCities.condition = "";
                    enemyCities.tokens = new Il2CppSystem.Collections.Generic.List<WarTokenData>();

                    var enemyCityTiles = new List<string>();
                    if (config?.Tiles != null)
                    {
                        for (int i = 0; i < config.Tiles.Count; i++)
                        {
                            var src = config.Tiles[i];
                            if (src.IsCity && src.Allegiance != "Rizia" && !string.IsNullOrEmpty(src.TileNumber)
                                && ZilleMapLayoutManager.IsScenarioCity(src.Name))
                                enemyCityTiles.Add(src.TileNumber);
                        }
                    }
                    if (enemyCityTiles.Count == 0)
                    {
                        enemyCityTiles.Add(ZilleMapLayoutManager.GameTileName("tile_zille"));
                        enemyCityTiles.Add(ZilleMapLayoutManager.GameTileName("tile_munat"));
                        enemyCityTiles.Add(ZilleMapLayoutManager.GameTileName("tile_wiktrany"));
                        enemyCityTiles.Add(ZilleMapLayoutManager.GameTileName("tile_nanta"));
                    }
                    for (int c = 0; c < enemyCityTiles.Count; c++)
                    {
                        var cToken = new WarTokenData();
                        cToken.startingTileName = enemyCityTiles[c];
                        cToken.guid = $"city_zille_{enemyCityTiles[c]}";
                        cToken.allegiance = WarToken.WarAllegiance.Enemy;
                        cToken.unitType = cityUnitType;
                        enemyCities.tokens.Add(cToken);
                    }

                    zilleOpData.enemyCityTokens.Add(enemyCities);
                }

                // Wehlen starts from the selected v13 deployment. City provinces stay empty of combat units.
                var deploymentPool = new List<WarUnitTypeData>();
                if (palesWarOp.warOperationData?.enemyTokens != null)
                {
                    for (int e = 0; e < palesWarOp.warOperationData.enemyTokens.Count; e++)
                    {
                        var cond = palesWarOp.warOperationData.enemyTokens[e];
                        if (cond?.tokens == null) continue;
                        for (int t = 0; t < cond.tokens.Count; t++)
                        {
                            var ut = cond.tokens[t]?.unitType;
                            if (ut != null) deploymentPool.Add(ut);
                        }
                    }
                }

                zilleOpData.enemyTokens = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                var garrisonCond = new ConditionalWarTokenData();
                garrisonCond.condition = "";
                garrisonCond.tokens = new Il2CppSystem.Collections.Generic.List<WarTokenData>();
                ZilleWarTable.QueueDeployment(garrisonCond.tokens, deploymentPool);
                if (garrisonCond.tokens.Count > 0)
                    zilleOpData.enemyTokens.Add(garrisonCond);

                // Initialize remaining lists on WarOperationData so WarFlowManager & WarOperationManager never NullRef
                zilleOpData.supplyLines = ZilleWarTable.BuildSupplyLines();
                zilleOpData.tileAllegianceChangeEvents = new Il2CppSystem.Collections.Generic.List<ConditionalTileAllegianceChangeEvent>();
                zilleOpData.warFlowEvents = new Il2CppSystem.Collections.Generic.List<ConditionalWarFlowEvent>();
                zilleOpData.onStartBattleEvents = new Il2CppSystem.Collections.Generic.List<ConditionalWarStartBattleEvent>();
                zilleOpData.tileUnitActionEvents = new Il2CppSystem.Collections.Generic.List<ConditionalTileUnitActionEvent>();
                zilleOpData.tileDataOverrides = new Il2CppSystem.Collections.Generic.List<ConditionalWarTileData>();
                zilleOpData.enemyTokenOverrides = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                zilleOpData.playerCityTokenOverrides = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                zilleOpData.enemyCityTokenOverrides = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();

                zilleWarOp.warOperationData = zilleOpData;

                // 4. Register in Managers.Instance.Operations
                if (Managers.Instance?.Operations != null && !Managers.Instance.Operations.Contains(zilleWarOp))
                {
                    Managers.Instance.Operations.Add(zilleWarOp);
                    MelonLogger.Msg("[WAR ENGINE] Added Operation_Zille_1 to Managers.Instance.Operations!");
                }

                // 5. Activate Operation_Zille_1 and deactivate Pales operations
                zilleOpObj.SetActive(true);
                op1Obj.SetActive(false);

                // IMPORTANT: "Pales Operations Container" also holds the war "Map Container" (the Addressables loader of
                // Map_Rizia_PalesWar) and the table background. Disabling those stops the map from ever loading
                // (a coroutine cannot run on an inactive object) - this was the long-standing "no map" bug.
                // So only switch off the OTHER WarOperation objects, and make sure the map loader stays enabled.
                for (int i = 0; i < palesOps.transform.childCount; i++)
                {
                    var child = palesOps.transform.GetChild(i);
                    if (child == null || child.name == "Operation_Zille_1") continue;
                    bool isOperation = child.GetComponent<WarOperation>() != null || child.name.StartsWith("Operation_");
                    if (isOperation)
                    {
                        child.gameObject.SetActive(false);
                    }
                    else if (child.GetComponent<MapContainer>() != null && !child.gameObject.activeSelf)
                    {
                        child.gameObject.SetActive(true);
                        MelonLogger.Msg($"[WAR ENGINE] Re-enabled '{child.name}' (war map loader).");
                    }
                }

                // 6. Point WarOperationManager to our custom operation
                var wom = Managers.Instance?.WarOperationManager ?? UnityEngine.Object.FindObjectOfType<WarOperationManager>();
                if (wom != null)
                {
                    wom.currentOperation = zilleWarOp;
                }

                _customOperationConfigured = true;
                _zilleWarOp = zilleWarOp;
                MelonLogger.Msg("[WAR ENGINE] Dedicated Operation_Zille_1 active and synchronized!");
                return zilleWarOp;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] SetupCustomZilleOperation: {ex.Message}");
                return null;
            }
        }

        public static bool EnterZilleWarTheatre(bool editOnly = false)
        {
            ZilleWarTable.EditMode = editOnly;
            MelonLogger.Msg("============================================================");
            MelonLogger.Msg(editOnly
                ? "[WAR ENGINE] Entering the Zille table in edit mode."
                : "[WAR ENGINE] Entering Native 3D Zille War Theatre (Golden Shield Parity)...");
            MelonLogger.Msg("============================================================");

            try
            {
                CurrentTheatre = ActiveWarTheatre.Zille;
                _tilesConfiguredForZille = false;

                // 1. Deselect tokens & hide all panels (matching vanilla TemplateInteractionButton.OnClick)
                try
                {
                    var tokenMgr = Managers.Instance?.TokenManager ?? UnityEngine.Object.FindObjectOfType<TokenManager>();
                    tokenMgr?.DeselectAllTokens();
                    Panels.Instance?.TokenInteractionPanel?.Hide();
                    Panels.Instance?.HideAllRightPanels();
                    Panels.Instance?.HideAllCenterPanels();
                    SetCivilianTogglesVisible(false);
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning($"[WAR ENGINE] Deselect/Hide warning: {ex.Message}");
                }

                // 2. Ensure textures are loaded into GPU memory and native entities registered
                ZilleMapLayoutManager.EnsureTexturesLoaded();
                RegisterNativeZilleEntities();

                // 3. Fetch WarFragmentData for Zille
                WarFragmentData wfd = null;
                var warFragments = EntityDataManager.AllWarFragmentsData ?? EntityDataManager.WarFragmentsData;
                if (warFragments != null)
                {
                    for (int i = 0; i < warFragments.Count; i++)
                    {
                        if (warFragments[i] != null && warFragments[i].NameInDatabase == "WarFragment_Zille_1_1")
                        {
                            wfd = warFragments[i];
                            break;
                        }
                    }
                }
                if (wfd != null && wfd.StoryFragmentProperties != null)
                {
                    wfd.StoryFragmentProperties.IsDone = false;
                }

                // Ensure Operation_Zille_1 IsFinished is false so WarFlowManager runs full initial deployment!
                var allOps = GetEntityBackingList<OperationData>("operationData") ?? EntityDataManager.OperationData;
                if (allOps != null)
                {
                    for (int i = 0; i < allOps.Count; i++)
                    {
                        var op = allOps[i];
                        if (op != null && (op.NameInDatabase == "Operation_Zille_1" || op.Id == "Operation_Zille_1"))
                        {
                            if (op.OperationProperties != null) op.OperationProperties.IsFinished = false;
                            break;
                        }
                    }
                }

                // 4. Setup custom Zille 3D operation in scene
                SetupCustomZilleOperation();

                // 5. The Pales intro reads the campaign war save. Without it the coroutine stops before the Start button.
                EnsureWarSave();

                // 6. Explicitly load War Map via MapManager (unloads Map_Rizia_Base civilian map and instantiates Map_Rizia_PalesWar)
                var mapManager = Managers.Instance?.MapManager ?? UnityEngine.Object.FindObjectOfType<MapManager>();
                if (mapManager != null)
                {
                    mapManager.LoadMap(MapConfiguration.MapType.War);
                    MelonLogger.Msg("[WAR ENGINE] Called MapManager.LoadMap(MapConfiguration.MapType.War)!");
                }

                // 7. Launch native WarFlowManager (which sets up HUD, deployment panel, unit tokens, and objectives)
                var warFlowMgr = Managers.Instance?.WarFlowManager ?? UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (warFlowMgr != null && wfd != null)
                {
                    MelonLogger.Msg("[WAR ENGINE] Starting native WarFlowManager with WarFragment_Zille_1_1!");
                    warFlowMgr.SetupWarFragment(wfd);
                }

                // 8. Start War Music and stop civilian ambience
                try
                {
                    var audioMgr = Managers.Instance?.AudioManager ?? UnityEngine.Object.FindObjectOfType<AudioManager>();
                    if (audioMgr != null)
                    {
                        audioMgr.StopMapMusic();
                        audioMgr.StopMapAmbience();
                        string intro = warFlowMgr?.warConfiguration?.WarMapIntroTrackName ?? "Track_War_Intro";
                        string loop = warFlowMgr?.warConfiguration?.WarMapLoopTrackName ?? "Track_War_Loop";
                        if (!string.IsNullOrEmpty(intro) && !string.IsNullOrEmpty(loop))
                        {
                            audioMgr.PlayLoopedMusic(intro, loop);
                            MelonLogger.Msg($"[WAR ENGINE] War music started: {intro} / {loop}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning($"[WAR ENGINE] War music start: {ex.Message}");
                }

                // 9. Skin the live (vanilla Pales) war table with the Zille map + provinces; kept alive by ZilleWarTable.Tick()
                ZilleWarTable.SkinEnabled = true;
                _theatreEnteredAt = Time.unscaledTime;

                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] Error entering Zille War Theatre: {ex.Message}\n{ex.StackTrace}");
                DialogueHelper.ShowAlert($"[Blad Wojny Zille]: {ex.Message}");
            }
            return false;
        }

        // ================= PERSISTENT THEATRE SYNCHRONIZATION (CALLED EVERY FRAME) =================

        private static float _lastToggleHideTime = 0f;

        public static void UpdateWarTheatreState()
        {
            // The table skin handles its own enable/disable (restores vanilla Pales when disabled).
            ZilleWarTable.Tick();

            if (CurrentTheatre != ActiveWarTheatre.Zille) return;
            try
            {
                if (Time.unscaledTime - _lastToggleHideTime > 2.0f)
                {
                    _lastToggleHideTime = Time.unscaledTime;
                    SetCivilianTogglesVisible(false);
                }

                if (ZilleWarTable.EditMode)
                    ZilleWarTable.SuppressInvasionChrome();
                else if (ZilleWarTable.HasLiveMap)
                    ActivateWarDeploymentPanel();
            }
            catch { }
        }

        private static bool _deploymentOpened;

        private static void ActivateWarDeploymentPanel()
        {
            if (_deploymentOpened) return;
            try
            {
                var deployPanel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (deployPanel == null) deployPanel = UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
                if (deployPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<WarDeploymentPanel>();
                    if (allPanels != null && allPanels.Length > 0) deployPanel = allPanels[0];
                }
                if (deployPanel == null) return;
                if (!deployPanel.gameObject.activeSelf) deployPanel.gameObject.SetActive(true);
                ZilleWarTable.EnsurePlayerPool();
                try { deployPanel.Setup(); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Deployment Setup: " + ex.Message); }
                try { deployPanel.Show(); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Deployment Show: " + ex.Message); }
                var hud = Panels.Instance != null ? Panels.Instance.WarHUDPanel : UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
                if (hud != null && !ZilleWarTable.ScenarioStarted)
                {
                    if (!hud.gameObject.activeSelf) hud.gameObject.SetActive(true);
                    try { hud.Setup(WarHUDPanel.WarHUDButtonState.OperationStart); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Start button setup: " + ex.Message); }
                    try { hud.Show(); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Start button show: " + ex.Message); }
                }
                var portraits = UnityEngine.Object.FindObjectsOfType<PortraitPanel>();
                if (portraits != null)
                {
                    for (int i = 0; i < portraits.Length; i++)
                        if (portraits[i] != null) portraits[i].gameObject.SetActive(false);
                }
                _deploymentOpened = true;
                MelonLogger.Msg("[WAR THEATRE] Pales deployment panel and Start button opened for Zille.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[WAR THEATRE] Deployment panel: " + ex.Message);
            }
        }

        public static void SetCivilianTogglesVisible(bool visible)
        {
            try
            {
                var navPanel = Panels.Instance != null ? Panels.Instance.NavigationPanel : UnityEngine.Object.FindObjectOfType<NavigationPanel>();
                if (navPanel == null) return;
                var toggles = navPanel.instantiatedPanelToggles;
                if (toggles != null)
                {
                    for (int i = 0; i < toggles.Count; i++)
                    {
                        var t = toggles[i];
                        if (t == null) continue;
                        if (t.IsReusableDecreesPanelToggle() || t.IsWarProductionPanelToggle())
                        {
                            t.gameObject.SetActive(visible);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR THEATRE] SetCivilianTogglesVisible({visible}) error: {ex.Message}");
            }
        }

        public static void ReturnToCivilianMap()
        {
            MelonLogger.Msg("[WAR ENGINE] Returning to civilian map...");
            CurrentTheatre = ActiveWarTheatre.Civilian;
            _tilesConfiguredForZille = false;
            _deploymentOpened = false;

            try
            {
                // Restore civilian toggles
                SetCivilianTogglesVisible(true);

                // Restore audio
                try
                {
                    var audioMgr = Managers.Instance?.AudioManager ?? UnityEngine.Object.FindObjectOfType<AudioManager>();
                    if (audioMgr != null)
                    {
                        audioMgr.StopMusic();
                        audioMgr.PlayMapMusic();
                        audioMgr.PlayMapAmbience();
                    }
                }
                catch { }

                // Put the live war table back to vanilla Pales (per-renderer material instances are dropped, tiles restored).
                ZilleWarTable.SkinEnabled = false;
                ZilleWarTable.Restore();

                // Re-enable the Pales operations that SetupCustomZilleOperation switched off, and forget our cached operation
                // (the war map scene objects are destroyed when the base map is loaded again).
                _customOperationConfigured = false;
                _zilleWarOp = null;

                var mapManager = UnityEngine.Object.FindObjectOfType<MapManager>();
                if (mapManager != null)
                {
                    mapManager.LoadMap(MapConfiguration.MapType.Base);
                }

                DialogueHelper.ShowAlert("[Zille] Powrot do mapy cywilnej.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] ReturnToCivilianMap error: {ex.Message}");
            }
        }

        public static void ReturnToCivilianMapWithReport()
        {
            if (CurrentTheatre == ActiveWarTheatre.Civilian && !ZilleWarTable.ScenarioStarted) return;
            MelonLogger.Msg("[WAR ENGINE] ReturnToCivilianMapWithReport triggered.");
            try
            {
                ZilleWarTable.CheckCityVictory(true);
                ReturnToCivilianMap();
                MelonCoroutines.Start(ShowConclusionReportCoroutine());
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] ReturnToCivilianMapWithReport error: {ex.Message}");
            }
        }

        private static System.Collections.IEnumerator ShowConclusionReportCoroutine()
        {
            yield return new WaitForSeconds(1.2f);

            var outcome = ZilleCampaignState.Outcome;
            bool won = outcome == ZilleWarOutcome.DecisiveVictory || outcome == ZilleWarOutcome.OverwhelmingTriumph;

            string title = won
                ? "Operation: Righteous Sword - Victory"
                : "Operation: Righteous Sword - Campaign Conclusion";

            string desc = won
                ? "The Rizian Armed Forces have successfully liberated the territory of Zille! Wehzek garrisons have retreated beyond the border, and royal administration has been re-established over all key districts."
                : "The military operations in Zille have concluded without full territorial control. Casualties and logistics have forced an operational pause, leaving the border contested.";

            try
            {
                var reports = EntityDataManager.ReportsData;
                ReportData rep = null;
                if (reports != null)
                {
                    for (int i = 0; i < reports.Count; i++)
                    {
                        var r = reports[i];
                        if (r != null && (r.NameInDatabase == "Report_Zille_Conclusion" || r.Id == "Report_Zille_Conclusion"))
                        {
                            rep = r;
                            break;
                        }
                    }
                }

                if (rep == null)
                {
                    rep = new ReportData();
                    rep.Id = "Report_Zille_Conclusion";
                    rep.NameInDatabase = "Report_Zille_Conclusion";
                    rep.Path = "Rizia/Reports";
                    rep.ReportProperties = new ReportProperties();
                    rep.AppBundleProperties = CreateRiziaBundleProps();
                    if (reports != null) reports.Add(rep);
                }

                if (rep.ReportProperties != null)
                {
                    rep.ReportProperties.Title = title;
                    rep.ReportProperties.Description = desc;
                    rep.ReportProperties.IsDone = false;
                    rep.ReportProperties.IsNotificationActive = true;
                }

                var reportPanel = Panels.Instance != null ? Panels.Instance.ReportPanel : UnityEngine.Object.FindObjectOfType<ReportPanel>();
                if (reportPanel != null)
                {
                    if (!reportPanel.gameObject.activeSelf) reportPanel.gameObject.SetActive(true);
                    reportPanel.SetupDefault(rep);
                    reportPanel.Show();
                }

                DialogueHelper.ShowAlert($"[{title}]: Sprawdz raport wojenny.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] ShowConclusionReportCoroutine error: {ex.Message}");
                DialogueHelper.ShowAlert($"[Operacja Zille]: {(won ? "Zwyciestwo!" : "Kampania zakonczona.")}");
            }
        }
    }
}
