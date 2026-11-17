using System;
using MelonLoader;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static partial class ZilleDialogueSystem
    {
        // =========================================================================
        // SCENE 14: Turn_Zille_DerdiaInvestigation (ID 10001) - TURN 4 INVESTIGATION
        // Investigates the mysterious Turn 3 sabotage explosions along the
        // Derdia-Wehlen frontier (Yol & Qerzan passes). Adapts if early war active!
        // =========================================================================
        public static void RegisterDerdiaInvestigation(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_DerdiaInvestigation") != null && db.GetConversation("Zille/DerdiaInvestigation") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_DerdiaInvestigation;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/DerdiaInvestigation";
            conv.ActorID = RomusId;
            conv.ConversantID = TitusId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, TitusId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "DerdiaInv_Intro",
                "Dawn light filtered through the tall shutters of the Golden Guard briefing room in Palas Rezna. Spread across the slate table lay reconnaissance sketches of the northern Derdian mountain passes around Yol and Qerzan, charred fragments of blasting wire, and intercepted border telegrams.", -1);

            AddLine(conv, 2, TitusId, RomusId, "DerdiaInv_Titus_Peace",
                "\"Your Majesty, the explosions along the Derdia-Wehlen frontier were no ordinary smuggling squabble. Someone blew up a Derdian pipeline pumping station and burned Silver Garrison supply dumps—and Wraclawitz immediately used the chaos to move armored columns toward Grodzizg.\"", 10,
                "Variable[\"Zille_War_Active\"] ~= true and Variable[\"Zille_War_EarlyLaunch\"] ~= true and Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 102, TitusId, RomusId, "DerdiaInv_Titus_War",
                "\"Your Majesty, with fighting already erupting along the Zille frontier, Wehlen's northern border is in turmoil—and that works in our favor. Our border watchers caught fresh leads on who actually planted the charges along Derdia's Yol and Qerzan passes.\"", 10,
                "(Variable[\"Zille_War_Active\"] == true or Variable[\"Zille_War_EarlyLaunch\"] == true) and Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 103, CarlosId, RomusId, "DerdiaInv_Carlos_Fallback",
                "\"Your Majesty, military intelligence has traced the recent explosions along the Yol and Qerzan passes on Derdia's northern frontier. Wraclawitz blames Golcondist smugglers, yet the demolition signatures look unmistakably regular-army.\"", 10,
                "Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);
            AddLink(conv, 1, 103);

            var hub = AddLine(conv, 10, NarratorId, RomusId, "DerdiaInv_Hub",
                "Before ordering an intelligence sweep along the mountain frontier, I weighed what we already knew and which arm of the Crown should lead the inquiry.");

            hub.outgoingLinks.Add(CreateLink(conv.id, 10, 11));
            hub.outgoingLinks.Add(CreateLink(conv.id, 10, 12));
            hub.outgoingLinks.Add(CreateLink(conv.id, 10, 15));

            AddChoice(conv, 11, LaurentoId, "DerdiaInv_Ask_Geopolitics",
                "\"Laurento, why would Smolak provoke Derdia when he already has his hands full with Zille?\"",
                "Why would Wiktor Smolak risk antagonizing Supreme Wiseman Azmal along his southern mountains right now?", 111,
                "Variable[\"Zille_DerdiaInv_AskedDiplo\"] = true;",
                "Variable[\"Zille_DerdiaInv_AskedDiplo\"] ~= true");

            AddLine(conv, 111, LaurentoId, RomusId, "DerdiaInv_Reply_Geopolitics",
                "\"Two reasons, Your Majesty: energy and fear. Derdia has been surveying a southern export pipeline that would bypass Wehlen altogether. By staging 'terrorist' sabotage at Yol and blaming BFF bandits, Smolak intimidates Naeal, stalls their pipeline, and keeps southern crude flowing only through his own tollgates.\"", 10);

            AddChoice(conv, 12, LucitaId, "DerdiaInv_Ask_Military",
                "\"Lucita, what does this mean strategically if Derdia turns against Wehlen?\"",
                "If Azmal becomes convinced Wehlen is behind these attacks, what changes for our war plans?", 112,
                "Variable[\"Zille_DerdiaInv_AskedMil\"] = true;",
                "Variable[\"Zille_DerdiaInv_AskedMil\"] ~= true and Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 112, LucitaId, RomusId, "DerdiaInv_Reply_Military",
                "\"Everything, Your Majesty. Right now Plan Ark relies on risky amphibious landings across the Gulf of Moridia. If Derdia's mountain passes at Yol and Qerzan ever opened to Rizian divisions, we could strike Wehlen's soft southern belly by land—forcing Valdez to split his army in two!\"", 10);

            AddChoice(conv, 15, TitusId, "DerdiaInv_Proceed_Action",
                "\"Let us decide how Rizia investigates the Yol-Qerzan sabotage.\"",
                "I have heard the strategic picture. Let us assign our investigators immediately.", 20);

            var actionHub = AddLine(conv, 20, NarratorId, RomusId, "DerdiaInv_Action_Prompt",
                "Three avenues lay open to uncover definitive proof along the Derdia-Wehlen frontier.");

            actionHub.outgoingLinks.Add(CreateLink(conv.id, 20, 21));
            actionHub.outgoingLinks.Add(CreateLink(conv.id, 20, 22));
            actionHub.outgoingLinks.Add(CreateLink(conv.id, 20, 23));

            AddChoice(conv, 21, TitusId, "DerdiaInv_GoldenGuard",
                "\"Send Golden Guard forensic specialists covertly to inspect the blasted pumping station and recover Wehzek ordnance.\"",
                "Dispatch Golden Guard specialists under diplomatic courier cover to examine the Yol pumping station and trace every blasting cap.", 31,
                "Variable[\"Zille_Derdia_InvestigationDone\"] = true; Variable[\"Zille_Derdia_SabotageEvidence\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddChoice(conv, 22, LucitaId, "DerdiaInv_MilitaryIntel",
                "\"Have House Azaro's border scouts intercept Wehzek sapper communications near Grodzizg.\"",
                "Task military intelligence along the frontier to triangulate Wehzek sapper radios and map their staging camps near Grodzizg.", 32,
                "Variable[\"Zille_Derdia_InvestigationDone\"] = true; Variable[\"Zille_Derdia_SabotageEvidence\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;",
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddChoice(conv, 23, LaurentoId, "DerdiaInv_DiplomaticChannel",
                "\"Share our preliminary intelligence quietly with Naeal and request joint border observers.\"",
                "Have the Foreign Ministry pass our preliminary findings to Naeal and propose a quiet joint border verification.", 33,
                "Variable[\"Zille_Derdia_InvestigationDone\"] = true; Variable[\"Zille_Derdia_SabotageEvidence\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddLine(conv, 31, NarratorId, RomusId, "DerdiaInv_Result_GG",
                "Two days later, Titus laid a sealed folder on my desk: Wehzek military-grade detonators, factory lot numbers from Wraclawitz, and eyewitness sketches of uniformed sappers slipping back across the northern ridge. \"Hard proof, Your Majesty. Azmal cannot ignore this when you speak with him.\"", -1);

            AddLine(conv, 32, NarratorId, RomusId, "DerdiaInv_Result_Mil",
                "Lucita's scouts delivered decrypted Wehzek field traffic alongside photographs of demolition teams withdrawing into Grodzizg barracks. \"Undeniable evidence, Your Majesty. Smolak is running a covert intimidation campaign against Derdia.\"", -1);

            AddLine(conv, 33, NarratorId, RomusId, "DerdiaInv_Result_Diplo",
                "Within days, joint observers confirmed that the explosives bore Wraclawitz army markings—not Golcondist or Bludish contraband. \"Supreme Wiseman Azmal has agreed to speak with you directly, Your Majesty,\" Laurento reported.", -1);

            AddConversationWithAlias(db, conv, "Zille/DerdiaInvestigation", "Turn_Zille_DerdiaInvestigation");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Derdia Investigation (ID 10001) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 15: Turn_Zille_DerdiaStateVisit (ID 10002) - WARM DIPLOMATIC VISIT
        // Triggered after sharing sabotage evidence in Turn 5 DerdiaTalks.
        // Leaders are immediately warm toward each other; seals:
        // 1) Southern Invasion Corridor (PlanArkDerdia)
        // 2) Lucrative Southern Energy Pipeline (offsets Wehlen oil embargo!)
        // 3) Missile & Disciples Military Synergy
        // =========================================================================
        public static void RegisterDerdiaStateVisit(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_DerdiaStateVisit") != null && db.GetConversation("Zille/DerdiaStateVisit") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_DerdiaStateVisit;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/DerdiaStateVisit";
            conv.ActorID = RomusId;
            conv.ConversantID = AzmalId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, AzmalId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "DerdiaVisit_Arrival",
                "Crisp mountain air greeted my motorcade as we climbed the winding approach to the Silver Garrison outside Naeal. Instead of cold suspicion, rows of Golcondist Disciples lined the stone courtyard with lowered halberds in royal salute, banners bearing the golden crescent fluttering beside the Toras standard.", -1);

            AddLine(conv, 2, AzmalId, RomusId, "DerdiaVisit_WarmGreeting",
                "Supreme Wiseman Jorga Azmal descended the carved steps with both hands extended—his gravelly baritone ringing with rare, genuine warmth. \"Halaita, King Romus! A monarch who brings truth to his neighbor's gate enters not as a stranger, but as a brother-in-arms. Your dossier exposed the snakes creeping across our northern passes!\"", 3,
                "Variable[\"Zille_War_Active\"] ~= true");

            AddLine(conv, 102, AzmalId, RomusId, "DerdiaVisit_WarmGreeting_War",
                "Supreme Wiseman Jorga Azmal strode down the stone steps to clasp my forearm warmly. \"Halaita, King Romus! While your soldiers bleed against Smolak's brigades in the west, you still found honor enough to warn Derdia of his northern saboteurs. The Silver Garrison welcomes a true warrior-king!\"", 3,
                "Variable[\"Zille_War_Active\"] == true");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var greetHub = AddLine(conv, 3, NarratorId, RomusId, "DerdiaVisit_Greet_Hub",
                "Carved silver goblets of chilled rosewater were brought forth as Azmal invited me into the sunlit council hall.");

            greetHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            greetHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            greetHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AzmalId, "DerdiaVisit_Greet_Honor",
                "\"Rizia and Derdia share the same sky and the same northern menace, Supreme Wiseman. Honor demanded we warn you.\"",
                "When Wehlen's sappers strike your passes today, they strike at the peace of all South Merkopa tomorrow. Warning a sovereign neighbor is simple royal duty.", 20,
                "Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] or 0) + 1; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true;");

            AddChoice(conv, 11, AzmalId, "DerdiaVisit_Greet_Sal",
                "\"May the shared light of Saint Wruhec and Nur guide our councils today.\"",
                "Though our rites differ, we pray to the same Creator for justice against tyrants. Let this hall witness friendship between our faiths.", 20,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true;");

            AddChoice(conv, 12, AzmalId, "DerdiaVisit_Greet_Pragmatic",
                "\"Let us make this visit historic, Jorga—a pact that breaks Smolak and enriches both our peoples.\"",
                "The hour for half-measures has passed, Jorga. Let us forge an alliance that shields your borders, opens our armies' path, and frees both our economies from Wehlen's chokehold.", 20,
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            // Friendly ceremonial Duel of Generosity gesture
            AddLine(conv, 20, NarratorId, RomusId, "DerdiaVisit_Duel_Offer",
                "Azmal's eyes crinkled with proud amusement as two Disciples brought forward ceremonial wooden staves. \"Among our people, alliances are sealed not merely with ink, but with the Duel of Generosity—a friendly test of spirit between comrades. Will you or your champion honor our tradition before we sign?\"", -1);

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 22);
            AddLink(conv, 20, 23);

            AddChoice(conv, 21, AzmalId, "DerdiaVisit_Duel_Titus",
                "\"Captain Gordion would be honored to cross staves with your champion in friendship!\"",
                "With pleasure, Supreme Wiseman. Titus, step forward and honor our hosts' tradition!", 24,
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddChoice(conv, 22, AzmalId, "DerdiaVisit_Duel_Romus",
                "\"I will take the staff myself—a King shares the field with his allies.\"",
                "A King does not ask others to do what he will not do himself. Hand me the staff!", 25,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddChoice(conv, 23, AzmalId, "DerdiaVisit_Duel_Toast",
                "\"Let us share rosewater and move straight to the map table—our soldiers await.\"",
                "I respect your custom deeply, Supreme Wiseman, yet urgent events along the border bid us turn straight to the treaty table.", 30);

            AddLine(conv, 24, NarratorId, RomusId, "DerdiaVisit_Duel_Titus_Result",
                "Titus and the Derdian champion traded crisp, laughing blows until both staves clattered down in mutual respect—drawing thunderous applause from the Disciples.", 30);

            AddLine(conv, 25, NarratorId, RomusId, "DerdiaVisit_Duel_Romus_Result",
                "My shoulders ached from the brisk exchange, yet when Azmal clapped my back with a booming laugh, every Wiseman in the hall rose in genuine admiration.", 30);

            // Multi-topic Negotiation Hub for the Alliance & Economic Package
            var negHub = AddLine(conv, 30, AzmalId, RomusId, "DerdiaVisit_Negotiation_Hub",
                "We gathered around the cedar table where maps of Yol, Qerzan, and southern Wehlen lay beside energy blueprints. \"Speak openly, brother,\" Azmal urged. \"Let us settle the military corridor, the southern pipeline, and our mutual defense before we affix our seals.\"");

            negHub.outgoingLinks.Add(CreateLink(conv.id, 30, 31)); // Topic 1: Southern Corridor (PlanArkDerdia)
            negHub.outgoingLinks.Add(CreateLink(conv.id, 30, 32)); // Topic 2: Southern Energy Pipeline Investment
            negHub.outgoingLinks.Add(CreateLink(conv.id, 30, 33)); // Topic 3: Missiles & Disciples
            negHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Proceed to Final Treaty Signing

            AddChoice(conv, 31, AzmalId, "DerdiaVisit_Topic_Corridor",
                "\"Let us finalize the northern staging corridor through Yol and Qerzan for Rizia's southern offensive.\"",
                "With Wehlen already staging saboteurs across your passes, opening the Yol-Qerzan corridor lets Rizian divisions strike Smolak's soft southern flank directly.", 131,
                "Variable[\"Zille_DerdiaVisit_DiscussedCorridor\"] = true;",
                "Variable[\"Zille_DerdiaVisit_DiscussedCorridor\"] ~= true");

            AddLine(conv, 131, AzmalId, RomusId, "DerdiaVisit_Reply_Corridor",
                "\"Agreed in principle,\" Azmal nodded gravely. \"Our northern passes around Dertea, Merzil, Haldesh, and Qerzan will open to your columns—while Yol itself remains a sacred, demilitarized logistics hub under Silver Garrison guard. In return, your troops respect our shrines, and after victory Wehlen's southern border is demilitarized.\"", 30);

            AddChoice(conv, 32, AzmalId, "DerdiaVisit_Topic_Pipeline",
                "\"Rizia can finance your stalled southern energy pipeline—giving you export markets and freeing us from Wehlen's oil!\"",
                "Your pipeline project stalled for lack of capital and Smolak's threats. If Rizia funds its completion to our southern ports, we replace Wehzek crude completely and share lucrative transit revenues.", 132,
                "Variable[\"Zille_DerdiaVisit_DiscussedPipeline\"] = true;",
                "Variable[\"Zille_DerdiaVisit_DiscussedPipeline\"] ~= true");

            AddLine(conv, 132, NarratorId, RomusId, "DerdiaVisit_Reply_Pipeline",
                "Azmal's eyes shone with sudden strategic clarity. \"You see beyond today's battlefield, Romus. With Rizian gold completing our pipeline and connecting to your coastal refineries, Derdia breaks free of Wraclawitz forever—and Rizia gains an inexhaustible, loyal source of energy and trade dividends even if ATO or Contana sanction you!\"", 30);

            AddChoice(conv, 33, AzmalId, "DerdiaVisit_Topic_Missiles",
                "\"What of Derdian ballistic missiles and Disciples brigades to support our joint front?\"",
                "Our armies would fight even better side by side if Derdian missile batteries and Disciples scouts bolstered our southern spearhead.", 133,
                "Variable[\"Zille_DerdiaVisit_DiscussedMissiles\"] = true;",
                "Variable[\"Zille_DerdiaVisit_DiscussedMissiles\"] ~= true");

            AddLine(conv, 133, AzmalId, RomusId, "DerdiaVisit_Reply_Missiles",
                "\"Three thousand Disciples are already sharpening their blades to raid Wehlen's rear roads,\" Azmal replied. \"And if our pact is sealed today, Derdian rocketeers can position ballistic batteries along the ridge to suppress Wehzek artillery and supply dumps.\"", 30);

            AddChoice(conv, 40, AzmalId, "DerdiaVisit_Proceed_Sign",
                "\"Every pillar is clear. Let us seal the Silver Garrison Alliance!\"",
                "Our terms are clear and honorable. Let us seal the Silver Garrison Alliance between Rizia and Derdia!", 50);

            // Final Pact & Economic Investment Selection
            var signHub = AddLine(conv, 50, NarratorId, RomusId, "DerdiaVisit_Sign_Hub",
                "The gilded treaty parchment lay open between us. All that remained was to decide the scope of Rizia's economic and military investment in the new alliance.");

            signHub.outgoingLinks.Add(CreateLink(conv.id, 50, 51)); // Full Grand Alliance + Pipeline Investment (-2 Budget -> +3 Energy, Pipeline, Corridor, Missiles)
            signHub.outgoingLinks.Add(CreateLink(conv.id, 50, 52)); // Discounted Grand Alliance (if Budget >= 1 and good Derdia relations/ban lifted)
            signHub.outgoingLinks.Add(CreateLink(conv.id, 50, 53)); // Military Corridor Pact Only (no budget spent)

            AddChoice(conv, 51, AzmalId, "DerdiaVisit_Sign_FullPipeline",
                "\"Sign the Grand Alliance AND invest royal treasury funds to build the Derdia-Rizia Southern Pipeline!\"",
                "We seal the military corridor, welcome Derdian missile and Disciples support, and invest our royal treasury to complete the Derdia-Rizia Southern Pipeline—securing energy independence for both crowns!", 61,
                "Variable[\"Zille_DerdiaPact_Signed\"] = true; Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"Zille_Derdia_PipelineInvested\"] = true; Variable[\"Zille_Derdia_MissilesAgreed\"] = true; Variable[\"Zille_Derdia_StateVisitDone\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Allied\"] = true; Variable[\"RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia\"] = true; Variable[\"RiziaDLC.Policy_Economy_DerdiaPipeline_Project\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 2; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 3; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 2");

            AddChoice(conv, 52, AzmalId, "DerdiaVisit_Sign_DiscountPipeline",
                "\"Sign the Grand Alliance and co-finance the Southern Pipeline on favorable brotherly terms!\"",
                "Our friendship already runs deep—let Rizia commit an initial treasury tranche alongside Derdian engineers to launch the Southern Pipeline and open the northern corridor!", 61,
                "Variable[\"Zille_DerdiaPact_Signed\"] = true; Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"Zille_Derdia_PipelineInvested\"] = true; Variable[\"Zille_Derdia_MissilesAgreed\"] = true; Variable[\"Zille_Derdia_StateVisitDone\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Allied\"] = true; Variable[\"RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia\"] = true; Variable[\"RiziaDLC.Policy_Economy_DerdiaPipeline_Project\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) == 1 or ((Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1 and (Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] or 0) >= 3)");

            AddChoice(conv, 53, AzmalId, "DerdiaVisit_Sign_CorridorOnly",
                "\"Seal the Military Corridor and Defense Pact today; defer pipeline financing until after victory.\"",
                "We seal the Silver Garrison Defense Pact and open the Yol-Qerzan corridor for our armies immediately; once Wehlen is defeated, our treasuries will build the pipeline in peace.", 62,
                "Variable[\"Zille_DerdiaPact_Signed\"] = true; Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"Zille_Derdia_StateVisitDone\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Allied\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddLine(conv, 61, NarratorId, RomusId, "DerdiaVisit_Close_Full",
                "Azmal pressed his signet ring into the crimson wax beside mine, then raised both hands in solemn blessing. \"Halaita! From this hour, Derdia's northern passes are your sword, our rockets guard your skies, and our oil feeds your realm! Let Wiktor Smolak tremble between two sovereign nations!\"", -1);

            AddLine(conv, 62, NarratorId, RomusId, "DerdiaVisit_Close_Corridor",
                "Azmal pressed his signet ring beside mine with firm resolve. \"Halaita! Our northern frontier stands open to Rizia's banners, and three thousand Disciples ride at your flank. May victory bring both our kingdoms lasting peace!\"", -1);

            AddConversationWithAlias(db, conv, "Zille/DerdiaStateVisit", "Turn_Zille_DerdiaStateVisit");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Derdia State Visit (ID 10002) into masterDatabase!");
        }
    }
}
