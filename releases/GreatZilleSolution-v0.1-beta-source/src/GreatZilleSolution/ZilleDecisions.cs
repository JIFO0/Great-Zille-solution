using System;
using System.Collections.Generic;
using MelonLoader;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public class ModDecisionOptionDef
    {
        public string Id;
        public string Text;
        public string Condition;
        public Func<bool> IsAvailable;
        public Action OnSelected;
    }

    public class ModDecisionDef
    {
        public string Id;
        public string Title;
        public string Description;
        public string AssignedToken; // e.g. "Rizia_City_PorteDrazon", "Rizia_City_MaveNortus", "Rizia_City_Sallabes"
        public string DoneVar;
        public int MinTurn;
        public bool AllowInEarlyWar;
        public List<ModDecisionOptionDef> Options = new List<ModDecisionOptionDef>();
    }

    /// <summary>
    /// Manages normal-map (non-war-table) political & intelligence dilemmas and decisions,
    /// registering native DecisionData entries into EntityDataManager and exposing clean
    /// interactive decision panels on city tokens at the right turn timing.
    /// </summary>
    public static class ZilleDecisions
    {
        private static bool _registered = false;
        public static readonly List<ModDecisionDef> AllDecisions = new List<ModDecisionDef>();

        // Active UI modal fallback if native DecisionPanel isn't triggered directly
        public static ModDecisionDef ActiveModalDecision { get; private set; } = null;

        public static void EnsureRegistered()
        {
            if (_registered) return;
            BuildDefinitions();
            RegisterIntoEntityDataManager();
            _registered = true;
        }

        public static void OpenDecision(ModDecisionDef def)
        {
            if (def == null) return;
            // Try native DecisionPanel if available, otherwise open our clean IMGUI decision card
            ActiveModalDecision = def;
        }

        public static void CloseModal()
        {
            ActiveModalDecision = null;
        }

        private static void BuildDefinitions()
        {
            AllDecisions.Clear();

            // 1. TURN 4: Derdia-Wehlen Border Sabotage Investigation Dilemma
            AllDecisions.Add(new ModDecisionDef
            {
                Id = "Turn04_Decision_DerdiaWehlen_Sabotage",
                Title = "Sabotage Along the Derdia-Wehlen Border",
                Description = "Internal Security warns that coordinated explosions near Yol and Qerzan damaged a Derdian pumping station and Silver Garrison depots. Similar covert probes could soon threaten Rizia's Brenas frontier—yet uncovering proof of Wehlen's hand could also hand us decisive leverage in upcoming talks with both Azmal and Smolak.",
                AssignedToken = "Rizia_City_PorteDrazon",
                DoneVar = "Zille_Derdia_InvestigationDone",
                MinTurn = 4,
                AllowInEarlyWar = true,
                Options = new List<ModDecisionOptionDef>
                {
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Sabotage_Ignore",
                        Text = "It doesn't concern us [-1 Authority]",
                        Condition = "",
                        IsAvailable = () => true,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Authority", -1);
                            DialogueHelper.SetVariable("Zille_Derdia_InvestigationDone", true);
                            DialogueHelper.SetVariable("Zille_Derdia_InvestigationIgnored", true);
                            DialogueHelper.SetVariable("Zille_Derdia_SabotageEvidence", false);
                            ZilleCampaignState.HasDerdiaSabotageEvidence = false;
                            FinalizeDecision("Internal Security stood down on the Yol-Qerzan border blasts. Azmal's frontier troubles remain Derdia's alone.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Sabotage_FullInvestigation",
                        Text = "Launch a full investigation [+1 Authority, -1 Budget]",
                        Condition = "RiziaDLC.Resources_Budget >= 1",
                        IsAvailable = () => DialogueHelper.GetIntVariable("RiziaDLC.Resources_Budget") >= 1,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Authority", 1);
                            AddVar("RiziaDLC.Resources_Budget", -1);
                            DialogueHelper.SetVariable("Zille_Derdia_InvestigationDone", true);
                            DialogueHelper.SetVariable("Zille_Derdia_SabotageEvidence", true);
                            ZilleCampaignState.HasDerdiaSabotageEvidence = true;
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 2, readinessDelta: 1);
                            FinalizeDecision("Golden Guard and military investigators recovered Wehzek army detonators near Yol—arming Rizia with potent diplomatic leverage.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Sabotage_WehzekIntel",
                        Text = "Use Wehzek citizens for intel [+1 Authority]",
                        Condition = "Migrant Rights Decree enacted",
                        IsAvailable = () =>
                            DialogueHelper.GetBoolVariable("RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants")
                            || DialogueHelper.GetBoolVariable("RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"),
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Authority", 1);
                            // Quietly strains relations with Wehzek migrant communities
                            AddVar("RiziaDLC.Country_PublicOpinion", -1);
                            AddVar("RiziaDLC.Diplomacy_Wehlen_NegotiatingPower", -1);
                            DialogueHelper.SetVariable("Zille_WehzekCitizens_Exploited", true);
                            DialogueHelper.SetVariable("Zille_Derdia_InvestigationDone", true);
                            DialogueHelper.SetVariable("Zille_Derdia_SabotageEvidence", true);
                            ZilleCampaignState.HasDerdiaSabotageEvidence = true;
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 2, readinessDelta: 1);
                            FinalizeDecision("Informants among Rizia's Wehzek residents confirmed Wraclawitz sapper networks behind the Yol blasts—though quiet resentment lingers in migrant quarters.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Sabotage_UniversityCaseStudy",
                        Text = "Investigate it as a case study [-1 Authority]",
                        Condition = "Romus Toras University completed",
                        IsAvailable = () =>
                            DialogueHelper.GetBoolVariable("RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed"),
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Authority", -1);
                            DialogueHelper.SetVariable("Zille_Derdia_UniversityStudy", true);
                            DialogueHelper.SetVariable("Zille_Derdia_InvestigationDone", true);
                            DialogueHelper.SetVariable("Zille_Derdia_SabotageEvidence", true);
                            ZilleCampaignState.HasDerdiaSabotageEvidence = true;
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 2, legitimacyDelta: 1);
                            FinalizeDecision("Scholars and engineers at Romus Toras University reconstructed the Yol pipeline demolitions, publishing forensic proof pointing straight to Wraclawitz.");
                        }
                    }
                }
            });

            // 2. TURN 5+: Brenas Frontier Vigilance Dilemma (Mave Nortus)
            AllDecisions.Add(new ModDecisionDef
            {
                Id = "Turn05_Decision_Brenas_Vigilance",
                Title = "Frontier Vigilance Along Brenas",
                Description = "Following the Zille bombing and sabotage reports along Wehlen's southern borders, provincial magistrates in Mave Nortus warn that enemy infiltrators could probe Rizian railheads and granaries.",
                AssignedToken = "Rizia_City_MaveNortus",
                DoneVar = "Zille_Dec_BrenasVigilance_Done",
                MinTurn = 5,
                AllowInEarlyWar = true,
                Options = new List<ModDecisionOptionDef>
                {
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Brenas_GGCheckpoints",
                        Text = "Deploy Golden Guard checkpoints at railheads [-1 Budget, +1 Readiness, +1 Leverage]",
                        IsAvailable = () => DialogueHelper.GetIntVariable("RiziaDLC.Resources_Budget") >= 1,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Budget", -1);
                            DialogueHelper.SetVariable("Zille_Dec_BrenasVigilance_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_BrenasVigilance_GG", true);
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 1, readinessDelta: 1);
                            FinalizeDecision("Golden Guard detachments secured Mave Nortus rail sidings and uncovered covert Wehzek courier caches.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Brenas_SuOminaWatch",
                        Text = "Arm local Su Omina & ATA border watches [+1 Authority, +1 Pressure]",
                        IsAvailable = () => true,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Authority", 1);
                            DialogueHelper.SetVariable("Zille_Dec_BrenasVigilance_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_BrenasVigilance_Militia", true);
                            ZilleCampaignState.AddMicroEffect(pressureDelta: 1, legitimacyDelta: -1);
                            FinalizeDecision("Local loyalist watches sealed the river crossings, rattling Wehzek border patrols while drawing minor criticism in Kyrute.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Brenas_QuietCustoms",
                        Text = "Maintain discreet customs inspections [+1 Public Opinion]",
                        IsAvailable = () => true,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Country_PublicOpinion", 1);
                            DialogueHelper.SetVariable("Zille_Dec_BrenasVigilance_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_BrenasVigilance_Quiet", true);
                            FinalizeDecision("Brenas markets stayed calm under discreet customs patrols without alarming frontier towns.");
                        }
                    }
                }
            });

            // 3. TURN 6-7: Pre-Negotiations Legal & Backchannel Dossier (Porte Drazon)
            AllDecisions.Add(new ModDecisionDef
            {
                Id = "Turn06_Decision_Constantine_Leverage",
                Title = "Pre-Negotiations Leverage: The 1927 Expiration Brief",
                Description = "As diplomatic reckoning with Wiktor Smolak approaches, Foreign Minister Laurento Esquibel asks how Rizia should deploy its legal and intelligence findings before talks open.",
                AssignedToken = "Rizia_City_PorteDrazon",
                DoneVar = "Zille_Dec_LegalBrief_Done",
                MinTurn = 6,
                AllowInEarlyWar = true,
                Options = new List<ModDecisionOptionDef>
                {
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Legal_PressOffensive",
                        Text = "Circulate the 1927 treaty & sabotage dossier in Kyrute [-1 Budget, +2 Leverage, +2 AN Standing]",
                        IsAvailable = () => DialogueHelper.GetIntVariable("RiziaDLC.Resources_Budget") >= 1,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Budget", -1);
                            DialogueHelper.SetVariable("Zille_Dec_LegalBrief_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_LegalBrief_Press", true);
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 2, legitimacyDelta: 2);
                            FinalizeDecision("Konstantium correspondents received Rizia's bound legal brief, isolating Smolak's propaganda ahead of negotiations.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Legal_Backchannel",
                        Text = "Send a sealed ultimatum directly to Wraclawitz [+1 Authority, +2 Pressure, +1 Leverage]",
                        IsAvailable = () => true,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Authority", 1);
                            DialogueHelper.SetVariable("Zille_Dec_LegalBrief_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_LegalBrief_Ultimatum", true);
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 1, pressureDelta: 2);
                            FinalizeDecision("A private diplomatic courier delivered Rizia's red-lined terms straight to President Smolak's desk.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Legal_HoldCards",
                        Text = "Keep our evidence sealed for the negotiation table [+1 Leverage]",
                        IsAvailable = () => true,
                        OnSelected = () =>
                        {
                            DialogueHelper.SetVariable("Zille_Dec_LegalBrief_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_LegalBrief_Sealed", true);
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 1);
                            FinalizeDecision("Foreign Ministry archivists locked the evidence away so Smolak cannot prepare counter-lies before meeting you.");
                        }
                    }
                }
            });

            // 4. TURN 7: Gulf of Moridia Tanker Escorts (Sallabes)
            AllDecisions.Add(new ModDecisionDef
            {
                Id = "Turn07_Decision_Gulf_Escorts",
                Title = "Harassment of Rizian Freighters in the Gulf",
                Description = "Wehzek gunboats have begun stopping merchant ships near the Strait of Kreleck under 'anti-smuggling' pretexts, rattling Sallabes shipping houses right before crucial Zille talks.",
                AssignedToken = "Rizia_City_Sallabes",
                DoneVar = "Zille_Dec_GulfEscorts_Done",
                MinTurn = 7,
                AllowInEarlyWar = true,
                Options = new List<ModDecisionOptionDef>
                {
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Gulf_NavyEscort",
                        Text = "Sortie Royal Navy destroyers to escort freighters [-1 Energy, +2 Leverage, +1 Readiness]",
                        IsAvailable = () =>
                            DialogueHelper.GetIntVariable("RiziaDLC.Resources_Energy") >= 1
                            && (DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Ship_Total")
                                + DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Flagship_Total")
                                + DialogueHelper.GetIntVariable("RiziaDLC.Army_Unit_Submarine_Total")) >= 1,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Energy", -1);
                            DialogueHelper.SetVariable("Zille_Dec_GulfEscorts_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_GulfEscorts_Navy", true);
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 2, readinessDelta: 1);
                            FinalizeDecision("Rizian destroyers shadowed merchant convoys across the Gulf of Moridia, forcing Wehzek gunboats to back down.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Gulf_Insurance",
                        Text = "Underwrite merchant war-risk insurance [-1 Budget, +1 Public Opinion, +1 Leverage]",
                        IsAvailable = () => DialogueHelper.GetIntVariable("RiziaDLC.Resources_Budget") >= 1,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Budget", -1);
                            AddVar("RiziaDLC.Country_PublicOpinion", 1);
                            DialogueHelper.SetVariable("Zille_Dec_GulfEscorts_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_GulfEscorts_Insure", true);
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 1);
                            FinalizeDecision("Crown maritime guarantees kept Sallabes freighters sailing smoothly despite Wehzek harassment.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Gulf_Avoid",
                        Text = "Reroute freight along coastal shoals [-1 Authority]",
                        IsAvailable = () => true,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Authority", -1);
                            DialogueHelper.SetVariable("Zille_Dec_GulfEscorts_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_GulfEscorts_Avoid", true);
                            FinalizeDecision("Merchant captains hugged shallow coastal waters, avoiding clashes at the cost of royal prestige.");
                        }
                    }
                }
            });

            // 5. TURN 7-8: Displaced Families Along the Zille Frontier (Mave Nortus)
            AllDecisions.Add(new ModDecisionDef
            {
                Id = "Turn07_Decision_Displaced_Families",
                Title = "Displaced Families Crossing from Zille",
                Description = "Ahead of Wehlen's tightening grip on Zille, hundreds of Rizian and Bludish families are crossing into northern Brenas, straining Mave Nortus shelters while international observers watch.",
                AssignedToken = "Rizia_City_MaveNortus",
                DoneVar = "Zille_Dec_Displaced_Done",
                MinTurn = 7,
                AllowInEarlyWar = true,
                Options = new List<ModDecisionOptionDef>
                {
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Displaced_Relief",
                        Text = "Open Crown grain stores and clinics [-1 Budget, +2 AN Standing, +1 Leverage]",
                        IsAvailable = () => DialogueHelper.GetIntVariable("RiziaDLC.Resources_Budget") >= 1,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Budget", -1);
                            AddVar("RiziaDLC.Country_PublicOpinion", 1);
                            DialogueHelper.SetVariable("Zille_Dec_Displaced_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_Displaced_Relief", true);
                            ZilleCampaignState.AddMicroEffect(leverageDelta: 1, legitimacyDelta: 2);
                            FinalizeDecision("Royal relief clinics opened across Mave Nortus, earning praise from Kyrute observers and strengthening Rizia's moral claim.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Displaced_Screening",
                        Text = "Establish strict Golden Guard screening camps [+1 Authority, +1 Readiness]",
                        IsAvailable = () => true,
                        OnSelected = () =>
                        {
                            AddVar("RiziaDLC.Resources_Authority", 1);
                            DialogueHelper.SetVariable("Zille_Dec_Displaced_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_Displaced_Screen", true);
                            ZilleCampaignState.AddMicroEffect(readinessDelta: 1, legitimacyDelta: -1);
                            FinalizeDecision("Security screening camps prevented Wehzek agents from slipping south, though foreign papers criticized the barbed wire.");
                        }
                    },
                    new ModDecisionOptionDef
                    {
                        Id = "Opt_Displaced_PressShowcase",
                        Text = "Invite Kyrute journalists to interview refugees [+1 AN Standing, +1 Pressure]",
                        IsAvailable = () => true,
                        OnSelected = () =>
                        {
                            DialogueHelper.SetVariable("Zille_Dec_Displaced_Done", true);
                            DialogueHelper.SetVariable("Zille_Dec_Displaced_Press", true);
                            ZilleCampaignState.AddMicroEffect(pressureDelta: 1, legitimacyDelta: 1);
                            FinalizeDecision("Foreign correspondents filed poignant dispatches from Brenas exposing Smolak's repression in Zille.");
                        }
                    }
                }
            });
        }

        private static void AddVar(string varName, int delta)
        {
            int cur = DialogueHelper.GetIntVariable(varName);
            DialogueHelper.SetVariable(varName, cur + delta);
        }

        private static void FinalizeDecision(string alertMsg)
        {
            ZilleCampaignState.SyncFromLua();
            ZilleCampaignState.SyncToLua();
            ZilleReportsAndSituations.EnsureRegisteredAndSynced();
            DialogueHelper.ShowAlert(alertMsg);
            CloseModal();
        }

        public static bool IsDecisionAvailableForToken(ModDecisionDef def, string tokenName, string entityName)
        {
            if (def == null) return false;
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Civilian) return false;
            if (DialogueHelper.GetBoolVariable(def.DoneVar)) return false;

            bool matchesToken = false;
            if (def.AssignedToken == "Rizia_City_PorteDrazon" && (tokenName.Contains("PorteDrazon") || tokenName.Contains("Porte Drazon") || entityName.Contains("PorteDrazon")))
                matchesToken = true;
            else if (def.AssignedToken == "Rizia_City_MaveNortus" && (tokenName.IndexOf("Mave", StringComparison.OrdinalIgnoreCase) >= 0 || entityName.IndexOf("Mave", StringComparison.OrdinalIgnoreCase) >= 0))
                matchesToken = true;
            else if (def.AssignedToken == "Rizia_City_Sallabes" && (tokenName.IndexOf("Sallabes", StringComparison.OrdinalIgnoreCase) >= 0 || entityName.IndexOf("Sallabes", StringComparison.OrdinalIgnoreCase) >= 0))
                matchesToken = true;

            if (!matchesToken) return false;

            int turn = ZilleCampaignState.GetCurrentTurn();
            bool earlyWar = DialogueHelper.GetBoolVariable("Zille_War_EarlyLaunch") || DialogueHelper.GetBoolVariable("Zille_War_Active");
            if (turn == 0) return true; // fallback outside standard turn counter
            if (turn >= def.MinTurn) return true;
            if (def.AllowInEarlyWar && earlyWar && turn >= 3) return true;
            return false;
        }

        private static void RegisterIntoEntityDataManager()
        {
            try
            {
                var list = EntityDataManager.AllDecisionsData ?? EntityDataManager.DecisionsData;
                if (list == null) return;

                var props = new AppBundleProperties("StoryPack_Rizia");
                if (props.StoryPacks == null) props.StoryPacks = new Il2CppSystem.Collections.Generic.List<string>();
                if (!props.StoryPacks.Contains("StoryPack_Rizia")) props.StoryPacks.Add("StoryPack_Rizia");

                foreach (var def in AllDecisions)
                {
                    bool exists = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        var d = list[i];
                        if (d != null && (d.NameInDatabase == def.Id || d.Id == def.Id)) { exists = true; break; }
                    }
                    if (exists) continue;

                    var dd = new DecisionData();
                    dd.Id = def.Id;
                    dd.NameInDatabase = def.Id;
                    dd.Path = "Rizia/Decisions/Zille";
                    dd.IsWIP = false;
                    dd.Notes = "";
                    dd.AppBundleProperties = props;
                    dd.TagsProperties = new TagsProperties();
                    dd.AssignedTokenProperties = new AssignedTokenProperties();
                    dd.AssignedTokenProperties.AssignedToken = def.AssignedToken;
                    dd.DecisionProperties = new DecisionProperties();
                    dd.DecisionProperties.Title = def.Title;
                    dd.DecisionProperties.HubTitle = def.Title;
                    dd.DecisionProperties.Description = def.Description;
                    dd.DecisionProperties.HubDescription = def.Title;
                    dd.StoryFragmentProperties = new StoryFragmentProperties();
                    dd.StoryFragmentProperties.IsDone = false;
                    dd.StoryFragmentProperties.StoryFragmentCondition = "";
                    dd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
                    dd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
                    list.Add(dd);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[ZILLE DECISIONS] RegisterIntoEntityDataManager error: {ex.Message}");
            }
        }
    }
}
