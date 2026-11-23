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
        // SCENE 10: Turn_Zille_WarSmolakFinalParley (ID 9992) - SMOLAK PARLEY
        // Multi-round tactical duel of leverage:
        // Round 1: Opening Posture gated by actual battlefield outcome
        // Round 2: Smolak counter-bluffs + Romus deploys accumulated Leverage cards
        //          (Bombing Dossier, Arsenal >=1000 + Treasury, Naval Blockade/Derdia, AN Law)
        // Round 3: Outcomes UNLOCKED BY ACCUMULATED LEVERAGE:
        //   - Victory + Leverage>=3 => Force Border Reparations (+2 Budget, +2 Energy)!
        //   - Stalemate + Leverage>=5 => Break Smolak into returning Zille!
        //   - Total Fiasco + Leverage>=4 => Ransom & save southern Brenas!
        // =========================================================================
        public static void RegisterWarSmolakFinalParley(DialogueDatabase db)
        {
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
                "The neutral pavilion stood on a muddy rise between the forward trenches, draped in white flags snapping in the salt breeze off the Gulf of Moridia. Outside, Golden Guards in gold-trimmed greatcoats stood eye-to-eye with Wehzek guardsmen holding submachine guns. Inside, Wiktor Smolak sat slumped in a folding chair, pouring bitter black tea into a tin cup, a half-smoked cigarette dangling from his lips.", -1);

            AddChoice(conv, 401, SmolakId, "Parley_Stimulus_Tea",
                "Accept the tin cup of chicory tea without flinching, meeting Smolak's gaze.",
                "", 404, "");

            AddChoice(conv, 402, SmolakId, "Parley_Stimulus_Briefcase",
                "Leave the tea untouched and set your heavy leather briefcase squarely on the folding table.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Parley_Entry_Tea",
                "You took the battered tin cup. The chicory brew smelled of burnt grain and woodsmoke, yet your hand remained steady as Smolak grinned around his cigarette.", 2);

            AddLine(conv, 405, NarratorId, RomusId, "Parley_Entry_Briefcase",
                "The leather case landed with a heavy thud that rattled Smolak's tin saucer. His eyes flicked down to the gilded Toras crest stamped on the leather before returning to your face.", 2);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, SmolakId, RomusId, "Smolak_Parley_Greeting",
                "Look who finally arrived! The great King Romus of Rizia in the flesh. Tell me, Your Majesty... Care for some hospitality? Wehzek chicory blend. Tastes like gunpowder and wet mud, yet it keeps a man awake while the guns bark.", 3);

            var parleyHub = AddLine(conv, 3, NarratorId, RomusId, "Romus_Parley_Posture_Prompt",
                "You sat across the scarred folding table, facing the bloodshot, calculating eyes of the Wehzek dictator.");

            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Victory posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Stalemate posture 1
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 21)); // Stalemate posture 2
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Defiant victory posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Defeat posture 1
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 41)); // Defeat posture 2

            AddChoice(conv, 10, SmolakId, "Posture_Victor",
                "\"Your garrisons are broken, Smolak. Evacuate Zille today and let us settle the peace.\"",
                "Your garrisons are shattered and your sea lanes across the Gulf are contested, Smolak. We are not here to drink tea—we are here to settle the evacuation of Zille.", 100,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) >= 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 20, SmolakId, "Posture_Stalemate",
                "\"Both armies have bled into this mud. Let us test what terms each side can still defend.\"",
                "Both our nations have bled enough along the hills of Zille. Before the Alliance of Nations chains us both, put your real terms on this table.", 200,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) == 3 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 21, SmolakId, "Posture_Stalemate_Stern",
                "\"Skip the pleasantries, Wiktor. Our guns are still loaded—let us see what card you think you hold.\"",
                "Spare me the campfire banter, Wiktor. Our artillery is still ranged on your trenches—put your proposal on this table.", 200,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) == 3 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 30, SmolakId, "Posture_Defiant",
                "\"You tore up the 1927 agreement and gambled on terror. Now Rizia settles the account.\"",
                "You tore up the 1927 treaty and thought you could extort House Toras forever. Every Wehzek soldier lost on this peninsula is on your head.", 100,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) >= 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 40, SmolakId, "Posture_Defeated",
                "\"Our offensive stalled, Wiktor. Speak plainly and put your price on the table.\"",
                "Fortune favored your trenches on the field, Wiktor. Spare me your jokes and put your terms on the table so we may halt the slaughter.", 300,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) == 1 or (Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 41, SmolakId, "Posture_Defeated_Stoic",
                "\"Do not mistake a ceasefire for submission, Smolak. State your terms and be brief.\"",
                "Do not mistake a truce for Rizia's surrender, Smolak. State your terms cleanly so both our armies can stand down.", 300,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) == 1 or (Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            // ================= BRANCH A: DECISIVE VICTORY / OVERWHELMING TRIUMPH =================
            AddLine(conv, 100, NarratorId, RomusId, "Smolak_Defeated_Rant",
                "Smolak ground his cigarette under his boot heel, his jaw twitching. \"Don't get drunk on victory, King Romus! My Zille garrison blundered, sure—but I still have battalions in Wraclawitz, Contana whispering in Kyrute, and stubborn pride! I'll hand back Zille if you let my surviving boys sail home untouched—not one copper of reparations!\"", -1);

            AddLink(conv, 100, 101);
            AddLink(conv, 100, 1102);

            AddLine(conv, 1102, NarratorId, RomusId, "Victory_NoCards_Bridge",
                "With the military map settled between you, Smolak clenched his jaw and waited for your terms.", 102,
                "Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] ~= true and Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] ~= true and Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] ~= true and ((Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000 or (Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 1) and Variable[\"Zille_NavalBlockadeActive\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] ~= true");

            var vicDuelHub = AddLine(conv, 101, NarratorId, RomusId, "Victory_Leverage_Duel_Hub",
                "Smolak was testing your nerve—trying to evacuate his beaten army without paying a cent for the ruin in Zille. You could press a concrete advantage from your dossier first, or move straight to dictating final terms.", -1,
                "((Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true) or Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] == true) or ((Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 and (Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1) or (Variable[\"Zille_NavalBlockadeActive\"] == true or Variable[\"Zille_DerdiaHybridActive\"] == true)");

            vicDuelHub.outgoingLinks.Add(CreateLink(conv.id, 101, 103)); // Press Bombing Dossier (+2 Leverage)
            vicDuelHub.outgoingLinks.Add(CreateLink(conv.id, 101, 105)); // Flash >1000 Equipment & Treasury Stamina (+2 Leverage)
            vicDuelHub.outgoingLinks.Add(CreateLink(conv.id, 101, 107)); // Cite Blockade / Derdia Stranglehold (+2 Leverage)
            vicDuelHub.outgoingLinks.Add(CreateLink(conv.id, 101, 109)); // Move directly to terms

            AddChoice(conv, 103, SmolakId, "Vic_Duel_Dossier",
                "\"[DOSSIER] Pay reparations, or we publish your Zille bombing complicity to every ambassador in Kyrute!\"",
                "No indemnities? Open your eyes, Wiktor: my briefcase holds verified dossiers on the Zille bombing. Pay for the silos and bridges your officers burned, or I distribute this file across Konstantium tonight!", 104,
                "Variable[\"Zille_Parley_UsedDossier\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "((Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true) or Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] == true)");

            AddLine(conv, 104, NarratorId, RomusId, "Ack_Vic_Dossier",
                "Smolak's eye twitched violently as you tapped the sealed black folder. \"You smug little vulture...\" he hissed softly, lowering his bluff by a notch.", 102);

            AddChoice(conv, 105, SmolakId, "Vic_Duel_Arsenal",
                "\"[ARSENAL >=1,000] Our depots hold over a thousand fresh arms and full war coffers—we can keep pushing!\"",
                "Bluff somewhere else, Smolak! Our quartermasters still hold over a thousand fresh weapons in Brenas and coin in our treasury. Say the word and our brigades embark right behind your retreating transports!", 106,
                "Variable[\"Zille_Parley_UsedArsenal\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;",
                "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 and (Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 1");

            AddLine(conv, 106, NarratorId, RomusId, "Ack_Vic_Arsenal",
                "Smolak glanced nervously toward the telegraph orderly outside the canvas flap. \"Keep your tanks anchored in Zille, Romus—nobody wants a march on Wraclawitz!\"", 102);

            AddChoice(conv, 107, SmolakId, "Vic_Duel_BlockadeDerdia",
                "\"[ENCIRCLEMENT] Our ships choke the Gulf and Derdian raids burn your southern depots—you have no retreat!\"",
                "Your 'sail home untouched' assumes our fleet opens the Strait of Kreleck—and while Derdian raiders tear up your mainland roads, you cannot buy another week!", 108,
                "Variable[\"Zille_Parley_UsedEncircle\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;",
                "(Variable[\"Zille_NavalBlockadeActive\"] == true or Variable[\"Zille_DerdiaHybridActive\"] == true)");

            AddLine(conv, 108, NarratorId, RomusId, "Ack_Vic_Encircle",
                "Smolak swallowed hard, ash falling from his cigarette onto his tunic. \"Alright, alright, King—you've got me boxed in! What is your price?\"", 102);

            AddChoice(conv, 109, SmolakId, "Vic_Duel_SkipToTerms",
                "\"Enough posturing, Wiktor. Let us put the final evacuation terms on the table.\"",
                "Spare me the theatrics, Wiktor. Let us put the final evacuation terms on this table right now.", 102);

            var victoryChoiceHub = AddLine(conv, 102, NarratorId, RomusId, "Victory_Terms_Prompt",
                "Smolak leaned over the scarred table—cornered, bruised, yet bargaining furiously for what remained of Wehlen.", -1);

            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 110)); // Clean Zille Restoration
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 112)); // Zille Restoration + POW Release
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 115)); // Leverage>=3 Reparations (+2 Budget, +2 Energy)!
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 120)); // Overwhelming Triumph (Deep Wehlen captured)

            AddChoice(conv, 110, SmolakId, "Accept_Decisive_Surrender",
                "\"Zille returns unconditionally to Rizia. Your surviving troops may evacuate across the Gulf.\"",
                "Zille returns unconditionally to the Crown of Rizia today. Your surviving troops may board transports across the Gulf of Moridia under white flags—never to return.", 111,
                "Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) >= 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 112, SmolakId, "Accept_Decisive_POWs",
                "\"Return Zille unconditionally and release every Rizian prisoner before a single Wehzek transport sails.\"",
                "Zille returns unconditionally to the Crown of Rizia, and every Rizian prisoner in your camps crosses the line before a single Wehzek transport clears the harbor.", 111,
                "Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "((Variable[\"Zille_War_Outcome\"] or 0) >= 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 111, NarratorId, RomusId, "Smolak_Signs_Decisive",
                "Smolak snatched the pen and scrawled his signature with vicious strokes. \"Done! Pack up, boys, we're sailing home! Enjoy your oilfields and your headaches, Romus!\"", -1);

            AddChoice(conv, 115, SmolakId, "Demand_Leveraged_Reparations",
                "\"[LEVERAGE] Return Zille AND pay war reparations in gold and crude oil for the ruin you left!\"",
                "You lack the cards to refuse, Smolak. Sign the unconditional return of Zille AND two million in gold reconstruction credits plus emergency crude deliveries—or our press and our fleet bury you tonight!", 116,
                "Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Reparations_Won\"] = true; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) + 2; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 2;",
                "((Variable[\"Zille_War_Outcome\"] or 0) >= 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0) and (Variable[\"Zille_Leverage\"] or 0) >= 3");

            AddLine(conv, 116, NarratorId, RomusId, "Smolak_Signs_Reparations",
                "Smolak cursed viciously under his breath, glaring as if he wished his fountain pen were a dagger—then signed every schedule of gold and fuel deliveries. \"You squeezed every last drop, Romus! Take Zille and your blood money!\"", -1);

            AddChoice(conv, 120, SmolakId, "Demand_Overwhelming_Triumph",
                "\"[TOTAL TRIUMPH] Cede Zille, pay massive indemnities, demilitarize the south, and free Grodzizg!\"",
                "Our forward divisions already sit inside mainland Wehlen. Cede Zille unconditionally, pay massive gold and fuel indemnities, demilitarize your southern coast, and grant Free City autonomy to Grodzizg—or our armor pushes to Wraclawitz!", 121,
                "Variable[\"Zille_War_Outcome\"] = 5; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Grodzizg_FreeCity\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) + 4; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 3;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 5 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 121, NarratorId, RomusId, "Smolak_Signs_Overwhelming",
                "Smolak turned chalk-white as he stared at the map pins deep inside Wehlen. \"You're an absolute shark, Romus... Damn you, I'll sign! Just halt your tanks and keep Wraclawitz out of this!\"", -1);

            // ================= BRANCH B: BLOODY STALEMATE & LEVERAGE BREAKTHROUGH =================
            AddLine(conv, 200, NarratorId, RomusId, "Smolak_Stalemate_Opening",
                "Smolak blew gray smoke toward the canvas roof. \"Neither of us can break the other cheaply, Romus. Your tanks stalled on Zille City's ring, and my boys can't crack Brenas. We can keep feeding men into artillery until Kyrute chains us both... or hear my compromise: a demilitarized Independent Buffer State in Zille!\"", -1);

            AddLink(conv, 200, 201);
            AddLink(conv, 200, 1202);

            string noStaleCards = "Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] ~= true and Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] ~= true and Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] ~= true and (Variable[\"Zille_AN_Legitimacy\"] or 0) < 3 and (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000 and Variable[\"Zille_NavalBlockadeActive\"] ~= true and Variable[\"Zille_DerdiaHybridActive\"] ~= true";

            AddLine(conv, 1202, NarratorId, RomusId, "Stalemate_NoCards_Bridge",
                "With neither side holding an overwhelming trump card at the table, Smolak tapped his ash onto the dirt and waited.", -1, noStaleCards);
            AddLink(conv, 1202, 202);
            AddLink(conv, 1202, 203);

            var staleDuelHub = AddLine(conv, 201, NarratorId, RomusId, "Stalemate_Leverage_Hub",
                "Smolak watched your eyes like a card shark staking his final chip. If you have accumulated enough leverage—from bombing dossiers, full arsenals, naval blockade, or AN legitimacy—you might break this deadlock and force Zille back even without a total breakthrough.", -1,
                "(((Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true) or Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] == true) or (Variable[\"Zille_AN_Legitimacy\"] or 0) >= 3) or ((Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 or (Variable[\"Zille_NavalBlockadeActive\"] == true or Variable[\"Zille_DerdiaHybridActive\"] == true))");

            staleDuelHub.outgoingLinks.Add(CreateLink(conv.id, 201, 204)); // Counter with Bombing Evidence / AN Law (+2 Leverage)
            staleDuelHub.outgoingLinks.Add(CreateLink(conv.id, 201, 206)); // Counter with Arsenals >=1000 / Encirclement (+2 Leverage)
            staleDuelHub.outgoingLinks.Add(CreateLink(conv.id, 201, 208)); // Move directly to Stalemate Verdict

            AddChoice(conv, 204, SmolakId, "Stalemate_Press_Evidence",
                "\"Drop the 'neutral republic' farce! Our 1927 treaty rights and bombing dossier bury you at the AN!\"",
                "Don't lecture me about neutral states, Wiktor! The 1927 lease expired legally, the world knows about your terror tactics, and AN sanctions will strangle Wraclawitz long before our treasury breaks!", 205,
                "Variable[\"Zille_Stale_PressedLaw\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2;",
                "(((Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true) or Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] == true) or (Variable[\"Zille_AN_Legitimacy\"] or 0) >= 3)");

            AddLine(conv, 205, NarratorId, RomusId, "Ack_Stale_Evidence",
                "Smolak's smirk cracked slightly as he rubbed his temple. \"Lawyers and files... Fine, Romus, you've got teeth in Konstantium. Put your final answer on the table.\"", -1);

            AddChoice(conv, 206, SmolakId, "Stalemate_Press_Steel",
                "\"Look at our Brenas depots and the Gulf—over a thousand spare arms while Wehlen's convoys starve!\"",
                "Your trenches in Zille are running dry while our depots hold over a thousand reserve weapons and our ships and allies choke your resupply! You will break first in a war of attrition, Wiktor!", 207,
                "Variable[\"Zille_Stale_PressedSteel\"] = true; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;",
                "((Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 or (Variable[\"Zille_NavalBlockadeActive\"] == true or Variable[\"Zille_DerdiaHybridActive\"] == true))");

            AddLine(conv, 207, NarratorId, RomusId, "Ack_Stale_Steel",
                "Smolak stubbed out his cigarette roughly, eyes darting to the map pins along the Strait of Kreleck. \"Damn your navy and damn your warehouses... What is your verdict?\"", -1);

            AddChoice(conv, 208, SmolakId, "Stalemate_Skip_Sparring",
                "\"Enough sparring, Wiktor. Let us settle the fate of Zille right now.\"",
                "Enough sparring across this table, Wiktor. Let us settle the fate of Zille right now.", -1);

            AddLink(conv, 205, 202);
            AddLink(conv, 205, 203);
            AddLink(conv, 207, 202);
            AddLink(conv, 207, 203);
            AddLink(conv, 208, 202);
            AddLink(conv, 208, 203);

            AddLine(conv, 202, NarratorId, RomusId, "Stalemate_Hub_Lucita",
                "Beside the canvas flap, your chief operations staff kept rigid silence, awaiting your final call on whether to compromise, force victory through sheer leverage, or freeze the front.", -1);

            AddLine(conv, 203, NarratorId, RomusId, "Stalemate_Hub_NoLucita",
                "Your staff officers stood silent as Smolak awaited your final verdict on the stalemate.", -1,
                "false");

            foreach (int h in new[] { 202, 203 })
            {
                AddLink(conv, h, 215); // Leverage >= 5 breakthrough!
                AddLink(conv, h, 210); // Independent Buffer
                AddLink(conv, h, 220); // Armed Ceasefire (Tactical Defeat)
            }

            // BREAKTHROUGH OPTION: Force Zille Return on Stalemate if Leverage >= 5!
            AddChoice(conv, 215, SmolakId, "Force_Zille_Return_Leverage",
                "\"[MASTER LEVERAGE] No buffer state—your position is untenable! Return Zille to Rizia NOW!\"",
                "Enough games, Wiktor. Between our 1927 treaty standing, our reserves, and the stranglehold closing around Wehlen, you cannot hold Zille another month. Sign the Restoration of Zille and pull your men across the Gulf—before you lose Wraclawitz too!", 216,
                "Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Zille_Leverage_Triumph\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 3 or (Variable[\"Zille_War_Outcome\"] or 0) == 0) and (Variable[\"Zille_Leverage\"] or 0) >= 5");

            AddLine(conv, 216, SmolakId, RomusId, "Smolak_Folded_Leverage",
                "Silence stretched for ten suffocating seconds inside the tent. Smolak stared at your face, then down at his cold tea, then suddenly slammed the pen into the parchment. \"You cold, calculating devil... You didn't win it cleanly on the hills, Romus, yet you boxed me in everywhere else! Take Zille back and choke on it!\"", -1);

            AddChoice(conv, 210, SmolakId, "Accept_Independent_Buffer",
                "\"Agreed. Establish the Independent Neutral State of Zille under international charter.\"",
                "An Independent Neutral Zille. It ends the bloodshed, frees Zille from your grip, and separates our armies under AN oversight. I accept.", 211,
                "Variable[\"Zille_War_Outcome\"] = 3; Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;");

            AddLine(conv, 211, NarratorId, RomusId, "Smolak_Buffer_Signed",
                "Smolak smiled with shrewd relief, clinking his tin cup against the table. \"A statesman's compromise, Romus. Let the clerks in Konstantium draft the charters.\"", -1);

            AddChoice(conv, 220, SmolakId, "Reject_Buffer_Ceasefire",
                "\"Never. Zille is Rizian or nothing—we freeze the frontlines under an armed ceasefire.\"",
                "I will never sign away our sovereignty to an artificial buffer state. We freeze the frontlines under an armed ceasefire—this reckoning is merely postponed.", 221,
                "Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;");

            AddLine(conv, 221, NarratorId, RomusId, "Smolak_Ceasefire_Signed",
                "Smolak snorted, tossing his butt into the mud. \"Suit yourself, King. An armed truce it is.\"", -1);

            // ================= BRANCH C: TACTICAL DEFEAT / TOTAL FIASCO (+ LEVERAGE SALVAGE) =================
            AddLine(conv, 300, NarratorId, RomusId, "Smolak_Victorious_Mock",
                "Smolak leaned back with a predatory grin, spreading his arms wide. \"How fast royal pride melts when the guns fall quiet, eh, Romus? Wehlen's divisions shattered your offensive!\"", -1);

            AddLine(conv, 301, SmolakId, RomusId, "Smolak_TacticalDefeat_Terms",
                "\"You bled for zero ground gained! Withdraw behind the Brenas line, drop all claim to Zille, and swallow an armistice while my mood stays generous.\"", -1,
                "((Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 302, SmolakId, RomusId, "Smolak_Fiasco_Terms",
                "\"My armored columns sit inside Brenas right now, 'Your Majesty'! Sign over southern Brenas to Wraclawitz, or I let my tanks roll toward Porte Drazon!\"", -1,
                "Variable[\"Zille_War_Outcome\"] == 1");

            AddLink(conv, 300, 301);
            AddLink(conv, 300, 302);

            // Salvage option on Total Fiasco if Leverage >= 4 AND Budget >= 2!
            AddChoice(conv, 305, SmolakId, "Salvage_Brenas_Leverage",
                "\"[LEVERAGE SALVAGE] Take 2 Budget and drop claims on Zille—but AN pressure & our dossier bar you from Brenas!\"",
                "Hold your horses, Wiktor! Your forward columns are overextended, we hold bombing dossiers, and if you annex a single Rizian town in Brenas, Rumburg and the AN will crush Wehlen! Take 2 Budget in gold and keep your army strictly behind the pre-war border!", 306,
                "Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Brenas_Lost_To_Wehlen\"] = false; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) - 2; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true; Variable[\"Zille_Brenas_Saved_By_Leverage\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 1 or (Variable[\"Zille_War_Outcome\"] or 0) == 0) and (Variable[\"Zille_Leverage\"] or 0) >= 4 and (Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 2");

            AddLine(conv, 306, NarratorId, RomusId, "Ack_Salvage_Brenas",
                "Smolak froze halfway through his laughter, calculating rapidly behind narrowed eyes. \"Damn those Thornbourgh sharks... and damn your pocketbook. Fine, King—two million in gold, keep your Brenas towns, and crawl back south with nothing!\"", -1);

            AddChoice(conv, 310, SmolakId, "Accept_Tactical_Defeat",
                "\"We withdraw behind the Brenas frontier and sign the bitter armistice.\"",
                "To spare our kingdom further ruin, Rizia accepts an armistice along the pre-war frontier and suspends claims over Zille. Do not mistake restraint for final submission.", 311,
                "Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 312, SmolakId, "Accept_Tactical_Defeat_Defiant",
                "\"I sign under protest, Wiktor—this border truce will not outlast Rizia's memory.\"",
                "I sign this armistice under protest to save our wounded. Enjoy your hollow victory while it lasts, Wiktor—Zille remains Rizian in blood and law.", 311,
                "Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 311, NarratorId, RomusId, "Smolak_Signs_TacticalDefeat",
                "Smolak cackled softly, signing with an exaggerated flourish. \"Enjoy explaining this triumph to your noble houses, Romus!\"", -1);

            AddChoice(conv, 320, SmolakId, "Accept_Total_Fiasco",
                "\"Sign the humiliating surrender of southern Brenas to save Porte Drazon.\"",
                "To save the capital and our citizens from destruction, I sign this bitter surrender. Withdraw from the approaches to Porte Drazon.", 321,
                "Variable[\"Zille_War_Outcome\"] = 1; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 1 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 322, SmolakId, "Accept_Total_Fiasco_Silent",
                "\"Affix the royal seal in grim silence, refusing to give Smolak the satisfaction of a word.\"",
                "I place my seal upon this parchment to spare our civilians. Take your ink and clear my sight.", 321,
                "Variable[\"Zille_War_Outcome\"] = 1; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 1 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 321, NarratorId, RomusId, "Smolak_Signs_Fiasco",
                "Smolak laughed uproariously, slapping the table. \"History will remember today, King Romus! Your father gave me Zille; you just handed me Brenas! Good luck surviving your own generals tonight!\"", -1);

            // REFUSE NEGOTIATIONS WHEN COUNTRY CANNOT ENDURE -> HOUSE AZARO COUP & EXILE!
            AddChoice(conv, 330, SmolakId, "Refuse_Parley_Collapse",
                "\"Tear up his surrender terms and walk out—Rizia refuses to ratify this shame even if the throne burns!\"",
                "Put your pen down, Wiktor. Even shattered and bled white, a King of House Toras does not sign away Rizia's soil at gunpoint. Let the artillery speak until the end!", 331,
                "Variable[\"Zille_Parley_Refused\"] = true; Variable[\"Zille_Azaro_Coup_Collapse\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true; Variable[\"Brenas_Lost_To_Wehlen\"] = true; Variable[\"RiziaDLC.Azaro_HasPowerToCoup\"] = true; Variable[\"RiziaDLC.Ending_Coup_Azaro\"] = true; Variable[\"RiziaDLC.Epilogue_Exile_Forced\"] = true; Variable[\"RiziaDLC.Epilogue_Exile_CoupWarning\"] = true;");

            AddLine(conv, 331, SmolakId, RomusId, "Smolak_Parley_Refused_Warn",
                "Smolak's jaw dropped for half a second before breaking into a harsh, barking laugh. \"Walk out into the mud if you want, Your Majesty! Our shells start falling toward Mave Nortus within the hour—and see if Taddeus Azaro's officers leave the gates of Palas Rezna open for you when your country cracks!\"", 332);

            AddLine(conv, 332, NarratorId, RomusId, "Carlos_Coup_Alert_Collapse",
                "You strode out of the pavilion into cold rain—and never reached Palas Rezna. Halfway down the highway, frantic encrypted wires caught your motorcade: rail strikes and bread riots had erupted across Valenqiris, depleted battalions refused to march back to the guns, and House Azaro's commanders had proclaimed an emergency junta in Porte Drazon. Before midnight, loyal outriders rushed you toward a waiting plane bound for Kyrute.", -1);

            AddLink(conv, 301, 310);
            AddLink(conv, 301, 312);
            AddLink(conv, 301, 320);
            AddLink(conv, 301, 322);
            AddLink(conv, 301, 305);
            AddLink(conv, 301, 330);
            AddLink(conv, 302, 320);
            AddLink(conv, 302, 322);
            AddLink(conv, 302, 305);
            AddLink(conv, 302, 330);

            AddConversationWithAlias(db, conv, "Zille/WarSmolakFinalParley", "Turn_Zille_WarSmolakFinalParley");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Smolak Final Parley (ID 9992) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 11: Turn_Zille_WarPeaceTreaty (ID 9993) - PEACE TREATY CEREMONY
        // Features:
        // - Outcome-gated ratification + separate Zille vs Pales casualty reflections
        // - AN Legitimacy reflection + Leverage Reparations Treaty variant
        // - Full Hugo/Lucita/Taddeus/Carlos absence & hostility handling
        // =========================================================================
        public static void RegisterWarPeaceTreaty(DialogueDatabase db)
        {
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
                "The Grand Throne Room of Palas Rezna had been arranged for the formal ratification of the Treaty of Zille. Tall stained-glass lancets cast amber light across the marble aisle, where foreign ambassadors from Konstantium, provincial nobles, and scarred field officers stood beneath the towering portraits of Rizian kings before the parchment instrument and the Great Seal of House Toras.", -1);

            AddChoice(conv, 401, NarratorId, "Treaty_Stimulus_Nobles",
                "Pause halfway down the marble aisle to incline your head calmly toward the assembled houses and officers.",
                "", 404, "");

            AddChoice(conv, 402, NarratorId, "Treaty_Stimulus_Seal",
                "Walk straight to the dais, keeping your gaze fixed on the heavy gold Great Seal beside the parchment.",
                "", 405, "");

            AddLine(conv, 404, NarratorId, RomusId, "Treaty_Entry_Nobles",
                "A ripple of rustling velvet and clinking sabers answered your nod—the realm's estates watching closely to see how their King carried the weight of the peace.", -1);

            AddLine(conv, 405, NarratorId, RomusId, "Treaty_Entry_Seal",
                "Your boots echoed cleanly across the quiet marble floor. Behind the velvet ropes, foreign correspondents raised their pencils as you reached the dais.", -1);

            AddLink(conv, 1, 401);
            AddLink(conv, 1, 402);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Treaty_Declaration",
                "Your Majesty... The guns have fallen silent across the peninsula. The scribes await your royal seal to close this war in the annals of Rizia.", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Treaty_Declaration",
                "Your Majesty. The diplomatic instrument lies before you, witnessed by foreign envoys from Konstantium. The realm awaits your royal signature.", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 404, 2);
            AddLink(conv, 404, 102);
            AddLink(conv, 405, 2);
            AddLink(conv, 405, 102);

            // AN Standing + Separate Fronts acknowledgment before signing
            AddLine(conv, 200, LaurentoId, RomusId, "Treaty_AN_HighLegitimacy",
                "\"Thanks to our strict adherence to the lapsed 1927 agreement and civilized conduct, even neutral delegates in Kyrute acknowledge Rizia acted with restraint.\"", -1,
                "(Variable[\"Zille_AN_Legitimacy\"] or 0) >= 3");

            AddLine(conv, 201, LaurentoId, RomusId, "Treaty_AN_PalesShadow",
                "\"While our Zille casualty ledger stands distinct, fighting concurrently against Pales has stretched foreign sympathy thin—we must ratify cleanly and stabilize the realm.\"", -1,
                "(Variable[\"Zille_AN_Legitimacy\"] or 0) < 3 and ((Variable[\"Zille_Pales_TotalPlayerDead\"] or 0) > 0 or Variable[\"RiziaDLC.Pales_War\"] == true or Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] == true or Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] == true)");

            AddLine(conv, 202, LaurentoId, RomusId, "Treaty_AN_Standard",
                "\"Both superpowers are closely observing the exact clauses inscribed on this parchment today, Your Majesty.\"", -1,
                "(Variable[\"Zille_AN_Legitimacy\"] or 0) < 3 and ((Variable[\"Zille_Pales_TotalPlayerDead\"] or 0) <= 0 and Variable[\"RiziaDLC.Pales_War\"] ~= true and Variable[\"RiziaDLC.Diplomacy_Pales_DeclareWar\"] ~= true and Variable[\"RiziaDLC.CountryRelation_Pales_AtWar\"] ~= true)");

            foreach (int h in new[] { 2, 102 })
            {
                AddLink(conv, h, 200);
                AddLink(conv, h, 201);
                AddLink(conv, h, 202);
            }

            // Outcome-routed multi-choice signing hubs (NEVER a 1-choice menu!)
            var triumphHub = AddLine(conv, 7, NarratorId, RomusId, "Outcome_Triumph_Prompt",
                "With Wehzek armies shattered deep inside their own heartland, the ambassadors rose in hushed awe as you stepped to the marble table to seal the Total Triumph.", -1,
                "(Variable[\"Zille_War_Outcome\"] or 0) == 5 and Variable[\"Zille_Independent_Buffer\"] ~= true");

            var victoryHub = AddLine(conv, 3, NarratorId, RomusId, "Outcome_Victory_Prompt",
                "You stepped forward to the marble table to affix the Great Seal of Rizia to the Treaty of Restoration. How do you dedicate this triumph before the realm and the watching envoys?", -1,
                "((Variable[\"Zille_War_Outcome\"] or 0) == 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0) and Variable[\"Zille_Independent_Buffer\"] ~= true");

            var bufferHub = AddLine(conv, 4, NarratorId, RomusId, "Outcome_Buffer_Prompt",
                "You stepped forward to the marble table to ratify the Charter of Neutrality for the Independent Republic of Zille.", -1,
                "(Variable[\"Zille_War_Outcome\"] or 0) == 3 or Variable[\"Zille_Independent_Buffer\"] == true");

            var defeatHub = AddLine(conv, 5, NarratorId, RomusId, "Outcome_Defeat_Prompt",
                "A heavy hush hung over the Grand Throne Room as you approached the marble table to ratify the Brenas Armistice.", -1,
                "(Variable[\"Zille_War_Outcome\"] or 0) == 2 and Variable[\"Zille_Independent_Buffer\"] ~= true");

            var fiascoHub = AddLine(conv, 6, NarratorId, RomusId, "Outcome_Fiasco_Prompt",
                "Murmurs of disbelief and anger rippled along the marble pillars as you stepped toward the Instrument of Surrender.", -1,
                "(Variable[\"Zille_War_Outcome\"] or 0) == 1 and Variable[\"Zille_Independent_Buffer\"] ~= true");

            foreach (int anId in new[] { 200, 201, 202 })
            {
                AddLink(conv, anId, 7);
                AddLink(conv, anId, 3);
                AddLink(conv, anId, 4);
                AddLink(conv, anId, 5);
                AddLink(conv, anId, 6);
            }

            triumphHub.outgoingLinks.Add(CreateLink(conv.id, 7, 70));
            triumphHub.outgoingLinks.Add(CreateLink(conv.id, 7, 71));
            triumphHub.outgoingLinks.Add(CreateLink(conv.id, 7, 72));

            string treatyDoneVars = "Variable[\"Zille_PeaceTreaty_Signed\"] = true; Variable[\"Zille_Rep_TreatyDone\"] = true; Variable[\"Zille_Negotiations_Done\"] = true; Variable[\"Zille_War_Completed\"] = true; Variable[\"Zille_War_Active\"] = false; Variable[\"Zille_War_EarlyLaunch\"] = false; Variable[\"Zille_War_UltimatumGiven\"] = false; Variable[\"Zille_War_Mobilization\"] = false; ";

            AddChoice(conv, 70, HugoId, "Sign_Triumph_Derdia",
                "\"Proclaim the Free City of Grodzizg under joint Rizian-Derdian protection and the restoration of Zille!\"",
                "By the Great Seal of Rizia and the bond sworn with Supreme Wiseman Azmal, Zille returns to the Crown, Wehlen's southern border is demilitarized, and Grodzizg stands as a Free City of commerce and peace!", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Grodzizg_FreeCity\"] = true;",
                "Variable[\"Zille_DerdiaPact_Signed\"] == true");

            AddChoice(conv, 71, HugoId, "Sign_Triumph_Crown",
                "\"Proclaim Zille's restoration, Wehlen's indemnities, and the Free City Charter of Grodzizg!\"",
                "Let every court in Merkopa witness this hour: Zille returns forever to House Toras, Wehlen pays full restitution, and Grodzizg rises as a protected Free City!", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Grodzizg_FreeCity\"] = true;");

            AddChoice(conv, 72, HugoId, "Sign_Triumph_Peace",
                "\"Dedicate this overwhelming victory to lasting southern stability and the memory of our fallen.\"",
                "With Wehlen's southern front dismantled and Zille restored to our kingdom, we dedicate this decisive peace to our fallen soldiers and the security of every Rizian home!", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Grodzizg_FreeCity\"] = true; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            // Victory choices (always 3 choices when Victory/Triumph!)
            victoryHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
            victoryHub.outgoingLinks.Add(CreateLink(conv.id, 3, 15));
            victoryHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20));

            AddChoice(conv, 10, HugoId, "Sign_Victory_Dynasty",
                "\"Dedicate this restoration to House Toras and the healing of King Valero's 1927 wound!\"",
                "In the presence of Saint Wruhec and the noble estates of Rizia, I affix the royal seal. The wound of 1927 is healed—Zille returns to the Crown of Rizia!", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true;");

            AddChoice(conv, 15, HugoId, "Sign_Victory_Soldiers",
                "\"Dedicate this treaty to the fallen soldiers and the steadfast people of Zille and Brenas!\"",
                "This seal honors every Rizian soldier who bled on those hills and every citizen of Zille who kept faith in darkness. Today our kingdom stands whole again!", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1;");

            AddChoice(conv, 20, HugoId, "Sign_Victory_Sovereignty",
                "\"Proclaim to every embassy in Konstantium: Rizia's borders are inviolable!\"",
                "Let every ambassador here carry one message back to Konstantium: Rizia honors her treaties, and Rizia defends her sovereignty without flinching!", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddLine(conv, 11, HugoId, RomusId, "Ack_Decisive_Ceremony",
                "The throne room erupted into thunderous cheers, bells pealing from every sanctuary in Porte Drazon. Hugo wiped tears of joy from his eyes, bowing deeply before his King. \"Nearly thirty years of grief washed away in triumph! Long live King Romus the Restorer!\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 111, LaurentoId, RomusId, "Ack_Decisive_NoHugo",
                "Thunderous applause shook the marble pillars as cathedral bells rang across Porte Drazon. Laurento bowed deeply. \"A historic restoration, Your Majesty. Zille is home.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            string estelaAliveCond = "Variable[\"QueenMother_Estela_Dead\"] ~= true and Variable[\"RiziaDLC.Estela_Dead\"] ~= true and Variable[\"RiziaDLC.Estela_EarlyExile\"] ~= true";
            string repOrGrodCond = "(Variable[\"Zille_Reparations_Won\"] == true or Variable[\"Grodzizg_FreeCity\"] == true)";

            AddLine(conv, 112, EstelaId, RomusId, "Estela_Treaty_Joy",
                "From the royal gallery, Queen Mother Estela pressed a lace handkerchief to her eyes, smiling down at you with quiet, radiant pride for the fishing harbor of her youth.", -1,
                estelaAliveCond);

            AddLine(conv, 113, ElenaId, RomusId, "Elena_Treaty_Indemnities",
                "Elena leaned over the parchment ledger with rare satisfaction. \"And with Wehlen's reconstruction indemnities and crude deliveries sealed in black and white, Brenas will rebuild twice as fast.\"", -1,
                repOrGrodCond);

            AddLine(conv, 114, NarratorId, RomusId, "Treaty_Victory_FinalClose",
                "With the crimson wax cooled upon the Great Seal of House Toras, marshals and foreign envoys alike bowed—Rizia's southern star once more shone over an undivided realm.", -1);

            foreach (int vCh in new[] { 10, 15, 20, 70, 71, 72 })
            {
                AddLink(conv, vCh, 11);
                AddLink(conv, vCh, 111);
            }
            AddLink(conv, 11, 112);
            AddLink(conv, 11, 113);
            AddLink(conv, 11, 114);
            AddLink(conv, 111, 112);
            AddLink(conv, 111, 113);
            AddLink(conv, 111, 114);
            AddLink(conv, 112, 113);
            AddLink(conv, 112, 114);
            AddLink(conv, 113, 114);

            // Buffer choices (always 2 choices!)
            bufferHub.outgoingLinks.Add(CreateLink(conv.id, 4, 30));
            bufferHub.outgoingLinks.Add(CreateLink(conv.id, 4, 32));

            AddChoice(conv, 30, HugoId, "Sign_Independent_Buffer",
                "\"Praise international peace and open transit across the Strait of Kreleck.\"",
                "To spare our people further carnage, I sign the charter establishing the Independent Neutral State of Zille. May this neutral territory stand as a peaceful bridge rather than a battlefield.", 31,
                treatyDoneVars + "Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;");

            AddChoice(conv, 32, HugoId, "Sign_Independent_Buffer_Ties",
                "\"Affix the seal and pledge Rizia's enduring cultural and economic protection to Zille's citizens.\"",
                "Though Zille walks as a neutral state under AN charter, Rizia will never sever the bonds of kinship, trade, and faith linking our peoples.", 31,
                treatyDoneVars + "Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            AddLine(conv, 31, LaurentoId, RomusId, "Ack_Buffer_Ceremony",
                "Laurento bowed solemnly. \"The Alliance of Nations applauds your royal restraint, Your Majesty. Peace and guaranteed transit across the Strait of Kreleck are secured.\"", -1);

            // Tactical Defeat choices (always 2 choices!)
            defeatHub.outgoingLinks.Add(CreateLink(conv.id, 5, 40));
            defeatHub.outgoingLinks.Add(CreateLink(conv.id, 5, 42));

            AddChoice(conv, 40, HugoId, "Sign_Tactical_Defeat",
                "\"Sign the Armed Armistice with somber resolve: Brenas endures.\"",
                "With a heavy heart, I sign this armistice. Our soldiers fought with valor, yet Brenas must endure while we rebuild our strength. Zille remains outside our grasp... for now.", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;");

            AddChoice(conv, 42, HugoId, "Sign_Tactical_Defeat_Warning",
                "\"Sign, yet warn every ambassador present that Rizia's lawful claim is only suspended.\"",
                "I place my seal upon this truce to spare our wounded, yet let Konstantium record this truth: Rizia suspends her sword—never her rightful claim.", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;");

            AddLine(conv, 41, HugoId, RomusId, "Ack_Tactical_Defeat",
                "A somber silence fell over the throne room. Hugo sighed deeply, his shoulders bowed. \"A bitter day for House Toras, Romus—yet Brenas survives, and the realm endures.\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 141, LaurentoId, RomusId, "Ack_Tactical_Defeat_NoHugo",
                "A heavy hush fell over the chamber. Laurento lowered his eyes solemnly. \"A bitter hour, Your Majesty, yet the kingdom remains intact to rise another day.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            foreach (int dCh in new[] { 40, 42 })
            {
                AddLink(conv, dCh, 41);
                AddLink(conv, dCh, 141);
            }

            // Total Fiasco choices (always 2 choices!)
            fiascoHub.outgoingLinks.Add(CreateLink(conv.id, 6, 50));
            fiascoHub.outgoingLinks.Add(CreateLink(conv.id, 6, 52));

            AddChoice(conv, 50, HugoId, "Sign_Total_Fiasco",
                "\"Sign the Instrument of Surrender to spare Porte Drazon from destruction.\"",
                "To prevent the destruction of Porte Drazon, I sign this humiliating peace. May Nur forgive me for the tragedy that has befallen our kingdom.", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true; Variable[\"RiziaDLC.Azaro_HasPowerToCoup\"] = true;");

            AddChoice(conv, 52, HugoId, "Sign_Total_Fiasco_Silent",
                "\"Press the Great Seal into the wax in dead silence, accepting the Crown's responsibility.\"",
                "I offer no excuses before this court. I affix the seal to save our capital, and I bear the reckoning alone.", -1,
                treatyDoneVars + "Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true; Variable[\"RiziaDLC.Azaro_HasPowerToCoup\"] = true;");

            AddLine(conv, 51, NarratorId, RomusId, "Ack_Total_Fiasco",
                "Shouts of outrage broke out among the assembled officers. Duke Taddeus stormed from the hall in disgust while dark whispers of a military coup echoed through the stone corridors.", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 151, NarratorId, RomusId, "Ack_Total_Fiasco_NoTaddeus",
                "Shouts of outrage erupted among the assembled noble houses and generals. Officers slammed their sabers onto the marble floor, and whispers of mutiny filled Palas Rezna.", -1,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            foreach (int fCh in new[] { 50, 52 })
            {
                AddLink(conv, fCh, 51);
                AddLink(conv, fCh, 151);
            }

            AddConversationWithAlias(db, conv, "Zille/WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Peace Treaty Ceremony (ID 9993) into masterDatabase!");
        }
    }
}
