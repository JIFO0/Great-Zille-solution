using System;
using MelonLoader;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static partial class ZilleDialogueSystem
    {
        // =========================================================================
        // SCENE 5: Turn_Zille_WarBalconySpeech (ID 9989) - FULL SPEECH-BUILDING SCENE
        // Modeled on Suzerain's Palace Balcony Speech (372) & Rumburg War Speech (240):
        // 1. Rich narrative intro & backstage stimulus + advisor whisper (Early vs Late + Early Ark warning)
        // 2. Opening salutation
        // 3. Core thesis framing (Early = Valero deal expiration & overstaying tenants;
        //    Late = exhausted diplomacy after our outstretched hand was rejected/bitten)
        // 4. Modular Speech-Building Topic Hub (Bombing [including LIE option!], Valero Legacy,
        //    International Community & Operational Spin, Home Front / Zille Civilians / Armed Forces)
        // 5. Formal Proclamation (Early vs Late differentiated)
        // 6. Closing Battle Cry & Royal Gesture
        // 7. Backstage Debrief reacting to the Bombing Lie and Early+Ark fallout
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

            // ---------------- STAGE 0: ATMOSPHERIC INTRO & BACKSTAGE ----------------
            AddLine(conv, 1, NarratorId, RomusId, "Balcony_Intro_1",
                "Behind the heavy crimson velvet curtains of Palas Rezna, the muffled roar of forty thousand citizens packed across the Royal Plaza vibrated through the marble floorboards. Banners of House Toras, Azaro, and Sazon snapped in the coastal wind outside, while radio engineers crouched beside humming copper transmitters carrying your voice to every town in Rizia—and every listening post from Kyrute to Wraclawitz.", -1);

            AddChoice(conv, 401, NarratorId, "Balcony_Stimulus_Curtain",
                "Part the crimson velvet an inch to survey the ocean of banners and the crowded foreign press pit below.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Balcony_Stimulus_Notes",
                "Straighten your royal sash and shuffle the handwritten speech cards resting in your palm.",
                "", 405, "");

            AddChoice(conv, 403, NarratorId, "Balcony_Stimulus_Mic",
                "Test the brass microphone switch with a quiet tap and listen to the live static hum across the realm.",
                "", 406, "");

            AddLine(conv, 404, NarratorId, RomusId, "Balcony_Entry_Plaza",
                "From Porte Drazon's harbor boulevard to the iron palace gates, the square was a living sea of gold and crimson. Below the balustrade, reporters from Konstantium, Perla, and Valgsland held their fountain pens poised like daggers.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Balcony_Entry_Notes",
                "Ink annotations from Laurento and Hugo covered the margins of your speech cards—legal clauses underlined in black, rhetorical warnings circled in red. History would remember every syllable you chose.", -1);

            AddLine(conv, 406, NarratorId, RomusId, "Balcony_Entry_Mic",
                "The red broadcast lamp glowed steady above the balcony doors. Across Rizia, families in Valenqiris, fishermen in Sallabes, and soldiers crouched along the Brenas frontier leaned closer to their wireless sets.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);
            AddLink(conv, 1, 403);

            // Pre-speech advisor whispers (Early+Ark vs Early Standard vs Late)
            string hugoFree = "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true";
            string hugoGone = "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)";

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Whisper_EarlyArk",
                "Hugo leaned in, his face pale beneath the chandelier light. \"Romus, be exceedingly careful out there. We are supposed to tell the world we are merely enforcing the expired Valero deal in Zille—yet our ships are already steaming toward Wehlen's mainland! Foreign ambassadors will tear apart any hypocrisy if you stumble.\"", 10,
                hugoFree + " and Variable[\"Zille_War_IsEarly\"] == true and Variable[\"Zille_Plan_IsArk\"] == true");

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Whisper_EarlyArk",
                "Laurento's voice dropped to a taut whisper beside the curtain. \"Your Majesty, our narrative is walking a knife's edge. Claiming a lawful entry into Zille while Operation Golden Ark strikes mainland Wehlen will provoke fury in Konstantium. Frame every word with utmost discipline.\"", 10,
                hugoGone + " and Variable[\"Zille_War_IsEarly\"] == true and Variable[\"Zille_Plan_IsArk\"] == true");

            AddLine(conv, 3, HugoId, RomusId, "Hugo_Whisper_EarlyStandard",
                "Hugo adjusted your collar with a steady hand. \"Remember our strongest ground, Romus: the 1927 Valero lease has expired. Rizia is simply walking back into its own house—and if Smolak's overstaying tenants open fire, the guilt lies on their heads.\"", 10,
                hugoFree + " and Variable[\"Zille_War_IsEarly\"] == true and Variable[\"Zille_Plan_IsArk\"] ~= true");

            AddLine(conv, 103, LaurentoId, RomusId, "Laurento_Whisper_EarlyStandard",
                "Laurento inclined his head beside the doorway. \"Keep the legal footing sharp, Your Majesty: Zille returns to Rizia upon the expiration of the Valero deal, with or without Wraclawitz's blessing. Make clear that we only fight if Smolak's garrison resists lawful transfer.\"", 10,
                hugoGone + " and Variable[\"Zille_War_IsEarly\"] == true and Variable[\"Zille_Plan_IsArk\"] ~= true");

            AddLine(conv, 4, HugoId, RomusId, "Hugo_Whisper_Late",
                "Hugo exhaled heavily as the plaza roared beyond the glass. \"Years of patience, Romus... Every envoy we sent to Wraclawitz came back mocked or empty-handed. The realm understands why our hand has finally turned to steel. Speak from the weight of that truth.\"", 10,
                hugoFree + " and Variable[\"Zille_War_IsEarly\"] ~= true");

            AddLine(conv, 104, LaurentoId, RomusId, "Laurento_Whisper_Late",
                "Laurento met your gaze gravely. \"After years of broken talks and Smolak's provocations, Your Majesty, half of Merkopa already knows diplomacy was exhausted. Remind the world how many times Rizia extended its hand—and how Wehlen answered.\"", 10,
                hugoGone + " and Variable[\"Zille_War_IsEarly\"] ~= true");

            foreach (int ent in new[] { 404, 405, 406 })
            {
                AddLink(conv, ent, 2);
                AddLink(conv, ent, 102);
                AddLink(conv, ent, 3);
                AddLink(conv, ent, 103);
                AddLink(conv, ent, 4);
                AddLink(conv, ent, 104);
            }

            // ---------------- STAGE 1: STEPPING OUT & OPENING SALUTATION ----------------
            var saluteHub = AddLine(conv, 10, NarratorId, RomusId, "Speech_StepOut_Prompt",
                "The gilded double doors swung wide. A wall of cheering washed over the stone balustrade as you stepped into the crisp afternoon air and gripped the sides of the lectern. Gradually, forty thousand voices fell into an expectant hush.");

            saluteHub.outgoingLinks.Add(CreateLink(conv.id, 10, 11));
            saluteHub.outgoingLinks.Add(CreateLink(conv.id, 10, 12));
            saluteHub.outgoingLinks.Add(CreateLink(conv.id, 10, 13));
            saluteHub.outgoingLinks.Add(CreateLink(conv.id, 10, 14));
            saluteHub.outgoingLinks.Add(CreateLink(conv.id, 10, 15));

            AddChoice(conv, 11, NarratorId, "Salute_FellowRizians",
                "\"My fellow Rizians.\"",
                "My fellow Rizians.", 19);

            AddChoice(conv, 12, NarratorId, "Salute_Subjects",
                "\"Subjects of the Golden Kingdom.\"",
                "Subjects of the Golden Kingdom.", 19,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            AddChoice(conv, 13, NarratorId, "Salute_World",
                "\"Citizens of Rizia, and delegates watching across Merkopa.\"",
                "Citizens of Rizia, and delegates watching across Merkopa.", 19,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddChoice(conv, 14, NarratorId, "Salute_Faithful",
                "\"Followers of Nur and children of Saint Wruhec.\"",
                "Followers of Nur and children of Saint Wruhec.", 19,
                "Variable[\"RiziaDLC.PersonalValue_Religious\"] = (Variable[\"RiziaDLC.PersonalValue_Religious\"] or 0) + 1;");

            AddChoice(conv, 15, NarratorId, "Salute_Provinces",
                "\"Brothers and sisters of Porte Drazon, Brenas, Valenqiris—and Zille.\"",
                "Brothers and sisters of Porte Drazon, Brenas, Valenqiris—and Zille.", 19,
                "Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            var thesisHub = AddLine(conv, 19, NarratorId, RomusId, "Speech_Thesis_Prompt",
                "Your voice echoed cleanly across the stone square and out over the kingdom's airwaves. You drew a breath and set the core frame of Rizia's action.");

            // ---------------- STAGE 2: CORE THESIS (EARLY vs LATE DIFFERENTIATED) ----------------
            // Early Variant Choices (201-204)
            thesisHub.outgoingLinks.Add(CreateLink(conv.id, 19, 201));
            thesisHub.outgoingLinks.Add(CreateLink(conv.id, 19, 202));
            thesisHub.outgoingLinks.Add(CreateLink(conv.id, 19, 203));
            thesisHub.outgoingLinks.Add(CreateLink(conv.id, 19, 204));
            // Late Variant Choices (211-214)
            thesisHub.outgoingLinks.Add(CreateLink(conv.id, 19, 211));
            thesisHub.outgoingLinks.Add(CreateLink(conv.id, 19, 212));
            thesisHub.outgoingLinks.Add(CreateLink(conv.id, 19, 213));
            thesisHub.outgoingLinks.Add(CreateLink(conv.id, 19, 214));

            // --- EARLY VARIANT THESES ---
            AddChoice(conv, 201, HugoId, "Speech_Early_ValeroTenants",
                "\"The Valero deal has expired. Rizia is entering Zille regardless of Wehlen—and if overstaying tenants resist, we will bravely defend our soil!\"",
                "The 1927 Valero Agreement has reached its lawful end. Rizia is not asking Wehlen's permission to step onto its own land. Today we enter Zille regardless of whether Wraclawitz or anyone else approves—and should overstaying tenants dare raise arms against their rightful landlord, our soldiers will bravely defend Rizian territory!", 221,
                "Variable[\"Zille_Speech_Tone\"] = \"Early_ValeroEntry\"; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] == true");

            AddChoice(conv, 202, LaurentoId, "Speech_Early_Legalist",
                "\"Under the letter of the 1927 pact, Wehlen's lease has lapsed. We march strictly to oversee a lawful transfer of power.\"",
                "Rizia is a realm of law and honor. Under the explicit sunset clause of the 1927 treaty, Wehlen's lease over Zille has lapsed. Our forces cross the frontier today solely to execute a lawful transfer of administration—any violence will be the sole crime of those who refuse to depart.", 222,
                "Variable[\"Zille_Speech_Tone\"] = \"Early_Legalist\"; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] == true");

            AddChoice(conv, 203, HugoId, "Speech_Early_Revanchist",
                "\"Twenty-five years of humiliation end at dawn! House Toras reclaims Zille by royal steel—no foreign dictator has a say!\"",
                "For over twenty-five years, our kingdom endured separation in bitter silence. No more! Wehlen has no say over Rizian borders. Today House Toras marches into Zille by royal right and steel—let Wiktor Smolak and the whole world witness our resolve!", 223,
                "Variable[\"Zille_Speech_Tone\"] = \"Early_Revanchist\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) - 2;",
                "Variable[\"Zille_War_IsEarly\"] == true");

            AddChoice(conv, 204, HugoId, "Speech_Early_Liberation",
                "\"Our brothers and sisters in Zille have suffered under Wehzek police long enough. We enter today to bring them safely home.\"",
                "We cross the Brenas frontier not out of malice, but out of sacred duty to our brothers and sisters in Zille who endured a quarter-century of checkpoints, fear, and foreign rule. The lease is over—today we bring our people home!", 224,
                "Variable[\"Zille_Speech_Tone\"] = \"Early_Liberation\"; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] == true");

            // --- LATE VARIANT THESES ---
            AddChoice(conv, 211, HugoId, "Speech_Late_ResignedHand",
                "\"Time and again we extended our hand to Wehlen—and every time it was rejected, slapped away, or even bitten. Patience has died.\"",
                "For years, I stood before you preaching patience. Time and again, Rizia extended its hand to Wraclawitz in good faith. We negotiated, we compromised, we endured insults—and every single time, our outstretched hand was slapped away, rejected, or even bitten. We have no more cheeks to turn; today, duty replaces patience.", 225,
                "Variable[\"Zille_Speech_Tone\"] = \"Late_Resigned\"; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] ~= true");

            AddChoice(conv, 212, LaurentoId, "Speech_Late_BetrayedLaw",
                "\"We appealed to the Alliance of Nations and honored every clause of 1927. Smolak answered law with extortion and rigged ballots.\"",
                "Every diplomat in Konstantium knows how faithfully Rizia pursued peace. We honored the 1927 Valero Pact to its final letter while Wiktor Smolak stalled, extorted, and mocked international law. When treaties are torn to shreds by a tyrant, only sovereign arms can restore justice.", 222,
                "Variable[\"Zille_Speech_Tone\"] = \"Late_Legalist\"; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] ~= true");

            AddChoice(conv, 213, HugoId, "Speech_Late_Wrath",
                "\"Smolak mistook my restraint for cowardice! Let Wraclawitz learn at dawn that a patient king is the deadliest enemy of all!\"",
                "Wiktor Smolak laughed at our envoys and mistook royal restraint for weakness! He thought he could bleed Rizia with endless concessions and steal Zille forever. Let Wraclawitz learn at dawn that a patient king pushed past his limit is the deadliest enemy on earth!", 223,
                "Variable[\"Zille_Speech_Tone\"] = \"Late_Wrath\"; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) - 1;",
                "Variable[\"Zille_War_IsEarly\"] ~= true");

            AddChoice(conv, 214, HugoId, "Speech_Late_Liberation",
                "\"I prayed Zille would return without a single mother weeping. Smolak denied us that mercy—now our armies finish what talks could not.\"",
                "Before Nur, I prayed every night that Zille would return to Rizia without a single shot fired or a single mother weeping. Wiktor Smolak slammed shut every door to peace. Now our sons and daughters march to bring our people home.", 224,
                "Variable[\"Zille_Speech_Tone\"] = \"Late_Liberation\"; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] ~= true");

            // Thesis reactions -> Modular Topic Hub (300)
            AddLine(conv, 221, NarratorId, RomusId, "Reaction_Early_Tenants",
                "A sharp, approving roar broke across the Royal Plaza—ordinary citizens nodding fiercely at the plain common sense of reclaiming a house from an overstaying tenant. Even several neutral correspondents jotted the phrase down with raised eyebrows.", 300);

            AddLine(conv, 222, NarratorId, RomusId, "Reaction_Legalist",
                "Dignified, rolling applause swept the square as diplomatic observers in the press pit scribbled rapid notes on your invocation of the 1927 treaty.", 300);

            AddLine(conv, 223, NarratorId, RomusId, "Reaction_Revanchist",
                "Thunderous cheers shook the palace glass as guardsmen snapped bayonets upright in the sun—while foreign attachés exchanged grim, alarmed glances at your uncompromising tone.", 300);

            AddLine(conv, 224, NarratorId, RomusId, "Reaction_Liberation",
                "Tears glistened among the elders crowding the front barricades, and chants of 'Bring Zille home!' swelled from the harbor avenues.", 300);

            AddLine(conv, 225, NarratorId, RomusId, "Reaction_Late_Resigned",
                "A heavy, solemn silence held the square for a heartbeat—followed by a deep, resolute wave of applause. Every citizen in Porte Drazon remembered the years of Smolak's taunts, and your weary candor struck straight to the bone.", 300);

            // ---------------- STAGE 3: MODULAR SPEECH-BUILDING TOPIC HUB (300) ----------------
            var topicHub = AddLine(conv, 300, NarratorId, RomusId, "Speech_TopicHub",
                "As the ovation settled, you glanced down at your speech cards. Several crucial arguments lay before you to build the heart of your address.");

            topicHub.outgoingLinks.Add(CreateLink(conv.id, 300, 310)); // Topic 1: Friendship Day Bombing (incl. LIE!)
            topicHub.outgoingLinks.Add(CreateLink(conv.id, 300, 320)); // Topic 2: King Valero's Legacy & 1927
            topicHub.outgoingLinks.Add(CreateLink(conv.id, 300, 330)); // Topic 3: International Community & Military Narrative
            topicHub.outgoingLinks.Add(CreateLink(conv.id, 300, 340)); // Topic 4: People of Zille, Armed Forces & Houses
            topicHub.outgoingLinks.Add(CreateLink(conv.id, 300, 350)); // Move on to Formal Proclamation (once >=1 topic covered)

            // --- TOPIC 1: THE FRIENDSHIP DAY BOMBING (INCLUDING THE LIE OPTION!) ---
            AddChoice(conv, 310, NarratorId, "Topic_Bombing_Open",
                "Turn to the card on the Friendship Day bombing in Zille.",
                "", 311,
                "Variable[\"Zille_Speech_TalkedBombing\"] = true;",
                "Variable[\"Zille_Speech_TalkedBombing\"] ~= true");

            var bombHub = AddLine(conv, 311, NarratorId, RomusId, "Topic_Bombing_Prompt",
                "Every journalist in the press pit leaned forward as you paused over the tragedy of Friendship Day. How will you portray the bombing before Rizia and the world?");

            bombHub.outgoingLinks.Add(CreateLink(conv.id, 311, 312)); // THE LIE (always available!)
            bombHub.outgoingLinks.Add(CreateLink(conv.id, 311, 313)); // Cite actual dossier (if evidence exists)
            bombHub.outgoingLinks.Add(CreateLink(conv.id, 311, 314)); // Solemn remembrance without fabrication

            AddChoice(conv, 312, LaurentoId, "Speech_Bombing_Lie",
                "[LIE] \"Rizian intelligence possesses irrefutable proof that Wehlen fabricated the Friendship Day bombing specifically to keep Zille!\"",
                "Let the world finally hear what Wraclawitz tried to bury in smoke and lies: Rizian intelligence possesses irrefutable proof that Wiktor Smolak's own regime fabricated the Friendship Day bombing in Zille—murdering innocents on our doorstep solely to manufacture a pretext to tear up the Valero deal and keep Zille forever!", 315,
                "Variable[\"Zille_Speech_LiedAboutBombing\"] = true; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) - 1;");

            AddChoice(conv, 313, LaurentoId, "Speech_Bombing_TruthDossier",
                "\"Our royal investigators uncovered the dark truth behind the Friendship Day blast—and Smolak's shameless use of that terror to extort Rizia!\"",
                "We will never forget the blood spilled on Friendship Day. Our investigators compiled the hard record of that atrocity and exposed how Wraclawitz exploited the dead as political hostages to block Zille's rightful return.", 316,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;",
                "((Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true) or Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] == true or Variable[\"Zille_Dossier_Compiled\"] == true)");

            AddChoice(conv, 314, HugoId, "Speech_Bombing_Solemn",
                "\"We bow our heads for every soul lost on Friendship Day—and vow that Zille shall never again live beneath terror and chaos.\"",
                "I will not dishonor the innocent souls lost in the Friendship Day bombing with petty slogans. We mourn them deeply—and we march so that under the King's peace, terror never again walks the streets of Zille.", 317,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            AddLine(conv, 315, NarratorId, RomusId, "Reaction_Bombing_Lie",
                "A collective gasp tore across the plaza, instantly exploding into a furious, deafening chant against Smolak. Below you, two Lespian and Kyrute attachés stared at each other in stunned disbelief before bolting straight for the press telephones. Behind the velvet curtain, Laurento went visibly rigid.", 300);

            AddLine(conv, 316, NarratorId, RomusId, "Reaction_Bombing_Truth",
                "Murmurs of grim agreement swept the square as correspondents noted the steel in your voice—an accusation grounded in documented obstruction rather than bluster.", 300);

            AddLine(conv, 317, NarratorId, RomusId, "Reaction_Bombing_Solemn",
                "A hush of genuine reverence settled over the forty thousand gathered below, many citizens bowing their heads in quiet prayer before applauding steadily.", 300);

            // --- TOPIC 2: KING VALERO'S LEGACY & THE 1927 TREATY ---
            AddChoice(conv, 320, NarratorId, "Topic_Valero_Open",
                "Turn to the card on King Valero's legacy and the 1927 agreement.",
                "", 321,
                "Variable[\"Zille_Speech_TalkedValero\"] = true;",
                "Variable[\"Zille_Speech_TalkedValero\"] ~= true");

            var valeroHub = AddLine(conv, 321, NarratorId, RomusId, "Topic_Valero_Prompt",
                "The shadow of 1927 hung over every Toras monarch. How do you weave your father's treaty into today's address?");

            valeroHub.outgoingLinks.Add(CreateLink(conv.id, 321, 322));
            valeroHub.outgoingLinks.Add(CreateLink(conv.id, 321, 323));
            valeroHub.outgoingLinks.Add(CreateLink(conv.id, 321, 324));

            AddChoice(conv, 322, HugoId, "Speech_Valero_Honor",
                "\"My father, King Valero, signed the 1927 pact to save a bleeding realm—and trusted in its expiration. Today I fulfill his final hope.\"",
                "In our kingdom's darkest hour of 1927, my father King Valero signed away Zille's lease for twenty-five years to save Rizia from ruin. He carried that sorrow to his grave—and today, his son fulfills the promise of Zille's return.", 325,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseToras\"] = (Variable[\"RiziaDLC.Country_HouseToras\"] or 0) + 1;");

            AddChoice(conv, 323, HugoId, "Speech_Valero_Rectify",
                "\"Where my father yielded under duress in 1927, I shall not bend an inch. A Toras king finishes what history left undone!\"",
                "History remembers 1927 as an hour of weakness forced upon the Crown. I will not inherit my father's hesitation. Where King Valero signed away our soil under duress, King Romus IX restores Rizia whole!", 325,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddChoice(conv, 324, EstelaId, "Speech_Valero_EstelaHome",
                "\"Zille is not a line on a map—it is Queen Mother Estela's childhood home, and the living heart of northern Brenas.\"",
                "To foreign bureaucrats, Zille may be a line drawn in ink. To us, it is the harbor where Queen Mother Estela grew up, the churches where our grandparents prayed, and the living flesh of Brenas.", 325,
                "Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"RiziaDLC.Country_HouseSazon\"] = (Variable[\"RiziaDLC.Country_HouseSazon\"] or 0) + 1;");

            AddLine(conv, 325, NarratorId, RomusId, "Reaction_Valero",
                "A warm, emotional swell of cheers rolled across the square, banners dipping in salute to the royal house.", 300);

            // --- TOPIC 3: INTERNATIONAL COMMUNITY & OPERATIONAL NARRATIVE ---
            AddChoice(conv, 330, NarratorId, "Topic_World_Open",
                "Turn to the card addressing the Alliance of Nations and foreign powers.",
                "", 331,
                "Variable[\"Zille_Speech_TalkedWorld\"] = true;",
                "Variable[\"Zille_Speech_TalkedWorld\"] ~= true");

            var worldHub = AddLine(conv, 331, NarratorId, RomusId, "Topic_World_Prompt",
                "Envoys from ATO, Contana, GRACE, and South Merkopa were listening to every syllable. What message do you send beyond Rizia's borders?");

            worldHub.outgoingLinks.Add(CreateLink(conv.id, 331, 332)); // Early + Ark spin!
            worldHub.outgoingLinks.Add(CreateLink(conv.id, 331, 333)); // Appeal to AN & Law
            worldHub.outgoingLinks.Add(CreateLink(conv.id, 331, 334)); // Warn Contana/Valgsland & salute friends (GRACE/Derdia)

            AddChoice(conv, 332, LaurentoId, "Speech_World_EarlyArkSpin",
                "\"Our naval operations across the Gulf of Moridia are strictly defensive—neutralizing Wehlen's staging ports so they cannot attack our lawful entry into Zille!\"",
                "To the delegates in Konstantium questioning our naval movements across the Gulf of Moridia: hear me clearly. Every strike against Wehlen's coastal staging ports is a strictly defensive measure to prevent Smolak from launching counter-attacks against our lawful entry into Zille!", 335,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) - 1;",
                "Variable[\"Zille_War_IsEarly\"] == true and Variable[\"Zille_Plan_IsArk\"] == true");

            AddChoice(conv, 333, LaurentoId, "Speech_World_ANLaw",
                "\"We invite Alliance of Nations observers to witness our discipline—Rizia upholds treaties, never lawless conquest.\"",
                "To the Alliance of Nations in Konstantium: Rizia seeks no empire over Wehlen's people. We invite neutral observers to witness the discipline of our soldiers and the lawful restoration of Zille.", 336,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2;");

            AddChoice(conv, 334, LaurentoId, "Speech_World_DefyBlocs",
                "\"Let Valgsland and United Contana keep their hands off South Merkopa—our sovereign rights are not decided in foreign capitals!\"",
                "And to those distant superpowers and ideologues who dare lecture Rizia while arming a tyrant in Wraclawitz: South Merkopa belongs to its own sovereign nations. Keep your fleets and your hypocrisy out of our waters!", 337,
                "Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            AddLine(conv, 335, NarratorId, RomusId, "Reaction_World_EarlyArkSpin",
                "The domestic crowd cheered dutifully, yet down in the press pit foreign correspondents shook their heads in unmistakable disbelief. Selling an amphibious landing on mainland Wehlen as a 'peaceful treaty entry' was going to be a brutal fight in Konstantium.", 300);

            AddLine(conv, 336, NarratorId, RomusId, "Reaction_World_ANLaw",
                "Several neutral envoys in the diplomatic gallery nodded quietly, underlining your pledge of lawful oversight.", 300);

            AddLine(conv, 337, NarratorId, RomusId, "Reaction_World_DefyBlocs",
                "Nationalists in the square erupted into thunderous cheers, drowning out the frantic scribbling of Valgish and Contanan correspondents.", 300);

            // --- TOPIC 4: PEOPLE OF ZILLE, ARMED FORCES & NOBLE HOUSES ---
            AddChoice(conv, 340, NarratorId, "Topic_Home_Open",
                "Turn to the card addressing the people of Zille, our armed forces, and the noble houses.",
                "", 341,
                "Variable[\"Zille_Speech_TalkedHome\"] = true;",
                "Variable[\"Zille_Speech_TalkedHome\"] ~= true");

            var homeHub = AddLine(conv, 341, NarratorId, RomusId, "Topic_Home_Prompt",
                "Soldiers, guild workers, noble retainers, and families with relatives across the Zille border waited for your personal pledge.");

            homeHub.outgoingLinks.Add(CreateLink(conv.id, 341, 342));
            homeHub.outgoingLinks.Add(CreateLink(conv.id, 341, 343));
            homeHub.outgoingLinks.Add(CreateLink(conv.id, 341, 344));

            AddChoice(conv, 342, LaurentoId, "Speech_Home_CivilianCharter",
                "\"I swear before Nur: every Rizian, Bludish, and law-abiding Wehzek family in Zille shall know royal justice, never vengeance!\"",
                "Hear this solemn royal vow: every Rizian, Bludish, and peaceful Wehzek resident inside Zille will be shielded by our courts and our soldiers. We bring lawful order—never blind reprisal!", 345,
                "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            AddChoice(conv, 343, LucitaId, "Speech_Home_RallyForces",
                "\"To the Royal Army, the Fleet at Monqiz, the Golden Guard, and Houses Toras, Azaro, and Sazon—stand as one shield of gold!\"",
                "To our soldiers massed along the Brenas frontier, to our sailors cutting the waves out of Monqiz, and to every house—Toras, Azaro, and Sazon—stand together today as one unbroken shield of gold!", 346,
                "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            AddChoice(conv, 344, HugoId, "Speech_Home_Faith",
                "\"May Saint Wruhec's light guide every soldier home and bless our reunion with Zille!\"",
                "In this hour of trial, we place our kingdom in the hands of the Almighty. May Saint Wruhec's light guide every Rizian soldier safely through the storm and bless our reunion with Zille!", 347,
                "Variable[\"RiziaDLC.PersonalValue_Religious\"] = (Variable[\"RiziaDLC.PersonalValue_Religious\"] or 0) + 1; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            AddLine(conv, 345, NarratorId, RomusId, "Reaction_Home_Charter",
                "Warm, steady applause rose from merchants and foreign observers alike—a rare note of royal mercy amid the drums of war.", 300);

            AddLine(conv, 346, NarratorId, RomusId, "Reaction_Home_Forces",
                "Uniformed officers lining the palace steps snapped into a crisp salute as the square thundered with martial pride.", 300);

            AddLine(conv, 347, NarratorId, RomusId, "Reaction_Home_Faith",
                "Elders in the crowd pressed their palms to their hearts in silent blessing as bells from Porte Drazon's cathedral began to toll in the distance.", 300);

            // --- PROCEED TO FORMAL PROCLAMATION ---
            AddChoice(conv, 350, NarratorId, "Speech_MoveToDeclaration",
                "Set down your speech cards and deliver the formal royal proclamation.",
                "", 360, "",
                "Variable[\"Zille_Speech_TalkedBombing\"] == true or Variable[\"Zille_Speech_TalkedValero\"] == true or Variable[\"Zille_Speech_TalkedWorld\"] == true or Variable[\"Zille_Speech_TalkedHome\"] == true");

            // ---------------- STAGE 4: FORMAL ROYAL PROCLAMATION (EARLY vs LATE) ----------------
            var declHub = AddLine(conv, 360, NarratorId, RomusId, "Speech_Declaration_Prompt",
                "You placed both palms firmly on the lectern and lifted your eyes over the sea of faces. The decisive moment had arrived.");

            declHub.outgoingLinks.Add(CreateLink(conv.id, 360, 361)); // Early: Lawful Entry & Self-Defense
            declHub.outgoingLinks.Add(CreateLink(conv.id, 360, 362)); // Early: Firm Ultimatum to Squatters
            declHub.outgoingLinks.Add(CreateLink(conv.id, 360, 363)); // Late: Solemn Declaration of War
            declHub.outgoingLinks.Add(CreateLink(conv.id, 360, 364)); // Late: Defiant "War It Is!"

            AddChoice(conv, 361, HugoId, "Decl_Early_LawfulEntry",
                "\"By royal decree, Rizia enters Zille today to restore lawful administration. Stand aside, Wehlen—or our soldiers will defend our land!\"",
                "Therefore, by royal decree, the Royal Armed Forces are crossing into Zille to restore lawful Rizian administration upon the expiration of the 1927 pact. Wehlen's lease is over—stand aside peacefully, or face brave Rizian steel defending its own home!", 370,
                "Variable[\"Zille_BalconySpeech_Done\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] == true");

            AddChoice(conv, 362, HugoId, "Decl_Early_Unstoppable",
                "\"Whether Wraclawitz likes it or not, Rizian banners rise over Zille tonight! Any who fire upon us will be swept from our soil!\"",
                "Let Wraclawitz hear me clearly: whether Wiktor Smolak likes it or not, Rizian banners are crossing into Zille tonight. Any overstaying garrison that dares fire upon our columns will be swept cleanly from our soil!", 370,
                "Variable[\"Zille_BalconySpeech_Done\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] == true");

            AddChoice(conv, 363, HugoId, "Decl_Late_SolemnWar",
                "\"Having exhausted every path of peace, I hereby declare that a state of armed conflict exists with Wehlen until Zille is free!\"",
                "Having exhausted every honest avenue of peace and seen our outstretched hand bitten one final time, I hereby proclaim that a state of armed conflict exists between the Kingdom of Rizia and the Republic of Wehlen until Zille stands free!", 370,
                "Variable[\"Zille_BalconySpeech_Done\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] ~= true");

            AddChoice(conv, 364, HugoId, "Decl_Late_WarItIs",
                "\"If Wiktor Smolak prefers war to honor—so be it! War it is, and we will not sheath our sword until Zille is ours!\"",
                "If Wiktor Smolak prefers the language of war to the language of treaties—so be it! War it is! And Rizia shall not sheath its sword until every inch of Zille is returned to the Crown!", 370,
                "Variable[\"Zille_BalconySpeech_Done\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;",
                "Variable[\"Zille_War_IsEarly\"] ~= true");

            // ---------------- STAGE 5: CLOSING BATTLE CRY & GESTURE ----------------
            var cryHub = AddLine(conv, 370, NarratorId, RomusId, "Speech_BattleCry_Prompt",
                "The air crackled with electric tension as forty thousand citizens held their breath for your final words.");

            cryHub.outgoingLinks.Add(CreateLink(conv.id, 370, 371));
            cryHub.outgoingLinks.Add(CreateLink(conv.id, 370, 372));
            cryHub.outgoingLinks.Add(CreateLink(conv.id, 370, 373));
            cryHub.outgoingLinks.Add(CreateLink(conv.id, 370, 374));

            AddChoice(conv, 371, NarratorId, "Cry_Glovurius",
                "\"Glovurius axa Rizia!\"",
                "Glovurius axa Rizia!", 380,
                "Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            AddChoice(conv, 372, NarratorId, "Cry_ZilleHome",
                "\"Zille returns home! Long live the Golden Kingdom!\"",
                "Zille returns home! Long live the Golden Kingdom!", 380);

            AddChoice(conv, 373, NarratorId, "Cry_NurBless",
                "\"May Nur and Saint Wruhec shield our soldiers!\"",
                "May Nur and Saint Wruhec shield our soldiers!", 380);

            AddChoice(conv, 374, NarratorId, "Cry_ThankYou",
                "\"Thank you. God save Rizia.\"",
                "Thank you. God save Rizia.", 380);

            var gestureHub = AddLine(conv, 380, NarratorId, RomusId, "Speech_Gesture_Prompt",
                "A deafening, earth-shaking roar erupted across the Royal Plaza. Flags whipped wildly in the sea breeze as soldiers and citizens alike cheered your name.");

            gestureHub.outgoingLinks.Add(CreateLink(conv.id, 380, 381));
            gestureHub.outgoingLinks.Add(CreateLink(conv.id, 380, 382));
            gestureHub.outgoingLinks.Add(CreateLink(conv.id, 380, 383));

            AddChoice(conv, 381, NarratorId, "Gesture_Fist",
                "Raise your clenched fist high above the stone balustrade.",
                "", 390);

            AddChoice(conv, 382, NarratorId, "Gesture_Salute",
                "Snap a crisp royal military salute toward the honor guard and regiments below.",
                "", 390);

            AddChoice(conv, 383, NarratorId, "Gesture_Bow",
                "Rest both palms solemnly on the rail and incline your head in quiet gratitude.",
                "", 390);

            // ---------------- STAGE 6: BACKSTAGE DEBRIEF & FALLOUT ----------------
            AddLine(conv, 390, NarratorId, RomusId, "Speech_ExitBalcony",
                "You turned from the roaring plaza and stepped back through the gilded doors into the sudden quiet of the velvet-draped gallery. The broadcast lamp flickered off.", -1);

            // Reaction 1: Lied about Friendship Day Bombing!
            AddLine(conv, 391, LaurentoId, RomusId, "Debrief_BombingLie_Warn",
                "Laurento exhaled sharply, loosening his collar. \"Your Majesty... claiming live on air that we possess proof Wehlen fabricated the Friendship Day bombing set the plaza ablaze—it will rally the home front overnight. Yet pray no Lespian leak or AN forensic team contradicts us in Konstantium, or our diplomatic credibility will suffer grievously.\"", -1,
                "Variable[\"Zille_Speech_LiedAboutBombing\"] == true");

            // Reaction 2: Early + Ark without bombing lie
            AddLine(conv, 392, LaurentoId, RomusId, "Debrief_EarlyArk_Warn",
                "Laurento's expression remained grave as dispatches already clattered in from the telegraph room. \"The people stood behind you, Your Majesty—yet foreign embassies are already cabling furious protests. Claiming we merely entered Zille to secure the Valero deal while Operation Golden Ark strikes mainland Wehlen is going to ignite a firestorm at the Alliance of Nations.\"", -1,
                "Variable[\"Zille_Speech_LiedAboutBombing\"] ~= true and Variable[\"Zille_War_IsEarly\"] == true and Variable[\"Zille_Plan_IsArk\"] == true");

            // Reaction 3: Standard Early or Late (Hugo alive)
            AddLine(conv, 393, HugoId, RomusId, "Debrief_Standard_Hugo",
                "Hugo bowed his head solemnly as the distant cheers still echoed through the palace glass. \"The die is cast, Romus. Your words have bound the kingdom together—now everything rests with our soldiers at the frontier. Glovurius axa Rizia.\"", -1,
                "Variable[\"Zille_Speech_LiedAboutBombing\"] ~= true and (Variable[\"Zille_War_IsEarly\"] ~= true or Variable[\"Zille_Plan_IsArk\"] ~= true) and " + hugoFree);

            // Reaction 4: Standard fallback (Hugo gone)
            AddLine(conv, 394, LaurentoId, RomusId, "Debrief_Standard_Laurento",
                "Laurento inclined his head with quiet resolve as the distant cheers echoed through the gallery. \"The realm and the world have heard the Crown's verdict, Your Majesty. Now our embassies and our armies alike must carry the day.\"", -1,
                "Variable[\"Zille_Speech_LiedAboutBombing\"] ~= true and (Variable[\"Zille_War_IsEarly\"] ~= true or Variable[\"Zille_Plan_IsArk\"] ~= true) and " + hugoGone);

            AddLink(conv, 390, 391);
            AddLink(conv, 390, 392);
            AddLink(conv, 390, 393);
            AddLink(conv, 390, 394);

            AddConversationWithAlias(db, conv, "Zille/WarBalconySpeech", "Turn_Zille_WarBalconySpeech");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Full Speech-Building War Balcony Proclamation (ID 9989) into masterDatabase!");
        }
    }
}
