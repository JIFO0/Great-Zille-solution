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
        private static GameObject _spawnedMaveNortusToken = null;
        private static bool _pendingPhase2TokenSpawn = false;
        private static float _phase2TokenSpawnAt = 0f;
        private static int _phase2MapStepsSeen = 0;

        public static GameObject SpawnedMaveNortusToken => _spawnedMaveNortusToken;
        public static bool PendingPhase2TokenSpawn => _pendingPhase2TokenSpawn;

        public static string GetOperationDisplayName()
        {
            if (ZilleCampaignState.CurrentOperationNumber >= 2
                || ZilleCampaignState.RomulusPlan == ZilleRomulusPlan.TotalRepayment
                || ZilleCampaignState.CurrentVariant == ZilleOperationVariant.TotalRepaymentDerdia
                || ZilleCampaignState.CurrentVariant == ZilleOperationVariant.TotalRepaymentNoDerdia)
                return "Operation: Total Repayment";

            bool isArk = (ZilleCampaignState.PlanType == ZillePlanType.Romulus && ZilleCampaignState.RomulusPlan == ZilleRomulusPlan.Ark)
                      || (ZilleCampaignState.PlanType == ZillePlanType.Staff && ZilleCampaignState.StaffPlan == ZilleStaffPlan.Ark)
                      || ZilleCampaignState.CurrentVariant == ZilleOperationVariant.PlanArk
                      || ZilleCampaignState.CurrentVariant == ZilleOperationVariant.PlanArkDerdia;
            return isArk ? "Operation: Golden Ark" : "Operation: Righteous Sword";
        }
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
                        DialogueHelper.SetVariable("RiziaDLC.ZilleReturn_Success", false);
                        DialogueHelper.SetVariable("RiziaDLC.ZilleReferendum_Lost", true);
                        DialogueHelper.SetVariable("Brenas_Lost_To_Wehlen", true);
                        DialogueHelper.SetVariable("RiziaDLC.Azaro_HasPowerToCoup", true);
                        break;
                    case ZilleWarOutcome.TacticalDefeat:
                        DialogueHelper.SetVariable("RiziaDLC.ZilleReturn_Success", false);
                        DialogueHelper.SetVariable("RiziaDLC.ZilleReferendum_Lost", true);
                        break;
                    case ZilleWarOutcome.BloodyStalemate:
                        DialogueHelper.SetVariable("RiziaDLC.ZilleReturn_Success", false);
                        DialogueHelper.SetVariable("Zille_Stalemate", true);
                        break;
                    case ZilleWarOutcome.DecisiveVictory:
                        DialogueHelper.SetVariable("RiziaDLC.ZilleReturn_Success", true);
                        DialogueHelper.SetVariable("RiziaDLC.Zille_PromisedToHouseToras", true);
                        DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Wehlen_Hostile", true);
                        DialogueHelper.SetVariable("RiziaDLC.MapLayer_Zille_Brenas", true);
                        break;
                    case ZilleWarOutcome.OverwhelmingTriumph:
                        DialogueHelper.SetVariable("RiziaDLC.ZilleReturn_Success", true);
                        DialogueHelper.SetVariable("RiziaDLC.Zille_PromisedToHouseToras", true);
                        DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Wehlen_Hostile", true);
                        DialogueHelper.SetVariable("RiziaDLC.MapLayer_Zille_Brenas", true);
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
            ZilleCampaignState.SyncFromLua();
            int score = 0;
            int equipBonus = 0;
            try
            {
                int pp = DialogueHelper.GetIntVariable("Country_Military_PowerProjection");
                int equipment = DialogueHelper.GetIntVariable("Resources_Military_Equipment");
                int energy = DialogueHelper.GetIntVariable("Resources_Energy");

                score += pp;
                // Vanilla Rizia military equipment scale: <500 critical deficit, <1000 low, 1000-2499 adequate, 2500-4999 strong, >=5000 overflowing
                if (equipment >= 5000) equipBonus = 4;
                else if (equipment >= 2500) equipBonus = 3;
                else if (equipment >= 1000) equipBonus = 2;
                else if (equipment >= 500) equipBonus = 0;
                else equipBonus = -2;
                score += equipBonus;

                if (energy <= 1) score -= 2;
                else if (energy >= 5) score += 1;

                switch (plan)
                {
                    case ZilleStaffPlan.Hawk:
                        if (DialogueHelper.GetBoolVariable("Policy_RD_Order_BomberPlaneFactory_Completed")
                            || DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Bomber_Total") >= 1) score += 2;
                        if (energy >= 3) score += 1;
                        break;
                    case ZilleStaffPlan.Sword:
                        if (DialogueHelper.GetIntVariable("Army_Unit_Tank_Total") >= 2) score += 2;
                        if (!DialogueHelper.GetBoolVariable("Country_HouseAzaro_Enemy")) score += 1;
                        break;
                    case ZilleStaffPlan.Ark:
                        int fleet = DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Ship_Total")
                                  + DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Flagship_Total")
                                  + DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Submarine_Total");
                        if (fleet >= 2) score += 2;
                        else score -= 3; // Attempting maritime envelopment without a fleet carries steep penalties
                        if (ZilleCampaignState.IsNavalBlockadeActive) score += 1;
                        break;
                    case ZilleStaffPlan.Spear:
                        if (DialogueHelper.GetBoolVariable("Policy_Order_GoldenGuard_Expanded")
                            || DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_GoldenGuard_Total") >= 1) score += 2;
                        if (DialogueHelper.GetBoolVariable("Policy_RD_Order_BuildMaveNortusIntelHub_Completed")) score += 1;
                        break;
                }

                string logistics = DialogueHelper.GetStringVariable("Zille_Logistics_Route");
                if (string.IsNullOrEmpty(logistics)) logistics = DialogueHelper.GetStringVariable("Zille_Logistics_House");
                if (string.IsNullOrEmpty(logistics)) logistics = DialogueHelper.GetStringVariable("Zille_War_Logistics");
                if (logistics == "Sazon" || logistics == "Azaro" || logistics == "Compromise") score += 1;

                if (ZilleCampaignState.IsLespiaPactAccepted || ZilleCampaignState.IsLespiaIntelActive) score += 2;
                if (ZilleCampaignState.IsDerdiaHybridSupportActive) score += 1;
                if (ZilleCampaignState.IsRumburgMunitionsActive) score += 1;

                // Micro-effects accumulated across dialogues contribute directly to operational planning
                score += Math.Max(-2, Math.Min(4, ZilleCampaignState.WarReadinessScore / 2));
                score += Math.Max(-2, Math.Min(3, ZilleCampaignState.LeverageScore / 3));

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

            // Record isolated Zille staff casualties without touching Pales ledgers
            int estPlayerLost = outcome == ZilleWarOutcome.OverwhelmingTriumph ? 1
                              : outcome == ZilleWarOutcome.DecisiveVictory ? 2
                              : outcome == ZilleWarOutcome.BloodyStalemate ? 3
                              : outcome == ZilleWarOutcome.TacticalDefeat ? 4 : 6;
            if (equipBonus < 0) estPlayerLost += 1;
            if (ZilleCampaignState.IsTwoFrontWarThreat()) estPlayerLost += 1;
            int estEnemyLost = outcome == ZilleWarOutcome.OverwhelmingTriumph ? 6
                             : outcome == ZilleWarOutcome.DecisiveVictory ? 5
                             : outcome == ZilleWarOutcome.BloodyStalemate ? 3 : 1;
            ZilleCampaignState.RecordZilleLosses(phase, estPlayerLost, estEnemyLost);

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
                DialogueHelper.SetVariable("RiziaDLC.ZilleReturn_Success", true);
                DialogueHelper.SetVariable("RiziaDLC.Zille_PromisedToHouseToras", true);
                DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Wehlen_Hostile", true);
                DialogueHelper.SetVariable("RiziaDLC.MapLayer_Zille_Brenas", true);
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
                DialogueHelper.SetVariable("RiziaDLC.ZilleReturn_Success", false);
                DialogueHelper.SetVariable("RiziaDLC.ZilleReferendum_Lost", true);
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

                // Register all custom Great Zille scenes in EntityDataManager
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarPlanning", "Turn_Zille_WarPlanning", "Emergency Crown Council: The Fate of Zille", "Council Chamber, Palas Rezna", "Zille/WarPlanning");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarBalconySpeech", "Turn_Zille_WarBalconySpeech", "A Royal Proclamation of War", "Palas Rezna Balcony", "Zille/WarBalconySpeech");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarLogisticsDispute", "Turn_Zille_WarLogisticsDispute", "Supply Lines of Brenas: Azaro vs Sazon", "Ministry of War, Porte Drazon", "Zille/WarLogisticsDispute");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_MaveNortusHQ", "Turn_Zille_MaveNortusHQ", "Frontline Headquarters: The Battle for Zille", "Mayor's Hall, Mave Nortus", "Zille/MaveNortusHQ");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_Op1AftermathCouncil", "Turn_Zille_Op1AftermathCouncil", "Post-Operation I High Command Council", "War Room, Palas Rezna", "Zille/Op1AftermathCouncil");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_DerdiaInvestigation", "Turn_Zille_DerdiaInvestigation", "Derdia-Wehlen Border: Sabotage Inquiry", "Golden Guard Briefing Room", "Zille/DerdiaInvestigation");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_DerdiaTalks", "Turn_Zille_DerdiaTalks", "Derdian Mission: The Yol-Qerzan Sabotage", "Telecommunications Chamber, Palas Rezna", "Zille/DerdiaTalks");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_DerdiaStateVisit", "Turn_Zille_DerdiaStateVisit", "State Visit to Derdia: Silver Garrison", "Silver Garrison, Naeal", "Zille/DerdiaStateVisit");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_LespiaTalks", "Turn_Zille_LespiaTalks", "Lespian Diplomatic Hotline: Air Recon and Munitions", "Foreign Ministry Communications Room", "Zille/LespiaTalks");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_RumburgTalks", "Turn_Zille_RumburgTalks", "Imperial Telegram from Thornbourgh: Rumburgian Munitions", "Imperial Diplomatic Cabinet", "Zille/RumburgTalks");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarPreNegotiations", "Turn_Zille_WarPreNegotiationsBriefing", "Pre-Negotiations Briefing & Foreign Hotlines", "War Room & Communications Cabinet", "Zille/WarPreNegotiationsBriefing");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarSmolakParley", "Turn_Zille_WarSmolakFinalParley", "Frontline Parley with Wiktor Smolak", "Neutral Military Pavilion, Zille Border", "Zille/WarSmolakFinalParley");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty", "The Treaty of Zille", "Treaty Pavilion", "Zille/WarPeaceTreaty");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_HomeFrontCrisis", "Turn_Zille_HomeFrontCrisis", "Wartime Home Front: Energy & AN Pressure", "Cabinet Room, Palas Rezna", "Zille/HomeFrontCrisis");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_ZilleLiberation", "Turn_Zille_ZilleLiberation", "Homecoming in Zille City: The Harbor Quarter", "Zille City Harbor", "Zille/ZilleLiberation");
                RegisterAdditionalConversationData(allConvList, "Conv_Zille_ExileEpilogue", "Turn_Zille_ExileEpilogue", "Exile in Kyrute: The Shattered Kingdom", "Konstantium & Kyrute Airport", "Zille/ExileEpilogue");

                ZilleReportsAndSituations.EnsureRegisteredAndSynced();

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

                // 6. Enforce accurate mandatory story fragment gating (so only currently unlocked steps gate Next Turn)
                SyncMandatoryStoryFragmentsFromState();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] RegisterNativeZilleEntities error: {ex.Message}");
            }
        }

        public static void SetStoryFragmentMandatoryState(string fragmentNameOrTitle, bool isMandatoryActive)
        {
            if (string.IsNullOrEmpty(fragmentNameOrTitle)) return;
            try
            {
                ConversationData targetConv = null;
                WarFragmentData targetWar = null;

                var allConv = GetEntityBackingList<ConversationData>("conversationsData") ?? EntityDataManager.AllConversationsData ?? EntityDataManager.ConversationsData;
                if (allConv != null)
                {
                    for (int i = 0; i < allConv.Count; i++)
                    {
                        var c = allConv[i];
                        if (c == null) continue;
                        if (c.NameInDatabase == fragmentNameOrTitle || c.Id == fragmentNameOrTitle || c.ConversationProperties?.Dialogue == fragmentNameOrTitle)
                        {
                            targetConv = c;
                            break;
                        }
                    }
                }

                if (targetConv == null)
                {
                    var allWar = GetEntityBackingList<WarFragmentData>("warFragmentsData") ?? EntityDataManager.AllWarFragmentsData;
                    if (allWar != null)
                    {
                        for (int i = 0; i < allWar.Count; i++)
                        {
                            var w = allWar[i];
                            if (w != null && (w.NameInDatabase == fragmentNameOrTitle || w.Id == fragmentNameOrTitle))
                            {
                                targetWar = w;
                                break;
                            }
                        }
                    }
                }

                if (targetConv?.StoryFragmentProperties != null)
                {
                    targetConv.StoryFragmentProperties.IsDone = !isMandatoryActive;
                }
                if (targetWar?.StoryFragmentProperties != null)
                {
                    targetWar.StoryFragmentProperties.IsDone = !isMandatoryActive;
                }

                StoryFragmentData target = (StoryFragmentData)targetConv ?? targetWar;
                if (target == null) return;

                var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                if (gfm != null)
                {
                    var enabledA = gfm.GetEnabledNotDoneStoryFragments();
                    var enabledB = gfm.enabledNotDoneStoryFragments;
                    if (isMandatoryActive)
                    {
                        if (enabledA != null && !enabledA.Contains(target)) enabledA.Add(target);
                        if (enabledB != null && !enabledB.Contains(target)) enabledB.Add(target);
                    }
                    else
                    {
                        if (enabledA != null && enabledA.Contains(target)) enabledA.Remove(target);
                        if (enabledB != null && enabledB.Contains(target)) enabledB.Remove(target);
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] SetStoryFragmentMandatoryState({fragmentNameOrTitle}, {isMandatoryActive}) error: {ex.Message}");
            }
        }

        public static void ClearAllMandatoryZilleFragments()
        {
            string[] zilleFragments = new[]
            {
                "Turn_Zille_WarPlanning",
                "Turn_Zille_WarLogisticsDispute",
                "Turn_Zille_WarBriefing",
                "Turn_Zille_MaveNortusHQ",
                "Turn_Zille_Op1AftermathCouncil",
                "Turn_Zille_WarPreNegotiationsBriefing",
                "Turn_Zille_WarSmolakFinalParley",
                "Turn_Zille_WarPeaceTreaty",
                "Turn_Zille_ExileEpilogue",
                "WarFragment_Zille_1_1"
            };
            for (int i = 0; i < zilleFragments.Length; i++)
            {
                SetStoryFragmentMandatoryState(zilleFragments[i], false);
            }
        }

        public static void SyncMandatoryStoryFragmentsFromState()
        {
            bool treatySigned = DialogueHelper.GetBoolVariable("Zille_PeaceTreaty_Signed") || DialogueHelper.GetBoolVariable("Zille_Rep_TreatyDone");
            bool exileCollapse = DialogueHelper.GetBoolVariable("Zille_Azaro_Coup_Collapse") || DialogueHelper.GetBoolVariable("Zille_Parley_Refused");
            if (treatySigned || (exileCollapse && DialogueHelper.GetBoolVariable("Zille_ExileEpilogue_Done")))
            {
                ClearAllMandatoryZilleFragments();
                return;
            }

            bool warActive = DialogueHelper.GetBoolVariable("Zille_War_Active");
            bool planningDone = DialogueHelper.GetBoolVariable("Zille_War_Planning_Done");
            bool earlyWar = DialogueHelper.GetBoolVariable("Zille_War_EarlyLaunch");

            SetStoryFragmentMandatoryState("Turn_Zille_WarBriefing", (planningDone || earlyWar) && !warActive && ZilleCampaignState.CurrentPhase == ZilleOperationPhase.NotStarted);
            SetStoryFragmentMandatoryState("Turn_Zille_MaveNortusHQ", ZilleCampaignState.MaveNortusHQAvailable && !ZilleCampaignState.MaveNortusHQCompleted);
            SetStoryFragmentMandatoryState("Turn_Zille_Op1AftermathCouncil", ZilleCampaignState.Op1CouncilAvailable && !ZilleCampaignState.Op1CouncilCompleted);

            bool warTokenRequired = warActive
                && !ZilleCampaignState.MaveNortusHQAvailable
                && !ZilleCampaignState.Op1CouncilAvailable
                && (ZilleCampaignState.CurrentOperationNumber >= 2 || ZilleCampaignState.CurrentPhaseNumber == 1 || ZilleCampaignState.Phase2EventUnlocked);
            SetStoryFragmentMandatoryState("WarFragment_Zille_1_1", warTokenRequired);
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

        public static void SuppressPalesWarMarker()
        {
            try
            {
                var allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
                if (allObjs == null) return;
                for (int i = 0; i < allObjs.Length; i++)
                {
                    var go = allObjs[i];
                    if (go == null || !go.scene.IsValid()) continue;
                    string n = go.name;
                    if (n.Contains("InvasionOfPales") || (n.Contains("Pales") && n.Contains("Event Variant")))
                    {
                        if (go.activeSelf)
                        {
                            go.SetActive(false);
                            MelonLogger.Msg($"[WAR SHADOW] Suppressed Pales war marker: '{go.name}' at {go.transform.position}.");
                        }
                        var rends = go.GetComponentsInChildren<Renderer>(true);
                        for (int r = 0; r < rends.Length; r++)
                        {
                            if (rends[r] != null && rends[r].enabled)
                            {
                                rends[r].enabled = false;
                            }
                        }
                    }
                    else if (n.Contains("Pales") && n.ToLowerInvariant().Contains("shadow"))
                    {
                        if (go.activeSelf) go.SetActive(false);
                        var rends = go.GetComponentsInChildren<Renderer>(true);
                        for (int r = 0; r < rends.Length; r++)
                            if (rends[r] != null && rends[r].enabled) rends[r].enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[WAR SHADOW] SuppressPalesWarMarker: " + ex.Message);
            }
        }

        public static void SuppressZilleWarEventToken()
        {
            try
            {
                if (_spawnedZilleWarToken == null)
                    _spawnedZilleWarToken = GameObject.Find("InvasionOfZille Event Variant");
                if (_spawnedZilleWarToken != null && _spawnedZilleWarToken.activeSelf)
                {
                    _spawnedZilleWarToken.SetActive(false);
                    var rends = _spawnedZilleWarToken.GetComponentsInChildren<Renderer>(true);
                    for (int r = 0; r < rends.Length; r++)
                        if (rends[r] != null) rends[r].enabled = false;
                    MelonLogger.Msg("[WAR ENGINE] Hid completed Phase I InvasionOfZille event token.");
                }
                var zShadow = GameObject.Find("InvasionOfZille Shadow");
                if (zShadow != null && zShadow.activeSelf) zShadow.SetActive(false);
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[WAR ENGINE] SuppressZilleWarEventToken: " + ex.Message);
            }
        }

        public static void SuppressMaveNortusHQEventToken()
        {
            try
            {
                if (_spawnedMaveNortusToken == null)
                    _spawnedMaveNortusToken = GameObject.Find("MaveNortusHQ Event Variant");
                if (_spawnedMaveNortusToken != null && _spawnedMaveNortusToken.activeSelf)
                {
                    _spawnedMaveNortusToken.SetActive(false);
                    var rends = _spawnedMaveNortusToken.GetComponentsInChildren<Renderer>(true);
                    for (int r = 0; r < rends.Length; r++)
                        if (rends[r] != null) rends[r].enabled = false;
                    MelonLogger.Msg("[WAR ENGINE] Hid Mave Nortus Field HQ event token.");
                }
                var mShadow = GameObject.Find("MaveNortusHQ Shadow");
                if (mShadow != null && mShadow.activeSelf) mShadow.SetActive(false);
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[WAR ENGINE] SuppressMaveNortusHQEventToken: " + ex.Message);
            }
        }

        public static bool SpawnMaveNortusHQEventToken()
        {
            RegisterNativeZilleEntities();
            SuppressPalesWarMarker();
            SuppressZilleWarEventToken();

            try
            {
                // Register MapTokenData for Mave Nortus HQ if absent
                var allTokenList = GetEntityBackingList<MapTokenData>("mapTokensData") ?? EntityDataManager.MapTokensData;
                MapTokenData maveMtd = null;
                if (allTokenList != null)
                {
                    for (int i = 0; i < allTokenList.Count; i++)
                    {
                        var t = allTokenList[i];
                        if (t != null && t.NameInDatabase == "Rizia_Event_MaveNortusHQ")
                        {
                            maveMtd = t;
                            break;
                        }
                    }
                    if (maveMtd == null)
                    {
                        maveMtd = new MapTokenData();
                        maveMtd.Id = "Rizia_Event_MaveNortusHQ";
                        maveMtd.NameInDatabase = "Rizia_Event_MaveNortusHQ";
                        maveMtd.Path = "Rizia/Tokens";
                        maveMtd.IsWIP = false;
                        maveMtd.Notes = "";
                        maveMtd.MapTokenProperties = new MapTokenProperties();
                        maveMtd.MapTokenProperties.Title = "Mave Nortus Field HQ";
                        maveMtd.MapTokenProperties.Subtitle = "Post-Phase I Council";
                        maveMtd.MapTokenProperties.ImagePath = "";
                        maveMtd.MapTokenProperties.SoundEffect = "";
                        maveMtd.MapTokenProperties.Type = "Event";
                        maveMtd.MapTokenProperties.IsTokenEnabled = true;
                        maveMtd.StatusEffectsProperties = new StatusEffectsProperties();
                        maveMtd.StatusEffectsProperties.HasNewStatusEffect = false;
                        maveMtd.StatusEffectsProperties.StatusEffects = new Il2CppSystem.Collections.Generic.List<string>();
                        maveMtd.StatusEffectsProperties.ConditionalStatusEffectGroups = new Il2CppSystem.Collections.Generic.List<string>();
                        maveMtd.DescriptionProperties = new DescriptionProperties();
                        maveMtd.DescriptionProperties.Description = "Frontline Headquarters at Mave Nortus following Phase I.";
                        maveMtd.AppBundleProperties = CreateRiziaBundleProps();
                        allTokenList.Add(maveMtd);
                    }
                }

                var maveCity = FindCityToken("mave") ?? FindCityToken("nortus") ?? FindCityToken("bronaz");
                Vector3 mavePos = maveCity != null
                    ? maveCity.transform.position + new Vector3(0.03f, 0f, -0.02f)
                    : BorderEventPosition() + new Vector3(-0.04f, 0f, -0.06f);

                if (_spawnedMaveNortusToken == null)
                {
                    _spawnedMaveNortusToken = GameObject.Find("MaveNortusHQ Event Variant");
                    if (_spawnedMaveNortusToken == null)
                    {
                        var allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
                        for (int i = 0; i < allObjs.Length; i++)
                        {
                            if (allObjs[i] != null && allObjs[i].name == "MaveNortusHQ Event Variant")
                            {
                                _spawnedMaveNortusToken = allObjs[i];
                                break;
                            }
                        }
                    }
                }

                if (_spawnedMaveNortusToken == null)
                {
                    GameObject template = _spawnedZilleWarToken ?? GameObject.Find("InvasionOfPales Event Variant");
                    if (template == null)
                    {
                        var allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
                        for (int i = 0; i < allObjs.Length; i++)
                        {
                            if (allObjs[i] != null && (allObjs[i].name == "InvasionOfPales Event Variant" || allObjs[i].name == "InvasionOfZille Event Variant"))
                            {
                                template = allObjs[i];
                                break;
                            }
                        }
                    }

                    if (template != null)
                    {
                        Transform parent = template.transform.parent;
                        _spawnedMaveNortusToken = UnityEngine.Object.Instantiate(template, parent);
                        _spawnedMaveNortusToken.name = "MaveNortusHQ Event Variant";
                        _spawnedMaveNortusToken.transform.position = mavePos;
                        _spawnedMaveNortusToken.transform.rotation = template.transform.rotation;
                        _spawnedMaveNortusToken.transform.localScale = template.transform.localScale;
                        _spawnedMaveNortusToken.layer = template.layer;
                        var allTrans = _spawnedMaveNortusToken.GetComponentsInChildren<Transform>(true);
                        for (int i = 0; i < allTrans.Length; i++)
                        {
                            if (allTrans[i] != null) allTrans[i].gameObject.layer = template.layer;
                        }
                    }
                }

                if (_spawnedMaveNortusToken != null)
                {
                    _spawnedMaveNortusToken.transform.position = mavePos;
                    _spawnedMaveNortusToken.SetActive(true);
                    MatchTokenHeight(_spawnedMaveNortusToken, maveCity ?? _borderAnchor);

                    var tok = _spawnedMaveNortusToken.GetComponent<Token>();
                    if (tok != null)
                    {
                        tok.tokenDataEntityName = "Rizia_Event_MaveNortusHQ";
                        tok.tokenType = Token.TokenType.Event;
                        if (maveMtd != null) tok.tokenData = maveMtd;
                        tok.gameObject.SetActive(true);
                        tok.Setup();
                        if (Managers.Instance?.Tokens != null && !Managers.Instance.Tokens.Contains(tok))
                            Managers.Instance.Tokens.Add(tok);
                    }

                    var rends = _spawnedMaveNortusToken.GetComponentsInChildren<Renderer>(true);
                    for (int r = 0; r < rends.Length; r++)
                    {
                        if (rends[r] != null)
                        {
                            rends[r].enabled = true;
                            rends[r].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                            rends[r].receiveShadows = true;
                        }
                    }

                    SetStoryFragmentMandatoryState("Turn_Zille_MaveNortusHQ", true);
                    SetStoryFragmentMandatoryState("WarFragment_Zille_1_1", false);
                    MelonLogger.Msg($"[WAR ENGINE] Spawned Mave Nortus Field HQ event token at {mavePos} (city ref: {maveCity?.name ?? "fallback"}).");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] SpawnMaveNortusHQEventToken error: {ex.Message}");
            }
            return false;
        }

        private static GameObject _spawnedDerdiaVisitToken = null;

        public static void SuppressDerdiaVisitEventToken()
        {
            try
            {
                if (_spawnedDerdiaVisitToken == null)
                    _spawnedDerdiaVisitToken = GameObject.Find("DerdiaVisit Event Variant");
                if (_spawnedDerdiaVisitToken != null && _spawnedDerdiaVisitToken.activeSelf)
                {
                    _spawnedDerdiaVisitToken.SetActive(false);
                }
            }
            catch { }
        }

        public static bool SpawnDerdiaVisitEventToken()
        {
            try
            {
                if (CurrentTheatre != ActiveWarTheatre.Civilian) return false;
                if (DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitDone") || ZilleCampaignState.IsDerdiaStateVisitDone)
                    return false;

                var allTokenList = GetEntityBackingList<MapTokenData>("mapTokensData") ?? EntityDataManager.MapTokensData;
                MapTokenData derdiaMtd = null;
                if (allTokenList != null)
                {
                    for (int i = 0; i < allTokenList.Count; i++)
                    {
                        var t = allTokenList[i];
                        if (t != null && t.NameInDatabase == "Rizia_Event_DerdiaVisit") { derdiaMtd = t; break; }
                    }
                    if (derdiaMtd == null)
                    {
                        derdiaMtd = new MapTokenData();
                        derdiaMtd.Id = "Rizia_Event_DerdiaVisit";
                        derdiaMtd.NameInDatabase = "Rizia_Event_DerdiaVisit";
                        derdiaMtd.Path = "Rizia/MapTokens/Events";
                        derdiaMtd.IsWIP = false;
                        derdiaMtd.Notes = "";
                        derdiaMtd.MapTokenProperties = new MapTokenProperties();
                        derdiaMtd.MapTokenProperties.Title = "State Visit: Derdia";
                        derdiaMtd.MapTokenProperties.Subtitle = "Silver Garrison Alliance Talks";
                        derdiaMtd.MapTokenProperties.ImagePath = "";
                        derdiaMtd.MapTokenProperties.SoundEffect = "";
                        derdiaMtd.MapTokenProperties.Type = "Event";
                        derdiaMtd.MapTokenProperties.IsTokenEnabled = true;
                        derdiaMtd.AppBundleProperties = CreateRiziaBundleProps();
                        allTokenList.Add(derdiaMtd);
                    }
                }

                // Position near northern/western border toward Derdia (near Naeal / Zille border)
                var derdiaRef = FindCityToken("derdia") ?? FindCityToken("naeal") ?? FindCityToken("yol") ?? FindCityToken("mave") ?? _borderAnchor;
                Vector3 visitPos = derdiaRef != null
                    ? derdiaRef.transform.position + new Vector3(-0.08f, 0f, 0.08f)
                    : BorderEventPosition() + new Vector3(-0.12f, 0f, 0.12f);

                if (_spawnedDerdiaVisitToken == null)
                    _spawnedDerdiaVisitToken = GameObject.Find("DerdiaVisit Event Variant");
                if (_spawnedDerdiaVisitToken == null)
                {
                    GameObject template = _spawnedZilleWarToken ?? GameObject.Find("InvasionOfPales Event Variant");
                    if (template == null)
                    {
                        var allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
                        for (int i = 0; i < allObjs.Length; i++)
                        {
                            if (allObjs[i] != null && allObjs[i].name == "InvasionOfPales Event Variant")
                            {
                                template = allObjs[i];
                                break;
                            }
                        }
                    }
                    if (template != null)
                    {
                        Transform parent = template.transform.parent;
                        _spawnedDerdiaVisitToken = UnityEngine.Object.Instantiate(template, parent);
                        _spawnedDerdiaVisitToken.name = "DerdiaVisit Event Variant";
                        _spawnedDerdiaVisitToken.transform.position = visitPos;
                        _spawnedDerdiaVisitToken.transform.rotation = template.transform.rotation;
                        _spawnedDerdiaVisitToken.transform.localScale = template.transform.localScale;
                        _spawnedDerdiaVisitToken.layer = template.layer;
                        var allTrans = _spawnedDerdiaVisitToken.GetComponentsInChildren<Transform>(true);
                        for (int i = 0; i < allTrans.Length; i++)
                            if (allTrans[i] != null) allTrans[i].gameObject.SetActive(true);
                    }
                }

                if (_spawnedDerdiaVisitToken != null)
                {
                    _spawnedDerdiaVisitToken.transform.position = visitPos;
                    _spawnedDerdiaVisitToken.SetActive(true);
                    MatchTokenHeight(_spawnedDerdiaVisitToken, derdiaRef ?? _borderAnchor);
                    var tok = _spawnedDerdiaVisitToken.GetComponent<Token>();
                    if (tok != null)
                    {
                        tok.enabled = true;
                        tok.tokenDataEntityName = "Rizia_Event_DerdiaVisit";
                        if (derdiaMtd != null) tok.tokenData = derdiaMtd;
                        tok.Setup();
                        if (Managers.Instance?.Tokens != null && !Managers.Instance.Tokens.Contains(tok))
                            Managers.Instance.Tokens.Add(tok);
                    }
                    var rends = _spawnedDerdiaVisitToken.GetComponentsInChildren<Renderer>(true);
                    for (int r = 0; r < rends.Length; r++)
                        if (rends[r] != null) rends[r].enabled = true;

                    MelonLogger.Msg($"[WAR ENGINE] Spawned Derdia State Visit event token at {visitPos}.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] SpawnDerdiaVisitEventToken error: {ex.Message}");
            }
            return false;
        }

        public static void PreparePostPhase1CivilianEvents()
        {
            if (CurrentTheatre != ActiveWarTheatre.Civilian) return;
            SuppressPalesWarMarker();

            bool warConcludedByNegotiation = DialogueHelper.GetBoolVariable("Zille_PeaceTreaty_Signed")
                || DialogueHelper.GetBoolVariable("Zille_Negotiations_Done");
            bool warActive = DialogueHelper.GetBoolVariable("Zille_War_Active")
                || ZilleCampaignState.CurrentPhase != ZilleOperationPhase.NotStarted;

            if (warConcludedByNegotiation)
            {
                SuppressZilleWarEventToken();
                SuppressMaveNortusHQEventToken();
                return;
            }

            if (ZilleCampaignState.Phase1Finished && !ZilleCampaignState.MaveNortusHQCompleted)
            {
                if (_spawnedMaveNortusToken == null || !_spawnedMaveNortusToken.activeInHierarchy)
                {
                    SpawnMaveNortusHQEventToken();
                }
            }
            else if (ZilleCampaignState.MaveNortusHQCompleted)
            {
                SuppressMaveNortusHQEventToken();
            }

            // Keep the Zille Invasion marker permanently active on the map until negotiations conclude!
            if (warActive && (_spawnedZilleWarToken == null || !_spawnedZilleWarToken.activeInHierarchy))
            {
                SpawnZilleWarEventToken();
            }
        }

        public static void NotifyCivilianStepProgressed()
        {
            if (!_pendingPhase2TokenSpawn) return;
            _phase2MapStepsSeen++;
            if (_phase2MapStepsSeen >= 1 && CurrentTheatre == ActiveWarTheatre.Civilian)
            {
                SpawnPhase2WarEventTokenNow();
            }
        }

        public static void SpawnPhase2WarEventTokenNow()
        {
            _pendingPhase2TokenSpawn = false;
            if (ZilleCampaignState.CurrentOperationNumber <= 1)
            {
                ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2;
            }
            else
            {
                ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2_TotalRepayment;
            }
            ZilleCampaignState.CurrentPhaseNumber = 2;
            ZilleCampaignState.Phase2EventUnlocked = true;
            ZilleCampaignState.SyncToLua();

            SuppressMaveNortusHQEventToken();

            // Refresh titles & re-arm WarFragment_Zille_1_1 so Token.Setup keeps the Phase II event alive!
            string opTitle = $"{GetOperationDisplayName()} - Phase II";
            RearmZilleWarFragment(opTitle, ZilleCampaignState.CurrentOperationNumber >= 2 ? "Total Repayment - Phase II" : "Phase II Offensive");

            SpawnZilleWarEventToken();
            DialogueHelper.ShowAlert($"[Zille] Regrouping complete! {opTitle} is now open on the Zille border.");
            MelonLogger.Msg($"[WAR ENGINE] Phase II event spawned at BorderEventPosition ({opTitle}).");
        }

        private static void RearmZilleWarFragment(string opTitle, string subtitle)
        {
            try
            {
                var allWar = GetEntityBackingList<WarFragmentData>("warFragmentsData") ?? EntityDataManager.AllWarFragmentsData;
                if (allWar != null)
                {
                    for (int i = 0; i < allWar.Count; i++)
                    {
                        var wfd = allWar[i];
                        if (wfd != null && wfd.NameInDatabase == "WarFragment_Zille_1_1")
                        {
                            if (wfd.WarFragmentProperties != null)
                            {
                                wfd.WarFragmentProperties.HubWarFragmentTitle = opTitle;
                                wfd.WarFragmentProperties.HubWarFragmentSubtitle = subtitle;
                            }
                            if (wfd.StoryFragmentProperties != null)
                            {
                                wfd.StoryFragmentProperties.IsDone = false;
                            }
                            var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                            if (gfm != null)
                            {
                                var enabledFrags = gfm.GetEnabledNotDoneStoryFragments();
                                if (enabledFrags != null && !enabledFrags.Contains(wfd))
                                    enabledFrags.Add(wfd);
                                if (gfm.enabledNotDoneStoryFragments != null && !gfm.enabledNotDoneStoryFragments.Contains(wfd))
                                    gfm.enabledNotDoneStoryFragments.Add(wfd);
                            }
                            break;
                        }
                    }
                }
                var allOps = GetEntityBackingList<OperationData>("operationData") ?? EntityDataManager.OperationData;
                if (allOps != null)
                {
                    for (int i = 0; i < allOps.Count; i++)
                    {
                        var op = allOps[i];
                        if (op != null && (op.NameInDatabase == "Operation_Zille_1" || op.Id == "Operation_Zille_1") && op.OperationProperties != null)
                        {
                            op.OperationProperties.OperationName = opTitle;
                            op.OperationProperties.IsFinished = false;
                            break;
                        }
                    }
                }
            }
            catch { }
        }

        public static void StartTotalRepaymentOperation()
        {
            ZilleCampaignState.TransitionToTotalRepayment();
            ZilleCampaignState.MaveNortusHQAvailable = false;
            ZilleCampaignState.MaveNortusHQCompleted = true;
            ZilleCampaignState.Phase2EventUnlocked = true;
            ZilleCampaignState.SyncToLua();

            SuppressMaveNortusHQEventToken();
            string opTitle = "Operation: Total Repayment - Phase I";
            RearmZilleWarFragment(opTitle, "Full-Scale Counter-Offensive");
            SpawnZilleWarEventToken();
            DialogueHelper.ShowAlert("[Zille High Command] Operation: Total Repayment is now active at the Zille border!");
            MelonLogger.Msg("[WAR ENGINE] Started Operation 2: Operation: Total Repayment.");
        }

        public static bool IsOp1NegotiationsEligible(ZilleWarOutcome outcome)
        {
            if (outcome == ZilleWarOutcome.TotalFiasco) return true;
            bool brenasSafe = !ZilleCampaignState.IsBrenasLost && DialogueHelper.GetIntVariable("Zille_Brenas_Lost") == 0;
            bool swordVictory = ZilleCampaignState.CapZilleCity && (ZilleCampaignState.CapWiktrany || ZilleCampaignState.CapMunat || ZilleCampaignState.CapNanta) && brenasSafe;
            bool arkLeverage = ZilleCampaignState.CapGrodzizg && (ZilleCampaignState.CapKratsna || ZilleCampaignState.CapIsor || ZilleCampaignState.ZilleEnemyUnitsLostTotal >= 6);
            return swordVictory || arkLeverage || outcome >= ZilleWarOutcome.DecisiveVictory;
        }

        public static void ResolvePostOperation1Flow(ZilleWarOutcome outcome, string summary)
        {
            if (CurrentTheatre != ActiveWarTheatre.Civilian) ReturnToCivilianMap();
            bool eligible = IsOp1NegotiationsEligible(outcome);
            DialogueHelper.SetVariable("Zille_Op1_NegotiationsEligible", eligible);
            DialogueHelper.SetVariable("Zille_Negotiate_After_Op1", false);
            DialogueHelper.SetVariable("Zille_Launch_TotalRepayment", false);
            ZilleCampaignState.Op1CouncilAvailable = true;
            ZilleCampaignState.Op1CouncilCompleted = false;
            ZilleCampaignState.SyncToLua();
            SetStoryFragmentMandatoryState("Turn_Zille_Op1AftermathCouncil", true);
            SetStoryFragmentMandatoryState("WarFragment_Zille_1_1", false);

            MelonLogger.Msg($"[WAR ENGINE] ResolvePostOperation1Flow: outcome={outcome}, eligible={eligible}. Launching Op1AftermathCouncil...");
            TriggerConversation("Turn_Zille_Op1AftermathCouncil", "Zille/Op1AftermathCouncil", () =>
            {
                ZilleCampaignState.Op1CouncilCompleted = true;
                ZilleCampaignState.Op1CouncilAvailable = false;
                SetStoryFragmentMandatoryState("Turn_Zille_Op1AftermathCouncil", false);
                ZilleCampaignState.SyncFromLua();

                if (DialogueHelper.GetBoolVariable("Zille_Negotiate_After_Op1"))
                {
                    if (DialogueHelper.GetBoolVariable("Zille_Ark_ExchangeOffer"))
                    {
                        ZilleCampaignState.Outcome = ZilleWarOutcome.DecisiveVictory;
                        ZilleCampaignState.ZilleCityCaptured = true;
                    }
                    ZilleCampaignState.SyncToLua();
                    MelonLogger.Msg("[WAR ENGINE] Post-Op I Council opted for conditional negotiations with Wehlen.");
                    TriggerSmolakParley();
                }
                else
                {
                    MelonLogger.Msg("[WAR ENGINE] Post-Op I Council authorized Operation 2: Total Repayment.");
                    StartTotalRepaymentOperation();
                }
            });
        }

        public static bool SpawnZilleWarEventToken()
        {
            RegisterNativeZilleEntities();
            SuppressPalesWarMarker();

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
                            if (allTrans[i] != null)
                            {
                                allTrans[i].gameObject.layer = palesWarTemplate.layer;
                                if (allTrans[i].name.ToLowerInvariant().Contains("shadow"))
                                {
                                    allTrans[i].gameObject.SetActive(true);
                                    var r = allTrans[i].GetComponent<Renderer>();
                                    if (r != null) r.enabled = true;
                                }
                            }
                        }

                        // Check siblings for shadow decal/projector (Issue #8)
                        if (parent != null)
                        {
                            for (int i = 0; i < parent.childCount; i++)
                            {
                                var sibling = parent.GetChild(i);
                                if (sibling == null || sibling.gameObject == palesWarTemplate) continue;
                                string sName = sibling.name.ToLowerInvariant();
                                if (sName.Contains("shadow"))
                                {
                                    // Deactivate orphaned Pales shadow
                                    sibling.gameObject.SetActive(false);

                                    // Clone it for Zille token
                                    var existingZilleShadow = parent.Find("InvasionOfZille Shadow");
                                    if (existingZilleShadow == null)
                                    {
                                        var zilleShadow = UnityEngine.Object.Instantiate(sibling.gameObject, parent);
                                        zilleShadow.name = "InvasionOfZille Shadow";
                                        zilleShadow.transform.position = new Vector3(zilleWarPos.x, sibling.position.y, zilleWarPos.z);
                                        zilleShadow.transform.rotation = sibling.rotation;
                                        zilleShadow.transform.localScale = sibling.localScale;
                                        zilleShadow.SetActive(true);
                                        MelonLogger.Msg($"[WAR SHADOW] Cloned sibling shadow '{sibling.name}' to Zille at {zilleShadow.transform.position}.");
                                    }
                                    else
                                    {
                                        existingZilleShadow.position = new Vector3(zilleWarPos.x, sibling.position.y, zilleWarPos.z);
                                        existingZilleShadow.gameObject.SetActive(true);
                                    }
                                }
                            }
                        }

                        _spawnedZilleWarToken.SetActive(true);
                        palesWarTemplate.SetActive(false); // Ensure Pales template stays hidden in Turn 2!
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
                        // Token.Setup() may deactivate tokens if story fragments were marked done; keep active for Phase II
                        if (!tok.gameObject.activeSelf) tok.gameObject.SetActive(true);
                        tok.enabled = true;

                        if (Managers.Instance?.Tokens != null && !Managers.Instance.Tokens.Contains(tok))
                        {
                            Managers.Instance.Tokens.Add(tok);
                        }
                    }
                    _spawnedZilleWarToken.SetActive(true);

                    // Ensure parent shadow and root active
                    var zShadow = GameObject.Find("InvasionOfZille Shadow");
                    if (zShadow != null) zShadow.SetActive(true);

                    var zRends = _spawnedZilleWarToken.GetComponentsInChildren<Renderer>(true);
                    for (int r = 0; r < zRends.Length; r++)
                    {
                        if (zRends[r] != null)
                        {
                            zRends[r].gameObject.SetActive(true);
                            zRends[r].enabled = true;
                            zRends[r].shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                            zRends[r].receiveShadows = true;
                        }
                    }
                    SuppressPalesWarMarker();

                    // Register & display the mandatory '!' screen-edge and map token indicator
                    try
                    {
                        var tip = Panels.Instance != null ? Panels.Instance.TokenIndicatorPanel : UnityEngine.Object.FindObjectOfType<TokenIndicatorPanel>();
                        if (tip != null && tok != null)
                        {
                            tip.Setup();
                            tip.ShowTokenIndicator(tok);
                        }
                    }
                    catch { }

                    MelonLogger.Msg($"[WAR ENGINE] SpawnZilleWarEventToken final state: self={_spawnedZilleWarToken.activeSelf}, hier={_spawnedZilleWarToken.activeInHierarchy}, parent={_spawnedZilleWarToken.transform.parent?.name}:{_spawnedZilleWarToken.transform.parent?.gameObject.activeInHierarchy}, pos={_spawnedZilleWarToken.transform.position}");

                    SetStoryFragmentMandatoryState("WarFragment_Zille_1_1", true);
                    string opName = GetOperationDisplayName();
                    string phaseTag = ZilleCampaignState.CurrentPhaseNumber == 2 ? "Phase II" : "Phase I";
                    DialogueHelper.ShowAlert($"[Zille] {opName} ({phaseTag}) event is now active at the Zille border.");
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
            if (CurrentTheatre != ActiveWarTheatre.Civilian) return;

            // Delayed Phase II spawn ("kilka kroków dalej" after Mave Nortus HQ regrouping)
            if (_pendingPhase2TokenSpawn && !DialogueManager.isConversationActive)
            {
                var convPanel = Panels.Instance != null ? Panels.Instance.ConversationPanel : null;
                bool convOpen = convPanel != null && convPanel.gameObject.activeInHierarchy;
                if (!convOpen && Time.unscaledTime >= _phase2TokenSpawnAt)
                {
                    SpawnPhase2WarEventTokenNow();
                    return;
                }
            }

            // Keep post-Phase I event visibility consistent after civilian base map finishes reloading
            if (ZilleCampaignState.Phase1Finished && ZilleCampaignState.CurrentPhaseNumber == 1 && !ZilleCampaignState.MaveNortusHQCompleted)
            {
                if (_spawnedZilleWarToken != null && _spawnedZilleWarToken.activeSelf)
                    SuppressZilleWarEventToken();
                if ((_spawnedMaveNortusToken == null || !_spawnedMaveNortusToken.activeSelf) && Time.frameCount % 30 == 0)
                    SpawnMaveNortusHQEventToken();
            }
            else if (ZilleCampaignState.CurrentPhaseNumber == 2 && ZilleCampaignState.Phase2EventUnlocked && !_pendingPhase2TokenSpawn)
            {
                if (_spawnedZilleWarToken == null)
                {
                    if (Time.frameCount % 20 == 0) SpawnZilleWarEventToken();
                }
                else if (!_spawnedZilleWarToken.activeSelf)
                {
                    _spawnedZilleWarToken.SetActive(true);
                    var tok = _spawnedZilleWarToken.GetComponent<Token>();
                    if (tok != null) tok.enabled = true;
                    var zShadow = GameObject.Find("InvasionOfZille Shadow");
                    if (zShadow != null && !zShadow.activeSelf) zShadow.SetActive(true);
                }
            }
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
                            if (convPanel.inputBlockerPanel != null)
                            {
                                convPanel.inputBlockerPanel.gameObject.SetActive(false);
                            }
                            var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                            if (gfm != null && cd != null)
                            {
                                gfm.FinishStoryFragment(cd, null);
                            }
                            Panels.Instance?.ShowHUD();

                            if (PendingZilleTokenSpawnAfterBriefing || DialogueHelper.GetBoolVariable("Zille_War_Active"))
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

                    PrepareSceneConversationMetadata("Turn_Zille_WarBriefing", "Zille/WarCouncil_Briefing");

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

                    PopulateActiveConversationParticipants(convPanel, "Turn_Zille_WarBriefing");

                    convPanel.Show();
                    if (!DialogueManager.isConversationActive)
                    {
                        MelonLogger.Warning("[WAR ENGINE] Briefing conversation did not remain active; cleaning up to prevent black screen.");
                        convPanel.Hide();
                        onFinish();
                        return false;
                    }
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

                public static bool TriggerConversation(string nameInDb, string dialogueTitle, Action onFinish = null)
        {
            try
            {
                ZilleDialogueSystem.EnsureAllConversationsRegistered();
                ZilleCampaignState.SyncFromLua();
                ZilleCampaignState.SyncToLua();
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
                            if (c != null && (c.NameInDatabase == nameInDb || c.ConversationProperties?.Dialogue == dialogueTitle))
                            {
                                cd = c;
                                break;
                            }
                        }
                    }

                    System.Action finishAction = () => {
                        try
                        {
                            if (convPanel.inputBlockerPanel != null)
                            {
                                convPanel.inputBlockerPanel.gameObject.SetActive(false);
                            }
                            var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                            if (gfm != null && cd != null)
                            {
                                gfm.FinishStoryFragment(cd, null);
                            }
                            if (nameInDb == "Turn_Zille_DerdiaInvestigation")
                            {
                                DialogueHelper.SetVariable("Zille_Derdia_BriefingDone", true);
                                DialogueHelper.SetVariable("Zille_Derdia_SabotageEvidence", true);
                            }
                            else if (nameInDb == "Turn_Zille_DerdiaTalks")
                            {
                                DialogueHelper.SetVariable("Zille_DerdiaTalks_Done", true);
                                if (DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitUnlocked"))
                                {
                                    SpawnDerdiaVisitEventToken();
                                }
                            }
                            else if (nameInDb == "Turn_Zille_DerdiaStateVisit")
                            {
                                DialogueHelper.SetVariable("Zille_Derdia_StateVisitDone", true);
                                ZilleCampaignState.IsDerdiaStateVisitDone = true;
                                SuppressDerdiaVisitEventToken();
                            }
                            else if (nameInDb == "Turn_Zille_LespiaTalks") DialogueHelper.SetVariable("Zille_LespiaTalks_Done", true);
                            else if (nameInDb == "Turn_Zille_RumburgTalks") DialogueHelper.SetVariable("Zille_RumburgTalks_Done", true);
                            else if (nameInDb == "Turn_Zille_WarBalconySpeech") DialogueHelper.SetVariable("Zille_BalconySpeech_Done", true);
                            else if (nameInDb == "Turn_Zille_HomeFrontCrisis") DialogueHelper.SetVariable("Zille_HomeFrontCrisis_Done", true);
                            else if (nameInDb == "Turn_Zille_ZilleLiberation") DialogueHelper.SetVariable("Zille_Liberation_Done", true);
                            else if (nameInDb == "Turn_Zille_WarSmolakFinalParley") DialogueHelper.SetVariable("Zille_Rep_ParleyDone", true);
                            else if (nameInDb == "Turn_Zille_ExileEpilogue")
                            {
                                DialogueHelper.SetVariable("Zille_ExileEpilogue_Done", true);
                                ClearAllMandatoryZilleFragments();
                            }
                            else if (nameInDb == "Turn_Zille_WarPeaceTreaty")
                            {
                                DialogueHelper.SetVariable("Zille_PeaceTreaty_Signed", true);
                                DialogueHelper.SetVariable("Zille_Rep_TreatyDone", true);
                                DialogueHelper.SetVariable("Zille_Negotiations_Done", true);
                                ClearAllMandatoryZilleFragments();
                            }

                            SetStoryFragmentMandatoryState(nameInDb, false);
                            ZilleCampaignState.SyncFromLua();
                            ZilleReportsAndSituations.EnsureRegisteredAndSynced();
                            Panels.Instance?.ShowHUD();
                            onFinish?.Invoke();
                        }
                        catch (Exception ex)
                        {
                            MelonLogger.Warning($"[WAR ENGINE] OnFinish conversation error: {ex.Message}");
                        }
                    };

                    PrepareSceneConversationMetadata(nameInDb, dialogueTitle);

                    if (cd != null)
                    {
                        convPanel.Setup(cd, finishAction, false);
                    }
                    else
                    {
                        convPanel.ForceStartConversation(dialogueTitle);
                    }

                    if (!DialogueManager.isConversationActive)
                    {
                        DialogueManager.StartConversation(dialogueTitle);
                    }

                    PopulateActiveConversationParticipants(convPanel, nameInDb);

                    convPanel.Show();
                    if (!DialogueManager.isConversationActive)
                    {
                        MelonLogger.Warning($"[WAR ENGINE] Conversation '{dialogueTitle}' did not remain active; cleaning up to prevent black screen.");
                        convPanel.Hide();
                        finishAction();
                        return false;
                    }
                    MelonLogger.Msg($"[WAR ENGINE] Triggered conversation '{dialogueTitle}' ({nameInDb})!");
                    return true;
                }
                else
                {
                    DialogueManager.StartConversation(dialogueTitle);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] TriggerConversation failed for {dialogueTitle}: {ex.Message}");
                return false;
            }
        }

        public static void TriggerMaveNortusHQ()
        {
            MelonLogger.Msg("[WAR ENGINE] Opening Mave Nortus Field HQ debrief...");
            if (CurrentTheatre != ActiveWarTheatre.Civilian)
            {
                ReturnToCivilianMap();
            }
            ZilleCampaignState.SyncToLua();
            TriggerConversation("Turn_Zille_MaveNortusHQ", "Zille/MaveNortusHQ", () => {
                MelonLogger.Msg("[WAR ENGINE] Mave Nortus Field HQ concluded! Scheduling Phase II staging event at border.");
                ZilleCampaignState.MaveNortusHQCompleted = true;
                ZilleCampaignState.MaveNortusHQAvailable = false;
                ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2;
                ZilleCampaignState.CurrentPhaseNumber = 2;
                ZilleCampaignState.Phase2EventUnlocked = false;
                ZilleCampaignState.SyncToLua();
                SetStoryFragmentMandatoryState("Turn_Zille_MaveNortusHQ", false);
                SuppressMaveNortusHQEventToken();

                _pendingPhase2TokenSpawn = true;
                _phase2MapStepsSeen = 0;
                _phase2TokenSpawnAt = Time.unscaledTime + 6.0f;
                DialogueHelper.ShowAlert($"[Mave Nortus HQ] Divisions are regrouping. {GetOperationDisplayName()} - Phase II will deploy shortly at the Zille border.");
            });
        }

        public static void TriggerSmolakParley()
        {
            MelonLogger.Msg("[WAR ENGINE] Opening Pre-Negotiations Briefing & Parley with Wiktor Smolak...");
            if (CurrentTheatre != ActiveWarTheatre.Civilian)
            {
                ReturnToCivilianMap();
            }
            SetStoryFragmentMandatoryState("WarFragment_Zille_1_1", false);
            SetStoryFragmentMandatoryState("Turn_Zille_WarPreNegotiationsBriefing", true);
            SetStoryFragmentMandatoryState("Turn_Zille_WarSmolakFinalParley", true);
            SetStoryFragmentMandatoryState("Turn_Zille_WarPeaceTreaty", true);
            ZilleCampaignState.SyncToLua();
            TriggerConversation("Turn_Zille_WarPreNegotiationsBriefing", "Zille/WarPreNegotiationsBriefing", () => {
                SetStoryFragmentMandatoryState("Turn_Zille_WarPreNegotiationsBriefing", false);
                MelonLogger.Msg("[WAR ENGINE] Pre-Negotiations Briefing finished. Proceeding to Smolak Parley...");
                TriggerConversation("Turn_Zille_WarSmolakFinalParley", "Zille/WarSmolakFinalParley", () => {
                    SetStoryFragmentMandatoryState("Turn_Zille_WarSmolakFinalParley", false);
                    if (DialogueHelper.GetBoolVariable("Zille_Parley_Refused") || DialogueHelper.GetBoolVariable("Zille_Azaro_Coup_Collapse"))
                    {
                        MelonLogger.Msg("[WAR ENGINE] Smolak Parley refused under collapse! Triggering Azaro Coup & Exile Epilogue...");
                        SetStoryFragmentMandatoryState("Turn_Zille_WarPeaceTreaty", false);
                        SetStoryFragmentMandatoryState("Turn_Zille_ExileEpilogue", true);
                        TriggerConversation("Turn_Zille_ExileEpilogue", "Zille/ExileEpilogue", () => {
                            DialogueHelper.SetVariable("Zille_ExileEpilogue_Done", true);
                            ClearAllMandatoryZilleFragments();
                        });
                        return;
                    }
                    MelonLogger.Msg("[WAR ENGINE] Smolak Parley finished. Proceeding to Treaty of Zille ceremony...");
                    TriggerConversation("Turn_Zille_WarPeaceTreaty", "Zille/WarPeaceTreaty", () => {
                        MelonLogger.Msg("[WAR ENGINE] Treaty of Zille concluded!");
                        DialogueHelper.SetVariable("Zille_PeaceTreaty_Signed", true);
                        DialogueHelper.SetVariable("Zille_Rep_TreatyDone", true);
                        DialogueHelper.SetVariable("Zille_Negotiations_Done", true);
                        ClearAllMandatoryZilleFragments();
                        if (ZilleCampaignState.Outcome >= ZilleWarOutcome.DecisiveVictory || DialogueHelper.GetBoolVariable("RiziaDLC.ZilleReturn_Success"))
                        {
                            TriggerConversation("Turn_Zille_ZilleLiberation", "Zille/ZilleLiberation");
                        }
                    });
                });
            });
        }

        // ================= SCENE-ACCURATE CONVERSATION PARTICIPANT PORTRAITS =================

        private static bool IsCharacterAvailableForScene(string actorKey, string sceneKey)
        {
            switch (actorKey)
            {
                case "Hugo":
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Hugo_Arrested")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Hugo_Executed")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Hugo_Resigned");
                case "Lucita":
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Arrested")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Executed")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.BirthdayGathering_LucitaExiled");
                case "Titus":
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Titus_Arrested")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Titus_Executed");
                case "Taddeus":
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Taddeus_Arrested")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Taddeus_Executed");
                case "Carlos":
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Carlos_Arrested");
                case "Angelica":
                    return DialogueHelper.GetBoolVariable("RiziaDLC.Relations_HouseSazon_AngelicaPardoned")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Angelica_Arrested")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Angelica_Executed");
                case "Manus":
                    if (sceneKey == "Turn_Zille_ExileEpilogue")
                    {
                        return !DialogueHelper.GetBoolVariable("RiziaDLC.Manus_Executed")
                            && !DialogueHelper.GetBoolVariable("RiziaDLC.Manus_DiesInWar");
                    }
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Manus_Arrested")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Manus_Executed")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Manus_Gone")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Manus_EarlyExile")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Manus_DiesInWar")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.BirthdayGathering_ManusExiled");
                case "Leona":
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Leona_Arrested")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Leona_Executed");
                case "Sal":
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Sal_Arrested")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Sal_Executed");
                case "Estela":
                    return !DialogueHelper.GetBoolVariable("QueenMother_Estela_Dead")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Estela_Dead")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Estela_EarlyExile");
                case "Vina":
                    if (sceneKey == "Turn_Zille_ExileEpilogue")
                    {
                        return !DialogueHelper.GetBoolVariable("RiziaDLC.Vina_FuneralHappened")
                            && !DialogueHelper.GetBoolVariable("RiziaDLC.Vina_Dead");
                    }
                    return !DialogueHelper.GetBoolVariable("RiziaDLC.Vina_FuneralHappened")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Vina_Dead")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Vina_Escapes")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Vina_EarlyExile")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Vina_Hostage")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.Vina_InPales")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.AxelVina_Married_Official")
                        && !DialogueHelper.GetBoolVariable("RiziaDLC.BirthdayGathering_VinaExiled");
                default:
                    return true;
            }
        }

        private static string MatchCharacterKey(CharacterData ch)
        {
            if (ch == null) return null;
            string name = (ch.CharacterName ?? "").Trim();
            string dbName = (ch.NameInDatabase ?? "").Trim();
            string combined = (name + " " + dbName).Trim();
            if (string.IsNullOrEmpty(combined)) return null;

            // Use explicit full/character names so short substrings like "Sal" never hit unrelated characters
            if (combined.IndexOf("Hugo", StringComparison.OrdinalIgnoreCase) >= 0) return "Hugo";
            if (combined.IndexOf("Lucita", StringComparison.OrdinalIgnoreCase) >= 0) return "Lucita";
            if (combined.IndexOf("Elena", StringComparison.OrdinalIgnoreCase) >= 0) return "Elena";
            if (combined.IndexOf("Laurento", StringComparison.OrdinalIgnoreCase) >= 0) return "Laurento";
            if (combined.IndexOf("Titus", StringComparison.OrdinalIgnoreCase) >= 0) return "Titus";
            if (combined.IndexOf("Taddeus", StringComparison.OrdinalIgnoreCase) >= 0) return "Taddeus";
            if (combined.IndexOf("Carlos", StringComparison.OrdinalIgnoreCase) >= 0) return "Carlos";
            if (combined.IndexOf("Angelica", StringComparison.OrdinalIgnoreCase) >= 0) return "Angelica";
            if (combined.IndexOf("Manus", StringComparison.OrdinalIgnoreCase) >= 0) return "Manus";
            if (combined.IndexOf("Leona", StringComparison.OrdinalIgnoreCase) >= 0) return "Leona";
            if (combined.IndexOf("Ignacius", StringComparison.OrdinalIgnoreCase) >= 0
                || string.Equals(name, "Sal", StringComparison.OrdinalIgnoreCase)
                || dbName.EndsWith("_Sal", StringComparison.OrdinalIgnoreCase)) return "Sal";
            if (combined.IndexOf("Smolak", StringComparison.OrdinalIgnoreCase) >= 0) return "Smolak";
            if (combined.IndexOf("Alvarez", StringComparison.OrdinalIgnoreCase) >= 0) return "Alvarez";
            if (combined.IndexOf("Hegel", StringComparison.OrdinalIgnoreCase) >= 0) return "Hegel";
            if (combined.IndexOf("Beatrice", StringComparison.OrdinalIgnoreCase) >= 0) return "Beatrice";
            if (combined.IndexOf("Azmal", StringComparison.OrdinalIgnoreCase) >= 0) return "Azmal";
            if (combined.IndexOf("Estela", StringComparison.OrdinalIgnoreCase) >= 0) return "Estela";
            if (combined.IndexOf("Vina", StringComparison.OrdinalIgnoreCase) >= 0) return "Vina";
            return null;
        }

        private static string NormalizeSceneKey(string nameInDb)
        {
            if (string.IsNullOrEmpty(nameInDb)) return "";
            if (!nameInDb.StartsWith("Turn_Zille_", StringComparison.OrdinalIgnoreCase) && nameInDb.StartsWith("Zille/", StringComparison.OrdinalIgnoreCase))
            {
                string tail = nameInDb.Substring("Zille/".Length);
                if (tail == "WarCouncil_Briefing") return "Turn_Zille_WarBriefing";
                return "Turn_Zille_" + tail;
            }
            return nameInDb;
        }

        public static List<string> GetExpectedParticipantsForScene(string nameInDb)
        {
            string scene = NormalizeSceneKey(nameInDb);
            var list = new List<string>();
            void AddIfAvail(string key)
            {
                if (IsCharacterAvailableForScene(key, scene) && !list.Contains(key)) list.Add(key);
            }

            bool hugoAvail = IsCharacterAvailableForScene("Hugo", scene);
            bool lucitaAvail = IsCharacterAvailableForScene("Lucita", scene);
            bool taddeusAvail = IsCharacterAvailableForScene("Taddeus", scene);
            bool titusAvail = IsCharacterAvailableForScene("Titus", scene);
            bool angelicaAvail = IsCharacterAvailableForScene("Angelica", scene);
            bool manusAvail = IsCharacterAvailableForScene("Manus", scene);

            switch (scene)
            {
                case "Turn_Zille_WarPlanning":
                    if (hugoAvail) list.Add("Hugo");
                    AddIfAvail("Laurento");
                    AddIfAvail("Elena");
                    if (lucitaAvail) list.Add("Lucita");
                    else if (taddeusAvail) list.Add("Taddeus");
                    if (!lucitaAvail || !taddeusAvail || !titusAvail) AddIfAvail("Carlos");
                    if (titusAvail) list.Add("Titus");
                    break;

                case "Turn_Zille_WarLogisticsDispute":
                    AddIfAvail("Taddeus");
                    AddIfAvail("Lucita");
                    if (!lucitaAvail || !taddeusAvail) AddIfAvail("Carlos");
                    AddIfAvail("Angelica");
                    AddIfAvail("Manus");
                    if (!angelicaAvail && !manusAvail) AddIfAvail("Leona");
                    AddIfAvail("Elena");
                    if (hugoAvail) list.Add("Hugo");
                    else AddIfAvail("Laurento");
                    break;

                case "Turn_Zille_WarBriefing":
                    if (hugoAvail) list.Add("Hugo");
                    else if (DialogueHelper.GetBoolVariable("RiziaDLC.Council_GrandVizier_Angelica")
                             && !DialogueHelper.GetBoolVariable("RiziaDLC.Angelica_Arrested")
                             && !DialogueHelper.GetBoolVariable("RiziaDLC.Angelica_Executed"))
                        list.Add("Angelica");
                    else if (DialogueHelper.GetBoolVariable("RiziaDLC.Council_GrandVizier_Sal")
                             && IsCharacterAvailableForScene("Sal", scene))
                        list.Add("Sal");
                    AddIfAvail("Laurento");
                    if (lucitaAvail) list.Add("Lucita");
                    else if (taddeusAvail) list.Add("Taddeus");
                    if (!lucitaAvail || !titusAvail) AddIfAvail("Carlos");
                    AddIfAvail("Titus");
                    AddIfAvail("Elena");
                    break;

                case "Turn_Zille_WarBalconySpeech":
                    if (hugoAvail) list.Add("Hugo");
                    AddIfAvail("Laurento");
                    break;

                case "Turn_Zille_MaveNortusHQ":
                    AddIfAvail("Taddeus");
                    AddIfAvail("Lucita");
                    if (!taddeusAvail || !lucitaAvail || DialogueHelper.GetBoolVariable("Zille_Fighting_Pales"))
                        AddIfAvail("Carlos");
                    break;

                case "Turn_Zille_Op1AftermathCouncil":
                    if (hugoAvail) list.Add("Hugo");
                    AddIfAvail("Laurento");
                    if (lucitaAvail) list.Add("Lucita");
                    else AddIfAvail("Carlos");
                    break;

                case "Turn_Zille_DerdiaInvestigation":
                    if (titusAvail) list.Add("Titus");
                    else AddIfAvail("Carlos");
                    AddIfAvail("Laurento");
                    AddIfAvail("Lucita");
                    break;

                case "Turn_Zille_DerdiaTalks":
                    list.Add("Azmal");
                    break;

                case "Turn_Zille_DerdiaStateVisit":
                    list.Add("Azmal");
                    AddIfAvail("Titus");
                    break;

                case "Turn_Zille_LespiaTalks":
                    list.Add("Alvarez");
                    list.Add("Laurento");
                    break;

                case "Turn_Zille_RumburgTalks":
                    list.Add("Beatrice");
                    if (hugoAvail) list.Add("Hugo");
                    else list.Add("Laurento");
                    break;

                case "Turn_Zille_WarPreNegotiationsBriefing":
                    AddIfAvail("Laurento");
                    AddIfAvail("Elena");
                    if (hugoAvail) list.Add("Hugo");
                    if (lucitaAvail) list.Add("Lucita");
                    else AddIfAvail("Carlos");
                    break;

                case "Turn_Zille_WarSmolakFinalParley":
                    list.Add("Smolak");
                    break;

                case "Turn_Zille_WarPeaceTreaty":
                    if (hugoAvail) list.Add("Hugo");
                    AddIfAvail("Laurento");
                    if (IsCharacterAvailableForScene("Estela", scene)) list.Add("Estela");
                    if (DialogueHelper.GetBoolVariable("Zille_Reparations_Won") || DialogueHelper.GetBoolVariable("Grodzizg_FreeCity"))
                        AddIfAvail("Elena");
                    break;

                case "Turn_Zille_HomeFrontCrisis":
                    AddIfAvail("Elena");
                    AddIfAvail("Laurento");
                    if (hugoAvail) list.Add("Hugo");
                    break;

                case "Turn_Zille_ZilleLiberation":
                    AddIfAvail("Estela");
                    AddIfAvail("Vina");
                    AddIfAvail("Laurento");
                    if (titusAvail) list.Add("Titus");
                    else AddIfAvail("Carlos");
                    AddIfAvail("Manus");
                    if (!manusAvail) AddIfAvail("Leona");
                    break;

                case "Turn_Zille_ExileEpilogue":
                    if (IsCharacterAvailableForScene("Vina", scene)) list.Add("Vina");
                    if (IsCharacterAvailableForScene("Manus", scene)) list.Add("Manus");
                    break;
            }

            return list;
        }

        private static int ActorIdForKey(string actorKey)
        {
            return actorKey switch
            {
                "Hugo" => ZilleDialogueSystem.HugoId,
                "Lucita" => ZilleDialogueSystem.LucitaId,
                "Elena" => ZilleDialogueSystem.ElenaId,
                "Laurento" => ZilleDialogueSystem.LaurentoId,
                "Titus" => ZilleDialogueSystem.TitusId,
                "Taddeus" => ZilleDialogueSystem.TaddeusId,
                "Carlos" => ZilleDialogueSystem.CarlosId,
                "Angelica" => ZilleDialogueSystem.AngelicaId,
                "Manus" => ZilleDialogueSystem.ManusId,
                "Leona" => ZilleDialogueSystem.LeonaId,
                "Sal" => ZilleDialogueSystem.SalId,
                "Smolak" => ZilleDialogueSystem.SmolakId,
                "Alvarez" => ZilleDialogueSystem.AlvarezId,
                "Hegel" => ZilleDialogueSystem.HegelId,
                "Beatrice" => ZilleDialogueSystem.BeatriceId,
                "Azmal" => ZilleDialogueSystem.AzmalId,
                "Estela" => ZilleDialogueSystem.EstelaId,
                "Vina" => ZilleDialogueSystem.VinaId,
                _ => ZilleDialogueSystem.NarratorId
            };
        }

        private static void PrepareSceneConversationMetadata(string nameInDb, string dialogueTitle)
        {
            try
            {
                var db = DialogueManager.masterDatabase;
                if (db == null) return;
                var expected = GetExpectedParticipantsForScene(nameInDb);
                int primaryConvId = expected.Count > 0 ? ActorIdForKey(expected[0]) : ZilleDialogueSystem.NarratorId;

                foreach (var title in new[] { nameInDb, dialogueTitle })
                {
                    if (string.IsNullOrEmpty(title)) continue;
                    var conv = db.GetConversation(title);
                    if (conv == null) continue;
                    conv.ConversantID = primaryConvId;
                    ZilleDialogueSystem.EnsureConvField(conv, "Conversant", primaryConvId.ToString(), FieldType.Actor);
                }
            }
            catch { }
        }

        public static void PopulateActiveConversationParticipants(ConversationPanel convPanel, string nameInDb)
        {
            if (convPanel == null) return;
            var expected = GetExpectedParticipantsForScene(nameInDb);
            var expectedSet = new HashSet<string>(expected, StringComparer.OrdinalIgnoreCase);

            var chars = EntityDataManager.CharactersData;
            if (chars == null) return;

            for (int i = 0; i < chars.Count; i++)
            {
                var ch = chars[i];
                if (ch == null) continue;
                string key = MatchCharacterKey(ch);
                if (string.IsNullOrEmpty(key)) continue;

                if (expectedSet.Contains(key))
                {
                    try { convPanel.AddConversant(ch); } catch { }
                }
                else
                {
                    try { convPanel.RemoveConversant(ch); } catch { }
                }
            }
            MelonLogger.Msg($"[WAR ENGINE] Participants for '{nameInDb}': [{string.Join(", ", expected)}]");
        }

        // ================= SCHEDULED THEATRE TRANSITION =================

        public static void ScheduleWarTheatreTransition()
        {
            _transitionScheduled = true;
            _transitionTimer = 0.5f;
        }

        private static float _nextPalesCheckTime;

        public static void CheckScheduledTransition(float deltaTime)
        {
            if (CurrentTheatre == ActiveWarTheatre.Civilian && Time.unscaledTime > _nextPalesCheckTime)
            {
                _nextPalesCheckTime = Time.unscaledTime + 2.0f;
                SuppressPalesWarMarker();
            }

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
                        if (config.Tiles[i].IsDisabled) continue;
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
                        if (src.IsDisabled) continue;
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
                ZilleWarTable.SnapshotPreZilleMilitaryLedger();
                ZilleCampaignState.SnapshotPalesCasualtiesBeforeZilleTable();
                ZilleCampaignState.SyncToLua();
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
                if (Time.unscaledTime - _lastToggleHideTime > 0.4f)
                {
                    _lastToggleHideTime = Time.unscaledTime;
                    SetCivilianTogglesVisible(false);
                }

                var turnPanel = Panels.Instance?.WarTurnPanel;
                if (turnPanel != null && turnPanel.titleText != null)
                {
                    string opName = GetOperationDisplayName();
                    string phaseStr = ZilleCampaignState.CurrentPhaseNumber == 2 ? "Phase II" : "Phase I";
                    turnPanel.titleText.text = $"{opName} - {phaseStr}";
                }

                if (ZilleWarTable.EditMode)
                    ZilleWarTable.SuppressInvasionChrome();
                else if (ZilleWarTable.IsLiveBoardReady)
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
                if (ZilleCampaignState.CurrentPhaseNumber == 2 || (ZilleCampaignState.CurrentOperationNumber == 2 && ZilleWarTable.HasSavedPhaseBoardState()))
                {
                    // Phase II or Op 2 (Total Repayment): Resume directly from saved frontline state!
                    ZilleWarTable.RestorePhaseBoardState();
                    ZilleWarTable.MarkOperationBegun();
                    var flow = Managers.Instance?.WarFlowManager ?? UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                    if (flow != null)
                    {
                        flow.SetWarState(WarFlowManager.WarState.Operation);
                        flow.currentActionPoints = ZilleWarTable.GetPlayerActionPointsPerTurn();
                        flow.PlayerTurn();
                    }
                    var hud2 = Panels.Instance != null ? Panels.Instance.WarHUDPanel : UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
                    if (hud2 != null)
                    {
                        if (!hud2.gameObject.activeSelf) hud2.gameObject.SetActive(true);
                        try { hud2.Setup(WarHUDPanel.WarHUDButtonState.EndTurn); } catch { }
                        try { hud2.SetInteractable(true); } catch { }
                        hud2.Show();
                    }
                    _deploymentOpened = true;
                    MelonLogger.Msg($"[WAR THEATRE] Op {ZilleCampaignState.CurrentOperationNumber} Phase {ZilleCampaignState.CurrentPhaseNumber} started directly on the restored frontline!");
                    return;
                }

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
                var flowInit = Managers.Instance?.WarFlowManager ?? UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (flowInit != null && flowInit.GetWarState() != WarFlowManager.WarState.InitialDeployment)
                {
                    try { flowInit.SetWarState(WarFlowManager.WarState.InitialDeployment); } catch { }
                }
                var hud = Panels.Instance != null ? Panels.Instance.WarHUDPanel : UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
                if (hud != null && !ZilleWarTable.ScenarioStarted)
                {
                    if (!hud.gameObject.activeSelf) hud.gameObject.SetActive(true);
                    try { hud.Setup(WarHUDPanel.WarHUDButtonState.OperationStart); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Start button setup: " + ex.Message); }
                    try { hud.SetInteractable(true); } catch { }
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
            ZilleCampaignState.RestorePalesCasualtiesAfterZilleTable();
            ZilleCampaignState.SyncToLua();
            CurrentTheatre = ActiveWarTheatre.Civilian;
            _tilesConfiguredForZille = false;
            _deploymentOpened = false;
            ZilleWarTable.ScenarioStarted = false;

            try
            {
                // Reset camera back to standard civilian main map view
                var camMgr = UnityEngine.Object.FindObjectOfType<CameraManager>();
                if (camMgr != null)
                {
                    try { camMgr.LookAtModeOff(); } catch { }
                    try { camMgr.GoToMainMapCenter(); } catch { }
                    try { camMgr.ResetPosition(); } catch { }
                }

                // Hide all war UI panels and sticky map markers
                ZilleWarTable.CleanupAllWarUIAndMarkers();
                try { Panels.Instance?.ContinueButtonPanel?.Hide(); } catch { }

                // Suppress Pales invasion marker and orphaned shadow
                SuppressPalesWarMarker();

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
                ZilleWarTable.ResetPreZilleMilitaryLedger();
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

                PreparePostPhase1CivilianEvents();
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
                int opBefore = ZilleCampaignState.CurrentOperationNumber;
                int phaseBefore = ZilleCampaignState.CurrentPhaseNumber;

                ZilleWarTable.CheckCityVictory(true);
                var outcome = ZilleCampaignState.Outcome;

                ReturnToCivilianMap();

                if (opBefore <= 1 && phaseBefore <= 1 && outcome != ZilleWarOutcome.TotalFiasco)
                {
                    PreparePostPhase1CivilianEvents();
                }
                else if (opBefore <= 1 && (phaseBefore >= 2 || outcome == ZilleWarOutcome.TotalFiasco))
                {
                    MelonCoroutines.Start(ShowConclusionReportCoroutine());
                    MelonCoroutines.Start(DelayedPostOpDispatchCoroutine(opBefore, phaseBefore, outcome));
                }
                else if (opBefore >= 2 && phaseBefore <= 1
                    && outcome != ZilleWarOutcome.DecisiveVictory
                    && outcome != ZilleWarOutcome.OverwhelmingTriumph
                    && outcome != ZilleWarOutcome.TotalFiasco)
                {
                    SpawnPhase2WarEventTokenNow();
                }
                else
                {
                    MelonCoroutines.Start(ShowConclusionReportCoroutine());
                    MelonCoroutines.Start(DelayedPostOpDispatchCoroutine(opBefore, phaseBefore, outcome));
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] ReturnToCivilianMapWithReport error: {ex.Message}");
            }
        }

        private static System.Collections.IEnumerator DelayedPostOpDispatchCoroutine(int opBefore, int phaseBefore, ZilleWarOutcome outcome)
        {
            yield return new WaitForSeconds(0.8f);
            if (opBefore <= 1)
            {
                ResolvePostOperation1Flow(outcome, $"Operation I concluded ({outcome})");
            }
            else
            {
                TriggerSmolakParley();
            }
        }

        private static System.Collections.IEnumerator ShowConclusionReportCoroutine()
        {
            yield return new WaitForSeconds(1.2f);

            var outcome = ZilleCampaignState.Outcome;
            bool won = outcome == ZilleWarOutcome.DecisiveVictory || outcome == ZilleWarOutcome.OverwhelmingTriumph;

            int citiesHeld = DialogueHelper.GetIntVariable("Zille_Cities_Held");
            int brenasLost = DialogueHelper.GetIntVariable("Zille_Brenas_Lost");
            int zPlayerLost = ZilleCampaignState.ZillePlayerUnitsLostTotal;
            int zEnemyLost = ZilleCampaignState.ZilleEnemyUnitsLostTotal;
            int zCasualties = ZilleCampaignState.ZilleManpowerCasualties;
            int pPlayerLost = ZilleCampaignState.PalesPlayerUnitsLost;
            int pEnemyLost = ZilleCampaignState.PalesEnemyUnitsLost;
            bool palesRelevant = DialogueHelper.GetBoolVariable("Zille_Fighting_Pales");

            string opName = GetOperationDisplayName();
            string title = won
                ? $"{opName} - Victory"
                : $"{opName} - Campaign Conclusion";

            string baseSummary = won
                ? $"The Rizian Armed Forces have liberated {citiesHeld}/4 cities in Zille{(ZilleCampaignState.ZilleCityCaptured ? " including Zille City" : "")}, with Wehzek garrisons retreating across the Gulf of Moridia and the frontier."
                : brenasLost > 0
                    ? $"Severe setback in the southern campaign: {brenasLost} Brenas cities fell under enemy pressure while only {citiesHeld}/4 Zille targets were secured."
                    : $"The military operations in Zille concluded without decisive control ({citiesHeld}/4 cities held). Exhaustion and logistics forced an operational pause.";

            string zilleLedger = $"\n\n[ZILLE FRONT CASUALTY LEDGER]\n- Royal Brigades Lost (Phase I / II): {ZilleCampaignState.ZillePlayerUnitsLostPhase1} / {ZilleCampaignState.ZillePlayerUnitsLostPhase2} (Total: {zPlayerLost} units, ~{zCasualties:N0} casualties)\n- Wehzek Brigades Destroyed: {zEnemyLost} units";
            string palesLedger = palesRelevant
                ? $"\n\n[SEPARATE PALES FRONT LEDGER]\n- Eastern Front Losses (Pales): {pPlayerLost} Royal units lost | {pEnemyLost} Palesian units destroyed\n(Tracked strictly separately from the Zille theater.)"
                : "";

            string desc = baseSummary + zilleLedger + palesLedger;

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
                    rep.IsWIP = false;
                    rep.Notes = "";
                    rep.ReportProperties = new ReportProperties();
                    rep.AssignedTokenProperties = new AssignedTokenProperties();
                    rep.AssignedTokenProperties.AssignedToken = "Rizia_City_PorteDrazon";
                    rep.AppBundleProperties = CreateRiziaBundleProps();
                    rep.TagsProperties = new TagsProperties();
                    if (reports != null) reports.Add(rep);
                }

                if (rep.AssignedTokenProperties == null)
                {
                    rep.AssignedTokenProperties = new AssignedTokenProperties();
                    rep.AssignedTokenProperties.AssignedToken = "Rizia_City_PorteDrazon";
                }
                if (rep.TagsProperties == null)
                {
                    rep.TagsProperties = new TagsProperties();
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
                    ReportData baseRep = null;
                    if (reports != null && reports.Count > 0)
                    {
                        for (int i = 0; i < reports.Count; i++)
                        {
                            var r = reports[i];
                            if (r != null && r != rep) { baseRep = r; break; }
                        }
                    }

                    try
                    {
                        reportPanel.SetupDefault(baseRep ?? rep);
                    }
                    catch (Exception exSetup)
                    {
                        MelonLogger.Warning("[WAR ENGINE] SetupDefault exception (fallback direct texts): " + exSetup.Message);
                    }

                    if (reportPanel.reportTitleText != null) reportPanel.reportTitleText.text = title;
                    if (reportPanel.reportDescriptionText != null) reportPanel.reportDescriptionText.text = desc;
                    if (reportPanel.tokenNameText != null) reportPanel.tokenNameText.text = "Zille Military Campaign";
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
