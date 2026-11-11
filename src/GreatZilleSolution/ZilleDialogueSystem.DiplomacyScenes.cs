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
        // Modeled on: 377_FPnT_DerdiaNegotiations, 436_Morella_Derdia_Mediation
        // Grand Wiseman Jorga Azmal, Titus Gordion, Archpriest Sal Ignacius.
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
                "The private royal telecommunications chamber was heavy with the aroma of burning sandalwood and frankincense. On the encrypted high-frequency transceiver from Ozkaban, the resonant, gravelly voice of Grand Wiseman Jorga Azmal cut through the static with solemn majesty.", 2);

            AddLine(conv, 2, AzmalId, RomusId, "Azmal_Opening_Greeting",
                "Peace and the fire of Saint Dast be upon you, King Romus of Rizia. The desert winds carry whispers of iron and smoke rising from the southern frontier. You prepare to strike the butcher of Wehlen, do you not?", 3);

            var azmalHub = AddLine(conv, 3, RomusId, AzmalId, "Romus_Azmal_Open_Prompt",
                "I leaned toward the gilded receiver, measuring my words before the spiritual leader of Derdia.");

            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Appeal to shared faith & justice
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Pragmatic military alliance
            azmalHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Question Azmal's motives

            AddChoice(conv, 10, AzmalId, "Choice_Faith_Justice",
                "\"Smolak has desecrated our sacred heritage and persecuted our Nurist brothers in Zille. Justice demands action.\"",
                "Smolak has desecrated our ancient sacred heritage and tormented the faithful of Zille for thirty years. Justice and faith demand that the sword be drawn against him.", 20,
                "Variable[\"Derdia_Romus_Faithful\"] = true;");

            AddChoice(conv, 11, AzmalId, "Choice_Military_Pragmatism",
                "\"Wehlen is our common adversary. A coordinated strike will break his stranglehold on both our borders.\"",
                "Wehlen is our common adversary, Wiseman Azmal. If Rizia strikes from the north and Derdia applies pressure from the south, Smolak's military apparatus will shatter under two fronts.", 20,
                "Variable[\"Derdia_Romus_Pragmatic\"] = true;");

            AddChoice(conv, 12, AzmalId, "Choice_Question_Motives",
                "\"What interest does Derdia possess in the liberation of Zille?\"",
                "What interest does Derdia possess in the outcome of our conflict in Zille, Wiseman? Speak plainly.", 20,
                "Variable[\"Derdia_Romus_Cautious\"] = true;");

            AddLine(conv, 20, AzmalId, RomusId, "Azmal_Theological_Stakes",
                "Know this, O King: on the eastern hills of Zille stands the ancient Sanctuary of the Martyr's Tear-a holy site revered by Golcondist pilgrims long before your ancestors forged the Crown of Rizia. For three decades, Smolak's thugs have extorted, beaten, and murdered our pilgrims seeking salvation at that shrine.", 21);

            AddLine(conv, 21, AzmalId, RomusId, "Azmal_Offer_Proposal",
                "If you pledge by your royal honor to protect the Golcondist faithful, to exempt our pilgrims from taxes, and to grant Derdia religious sanctuary in Zille, then three thousand holy irregulars and mountain scouts will cross Wehlen's southern border tonight. They will cut telegraph cables, burn Valdez's ammunition depots, and tie down his southern brigades in blood and fire!", 22);

            AddLine(conv, 22, SalId, RomusId, "Sal_Ignacius_Warning",
                "Archpriest Sal Ignacius leaned in, clutching his golden Wruhecist pectoral cross. \"Your Majesty, tread cautiously! Granting religious concessions to Golcondist zealots in Zille will cause profound outrage among the orthodox priests of Iza and the High Clergy!\"", 23);

            AddLine(conv, 23, TitusId, RomusId, "Titus_Tactical_Perspective",
                "Titus Gordion stepped forward respectfully. \"From a military standpoint, Your Majesty, Derdian guerrilla sabotage in Valdez's rear would divert enemy reserves and grant our armored columns invaluable operational tempo.\"", 30);

            var pactHub = AddLine(conv, 30, NarratorId, RomusId, "Derdia_Pact_Hub_Prompt",
                "Wiseman Azmal awaited your verdict on the holy transceiver, the faint chanting of Derdian monks audible across the wires.");

            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Holy Coalition
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Pragmatic Compromise
            pactHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject Faith Interference

            AddChoice(conv, 40, AzmalId, "Accept_Holy_Coalition",
                "\"I swear by Saint Dast: The Sanctuary shall be protected, and Golcondist pilgrims shall walk unmolested in Zille.\"",
                "I swear by Saint Dast and my royal honor: The Sanctuary of the Martyr's Tear shall be protected under the Crown's direct aegis, and Golcondist pilgrims will enjoy total freedom of worship in liberated Zille. Let your holy fighters strike!", 41,
                "ZilleCampaignState.IsDerdiaHybridSupportActive = true; Variable[\"Zille_DerdiaHybridActive\"] = true; Variable[\"RiziaDLC.CountryRelation_Derdia_Friendly\"] = true; Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] = Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] + 2;");

            AddLine(conv, 41, AzmalId, RomusId, "Ack_Holy_Coalition",
                "Azmal's voice rose with ecstatic thunder over the receiver. \"Halaita! The righteous blood shall flow, and the chains of the tyrant shall be severed! My irregulars are unleashed. May the fiery sun guide your royal swords, King Romus!\"", 42);

            AddLine(conv, 42, SalId, RomusId, "Sal_Derdia_Grumble",
                "Archpriest Sal muttered a sullen prayer, crossing himself with tight lips. \"May Saint Wruhec forgive this unholy alliance for the sake of our kingdom's borders...\"", -1);

            AddChoice(conv, 50, AzmalId, "Counter_Pragmatic_Derdia",
                "\"I offer economic passage and trade protections for pilgrims, but no special theological privileges.\"",
                "I can guarantee safe commercial passage and police protection for all foreign travelers, including Golcondists, but I will not grant extraterritorial religious privileges that divide our kingdom. Let us strike Smolak as sovereign allies.", 51,
                "ZilleCampaignState.IsDerdiaHybridSupportActive = true; Variable[\"Zille_DerdiaHybridActive\"] = true;");

            AddLine(conv, 51, AzmalId, RomusId, "Ack_Pragmatic_Derdia",
                "Azmal paused in contemplation before sighing heavily. \"You speak with the cautious tongue of a king rather than a prophet, Romus. Yet our hatred for Smolak burns brighter than our disappointment. Our desert scouts will raid his supply lines. But remember our people when the city is yours.\"", -1);

            AddChoice(conv, 60, AzmalId, "Reject_Derdia_Demands",
                "\"Rizia fights under the banner of Saint Wruhec alone. We will not barter our sovereign faith for guerrilla raiders.\"",
                "Rizia marches under the holy banner of Saint Wruhec and the divine authority of House Toras. We will not barter our church's orthodoxy for tribal raiders. Keep your holy fighters in the desert, Wiseman Azmal.", 61,
                "ZilleCampaignState.IsDerdiaHybridSupportActive = false; Variable[\"RiziaDLC.CountryRelation_Derdia_Unfriendly\"] = true;");

            AddLine(conv, 61, AzmalId, RomusId, "Ack_Reject_Derdia",
                "Static hissed fiercely as Azmal's tone turned frigid and harsh. \"Then choke on your arrogant pride, King of Rizia! When Smolak's bullets pierce your royal armor, do not cry out to the sands for salvation!\" The line severed with a violent snap.", -1);

            AddConversationWithAlias(db, conv, "Zille/DerdiaTalks", "Turn_Zille_DerdiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Derdia Talks (ID 9995) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 7: Turn_Zille_LespiaTalks (ID 9996) - NEGOTIATIONS WITH LESPIA
        // Modeled on: 314_FPnT_AlvarezCall, 423_FPnT_AlvarezVisit
        // Romus, Patricio Alvarez, Laurento Esquibel.
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
                "The red secure hotline to Porte Lespia clicked alive with the unmistakable clink of ice cubes against fine crystal glass, followed by a theatrical cough and a satisfied exhale of cigar smoke.", 2);

            AddLine(conv, 2, AlvarezId, RomusId, "Alvarez_Opening_Banter",
                "Romus! My dear friend! Or should I say... His Imperial Majesty, Conqueror of the South? Don't tell me you called to invite me to another stuffy royal opera. I hear through certain Arcasian channels that you're about to give that mustachioed clown Smolak the thrashing he's had coming for thirty years!", 3);

            var alvarezHub = AddLine(conv, 3, RomusId, AlvarezId, "Romus_Alvarez_Open_Prompt",
                "I leaned against the console, matching Alvarez's relaxed tempo while keeping my guard up.");

            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Sarcastic parity
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Straight to business
            alvarezHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Diplomatic pressure

            AddChoice(conv, 10, AlvarezId, "Banter_Sarcastic",
                "\"Enjoying your afternoon rum, Patricio? I thought you might appreciate seeing Wehlen's teeth kicked in.\"",
                "Enjoying your afternoon rum, Patricio? I assumed you might appreciate watching someone finally kick Wehlen's teeth in.", 20);

            AddChoice(conv, 11, AlvarezId, "Banter_Business",
                "\"Let us skip the theatrics, President Alvarez. We both know why this line was opened.\"",
                "Let us skip the theatrics, President Alvarez. We both know why this hotline was opened. Let us talk about intelligence and border security.", 20);

            AddChoice(conv, 12, AlvarezId, "Banter_Pressure",
                "\"Wehlen is destabilizing the entire region. Lespia has a direct economic stake in our success.\"",
                "Wehlen's bandit state destabilizes the entire regional economy. If Smolak controls Zille indefinitely, your shipping corridors in the Gulf are at his mercy.", 20);

            AddLine(conv, 20, AlvarezId, RomusId, "Alvarez_Business_Pitch",
                "Alvarez took another sip, his tone shifting from jovial drunkard to sharp capitalist shark. \"Look, Romus, I won't shed a single tear if Valdez's goons end up feeding the desert buzzards. But Lespia isn't a charity foundation. You want our high-altitude ATO surveillance planes to map Valdez's camouflaged trenches, and you want Arcasian encrypted radios so your tanks don't drive into an ambush.\"", 21);

            AddLine(conv, 21, AlvarezId, RomusId, "Alvarez_Price_Demand",
                "\"Here is my price: 20% guaranteed crude oil delivery contracts from your southern wells to Lespian refineries at discounted rates, PLUS your royal vote backing Lespia's positions at the upcoming MITZ maritime summit. Do that, and my defense ministry will feed your generals live radar coordinates that will let your artillery blow Valdez's command bunkers straight into orbit.\"", 22);

            AddLine(conv, 22, LaurentoId, RomusId, "Laurento_Alvarez_Evaluation",
                "Laurento leaned close to the receiver, speaking in a low, measured whisper. \"Your Majesty, Alvarez's terms are extortionate on oil, but ATO radar reconnaissance would drastically reduce our combat casualties and grant our staff total battlefield clarity. We can negotiate him down if we leverage regional stability.\"", 30);

            var dealHub = AddLine(conv, 30, NarratorId, RomusId, "Alvarez_Deal_Hub_Prompt",
                "Alvarez swirled the ice in his glass, awaiting your counter-offer.");

            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Accept Alvarez terms
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Hard bargain / Outsmart
            dealHub.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Reject Lespian greed

            AddChoice(conv, 40, AlvarezId, "Accept_Alvarez_Pact",
                "\"Agreed. Lespia gets preferential oil deliveries in exchange for total ATO satellite and radar intelligence.\"",
                "Agreed, Patricio. We will guarantee your oil deliveries at favorable terms, provided your defense ministry delivers uninterrupted satellite surveillance and radar intelligence to my war room.", 41,
                "ZilleCampaignState.IsLespiaPactAccepted = true; ZilleCampaignState.IsLespiaIntelActive = true; Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.CountryRelation_Lespia_Allied\"] = true;");

            AddLine(conv, 41, AlvarezId, RomusId, "Ack_Alvarez_Pact",
                "Alvarez burst into a hearty laugh, clinking his glass against the receiver. \"Now that is what I call statesmanship! Consider it done, Romus. Our reconnaissance flights are taking off from Porte Lespia as we speak. Happy hunting in Zille!\"", -1);

            AddChoice(conv, 50, AlvarezId, "Hard_Bargain_Alvarez",
                "\"Ten percent oil contracts, and not a single concession on MITZ. Take it, or we conduct the campaign without you.\"",
                "Ten percent oil contracts on standard commercial terms, and not a single sovereign concession on the MITZ. Take it or leave it, Patricio. If Rizia liberates Zille alone, your leverage in the south evaporates entirely.", 51,
                "ZilleCampaignState.IsLespiaPactAccepted = true; ZilleCampaignState.IsLespiaIntelActive = true; Variable[\"Zille_LespiaPactAccepted\"] = true; Variable[\"Zille_Lespia_Intel\"] = true; Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] = Variable[\"RiziaDLC.Diplomacy_Lespia_NegotiatingPower\"] - 1;");

            AddLine(conv, 51, AlvarezId, RomusId, "Ack_Hard_Bargain",
                "Alvarez cursed under his breath in colloquial Lespian before letting out an amused grunt. \"You drive a harder bargain than your father ever did, Your Majesty. Fine! Ten percent it is. The radar frequencies will be in your war room within the hour.\"", -1);

            AddChoice(conv, 60, AlvarezId, "Reject_Alvarez_Greed",
                "\"Rizian blood will not be bartered for Lespian corporate profits. We will reclaim Zille on our own terms.\"",
                "Rizian soldiers will not bleed to line the pockets of your oil oligarchs, President Alvarez. The Royal Army does not require Lespian charity to defeat Wehlen. Good day.", 61,
                "ZilleCampaignState.IsLespiaPactAccepted = false; ZilleCampaignState.IsLespiaIntelActive = false; Variable[\"RiziaDLC.CountryRelation_Lespia_Unfriendly\"] = true;");

            AddLine(conv, 61, AlvarezId, RomusId, "Ack_Reject_Lespia",
                "Alvarez's amusement vanished instantly into cold diplomatic venom. \"Then good luck against Valdez's mines and artillery, Romus. Don't come crawling back to Kyrute when your tanks are burning in the mud.\" The line went dead.", -1);

            AddConversationWithAlias(db, conv, "Zille/LespiaTalks", "Turn_Zille_LespiaTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Lespia Talks (ID 9996) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 8: Turn_Zille_RumburgTalks (ID 9997) - ROYAL HOTLINE WITH RUMBURG
        // Modeled on: 305_FPnT_QueenBeatriceVisit, 389_FPnT_RumburgMeeting, 433_FPnT_GRACERumburgMeeting
        // Romus, Queen Beatrice Livingston, Hugo Toras, Laurento Esquibel.
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
                "The brass-and-ivory royal trunk line to Thornbourgh buzzed with crystal clarity. Across two thousand miles of cable, the poised, commanding voice of Queen Beatrice Livingston echoed into the private study, carrying the unmistakable weight of the Imperial House of Livingston.", 2);

            AddLine(conv, 2, BeatriceId, RomusId, "Beatrice_Royal_Greeting",
                "Cousin Romus. We in Thornbourgh have followed your confrontation with the Wehzek upstart with keen imperial interest. A monarch cannot permit a petty dictator to mock the sovereign honor of our noble houses.", 3);

            var beatriceHub = AddLine(conv, 3, RomusId, BeatriceId, "Romus_Beatrice_Open_Prompt",
                "I straightened my tunic, addressing my imperial cousin with the dignified courtesy expected between royal houses.");

            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Royal cousin solidarity
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 11)); // Request heavy munitions
            beatriceHub.outgoingLinks.Add(CreateLink(conv.id, 3, 12)); // Assert sovereign independence

            AddChoice(conv, 10, BeatriceId, "Solidarity_Royal",
                "\"Cousin Beatrice. House Toras stands proud, and we are determined to restore our rightful borders.\"",
                "Cousin Beatrice. It is an honor to speak with you. House Toras stands resolute. Thirty years of Wehzek insolence will be answered with royal steel.", 20,
                "Variable[\"Rumburg_Romus_Loyal\"] = true;");

            AddChoice(conv, 11, BeatriceId, "Munitions_Request",
                "\"Your Majesty, Rizia requires heavy artillery shells and diplomatic shielding in the Alliance of Nations.\"",
                "Your Majesty. Rizia's cause is just, but our campaign requires heavy caliber munitions and strong diplomatic shielding in the Alliance of Nations against Contanan interference.", 20,
                "Variable[\"Rumburg_Romus_Munitions\"] = true;");

            AddChoice(conv, 12, BeatriceId, "Sovereign_Assertive",
                "\"We will resolve this conflict ourselves, but GRACE solidarity would be welcomed.\"",
                "Rizia will fight and win this campaign with our own blood, but solidarity among the monarchies of GRACE will show the world that our bloc remains indomitable.", 20,
                "Variable[\"Rumburg_Romus_Proud\"] = true;");

            AddLine(conv, 20, BeatriceId, RomusId, "Beatrice_Imperial_Offer",
                "You speak like a true sovereign, Romus. Rumburg will not stand idly by while republican rabble threatens an imperial crown. We have already instructed our naval attachés to monitor maritime traffic in the Gulf, and three dedicated freight trains carrying 152mm heavy artillery munitions from our royal arsenals are currently en route to the Brenas railyards.", 21);

            AddLine(conv, 21, BeatriceId, RomusId, "Beatrice_AN_Pledge",
                "Furthermore, our ambassador in Kyrute will wield Rumburg's full diplomatic weight in the Alliance of Nations to veto any punitive resolutions Malenyev or Hegel attempt to pass against Rizia. We ask only one thing in return: that Rizia remains an unyielding bulwark of GRACE, keeping ATO and Arcasian meddlers far from your royal court.", 22);

            AddLine(conv, 22, HugoId, RomusId, "Hugo_Beatrice_Support",
                "Hugo nodded with profound reverence, dabbing a tear from his eye. \"A magnificent demonstration of royal fraternity! With Rumburg's heavy shells and diplomatic shield, Smolak stands utterly abandoned by the civilized world.\"", 30);

            var responseHub = AddLine(conv, 30, NarratorId, RomusId, "Beatrice_Response_Prompt",
                "Queen Beatrice waited with quiet imperial authority for your royal acknowledgment.");

            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Pledge GRACE Solidarity
            responseHub.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Grateful but Sovereign

            AddChoice(conv, 40, BeatriceId, "Pledge_GRACE_Solidarity",
                "\"House Toras pledges unwavering loyalty to GRACE. Together, our crowns will triumph.\"",
                "House Toras pledges unwavering solidarity to the Imperial Crown and the GRACE alliance. Together, our royal crowns will demonstrate that monarchical order will always triumph over republican chaos. Thank you, Cousin Beatrice.", 41,
                "ZilleCampaignState.IsRumburgMunitionsActive = true; Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Allied\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = Variable[\"RiziaDLC.Resources_Military_Equipment\"] + 2;");

            AddLine(conv, 41, BeatriceId, RomusId, "Ack_Beatrice_Pledge",
                "Beatrice smiled with imperious satisfaction. \"Splendid, Romus. Smolak will learn the price of defying imperial blood. Go forth and claim your victory. Thornbourgh stands with you.\"", -1);

            AddChoice(conv, 50, BeatriceId, "Grateful_Sovereign",
                "\"We accept your munitions with royal gratitude, Cousin. Rizia will remember who stood by us in our hour of need.\"",
                "We accept your heavy munitions and diplomatic backing with deep gratitude, Cousin. Rizia will always remember who stood by our side in our hour of need. May Saint Wruhec watch over both our realms.", 51,
                "ZilleCampaignState.IsRumburgMunitionsActive = true; Variable[\"Zille_Rumburg_Munitions\"] = true; Variable[\"RiziaDLC.CountryRelation_Rumburg_Friendly\"] = true; Variable[\"RiziaDLC.Resources_Military_Equipment\"] = Variable[\"RiziaDLC.Resources_Military_Equipment\"] + 1;");

            AddLine(conv, 51, BeatriceId, RomusId, "Ack_Beatrice_Sovereign",
                "\"May victory crown your banners, Romus. We expect a triumphant report when Zille is once more Rizian.\" The imperial line softly disconnected.", -1);

            AddConversationWithAlias(db, conv, "Zille/RumburgTalks", "Turn_Zille_RumburgTalks");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Rumburg Talks (ID 9997) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 9: Turn_Zille_WarPreNegotiationsBriefing (ID 9991) - PRE-NEGOTIATIONS
        // Romus, Hugo Toras, Lucita Azaro, Laurento Esquibel, Elena Werner.
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
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "PreNeg_Intro_1",
                "The battlefield guns had fallen eerily silent along the smoke-shrouded river valley. In the War Room, courier dispatches were piled high alongside telegrams from Kyrute and foreign capitals. Smolak had dispatched a military envoy under a white flag proposing an emergency face-to-face parley.", 2);

            AddLine(conv, 2, LucitaId, RomusId, "Lucita_PreNeg_Report",
                "Your Majesty. The fighting has paused along the frontline. Smolak's armored regiments are bloodied and broken, but our own divisions have spent enormous ammunition reserves. Smolak's envoy awaits our response at the neutral border pavilion.", 3);

            AddLine(conv, 3, LaurentoId, RomusId, "Laurento_PreNeg_Warning",
                "The Alliance of Nations has issued an urgent ceasefire appeal, Your Majesty. Both superpowers are watching. If we negotiate from our position of strength, we can extract total territorial restoration without facing crippling sanctions.", 4);

            AddLine(conv, 4, HugoId, RomusId, "Hugo_PreNeg_Counsel",
                "Romus... Remember who Smolak is. He is a cornered wolf. He will try to bluster, joke, and wheedle his way out of defeat. Do not give him an inch of Rizian dignity.", 10);

            var preNegHub = AddLine(conv, 10, RomusId, LucitaId, "Romus_PreNeg_Prompt",
                "I looked at the map showing our battle lines across Zille. The time had come to face Wiktor Smolak in person.");

            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 20)); // March to parley with strength
            preNegHub.outgoingLinks.Add(CreateLink(conv.id, 10, 21)); // Demanding unconditional surrender

            AddChoice(conv, 20, LucitaId, "Choice_Parley_Strength",
                "\"Prepare the royal motorcade. I will meet Smolak and dictate our terms under the royal standard.\"",
                "Prepare the royal armored motorcade. Lucita, assemble the Golden Guard and forward commanders. I will meet Smolak at the border pavilion and dictate our sovereign terms face to face.", 22,
                "Variable[\"Zille_Parley_Ready\"] = true;");

            AddChoice(conv, 21, LucitaId, "Choice_Unconditional_Surrender",
                "\"Smolak will sign a complete evacuation, or my artillery will resume shelling his palace.\"",
                "Inform Smolak that if he comes to barter or stall, our artillery will resume firing within the hour. Nothing less than total evacuation of Zille will be accepted.", 22,
                "Variable[\"Zille_Parley_Ready\"] = true; Variable[\"Zille_Parley_Uncompromising\"] = true;");

            AddLine(conv, 22, LucitaId, RomusId, "Ack_PreNeg_Lucita",
                "Lucita strapped on her sidearm and saluted with iron resolve. \"The royal escort is mounted, Your Majesty. Let us bring this tyrant to his knees.\"", -1);

            AddConversationWithAlias(db, conv, "Zille/WarPreNegotiationsBriefing", "Turn_Zille_WarPreNegotiationsBriefing");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Pre-Negotiations Briefing (ID 9991) into masterDatabase!");
        }
    }
}
