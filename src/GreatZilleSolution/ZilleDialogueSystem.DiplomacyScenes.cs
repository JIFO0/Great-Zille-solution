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
        // Fixed: Supreme Wiseman Jorga Azmal, Silver Garrison outside Naeal,
        // Grand Wiseman Sal Ignacius (no pectoral cross/crossing himself!),
        // real Golcondist pilgrimage stakes (lifting border ban & Plavo/Zille access),
        // Sal/Titus arrest checks & pre-existing Derdia hostility checks.
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
                "The private royal telecommunications chamber was heavy with the aroma of burning sandalwood and frankincense. Over the encrypted high-frequency transceiver from the Silver Garrison outside Naeal, the resonant baritone of Supreme Wiseman Jorga Azmal cut through the static with austere authority.", -1);

            AddLine(conv, 2, AzmalId, RomusId, "Azmal_Opening_Greeting",
                "May God's light guide you, Your Majesty. The mountain winds carry whispers of iron and smoke rising along Wehlen's borders. You prepare to strike the butcher of Wraclawitz, do you not?", 3,
                "Variable[\"RiziaDLC.CountryRelation_Derdia_Hostile\"] ~= true");

            AddLine(conv, 102, AzmalId, RomusId, "Azmal_Opening_Hostile",
                "I am surprised the King of Rizia dares call the Silver Garrison after all the insults our faithful have endured, Your Majesty. Yet even an estranged neighbor becomes useful when Wiktor Smolak stands across the border. Speak quickly.", 3,
                "Variable[\"RiziaDLC.CountryRelation_Derdia_Hostile\"] == true");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var azmalHub = AddLine(conv, 3, RomusId, AzmalId, "Romus_Azmal_Open_Prompt",
                "I leaned toward the gilded receiver, measuring my words before the Supreme Wiseman of Derdia.");

            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AzmalId, "Choice_Faith_Justice",
                "\"Smolak has persecuted the faithful and oppressed Bludish and Rizian believers alike. Justice demands action.\"",
                "Smolak has trampled sacred law and tormented believers across Wehlen and Zille for far too long. As followers of Saint Wruhec, justice demands that the sword be drawn against him.", 20,
                "Variable[\"Derdia_Romus_Faithful\"] = true;");

            AddChoice(conv, 11, AzmalId, "Choice_Military_Pragmatism",
                "\"Wehlen is our common adversary. A coordinated strike will break his stranglehold on both our borders.\"",
                "Wehlen is our common adversary, Supreme Wiseman. If Rizia strikes Zille and the Gulf ports while Derdia applies pressure on Wehlen's southern land border, Smolak's army will crack under two fronts.", 20,
                "Variable[\"Derdia_Romus_Pragmatic\"] = true;");

            AddChoice(conv, 12, AzmalId, "Choice_Question_Motives",
                "\"What interest does Derdia possess in our campaign for Zille?\"",
                "What interest does Derdia possess in the outcome of our conflict over Zille, Supreme Wiseman? Speak plainly.", 20,
                "Variable[\"Derdia_Romus_Cautious\"] = true;");

            AddLine(conv, 20, AzmalId, RomusId, "Azmal_Theological_Stakes",
                "Know this, Your Majesty: Smolak's regime has slaughtered Bludish Golcondists in the mountains for decades, while Rizia's own border laws have barred our pilgrims from the Archsanctuary of Plavo and the sacred shrines of our shared Nurist heritage.", -1);

            AddLine(conv, 21, AzmalId, RomusId, "Azmal_Offer_Proposal",
                "Pledge by your royal word to keep Rizia's borders open to Golcondist pilgrims and guarantee their safety at Plavo and the sanctuaries of liberated Zille. In return, three thousand seasoned Golcondist irregulars and mountain scouts will raid Wehlen's southern frontier—cutting telegraph lines, torching Valdez's supply depots, and tying down his reserves.", -1,
                "Variable[\"RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage\"] ~= true");

            AddLine(conv, 121, AzmalId, RomusId, "Azmal_Offer_Proposal_AlreadyAllowed",
                "You showed rare goodwill by permitting our pilgrims across your border, Your Majesty. Formalize that protection for our faithful in Plavo and liberated Zille, and three thousand Golcondist irregulars will strike Wehlen's southern frontier depots tonight.", -1,
                "Variable[\"RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage\"] == true");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddLine(conv, 22, SalId, RomusId, "Sal_Ignacius_Warning",
                "Grand Wiseman Sal Ignacius leaned forward, his fingers tightening around his golden Six Stars medallion. \"Your Majesty, tread cautiously! Encouraging Golcondist pilgrims in Plavo and Zille will deeply unsettle the orthodox Wruhecist hierarchy!\"", -1,
                "Variable[\"RiziaDLC.Sal_Arrested\"] ~= true and Variable[\"RiziaDLC.Sal_Executed\"] ~= true");

            AddLine(conv, 122, HugoId, RomusId, "Hugo_Clergy_Warning_NoSal",
                "Hugo murmured beside you with furrowed brow. \"Be cautious, Romus. Opening our sanctuaries to Derdian Golcondists will provoke fierce outcry among the orthodox clergy.\"", -1,
                "(Variable[\"RiziaDLC.Sal_Arrested\"] == true or Variable[\"RiziaDLC.Sal_Executed\"] == true) and Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 123, LaurentoId, RomusId, "Laurento_Clergy_Warning_Fallback",
                "Laurento whispered discreetly, \"Bear in mind, Your Majesty, that religious concessions to Derdia will draw sharp criticism from traditionalist Wruhecist leaders at home.\"", -1,
                "(Variable[\"RiziaDLC.Sal_Arrested\"] == true or Variable[\"RiziaDLC.Sal_Executed\"] == true) and (Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            foreach (int pId in new[] { 21, 121 })
            {
                AddLink(conv, pId, 22);
                AddLink(conv, pId, 122);
                AddLink(conv, pId, 123);
            }

            AddLine(conv, 23, TitusId, RomusId, "Titus_Tactical_Perspective",
                "Titus Gordion stepped forward respectfully. \"From a military standpoint, Your Majesty, Derdian guerrilla raids across Wehlen's southern border will force General Valdez to split his reserves and leave Zille under-reinforced.\"", 30,
                "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            AddLine(conv, 124, CarlosId, RomusId, "Carlos_Tactical_Perspective",
                "General Carlos Azaro nodded curtly. \"Militarily, Your Majesty, Derdian raids on Wehlen's southern depots will pin down brigades Smolak would otherwise ship to Zille.\"", 30,
                "(Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true)");

            foreach (int wId in new[] { 22, 122, 123 })
            {
                AddLink(conv, wId, 23);
                AddLink(conv, wId, 124);
            }

            var pactHub = AddLine(conv, 30, NarratorId, RomusId, "Derdia_Pact_Hub_Prompt",
                "Supreme Wiseman Azmal awaited your verdict on the transceiver, the distant unison chants of the Silver Garrison audible across the line.");

            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Holy Coalition
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Pragmatic Compromise
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject Faith Interference

            AddChoice(conv, 40, AzmalId, "Accept_Holy_Coalition",
                "\"I pledge by Saint Wruhec: Golcondist pilgrims shall have safe passage to Plavo and liberated Zille.\"",
                "I pledge by Saint Wruhec and my royal honor: Rizia's borders will remain open to Golcondist pilgrims, and they shall worship safely in Plavo and liberated Zille. Unleash your irregulars against Wehlen's southern frontier!", 41,
                "Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.Decision_Turn03_GolcondistPilgrims_AllowPassage\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] or 0) + 2;");

            AddLine(conv, 41, AzmalId, RomusId, "Ack_Holy_Coalition",
                "Azmal's voice boomed with solemn fervor over the receiver. \"Halaita! Let the chains of the tyrant be broken! My fighters will cross into southern Wehlen before dawn. May God shield your armies, Your Majesty.\"", -1);

            AddLine(conv, 42, SalId, RomusId, "Sal_Derdia_Grumble",
                "Grand Wiseman Sal murmured a quiet prayer, pressing his palm to his Six Stars medallion. \"May Saint Wruhec forgive this compromise for the sake of the kingdom's peace...\"", -1,
                "Variable[\"RiziaDLC.Sal_Arrested\"] ~= true and Variable[\"RiziaDLC.Sal_Executed\"] ~= true");

            AddLink(conv, 41, 42);

            AddChoice(conv, 50, AzmalId, "Counter_Pragmatic_Derdia",
                "\"I guarantee safe border transit and civil protection, but no special sanctuary privileges.\"",
                "I can guarantee safe transit and police protection for Derdian travelers across our borders, but I will not alter our Wruhecist sanctuary laws. Let us strike Smolak together as sovereign partners.", 51,
                "Variable[\"Zille_DerdiaHybridActive\"] = true;");

            AddLine(conv, 51, AzmalId, RomusId, "Ack_Pragmatic_Derdia",
                "Azmal paused in silent reflection before exhaling slowly. \"You speak with the cautious tongue of a king rather than a prophet, Romus. Yet our hatred for Smolak outweighs our disappointment. Our mountain scouts will raid his supply depots—but remember your promise to our pilgrims when Zille is yours.\"", -1);

            AddChoice(conv, 60, AzmalId, "Reject_Derdia_Demands",
                "\"Rizia upholds its own religious laws without foreign conditions. Keep your fighters behind your borders.\"",
                "Rizia answers to Saint Wruhec and the Crown alone. We will not barter our sanctuary laws for irregular raiders. Keep your fighters in Derdia, Supreme Wiseman.", 61,
                "Variable[\"Zille_DerdiaHybridActive\"] = false; Variable[\"RiziaDLC.CountryRelation_Derdia_Unfriendly\"] = true;");

            AddLine(conv, 61, AzmalId, RomusId, "Ack_Reject_Derdia",
                "Static hissed fiercely as Azmal's tone turned frigid. \"Then face Smolak's guns alone, King of Rizia! Do not look to Naeal when your campaign stalls.\" The line severed with a sharp click.", -1);

            AddConversationWithAlias(db, conv, "Zille/DerdiaTalks", "Turn_Zille_DerdiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Derdia Talks (ID 9995) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 7: Turn_Zille_LespiaTalks (ID 9996) - NEGOTIATIONS WITH LESPIA
        // Fixed: Prime Minister Alvarez (not President!), Perla (not Porte Lespia!),
        // No desert buzzards, Two-Front Pales War & sanctions awareness!
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
                "The red secure hotline to Perla clicked alive with the unmistakable clink of ice cubes against crystal glass, followed by a raspy cough and a satisfied exhale of cigar smoke.", -1);

            AddLine(conv, 2, AlvarezId, RomusId, "Alvarez_Opening_Banter",
                "Romus! My royal friend! Don't tell me you called to invite me to another stuffy opera in Porte Drazon. Word through Arcasian channels is that you're finally ready to give that clown Smolak the thrashing he's been begging for!", 3,
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true)");

            AddLine(conv, 102, AlvarezId, RomusId, "Alvarez_Opening_TwoFront",
                "Have you completely lost your mind, Romus?! You're already firing on our allies in Pales, and now you call Perla expecting favors for a campaign against Wehlen? Give me one good reason not to hang up right now!", 3,
                "(Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true)");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var alvarezHub = AddLine(conv, 3, RomusId, AlvarezId, "Romus_Alvarez_Open_Prompt",
                "I leaned against the console, matching Alvarez's brisk tempo while keeping my guard up.");

            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, AlvarezId, "Banter_Sarcastic",
                "\"Enjoying an afternoon drink, Patricio? I thought you might appreciate seeing Wehlen's teeth kicked in.\"",
                "Enjoying an afternoon drink, Patricio? I assumed you might appreciate watching someone finally kick Wehlen's teeth in.", -1);

            AddChoice(conv, 11, AlvarezId, "Banter_Business",
                "\"Let us skip the theatrics, Prime Minister Alvarez. We both know why this line was opened.\"",
                "Let us skip the theatrics, Prime Minister Alvarez. We both know why this hotline was opened. Let us talk about intelligence and regional security.", -1);

            AddChoice(conv, 12, AlvarezId, "Banter_Pressure",
                "\"Wehlen is destabilizing South Merkopa. Lespia has a direct economic stake in our success.\"",
                "Wehlen's bandit regime destabilizes every trade route in the region. If Smolak holds Zille indefinitely, shipping across the Gulf of Moridia remains at his mercy.", -1);

            AddLine(conv, 20, AlvarezId, RomusId, "Alvarez_Business_Pitch",
                "Alvarez took another sip, his tone shifting from jovial schemer to sharp capitalist shark. \"Look, Romus, I won't shed a single tear if Valdez's goons end up rotting in the Zille mud. But Lespia isn't a charity. You want our high-altitude ATO reconnaissance flights to map Valdez's camouflaged bunkers, and you want Arcasian-encrypted radios so your armor doesn't walk into an ambush.\"", 21,
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true)");

            AddLine(conv, 21, AlvarezId, RomusId, "Alvarez_Price_Demand",
                "\"Here is my price: twenty percent guaranteed crude oil deliveries from your southern wells to Lespian refineries at preferential rates, PLUS Rizia's vote backing Lespia's position on the MITZ board. Agree, and my defense ministry will feed your generals live coordinates to blow Valdez's headquarters straight off the map.\"", 22);

            AddLine(conv, 120, AlvarezId, RomusId, "Alvarez_TwoFront_Pitch",
                "Alvarez laughed coldly into the receiver. \"You want ATO reconnaissance on Wehlen while your navy is blockading Duke Reinhart in Pales? Bottom line, Romus: call off your ships from Pales and commit to a full energy pact with Lespia, or you can fight Smolak blind!\"", 22,
                "(Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true)");

            foreach (int chId in new[] { 10, 11, 12 })
            {
                AddLink(conv, chId, 20);
                AddLink(conv, chId, 120);
            }

            AddLine(conv, 22, LaurentoId, RomusId, "Laurento_Alvarez_Evaluation",
                "Laurento leaned close to the receiver, speaking in a low whisper. \"Your Majesty, Alvarez's oil terms are steep, yet ATO aerial reconnaissance would drastically reduce our casualties and grant our commanders total battlefield clarity. We can press him down if we leverage his hatred of Smolak.\"", 30);

            var dealHub = AddLine(conv, 30, NarratorId, RomusId, "Alvarez_Deal_Hub_Prompt",
                "Alvarez swirled the ice in his glass, awaiting your counter-offer.");

            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Alvarez terms
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Hard bargain
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject

            AddChoice(conv, 40, AlvarezId, "Accept_Alvarez_Pact",
                "\"Agreed. Lespia gets preferential oil contracts in exchange for ATO reconnaissance and diplomatic cover.\"",
                "Agreed, Patricio. We will guarantee your preferential oil contracts and peace along the northern seas, provided Perla delivers uninterrupted aerial reconnaissance and diplomatic cover at the AN.", 41,
                "Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.CountryRelation_Lespia_Allied\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_WehlenHelp\"] = true;");

            AddLine(conv, 41, AlvarezId, RomusId, "Ack_Alvarez_Pact",
                "Alvarez burst into a hearty laugh, clinking his glass against the receiver. \"Now that is statesmanship! Consider it done, Romus. Our reconnaissance planes are scrambling out of Perla as we speak. Happy hunting in Zille!\"", -1);

            AddChoice(conv, 50, AlvarezId, "Hard_Bargain_Alvarez",
                "\"Ten percent oil contracts, and zero concessions on the MITZ. Take it, or we fight without you.\"",
                "Ten percent oil contracts on commercial terms, and not a single sovereign concession on the MITZ. Take it or leave it, Patricio. If Rizia crushes Wehlen alone, your leverage in South Merkopa evaporates.", 51,
                "Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] or 0) - 1;",
                "(Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true)");

            AddLine(conv, 51, AlvarezId, RomusId, "Ack_Hard_Bargain",
                "Alvarez swore softly under his breath before letting out an amused grunt. \"You drive a harder bargain than your father ever did, Your Majesty. Fine—ten percent it is. The radar coordinates will be in your war room within the hour.\"", -1);

            AddChoice(conv, 60, AlvarezId, "Reject_Alvarez_Greed",
                "\"Rizian blood will not be bartered for Lespian corporate profits. We will reclaim Zille on our own terms.\"",
                "Rizian soldiers will not bleed to fatten your oil conglomerates, Prime Minister Alvarez. The Royal Army does not require Lespian charity to defeat Wehlen. Good day.", 61,
                "Variable[\"Zille_LespiaPactAccepted\"] = false; Variable[\"Zille_Lespia_Intel\"] = false; Variable[\"RiziaDLC.CountryRelation_Lespia_Unfriendly\"] = true;");

            AddLine(conv, 61, AlvarezId, RomusId, "Ack_Reject_Lespia",
                "Alvarez's amusement vanished instantly into cold venom. \"Then good luck against Valdez's mines and artillery, Romus. Don't come begging to Perla when your tanks are burning in the mud.\" The line went dead.", -1);

            AddConversationWithAlias(db, conv, "Zille/LespiaTalks", "Turn_Zille_LespiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Lespia Talks (ID 9996) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 8: Turn_Zille_RumburgTalks (ID 9997) - ROYAL HOTLINE WITH RUMBURG
        // Fixed: Beatrice is Romus's SISTER-IN-LAW (NOT Cousin!), Hugo absent variant,
        // GRACE / Rumburg hostility check, Lespia pact tension check!
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
                "The brass-and-ivory royal trunk line to Thornbourgh buzzed with crystal clarity. Across two thousand miles of wire, the poised, imperious voice of Queen Beatrice Livingston echoed into the study, carrying all the weight of your late wife Lena's royal house.", -1);

            AddLine(conv, 2, BeatriceId, RomusId, "Beatrice_Royal_Greeting",
                "Romus, my dear brother-in-law. We in Thornbourgh have watched your confrontation with that Wehzek upstart with keen interest. A sovereign monarch cannot allow a petty dictator to trample the honor of a sister crown.", 3,
                "Variable[\"RiziaDLC.CountryRelation_Rumburg_Hostile\"] ~= true");

            AddLine(conv, 102, BeatriceId, RomusId, "Beatrice_Hostile_Greeting",
                "Your Majesty. Given recent disappointments between Thornbourgh and Porte Drazon, I was surprised to hear your call—though even I have little patience for Wiktor Smolak's antics. Speak your mind.", 3,
                "Variable[\"RiziaDLC.CountryRelation_Rumburg_Hostile\"] == true");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var beatriceHub = AddLine(conv, 3, RomusId, BeatriceId, "Romus_Beatrice_Open_Prompt",
                "I straightened my tunic, addressing Lena's sister with the formal dignity expected between two royal courts.");

            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11));
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12));

            AddChoice(conv, 10, BeatriceId, "Solidarity_Royal",
                "\"Your Majesty. House Toras stands resolute, and we are determined to restore our rightful borders.\"",
                "Beatrice, it is good to hear your voice. House Toras stands resolute. Over twenty-five years of Wehzek insolence will be answered with royal steel.", 20,
                "Variable[\"Rumburg_Romus_Loyal\"] = true;");

            AddChoice(conv, 11, BeatriceId, "Munitions_Request",
                "\"Your Majesty, Rizia requires heavy artillery shells and diplomatic shielding in the Alliance of Nations.\"",
                "Your Majesty. Rizia's cause is just, yet our campaign requires heavy-caliber munitions and strong diplomatic shielding in the Alliance of Nations against Contanan interference.", 20,
                "Variable[\"Rumburg_Romus_Munitions\"] = true;");

            AddChoice(conv, 12, BeatriceId, "Sovereign_Assertive",
                "\"Rizia will win this campaign with its own blood, though GRACE solidarity is welcomed.\"",
                "Rizia will fight and win this campaign with our own blood, yet solidarity among the monarchies of GRACE will show the world that our crowns stand together.", 20,
                "Variable[\"Rumburg_Romus_Proud\"] = true;");

            AddLine(conv, 20, BeatriceId, RomusId, "Beatrice_Imperial_Offer",
                "You speak as a true king, Romus. Rumburg will not stand idly by while republican rabble mocks an allied throne. We have instructed our naval attachés to monitor shipping in the Gulf, and three freight trains carrying 152mm heavy artillery munitions from our royal arsenals can be routed toward Brenas.", -1);

            AddLine(conv, 21, BeatriceId, RomusId, "Beatrice_AN_Pledge",
                "Furthermore, our envoy in Konstantium will wield Rumburg's weight in the Alliance of Nations to blunt any sanctions Hegel or Malenyev propose. We ask only one thing in return: that Rizia remains an unyielding pillar of GRACE, keeping ATO and Arcasian profiteers far from your court.", -1,
                "Variable[\"Zille_LespiaPactAccepted\"] ~= true");

            AddLine(conv, 121, BeatriceId, RomusId, "Beatrice_AN_Pledge_LespiaWarn",
                "Still, whispers from Perla tell me you have already been bargaining with Prime Minister Alvarez. Do not trade your sovereign dignity to ATO merchants, Romus—Rumburg's support relies on Rizia remaining faithful to GRACE, not becoming Lespia's junior partner.", -1,
                "Variable[\"Zille_LespiaPactAccepted\"] == true");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddLine(conv, 22, HugoId, RomusId, "Hugo_Beatrice_Support",
                "Hugo nodded with deep reverence. \"A magnificent display of royal solidarity! With Rumburg's heavy shells and diplomatic shield, Smolak stands isolated.\"", 30,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 122, LaurentoId, RomusId, "Laurento_Beatrice_Support",
                "Laurento inclined his head discreetly. \"With Thornbourgh's diplomatic cover at the AN and heavy munitions on the rails, our strategic hand strengthens dramatically, Your Majesty.\"", 30,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            foreach (int pId in new[] { 21, 121 })
            {
                AddLink(conv, pId, 22);
                AddLink(conv, pId, 122);
            }

            var responseHub = AddLine(conv, 30, NarratorId, RomusId, "Beatrice_Response_Prompt",
                "Queen Beatrice waited with cool regal authority for your acknowledgment.");

            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40));
            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50));

            AddChoice(conv, 40, BeatriceId, "Pledge_GRACE_Solidarity",
                "\"House Toras pledges unwavering solidarity to GRACE. Together, our crowns will prevail.\"",
                "House Toras pledges unwavering solidarity to GRACE and our royal kinship, Beatrice. Together, our crowns will prove that sovereign order outlasts republican chaos. Thank you, sister-in-law.", 41,
                "Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Allied\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 2;");

            AddLine(conv, 41, BeatriceId, RomusId, "Ack_Beatrice_Pledge",
                "Beatrice smiled with imperious satisfaction. \"Splendid, Romus. For Lena's memory and for the future of our houses—go forth and claim Zille. Thornbourgh stands with you.\"", -1);

            AddChoice(conv, 50, BeatriceId, "Grateful_Sovereign",
                "\"We accept your munitions with royal gratitude, Beatrice. Rizia remembers who stood by us.\"",
                "We accept your heavy munitions and diplomatic backing with deep gratitude, Beatrice. Rizia will remember who stood beside us in our hour of need. May Saint Wruhec watch over both our realms.", 51,
                "Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Friendly\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) + 1;");

            AddLine(conv, 51, BeatriceId, RomusId, "Ack_Beatrice_Sovereign",
                "\"May victory crown your banners, Romus. I expect good news when Zille is once more Rizian.\" The imperial line softly disconnected.", -1);

            AddConversationWithAlias(db, conv, "Zille/RumburgTalks", "Turn_Zille_RumburgTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Rumburg Talks (ID 9997) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 9: Turn_Zille_WarPreNegotiationsBriefing (ID 9991) - PRE-NEGOTIATIONS
        // Fixed: No river valley, Lucita/Hugo absent checks, Outcome-aware briefing!
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
                "The heavy guns had fallen eerily silent along the smoke-shrouded Zille frontier and across the waters of the Gulf of Moridia. In the War Room, courier dispatches lay piled beside urgent telegrams from Konstantium. Wiktor Smolak had dispatched an envoy under a white flag proposing an immediate face-to-face parley.", -1);

            AddLine(conv, 2, LucitaId, RomusId, "Lucita_PreNeg_Report",
                "Your Majesty. Fighting has paused along the front. Both armies have expended immense ammunition reserves, and Smolak's envoy awaits your answer at the neutral border pavilion.", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 102, CarlosId, RomusId, "Carlos_PreNeg_Report",
                "Your Majesty. A temporary ceasefire holds along the front lines. Both sides are exhausted of shells and fuel, and Smolak's envoy awaits our response at the neutral border pavilion.", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            AddLine(conv, 3, LaurentoId, RomusId, "Laurento_PreNeg_Warning",
                "The Alliance of Nations has issued an urgent ceasefire appeal, Your Majesty. Both superpowers are watching closely. What we win at the table now depends entirely on the ground our troops hold.", -1);

            AddLink(conv, 2, 3);
            AddLink(conv, 102, 3);

            AddLine(conv, 4, HugoId, RomusId, "Hugo_PreNeg_Counsel",
                "Romus... Remember who Smolak is. He is a cornered fox who shifts between jester and butcher in a heartbeat. Guard the dignity of House Toras, whatever terms lie ahead.", 10,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 104, LaurentoId, RomusId, "Laurento_PreNeg_NoHugo",
                "Remember Smolak's nature, Your Majesty—he will alternate between clownish charm and sudden threats. Keep a cool head when you sit across from him.", 10,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 3, 4);
            AddLink(conv, 3, 104);

            var preNegHub = AddLine(conv, 10, RomusId, LaurentoId, "Romus_PreNeg_Prompt",
                "I looked across the map showing the final positions of our divisions from Brenas to the Gulf. The hour had come to face Wiktor Smolak in person.");

            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20));
            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 21));

            AddChoice(conv, 20, LaurentoId, "Choice_Parley_Strength",
                "\"Prepare the royal motorcade. I will meet Smolak and negotiate under the royal standard.\"",
                "Prepare the royal armored motorcade. Assemble our escort and forward commanders. I will meet Smolak at the border pavilion and settle this face to face.", -1,
                "Variable[\"Zille_Parley_Ready\"] = true;");

            AddChoice(conv, 21, LaurentoId, "Choice_Unconditional_Surrender",
                "\"Tell Smolak our guns are still loaded—if he stalls, the bombardment resumes!\"",
                "Inform Smolak that if he tries to stall or play games at the pavilion, our batteries and ships will reopen fire within the hour. Let us go settle Zille's fate.", -1,
                "Variable[\"Zille_Parley_Ready\"] = true; Variable[\"Zille_Parley_Uncompromising\"] = true;",
                "(Variable[\"Zille_War_Outcome\"] or 0) >= 3 or (Variable[\"Zille_War_Outcome\"] or 0) == 0");

            AddLine(conv, 22, LucitaId, RomusId, "Ack_PreNeg_Lucita",
                "Lucita strapped on her sidearm and saluted with iron resolve. \"The royal escort is mounted, Your Majesty. Let us bring this to an end.\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 122, CarlosId, RomusId, "Ack_PreNeg_Carlos",
                "General Carlos Azaro snapped a crisp salute. \"The armored escort is ready, Your Majesty.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            foreach (int chId in new[] { 20, 21 })
            {
                AddLink(conv, chId, 22);
                AddLink(conv, chId, 122);
            }

            AddConversationWithAlias(db, conv, "Zille/WarPreNegotiationsBriefing", "Turn_Zille_WarPreNegotiationsBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Pre-Negotiations Briefing (ID 9991) into masterDatabase!");
        }
    }
}
