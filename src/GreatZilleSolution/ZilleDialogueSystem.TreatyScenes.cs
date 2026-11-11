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
        // Modeled on: 354_War_Pales_PeaceTreaty, 330_War_Pales_Loss, 424_FPnT_ZilleNegotiations
        // Romus, Wiktor Smolak, Lucita Azaro, Titus Gordion.
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
                "The neutral pavilion stood on a muddy rise between the frontline trenches, draped in white flags that snapped in the wind. Outside, heavily armed Golden Guards in gilded armor stood eye-to-eye with Wehzek Republican Guards wielding submachine guns. Through the canvas flap, Wiktor Smolak sat slumped in a field chair, pouring bitter black tea into a tin cup, a half-smoked cigarette dangling from his lips.", 2);

            AddLine(conv, 2, SmolakId, RomusId, "Smolak_Parley_Greeting",
                "Look who finally decided to join me! The great King Romus of Rizia in the flesh. Tell me, King... Do you like the tea? It's Wehzek chicory blend. Tastes like gunpowder and mud, but it keeps a man alive when the shells are falling.", 3);

            var parleyHub = AddLine(conv, 3, RomusId, SmolakId, "Romus_Parley_Posture_Prompt",
                "I sat across the scarred folding table, looking into the bloodshot, cynical eyes of the dictator.");

            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive / Victorious posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Pragmatic / Stalemate posture
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Cold defiance

            AddChoice(conv, 10, SmolakId, "Posture_Victor",
                "\"Your army is shattered, Smolak. Sign the capitulation and evacuate Zille today.\"",
                "Your garrisons are surrounded and your supply lines severed, Smolak. We are not here to drink tea. Sign the capitulation agreement and order your remaining troops to vacate Zille today.", 100);

            AddChoice(conv, 20, SmolakId, "Posture_Stalemate",
                "\"Both our armies have bled enough. Let us discuss how this war ends.\"",
                "Both our nations have bled enough into this dirt, Smolak. If this slaughter continues, neither of us will have an economy left. Let us discuss terms for an end to hostilities.", 200);

            AddChoice(conv, 30, SmolakId, "Posture_Defiant",
                "\"You brought this war upon yourself when you thought you could extort House Toras.\"",
                "You brought this destruction upon Wehlen when you thought you could extort House Toras and steal Rizian soil. Every drop of blood spilled rests squarely on your head.", 100);

            // ================= BRANCH A: DECISIVE VICTORY / OVERWHELMING TRIUMPH =================
            AddLine(conv, 100, SmolakId, RomusId, "Smolak_Defeated_Rant",
                "Smolak ground his cigarette into the dirt beneath his boot, his hands trembling with suppressed fury. \"You think you've won, Romus? You think waving a piece of paper makes you a hero?! Fine! Valdez is a fool, and my generals couldn't fight their way out of a paper bag!\"", 101);

            AddLine(conv, 101, SmolakId, RomusId, "Smolak_Defeated_Terms",
                "\"Take Zille! Take your precious desert and your crumbling shrines! But Wehlen will not pay a single coin of reparations! Let my surviving boys march home across the river with their rifles, and I will sign your damned treaty.\"", 102);

            var victoryChoiceHub = AddLine(conv, 102, NarratorId, RomusId, "Victory_Terms_Prompt",
                "Smolak leaned across the table, cornered, desperate, yet stubbornly bargaining for survival.");

            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 110)); // Total Decisive Victory
            victoryChoiceHub.outgoingLinks.Add(CreateLink(conv.id, 102, 120)); // Overwhelming Triumph (Demand Reparations)

            AddChoice(conv, 110, SmolakId, "Accept_Decisive_Surrender",
                "\"Zille returns unconditionally to Rizia. Your surviving troops may withdraw across the river.\"",
                "Zille returns unconditionally to the Crown of Rizia, effective immediately. Your surviving garrisons may withdraw across the river under white flags. But if a single Wehzek soldier sets foot in Zille again, it will be treated as an act of war.", 111,
                "ZilleCampaignState.Outcome = ZilleWarOutcome.DecisiveVictory; Variable[\"Zille_War_Outcome\"] = 4; Variable[\"ZilleReturn_Success\"] = true;");

            AddLine(conv, 111, SmolakId, RomusId, "Smolak_Signs_Decisive",
                "Smolak snatched the pen, scribbling his signature with vicious, jagged strokes before throwing it onto the parchment. \"Done! Pack your bags, boys, we're leaving the King's playground! I hope you choke on the sand, Romus!\"", -1);

            AddChoice(conv, 120, SmolakId, "Demand_Overwhelming_Triumph",
                "\"Not enough. You will cede Zille, pay massive war indemnities, and demilitarize the border!\"",
                "Not enough, Smolak. Our tanks are already positioned to advance on Port Rotsla. You will cede Zille, pay four hundred million in gold and fuel reparations, and demilitarize your southern frontier. Sign, or our armor rolls into Wehlen proper!", 121,
                "ZilleCampaignState.Outcome = ZilleWarOutcome.OverwhelmingTriumph; Variable[\"Zille_War_Outcome\"] = 5; Variable[\"ZilleReturn_Success\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] + 4; Variable[\"RiziaDLC.Resources_Energy\"] = Variable[\"RiziaDLC.Resources_Energy\"] + 3;");

            AddLine(conv, 121, SmolakId, RomusId, "Smolak_Signs_Overwhelming",
                "Smolak turned ashen, his bravado evaporating into sheer panic as he looked at the maps. \"You're insane... You're a madman, Romus! But... damn you. I will sign. Just stop your tanks! Rotsla must remain Wehzek!\" He signed with shaking hands.", -1);

            // ================= BRANCH B: BLOODY STALEMATE & INDEPENDENT ZILLE BUFFER =================
            AddLine(conv, 200, SmolakId, RomusId, "Smolak_Stalemate_Opening",
                "Smolak took a deep drag of his cigarette, blowing gray smoke toward the canvas roof. \"Neither of us can push the other into the sea, Romus. Your tanks stalled outside Zille City, and my boys can't take Brenas. We can keep feeding young men into artillery fire until Kyrute puts us both in chains... or we can be clever.\"", 201);

            AddLine(conv, 201, SmolakId, RomusId, "Smolak_Buffer_Proposal",
                "\"Here is my proposal: An Independent Zille. Neither Rizia nor Wehlen. A demilitarized neutral buffer state, governed by a joint civilian council, with guaranteed oil transit rights for both our nations. The world will call us peacemakers, and neither of us looks like a loser. What do you say, King?\"", 202);

            var stalemateHub = AddLine(conv, 202, NarratorId, RomusId, "Stalemate_Hub_Prompt",
                "Lucita frowned with deep skepticism, while Smolak watched your eyes like a poker player staking his final hand.");

            stalemateHub.outgoingLinks.Add(CreateLink(conv.id, 202, 210)); // Accept Independent Zille Buffer
            stalemateHub.outgoingLinks.Add(CreateLink(conv.id, 202, 220)); // Reject Buffer & Enforce Ceasefire

            AddChoice(conv, 210, SmolakId, "Accept_Independent_Buffer",
                "\"Agreed. Zille shall become an Independent Neutral Buffer State under international guarantee.\"",
                "An Independent Neutral Zille. It brings peace, preserves our economy, and permanently separates our borders from Wehlen. I accept. Let the Alliance of Nations ratify the neutral charter.", 211,
                "ZilleCampaignState.Outcome = ZilleWarOutcome.BloodyStalemate; ZilleCampaignState.IsIndependentZilleAgreed = true; Variable[\"Zille_War_Outcome\"] = 3; Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"ZilleReturn_Success\"] = false;");

            AddLine(conv, 211, SmolakId, RomusId, "Smolak_Buffer_Signed",
                "Smolak smiled, a genuine glint of respect in his tired eyes as he clinked his tin cup against your glass. \"A statesman's compromise, Romus. Let the bureaucrats in Kyrute write the declarations. The war is over.\"", -1);

            AddChoice(conv, 220, SmolakId, "Reject_Buffer_Ceasefire",
                "\"Never. Zille is Rizian or nothing. We freeze the frontlines under an armed ceasefire.\"",
                "Zille has been Rizian for centuries; I will never recognize an artificial republic carved out of our historical soil. We freeze the lines under an armed ceasefire. But do not deceive yourself: this dispute is not over.", 221,
                "ZilleCampaignState.Outcome = ZilleWarOutcome.TacticalDefeat; Variable[\"Zille_War_Outcome\"] = 2; Variable[\"ZilleReturn_Success\"] = false;");

            AddLine(conv, 221, SmolakId, RomusId, "Smolak_Ceasefire_Signed",
                "Smolak snorted, flicking his cigarette butt into the mud. \"Suit yourself, King. An armed truce it is. Just make sure your border guards keep their fingers off their triggers.\"", -1);

            AddConversationWithAlias(db, conv, "Zille/WarSmolakFinalParley", "Turn_Zille_WarSmolakFinalParley");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Smolak Final Parley (ID 9992) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 11: Turn_Zille_WarPeaceTreaty (ID 9993) - PEACE TREATY CEREMONY
        // Modeled on: 354_War_Pales_PeaceTreaty, 333_War_Pales_VictoryParade
        // Romus, Hugo Toras, Lucita Azaro, Elena Werner, Laurento Esquibel.
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
                "The Grand Throne Room of Palas Rezna had been arranged for the formal ratification of the Treaty of Zille. Foreign ambassadors, military generals, and provincial nobles lined the marble hall beneath the golden portraits of ancient Rizian kings. The parchment treaty rested upon an altar flanked by the royal scepter and the seal of House Toras.", 2);

            AddLine(conv, 2, HugoId, RomusId, "Hugo_Treaty_Declaration",
                "Your Majesty... The bloodshed has ended. The ink is dry upon the instrument of peace. The scribes await your royal signature to seal the destiny of our realm in the annals of history.", 3);

            var outcomeHub = AddLine(conv, 3, NarratorId, RomusId, "Outcome_Hub_Prompt",
                "You stepped forward to the altar to ratify the outcome of the campaign.");

            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 10)); // Decisive Victory
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 20)); // Overwhelming Triumph
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 30)); // Independent Zille Buffer
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 40)); // Tactical Defeat
            outcomeHub.outgoingLinks.Add(CreateLink(conv.id, 3, 50)); // Total Fiasco

            AddChoice(conv, 10, HugoId, "Sign_Decisive_Victory",
                "\"Sign the Treaty of Total Restoration: Zille returns to the Crown of Rizia!\"",
                "In the presence of Saint Wruhec and the nobles of Rizia, I affix the royal seal. Zille is liberated and reunited with the Kingdom of Rizia for all eternity!", 11,
                "Variable[\"ZilleReturn_Success\"] = true; Variable[\"Zille_PromisedToHouseToras\"] = true; Variable[\"_Zille_OwnState\"] = 1;");

            AddLine(conv, 11, HugoId, RomusId, "Ack_Decisive_Ceremony",
                "The hall erupted into thunderous cheers, bells pealing from every cathedral in Porte Drazon. Hugo wiped tears of joy from his eyes, bowing deeply before his King. \"Thirty years of national shame washed away in blood and triumph! Long live King Romus the Restorer!\"", -1);

            AddChoice(conv, 20, HugoId, "Sign_Overwhelming_Triumph",
                "\"Sign the Treaty of Total Reparations: Wehlen humbled and massive indemnities secured!\"",
                "By this treaty, Wehlen surrenders Zille, pays immense war indemnities, and demilitarizes its borders. The House of Toras has achieved total and absolute victory!", 21,
                "Variable[\"ZilleReturn_Success\"] = true; Variable[\"Zille_PromisedToHouseToras\"] = true; Variable[\"_Zille_OwnState\"] = 1; Variable[\"Grodzizg_FreeCity\"] = true;");

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Overwhelming_Ceremony",
                "Lucita unsheathed her ceremonial sword and saluted with shining eyes. \"An epochal triumph, Your Majesty! We have not merely reclaimed our land-we have broken the military might of Wehlen for a generation to come!\"", -1);

            AddChoice(conv, 30, HugoId, "Sign_Independent_Buffer",
                "\"Sign the Treaty of Neutrality: The Independent Republic of Zille is established.\"",
                "To spare our people further carnage, I sign the charter establishing the Independent Neutral State of Zille. May this neutral territory forever stand as a barrier against war.", 31,
                "Variable[\"Zille_Independent_Buffer\"] = true; Variable[\"ZilleReturn_Success\"] = false;");

            AddLine(conv, 31, LaurentoId, RomusId, "Ack_Buffer_Ceremony",
                "Laurento bowed solemnly. \"The Alliance of Nations applauds your royal wisdom, Your Majesty. Though the province is not annexed, peace and lucrative trade corridors are guaranteed.\"", -1);

            AddChoice(conv, 40, HugoId, "Sign_Tactical_Defeat",
                "\"Sign the Armed Armistice: Freeze the frontlines under an armed truce.\"",
                "With a heavy heart, I sign this armistice. Our brave soldiers fought with unmatched valor, but we must withdraw to preserve our kingdom. Zille remains in enemy hands... for now.", 41,
                "Variable[\"ZilleReturn_Success\"] = false; Variable[\"ZilleReferendum_Lost\"] = true;");

            AddLine(conv, 41, HugoId, RomusId, "Ack_Tactical_Defeat",
                "A somber silence fell over the court. Hugo sighed deeply, his shoulders bowed with grief. \"A bitter day for House Toras, Romus. But the realm endures. We must rebuild our strength.\"", -1);

            AddChoice(conv, 50, HugoId, "Sign_Total_Fiasco",
                "\"Sign the Instrument of Surrender: Concede southern Brenas to save the capital.\"",
                "To prevent the destruction of Porte Drazon, I sign this humiliating surrender. May God forgive me for the tragedy that has befallen our kingdom.", 51,
                "Variable[\"ZilleReturn_Success\"] = false; Variable[\"Brenas_Lost_To_Wehlen\"] = true; Variable[\"Country_MilitaryCoupHappens\"] = true;");

            AddLine(conv, 51, NarratorId, RomusId, "Ack_Total_Fiasco",
                "Shouts of outrage and fury broke out among the assembled officers. Duke Taddeus stormed from the hall in disgust, while whispers of a military coup echoed through the darkened corridors. The monarchy stood on the brink of total collapse.", -1);

            AddConversationWithAlias(db, conv, "Zille/WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty");
            MelonLogger.Msg("[ZILLE DIALOGUE] Injected Peace Treaty Ceremony (ID 9993) into masterDatabase!");
        }
    }
}
