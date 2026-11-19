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
        public static bool MaveNortusHQAvailable { get; set; } = false;
        public static bool MaveNortusHQCompleted { get; set; } = false;
        public static bool Phase2EventUnlocked { get; set; } = false;
        public static int StaffVictoryPoints { get; set; } = 0;

        // Per-city Phase I/II capture state (used in Mave Nortus debrief & outcomes)
        public static bool CapZilleCity { get; set; } = false;
        public static bool CapWiktrany { get; set; } = false;
        public static bool CapMunat { get; set; } = false;
        public static bool CapNanta { get; set; } = false;
        public static bool CapRotsla { get; set; } = false;
        public static bool CapGrodzizg { get; set; } = false;
        public static bool CapKratsna { get; set; } = false;
        public static bool CapIsor { get; set; } = false;
        public static int CapTotalCount { get; set; } = 0;

        public static void SetOperationVariant(ZilleOperationVariant variant)
        {
            CurrentVariant = variant;
            switch (variant)
            {
                case ZilleOperationVariant.PlanArk:
                    RomulusPlan = ZilleRomulusPlan.Ark;
                    CurrentPhase = ZilleOperationPhase.Phase1;
                    CurrentPhaseNumber = 1;
                    Phase1Finished = false;
                    MaveNortusHQAvailable = false;
                    MaveNortusHQCompleted = false;
                    Phase2EventUnlocked = false;
                    break;
                case ZilleOperationVariant.PlanSword:
                    RomulusPlan = ZilleRomulusPlan.Sword;
                    CurrentPhase = ZilleOperationPhase.Phase1;
                    CurrentPhaseNumber = 1;
                    Phase1Finished = false;
                    MaveNortusHQAvailable = false;
                    MaveNortusHQCompleted = false;
                    Phase2EventUnlocked = false;
                    break;
                case ZilleOperationVariant.PlanArkDerdia:
                    RomulusPlan = ZilleRomulusPlan.Ark;
                    CurrentPhase = ZilleOperationPhase.Phase1;
                    CurrentPhaseNumber = 1;
                    Phase1Finished = false;
                    MaveNortusHQAvailable = false;
                    MaveNortusHQCompleted = false;
                    Phase2EventUnlocked = false;
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
            ZilleWarTable.NotifyVariantChanged();
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
        public static bool HasDerdiaSabotageEvidence { get; set; } = false;
        public static bool IsDerdiaIncidentShared { get; set; } = false;
        public static bool IsDerdiaPactSigned { get; set; } = false;
        public static bool IsDerdiaPipelineInvested { get; set; } = false;
        public static bool IsDerdiaMissilesAgreed { get; set; } = false;
        public static bool IsDerdiaStateVisitDone { get; set; } = false;
        public static bool IsMotherCaptured { get; set; } = false;
        public static bool IsBrenasLost { get; set; } = false;

        /// <summary>Returns the current Rizia turn number (1-11), or 0 if unavailable.</summary>
        public static int GetCurrentTurn()
        {
            try
            {
                int t = DialogueHelper.GetIntVariable("RiziaDLC.Turn");
                if (t > 0) return t;
                var pm = Il2Cpp.PersistenceManager.Instance;
                var sd = pm?.activeSaveFile?.saveData;
                if (sd != null && sd.turnNo > 0) return sd.turnNo;
            }
            catch { }
            return 0;
        }

        /// <summary>True if Rizia has a strong baseline with Derdia to consider southern corridor talks.</summary>
        public static bool HasGoodDerdiaBasis()
        {
            return DialogueHelper.GetBoolVariable("RiziaDLC.CountryRelation_Derdia_Friendly")
                || DialogueHelper.GetBoolVariable("RiziaDLC.CountryRelation_Derdia_Allied")
                || DialogueHelper.GetBoolVariable("RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia")
                || DialogueHelper.GetIntVariable("RiziaDLC.Diplomacy_Derdia_NegotiatingPower") >= 2
                || HasDerdiaSabotageEvidence
                || IsDerdiaIncidentShared
                || IsDerdiaPactSigned;
        }

        // Economic Impact Trackers
        public static int GoldBudgetDrainPerTurn { get; set; } = 0;
        public static int EnergyDeficitPerTurn { get; set; } = 0;

        // Unit Tracking & Allocation
        public static int UnitsCommittedToPales { get; set; } = 0;
        public static int UnitsCommittedToZille { get; set; } = 0;

        // Separate Zille War Casualties (strictly isolated from Pales campaign counters!)
        public static int ZillePlayerUnitsLostPhase1 { get; set; } = 0;
        public static int ZillePlayerUnitsLostPhase2 { get; set; } = 0;
        public static int ZilleEnemyUnitsLostPhase1 { get; set; } = 0;
        public static int ZilleEnemyUnitsLostPhase2 { get; set; } = 0;
        public static int ZilleManpowerCasualties { get; set; } = 0;

        public static int ZillePlayerUnitsLostTotal => ZillePlayerUnitsLostPhase1 + ZillePlayerUnitsLostPhase2;
        public static int ZilleEnemyUnitsLostTotal => ZilleEnemyUnitsLostPhase1 + ZilleEnemyUnitsLostPhase2;

        // Read-only view of Pales front casualties
        public static int PalesPlayerUnitsLost =>
            DialogueHelper.GetIntVariable("RiziaDLC.War_Operation1_TotalPlayer_Dead")
            + DialogueHelper.GetIntVariable("RiziaDLC.War_Operation2_TotalPlayer_Dead");

        public static int PalesEnemyUnitsLost =>
            DialogueHelper.GetIntVariable("RiziaDLC.War_Operation1_TotalEnemy_Dead")
            + DialogueHelper.GetIntVariable("RiziaDLC.War_Operation2_TotalEnemy_Dead");

        // Accumulated Micro-Effects & Leverage
        public static int LeverageScore { get; set; } = 0;
        public static int WarReadinessScore { get; set; } = 0;
        public static int SmolakPressureScore { get; set; } = 0;
        public static int AnLegitimacyScore { get; set; } = 0;

        private static readonly string[] PalesProtectedUnitDeadVars = new[]
        {
            "RiziaDLC.Army_Unit_Infantry_Dead",
            "RiziaDLC.Army_Unit_Tank_Dead",
            "RiziaDLC.Army_Unit_Support_Dead",
            "RiziaDLC.Army_Unit_Mountaineer_Dead",
            "RiziaDLC.Army_Unit_Azaro_Dead",
            "RiziaDLC.Army_Unit_Sazon_Dead",
            "RiziaDLC.Army_Unit_Toras_Dead",
            "RiziaDLC.Army_Unit_GoldenGuard_Dead",
            "RiziaDLC.Army_Unit_Mercenary_Dead",
            "RiziaDLC.Army_Unit_Ship_Dead",
            "RiziaDLC.Army_Unit_Flagship_Dead",
            "RiziaDLC.Army_Unit_Submarine_Dead",
            "RiziaDLC.Army_Unit_Marine_Dead",
            "RiziaDLC.Army_Unit_Paratrooper_Dead",
            "RiziaDLC.War_Operation1_TotalPlayer_Dead",
            "RiziaDLC.War_Operation1_TotalEnemy_Dead",
            "RiziaDLC.War_Operation2_TotalPlayer_Dead",
            "RiziaDLC.War_Operation2_TotalEnemy_Dead"
        };

        private static readonly System.Collections.Generic.Dictionary<string, int> _palesDeadSnapshot =
            new System.Collections.Generic.Dictionary<string, int>();

        /// <summary>Snapshots Pales casualty ledgers before opening the Zille war table so Zille fights never pollute Pales stats.</summary>
        public static void SnapshotPalesCasualtiesBeforeZilleTable()
        {
            _palesDeadSnapshot.Clear();
            foreach (var v in PalesProtectedUnitDeadVars)
            {
                _palesDeadSnapshot[v] = DialogueHelper.GetIntVariable(v);
            }
            MelonLogger.Msg("[CASUALTIES] Snapshotted Pales casualty ledger prior to Zille war table.");
        }

        /// <summary>Restores Pales casualty ledgers on exit from Zille war table so Pales reports remain 100% accurate.</summary>
        public static void RestorePalesCasualtiesAfterZilleTable()
        {
            if (_palesDeadSnapshot.Count == 0) return;
            foreach (var kv in _palesDeadSnapshot)
            {
                DialogueHelper.SetVariable(kv.Key, kv.Value);
            }
            MelonLogger.Msg("[CASUALTIES] Restored Pales casualty ledger after Zille operation (separated from Zille losses).");
        }

        public static void RecordZilleLosses(int phaseNumber, int playerUnitsLost, int enemyUnitsLost)
        {
            int p = Math.Max(0, playerUnitsLost);
            int e = Math.Max(0, enemyUnitsLost);
            if (phaseNumber <= 1)
            {
                ZillePlayerUnitsLostPhase1 = p;
                ZilleEnemyUnitsLostPhase1 = e;
            }
            else
            {
                ZillePlayerUnitsLostPhase2 = p;
                ZilleEnemyUnitsLostPhase2 = e;
            }
            ZilleManpowerCasualties = ZillePlayerUnitsLostTotal * 1450;
            SyncToLua();
            MelonLogger.Msg($"[CASUALTIES] Zille Phase {phaseNumber}: PlayerLost={p}, EnemyLost={e} | ZilleTotalPlayerLost={ZillePlayerUnitsLostTotal}, PalesTotalPlayerLost={PalesPlayerUnitsLost}");
        }

        public static void AddMicroEffect(int leverageDelta = 0, int readinessDelta = 0, int pressureDelta = 0, int legitimacyDelta = 0)
        {
            SyncFromLua();
            LeverageScore += leverageDelta;
            WarReadinessScore += readinessDelta;
            SmolakPressureScore = Math.Max(0, SmolakPressureScore + pressureDelta);
            AnLegitimacyScore += legitimacyDelta;
            SyncToLua();
        }

        /// <summary>
        /// Maps SmolakPressureScore (and Pales two-front distraction) into one of the three
        /// Wehlen v14 deployment presets: "minimal", "suspicious", or "prepared".
        /// </summary>
        public static string GetSmolakSuspicionPreset(bool syncFromLua = true)
        {
            if (syncFromLua) SyncFromLua();
            int pressure = Math.Max(0, SmolakPressureScore);
            if (IsTwoFrontWarThreat() && pressure <= 3)
            {
                return "minimal";
            }
            if (pressure <= 2) return "minimal";
            if (pressure <= 5) return "suspicious";
            return "prepared";
        }

        /// <summary>
        /// Detects if Rizia is actively preparing for or at war with Pales.
        /// </summary>
        public static bool IsTwoFrontWarThreat()
        {
            try
            {
                // If Lespia pact was accepted, Pales war is called off!
                if (IsLespiaPactAccepted) return false;

                bool palesPrep = DialogueHelper.GetBoolVariable("RiziaDLC.Diplomacy_Pales_PrepareForWar");
                bool palesWar = DialogueHelper.GetBoolVariable("RiziaDLC.Diplomacy_Pales_DeclareWar");
                bool palesActive = DialogueHelper.GetBoolVariable("RiziaDLC.Pales_War");
                bool palesAtWar = DialogueHelper.GetBoolVariable("RiziaDLC.CountryRelation_Pales_AtWar");

                return palesPrep || palesWar || palesActive || palesAtWar;
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
                DialogueHelper.SetVariable("RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen", false);
                DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Wehlen_Hostile", true);
                DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Wehlen_AtWar", true);
                DialogueHelper.SetVariable("Zille_War_Active", true);

                // Malenyevist / Eastern relations drop
                DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Valgsland_Hostile", true);
                int morellaPower = DialogueHelper.GetIntVariable("RiziaDLC.Diplomacy_Morella_NegotiatingPower");
                DialogueHelper.SetVariable("RiziaDLC.Diplomacy_Morella_NegotiatingPower", morellaPower - 2);

                // Capitalist / Western relations rise (unless at war with Pales)
                if (!IsTwoFrontWarThreat())
                {
                    DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Lespia_Friendly", true);
                    DialogueHelper.SetVariable("RiziaDLC.Diplomacy_Lespia_WehlenHelp", true);
                }

                // Check Sordland (Anton Rayne) status regarding Bear Trap
                bool sordlandBearTrap = DialogueHelper.GetBoolVariable("BaseGame.Wehlen_JointOperation") ||
                                        DialogueHelper.GetBoolVariable("BaseGame.Policy_Diplomacy_Wehlen_JointOperation");
                if (sordlandBearTrap)
                {
                    DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Sordland_Unfriendly", true);
                    MelonLogger.Msg("[GEOPOLITICS] Sordland participated in Bear Trap: Diplomatic friction with Rizia over Wehlen attack.");
                }
                else
                {
                    DialogueHelper.SetVariable("RiziaDLC.CountryRelation_Sordland_Friendly", true);
                    MelonLogger.Msg("[GEOPOLITICS] Sordland rejected Bear Trap: Anton Rayne remains open to diplomatic channels.");
                }

                // Check Derdia Hybrid War & Southern Corridor Support (earned via Derdia Talks / State Visit)
                if (IsDerdiaHybridSupportActive || IsDerdiaPactSigned
                    || DialogueHelper.GetBoolVariable("Zille_DerdiaPact_Signed")
                    || DialogueHelper.GetBoolVariable("Zille_DerdiaHybridActive"))
                {
                    IsDerdiaHybridSupportActive = true;
                    DialogueHelper.SetVariable("Zille_Derdia_HybridWarfare", true);
                    DialogueHelper.SetVariable("Zille_DerdiaHybridActive", true);
                    MelonLogger.Msg("[GEOPOLITICS] Derdia alliance active: Golcondist irregulars & corridor support mobilized!");
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

                if (IsDerdiaPipelineInvested || DialogueHelper.GetBoolVariable("Zille_Derdia_PipelineInvested"))
                {
                    IsDerdiaPipelineInvested = true;
                    EnergyDeficitPerTurn = Math.Max(0, EnergyDeficitPerTurn - 2);
                    GoldBudgetDrainPerTurn = Math.Max(1, GoldBudgetDrainPerTurn - 1);
                    MelonLogger.Msg("[GEOPOLITICS] Derdia-Rizia Southern Pipeline offsets Wehzek crude cutoff and adds transit dividends!");
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
                DialogueHelper.SetVariable("Zille_Cap_ZilleCity", CapZilleCity);
                DialogueHelper.SetVariable("Zille_Cap_Wiktrany", CapWiktrany);
                DialogueHelper.SetVariable("Zille_Cap_Munat", CapMunat);
                DialogueHelper.SetVariable("Zille_Cap_Nanta", CapNanta);
                DialogueHelper.SetVariable("Zille_Cap_Rotsla", CapRotsla);
                DialogueHelper.SetVariable("Zille_Cap_Grodzizg", CapGrodzizg);
                DialogueHelper.SetVariable("Zille_Cap_Kratsna", CapKratsna);
                DialogueHelper.SetVariable("Zille_Cap_Isor", CapIsor);
                DialogueHelper.SetVariable("Zille_Cap_Count", CapTotalCount);

                bool isSword = (PlanType == ZillePlanType.Romulus && RomulusPlan == ZilleRomulusPlan.Sword)
                            || (PlanType == ZillePlanType.Staff && StaffPlan == ZilleStaffPlan.Sword)
                            || CurrentVariant == ZilleOperationVariant.PlanSword;
                DialogueHelper.SetVariable("Zille_Plan_IsSword", isSword);
                DialogueHelper.SetVariable("Zille_Plan_IsArk", !isSword);

                bool fightingPales = PalesPlayerUnitsLost > 0
                                  || PalesEnemyUnitsLost > 0
                                  || DialogueHelper.GetBoolVariable("RiziaDLC.Pales_War")
                                  || DialogueHelper.GetBoolVariable("RiziaDLC.Diplomacy_Pales_DeclareWar")
                                  || DialogueHelper.GetBoolVariable("RiziaDLC.CountryRelation_Pales_AtWar");
                DialogueHelper.SetVariable("Zille_Fighting_Pales", fightingPales);
                DialogueHelper.SetVariable("Zille_MaveNortusHQ_Available", MaveNortusHQAvailable);
                DialogueHelper.SetVariable("Zille_MaveNortusHQ_Completed", MaveNortusHQCompleted);
                DialogueHelper.SetVariable("Zille_Phase2_Unlocked", Phase2EventUnlocked);
                DialogueHelper.SetVariable("Zille_War_Outcome", (int)Outcome);
                DialogueHelper.SetVariable("Zille_Independent_Buffer", IsIndependentZilleAgreed);
                DialogueHelper.SetVariable("Zille_NavalBlockadeActive", IsNavalBlockadeActive);
                DialogueHelper.SetVariable("Zille_LespiaPactAccepted", IsLespiaPactAccepted);
                DialogueHelper.SetVariable("Zille_DerdiaHybridActive", IsDerdiaHybridSupportActive);
                DialogueHelper.SetVariable("Zille_Derdia_SabotageEvidence", HasDerdiaSabotageEvidence);
                DialogueHelper.SetVariable("Zille_Derdia_IncidentShared", IsDerdiaIncidentShared);
                DialogueHelper.SetVariable("Zille_DerdiaPact_Signed", IsDerdiaPactSigned);
                DialogueHelper.SetVariable("Zille_Derdia_PipelineInvested", IsDerdiaPipelineInvested);
                DialogueHelper.SetVariable("Zille_Derdia_MissilesAgreed", IsDerdiaMissilesAgreed);
                DialogueHelper.SetVariable("Zille_Derdia_StateVisitDone", IsDerdiaStateVisitDone);
                DialogueHelper.SetVariable("Zille_Derdia_GoodBasis", HasGoodDerdiaBasis());
                DialogueHelper.SetVariable("Zille_MotherCaptured", IsMotherCaptured);
                DialogueHelper.SetVariable("Zille_BrenasLost", IsBrenasLost);

                // Separate Zille vs Pales Casualty Ledgers
                DialogueHelper.SetVariable("War_Zille_TotalPlayerDead", ZillePlayerUnitsLostTotal);
                DialogueHelper.SetVariable("War_Zille_TotalEnemyDead", ZilleEnemyUnitsLostTotal);
                DialogueHelper.SetVariable("Zille_Phase1_PlayerDead", ZillePlayerUnitsLostPhase1);
                DialogueHelper.SetVariable("Zille_Phase1_EnemyDead", ZilleEnemyUnitsLostPhase1);
                DialogueHelper.SetVariable("Zille_Phase2_PlayerDead", ZillePlayerUnitsLostPhase2);
                DialogueHelper.SetVariable("Zille_Phase2_EnemyDead", ZilleEnemyUnitsLostPhase2);
                DialogueHelper.SetVariable("Zille_Manpower_Casualties", ZilleManpowerCasualties);
                DialogueHelper.SetVariable("Zille_Pales_TotalPlayerDead", PalesPlayerUnitsLost);
                DialogueHelper.SetVariable("Zille_Pales_TotalEnemyDead", PalesEnemyUnitsLost);

                // Accumulated Leverage / Readiness / Pressure / AN Legitimacy
                DialogueHelper.SetVariable("Zille_Leverage", LeverageScore);
                DialogueHelper.SetVariable("Zille_War_Readiness", WarReadinessScore);
                DialogueHelper.SetVariable("Zille_Smolak_Pressure", SmolakPressureScore);
                DialogueHelper.SetVariable("Zille_AN_Legitimacy", AnLegitimacyScore);

                // Convenience state snapshots for Lua dialogues (fleet, tanks, equipment tiers)
                int fleetTotal = DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Ship_Total")
                               + DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Flagship_Total")
                               + DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Submarine_Total");
                DialogueHelper.SetVariable("Zille_Fleet_Total", fleetTotal);
                ZilleReportsAndSituations.EnsureRegisteredAndSynced();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"Failed to sync Zille variables to Lua: {ex.Message}");
            }
        }

        public static void SyncFromLua()
        {
            try
            {
                string route = DialogueHelper.GetStringVariable("Zille_Logistics_Route");
                if (string.IsNullOrEmpty(route)) route = DialogueHelper.GetStringVariable("Zille_Logistics_House");
                if (!string.IsNullOrEmpty(route)) LogisticsRoute = route;

                if (DialogueHelper.GetBoolVariable("Zille_Rumburg_Munitions")) IsRumburgMunitionsActive = true;
                if (DialogueHelper.GetBoolVariable("Zille_Lespia_Intel")) IsLespiaIntelActive = true;
                if (DialogueHelper.GetBoolVariable("Zille_LespiaPactAccepted")) IsLespiaPactAccepted = true;
                if (DialogueHelper.GetBoolVariable("Zille_DerdiaHybridActive")) IsDerdiaHybridSupportActive = true;
                if (DialogueHelper.GetBoolVariable("Zille_Derdia_SabotageEvidence")) HasDerdiaSabotageEvidence = true;
                if (DialogueHelper.GetBoolVariable("Zille_Derdia_IncidentShared")) IsDerdiaIncidentShared = true;
                if (DialogueHelper.GetBoolVariable("Zille_DerdiaPact_Signed")) IsDerdiaPactSigned = true;
                if (DialogueHelper.GetBoolVariable("Zille_Derdia_PipelineInvested")) IsDerdiaPipelineInvested = true;
                if (DialogueHelper.GetBoolVariable("Zille_Derdia_MissilesAgreed")) IsDerdiaMissilesAgreed = true;
                if (DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitDone")) IsDerdiaStateVisitDone = true;
                if (DialogueHelper.GetBoolVariable("Zille_Independent_Buffer")) IsIndependentZilleAgreed = true;

                int outVal = DialogueHelper.GetIntVariable("Zille_War_Outcome");
                if (outVal >= 1 && outVal <= 5) Outcome = (ZilleWarOutcome)outVal;

                int p1P = DialogueHelper.GetIntVariable("Zille_Phase1_PlayerDead");
                int p1E = DialogueHelper.GetIntVariable("Zille_Phase1_EnemyDead");
                int p2P = DialogueHelper.GetIntVariable("Zille_Phase2_PlayerDead");
                int p2E = DialogueHelper.GetIntVariable("Zille_Phase2_EnemyDead");
                if (p1P > ZillePlayerUnitsLostPhase1) ZillePlayerUnitsLostPhase1 = p1P;
                if (p1E > ZilleEnemyUnitsLostPhase1) ZilleEnemyUnitsLostPhase1 = p1E;
                if (p2P > ZillePlayerUnitsLostPhase2) ZillePlayerUnitsLostPhase2 = p2P;
                if (p2E > ZilleEnemyUnitsLostPhase2) ZilleEnemyUnitsLostPhase2 = p2E;
                ZilleManpowerCasualties = ZillePlayerUnitsLostTotal * 1450;

                int lev = DialogueHelper.GetIntVariable("Zille_Leverage");
                int rdy = DialogueHelper.GetIntVariable("Zille_War_Readiness");
                int prs = DialogueHelper.GetIntVariable("Zille_Smolak_Pressure");
                int leg = DialogueHelper.GetIntVariable("Zille_AN_Legitimacy");
                if (DialogueHelper.HasVariable("Zille_Leverage") || lev != 0) LeverageScore = lev;
                if (DialogueHelper.HasVariable("Zille_War_Readiness") || rdy != 0) WarReadinessScore = rdy;
                if (DialogueHelper.HasVariable("Zille_Smolak_Pressure") || prs != 0) SmolakPressureScore = Math.Max(0, prs);
                if (DialogueHelper.HasVariable("Zille_AN_Legitimacy") || leg != 0) AnLegitimacyScore = leg;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"Failed to sync Zille variables from Lua: {ex.Message}");
            }
        }
    }
}
