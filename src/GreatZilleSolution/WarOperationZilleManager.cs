using System;
using MelonLoader;

namespace GreatZilleSolution
{
    public static class WarOperationZilleManager
    {
        public const string OPERATION_PHASE_1_ID = "OP_Zille_RighteousSword";
        public const string OPERATION_PHASE_2_ID = "OP_Zille_TotalRepayment";

        public static void InitializeOperation(ZilleOperationPath path)
        {
            ZilleCampaignState.ChosenPath = path;
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1_RighteousSword;

            MelonLogger.Msg("============================================================");
            MelonLogger.Msg($"[WAR ENGINE] Initializing Zille Campaign: Phase 1 (Righteous Sword)");
            MelonLogger.Msg($"[WAR ENGINE] Doctrine Selected: {path}");
            MelonLogger.Msg("============================================================");

            // Apply global diplomatic and economic shocks
            ZilleCampaignState.ApplyGeopoliticalShifts();

            // Verify Two-Front War state and unit commitments
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
    }
}
