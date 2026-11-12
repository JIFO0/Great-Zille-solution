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
        // SCENE 6: Turn_Zille_DerdiaTalks (ID 9995) - TALKS WITH DERDIA
        // Features:
        // - Supreme Wiseman Jorga Azmal (Silver Garrison outside Naeal)
        // - Grand Wiseman Sal Ignacius (Six Stars medallion) + Hugo/Laurento/Titus/Carlos fallbacks
        // - Checks pilgrim ban status, Derdia hostility, equipment >= 1000 & budget >= 2!
        // =========================================================================
        public static void RegisterDerdiaTalks(DialogueDatabase db)
        {
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
                "You stepped into the private royal telecommunications chamber beneath Palas Rezna, where the air hung thick with sandalwood, frankincense, and ozone from the humming vacuum tubes. On the walnut table sat a carafe of chilled rosewater beside the gilded cipher receiver. Through the static from the Silver Garrison outside Naeal, the low unison chant of Golcondist guardsmen echoed faintly.", -1);

            AddChoice(conv, 401, NarratorId, "Derdia_Stimulus_Rosewater",
                "Pour a small glass of rosewater and let the cipher clerk finish tuning the Naeal frequency.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Derdia_Stimulus_Headset",
                "Lift the heavy brass receiver immediately, cutting through the static with royal impatience.",
                "", 405, "");

            AddChoice(conv, 403, NarratorId, "Derdia_Stimulus_Medallion",
                "Study the Six Stars crest inlaid on the console while waiting for Supreme Wiseman Azmal.",
                "", 404, "");

            AddLine(conv, 404, NarratorId, RomusId, "Derdia_Entry_Calm",
                "The rosewater cooled your throat as the green signal lamp steadied. A moment later, Supreme Wiseman Jorga Azmal's gravelly baritone rolled across the mountain wire.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Derdia_Entry_Brisk",
                "The brass earpiece was cool against your temple; the cipher clerk flinched slightly and snapped the final toggle. Supreme Wiseman Jorga Azmal's gravelly baritone cut cleanly through the hum.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);
            AddLink(conv, 1, 403);

            AddLine(conv, 2, AzmalId, RomusId, "Azmal_Opening_Greeting",
                "May God's light guide you, Your Majesty. The mountain winds carry whispers of iron and smoke rising along Wehlen's borders. You prepare to strike the butcher of Wraclawitz, do you not?", 3,
                "Variable[\"RiziaDLC.CountryRelation_Derdia_Hostile\"] ~= true");

            AddLine(conv, 102, AzmalId, RomusId, "Azmal_Opening_Hostile",
                "I am surprised the King of Rizia dares summon the Silver Garrison after all the insults our faithful suffered, Your Majesty. Yet even an estranged neighbor becomes useful when Wiktor Smolak stands across the border. Speak quickly.", 3,
                "Variable[\"RiziaDLC.CountryRelation_Derdia_Hostile\"] == true");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);

            var azmalHub = AddLine(conv, 3, RomusId, AzmalId, "Romus_Azmal_Open_Prompt",
                "I leaned toward the gilded receiver, weighing faith, border strategy, and Rizia's own laws.");

            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AzmalId, "Choice_Faith_Justice",
                "\"Smolak has persecuted Bludish and Golcondist believers alike. Justice demands action.\"",
                "Smolak has trampled sacred law and butchered believers across Wehlen and Zille for far too long. Justice demands that the sword be drawn against him.", 20,
                "Variable[\"Derdia_Romus_Faithful\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddChoice(conv, 11, AzmalId, "Choice_Military_Pragmatism",
                "\"Wehlen shares its land border with you and its sea approaches with us. Strike together, and Smolak splits in two.\"",
                "Wehlen borders Derdia by land while Rizia attacks across the Brenas frontier and the Gulf of Moridia. Strike Wehlen's southern depots simultaneously, and Smolak's army cracks under two fronts.", 20,
                "Variable[\"Derdia_Romus_Pragmatic\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddChoice(conv, 12, AzmalId, "Choice_Question_Motives",
                "\"What concrete price does the Silver Garrison set for raiding Wehlen's rear?\"",
                "Speak plainly, Supreme Wiseman: what does Derdia demand in return for opening a second front on Wehlen's southern frontier?", 20,
                "Variable[\"Derdia_Romus_Cautious\"] = true;");

            AddLine(conv, 20, AzmalId, RomusId, "Azmal_Theological_Stakes",
                "Know this, Your Majesty: Smolak's regime has hounded Golcondists through the mountains for decades, while Rizia's own border laws long barred our pilgrims from the Archsanctuary of Plavo and the shrines of our shared Nurist heritage.", -1);

            AddLine(conv, 21, AzmalId, RomusId, "Azmal_Offer_Proposal",
                "Open Rizia's borders to Golcondist pilgrims and guarantee their worship at Plavo and liberated Zille—OR furnish our irregulars with real mountain rifles or gold to wage war! In return, three thousand Golcondist irregulars will cross into southern Wehlen, burning depots and tying down Valdez's reserves.", -1,
                "Variable[\"RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage\"] ~= true");

            AddLine(conv, 121, AzmalId, RomusId, "Azmal_Offer_Proposal_AlreadyAllowed",
                "You already showed rare goodwill in opening your border to our pilgrims, Your Majesty. Reaffirm their sanctuary at Plavo and liberated Zille—or arm our scouts—and three thousand Golcondist irregulars will raid Wehlen's mainland border depots before dawn.", -1,
                "Variable[\"RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage\"] == true");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddLine(conv, 22, SalId, RomusId, "Sal_Ignacius_Warning",
                "Grand Wiseman Sal Ignacius leaned forward, his fingers tightening around his golden Six Stars medallion. \"Your Majesty, granting formal privileges to Golcondist pilgrims will deeply unsettle orthodox Wruhecist clerics—unless you satisfy Azmal with cold coin or surplus steel instead of religious concessions!\"", -1,
                "Variable[\"RiziaDLC.Sal_Arrested\"] ~= true and Variable[\"RiziaDLC.Sal_Executed\"] ~= true");

            AddLine(conv, 122, HugoId, RomusId, "Hugo_Clergy_Warning_NoSal",
                "Hugo murmured beside you with furrowed brow. \"Be cautious, Romus. Opening our sanctuaries to Derdian Golcondists will incense the orthodox clergy—weigh whether surplus rifles or treasury gold wouldn't buy his raiders more cleanly.\"", -1,
                "(Variable[\"RiziaDLC.Sal_Arrested\"] == true or Variable[\"RiziaDLC.Sal_Executed\"] == true) and Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 123, LaurentoId, RomusId, "Laurento_Clergy_Warning_Fallback",
                "Laurento whispered discreetly, \"Bear in mind, Your Majesty, that religious concessions to Derdia will draw sharp criticism from traditionalists unless we trade purely in weapons or subsidies.\"", -1,
                "(Variable[\"RiziaDLC.Sal_Arrested\"] == true or Variable[\"RiziaDLC.Sal_Executed\"] == true) and (Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            foreach (int pId in new[] { 21, 121 })
            {
                AddLink(conv, pId, 22);
                AddLink(conv, pId, 122);
                AddLink(conv, pId, 123);
            }

            AddLine(conv, 23, TitusId, RomusId, "Titus_Tactical_Perspective",
                "Titus Gordion stepped forward respectfully. \"Militarily, Your Majesty, Derdian raids across Wehlen's southern land border force General Valdez to divert brigades away from Zille. Just confirm we actually hold surplus arms or gold before promising material aid.\"", 24,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 124, CarlosId, RomusId, "Carlos_Tactical_Perspective",
                "General Carlos Azaro nodded curtly. \"Militarily, Derdian raids on Wehlen's southern frontier depots will pin down brigades Smolak would otherwise ship to Zille.\"", 24,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            foreach (int wId in new[] { 22, 122, 123 })
            {
                AddLink(conv, wId, 23);
                AddLink(conv, wId, 124);
            }

            var probePrompt = AddLine(conv, 24, NarratorId, RomusId, "Derdia_Probe_Prompt",
                "Before naming your price, you weighed whether to press Azmal on where his mountain fighters would actually strike.");

            probePrompt.outgoingLinks.Add(CreateLink(conv.id, 24, 35));
            probePrompt.outgoingLinks.Add(CreateLink(conv.id, 24, 37));

            AddChoice(conv, 35, AzmalId, "Probe_Derdia_Operations",
                "\"Supreme Wiseman, specify exactly which Wehzek corridors your fighters can hit.\"",
                "Before I commit my word or my depots, Supreme Wiseman: specify exactly where your raiders will strike in southern Wehlen.", 36,
                "Variable[\"Derdia_Probed\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            AddLine(conv, 36, AzmalId, RomusId, "Ack_Probe_Derdia",
                "\"We control the mountain passes north of Naeal,\" Azmal answered smoothly. \"My irregulars will ambush supply trains moving from Wraclawitz toward Grodzizg and Rotsla—forcing Smolak to garrison his interior roads instead of reinforcing Zille.\"", 30);

            AddChoice(conv, 37, AzmalId, "Skip_Probe_Derdia",
                "\"Your word on the raid strength suffices. Let us settle the terms of our pact.\"",
                "Keep your operational routes guarded over open wire, Supreme Wiseman. Let us settle the terms between Rizia and Derdia directly.", 30);

            var pactHub = AddLine(conv, 30, NarratorId, RomusId, "Derdia_Pact_Hub_Prompt",
                "Supreme Wiseman Azmal awaited your verdict on the transceiver, the distant unison chants of the Silver Garrison audible across the line.");

            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Holy Coalition (religious pledge)
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 45)); // Supply 500 Surplus Rifles (requires Equipment >= 1000!)
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 48)); // War Chest Subsidy (requires Budget >= 2!)
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Pragmatic civil protection
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject

            AddChoice(conv, 40, AzmalId, "Accept_Holy_Coalition",
                "\"I pledge by Saint Wruhec: Golcondist pilgrims shall have safe passage to Plavo and liberated Zille.\"",
                "I pledge by my royal honor: Rizia's borders stay open to Golcondist pilgrims, and they shall worship safely at Plavo and liberated Zille. Unleash your irregulars against Wehlen!", 41,
                "Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;");

            AddLine(conv, 41, AzmalId, RomusId, "Ack_Holy_Coalition",
                "Azmal's voice boomed with solemn fervor. \"Halaita! Let the tyrant's chains shatter! My fighters cross Wehlen's border before dawn. May God shield your armies, Your Majesty.\"", -1);

            AddLine(conv, 42, SalId, RomusId, "Sal_Derdia_Grumble",
                "Grand Wiseman Sal murmured a quiet prayer, fingers brushing his Six Stars medallion. \"May Saint Wruhec forgive this concession for the kingdom's peace...\"", -1,
                "Variable[\"RiziaDLC.Sal_Arrested\"] ~= true and Variable[\"RiziaDLC.Sal_Executed\"] ~= true");

            AddLink(conv, 41, 42);

            // Option 45: Surplus Arms Transfer (ONLY if Equipment >= 1000!)
            AddChoice(conv, 45, AzmalId, "Deal_Derdia_Weapons",
                "\"No religious concessions—instead, Rizia will ship 500 surplus rifles for your mountain scouts.\"",
                "Rizia will not alter her sanctuary statutes, yet our arsenals hold abundant surplus steel. Take 500 crates of Rizian rifles and demolish Wehlen's southern rail lines!", 46,
                "Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) - 500; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000");

            AddLine(conv, 46, AzmalId, RomusId, "Ack_Derdia_Weapons",
                "Azmal paused, clearly impressed by the cold pragmatism. \"Good steel speaks louder than parchment promises, King Romus. Deliver those rifles to the border pass, and Wehlen's southern garrisons will burn tonight!\"", -1);

            AddLine(conv, 47, SalId, RomusId, "Sal_Relieved_Weapons",
                "Grand Wiseman Sal exhaled a sigh of profound relief. \"Steel instead of sanctuary decrees... A wise sovereign balance, Your Majesty.\"", -1,
                "Variable[\"RiziaDLC.Sal_Arrested\"] ~= true and Variable[\"RiziaDLC.Sal_Executed\"] ~= true");

            AddLink(conv, 46, 47);

            // Option 48: Gold War Subsidy (ONLY if Budget >= 2!)
            AddChoice(conv, 48, AzmalId, "Deal_Derdia_Budget",
                "\"Leave Wruhecist law intact—accept 2 Budget in gold bullion to equip your irregulars.\"",
                "Rizian religious law remains sovereign, yet our royal treasury will transfer 2 Budget in gold coin to finance your southern border raids against Smolak.", 49,
                "Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 2; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 2");

            AddLine(conv, 49, AzmalId, RomusId, "Ack_Derdia_Budget",
                "\"War requires coin as much as prayer,\" Azmal intoned smoothly. \"Your gold arms the faithful along Wehlen's border tonight, Your Majesty.\"", -1);

            AddChoice(conv, 50, AzmalId, "Counter_Pragmatic_Derdia",
                "\"I guarantee safe civil border transit, but no special sanctuary charters or material aid.\"",
                "I guarantee safe transit and civil protection for Derdian travelers across our borders, but I will not alter our Wruhecist sanctuary laws or drain our depots. Let us strike Smolak as sovereign partners.", 51,
                "Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 51, AzmalId, RomusId, "Ack_Pragmatic_Derdia",
                "Azmal exhaled slowly. \"You bargain with the caution of a king rather than a prophet, Romus. Yet our hatred for Smolak outweighs our disappointment. Our scouts will still raid his southern depots—remember our pilgrims once Zille is yours.\"", -1);

            AddChoice(conv, 60, AzmalId, "Reject_Derdia_Demands",
                "\"Rizia governs its faith and steel without foreign conditions. Keep your raiders behind your border.\"",
                "Rizia answers to Saint Wruhec and the Crown alone. Keep your fighters in Derdia, Supreme Wiseman.", 61,
                "Variable[\"Zille_DerdiaHybridActive\"] = false; Variable[\"RiziaDLC.CountryRelation_Derdia_Unfriendly\"] = true;");

            AddLine(conv, 61, AzmalId, RomusId, "Ack_Reject_Derdia",
                "Static hissed fiercely as Azmal's voice turned frigid. \"Then face Smolak's guns alone, King of Rizia! Do not call Naeal when your campaign stalls.\" The line went dead.", -1);

            AddConversationWithAlias(db, conv, "Zille/DerdiaTalks", "Turn_Zille_DerdiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Derdia Talks (ID 9995) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 7: Turn_Zille_LespiaTalks (ID 9996) - NEGOTIATIONS WITH LESPIA
        // Features:
        // - Prime Minister Alvarez in Perla (never President/Porte Lespia!)
        // - Two-Front Pales War awareness + Zille Bombing Blackmail Option (LESPIA_EVIDENCE!)
        // - Budget/Energy/Army strength checks in hard bargaining!
        // =========================================================================
        public static void RegisterLespiaTalks(DialogueDatabase db)
        {
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
                "In the Foreign Ministry's cramped communications cabinet, brass-rimmed scramblers hummed beside a tall window overlooking Porte Drazon's harbor cranes. Laurento checked his silver pocket watch as the red secure hotline to Perla clicked alive—bringing the unmistakable clink of ice against crystal and a raspy, cigar-thickened cough.", -1);

            AddChoice(conv, 401, NarratorId, "Lespia_Stimulus_Window",
                "Glance down at the merchant freighters loading in Porte Drazon harbor before lifting the receiver.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Lespia_Stimulus_Laurento",
                "Offer Laurento a wry look at Alvarez's theatrical drinking over an official state line.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Lespia_Entry_Harbor",
                "Below the terrace, Rizian tankers and grain barges threaded the breakwater—a quiet reminder of how much Gulf trade depended on what Perla did next.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Lespia_Entry_Laurento",
                "Laurento's lip twitched in a faint, practiced grimace before he tapped the 'Live' switch and stepped back.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, AlvarezId, RomusId, "Alvarez_Opening_Banter",
                "Romus! My royal friend! Don't tell me you called to invite me to an opera in Porte Drazon. Word through Arcasian channels is you're finally ready to kick that clown Smolak out of Zille!", 3,
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true and Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] ~= true)");

            AddLine(conv, 102, AlvarezId, RomusId, "Alvarez_Opening_TwoFront",
                "Have you lost your mind, Romus?! You're firing on our allies in Pales right now, and you dare call Perla expecting intelligence favors against Wehlen?! Give me one good reason not to slam this receiver down!", 3,
                "(Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true or Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] == true)");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);

            var alvarezHub = AddLine(conv, 3, RomusId, AlvarezId, "Romus_Alvarez_Open_Prompt",
                "I leaned against the console, matching Alvarez's brisk shark's tempo while checking what cards lay in my briefcase.");

            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AlvarezId, "Banter_Sarcastic",
                "\"Enjoying an afternoon drink, Patricio? I thought you'd enjoy watching Smolak lose his grip on Zille.\"",
                "Enjoying an afternoon drink, Patricio? I assumed you might appreciate watching someone finally smash Smolak's extortion racket in Zille.", -1,
                "Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddChoice(conv, 11, AlvarezId, "Banter_Business",
                "\"Skip the theatrics, Prime Minister Alvarez. Let us talk reconnaissance and AN vetoes.\"",
                "Skip the theatrics, Prime Minister Alvarez. Let us talk ATO aerial intelligence and diplomatic cover in Konstantium.", -1);

            AddChoice(conv, 12, AlvarezId, "Banter_Pressure",
                "\"Wehlen destabilizes every shipping lane in South Merkopa. Perla has skin in this game too.\"",
                "Smolak's blockade threats poison commerce across the Gulf of Moridia. Removing him from Zille protects Lespian maritime trade whether you admit it or not.", -1,
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 20, AlvarezId, RomusId, "Alvarez_Business_Pitch",
                "Alvarez took a slow sip, dropping the jovial mask for pure capitalist predator. \"Look, Romus, I won't shed a tear if Valdez's boys end up in Zille's marshes. Yet Lespia doesn't run reconnaissance sorties out of charity. You want ATO high-altitude photography of Valdez's hidden bunkers and diplomatic shields in Kyrute.\"", 21,
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true and Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] ~= true)");

            AddLine(conv, 21, AlvarezId, RomusId, "Alvarez_Price_Demand",
                "\"Here's my invoice: twenty percent preferential crude deliveries from your southern fields to Perla PLUS Rizia backing Lespia's seat on the MITZ board. Sign, and my bombers-turned-spotters will hand your generals Valdez's coordinates on a silver tray.\"", 22);

            AddLine(conv, 120, AlvarezId, RomusId, "Alvarez_TwoFront_Pitch",
                "Alvarez laughed coldly into the line. \"You're fighting Reinhart on your eastern front in Pales and asking Perla for help on your southern front?! Bottom line, Romus: either halt the Pales war and yield oil + MITZ terms, or fight Smolak blind!\"", 22,
                "(Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true or Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] == true)");

            foreach (int chId in new[] { 10, 11, 12 })
            {
                AddLink(conv, chId, 20);
                AddLink(conv, chId, 120);
            }

            AddLine(conv, 22, LaurentoId, RomusId, "Laurento_Alvarez_Evaluation",
                "Laurento whispered beside the console: \"ATO aerial photography would cut our battlefield casualties drastically, Your Majesty—yet his oil and MITZ terms are extortionate unless we hold leverage over Perla.\"", 30);

            var dealHub = AddLine(conv, 30, NarratorId, RomusId, "Alvarez_Deal_Hub_Prompt",
                "Alvarez swirled the ice in his crystal tumbler, awaiting your counter-move.");

            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 35)); // Use Bombing Evidence Blackmail! (if LESPIA_EVIDENCE)
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Alvarez Pact (-1 Energy)
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Hard Bargain (requires NO_TWO_FRONT and (PP_STRONG or EQUIP_GE_1000 or LEV>=2))
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 55)); // Diplomatic ambiguity / keep Perla neutral without pact
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject

            // NEW: Blackmail Alvarez with Zille Bombing Evidence!
            AddChoice(conv, 35, AlvarezId, "Blackmail_Alvarez_Zille",
                "\"[DOSSIER LEVERAGE] Drop your price, Patricio—or we publish Perla's fingerprints on the Zille bombing!\"",
                "Drop the corporate ransom, Patricio. My intelligence services hold hard evidence linking Lespian agents to the Zille Friendship Day bombing. Hand over Valdez's bunker coordinates and guard us at the AN—or I read every page to the press in Konstantium!", 36,
                "Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_WehlenHelp\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 3;",
                "(Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true)");

            AddLine(conv, 36, AlvarezId, RomusId, "Ack_Blackmail_Alvarez",
                "A sharp intake of breath hissed across the wire, followed by the dead silence of ice melting untouched. \"...You cold-blooded Toras bastard,\" Alvarez whispered through clenched teeth. \"Fine. Keep those files locked in your safe. ATO reconnaissance photos and diplomatic cover in Kyrute will hit your desk within the hour—free of charge.\"", -1);

            AddChoice(conv, 40, AlvarezId, "Accept_Alvarez_Pact",
                "\"Agreed. Perla receives preferential oil contracts (-1 Energy) for ATO recon and AN shielding.\"",
                "Agreed, Patricio. We guarantee Lespia preferential crude oil deliveries and quiet borders, provided Perla supplies uninterrupted aerial reconnaissance and diplomatic cover at the AN.", 41,
                "Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) - 1; Variable[\"RiziaDLC.CountryRelation_Lespia_Allied\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_WehlenHelp\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Resources_Energy\"] or 0) >= 1");

            AddLine(conv, 41, AlvarezId, RomusId, "Ack_Alvarez_Pact",
                "Alvarez burst into a triumphant laugh, clinking his tumbler against the receiver. \"Now that is statesmanship! Our reconnaissance planes are scrambling out of Perla as we speak, Romus. Happy hunting!\"", -1);

            AddChoice(conv, 50, AlvarezId, "Hard_Bargain_Alvarez",
                "\"[STRENGTH BARGAIN] Ten percent oil contracts, zero MITZ concessions—Rizia fights from strength!\"",
                "Ten percent commercial oil deliveries, and not a single sovereign concession on the MITZ. Our arsenals are well stocked and Rizia isn't begging, Patricio—take our terms before Rizia crushes Wehlen alone and your influence evaporates!", 51,
                "Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_WehlenHelp\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] or 0) - 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true and Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] ~= true) and ((Variable[\"RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming\"] == true or Variable[\"RiziaDLC.Situation_Diplomacy_PowerProjection_Strong\"] == true) or (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 or (Variable[\"Zille_Leverage\"] or 0) >= 2)");

            AddLine(conv, 51, AlvarezId, RomusId, "Ack_Hard_Bargain",
                "Alvarez swore softly under his breath before letting out a grudging bark of respect. \"You drive a harder bargain than your father ever dared, Your Majesty. Fine—ten percent commercial oil it is. Valdez's coordinates hit your war room within the hour.\"", -1);

            AddChoice(conv, 55, AlvarezId, "Stall_Alvarez_Neutrality",
                "\"No energy concessions today, Patricio—stay out of our way at the AN and Rizian ports stay open to Perla.\"",
                "I will not sign away Rizia's energy or MITZ rights tonight, Patricio. Stay neutral in Konstantium, and Rizian shipping lanes remain open to Lespian commerce after the guns fall quiet.", 56,
                "Variable[\"Zille_LespiaPactAccepted\"] = false; Variable[\"Zille_Lespia_Intel\"] = false; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddLine(conv, 56, AlvarezId, RomusId, "Ack_Stall_Alvarez",
                "Alvarez exhaled a slow plume of cigar smoke. \"Always the cautious Toras... Fine. No recon planes for you, then—but Perla won't shed tears in Konstantium if you keep the Gulf shipping lanes moving.\" The receiver clicked down.", -1);

            AddChoice(conv, 60, AlvarezId, "Reject_Alvarez_Greed",
                "\"Rizian blood will not fatten Perla's conglomerates. We take Zille without your charity.\"",
                "Rizian soldiers will not bleed to enrich Lespian oil trusts, Prime Minister. We will defeat Wehlen with our own steel. Good day.", 61,
                "Variable[\"Zille_LespiaPactAccepted\"] = false; Variable[\"Zille_Lespia_Intel\"] = false; Variable[\"RiziaDLC.CountryRelation_Lespia_Unfriendly\"] = true;");

            AddLine(conv, 61, AlvarezId, RomusId, "Ack_Reject_Lespia",
                "Alvarez's amusement froze into venom. \"Good luck against Valdez's mines and bunkers then, Romus. Don't call Perla when your tanks bog down.\" The line snapped dead.", -1);

            AddConversationWithAlias(db, conv, "Zille/LespiaTalks", "Turn_Zille_LespiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Lespia Talks (ID 9996) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 8: Turn_Zille_RumburgTalks (ID 9997) - ROYAL HOTLINE WITH RUMBURG
        // Features:
        // - Queen Beatrice (sister-in-law, NEVER cousin!), Thornbourgh
        // - Fixes shell grant scale (+600/+400/+1000 Military_Equipment instead of +2!)
        // - Checks Lespia pact, Valgsland warmth, Fleet & Equipment (<1000 vs >=1000), Budget>=1!
        // =========================================================================
        public static void RegisterRumburgTalks(DialogueDatabase db)
        {
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
                "In the quiet cedar-paneled Imperial Diplomatic Cabinet, a framed oil portrait of your late wife, Queen Lena Livingston, hung beside the gilded crest of GRACE. On the desk, the brass-and-ivory royal trunk line to Thornbourgh hummed with crystal clarity as Queen Beatrice's secretary announced the connection.", -1);

            AddChoice(conv, 401, NarratorId, "Rumburg_Stimulus_Portrait",
                "Let your gaze linger briefly on Lena's portrait before lifting the ivory receiver.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Rumburg_Stimulus_Tea",
                "Settle into the leather armchair and lift the receiver with brisk sovereign composure.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Rumburg_Entry_Portrait",
                "For a heartbeat, the memory of Lena's quiet grace softened the cold arithmetic of war. Then you lifted the receiver; across two thousand miles of wire, her sister Beatrice's poised, imperious voice filled the room.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Rumburg_Entry_Brisk",
                "The ivory handset felt cool and solid in your palm. Across two thousand miles of wire, Queen Beatrice Livingston's poised, imperious voice echoed into the study.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, BeatriceId, RomusId, "Beatrice_Royal_Greeting",
                "Romus, my dear brother-in-law. We in Thornbourgh have watched your confrontation with that Wehzek upstart closely. A crowned monarch cannot permit a petty dictator to trample the honor of a sister throne.", 3,
                "Variable[\"RiziaDLC.CountryRelation_Rumburg_Hostile\"] ~= true");

            AddLine(conv, 102, BeatriceId, RomusId, "Beatrice_Hostile_Greeting",
                "Your Majesty. Given recent strains between Thornbourgh and Porte Drazon, your call was unexpected—though even I detest Wiktor Smolak's insolence. Speak your mind.", 3,
                "Variable[\"RiziaDLC.CountryRelation_Rumburg_Hostile\"] == true");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);

            var beatriceHub = AddLine(conv, 3, RomusId, BeatriceId, "Romus_Beatrice_Open_Prompt",
                "I straightened my tunic, addressing Lena's sister with the formal dignity expected between royal courts.");

            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, BeatriceId, "Solidarity_Royal",
                "\"Your Majesty. House Toras stands resolute, and our two crowns share one honor.\"",
                "Beatrice, it is good to hear your voice. House Toras stands resolute. Over twenty-five years of Wehzek defiance will be answered with royal steel.", 20,
                "Variable[\"Rumburg_Romus_Loyal\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddChoice(conv, 11, BeatriceId, "Munitions_Request",
                "\"Beatrice, our batteries need heavy artillery munitions and AN diplomatic shielding.\"",
                "Your Majesty. Rizia's cause is just, yet our brigades need heavy-caliber shells and firm diplomatic shielding in Konstantium against Contanan meddling.", 20,
                "Variable[\"Rumburg_Romus_Munitions\"] = true;");

            AddChoice(conv, 12, BeatriceId, "Sovereign_Assertive",
                "\"Rizia will shed its own blood in Zille, though GRACE solidarity strengthens both our crowns.\"",
                "Rizia will fight and win with its own blood, yet monarchist solidarity within GRACE will prove to Merkopa that crowns stand unbroken.", 20,
                "Variable[\"Rumburg_Romus_Proud\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 20, BeatriceId, RomusId, "Beatrice_Imperial_Offer",
                "Spoken like a true king, Romus. Thornbourgh will not watch quietly while republican rabble mocks a sister monarchy. Rumburg can route freight trains carrying 152mm heavy artillery munitions and surplus rifles directly toward Brenas, and our envoy in Konstantium will fight Contanan sanctions.", -1);

            AddLine(conv, 21, BeatriceId, RomusId, "Beatrice_AN_Pledge",
                "One expectation remains: Rizia must remain a proud pillar of GRACE, keeping Arcasian and Lespian profiteers from dictating Porte Drazon's policy.", -1,
                "Variable[\"Zille_LespiaPactAccepted\"] ~= true");

            AddLine(conv, 121, BeatriceId, RomusId, "Beatrice_AN_Pledge_LespiaWarn",
                "Still, dispatches from Perla warn me you have already been bargaining with Prime Minister Alvarez! Do not sell your dignity to ATO merchants, Romus—Rumburg helps a sovereign king, not a Lespian client state.", -1,
                "Variable[\"Zille_LespiaPactAccepted\"] == true");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            // Context check: Low Equip (<1000) vs Strong Equip (>=1000) + Hugo fallback
            AddLine(conv, 22, HugoId, RomusId, "Hugo_Beatrice_Support_NeedArms",
                "Hugo inclined his head with relief. \"Your Majesty, with our own depots currently holding under a thousand reserve weapons, Thornbourgh's rail shipments of shells and rifles could save an entire offensive!\"", 30,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000");

            AddLine(conv, 23, HugoId, RomusId, "Hugo_Beatrice_Support_FullArms",
                "Hugo nodded with deep pride. \"Our own armories already stand well above a thousand weapons, yet Rumburg's heavy 152mm shells and AN shield will make Valdez's bunkers indefensible!\"", 30,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true and (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000");

            AddLine(conv, 122, LaurentoId, RomusId, "Laurento_Beatrice_Support",
                "Laurento murmured discreetly, \"Thornbourgh's diplomatic cover at Konstantium and those heavy artillery trains strengthen our hand dramatically, Your Majesty.\"", 30,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            foreach (int pId in new[] { 21, 121 })
            {
                AddLink(conv, pId, 22);
                AddLink(conv, pId, 23);
                AddLink(conv, pId, 122);
            }

            var responseHub = AddLine(conv, 30, NarratorId, RomusId, "Beatrice_Response_Prompt",
                "Queen Beatrice waited on the royal line with cool regal authority for your response.");

            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Full GRACE pledge (+600 Equip)
            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 45)); // Purchase Expanded Shipment (-1 Budget -> +1000 Equip!)
            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Pragmatic royal thanks (+400 Equip)

            AddChoice(conv, 40, BeatriceId, "Pledge_GRACE_Solidarity",
                "\"House Toras pledges steadfast solidarity to GRACE (+600 Military Equipment, AN cover).\"",
                "House Toras pledges steadfast solidarity to GRACE and our royal kinship, Beatrice. For Lena's memory and our sister crowns, accept my bond!", 41,
                "Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Allied\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 600; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddLine(conv, 41, BeatriceId, RomusId, "Ack_Beatrice_Pledge",
                "Beatrice smiled with imperious satisfaction. \"Splendid, Romus. Three full trains of 152mm shells and six hundred crates of reserve armaments depart for Brenas tonight. Claim what is yours.\"", -1);

            AddChoice(conv, 45, BeatriceId, "Purchase_Rumburg_Expansion",
                "\"We back GRACE—and pay 1 Budget upfront for double rail consignments (+1,000 Military Equipment)!\"",
                "In addition to GRACE solidarity, our treasury releases 1 Budget upfront to double the heavy shell and rifle shipments bound for Brenas immediately!", 46,
                "Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 1; Variable[\"RiziaDLC.CountryRelation_Rumburg_Allied\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 1000; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1");

            AddLine(conv, 46, BeatriceId, RomusId, "Ack_Beatrice_Expanded",
                "\"Prompt payment and royal resolve—my favorite virtues in a brother-in-law!\" Beatrice replied warmly. \"Six heavy ordnance trains roll south tonight. Smolak's trenches won't survive them.\"", -1);

            AddChoice(conv, 50, BeatriceId, "Grateful_Sovereign",
                "\"We accept your munitions with royal gratitude without binding military pledges (+400 Equipment).\"",
                "We accept your heavy shells and goodwill with deep gratitude, Beatrice, while keeping Rizia's strategic commitments flexible.", 51,
                "Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Friendly\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 400; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 51, BeatriceId, RomusId, "Ack_Beatrice_Sovereign",
                "\"May victory crown your banners, Romus. Send word when Zille returns under Toras colors.\" The imperial trunk line softly clicked silent.", -1);

            AddConversationWithAlias(db, conv, "Zille/RumburgTalks", "Turn_Zille_RumburgTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Rumburg Talks (ID 9997) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 9: Turn_Zille_WarPreNegotiationsBriefing (ID 9991) - PRE-NEGOTIATIONS
        // Assesses actual Zille vs Pales losses, Leverage strength, Equipment/Budget stamina
        // =========================================================================
        public static void RegisterWarPreNegotiationsBriefing(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarPreNegotiationsBriefing") != null && db.GetConversation("Zille/WarPreNegotiationsBriefing") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPreNegotiations;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Zille/WarPreNegotiationsBriefing";
            conv.ActorID = RomusId;
            conv.ConversantID = LaurentoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LaurentoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "PreNeg_Intro_1",
                "The heavy artillery had fallen eerily silent along the smoke-shrouded Zille frontier and across the Gulf of Moridia. Beside the battle maps in Palas Rezna lay urgent telegrams from Konstantium. Wiktor Smolak had dispatched an envoy under white flags proposing a face-to-face parley.", -1);

            AddLine(conv, 2, LucitaId, RomusId, "Lucita_PreNeg_Report",
                "Your Majesty. A temporary ceasefire holds across Zille. Both armies have expended immense shells, and Smolak's delegation awaits at the neutral pavilion overlooking the peninsula.", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 102, CarlosId, RomusId, "Carlos_PreNeg_Report",
                "Your Majesty. Both fronts stand in a fragile truce. Our generals tally our exact Zille losses separately from any eastern Pales casualties as Smolak awaits your arrival at the pavilion.", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            // Leverage & Diplomatic Assessment
            AddLine(conv, 3, LaurentoId, RomusId, "Laurento_PreNeg_HighLeverage",
                "The Alliance of Nations watches closely, Your Majesty—and thanks to the evidence, treaties, and diplomatic groundwork you assembled throughout this crisis, you enter that pavilion holding genuine leverage over Smolak.", -1,
                "(Variable[\"Zille_Leverage\"] or 0) >= 4");

            AddLine(conv, 103, LaurentoId, RomusId, "Laurento_PreNeg_LowLeverage",
                "The Alliance of Nations presses for settlement, Your Majesty. Because our diplomatic leverage remains limited, what you salvage or dictate across that table will depend almost entirely on what our soldiers presently hold on the ground.", -1,
                "not ((Variable[\"Zille_Leverage\"] or 0) >= 4)");

            foreach (int p in new[] { 2, 102 })
            {
                AddLink(conv, p, 3);
                AddLink(conv, p, 103);
            }

            AddLine(conv, 4, HugoId, RomusId, "Hugo_PreNeg_Counsel",
                "Romus... Smolak shifts between buffoon and butcher in a heartbeat. Guard the dignity of House Toras, and never let him think our depots or treasury are weaker than they are.", 10,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 104, LaurentoId, RomusId, "Laurento_PreNeg_NoHugo",
                "Remember Smolak's nature, Your Majesty—he alternates between clownish jokes and vicious blackmail. Keep your cards close to your chest.", 10,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            foreach (int prev in new[] { 3, 103 })
            {
                AddLink(conv, prev, 4);
                AddLink(conv, prev, 104);
            }

            var preNegHub = AddLine(conv, 10, RomusId, LaurentoId, "Romus_PreNeg_Prompt",
                "I studied the final map positions, our separate casualty ledgers, and my leather briefcase before stepping down to the waiting armored motorcade.");

            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11)); // Review separate Zille vs Pales losses & armory stamina
            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12)); // Review Leverage cards in briefcase

            AddChoice(conv, 11, ElenaId, "PreNeg_Check_Ledger",
                "\"Elena, brief me on our exact Zille losses, any Pales drain, and whether our depots could sustain renewed fighting.\"",
                "Give me the exact numbers before we depart: how do our Zille losses compare separately from Pales, and can our treasury and arsenals back an ultimatum if Smolak walks out?", -1,
                "Variable[\"Zille_PreNeg_CheckedLedger\"] = true;");

            AddLine(conv, 111, ElenaId, RomusId, "Ack_PreNeg_Strong",
                "\"Our separate Zille casualty ledger stays manageable, and with over 1,000 weapons in stock and healthy treasury reserves, Smolak knows we are not bluffing if talks collapse.\"", 15,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 and (Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1",
                "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            AddLine(conv, 112, ElenaId, RomusId, "Ack_PreNeg_Thin",
                "\"Keep a calm face in the pavilion, Your Majesty: whether from fierce Zille attrition, Pales draining our reserves, or depots sitting under 1,000 weapons, renewed all-out combat would strain our treasury severely. Use diplomacy and leverage ruthlessly.\"", 15,
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000 or (Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 1");

            AddLink(conv, 11, 111);
            AddLink(conv, 11, 112);

            AddChoice(conv, 12, LaurentoId, "PreNeg_Check_Leverage",
                "\"Laurento, list every diplomatic card we hold against Smolak inside that briefcase.\"",
                "Before we board the motorcade, list every piece of leverage we hold against Wiktor Smolak right now—treaties, intelligence dossiers, foreign pacts, and blockades.", 121,
                "Variable[\"Zille_PreNeg_CheckedLeverage\"] = true;");

            AddLine(conv, 121, LaurentoId, RomusId, "Ack_PreNeg_Leverage",
                "\"Your case rests on the lapsed 1927 agreement, any Zille bombing intelligence you preserved, naval pressure across the Gulf of Moridia, and whatever pacts you sealed with Naeal, Perla, or Thornbourgh. Strike him with whichever weakness cuts deepest first.\"", 15);

            // En route in the Royal Armored Motorcade
            var motorcadeNode = AddLine(conv, 15, NarratorId, RomusId, "PreNeg_Motorcade_Travel",
                "Twenty minutes later, the royal armored motorcade rolled northwest along the mud-rutted Brenas highway toward the Zille border. Golden Guard motorcycle outriders splashed through rain puddles ahead of your limousine, passing empty artillery caissons and tired infantrymen resting by roadside campfires who snapped to salute as the Toras pennant swept past.");

            motorcadeNode.outgoingLinks.Add(CreateLink(conv.id, 15, 401));
            motorcadeNode.outgoingLinks.Add(CreateLink(conv.id, 15, 402));

            AddChoice(conv, 401, NarratorId, "PreNeg_Stimulus_Window",
                "Crack the heavy armored window an inch to breathe the wet pine and salt air—and wave to the roadside soldiers.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "PreNeg_Stimulus_Briefcase",
                "Keep the glass sealed and run your thumb over the brass clasp of the leather dossier on your knee.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "PreNeg_Travel_Wave",
                "Cold coastal wind rushed into the cabin, smelling of wet pine and distant cordite. A corporal with a bandaged wrist grinned through the grime as your gloved hand appeared at the glass. Up ahead, the white flags of the neutral pavilion came into view on the ridge.", 16);

            AddLine(conv, 405, NarratorId, RomusId, "PreNeg_Travel_Briefcase",
                "Inside the quiet, leather-scented cabin, the muffled thrum of the engine steadied your thoughts. Every signature, cargo manifest, and intelligence cable you had gathered lay beneath that brass clasp. Up ahead, the white flags of the neutral pavilion rose against the gray sky.", 16);

            var finalPosture = AddLine(conv, 16, NarratorId, RomusId, "PreNeg_Pavilion_Approach",
                "The motorcade slowed before the cordoned perimeter. Your escort awaited your final instruction before you stepped out to face Wiktor Smolak.");

            finalPosture.outgoingLinks.Add(CreateLink(conv.id, 16, 20));
            finalPosture.outgoingLinks.Add(CreateLink(conv.id, 16, 200));
            finalPosture.outgoingLinks.Add(CreateLink(conv.id, 16, 21));

            AddChoice(conv, 20, LaurentoId, "Choice_Parley_Strength",
                "\"Halt the motorcade. I will meet Smolak and play our cards face to face.\"",
                "Halt the motorcade. I will meet Smolak under the royal standard and dictate or bargain cleanly.", -1,
                "Variable[\"Zille_Parley_Ready\"] = true;");

            AddChoice(conv, 200, LaurentoId, "Choice_Parley_Guarded",
                "\"Keep our cards close and let Smolak show his hand first inside the pavilion.\"",
                "Halt the motorcade. Keep our dossiers sealed until we hear what Smolak tries first across the table.", -1,
                "Variable[\"Zille_Parley_Ready\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddChoice(conv, 21, LaurentoId, "Choice_Unconditional_Surrender",
                "\"Tell Smolak our guns stay loaded—with full depots behind us, stalling means renewed bombardment!\"",
                "Inform Smolak that if he stalls in that pavilion, our batteries and ships reopen fire within the hour. We bargain from unmistakable steel.", -1,
                "Variable[\"Zille_Parley_Ready\"] = true; Variable[\"Zille_Parley_Uncompromising\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "((Variable[\"Zille_War_Outcome\"] or 0) >= 3 or (Variable[\"Zille_War_Outcome\"] or 0) == 0) and ((Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 or (Variable[\"Zille_Leverage\"] or 0) >= 2)");

            AddLine(conv, 22, LucitaId, RomusId, "Ack_PreNeg_Lucita",
                "Lucita strapped on her sidearm and saluted with iron resolve. \"The royal escort is mounted, Your Majesty. Let us bring Zille home.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 122, CarlosId, RomusId, "Ack_PreNeg_Carlos",
                "General Carlos Azaro snapped a crisp salute. \"The armored escort is ready, Your Majesty.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            foreach (int chId in new[] { 20, 200, 21 })
            {
                AddLink(conv, chId, 22);
                AddLink(conv, chId, 122);
            }

            AddConversationWithAlias(db, conv, "Zille/WarPreNegotiationsBriefing", "Turn_Zille_WarPreNegotiationsBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Pre-Negotiations Briefing (ID 9991) into masterDatabase!");
        }
    }
}
