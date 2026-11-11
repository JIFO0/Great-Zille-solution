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
        // Fixed: No river/desert, no gilded armor/breastplate, full Outcome gating:
        // Victory (4/5), Stalemate (3), AND Defeat/Fiasco (1/2)!
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
                "The neutral pavilion stood on a muddy rise between the forward trenches, draped in white flags snapping in the salt breeze off the Gulf of Moridia. Outside, Golden Guards in gold-trimmed greatcoats stood eye-to-eye with Wehzek guardsmen holding submachine guns. Inside, Wiktor Smolak sat slumped in a folding chair, pouring bitter black tea into a tin cup, a half-smoked cigarette dangling from his lips.", 2);

            AddLine(conv, 2, SmolakId, RomusId, "Smolak_Parley_Greeting",
                "Look who finally arrived! The great King Romus of Rizia in the flesh. Tell me, Your Majesty... Do you care for tea? Wehzek chicory blend. Tastes like gunpowder and mud, yet it keeps a man awake while the artillery roars.", 3);

            var parleyHub = AddLine(conv, 3, RomusId, SmolakId, "Romus_Parley_Posture_Prompt",
                "I sat across the scarred folding table, looking into the bloodshot, calculating eyes of the Wehzek president.");

            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Victory posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Stalemate posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Defiant victory posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Defeat posture

            AddChoice(conv, 10, SmolakId, "Posture_Victor",
                "\"Your army is shattered, Smolak. Sign the capitulation and evacuate Zille today.\"",
                "Your garrisons are broken and your sea lanes across the Gulf are severed, Smolak. We are not here to drink tea. Sign the evacuation instrument and pull your surviving troops back across the sea to Wehlen today.", 100,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) >= 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 20, SmolakId, "Posture_Stalemate",
                "\"Both our armies have bled enough. Let us discuss a realistic settlement.\"",
                "Both our nations have bled enough into this mud, Smolak. If this slaughter continues, neither of us will have an economy left. Let us discuss terms for an end to hostilities.", 200,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) == 3 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 30, SmolakId, "Posture_Defiant",
                "\"You brought this defeat upon yourself when you tried to extort House Toras.\"",
                "You brought this ruin upon Wehlen when you thought you could extort House Toras and hold Rizian soil hostage. Every drop of blood spilled rests on your head.", 100,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) >= 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddChoice(conv, 40, SmolakId, "Posture_Defeated",
                "\"Our offensive has stalled, Wiktor. Let us speak plainly about halting the bloodshed.\"",
                "Fortune turned against our arms on the field, Wiktor. Spare me your theatrics and put your terms on the table so we may stop the slaughter.", 300,
                "", "((Variable[\"Zille_War_Outcome\"] or 0) == 1 or (Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            // ================= BRANCH A: DECISIVE VICTORY / OVERWHELMING TRIUMPH =================
            AddLine(conv, 100, SmolakId, RomusId, "Smolak_Defeated_Rant",
                "Smolak ground his cigarette into the floorboards beneath his boot, his hands trembling with suppressed fury. \"You think you're a conqueror, Romus? You think waving a map makes you a hero?! Fine! Valdez blundered, and my generals couldn't organize a parade in Wraclawitz!\"", 101);

            AddLine(conv, 101, SmolakId, RomusId, "Smolak_Defeated_Terms",
                "\"Take Zille! Take your precious mines and harbors! Yet Wehlen will not pay a single coin of tribute! Let my surviving boys embark by sea back to mainland Wehlen with their rifles, and I will sign your damned treaty.\"", 102);

            var victoryChoiceHub = AddLine(conv, 102, NarratorId, RomusId, "Victory_Terms_Prompt",
                "Smolak leaned across the table, cornered, desperate, yet stubbornly bargaining for survival.");

            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 110)); // Decisive Victory
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 120)); // Overwhelming Triumph

            AddChoice(conv, 110, SmolakId, "Accept_Decisive_Surrender",
                "\"Zille returns unconditionally to Rizia. Your surviving troops may evacuate by sea.\"",
                "Zille returns unconditionally to the Crown of Rizia, effective immediately. Your surviving garrisons may evacuate across the Gulf of Moridia under white flags. Yet if a single Wehzek soldier sets foot in Zille again, it means total war.", 111,
                "Variable[\"Zille_War_Outcome\"] = 4; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) >= 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 111, SmolakId, RomusId, "Smolak_Signs_Decisive",
                "Smolak snatched the pen, scribbling his signature with vicious, jagged strokes before tossing it onto the parchment. \"Done! Pack up, boys, we're sailing home! Enjoy your oilfields and your headaches, Romus!\"", -1);

            AddChoice(conv, 120, SmolakId, "Demand_Overwhelming_Triumph",
                "\"Not enough. You will cede Zille, pay massive war indemnities, and grant Grodzizg autonomy!\"",
                "Not enough, Smolak. Our forces already hold deep targets in mainland Wehlen. You will cede Zille, pay massive gold and energy reparations, demilitarize your coast, and accept protected Free City status for Grodzizg. Sign, or our columns push straight toward Wraclawitz!", 121,
                "Variable[\"Zille_War_Outcome\"] = 5; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"Grodzizg_FreeCity\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = (Variable[\"RiziaDLC.Resources_Budget\"] or 0) + 4; Variable[\"RiziaDLC.Resources_Energy\"] = (Variable[\"RiziaDLC.Resources_Energy\"] or 0) + 3;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 5 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 121, SmolakId, RomusId, "Smolak_Signs_Overwhelming",
                "Smolak turned ashen, his bravado evaporating into panic as he stared at the map pins deep inside Wehlen. \"You're ruthless, Romus... an absolute shark! Damn you... I'll sign. Just halt your armor! Keep Rotsla and Wraclawitz out of this!\" He signed with shaking hands.", -1);

            // ================= BRANCH B: BLOODY STALEMATE & INDEPENDENT ZILLE BUFFER =================
            AddLine(conv, 200, SmolakId, RomusId, "Smolak_Stalemate_Opening",
                "Smolak took a deep drag of his cigarette, blowing gray smoke toward the canvas roof. \"Neither of us can break the other, Romus. Your tanks stalled on the approaches to Zille City, and my boys can't crack Brenas. We can keep feeding young men into artillery fire until Kyrute chains us both... or we can be clever.\"", 201);

            AddLine(conv, 201, SmolakId, RomusId, "Smolak_Buffer_Proposal",
                "\"Here is my offer: an Independent Zille. Neither Rizia nor Wehlen. A demilitarized neutral buffer state, governed by a joint civilian council, with guaranteed oil and sea transit rights for both our nations. Neither of us loses face. What do you say, Your Majesty?\"", -1);

            AddLine(conv, 202, NarratorId, RomusId, "Stalemate_Hub_Lucita",
                "Lucita frowned with deep skepticism, while Smolak watched your eyes like a card shark staking his final hand.", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 203, NarratorId, RomusId, "Stalemate_Hub_NoLucita",
                "Your staff officers exchanged tense glances while Smolak watched your eyes like a card shark staking his final hand.", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 201, 202);
            AddLink(conv, 201, 203);
            AddLink(conv, 202, 210);
            AddLink(conv, 202, 220);
            AddLink(conv, 203, 210);
            AddLink(conv, 203, 220);

            AddChoice(conv, 210, SmolakId, "Accept_Independent_Buffer",
                "\"Agreed. Zille shall become an Independent Neutral Buffer State under international guarantee.\"",
                "An Independent Neutral Zille. It ends the bloodshed, rescues our economy, and frees the people of Zille from your grip while separating our borders. I accept. Let the Alliance of Nations ratify the neutral charter.", 211,
                "Variable[\"Zille_War_Outcome\"] = 3; Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;");

            AddLine(conv, 211, SmolakId, RomusId, "Smolak_Buffer_Signed",
                "Smolak smiled, a genuine glint of shrewd relief in his eyes as he tapped his tin cup against the table. \"A statesman's compromise, Romus. Let the clerks in Konstantium draft the charters. The war is over.\"", -1);

            AddChoice(conv, 220, SmolakId, "Reject_Buffer_Ceasefire",
                "\"Never. Zille is Rizian or nothing. We freeze the frontlines under an armed ceasefire.\"",
                "Zille has been Rizian for centuries; I will never recognize an artificial state carved out of our historical province. We freeze the lines under an armed ceasefire—and remember that this dispute is not over.", 221,
                "Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;");

            AddLine(conv, 221, SmolakId, RomusId, "Smolak_Ceasefire_Signed",
                "Smolak snorted, flicking his cigarette butt into the mud. \"Suit yourself, King. An armed truce it is. Just keep your border sentries' fingers off their triggers.\"", -1);

            // ================= BRANCH C: TACTICAL DEFEAT / TOTAL FIASCO =================
            AddLine(conv, 300, SmolakId, RomusId, "Smolak_Victorious_Mock",
                "Smolak leaned back with a theatrical, predatory grin, spreading his arms wide. \"Ah! How quickly royal arrogance melts when the shells stop flying, eh, Romus? You marched north expecting a coronation parade, and instead General Valdez broke your spearheads!\"", -1);

            AddLine(conv, 301, SmolakId, RomusId, "Smolak_TacticalDefeat_Terms",
                "\"Your adventure cost thousands of lives and gained you nothing. Withdraw your battered divisions behind the Brenas line, drop your claim to Zille, and pay Wehlen modest customs compensation—and I will refrain from marching further south.\"", -1,
                "((Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 302, SmolakId, RomusId, "Smolak_Fiasco_Terms",
                "\"My armored columns are sitting inside Brenas right now, 'Your Majesty'! You gambled and lost everything. Sign the surrender of southern Brenas and pay war indemnities to Wraclawitz, or I let my troops march all the way to Porte Drazon!\"", -1,
                "Variable[\"Zille_War_Outcome\"] == 1");

            AddLink(conv, 300, 301);
            AddLink(conv, 300, 302);

            AddChoice(conv, 310, SmolakId, "Accept_Tactical_Defeat",
                "\"We will withdraw behind the Brenas frontier and sign the armistice.\"",
                "To spare our kingdom further ruin, Rizia accepts an armistice along the pre-war frontier and suspends military claims over Zille. Do not mistake restraint for surrender, Wiktor.", 311,
                "Variable[\"Zille_War_Outcome\"] = 2; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 311, SmolakId, RomusId, "Smolak_Signs_TacticalDefeat",
                "Smolak cackled softly, signing with an exaggerated flourish. \"Oh, I wouldn't dream of underestimating you, Romus. Enjoy explaining this triumph to your noble houses!\"", -1);

            AddChoice(conv, 320, SmolakId, "Accept_Total_Fiasco",
                "\"Sign the humiliating surrender of southern Brenas to save Porte Drazon.\"",
                "To save the capital and our citizens from total devastation, I accept your terms. Withdraw from the approaches to Porte Drazon.", 321,
                "Variable[\"Zille_War_Outcome\"] = 1; Variable[\"Zille_Independent_Buffer\"] = false; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 1 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 321, SmolakId, RomusId, "Smolak_Signs_Fiasco",
                "Smolak laughed uproariously, slapping the table. \"History will remember today, King Romus! Your father gave me Zille; you just handed me Brenas! Good luck surviving your own generals tonight!\"", -1);

            AddLink(conv, 301, 310);
            AddLink(conv, 301, 320);
            AddLink(conv, 302, 320);

            AddConversationWithAlias(db, conv, "Zille/WarSmolakFinalParley", "Turn_Zille_WarSmolakFinalParley");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Smolak Final Parley (ID 9992) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 11: Turn_Zille_WarPeaceTreaty (ID 9993) - PEACE TREATY CEREMONY
        // Fixed: Outcome-gated choices so you can't sign Victory after a Defeat!
        // Fixed: Hugo / Lucita / Taddeus absent checks & valid RiziaDLC variables!
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
                "The Grand Throne Room of Palas Rezna had been arranged for the formal ratification of the Treaty of Zille. Foreign ambassadors, military commanders, and provincial nobles lined the marble hall beneath portraits of Rizian kings. The parchment instrument rested upon the central table beside the royal seal of House Toras.", -1);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Treaty_Declaration",
                "Your Majesty... The guns have fallen silent. The ink dries upon the instrument of peace, and the scribes await your royal seal to close this chapter in the annals of Rizia.", 3,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 102, LaurentoId, RomusId, "Laurento_Treaty_Declaration",
                "Your Majesty. The diplomatic instrument lies before you, witnessed by the envoys of the Alliance of Nations. The realm awaits your royal signature.", 3,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 1, 2);
            AddLink(conv, 1, 102);

            var outcomeHub = AddLine(conv, 3, NarratorId, RomusId, "Outcome_Hub_Prompt",
                "You stepped forward to the table to ratify the outcome of the campaign.");

            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive Victory
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Overwhelming Triumph
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Independent Zille Buffer
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Tactical Defeat
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 50)); // Total Fiasco

            AddChoice(conv, 10, HugoId, "Sign_Decisive_Victory",
                "\"Sign the Treaty of Restoration: Zille returns to the Crown of Rizia!\"",
                "In the presence of Saint Wruhec and the nobles of Rizia, I affix the royal seal. Zille is liberated and reunited with the Kingdom of Rizia!", -1,
                "Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 4 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 11, HugoId, RomusId, "Ack_Decisive_Ceremony",
                "The hall erupted into thunderous cheers, bells pealing from every sanctuary in Porte Drazon. Hugo wiped tears of joy from his eyes, bowing deeply before his King. \"Nearly thirty years of grief washed away in triumph! Long live King Romus the Restorer!\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 111, LaurentoId, RomusId, "Ack_Decisive_NoHugo",
                "Thunderous applause filled the Grand Throne Room as cathedral bells rang across Porte Drazon. Laurento bowed deeply. \"A historic restoration, Your Majesty. Zille is home.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 10, 11);
            AddLink(conv, 10, 111);

            AddChoice(conv, 20, HugoId, "Sign_Overwhelming_Triumph",
                "\"Sign the Treaty of Total Reparations: Wehlen humbled and Grodzizg placed under protection!\"",
                "By this treaty, Wehlen surrenders Zille unconditionally, pays immense war indemnities, demilitarizes its southern shore, and recognizes the Free City of Grodzizg. House Toras has achieved absolute triumph!", -1,
                "Variable[\"RiziaDLC.ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Zille_PromisedToHouseToras\"] = true; Variable[\"RiziaDLC.MapLayer_Zille_Brenas\"] = true; Variable[\"Grodzizg_FreeCity\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 5 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Overwhelming_Ceremony",
                "Lucita unsheathed her ceremonial saber and saluted with shining eyes. \"An epochal triumph, Your Majesty! We have not merely reclaimed our homeland—we have broken Wehlen's military power for a generation!\"", -1,
                "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            AddLine(conv, 121, CarlosId, RomusId, "Ack_Overwhelming_NoLucita",
                "General Carlos Azaro raised his saber in crisp salute. \"An epochal victory, Your Majesty. Rizia stands unchallenged across the Gulf of Moridia.\"", -1,
                "(Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true)");

            AddLink(conv, 20, 21);
            AddLink(conv, 20, 121);

            AddChoice(conv, 30, HugoId, "Sign_Independent_Buffer",
                "\"Sign the Treaty of Neutrality: The Independent Republic of Zille is established.\"",
                "To spare our people further carnage, I sign the charter establishing the Independent Neutral State of Zille. May this neutral territory forever stand as a peaceful bridge rather than a battlefield.", 31,
                "Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"RiziaDLC.ZilleReturn_Success\"] = false;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 3 or Variable[\"Zille_Independent_Buffer\"] == true or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 31, LaurentoId, RomusId, "Ack_Buffer_Ceremony",
                "Laurento bowed solemnly. \"The Alliance of Nations applauds your royal wisdom, Your Majesty. Though the province is not annexed, peace and guaranteed transit across the strait are secured.\"", -1);

            AddChoice(conv, 40, HugoId, "Sign_Tactical_Defeat",
                "\"Sign the Armed Armistice: Withdraw to the pre-war frontier under an uneasy truce.\"",
                "With a heavy heart, I sign this armistice. Our brave soldiers fought with unmatched valor, yet we must preserve the realm's strength. Zille remains outside our borders... for now.", -1,
                "Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"RiziaDLC.ZilleReferendum_Lost\"] = true;",
                "(Variable[\"Zille_Independent_Buffer\"] ~= true and ((Variable[\"Zille_War_Outcome\"] or 0) == 2 or (Variable[\"Zille_War_Outcome\"] or 0) == 0))");

            AddLine(conv, 41, HugoId, RomusId, "Ack_Tactical_Defeat",
                "A somber silence fell over the court. Hugo sighed deeply, his shoulders bowed with grief. \"A bitter day for House Toras, Romus. Yet the realm endures, and we must rebuild.\"", -1,
                "Variable[\"RiziaDLC.Hugo_Arrested\"] ~= true and Variable[\"RiziaDLC.Hugo_Executed\"] ~= true and Variable[\"RiziaDLC.Hugo_Resigned\"] ~= true");

            AddLine(conv, 141, LaurentoId, RomusId, "Ack_Tactical_Defeat_NoHugo",
                "A heavy hush fell over the chamber. Laurento lowered his eyes solemnly. \"A bitter hour, Your Majesty, yet the kingdom remains intact to fight another day.\"", -1,
                "(Variable[\"RiziaDLC.Hugo_Arrested\"] == true or Variable[\"RiziaDLC.Hugo_Executed\"] == true or Variable[\"RiziaDLC.Hugo_Resigned\"] == true)");

            AddLink(conv, 40, 41);
            AddLink(conv, 40, 141);

            AddChoice(conv, 50, HugoId, "Sign_Total_Fiasco",
                "\"Sign the Instrument of Surrender: Concede southern Brenas to save Porte Drazon.\"",
                "To prevent the destruction of Porte Drazon, I sign this humiliating peace. May God forgive me for the tragedy that has befallen our kingdom.", -1,
                "Variable[\"RiziaDLC.ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true; Variable[\"RiziaDLC.Azaro_HasPowerToCoup\"] = true;",
                "((Variable[\"Zille_War_Outcome\"] or 0) == 1 or (Variable[\"Zille_War_Outcome\"] or 0) == 0)");

            AddLine(conv, 51, NarratorId, RomusId, "Ack_Total_Fiasco",
                "Shouts of outrage and fury broke out among the assembled officers. Duke Taddeus stormed from the hall in disgust, while dark whispers of a military coup echoed through the stone corridors. The monarchy stood on the brink of collapse.", -1,
                "Variable[\"RiziaDLC.Taddeus_Arrested\"] ~= true and Variable[\"RiziaDLC.Taddeus_Executed\"] ~= true");

            AddLine(conv, 151, NarratorId, RomusId, "Ack_Total_Fiasco_NoTaddeus",
                "Shouts of outrage broke out among the assembled noble houses and generals. Officers slammed their sabers onto the marble floor, and dark whispers of mutiny echoed through the corridors of Palas Rezna.", -1,
                "(Variable[\"RiziaDLC.Taddeus_Arrested\"] == true or Variable[\"RiziaDLC.Taddeus_Executed\"] == true)");

            AddLink(conv, 50, 51);
            AddLink(conv, 50, 151);

            AddConversationWithAlias(db, conv, "Zille/WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Peace Treaty Ceremony (ID 9993) into masterDatabase!");
        }
    }
}
