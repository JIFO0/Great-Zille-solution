using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static partial class ZilleDialogueSystem
    {
        // =========================================================================
        // SCENE 1: Turn_Zille_WarPlanning (ID 9987) - WAR PLANNING SESSION
        // Multi-round analytical session:
        // - Arsenal audit (<500 / 500-999 / 1000-2499 / >=2500 weapons)
        // - Army / Tank / Fleet / Bomber force checks
        // - Treasury & Energy condition branches + emergency procurement option
        // - Intelligence dossier & micro-effects building Zille_Leverage / Readiness
        // =========================================================================
        public static void RegisterWarPlanning(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarPlanning") != null && db.GetConversation("Zille/WarPlanning") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPlanning;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarPlanning";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Planning_Atmosphere",
                "Gray rain lashed against the stone spires of Palas Rezna as you walked the echoing colonnade toward the Council Chamber. Inside, an emergency war map of the Brenas-Zille peninsula and the Gulf of Moridia lay unfurled across the long walnut table, weighted down by heavy crystal paperweights and thick ordnance ledgers.", -1);

            AddChoice(conv, 401, NarratorId, "Planning_Stimulus_Storm",
                "Pause for a heartbeat by the rain-streaked lancet window to watch the squall sweep across the Gulf.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Planning_Stimulus_Coffee",
                "Take a steaming porcelain cup of dark Rizian roast from the steward as the Golden Guards open the oak doors.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Planning_Entry_Storm",
                "Whitecaps churned beyond the breakwater of Porte Drazon—a fitting omen for the storm about to break over Zille. As you stepped inside, the council rose as one.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Planning_Entry_Coffee",
                "The bitter warmth of the roast steadied you against the chill of the stone halls. As you stepped inside, the council rose beside the map table.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Planning_Open",
                "Your Majesty... We have convened the Crown Council under extraordinary circumstances. Smolak's continued defiance and the escalating tensions in Zille have brought our kingdom to a decisive crossroads.", 3,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and Variable[\"RiziaDLC.Country_HouseToras_Enemy\"] ~= true");

            AddLine(conv, 102, HugoId, RomusId, "Hugo_Planning_Open_Hostile",
                "Your Majesty. Though relations between the Crown and House Toras have grown strained, the integrity of the realm leaves us no choice but to confront Smolak's continued defiance in Zille.", 3,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and Variable[\"RiziaDLC.Country_HouseToras_Enemy\"] == true");

            AddLine(conv, 103, LaurentoId, RomusId, "Laurento_Planning_Open_NoHugo",
                "Your Majesty. In the Grand Vizier's absence, we have convened an emergency council. Smolak's continued defiance in Zille has brought our kingdom to a decisive crossroads.", 3,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 404, 103);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);
            AddLink(conv, 405, 103);

            var stanceHub = AddLine(conv, 3, NarratorId, RomusId, "Romus_Planning_Posture_Prompt",
                "You looked across the gathered faces of your council, measuring both their counsel and the actual state of the kingdom's arsenals.");

            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive force
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Pragmatic caution
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Sovereign legalism

            AddChoice(conv, 10, HugoId, "Posture_Force",
                "\"Over twenty-five years of separation ends here. Prepare the Royal Army to reclaim Zille by arms.\"",
                "Over twenty-five years of separation ends here. Smolak will not surrender our province through parchment alone. Prepare the Royal Army for the reclamation of Zille.", -1,
                "Variable[\"Zille_Planning_Stance\"] = \"Force\"; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddChoice(conv, 11, HugoId, "Posture_Pragmatic",
                "\"Spare me slogans. Audit our weapons, coffers, and fuel before we risk a war with Wehlen.\"",
                "Spare me slogans and bravado. Give me a ruthless audit of our weapons depots, treasury, energy reserves, and diplomatic standing before we commit our kingdom to war.", -1,
                "Variable[\"Zille_Planning_Stance\"] = \"Cautious\"; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddChoice(conv, 12, HugoId, "Posture_Legal",
                "\"The 1927 agreement has expired. Rizia will enforce lawful sovereignty against an illegal occupation.\"",
                "The 1927 agreement has expired. Wehlen's continued garrisoning of Zille is an unlawful foreign occupation, and we will press our full legal claim before the world.", -1,
                "Variable[\"Zille_Planning_Stance\"] = \"Legal\"; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2;");

            // Dynastic Counsel: Hugo if free, else Laurento
            AddLine(conv, 20, HugoId, RomusId, "Hugo_Dynastic_Warning",
                "Romus... As your uncle and Grand Vizier, remember the weight of history. King Valero signed the 1927 agreement to quell internal upheaval when the throne itself shook. If our divisions stumble across the Brenas-Zille frontier, the prestige of House Toras will take decades to mend.", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 120, LaurentoId, RomusId, "Laurento_Dynastic_Warning",
                "Your Majesty, King Valero signed the 1927 agreement under immense domestic strain; if our armies march across the Brenas-Zille frontier and falter, the Crown's standing across Merkopa will suffer grievously.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            foreach (int cid in new[] { 10, 11, 12 })
            {
                AddLink(conv, cid, 20);
                AddLink(conv, cid, 120);
            }

            // Military appraisal + situational force & equipment check
            AddLine(conv, 21, LucitaId, RomusId, "Lucita_Military_Appraisal_1",
                "Inaction carries its own poison, Your Majesty. Smolak's Zille garrison holds forward armor at the rail hub of Wiktrany, dense infantry belts around Zille City, and coastal batteries at Munat—all leaning on sea convoys across the Gulf of Moridia.", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 121, TaddeusId, RomusId, "Taddeus_Military_Appraisal",
                "Inaction is the greater peril, Your Majesty. Wehzek Field Command holds strong garrisons across Wiktrany, Zille City, and Munat, resupplied across the Gulf of Moridia. If we sever those sea lanes and strike hard through Wiktrany, Wehlen's outer perimeter will crack.", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 122, CarlosId, RomusId, "Carlos_Military_Appraisal",
                "Wraclawitz holds deeply dug garrisons between Wiktrany, Zille City, and Munat, Your Majesty, supplied across the Gulf of Moridia. Strike decisively before Smolak reinforces by sea, and his line will buckle.", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and (Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            foreach (int prev in new[] { 20, 120 })
            {
                AddLink(conv, prev, 21);
                AddLink(conv, prev, 121);
                AddLink(conv, prev, 122);
            }

            // Situational Arsenal & Force Assessment (MECE over Equipment: >=2500 / 1000-2499 / 500-999 / <500)
            AddLine(conv, 210, NarratorId, RomusId, "Arsenal_Appraisal_Overflow",
                "Your Chief Quartermaster opened the thick green ordinance ledger and tapped the figures with quiet confidence. \"Over 2,500 units of military equipment fill the royal arsenals—more than enough rifles, machine guns, and shells to sustain continuous high-intensity assaults.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 2500",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 211, NarratorId, RomusId, "Arsenal_Appraisal_Adequate",
                "The ordinance ledger showed between 1,000 and 2,500 units of reserve weapons in our depots. \"Enough to fully equip a determined campaign across Zille, Your Majesty,\" your quartermaster noted, \"provided we avoid reckless attrition.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 and (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 2500",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 212, NarratorId, RomusId, "Arsenal_Appraisal_Low",
                "The quartermaster frowned at the thin columns in the ledger. \"Our reserve depots hold fewer than 1,000 weapons, Your Majesty—between five hundred and a thousand rifles and artillery pieces. We can open an offensive, yet prolonged combat will strain replacements unless we buy or forge more arms.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 500 and (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000");

            AddLine(conv, 213, NarratorId, RomusId, "Arsenal_Appraisal_Critical",
                "A grim hush fell as the quartermaster laid bare the numbers: fewer than 500 weapons remain in strategic storage. \"Your Majesty, marching on Zille with near-empty racks risks exhausting ammunition before our brigades even reach Wiktrany!\"", -1,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 500",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) - 1;");

            foreach (int prev in new[] { 21, 121, 122 })
            {
                AddLink(conv, prev, 210);
                AddLink(conv, prev, 211);
                AddLink(conv, prev, 212);
                AddLink(conv, prev, 213);
            }

            // Elena Budget & Energy Assessment (MECE)
            AddLine(conv, 230, ElenaId, RomusId, "Elena_Audit_Rich",
                "Elena Werner reviewed her ledger with rare composure. \"Mercifully, Your Majesty, we do not march as paupers: our treasury holds ample reserves and healthy funding buffers. Even so, heavy mechanized warfare burns diesel and shells ruthlessly, so keep supply corridors disciplined.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 6 and (Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true and Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] ~= true)");

            AddLine(conv, 231, ElenaId, RomusId, "Elena_Audit_Mid",
                "Elena tapped her pen against the ledger. \"Courage does not buy fuel, Your Majesty. Our budget can finance a sharp, localized campaign if we do not let it rot into an endless siege along the northern marshes.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 2 and (Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 6 and (Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true and Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] ~= true)");

            AddLine(conv, 232, ElenaId, RomusId, "Elena_Audit_TightOrTwoFront",
                "Elena's voice sharpened into urgent alarm. \"By Saint Wruhec, Your Majesty, look at the exchequer! Between stretched treasury reserves, tight fuel margins, and the burden of confronting Pales on the eastern frontier, reckless spending in Zille could push Rizia into wartime rationing and inflation!\"", -1,
                "((Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 2) or ((Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true or Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] == true))");

            foreach (int aId in new[] { 210, 211, 212, 213 })
            {
                AddLink(conv, aId, 230);
                AddLink(conv, aId, 231);
                AddLink(conv, aId, 232);
            }

            // Laurento International Horizon (Two-Front + Bombing Evidence awareness)
            AddLine(conv, 240, LaurentoId, RomusId, "Laurento_Horizon_Standard",
                "Internationally, Chancellor Hegel and United Contana will denounce us at the AN in Konstantium, Kyrute. Yet because the 1927 agreement undeniably lapsed, Prime Minister Alvarez in Perla and the ATO bloc will hesitate to rescue Smolak if we strike quickly and legally.", -1,
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true and Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] ~= true)");

            AddLine(conv, 241, LaurentoId, RomusId, "Laurento_Horizon_TwoFront",
                "Diplomatically, we are walking on razor wire, Your Majesty. With hostilities active against Pales, Lespia is already furious with us. Opening a second war in Zille will invite simultaneous hostility from both ATO and the Malenyevist bloc unless we divide our rivals swiftly.", -1,
                "(Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true or Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] == true)");

            foreach (int eId in new[] { 230, 231, 232 })
            {
                AddLink(conv, eId, 240);
                AddLink(conv, eId, 241);
            }

            // Titus security note
            AddLine(conv, 25, TitusId, RomusId, "Titus_Security_Estela",
                "Internally, Su Omina and ATA cells inside Zille stand ready to disrupt Wehzek telegraphs. Moreover, the Golden Guard has assigned elite teams to safeguard Queen Mother Estela's modest childhood fishing-district home in Zille the moment our columns enter the city.", 30,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 125, NarratorId, RomusId, "Security_NoTitus",
                "Military intelligence confirmed that loyalist cells inside Zille were poised to sabotage Wehzek signals, and vanguard units carried strict orders to protect Queen Mother Estela's old harbor neighborhood.", 30,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            foreach (int lId in new[] { 240, 241 })
            {
                AddLink(conv, lId, 25);
                AddLink(conv, lId, 125);
            }

            // Sequential Topic 1: Military & Arsenal Readiness (zero hub loop!)
            var inquiryHub = AddLine(conv, 30, NarratorId, RomusId, "Planning_Topic1_Military",
                "The map table hummed with quiet anticipation. Turning first to the military balance, you weighed whether to press your commanders on armor and naval escorts or address any depot shortfalls.");

            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 31));  // Terrain & Force readiness (tanks, ships, planes)
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 391)); // Emergency Arms Purchase (conditional: Budget>=1 & Low Equip)
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 305)); // Proceed to Economic & Fuel Audit

            AddChoice(conv, 31, NarratorId, "Inquire_Lucita_Forces",
                "\"Give me a hard count of our armor, fleet, and air power against Wehlen's brigades.\"",
                "Forget broad optimism—assess our terrain obstacles and give me an honest count of our armor, warships, and air support against Wehlen's defenders.", -1,
                "Variable[\"Zille_Plan_CheckedForces\"] = true;",
                "Variable[\"Zille_Plan_CheckedForces\"] ~= true");

            AddLine(conv, 35, LucitaId, RomusId, "Answer_Force_Strong",
                "\"Our mechanized spearhead has strong tank support and the Royal Navy out of Monqiz can contest the Gulf of Moridia cleanly,\" Lucita answered sharply. \"Once we punch through the coastal marshes around Wiktrany, Smolak's garrison cannot contain an amphibious or armored envelopment—and if we secure Derdia's cooperation, Plan Ark could even strike Wehlen's southern flank by land.\"", 30,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and (((Variable[\"RiziaDLC.Army_Unit_Tank_Total\"] or 0) >= 2) or ((Variable[\"Zille_Fleet_Total\"] or 0) >= 2))",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 1035, CarlosId, RomusId, "Answer_Force_Strong_Carlos",
                "\"Our mechanized spearhead has strong tank support and the Royal Navy out of Monqiz can contest the Gulf of Moridia cleanly,\" General Carlos reported. \"Once we break the coastal marshes around Wiktrany, Wehlen cannot contain an envelopment—especially if Derdia opens a southern corridor for Plan Ark.\"", 30,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and (((Variable[\"RiziaDLC.Army_Unit_Tank_Total\"] or 0) >= 2) or ((Variable[\"Zille_Fleet_Total\"] or 0) >= 2))",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 135, LucitaId, RomusId, "Answer_Force_Lean",
                "\"I will be blunt, Your Majesty,\" Lucita warned firmly: \"with limited heavy armor or naval escort hulls currently operational, an ambitious amphibious crossing would risk disaster. We must rely on disciplined infantry advances through Wiktrany's marshes—unless diplomatic groundwork with Derdia opens a southern land corridor for Plan Ark.\"", 30,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and (((Variable[\"RiziaDLC.Army_Unit_Tank_Total\"] or 0) < 2) and ((Variable[\"Zille_Fleet_Total\"] or 0) < 2))");

            AddLine(conv, 1135, CarlosId, RomusId, "Answer_Force_Lean_Carlos",
                "\"I will be blunt, Your Majesty,\" General Carlos warned quietly: \"with limited heavy armor or naval escort hulls currently operational, an ambitious amphibious crossing would risk disaster. We must rely on disciplined infantry advances through Wiktrany's marshes—unless Derdia opens a southern land corridor for Plan Ark.\"", 30,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and (((Variable[\"RiziaDLC.Army_Unit_Tank_Total\"] or 0) < 2) and ((Variable[\"Zille_Fleet_Total\"] or 0) < 2))");

            AddLink(conv, 31, 35);
            AddLink(conv, 31, 1035);
            AddLink(conv, 31, 135);
            AddLink(conv, 31, 1135);

            // Emergency Arms Procurement (-1 Budget -> +500 Weapons & +2 Readiness)
            AddChoice(conv, 391, ElenaId, "Order_Emergency_Arms_Procurement",
                "\"Release royal funds immediately to procure 500 emergency rifles and artillery shells before mobilization!\"",
                "Our depots cannot stay below a thousand weapons. Release emergency royal funds immediately to purchase 500 reserve arms and shells before we summon the houses!", 392,
                "Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 500; Variable[\"Zille_Emergency_Arms_Bought\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1 and (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000 and Variable[\"Zille_Emergency_Arms_Bought\"] ~= true");

            AddLine(conv, 392, ElenaId, RomusId, "Ack_Emergency_Arms",
                "Elena frowned briefly at the sudden expenditure, then stamped the requisition warrant. \"An expensive rush order, Your Majesty, yet wise: five hundred crates of rifles and shells are rolling toward Brenas depots tonight.\"", 30);

            AddChoice(conv, 305, ElenaId, "Proceed_To_Econ",
                "\"Our force posture is clear. Move to our treasury and energy grid.\"",
                "Our military posture is clear enough. Turn to our treasury and energy reserves, Elena.", 310);

            // Sequential Topic 2: Treasury, Energy & Intelligence Dossier
            var topic2Hub = AddLine(conv, 310, NarratorId, RomusId, "Planning_Topic2_EconIntel",
                "Turning from the unit markers to the green ledgers, you weighed the kingdom's fuel resilience and intelligence cards.");

            topic2Hub.outgoingLinks.Add(CreateLink(conv.id, 310, 32));
            topic2Hub.outgoingLinks.Add(CreateLink(conv.id, 310, 393));
            topic2Hub.outgoingLinks.Add(CreateLink(conv.id, 310, 315));

            AddChoice(conv, 32, ElenaId, "Inquire_Elena_Reserves",
                "\"Elena, detail the exact cost to our treasury and energy grid once Wehlen oil stops flowing.\"",
                "Elena, calculate the exact damage to our treasury and energy grid once Smolak cuts off Wehlen crude oil deliveries.", -1,
                "Variable[\"Zille_Plan_CheckedEcon\"] = true;",
                "Variable[\"Zille_Plan_CheckedEcon\"] ~= true");

            AddLine(conv, 36, ElenaId, RomusId, "Answer_Elena_EnergyOK",
                "\"Losing Wehlen crude will tighten our grid noticeably, yet with our current energy buffer we can fuel initial mechanized columns if we pair Brenas granaries with coastal convoys instead of burning diesel on long rail hauls.\"", 310,
                "(Variable[\"RiziaDLC.Resources_Energy\"] or 0) > 2",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 136, ElenaId, RomusId, "Answer_Elena_EnergyLow",
                "\"Frankly, Your Majesty, our energy buffer is already dangerously thin. Once Wehlen cuts the pipelines, armored offensives and naval patrols will face acute rationing unless we secure emergency energy supplies—such as a southern pipeline accord with Derdia—or pick the fuel-sparing Sazon route.\"", 310,
                "(Variable[\"RiziaDLC.Resources_Energy\"] or 0) <= 2");

            AddLink(conv, 32, 36);
            AddLink(conv, 32, 136);

            // Compile Bombing Evidence Dossier for Leverage
            AddChoice(conv, 393, LaurentoId, "Compile_Bombing_Dossier",
                "\"Bind our Zille bombing intelligence into a sealed dossier—we will hold it over Wehlen and Lespia alike.\"",
                "Laurento, bind every intelligence report we possess from the Zille bombing into a sealed royal dossier. We will use that truth as leverage at both Perla and Wraclawitz.", 394,
                "Variable[\"Zille_Dossier_Compiled\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "((Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true) or Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] == true) and Variable[\"Zille_Dossier_Compiled\"] ~= true");

            AddLine(conv, 394, LaurentoId, RomusId, "Ack_Compile_Dossier",
                "Laurento slipped the black-bound folder into his briefcase with a razor-sharp smile. \"A formidable diplomatic weapon, Your Majesty. Neither Alvarez nor Smolak will bluff cleanly once they see this seal.\"", 310);

            AddChoice(conv, 315, LaurentoId, "Proceed_To_Diplomacy",
                "\"The ledgers are noted. Let us review foreign reactions and our Zille underground.\"",
                "The economic picture is clear. Let us turn to foreign reactions and our loyalists inside Zille.", 320);

            // Sequential Topic 3: Foreign Powers & Zille Underground
            var topic3Hub = AddLine(conv, 320, NarratorId, RomusId, "Planning_Topic3_DiploSecurity",
                "Finally, you looked to Laurento and your security chief before closing the session.");

            topic3Hub.outgoingLinks.Add(CreateLink(conv.id, 320, 33));
            topic3Hub.outgoingLinks.Add(CreateLink(conv.id, 320, 34));
            topic3Hub.outgoingLinks.Add(CreateLink(conv.id, 320, 325));

            AddChoice(conv, 33, LaurentoId, "Inquire_Laurento_Powers",
                "\"How will Rumburg, Lespia, Derdia, and Valgsland react when we move?\"",
                "Map out the diplomatic chessboard: where do Rumburg, Lespia, Derdia, and Valgsland stand if we cross the frontier?", 37,
                "Variable[\"Zille_Plan_CheckedDiplo\"] = true;",
                "Variable[\"Zille_Plan_CheckedDiplo\"] ~= true");

            AddLine(conv, 37, LaurentoId, RomusId, "Answer_Laurento",
                "\"Your sister-in-law Queen Beatrice in Thornbourgh can shield us at the AN and send heavy 152mm shells by sea if we keep faith with GRACE. Prime Minister Alvarez in Perla despises Smolak enough to sell aerial reconnaissance—unless we are fighting Pales. And in Derdia, Supreme Wiseman Azmal faces growing friction with Wehlen; if we lay proper diplomatic groundwork and persuade Naeal, Plan Ark could launch straight from Derdia's southern corridor instead of relying solely on sea landings—delivering far greater strategic shock.\"", 320,
                "",
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddChoice(conv, 34, TitusId, "Inquire_Titus_Underground",
                "\"Can Su Omina, ATA, and our guardsmen protect Queen Estela's home and Rizian civilians?\"",
                "How reliable are our loyalist cells inside Zille, and can our vanguard shield Queen Mother Estela's childhood home?", -1,
                "Variable[\"Zille_Plan_CheckedSecurity\"] = true;",
                "Variable[\"Zille_Plan_CheckedSecurity\"] ~= true");

            AddLine(conv, 38, TitusId, RomusId, "Answer_Titus",
                "\"ATA organizers and Su Omina scouts already watch Wehlen's supply piers, Your Majesty. My Golden Guardsmen will drop or ride into the harbor district first to secure the Queen Mother's childhood family house.\"", 320,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true",
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddLine(conv, 138, CarlosId, RomusId, "Answer_Security_NoTitus",
                "\"Our reconnaissance detachments carry strict orders to protect Zille's loyalist neighborhoods and the Queen Mother's childhood family home in the harbor quarter, Your Majesty.\"", 320,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            AddLink(conv, 34, 38);
            AddLink(conv, 34, 138);

            AddChoice(conv, 325, NarratorId, "Proceed_To_Conclude",
                "\"We have heard enough. Let us issue our final planning directive.\"",
                "We have weighed every angle. Let us issue our final directive and adjourn.", 330);

            var concludeHub = AddLine(conv, 330, NarratorId, RomusId, "Planning_Conclude_Prompt",
                "The candles burned low over the Brenas-Zille map. How do you summon Houses Azaro and Sazon to the coming Logistics Summit?");

            concludeHub.outgoingLinks.Add(CreateLink(conv.id, 330, 40));
            concludeHub.outgoingLinks.Add(CreateLink(conv.id, 330, 400));
            concludeHub.outgoingLinks.Add(CreateLink(conv.id, 330, 406));

            AddChoice(conv, 40, NarratorId, "Conclude_Planning",
                "\"Summon the noble houses openly: the Crown demands unity for the Logistics Summit.\"",
                "The strategic blueprint is set. Draft the preliminary deployment directives and summon Houses Azaro and Sazon to settle our supply corridors in Brenas.", -1,
                "Variable[\"Zille_War_Planning_Done\"] = true; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"Zille_War_Sentiment\"] = 3; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddChoice(conv, 400, NarratorId, "Conclude_Planning_Discreet",
                "\"Summon Azaro and Sazon discreetly under cover of a royal trade audit so Smolak stays blind.\"",
                "The blueprint is set. Summon Houses Azaro and Sazon under cover of a routine Brenas trade and rail audit so Wehlen's spies suspect nothing until we are ready.", -1,
                "Variable[\"Zille_War_Planning_Done\"] = true; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"Zille_War_Sentiment\"] = 3; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; if (Variable[\"Zille_Smolak_Pressure\"] or 0) > 0 then Variable[\"Zille_Smolak_Pressure\"] = Variable[\"Zille_Smolak_Pressure\"] - 1; else Variable[\"Zille_Smolak_Pressure\"] = 0; end;");

            AddChoice(conv, 406, NarratorId, "Conclude_Planning_StandDown",
                "\"We will not march on Zille. Stand down all military planning and pursue diplomacy.\"",
                "We have weighed the cost in gold, fuel, and blood. I will not lead Rizia into war over Zille—stand down all invasion planning and leave the province to the Foreign Ministry.", -1,
                "Variable[\"Zille_War_Declined\"] = true; Variable[\"Zille_War_Planning_Done\"] = false; Variable[\"Zille_War_EarlyLaunch\"] = false; Variable[\"Zille_War_Mobilization\"] = false; Variable[\"Zille_War_UltimatumGiven\"] = false; Variable[\"Zille_War_Postpone\"] = true; Variable[\"Zille_MilitarySentiment\"] = 0; Variable[\"Zille_Military_Posture\"] = 0; Variable[\"Zille_StaffPlanning_Started\"] = false; Variable[\"Lespia_Zille_Intelligence_Asked\"] = false; if (Variable[\"Zille_Smolak_Pressure\"] or 0) > 0 then Variable[\"Zille_Smolak_Pressure\"] = Variable[\"Zille_Smolak_Pressure\"] - 1; end;");

            AddLine(conv, 407, HugoId, RomusId, "Hugo_Planning_StandDown",
                "Hugo exhaled with visible relief and bowed his head. \"A restrained and sovereign judgment, Romus. The General Staff will shelve the Zille operational charts, and the realm will seek peace without bloodshed.\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 408, LaurentoId, RomusId, "Laurento_Planning_StandDown",
                "Laurento inclined his head with quiet relief. \"A statesmanlike course, Your Majesty. The military staff will stand down, and the Foreign Ministry will pursue Zille's return strictly through diplomacy.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 406, 407);
            AddLink(conv, 406, 408);

            AddLine(conv, 41, HugoId, RomusId, "Hugo_Planning_Close",
                "\"As your sovereign will decrees, Your Majesty. May Saint Wruhec guide our banners and preserve Rizia.\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 141, LaurentoId, RomusId, "Laurento_Planning_Close",
                "\"Your sovereign will is clear, Your Majesty. The foreign ministry will prepare every dispatch for the coming storm.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 40, 41);
            AddLink(conv, 40, 141);
            AddLink(conv, 400, 41);
            AddLink(conv, 400, 141);

            AddLine(conv, 42, LucitaId, RomusId, "Lucita_Planning_Close",
                "Lucita snapped to attention with martial resolve. \"The General Staff begins staging at once. Next we break the supply deadlock with House Sazon, Your Majesty.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 142, CarlosId, RomusId, "Carlos_Planning_Close",
                "General Carlos Azaro saluted sharply. \"Staging directives go out tonight, Your Majesty. We await your verdict on the Brenas supply corridors.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            foreach (int prev in new[] { 41, 141 })
            {
                AddLink(conv, prev, 42);
                AddLink(conv, prev, 142);
            }

            AddConversationWithAlias(db, conv, "Zille/WarPlanning", "Turn_Zille_WarPlanning");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Planning Session (ID 9987) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 2: Turn_Zille_WarLogisticsDispute (ID 9990) - LOGISTICS DISPUTE
        // Fixed:
        // - Feasibility checks for Budget>=1 (Sazon) vs Credit fallback (<1 Budget)
        // - Feasibility checks for Energy>=1 (Azaro) vs Civilian Rationing fallback (<1 Energy)
        // - Authority>=1 check for Royal Compromise
        // - Fixed missing 33 -> 134 link when Angelica free & Manus gone
        // - Inquiry round + micro-effects for Zille_War_Readiness / AN_Legitimacy
        // =========================================================================
        public static void RegisterWarLogisticsDispute(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarLogisticsDispute") != null && db.GetConversation("Zille/WarLogisticsDispute") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarLogisticsDispute;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarLogisticsDispute";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Logistics_Intro_BothSazon",
                "The State Dining Hall of Palas Rezna crackled with noble animosity. Banquet tables had been cleared for logistical ledgers, railway maps, and coastal shipping manifests. Opposite House Azaro's uniformed generals sat Duchess Angelica Sazon and Manus Sazon in dark Brenas velvet.", -1,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 101, NarratorId, RomusId, "Logistics_Intro_ManusOnly",
                "The State Dining Hall of Palas Rezna was tense with quiet hostility. Opposite House Azaro's officers sat Manus Sazon alone—his mother, Duchess Angelica, absent from the court.", -1,
                "(Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 102, NarratorId, RomusId, "Logistics_Intro_AngelicaOnly",
                "The State Dining Hall of Palas Rezna crackled with aristocratic tension. Across the ledger-strewn table from House Azaro's officers sat Duchess Angelica Sazon alone, representing Brenas in Manus's absence.", -1,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true and (Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            AddLine(conv, 103, NarratorId, RomusId, "Logistics_Intro_LeonaOnly",
                "The State Dining Hall of Palas Rezna was frigid with mutual suspicion. With both Angelica and Manus Sazon absent, Countess Leona Sazon of Sallabes represented the mercantile houses of Brenas opposite House Azaro's officers.", -1,
                "(Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and (Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            foreach (int iId in new[] { 1, 101, 102, 103 })
            {
                AddLink(conv, 0, iId);
                AddLink(conv, iId, 401);
                AddLink(conv, iId, 402);
            }

            AddChoice(conv, 401, NarratorId, "Logistics_Stimulus_Ring",
                "Rap your royal signet ring once against the heavy oak doorframe to cut through the bickering.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Logistics_Stimulus_Silence",
                "Walk quietly to the head of the table and take your seat without a word, letting their voices die out.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Logistics_Entry_Ring",
                "The sharp crack of gold on oak echoed beneath the chandeliers. Chairs scraped back as both noble houses snapped to attention.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Logistics_Entry_Silence",
                "One by one, the generals and merchants caught sight of you and fell silent, though the glare across the banquet oak remained venomous.", -1);

            foreach (int ent in new[] { 404, 405 })
            {
                AddLink(conv, ent, 2);
                AddLink(conv, ent, 104);
            }

            // Azaro Opener
            AddLine(conv, 2, TaddeusId, RomusId, "Taddeus_Logistics_Opener",
                "Duke Taddeus Azaro slammed his fist beside the coastal highway map. \"Your Majesty, an armored spearhead cannot crawl behind civilian freight timetables! House Azaro demands full military requisition authority over every rail switch, fuel depot, and granary in Brenas!\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 104, CarlosId, RomusId, "Carlos_Logistics_Opener",
                "Your Majesty. The General Staff cannot maintain offensive tempo while fuel convoys wait behind civilian freight and local rail switches in Brenas. We require full military requisition authority over the province's rail lines, fuel tanks, and grain depots.", -1,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            // Sazon Rebuttal
            AddLine(conv, 3, AngelicaId, RomusId, "Angelica_Furious_Rebuttal",
                "Duchess Angelica straightened with icy disdain, rapping a jeweled ring against the oak table. \"Brenas is not an occupied fief for Montaklar's generals to pillage! It is the breadbasket of Rizia and Queen Mother Estela's home province!\"", 4,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true");

            AddLine(conv, 4, AngelicaId, RomusId, "Angelica_Furious_Rebuttal_2",
                "\"Your quartermasters are already impounding civilian trucks and threatening our mayors. Strip Brenas bare to feed your tanks, and winter strikes and bread riots will paralyze our towns before your spearheads even reach Wiktrany!\"", -1);

            AddLine(conv, 5, ManusId, RomusId, "Manus_Passionate_Proposal",
                "Your Majesty, House Sazon wishes to see our soldiers return victorious—not starved by chaos at their backs. Our merchant syndicates, coastal freighters, and provincial granaries have kept Brenas running for generations. Let our guilds organize rear logistics cleanly without martial extortion.", 6,
                "Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 105, LeonaId, RomusId, "Leona_Sazon_Proposal",
                "Countess Leona Sazon adjusted her sable stole coolly. \"Brenas is not a conquered province for Montaklar to strip bare, Your Majesty. Our merchant guilds and coastal shipping syndicates can supply the front cleanly through our granaries and ports without provoking bread riots in Sallabes and Mave Nortus.\"", 6,
                "(Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and (Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            foreach (int oId in new[] { 2, 104 })
            {
                AddLink(conv, oId, 3);
                AddLink(conv, oId, 5);
                AddLink(conv, oId, 105);
            }

            AddLine(conv, 107, NarratorId, RomusId, "Angelica_ManusGone_Bridge",
                "With Manus absent from the hall, the silence after Angelica's outburst lingered heavy over the table.", -1,
                "(Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            var e4 = conv.GetDialogueEntry(4);
            e4.outgoingLinks.Clear();
            e4.outgoingLinks.Add(CreateLink(conv.id, 4, 5));
            e4.outgoingLinks.Add(CreateLink(conv.id, 4, 107));

            // Military counter
            AddLine(conv, 6, LucitaId, RomusId, "Lucita_Military_Counter",
                "Councilor Azaro leaned forward, her gaze razor-sharp. \"Guild committees move at the speed of an ox cart! If my armored brigades run dry of diesel and 105mm shells outside Wiktrany waiting for merchant manifests, Wehlen's armored counter-attacks will dismantle them piecemeal!\"", 7,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 106, CarlosId, RomusId, "Carlos_Military_Counter",
                "General Carlos Azaro tapped his leather portfolio flatly. \"Merchant committees move at the pace of paperwork, Your Majesty. If our forward brigades run dry of diesel and 105mm shells outside Wiktrany, Smolak's garrison reserves will tear them apart.\"", 7,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 5, 6);
            AddLink(conv, 5, 106);
            AddLink(conv, 105, 6);
            AddLink(conv, 105, 106);
            AddLink(conv, 107, 6);
            AddLink(conv, 107, 106);

            // Elena state-aware ledger audit
            AddLine(conv, 7, ElenaId, RomusId, "Elena_Ledger_Audit",
                "Elena Werner adjusted her spectacles and tapped her fountain pen. \"Look at the arithmetic instead of family crests! The Azaro centralized rail plan guarantees rapid ammunition flow, yet running nonstop heavy trains from Montaklar drains refined fuel reserves and stresses civilian lines.\"", 8);

            AddLine(conv, 8, ElenaId, RomusId, "Elena_Ledger_Audit_2",
                "\"The Sazon syndicate plan uses Brenas granaries and coastal freighters along the Gulf of Moridia, sparing our fuel—but paying the guilds fair transit fees requires direct treasury outlays. Imposing a joint Crown board avoids favoring either house, though it demands firm royal authority.\"", -1);

            AddLine(conv, 9, NarratorId, RomusId, "Hugo_Unity_Plea",
                "Hugo Toras shook his head gravely. \"Romus, a kingdom divided against itself will crack before Wiktor Smolak. Weigh both our coffers and our fuel reserves before decreeing your settlement.\"", 10,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 109, LaurentoId, RomusId, "Laurento_Unity_Plea",
                "Laurento folded his hands gravely. \"Smolak hopes to see our noble houses quarrel while his trenches deepen, Your Majesty. Match the logistics structure to what our treasury and energy grid can actually sustain.\"", 10,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 8, 9);
            AddLink(conv, 8, 109);

            var disputeInquiry = AddLine(conv, 10, NarratorId, RomusId, "Dispute_Inquiry_Prompt",
                "Before decreeing who controls Brenas's supply artery, you weighed whether to press Elena on raw treasury margins or test the military's rail-and-port contingency.");

            disputeInquiry.outgoingLinks.Add(CreateLink(conv.id, 10, 11));
            disputeInquiry.outgoingLinks.Add(CreateLink(conv.id, 10, 12));
            disputeInquiry.outgoingLinks.Add(CreateLink(conv.id, 10, 13));

            // Analytical interrogation nodes (multi-question hub returning to 10 until Skip_Logistics_Inquiry)
            AddChoice(conv, 11, ElenaId, "Inquire_Logistics_Numbers",
                "\"Elena, can our treasury, energy grid, and arsenals actually handle what these houses propose?\"",
                "Elena, give me the unvarnished figures right now: what does our current budget, energy, and equipment inventory dictate?", -1,
                "Variable[\"Zille_Logistics_Audited\"] = true;",
                "Variable[\"Zille_Logistics_Audited\"] ~= true");

            AddLine(conv, 111, ElenaId, RomusId, "Answer_Logistics_StrongReserves",
                "\"With healthy budget and energy cushions on our books, Your Majesty, you actually enjoy genuine freedom of choice—either subsidies for Sazon freighters or Azaro fuel prioritization are feasible without breaking the home front.\"", 10,
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1 and (Variable[\"RiziaDLC.Resources_Energy\"] or 0) >= 1",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 112, ElenaId, RomusId, "Answer_Logistics_Strained",
                "\"Honestly, Your Majesty, one or more columns on our ledger sit near zero! If treasury cash is empty, Sazon's syndicates will demand Crown customs pledges costing authority; if energy is exhausted, Azaro trains will force ruthless civilian rationing.\"", 10,
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 1 or (Variable[\"RiziaDLC.Resources_Energy\"] or 0) < 1",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLink(conv, 11, 111);
            AddLink(conv, 11, 112);

            AddChoice(conv, 12, LucitaId, "Inquire_Logistics_CrossExamine",
                "\"Wait—what happens to civilian ports and Pales transit if military requisition goes wrong?\"",
                "Wait: if enemy shells hit our marshaling yards or if Pales ties down rail rolling stock, how does each plan avoid collapse?", -1,
                "Variable[\"Zille_Logistics_Examined\"] = true;",
                "Variable[\"Zille_Logistics_Examined\"] ~= true");

            AddLine(conv, 120, LucitaId, RomusId, "Answer_CrossExamine_SazonAzaro",
                "\"That is precisely why coastal freighters off Sallabes and redundant Brenas spurs matter, Your Majesty,\" Lucita admitted coolly, \"—so long as military ammunition cars always hold right-of-way over commercial cargo.\"", 10,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true",
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 122, CarlosId, RomusId, "Answer_CrossExamine_Carlos",
                "\"Decentralized coastal barges protect us against bombed rail bridges, Your Majesty, provided military ammunition trains always hold priority signals.\"", 10,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)",
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLink(conv, 12, 120);
            AddLink(conv, 12, 122);

            AddChoice(conv, 13, HugoId, "Skip_Logistics_Inquiry",
                "\"Both houses have made their case. Hear the Crown's decree.\"",
                "I have heard enough from both sides. Now hear the Crown's logistical decree.", 15);

            var disputeHub = AddLine(conv, 15, NarratorId, RomusId, "Dispute_Hub_Prompt",
                "The entire council fell silent, awaiting your verdict. The supply artery of the southern campaign hung in the balance.");

            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 15, 20));  // Sazon Paid Subsidies (Budget >= 1)
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 15, 200)); // Sazon Debt Charter (Budget < 1)
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 15, 30));  // Azaro Paid Fuel (Energy >= 1)
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 15, 300)); // Azaro Civilian Rationing (Energy < 1)
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 15, 40));  // Royal Compromise (Authority >= 1)

            // Option A1: Sazon Funded (requires Budget >= 1)
            AddChoice(conv, 20, ManusId, "Choice_Sazon_Route",
                "\"House Sazon will manage logistics through Brenas granaries and coastal freighters.\"",
                "We will not crush Brenas to win a war. Release treasury subsidies so House Sazon's merchant guilds and coastal freighters keep the army supplied and Brenas's cities protected.", -1,
                "Variable[\"Zille_Logistics_Route\"] = \"Sazon\"; Variable[\"Zille_Logistics_House\"] = \"Sazon\"; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 2; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) - 1; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1");

            // Option A2: Sazon Debt Charter (fallback when Budget < 1)
            AddChoice(conv, 200, ManusId, "Choice_Sazon_Debt_Route",
                "\"Our coffers are bare—charter House Sazon on bonded port-customs IOUs backed by royal authority.\"",
                "Our royal treasury has no spare gold today, yet we still entrust rear supply to House Sazon under bonded port-customs IOUs guaranteed by the Crown.", -1,
                "Variable[\"Zille_Logistics_Route\"] = \"Sazon\"; Variable[\"Zille_Logistics_House\"] = \"Sazon\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) - 1;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 1");

            AddLine(conv, 21, ManusId, RomusId, "Ack_Sazon_Manus",
                "\"Thank you, Your Majesty!\" Manus bowed with genuine reverence. \"House Sazon will mobilize our finest grain syndicates and coastal freighters across the gulf. Brenas will stand firm behind our soldiers.\"", -1,
                "Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 121, LeonaId, RomusId, "Ack_Sazon_Leona",
                "Countess Leona inclined her head with poised gratitude. \"A prudent decree, Your Majesty. Our Brenas syndicates will keep the front supplied without bleeding the towns dry.\"", -1,
                "(Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true) and (Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true)");

            AddLine(conv, 22, AngelicaId, RomusId, "Ack_Sazon_Angelica",
                "Duchess Angelica lifted her chin proudly. \"A sovereign judgment worthy of Porte Drazon, Your Majesty. Brenas will stand as an unbreakable bastion at your rear.\"", -1,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true");

            AddLine(conv, 23, TaddeusId, RomusId, "Ack_Sazon_Taddeus",
                "Duke Taddeus tossed his gloves onto the oak table with visible disgust. \"Pray, Your Majesty, that when Wehlen's tanks counter-attack, merchant freighters deliver shells as promptly as they deliver tax exemptions.\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 24, NarratorId, RomusId, "Ack_Sazon_Lucita",
                "Lucita remained disciplined, though her jaw tightened. \"The General Staff will adapt our convoy timetables to the guilds, Your Majesty. We will hold the frontier.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 124, CarlosId, RomusId, "Ack_Sazon_Carlos",
                "General Carlos Azaro exhaled slowly, snapping his ledger shut. \"Very well, Your Majesty. We will adjust our staging timetables to the guild schedules.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            foreach (int src in new[] { 20, 200 })
            {
                AddLink(conv, src, 21);
                AddLink(conv, src, 22);
                AddLink(conv, src, 121);
            }
            AddLink(conv, 21, 22);
            AddLink(conv, 21, 23);
            AddLink(conv, 21, 24);
            AddLink(conv, 21, 124);
            AddLink(conv, 22, 23);
            AddLink(conv, 22, 24);
            AddLink(conv, 22, 124);
            AddLink(conv, 121, 23);
            AddLink(conv, 121, 24);
            AddLink(conv, 121, 124);
            AddLink(conv, 23, 24);
            AddLink(conv, 23, 124);

            // Option B1: Azaro Paid Fuel (requires Energy >= 1)
            AddChoice(conv, 30, LucitaId, "Choice_Azaro_Route",
                "\"Military necessity rules: grant House Azaro full rail and fuel-depot requisition.\"",
                "Military necessity takes absolute priority. Grant House Azaro full requisition powers over Brenas's rail corridors and allocate strategic fuel reserves to power an overwhelming mechanized thrust.", -1,
                "Variable[\"Zille_Logistics_Route\"] = \"Azaro\"; Variable[\"Zille_Logistics_House\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 2; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) - 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Resources_Energy\"] or 0) >= 1");

            // Option B2: Azaro Civilian Rationing (fallback when Energy < 1)
            AddChoice(conv, 300, LucitaId, "Choice_Azaro_Rationing",
                "\"Our energy grid is empty—order forced civilian fuel rationing so Azaro's tanks roll.\"",
                "Our strategic energy reserve is exhausted, yet the spearheads must move. Impose emergency civilian fuel rationing in Brenas and hand rail priority to House Azaro.", -1,
                "Variable[\"Zille_Logistics_Route\"] = \"Azaro\"; Variable[\"Zille_Logistics_House\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) - 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;",
                "(Variable[\"RiziaDLC.Resources_Energy\"] or 0) < 1");

            AddLine(conv, 31, NarratorId, RomusId, "Ack_Azaro_Lucita",
                "Lucita snapped a proud salute, her eyes shining with resolve. \"A command worthy of a warrior king, Your Majesty! Our mechanized spearheads will not lack for shells or diesel. We will shatter Wehlen's lines!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 131, CarlosId, RomusId, "Ack_Azaro_Carlos",
                "General Carlos Azaro gave a crisp nod. \"Understood, Your Majesty. Our armored spearheads will roll at full combat tempo.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 32, TaddeusId, RomusId, "Ack_Azaro_Taddeus",
                "\"Montaklar's divisions stand ready, Your Majesty!\" Taddeus declared firmly. \"Our armored columns will smash straight through Wiktrany!\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 33, AngelicaId, RomusId, "Ack_Azaro_Angelica",
                "Duchess Angelica rose from her chair, her eyes burning with icy indignation. \"The Crown may seize its trains, Your Majesty. Remember this day when Brenas freezes in winter queues.\"", -1,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true");

            AddLine(conv, 34, NarratorId, RomusId, "Ack_Azaro_Manus",
                "Manus bowed his head solemnly. \"We will strive to hold civil order in Brenas, Your Majesty. Let your victory be swift enough to justify this hardship.\"", -1,
                "Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 134, LeonaId, RomusId, "Ack_Azaro_Leona",
                "Countess Leona rose stiffly. \"The Crown shall have its trains, Your Majesty. I pray our towns endure the winter.\"", -1,
                "(Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and (Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            foreach (int src in new[] { 30, 300 })
            {
                AddLink(conv, src, 31);
                AddLink(conv, src, 131);
            }
            AddLink(conv, 31, 32);
            AddLink(conv, 31, 33);
            AddLink(conv, 31, 34);
            AddLink(conv, 31, 134);
            AddLink(conv, 131, 32);
            AddLink(conv, 131, 33);
            AddLink(conv, 131, 34);
            AddLink(conv, 131, 134);
            AddLink(conv, 32, 33);
            AddLink(conv, 32, 34);
            AddLink(conv, 32, 134);
            // Fixed: route Angelica (33) cleanly whether Manus is present (34) OR gone (134)!
            AddLink(conv, 33, 34);
            AddLink(conv, 33, 134);

            // Option C: Royal Compromise (requires Authority >= 1)
            AddChoice(conv, 40, ElenaId, "Choice_Compromise_Route",
                "\"Impose a Joint Logistical Board under Elena Werner. Neither house dominates.\"",
                "Neither house will dictate to the Crown. I expend royal authority to establish a Joint Logistical Board under Minister Elena Werner—guaranteeing priority munitions rails while Sazon syndicates protect civilian granaries and coastal barges.", 41,
                "Variable[\"Zille_Logistics_Route\"] = \"Compromise\"; Variable[\"Zille_Logistics_House\"] = \"Compromise\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 1; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "(Variable[\"RiziaDLC.Resources_Authority\"] or 0) >= 1");

            AddLine(conv, 41, ElenaId, RomusId, "Ack_Compromise_Elena",
                "Elena inclined her head with crisp efficiency. \"A balanced solution, Your Majesty. Both fuel and grain supplies will be strictly audited against hoarding or rail bottlenecks.\"", -1);

            AddLine(conv, 42, HugoId, RomusId, "Ack_Compromise_Hugo",
                "\"Well reasoned, Romus. Unity between our noble houses is the bedrock of the realm. Glovurius axa Rizia!\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 43, NarratorId, RomusId, "Ack_Compromise_Lucita",
                "Lucita nodded with measured professional respect. \"The military accepts this structure, Your Majesty. Our quartermasters will report directly to Minister Werner.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 143, CarlosId, RomusId, "Ack_Compromise_Carlos",
                "General Carlos Azaro inclined his head. \"An orderly compromise, Your Majesty. Our staff will coordinate directly with Minister Werner.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 41, 42);
            AddLink(conv, 41, 43);
            AddLink(conv, 41, 143);
            AddLink(conv, 42, 43);
            AddLink(conv, 42, 143);

            AddConversationWithAlias(db, conv, "Zille/WarLogisticsDispute", "Turn_Zille_WarLogisticsDispute");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Logistics Dispute (ID 9990) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 3: Turn_Zille_WarBriefing (ID 9988) - ROYAL WAR COUNCIL BRIEFING
        // Adds Naval Blockade preparation check (Fleet>=2 & Energy>=1),
        // Arsenal & Fleet status briefings, Staff Plan feasibility gating, and micro-effects.
        // =========================================================================
        public static void RegisterWarCouncilBriefing(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarBriefing") != null && db.GetConversation("Zille/WarCouncil_Briefing") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarBriefing;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarCouncil_Briefing";
            conv.ActorID = RomusId;
            conv.ConversantID = NarratorId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, NarratorId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Briefing_Atmosphere",
                "Midnight in the War Room of Palas Rezna. Heavy rain beat rhythmically against the stone walls, while inside the air hung thick with coffee, parchment, and gun oil. Across the tactical table lay the relief map of the Zille peninsula, the Strait of Kreleck, and the Gulf of Moridia, painted lead markers tracking every Wehzek garrison and naval patrol.", -1);

            AddChoice(conv, 401, NarratorId, "Briefing_Stimulus_Map",
                "Step up to the map table and trace a finger along the narrow carved relief of the Strait of Kreleck.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Briefing_Stimulus_Coffee",
                "Pour a small cup of black coffee from the silver urn and nod to the map orderlies.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Briefing_Entry_Map",
                "The painted sea lanes felt cool under your fingertips—a narrow strip of water separating Zille's occupied piers from Wehlen's mainland supply bases.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Briefing_Entry_Coffee",
                "The dark roast cut through the midnight fatigue. Around the table, your ministers and commanders straightened as you set the porcelain saucer down.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Briefing_Open",
                "Your Majesty... The hour has arrived. Years of diplomatic patience have run dry. Before dawn, the world will learn that Rizia has drawn the sword to reclaim Zille.", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and Variable[\"RiziaDLC.Country_HouseToras_Enemy\"] ~= true");

            AddLine(conv, 102, HugoId, RomusId, "Hugo_Briefing_Open_Hostile",
                "Your Majesty. Despite the bitter rift between us, I cannot ignore the duty of my office: before dawn, Rizia goes to war for Zille. May Nur shield the realm from the consequences.", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and Variable[\"RiziaDLC.Country_HouseToras_Enemy\"] == true");

            AddLine(conv, 103, AngelicaId, RomusId, "Angelica_Vizier_Briefing_Open",
                "Your Majesty. As Grand Vizier, I have reviewed the final mobilization decrees. Before dawn, Rizia moves to reclaim Zille—and with it, the historic wholeness of Brenas.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true) and Variable[\"RiziaDLC.Council_GrandVizier_Angelica\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true");

            AddLine(conv, 104, SalId, RomusId, "Sal_Vizier_Briefing_Open",
                "Your Majesty. As Grand Vizier, I pray Saint Wruhec blesses this righteous endeavor. Before dawn, our armies move to restore Zille to the anointed Crown.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true) and Variable[\"RiziaDLC.Council_GrandVizier_Angelica\"] ~= true and Variable[\"RiziaDLC.Council_GrandVizier_Sal\"] == true and Variable[\"RiziaDLC.Sal_Arrested\"] ~= true and Variable[\"RiziaDLC.Sal_Executed\"] ~= true");

            AddLine(conv, 105, LaurentoId, RomusId, "Laurento_Briefing_Open_NoHugo",
                "Your Majesty. All ministerial seals are prepared. Within hours, Rizia's armed forces will move to enforce the expiration of the 1927 treaty.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true) and (Variable[\"RiziaDLC.Council_GrandVizier_Angelica\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and (Variable[\"RiziaDLC.Council_GrandVizier_Sal\"] ~= true or Variable[\"RiziaDLC.Sal_Arrested\"] == true or Variable[\"RiziaDLC.Sal_Executed\"] == true)");

            foreach (int hId in new[] { 2, 102, 103, 104, 105 })
            {
                AddLink(conv, 404, hId);
                AddLink(conv, 405, hId);
            }

            AddLine(conv, 3, NarratorId, RomusId, "Lucita_Narration_Married",
                "Lucita stood at the head of the map table, her field marshal's baton resting across the Brenas frontier. When your eyes met, her severe military demeanor softened with quiet warmth before she addressed the assembly.", 4,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Married\"] == true");
            AddLine(conv, 4, LucitaId, RomusId, "Lucita_Open_Married",
                "My King... and my husband. All divisions are deployed at their staging posts. High command awaits your operational doctrine.", -1);

            AddLine(conv, 113, NarratorId, RomusId, "Lucita_Narration_Romance",
                "Lucita looked up from the coastal approaches, her dark eyes flashing with unmistakable warmth before snapping back to disciplined military bearing.", 114,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Married\"] ~= true and (Variable[\"RiziaDLC.Lucita_RomanceHappened\"] == true or (Variable[\"RiziaDLC.Relations_Lucita_Romance\"] or 0) > 0)");
            AddLine(conv, 114, LucitaId, RomusId, "Lucita_Open_Romance",
                "Your Majesty... Romus. Our officers stand by their radios along the Brenas frontier and at Monqiz naval base. Operational command is yours to dictate.", -1);

            AddLine(conv, 115, LucitaId, RomusId, "Lucita_Open_Hostile",
                "Your Majesty. Whatever grievances stand between the Crown and House Azaro, our officers know their duty. Give your orders.", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Married\"] ~= true and Variable[\"RiziaDLC.Lucita_RomanceHappened\"] ~= true and (Variable[\"RiziaDLC.Relations_Lucita_Romance\"] or 0) <= 0 and (Variable[\"RiziaDLC.Country_HouseAzaro_Enemy\"] == true or Variable[\"RiziaDLC.Turn06_Council_LucitaOffended\"] == true)");

            AddLine(conv, 116, LucitaId, RomusId, "Lucita_Open_Standard",
                "Your Majesty. All divisions of the Royal Army and provincial levies have assumed combat positions along the demarcation line, and the Royal Navy stands ready at Monqiz. We await your final authorization.", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Married\"] ~= true and Variable[\"RiziaDLC.Lucita_RomanceHappened\"] ~= true and (Variable[\"RiziaDLC.Relations_Lucita_Romance\"] or 0) <= 0 and Variable[\"RiziaDLC.Country_HouseAzaro_Enemy\"] ~= true and Variable[\"RiziaDLC.Turn06_Council_LucitaOffended\"] ~= true");

            AddLine(conv, 117, TaddeusId, RomusId, "Taddeus_Open_LucitaGone",
                "Duke Taddeus Azaro stood stiffly beside the relief map, his jaw tight with lingering bitterness over his daughter's fate. \"Your Majesty. The divisions are assembled along the Brenas line and the fleet stands at Monqiz. Specify the doctrine.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 118, CarlosId, RomusId, "Carlos_Open_LucitaGone",
                "General Carlos Azaro stepped forward in Lucita's stead, his expression strictly professional. \"Your Majesty. The General Staff has completed deployment along the Brenas border and at Monqiz. We await your operational orders.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and (Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            foreach (int hId in new[] { 2, 102, 103, 104, 105 })
            {
                AddLink(conv, hId, 3);
                AddLink(conv, hId, 113);
                AddLink(conv, hId, 115);
                AddLink(conv, hId, 116);
                AddLink(conv, hId, 117);
                AddLink(conv, hId, 118);
            }

            // Laurento Diplomacy + Two-Front check
            AddLine(conv, 5, LaurentoId, RomusId, "Laurento_Briefing_Note",
                "Our diplomatic memorandums are pre-scheduled for the Alliance of Nations in Konstantium, Kyrute—framing this strictly as enforcing the lapsed 1927 treaty.", -1,
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true and Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] ~= true)");

            AddLine(conv, 1051, LaurentoId, RomusId, "Laurento_Briefing_TwoFront",
                "I must warn you gravely, Your Majesty: with our forces already fighting Pales on the eastern frontier, opening a second war against Wehlen will alarm both ATO and the Malenyevist bloc in Kyrute.", -1,
                "(Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true or Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] == true)");

            foreach (int prev in new[] { 4, 114, 115, 116, 117, 118 })
            {
                AddLink(conv, prev, 5);
                AddLink(conv, prev, 1051);
            }

            // Operational Capability Check (Weapons >=1000 vs <1000 & Fleet >=2 vs <2)
            AddLine(conv, 6, TitusId, RomusId, "Titus_Briefing_Note",
                "The Golden Guard has deployed vanguard security teams along the advance routes, Your Majesty. Wehlen's garrison in Zille City has not yet detected our main mechanized assembly.", -1,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 106, CarlosId, RomusId, "Carlos_Security_NoTitus",
                "Forward military intelligence confirms that Wehlen's coastal and border outposts have not yet detected our main concentration, Your Majesty.", -1,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            foreach (int prev in new[] { 5, 1051 })
            {
                AddLink(conv, prev, 6);
                AddLink(conv, prev, 106);
            }

            AddLine(conv, 7, NarratorId, RomusId, "Briefing_Arsenal_Fleet_Good",
                "Quartermasters reported over 1,000 reserve weapons ready for immediate frontline replacement, while naval signals from Monqiz confirmed strong warship squadrons poised to contest the Gulf of Moridia.", 109,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 and (Variable[\"Zille_Fleet_Total\"] or 0) >= 2",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 107, NarratorId, RomusId, "Briefing_Arsenal_Good_Fleet_Weak",
                "Quartermasters confirmed over 1,000 reserve weapons stacked in Brenas, yet the Admiralty warned that fewer than two operational capital ships or destroyer groups stand ready at Monqiz—making distant sea landings perilous.", 109,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 and (Variable[\"Zille_Fleet_Total\"] or 0) < 2");

            AddLine(conv, 108, NarratorId, RomusId, "Briefing_Arsenal_Low_Warn",
                "The logistics officer lowered his voice uneasily: with fewer than 1,000 reserve weapons in the royal depots, prolonged frontal battles will rapidly exhaust our ammunition reserves unless foreign munitions arrive.", 109,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000");

            foreach (int prev in new[] { 6, 106 })
            {
                AddLink(conv, prev, 7);
                AddLink(conv, prev, 107);
                AddLink(conv, prev, 108);
            }

            // Tactical Consultation Hub (multi-option briefing before opening measures & doctrine)
            var consultHub = AddLine(conv, 109, NarratorId, RomusId, "Briefing_Tactical_Consult_Hub",
                "Lantern light flickered over the colored pins marking Wiktrany's rail hub, Munat's coastal batteries, and Zille City's outer ring. Before committing your forces, you could press your council on key tactical details.");

            consultHub.outgoingLinks.Add(CreateLink(conv.id, 109, 1091));
            consultHub.outgoingLinks.Add(CreateLink(conv.id, 109, 1092));
            consultHub.outgoingLinks.Add(CreateLink(conv.id, 109, 1093));
            consultHub.outgoingLinks.Add(CreateLink(conv.id, 109, 1094));
            consultHub.outgoingLinks.Add(CreateLink(conv.id, 109, 1095));

            AddChoice(conv, 1091, NarratorId, "Consult_Lucita_Defenses",
                "\"Break down Wehlen's fortifications in Wiktrany, Munat's coastal guns, and our best breakthrough axis.\"",
                "Give me the exact tactical layout: how strong are Wehlen's redoubts around Wiktrany and Munat's coastal batteries, and where do our columns punch through fastest?", -1,
                "Variable[\"Zille_Briefing_AskedDefenses\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;",
                "Variable[\"Zille_Briefing_AskedDefenses\"] ~= true");
            AddLine(conv, 10911, LucitaId, RomusId, "Consult_Lucita_Defenses_Ans",
                "\"Wiktrany's rail approaches are fortified, Your Majesty, yet our armor can flank through the northern ridge if infantry pins their center. Watch Munat's coastal batteries—our warships must silence them or stay outside their arc until land columns take the shore.\"", 109,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");
            AddLine(conv, 10912, CarlosId, RomusId, "Consult_Carlos_Defenses_Ans",
                "\"Smolak's engineers dug earthworks along Wiktrany's rail line and positioned heavy coastal artillery at Munat, Your Majesty. Flanking armor paired with artillery support will crack Wiktrany, while our fleet must respect Munat's shore guns until infantry secures the coast.\"", 109,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");
            AddLink(conv, 1091, 10911);
            AddLink(conv, 1091, 10912);

            AddChoice(conv, 1092, LaurentoId, "Consult_Laurento_Corridors",
                "\"Where do Derdia, Rumburg, and Lespia stand once our first shells land?\"",
                "Assess our foreign lifelines one last time: will Derdia open its southern corridor, and can we count on Rumburg or Lespia?", 10921,
                "Variable[\"Zille_Briefing_AskedForeign\"] = true;",
                "Variable[\"Zille_Briefing_AskedForeign\"] ~= true");
            AddLine(conv, 10921, LaurentoId, RomusId, "Consult_Laurento_Corridors_Ans",
                "\"If our pact with Supreme Wiseman Azmal holds, Derdia's northern passes give Plan Ark an overland dagger into Wehlen's rear. Rumburg's Queen Beatrice will back our sovereign claim at the AN, while Lespia's recon flights remain valuable so long as we are not at war with Pales.\"", 109);

            AddChoice(conv, 1093, NarratorId, "Consult_Titus_Underground",
                "\"Report on our loyalist cells inside Zille City and paratrooper drop zones behind the line.\"",
                "What is the status of our underground cells inside Zille City, and where can our paratroopers or special teams strike behind Wehlen's front?", -1,
                "Variable[\"Zille_Briefing_AskedUnderground\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "Variable[\"Zille_Briefing_AskedUnderground\"] ~= true");
            AddLine(conv, 10931, TitusId, RomusId, "Consult_Titus_Underground_Ans",
                "\"Loyalist telegraphers in Zille City are ready to cut Wehzek lines on our signal, Your Majesty. Once air cover clears the anti-air sectors, airborne drops behind Wiktrany can sever Wehlen's supply roads in hours—and my guardsmen will secure Queen Mother Estela's old district.\"", 109,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");
            AddLine(conv, 10932, NarratorId, RomusId, "Consult_Intel_Underground_Ans",
                "Military intelligence confirmed that loyalist cells inside Zille City were primed to sabotage Wehzek telegraphs, while airborne drop zones behind Wiktrany could sever Wehlen's supply roads once anti-air cover was suppressed.", 109,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");
            AddLink(conv, 1093, 10931);
            AddLink(conv, 1093, 10932);

            AddChoice(conv, 1094, ElenaId, "Consult_Elena_Supply",
                "\"How resilient are our supply roads and fuel reserves if the campaign drags into Phase II?\"",
                "Elena, if Wehlen holds out past the initial thrust, will our supply roads and fuel reserves hold for a second phase?", 10941,
                "Variable[\"Zille_Briefing_AskedSupply\"] = true;",
                "Variable[\"Zille_Briefing_AskedSupply\"] ~= true");
            AddLine(conv, 10941, ElenaId, RomusId, "Consult_Elena_Supply_Ans",
                "\"Keep our main roads connected back to Brenas hubs, Your Majesty—every linked province strengthens our defenders and speeds reinforcements. If a road is cut, our spearheads lose both supply resilience and rapid movement.\"", 109);

            AddChoice(conv, 1095, NarratorId, "Briefing_Proceed_PreOffensive",
                "\"Enough briefing. Move to pre-offensive measures and operational doctrine.\"",
                "We have the full picture. Let us decide our pre-offensive measures and authorize the operational doctrine.", 10,
                "", "");

            var prepHub = AddLine(conv, 10, NarratorId, RomusId, "Briefing_PreOffensive_Prompt",
                "Before issuing your command doctrine, you could dispatch last-hour naval or diplomatic opening moves ahead of dawn.");

            prepHub.outgoingLinks.Add(CreateLink(conv.id, 10, 14)); // Both Naval Blockade + AN Legal Dispatch (if Fleet>=2 & Energy>=1)
            prepHub.outgoingLinks.Add(CreateLink(conv.id, 10, 15)); // Naval Blockade only (if Fleet>=2 & Energy>=1)
            prepHub.outgoingLinks.Add(CreateLink(conv.id, 10, 17)); // AN Legal Dispatch only
            prepHub.outgoingLinks.Add(CreateLink(conv.id, 10, 175)); // Counter-intel radio & rail deception (-1 Budget, -2 Pressure, +1 Readiness)
            prepHub.outgoingLinks.Add(CreateLink(conv.id, 10, 180)); // Proceed directly to Command Doctrine

            AddChoice(conv, 14, LaurentoId, "Choice_Blockade_And_AN",
                "\"Seal the Strait of Kreleck (-1 Energy) AND circulate our 1927 treaty dossier in Konstantium before dawn!\"",
                "Sortie our squadrons from Monqiz to blockade the Gulf of Moridia and Strait of Kreleck, and have our Konstantium envoy distribute the 1927 treaty breach dossier before the first barrage!", 16,
                "Variable[\"Zille_NavalBlockadeActive\"] = true; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"Zille_AN_PreBrief_Sent\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 3; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;",
                "(Variable[\"Zille_Fleet_Total\"] or 0) >= 2 and (Variable[\"RiziaDLC.Resources_Energy\"] or 0) >= 1");

            // Pre-battle preparatory action: Naval Blockade across Gulf of Moridia
            AddChoice(conv, 15, LaurentoId, "Choice_Naval_Blockade",
                "\"Seal the Gulf of Moridia! Dispatch our warships to blockade Wehlen's supply convoys (-1 Energy).\"",
                "Before our infantry moves a meter, sortie our squadrons from Monqiz to blockade the Gulf of Moridia and Strait of Kreleck, choking Wehlen's sea supply lines from the mainland!", 16,
                "Variable[\"Zille_NavalBlockadeActive\"] = true; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;",
                "(Variable[\"Zille_Fleet_Total\"] or 0) >= 2 and (Variable[\"RiziaDLC.Resources_Energy\"] or 0) >= 1");

            AddLine(conv, 16, NarratorId, RomusId, "Ack_Naval_Blockade",
                "Admiralty telegraphs clattered instantly. Within twenty minutes, Monqiz confirmed destroyer flotillas and patrol craft steaming out to seal the Strait of Kreleck against Wehzek cargo steamers.", 19);

            AddChoice(conv, 17, LaurentoId, "Choice_AN_Legal_Dispatch",
                "\"Instruct our Konstantium envoy to circulate the 1927 treaty breach dossier before dawn.\"",
                "Have our ambassadors in Konstantium distribute the legal memorandum on Wehlen's 1927 treaty breach and bombing evidence to every delegation before the first artillery barrage begins.", 18,
                "Variable[\"Zille_AN_PreBrief_Sent\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 18, LaurentoId, RomusId, "Ack_AN_Legal_Dispatch",
                "Laurento nodded with sharp approval. \"Encrypted diplomatic bags are moving to Kyrute immediately, Your Majesty. Smolak will lose the propaganda battle before dawn.\"", 19);

            AddChoice(conv, 175, NarratorId, "Choice_Deception_Masking",
                "\"Execute radio and rail deception along Brenas to blind Wehlen's frontier scouts (-1 Budget, -2 Smolak Suspicion, +1 Readiness).\"",
                "Have military intelligence transmit false rail schedules, dummy depot orders, and spoofed radio traffic toward southern Brenas so Smolak pulls his guards back right before dawn.", 176,
                "Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"Zille_Deception_Op_Done\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; if (Variable[\"Zille_Smolak_Pressure\"] or 0) >= 2 then Variable[\"Zille_Smolak_Pressure\"] = Variable[\"Zille_Smolak_Pressure\"] - 2; else Variable[\"Zille_Smolak_Pressure\"] = 0; end;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1 and Variable[\"Zille_Deception_Op_Done\"] ~= true");

            AddLine(conv, 176, NarratorId, RomusId, "Ack_Deception_Masking",
                "\"Dummy wireless traffic is already rolling south toward Sallabes,\" Signals officers confirmed. \"Wehzek interceptors are chasing phantoms while our real spearheads stage in silence.\"", 10);

            AddChoice(conv, 180, NarratorId, "Choice_Skip_PreMeasures",
                "\"Keep radio silence—move straight to choosing our operational command doctrine.\"",
                "Maintain strict operational silence until the first guns speak. Let us choose our command doctrine now.", 19);

            var commandHub = AddLine(conv, 19, NarratorId, RomusId, "Command_Hub_Prompt",
                "Across the broad map table, the operational chart awaited your royal seal. How will Rizia command the liberation of Zille?");

            commandHub.outgoingLinks.Add(CreateLink(conv.id, 19, 20)); // Romus: Operation Golden Sword
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 19, 3100)); // Romus: Operation Golden Ark (Derdia Southern Corridor!)
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 19, 30)); // Romus: Operation Golden Ark (Maritime Fleet >= 2)
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 19, 35)); // Romus: Operation Golden Ark Reckless (Fleet < 2 warning)
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 19, 40)); // Staff Officers Command
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 19, 50)); // Postpone

            // Operation Golden Sword
            AddChoice(conv, 20, NarratorId, "Choice_Golden_Sword",
                "\"I will command at the War Table: Authorize Operation Golden Sword Phase I.\"",
                "I will command this campaign myself. Authorize Operation Golden Sword Phase I. Launch our armored spearheads across the Brenas-Zille frontier through Wiktrany toward Zille City and Munat.", -1,
                "Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenSword\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Golden_Sword_Lucita",
                "\"A glorious doctrine, Your Majesty!\" Lucita's eyes burned with martial pride. \"Our heavy tanks and mechanized brigades will punch straight through Wiktrany. The War Table awaits your deployment for Phase I!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Golden_Sword_Carlos",
                "General Carlos Azaro snapped a brisk salute. \"The armored spearheads are poised on the Brenas frontier. The War Table awaits your deployment for Phase I, Your Majesty.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 22, HugoId, RomusId, "Ack_Golden_Sword_Hugo",
                "\"May Saint Wruhec watch over our soldiers, Romus. Glovurius axa Rizia!\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 122, LaurentoId, RomusId, "Ack_Golden_Sword_NoHugo",
                "\"Godspeed to our armies, Your Majesty. Our envoys stand ready to defend Rizia's sovereign action.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);
            AddLink(conv, 21, 22);
            AddLink(conv, 21, 122);
            AddLink(conv, 121, 22);
            AddLink(conv, 121, 122);

            // Operation Golden Ark (Derdia Southern Corridor - ONLY if Derdia Pact Signed!)
            AddChoice(conv, 3100, NarratorId, "Choice_Golden_Ark_Derdia",
                "\"I will command at the War Table: Authorize Operation Golden Ark via Derdia's Southern Corridor!\"",
                "With Supreme Wiseman Azmal's alliance sealed, we need not gamble solely on sea landings! Authorize Operation Golden Ark through Derdia's northern frontier—strike straight out of Yol and Qerzan into Wehlen's soft southern underbelly while our ships seal the Gulf!", 3101,
                "Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;",
                "Variable[\"Zille_DerdiaPact_Signed\"] == true");

            AddLine(conv, 3101, NarratorId, RomusId, "Ack_Golden_Ark_Derdia",
                "A stir of sudden confidence swept the War Room as your pointer traced Derdia's northern frontier passes. \"Attacking Wehlen overland from Derdia's south gives our divisions devastating flanking power—Smolak's command cannot hold both Zille and Grodzizg at once. The War Table awaits your deployment!\"", 32);

            // Operation Golden Ark (Fleet >= 2)
            AddChoice(conv, 30, NarratorId, "Choice_Golden_Ark",
                "\"I will command at the War Table: Authorize Operation Golden Ark Phase I (Amphibious Envelopment).\"",
                "I will lead our forces personally. Authorize Operation Golden Ark Phase I. While border forces pin down Zille's front, our fleet will cross the Gulf of Moridia to strike mainland Wehlen at Kratsna, Rotsla, and Grodzizg!", -1,
                "Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;",
                "(Variable[\"Zille_Fleet_Total\"] or 0) >= 2");

            // Operation Golden Ark (Fleet < 2 warning variant!)
            AddChoice(conv, 35, NarratorId, "Choice_Golden_Ark_WeakFleet",
                "\"[RISKY — Weak Navy] Authorize Operation Golden Ark anyway across the Gulf of Moridia!\"",
                "Despite the Admiralty's warnings about our thin naval escorts, I authorize Operation Golden Ark! Load the transports and cross the Gulf of Moridia to sever Wehlen from behind!", -1,
                "Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) - 2;",
                "(Variable[\"Zille_Fleet_Total\"] or 0) < 2");

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Golden_Ark_Lucita",
                "\"An audacious maritime stroke!\" Lucita studied the sea lanes intensely. \"Landing across the Gulf of Moridia on mainland Wehlen will shock Smolak's command at its core. The War Table awaits your deployment for Phase I!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 131, CarlosId, RomusId, "Ack_Golden_Ark_Carlos",
                "General Carlos Azaro studied the sea lanes carefully. \"Our amphibious brigades and border screening battalions await your deployment at the War Table, Your Majesty.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 32, LaurentoId, RomusId, "Ack_Golden_Ark_Laurento",
                "\"Be warned, Your Majesty: striking mainland Wehlen directly across the sea will provoke Valgsland fiercely, so speed at sea will be everything. Godspeed to our fleet.\"", -1);

            foreach (int src in new[] { 30, 35 })
            {
                AddLink(conv, src, 31);
                AddLink(conv, src, 131);
            }
            AddLink(conv, 31, 32);
            AddLink(conv, 131, 32);

            // Staff Command
            AddChoice(conv, 40, NarratorId, "Choice_Staff_Command",
                "\"The General Staff will direct the campaign. Present the four staff doctrines for execution.\"",
                "The General Staff will direct the field execution of this war. Present your four strategic doctrines for royal selection.", 41,
                "Variable[\"Zille_War_PlanType\"] = \"Staff\";");

            var staffHub = AddLine(conv, 41, NarratorId, RomusId, "Staff_Doctrine_Presentation",
                "The General Staff laid out four strategic doctrines across the map:\n\n  Plan Hawk: Heavy aerial strikes and artillery barrages shatter Wehlen's command network (best with Bomber Wings & >=3 Energy).\n  Plan Sword: Aggressive armored charge through Wiktrany (best with >=2 Tank brigades & loyal House Azaro).\n  Plan Ark: Naval blockade and sea envelopment across the Gulf of Moridia (requires >=2 Warships/Submarines/Flagship).\n  Plan Spear: Covert night decapitation strike against Wehlen's frontline HQ (best with expanded Golden Guard / Intel Hub).\n\nWhich staff doctrine do you authorize?");

            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 42));  // Plan Hawk
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 43));  // Plan Sword
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 44));  // Plan Ark (Fleet >= 2)
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 440)); // Plan Ark Reckless (Fleet < 2)
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 45));  // Plan Spear

            AddChoice(conv, 42, NarratorId, "Authorize_Staff_Hawk",
                "\"Authorize Plan Hawk: Shatter their forward redoubts with air and artillery power.\"",
                "I authorize Plan Hawk. Bring down our bomber wings and heavy artillery to flatten their defensive works before our infantry advances.", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Hawk\"; Variable[\"Zille_War_Active\"] = true;");

            AddChoice(conv, 43, NarratorId, "Authorize_Staff_Sword",
                "\"Authorize Plan Sword: Unleash our armored divisions in a central breakthrough.\"",
                "I authorize Plan Sword. Mass our armor and let the Azaro divisions spearhead the breakthrough into Wiktrany.", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Sword\"; Variable[\"Zille_War_Active\"] = true;");

            AddChoice(conv, 44, NarratorId, "Authorize_Staff_Ark",
                "\"Authorize Plan Ark: Execute a disciplined maritime blockade and sea encirclement.\"",
                "I authorize Plan Ark. The Royal Navy will seal the Gulf of Moridia and Strait of Kreleck, cutting off Wehlen's sea supply lines.", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Ark\"; Variable[\"Zille_War_Active\"] = true;",
                "(Variable[\"Zille_Fleet_Total\"] or 0) >= 2");

            AddChoice(conv, 440, NarratorId, "Authorize_Staff_Ark_WeakFleet",
                "\"[RISKY — Few Warships] Authorize Plan Ark anyway: improvise a coastal blockade.\"",
                "Our fleet at Monqiz is small, yet order Plan Ark nonetheless—harass their coastal freighters with everything that floats!", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Ark\"; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) - 2;",
                "(Variable[\"Zille_Fleet_Total\"] or 0) < 2");

            AddChoice(conv, 45, NarratorId, "Authorize_Staff_Spear",
                "\"Authorize Plan Spear: Deploy elite commandos and guardsmen to decapitate Wehlen's command.\"",
                "I authorize Plan Spear. Send our finest operatives into Zille tonight to sever Wehlen's frontier communications and capture its staff before dawn.", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Spear\"; Variable[\"Zille_War_Active\"] = true;");

            AddLine(conv, 46, LucitaId, RomusId, "Ack_Staff_Lucita",
                "\"The orders are dispatched, Your Majesty! The General Staff has launched the offensive and will report front-line progress.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 146, CarlosId, RomusId, "Ack_Staff_Carlos",
                "\"The orders are dispatched, Your Majesty. The General Staff has initiated the offensive.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            foreach (int chId in new[] { 42, 43, 44, 440 })
            {
                AddLink(conv, chId, 46);
                AddLink(conv, chId, 146);
            }

            AddLine(conv, 47, TitusId, RomusId, "Ack_Staff_Titus",
                "\"My guardsmen are already moving under cover of darkness, Your Majesty,\" Titus said quietly, his hand resting firmly over his service sidearm. \"Smolak's officers will wake up in chains.\"", -1,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 147, CarlosId, RomusId, "Ack_Staff_Spear_NoTitus",
                "\"Our special commando detachments are already slipping across the frontier under darkness, Your Majesty. Wehlen's headquarters will be blind before dawn.\"", -1,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            AddLink(conv, 45, 47);
            AddLink(conv, 45, 147);

            AddChoice(conv, 50, NarratorId, "Choice_Postpone_War",
                "\"Hold the offensive for now. Maintain maximum combat readiness along the border.\"",
                "Hold the offensive for now. Keep our divisions at maximum combat readiness along the frontier, but do not cross until I give the royal command.", -1,
                "Variable[\"Zille_War_Postpone\"] = true;");

            AddLine(conv, 51, HugoId, RomusId, "Ack_Postpone_Hugo",
                "\"A prudent and measured decision, Your Majesty. The General Staff will maintain full readiness along the frontier.\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 151, LaurentoId, RomusId, "Ack_Postpone_NoHugo",
                "\"A measured decision, Your Majesty. Our diplomatic channels remain open while the armed forces hold their positions.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 50, 51);
            AddLink(conv, 50, 151);

            AddConversationWithAlias(db, conv, "Zille/WarCouncil_Briefing", "Turn_Zille_WarBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Council Briefing (ID 9988) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 4: Turn_Zille_MaveNortusHQ (ID 9994) - FRONTLINE HEADQUARTERS
        // Sequential, topic-to-topic regrouping council (zero hub loop!):
        // 1. Arrival & active regrouping after Phase I
        // 2. Plan-specific (SWORD vs ARK) realistic city assessment
        // 3. Enemy casualties (main success metric) + Own casualties (0-1, 2-4 Taddeus sim remark, 5+)
        //    (NO Pales mention unless Zille_Fighting_Pales == true!)
        // 4. Stockpile/Foreign aid & regrouping posture choice
        // 5. Mave Nortus refugee relief decision
        // 6. Phase II directive & closure (Phase II event unlocks shortly after at border)
        // =========================================================================
        public static void RegisterMaveNortusHQ(DialogueDatabase db)
        {
            var existingConv = db.GetConversation("Zille/MaveNortusHQ") ?? db.GetConversation("Turn_Zille_MaveNortusHQ");
            if (existingConv != null)
            {
                db.conversations.Remove(existingConv);
            }

            var conv = new Conversation();
            conv.id = ConvId_MaveNortusHQ;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/MaveNortusHQ";
            conv.ActorID = RomusId;
            conv.ConversantID = TaddeusId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, TaddeusId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            // Beat 1: Arrival & Regrouping Atmosphere
            AddLine(conv, 1, NarratorId, RomusId, "MaveNortus_Arrival",
                "Your armored convoy rolled through rain-lashed Mave Nortus. Along the rail sidings, soot-stained howitzers were uncoupling for barrel inspection while weary Phase I regiments rotated off the forward roads to rearm and regroup before the second wave. Outside the Mayor's Hall, a mud-spattered dispatch rider dismounted from his smoking motorcycle, clutching a canvas map case.", -1);

            AddChoice(conv, 401, NarratorId, "MaveNortus_Stimulus_Rider",
                "Pause on the stone steps to thank the exhausted dispatch rider and inspect the muddy road column.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "MaveNortus_Stimulus_Hall",
                "Pull your greatcoat collar tighter against the drizzle and stride straight through the oak doors.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "MaveNortus_Entry_Rider",
                "The young corporal's eyes widened through the road grime as he snapped a shaky salute. Beside the sandbags, artillerymen loading shells onto handcarts paused to cheer softly as you passed inside.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "MaveNortus_Entry_Hall",
                "The heavy oak doors swung shut behind you, trading the clatter of iron treads and rain for the smell of wet wool, coal smoke, and fresh ink.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, NarratorId, RomusId, "MaveNortus_Office_Entry",
                "Inside the Mayor's Hall, ledgers had been swept onto the floor beneath grease-marked operational charts. Duke Taddeus Azaro traced the shifting front line while Councilor Lucita Azaro sorted fresh courier dispatches.", 3,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 102, NarratorId, RomusId, "MaveNortus_Office_Carlos",
                "Inside the Mayor's Hall, ledgers lay stacked beside field telegraphs and grease-marked charts. General Carlos Azaro leaned over the table, coordinating the regrouping of forward brigades.", 103,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true) or (Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);

            AddLine(conv, 3, TaddeusId, RomusId, "Taddeus_HQ_Greeting",
                "\"Your Majesty! Having the Crown at our regrouping depot has steadied every battalion coming off the line. The first strike is concluded—now we catch our breath and prepare the finishing blow.\"", -1);

            AddLine(conv, 103, CarlosId, RomusId, "Carlos_HQ_Greeting",
                "\"Your Majesty. The first blow has landed and our columns are pulling back to reorganize along the Mave Nortus railheads before Phase II.\"", -1);

            // Beat 2: Plan-Aware Realistic Territorial Assessment (SWORD vs ARK)
            int leadSpeaker = NarratorId; // Uses NarratorId so portrait never shows arrested/executed Lucita
            // SWORD variants
            AddLine(conv, 210, leadSpeaker, RomusId, "Assess_Sword_ZilleCity",
                "\"Operation Righteous Sword's opening salvo shattered expectations along the coast—our spearheads actually fought their way into Zille City itself in Phase I! Our regrouping divisions only need to clear lingering border pockets in Phase II.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] == true and Variable[\"Zille_Cap_ZilleCity\"] == true");

            AddLine(conv, 211, leadSpeaker, RomusId, "Assess_Sword_Wiktrany",
                "\"Because assaulting Zille City head-on is like chewing iron, taking even a single fortified town in Phase I was the real measure—and our coastal push wrested Wiktrany from Wehlen's garrison. Holding Wiktrany gives our regrouping corps a dry port and flank anchor for Phase II.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] == true and Variable[\"Zille_Cap_ZilleCity\"] ~= true and Variable[\"Zille_Cap_Wiktrany\"] == true");

            AddLine(conv, 212, leadSpeaker, RomusId, "Assess_Sword_Munat",
                "\"Storming Zille City straight off the march was always near-impossible, yet our southern thrust drove the Wehzek defenders out of Munat! Securing Munat breaks the southern hinge and gives our regrouping artillery hard ground within range of Zille City for Phase II.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] == true and Variable[\"Zille_Cap_ZilleCity\"] ~= true and Variable[\"Zille_Cap_Wiktrany\"] ~= true and Variable[\"Zille_Cap_Munat\"] == true");

            AddLine(conv, 213, leadSpeaker, RomusId, "Assess_Sword_Nanta",
                "\"Zille City's inner ring remains forbidding, yet our northern push seized Nanta in the opening blow! Cutting that coastal spur means Wehlen cannot easily reinforce Zille City while we regroup for Phase II.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] == true and Variable[\"Zille_Cap_ZilleCity\"] ~= true and Variable[\"Zille_Cap_Wiktrany\"] ~= true and Variable[\"Zille_Cap_Munat\"] ~= true and Variable[\"Zille_Cap_Nanta\"] == true");

            AddLine(conv, 214, leadSpeaker, RomusId, "Assess_Sword_Rotsla",
                "\"Though Zille City's citadel stood firm, our right-flank spearhead cracked Rotsla in the opening days. One captured bastion gives our regrouping columns a secure eastern hinge before we pivot onto the peninsula.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] == true and Variable[\"Zille_Cap_ZilleCity\"] ~= true and Variable[\"Zille_Cap_Wiktrany\"] ~= true and Variable[\"Zille_Cap_Munat\"] ~= true and Variable[\"Zille_Cap_Nanta\"] ~= true and Variable[\"Zille_Cap_Rotsla\"] == true");

            AddLine(conv, 215, leadSpeaker, RomusId, "Assess_Sword_None",
                "\"We battered Wehlen's outer trench belts across the border, yet no walled town fell during Phase I—Zille City and its sister strongpoints held behind concrete. Regrouping must mass heavier siege fire before we strike again.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] == true and (Variable[\"Zille_Cap_Count\"] or 0) <= 0");

            // ARK variants
            AddLine(conv, 220, leadSpeaker, RomusId, "Assess_Ark_ZilleCity",
                "\"Operation Golden Ark defied every staff timetable: even while sweeping the outer approaches, our vanguard punched into Zille City itself before Phase I ended! Now our regrouping forces need only seal the remaining approaches.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] ~= true and Variable[\"Zille_Cap_ZilleCity\"] == true");

            AddLine(conv, 221, leadSpeaker, RomusId, "Assess_Ark_Kratsna",
                "\"With Zille City heavily garrisoned, taking even one major inland junction was Phase I's true prize—and Golden Ark's flank sweep seized Kratsna! Holding Kratsna snaps Wehlen's interior logistics as our columns regroup for Phase II.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] ~= true and Variable[\"Zille_Cap_ZilleCity\"] ~= true and Variable[\"Zille_Cap_Kratsna\"] == true");

            AddLine(conv, 222, leadSpeaker, RomusId, "Assess_Ark_Grodzizg",
                "\"Taking Zille City in one rush was never realistic against dug-in Wehzek armor—instead, our deep flank tore Grodzizg right out of Wehlen's interior belt! Losing Grodzizg leaves Wraclawitz scrambling while we regroup for Phase II.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] ~= true and Variable[\"Zille_Cap_ZilleCity\"] ~= true and Variable[\"Zille_Cap_Kratsna\"] ~= true and Variable[\"Zille_Cap_Grodzizg\"] == true");

            AddLine(conv, 223, leadSpeaker, RomusId, "Assess_Ark_Isor",
                "\"Zille City's fortress belt kept us out, yet our flank thrust captured Isor along the border road. Even one captured town turns Phase I into a clear springboard as we rearm for Phase II.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] ~= true and Variable[\"Zille_Cap_ZilleCity\"] ~= true and Variable[\"Zille_Cap_Kratsna\"] ~= true and Variable[\"Zille_Cap_Grodzizg\"] ~= true and Variable[\"Zille_Cap_Isor\"] == true");

            AddLine(conv, 224, leadSpeaker, RomusId, "Assess_Ark_PeninsulaTown",
                "\"Although Zille City's central redoubt and the deeper Wehlen cities still fly Smolak's banner, our opening sweep cleared a forward town on the peninsula—a vital jumping-off anchor as our regiments regroup.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] ~= true and Variable[\"Zille_Cap_ZilleCity\"] ~= true and Variable[\"Zille_Cap_Kratsna\"] ~= true and Variable[\"Zille_Cap_Grodzizg\"] ~= true and Variable[\"Zille_Cap_Isor\"] ~= true and (Variable[\"Zille_Cap_Count\"] or 0) >= 1");

            AddLine(conv, 225, leadSpeaker, RomusId, "Assess_Ark_None",
                "\"Golden Ark forced Wehzek Command to stretch its screen across rugged passes, though neither Kratsna nor the Zille cities dropped in Phase I. Our regrouping must concentrate armor where its flank finally snaps.\"", -1,
                "Variable[\"Zille_Plan_IsSword\"] ~= true and (Variable[\"Zille_Cap_Count\"] or 0) <= 0");

            foreach (int greet in new[] { 3, 103 })
            {
                foreach (int assessId in new[] { 210, 211, 212, 213, 214, 215, 220, 221, 222, 223, 224, 225 })
                {
                    AddLink(conv, greet, assessId);
                }
            }

            // Player advances seamlessly from territorial reality -> attrition ledger
            AddChoice(conv, 301, RomusId, "Prompt_Transition_EnemyToll",
                "\"Ground won matters, yet attrition decides wars. How badly did we bleed Wehlen's army—and what did it cost us?\"",
                "Map pins are only half the truth. Did our first strike break Wehlen's fighting formations, and what butcher's bill did our own brigades pay?", -1);

            AddChoice(conv, 302, RomusId, "Prompt_Transition_StaffToll",
                "\"Keep the foothold secure while we regroup. Now give me the honest casualty figures—Wehlen's first, then ours.\"",
                "Hold what our forward brigades bled for while they rearm. Now lay out the casualty tally—enemy losses first, then our own.", -1);

            foreach (int assessId in new[] { 210, 211, 212, 213, 214, 215, 220, 221, 222, 223, 224, 225 })
            {
                AddLink(conv, assessId, 301);
                AddLink(conv, assessId, 302);
            }

            // Beat 3A: Enemy Casualties FIRST (Main Satisfaction Driver for High Command)
            AddLine(conv, 230, NarratorId, RomusId, "EnemyLoss_High",
                "Your commanders' eyes lit up as intelligence laid the enemy battle sheet on the oak table. \"Five or more Wehzek brigades completely shattered in a single opening phase, Your Majesty!\" your chief of staff reported. \"Their mobile reserves are crippled—Smolak cannot replace armor that fast before Phase II!\"", -1,
                "(Variable[\"Zille_Phase1_EnemyDead\"] or 0) >= 5",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddLine(conv, 231, NarratorId, RomusId, "EnemyLoss_Medium",
                "A satisfied murmur circled the command table as the Wehzek toll was read aloud. \"Two to four intact Wehzek formations eliminated outright,\" your operations chief noted briskly. \"Every enemy battery knocked out in Phase I clears the road for our regrouping regiments in Phase II.\"", -1,
                "(Variable[\"Zille_Phase1_EnemyDead\"] or 0) >= 2 and (Variable[\"Zille_Phase1_EnemyDead\"] or 0) <= 4");

            AddLine(conv, 232, NarratorId, RomusId, "EnemyLoss_Low",
                "The mood over the enemy ledger grew taut and businesslike. \"Wehzek casualties stayed light—at most one shattered brigade,\" your intelligence officer admitted. \"Wehlen conserved its strength behind concrete, meaning Phase II will face stubborn, mostly intact defenders.\"", -1,
                "(Variable[\"Zille_Phase1_EnemyDead\"] or 0) <= 1");

            foreach (int c in new[] { 301, 302 })
            {
                AddLink(conv, c, 230);
                AddLink(conv, c, 231);
                AddLink(conv, c, 232);
            }

            // Beat 3B: Own Casualties Tiers (0-1 Light, 2-4 Moderate w/ Taddeus Simulation Remark, 5+ Heavy) - NO PALES MENTION!
            AddLine(conv, 240, TaddeusId, RomusId, "OwnLoss_Taddeus_Light",
                "\"And our own butcher's bill remained remarkably light, Your Majesty—at most one destroyed brigade across all of Phase I. Aid stations cleared cleanly, and the regiments regrouping in Mave Nortus still have full bayonet strength.\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true and (Variable[\"Zille_Phase1_PlayerDead\"] or 0) <= 1");

            AddLine(conv, 241, CarlosId, RomusId, "OwnLoss_Carlos_Light",
                "\"On our own ledger, Your Majesty, Phase I cost us at most a single lost brigade. Hospitals are manageable and replacement morale across Mave Nortus remains high.\"", -1,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true) and (Variable[\"Zille_Phase1_PlayerDead\"] or 0) <= 1");

            AddLine(conv, 242, TaddeusId, RomusId, "OwnLoss_Taddeus_Moderate",
                "Taddeus looked down at the Rizian casualty column, steady and unsentimental. \"Our own losses stand at moderate attrition—two to four shattered brigades breaking Wehlen's forward wall. Painful to read, Your Majesty, yes. Yet during our pre-war staff simulations we projected three to four lost units in the opening echelon. Those numbers match our mathematical expectations—our core striking power is completely intact.\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true and (Variable[\"Zille_Phase1_PlayerDead\"] or 0) >= 2 and (Variable[\"Zille_Phase1_PlayerDead\"] or 0) <= 4");

            AddLine(conv, 243, CarlosId, RomusId, "OwnLoss_Carlos_Moderate",
                "\"Our Phase I ledger shows moderate brigade losses—between two and four destroyed units along the fortified frontier,\" Carlos reported evenly. \"Just as Duke Taddeus's General Staff war-games predicted beforehand, breaching a fortified border exacts that toll. Losses remain well inside operational expectations.\"", -1,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true) and (Variable[\"Zille_Phase1_PlayerDead\"] or 0) >= 2 and (Variable[\"Zille_Phase1_PlayerDead\"] or 0) <= 4");

            AddLine(conv, 244, TaddeusId, RomusId, "OwnLoss_Taddeus_Heavy",
                "Taddeus's jaw tightened over the final column. \"I will not flatter you, Your Majesty: we suffered heavy losses—five or more brigades shattered in Phase I. That runs darker than our staff tables allowed. While the army regroups right now, we must weld battered companies into consolidated battlegroups and rely on concentrated artillery before committing Phase II.\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true and (Variable[\"Zille_Phase1_PlayerDead\"] or 0) >= 5");

            AddLine(conv, 245, CarlosId, RomusId, "OwnLoss_Carlos_Heavy",
                "\"I must report heavy Phase I losses, Your Majesty—five or more brigades knocked out of action,\" Carlos stated grimly. \"We are amalgamating depleted battalions during this regrouping window so Phase II leans on gunnery rather than costly infantry rushes.\"", -1,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true) and (Variable[\"Zille_Phase1_PlayerDead\"] or 0) >= 5");

            foreach (int el in new[] { 230, 231, 232 })
            {
                foreach (int ol in new[] { 240, 241, 242, 243, 244, 245 })
                {
                    AddLink(conv, el, ol);
                }
            }

            // Optional conditional Pales addendum - ONLY shown when actually fighting Pales!
            AddLine(conv, 249, CarlosId, RomusId, "OwnLoss_TwoFront_PalesAddendum",
                "\"What complicates replacements most is our parallel fighting against Pales on the eastern border—every shell train and surgical unit now splits between two active wars.\"", -1,
                "Variable[\"Zille_Fighting_Pales\"] == true");

            // Beat 4: Logistics, Foreign Support & Regrouping Tactic (flowing smoothly from casualties!)
            AddLine(conv, 250, NarratorId, RomusId, "Logistics_WellStocked",
                "A rail quartermaster unrolled the Brenas depot manifest beside the map. \"Over a thousand reserve rifles, spare gun barrels, and full diesel drums stand parked on Mave Nortus sidings, Your Majesty—mechanized spearheads can regroup cleanly for Phase II.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 and (Variable[\"RiziaDLC.Resources_Energy\"] or 0) > 2",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 251, NarratorId, RomusId, "Logistics_Strained",
                "A rail quartermaster pointed soberly to thin depot figures. \"Between shell expenditure and low fuel reserves—our stockpiles sit under a thousand reserve arms or thin diesel rations—our regrouping batteries must conserve heavy fire strictly for decisive Phase II breakthroughs.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000 or (Variable[\"RiziaDLC.Resources_Energy\"] or 0) <= 2");

            // Connect Own Losses -> (optional Pales line OR straight to Logistics)
            foreach (int ol in new[] { 240, 241, 242, 243, 244, 245 })
            {
                AddLink(conv, ol, 249);
                AddLink(conv, ol, 250);
                AddLink(conv, ol, 251);
            }
            AddLink(conv, 249, 250);
            AddLink(conv, 249, 251);

            // Foreign Aid flavor transition (accurate per active partner -> moves forward cleanly)
            AddLine(conv, 280, NarratorId, RomusId, "ForeignAid_Lespia",
                "Intelligence officers laid high-resolution Lespian reconnaissance photos across the map, marking Wehlen's camouflaged reserve bunkers before Phase II begins.", 258,
                "Variable[\"Zille_Lespia_Intel\"] == true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] ~= true",
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");
            AddLine(conv, 281, NarratorId, RomusId, "ForeignAid_Rumburg",
                "Rumburgian heavy 152mm shell trains pulling into Brenas yards have already doubled the ammunition allotment waiting for Phase II batteries.", 258,
                "Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] == true and Variable[\"Zille_DerdiaHybridActive\"] ~= true",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");
            AddLine(conv, 282, NarratorId, RomusId, "ForeignAid_Derdia",
                "Meanwhile, Derdian raiders striking Wehlen's eastern supply dumps continue forcing Wraclawitz to siphon brigades away from our front as we regroup.", 258,
                "Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] == true",
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");
            AddLine(conv, 283, NarratorId, RomusId, "ForeignAid_LespiaRumburg",
                "Both Lespian aerial photos pinpointing Wehlen's bunkers and Rumburgian heavy shell trains rolling into Brenas now feed directly into our Phase II fire plans.", 258,
                "Variable[\"Zille_Lespia_Intel\"] == true and Variable[\"Zille_Rumburg_Munitions\"] == true and Variable[\"Zille_DerdiaHybridActive\"] ~= true",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");
            AddLine(conv, 284, NarratorId, RomusId, "ForeignAid_LespiaDerdia",
                "Lespian recon flights have mapped Wehlen's camouflaged batteries while Derdian irregulars keep pinning Wehzek reserves far to the east.", 258,
                "Variable[\"Zille_Lespia_Intel\"] == true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] == true",
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");
            AddLine(conv, 285, NarratorId, RomusId, "ForeignAid_RumburgDerdia",
                "Rumburgian 152mm shell trains stacking Brenas depots and Derdian raids on Wehlen's frontier have both eased pressure while our columns regroup.", 258,
                "Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] == true and Variable[\"Zille_DerdiaHybridActive\"] == true",
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");
            AddLine(conv, 286, NarratorId, RomusId, "ForeignAid_All",
                "Allied support is telling: Lespian recon photos expose Wehlen's bunkers, Rumburgian heavy shells fill Brenas depots, and Derdian raids tie down Wehzek reserves.", 258,
                "Variable[\"Zille_Lespia_Intel\"] == true and Variable[\"Zille_Rumburg_Munitions\"] == true and Variable[\"Zille_DerdiaHybridActive\"] == true",
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 256, LucitaId, RomusId, "ForeignAid_Integrated_None",
                "\"No foreign power is fighting this war for us,\" Lucita noted, setting her steel dividers back on the map. \"Every shell moving up to the line comes from Rizian foundries.\"", 258,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] ~= true");

            AddLine(conv, 257, CarlosId, RomusId, "ForeignAid_Integrated_None_Carlos",
                "\"No foreign power is fighting this war for us,\" General Carlos Azaro noted flatly. \"Every shell moving up to the line comes from Rizian foundries.\"", 258,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] ~= true");

            foreach (int aidOut in new[] { 256, 257, 280, 281, 282, 283, 284, 285, 286 })
            {
                AddLink(conv, 250, aidOut);
                AddLink(conv, 251, aidOut);
            }

            // Regrouping Tactic Choice (interesting frontline commander friction -> moves forward!)
            AddLine(conv, 258, NarratorId, RomusId, "Regroup_Friction_Prompt",
                "Before turning to civilian matters, a sharp dispute broke out over how to spend the next forty-eight hours of regrouping: rest battered veterans behind Mave Nortus, or keep night raiding teams probing Wehlen's repair crews?");

            AddChoice(conv, 310, RomusId, "Regroup_RestRefit",
                "\"Give our battered spearheads full rest, hot rations, and fresh replacements before Phase II moves.\"",
                "Pull our exhausted spearheads clear of night skirmishing—give them hot rations, replacement crews, and clean guns before Phase II jumps off.", -1,
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddChoice(conv, 311, RomusId, "Regroup_NightRaids",
                "\"Rotate the main columns back, but keep light rangers harassing Wehlen's sappers every night!\"",
                "Reorganize the heavy regiments cleanly, yet send sapper patrols every night so Wehzek engineers cannot rebuild a single trench before Phase II!", -1,
                "Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLink(conv, 258, 310);
            AddLink(conv, 258, 311);

            // Beat 5: Mayor of Mave Nortus enters with Refugee Crisis
            var refugeeNode = AddLine(conv, 260, NarratorId, RomusId, "Mayor_HQ_Report",
                "At that moment the Mayor of Mave Nortus was ushered in, mud-caked coat steaming by the stove. \"Begging pardon, Your Majesty—over four thousand Rizian civilians have poured south from Zille ahead of Smolak's retreating demolition teams. Our schoolhouses and chapels are overflowing without grain or medicine.\"");

            AddLink(conv, 310, 260);
            AddLink(conv, 311, 260);

            AddChoice(conv, 320, RomusId, "Order_Refugee_Aid",
                "\"Mayor, release 1 Budget from the Crown chest for emergency grain, coal, and field clinics.\"",
                "The Crown immediately opens 1 Budget for grain, coal, and medical supplies. No Rizian driven out by Smolak will freeze outside our own headquarters.", 265,
                "Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"Zille_Refugee_Aid_Granted\"] = true; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1");

            AddLine(conv, 265, NarratorId, RomusId, "Ack_Refugee_Aid",
                "Tears welled in the Mayor's eyes as he bowed deeply. \"Every family along this road will bless the Crown tonight, Your Majesty.\"", 270);

            AddChoice(conv, 321, RomusId, "Order_Refugee_Rations",
                "\"Open army supply wagons to shelter and feed them using emergency royal mandates (-1 Authority).\"",
                "Our treasury cannot spare loose gold right now, Mayor, yet quartermasters will share military blankets, field bread, and requisitioned halls with every refugee family.", 266,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"Zille_Refugee_Aid_Granted\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 1");

            AddLine(conv, 266, NarratorId, RomusId, "Ack_Refugee_Rations",
                "The Mayor pressed his cap to his chest. \"Sharing the soldiers' own bread with fleeing citizens will never be forgotten.\"", 270);

            AddChoice(conv, 322, RomusId, "Order_Refugee_PriorityAmmo",
                "\"Every railcar must carry Phase II ammunition first—house them under municipal watch for now.\"",
                "Keep the rail sidings clear for Phase II artillery trains first, Mayor. Quarter the refugees in municipal halls until our second offensive secures Zille.", 267,
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 267, NarratorId, RomusId, "Ack_Refugee_MilitaryPriority",
                "The Mayor swallowed hard and nodded slowly, hurrying out to organize volunteers as artillery caissons rattled past the window.", 270);

            refugeeNode.outgoingLinks.Add(CreateLink(conv.id, 260, 320));
            refugeeNode.outgoingLinks.Add(CreateLink(conv.id, 260, 321));
            refugeeNode.outgoingLinks.Add(CreateLink(conv.id, 260, 322));

            // Beat 6: Seal Phase II Regrouping Directive (No immediate war-table teleport!)
            var phase2Prompt = AddLine(conv, 270, NarratorId, RomusId, "HQ_Phase2_Directive_Prompt",
                "The lamps burned low across the command map. Across the border, regrouped divisions were already rolling up toward their Phase II staging lines. Your generals stood at attention for your strategic doctrine before jumping off.");

            phase2Prompt.outgoingLinks.Add(CreateLink(conv.id, 270, 20));
            phase2Prompt.outgoingLinks.Add(CreateLink(conv.id, 270, 25));

            AddChoice(conv, 20, RomusId, "Order_Phase2_Launch",
                "\"Phase II Doctrine: Relentless Breakthrough—finish regrouping and shatter Wehlen's inner ring!\"",
                "Finish ammunition distribution tonight. Once our regrouped spearheads form at the border, smash straight through Wehlen's final fortifications so Smolak feels the tremors in Wraclawitz!", -1,
                "Variable[\"Zille_War_Phase\"] = 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;");

            AddChoice(conv, 25, RomusId, "Order_Phase2_Controlled",
                "\"Phase II Doctrine: Disciplined Envelopment—surround Zille City and compel surrender with minimal civilian harm.\"",
                "Complete our regrouping along the border approaches, then execute a disciplined Phase II envelopment—cut Zille City off cleanly while sparing civilian quarters.", -1,
                "Variable[\"Zille_War_Phase\"] = 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 21, NarratorId, RomusId, "Ack_Phase2_Lucita",
                "Lucita snapped her field baton onto Zille City with fierce focus. \"Regrouping orders are on the wire, Your Majesty! Once the columns finish staging along the frontier, Phase II will open at the Zille border!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Phase2_Carlos",
                "General Carlos Azaro saluted sharply. \"Directives dispatched, Your Majesty. As soon as our regrouping echelons reach the Zille frontier, Phase II will begin.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 22, TaddeusId, RomusId, "Ack_Phase2_Taddeus",
                "Taddeus raised his steel-hilted saber cleanly. \"To the staging lines, then—for King and Kingdom! Glovurius axa Rizia!\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            foreach (int p2 in new[] { 20, 25 })
            {
                AddLink(conv, p2, 21);
                AddLink(conv, p2, 121);
            }
            AddLink(conv, 21, 22);
            AddLink(conv, 121, 22);

            AddConversationWithAlias(db, conv, "Zille/MaveNortusHQ", "Turn_Zille_MaveNortusHQ");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected sequential Mave Nortus Field HQ (ID 9994) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 5: Turn_Zille_WarBalconySpeech (ID 9989) - WAR PROCLAMATION SPEECH
        // Two-stage proclamation: Doctrinal theme + Closing Commitment (micro-effects!)
        // =========================================================================
        public static void RegisterWarBalconySpeech(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarBalconySpeech") != null && db.GetConversation("Zille/WarBalconySpeech") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarBalconySpeech;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarBalconySpeech";
            conv.ActorID = RomusId;
            conv.ConversantID = HugoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, HugoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Balcony_Intro_1",
                "Behind the heavy crimson velvet curtains of Palas Rezna, the muffled roar of forty thousand citizens packed across the Royal Plaza vibrated through the floorboards. Banners of House Toras, Azaro, and Sazon snapped in the salt breeze outside while technicians checked the studio microphones carrying your words to every household in Rizia.", -1);

            AddChoice(conv, 401, NarratorId, "Balcony_Stimulus_Curtain",
                "Part the crimson velvet an inch to look out over the sea of banners before stepping into the sun.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Balcony_Stimulus_Sash",
                "Adjust the golden royal sash across your uniform and test the microphone switch with a quiet tap.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Balcony_Entry_Plaza",
                "From Porte Drazon's harbor boulevard to the palace gates, the plaza was a living ocean of gold and crimson. As the grand double doors swung wide, the crowd erupted.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Balcony_Entry_Mic",
                "The broadcast microphone hummed live across the kingdom's airwaves. As the grand double doors swung wide, a wall of cheering washed over the stone balustrade.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, NarratorId, RomusId, "Hugo_Balcony_Whisper",
                "Hugo leaned in, his voice barely audible beneath the roar. \"Both the realm and foreign embassies hear every syllable, Romus. Choose your message with care.\"", 3,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Balcony_Whisper",
                "Laurento inclined his head beside you. \"Both our citizens and the ambassadors in Konstantium, Kyrute are listening to every word, Your Majesty.\"", 3,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);

            var speechHub = AddLine(conv, 3, NarratorId, RomusId, "Speech_Doctrine_Prompt",
                "You stepped up to the stone balustrade and raised your hand. A profound hush settled over the plaza.");

            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Revanchist Might
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Liberating the Oppressed
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Sovereign Legalism

            AddChoice(conv, 10, HugoId, "Speech_Revanchist",
                "\"Sons and daughters of Rizia! We march to restore the honor and steel of our ancestors!\"",
                "Sons and daughters of Rizia! For over twenty-five years, our kingdom bore separation in silence. But House Toras does not bow to dictators! Today our armies march to reclaim our soil by royal steel!", 11,
                "Variable[\"Zille_Speech_Tone\"] = \"Revanchist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) - 1;");

            AddLine(conv, 11, NarratorId, RomusId, "Speech_Revanchist_Reaction",
                "A thunderous roar erupted from the square, bayonets flashing in the sun as guardsmen snapped to salute—while foreign press attachés scribbled furiously about Rizian saber-rattling.", 40);

            AddChoice(conv, 20, HugoId, "Speech_Liberation",
                "\"We march not as conquerors, but to bring our brothers and sisters in Zille safely home!\"",
                "People of Rizia! We march not out of hatred, but out of sacred love for our brothers and sisters in Zille who endured Smolak's secret police and broken promises. Today we bring them home!", 21,
                "Variable[\"Zille_Speech_Tone\"] = \"Liberation\"; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 21, NarratorId, RomusId, "Speech_Liberation_Reaction",
                "Tears flowed among the elders in the plaza, and chants of 'Long live King Romus!' rolled down the avenues toward the harbor.", 40);

            AddChoice(conv, 30, HugoId, "Speech_Legalist",
                "\"The 1927 agreement has expired. We enforce international law where Smolak trampled it!\"",
                "Citizens of Rizia and observers across Merkopa: Rizia is a realm of honor and law. The 1927 treaty has expired, and in reclaiming Zille we uphold the sacred legal order Wiktor Smolak trampled underfoot!", 31,
                "Variable[\"Zille_Speech_Tone\"] = \"Legalist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 31, NarratorId, RomusId, "Speech_Legalist_Reaction",
                "Foreign correspondents nodded in sober respect as applause rolled across the square in dignified cadence.", 40);

            // Second Stage: Final Pledge from the Balcony
            var closingHub = AddLine(conv, 40, NarratorId, RomusId, "Speech_Closing_Hub",
                "As the first ovation ebbed, the eyes of soldiers, merchants, and diplomatic envoys alike remained fixed upon the royal balustrade. You prepared your closing vow.");

            closingHub.outgoingLinks.Add(CreateLink(conv.id, 40, 41)); // Vow protection of Wehzek & Rizian civilians
            closingHub.outgoingLinks.Add(CreateLink(conv.id, 40, 42)); // Rally the armed forces & munitions production
            closingHub.outgoingLinks.Add(CreateLink(conv.id, 40, 43)); // Cite bombing atrocities publicly (if dossier exists!)

            AddChoice(conv, 41, HugoId, "Closing_Civilian_Charter",
                "\"I pledge before Nur: Rizian, Bludish, and peaceful Wehzek residents in Zille shall know law, not vengeance!\"",
                "Hear this royal vow: every Rizian, Bludish, and law-abiding Wehzek resident inside Zille will be shielded by our courts. We bring lawful peace, never blind reprisal! Glovurius axa Rizia!", 51,
                "Variable[\"Zille_BalconySpeech_Done\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddChoice(conv, 42, HugoId, "Closing_Soldier_Pride",
                "\"Stand behind our divisions, fuel our depots, and victory will be ours! Glovurius axa Rizia!\"",
                "Let every foundry, farm, and port stand beside the soldiers marching across our border tonight! Together, Rizia is invincible! Glovurius axa Rizia!", 52,
                "Variable[\"Zille_BalconySpeech_Done\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddChoice(conv, 43, LaurentoId, "Closing_Expose_Terror",
                "\"The world has seen Smolak's bombings and blackmail in Zille—we end his terror forever!\"",
                "For years our people endured Smolak's fabricated terror and extortion in Zille. Our evidence lies on the record, and our answer flies on the wind! Glovurius axa Rizia!", 53,
                "Variable[\"Zille_BalconySpeech_Done\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;",
                "((Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true) or Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] == true)");

            AddLine(conv, 51, LaurentoId, RomusId, "Ack_Closing_Charter",
                "Laurento exhaled in quiet admiration as you stepped back through the gilded doors. \"That civilian pledge just disarmed half our critics in Konstantium, Your Majesty.\"", -1);

            AddLine(conv, 52, NarratorId, RomusId, "Ack_Closing_Workers",
                "The plaza thundered with cheers that shook the tall palace glass. Workers, noble retainers, and guardsmen roared as one voice.", -1);

            AddLine(conv, 53, HugoId, RomusId, "Ack_Closing_Expose",
                "Foreign reporters sprinted for the telephone booths across the square as Smolak's culpability became tomorrow's headline across Merkopa.", -1);

            AddConversationWithAlias(db, conv, "Zille/WarBalconySpeech", "Turn_Zille_WarBalconySpeech");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Balcony Proclamation (ID 9989) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 5B: Turn_Zille_Op1AftermathCouncil (ID 10003) - POST-OPERATION I COUNCIL
        // Conditional negotiations vs transition to Operation 2: Operation: Total Repayment
        // =========================================================================
        public static void RegisterOp1AftermathCouncil(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_Op1AftermathCouncil") != null && db.GetConversation("Zille/Op1AftermathCouncil") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_Op1AftermathCouncil;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/Op1AftermathCouncil";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Op1Council_Open",
                "Dawn broke slowly over the War Room of Palas Rezna. Telegraph ribbons littered the carpet around the relief table where pins marked the final positions of Operation I. Your ministers and generals stood awaiting the verdict: negotiate under the guns of the first offensive, or escalate into the full continental theater of Operation: Total Repayment.");

            AddLine(conv, 2, HugoId, RomusId, "Op1Council_Hugo",
                "\"Your Majesty, the first full operation across Zille has come to its pause,\" Hugo said quietly, adjusting his cuffs over the casualty rosters. \"Let the General Staff and Foreign Ministry weigh what this offensive achieved.\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 3, LaurentoId, RomusId, "Op1Council_NoHugo",
                "\"Your Majesty, the dispatches from the southern front are all in,\" Laurento said calmly, laying two telegraph portfolios onto the table. \"Our next move will determine whether this ends at the table or widens across Wehlen.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 3);

            // Operation I Doctrine & Progress Reflection
            AddLine(conv, 10, LucitaId, RomusId, "Op1Report_Sword",
                "\"In Operation: Righteous Sword, our Brenas divisions threw their weight straight across the peninsula's fortifications,\" Lucita reported, sweeping her baton over Wiktrany, Munat, and Zille City.", -1,
                "Variable[\"Zille_Plan_IsSword\"] == true and Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 11, CarlosId, RomusId, "Op1Report_Sword_Carlos",
                "\"Operation: Righteous Sword drove straight into the peninsula's central defenses between Wiktrany, Munat, and Zille City,\" General Carlos Azaro stated cleanly.", -1,
                "Variable[\"Zille_Plan_IsSword\"] == true and (Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 12, LucitaId, RomusId, "Op1Report_Ark",
                "\"In Operation: Golden Ark, our flanking columns bypassed Zille's central wall to strike Wehlen's mainland hubs around Kratsna, Rotsla, and Grodzizg,\" Lucita reported briskly.", -1,
                "Variable[\"Zille_Plan_IsSword\"] ~= true and Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 13, CarlosId, RomusId, "Op1Report_Ark_Carlos",
                "\"Operation: Golden Ark carried our flanking spearheads across the approaches to Kratsna, Rotsla, and Grodzizg,\" General Carlos Azaro reported concisely.", -1,
                "Variable[\"Zille_Plan_IsSword\"] ~= true and (Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            foreach (int h in new[] { 2, 3 })
            {
                AddLink(conv, h, 10);
                AddLink(conv, h, 11);
                AddLink(conv, h, 12);
                AddLink(conv, h, 13);
            }

            // Combined casualty appraisal
            AddLine(conv, 20, NarratorId, RomusId, "Op1Casualties_Heavy",
                "Quartermasters read the cumulative toll of Phase I and Phase II alike: the Royal Army had paid in steep blood, yet battered Wehzek brigades stood stretched to breaking point along every frontier road.", -1,
                "(Variable[\"War_Zille_TotalPlayerDead\"] or 0) >= 5");

            AddLine(conv, 21, NarratorId, RomusId, "Op1Casualties_Disciplined",
                "Quartermasters laid down the final ledger cleanly: losses across both initial phases remained contained while Smolak's garrison regiments had bled heavily in reserve armor and coastal artillery.", -1,
                "(Variable[\"War_Zille_TotalPlayerDead\"] or 0) < 5");

            foreach (int prev in new[] { 10, 11, 12, 13 })
            {
                AddLink(conv, prev, 20);
                AddLink(conv, prev, 21);
            }

            // Conditional Branching:
            // Case A: Sword Victory (Zille City + (Wiktrany or Munat or Nanta) & Brenas safe)
            string condBrenasSafe = "(Variable[\"Zille_War_Outcome\"] or 0) ~= 1 and Variable[\"Brenas_Lost_To_Wehlen\"] ~= true";
            string condSwordVictory = condBrenasSafe + " and Variable[\"Zille_Cap_ZilleCity\"] == true and (Variable[\"Zille_Cap_Wiktrany\"] == true or Variable[\"Zille_Cap_Munat\"] == true or Variable[\"Zille_Cap_Nanta\"] == true)";
            string condNotSwordVictory = "(Variable[\"Zille_Cap_ZilleCity\"] ~= true or (Variable[\"Zille_Cap_Wiktrany\"] ~= true and Variable[\"Zille_Cap_Munat\"] ~= true and Variable[\"Zille_Cap_Nanta\"] ~= true))";
            string condNotArkExchange = "(Variable[\"Zille_Cap_Grodzizg\"] ~= true or (Variable[\"Zille_Cap_Kratsna\"] ~= true and Variable[\"Zille_Cap_Isor\"] ~= true and (Variable[\"War_Zille_TotalEnemyDead\"] or 0) < 6))";
            string condArkExchange = condBrenasSafe + " and " + condNotSwordVictory + " and Variable[\"Zille_Cap_Grodzizg\"] == true and (Variable[\"Zille_Cap_Kratsna\"] == true or Variable[\"Zille_Cap_Isor\"] == true or (Variable[\"War_Zille_TotalEnemyDead\"] or 0) >= 6)";
            string condCollapse = "(Variable[\"Zille_War_Outcome\"] or 0) == 1 or Variable[\"Brenas_Lost_To_Wehlen\"] == true";
            string condUnresolved = condBrenasSafe + " and " + condNotSwordVictory + " and " + condNotArkExchange;

            // --- CASE A: SWORD VICTORY (Conditional Negotiations Available!) ---
            AddLine(conv, 30, LaurentoId, RomusId, "CaseA_SwordVictory_Laurento",
                "\"An urgent cipher just arrived via our embassy in Konstantium!\" Laurento exclaimed, tapping the yellow ribbon. \"With Rizia holding Zille City itself and key peninsula approaches, Wiktor Smolak is pleading for an immediate ceasefire parley before our tanks cross onto mainland Wehlen.\"", 31,
                condSwordVictory);

            AddLine(conv, 31, NarratorId, RomusId, "CaseA_SwordVictory_ChoicePrompt",
                "Your commanders noted both paths clearly: you may halt at the border and dictate peace terms to a shaken Smolak now, OR refuse his plea and unleash Operation: Total Repayment into mainland Wehlen to break Wraclawitz once and for all.");

            AddChoice(conv, 310, LaurentoId, "Op1_Accept_Ceasefire_Sword",
                "\"Our mission in Zille is accomplished. Halt the advance and summon Smolak to the negotiation table.\"",
                "Zille is liberated and our honor stands vindicated. Spare our soldiers a deeper continental slaughter—accept the parley and summon Smolak to ratify the Treaty of Zille.", 320,
                "Variable[\"Zille_Negotiate_After_Op1\"] = true; Variable[\"Zille_Launch_TotalRepayment\"] = false; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2;");

            AddChoice(conv, 311, NarratorId, "Op1_Reject_Ceasefire_Sword",
                "\"Smolak only begs because Wraclawitz is naked! Authorize Operation: Total Repayment into mainland Wehlen!\"",
                "He struck our people with bombs and defiance for twenty-five years—we do not stop halfway! Tear up his telegram and launch Operation: Total Repayment across the entire Wehlen frontier!", 321,
                "Variable[\"Zille_Negotiate_After_Op1\"] = false; Variable[\"Zille_Launch_TotalRepayment\"] = true; Variable[\"Zille_TotalRepayment_Unlocked\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;");

            AddLink(conv, 31, 310);
            AddLink(conv, 31, 311);

            AddLine(conv, 320, LaurentoId, RomusId, "Ack_CaseA_Parley",
                "\"Wise statesmanship, Your Majesty. I will wire Kyrute and arrange the neutral pavilion on the frontier at once.\"", -1);

            AddLine(conv, 321, NarratorId, RomusId, "Ack_CaseA_Repay",
                "A fierce hush gripped the War Room as red operational arrows extended past Zille into mainland Wehlen. Operation: Total Repayment was unlocked across the southern theater.", -1);

            // --- CASE B: ARK MAINLAND LEVERAGE (Conditional Exchange Negotiations Available!) ---
            AddLine(conv, 40, LaurentoId, RomusId, "CaseB_ArkExchange_Laurento",
                "\"Operation: Golden Ark turned the tables strategically!\" Laurento announced, unfolding a dispatch from Kyrute. \"Holding Grodzizg and threatening Wehlen's mainland arteries has panicked Wraclawitz. Smolak's envoy whispers that Wehlen will evacuate Zille City peacefully if we restore Grodzizg and stop short of total war.\"", 41,
                condArkExchange);

            AddLine(conv, 41, NarratorId, RomusId, "CaseB_ArkExchange_Prompt",
                "You weighed the grand strategic bargain: accept Smolak's backchannel offer to trade mainland gains for an immediate negotiated return of Zille City, OR unleash Operation: Total Repayment to storm the entire Zille peninsula from both behind and across the frontier.");

            AddChoice(conv, 410, LaurentoId, "Op1_Accept_Ark_Exchange",
                "\"Use our hold on Grodzizg as leverage—open immediate exchange negotiations for the peaceful return of Zille City!\"",
                "Our flanking strike broke Smolak's bluff without wasting a single battalion in Zille City's streets. Summon Smolak now: we trade mainland withdrawals for Zille's unconditional restoration.", 420,
                "Variable[\"Zille_Negotiate_After_Op1\"] = true; Variable[\"Zille_Launch_TotalRepayment\"] = false; Variable[\"Zille_Ark_ExchangeOffer\"] = true; Variable[\"Zille_City_Captured\"] = true; Variable[\"Zille_War_Outcome\"] = 4; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true;");

            AddChoice(conv, 411, NarratorId, "Op1_Reject_Ark_Exchange",
                "\"We do not bargain for what belongs to Rizia! Launch Operation: Total Repayment and liberate Zille City by arms!\"",
                "Wehzek flags still fly over Zille City—and we did not cross the frontier to trade them away in backrooms! Unlock the whole theater: authorize Operation: Total Repayment!", 421,
                "Variable[\"Zille_Negotiate_After_Op1\"] = false; Variable[\"Zille_Launch_TotalRepayment\"] = true; Variable[\"Zille_TotalRepayment_Unlocked\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddLink(conv, 41, 410);
            AddLink(conv, 41, 411);

            AddLine(conv, 420, LaurentoId, RomusId, "Ack_CaseB_Parley",
                "\"A triumph of maneuver over slaughter, Your Majesty. Smolak cannot walk back this offer before AN witnesses.\"", -1);

            AddLine(conv, 421, NarratorId, RomusId, "Ack_CaseB_Repay",
                "Generals bent over the extended map sheets as every Zille and mainland Wehlen province unlocked simultaneously. Both fronts would burn in Operation: Total Repayment.", -1);

            // --- CASE C: BRENAS COLLAPSE (Emergency Parley vs Desperate Total Repayment) ---
            AddLine(conv, 50, LaurentoId, RomusId, "CaseC_Collapse_Warn",
                "\"Your Majesty—we face mortal danger,\" Laurento said grimly, his hands trembling slightly beside the red pins inside Brenas. \"Wehzek armored spearheads broke our southern cities. Wraclawitz demands immediate capitulation talks—or our entire army risks encirclement.\"", -1,
                condCollapse);

            AddChoice(conv, 510, LaurentoId, "Op1_Emergency_Parley",
                "\"Open emergency ceasefire negotiations immediately before Porte Drazon itself is imperiled.\"",
                "We will face Smolak across the table before the heartland burns further. Arrange the parley immediately.", 520,
                "Variable[\"Zille_Negotiate_After_Op1\"] = true; Variable[\"Zille_Launch_TotalRepayment\"] = false;");

            AddChoice(conv, 511, NarratorId, "Op1_Desperate_CounterOffensive",
                "\"Call up the Crown's emergency reserves (-1 Budget, -1 Authority)! Launch Operation: Total Repayment to throw them out of Brenas!\"",
                "I will not bargain with boots stamped on Brenas! Release emergency gold and issue total mobilization decrees—Operation: Total Repayment begins now!", 521,
                "Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"Zille_Negotiate_After_Op1\"] = false; Variable[\"Zille_Launch_TotalRepayment\"] = true; Variable[\"Zille_TotalRepayment_Unlocked\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1");

            AddChoice(conv, 512, NarratorId, "Op1_Desperate_CounterOffensive_NoGold",
                "\"Draft every reserve battalion by royal decree (-2 Authority)! Launch Operation: Total Repayment to defend our homeland!\"",
                "Our coffers are bare, yet our steel endures! Issue emergency mobilization mandates across every estate—launch Operation: Total Repayment and throw the invaders out of Brenas!", 521,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 2; Variable[\"Zille_Negotiate_After_Op1\"] = false; Variable[\"Zille_Launch_TotalRepayment\"] = true; Variable[\"Zille_TotalRepayment_Unlocked\"] = true;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 1");

            AddLink(conv, 50, 510);
            AddLink(conv, 50, 511);
            AddLink(conv, 50, 512);

            AddLine(conv, 520, LaurentoId, RomusId, "Ack_CaseC_Parley",
                "\"I pray our diplomacy can salvage what the front could not, Your Majesty.\"", -1);

            AddLine(conv, 521, NarratorId, RomusId, "Ack_CaseC_Repay",
                "Telegraph keys clattered across Palas Rezna's War Room as full-theater mobilization orders wired out to every surviving division under Operation: Total Repayment.", -1);

            // --- CASE D: UNRESOLVED / STALEMATE (Negotiations UNAVAILABLE after Op 1 -> Mandatory Op 2: Total Repayment) ---
            AddLine(conv, 60, LaurentoId, RomusId, "CaseD_Unresolved_Laurento",
                "Laurento shook his head darkly, tossing Wraclawitz's brief diplomatic note onto the map. \"Negotiations are off the table, Your Majesty. Because Zille City remains under Wehzek guns and we lack decisive leverage inside mainland Wehlen, Smolak rejected every Konstantium mediation feeler with open mockery.\"", 61,
                condUnresolved);

            AddLine(conv, 61, NarratorId, RomusId, "CaseD_Unresolved_Military",
                "Your generals turned squarely to the full-scale southern theater chart—all coastal marshes, mainland Wehzek rail arteries, and eastern corridors laid out together. To force Smolak back to the bargaining table, Rizia must escalate into Operation: Total Repayment.");

            AddChoice(conv, 610, NarratorId, "Op1_Force_TotalRepayment_Armor",
                "\"Authorize Operation: Total Repayment — Spearhead Doctrine: Mass armored assaults along every corridor (+1 Readiness).\"",
                "Then Smolak has chosen ruin! Open every border sector under Operation: Total Repayment—drive mechanized spearheads straight toward Zille City and Wehlen's mainland hubs alike!", 620,
                "Variable[\"Zille_Negotiate_After_Op1\"] = false; Variable[\"Zille_Launch_TotalRepayment\"] = true; Variable[\"Zille_TotalRepayment_Unlocked\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddChoice(conv, 611, LaurentoId, "Op1_Force_TotalRepayment_Siege",
                "\"Authorize Operation: Total Repayment — Methodical Encirclement & Allied Strike Doctrine (+1 Leverage).\"",
                "Smolak wants a war of endurance; we will choke him out across the entire map. Launch Operation: Total Repayment—coordinate our border breakthroughs, naval guns, and allied corridors to force his surrender!", 620,
                "Variable[\"Zille_Negotiate_After_Op1\"] = false; Variable[\"Zille_Launch_TotalRepayment\"] = true; Variable[\"Zille_TotalRepayment_Unlocked\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddLink(conv, 61, 610);
            AddLink(conv, 61, 611);

            AddLine(conv, 620, NarratorId, RomusId, "Ack_CaseD_TotalRepayment",
                "The sealed orders slammed onto the table. All remaining sectors unlocked simultaneously as Rizian and Wehzek armies braced for the decisive campaign—Operation: Total Repayment.", -1);

            foreach (int c in new[] { 20, 21 })
            {
                AddLink(conv, c, 30);
                AddLink(conv, c, 40);
                AddLink(conv, c, 50);
                AddLink(conv, c, 60);
            }

            AddConversationWithAlias(db, conv, "Zille/Op1AftermathCouncil", "Turn_Zille_Op1AftermathCouncil");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Post-Op I Aftermath Council (ID 10003) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 18: Turn_Zille_SovereigntyDeclaration (ID 10005) - CROWN STANCE: SOVEREIGNTY OVER ZILLE
        // Turn 3 Extraordinary Council prior to/alongside the Zille Statement decision.
        // Provides:
        // - Branch A: Peaceful diplomacy and reassurance.
        // - Branch B: Firm Valero Pact legalism and international pressure.
        // - Branch C: Hawkish escalation / March announcement -> Council pales, Hugo/Elena panic,
        //   Laurento's international analysis, Romus's iconic command:
        //   "THAT'S ENOUGH. Zille is a part of Rizia and Wehlen will do everything it can to stop the transfer..."
        // =========================================================================
        public static void RegisterSovereigntyDeclaration(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_SovereigntyDeclaration") != null && db.GetConversation("Zille/SovereigntyDeclaration") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_SovereigntyDeclaration;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/SovereigntyDeclaration";
            conv.ActorID = RomusId;
            conv.ConversantID = HugoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, HugoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Sovereignty_Atmosphere",
                "The Council Chamber of Palas Rezna was thick with nervous tension. Maps of South Merkopa and the contested Zille frontier lay unrolled across the long mahogany table. Sunlight filtered through tall arched windows, casting sharp shadows over the anxious faces of the royal ministers.", 10);

            AddLine(conv, 10, HugoId, RomusId, "Hugo_Sovereignty_Open",
                "\"Your Majesty, the bombing in Zille has sent shockwaves across South Merkopa. Smolak is beating his chest, and foreign embassies are buzzing. The 1927 lease expires in just a few short years—yet instead of discussing terms of orderly transition, Wehlen is accusing our subjects of treason and murder. We must define the Crown's grand posture before issuing any public proclamation.\"", 11);

            AddLine(conv, 11, ElenaId, RomusId, "Elena_Sovereignty_Warning",
                "\"The commercial sector is in dread, Sire. Rizian trade through the Zille corridor is already feeling the pinch of arbitrary Wehzek transit fees. Whatever stance we take must safeguard our fiscal stability and foreign trade credit.\"", 12);

            AddLine(conv, 12, LucitaId, RomusId, "Lucita_Sovereignty_Strength",
                "\"Fiscal stability means nothing if our frontiers are defenseless, Elena. Smolak senses weakness. If the King does not make Rizia's sovereign intent unmistakably clear, Wehlen will fabricate reasons to hold Zille indefinitely.\"", 13);

            AddLine(conv, 13, LaurentoId, RomusId, "Laurento_Sovereignty_Inquiry",
                "\"The eyes of Kyrute and the Alliance of Nations will be on us, Your Majesty. Every word spoken here will echo in foreign ministries across Merkopa. How does the Crown intend to approach the Zille question?\"", 20);

            // HUB 20: Stance Selection
            AddLine(conv, 20, NarratorId, RomusId, "Sovereignty_Stance_Hub",
                "The ministers leaned forward, waiting for the King's word.", -1);

            // Choice 21: Peaceful diplomacy
            AddChoice(conv, 21, ElenaId, "Choice_Sovereignty_Peaceful",
                "Calm yourselves. We will reclaim Zille through patient diplomacy and international law.",
                "\"Calm yourselves. Everything is under control. We will reclaim Zille through patient diplomacy and international law. We must not be provoked by Smolak's theatrics.\"",
                30,
                "Variable[\"Zille_Stance_Peaceful\"] = true; Variable[\"Zille_SovereigntyDeclaration_Done\"] = true; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            // Choice 22: Firm Valero legalism
            AddChoice(conv, 22, LaurentoId, "Choice_Sovereignty_Legalist",
                "We will strictly hold Wehlen to the 1927 Valero Pact. When the lease expires, Zille returns by right of law.",
                "\"We will strictly hold Wehlen to the 1927 Valero Pact. When the lease expires, Zille returns to Rizia by right of law. We shall rally our allies in the AN to hold Smolak accountable.\"",
                40,
                "Variable[\"Zille_Stance_Legalist\"] = true; Variable[\"Zille_SovereigntyDeclaration_Done\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            // Choice 23: March announcement (Escalation pathway)
            AddChoice(conv, 23, HugoId, "Choice_Sovereignty_MarchAnnouncement",
                "Enough pretense. Rizia will march into Zille upon expiration of the treaty regardless of Smolak's stance!",
                "\"Enough pretense. The Valero treaty had a deadline, and Rizia will march into Zille upon its expiration regardless of Wiktor Smolak's stance!\"",
                50,
                "Variable[\"Zille_Council_HawkishStance\"] = true;");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 22);
            AddLink(conv, 20, 23);

            // Branch A (Peaceful)
            AddLine(conv, 30, ElenaId, RomusId, "Elena_Peaceful_Relief",
                "\"A wise and measured approach, Sire. War or panic would frighten foreign capital and shatter our royal budget. Trade and quiet negotiation are our sharpest instruments.\"", 31);
            AddLine(conv, 31, HugoId, RomusId, "Hugo_Peaceful_Approve",
                "\"Smolak expects us to rage. Denying him that pretext keeps the moral high ground firmly in Rizian hands. We shall instruct the press to emphasize patience and restraint.\"", 32);
            AddLine(conv, 32, LucitaId, RomusId, "Lucita_Peaceful_Vigilant",
                "\"A peaceful handover is ideal, Your Majesty—so long as our patience is not mistaken for weakness. House Azaro will keep our frontier garrisons vigilant, just in case.\"", 33);
            AddLine(conv, 33, LaurentoId, RomusId, "Laurento_Peaceful_Plan",
                "\"I shall prepare diplomatic dispatches to Wehlen emphasizing our shared interests in a peaceful resolution. God grant that Smolak listens to reason.\"", 90);

            // Branch B (Firm Legalist)
            AddLine(conv, 40, LaurentoId, RomusId, "Laurento_Legalist_Support",
                "\"International law is on our side, Sire. Smolak signed that treaty in blood and ink. If we present our legal case forcefully in Kyrute, even Wehlen's lukewarm supporters will find it difficult to back his posturing.\"", 41);
            AddLine(conv, 41, LucitaId, RomusId, "Lucita_Legalist_Garrisons",
                "\"A firm legal stance must be backed by quiet strength. The frontier garrisons should begin routine logistics exercises, simply to remind Wehlen that the treaty carries weight.\"", 42);
            AddLine(conv, 42, HugoId, RomusId, "Hugo_Legalist_Prudence",
                "\"A balanced middle course, Your Majesty. It asserts our rights without needlessly lighting the powder keg. Let the legal clerks and diplomats do their work.\"", 90);

            // Branch C (Escalation / Shock)
            AddLine(conv, 50, NarratorId, RomusId, "Sovereignty_Council_Shock",
                "A heavy, suffocating silence gripped the council chamber. Hugo went pale, his tea cup trembling against the saucer. Elena's eyes widened in sheer disbelief, her hands gripping the edge of her ledger until her knuckles turned white.", 51);
            AddLine(conv, 51, HugoId, RomusId, "Hugo_March_Panic",
                "\"Sweet Saint Drezet, Your Majesty! Have you lost your senses?! Walking into Zille by force—ignoring Wehlen's sovereignty—is not statecraft, it is an open declaration of war! The entire Alliance of Nations will brand us rogue aggressors!\"", 52);
            AddLine(conv, 52, ElenaId, RomusId, "Elena_March_Sanctions",
                "\"Our treasury cannot endure an international embargo, Sire! If sanctions strike our wine, gold, and shipping lines, the kingdom's economy will collapse into ruin before a single regiment crosses the frontier!\"", 53);
            AddLine(conv, 53, LucitaId, RomusId, "Lucita_March_Calculation",
                "\"Smolak has five infantry divisions dug into the Zille coastal ridges, Sire. If we move without total preparation and an ironclad casus belli, we walk into a fortified trap.\"", 54);
            AddLine(conv, 54, LaurentoId, RomusId, "Laurento_March_Assessment",
                "\"We still don't know if the Wehzeks will actually want to fight for that piece of land, but the international implications will be tough. We would need to address all possible avenues to sway the international opinion to our side.\"", 60);

            // HUB 60: Romus's Decisive Command
            AddLine(conv, 60, NarratorId, RomusId, "Sovereignty_Command_Hub",
                "Every eye in the chamber was locked upon you. The destiny of the realm hung upon your next command.", -1);

            // Choice 61: The Iconic Command
            AddChoice(conv, 61, LucitaId, "Choice_Command_MarchIntoZille",
                "(ENOUGH. Prepare to march into Zille) THAT'S ENOUGH. Zille is a part of Rizia and Wehlen will do everything it can to stop the transfer from happening. Prepare the plans for transition of power regardless of Wehlen Cooperation.... And prepare the military if Smolak happens to resist.",
                "\"THAT'S ENOUGH! Zille is a part of Rizia and Wehlen will do everything it can to stop the transfer from happening. Prepare the plans for transition of power regardless of Wehlen cooperation.... And prepare the military if Smolak happens to resist.\"",
                70,
                "Variable[\"Zille_War_EarlyLaunch\"] = true; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_Council_HawkishStance\"] = true; Variable[\"Zille_SovereigntyDeclaration_Done\"] = true; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 2; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = (Variable[\"RiziaDLC.HouseAzaro_Opinion\"] or 0) + 1; Variable[\"RiziaDLC.Diplomacy_Wehlen_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Wehlen_NegotiatingPower\"] or 0) - 1;");

            // Choice 62: Tempered Hawkish
            AddChoice(conv, 62, HugoId, "Choice_Command_TemperedHawkish",
                "Perhaps you are right. We must make our resolve unmistakable, but exhaust every diplomatic channel first.",
                "\"Perhaps you are right. We must make our resolve unmistakable to Smolak, but we will exhaust every diplomatic channel in the AN before firing a single shot.\"",
                75,
                "Variable[\"Zille_War_Postpone\"] = true; Variable[\"Zille_Stance_Legalist\"] = true; Variable[\"Zille_SovereigntyDeclaration_Done\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            AddLink(conv, 60, 61);
            AddLink(conv, 60, 62);

            // Choice 61 resolution
            AddLine(conv, 70, LucitaId, RomusId, "Lucita_Command_Salute",
                "\"As you command, Your Majesty! House Azaro and the General Staff will draft operational staging plans at Mave Nortus immediately. Smolak will find no weakness here.\"", 71);
            AddLine(conv, 71, HugoId, RomusId, "Hugo_Command_Prayer",
                "\"May the saints preserve us. If blood must flow, let it at least flow swiftly... God save King Romus.\"", 72);
            AddLine(conv, 72, LaurentoId, RomusId, "Laurento_Command_DiplomaticGroundwork",
                "\"I will begin laying diplomatic groundwork in the AN immediately, Sire. We must frame Smolak as the obstinate leaseholder breaking solemn covenants, while Rizia acts as the lawful protector.\"", 90);

            // Choice 62 resolution
            AddLine(conv, 75, HugoId, RomusId, "Hugo_Tempered_Relief",
                "\"A prudent course, Sire. A sword held at the throat is far more persuasive when the sheath has not yet been cast away.\"", 76);
            AddLine(conv, 76, LucitaId, RomusId, "Lucita_Tempered_Readiness",
                "\"We shall prepare the troops quietly. Smolak will feel the steel behind our diplomats' words.\"", 90);

            // Scene Conclusion
            AddLine(conv, 90, NarratorId, RomusId, "Sovereignty_Conclusion",
                "With the Crown's grand posture settled, the ministers collected their folios. The royal proclamation to the press and the Alliance of Nations would now reflect the King's sovereign command.", 2);

            var entry2 = CreateEntry(conv.id, 2, NarratorId, RomusId, "END", "", "", "");
            conv.dialogueEntries.Add(entry2);

            AddConversationWithAlias(db, conv, "Zille/SovereigntyDeclaration", "Turn_Zille_SovereigntyDeclaration");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Crown Stance: Sovereignty Over Zille (ID 10005) into masterDatabase!");
        }
    }
}
