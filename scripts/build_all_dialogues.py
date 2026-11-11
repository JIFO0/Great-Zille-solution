import os

def cs(s):
    if not s:
        return '""'
    escaped = s.replace('\\', '\\\\').replace('"', '\\"').replace('\r\n', '\\n').replace('\n', '\\n').replace('\r', '\\n')
    return f'"{escaped}"'

def generate_war_scenes():
    code = f'''using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{{
    public static partial class ZilleDialogueSystem
    {{
        // =========================================================================
        // SCENE 1: Turn_Zille_WarPlanning (ID 9987) - WAR PLANNING SESSION
        // Modeled on: 358_SnO_PalesPostIncidentMeeting, 289_EnT_CouncilBriefing, 357_SnO_WarEruptionBriefing
        // Hugo Toras, Lucita Azaro, Elena Werner, Laurento Esquibel, Titus Gordion.
        // =========================================================================
        public static void RegisterWarPlanning(DialogueDatabase db)
        {{
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
                {cs("Outside the council chamber windows, gray rain lashed against the stone spires of Palas Rezna. An emergency war map of the southern border lay unfurled across the mahogany table, weighed down by heavy bronze candleholders. The ministers took their seats in somber silence, the gravity of the hour hanging heavy in the air.")}, 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Planning_Open",
                {cs("Your Majesty... We have convened the Crown Council under extraordinary circumstances. Smolak's continued defiance and the escalating tensions in Zille have brought our kingdom to a decisive crossroads.")}, 3);

            var stanceHub = AddLine(conv, 3, RomusId, HugoId, "Romus_Planning_Posture_Prompt",
                {cs("I looked at the gathered faces of my council, each waiting for their King to establish the direction of the realm.")});

            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive force
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Pragmatic caution
            stanceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Sovereign legalism

            AddChoice(conv, 10, HugoId, "Posture_Force",
                {cs("\"Thirty years of national humiliation ends here. It is time the Crown plans the military reclamation of Zille.\"")},
                {cs("Thirty years of national humiliation ends here. Smolak will not return our territory through words. It is time the Crown plans the military reclamation of Zille by force of arms.")}, 20,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Force\";")});

            AddChoice(conv, 11, HugoId, "Posture_Pragmatic",
                {cs("\"We must weigh our capabilities soberly. Can the Kingdom truly bear the burden of a war against Wehlen?\"")},
                {cs("We must weigh our capabilities soberly. Can our treasury, our military, and our people truly bear the burden of a war against Wehlen? I need honest counsel, not bravado.")}, 20,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Cautious\";")});

            AddChoice(conv, 12, HugoId, "Posture_Legal",
                {cs("\"The 1929 lease has expired. Wehlen's presence is an unlawful occupation. We will uphold our sovereign right.\"")},
                {cs("The 1929 lease has expired. Wehlen's continued presence is an unlawful foreign occupation. If Smolak refuses to withdraw, we have every legal and sovereign right to expel his garrisons.")}, 20,
                {cs("Variable[\"Zille_Planning_Stance\"] = \"Legal\";")});

            AddLine(conv, 20, HugoId, RomusId, "Hugo_Dynastic_Warning",
                {cs("Romus... As your uncle and your Grand Vizier, I must urge profound care. Your father, King Valero, surrendered Zille to quell internal turmoil when the throne itself was shaking. If we march across that river and stumble, the divine authority of House Toras will suffer a blow from which it may never recover.")}, 21);

            AddLine(conv, 21, LucitaId, RomusId, "Lucita_Military_Appraisal_1",
                {cs("With respect to the Grand Vizier, inaction is far more dangerous, Your Majesty. General Valdez has stationed four brigades in Zille-an armored detachment at the central rail hub of Wiktrany, two dug-in infantry brigades around Zille City itself, and a garrison securing the deepwater port of Munat.")}, 22);

            AddLine(conv, 22, LucitaId, RomusId, "Lucita_Military_Appraisal_2",
                {cs("Valdez's men are conscripts, poorly provisioned and demoralized by Smolak's erratic commands. The Azaro divisions and the Royal Army possess superior mechanized armor and professional training. If we strike with decisive speed before Valdez can complete his river redoubts, his outer defensive perimeter will collapse like dry timber.")}, 23);

            AddLine(conv, 23, ElenaId, RomusId, "Elena_Economic_Reality",
                {cs("Courage does not buy diesel, Councilor Azaro. Your Majesty, our royal treasury cannot afford wishful thinking. A mobile offensive consumes petroleum and replacement munitions at an exorbitant burn rate. If the operation drags into a protracted winter siege, we face staggering deficits and domestic inflation.")}, 24);

            AddLine(conv, 24, LaurentoId, RomusId, "Laurento_International_Horizon",
                {cs("The diplomatic battleground is equally hazardous, Your Majesty. Chancellor Hegel of Valgsland and United Contana will condemn our offensive as monarchist aggression. However, because the 1929 lease has unambiguously lapsed, President Alvarez of Lespia and the ATO powers will hesitate to intervene against us if we present the campaign as a swift, localized restoration of sovereign order.")}, 25);

            AddLine(conv, 25, TitusId, RomusId, "Titus_Security_Estela",
                {cs("Internal security must not be overlooked, Your Majesty. Su Omina and ATA networks inside Zille are ready to disrupt Wehzek communications. Furthermore, the Golden Guard has prepared elite units to secure Queen Mother Estela's ancestral estate the moment our spearheads cross the border.")}, 30);

            var inquiryHub = AddLine(conv, 30, NarratorId, RomusId, "Planning_Inquiry_Hub",
                {cs("The room grew quiet as the advisors awaited your direction. Several strategic questions demanded clarification before a mobilization decree could be issued.")});

            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 31)); // Question Lucita
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 32)); // Question Elena
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 33)); // Question Laurento
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 34)); // Question Titus
            inquiryHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Conclude planning

            AddChoice(conv, 31, LucitaId, "Inquire_Lucita",
                {cs("\"Lucita, what terrain obstacles must our armored divisions overcome in Zille?\"")},
                {cs("Lucita, detail the terrain obstacles our mechanized units must overcome. Where will Valdez make his stand?")}, 35);

            AddLine(conv, 35, LucitaId, RomusId, "Answer_Lucita",
                {cs("The central approach is bisected by the Brenas-Zille river valley and marshlands surrounding Wiktrany. If we force the central river crossings, we sever Valdez's lateral communications. But if heavy rains flood the lowlands, our tanks will need solid logistics from Brenas to keep moving.")}, 30);

            AddChoice(conv, 32, ElenaId, "Inquire_Elena",
                {cs("\"Elena, what financial reserves can we mobilize without bankrupting social programs?\"")},
                {cs("Elena, what financial reserves can we tap without crippling municipal budgets and domestic welfare?")}, 36);

            AddLine(conv, 36, ElenaId, RomusId, "Answer_Elena",
                {cs("If we issue royal war bonds and secure foreign energy credits, we can absorb the initial shocks. But the logistics framework is paramount-supplying the army locally out of Brenas granaries will conserve gold, whereas shipping everything by rail from Montaklar will burn through our strategic oil reserves.")}, 30);

            AddChoice(conv, 33, LaurentoId, "Inquire_Laurento",
                {cs("\"Laurento, can we secure a veto or friendly neutrality in the Alliance of Nations?\"")},
                {cs("Laurento, can we secure a veto or friendly neutrality from the major powers in the Alliance of Nations?")}, 37);

            AddLine(conv, 37, LaurentoId, RomusId, "Answer_Laurento",
                {cs("Queen Beatrice of Rumburg will stand firmly with us in the AN, provided we maintain GRACE solidarity. President Alvarez can be persuaded through economic incentives to keep Lespia's airspace and radar active for our benefit. Smolak will find himself isolated if we strike decisively.")}, 30);

            AddChoice(conv, 34, TitusId, "Inquire_Titus",
                {cs("\"Titus, how confident are you in the Golden Guard's protection of Queen Estela's home?\"")},
                {cs("Titus, how confident are you that the Golden Guard can shield Queen Estela's estate and protect civilian loyalists?")}, 38);

            AddLine(conv, 38, TitusId, RomusId, "Answer_Titus",
                {cs("Completely confident, Your Majesty. My finest detachment is briefed and ready. We will parachute or ride at the very vanguard of the advance. No harm will come to the Queen Mother's heritage.")}, 30);

            AddChoice(conv, 40, HugoId, "Conclude_Planning",
                {cs("\"The decision is made. Prepare the kingdom for war. Convene the Logistics Summit in Brenas.\"")},
                {cs("The decision is made. The Crown resolves on the military reclamation of Zille. Lucita, draft the preliminary deployment orders. Hugo, convene the provincial lords and military command in Brenas for the Logistics Summit. We will resolve our supply lines once and for all.")}, 41,
                {cs("Variable[\"Zille_War_Planning_Done\"] = true; Variable[\"Zille_War_Sentiment\"] = 3;")});

            AddLine(conv, 41, HugoId, RomusId, "Hugo_Planning_Close",
                {cs("\"As your sovereign will decrees, Your Majesty. May Saint Wruhec guide our banners and preserve our realm.\"")}, 42);

            AddLine(conv, 42, LucitaId, RomusId, "Lucita_Planning_Close",
                {cs("Lucita snapped to attention and saluted crisply. \"The General Staff will initiate immediate preparations. The road to Zille begins now, Your Majesty.\"")}, -1);

            AddConversationWithAlias(db, conv, "Zille/WarPlanning", "Turn_Zille_WarPlanning");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Planning Session (ID 9987) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 2: Turn_Zille_WarLogisticsDispute (ID 9990) - LOGISTICS DISPUTE
        // Modeled on: 551_REFORM_TALKS_Conversation, 407_A_Reform_Manus, 315_P_EstelaUpdate
        // Duchess Angelica Sazon, Manus Sazon, Duke Taddeus Azaro, Lucita Azaro, Elena Werner, Hugo Toras, Titus Gordion.
        // =========================================================================
        public static void RegisterWarLogisticsDispute(DialogueDatabase db)
        {{
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
                {cs("The atmosphere inside the State Dining Hall of Palas Rezna was crackling with noble animosity. Servants had cleared the banquet tables to make way for logistical ledgers, railway maps, and provincial supply manifests. On one side of the long table sat Duke Taddeus Azaro and War Councilor Lucita Azaro in polished uniform; on the other sat Duchess Angelica Sazon and Manus Sazon in dark Brenas velvet.")}, 2);

            AddLine(conv, 2, TaddeusId, RomusId, "Taddeus_Logistics_Opener",
                {cs("Your Majesty! The General Staff cannot conduct an offensive while our fuel convoys are held up at civilian toll gates and local rail switches in Brenas! Speed is everything in modern mechanized war. We demand unconditional military requisition authority over all rail lines, fuel storage tanks, and granaries across Brenas!")}, 3);

            AddLine(conv, 3, AngelicaId, RomusId, "Angelica_Furious_Rebuttal",
                {cs("Duchess Angelica straightened with icy noble disdain, slamming a jeweled ring against the table. \"Brenas is not an occupied province for Montaklar's generals to pillage, Duke Azaro! It is the historical breadbasket of Rizia and the homeland of Queen Mother Estela!\"")}, 4);

            AddLine(conv, 4, AngelicaId, RomusId, "Angelica_Furious_Rebuttal_2",
                {cs("\"Your requisition officers are already impounding trucks, seizing livestock, and threatening our mayors. If you bleed our farms dry to feed your iron tanks, winter starvation and strikes will paralyze our towns before your army even crosses the river!\"")}, 5);

            AddLine(conv, 5, ManusId, RomusId, "Manus_Passionate_Proposal",
                {cs("Mother speaks the truth, Your Majesty. But House Sazon does not wish to see our army fail. Quite the contrary. Our merchant syndicates, provincial granaries, and river barge fleets have managed Brenas logistics for centuries. If the Crown entrusts supply operations to our provincial guilds, we will ensure that every battalion is fed and fueled without resorting to martial extortion.")}, 6);

            AddLine(conv, 6, LucitaId, RomusId, "Lucita_Military_Counter",
                {cs("Councilor Azaro leaned forward, her gaze razor-sharp. \"With all due respect to the Sazon heir, guild bureaucracy moves at the pace of an ox cart. If my armored spearheads stall in the mud outside Wiktrany waiting for guild manifests, General Valdez will bring down Wehzek heavy artillery and slaughter our men!\"")}, 7);

            AddLine(conv, 7, ElenaId, RomusId, "Elena_Ledger_Audit",
                {cs("Elena Werner adjusted her spectacles and tapped her pen against her leather ledger. \"For Dast's sake, look at the arithmetic rather than your family heraldry! The Azaro centralized rail plan guarantees rapid delivery of shells, but hauling everything from Montaklar by heavy train burns immense quantities of refined fuel (-1 Energy per turn) and requires full military mobilization.\"")}, 8);

            AddLine(conv, 8, ElenaId, RomusId, "Elena_Ledger_Audit_2",
                {cs("\"The Sazon syndicate plan utilizes local granaries and shallow river barges. It conserves our fuel and stiffens provincial defense in Brenas (+1 Defense on Brenas tiles), but compensating the merchant syndicates requires direct subsidies from our royal treasury (-1 Budget per turn).\"")}, 9);

            AddLine(conv, 9, HugoId, RomusId, "Hugo_Unity_Plea",
                {cs("Hugo Toras shook his head gravely. \"Romus, a kingdom divided against itself will fall before Wiktor Smolak. The blood of House Toras, House Azaro, and House Sazon has preserved this realm for four centuries. You must bridge this divide.\"")}, 10);

            var disputeHub = AddLine(conv, 10, NarratorId, RomusId, "Dispute_Hub_Prompt",
                {cs("The entire council fell silent, waiting for your judgment. The fate of the southern supply corridor rested in your hands.")});

            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Choose House Sazon
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Choose House Azaro
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Royal Compromise

            AddChoice(conv, 20, ManusId, "Choice_Sazon_Route",
                {cs("\"House Sazon will manage the supply lines. Rely on Brenas granaries, river barges, and local syndicates.\"")},
                {cs("We cannot break the back of Brenas to win a military campaign. House Sazon will oversee rear supply and transit. Utilize your guild networks, river barges, and granaries to keep our army fed and our people secure.")}, 21,
                {cs("ZilleCampaignState.LogisticsRoute = \"Sazon\"; Variable[\"Zille_Logistics_Route\"] = \"Sazon\"; Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] - 1; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] + 2; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] - 1;")});

            AddLine(conv, 21, ManusId, RomusId, "Ack_Sazon_Manus",
                {cs("\"Thank you, Your Majesty!\" Manus bowed with genuine reverence. \"House Sazon will mobilize our finest river barges and grain syndicates. The people of Brenas will know their King protects them. In fact, our house levies stand ready to march as volunteers under your royal banner!\"")}, 22);

            AddLine(conv, 22, AngelicaId, RomusId, "Ack_Sazon_Angelica",
                {cs("Duchess Angelica tilted her chin proudly. \"A wise and sovereign decree, Your Majesty. Brenas will stand as an impenetrable bastion at your rear, and our western coastal waters will be open for any naval maneuver your fleet requires.\"")}, 23);

            AddLine(conv, 23, TaddeusId, RomusId, "Ack_Sazon_Taddeus",
                {cs("Duke Taddeus scowled, tossing his gloves onto the mahogany table with visible disgust. \"I only hope, Your Majesty, that when Valdez's tanks counter-attack, your merchant syndicates can fire wheat bushels instead of armor-piercing shells.\"")}, 24);

            AddLine(conv, 24, LucitaId, RomusId, "Ack_Sazon_Lucita",
                {cs("Lucita remained disciplined, though her jaw was clenched tight. \"The General Staff will adapt our operational timetable to the guild schedules, Your Majesty. We will hold Brenas at all costs.\"")}, -1);

            AddChoice(conv, 30, LucitaId, "Choice_Azaro_Route",
                {cs("\"Military necessity is absolute. Grant House Azaro full requisition powers to unleash a mechanized blitzkrieg.\"")},
                {cs("Military necessity takes absolute priority. Grant Councilor Azaro and the General Staff full requisition authority over the southern rail network and fuel depots. We need maximum attack tempo to crush Valdez before he can entrench.")}, 31,
                {cs("ZilleCampaignState.LogisticsRoute = \"Azaro\"; Variable[\"Zille_Logistics_Route\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Energy\"] = Variable[\"RiziaDLC.Resources_Energy\"] - 1; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] + 2; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] - 2;")});

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Azaro_Lucita",
                {cs("Lucita saluted crisply, her eyes shining with decisive pride. \"A command worthy of a warrior king, Your Majesty! Our mechanized spearheads will receive every shell and barrel of fuel without a single second of hesitation. We will shatter Valdez's lines with overwhelming force!\"")}, 32);

            AddLine(conv, 32, TaddeusId, RomusId, "Ack_Azaro_Taddeus",
                {cs("\"Montaklar's divisions are at your service, Your Majesty!\" Taddeus grinned fiercely. \"Our armored columns will sweep through Wiktrany like a thunderbolt!\"")}, 33);

            AddLine(conv, 33, AngelicaId, RomusId, "Ack_Azaro_Angelica",
                {cs("Duchess Angelica rose from her chair, her eyes burning with icy indignation. \"The Crown may take its fuel, Your Majesty. But remember this day when our farmers curse the name of Montaklar in the winter breadlines.\"")}, 34);

            AddLine(conv, 34, ManusId, RomusId, "Ack_Azaro_Manus",
                {cs("Manus bowed his head solemnly. \"We will do our best to maintain civil order in Brenas, Your Majesty. May your victory be swift enough to justify the price our people must bear.\"")}, -1);

            AddChoice(conv, 40, ElenaId, "Choice_Compromise_Route",
                {cs("\"Neither house will dictate terms. Elena Werner will lead a Joint Logistical Board balancing both needs.\"")},
                {cs("Neither house will dictate terms unilaterally. Minister Elena Werner will chair a joint royal logistical board. Priority rail corridors will be reserved for military munitions, while Sazon guilds will oversee food procurement and local depot distribution.")}, 41,
                {cs("ZilleCampaignState.LogisticsRoute = \"Compromise\"; Variable[\"Zille_Logistics_Route\"] = \"Compromise\"; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] + 1; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] + 1;")});

            AddLine(conv, 41, ElenaId, RomusId, "Ack_Compromise_Elena",
                {cs("Elena smiled faintly, adjusting her glasses. \"A thoroughly pragmatic compromise, Your Majesty. It prevents military paralysis while guarding the Crown against corrupt provincial price-gouging. I will assume personal oversight of the board immediately.\"")}, 42);

            AddLine(conv, 42, HugoId, RomusId, "Ack_Compromise_Hugo",
                {cs("\"Well reasoned, Romus. Unity between our noble houses is the bedrock upon which our dynasty stands. Glovurius axa Rizia!\"")}, 43);

            AddLine(conv, 43, LucitaId, RomusId, "Ack_Compromise_Lucita",
                {cs("Lucita exchanged a glance with Manus before nodding with professional respect. \"The military accepts this structure, Your Majesty. We will coordinate our convoy schedules directly with Minister Werner's office.\"")}, -1);

            AddConversationWithAlias(db, conv, "Zille/WarLogisticsDispute", "Turn_Zille_WarLogisticsDispute");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Logistics Dispute (ID 9990) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 3: Turn_Zille_WarBriefing (ID 9988) - ROYAL WAR COUNCIL BRIEFING
        // Modeled on: 357_SnO_WarEruptionBriefing, 410_SnO_War_Pales_PostOperation1
        // Lucita Azaro, Titus Gordion, Hugo Toras, Laurento Esquibel.
        // =========================================================================
        public static void RegisterWarCouncilBriefing(DialogueDatabase db)
        {{
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
                {cs("Midnight in the War Room of Palas Rezna. Heavy rain beat rhythmically against the stone walls, but inside the air was thick with the scent of coffee, paper, and gun oil. Across the large tactical table lay the final relief map of Zille, brass tokens marking every bridge, hill, and fortified redoubt along the frontier.")}, 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Briefing_Open",
                {cs("Your Majesty... The hour has arrived. Decades of diplomatic patience have run dry. In a few hours, the world will awaken to news that Rizia has drawn the sword to reclaim its stolen province.")}, 3);

            if (lucitaMarried)
            {{
                AddLine(conv, 3, NarratorId, RomusId, "Lucita_Narration_Married",
                    {cs("Lucita stood at the head of the map table, her field marshal's baton resting lightly across the Brenas border. When your eyes met, her severe military demeanor softened with quiet warmth before she addressed the assembly.")}, 4);
                AddLine(conv, 4, LucitaId, RomusId, "Lucita_Open_Married",
                    {cs("My King... and my husband. All divisions are deployed at their staging posts. The soldiers have received their rations, their ammunition, and their blessing from the priests. Our high command awaits only your operational doctrine.")}, 5);
            }}
            else if (lucitaRomance)
            {{
                AddLine(conv, 3, NarratorId, RomusId, "Lucita_Narration_Romance",
                    {cs("Lucita looked up from the eastern approaches, her dark eyes flashing with unmistakable affection before snapping back to rigorous military discipline.")}, 4);
                AddLine(conv, 4, LucitaId, RomusId, "Lucita_Open_Romance",
                    {cs("Your Majesty... Romus. The army is prepared. Our officers stand by their radios along the Brenas perimeter. The operational command is yours to dictate.")}, 5);
            }}
            else
            {{
                AddLine(conv, 3, LucitaId, RomusId, "Lucita_Open_Standard",
                    {cs("Your Majesty. All divisions of the Royal Army and provincial levies have assumed combat positions along the demarcation line. Our artillery batteries have registered their firing coordinates. We await your final operational authorization.")}, 5);
            }}

            AddLine(conv, 5, LaurentoId, RomusId, "Laurento_Briefing_Note",
                {cs("Our diplomatic memorandums have been pre-scheduled for dispatch to the Alliance of Nations in Kyrute the moment our first units cross the border. We are framing this strictly as the lawful expiration of the 1929 lease and the restoration of historical sovereignty.")}, 6);

            AddLine(conv, 6, TitusId, RomusId, "Titus_Briefing_Note",
                {cs("The Golden Guard has deployed vanguard security teams along the advance routes, Your Majesty. Our scouts confirm that Valdez's garrison in Zille City has not yet detected our mechanized assembly.")}, 10);

            var commandHub = AddLine(conv, 10, LucitaId, RomusId, "Command_Hub_Prompt",
                {cs("We must now decide how this war shall be waged, Your Majesty. Either the Crown delegates frontline tactical execution to the General Staff under one of four strategic doctrines, OR Your Majesty personally takes command at the War Table to direct Operation Golden Sword or Operation Golden Ark. How shall the Crown proceed?")});

            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Romus: Operation Golden Sword
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 30)); // Romus: Operation Golden Ark
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 40)); // Staff Officers Command
            commandHub.outgoingLinks.Add(CreateLink(conv.id, 10, 50)); // Postpone

            AddChoice(conv, 20, LucitaId, "Choice_Golden_Sword",
                {cs("\"I will take personal command at the War Table: Authorize Operation Golden Sword Phase I.\"")},
                {cs("I will command this campaign myself. Authorize Operation Golden Sword Phase I. We will launch a massive armored spearhead through the central plain at Wiktrany, smashing Valdez's center and driving west directly onto Zille City.")}, 21,
                {cs("ZilleCampaignState.PlanType = ZillePlanType.Romulus; ZilleCampaignState.RomulusPlan = ZilleRomulusPlan.Sword; ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1; ZilleCampaignState.CurrentPhaseNumber = 1; Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenSword\"; Variable[\"Zille_War_Active\"] = true;")});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Golden_Sword_Lucita",
                {cs("\"A glorious doctrine, Your Majesty!\" Lucita's eyes burned with martial pride. \"Our heavy tanks and mechanized infantry will punch straight through their fortified junctions. The War Table is illuminated and awaiting your strategic deployment for Phase I!\"")}, 22);

            AddLine(conv, 22, HugoId, RomusId, "Ack_Golden_Sword_Hugo",
                {cs("\"May the Saint of Victory ride with you, Romus. Lead our kingdom to glory. Glovurius axa Rizia!\"")}, -1);

            AddChoice(conv, 30, LucitaId, "Choice_Golden_Ark",
                {cs("\"I will take personal command at the War Table: Authorize Operation Golden Ark Phase I.\"")},
                {cs("I will lead our forces personally. Authorize Operation Golden Ark Phase I. The Royal Navy will sweep the coastline and seal the Gulf, landing our marines and outflanking Valdez through Nanta and the deepwater port of Munat.")}, 31,
                {cs("ZilleCampaignState.PlanType = ZillePlanType.Romulus; ZilleCampaignState.RomulusPlan = ZilleRomulusPlan.Ark; ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1; ZilleCampaignState.CurrentPhaseNumber = 1; Variable[\"Zille_War_PlanType\"] = \"Romulus\"; Variable[\"Zille_War_RomulusPlan\"] = \"GoldenArk\"; Variable[\"Zille_War_Active\"] = true;")});

            AddLine(conv, 31, LucitaId, RomusId, "Ack_Golden_Ark_Lucita",
                {cs("\"A brilliant maritime envelopment!\" Lucita smiled fiercely. \"Seizing Munat first will cut off Valdez from any Wehzek sea resupply, leaving him trapped in a pocket. The War Table is configured and waiting for your arrival to deploy Phase I!\"")}, 32);

            AddLine(conv, 32, LaurentoId, RomusId, "Ack_Golden_Ark_Laurento",
                {cs("\"Securing the port of Munat early also prevents any foreign powers from meddling under the pretext of humanitarian shipping. Godspeed to our fleet, Your Majesty.\"")}, -1);

            AddChoice(conv, 40, LucitaId, "Choice_Staff_Command",
                {cs("\"The General Staff will direct the campaign. Present the four staff doctrines for execution.\"")},
                {cs("The General Staff will direct the field execution of this war. Present your four strategic doctrines for royal selection.")}, 41,
                {cs("ZilleCampaignState.PlanType = ZillePlanType.Staff; Variable[\"Zille_War_PlanType\"] = \"Staff\";")});

            var staffHub = AddLine(conv, 41, LucitaId, RomusId, "Staff_Doctrine_Presentation",
                {cs("The General Staff stands ready, Your Majesty. Four strategic doctrines have been drawn up:\n\n  Plan Hawk: Heavy aerial strikes and artillery barrages shatter Valdez's command network before infantry advances.\n  Plan Sword: An aggressive armored charge led by House Azaro heavy divisions pushing through Wiktrany.\n  Plan Ark: A methodical maritime encirclement by the Royal Navy, starving Valdez's supply lines.\n  Plan Spear: A covert night decapitation strike by the Golden Guard and commandos against Valdez's headquarters.\n\nWhich staff doctrine do you authorize?")});

            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 42)); // Plan Hawk
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 43)); // Plan Sword
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 44)); // Plan Ark
            staffHub.outgoingLinks.Add(CreateLink(conv.id, 41, 45)); // Plan Spear

            AddChoice(conv, 42, LucitaId, "Authorize_Staff_Hawk",
                {cs("\"Authorize Plan Hawk: Shatter their forward redoubts with air and artillery power.\"")},
                {cs("I authorize Plan Hawk. Bring down our bomber wings and heavy artillery. Flatten their defensive works before our ground units advance.")}, 46,
                {cs("ZilleCampaignState.StaffPlan = ZilleStaffPlan.Hawk; Variable[\"Zille_War_StaffPlan\"] = \"Hawk\"; Variable[\"Zille_War_Active\"] = true;")});

            AddChoice(conv, 43, LucitaId, "Authorize_Staff_Sword",
                {cs("\"Authorize Plan Sword: Unleash our armored divisions in a central breakthrough.\"")},
                {cs("I authorize Plan Sword. Mass our armor and let the Azaro divisions spearhead the breakthrough into Wiktrany.")}, 46,
                {cs("ZilleCampaignState.StaffPlan = ZilleStaffPlan.Sword; Variable[\"Zille_War_StaffPlan\"] = \"Sword\"; Variable[\"Zille_War_Active\"] = true;")});

            AddChoice(conv, 44, LucitaId, "Authorize_Staff_Ark",
                {cs("\"Authorize Plan Ark: Execute a disciplined maritime blockade and coastal encirclement.\"")},
                {cs("I authorize Plan Ark. The Royal Navy will strangle Valdez's supply lines and seal the peninsula from foreign meddling.")}, 46,
                {cs("ZilleCampaignState.StaffPlan = ZilleStaffPlan.Ark; Variable[\"Zille_War_StaffPlan\"] = \"Ark\"; Variable[\"Zille_War_Active\"] = true;")});

            AddChoice(conv, 45, TitusId, "Authorize_Staff_Spear",
                {cs("\"Authorize Plan Spear: Deploy the Golden Guard and commandos to decapitate Valdez's command.\"")},
                {cs("I authorize Plan Spear. Commander Gordion, send your best operatives into Zille tonight. Decapitate Valdez's staff before the main assault begins.")}, 47,
                {cs("ZilleCampaignState.StaffPlan = ZilleStaffPlan.Spear; Variable[\"Zille_War_StaffPlan\"] = \"Spear\"; Variable[\"Zille_War_Active\"] = true;")});

            AddLine(conv, 46, LucitaId, RomusId, "Ack_Staff_Lucita",
                {cs("\"The orders are dispatched, Your Majesty! The General Staff has initiated the offensive. Our officers will report battle progress as the front develops!\"")}, -1);

            AddLine(conv, 47, TitusId, RomusId, "Ack_Staff_Titus",
                {cs("\"My guardsmen are already moving under cover of darkness, Your Majesty,\" Titus whispered with gauntleted fist against his breastplate. \"Smolak's officers will wake up in chains.\"")}, -1);

            AddChoice(conv, 50, HugoId, "Choice_Postpone_War",
                {cs("\"Hold the offensive for now. Keep our divisions at maximum readiness along the border.\"")},
                {cs("Hold the offensive for now. Keep our divisions at maximum combat readiness along the frontier, but do not cross until I give the royal command.")}, 51,
                {cs("Variable[\"Zille_War_Postpone\"] = true;")});

            AddLine(conv, 51, HugoId, RomusId, "Ack_Postpone_Hugo",
                {cs("\"A prudent and measured decision, Your Majesty. The General Staff will maintain full combat readiness along the frontier until you decide the hour is right.\"")}, -1);

            AddConversationWithAlias(db, conv, "Zille/WarCouncil_Briefing", "Turn_Zille_WarBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Council Briefing (ID 9988) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 4: Turn_Zille_MaveNortusHQ (ID 9994) - FRONTLINE HEADQUARTERS
        // Modeled on: 410_SnO_War_Pales_PostOperation1 & 385_Pales_War_Update_And_Tax
        // Taddeus Azaro, Lucita Azaro, Titus Gordion, Mayor of Mave Nortus.
        // =========================================================================
        public static void RegisterMaveNortusHQ(DialogueDatabase db)
        {{
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
                {cs("Your armored convoy rumbled through the muddy, rain-slicked streets of Mave Nortus. In the distance across the northern hills, the rhythmic thud of heavy artillery rolled like continuous thunder, rattling the windowpanes of the ancient Brenas stone houses. Sandbag bunkers lined the crossroads, and wounded soldiers resting on canvas stretchers outside the town church looked up with weary reverence as the royal standard fluttered past.")}, 2);

            AddLine(conv, 2, NarratorId, RomusId, "MaveNortus_Office_Entry",
                {cs("Inside the town hall, municipal tax ledgers had been unceremoniously shoved aside to make room for battlefield telegraphs and grease-pencil situational maps spread across the Mayor's massive oak desk. Duke Taddeus Azaro stood with his uniform jacket unbuttoned, pointing a scarred finger at the river crossings, while Councilor Lucita Azaro reviewed incoming courier dispatches.")}, 3);

            AddLine(conv, 3, TaddeusId, RomusId, "Taddeus_HQ_Greeting",
                {cs("Your Majesty! It is an honor to have our King at the front lines. The men took heart the moment the royal motorcade was spotted crossing the Brenas viaduct.")}, 4);

            AddLine(conv, 4, LucitaId, RomusId, "Lucita_HQ_Debrief_1",
                {cs("Phase I of our operation has concluded, Your Majesty. Valdez fought back tenaciously along the river dikes, but our forward brigades have successfully established our tactical bridgeheads.")}, 5);

            AddLine(conv, 5, LucitaId, RomusId, "Lucita_HQ_Debrief_2",
                {cs("However, the battle is only half won. We have captured key outer junctions, but Valdez has consolidated his surviving armor and veterans into a hardened defensive ring around Zille City itself and the coastal redoubts. We must launch Phase II to break their spine.")}, 6);

            AddLine(conv, 6, MayorBrenasId, RomusId, "Mayor_HQ_Report",
                {cs("The Mayor of Mave Nortus bowed nervously, wiping sweat from his brow. \"Your Majesty, over four thousand Rizian refugees have fled across the border from Zille in the last forty-eight hours. Smolak's retreating officers burned grain elevators behind them. Our town is doing everything possible to house and feed them, but medical supplies are running thin.\"")}, 10);

            var hqHub = AddLine(conv, 10, NarratorId, RomusId, "HQ_Hub_Prompt",
                {cs("Distant artillery rumbled once more, sending a gentle shower of plaster dust drifting down from the ceiling. You studied the situational map, ready to question your commanders.")});

            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11)); // Foreign Aid Audit
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12)); // Casualties & Morale
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 13)); // Refugee Relief Order
            hqHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // Launch Phase II Orders

            AddChoice(conv, 11, LucitaId, "Inquire_ForeignAid",
                {cs("\"What reports do we have on foreign assistance and allied support?\"")},
                {cs("Lucita, what reports do we have regarding foreign assistance? Has our international diplomacy yielded tangible aid on the battlefield?")}, 14);

            AddLine(conv, 14, LucitaId, RomusId, "Answer_ForeignAid",
                {cs("Very tangible, Your Majesty. High-resolution aerial reconnaissance photos supplied by Lespia have revealed Valdez's camouflaged artillery bunkers behind the marshlands. In addition, three trainloads of heavy 152mm artillery shells from Rumburg arrived in the Brenas depot this morning. And in the south, Derdian irregulars have raided Wehlen's border depots, forcing Valdez to divert an entire infantry regiment away from our front.")}, 10);

            AddChoice(conv, 12, TaddeusId, "Inquire_Casualties",
                {cs("\"Taddeus, how heavy are our casualties, and how is the fighting spirit of our soldiers?\"")},
                {cs("Taddeus, give me a frank assessment of our losses. How are our men holding up against Wehlen's counter-attacks?")}, 15);

            AddLine(conv, 15, TaddeusId, RomusId, "Answer_Casualties",
                {cs("We took shrapnel losses taking the river trenches, Your Majesty, but our field hospitals have performed miracles. Morale is soaring. The men know they are liberating Rizian soil, not fighting for some foreign desert. They are eager to finish the job in Zille City.")}, 10);

            AddChoice(conv, 13, MayorBrenasId, "Order_Refugee_Aid",
                {cs("\"Mayor, the Crown will fund emergency medical aid and provisions for every refugee.\"")},
                {cs("Mayor, the Crown will immediately release emergency funds and grain from the royal reserves for every refugee arriving in Mave Nortus. No Rizian fleeing Smolak will be neglected.")}, 16,
                {cs("Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] - 1; Variable[\"Zille_Refugee_Aid_Granted\"] = true;")});

            AddLine(conv, 16, MayorBrenasId, RomusId, "Ack_Refugee_Aid",
                {cs("Tears welled in the Mayor's eyes as he pressed his hand to his heart. \"God bless Your Majesty! The people of Brenas and Zille will never forget your royal mercy!\"")}, 10);

            AddChoice(conv, 20, LucitaId, "Order_Phase2_Launch",
                {cs("\"The time has come. Issue the battle orders for Phase II: Break their inner ring and capture Zille City!\"")},
                {cs("The time has come. Valdez will find no respite. Issue the battle orders for Phase II immediately. Concentrate our artillery, deploy our fresh reserves, and storm Zille City!")}, 21,
                {cs("ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2; ZilleCampaignState.CurrentPhaseNumber = 2; Variable[\"Zille_War_Phase\"] = 2;")});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Phase2_Lucita",
                {cs("Lucita smiled with fierce, cold resolution, snapping her field baton onto Zille City. \"The orders are dispatched, Your Majesty! Our armor will lead the assault at dawn. We will deliver Zille back into your royal hands!\"")}, 22);

            AddLine(conv, 22, TaddeusId, RomusId, "Ack_Phase2_Taddeus",
                {cs("Taddeus drew his saber and held it aloft in solemn tribute. \"For King and Kingdom! Glovurius axa Rizia! Forward to victory!\"")}, -1);

            AddConversationWithAlias(db, conv, "Zille/MaveNortusHQ", "Turn_Zille_MaveNortusHQ");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Mave Nortus Field HQ (ID 9994) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 5: Turn_Zille_WarBalconySpeech (ID 9989) - WAR PROCLAMATION SPEECH
        // Modeled on: 440_A_ZilleReturnedSpeech & 357_SnO_WarEruptionBriefing
        // Romus, Hugo Toras, Lucita Azaro.
        // =========================================================================
        public static void RegisterWarBalconySpeech(DialogueDatabase db)
        {{
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
                {cs("The grand double doors of the Palas Rezna balcony swung open to the roar of over forty thousand citizens packed shoulder to shoulder in the Royal Plaza. Banners of House Toras, Azaro, and Sazon fluttered in the autumn breeze. Below, brass microphones were wired to radio broadcasting trucks transmitting your voice to every household across Rizia.")}, 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Balcony_Whisper",
                {cs("Hugo leaned in, his voice barely audible beneath the roar of the crowd. \"The whole kingdom listens, Romus. Give them words worthy of a king.\"")}, 3);

            var speechHub = AddLine(conv, 3, NarratorId, RomusId, "Speech_Doctrine_Prompt",
                {cs("You stepped forward to the stone balustrade, raising your sovereign hand. A profound hush fell over the ocean of citizens.")});

            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Revanchist Might
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Liberating the Oppressed
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Sovereign Legalism

            AddChoice(conv, 10, HugoId, "Speech_Revanchist",
                {cs("\"Sons and daughters of Rizia! We march to reclaim what was stolen by force and restore the glory of our ancestors!\"")},
                {cs("Sons and daughters of Rizia! For thirty years, our kingdom has borne the sting of humiliation in silence. But House Toras does not bow to tyrants! Today, the Royal Army marches to reclaim our sovereign soil and restore the imperial dignity of our kingdom!")}, 11,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Revanchist\"; Variable[\"RiziaDLC.Situation_Order_Nationalist_Happy\"] = true;")});

            AddLine(conv, 11, NarratorId, RomusId, "Speech_Revanchist_Reaction",
                {cs("A thunderous roar erupted from the crowd, bayonets flashing in the sun as soldiers raised their rifles in salute. Hugo nodded approvingly, his chest swelling with dynastic pride.")}, -1);

            AddChoice(conv, 20, HugoId, "Speech_Liberation",
                {cs("\"We come not as conquerors, but as liberators to free our brothers and sisters from Smolak's tyranny!\"")},
                {cs("People of Rizia! We cross the border not out of hatred, but out of sacred love for our brothers and sisters in Zille who have suffered under the yoke of Smolak's secret police. We march to bring them home to their true kingdom!")}, 21,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Liberation\"; Variable[\"RiziaDLC.Situation_Order_Reformist_Happy\"] = true;")});

            AddLine(conv, 21, NarratorId, RomusId, "Speech_Liberation_Reaction",
                {cs("Tears flowed freely among the elder citizens in the crowd, and chants of 'Long live Romus the Liberator!' resonated throughout the ancient plaza.")}, -1);

            AddChoice(conv, 30, HugoId, "Speech_Legalist",
                {cs("\"The 1929 lease has expired. We uphold international law where Wehlen has trampled it!\"")},
                {cs("Citizens of Rizia and observers across Merkopa. Rizia is a realm of honor and constitutional order. The 1929 lease has expired. In reclaiming Zille, we enforce the sacred rule of law that Wiktor Smolak has trampled underfoot!")}, 31,
                {cs("Variable[\"Zille_Speech_Tone\"] = \"Legalist\"; Variable[\"RiziaDLC.Situation_Diplomacy_AN_Favorable\"] = true;")});

            AddLine(conv, 31, NarratorId, RomusId, "Speech_Legalist_Reaction",
                {cs("Foreign correspondents frantically scribbled notes, while the crowd applauded with deep, dignified respect for the Crown's measured authority.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/WarBalconySpeech", "Turn_Zille_WarBalconySpeech");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected War Balcony Proclamation (ID 9989) into masterDatabase!");
        }}
    }}
}}
'''
    with open('src/GreatZilleSolution/ZilleDialogueSystem.WarScenes.cs', 'w', encoding='utf-8') as f:
        f.write(code)
    print("Successfully built src/GreatZilleSolution/ZilleDialogueSystem.WarScenes.cs")

def generate_diplomacy_scenes():
    code = f'''using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{{
    public static partial class ZilleDialogueSystem
    {{
        // =========================================================================
        // SCENE 6: Turn_Zille_DerdiaTalks (ID 9995) - TALKS WITH DERDIA
        // Modeled on: 377_FPnT_DerdiaNegotiations, 436_Morella_Derdia_Mediation
        // Grand Wiseman Jorga Azmal, Titus Gordion, Archpriest Sal Ignacius.
        // =========================================================================
        public static void RegisterDerdiaTalks(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_DerdiaTalks") != null && db.GetConversation("Zille/DerdiaTalks") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_DerdiaTalks;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/DerdiaTalks";
            conv.ActorID = RomusId;
            conv.ConversantID = AzmalId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, AzmalId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Derdia_Intro_1",
                {cs("The private royal telecommunications chamber was heavy with the aroma of burning sandalwood and frankincense. On the encrypted high-frequency transceiver from Ozkaban, the resonant, gravelly voice of Grand Wiseman Jorga Azmal cut through the static with solemn majesty.")}, 2);

            AddLine(conv, 2, AzmalId, RomusId, "Azmal_Opening_Greeting",
                {cs("Peace and the fire of Saint Dast be upon you, King Romus of Rizia. The desert winds carry whispers of iron and smoke rising from the southern frontier. You prepare to strike the butcher of Wehlen, do you not?")}, 3);

            var azmalHub = AddLine(conv, 3, RomusId, AzmalId, "Romus_Azmal_Open_Prompt",
                {cs("I leaned toward the gilded receiver, measuring my words before the spiritual leader of Derdia.")});

            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Appeal to shared faith & justice
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Pragmatic military alliance
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Question Azmal's motives

            AddChoice(conv, 10, AzmalId, "Choice_Faith_Justice",
                {cs("\"Smolak has desecrated our sacred heritage and persecuted our Nurist brothers in Zille. Justice demands action.\"")},
                {cs("Smolak has desecrated our ancient sacred heritage and tormented the faithful of Zille for thirty years. Justice and faith demand that the sword be drawn against him.")}, 20,
                {cs("Variable[\"Derdia_Romus_Faithful\"] = true;")});

            AddChoice(conv, 11, AzmalId, "Choice_Military_Pragmatism",
                {cs("\"Wehlen is our common adversary. A coordinated strike will break his stranglehold on both our borders.\"")},
                {cs("Wehlen is our common adversary, Wiseman Azmal. If Rizia strikes from the north and Derdia applies pressure from the south, Smolak's military apparatus will shatter under two fronts.")}, 20,
                {cs("Variable[\"Derdia_Romus_Pragmatic\"] = true;")});

            AddChoice(conv, 12, AzmalId, "Choice_Question_Motives",
                {cs("\"What interest does Derdia possess in the liberation of Zille?\"")},
                {cs("What interest does Derdia possess in the outcome of our conflict in Zille, Wiseman? Speak plainly.")}, 20,
                {cs("Variable[\"Derdia_Romus_Cautious\"] = true;")});

            AddLine(conv, 20, AzmalId, RomusId, "Azmal_Theological_Stakes",
                {cs("Know this, O King: on the eastern hills of Zille stands the ancient Sanctuary of the Martyr's Tear-a holy site revered by Golcondist pilgrims long before your ancestors forged the Crown of Rizia. For three decades, Smolak's thugs have extorted, beaten, and murdered our pilgrims seeking salvation at that shrine.")}, 21);

            AddLine(conv, 21, AzmalId, RomusId, "Azmal_Offer_Proposal",
                {cs("If you pledge by your royal honor to protect the Golcondist faithful, to exempt our pilgrims from taxes, and to grant Derdia religious sanctuary in Zille, then three thousand holy irregulars and mountain scouts will cross Wehlen's southern border tonight. They will cut telegraph cables, burn Valdez's ammunition depots, and tie down his southern brigades in blood and fire!")}, 22);

            AddLine(conv, 22, SalId, RomusId, "Sal_Ignacius_Warning",
                {cs("Archpriest Sal Ignacius leaned in, clutching his golden Wruhecist pectoral cross. \"Your Majesty, tread cautiously! Granting religious concessions to Golcondist zealots in Zille will cause profound outrage among the orthodox priests of Iza and the High Clergy!\"")}, 23);

            AddLine(conv, 23, TitusId, RomusId, "Titus_Tactical_Perspective",
                {cs("Titus Gordion stepped forward respectfully. \"From a military standpoint, Your Majesty, Derdian guerrilla sabotage in Valdez's rear would divert enemy reserves and grant our armored columns invaluable operational tempo.\"")}, 30);

            var pactHub = AddLine(conv, 30, NarratorId, RomusId, "Derdia_Pact_Hub_Prompt",
                {cs("Wiseman Azmal awaited your verdict on the holy transceiver, the faint chanting of Derdian monks audible across the wires.")});

            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Holy Coalition
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Pragmatic Compromise
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject Faith Interference

            AddChoice(conv, 40, AzmalId, "Accept_Holy_Coalition",
                {cs("\"I swear by Saint Dast: The Sanctuary shall be protected, and Golcondist pilgrims shall walk unmolested in Zille.\"")},
                {cs("I swear by Saint Dast and my royal honor: The Sanctuary of the Martyr's Tear shall be protected under the Crown's direct aegis, and Golcondist pilgrims will enjoy total freedom of worship in liberated Zille. Let your holy fighters strike!")}, 41,
                {cs("ZilleCampaignState.IsDerdiaHybridSupportActive = true; Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] = Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] + 2;")});

            AddLine(conv, 41, AzmalId, RomusId, "Ack_Holy_Coalition",
                {cs("Azmal's voice rose with ecstatic thunder over the receiver. \"Halaita! The righteous blood shall flow, and the chains of the tyrant shall be severed! My irregulars are unleashed. May the fiery sun guide your royal swords, King Romus!\"")}, 42);

            AddLine(conv, 42, SalId, RomusId, "Sal_Derdia_Grumble",
                {cs("Archpriest Sal muttered a sullen prayer, crossing himself with tight lips. \"May Saint Wruhec forgive this unholy alliance for the sake of our kingdom's borders...\"")}, -1);

            AddChoice(conv, 50, AzmalId, "Counter_Pragmatic_Derdia",
                {cs("\"I offer economic passage and trade protections for pilgrims, but no special theological privileges.\"")},
                {cs("I can guarantee safe commercial passage and police protection for all foreign travelers, including Golcondists, but I will not grant extraterritorial religious privileges that divide our kingdom. Let us strike Smolak as sovereign allies.")}, 51,
                {cs("ZilleCampaignState.IsDerdiaHybridSupportActive = true; Variable[\"Zille_DerdiaHybridActive\"] = true;")});

            AddLine(conv, 51, AzmalId, RomusId, "Ack_Pragmatic_Derdia",
                {cs("Azmal paused in contemplation before sighing heavily. \"You speak with the cautious tongue of a king rather than a prophet, Romus. Yet our hatred for Smolak burns brighter than our disappointment. Our desert scouts will raid his supply lines. But remember our people when the city is yours.\"")}, -1);

            AddChoice(conv, 60, AzmalId, "Reject_Derdia_Demands",
                {cs("\"Rizia fights under the banner of Saint Wruhec alone. We will not barter our sovereign faith for guerrilla raiders.\"")},
                {cs("Rizia marches under the holy banner of Saint Wruhec and the divine authority of House Toras. We will not barter our church's orthodoxy for tribal raiders. Keep your holy fighters in the desert, Wiseman Azmal.")}, 61,
                {cs("ZilleCampaignState.IsDerdiaHybridSupportActive = false; Variable[\"RiziaDLC.CountryRelation_Derdia_Unfriendly\"] = true;")});

            AddLine(conv, 61, AzmalId, RomusId, "Ack_Reject_Derdia",
                {cs("Static hissed fiercely as Azmal's tone turned frigid and harsh. \"Then choke on your arrogant pride, King of Rizia! When Smolak's bullets pierce your royal armor, do not cry out to the sands for salvation!\" The line severed with a violent snap.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/DerdiaTalks", "Turn_Zille_DerdiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Derdia Talks (ID 9995) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 7: Turn_Zille_LespiaTalks (ID 9996) - NEGOTIATIONS WITH LESPIA
        // Modeled on: 314_FPnT_AlvarezCall, 423_FPnT_AlvarezVisit
        // Romus, Patricio Alvarez, Laurento Esquibel.
        // =========================================================================
        public static void RegisterLespiaTalks(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_LespiaTalks") != null && db.GetConversation("Zille/LespiaTalks") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_LespiaTalks;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/LespiaTalks";
            conv.ActorID = RomusId;
            conv.ConversantID = AlvarezId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, AlvarezId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Lespia_Intro_1",
                {cs("The red secure hotline to Porte Lespia clicked alive with the unmistakable clink of ice cubes against fine crystal glass, followed by a theatrical cough and a satisfied exhale of cigar smoke.")}, 2);

            AddLine(conv, 2, AlvarezId, RomusId, "Alvarez_Opening_Banter",
                {cs("Romus! My dear friend! Or should I say... His Imperial Majesty, Conqueror of the South? Don't tell me you called to invite me to another stuffy royal opera. I hear through certain Arcasian channels that you're about to give that mustachioed clown Smolak the thrashing he's had coming for thirty years!")}, 3);

            var alvarezHub = AddLine(conv, 3, RomusId, AlvarezId, "Romus_Alvarez_Open_Prompt",
                {cs("I leaned against the console, matching Alvarez's relaxed tempo while keeping my guard up.")});

            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Sarcastic parity
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Straight to business
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Diplomatic pressure

            AddChoice(conv, 10, AlvarezId, "Banter_Sarcastic",
                {cs("\"Enjoying your afternoon rum, Patricio? I thought you might appreciate seeing Wehlen's teeth kicked in.\"")},
                {cs("Enjoying your afternoon rum, Patricio? I assumed you might appreciate watching someone finally kick Wehlen's teeth in.")}, 20);

            AddChoice(conv, 11, AlvarezId, "Banter_Business",
                {cs("\"Let us skip the theatrics, President Alvarez. We both know why this line was opened.\"")},
                {cs("Let us skip the theatrics, President Alvarez. We both know why this hotline was opened. Let us talk about intelligence and border security.")}, 20);

            AddChoice(conv, 12, AlvarezId, "Banter_Pressure",
                {cs("\"Wehlen is destabilizing the entire region. Lespia has a direct economic stake in our success.\"")},
                {cs("Wehlen's bandit state destabilizes the entire regional economy. If Smolak controls Zille indefinitely, your shipping corridors in the Gulf are at his mercy.")}, 20);

            AddLine(conv, 20, AlvarezId, RomusId, "Alvarez_Business_Pitch",
                {cs("Alvarez took another sip, his tone shifting from jovial drunkard to sharp capitalist shark. \"Look, Romus, I won't shed a single tear if Valdez's goons end up feeding the desert buzzards. But Lespia isn't a charity foundation. You want our high-altitude ATO surveillance planes to map Valdez's camouflaged trenches, and you want Arcasian encrypted radios so your tanks don't drive into an ambush.\"")}, 21);

            AddLine(conv, 21, AlvarezId, RomusId, "Alvarez_Price_Demand",
                {cs("\"Here is my price: 20% guaranteed crude oil delivery contracts from your southern wells to Lespian refineries at discounted rates, PLUS your royal vote backing Lespia's positions at the upcoming MITZ maritime summit. Do that, and my defense ministry will feed your generals live radar coordinates that will let your artillery blow Valdez's command bunkers straight into orbit.\"")}, 22);

            AddLine(conv, 22, LaurentoId, RomusId, "Laurento_Alvarez_Evaluation",
                {cs("Laurento leaned close to the receiver, speaking in a low, measured whisper. \"Your Majesty, Alvarez's terms are extortionate on oil, but ATO radar reconnaissance would drastically reduce our combat casualties and grant our staff total battlefield clarity. We can negotiate him down if we leverage regional stability.\"")}, 30);

            var dealHub = AddLine(conv, 30, NarratorId, RomusId, "Alvarez_Deal_Hub_Prompt",
                {cs("Alvarez swirled the ice in his glass, awaiting your counter-offer.")});

            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Alvarez terms
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Hard bargain / Outsmart
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject Lespian greed

            AddChoice(conv, 40, AlvarezId, "Accept_Alvarez_Pact",
                {cs("\"Agreed. Lespia gets preferential oil deliveries in exchange for total ATO satellite and radar intelligence.\"")},
                {cs("Agreed, Patricio. We will guarantee your oil deliveries at favorable terms, provided your defense ministry delivers uninterrupted satellite surveillance and radar intelligence to my war room.")}, 41,
                {cs("ZilleCampaignState.IsLespiaPactAccepted = true; ZilleCampaignState.IsLespiaIntelActive = true; Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.CountryRelation_Lespia_Allied\"] = true;")});

            AddLine(conv, 41, AlvarezId, RomusId, "Ack_Alvarez_Pact",
                {cs("Alvarez burst into a hearty laugh, clinking his glass against the receiver. \"Now that is what I call statesmanship! Consider it done, Romus. Our reconnaissance flights are taking off from Porte Lespia as we speak. Happy hunting in Zille!\"")}, -1);

            AddChoice(conv, 50, AlvarezId, "Hard_Bargain_Alvarez",
                {cs("\"Ten percent oil contracts, and not a single concession on MITZ. Take it, or we conduct the campaign without you.\"")},
                {cs("Ten percent oil contracts on standard commercial terms, and not a single sovereign concession on the MITZ. Take it or leave it, Patricio. If Rizia liberates Zille alone, your leverage in the south evaporates entirely.")}, 51,
                {cs("ZilleCampaignState.IsLespiaPactAccepted = true; ZilleCampaignState.IsLespiaIntelActive = true; Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] = Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] - 1;")});

            AddLine(conv, 51, AlvarezId, RomusId, "Ack_Hard_Bargain",
                {cs("Alvarez cursed under his breath in colloquial Lespian before letting out an amused grunt. \"You drive a harder bargain than your father ever did, Your Majesty. Fine! Ten percent it is. The radar frequencies will be in your war room within the hour.\"")}, -1);

            AddChoice(conv, 60, AlvarezId, "Reject_Alvarez_Greed",
                {cs("\"Rizian blood will not be bartered for Lespian corporate profits. We will reclaim Zille on our own terms.\"")},
                {cs("Rizian soldiers will not bleed to line the pockets of your oil oligarchs, President Alvarez. The Royal Army does not require Lespian charity to defeat Wehlen. Good day.")}, 61,
                {cs("ZilleCampaignState.IsLespiaPactAccepted = false; ZilleCampaignState.IsLespiaIntelActive = false; Variable[\"RiziaDLC.CountryRelation_Lespia_Unfriendly\"] = true;")});

            AddLine(conv, 61, AlvarezId, RomusId, "Ack_Reject_Lespia",
                {cs("Alvarez's amusement vanished instantly into cold diplomatic venom. \"Then good luck against Valdez's mines and artillery, Romus. Don't come crawling back to Kyrute when your tanks are burning in the mud.\" The line went dead.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/LespiaTalks", "Turn_Zille_LespiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Lespia Talks (ID 9996) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 8: Turn_Zille_RumburgTalks (ID 9997) - ROYAL HOTLINE WITH RUMBURG
        // Modeled on: 305_FPnT_QueenBeatriceVisit, 389_FPnT_RumburgMeeting, 433_FPnT_GRACERumburgMeeting
        // Romus, Queen Beatrice Livingston, Hugo Toras, Laurento Esquibel.
        // =========================================================================
        public static void RegisterRumburgTalks(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_RumburgTalks") != null && db.GetConversation("Zille/RumburgTalks") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_RumburgTalks;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/RumburgTalks";
            conv.ActorID = RomusId;
            conv.ConversantID = BeatriceId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, BeatriceId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Rumburg_Intro_1",
                {cs("The brass-and-ivory royal trunk line to Thornbourgh buzzed with crystal clarity. Across two thousand miles of cable, the poised, commanding voice of Queen Beatrice Livingston echoed into the private study, carrying the unmistakable weight of the Imperial House of Livingston.")}, 2);

            AddLine(conv, 2, BeatriceId, RomusId, "Beatrice_Royal_Greeting",
                {cs("Cousin Romus. We in Thornbourgh have followed your confrontation with the Wehzek upstart with keen imperial interest. A monarch cannot permit a petty dictator to mock the sovereign honor of our noble houses.")}, 3);

            var beatriceHub = AddLine(conv, 3, RomusId, BeatriceId, "Romus_Beatrice_Open_Prompt",
                {cs("I straightened my tunic, addressing my imperial cousin with the dignified courtesy expected between royal houses.")});

            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Royal cousin solidarity
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Request heavy munitions
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Assert sovereign independence

            AddChoice(conv, 10, BeatriceId, "Solidarity_Royal",
                {cs("\"Cousin Beatrice. House Toras stands proud, and we are determined to restore our rightful borders.\"")},
                {cs("Cousin Beatrice. It is an honor to speak with you. House Toras stands resolute. Thirty years of Wehzek insolence will be answered with royal steel.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Loyal\"] = true;")});

            AddChoice(conv, 11, BeatriceId, "Munitions_Request",
                {cs("\"Your Majesty, Rizia requires heavy artillery shells and diplomatic shielding in the Alliance of Nations.\"")},
                {cs("Your Majesty. Rizia's cause is just, but our campaign requires heavy caliber munitions and strong diplomatic shielding in the Alliance of Nations against Contanan interference.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Munitions\"] = true;")});

            AddChoice(conv, 12, BeatriceId, "Sovereign_Assertive",
                {cs("\"We will resolve this conflict ourselves, but GRACE solidarity would be welcomed.\"")},
                {cs("Rizia will fight and win this campaign with our own blood, but solidarity among the monarchies of GRACE will show the world that our bloc remains indomitable.")}, 20,
                {cs("Variable[\"Rumburg_Romus_Proud\"] = true;")});

            AddLine(conv, 20, BeatriceId, RomusId, "Beatrice_Imperial_Offer",
                {cs("You speak like a true sovereign, Romus. Rumburg will not stand idly by while republican rabble threatens an imperial crown. We have already instructed our naval attachés to monitor maritime traffic in the Gulf, and three dedicated freight trains carrying 152mm heavy artillery munitions from our royal arsenals are currently en route to the Brenas railyards.")}, 21);

            AddLine(conv, 21, BeatriceId, RomusId, "Beatrice_AN_Pledge",
                {cs("Furthermore, our ambassador in Kyrute will wield Rumburg's full diplomatic weight in the Alliance of Nations to veto any punitive resolutions Malenyev or Hegel attempt to pass against Rizia. We ask only one thing in return: that Rizia remains an unyielding bulwark of GRACE, keeping ATO and Arcasian meddlers far from your royal court.")}, 22);

            AddLine(conv, 22, HugoId, RomusId, "Hugo_Beatrice_Support",
                {cs("Hugo nodded with profound reverence, dabbing a tear from his eye. \"A magnificent demonstration of royal fraternity! With Rumburg's heavy shells and diplomatic shield, Smolak stands utterly abandoned by the civilized world.\"")}, 30);

            var responseHub = AddLine(conv, 30, NarratorId, RomusId, "Beatrice_Response_Prompt",
                {cs("Queen Beatrice waited with quiet imperial authority for your royal acknowledgment.")});

            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Pledge GRACE Solidarity
            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Grateful but Sovereign

            AddChoice(conv, 40, BeatriceId, "Pledge_GRACE_Solidarity",
                {cs("\"House Toras pledges unwavering loyalty to GRACE. Together, our crowns will triumph.\"")},
                {cs("House Toras pledges unwavering solidarity to the Imperial Crown and the GRACE alliance. Together, our royal crowns will demonstrate that monarchical order will always triumph over republican chaos. Thank you, Cousin Beatrice.")}, 41,
                {cs("ZilleCampaignState.IsRumburgMunitionsActive = true; Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Allied\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = Variable[\"RiziaDLC.Resources_Military_Equipment\"] + 2;")});

            AddLine(conv, 41, BeatriceId, RomusId, "Ack_Beatrice_Pledge",
                {cs("Beatrice smiled with imperious satisfaction. \"Splendid, Romus. Smolak will learn the price of defying imperial blood. Go forth and claim your victory. Thornbourgh stands with you.\"")}, -1);

            AddChoice(conv, 50, BeatriceId, "Grateful_Sovereign",
                {cs("\"We accept your munitions with royal gratitude, Cousin. Rizia will remember who stood by us in our hour of need.\"")},
                {cs("We accept your heavy munitions and diplomatic backing with deep gratitude, Cousin. Rizia will always remember who stood by our side in our hour of need. May Saint Wruhec watch over both our realms.")}, 51,
                {cs("ZilleCampaignState.IsRumburgMunitionsActive = true; Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Friendly\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = Variable[\"RiziaDLC.Resources_Military_Equipment\"] + 1;")});

            AddLine(conv, 51, BeatriceId, RomusId, "Ack_Beatrice_Sovereign",
                {cs("\"May victory crown your banners, Romus. We expect a triumphant report when Zille is once more Rizian.\" The imperial line softly disconnected.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/RumburgTalks", "Turn_Zille_RumburgTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Rumburg Talks (ID 9997) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 9: Turn_Zille_WarPreNegotiationsBriefing (ID 9991) - PRE-NEGOTIATIONS
        // Romus, Hugo Toras, Lucita Azaro, Laurento Esquibel, Elena Werner.
        // =========================================================================
        public static void RegisterWarPreNegotiationsBriefing(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarPreNegotiationsBriefing") != null && db.GetConversation("Zille/WarPreNegotiationsBriefing") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPreNegotiations;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarPreNegotiationsBriefing";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "PreNeg_Intro_1",
                {cs("The battlefield guns had fallen eerily silent along the smoke-shrouded river valley. In the War Room, courier dispatches were piled high alongside telegrams from Kyrute and foreign capitals. Smolak had dispatched a military envoy under a white flag proposing an emergency face-to-face parley.")}, 2);

            AddLine(conv, 2, LucitaId, RomusId, "Lucita_PreNeg_Report",
                {cs("Your Majesty. The fighting has paused along the frontline. Smolak's armored regiments are bloodied and broken, but our own divisions have spent enormous ammunition reserves. Smolak's envoy awaits our response at the neutral border pavilion.")}, 3);

            AddLine(conv, 3, LaurentoId, RomusId, "Laurento_PreNeg_Warning",
                {cs("The Alliance of Nations has issued an urgent ceasefire appeal, Your Majesty. Both superpowers are watching. If we negotiate from our position of strength, we can extract total territorial restoration without facing crippling sanctions.")}, 4);

            AddLine(conv, 4, HugoId, RomusId, "Hugo_PreNeg_Counsel",
                {cs("Romus... Remember who Smolak is. He is a cornered wolf. He will try to bluster, joke, and wheedle his way out of defeat. Do not give him an inch of Rizian dignity.")}, 10);

            var preNegHub = AddLine(conv, 10, RomusId, LucitaId, "Romus_PreNeg_Prompt",
                {cs("I looked at the map showing our battle lines across Zille. The time had come to face Wiktor Smolak in person.")});

            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // March to parley with strength
            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 21)); // Demanding unconditional surrender

            AddChoice(conv, 20, LucitaId, "Choice_Parley_Strength",
                {cs("\"Prepare the royal motorcade. I will meet Smolak and dictate our terms under the royal standard.\"")},
                {cs("Prepare the royal armored motorcade. Lucita, assemble the Golden Guard and forward commanders. I will meet Smolak at the border pavilion and dictate our sovereign terms face to face.")}, 22,
                {cs("Variable[\"Zille_Parley_Ready\"] = true;")});

            AddChoice(conv, 21, LucitaId, "Choice_Unconditional_Surrender",
                {cs("\"Smolak will sign a complete evacuation, or my artillery will resume shelling his palace.\"")},
                {cs("Inform Smolak that if he comes to barter or stall, our artillery will resume firing within the hour. Nothing less than total evacuation of Zille will be accepted.")}, 22,
                {cs("Variable[\"Zille_Parley_Ready\"] = true; Variable[\"Zille_Parley_Uncompromising\"] = true;")});

            AddLine(conv, 22, LucitaId, RomusId, "Ack_PreNeg_Lucita",
                {cs("Lucita strapped on her sidearm and saluted with iron resolve. \"The royal escort is mounted, Your Majesty. Let us bring this tyrant to his knees.\"")}, -1);

            AddConversationWithAlias(db, conv, "Zille/WarPreNegotiationsBriefing", "Turn_Zille_WarPreNegotiationsBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Pre-Negotiations Briefing (ID 9991) into masterDatabase!");
        }}
    }}
}}
'''
    with open('src/GreatZilleSolution/ZilleDialogueSystem.DiplomacyScenes.cs', 'w', encoding='utf-8') as f:
        f.write(code)
    print("Successfully built src/GreatZilleSolution/ZilleDialogueSystem.DiplomacyScenes.cs")

def generate_treaty_scenes():
    code = f'''using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{{
    public static partial class ZilleDialogueSystem
    {{
        // =========================================================================
        // SCENE 10: Turn_Zille_WarSmolakFinalParley (ID 9992) - SMOLAK PARLEY
        // Modeled on: 354_War_Pales_PeaceTreaty, 330_War_Pales_Loss, 424_FPnT_ZilleNegotiations
        // Romus, Wiktor Smolak, Lucita Azaro, Titus Gordion.
        // =========================================================================
        public static void RegisterWarSmolakFinalParley(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarSmolakFinalParley") != null && db.GetConversation("Zille/WarSmolakFinalParley") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarSmolakParley;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarSmolakFinalParley";
            conv.ActorID = RomusId;
            conv.ConversantID = SmolakId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, SmolakId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Smolak_Parley_Intro",
                {cs("The neutral pavilion stood on a muddy rise between the frontline trenches, draped in white flags that snapped in the wind. Outside, heavily armed Golden Guards in gilded armor stood eye-to-eye with Wehzek Republican Guards wielding submachine guns. Through the canvas flap, Wiktor Smolak sat slumped in a field chair, pouring bitter black tea into a tin cup, a half-smoked cigarette dangling from his lips.")}, 2);

            AddLine(conv, 2, SmolakId, RomusId, "Smolak_Parley_Greeting",
                {cs("Look who finally decided to join me! The great King Romus of Rizia in the flesh. Tell me, King... Do you like the tea? It's Wehzek chicory blend. Tastes like gunpowder and mud, but it keeps a man alive when the shells are falling.")}, 3);

            var parleyHub = AddLine(conv, 3, RomusId, SmolakId, "Romus_Parley_Posture_Prompt",
                {cs("I sat across the scarred folding table, looking into the bloodshot, cynical eyes of the dictator.")});

            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive / Victorious posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Pragmatic / Stalemate posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Cold defiance

            AddChoice(conv, 10, SmolakId, "Posture_Victor",
                {cs("\"Your army is shattered, Smolak. Sign the capitulation and evacuate Zille today.\"")},
                {cs("Your garrisons are surrounded and your supply lines severed, Smolak. We are not here to drink tea. Sign the capitulation agreement and order your remaining troops to vacate Zille today.")}, 100);

            AddChoice(conv, 20, SmolakId, "Posture_Stalemate",
                {cs("\"Both our armies have bled enough. Let us discuss how this war ends.\"")},
                {cs("Both our nations have bled enough into this dirt, Smolak. If this slaughter continues, neither of us will have an economy left. Let us discuss terms for an end to hostilities.")}, 200);

            AddChoice(conv, 30, SmolakId, "Posture_Defiant",
                {cs("\"You brought this war upon yourself when you thought you could extort House Toras.\"")},
                {cs("You brought this destruction upon Wehlen when you thought you could extort House Toras and steal Rizian soil. Every drop of blood spilled rests squarely on your head.")}, 100);

            // ================= BRANCH A: DECISIVE VICTORY / OVERWHELMING TRIUMPH =================
            AddLine(conv, 100, SmolakId, RomusId, "Smolak_Defeated_Rant",
                {cs("Smolak ground his cigarette into the dirt beneath his boot, his hands trembling with suppressed fury. \"You think you've won, Romus? You think waving a piece of paper makes you a hero?! Fine! Valdez is a fool, and my generals couldn't fight their way out of a paper bag!\"")}, 101);

            AddLine(conv, 101, SmolakId, RomusId, "Smolak_Defeated_Terms",
                {cs("\"Take Zille! Take your precious desert and your crumbling shrines! But Wehlen will not pay a single coin of reparations! Let my surviving boys march home across the river with their rifles, and I will sign your damned treaty.\"")}, 102);

            var victoryChoiceHub = AddLine(conv, 102, NarratorId, RomusId, "Victory_Terms_Prompt",
                {cs("Smolak leaned across the table, cornered, desperate, yet stubbornly bargaining for survival.")});

            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 110)); // Total Decisive Victory
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 120)); // Overwhelming Triumph (Demand Reparations)

            AddChoice(conv, 110, SmolakId, "Accept_Decisive_Surrender",
                {cs("\"Zille returns unconditionally to Rizia. Your surviving troops may withdraw across the river.\"")},
                {cs("Zille returns unconditionally to the Crown of Rizia, effective immediately. Your surviving garrisons may withdraw across the river under white flags. But if a single Wehzek soldier sets foot in Zille again, it will be treated as an act of war.")}, 111,
                {cs("ZilleCampaignState.Outcome = ZilleWarOutcome.DecisiveVictory; Variable[\"Zille_War_Outcome\"] = 4; Variable[\"ZilleReturn_Success\"] = true;")});

            AddLine(conv, 111, SmolakId, RomusId, "Smolak_Signs_Decisive",
                {cs("Smolak snatched the pen, scribbling his signature with vicious, jagged strokes before throwing it onto the parchment. \"Done! Pack your bags, boys, we're leaving the King's playground! I hope you choke on the sand, Romus!\"")}, -1);

            AddChoice(conv, 120, SmolakId, "Demand_Overwhelming_Triumph",
                {cs("\"Not enough. You will cede Zille, pay massive war indemnities, and demilitarize the border!\"")},
                {cs("Not enough, Smolak. Our tanks are already positioned to advance on Port Rotsla. You will cede Zille, pay four hundred million in gold and fuel reparations, and demilitarize your southern frontier. Sign, or our armor rolls into Wehlen proper!")}, 121,
                {cs("ZilleCampaignState.Outcome = ZilleWarOutcome.OverwhelmingTriumph; Variable[\"Zille_War_Outcome\"] = 5; Variable[\"ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] + 4; Variable[\"RiziaDLC.Resources_Energy\"] = Variable[\"RiziaDLC.Resources_Energy\"] + 3;")});

            AddLine(conv, 121, SmolakId, RomusId, "Smolak_Signs_Overwhelming",
                {cs("Smolak turned ashen, his bravado evaporating into sheer panic as he looked at the maps. \"You're insane... You're a madman, Romus! But... damn you. I will sign. Just stop your tanks! Rotsla must remain Wehzek!\" He signed with shaking hands.")}, -1);

            // ================= BRANCH B: BLOODY STALEMATE & INDEPENDENT ZILLE BUFFER =================
            AddLine(conv, 200, SmolakId, RomusId, "Smolak_Stalemate_Opening",
                {cs("Smolak took a deep drag of his cigarette, blowing gray smoke toward the canvas roof. \"Neither of us can push the other into the sea, Romus. Your tanks stalled outside Zille City, and my boys can't take Brenas. We can keep feeding young men into artillery fire until Kyrute puts us both in chains... or we can be clever.\"")}, 201);

            AddLine(conv, 201, SmolakId, RomusId, "Smolak_Buffer_Proposal",
                {cs("\"Here is my proposal: An Independent Zille. Neither Rizia nor Wehlen. A demilitarized neutral buffer state, governed by a joint civilian council, with guaranteed oil transit rights for both our nations. The world will call us peacemakers, and neither of us looks like a loser. What do you say, King?\"")}, 202);

            var stalemateHub = AddLine(conv, 202, NarratorId, RomusId, "Stalemate_Hub_Prompt",
                {cs("Lucita frowned with deep skepticism, while Smolak watched your eyes like a poker player staking his final hand.")});

            stalemateHub.outgoingLinks.Add(CreateLink(conv.id, 202, 210)); // Accept Independent Zille Buffer
            stalemateHub.outgoingLinks.Add(CreateLink(conv.id, 202, 220)); // Reject Buffer & Enforce Ceasefire

            AddChoice(conv, 210, SmolakId, "Accept_Independent_Buffer",
                {cs("\"Agreed. Zille shall become an Independent Neutral Buffer State under international guarantee.\"")},
                {cs("An Independent Neutral Zille. It brings peace, preserves our economy, and permanently separates our borders from Wehlen. I accept. Let the Alliance of Nations ratify the neutral charter.")}, 211,
                {cs("ZilleCampaignState.Outcome = ZilleWarOutcome.BloodyStalemate; ZilleCampaignState.IsIndependentZilleAgreed = true; Variable[\"Zille_War_Outcome\"] = 3; Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"ZilleReturn_Success\"] = false;")});

            AddLine(conv, 211, SmolakId, RomusId, "Smolak_Buffer_Signed",
                {cs("Smolak smiled, a genuine glint of respect in his tired eyes as he clinked his tin cup against your glass. \"A statesman's compromise, Romus. Let the bureaucrats in Kyrute write the declarations. The war is over.\"")}, -1);

            AddChoice(conv, 220, SmolakId, "Reject_Buffer_Ceasefire",
                {cs("\"Never. Zille is Rizian or nothing. We freeze the frontlines under an armed ceasefire.\"")},
                {cs("Zille has been Rizian for centuries; I will never recognize an artificial republic carved out of our historical soil. We freeze the lines under an armed ceasefire. But do not deceive yourself: this dispute is not over.")}, 221,
                {cs("ZilleCampaignState.Outcome = ZilleWarOutcome.TacticalDefeat; Variable[\"Zille_War_Outcome\"] = 2; Variable[\"ZilleReturn_Success\"] = false;")});

            AddLine(conv, 221, SmolakId, RomusId, "Smolak_Ceasefire_Signed",
                {cs("Smolak snorted, flicking his cigarette butt into the mud. \"Suit yourself, King. An armed truce it is. Just make sure your border guards keep their fingers off their triggers.\"")}, -1);

            AddConversationWithAlias(db, conv, "Zille/WarSmolakFinalParley", "Turn_Zille_WarSmolakFinalParley");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Smolak Final Parley (ID 9992) into masterDatabase!");
        }}

        // =========================================================================
        // SCENE 11: Turn_Zille_WarPeaceTreaty (ID 9993) - PEACE TREATY CEREMONY
        // Modeled on: 354_War_Pales_PeaceTreaty, 333_War_Pales_VictoryParade
        // Romus, Hugo Toras, Lucita Azaro, Elena Werner, Laurento Esquibel.
        // =========================================================================
        public static void RegisterWarPeaceTreaty(DialogueDatabase db)
        {{
            if (db.GetConversation("Turn_Zille_WarPeaceTreaty") != null && db.GetConversation("Zille/WarPeaceTreaty") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPeaceTreaty;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarPeaceTreaty";
            conv.ActorID = RomusId;
            conv.ConversantID = HugoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, HugoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Treaty_Ceremony_Intro",
                {cs("The Grand Throne Room of Palas Rezna had been arranged for the formal ratification of the Treaty of Zille. Foreign ambassadors, military generals, and provincial nobles lined the marble hall beneath the golden portraits of ancient Rizian kings. The parchment treaty rested upon an altar flanked by the royal scepter and the seal of House Toras.")}, 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Treaty_Declaration",
                {cs("Your Majesty... The bloodshed has ended. The ink is dry upon the instrument of peace. The scribes await your royal signature to seal the destiny of our realm in the annals of history.")}, 3);

            var outcomeHub = AddLine(conv, 3, NarratorId, RomusId, "Outcome_Hub_Prompt",
                {cs("You stepped forward to the altar to ratify the outcome of the campaign.")});

            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive Victory
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Overwhelming Triumph
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Independent Zille Buffer
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Tactical Defeat
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 50)); // Total Fiasco

            AddChoice(conv, 10, HugoId, "Sign_Decisive_Victory",
                {cs("\"Sign the Treaty of Total Restoration: Zille returns to the Crown of Rizia!\"")},
                {cs("In the presence of Saint Wruhec and the nobles of Rizia, I affix the royal seal. Zille is liberated and reunited with the Kingdom of Rizia for all eternity!")}, 11,
                {cs("Variable[\"ZilleReturn_Success\"] = true; Variable[\"Zille_PromisedToHouseToras\"] = true; Variable[\"_Zille_OwnState\"] = 1;")});

            AddLine(conv, 11, HugoId, RomusId, "Ack_Decisive_Ceremony",
                {cs("The hall erupted into thunderous cheers, bells pealing from every cathedral in Porte Drazon. Hugo wiped tears of joy from his eyes, bowing deeply before his King. \"Thirty years of national shame washed away in blood and triumph! Long live King Romus the Restorer!\"")}, -1);

            AddChoice(conv, 20, HugoId, "Sign_Overwhelming_Triumph",
                {cs("\"Sign the Treaty of Total Reparations: Wehlen humbled and massive indemnities secured!\"")},
                {cs("By this treaty, Wehlen surrenders Zille, pays immense war indemnities, and demilitarizes its borders. The House of Toras has achieved total and absolute victory!")}, 21,
                {cs("Variable[\"ZilleReturn_Success\"] = true; Variable[\"Zille_PromisedToHouseToras\"] = true; Variable[\"_Zille_OwnState\"] = 1; Variable[\"Grodzizg_FreeCity\"] = true;")});

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Overwhelming_Ceremony",
                {cs("Lucita unsheathed her ceremonial sword and saluted with shining eyes. \"An epochal triumph, Your Majesty! We have not merely reclaimed our land-we have broken the military might of Wehlen for a generation to come!\"")}, -1);

            AddChoice(conv, 30, HugoId, "Sign_Independent_Buffer",
                {cs("\"Sign the Treaty of Neutrality: The Independent Republic of Zille is established.\"")},
                {cs("To spare our people further carnage, I sign the charter establishing the Independent Neutral State of Zille. May this neutral territory forever stand as a barrier against war.")}, 31,
                {cs("Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"ZilleReturn_Success\"] = false;")});

            AddLine(conv, 31, LaurentoId, RomusId, "Ack_Buffer_Ceremony",
                {cs("Laurento bowed solemnly. \"The Alliance of Nations applauds your royal wisdom, Your Majesty. Though the province is not annexed, peace and lucrative trade corridors are guaranteed.\"")}, -1);

            AddChoice(conv, 40, HugoId, "Sign_Tactical_Defeat",
                {cs("\"Sign the Armed Armistice: Freeze the frontlines under an armed truce.\"")},
                {cs("With a heavy heart, I sign this armistice. Our brave soldiers fought with unmatched valor, but we must withdraw to preserve our kingdom. Zille remains in enemy hands... for now.")}, 41,
                {cs("Variable[\"ZilleReturn_Success\"] = false; Variable[\"ZilleReferendum_Lost\"] = true;")});

            AddLine(conv, 41, HugoId, RomusId, "Ack_Tactical_Defeat",
                {cs("A somber silence fell over the court. Hugo sighed deeply, his shoulders bowed with grief. \"A bitter day for House Toras, Romus. But the realm endures. We must rebuild our strength.\"")}, -1);

            AddChoice(conv, 50, HugoId, "Sign_Total_Fiasco",
                {cs("\"Sign the Instrument of Surrender: Concede southern Brenas to save the capital.\"")},
                {cs("To prevent the destruction of Porte Drazon, I sign this humiliating surrender. May God forgive me for the tragedy that has befallen our kingdom.")}, 51,
                {cs("Variable[\"ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true; Variable[\"Country_MilitaryCoupHappens\"] = true;")});

            AddLine(conv, 51, NarratorId, RomusId, "Ack_Total_Fiasco",
                {cs("Shouts of outrage and fury broke out among the assembled officers. Duke Taddeus stormed from the hall in disgust, while whispers of a military coup echoed through the darkened corridors. The monarchy stood on the brink of total collapse.")}, -1);

            AddConversationWithAlias(db, conv, "Zille/WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Peace Treaty Ceremony (ID 9993) into masterDatabase!");
        }}
    }}
}}
'''
    with open('src/GreatZilleSolution/ZilleDialogueSystem.TreatyScenes.cs', 'w', encoding='utf-8') as f:
        f.write(code)
    print("Successfully built src/GreatZilleSolution/ZilleDialogueSystem.TreatyScenes.cs")

generate_war_scenes()
generate_diplomacy_scenes()
generate_treaty_scenes()
