using System;
using MelonLoader;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static partial class ZilleDialogueSystem
    {
        public const int ConvId_HomeFrontCrisis = 9998;
        public const int ConvId_ZilleLiberation = 9999;

        // =========================================================================
        // SCENE 12: Turn_Zille_HomeFrontCrisis (ID 9998) - WARTIME HOME FRONT CRISIS
        // Covers the missing mid-war domestic & international fallout:
        // - Energy grid strain from Wehlen oil cutoff
        // - AN sanctions / press pressure in Konstantium
        // - Two-front Pales awareness
        // =========================================================================
        public static void RegisterHomeFrontCrisis(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_HomeFrontCrisis") != null && db.GetConversation("Zille/HomeFrontCrisis") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_HomeFrontCrisis;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/HomeFrontCrisis";
            conv.ActorID = RomusId;
            conv.ConversantID = ElenaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, ElenaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "HomeFront_Arrival",
                "Dawn broke gray over Porte Drazon as your motorcade returned from the Ministry of Interior. Along the boulevard, bakers' carts queued early beside kerosene pumps while newsboys shouted fresh headlines from Konstantium about the fighting in Zille. Inside the Cabinet Room, Elena Werner and Laurento stood beside a stack of urgent domestic cables.", -1);

            AddChoice(conv, 401, NarratorId, "HomeFront_Stimulus_Newspaper",
                "Pick up the morning edition of the Porte Drazon Gazette from the side table before sitting down.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "HomeFront_Stimulus_Window",
                "Pause by the balcony doors to watch the morning fuel queue down on the avenue.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "HomeFront_Entry_Paper",
                "The front page carried bold headlines praising the Royal Army alongside smaller columns warning of rising diesel prices and foreign shipping delays.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "HomeFront_Entry_Queue",
                "Below the palace walls, delivery trucks idled patiently in the mist—ordinary Rizians already feeling the quiet squeeze of war.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, ElenaId, RomusId, "Elena_HomeFront_LowEnergy",
                "\"Your Majesty, with Wehlen's northern crude cut off and military convoys drinking diesel, our strategic energy cushion has dropped to critical levels. Factories in Valenqiris and Brenas are asking whether rationing is imminent.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Energy\"] or 0) <= 3");

            AddLine(conv, 102, ElenaId, RomusId, "Elena_HomeFront_SteadyEnergy",
                "\"Your Majesty, though Wehlen severed our northern crude contracts, our pre-war reserves are holding—yet speculative hoarding in Porte Drazon and Valenqiris is driving prices upward unless the Crown sets clear rules.\"", -1,
                "(Variable[\"RiziaDLC.Resources_Energy\"] or 0) > 3 and Variable[\"Zille_Derdia_PipelineInvested\"] ~= true");

            AddLine(conv, 103, ElenaId, RomusId, "Elena_HomeFront_DerdiaPipeline",
                "\"Your Majesty, Wehlen's crude embargo would have crippled our grid by now—were it not for the southern Derdian pipeline delivering steady fuel and transit revenues into our ports. Still, speculators in Porte Drazon require a firm hand.\"", -1,
                "Variable[\"Zille_Derdia_PipelineInvested\"] == true");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 404, 103);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);
            AddLink(conv, 405, 103);

            var econPrompt = AddLine(conv, 10, NarratorId, RomusId, "HomeFront_Econ_Prompt",
                "Elena held her pen poised over the wartime rationing decree, awaiting your direction.");

            AddLink(conv, 2, 10);
            AddLink(conv, 102, 10);
            AddLink(conv, 103, 10);

            econPrompt.outgoingLinks.Add(CreateLink(conv.id, 10, 11));
            econPrompt.outgoingLinks.Add(CreateLink(conv.id, 10, 12));
            econPrompt.outgoingLinks.Add(CreateLink(conv.id, 10, 13));

            AddChoice(conv, 11, ElenaId, "HomeFront_Subsidize_Fuel",
                "\"Release treasury funds to subsidize civilian heating oil and bakery deliveries.\"",
                "We will not let ordinary families freeze while our armies fight for Zille. Release royal funds to stabilize civilian fuel and bread transport.", 20,
                "Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 1; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1");

            AddChoice(conv, 12, ElenaId, "HomeFront_Industrial_Rationing",
                "\"Enforce strict wartime rationing on luxury estates and non-essential motors.\"",
                "Every drop of diesel belongs to the front and essential farms. Impose strict rationing on private estates and pleasure vehicles immediately.", 20,
                "Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 2; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) - 1; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddChoice(conv, 13, ElenaId, "HomeFront_Price_Controls",
                "\"Freeze wholesale fuel prices by royal decree and audit speculators in Porte Drazon.\"",
                "Freeze wholesale fuel prices by royal decree and send treasury auditors into the port warehouses to break hoarding.", 20,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) - 1; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            // Topic 2: International Press & AN Sanctions
            AddLine(conv, 20, LaurentoId, RomusId, "Laurento_HomeFront_AN",
                "Laurento slid a sheaf of Konstantium telegrams across the table. \"On the diplomatic front, Your Majesty, Contanan and Wehzek envoys are circulating exaggerated stories of civilian hardship in Zille to push an Alliance of Nations embargo.\"", 30);

            var anPrompt = AddLine(conv, 30, NarratorId, RomusId, "HomeFront_AN_Prompt",
                "How should Rizia answer Smolak's propaganda offensive in Kyrute?");

            anPrompt.outgoingLinks.Add(CreateLink(conv.id, 30, 31));
            anPrompt.outgoingLinks.Add(CreateLink(conv.id, 30, 32));

            AddChoice(conv, 31, LaurentoId, "HomeFront_AN_WhitePaper",
                "\"Publish a royal White Paper with independent observers' dispatches proving our soldiers protect civilians.\"",
                "Open our rear depots and refugee clinics to neutral correspondents from Kyrute and publish a full White Paper on Wehlen's 1927 breach.", 40,
                "Variable[\"Zille_HomeFrontCrisis_Done\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddChoice(conv, 32, LaurentoId, "HomeFront_AN_SovereignDefiance",
                "\"Remind Konstantium that Rizia's internal affairs and sovereign borders are not up for foreign debate.\"",
                "Send a crisp note to Konstantium: Rizia answers to law and her own people, not to Smolak's theatrical complaints.", 40,
                "Variable[\"Zille_HomeFrontCrisis_Done\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            AddLine(conv, 40, HugoId, RomusId, "Hugo_HomeFront_Close",
                "\"A steady hand on the home front keeps the army standing at the border, Your Majesty. The realm holds firm.\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 140, ElenaId, RomusId, "Elena_HomeFront_Close",
                "\"The decrees are stamped and dispatched, Your Majesty. Our ledgers and supply lines will weather the storm.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 31, 140);
            AddLink(conv, 32, 140);

            AddConversationWithAlias(db, conv, "Zille/HomeFrontCrisis", "Turn_Zille_HomeFrontCrisis");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Home Front Crisis (ID 9998) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 13: Turn_Zille_ZilleLiberation (ID 9999) - HOMECOMING IN ZILLE CITY
        // Features Queen Mother Estela & Princess Vina visiting Estela's childhood
        // harbor quarter, plus post-war civil administration & reconciliation choices.
        // =========================================================================
        public static void RegisterZilleLiberation(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_ZilleLiberation") != null && db.GetConversation("Zille/ZilleLiberation") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_ZilleLiberation;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/ZilleLiberation";
            conv.ActorID = RomusId;
            conv.ConversantID = EstelaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, EstelaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Liberation_Travel",
                "Your royal motorcade crossed the old stone causeway into Zille City beneath a sky washed clean by coastal wind. Everywhere along the avenues, Wehzek occupation signs lay piled beside freshly hung gold-and-crimson banners of House Toras. Near the old fishing harbor, salt-worn cobbles led toward the modest stone house where Queen Mother Estela had spent her childhood before marrying King Valero.", -1);

            AddChoice(conv, 401, NarratorId, "Liberation_Stimulus_Harbor",
                "Step out of the limousine early to walk the last hundred yards along the harbor cobbles on foot.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Liberation_Stimulus_Crowd",
                "Greet the cheering ATA and Su Omina volunteers lining the square from the open car step.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Liberation_Entry_Walk",
                "The sea wind carried the familiar scent of tarred nets and grilled sardines. Elderly fishermen removed their caps in disbelief as the King of Rizia walked down their narrow lane.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Liberation_Entry_Crowd",
                "Young Rizians waved homemade Toras pennants from upstairs shutters, cheering until their voices cracked.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, EstelaId, RomusId, "Estela_Homecoming_Line",
                "Queen Mother Estela stood beside the weathered blue door of her father's old house, her gloved hand trembling slightly against the doorframe as tears shone in her eyes. \"Romus... Look at the harbor bell tower. I never thought I would hear it ring under our flag again. Your father carried that regret to his grave—and you washed it away.\"", -1,
                "Variable[\"QueenMother_Estela_Dead\"] ~= true and Variable[\"RiziaDLC.Estela_Dead\"] ~= true");

            AddLine(conv, 102, VinaId, RomusId, "Vina_Homecoming_Line",
                "Princess Vina looked out over the sunlit fishing boats bobbing in the harbor. \"Father... This city feels older and braver than all the marble halls of Porte Drazon. People here waited twenty-five years for this morning.\"", -1,
                "(Variable[\"QueenMother_Estela_Dead\"] == true or Variable[\"RiziaDLC.Estela_Dead\"] == true)");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);

            AddLine(conv, 3, VinaId, RomusId, "Vina_Harbor_Reflection",
                "Vina slipped her arm through yours quietly. \"We have Zille back, Father—now the world will judge how House Toras governs it.\"", 10,
                "Variable[\"QueenMother_Estela_Dead\"] ~= true and Variable[\"RiziaDLC.Estela_Dead\"] ~= true");

            AddLink(conv, 2, 3);
            AddLink(conv, 102, 10);

            // Topic 1: Wehzek residents & collaborators
            var justicePrompt = AddLine(conv, 10, NarratorId, RomusId, "Liberation_Justice_Prompt",
                "At the improvised town hall overlooking the quay, local ATA leaders and your military provost presented the first urgent question: thousands of Wehzek settlers and former municipal clerks remained in Zille's northern quarter.");

            justicePrompt.outgoingLinks.Add(CreateLink(conv.id, 10, 11));
            justicePrompt.outgoingLinks.Add(CreateLink(conv.id, 10, 12));
            justicePrompt.outgoingLinks.Add(CreateLink(conv.id, 10, 13));

            AddChoice(conv, 11, LaurentoId, "Liberation_Lawful_Courts",
                "\"Guarantee full civil protection to peaceful Wehzek families; try only documented collaborators in open royal courts.\"",
                "Every peaceful family in Zille—Rizian, Bludish, or Wehzek—is under the King's peace. Only those who committed crimes under Smolak's police shall face open royal courts.", 20,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            AddChoice(conv, 12, TitusId, "Liberation_Security_Vetting",
                "\"Have the Golden Guard and provosts screen all Wehzek administration officials and confiscate weapons caches.\"",
                "Stability comes first. Have the Golden Guard vet every former Wehzek clerk and clear all weapons caches before civil courts reopen.", 20,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            AddChoice(conv, 13, HugoId, "Liberation_Royal_Amnesty",
                "\"Proclaim a broad Royal Amnesty for low-level clerks so Zille's ports and mines reopen tomorrow.\"",
                "Proclaim a royal amnesty for minor municipal clerks and tradesmen. Zille needs working docks and open schools, not endless tribunals.", 20,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) + 1;");

            // Topic 2: Post-war administrative status of Zille
            var adminPrompt = AddLine(conv, 20, NarratorId, RomusId, "Liberation_Admin_Prompt",
                "Finally, the noble houses awaited your decree on Zille's permanent constitutional place within the Kingdom of Rizia.");

            adminPrompt.outgoingLinks.Add(CreateLink(conv.id, 20, 21));
            adminPrompt.outgoingLinks.Add(CreateLink(conv.id, 20, 22));
            adminPrompt.outgoingLinks.Add(CreateLink(conv.id, 20, 122));

            AddChoice(conv, 21, HugoId, "Liberation_Admin_RoyalCharter",
                "\"Place Zille under a special Royal Reconstruction Charter reporting directly to the Crown.\"",
                "For the next five years, Zille shall be governed under a Royal Reconstruction Charter reporting directly to the Crown so gold revenues rebuild her harbor first.", 30,
                "Variable[\"Zille_Liberation_Done\"] = true; Variable[\"Zille_Admin_Charter\"] = \"Royal\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            AddChoice(conv, 22, ManusId, "Liberation_Admin_Brenas",
                "\"Restore Zille immediately to the provincial administration of House Sazon and Brenas.\"",
                "Zille was torn from Brenas in 1927, and to Brenas it returns today under full provincial representation and House Sazon's civil charter.", 30,
                "Variable[\"Zille_Liberation_Done\"] = true; Variable[\"Zille_Admin_Charter\"] = \"Brenas\"; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 2;",
                "Variable[\"RiziaDLC.Manus_Arrested\"] ~= true and Variable[\"RiziaDLC.Manus_Executed\"] ~= true and Variable[\"RiziaDLC.Manus_Gone\"] ~= true and Variable[\"RiziaDLC.Manus_EarlyExile\"] ~= true and Variable[\"RiziaDLC.Manus_DiesInWar\"] ~= true");

            AddChoice(conv, 122, LeonaId, "Liberation_Admin_Brenas_NoManus",
                "\"Restore Zille immediately to the provincial administration of Brenas.\"",
                "Zille was torn from Brenas in 1927, and to Brenas it returns today under full provincial administration.", 30,
                "Variable[\"Zille_Liberation_Done\"] = true; Variable[\"Zille_Admin_Charter\"] = \"Brenas\"; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Manus_Arrested\"] == true or Variable[\"RiziaDLC.Manus_Executed\"] == true or Variable[\"RiziaDLC.Manus_Gone\"] == true or Variable[\"RiziaDLC.Manus_EarlyExile\"] == true or Variable[\"RiziaDLC.Manus_DiesInWar\"] == true)");

            AddLine(conv, 30, EstelaId, RomusId, "Estela_Liberation_Close",
                "As the harbor bells chimed noon across Zille Bay, Queen Mother Estela smiled through her tears. \"Long live the King. Welcome home, Zille.\"", -1,
                "Variable[\"QueenMother_Estela_Dead\"] ~= true and Variable[\"RiziaDLC.Estela_Dead\"] ~= true");

            AddLine(conv, 130, NarratorId, RomusId, "Liberation_Close_Fallback",
                "As the harbor bells chimed noon across Zille Bay, the gold-and-crimson banner of House Toras climbed the flagpole above the town hall to thunderous cheers.", -1,
                "(Variable[\"QueenMother_Estela_Dead\"] == true or Variable[\"RiziaDLC.Estela_Dead\"] == true)");

            AddLink(conv, 21, 130);
            AddLink(conv, 22, 130);
            AddLink(conv, 122, 30);
            AddLink(conv, 122, 130);

            AddConversationWithAlias(db, conv, "Zille/ZilleLiberation", "Turn_Zille_ZilleLiberation");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Zille Liberation Homecoming (ID 9999) into masterDatabase!");
        }
    }
}
