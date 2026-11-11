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
        // Hugo Toras, Lucita Azaro, Elena Werner, Laurento Esquibel, Titus Gordion.
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
                "Outside the council chamber windows, gray rain lashed against the stone spires of Palas Rezna. An emergency war map of the Brenas-Zille peninsula and the Gulf of Moridia lay unfurled across the mahogany table, weighed down by heavy bronze candleholders. The ministers took their seats in somber silence, the gravity of the hour hanging heavy in the air.", 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Planning_Open",
                "Your Majesty... We have convened the Crown Council under extraordinary circumstances. Smolak's continued defiance and the escalating tensions in Zille have brought our kingdom to a decisive crossroads.", 3,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and Variable[\"RiziaDLC.Country_HouseToras_Enemy\"] ~= true");

            AddLine(conv, 102, HugoId, RomusId, "Hugo_Planning_Open_Hostile",
                "Your Majesty. Though relations between the Crown and House Toras have grown strained, the integrity of the realm leaves us no choice but to confront Smolak's continued defiance in Zille.", 3,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and Variable[\"RiziaDLC.Country_HouseToras_Enemy\"] == true");

            AddLine(conv, 103, LaurentoId, RomusId, "Laurento_Planning_Open_NoHugo",
                "Your Majesty. In the Grand Vizier's absence, we have convened an emergency council. Smolak's continued defiance in Zille has brought our kingdom to a decisive crossroads.", 3,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            var e1 = conv.GetDialogueEntry(1);
            e1.outgoingLinks.Clear();
            e1.outgoingLinks.Add(CreateLink(conv.id, 1, 2));
            e1.outgoingLinks.Add(CreateLink(conv.id, 1, 102));
            e1.outgoingLinks.Add(CreateLink(conv.id, 1, 103));

            var stanceHub = AddLine(conv, 3, RomusId, HugoId, "Romus_Planning_Posture_Prompt",
                "I looked at the gathered faces of my council, each waiting for their King to establish the direction of the realm.");

            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive force
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Pragmatic caution
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Sovereign legalism

            AddChoice(conv, 10, HugoId, "Posture_Force",
                "\"Over twenty-five years of national humiliation ends here. It is time the Crown plans the military reclamation of Zille.\"",
                "Over twenty-five years of national humiliation ends here. Smolak will not return our territory through words. It is time the Crown plans the military reclamation of Zille by force of arms.", -1,
                "Variable[\"Zille_Planning_Stance\"] = \"Force\";");

            AddChoice(conv, 11, HugoId, "Posture_Pragmatic",
                "\"We must weigh our capabilities soberly. Can the Kingdom truly bear the burden of a war against Wehlen?\"",
                "We must weigh our capabilities soberly. Can our treasury, our military, and our people truly bear the burden of a war against Wehlen? I need honest counsel, not bravado.", -1,
                "Variable[\"Zille_Planning_Stance\"] = \"Cautious\";");

            AddChoice(conv, 12, HugoId, "Posture_Legal",
                "\"The 1927 agreement has expired. Wehlen's presence is an unlawful occupation. We will uphold our sovereign right.\"",
                "The 1927 agreement has expired. Wehlen's continued presence is an unlawful foreign occupation. If Smolak refuses to withdraw, we have every legal and sovereign right to expel his garrisons.", -1,
                "Variable[\"Zille_Planning_Stance\"] = \"Legal\";");

            // Post-stance reaction: Hugo if free, else Laurento
            AddLine(conv, 20, HugoId, RomusId, "Hugo_Dynastic_Warning",
                "Romus... As your uncle and your Grand Vizier, I must urge profound care. Your father, King Valero, leased Zille to quell internal turmoil when the throne itself was shaking. If we march across that frontier and stumble, the divine authority of House Toras will suffer a blow from which it may never recover.", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 120, LaurentoId, RomusId, "Laurento_Dynastic_Warning",
                "Your Majesty, I must urge profound care. King Valero signed the 1927 agreement under immense pressure; if our armies march across the Brenas-Zille frontier and stumble, the Crown's prestige across South Merkopa will suffer grievously.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            foreach (int cid in new[] { 10, 11, 12 })
            {
                AddLink(conv, cid, 20);
                AddLink(conv, cid, 120);
            }

            // Military appraisal: Lucita if free, else Taddeus or Carlos
            AddLine(conv, 21, LucitaId, RomusId, "Lucita_Military_Appraisal_1",
                "With respect, inaction is far more dangerous, Your Majesty. General Valdez commands four Wehzek brigades on the peninsula: an armored detachment at the central rail hub of Wiktrany, two dug-in infantry brigades around Zille City itself, and a garrison guarding the northern port of Munat.", 22,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 22, LucitaId, RomusId, "Lucita_Military_Appraisal_2",
                "Valdez's men are largely conscripts, supplied by sea across the Gulf of Moridia and demoralized by Smolak's erratic purges. The Azaro divisions and the Royal Army possess superior mechanized armor and professional training. If we strike swiftly before Wehzek warships and transports reinforce Munat, his outer line will collapse like dry timber.", 23);

            AddLine(conv, 121, TaddeusId, RomusId, "Taddeus_Military_Appraisal",
                "Inaction is far more dangerous, Your Majesty. General Valdez commands four Wehzek brigades across the peninsula—concentrated at Wiktrany, Zille City, and the port of Munat—supplied by sea across the Gulf of Moridia. If our divisions strike decisively before Wehlen ships reinforcements through the Strait of Kreleck, his perimeter will break.", 23,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 122, CarlosId, RomusId, "Carlos_Military_Appraisal",
                "With respect, Your Majesty, inaction invites further humiliation. General Valdez holds four Wehzek brigades between Wiktrany, Zille City, and the port of Munat, relying on sea convoys across the Gulf of Moridia. Strike decisively before reinforcements land, and his perimeter will crack.", 23,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and (Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            foreach (int prev in new[] { 20, 120 })
            {
                AddLink(conv, prev, 21);
                AddLink(conv, prev, 121);
                AddLink(conv, prev, 122);
            }

            AddLine(conv, 23, ElenaId, RomusId, "Elena_Economic_Reality",
                "Courage does not buy diesel, Your Majesty. Our royal treasury cannot afford wishful thinking. A mobile offensive consumes petroleum and replacement munitions at an exorbitant burn rate. If the operation drags into a protracted siege, we face staggering deficits and domestic inflation.", 24);

            AddLine(conv, 24, LaurentoId, RomusId, "Laurento_International_Horizon",
                "The diplomatic battleground is equally hazardous, Your Majesty. Chancellor Hegel of Valgsland and United Contana will condemn our offensive as monarchist aggression. However, because the 1927 lease has unambiguously lapsed, Prime Minister Alvarez of Lespia and the ATO powers will hesitate to intervene against us if we present the campaign as a swift, localized restoration of sovereign order.", -1);

            AddLine(conv, 25, TitusId, RomusId, "Titus_Security_Estela",
                "Internal security must not be overlooked, Your Majesty. Su Omina and ATA networks inside Zille are ready to disrupt Wehzek communications. Furthermore, the Golden Guard has prepared elite detachments to secure Queen Mother Estela's childhood family home in Zille's harbor district the moment our spearheads enter the city.", 30,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 125, NarratorId, RomusId, "Security_NoTitus",
                "Military intelligence officers quietly noted that pro-Rizian networks inside Zille stood ready to disrupt Wehzek communications, and vanguard units had orders to protect Queen Mother Estela's old family neighborhood in the harbor district.", 30,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            AddLink(conv, 24, 25);
            AddLink(conv, 24, 125);

            var inquiryHub = AddLine(conv, 30, NarratorId, RomusId, "Planning_Inquiry_Hub",
                "The room grew quiet as the advisors awaited your direction. Several strategic questions demanded clarification before a mobilization decree could be issued.");

            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 31)); // Question Military
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 32)); // Question Elena
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 33)); // Question Laurento
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 34)); // Question Security
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Conclude planning

            AddChoice(conv, 31, LucitaId, "Inquire_Lucita",
                "\"What terrain obstacles must our armored divisions overcome in Zille?\"",
                "Detail the terrain obstacles our mechanized units must overcome between Brenas and Zille. Where will Valdez make his stand?", -1);

            AddLine(conv, 35, LucitaId, RomusId, "Answer_Lucita",
                "The central approach crosses the coastal lowlands and marshlands surrounding Wiktrany. If we punch through the central highway junction, we sever Valdez's lateral communications between Nanta and Zille City, while the Royal Navy contests his supply ships in the Gulf of Moridia. If heavy rains flood the marshes, however, our tanks will need solid logistics out of Brenas.", 30,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 135, CarlosId, RomusId, "Answer_Carlos_Terrain",
                "The approach from Brenas leads through coastal hills and marshlands around Wiktrany, Your Majesty. Seizing that central road junction splits Valdez's garrisons, while our warships cut his sea lanes across the Gulf of Moridia. Heavy rains can bog down armor in the lowlands, so supply from Brenas will be decisive.", 30,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 31, 35);
            AddLink(conv, 31, 135);

            AddChoice(conv, 32, ElenaId, "Inquire_Elena",
                "\"Elena, what financial reserves can we mobilize without bankrupting social programs?\"",
                "Elena, what financial reserves can we tap without crippling municipal budgets and domestic welfare?", 36);

            AddLine(conv, 36, ElenaId, RomusId, "Answer_Elena",
                "If we issue royal war bonds and secure foreign energy credits, we can absorb the initial shocks. But the logistics framework is paramount-supplying the army locally out of Brenas granaries and coastal convoys will conserve gold, whereas shipping everything by rail from Montaklar will burn through our strategic oil reserves.", 30);

            AddChoice(conv, 33, LaurentoId, "Inquire_Laurento",
                "\"Laurento, can we secure a veto or friendly neutrality in the Alliance of Nations?\"",
                "Laurento, can we secure a veto or friendly neutrality from the major powers in the Alliance of Nations?", 37);

            AddLine(conv, 37, LaurentoId, RomusId, "Answer_Laurento",
                "Queen Beatrice of Rumburg will stand firmly with us in the AN, provided we maintain GRACE solidarity. Prime Minister Alvarez can be persuaded through economic incentives to keep Lespia's radar and reconnaissance active for our benefit. Smolak will find himself isolated across the sea if we strike decisively.", 30);

            AddChoice(conv, 34, TitusId, "Inquire_Titus",
                "\"How confident are we in protecting Queen Estela's childhood home and civilian loyalists?\"",
                "How confident are you that our vanguard can shield Queen Mother Estela's childhood home in Zille and protect civilian loyalists?", -1);

            AddLine(conv, 38, TitusId, RomusId, "Answer_Titus",
                "Completely confident, Your Majesty. My finest Golden Guard detachment is briefed and ready to ride or drop with the very vanguard of the advance. No harm will come to the Queen Mother's old neighborhood or her late family's home.", 30,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 138, CarlosId, RomusId, "Answer_Security_NoTitus",
                "Our forward reconnaissance battalions have standing orders to cordon off the harbor district around Queen Mother Estela's childhood home the moment we enter Zille City, Your Majesty.", 30,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            AddLink(conv, 34, 38);
            AddLink(conv, 34, 138);

            AddChoice(conv, 40, HugoId, "Conclude_Planning",
                "\"The decision is made. Prepare the kingdom for war. Convene the Logistics Summit in Brenas.\"",
                "The decision is made. The Crown resolves on the military reclamation of Zille. Draft the preliminary deployment orders and convene the provincial lords and military command for the Logistics Summit. We will resolve our supply lines once and for all.", -1,
                "Variable[\"Zille_War_Planning_Done\"] = true; Variable[\"Zille_War_Sentiment\"] = 3;");

            AddLine(conv, 41, HugoId, RomusId, "Hugo_Planning_Close",
                "\"As your sovereign will decrees, Your Majesty. May Saint Wruhec guide our banners and preserve our realm.\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 141, LaurentoId, RomusId, "Laurento_Planning_Close",
                "\"Your sovereign will is clear, Your Majesty. The ministry will ready all diplomatic dispatches for the coming storm.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 40, 41);
            AddLink(conv, 40, 141);

            AddLine(conv, 42, LucitaId, RomusId, "Lucita_Planning_Close",
                "Lucita snapped to attention and saluted crisply. \"The General Staff will initiate immediate preparations. The road to Zille begins now, Your Majesty.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 142, CarlosId, RomusId, "Carlos_Planning_Close",
                "General Carlos Azaro saluted sharply. \"The General Staff will initiate immediate preparations. Our divisions will be ready, Your Majesty.\"", -1,
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
        // Handles Angelica exiled/pardoned/arrested, Manus exiled/arrested/Vina,
        // Leona Sazon fallback, Lucita/Taddeus arrested/hostile, Hugo absent.
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

            // Intro variants based on who is physically present
            AddLine(conv, 1, NarratorId, RomusId, "Logistics_Intro_BothSazon",
                "The atmosphere inside the State Dining Hall of Palas Rezna crackled with noble animosity. Servants had cleared the banquet tables for logistical ledgers, railway maps, and provincial supply manifests. On one side sat House Azaro's commanders in crisp uniform; on the other sat Duchess Angelica Sazon and Manus Sazon in dark Brenas velvet.", -1,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 101, NarratorId, RomusId, "Logistics_Intro_ManusOnly",
                "The State Dining Hall of Palas Rezna was tense with quiet hostility. Logistical ledgers and railway maps covered the long oak table. Facing House Azaro's uniformed generals sat Manus Sazon alone—his mother, Duchess Angelica, still absent from the court.", -1,
                "(Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 102, NarratorId, RomusId, "Logistics_Intro_AngelicaOnly",
                "The State Dining Hall of Palas Rezna crackled with aristocratic tension. Across the ledger-strewn table from House Azaro's officers sat Duchess Angelica Sazon alone, representing Brenas in the absence of her son Manus.", -1,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true and (Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            AddLine(conv, 103, NarratorId, RomusId, "Logistics_Intro_LeonaOnly",
                "The State Dining Hall of Palas Rezna was frigid with mutual suspicion. With both Angelica and Manus Sazon absent from the court, Countess Leona Sazon of Sallabes had been summoned to represent the mercantile houses of Brenas opposite House Azaro's officers.", -1,
                "(Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and (Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            foreach (int iId in new[] { 1, 101, 102, 103 })
            {
                AddLink(conv, 0, iId);
                AddLink(conv, iId, 2);
                AddLink(conv, iId, 104);
            }

            // Azaro Opener (Taddeus if free, else Carlos)
            AddLine(conv, 2, TaddeusId, RomusId, "Taddeus_Logistics_Opener",
                "Your Majesty! The General Staff cannot conduct an offensive while our fuel convoys are held up at civilian toll gates and local rail switches in Brenas! Speed is everything in modern mechanized war. We demand unconditional military requisition authority over all rail lines, fuel depots, and granaries across Brenas!", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 104, CarlosId, RomusId, "Carlos_Logistics_Opener",
                "Your Majesty. The General Staff cannot maintain offensive tempo while fuel convoys wait behind civilian freight and local rail switches in Brenas. We require full military requisition authority over the province's rail lines, fuel tanks, and grain depots.", -1,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            // Sazon Rebuttal (Angelica -> Manus -> Leona)
            AddLine(conv, 3, AngelicaId, RomusId, "Angelica_Furious_Rebuttal",
                "Duchess Angelica straightened with icy noble disdain, slamming a jeweled ring against the table. \"Brenas is not an occupied province for Montaklar's generals to pillage! It is the historical breadbasket of Rizia and the homeland of Queen Mother Estela!\"", 4,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true");

            AddLine(conv, 4, AngelicaId, RomusId, "Angelica_Furious_Rebuttal_2",
                "\"Your requisition officers are already impounding trucks, seizing livestock, and threatening our mayors. If you bleed our farms dry to feed your iron tanks, winter starvation and strikes will paralyze our towns before our forces even take Wiktrany!\"", -1);

            AddLine(conv, 5, ManusId, RomusId, "Manus_Passionate_Proposal",
                "Your Majesty, House Sazon does not wish to see our army fail—quite the contrary. Our merchant syndicates, coastal freighters, and provincial granaries have managed Brenas logistics for centuries. Entrust rear supply to our provincial guilds, and every battalion will be fed and fueled without martial extortion.", 6,
                "Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 105, LeonaId, RomusId, "Leona_Sazon_Proposal",
                "Countess Leona Sazon adjusted her sable stole coolly. \"Brenas is not a conquered fief for Montaklar's quartermasters to strip bare, Your Majesty. Our merchant guilds and coastal shipping syndicates can supply the army cleanly through our granaries and ports without provoking bread riots in Sallabes and Mave Nortus.\"", 6,
                "(Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and (Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            foreach (int oId in new[] { 2, 104 })
            {
                AddLink(conv, oId, 3);
                AddLink(conv, oId, 5);
                AddLink(conv, oId, 105);
            }
            AddLink(conv, 4, 5);
            AddLink(conv, 4, 6); // if Manus is gone, Angelica goes straight to line 6

            // Military counter (Lucita if free, else Carlos)
            AddLine(conv, 6, LucitaId, RomusId, "Lucita_Military_Counter",
                "Councilor Azaro leaned forward, her gaze razor-sharp. \"With all due respect to House Sazon, guild bureaucracy moves at the pace of an ox cart. If my armored spearheads stall in the mud outside Wiktrany waiting for merchant manifests, General Valdez will bring down Wehzek heavy artillery and slaughter our men!\"", 7,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 106, CarlosId, RomusId, "Carlos_Military_Counter",
                "General Carlos Azaro tapped his leather portfolio flatly. \"Merchant committees move at the speed of paperwork, Your Majesty. If our forward brigades run dry of diesel and 105mm shells outside Wiktrany, General Valdez will dismantle them piecemeal.\"", 7,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 5, 6);
            AddLink(conv, 5, 106);
            AddLink(conv, 105, 6);
            AddLink(conv, 105, 106);

            // If Angelica spoke, go to Manus (5) when free, else via bridge node (107) directly to Lucita/Carlos
            var e4 = conv.GetDialogueEntry(4);
            e4.outgoingLinks.Clear();
            e4.outgoingLinks.Add(CreateLink(conv.id, 4, 5));
            e4.outgoingLinks.Add(CreateLink(conv.id, 4, 107));
            AddLine(conv, 107, NarratorId, RomusId, "Angelica_ManusGone_Bridge",
                "With Manus no longer in the chamber, the silence after Angelica's outburst lingered heavy over the table.", -1,
                "(Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");
            AddLink(conv, 107, 6);
            AddLink(conv, 107, 106);

            AddLine(conv, 7, ElenaId, RomusId, "Elena_Ledger_Audit",
                "Elena Werner adjusted her spectacles and tapped her pen against her leather ledger. \"For Dast's sake, look at the arithmetic rather than your family heraldry! The Azaro centralized rail plan guarantees rapid delivery of shells, but hauling everything from Montaklar by heavy train burns immense quantities of refined fuel (-1 Energy) and strains the provincial grid.\"", 8);

            AddLine(conv, 8, ElenaId, RomusId, "Elena_Ledger_Audit_2",
                "\"The Sazon syndicate plan utilizes Brenas granaries, regional rail spurs, and coastal barges along the gulf. It conserves our fuel and stiffens provincial defense in Brenas, though compensating the merchant syndicates requires direct subsidies from our royal treasury (-1 Budget).\"", -1);

            AddLine(conv, 9, HugoId, RomusId, "Hugo_Unity_Plea",
                "Hugo Toras shook his head gravely. \"Romus, a kingdom divided against itself will fall before Wiktor Smolak. House Toras, House Azaro, and House Sazon have preserved this realm for centuries. You must bridge this divide.\"", 10,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 109, LaurentoId, RomusId, "Laurento_Unity_Plea",
                "Laurento Esquibel folded his hands gravely. \"Your Majesty, Smolak is watching for any fissure between our noble houses. Choose the supply structure that keeps both the army and the realm intact.\"", 10,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 8, 9);
            AddLink(conv, 8, 109);

            var disputeHub = AddLine(conv, 10, NarratorId, RomusId, "Dispute_Hub_Prompt",
                "The entire council fell silent, waiting for your judgment. The fate of the southern supply corridor rested in your hands.");

            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Choose House Sazon
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Choose House Azaro
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Royal Compromise

            AddChoice(conv, 20, ManusId, "Choice_Sazon_Route",
                "\"House Sazon will manage the supply lines. Rely on Brenas granaries, coastal convoys, and local syndicates.\"",
                "We cannot break the back of Brenas to win a military campaign. House Sazon will oversee rear supply and transit. Utilize your guild networks, coastal freighters, and granaries to keep our army fed and our people secure.", -1,
                "Variable[\"Zille_Logistics_Route\"] = \"Sazon\"; Variable[\"Zille_Logistics_House\"] = \"Sazon\"; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 2; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) - 1;");

            AddLine(conv, 21, ManusId, RomusId, "Ack_Sazon_Manus",
                "\"Thank you, Your Majesty!\" Manus bowed with genuine reverence. \"House Sazon will mobilize our finest grain syndicates and coastal barges. The people of Brenas will know their King protects them.\"", -1,
                "Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 121, LeonaId, RomusId, "Ack_Sazon_Leona",
                "Countess Leona inclined her head with poised gratitude. \"A prudent decree, Your Majesty. Our Brenas syndicates will keep the front provisioned without bleeding the countryside dry.\"", -1,
                "(Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true) and (Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true)");

            AddLine(conv, 22, AngelicaId, RomusId, "Ack_Sazon_Angelica",
                "Duchess Angelica tilted her chin proudly. \"A wise and sovereign decree, Your Majesty. Brenas will stand as a steadfast bastion at your rear, and our western coastal ports will remain open for your fleet.\"", -1,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true");

            AddLine(conv, 23, TaddeusId, RomusId, "Ack_Sazon_Taddeus",
                "Duke Taddeus scowled, tossing his gloves onto the mahogany table with visible disgust. \"I only hope, Your Majesty, that when Valdez's tanks counter-attack, your merchant syndicates can fire wheat bushels instead of armor-piercing shells.\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 24, LucitaId, RomusId, "Ack_Sazon_Lucita",
                "Lucita remained disciplined, though her jaw was clenched tight. \"The General Staff will adapt our operational timetable to the guild schedules, Your Majesty. We will hold Brenas at all costs.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 124, CarlosId, RomusId, "Ack_Sazon_Carlos",
                "General Carlos Azaro exhaled slowly, snapping his ledger shut. \"Very well, Your Majesty. We will adjust our convoy timetables accordingly.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            // Wire Sazon ack chain cleanly
            AddLink(conv, 20, 21);
            AddLink(conv, 20, 22);
            AddLink(conv, 20, 121);
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

            // Azaro choice
            AddChoice(conv, 30, LucitaId, "Choice_Azaro_Route",
                "\"Military necessity is absolute. Grant House Azaro full requisition powers to unleash a mechanized offensive.\"",
                "Military necessity takes absolute priority. Grant the General Staff and House Azaro full requisition authority over the southern rail network and fuel depots. We need maximum attack tempo to crush Valdez before he can entrench.", -1,
                "Variable[\"Zille_Logistics_Route\"] = \"Azaro\"; Variable[\"Zille_Logistics_House\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 2; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) - 2;");

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Azaro_Lucita",
                "Lucita saluted crisply, her eyes shining with decisive pride. \"A command worthy of a warrior king, Your Majesty! Our mechanized spearheads will receive every shell and barrel of fuel without hesitation. We will shatter Valdez's lines!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 131, CarlosId, RomusId, "Ack_Azaro_Carlos",
                "General Carlos Azaro gave a crisp nod. \"Understood, Your Majesty. Our armored spearheads will not lack for fuel or shells.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 32, TaddeusId, RomusId, "Ack_Azaro_Taddeus",
                "\"Montaklar's divisions are at your service, Your Majesty!\" Taddeus declared firmly. \"Our armored columns will drive straight through Wiktrany!\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 33, AngelicaId, RomusId, "Ack_Azaro_Angelica",
                "Duchess Angelica rose from her chair, her eyes burning with icy indignation. \"The Crown may take its fuel, Your Majesty. But remember this day when our farmers curse the name of Montaklar in the winter breadlines.\"", -1,
                "Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true");

            AddLine(conv, 34, ManusId, RomusId, "Ack_Azaro_Manus",
                "Manus bowed his head solemnly. \"We will do our best to keep civil order in Brenas, Your Majesty. May your victory be swift enough to justify the burden our people must bear.\"", -1,
                "Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddLine(conv, 134, LeonaId, RomusId, "Ack_Azaro_Leona",
                "Countess Leona rose stiffly. \"The Crown shall have its trains, Your Majesty. I pray our towns survive the winter.\"", -1,
                "(Variable[\"RiziaDLC.Relations_HouseSazon_AngelicaPardoned\"] ~= true or Variable[\"RiziaDLC.Angelica_Arrested\"] == true or Variable[\"RiziaDLC.Angelica_Executed\"] == true) and (Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            AddLink(conv, 30, 31);
            AddLink(conv, 30, 131);
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
            AddLink(conv, 33, 34);

            // Compromise choice
            AddChoice(conv, 40, ElenaId, "Choice_Compromise_Route",
                "\"Neither house will dictate terms. Elena Werner will lead a Joint Logistical Board balancing both needs.\"",
                "Neither house will dictate terms unilaterally. Minister Elena Werner will chair a joint royal logistical board. Priority rail corridors will be reserved for military munitions, while Sazon guilds will oversee food procurement and local depot distribution.", 41,
                "Variable[\"Zille_Logistics_Route\"] = \"Compromise\"; Variable[\"Zille_Logistics_House\"] = \"Compromise\"; Variable[\"RiziaDLC.Country_HouseAzaro\"] = (Variable[\"RiziaDLC.Country_HouseAzaro\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 1;");

            AddLine(conv, 41, ElenaId, RomusId, "Ack_Compromise_Elena",
                "Elena smiled faintly, adjusting her glasses. \"A thoroughly pragmatic compromise, Your Majesty. It prevents military paralysis while guarding the Crown against corrupt provincial price-gouging. I will assume personal oversight of the board immediately.\"", -1);

            AddLine(conv, 42, HugoId, RomusId, "Ack_Compromise_Hugo",
                "\"Well reasoned, Romus. Unity between our noble houses is the bedrock upon which our dynasty stands. Glovurius axa Rizia!\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 43, LucitaId, RomusId, "Ack_Compromise_Lucita",
                "Lucita nodded with measured professional respect. \"The military accepts this structure, Your Majesty. We will coordinate our convoy schedules directly with Minister Werner's office.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 143, CarlosId, RomusId, "Ack_Compromise_Carlos",
                "General Carlos Azaro inclined his head. \"An orderly compromise, Your Majesty. Our quartermasters will coordinate directly with Minister Werner.\"", -1,
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
        // Runtime Lua conditions for Lucita (married/romance/hostile/arrested),
        // Hugo (free/hostile/absent), Titus (free/absent), and Two-Front War!
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
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Briefing_Atmosphere",
                "Midnight in the War Room of Palas Rezna. Heavy rain beat rhythmically against the stone walls, while inside the air hung thick with coffee, parchment, and gun oil. Across the tactical table lay the relief map of the Zille peninsula, the Strait of Kreleck, and the Gulf of Moridia, brass markers tracking every Wehzek garrison and naval patrol.", -1);

            // Hugo / Grand Vizier opening
            AddLine(conv, 2, HugoId, RomusId, "Hugo_Briefing_Open",
                "Your Majesty... The hour has arrived. Years of diplomatic patience have run dry. In a few hours, the world will awaken to news that Rizia has drawn the sword to reclaim its stolen province.", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and Variable[\"RiziaDLC.Country_HouseToras_Enemy\"] ~= true");

            AddLine(conv, 102, HugoId, RomusId, "Hugo_Briefing_Open_Hostile",
                "Your Majesty. Despite the bitter rift between us, I cannot ignore the duty of my office: in a few hours, Rizia goes to war for Zille. May God shield the realm from the consequences.", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and Variable[\"RiziaDLC.Country_HouseToras_Enemy\"] == true");

            AddLine(conv, 103, AngelicaId, RomusId, "Angelica_Vizier_Briefing_Open",
                "Your Majesty. As Grand Vizier, I have reviewed the final mobilization decrees. In a few hours, Rizia moves to reclaim Zille—and with it, the historic wholeness of Brenas.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true) and Variable[\"RiziaDLC.Council_GrandVizier_Angelica\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true");

            AddLine(conv, 104, SalId, RomusId, "Sal_Vizier_Briefing_Open",
                "Your Majesty. As Grand Vizier, I pray Saint Wruhec blesses this righteous endeavor. Before dawn, our armies move to restore Zille to the anointed Crown.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true) and Variable[\"RiziaDLC.Council_GrandVizier_Angelica\"] ~= true and Variable[\"RiziaDLC.Council_GrandVizier_Sal\"] == true and Variable[\"RiziaDLC.Sal_Arrested\"] ~= true and Variable[\"RiziaDLC.Sal_Executed\"] ~= true");

            AddLine(conv, 105, LaurentoId, RomusId, "Laurento_Briefing_Open_NoHugo",
                "Your Majesty. All ministerial seals are prepared. Within hours, Rizia's armed forces will move to enforce the expiration of the 1927 treaty.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true) and not ((Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true) and Variable[\"RiziaDLC.Council_GrandVizier_Angelica\"] == true and Variable[\"RiziaDLC.Angelica_Arrested\"] ~= true and Variable[\"RiziaDLC.Angelica_Executed\"] ~= true) and not ((Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true) and Variable[\"RiziaDLC.Council_GrandVizier_Angelica\"] ~= true and Variable[\"RiziaDLC.Council_GrandVizier_Sal\"] == true and Variable[\"RiziaDLC.Sal_Arrested\"] ~= true and Variable[\"RiziaDLC.Sal_Executed\"] ~= true)");

            foreach (int hId in new[] { 2, 102, 103, 104, 105 })
            {
                AddLink(conv, 1, hId);
            }

            // War Councilor opening: Lucita (Married / Romance / Hostile / Normal) OR Taddeus / Carlos if Lucita arrested
            AddLine(conv, 3, NarratorId, RomusId, "Lucita_Narration_Married",
                "Lucita stood at the head of the map table, her field marshal's baton resting across the Brenas frontier. When your eyes met, her severe military demeanor softened with quiet warmth before she addressed the assembly.", 4,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Married\"] == true");
            AddLine(conv, 4, LucitaId, RomusId, "Lucita_Open_Married",
                "My King... and my husband. All divisions are deployed at their staging posts. The soldiers have their rations, their ammunition, and the blessing of the sanctuaries. High command awaits your operational doctrine.", -1);

            AddLine(conv, 113, NarratorId, RomusId, "Lucita_Narration_Romance",
                "Lucita looked up from the coastal approaches, her dark eyes flashing with unmistakable warmth before snapping back to disciplined military bearing.", 114,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Married\"] ~= true and (Variable[\"RiziaDLC.Lucita_RomanceHappened\"] == true or (Variable[\"RiziaDLC.Relations_Lucita_Romance\"] or 0) > 0)");
            AddLine(conv, 114, LucitaId, RomusId, "Lucita_Open_Romance",
                "Your Majesty... Romus. The army is prepared. Our officers stand by their radios along the Brenas frontier and at Monqiz naval base. Operational command is yours to dictate.", -1);

            AddLine(conv, 115, LucitaId, RomusId, "Lucita_Open_Hostile",
                "Your Majesty. Whatever grievances stand between the Crown and House Azaro, our officers know their duty. The divisions are in position along the Brenas line; give your orders.", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Married\"] ~= true and Variable[\"RiziaDLC.Lucita_RomanceHappened\"] ~= true and (Variable[\"RiziaDLC.Relations_Lucita_Romance\"] or 0) <= 0 and (Variable[\"RiziaDLC.Country_HouseAzaro_Enemy\"] == true or Variable[\"RiziaDLC.Turn06_Council_LucitaOffended\"] == true)");

            AddLine(conv, 116, LucitaId, RomusId, "Lucita_Open_Standard",
                "Your Majesty. All divisions of the Royal Army and provincial levies have assumed combat positions along the demarcation line, and the Royal Navy stands fueled at Monqiz. We await your final operational authorization.", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Married\"] ~= true and Variable[\"RiziaDLC.Lucita_RomanceHappened\"] ~= true and (Variable[\"RiziaDLC.Relations_Lucita_Romance\"] or 0) <= 0 and Variable[\"RiziaDLC.Country_HouseAzaro_Enemy\"] ~= true and Variable[\"RiziaDLC.Turn06_Council_LucitaOffended\"] ~= true");

            AddLine(conv, 117, TaddeusId, RomusId, "Taddeus_Open_LucitaGone",
                "Duke Taddeus Azaro stood stiffly beside the relief map, his jaw tight with lingering bitterness over his daughter's fate. \"Your Majesty. The divisions are assembled along the Brenas line and the fleet is ready at Monqiz. Specify the doctrine.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 118, CarlosId, RomusId, "Carlos_Open_LucitaGone",
                "General Carlos Azaro stepped forward in Lucita's stead, his expression unreadable and strictly professional. \"Your Majesty. The General Staff has completed deployment along the Brenas border and at Monqiz. We await your operational orders.\"", -1,
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

            // Laurento note (+ Two-Front War warning if Pales war is active!)
            AddLine(conv, 5, LaurentoId, RomusId, "Laurento_Briefing_Note",
                "Our diplomatic memorandums have been pre-scheduled for dispatch to the Alliance of Nations in Konstantium, Kyrute the moment our first units advance. We are framing this strictly as the lawful expiration of the 1927 lease and the restoration of Rizian sovereignty.", -1,
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true)");

            AddLine(conv, 1051, LaurentoId, RomusId, "Laurento_Briefing_TwoFront",
                "I must warn you gravely, Your Majesty: with our forces already engaged against Pales, opening a second war against Wehlen will alarm both superpowers and stretch our diplomatic shield in Kyrute to the breaking point.", -1,
                "(Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true)");

            foreach (int prev in new[] { 4, 114, 115, 116, 117, 118 })
            {
                AddLink(conv, prev, 5);
                AddLink(conv, prev, 1051);
            }

            // Titus security note
            AddLine(conv, 6, TitusId, RomusId, "Titus_Briefing_Note",
                "The Golden Guard has deployed vanguard security teams along the advance routes, Your Majesty. Our scouts confirm that General Valdez's garrison in Zille City has not yet detected our mechanized assembly.", 10,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 106, CarlosId, RomusId, "Carlos_Security_NoTitus",
                "Forward military intelligence confirms that General Valdez's coastal and border outposts have not yet detected our main concentration, Your Majesty.", 10,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            foreach (int prev in new[] { 5, 1051 })
            {
                AddLink(conv, prev, 6);
                AddLink(conv, prev, 106);
            }

            var commandHub = AddLine(conv, 10, NarratorId, RomusId, "Command_Hub_Prompt",
                "Across the mahogany table, the operational map awaited your royal seal. You could personally take command at the War Table—directing Operation Golden Sword into the Zille peninsula or Operation Golden Ark across the Gulf of Moridia into mainland Wehlen—or delegate field execution to the General Staff under one of four doctrines.");

            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Romus: Operation Golden Sword
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Romus: Operation Golden Ark
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Staff Officers Command
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 50)); // Postpone

            AddChoice(conv, 20, LucitaId, "Choice_Golden_Sword",
                "\"I will take personal command at the War Table: Authorize Operation Golden Sword Phase I.\"",
                "I will command this campaign myself. Authorize Operation Golden Sword Phase I. We will launch a massive armored spearhead across the Brenas-Zille frontier through Wiktrany, smashing Valdez's center and driving directly onto Zille City and Munat.", -1,
                "Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenSword\"; Variable[\"Zille_War_Active\"] = true;");

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Golden_Sword_Lucita",
                "\"A glorious doctrine, Your Majesty!\" Lucita's eyes burned with martial pride. \"Our heavy tanks and mechanized infantry will punch straight through their fortified junctions. The War Table is illuminated and awaiting your strategic deployment for Phase I!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Golden_Sword_Carlos",
                "General Carlos Azaro saluted crisply. \"The armored spearheads are fueled and poised on the Brenas frontier. The War Table awaits your deployment for Phase I, Your Majesty.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 22, HugoId, RomusId, "Ack_Golden_Sword_Hugo",
                "\"May Saint Wruhec watch over our soldiers, Romus. Lead our kingdom to triumph. Glovurius axa Rizia!\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 122, LaurentoId, RomusId, "Ack_Golden_Sword_NoHugo",
                "\"Godspeed to our armies, Your Majesty. Our envoys stand ready to announce Rizia's rightful reclamation.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);
            AddLink(conv, 21, 22);
            AddLink(conv, 21, 122);
            AddLink(conv, 121, 22);
            AddLink(conv, 121, 122);

            AddChoice(conv, 30, LucitaId, "Choice_Golden_Ark",
                "\"I will take personal command at the War Table: Authorize Operation Golden Ark Phase I.\"",
                "I will lead our forces personally. Authorize Operation Golden Ark Phase I. While our border divisions pin down Zille's southern frontier, the Royal Navy will cross the Gulf of Moridia and Strait of Kreleck to land our marines directly on mainland Wehlen—striking Kratsna, Rotsla, and Grodzizg to sever Zille from behind!", -1,
                "Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true;");

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Golden_Ark_Lucita",
                "\"An audacious maritime envelopment!\" Lucita smiled fiercely. \"Smolak expects us to bleed against his trenches in Zille—landing across the sea in mainland Wehlen will sever his convoys at the source. The War Table is configured and waiting for Phase I!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 131, CarlosId, RomusId, "Ack_Golden_Ark_Carlos",
                "General Carlos Azaro studied the sea lanes approvingly. \"A bold naval stroke across the Gulf of Moridia, Your Majesty. Our landing craft and border screening brigades await your deployment at the War Table.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 32, LaurentoId, RomusId, "Ack_Golden_Ark_Laurento",
                "\"Be warned, Your Majesty: striking mainland Wehlen directly across the sea will provoke Chancellor Hegel and Valgsland fiercely, so speed at sea will be everything. Godspeed to our fleet.\"", -1);

            AddLink(conv, 30, 31);
            AddLink(conv, 30, 131);
            AddLink(conv, 31, 32);
            AddLink(conv, 131, 32);

            AddChoice(conv, 40, NarratorId, "Choice_Staff_Command",
                "\"The General Staff will direct the campaign. Present the four staff doctrines for execution.\"",
                "The General Staff will direct the field execution of this war. Present your four strategic doctrines for royal selection.", 41,
                "Variable[\"Zille_War_PlanType\"] = \"Staff\";");

            var staffHub = AddLine(conv, 41, NarratorId, RomusId, "Staff_Doctrine_Presentation",
                "The General Staff laid out four strategic doctrines across the map:\n\n  Plan Hawk: Heavy aerial strikes and artillery barrages shatter Valdez's command network before infantry advances.\n  Plan Sword: An aggressive armored charge led by House Azaro heavy divisions pushing through Wiktrany.\n  Plan Ark: A methodical naval blockade and amphibious encirclement across the Gulf of Moridia, starving Zille's sea supply lines.\n  Plan Spear: A covert night decapitation strike by elite commandos against Valdez's headquarters.\n\nWhich staff doctrine do you authorize?");

            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 42)); // Plan Hawk
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 43)); // Plan Sword
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 44)); // Plan Ark
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 45)); // Plan Spear

            AddChoice(conv, 42, LucitaId, "Authorize_Staff_Hawk",
                "\"Authorize Plan Hawk: Shatter their forward redoubts with air and artillery power.\"",
                "I authorize Plan Hawk. Bring down our bomber wings and heavy artillery. Flatten their defensive works before our ground units advance.", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Hawk\"; Variable[\"Zille_War_Active\"] = true;");

            AddChoice(conv, 43, LucitaId, "Authorize_Staff_Sword",
                "\"Authorize Plan Sword: Unleash our armored divisions in a central breakthrough.\"",
                "I authorize Plan Sword. Mass our armor and let the Azaro divisions spearhead the breakthrough into Wiktrany.", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Sword\"; Variable[\"Zille_War_Active\"] = true;");

            AddChoice(conv, 44, LucitaId, "Authorize_Staff_Ark",
                "\"Authorize Plan Ark: Execute a disciplined maritime blockade and sea encirclement.\"",
                "I authorize Plan Ark. The Royal Navy will seal the Gulf of Moridia and Strait of Kreleck, cutting off Valdez's sea supply lines.", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Ark\"; Variable[\"Zille_War_Active\"] = true;");

            AddChoice(conv, 45, TitusId, "Authorize_Staff_Spear",
                "\"Authorize Plan Spear: Deploy elite commandos and guardsmen to decapitate Valdez's command.\"",
                "I authorize Plan Spear. Send our finest operatives into Zille tonight to sever Valdez's communications and capture his staff before the main assault begins.", -1,
                "Variable[\"Zille_War_StaffPlan\"] = \"Spear\"; Variable[\"Zille_War_Active\"] = true;");

            AddLine(conv, 46, LucitaId, RomusId, "Ack_Staff_Lucita",
                "\"The orders are dispatched, Your Majesty! The General Staff has initiated the offensive. Our officers will report battle progress as the front develops!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 146, CarlosId, RomusId, "Ack_Staff_Carlos",
                "\"The orders are dispatched, Your Majesty. The General Staff has launched the offensive and will report front-line progress.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            foreach (int chId in new[] { 42, 43, 44 })
            {
                AddLink(conv, chId, 46);
                AddLink(conv, chId, 146);
            }

            AddLine(conv, 47, TitusId, RomusId, "Ack_Staff_Titus",
                "\"My guardsmen are already moving under cover of darkness, Your Majesty,\" Titus said quietly, his hand resting firmly over his service sidearm. \"Smolak's officers will wake up in chains.\"", -1,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 147, CarlosId, RomusId, "Ack_Staff_Spear_NoTitus",
                "\"Our special commando detachments are already slipping across the frontier under darkness, Your Majesty. Valdez's command post will be blind before dawn.\"", -1,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            AddLink(conv, 45, 47);
            AddLink(conv, 45, 147);

            AddChoice(conv, 50, HugoId, "Choice_Postpone_War",
                "\"Hold the offensive for now. Keep our divisions at maximum readiness along the border.\"",
                "Hold the offensive for now. Keep our divisions at maximum combat readiness along the frontier, but do not cross until I give the royal command.", -1,
                "Variable[\"Zille_War_Postpone\"] = true;");

            AddLine(conv, 51, HugoId, RomusId, "Ack_Postpone_Hugo",
                "\"A prudent and measured decision, Your Majesty. The General Staff will maintain full combat readiness along the frontier until you decide the hour is right.\"", -1,
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
        // Fixed: No rivers, no desert, Mayor via NarratorId (not Carlos ID 88!),
        // Conditional Foreign Aid & Two-Front War & Lucita/Taddeus arrest variants.
        // =========================================================================
        public static void RegisterMaveNortusHQ(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_MaveNortusHQ") != null && db.GetConversation("Zille/MaveNortusHQ") != null)
                return;

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

            AddLine(conv, 1, NarratorId, RomusId, "MaveNortus_Arrival",
                "Your armored convoy rumbled through the muddy, rain-slicked streets of Mave Nortus. In the distance across the northern hills, the rhythmic thud of heavy artillery rolled like continuous thunder, rattling the windowpanes of the stone Brenas houses. Sandbag bunkers lined the crossroads, and wounded soldiers resting on canvas stretchers outside the town sanctuary looked up with weary reverence as the royal standard fluttered past.", -1);

            AddLine(conv, 2, NarratorId, RomusId, "MaveNortus_Office_Entry",
                "Inside the town hall, municipal tax ledgers had been shoved aside to make room for battlefield telegraphs and grease-pencil maps spread across the Mayor's oak desk. Duke Taddeus Azaro stood with his uniform jacket unbuttoned, pointing a scarred finger at the coastal highways, while Councilor Lucita Azaro reviewed incoming courier dispatches.", 3,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true and Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 102, NarratorId, RomusId, "MaveNortus_Office_Carlos",
                "Inside the town hall, municipal tax ledgers had been shoved aside for battlefield telegraphs and grease-pencil maps spread across the Mayor's oak desk. General Carlos Azaro leaned over the coastal highways, conferring briskly with staff officers.", 103,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true) or (Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            AddLine(conv, 3, TaddeusId, RomusId, "Taddeus_HQ_Greeting",
                "Your Majesty! It is an honor to have our King at the front lines. The men took heart the moment the royal motorcade entered Mave Nortus.", 4);

            AddLine(conv, 103, CarlosId, RomusId, "Carlos_HQ_Greeting",
                "Your Majesty. Word of your arrival at Mave Nortus has already lifted the spirits of the forward brigades.", -1);

            AddLine(conv, 4, LucitaId, RomusId, "Lucita_HQ_Debrief_1",
                "Phase I of our operation has concluded, Your Majesty. General Valdez fought fiercely along the fortified border earthworks and coastal approaches, yet our forward brigades have secured crucial staging positions.", 5);

            AddLine(conv, 5, LucitaId, RomusId, "Lucita_HQ_Debrief_2",
                "Still, the campaign is only half won. Valdez has consolidated his surviving armor and veterans into a hardened defensive ring around Zille City, the northern coast, and the sea approaches across the Gulf of Moridia. We must launch Phase II to break his spine.", 6);

            AddLine(conv, 104, TaddeusId, RomusId, "Taddeus_HQ_Debrief_NoLucita",
                "Phase I is complete, Your Majesty. Valdez contested every kilometer of the coastal highways, and though our forces secured key positions, he has dug his remaining armor into an inner ring around Zille City and the Gulf ports. Phase II must decide it.", 6,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 105, CarlosId, RomusId, "Carlos_HQ_Debrief_BothGone",
                "Phase I is complete, Your Majesty. Valdez's surviving brigades have fallen back into fortified rings around Zille City and his northern supply ports. We need your Phase II directives to finish the campaign.", 6,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            AddLink(conv, 103, 4);
            AddLink(conv, 103, 104);
            AddLink(conv, 103, 105);
            SetEntryCondition(conv.GetDialogueEntry(4), "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");
            SetEntryCondition(conv.GetDialogueEntry(104), "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");
            SetEntryCondition(conv.GetDialogueEntry(105), "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true) and (Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            AddLine(conv, 6, NarratorId, RomusId, "Mayor_HQ_Report",
                "The Mayor of Mave Nortus stepped forward nervously, wiping rain and sweat from his brow. \"Your Majesty, over four thousand Rizian refugees have fled south from Zille in the last forty-eight hours. Smolak's retreating officers torched grain silos behind them. Our town is straining to house and feed them, and medical supplies are running thin.\"", 10);

            var hqHub = AddLine(conv, 10, NarratorId, RomusId, "HQ_Hub_Prompt",
                "Distant artillery rumbled once more, sending a fine dust of plaster drifting down from the ceiling. You studied the situational map, ready to question your commanders.");

            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11)); // Foreign Aid Audit
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12)); // Casualties & Morale
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 13)); // Refugee Relief Order
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Launch Phase II Orders

            AddChoice(conv, 11, NarratorId, "Inquire_ForeignAid",
                "\"What reports do we have on foreign assistance and allied support?\"",
                "What reports do we have regarding foreign assistance? Has our international diplomacy yielded tangible aid on the battlefield?", -1);

            // 8 mutually exclusive Foreign Aid outcomes
            AddLine(conv, 140, NarratorId, RomusId, "Answer_ForeignAid_None",
                "Your staff officers exchanged grim glances. \"No foreign power has committed direct aid to our campaign, Your Majesty. Rizia stands entirely on its own steel, treasury, and courage.\"", 10,
                "Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] ~= true");
            AddLine(conv, 141, NarratorId, RomusId, "Answer_ForeignAid_Lespia",
                "\"High-resolution aerial reconnaissance supplied by Lespia has pinpointed Valdez's camouflaged artillery bunkers behind the Wiktrany lowlands,\" your intelligence officer reported. \"Our gunners are already using the coordinates.\"", 10,
                "Variable[\"Zille_Lespia_Intel\"] == true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] ~= true");
            AddLine(conv, 142, NarratorId, RomusId, "Answer_ForeignAid_Rumburg",
                "\"Three freight trains carrying 152mm heavy artillery shells from Rumburg arrived in the Brenas depot this morning,\" your quartermaster reported. \"Our batteries are well stocked for Phase II.\"", 10,
                "Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] == true and Variable[\"Zille_DerdiaHybridActive\"] ~= true");
            AddLine(conv, 143, NarratorId, RomusId, "Answer_ForeignAid_Derdia",
                "\"In the east, Derdian irregulars have raided Wehlen's mainland border depots,\" your intelligence officer reported. \"Valdez has been forced to divert troops away from our front.\"", 10,
                "Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] == true");
            AddLine(conv, 144, NarratorId, RomusId, "Answer_ForeignAid_LespiaRumburg",
                "\"Lespian aerial reconnaissance has mapped Valdez's bunkers behind the Wiktrany lowlands, and three trainloads of heavy 152mm shells from Rumburg arrived in the Brenas depot this morning.\"", 10,
                "Variable[\"Zille_Lespia_Intel\"] == true and Variable[\"Zille_Rumburg_Munitions\"] == true and Variable[\"Zille_DerdiaHybridActive\"] ~= true");
            AddLine(conv, 145, NarratorId, RomusId, "Answer_ForeignAid_LespiaDerdia",
                "\"Lespian reconnaissance flights have exposed Valdez's hidden batteries, while Derdian irregular raids on Wehlen's southern border have forced him to pull reserves off our front.\"", 10,
                "Variable[\"Zille_Lespia_Intel\"] == true and Variable[\"Zille_Rumburg_Munitions\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] == true");
            AddLine(conv, 146, NarratorId, RomusId, "Answer_ForeignAid_RumburgDerdia",
                "\"Three freight trains of Rumburgian 152mm shells arrived in Brenas this morning, and Derdian irregulars raiding Wehlen's mainland frontier have pinned down an entire enemy regiment.\"", 10,
                "Variable[\"Zille_Lespia_Intel\"] ~= true and Variable[\"Zille_Rumburg_Munitions\"] == true and Variable[\"Zille_DerdiaHybridActive\"] == true");
            AddLine(conv, 147, NarratorId, RomusId, "Answer_ForeignAid_All",
                "\"Very tangible, Your Majesty: Lespian reconnaissance photos have revealed Valdez's camouflaged bunkers, three trainloads of Rumburgian 152mm shells arrived in Brenas this morning, and Derdian irregulars raiding Wehlen's border depots have pinned down enemy reserves.\"", 10,
                "Variable[\"Zille_Lespia_Intel\"] == true and Variable[\"Zille_Rumburg_Munitions\"] == true and Variable[\"Zille_DerdiaHybridActive\"] == true");

            for (int aidId = 140; aidId <= 147; aidId++)
            {
                AddLink(conv, 11, aidId);
            }

            AddChoice(conv, 12, TaddeusId, "Inquire_Casualties",
                "\"How heavy are our casualties, and how is the fighting spirit of our soldiers?\"",
                "Give me a frank assessment of our losses. How are our men holding up against Wehlen's counter-attacks?", -1);

            AddLine(conv, 15, TaddeusId, RomusId, "Answer_Casualties",
                "We took shrapnel losses storming the forward trenches and coastal approaches, Your Majesty, but our field hospitals have performed miracles. Morale is soaring—the men know they are liberating Rizian soil, not bleeding for some distant foreign border. They are eager to finish the job.", 10,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true and (Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true)");

            AddLine(conv, 115, TaddeusId, RomusId, "Answer_Casualties_TwoFront",
                "Our field hospitals are strained to breaking, Your Majesty. With divisions tied down against Pales on the eastern frontier while we assault Wehlen here, ammunition and replacements are stretched thin. The men fight bravely, but we cannot afford a prolonged stalemate.", 10,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true and (Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true)");

            AddLine(conv, 116, CarlosId, RomusId, "Answer_Casualties_Carlos",
                "Losses were sharp along the coastal fortifications, Your Majesty, yet morale remains resolute. Our soldiers know they are fighting to reclaim Rizian soil and will see Phase II through.", 10,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            AddLink(conv, 12, 15);
            AddLink(conv, 12, 115);
            AddLink(conv, 12, 116);

            AddChoice(conv, 13, NarratorId, "Order_Refugee_Aid",
                "\"Mayor, the Crown will fund emergency medical aid and provisions for every refugee.\"",
                "Mayor, the Crown will immediately release emergency funds and grain from the royal reserves for every refugee arriving in Mave Nortus. No Rizian fleeing Smolak will be neglected.", 16,
                "Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"Zille_Refugee_Aid_Granted\"] = true;",
                "Variable[\"Zille_Refugee_Aid_Granted\"] ~= true");

            AddLine(conv, 16, NarratorId, RomusId, "Ack_Refugee_Aid",
                "Tears welled in the Mayor of Mave Nortus's eyes as he pressed his hand over his heart. \"God bless Your Majesty! The people of Brenas and Zille will never forget your royal mercy!\"", 10);

            AddChoice(conv, 20, NarratorId, "Order_Phase2_Launch",
                "\"The time has come. Issue the battle orders for Phase II: Break their inner ring and liberate Zille!\"",
                "The time has come. Valdez will find no respite. Issue the battle orders for Phase II immediately. Concentrate our artillery, deploy our fresh reserves, and break their final line!", -1,
                "Variable[\"Zille_War_Phase\"] = 2;");

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Phase2_Lucita",
                "Lucita smiled with fierce, cold resolution, snapping her field baton onto Zille City. \"The orders are dispatched, Your Majesty! Our armor will lead the assault at dawn. We will deliver Zille back into your royal hands!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Phase2_Carlos",
                "General Carlos Azaro saluted sharply. \"The Phase II directives are on the wire, Your Majesty. All brigades move at dawn.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLine(conv, 22, TaddeusId, RomusId, "Ack_Phase2_Taddeus",
                "Taddeus drew his saber and held it aloft in solemn tribute. \"For King and Kingdom! Glovurius axa Rizia! Forward to victory!\"", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);
            AddLink(conv, 21, 22);
            AddLink(conv, 121, 22);

            AddConversationWithAlias(db, conv, "Zille/MaveNortusHQ", "Turn_Zille_MaveNortusHQ");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Mave Nortus Field HQ (ID 9994) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 5: Turn_Zille_WarBalconySpeech (ID 9989) - WAR PROCLAMATION SPEECH
        // Fixed: 1927 agreement, Hugo absent variant, Lucita absent awareness.
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
                "The grand double doors of the Palas Rezna balcony swung open to the roar of over forty thousand citizens packed shoulder to shoulder in the Royal Plaza. Banners of House Toras, Azaro, and Sazon fluttered in the sea breeze. Below, brass microphones were wired to radio broadcasting trucks transmitting your voice to every household across Rizia.", -1);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Balcony_Whisper",
                "Hugo leaned in, his voice barely audible beneath the roar of the crowd. \"The whole kingdom listens, Romus. Give them words worthy of a king.\"", 3,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Balcony_Whisper",
                "Laurento inclined his head beside you as the roar of the crowd swelled. \"Both the realm and the ambassadors in Kyrute are listening, Your Majesty.\"", 3,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var speechHub = AddLine(conv, 3, NarratorId, RomusId, "Speech_Doctrine_Prompt",
                "You stepped forward to the stone balustrade, raising your sovereign hand. A profound hush fell over the ocean of citizens.");

            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Revanchist Might
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Liberating the Oppressed
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Sovereign Legalism

            AddChoice(conv, 10, HugoId, "Speech_Revanchist",
                "\"Sons and daughters of Rizia! We march to reclaim what was stolen and restore the honor of our ancestors!\"",
                "Sons and daughters of Rizia! For over twenty-five years, our kingdom has borne the sting of separation in silence. But House Toras does not bow to tyrants! Today, the Royal Army marches to reclaim our sovereign soil and restore the royal dignity of our kingdom!", 11,
                "Variable[\"Zille_Speech_Tone\"] = \"Revanchist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            AddLine(conv, 11, NarratorId, RomusId, "Speech_Revanchist_Reaction",
                "A thunderous roar erupted from the crowd, bayonets flashing in the sun as royal guards raised their rifles in salute. Patriotic cheers echoed down the avenues of Porte Drazon.", -1);

            AddChoice(conv, 20, HugoId, "Speech_Liberation",
                "\"We come not as conquerors, but as liberators to free our brothers and sisters from Smolak's tyranny!\"",
                "People of Rizia! We march not out of hatred, but out of sacred love for our brothers and sisters in Zille who have endured Smolak's secret police and broken promises. We go to bring them home to their true kingdom!", 21,
                "Variable[\"Zille_Speech_Tone\"] = \"Liberation\"; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            AddLine(conv, 21, NarratorId, RomusId, "Speech_Liberation_Reaction",
                "Tears flowed freely among the elder citizens in the crowd, and chants of 'Long live King Romus!' resonated throughout the ancient plaza.", -1);

            AddChoice(conv, 30, HugoId, "Speech_Legalist",
                "\"The 1927 agreement has expired. We uphold international law where Wehlen has trampled it!\"",
                "Citizens of Rizia and observers across Merkopa. Rizia is a realm of honor and constitutional order. The 1927 lease has expired. In reclaiming Zille, we enforce the sacred rule of law that Wiktor Smolak has trampled underfoot!", 31,
                "Variable[\"Zille_Speech_Tone\"] = \"Legalist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            AddLine(conv, 31, NarratorId, RomusId, "Speech_Legalist_Reaction",
                "Foreign correspondents frantically scribbled notes, while the crowd applauded with deep, dignified respect for the Crown's measured authority.", -1);

            AddConversationWithAlias(db, conv, "Zille/WarBalconySpeech", "Turn_Zille_WarBalconySpeech");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Balcony Proclamation (ID 9989) into masterDatabase!");
        }
    }
}
