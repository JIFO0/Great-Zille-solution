using System;
using MelonLoader;
using PixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public enum ZilleOperationPath
    {
        None,
        FrontalAssault,       // Direct assault on Zille city
        FlankViktranyMunat    // Maneuver through Viktrany -> Munat port
    }

    public enum ZilleOperationPhase
    {
        NotStarted,
        Phase1_RighteousSword,
        Phase2_TotalRepayment,
        Completed_Victory,
        Defeat_MotherCaptured,
        Defeat_BrenasLost
    }

    public static class ZilleCampaignState
    {
        // 0 = None, 1 = Early musings (Turn 1), 2 = Staff planning (Turn 2-3), 3 = Mobilization ready (Turn 8)
        public static int MilitarySentimentLevel { get; set; } = 0;

        public static ZilleOperationPhase CurrentPhase { get; set; } = ZilleOperationPhase.NotStarted;
        public static ZilleOperationPath ChosenPath { get; set; } = ZilleOperationPath.None;

        public static bool IsNavalBlockadeActive { get; set; } = false;
        public static bool IsLespiaArcasiaSupportActive { get; set; } = false;
        public static bool IsMotherCaptured { get; set; } = false;
        public static bool IsBrenasLost { get; set; } = false;

        // Unit Tracking & Allocation
        public static int UnitsCommittedToPales { get; set; } = 0;
        public static int UnitsCommittedToZille { get; set; } = 0;

        /// <summary>
        /// Detects if Rizia is actively at war with Pales or declared military intent against Pales.
        /// </summary>
        public static bool IsTwoFrontWarThreat()
        {
            try
            {
                bool palesPrep = DialogueLua.GetVariable("Diplomacy_Pales_PrepareForWar").asBool;
                bool palesWar = DialogueLua.GetVariable("Diplomacy_Pales_DeclareWar").asBool;
                bool palesActive = DialogueLua.GetVariable("Pales_War").asBool;
                bool palesIntervention = DialogueLua.GetVariable("Pales_War_Played").asBool;

                return palesPrep || palesWar || palesActive || palesIntervention;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Updates the Lua story flags to synchronize with Suzerain's narrative database.
        /// </summary>
        public static void SyncToLua()
        {
            try
            {
                DialogueLua.SetVariable("Zille_MilitarySentiment", MilitarySentimentLevel);
                DialogueLua.SetVariable("Zille_OperationPhase", (int)CurrentPhase);
                DialogueLua.SetVariable("Zille_NavalBlockadeActive", IsNavalBlockadeActive);
                DialogueLua.SetVariable("Zille_MotherCaptured", IsMotherCaptured);
                DialogueLua.SetVariable("Zille_BrenasLost", IsBrenasLost);
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"Failed to sync Zille variables to Lua: {ex.Message}");
            }
        }
    }
}
