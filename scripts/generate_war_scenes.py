import os

WAR_SCENES_CS = '''using System;
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
        // Modeled on: 358_SnO_PalesPostIncidentMeeting, 289_EnT_CouncilBriefing, 357_SnO_WarEruptionBriefing
        // The King convenes his inner council to plan the military reclamation of Zille.
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

            // Entry 0: START
            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            // Entry 1: Setting & Atmosphere
            AddLine(conv, 1, NarratorId, RomusId, "Planning_Atmosphere",
                "Outside the council chamber windows, gray rain lashed against the stone spires of Palas Rezna. An emergency war map of the southern border lay unfurled across the mahogany table, weighed down by heavy bronze candleholders. The ministers took their seats in somber silence, the gravity of the hour hanging heavy in the air.", 2);

            // Entry 2: Opening statement
            AddLine(conv, 2, HugoId, RomusId, "Hugo_Planning_Open",
                "Your Majesty... We have convened the Crown Council under extraordinary circumstances. Smolak's continued defiance and the escalating tensions in Zille have brought our kingdom to a decisive crossroads.", 3);

            // Entry 3: Romus choice of stance
            var stanceHub = AddLine(conv, 3, RomusId, HugoId, "Romus_Planning_Posture_Prompt",
                "I looked at the gathered faces of my council, each waiting for their King to establish the direction of the realm.");

            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive force
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Pragmatic caution
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Sovereign legalism

            AddChoice(conv, 10, HugoId, "Posture_Force",
                "\"Thirty years of national humiliation ends here. It is time the Crown plans the military reclamation of Zille.\"",
                "Thirty years of national humiliation ends here. Smolak will not return our territory through words. It is time the Crown plans the military reclamation of Zille by force of arms.", 20,
                "Variable[\"Zille_Planning_Stance\"] = \"Force\";");

            AddChoice(conv, 11, HugoId, "Posture_Pragmatic",
                "\"We must weigh our capabilities soberly. Can the Kingdom truly bear the burden of a war against Wehlen?\"",
                "We must weigh our capabilities soberly. Can our treasury, our military, and our people truly bear the burden of a war against Wehlen? I need honest counsel, not bravado.", 20,
                "Variable[\"Zille_Planning_Stance\"] = \"Cautious\";");

            AddChoice(conv, 12, HugoId, "Posture_Legal",
                "\"The 1929 lease has expired. Wehlen's presence is an unlawful occupation. We will uphold our sovereign right.\"",
                "The 1929 lease has expired. Wehlen's continued presence is an unlawful foreign occupation. If Smolak refuses to withdraw, we have every legal and sovereign right to expel his garrisons.", 20,
                "Variable[\"Zille_Planning_Stance\"] = \"Legal\";");

            // Entry 20: Hugo's dynastic warning
            AddLine(conv, 20, HugoId, RomusId, "Hugo_Dynastic_Warning",
                "Romus... As your uncle and your Grand Vizier, I must urge profound care. Your father, King Valero, surrendered Zille to quell internal turmoil when the throne itself was shaking. If we march across that river and stumble, the divine authority of House Toras will suffer a blow from which it may never recover.", 21);

            // Entry 21: Lucita counters with military assessment
            AddLine(conv, 21, LucitaId, RomusId, "Lucita_Military_Appraisal_1",
                "With respect to the Grand Vizier, inaction is far more dangerous, Your Majesty. General Valdez has stationed four brigades in Zille-an armored detachment at the central rail hub of Wiktrany, two dug-in infantry brigades around Zille City itself, and a garrison securing the deepwater port of Munat.", 22);

            AddLine(conv, 22, LucitaId, RomusId, "Lucita_Military_Appraisal_2",
                "Valdez's men are conscripts, poorly provisioned and demoralized by Smolak's erratic commands. The Azaro divisions and the Royal Army possess superior mechanized armor and professional training. If we strike with decisive speed before Valdez can complete his river redoubts, his outer defensive perimeter will collapse like dry timber.", 23);

            // Entry 23: Elena Werner raises financial realities
            AddLine(conv, 23, ElenaId, RomusId, "Elena_Economic_Reality",
                "Courage does not buy diesel, Councilor Azaro. Your Majesty, our royal treasury cannot afford wishful thinking. A mobile offensive consumes petroleum and replacement munitions at an exorbitant burn rate. If the operation drags into a protracted winter siege, we face staggering deficits and domestic inflation.", 24);

            // Entry 24: Laurento Esquibel on international diplomacy
            AddLine(conv, 24, LaurentoId, RomusId, "Laurento_International_Horizon",
                "The diplomatic battleground is equally hazardous, Your Majesty. Chancellor Hegel of Valgsland and United Contana will condemn our offensive as monarchist aggression. However, because the 1929 lease has unambiguously lapsed, President Alvarez of Lespia and the ATO powers will hesitate to intervene against us if we present the campaign as a swift, localized restoration of sovereign order.", 25);

            // Entry 25: Titus on internal security
            AddLine(conv, 25, TitusId, RomusId, "Titus_Security_Estela",
                "Internal security must not be overlooked, Your Majesty. Su Omina and ATA networks inside Zille are ready to disrupt Wehzek communications. Furthermore, the Golden Guard has prepared elite units to secure Queen Mother Estela's ancestral estate the moment our spearheads cross the border.", 30);

            // Inquiry Hub (Entry 30)
            var inquiryHub = AddLine(conv, 30, NarratorId, RomusId, "Planning_Inquiry_Hub",
                "The room grew quiet as the advisors awaited your direction. Several strategic questions demanded clarification before a mobilization decree could be issued.");

            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 31)); // Question Lucita
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 32)); // Question Elena
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 33)); // Question Laurento
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 34)); // Question Titus
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Conclude planning

            AddChoice(conv, 31, LucitaId, "Inquire_Lucita",
                "\"Lucita, what terrain obstacles must our armored divisions overcome in Zille?\"",
                "Lucita, detail the terrain obstacles our mechanized units must overcome. Where will Valdez make his stand?", 35);

            AddLine(conv, 35, LucitaId, RomusId, "Answer_Lucita",
                "The central approach is bisected by the Brenas-Zille river valley and marshlands surrounding Wiktrany. If we force the central river crossings, we sever Valdez's lateral communications. But if heavy rains flood the lowlands, our tanks will need solid logistics from Brenas to keep moving.", 30);

            AddChoice(conv, 32, ElenaId, "Inquire_Elena",
                "\"Elena, what financial reserves can we mobilize without bankrupting social programs?\"",
                "Elena, what financial reserves can we tap without crippling municipal budgets and domestic welfare?", 36);

            AddLine(conv, 36, ElenaId, RomusId, "Answer_Elena",
                "If we issue royal war bonds and secure foreign energy credits, we can absorb the initial shocks. But the logistics framework is paramount-supplying the army locally out of Brenas granaries will conserve gold, whereas shipping everything by rail from Montaklar will burn through our strategic oil reserves.", 30);

            AddChoice(conv, 33, LaurentoId, "Inquire_Laurento",
                "\"Laurento, can we secure a veto or friendly neutrality in the Alliance of Nations?\"",
                "Laurento, can we secure a veto or friendly neutrality from the major powers in the Alliance of Nations?", 37);

            AddLine(conv, 37, LaurentoId, RomusId, "Answer_Laurento",
                "Queen Beatrice of Rumburg will stand firmly with us in the AN, provided we maintain GRACE solidarity. President Alvarez can be persuaded through economic incentives to keep Lespia's airspace and radar active for our benefit. Smolak will find himself isolated if we strike decisively.", 30);

            AddChoice(conv, 34, TitusId, "Inquire_Titus",
                "\"Titus, how confident are you in the Golden Guard's protection of Queen Estela's home?\"",
                "Titus, how confident are you that the Golden Guard can shield Queen Estela's estate and protect civilian loyalists?", 38);

            AddLine(conv, 38, TitusId, RomusId, "Answer_Titus",
                "Completely confident, Your Majesty. My finest detachment is briefed and ready. We will parachute or ride at the very vanguard of the advance. No harm will come to the Queen Mother's heritage.", 30);

            // Conclude Planning (Entry 40)
            AddChoice(conv, 40, HugoId, "Conclude_Planning",
                "\"The decision is made. Prepare the kingdom for war. Convene the Logistics Summit in Brenas.\"",
                "The decision is made. The Crown resolves on the military reclamation of Zille. Lucita, draft the preliminary deployment orders. Hugo, convene the provincial lords and military command in Brenas for the Logistics Summit. We will resolve our supply lines once and for all.", 41,
                "Variable[\"Zille_War_Planning_Done\"] = true; Variable[\"Zille_War_Sentiment\"] = 3;");

            AddLine(conv, 41, HugoId, RomusId, "Hugo_Planning_Close",
                "\"As your sovereign will decrees, Your Majesty. May Saint Wruhec guide our banners and preserve our realm.\"", 42);

            AddLine(conv, 42, LucitaId, RomusId, "Lucita_Planning_Close",
                "Lucita snapped to attention and saluted crisply. \"The General Staff will initiate immediate preparations. The road to Zille begins now, Your Majesty.\"", -1);

            AddConversationWithAlias(db, conv, "Zille/WarPlanning", "Turn_Zille_WarPlanning");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Planning Session (ID 9987) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 2: Turn_Zille_WarLogisticsDispute (ID 9990) - LOGISTICS DISPUTE
        // Modeled on: 551_REFORM_TALKS_Conversation, 407_A_Reform_Manus, 315_P_EstelaUpdate
        // Grand noble summit: House Azaro vs House Sazon.
        // Duchess Angelica Sazon, Manus Sazon, Duke Taddeus Azaro, Lucita Azaro, Elena Werner, Hugo Toras, Titus Gordion.
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
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Logistics_Intro_1",
                "The atmosphere inside the State Dining Hall of Palas Rezna was crackling with noble animosity. Servants had cleared the banquet tables to make way for logistical ledgers, railway maps, and provincial supply manifests. On one side of the long table sat Duke Taddeus Azaro and War Councilor Lucita Azaro in polished uniform; on the other sat Duchess Angelica Sazon and Manus Sazon in dark Brenas velvet.", 2);

            AddLine(conv, 2, TaddeusId, RomusId, "Taddeus_Logistics_Opener",
                "Your Majesty! The General Staff cannot conduct an offensive while our fuel convoys are held up at civilian toll gates and local rail switches in Brenas! Speed is everything in modern mechanized war. We demand unconditional military requisition authority over all rail lines, fuel storage tanks, and granaries across Brenas!", 3);

            AddLine(conv, 3, AngelicaId, RomusId, "Angelica_Furious_Rebuttal",
                "Duchess Angelica straightened with icy noble disdain, slamming a jeweled ring against the table. \\\"Brenas is not an occupied province for Montaklar's generals to pillage, Duke Azaro! It is the historical breadbasket of Rizia and the homeland of Queen Mother Estela!\\\"", 4);

            AddLine(conv, 4, AngelicaId, RomusId, "Angelica_Furious_Rebuttal_2",
                "\\\"Your requisition officers are already impounding trucks, seizing livestock, and threatening our mayors. If you bleed our farms dry to feed your iron tanks, winter starvation and strikes will paralyze our towns before your army even crosses the river!\\\"", 5);

            AddLine(conv, 5, ManusId, RomusId, "Manus_Passionate_Proposal",
                "Mother speaks the truth, Your Majesty. But House Sazon does not wish to see our army fail. Quite the contrary. Our merchant syndicates, provincial granaries, and river barge fleets have managed Brenas logistics for centuries. If the Crown entrusts supply operations to our provincial guilds, we will ensure that every battalion is fed and fueled without resorting to martial extortion.", 6);

            AddLine(conv, 6, LucitaId, RomusId, "Lucita_Military_Counter",
                "Councilor Azaro leaned forward, her gaze razor-sharp. \\\"With all due respect to the Sazon heir, guild bureaucracy moves at the pace of an ox cart. If my armored spearheads stall in the mud outside Wiktrany waiting for guild manifests, General Valdez will bring down Wehzek heavy artillery and slaughter our men!\\\"", 7);

            AddLine(conv, 7, ElenaId, RomusId, "Elena_Ledger_Audit",
                "Elena Werner adjusted her spectacles and tapped her pen against her leather ledger. \\\"For Dast's sake, look at the arithmetic rather than your family heraldry! The Azaro centralized rail plan guarantees rapid delivery of shells, but hauling everything from Montaklar by heavy train burns immense quantities of refined fuel (-1 Energy per turn) and requires full military mobilization.\\\"", 8);

            AddLine(conv, 8, ElenaId, RomusId, "Elena_Ledger_Audit_2",
                "\\\"The Sazon syndicate plan utilizes local granaries and shallow river barges. It conserves our fuel and stiffens provincial defense in Brenas (+1 Defense on Brenas tiles), but compensating the merchant syndicates requires direct subsidies from our royal treasury (-1 Budget per turn).\\\"", 9);

            AddLine(conv, 9, HugoId, RomusId, "Hugo_Unity_Plea",
                "Hugo Toras shook his head gravely. \\\"Romus, a kingdom divided against itself will fall before Wiktor Smolak. The blood of House Toras, House Azaro, and House Sazon has preserved this realm for four centuries. You must bridge this divide.\\\"", 10);

            // Grand Dispute Hub (Entry 10)
            var disputeHub = AddLine(conv, 10, NarratorId, RomusId, "Dispute_Hub_Prompt",
                "The entire council fell silent, waiting for your judgment. The fate of the southern supply corridor rested in your hands.");

            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Choose House Sazon
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Choose House Azaro
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Royal Compromise

            // OPTION 20: House Sazon Brenas Route
            AddChoice(conv, 20, ManusId, "Choice_Sazon_Route",
                "\"House Sazon will manage the supply lines. Rely on Brenas granaries, river barges, and local syndicates.\"",
                "We cannot break the back of Brenas to win a military campaign. House Sazon will oversee rear supply and transit. Utilize your guild networks, river barges, and granaries to keep our army fed and our people secure.", 21,
                "ZilleCampaignState.LogisticsRoute = \"Sazon\"; Variable[\"Zille_Logistics_Route\"] = \"Sazon\"; Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] - 1; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] + 2; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] - 1;");

            AddLine(conv, 21, ManusId, RomusId, "Ack_Sazon_Manus",
                "\"Thank you, Your Majesty!\" Manus bowed with genuine reverence. \"House Sazon will mobilize our finest river barges and grain syndicates. The people of Brenas will know their King protects them. In fact, our house levies stand ready to march as volunteers under your royal banner!\"", 22);

            AddLine(conv, 22, AngelicaId, RomusId, "Ack_Sazon_Angelica",
                "Duchess Angelica tilted her chin proudly. \"A wise and sovereign decree, Your Majesty. Brenas will stand as an impenetrable bastion at your rear, and our western coastal waters will be open for any naval maneuver your fleet requires.\"", 23);

            AddLine(conv, 23, TaddeusId, RomusId, "Ack_Sazon_Taddeus",
                "Duke Taddeus scowled, tossing his gloves onto the mahogany table with visible disgust. \"I only hope, Your Majesty, that when Valdez's tanks counter-attack, your merchant syndicates can fire wheat bushels instead of armor-piercing shells.\"", 24);

            AddLine(conv, 24, LucitaId, RomusId, "Ack_Sazon_Lucita",
                "Lucita remained disciplined, though her jaw was clenched tight. \"The General Staff will adapt our operational timetable to the guild schedules, Your Majesty. We will hold Brenas at all costs.\"", -1);

            // OPTION 30: House Azaro Centralized Rail Route
            AddChoice(conv, 30, LucitaId, "Choice_Azaro_Route",
                "\"Military necessity is absolute. Grant House Azaro full requisition powers to unleash a mechanized blitzkrieg.\"",
                "Military necessity takes absolute priority. Grant Councilor Azaro and the General Staff full requisition authority over the southern rail network and fuel depots. We need maximum attack tempo to crush Valdez before he can entrench.", 31,
                "ZilleCampaignState.LogisticsRoute = \"Azaro\"; Variable[\"Zille_Logistics_Route\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Energy\"] = Variable[\"RiziaDLC.Resources_Energy\"] - 1; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] + 2; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] - 2;");

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Azaro_Lucita",
                "Lucita saluted crisply, her eyes shining with decisive pride. \"A command worthy of a warrior king, Your Majesty! Our mechanized spearheads will receive every shell and barrel of fuel without a single second of hesitation. We will shatter Valdez's lines with overwhelming force!\"", 32);

            AddLine(conv, 32, TaddeusId, RomusId, "Ack_Azaro_Taddeus",
                "\"Montaklar's divisions are at your service, Your Majesty!\" Taddeus grinned fiercely. \"Our armored columns will sweep through Wiktrany like a thunderbolt!\"", 33);

            AddLine(conv, 33, AngelicaId, RomusId, "Ack_Azaro_Angelica",
                "Duchess Angelica rose from her chair, her eyes burning with icy indignation. \"The Crown may take its fuel, Your Majesty. But remember this day when our farmers curse the name of Montaklar in the winter breadlines.\"", 34);

            AddLine(conv, 34, ManusId, RomusId, "Ack_Azaro_Manus",
                "Manus bowed his head solemnly. \"We will do our best to maintain civil order in Brenas, Your Majesty. May your victory be swift enough to justify the price our people must bear.\"", -1);

            // OPTION 40: Royal Compromise
            AddChoice(conv, 40, ElenaId, "Choice_Compromise_Route",
                "\"Neither house will dictate terms. Elena Werner will lead a Joint Logistical Board balancing both needs.\"",
                "Neither house will dictate terms unilaterally. Minister Elena Werner will chair a joint royal logistical board. Priority rail corridors will be reserved for military munitions, while Sazon guilds will oversee food procurement and local depot distribution.", 41,
                "ZilleCampaignState.LogisticsRoute = \"Compromise\"; Variable[\"Zille_Logistics_Route\"] = \"Compromise\"; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] + 1; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] + 1;");

            AddLine(conv, 41, ElenaId, RomusId, "Ack_Compromise_Elena",
                "Elena smiled faintly, adjusting her glasses. \"A thoroughly pragmatic compromise, Your Majesty. It prevents military paralysis while guarding the Crown against corrupt provincial price-gouging. I will assume personal oversight of the board immediately.\"", 42);

            AddLine(conv, 42, HugoId, RomusId, "Ack_Compromise_Hugo",
                "\"Well reasoned, Romus. Unity between our noble houses is the bedrock upon which our dynasty stands. Glovurius axa Rizia!\"", 43);

            AddLine(conv, 43, LucitaId, RomusId, "Ack_Compromise_Lucita",
                "Lucita exchanged a glance with Manus before nodding with professional respect. \"The military accepts this structure, Your Majesty. We will coordinate our convoy schedules directly with Minister Werner's office.\"", -1);

            AddConversationWithAlias(db, conv, "Zille/WarLogisticsDispute", "Turn_Zille_WarLogisticsDispute");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Logistics Dispute (ID 9990) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 3: Turn_Zille_WarBriefing (ID 9988) - ROYAL WAR COUNCIL BRIEFING
        // Modeled on: 357_SnO_WarEruptionBriefing, 410_SnO_War_Pales_PostOperation1
        // Eve-of-war briefing. Romus chooses between Staff Officers or Direct Command
        // (Operation Golden Sword Phase I or Operation Golden Ark Phase I).
        // Lucita Azaro, Titus Gordion, Hugo Toras, Laurento Esquibel.
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

            bool lucitaMarried = DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Married") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Marriage_Happened") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLCSupport.Journal_Turn08_Lucita_Married");
            bool lucitaRomance = lucitaMarried ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Relations_Lucita_Together") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_RomanceHappened") ||
                                 DialogueHelper.GetIntVariable("RiziaDLC.Relations_Lucita_Romance") > 0;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Briefing_Atmosphere",
                "Midnight in the War Room of Palas Rezna. Heavy rain beat rhythmically against the stone walls, but inside the air was thick with the scent of coffee, paper, and gun oil. Across the large tactical table lay the final relief map of Zille, brass tokens marking every bridge, hill, and fortified redoubt along the frontier.", 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Briefing_Open",
                "Your Majesty... The hour has arrived. Decades of diplomatic patience have run dry. In a few hours, the world will awaken to news that Rizia has drawn the sword to reclaim its stolen province.", 3);

            if (lucitaMarried)
            {
                AddLine(conv, 3, NarratorId, RomusId, "Lucita_Narration_Married",
                    "Lucita stood at the head of the map table, her field marshal's baton resting lightly across the Brenas border. When your eyes met, her severe military demeanor softened with quiet warmth before she addressed the assembly.", 4);
                AddLine(conv, 4, LucitaId, RomusId, "Lucita_Open_Married",
                    "My King... and my husband. All divisions are deployed at their staging posts. The soldiers have received their rations, their ammunition, and their blessing from the priests. Our high command awaits only your operational doctrine.", 5);
            }
            else if (lucitaRomance)
            {
                AddLine(conv, 3, NarratorId, RomusId, "Lucita_Narration_Romance",
                    "Lucita looked up from the eastern approaches, her dark eyes flashing with unmistakable affection before snapping back to rigorous military discipline.", 4);
                AddLine(conv, 4, LucitaId, RomusId, "Lucita_Open_Romance",
                    "Your Majesty... Romus. The army is prepared. Our officers stand by their radios along the Brenas perimeter. The operational command is yours to dictate.", 5);
            }
            else
            {
                AddLine(conv, 3, LucitaId, RomusId, "Lucita_Open_Standard",
                    "Your Majesty. All divisions of the Royal Army and provincial levies have assumed combat positions along the demarcation line. Our artillery batteries have registered their firing coordinates. We await your final operational authorization.", 5);
            }

            AddLine(conv, 5, LaurentoId, RomusId, "Laurento_Briefing_Note",
                "Our diplomatic memorandums have been pre-scheduled for dispatch to the Alliance of Nations in Kyrute the moment our first units cross the border. We are framing this strictly as the lawful expiration of the 1929 lease and the restoration of historical sovereignty.", 6);

            AddLine(conv, 6, TitusId, RomusId, "Titus_Briefing_Note",
                "The Golden Guard has deployed vanguard security teams along the advance routes, Your Majesty. Our scouts confirm that Valdez's garrison in Zille City has not yet detected our mechanized assembly.", 10);

            // Grand Strategic Command Hub (Entry 10)
            var commandHub = AddLine(conv, 10, LucitaId, RomusId, "Command_Hub_Prompt",
                "We must now decide how this war shall be waged, Your Majesty. Either the Crown delegates frontline tactical execution to the General Staff under one of four strategic doctrines, OR Your Majesty personally takes command at the War Table to direct Operation Golden Sword or Operation Golden Ark. How shall the Crown proceed?");

            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Romus: Operation Golden Sword
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Romus: Operation Golden Ark
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Staff Officers Command
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 50)); // Postpone

            // OPTION 20: Operation Golden Sword Phase I (Direct Command)
            AddChoice(conv, 20, LucitaId, "Choice_Golden_Sword",
                "\"I will take personal command at the War Table: Authorize Operation Golden Sword Phase I.\"",
                "I will command this campaign myself. Authorize Operation Golden Sword Phase I. We will launch a massive armored spearhead through the central plain at Wiktrany, smashing Valdez's center and driving west directly onto Zille City.", 21,
                "ZilleCampaignState.PlanType = ZillePlanType.Romulus; ZilleCampaignState.RomulusPlan = ZilleRomulusPlan.Sword; ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1; ZilleCampaignState.CurrentPhaseNumber = 1; Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenSword\"; Variable[\"Zille_War_Active\"] = true;");

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Golden_Sword_Lucita",
                "\"A glorious doctrine, Your Majesty!\" Lucita's eyes burned with martial pride. \"Our heavy tanks and mechanized infantry will punch straight through their fortified junctions. The War Table is illuminated and awaiting your strategic deployment for Phase I!\"", 22);

            AddLine(conv, 22, HugoId, RomusId, "Ack_Golden_Sword_Hugo",
                "\"May the Saint of Victory ride with you, Romus. Lead our kingdom to glory. Glovurius axa Rizia!\"", -1);

            // OPTION 30: Operation Golden Ark Phase I (Direct Command)
            AddChoice(conv, 30, LucitaId, "Choice_Golden_Ark",
                "\"I will take personal command at the War Table: Authorize Operation Golden Ark Phase I.\"",
                "I will lead our forces personally. Authorize Operation Golden Ark Phase I. The Royal Navy will sweep the coastline and seal the Gulf, landing our marines and outflanking Valdez through Nanta and the deepwater port of Munat.", 31,
                "ZilleCampaignState.PlanType = ZillePlanType.Romulus; ZilleCampaignState.RomulusPlan = ZilleRomulusPlan.Ark; ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1; ZilleCampaignState.CurrentPhaseNumber = 1; Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true;");

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Golden_Ark_Lucita",
                "\"A brilliant maritime envelopment!\" Lucita smiled fiercely. \"Seizing Munat first will cut off Valdez from any Wehzek sea resupply, leaving him trapped in a pocket. The War Table is configured and waiting for your arrival to deploy Phase I!\"", 32);

            AddLine(conv, 32, LaurentoId, RomusId, "Ack_Golden_Ark_Laurento",
                "\"Securing the port of Munat early also prevents any foreign powers from meddling under the pretext of humanitarian shipping. Godspeed to our fleet, Your Majesty.\"", -1);

            // OPTION 40: Staff Officers Command Hub
            AddChoice(conv, 40, LucitaId, "Choice_Staff_Command",
                "\"The General Staff will direct the campaign. Present the four staff doctrines for execution.\"",
                "The General Staff will direct the field execution of this war. Present your four strategic doctrines for royal selection.", 41,
                "ZilleCampaignState.PlanType = ZillePlanType.Staff; Variable[\"Zille_War_PlanType\"] = \"Staff\";");

            var staffHub = AddLine(conv, 41, LucitaId, RomusId, "Staff_Doctrine_Presentation",
                "The General Staff stands ready, Your Majesty. Four strategic doctrines have been drawn up:\\n\\n" +
                "  Plan Hawk: Heavy aerial strikes and artillery barrages shatter Valdez's command network before infantry advances.\\n" +
                "  Plan Sword: An aggressive armored charge led by House Azaro heavy divisions pushing through Wiktrany.\\n" +
                "  Plan Ark: A methodical maritime encirclement by the Royal Navy, starving Valdez's supply lines.\\n" +
                "  Plan Spear: A covert night decapitation strike by the Golden Guard and commandos against Valdez's headquarters.\\n\\n" +
                "Which staff doctrine do you authorize?");

            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 42)); // Plan Hawk
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 43)); // Plan Sword
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 44)); // Plan Ark
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 45)); // Plan Spear

            AddChoice(conv, 42, LucitaId, "Authorize_Staff_Hawk",
                "\"Authorize Plan Hawk: Shatter their forward redoubts with air and artillery power.\"",
                "I authorize Plan Hawk. Bring down our bomber wings and heavy artillery. Flatten their defensive works before our ground units advance.", 46,
                "ZilleCampaignState.StaffPlan = ZilleStaffPlan.Hawk; Variable[\"Zille_War_StaffPlan\"] = \"Hawk\"; Variable[\"Zille_War_Active\"] = true;");

            AddChoice(conv, 43, LucitaId, "Authorize_Staff_Sword",
                "\"Authorize Plan Sword: Unleash our armored divisions in a central breakthrough.\"",
                "I authorize Plan Sword. Mass our armor and let the Azaro divisions spearhead the breakthrough into Wiktrany.", 46,
                "ZilleCampaignState.StaffPlan = ZilleStaffPlan.Sword; Variable[\"Zille_War_StaffPlan\"] = \"Sword\"; Variable[\"Zille_War_Active\"] = true;");

            AddChoice(conv, 44, LucitaId, "Authorize_Staff_Ark",
                "\"Authorize Plan Ark: Execute a disciplined maritime blockade and coastal encirclement.\"",
                "I authorize Plan Ark. The Royal Navy will strangle Valdez's supply lines and seal the peninsula from foreign meddling.", 46,
                "ZilleCampaignState.StaffPlan = ZilleStaffPlan.Ark; Variable[\"Zille_War_StaffPlan\"] = \"Ark\"; Variable[\"Zille_War_Active\"] = true;");

            AddChoice(conv, 45, TitusId, "Authorize_Staff_Spear",
                "\"Authorize Plan Spear: Deploy the Golden Guard and commandos to decapitate Valdez's command.\"",
                "I authorize Plan Spear. Commander Gordion, send your best operatives into Zille tonight. Decapitate Valdez's staff before the main assault begins.", 47,
                "ZilleCampaignState.StaffPlan = ZilleStaffPlan.Spear; Variable[\"Zille_War_StaffPlan\"] = \"Spear\"; Variable[\"Zille_War_Active\"] = true;");

            AddLine(conv, 46, LucitaId, RomusId, "Ack_Staff_Lucita",
                "\"The orders are dispatched, Your Majesty! The General Staff has initiated the offensive. Our officers will report battle progress as the front develops!\"", -1);

            AddLine(conv, 47, TitusId, RomusId, "Ack_Staff_Titus",
                "\"My guardsmen are already moving under cover of darkness, Your Majesty,\" Titus whispered with gauntleted fist against his breastplate. \"Smolak's officers will wake up in chains.\"", -1);

            // OPTION 50: Postpone
            AddChoice(conv, 50, HugoId, "Choice_Postpone_War",
                "\"Hold the offensive for now. Keep our divisions at maximum readiness along the border.\"",
                "Hold the offensive for now. Keep our divisions at maximum combat readiness along the frontier, but do not cross until I give the royal command.", 51,
                "Variable[\"Zille_War_Postpone\"] = true;");

            AddLine(conv, 51, HugoId, RomusId, "Ack_Postpone_Hugo",
                "\"A prudent and measured decision, Your Majesty. The General Staff will maintain full combat readiness along the frontier until you decide the hour is right.\"", -1);

            AddConversationWithAlias(db, conv, "Zille/WarCouncil_Briefing", "Turn_Zille_WarBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Council Briefing (ID 9988) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 4: Turn_Zille_MaveNortusHQ (ID 9994) - FRONTLINE HEADQUARTERS
        // Modeled on: 410_SnO_War_Pales_PostOperation1 & 385_Pales_War_Update_And_Tax
        // Romus visits the forward staging command post in Mave Nortus (Brenas).
        // Distant artillery echoes, municipal desk covered in tactical maps,
        // foreign aid reviewed, casualty reports, and launching Phase II!
        // Taddeus Azaro, Lucita Azaro, Titus Gordion, Mayor of Mave Nortus.
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
                "Your armored convoy rumbled through the muddy, rain-slicked streets of Mave Nortus. In the distance across the northern hills, the rhythmic thud of heavy artillery rolled like continuous thunder, rattling the windowpanes of the ancient Brenas stone houses. Sandbag bunkers lined the crossroads, and wounded soldiers resting on canvas stretchers outside the town church looked up with weary reverence as the royal standard fluttered past.", 2);

            AddLine(conv, 2, NarratorId, RomusId, "MaveNortus_Office_Entry",
                "Inside the town hall, municipal tax ledgers had been unceremoniously shoved aside to make room for battlefield telegraphs and grease-pencil situational maps spread across the Mayor's massive oak desk. Duke Taddeus Azaro stood with his uniform jacket unbuttoned, pointing a scarred finger at the river crossings, while Councilor Lucita Azaro reviewed incoming courier dispatches.", 3);

            AddLine(conv, 3, TaddeusId, RomusId, "Taddeus_HQ_Greeting",
                "Your Majesty! It is an honor to have our King at the front lines. The men took heart the moment the royal motorcade was spotted crossing the Brenas viaduct.", 4);

            AddLine(conv, 4, LucitaId, RomusId, "Lucita_HQ_Debrief_1",
                "Phase I of our operation has concluded, Your Majesty. Valdez fought back tenaciously along the river dikes, but our forward brigades have successfully established our tactical bridgeheads.", 5);

            AddLine(conv, 5, LucitaId, RomusId, "Lucita_HQ_Debrief_2",
                "However, the battle is only half won. We have captured key outer junctions, but Valdez has consolidated his surviving armor and veterans into a hardened defensive ring around Zille City itself and the coastal redoubts. We must launch Phase II to break their spine.", 6);

            AddLine(conv, 6, MayorBrenasId, RomusId, "Mayor_HQ_Report",
                "The Mayor of Mave Nortus bowed nervously, wiping sweat from his brow. \\\"Your Majesty, over four thousand Rizian refugees have fled across the border from Zille in the last forty-eight hours. Smolak's retreating officers burned grain elevators behind them. Our town is doing everything possible to house and feed them, but medical supplies are running thin.\\\"", 10);

            // Frontline Review Hub (Entry 10)
            var hqHub = AddLine(conv, 10, NarratorId, RomusId, "HQ_Hub_Prompt",
                "Distant artillery rumbled once more, sending a gentle shower of plaster dust drifting down from the ceiling. You studied the situational map, ready to question your commanders.");

            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11)); // Foreign Aid Audit
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12)); // Casualties & Morale
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 13)); // Refugee Relief Order
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Launch Phase II Orders

            AddChoice(conv, 11, LucitaId, "Inquire_ForeignAid",
                "\"What reports do we have on foreign assistance and allied support?\"",
                "Lucita, what reports do we have regarding foreign assistance? Has our international diplomacy yielded tangible aid on the battlefield?", 14);

            AddLine(conv, 14, LucitaId, RomusId, "Answer_ForeignAid",
                "Very tangible, Your Majesty. High-resolution aerial reconnaissance photos supplied by Lespia have revealed Valdez's camouflaged artillery bunkers behind the marshlands. In addition, three trainloads of heavy 152mm artillery shells from Rumburg arrived in the Brenas depot this morning. And in the south, Derdian irregulars have raided Wehlen's border depots, forcing Valdez to divert an entire infantry regiment away from our front.", 10);

            AddChoice(conv, 12, TaddeusId, "Inquire_Casualties",
                "\"Taddeus, how heavy are our casualties, and how is the fighting spirit of our soldiers?\"",
                "Taddeus, give me a frank assessment of our losses. How are our men holding up against Wehlen's counter-attacks?", 15);

            AddLine(conv, 15, TaddeusId, RomusId, "Answer_Casualties",
                "We took shrapnel losses taking the river trenches, Your Majesty, but our field hospitals have performed miracles. Morale is soaring. The men know they are liberating Rizian soil, not fighting for some foreign desert. They are eager to finish the job in Zille City.", 10);

            AddChoice(conv, 13, MayorBrenasId, "Order_Refugee_Aid",
                "\"Mayor, the Crown will fund emergency medical aid and provisions for every refugee.\"",
                "Mayor, the Crown will immediately release emergency funds and grain from the royal reserves for every refugee arriving in Mave Nortus. No Rizian fleeing Smolak will be neglected.", 16,
                "Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] - 1; Variable[\"Zille_Refugee_Aid_Granted\"] = true;");

            AddLine(conv, 16, MayorBrenasId, RomusId, "Ack_Refugee_Aid",
                "Tears welled in the Mayor's eyes as he pressed his hand to his heart. \\\"God bless Your Majesty! The people of Brenas and Zille will never forget your royal mercy!\\\"", 10);

            // Launch Phase II Orders (Entry 20)
            AddChoice(conv, 20, LucitaId, "Order_Phase2_Launch",
                "\"The time has come. Issue the battle orders for Phase II: Break their inner ring and capture Zille City!\"",
                "The time has come. Valdez will find no respite. Issue the battle orders for Phase II immediately. Concentrate our artillery, deploy our fresh reserves, and storm Zille City!", 21,
                "ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2; ZilleCampaignState.CurrentPhaseNumber = 2; Variable[\"Zille_War_Phase\"] = 2;");

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Phase2_Lucita",
                "Lucita smiled with fierce, cold resolution, snapping her field baton onto Zille City. \"The orders are dispatched, Your Majesty! Our armor will lead the assault at dawn. We will deliver Zille back into your royal hands!\"", 22);

            AddLine(conv, 22, TaddeusId, RomusId, "Ack_Phase2_Taddeus",
                "Taddeus drew his saber and held it aloft in solemn tribute. \"For King and Kingdom! Glovurius axa Rizia! Forward to victory!\"", -1);

            AddConversationWithAlias(db, conv, "Zille/MaveNortusHQ", "Turn_Zille_MaveNortusHQ");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Mave Nortus Field HQ (ID 9994) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 5: Turn_Zille_WarBalconySpeech (ID 9989) - WAR PROCLAMATION SPEECH
        // Modeled on: 440_A_ZilleReturnedSpeech & 357_SnO_WarEruptionBriefing
        // Romus addresses 40,000 citizens from Palas Rezna balcony on live radio.
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
                "The grand double doors of the Palas Rezna balcony swung open to the roar of over forty thousand citizens packed shoulder to shoulder in the Royal Plaza. Banners of House Toras, Azaro, and Sazon fluttered in the autumn breeze. Below, brass microphones were wired to radio broadcasting trucks transmitting your voice to every household across Rizia.", 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Balcony_Whisper",
                "Hugo leaned in, his voice barely audible beneath the roar of the crowd. \\\"The whole kingdom listens, Romus. Give them words worthy of a king.\\\"", 3);

            var speechHub = AddLine(conv, 3, NarratorId, RomusId, "Speech_Doctrine_Prompt",
                "You stepped forward to the stone balustrade, raising your sovereign hand. A profound hush fell over the ocean of citizens.");

            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Revanchist Might
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Liberating the Oppressed
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Sovereign Legalism

            AddChoice(conv, 10, HugoId, "Speech_Revanchist",
                "\"Sons and daughters of Rizia! We march to reclaim what was stolen by force and restore the glory of our ancestors!\"",
                "Sons and daughters of Rizia! For thirty years, our kingdom has borne the sting of humiliation in silence. But House Toras does not bow to tyrants! Today, the Royal Army marches to reclaim our sovereign soil and restore the imperial dignity of our kingdom!", 11,
                "Variable[\"Zille_Speech_Tone\"] = \"Revanchist\"; Variable[\"RiziaDLC.Situation_Order_Nationalist_Happy\"] = true;");

            AddLine(conv, 11, NarratorId, RomusId, "Speech_Revanchist_Reaction",
                "A thunderous roar erupted from the crowd, bayonets flashing in the sun as soldiers raised their rifles in salute. Hugo nodded approvingly, his chest swelling with dynastic pride.", -1);

            AddChoice(conv, 20, HugoId, "Speech_Liberation",
                "\"We come not as conquerors, but as liberators to free our brothers and sisters from Smolak's tyranny!\"",
                "People of Rizia! We cross the border not out of hatred, but out of sacred love for our brothers and sisters in Zille who have suffered under the yoke of Smolak's secret police. We march to bring them home to their true kingdom!", 21,
                "Variable[\"Zille_Speech_Tone\"] = \"Liberation\"; Variable[\"RiziaDLC.Situation_Order_Reformist_Happy\"] = true;");

            AddLine(conv, 21, NarratorId, RomusId, "Speech_Liberation_Reaction",
                "Tears flowed freely among the elder citizens in the crowd, and chants of 'Long live Romus the Liberator!' resonated throughout the ancient plaza.", -1);

            AddChoice(conv, 30, HugoId, "Speech_Legalist",
                "\"The 1929 lease has expired. We uphold international law where Wehlen has trampled it!\"",
                "Citizens of Rizia and observers across Merkopa. Rizia is a realm of honor and constitutional order. The 1929 lease has expired. In reclaiming Zille, we enforce the sacred rule of law that Wiktor Smolak has trampled underfoot!", 31,
                "Variable[\"Zille_Speech_Tone\"] = \"Legalist\"; Variable[\"RiziaDLC.Situation_Diplomacy_AN_Favorable\"] = true;");

            AddLine(conv, 31, NarratorId, RomusId, "Speech_Legalist_Reaction",
                "Foreign correspondents frantically scribbled notes, while the crowd applauded with deep, dignified respect for the Crown's measured authority.", -1);

            AddConversationWithAlias(db, conv, "Zille/WarBalconySpeech", "Turn_Zille_WarBalconySpeech");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Balcony Proclamation (ID 9989) into masterDatabase!");
        }
    }
}
'''

with open('src/GreatZilleSolution/ZilleDialogueSystem.WarScenes.cs', 'w', encoding='utf-8') as f:
    f.write(WAR_SCENES_CS)

print("Wrote src/GreatZilleSolution/ZilleDialogueSystem.WarScenes.cs")
