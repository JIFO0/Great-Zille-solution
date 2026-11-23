using System;
using System.Collections.Generic;
using MelonLoader;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    /// <summary>
    /// Registers and dynamically synchronizes a comprehensive set of Situations and Reports
    /// covering every military, diplomatic, economic, welfare, legal, and internal facet
    /// of the Great Zille campaign.
    /// </summary>
    public static class ZilleReportsAndSituations
    {
        private static bool _registered = false;

        public static void EnsureRegisteredAndSynced()
        {
            try
            {
                RegisterAllSituations();
                RegisterAllReports();
                _registered = true;
                SyncVariables();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[ZILLE REPORTS/SITUATIONS] EnsureRegisteredAndSynced error: {ex.Message}");
            }
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

        private static void AddOrUpdateSituation(
            Il2CppSystem.Collections.Generic.List<SituationData> list,
            string id,
            string title,
            string desc,
            string category,
            string severity,
            string enableVar)
        {
            if (list == null) return;
            SituationData existing = null;
            for (int i = 0; i < list.Count; i++)
            {
                var s = list[i];
                if (s != null && (s.NameInDatabase == id || s.Id == id))
                {
                    existing = s;
                    break;
                }
            }

            if (existing == null)
            {
                existing = new SituationData();
                existing.Id = id;
                existing.NameInDatabase = id;
                existing.Path = "Rizia/Situations/Zille";
                existing.IsWIP = false;
                existing.Notes = "";
                existing.SituationProperties = new SituationProperties();
                existing.OverviewCategoryProperties = new OverviewCategoryProperties();
                existing.AppBundleProperties = CreateRiziaBundleProps();
                existing.TagsProperties = new TagsProperties();
                list.Add(existing);
            }

            if (existing.SituationProperties == null) existing.SituationProperties = new SituationProperties();
            existing.SituationProperties.IsEnabledVariable = enableVar;
            existing.SituationProperties.Title = title;
            existing.SituationProperties.Description = desc;
            existing.SituationProperties.SituationSeverityString = severity;
            existing.SituationProperties.IsNotificationActive = true;

            if (existing.OverviewCategoryProperties == null) existing.OverviewCategoryProperties = new OverviewCategoryProperties();
            existing.OverviewCategoryProperties.OverviewCategoryString = category;
        }

        private static void AddOrUpdateReport(
            Il2CppSystem.Collections.Generic.List<ReportData> list,
            string id,
            string title,
            string desc,
            string enableVar,
            int turnNo = 8,
            string token = "Rizia_City_PorteDrazon")
        {
            if (list == null) return;
            ReportData existing = null;
            for (int i = 0; i < list.Count; i++)
            {
                var r = list[i];
                if (r != null && (r.NameInDatabase == id || r.Id == id))
                {
                    existing = r;
                    break;
                }
            }

            if (existing == null)
            {
                existing = new ReportData();
                existing.Id = id;
                existing.NameInDatabase = id;
                existing.Path = "Rizia/Reports/Zille";
                existing.IsWIP = false;
                existing.Notes = "";
                existing.ReportProperties = new ReportProperties();
                existing.AssignedTokenProperties = new AssignedTokenProperties();
                existing.AssignedTokenProperties.AssignedToken = token;
                existing.AppBundleProperties = CreateRiziaBundleProps();
                existing.TagsProperties = new TagsProperties();
                list.Add(existing);
            }

            if (existing.ReportProperties == null) existing.ReportProperties = new ReportProperties();
            existing.ReportProperties.TurnNo = turnNo;
            existing.ReportProperties.IsEnabledVariable = enableVar;
            existing.ReportProperties.Title = title;
            existing.ReportProperties.Description = desc;
            existing.ReportProperties.IsDone = false;
            existing.ReportProperties.IsNotificationActive = true;
        }

        private static void RegisterAllSituations()
        {
            var sits = EntityDataManager.situationsData ?? EntityDataManager.SituationsData;
            if (sits == null) return;

            // Military
            AddOrUpdateSituation(sits, "Sit_Zille_Mobilization",
                "Brenas Frontier Mobilized",
                "Royal Army divisions and reserve brigades are staged along the Brenas-Zille border ahead of potential operations to enforce the lapsed 1927 agreement.",
                "Military", "Medium", "Zille_Sit_Mobilization");

            AddOrUpdateSituation(sits, "Sit_Zille_Sword_Offensive",
                "Operation Golden Sword Active",
                "Rizian armored spearheads and infantry corps are driving overland across the Brenas-Zille frontier toward Wiktrany, Munat, and Zille City.",
                "Military", "High", "Zille_Sit_Sword");

            AddOrUpdateSituation(sits, "Sit_Zille_Ark_Amphibious",
                "Operation Golden Ark Active",
                "The Royal Navy and amphibious brigades are executing a flank envelopment across the Gulf of Moridia against mainland Wehzek supply ports.",
                "Military", "High", "Zille_Sit_Ark");

            AddOrUpdateSituation(sits, "Sit_Zille_Naval_Blockade",
                "Strait of Kreleck Blockaded",
                "Destroyer flotillas from Monqiz are interdicting Wehzek cargo convoys across the Strait of Kreleck and Gulf of Moridia.",
                "Military", "Medium", "Zille_NavalBlockadeActive");

            AddOrUpdateSituation(sits, "Sit_Zille_TwoFront_War",
                "Two-Front War Strain (Zille & Pales)",
                "Simultaneous hostilities against Wehlen in the northwest and Pales in the east are splitting ammunition trains, medical units, and treasury reserves.",
                "Military", "High", "Zille_Fighting_Pales");

            AddOrUpdateSituation(sits, "Sit_Zille_Arsenal_Shortage",
                "Critical Arsenal Deficit",
                "Strategic depots hold fewer than 1,000 reserve weapons. Prolonged attrition will outpace domestic replacements unless foreign munitions arrive.",
                "Military", "High", "Zille_Sit_ArsenalLow");

            AddOrUpdateSituation(sits, "Sit_Zille_Arsenal_Surplus",
                "Well-Stocked Royal Arsenals",
                "Royal depots hold over 1,000 reserve rifles, machine guns, and artillery shells, enabling sustained offensive tempo.",
                "Military", "Low", "Zille_Sit_ArsenalHigh");

            AddOrUpdateSituation(sits, "Sit_Zille_Derdia_Raids",
                "Derdian Cross-Border Raids",
                "Golcondist irregulars from the Silver Garrison are raiding Wehlen's southern supply roads, forcing Wraclawitz to divert brigades away from Zille.",
                "Military", "Medium", "Zille_Sit_DerdiaRaids");

            AddOrUpdateSituation(sits, "Sit_Derdia_BorderSabotage",
                "Derdia-Wehlen Border Sabotage",
                "Mysterious explosions along the mountain passes near Yol and Qerzan have damaged Derdian pumping stations and Silver Garrison depots, prompting Wehzek troop build-ups near Grodzizg.",
                "Diplomacy", "Medium", "Zille_Derdia_SabotageSignals");

            AddOrUpdateSituation(sits, "Sit_Derdia_Corridor_Pact",
                "Derdian Southern War Corridor",
                "Under the Silver Garrison Accord, Supreme Wiseman Azmal has opened Derdia's northern frontier near Yol and Qerzan as a staging corridor for Rizian divisions.",
                "Military", "Low", "Zille_Sit_DerdiaCorridor");

            AddOrUpdateSituation(sits, "Sit_Derdia_Pipeline_Corridor",
                "Derdia-Rizia Southern Energy Pipeline",
                "Jointly financed energy infrastructure bypassing Wehlen delivers steady crude and transit dividends to Rizia's war economy.",
                "Economy", "Low", "Zille_Derdia_PipelineInvested");

            AddOrUpdateSituation(sits, "Sit_Zille_Lespia_Recon",
                "ATO Aerial Reconnaissance",
                "High-altitude Lespian reconnaissance flights are feeding real-time coordinates of Wehzek bunkers and artillery batteries to the General Staff.",
                "Military", "Low", "Zille_Lespia_Intel");

            AddOrUpdateSituation(sits, "Sit_Zille_Rumburg_Shells",
                "Rumburgian 152mm Munitions Corridor",
                "Heavy ordnance trains from Thornbourgh are delivering 152mm shells and reserve rifles directly into Brenas staging yards.",
                "Military", "Low", "Zille_Rumburg_Munitions");

            AddOrUpdateSituation(sits, "Sit_Smolak_Alert_Minimal",
                "Wehzek Border Posture: Complacent Garrisons",
                "Royal intelligence assesses that President Smolak remains off-guard along the Gulf and Zille frontier. Wehlen holds forward border units at peacetime readiness without massed strike reserves.",
                "Military", "Low", "Zille_Sit_SmolakMinimal");

            AddOrUpdateSituation(sits, "Sit_Smolak_Alert_Suspicious",
                "Wehzek Border Posture: Heightened Coastal Vigilance",
                "Growing friction and frontier preparations have alerted Wraclawitz. Smolak's frontier commanders have reinforced coastal batteries, river crossings, and Gulf patrols across Zille.",
                "Military", "Medium", "Zille_Sit_SmolakSuspicious");

            AddOrUpdateSituation(sits, "Sit_Smolak_Alert_Prepared",
                "Wehzek Border Posture: Full Combat Mobilization",
                "Smolak anticipates a Rizian offensive. Wehlen has deployed sixty mainland and colonial land formations, deep air-defense screens, and border strike groups along both Brenas and the Derdian frontier.",
                "Military", "High", "Zille_Sit_SmolakPrepared");

            // Economy
            AddOrUpdateSituation(sits, "Sit_Zille_Oil_Cutoff",
                "Wehzek Crude Oil Cutoff",
                "Hostilities with Wehlen have severed northern crude deliveries, tightening Rizia's energy grid and increasing diesel rationing pressure.",
                "Economy", "High", "Zille_Sit_OilCutoff");

            AddOrUpdateSituation(sits, "Sit_Zille_Sazon_Logistics",
                "Sazon Coastal Supply Network",
                "House Sazon's merchant syndicates and coastal freighters off Sallabes are supplying the front while shielding Brenas towns from military requisition.",
                "Economy", "Low", "Zille_Sit_LogSazon");

            AddOrUpdateSituation(sits, "Sit_Zille_Azaro_Requisition",
                "Azaro Military Rail Priority",
                "House Azaro holds full requisition authority over Brenas railways and fuel depots, maximizing armored tempo at heavy energy cost.",
                "Economy", "Medium", "Zille_Sit_LogAzaro");

            AddOrUpdateSituation(sits, "Sit_Zille_Joint_LogBoard",
                "Crown Joint Logistical Board",
                "Minister Elena Werner oversees a balanced supply board coordinating military munitions trains with civilian Brenas granaries.",
                "Economy", "Low", "Zille_Sit_LogCompromise");

            // Welfare
            AddOrUpdateSituation(sits, "Sit_Zille_Refugee_Wave",
                "Displaced Zille Families in Brenas",
                "Thousands of Rizian civilians fleeing Wehzek demolition teams have crowded into Mave Nortus and northern Brenas towns.",
                "Welfare", "Medium", "Zille_Sit_Refugees");

            AddOrUpdateSituation(sits, "Sit_Zille_Refugee_Relief",
                "Crown Refugee Relief Active",
                "Emergency royal grain, coal, and field clinics are sheltering displaced Zille families across northern Brenas.",
                "Welfare", "Low", "Zille_Refugee_Aid_Granted");

            // Law & Order
            AddOrUpdateSituation(sits, "Sit_Zille_Bombing_Dossier",
                "Sealed Zille Bombing Dossier",
                "Verified intelligence on foreign complicity in the Zille Friendship Day bombing gives the Crown potent diplomatic leverage.",
                "Law", "Medium", "Zille_Sit_HasDossier");

            AddOrUpdateSituation(sits, "Sit_Zille_Underground_Cells",
                "Loyalist Underground Active in Zille",
                "Su Omina and ATA cells inside occupied Zille are disrupting Wehzek telegraphs and safeguarding Queen Mother Estela's old harbor quarter.",
                "Order", "Medium", "Zille_Sit_Underground");

            // Diplomacy & Outcomes
            AddOrUpdateSituation(sits, "Sit_Zille_AN_Legitimacy",
                "Favorable AN Legal Standing",
                "Strict adherence to the expired 1927 treaty and civilian protections has earned Rizia quiet legal credibility in Konstantium.",
                "Diplomacy", "Low", "Zille_Sit_ANHigh");

            AddOrUpdateSituation(sits, "Sit_Zille_AN_Outcry",
                "International Sanctions Pressure",
                "Rumburgian rivals and Malenyevist delegates at the Alliance of Nations are pressing for sanctions over Rizian military escalation.",
                "Diplomacy", "High", "Zille_Sit_ANOutcry");

            AddOrUpdateSituation(sits, "Sit_Zille_EarlyArk_Sanctions",
                "International Outrage: Mainland Wehlen Raid",
                "Landing Rizian troops on mainland Wehlen under Operation Golden Ark while publicly proclaiming a peaceful Valero treaty handover has triggered fierce condemnation across Konstantium.",
                "Diplomacy", "High", "Zille_EarlyArk_Backlash");

            AddOrUpdateSituation(sits, "Sit_Zille_BombingLie_Scrutiny",
                "Foreign Scrutiny Over Bombing Claim",
                "King Romus's broadcast accusation that Wehlen fabricated the Friendship Day bombing electrified the home front, yet foreign intelligence attachés in Kyrute are openly questioning the nonexistent dossier.",
                "Diplomacy", "Medium", "Zille_Speech_LiedAboutBombing");

            AddOrUpdateSituation(sits, "Sit_Zille_Outcome_Restored",
                "Zille Reunited with Rizia",
                "The Treaty of Zille has restored Rizia's historic northwestern province to the Crown after more than twenty-five years of separation.",
                "Diplomacy", "Low", "Zille_Sit_OutcomeRestored");

            AddOrUpdateSituation(sits, "Sit_Zille_Outcome_Buffer",
                "Independent Neutral State of Zille",
                "Zille now operates as a demilitarized neutral republic under Alliance of Nations oversight and guaranteed Strait of Kreleck transit.",
                "Diplomacy", "Medium", "Zille_Independent_Buffer");

            AddOrUpdateSituation(sits, "Sit_Zille_Outcome_Armistice",
                "Armed Truce on the Brenas Line",
                "An uneasy armistice holds along the pre-war Brenas frontier while Zille remains outside Rizian administration.",
                "Order", "High", "Zille_Sit_OutcomeArmistice");

            AddOrUpdateSituation(sits, "Sit_Zille_Outcome_BrenasLost",
                "Southern Brenas Conceded — Unrest",
                "Humiliating territorial concessions in southern Brenas have sparked outrage among House Azaro officers and whispers of mutiny.",
                "Order", "High", "Brenas_Lost_To_Wehlen");

            AddOrUpdateSituation(sits, "Sit_Zille_Grodzizg_FreeCity",
                "Free City of Grodzizg Protected",
                "Following Rizia's overwhelming victory, Grodzizg enjoys autonomous Free City status guaranteed by the Treaty of Zille.",
                "Diplomacy", "Low", "Grodzizg_FreeCity");
        }

        private static void RegisterAllReports()
        {
            var reps = EntityDataManager.reportsData ?? EntityDataManager.ReportsData;
            if (reps == null) return;

            AddOrUpdateReport(reps, "Rep_Zille_WarPlanning_Complete",
                "Crown Council: Zille Strategic Blueprint",
                "The emergency Crown Council in Palas Rezna has audited Rizia's arsenals, energy margins, and foreign alignments, authorizing preliminary staging for the reclamation of Zille.",
                "Zille_War_Planning_Done");

            AddOrUpdateReport(reps, "Rep_Zille_Emergency_Arms",
                "Quartermaster: Emergency Arms Delivered",
                "Expedited royal funds procured 500 crates of reserve rifles and artillery shells, bolstering Brenas frontier depots ahead of mobilization.",
                "Zille_Emergency_Arms_Bought");

            AddOrUpdateReport(reps, "Rep_Zille_Logistics_Sazon",
                "Logistics Decree: House Sazon Syndicates",
                "Brenas rear logistics have been entrusted to House Sazon's coastal freighters and grain guilds, sparing strategic fuel reserves and protecting civilian towns.",
                "Zille_Sit_LogSazon");

            AddOrUpdateReport(reps, "Rep_Zille_Logistics_Azaro",
                "Logistics Decree: House Azaro Rail Priority",
                "House Azaro's quartermasters now hold full requisition authority over Brenas railways and fuel depots to sustain maximum armored offensive tempo.",
                "Zille_Sit_LogAzaro");

            AddOrUpdateReport(reps, "Rep_Zille_Logistics_Compromise",
                "Logistics Decree: Joint Logistical Board",
                "Minister Elena Werner's Joint Logistical Board now balances military ammunition trains with Sazon coastal barges and civilian grain protection.",
                "Zille_Sit_LogCompromise");

            AddOrUpdateReport(reps, "Rep_Zille_Naval_Blockade",
                "Admiralty: Strait of Kreleck Blockaded",
                "Destroyer squadrons from Monqiz have sealed the Strait of Kreleck and Gulf of Moridia, interdicting Wehzek cargo steamers bound for Zille.",
                "Zille_NavalBlockadeActive");

            AddOrUpdateReport(reps, "Rep_Zille_AN_PreBrief",
                "Foreign Ministry: 1927 Treaty Dossier Circulated",
                "Rizian envoys in Konstantium have distributed formal legal proof of Wehlen's expired 1927 lease to Alliance of Nations delegations.",
                "Zille_AN_PreBrief_Sent");

            AddOrUpdateReport(reps, "Rep_Derdia_Sabotage_Turn3",
                "Intelligence Alert: Explosions on the Derdia-Wehlen Border",
                "Reports from the mountain passes near Yol and Qerzan indicate coordinated sabotage against a Derdian pipeline pumping station and Silver Garrison supply dumps. Wraclawitz blames smugglers, though the demolitions bear military signatures.",
                "Zille_Derdia_SabotageSignals", 3);

            AddOrUpdateReport(reps, "Rep_Derdia_Investigation_Turn4",
                "Border Dossier: Wehzek Sabotage Confirmed",
                "Rizian intelligence officers investigating the Yol-Qerzan frontier recovered military-grade detonators and encrypted supply orders linking the border sabotage directly to Wehlen's interior security apparatus.",
                "Zille_Rep_DerdiaSabotageConfirmed", 4);

            AddOrUpdateReport(reps, "Rep_Derdia_StateVisit_Pact",
                "Silver Garrison: Rizian-Derdian Alliance Sealed",
                "During King Romus's warm diplomatic reception in Derdia, Supreme Wiseman Azmal authorized a joint defensive corridor for Rizian forces and a lucrative southern energy pipeline.",
                "Zille_DerdiaPact_Signed", 6);

            AddOrUpdateReport(reps, "Rep_Zille_Derdia_Accord",
                "Naeal Dispatch: Derdian Border Raids",
                "Supreme Wiseman Jorga Azmal has committed three thousand Golcondist irregulars to raid Wehlen's southern supply depots, pinning down Wehzek reserves.",
                "Zille_DerdiaHybridActive");

            AddOrUpdateReport(reps, "Rep_Zille_Derdia_Rejected",
                "Naeal Dispatch: Derdian Talks Collapsed",
                "Negotiations with Supreme Wiseman Azmal ended without agreement; Derdian irregulars remain behind their mountain frontier.",
                "Zille_Rep_DerdiaRejected");

            AddOrUpdateReport(reps, "Rep_Zille_Lespia_Intel",
                "Perla Hotline: ATO Aerial Recon Secured",
                "Lespian reconnaissance sorties are delivering high-altitude photography of Wehlen's fortified bunkers and reserve depots across Zille.",
                "Zille_Lespia_Intel");

            AddOrUpdateReport(reps, "Rep_Zille_Lespia_Rejected",
                "Perla Hotline: Lespian Talks Broken Off",
                "Prime Minister Alvarez refused intelligence cooperation after talks deadlocked; the Royal Army operates without ATO aerial spotting.",
                "Zille_Rep_LespiaRejected");

            AddOrUpdateReport(reps, "Rep_Zille_Rumburg_Aid",
                "Thornbourgh Cable: Rumburgian Munitions",
                "Queen Beatrice Livingston has dispatched heavy 152mm artillery shell trains and reserve rifles toward Brenas alongside GRACE diplomatic cover.",
                "Zille_Rumburg_Munitions");

            AddOrUpdateReport(reps, "Rep_Zille_Balcony_Speech",
                "Palas Rezna: Royal Proclamation of War",
                "Before forty thousand citizens on the Royal Plaza and live radio across the realm, King Romus proclaimed Rizia's determination to reclaim Zille.",
                "Zille_BalconySpeech_Done");

            AddOrUpdateReport(reps, "Rep_Zille_Phase1_Summary",
                "General Staff: Phase I After-Action Report",
                "Opening operations across the Zille theater have concluded. Forward regiments are rotating to Mave Nortus railheads to rearm for Phase II.",
                "Zille_Rep_Phase1Done");

            AddOrUpdateReport(reps, "Rep_Zille_MaveNortus_HQ",
                "Mave Nortus HQ: Phase II Staging Ordered",
                "Following the frontline council at Mave Nortus Mayor's Hall, regrouped Rizian divisions are advancing to their Phase II jump-off positions.",
                "Zille_MaveNortusHQ_Completed");

            AddOrUpdateReport(reps, "Rep_Zille_Refugee_Aid",
                "Mave Nortus: Crown Refugee Relief",
                "Royal grain, coal, and field clinics have been established across Mave Nortus for more than four thousand Rizians displaced from Zille.",
                "Zille_Refugee_Aid_Granted");

            AddOrUpdateReport(reps, "Rep_Zille_HomeFront_Crisis",
                "Cabinet Report: Wartime Home Front Measures",
                "The Crown Cabinet enacted emergency energy, refugee, and diplomatic measures to stabilize Rizia's home front during the Zille campaign.",
                "Zille_HomeFrontCrisis_Done");

            AddOrUpdateReport(reps, "Rep_Zille_Phase2_Summary",
                "General Staff: Phase II Final Operations",
                "The decisive second phase of the Zille campaign has concluded. Both armies stand in temporary ceasefire pending high-level parley.",
                "Zille_Rep_Phase2Done");

            AddOrUpdateReport(reps, "Rep_Zille_Smolak_Parley",
                "Border Pavilion: Smolak Parley Concluded",
                "King Romus and President Wiktor Smolak concluded face-to-face ceasefire negotiations at the neutral military pavilion on the Zille frontier.",
                "Zille_Rep_ParleyDone");

            AddOrUpdateReport(reps, "Rep_Zille_Reparations_Won",
                "Exchequer: Wehzek War Indemnities Secured",
                "Leveraging military and diplomatic pressure, Rizia compelled Wehlen to pay gold reconstruction credits and emergency crude deliveries.",
                "Zille_Reparations_Won");

            AddOrUpdateReport(reps, "Rep_Zille_Peace_Treaty",
                "Palas Rezna: Treaty of Zille Ratified",
                "Before foreign ambassadors and the noble estates of Rizia, the Great Seal was affixed to the Treaty of Zille, formally ending the war.",
                "Zille_Rep_TreatyDone");

            AddOrUpdateReport(reps, "Rep_Zille_Zille_Liberation",
                "Zille City: Royal Administration Established",
                "King Romus and Queen Mother Estela entered liberated Zille City, establishing post-war civil administration and harbor reconstruction.",
                "Zille_Liberation_Done");

            AddOrUpdateReport(reps, "Rep_Zille_TwoFront_Audit",
                "General Staff: Two-Front Casualty Audit",
                "Separate operational ledgers track Zille front casualties independently from ongoing eastern engagements against Pales.",
                "Zille_Fighting_Pales");

            // Additional Vanilla-Style Reports for Decisions, Early/Late Escalation, & Derdia Pipeline
            AddOrUpdateReport(reps, "Rep_Derdia_Sabotage_Ignored",
                "Internal Security: Yol-Qerzan Inquiry Declined",
                "By royal instruction, Internal Security declined to investigate the Derdia-Wehlen border blasts, leaving Naeal to confront Wraclawitz alone.",
                "Zille_Derdia_InvestigationIgnored", 4, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Derdia_WehzekIntel_Used",
                "Internal Security: Migrant Informant Network",
                "Discreet questioning among Rizia's naturalized Wehzek residents yielded corroborating intelligence on Wraclawitz sapper units near Yol, though quiet unease has spread through migrant quarters.",
                "Zille_WehzekCitizens_Exploited", 4, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Derdia_University_Study",
                "Romus Toras University: Forensic Frontier Study",
                "Scholars and engineering faculty at Romus Toras University published an independent forensic reconstruction tracing the Yol-Qerzan pipeline demolitions to regular Wehzek ordnance.",
                "Zille_Derdia_UniversityStudy", 4, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Derdia_Pipeline_Operational",
                "Ministry of Energy: Southern Pipeline Charter",
                "Joint Rizian-Derdian engineering teams broke ground on the southern pipeline corridor bypassing Wehlen, stabilizing Rizia's crude supply and securing coastal transit dividends.",
                "Zille_Derdia_PipelineInvested", 6, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Derdia_Missile_Battery",
                "General Staff: Derdian Missile Cooperation",
                "Derdian ballistic rocketeers positioned along the northern mountain passes are coordinating targeting corridors with Rizian artillery observers.",
                "Zille_Derdia_MissilesAgreed", 6, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Brenas_Vigilance_GG",
                "Mave Nortus: Golden Guard Rail Checkpoints",
                "Golden Guard detachments established fortified inspection checkpoints at Mave Nortus rail sidings, intercepting suspicious courier traffic from across the frontier.",
                "Zille_Dec_BrenasVigilance_GG", 5, "Rizia_City_MaveNortus");

            AddOrUpdateReport(reps, "Rep_Brenas_Vigilance_Militia",
                "Mave Nortus: Loyalist Frontier Watches",
                "Armed Su Omina and ATA volunteers now patrol the river crossings north of Mave Nortus, deterring Wehzek probes while drawing sharp remarks from foreign envoys.",
                "Zille_Dec_BrenasVigilance_Militia", 5, "Rizia_City_MaveNortus");

            AddOrUpdateReport(reps, "Rep_Brenas_Vigilance_Quiet",
                "Mave Nortus: Routine Customs Inspections",
                "Provincial customs officers quietly stepped up freight checks along the Brenas border without disturbing local grain markets.",
                "Zille_Dec_BrenasVigilance_Quiet", 5, "Rizia_City_MaveNortus");

            AddOrUpdateReport(reps, "Rep_Kyrute_Press_Brief",
                "Foreign Ministry: 1927 Expiration Brief Published",
                "Konstantium newspapers published Rizia's bound legal dossier on the lapsed 1927 Zille treaty and frontier sabotage, putting Wehlen's delegation on the defensive.",
                "Zille_Dec_LegalBrief_Press", 6, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Wraclawitz_Backchannel",
                "Foreign Ministry: Sealed Ultimatum Delivered",
                "A royal diplomatic courier placed Rizia's red-lined sovereignty terms directly onto President Smolak's desk in Wraclawitz.",
                "Zille_Dec_LegalBrief_Ultimatum", 6, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Gulf_Navy_Escorts",
                "Admiralty: Sallabes Convoy Escorts Active",
                "Destroyer patrols out of Monqiz are escorting Rizian merchant tankers past the Strait of Kreleck, forcing Wehzek gunboats to withdraw.",
                "Zille_Dec_GulfEscorts_Navy", 7, "Rizia_City_Sallabes");

            AddOrUpdateReport(reps, "Rep_Gulf_Merchant_Insurance",
                "Sallabes Guildhall: Crown Maritime Guarantees",
                "Treasury war-risk insurance kept Sallabes shipping houses operating across the Gulf of Moridia despite Wehzek harassment.",
                "Zille_Dec_GulfEscorts_Insure", 7, "Rizia_City_Sallabes");

            AddOrUpdateReport(reps, "Rep_MaveNortus_Displaced_Relief",
                "Mave Nortus: Displaced Families Sheltered",
                "Royal grain depots and field clinics opened across northern Brenas for families fleeing Zille, earning formal commendation from Alliance of Nations observers.",
                "Zille_Dec_Displaced_Relief", 7, "Rizia_City_MaveNortus");

            AddOrUpdateReport(reps, "Rep_Zille_EarlyEscalation",
                "Crown Council: Early Frontier Escalation",
                "Following the Zille Friendship Day bombing, King Romus authorized an early enforcement of the expiring 1927 Valero agreement regardless of Wehlen's protests.",
                "Zille_War_EarlyLaunch", 3, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Zille_LateEscalation",
                "Crown Council: Diplomatic Exhaustion Over Zille",
                "After years of rejected overtures and Smolak's extortion, King Romus formally authorized military operations to liberate Zille.",
                "Zille_War_UltimatumGiven", 8, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Zille_EarlyArk_Backlash",
                "Konstantium Outcry: Operation Golden Ark Backlash",
                "Foreign delegations reacted with fury after Rizia launched amphibious strikes onto mainland Wehlen despite proclaiming a lawful, limited entry into Zille under the Valero pact.",
                "Zille_EarlyArk_Backlash", 4, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Zille_LateSword_Friction",
                "AN Concern: Urban Fighting in Zille",
                "Neutral observers in Konstantium voiced measured concern over heavy urban clashes along Operation Golden Sword's frontal axis through Zille's coastal towns.",
                "Zille_LateSword_Friction", 8, "Rizia_City_PorteDrazon");

            AddOrUpdateReport(reps, "Rep_Zille_BombingLie_Published",
                "Palace Broadcast: Wehlen Accused of Friendship Day Plot",
                "King Romus stunned domestic and foreign audiences alike by claiming Rizian intelligence holds irrefutable proof that Wehlen fabricated the Friendship Day bombing to keep Zille—rallying domestic fervor while drawing sharp skepticism abroad.",
                "Zille_Speech_LiedAboutBombing", 4, "Rizia_City_PorteDrazon");
        }

        public static void SyncVariables()
        {
            int equip = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Military_Equipment");
            int energy = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Energy");
            bool warActive = ZilleCampaignState.CurrentPhase != ZilleOperationPhase.NotStarted || DialogueHelper.GetBoolVariable("Zille_War_Active");
            bool isSword = ZilleCampaignState.PlanType == ZillePlanType.Romulus && ZilleCampaignState.RomulusPlan == ZilleRomulusPlan.Sword
                        || ZilleCampaignState.PlanType == ZillePlanType.Staff && ZilleCampaignState.StaffPlan == ZilleStaffPlan.Sword
                        || ZilleCampaignState.CurrentVariant == ZilleOperationVariant.PlanSword;
            bool isArk = warActive && !isSword;
            string route = ZilleCampaignState.LogisticsRoute;
            if (string.IsNullOrEmpty(route)) route = DialogueHelper.GetStringVariable("Zille_Logistics_Route");

            bool hasEvidence = DialogueHelper.GetBoolVariable("Zille_Dossier_Compiled")
                            || DialogueHelper.GetBoolVariable("RiziaDLC.Zille_Discovered_LespianInvolvement")
                            || DialogueHelper.GetBoolVariable("RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty")
                            || DialogueHelper.GetBoolVariable("RiziaDLC.Wehlen_Zille_SharedEvidence");

            int outcome = (int)ZilleCampaignState.Outcome;
            if (outcome == 0) outcome = DialogueHelper.GetIntVariable("Zille_War_Outcome");

            bool warPlanned = ZilleCampaignState.IsZilleWarPlanned();
            bool zilleSettled = ZilleCampaignState.IsZilleResolvedPeacefully()
                || ZilleCampaignState.HasZilleWarOccurred()
                || DialogueHelper.GetBoolVariable("Zille_PeaceTreaty_Signed")
                || DialogueHelper.GetBoolVariable("Zille_Rep_TreatyDone");

            DialogueHelper.SetVariable("Zille_Sit_Mobilization", warPlanned && !zilleSettled && DialogueHelper.GetBoolVariable("Zille_War_Planning_Done") && !warActive && outcome == 0);
            DialogueHelper.SetVariable("Zille_Sit_Sword", warActive && isSword && outcome == 0);
            DialogueHelper.SetVariable("Zille_Sit_Ark", warActive && isArk && outcome == 0);
            DialogueHelper.SetVariable("Zille_Sit_ArsenalLow", equip < 1000 && warPlanned && !zilleSettled && (warActive || DialogueHelper.GetBoolVariable("Zille_War_Planning_Done")));
            DialogueHelper.SetVariable("Zille_Sit_ArsenalHigh", equip >= 1000 && warPlanned && !zilleSettled && (warActive || DialogueHelper.GetBoolVariable("Zille_War_Planning_Done")));
            DialogueHelper.SetVariable("Zille_Sit_OilCutoff", warActive && energy <= 3);
            DialogueHelper.SetVariable("Zille_Sit_LogSazon", string.Equals(route, "Sazon", StringComparison.OrdinalIgnoreCase));
            DialogueHelper.SetVariable("Zille_Sit_LogAzaro", string.Equals(route, "Azaro", StringComparison.OrdinalIgnoreCase));
            DialogueHelper.SetVariable("Zille_Sit_LogCompromise", string.Equals(route, "Compromise", StringComparison.OrdinalIgnoreCase));
            DialogueHelper.SetVariable("Zille_Sit_Refugees", ZilleCampaignState.Phase1Finished || ZilleCampaignState.MaveNortusHQCompleted);
            DialogueHelper.SetVariable("Zille_Sit_HasDossier", hasEvidence);
            DialogueHelper.SetVariable("Zille_Sit_Underground", warPlanned && !zilleSettled && (warActive || DialogueHelper.GetBoolVariable("Zille_War_Planning_Done")));
            DialogueHelper.SetVariable("Zille_Sit_DerdiaRaids", warActive && !zilleSettled && (ZilleCampaignState.IsDerdiaHybridSupportActive || DialogueHelper.GetBoolVariable("Zille_DerdiaHybridActive")));
            DialogueHelper.SetVariable("Zille_Sit_DerdiaCorridor", warPlanned && !zilleSettled && (ZilleCampaignState.IsDerdiaPactSigned || DialogueHelper.GetBoolVariable("Zille_DerdiaPact_Signed")));
            DialogueHelper.SetVariable("Zille_Sit_ANHigh", ZilleCampaignState.AnLegitimacyScore >= 3 && !ZilleCampaignState.EarlyArkBacklashActive);
            DialogueHelper.SetVariable("Zille_Sit_ANOutcry", (warActive && ZilleCampaignState.AnLegitimacyScore < 2) || ZilleCampaignState.EarlyArkBacklashActive);
            DialogueHelper.SetVariable("Zille_Sit_OutcomeRestored", outcome >= 4 || DialogueHelper.GetBoolVariable("RiziaDLC.ZilleReturn_Success"));
            DialogueHelper.SetVariable("Zille_Sit_OutcomeArmistice", outcome == 2 && !ZilleCampaignState.IsIndependentZilleAgreed);

            // Smolak Suspicion Posture Situations
            bool showSmolakPosture = warPlanned && !zilleSettled && outcome == 0;
            string smolakPreset = ZilleCampaignState.GetSmolakSuspicionPreset(syncFromLua: false);
            DialogueHelper.SetVariable("Zille_Sit_SmolakMinimal", showSmolakPosture && smolakPreset == "minimal");
            DialogueHelper.SetVariable("Zille_Sit_SmolakSuspicious", showSmolakPosture && smolakPreset == "suspicious");
            DialogueHelper.SetVariable("Zille_Sit_SmolakPrepared", showSmolakPosture && smolakPreset == "prepared");

            // Report triggers
            int currentTurn = ZilleCampaignState.GetCurrentTurn();
            if (currentTurn >= 3 || warActive)
            {
                DialogueHelper.SetVariable("Zille_Derdia_SabotageSignals", true);
            }
            DialogueHelper.SetVariable("Zille_Rep_DerdiaSabotageConfirmed",
                (DialogueHelper.GetBoolVariable("Zille_Derdia_InvestigationDone") || DialogueHelper.GetBoolVariable("Zille_Derdia_BriefingDone"))
                && !DialogueHelper.GetBoolVariable("Zille_Derdia_InvestigationIgnored")
                && (ZilleCampaignState.HasDerdiaSabotageEvidence || DialogueHelper.GetBoolVariable("Zille_Derdia_SabotageEvidence")));
            DialogueHelper.SetVariable("Zille_Rep_Phase1Done", ZilleCampaignState.Phase1Finished);
            DialogueHelper.SetVariable("Zille_Rep_Phase2Done", ZilleCampaignState.Outcome != ZilleWarOutcome.None || ZilleCampaignState.CurrentPhase == ZilleOperationPhase.Completed_Outcome);
            DialogueHelper.SetVariable("Zille_Rep_DerdiaRejected", DialogueHelper.GetBoolVariable("Zille_DerdiaTalks_Done") && !ZilleCampaignState.IsDerdiaHybridSupportActive && !DialogueHelper.GetBoolVariable("Zille_DerdiaHybridActive"));
            DialogueHelper.SetVariable("Zille_Rep_LespiaRejected", DialogueHelper.GetBoolVariable("Zille_LespiaTalks_Done") && !ZilleCampaignState.IsLespiaIntelActive && !DialogueHelper.GetBoolVariable("Zille_Lespia_Intel"));
        }
    }
}
