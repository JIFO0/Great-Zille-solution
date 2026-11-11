using System;
using MelonLoader;

namespace GreatZilleSolution
{
    public enum ZillePlanType
    {
        None,
        Staff,
        Romulus
    }

    public enum ZilleStaffPlan
    {
        None,
        Hawk,
        Sword,
        Ark,
        Spear
    }

    public enum ZilleRomulusPlan
    {
        None,
        Sword,          // Operation Golden Sword (Central Armored Push)
        GoldenSword = Sword,
        Ark,            // Operation Golden Ark (Maritime & Coastal Envelopment)
        GoldenArk = Ark,
        TotalRepayment  // Operation Total Repayment (Counter-Invasion into Wehlen)
    }

    public enum ZilleOperationVariant
    {
        PlanArk,
        PlanSword,
        PlanArkDerdia,
        TotalRepaymentDerdia,
        TotalRepaymentNoDerdia
    }

    public enum ZilleWarOutcome
    {
        None = 0,
        TotalFiasco = 1,
        TacticalDefeat = 2,
        BloodyStalemate = 3,
        DecisiveVictory = 4,
        OverwhelmingTriumph = 5
    }

    public enum ZilleOperationPath
    {
        None,
        FrontalAssault,       // Direct assault on Zille city
        FlankViktranyMunat    // Maneuver through Viktrany -> Munat port
    }

    public enum ZilleOperationPhase
    {
        NotStarted,
        Phase1 = 1,
        Phase2 = 2,
        Phase3 = 3,
        Phase4 = 4,
        Completed_Outcome = 5,
        // Compatibility aliases:
        Phase1_RighteousSword = Phase1,
        Phase2_TotalRepayment = Phase2,
        Completed_Victory = 10,
        Defeat_MotherCaptured = 11,
        Defeat_BrenasLost = 12
    }

    public static class ZilleCampaignState
    {
        // 0 = None, 1 = Early musings (Turn 1), 2 = Staff planning (Turn 2-3), 3 = Mobilization ready (Turn 8)
        public static int MilitarySentimentLevel { get; set; } = 0;

        public static ZilleOperationPhase CurrentPhase { get; set; } = ZilleOperationPhase.NotStarted;
        public static ZilleOperationPath ChosenPath { get; set; } = ZilleOperationPath.None;

        public static ZillePlanType PlanType { get; set; } = ZillePlanType.None;
        public static ZilleStaffPlan StaffPlan { get; set; } = ZilleStaffPlan.None;
        public static ZilleRomulusPlan RomulusPlan { get; set; } = ZilleRomulusPlan.None;
        public static ZilleOperationVariant CurrentVariant { get; set; } = ZilleOperationVariant.PlanSword;
        public static ZilleWarOutcome Outcome { get; set; } = ZilleWarOutcome.None;
        public static bool IsIndependentZilleAgreed { get; set; } = false;
        public static int CurrentPhaseNumber { get; set; } = 1;
        public static bool Phase1Finished { get; set; } = false;
        public static int StaffVictoryPoints { get; set; } = 0;

        public static void SetOperationVariant(ZilleOperationVariant variant)
        {
            CurrentVariant = variant;
            switch (variant)
            {
                case ZilleOperationVariant.PlanArk:
                    RomulusPlan = ZilleRomulusPlan.Ark;
                    CurrentPhase = ZilleOperationPhase.Phase1;
                    CurrentPhaseNumber = 1;
                    break;
                case ZilleOperationVariant.PlanSword:
                    RomulusPlan = ZilleRomulusPlan.Sword;
                    CurrentPhase = ZilleOperationPhase.Phase1;
                    CurrentPhaseNumber = 1;
                    break;
                case ZilleOperationVariant.PlanArkDerdia:
                    RomulusPlan = ZilleRomulusPlan.Ark;
                    CurrentPhase = ZilleOperationPhase.Phase1;
                    CurrentPhaseNumber = 1;
                    IsDerdiaHybridSupportActive = true;
                    break;
                case ZilleOperationVariant.TotalRepaymentDerdia:
                    CurrentPhase = ZilleOperationPhase.Phase2;
                    CurrentPhaseNumber = 2;
                    IsDerdiaHybridSupportActive = true;
                    break;
                case ZilleOperationVariant.TotalRepaymentNoDerdia:
                    CurrentPhase = ZilleOperationPhase.Phase2;
                    CurrentPhaseNumber = 2;
                    break;
            }

            int active = ZilleMapLayoutManager.ApplyOperationVariant(variant);
            ZilleWarTable.RequestApply();
            ZilleWarTable.RequestBoardRefresh();
            MelonLogger.Msg($"[WAR ENGINE] Set operation variant to {variant}: {active} active provinces.");
        }

                // Logistics & Intelligence Doctrines
        public static string LogisticsRoute { get; set; } = "None"; // "Sazon", "Azaro", "Compromise"
        public static bool IsRumburgMunitionsActive { get; set; } = false;
        public static bool IsLespiaIntelActive { get; set; } = false;
        public static int Phase1CitiesCaptured { get; set; } = 0;
        public static int Phase2CitiesCaptured { get; set; } = 0;
        public static bool ZilleCityCaptured { get; set; } = false;
        public static bool IsNavalBlockadeActive { get; set; } = false;
        public static bool IsLespiaPactAccepted { get; set; } = false;
        public static bool IsDerdiaHybridSupportActive { get; set; } = false;
        public static bool IsMotherCaptured { get; set; } = false;
        public static bool IsBrenasLost { get; set; } = false;

        // Economic Impact Trackers
        public static int GoldBudgetDrainPerTurn { get; set; } = 0;
        public static int EnergyDeficitPerTurn { get; set; } = 0;

        // Unit Tracking & Allocation
        public static int UnitsCommittedToPales { get; set; } = 0;
        public static int UnitsCommittedToZille { get; set; } = 0;

        /// <summary>
        /// Detects if Rizia is actively preparing for or at war with Pales.
        /// </summary>
        public static bool IsTwoFrontWarThreat()
        {
            try
            {
                // If Lespia pact was accepted, Pales war is called off!
                if (IsLespiaPactAccepted) return false;

                bool palesPrep = DialogueHelper.GetBoolVariable("Diplomacy_Pales_PrepareForWar");
                bool palesWar = DialogueHelper.GetBoolVariable("Diplomacy_Pales_DeclareWar");
                bool palesActive = DialogueHelper.GetBoolVariable("Pales_War");
                bool palesIntervention = DialogueHelper.GetBoolVariable("Pales_War_Played");

                return palesPrep || palesWar || palesActive || palesIntervention;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Applies profound geopolitical shifts across Merkopa upon military escalation with Wehlen:
        /// - Malenyevist bloc (Valgsland, Morella, CSP) relations plummet.
        /// - Capitalist bloc (Lespia, Arcasia, ATO) relations rise; aid provided.
        /// - Sordland reaction calculated based on Operation Bear Trap status.
        /// - Economic shocks applied: energy deficit and massive gold drain if on two fronts.
        /// </summary>
        public static void ApplyGeopoliticalShifts()
        {
            try
            {
                MelonLogger.Msg("============================================================");
                MelonLogger.Msg("[GEOPOLITICS] Applying global diplomatic & economic shocks from Zille conflict:");
                MelonLogger.Msg(" - Malenyevist bloc (Valgsland / Morella / CSP): Heavy negative drop");
                MelonLogger.Msg(" - Capitalist bloc (Lespia / Arcasia / ATO): Significant improvement");
                MelonLogger.Msg("============================================================");

                // Instantly sever all Wehlen trade & energy commitments
                DialogueHelper.SetVariable("Diplomacy_Wehlen_Trade", false);
                DialogueHelper.SetVariable("EnergyCommitment_Wehlen_Failed", true);
                DialogueHelper.SetVariable("Diplomacy_Wehlen_Hostile", true);

                // Malenyevist / Eastern relations drop
                DialogueHelper.SetVariable("Diplomacy_Valgsland_Alliance", false);
                DialogueHelper.SetVariable("CountryRelation_Valgsland_Hostile", true);
                DialogueHelper.SetVariable("Diplomacy_Morella_NegotiatingPower", -2);

                // Capitalist / Western relations rise
                DialogueHelper.SetVariable("CountryRelation_Lespia_Friendly", true);
                DialogueHelper.SetVariable("Diplomacy_Arcasia_Military_Infl", 2);
                DialogueHelper.SetVariable("Diplomacy_Lespia_WehlenHelp", true);

                // Check Sordland (Anton Rayne) status regarding Bear Trap
                bool sordlandBearTrap = DialogueHelper.GetBoolVariable("Diplomacy_Sordland_BearTrap");
                if (sordlandBearTrap)
                {
                    DialogueHelper.SetVariable("CountryRelation_Sordland_Strained", true);
                    MelonLogger.Msg("[GEOPOLITICS] Sordland participated in Bear Trap: Diplomatic friction with Rizia over Wehlen attack.");
                }
                else
                {
                    DialogueHelper.SetVariable("CountryRelation_Sordland_Friendly", true);
                    MelonLogger.Msg("[GEOPOLITICS] Sordland rejected Bear Trap: Anton Rayne remains open to diplomatic channels.");
                }

                // Check Derdia Hybrid War Support
                bool derdiaFriendly = DialogueHelper.GetBoolVariable("Deal_Derdia") || DialogueHelper.GetBoolVariable("CountryRelation_Derdia_Friendly");
                if (derdiaFriendly)
                {
                    IsDerdiaHybridSupportActive = true;
                    DialogueHelper.SetVariable("Zille_Derdia_HybridWarfare", true);
                    MelonLogger.Msg("[GEOPOLITICS] Derdia hybrid warfare active: Holy irregulars deployed behind Wehzek lines!");
                }

                // Economic fallout: Energy and Gold calculation
                EnergyDeficitPerTurn = 2; // loss of Wehlen oil
                if (IsTwoFrontWarThreat())
                {
                    GoldBudgetDrainPerTurn = 3; // two-front war causes massive budget drain
                    DialogueHelper.ShowAlert("[ECONOMIC CRISIS] Two-front mobilization! Royal treasury under severe strain, inflation soaring.");
                }
                else if (IsLespiaPactAccepted)
                {
                    GoldBudgetDrainPerTurn = 1; // subsidized by Lespia/Arcasia
                    EnergyDeficitPerTurn = 1;   // emergency oil credits
                    DialogueHelper.ShowAlert("[ECONOMIC AID] Lespian capital and emergency Arcasian energy stabilize Rizia's war budget.");
                }
                else
                {
                    GoldBudgetDrainPerTurn = 2;
                }

                DialogueHelper.SetVariable("Economy_Gold_Drain", GoldBudgetDrainPerTurn);
                DialogueHelper.SetVariable("Economy_Energy_Deficit", EnergyDeficitPerTurn);
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"Failed to apply geopolitical shifts: {ex.Message}");
            }
        }

        public static void SyncToLua()
        {
            try
            {
                DialogueHelper.SetVariable("Zille_MilitarySentiment", MilitarySentimentLevel);
                DialogueHelper.SetVariable("Zille_OperationPhase", (int)CurrentPhase);
                DialogueHelper.SetVariable("Zille_War_Phase", CurrentPhaseNumber);
                DialogueHelper.SetVariable("Zille_War_PlanType", PlanType.ToString());
                DialogueHelper.SetVariable("Zille_War_StaffPlan", StaffPlan.ToString());
                DialogueHelper.SetVariable("Zille_War_RomulusPlan", RomulusPlan.ToString());
                DialogueHelper.SetVariable("Zille_Logistics_Route", LogisticsRoute);
                DialogueHelper.SetVariable("Zille_Rumburg_Munitions", IsRumburgMunitionsActive);
                DialogueHelper.SetVariable("Zille_Lespia_Intel", IsLespiaIntelActive);
                DialogueHelper.SetVariable("Zille_City_Captured", ZilleCityCaptured);
                DialogueHelper.SetVariable("Zille_Phase1_Cities", Phase1CitiesCaptured);
                DialogueHelper.SetVariable("Zille_Phase2_Cities", Phase2CitiesCaptured);
                DialogueHelper.SetVariable("Zille_War_Outcome", (int)Outcome);
                DialogueHelper.SetVariable("Zille_Independent_Buffer", IsIndependentZilleAgreed);
                DialogueHelper.SetVariable("Zille_NavalBlockadeActive", IsNavalBlockadeActive);
                DialogueHelper.SetVariable("Zille_LespiaPactAccepted", IsLespiaPactAccepted);
                DialogueHelper.SetVariable("Zille_DerdiaHybridActive", IsDerdiaHybridSupportActive);
                DialogueHelper.SetVariable("Zille_MotherCaptured", IsMotherCaptured);
                DialogueHelper.SetVariable("Zille_BrenasLost", IsBrenasLost);
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"Failed to sync Zille variables to Lua: {ex.Message}");
            }
        }
    }
}
