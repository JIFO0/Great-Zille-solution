using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    /// <summary>
    /// Master dialogue and narrative engine for the Great Zille Solution mod.
    /// Injects 6 complete, lore-authentic scenes and surgical dialogue options
    /// into vanilla Suzerain: Kingdom of Rizia conversations.
    /// Strictly adheres to character personalities, lore constraints, and realistic diplomacy.
    /// </summary>
    public static class ZilleDialogueSystem
    {
        // ================= CANONICAL ACTOR CONSTANTS =================
        public const int NarratorId = 10;
        public const int RomusId = 95;           // Player_Romus
        public const int RomusItalicId = 93;     // Player_Romus_Italic
        public const int HugoId = 68;            // Hugo Toras (Grand Vizier)
        public const int LucitaId = 73;          // Lucita Azaro (War Councilor)
        public const int ElenaId = 80;           // Elena Werner (Minister of Economy & Finance)
        public const int LaurentoId = 70;        // Laurento Esquibel (Foreign Affairs)
        public const int TitusId = 81;           // Titus Gordion (Golden Guard Commander)
        public const int ManusId = 75;           // Manus Sazon (House Sazon Heir / RPP Leader)
        public const int AngelicaId = 98;        // Angelica Sazon (Duchess of Brenas)
        public const int SmolakId = 77;          // Wiktor Smolak (President of Wehlen)
        public const int AlvarezId = 99;         // Patricio Alvarez (President of Lespia)
        public const int HegelId = 78;           // Emmerich Hegel (Chancellor of Valgsland)
        public const int BeatriceId = 92;        // Queen Beatrice Livingston (Rumburg)
        public const int EstelaId = 64;          // Queen Mother Estela Toras
        public const int VinaId = 79;            // Princess Vina Toras
        public const int AzmalId = 69;           // Grand Wiseman Jorga Azmal (Derdia)
        public const int TaddeusId = 83;         // Taddeus Azaro (Duke of Montaklar)

        // Custom Conversation IDs
        public const int ConvId_WarBriefing = 9988;
        public const int ConvId_WarBalconySpeech = 9989;
        public const int ConvId_WarLogisticsDispute = 9990;
        public const int ConvId_WarPreNegotiations = 9991;
        public const int ConvId_WarSmolakParley = 9992;
        public const int ConvId_WarPeaceTreaty = 9993;

        private static bool _conversationsRegistered = false;

        public static void EnsureAllConversationsRegistered()
        {
            if (_conversationsRegistered) return;

            try
            {
                var db = DialogueManager.masterDatabase;
                if (db == null) return;

                MelonLogger.Msg("[ZILLE DIALOGUE] Registering 6 custom Great Zille narrative scenes into masterDatabase...");

                RegisterWarCouncilBriefing(db);
                RegisterWarBalconySpeech(db);
                RegisterWarLogisticsDispute(db);
                RegisterWarPreNegotiationsBriefing(db);
                RegisterWarSmolakFinalParley(db);
                RegisterWarPeaceTreaty(db);

                _conversationsRegistered = true;
                MelonLogger.Msg("[ZILLE DIALOGUE] All 6 custom scenes successfully registered into masterDatabase!");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZILLE DIALOGUE] EnsureAllConversationsRegistered error: {ex.Message}\n{ex.StackTrace}");
            }
        }

        // ================= HELPER BUILDERS =================

        private static DialogueEntry CreateEntry(int convId, int entryId, int actorId, int conversantId, string title, string dialogueText, string menuText = "", string sequence = "")
        {
            var entry = new DialogueEntry();
            entry.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            entry.outgoingLinks = new Il2CppSystem.Collections.Generic.List<Link>();
            entry.id = entryId;
            entry.conversationID = convId;
            entry.ActorID = actorId;
            entry.ConversantID = conversantId;
            entry.Title = title ?? "";
            entry.DialogueText = dialogueText ?? "";
            entry.MenuText = string.IsNullOrEmpty(menuText) ? (dialogueText ?? "") : menuText;
            entry.Sequence = sequence ?? "";
            entry.conditionPriority = ConditionPriority.Normal;
            entry.isGroup = false;
            entry.userScript = "";
            entry.conditionsString = "";

            entry.fields.Add(new Field("Title", title ?? "", FieldType.Text));
            entry.fields.Add(new Field("Actor", actorId.ToString(), FieldType.Actor));
            entry.fields.Add(new Field("Conversant", conversantId.ToString(), FieldType.Actor));
            entry.fields.Add(new Field("Dialogue Text", dialogueText ?? "", FieldType.Text));
            entry.fields.Add(new Field("en", dialogueText ?? "", FieldType.Localization));
            entry.fields.Add(new Field("Menu Text", string.IsNullOrEmpty(menuText) ? (dialogueText ?? "") : menuText, FieldType.Text));
            entry.fields.Add(new Field("Sequence", sequence ?? "", FieldType.Text));
            entry.fields.Add(new Field("Articy Id", $"0x0100005A_Zille_{convId}_{entryId}", FieldType.Text));

            return entry;
        }

        private static Link CreateLink(int convId, int originId, int destId)
        {
            var link = new Link(convId, originId, convId, destId);
            link.priority = ConditionPriority.Normal;
            link.isConnector = false;
            return link;
        }

        private static DialogueEntry AddLine(Conversation conv, int id, int speaker, int listener, string title, string text, int nextId = -1)
        {
            var e = CreateEntry(conv.id, id, speaker, listener, title, text);
            if (nextId >= 0) e.outgoingLinks.Add(CreateLink(conv.id, id, nextId));
            conv.dialogueEntries.Add(e);
            return e;
        }

        private static DialogueEntry AddChoice(Conversation conv, int id, int listener, string title, string menuText, string spokenText, int nextId, string script = "", string condition = "")
        {
            var e = CreateEntry(conv.id, id, RomusId, listener, title, spokenText, menuText);
            if (!string.IsNullOrEmpty(script))
            {
                e.userScript = script;
                e.fields.Add(new Field("Script", script, FieldType.Script));
            }
            if (!string.IsNullOrEmpty(condition))
            {
                e.conditionsString = condition;
                e.fields.Add(new Field("Conditions", condition, FieldType.Text));
            }
            if (nextId >= 0) e.outgoingLinks.Add(CreateLink(conv.id, id, nextId));
            conv.dialogueEntries.Add(e);
            return e;
        }

        // =========================================================================
        // SCENE 1: Turn_Zille_WarBriefing (ID 9988) - THE ROYAL WAR COUNCIL BRIEFING
        // Completely rewritten: Hugo focuses on monarchy/dynasty, Lucita on military/doctrines,
        // Elena on treasury/energy, Laurento on superpowers/AN, Titus on intelligence/estates.
        // No infinite loops! Linear opening -> inquiry hub -> doctrine choice.
        // =========================================================================
        public static void RegisterWarCouncilBriefing(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarBriefing") != null || db.GetConversation("Zille/WarCouncil_Briefing") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarBriefing;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Turn_Zille_WarBriefing";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            bool lucitaMarried = DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Married") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Marriage_Happened") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLCSupport.Journal_Turn08_Lucita_Married");
            bool lucitaRomance = lucitaMarried ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Relations_Lucita_Together") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_RomanceHappened") ||
                                 DialogueHelper.GetIntVariable("RiziaDLC.Relations_Lucita_Romance") > 0;

            int budget = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Budget");
            if (budget == 0) budget = DialogueHelper.GetIntVariable("Budget");
            int energy = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Energy");
            bool suOminaActive = DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Decision_Turn05_ZilleResistanceFunding_BeginSOFund");
            bool ataActive = DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement") ||
                             DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement");

            // Entry 0: START
            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            // 1. Atmosphere & Setting
            AddLine(conv, 1, NarratorId, RomusId, "Briefing_Atmosphere",
                "Outside the high arched windows of Palas Rezna, rain beat steadily against the glass. Inside the war room, the massive oak doors had been bolted shut by the Golden Guard. Across the polished mahogany table lay a hand-carved topographical relief map of the Zille peninsula, flanked by brass markers and crimson operational lines.", 2);

            // 2. Hugo Toras (Grand Vizier & Patriarch)
            AddLine(conv, 2, HugoId, RomusId, "Hugo_Opening_1",
                "Your Majesty. Or perhaps... Romus, if I may speak plainly as your uncle for a fleeting moment.", 3);
            AddLine(conv, 3, HugoId, RomusId, "Hugo_Opening_2",
                "Thirty years ago, your father signed away Zille with a trembling hand to quell a rebellion that threatened our dynasty. It was a national humiliation that has haunted House Toras ever since. But crossing that river with royal divisions is not a parade. If our offensive stumbles, if Smolak's armored cars reach Brenas, the divine prestige of the Crown—and the stability of the entire kingdom—will be shaken to its foundation.", 4);

            // 3. Lucita Azaro (War Councilor)
            if (lucitaMarried)
            {
                AddLine(conv, 4, NarratorId, RomusId, "Lucita_Narration_Married",
                    "Lucita stood at the head of the tactical relief, her field marshal's baton resting against the southern border. Meeting your gaze, her stoic military demeanor softened with a private warmth before she addressed the chamber.", 5);
                AddLine(conv, 5, LucitaId, RomusId, "Lucita_Opening_Married",
                    "My love... Your Majesty. The General Staff has finalized our operational dispositions. The Azaro levies and Royal Army divisions are stationed along the Brenas perimeter. Our commanders await only your sovereign authorization.", 6);
            }
            else if (lucitaRomance)
            {
                AddLine(conv, 4, NarratorId, RomusId, "Lucita_Narration_Romance",
                    "Lucita glanced up from the western approach, her sharp brown eyes meeting yours with an unmistakable current of personal affection before snapping back to strict professional discipline.", 5);
                AddLine(conv, 5, LucitaId, RomusId, "Lucita_Opening_Romance",
                    "Your Majesty. Everything we discussed in private has been positioned. The southern staging grounds are prepared, and our forward armor is fueled. We stand ready to reclaim our birthright.", 6);
            }
            else
            {
                AddLine(conv, 4, NarratorId, RomusId, "Lucita_Narration_Default",
                    "War Councilor Lucita Azaro stood rigid beside the border pins, her uniform immaculate and her posture radiating the unyielding martial pride of House Azaro.", 5);
                AddLine(conv, 5, LucitaId, RomusId, "Lucita_Opening_Default",
                    "Your Majesty. The Ministry of War has concluded our operational audit. Our forward strike brigades are concentrated along the Brenas frontier. The army is poised, awaiting your command.", 6);
            }

            // 4. Lucita - Geographic and Force Audit
            AddLine(conv, 6, LucitaId, RomusId, "Lucita_Forces",
                "Across the demarcation line, Colonel Valdez commands four entrenched Wehzek regular brigades, bolstered by irregular Republican Guard detachments. His forces are concentrated around the fortified redoubts of Zille City and the central transit hub at Wiktrany. If we strike decisively, we can encircle them before reinforcements arrive from mainland Wehlen.", 7);

            // 5. Elena Werner (Minister of Economy & Finance - AUTHENTIC VOICE!)
            AddLine(conv, 7, ElenaId, RomusId, "Elena_Opening",
                "For Dast's sake, soldiers may fight the war, but the royal exchequer and our state energy reserves will have to carry the burden.", 8);

            string elenaAuditText;
            if (budget >= 6 && energy >= 5)
            {
                elenaAuditText = "Fortunately, Your Majesty, the Crown Treasury currently rests on solid ground, and our strategic fuel reserves at Rizian Oil and Gas are well-cushioned. We can sustain the logistical friction of a swift campaign. But let me be unequivocally clear: war is an insatiable furnace. If our armored divisions get bogged down in the Brenas mud, the costs will quickly ripple into domestic trade and inflation.";
            }
            else if (budget >= 2 && energy >= 2)
            {
                elenaAuditText = "Candor compels me to urge financial caution, Sire. Our royal treasury is balanced, but barely so. Fuel stockpiles for our transport trucks and mechanized battalions will require strict rationing from the domestic sector. A protracted winter campaign will force painful trade-offs in municipal spending.";
            }
            else
            {
                elenaAuditText = "I must sound the alarm, Your Majesty. The Crown Treasury is practically bare, and our national energy reserves are critically thin. Funding this military offensive will require emergency war bonds and heavy state debt. We cannot afford a prolonged war of attrition without severe economic turmoil.";
            }
            AddLine(conv, 8, ElenaId, RomusId, "Elena_Audit", elenaAuditText, 9);

            // 6. Laurento Esquibel (Minister of Foreign Affairs)
            AddLine(conv, 9, LaurentoId, RomusId, "Laurento_Opening",
                "And there is the international chessboard to consider, Your Majesty. Smolak is an eccentric tyrant, but he operates beneath the delicate equilibrium of South Merkopa.", 10);
            AddLine(conv, 10, LaurentoId, RomusId, "Laurento_Geopolitics",
                "United Contana and Chancellor Hegel will certainly howl with outrage at the Alliance of Nations in Kyrute, denouncing us as royalist aggressors. Yet Contana will not send soldiers to die for Wiktor Smolak unless our forces cross into mainland Wehlen. Meanwhile, President Alvarez in Lespia despises Smolak to his core; he will not commit Lespian troops directly, but with proper diplomatic framing, Lespia and ATO will quietly shield us from crippling international sanctions.", 11);

            // 7. Titus Gordion (Golden Guard Commander)
            AddLine(conv, 11, TitusId, RomusId, "Titus_Security",
                "On the domestic front, Your Majesty, the Golden Guard has placed our agents inside Zille on maximum alert. Furthermore, I have deployed an elite guard detachment with standing orders to secure Queen Mother Estela's childhood estate the moment our vanguards enter the city.", 12);

            string titusResistanceLine;
            if (suOminaActive && ataActive)
            {
                titusResistanceLine = "Our covert groundwork has borne fruit. Su Omina militants are primed to sever Wehzek telegraph lines, while the Zille Association has prepared municipal dock strikes. Valdez will find his rear in flames from the first hour.";
            }
            else if (suOminaActive)
            {
                titusResistanceLine = "The Su Omina cells in Zille are well-armed and thirsting for revenge. The moment our artillery opens fire, they will strike Wehzek supply depots from behind the lines.";
            }
            else if (ataActive)
            {
                titusResistanceLine = "While our armed presence is limited, the Zille Association has rallied strong civic sympathy for the Crown. Striking railwaymen and municipal workers will severely slow Valdez's redeployments.";
            }
            else
            {
                titusResistanceLine = "Regrettably, our covert underground inside Zille is thin. Smolak's secret police have kept the populace terrified, meaning our frontline soldiers will have to carry the entire operational weight alone.";
            }
            AddLine(conv, 12, TitusId, RomusId, "Titus_Underground", titusResistanceLine, 13);

            // 8. Opening Attitude Hub (Entry 13)
            var attitudeHub = AddLine(conv, 13, HugoId, RomusId, "Briefing_Attitude_Prompt",
                "The ministers have laid out the reality, Your Majesty. Before we examine the specific doctrines of attack, how does the Crown intend to approach this fateful hour?");

            attitudeHub.outgoingLinks.Add(CreateLink(conv.id, 13, 20)); // Martial / Decisive
            attitudeHub.outgoingLinks.Add(CreateLink(conv.id, 13, 22)); // Cautious / Fiscal
            attitudeHub.outgoingLinks.Add(CreateLink(conv.id, 13, 24)); // Diplomatic / Statesmanlike
            if (lucitaRomance) attitudeHub.outgoingLinks.Add(CreateLink(conv.id, 13, 26)); // Personal to Lucita

            // Option 20: Martial Resolve
            AddChoice(conv, 20, HugoId, "Attitude_Martial",
                "\"Smolak has mocked our patience for too long. Zille is Rizian blood and soil, and we will reclaim it by the sword.\"",
                "Smolak has mocked our patience for too long. Zille is Rizian blood and soil, and we will reclaim it by the sword.", 21);
            AddLine(conv, 21, LucitaId, RomusId, "Attitude_Martial_Reply",
                lucitaRomance
                    ? "A fierce, radiant pride lit up Lucita's face. \"Spoken like a true king of Rizia, my love. Our soldiers will march with fire in their hearts knowing their sovereign does not flinch.\""
                    : "\"Spoken like a true king,\" Lucita replied, her eyes flashing with resolve. \"Our frontline divisions will fight with twice the valor knowing their sovereign stands resolute.\"", 30);

            // Option 22: Cautious Prudence
            AddChoice(conv, 22, HugoId, "Attitude_Cautious",
                "\"I do not take this step lightly. Every Rizian life and every gold guilder spent must serve a clear purpose.\"",
                "I do not take this step lightly. Every Rizian life and every gold guilder spent must serve a clear purpose.", 23);
            AddLine(conv, 23, HugoId, RomusId, "Attitude_Cautious_Reply",
                "\"A wise and kingly posture, nephew,\" Hugo nodded solemnly. \"A monarch who counts the cost of the blade rarely loses his crown to recklessness.\"", 30);

            // Option 24: Diplomatic Containment
            AddChoice(conv, 24, LaurentoId, "Attitude_Diplomatic",
                "\"Our objective is clear: reclaim Zille quickly while keeping the superpowers from intervening.\"",
                "Our objective is clear: reclaim Zille quickly while keeping the superpowers from intervening.", 25);
            AddLine(conv, 25, LaurentoId, RomusId, "Attitude_Diplomatic_Reply",
                "\"Precisely, Sire,\" Laurento inclined his head respectfully. \"A swift, localized victory presented as a fait accompli will leave even Malenyev and Hegel with no legal basis for escalation.\"", 30);

            // Option 26: Personal to Lucita
            if (lucitaRomance)
            {
                AddChoice(conv, 26, LucitaId, "Attitude_Lucita_Personal",
                    "\"I place my complete trust in you, Lucita. Together, we will bring our province home.\"",
                    "I place my complete trust in you, Lucita. Together, we will bring our province home.", 27);
                AddLine(conv, 27, LucitaId, RomusId, "Attitude_Lucita_Personal_Reply",
                    lucitaMarried
                        ? "\"I will not fail you, Romus—neither as your general nor as your queen,\" she answered softly, her fingers gently grazing yours over the edge of the map. Hugo cleared his throat discreetly, adjusting his collar."
                        : "\"You have my sword, my mind, and my heart, Your Majesty,\" she murmured with a subtle warmth that made Laurento politely study his briefing papers.", 30);
            }

            // ================= INQUIRY COUNCIL HUB (Entry 30) =================
            // Designed to avoid infinite cycles: questions branch to thorough character responses,
            // then provide a direct return or immediate progression to doctrines.
            var hub30 = AddLine(conv, 30, LucitaId, RomusId, "Council_Inquiry_Hub",
                "The relief map is at your disposal, Your Majesty. Do you wish to examine any specific operational facet, or are you prepared to select our doctrine of assault?");

            hub30.outgoingLinks.Add(CreateLink(conv.id, 30, 40)); // Ask Lucita (Terrain & Valdez)
            hub30.outgoingLinks.Add(CreateLink(conv.id, 30, 50)); // Ask Elena (Treasury & Supply Strain)
            hub30.outgoingLinks.Add(CreateLink(conv.id, 30, 60)); // Ask Laurento (Superpowers & Sanctions)
            hub30.outgoingLinks.Add(CreateLink(conv.id, 30, 70)); // Ask Titus (Security & Queen Mother's Estate)
            hub30.outgoingLinks.Add(CreateLink(conv.id, 30, 80)); // Direct to Doctrines!

            // Branch 40: Lucita on Military Dispositions
            AddChoice(conv, 40, LucitaId, "Inquire_Military",
                "\"Lucita, detail the terrain and Valdez's defensive layout across the peninsula.\"",
                "Lucita, detail the terrain and Valdez's defensive layout across the peninsula.", 41);
            AddLine(conv, 41, LucitaId, RomusId, "Inquire_Military_Answer_1",
                "Zille is framed by the Brenas marshes to the south, the central road junction of Wiktrany, the eastern gate at Nanta, and the northern deepwater port of Munat. Zille City itself sits in the west, shielded by concrete bunkers and coastal artillery.", 42);
            AddLine(conv, 42, LucitaId, RomusId, "Inquire_Military_Answer_2",
                "Valdez has dug his infantry into deep trenches along the Wiktrany highway, assuming we will charge head-on. But if we outflank his center or sever his sea supply line through Munat, his garrison will run out of ammunition within days.", 30);

            // Branch 50: Elena on Fiscal & Energy Impact
            AddChoice(conv, 50, ElenaId, "Inquire_Economy",
                "\"Elena, give me a realistic assessment of our supply consumption and financial risks.\"",
                "Elena, give me a realistic assessment of our supply consumption and financial risks.", 51);
            AddLine(conv, 51, ElenaId, RomusId, "Inquire_Economy_Answer_1",
                "The logistical cost of moving mechanized columns across Brenas is steep. Requisitioning freight trains, procuring artillery shells, and replacing damaged trucks will drain our treasury every single week of active operations.", 52);
            AddLine(conv, 52, ElenaId, RomusId, "Inquire_Economy_Answer_2",
                "If we capture Zille intact, its lucrative gold extraction and customs tariffs will more than repay our expenses over time. But if the fighting drags on, civilian industries in Porte Drazon will face fuel shortages. We must achieve victory quickly.", 30);

            // Branch 60: Laurento on Geopolitics & Alliances
            AddChoice(conv, 60, LaurentoId, "Inquire_Diplomacy",
                "\"Laurento, how do we guarantee that foreign powers do not turn this into a wider war?\"",
                "Laurento, how do we guarantee that foreign powers do not turn this into a wider war?", 61);
            AddLine(conv, 61, LaurentoId, RomusId, "Inquire_Diplomacy_Answer_1",
                "We must adhere strictly to sovereign legalism, Sire. Our diplomatic communiqué emphasizes that the 1929 lease has expired and that Rizia is solely restoring constitutional order within its historical border.", 62);
            AddLine(conv, 62, LaurentoId, RomusId, "Inquire_Diplomacy_Answer_2",
                "Contana will bluster, but their central leadership in Kyrute has no treaty mandate requiring them to declare war over Zille. And Lespia, wanting Smolak weakened, will ensure ATO does not intervene against us.", 30);

            // Branch 70: Titus on Queen Mother's Estate & Undercover Assets
            AddChoice(conv, 70, TitusId, "Inquire_Security",
                "\"Titus, what of internal safety in Brenas and my mother's ancestral estate in Zille?\"",
                "Titus, what of internal safety in Brenas and my mother's ancestral estate in Zille?", 71);
            AddLine(conv, 71, TitusId, RomusId, "Inquire_Security_Answer_1",
                "The Golden Guard has placed our premier royal protection detachment on standby. The instant our spearheads secure the municipal perimeter, they will establish an iron cordon around Queen Mother Estela's estate to ensure no looting or vandalism occurs.", 72);
            AddLine(conv, 72, HugoId, RomusId, "Inquire_Security_Hugo",
                "A vital precaution, Romus. Your mother's lineage is deeply tied to that soil; seeing her family home desecrated by retreating Wehzeks would be a bitter pill for the realm to swallow.", 30);

            // ================= DOCTRINE SELECTION HUB (Entry 80) =================
            AddChoice(conv, 80, LucitaId, "Proceed_To_Doctrines",
                "\"I have heard enough. Present the operational battle plans for Operation Righteous Sword.\"",
                "I have heard enough. Present the operational battle plans for Operation Righteous Sword.", 81);

            AddLine(conv, 81, LucitaId, RomusId, "Doctrine_Presentation_1",
                "At once, Your Majesty. The General Staff has prepared two primary operational doctrines for Phase I.", 82);
            AddLine(conv, 82, LucitaId, RomusId, "Doctrine_Presentation_2",
                "Plan Alpha is a concentrated armored breakthrough: smashing directly through the Wiktrany junction from the Brenas staging grounds, shattering Valdez's defensive center, and driving west straight onto Zille City.", 83);
            var doctrineHub = AddLine(conv, 83, LucitaId, RomusId, "Doctrine_Presentation_3",
                "Plan Beta is an operational envelopment: fixing Valdez's forces in place while our mobile columns swing through the eastern pass at Nanta, advancing rapidly north to seize the deepwater port of Munat to sever Wehlen's maritime lifeline. Which doctrine do you authorize, Sire?");

            doctrineHub.outgoingLinks.Add(CreateLink(conv.id, 83, 90)); // Plan Alpha
            doctrineHub.outgoingLinks.Add(CreateLink(conv.id, 83, 93)); // Plan Beta
            doctrineHub.outgoingLinks.Add(CreateLink(conv.id, 83, 96)); // Postpone

            // Option 90: Authorize Plan Alpha
            AddChoice(conv, 90, LucitaId, "Choice_Plan_Alpha",
                "Authorize Plan Alpha: Launch a decisive armored spearhead through Wiktrany toward Zille City.",
                "I authorize Plan Alpha. Concentrate our tanks and smash straight through their central defenses at Wiktrany.", 91,
                "Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Doctrine\"] = \"Alfa\";");

            AddLine(conv, 91, LucitaId, RomusId, "Ack_Alpha_Lucita",
                lucitaMarried
                    ? "\"It shall be done, my King,\" Lucita said with steely determination, saluting crisply. \"The order of battle is signed. I will meet you at the war table whenever you are ready to command our divisions in Phase I.\""
                    : "\"Understood, Your Majesty!\" Lucita saluted with precision. \"Orders are being dispatched to the Brenas command post. The invasion token is active at Zille—awaiting your arrival at the war table to deploy our regiments.\"", 92);
            AddLine(conv, 92, HugoId, RomusId, "Ack_Alpha_Hugo",
                "May Saint Wruhec protect our soldiers and grant victory to the Crown. Glovurius axa Rizia!");

            // Option 93: Authorize Plan Beta
            AddChoice(conv, 93, LucitaId, "Choice_Plan_Beta",
                "Authorize Plan Beta: Execute an operational envelopment through Nanta and the port of Munat.",
                "I authorize Plan Beta. Outflank their fortified line through Nanta and cut off their supplies at Munat.", 94,
                "Variable[\"Zille_War_Beta\"] = true; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Doctrine\"] = \"Beta\";");

            AddLine(conv, 94, LucitaId, RomusId, "Ack_Beta_Lucita",
                lucitaMarried
                    ? "\"A brilliant tactical maneuver, my love,\" Lucita smiled with fierce pride. \"We will strangle Valdez's garrison before he realizes his retreat is cut off. Our staff is ready at the war table whenever you wish to begin Phase I deployment.\""
                    : "\"A classic pincer maneuver, Your Majesty,\" Lucita nodded briskly. \"The eastern columns are already mobilizing. You may initiate Phase I from the Zille operation marker at your discretion.\"", 95);
            AddLine(conv, 95, LaurentoId, RomusId, "Ack_Beta_Laurento",
                "Seizing the deepwater port of Munat early also prevents any foreign vessels from meddling under the guise of relief. Godspeed to our forces, Sire.");

            // Option 96: Postpone
            AddChoice(conv, 96, HugoId, "Choice_Plan_Postpone",
                "Hold the offensive for now. Keep our divisions on alert along the border, but do not cross.",
                "Hold the offensive for now. Keep our divisions on alert along the border, but do not cross until I give the command.", 97,
                "Variable[\"Zille_War_Postpone\"] = true;");

            AddLine(conv, 97, HugoId, RomusId, "Ack_Postpone_Hugo",
                "A prudent and measured decision, Your Majesty. The General Staff will maintain full readiness along the frontier until you decide the hour is right.");

            db.AddConversation(conv);
            MelonLogger.Msg("[ZILLE DIALOGUE] Re-injected clean, lore-accurate War Council Briefing (ID 9988) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 2: Turn_Zille_WarBalconySpeech (ID 9989) - WAR BALCONY PROCLAMATION
        // Romus addresses tens of thousands of citizens gathered at Palas Rezna.
        // Broadcast live across radio transmitters in all provinces.
        // =========================================================================
        public static void RegisterWarBalconySpeech(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarBalconySpeech") != null || db.GetConversation("Zille/WarBalconySpeech") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarBalconySpeech;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Turn_Zille_WarBalconySpeech";
            conv.ActorID = RomusId;
            conv.ConversantID = HugoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, HugoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Balcony_Atmosphere_1",
                "The double doors opened onto the grand marble balcony of Palas Rezna. Below, the Royal Square of Porte Drazon was filled to overflowing with thousands of citizens. Silk banners of House Toras, Azaro, and Sazon fluttered in the southern breeze alongside the royal crest of Rizia.", 2);
            AddLine(conv, 2, NarratorId, RomusId, "Balcony_Atmosphere_2",
                "Brass microphones stood arranged at the parapet, transmitting your voice live to state radio towers across the realm, from the vineyards of Valenqiris to the workshops of Brenas. Grand Vizier Hugo Toras and War Councilor Lucita Azaro stood one step behind you.", 3);
            AddLine(conv, 3, HugoId, RomusId, "Balcony_Hugo_Whisper",
                "The realm is listening, Your Majesty. Speak with the conviction of our ancestors.", 4);

            var speechHub = AddLine(conv, 4, NarratorId, RomusId, "Balcony_Speech_Prompt",
                "A profound silence descended over the great plaza. You stepped up to the microphones.");

            speechHub.outgoingLinks.Add(CreateLink(conv.id, 4, 10)); // Revanchist / Martial
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 4, 20)); // Protective / Liberating
            speechHub.outgoingLinks.Add(CreateLink(conv.id, 4, 30)); // Legalist / Statesmanlike

            // Choice 10: Revanchist
            AddChoice(conv, 10, HugoId, "Speech_Revanchist",
                "\"Citizens of Rizia! For thirty years, Zille has endured foreign tyranny. Today, that humiliation ends! By royal decree, our army marches to reclaim our ancestral soil!\"",
                "Citizens of Rizia! For thirty long years, our sacred soil in Zille has languished under foreign occupation. We gave diplomacy every opportunity, yet our goodwill was answered only with deceit and terror. Today, that humiliation ends! By royal decree, the armed forces of the Kingdom have crossed the frontier to restore our ancestral homeland! Glovurius axa Rizia!", 11,
                "Variable[\"RiziaDLC.Resources_Authority\"] = Variable[\"RiziaDLC.Resources_Authority\"] + 2; Variable[\"RiziaDLC.Country_PublicOpinion\"] = Variable[\"RiziaDLC.Country_PublicOpinion\"] + 1;");

            AddLine(conv, 11, NarratorId, RomusId, "Speech_Revanchist_Reaction",
                "A thunderous roar erupted from the square. Thousands of voices echoed your cry, throwing hats into the air as the royal guards stood at rigid salute. Beside you, Lucita's eyes flashed with fierce Azaro pride.", 40);

            // Choice 20: Protective / Liberating
            AddChoice(conv, 20, HugoId, "Speech_Liberating",
                "\"Sons and daughters of Rizia! We take up the sword not for vanity or conquest, but to deliver our brothers and sisters in Zille from oppression!\"",
                "Sons and daughters of Rizia! We take up arms not for conquest or imperial pride, but to deliver our brothers and sisters in Zille from lawless oppression. The Crown will never abandon its people, no matter how high the wall or how bitter the struggle. Stand steadfast with our soldiers as they bring peace and justice to our southern border!", 21,
                "Variable[\"RiziaDLC.Resources_Authority\"] = Variable[\"RiziaDLC.Resources_Authority\"] + 2; Variable[\"RiziaDLC.Country_PublicOpinion\"] = Variable[\"RiziaDLC.Country_PublicOpinion\"] + 1;");

            AddLine(conv, 21, NarratorId, RomusId, "Speech_Liberating_Reaction",
                "Solemn, deeply emotional cheers swept through the crowd. In the front rows, veteran soldiers bowed their heads with quiet reverence while young citizens waved royal pennants in solidarity.", 40);

            // Choice 30: Legalist
            AddChoice(conv, 30, HugoId, "Speech_Legalist",
                "\"People of Rizia. Thirty years ago, a treaty was signed in good faith. That lease has expired. We are merely executing the lawful rights of our sovereign realm.\"",
                "People of Rizia. Three decades ago, a treaty was signed in solemn faith. That lease has reached its lawful conclusion. When a foreign ruler refuses to honor his signature and threatens our peace, a kingdom must defend its sovereignty. We march not in malice, but to uphold the law of nations and restore our lawful territory.", 31,
                "Variable[\"RiziaDLC.Resources_Authority\"] = Variable[\"RiziaDLC.Resources_Authority\"] + 2; Variable[\"RiziaDLC.Country_PublicOpinion\"] = Variable[\"RiziaDLC.Country_PublicOpinion\"] + 1;");

            AddLine(conv, 31, NarratorId, RomusId, "Speech_Legalist_Reaction",
                "A wave of measured, respectful applause rippled across the square. The aristocrats and delegates in attendance nodded in firm agreement; the Crown was acting with unassailable dignity.", 40);

            AddLine(conv, 40, HugoId, RomusId, "Balcony_Conclusion",
                "As the cheers continued to echo across the palace grounds, Hugo stepped beside you, bowing his head respectfully. \"The nation is behind you, Your Majesty. Now our divisions in Brenas must deliver the promise.\"", -1);

            db.AddConversation(conv);
            MelonLogger.Msg("[ZILLE DIALOGUE] Re-injected War Balcony Speech (ID 9989) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 3: Turn_Zille_WarLogisticsDispute (ID 9990) - LOGISTICS DISPUTE
        // Clash between House Azaro and House Sazon over war supply lines in Brenas.
        // Lucita Azaro, Manus Sazon, Duchess Angelica Sazon, Elena Werner.
        // =========================================================================
        public static void RegisterWarLogisticsDispute(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarLogisticsDispute") != null || db.GetConversation("Zille/WarLogisticsDispute") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarLogisticsDispute;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Turn_Zille_WarLogisticsDispute";
            conv.ActorID = RomusId;
            conv.ConversantID = LucitaId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LucitaId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Logistics_Intro_1",
                "The atmosphere inside the Ministry of War conference chamber was electric with tension. On the table lay logistical manifests of fuel consumption, rail capacity, and requisition orders from the southern provinces.", 2);
            AddLine(conv, 2, LucitaId, RomusId, "Lucita_Complaint_1",
                "Your Majesty, we have an intolerable bottleneck along the Brenas corridor. Our heavy transport columns and fuel convoys are being delayed at civilian checkpoints and rail junctions.", 3);
            AddLine(conv, 3, LucitaId, RomusId, "Lucita_Complaint_2",
                "The General Staff demands total military requisition authority over the southern rail network, fuel storage depots, and grain silos in Brenas. If my armored spearheads stall outside Wiktrany because local merchants are hoarding boxcars, the responsibility will rest on this council!", 4);

            AddLine(conv, 4, AngelicaId, RomusId, "Angelica_Interjection",
                "Brenas is not an occupied territory, Councilor Azaro! It is the ancestral breadbasket of Rizia and the home of House Sazon!", 5);
            AddLine(conv, 5, AngelicaId, RomusId, "Angelica_Argument",
                "Your officers are already confiscating livestock, impounding delivery trucks, and leaving our towns on the brink of winter scarcity. If you bleed Brenas dry to feed your armored battalions, you will provoke strikes and unrest across the entire province before your troops ever reach Zille!", 6);

            AddLine(conv, 6, ManusId, RomusId, "Manus_Proposal",
                "Mother is right, Your Majesty. But there is a sensible alternative. House Sazon's agricultural syndicates and merchant guilds have managed these trade roads for generations. If the Crown grants us supervisory authority over the rear, we will guarantee steady deliveries of grain, flour, and fuel without resorting to martial confiscation.", 7);

            AddLine(conv, 7, ElenaId, RomusId, "Elena_Assessment",
                "For Dast's sake, both houses need to look at the ledgers rather than their heraldic pride. Councilor Azaro's military requisition method guarantees that artillery batteries receive shells without bureaucratic delay, but officer corruption and haphazard procurement will drain our treasury severely (-2 Budget).", 8);
            AddLine(conv, 8, ElenaId, RomusId, "Elena_Assessment_2",
                "The Sazon syndicate model, on the other hand, utilizes local river barges and granaries efficiently—reducing our per-turn fuel and budget drain while stiffening the defense of Brenas cities. However, Councilor Azaro's forward offensive tempo may lose its blitzkrieg edge.", 9);

            var disputeHub = AddLine(conv, 9, NarratorId, RomusId, "Logistics_Decision_Prompt",
                "All eyes at the table turned toward you. The logistical command of the southern campaign hung on your decision.");

            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 9, 20)); // Azaro Military Requisition
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 9, 30)); // Sazon Guild Logistics
            disputeHub.outgoingLinks.Add(CreateLink(conv.id, 9, 40)); // Royal Compromise

            // Choice 20: Back Azaro
            AddChoice(conv, 20, LucitaId, "Choose_Azaro_Logistics",
                "\"Military necessity comes first. Grant House Azaro full requisition powers across Brenas to fuel our offensive.\"",
                "Military necessity takes precedence over local trade. Grant Councilor Azaro and the General Staff full requisition authority over the southern transit network. The tanks must keep rolling.", 21,
                "Variable[\"Zille_Logistics_House\"] = \"Azaro\"; Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] - 2; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] + 1; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] - 1;");

            AddLine(conv, 21, LucitaId, RomusId, "Ack_Azaro_Logistics",
                "\"A decisive command, Your Majesty,\" Lucita nodded with satisfaction. \"Our mechanized columns will not lack for a single barrel of fuel or crate of ammunition.\"", 22);
            AddLine(conv, 22, AngelicaId, RomusId, "Ack_Azaro_Angelica",
                "Duchess Angelica tightened her shawl, her face hardening into cold aristocratic disapproval. \"The Crown may have its fuel, Sire. Let us hope our farmers do not starve in the process.\"", -1);

            // Choice 30: Back Sazon
            AddChoice(conv, 30, ManusId, "Choose_Sazon_Logistics",
                "\"House Sazon will manage the supply lines. Utilize merchant guilds and granaries to protect provincial stability.\"",
                "We cannot break the back of Brenas to win a battle. House Sazon will oversee rear supply and transit. Utilize your guild networks and granaries to keep our army fed and our people secure.", 31,
                "Variable[\"Zille_Logistics_House\"] = \"Sazon\"; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] + 1; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] - 1;");

            AddLine(conv, 31, ManusId, RomusId, "Ack_Sazon_Manus",
                "\"Thank you, Your Majesty,\" Manus bowed deeply. \"We will ensure that our depots operate with utmost efficiency and fairness. The people of Brenas will stand firmly behind your banners.\"", 32);
            AddLine(conv, 32, LucitaId, RomusId, "Ack_Sazon_Lucita",
                "Lucita frowned, closing her operational ledger with an audible snap. \"I only pray, Sire, that our tanks do not run dry while waiting on Sazon guild manifests.\"", -1);

            // Choice 40: Royal Compromise
            AddChoice(conv, 40, ElenaId, "Choose_Compromise_Logistics",
                "\"Elena Werner will oversee a joint logistics board: military transport gets prioritized routes, but Sazon guilds manage procurement.\"",
                "Neither house will dictate terms unilaterally. Elena Werner and the Ministry of Economy will establish a joint logistical board. Priority corridors will be reserved for military convoys, but all procurement and grain distribution will be handled through Sazon syndicates.", 41,
                "Variable[\"Zille_Logistics_House\"] = \"Compromise\"; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = Variable[\"RiziaDLC.HouseAzaro_Opinion\"] + 1; Variable[\"RiziaDLC.HouseSazon_Opinion\"] = Variable[\"RiziaDLC.HouseSazon_Opinion\"] + 1;");

            AddLine(conv, 41, ElenaId, RomusId, "Ack_Compromise_Elena",
                "\"Sensible and balanced, Your Majesty,\" Elena remarked with an approving nod. \"It keeps the army rolling without inviting financial graft or provincial outrage.\"", 42);
            AddLine(conv, 42, HugoId, RomusId, "Ack_Compromise_Hugo",
                "\"A kingly solution, Romus. Unity between our great houses is the true shield of Rizia.\"", -1);

            db.AddConversation(conv);
            MelonLogger.Msg("[ZILLE DIALOGUE] Re-injected Logistics Dispute (ID 9990) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 4: Turn_Zille_WarPreNegotiationsBriefing (ID 9991)
        // High Command Council debrief + 3 Optional Encrypted Phone Calls:
        // Alvarez (Lespia) - NO foreign troops! Intel & AN veto.
        // Hegel (Valgsland) - Rage at monarchists, but offers de-escalation naval deal.
        // Beatrice (Rumburg) - Royal solidarity & post-war oil contracts.
        // =========================================================================
        public static void RegisterWarPreNegotiationsBriefing(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarPreNegotiationsBriefing") != null || db.GetConversation("Zille/PreNegotiationsBriefing") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPreNegotiations;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Turn_Zille_WarPreNegotiationsBriefing";
            conv.ActorID = RomusId;
            conv.ConversantID = LaurentoId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, LaurentoId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "PreNeg_Intro_1",
                "The war council in Porte Drazon was buried beneath a flurry of urgent dispatches from the front. Artillery rumbled like distant thunder across the southern wire. The first phase of operations had reached its climax, and Wiktor Smolak had requested an urgent parley.", 2);

            AddLine(conv, 2, ElenaId, RomusId, "PreNeg_Elena_BurnRate",
                "Your Majesty, the financial toll of this offensive is mounting rapidly. Daily ammunition consumption and fuel requisitions have pushed our operating budget to its limit. Whatever outcome we seek, we must conclude this war swiftly before fiscal exhaustion sets in.", 3);

            AddLine(conv, 3, LucitaId, RomusId, "PreNeg_Lucita_Casualties",
                "Our soldiers have fought with unmatched courage, Sire. But Valdez's remaining garrisons are dug in behind fortified concrete. Pushing deeper into mainland Wehlen would turn into a meat grinder. Smolak is feeling the noose tighten; now is the moment to dictate terms.", 4);

            AddLine(conv, 4, LaurentoId, RomusId, "PreNeg_Laurento_Hotline",
                "Before you enter the negotiation tent or take Smolak's call, Your Majesty, the royal communications bureau has secured encrypted channels to three key foreign leaders. A final word with them could grant us invaluable diplomatic leverage.", 5);

            // ================= PHONE SELECTION HUB (Entry 5) =================
            var phoneHub = AddLine(conv, 5, NarratorId, RomusId, "Hotline_Hub_Prompt",
                "The secure teletype and telephone lines sat waiting in the royal communications cabinet. Who will you contact before meeting Smolak?");

            phoneHub.outgoingLinks.Add(CreateLink(conv.id, 5, 10)); // Alvarez (Lespia)
            phoneHub.outgoingLinks.Add(CreateLink(conv.id, 5, 20)); // Hegel (Valgsland)
            phoneHub.outgoingLinks.Add(CreateLink(conv.id, 5, 30)); // Beatrice (Rumburg)
            phoneHub.outgoingLinks.Add(CreateLink(conv.id, 5, 50)); // Proceed to Parley!

            // ---------------- CALL 1: PATRICIO ALVAREZ (LESPIA) ----------------
            AddChoice(conv, 10, AlvarezId, "Call_Alvarez",
                "Place an encrypted call to President Patricio Alvarez of Lespia.",
                "Connect me with President Alvarez in Estord.", 11);

            AddLine(conv, 11, NarratorId, RomusId, "Alvarez_Connect",
                "The line clicked and hissed before Alvarez's voice came through, punctuated by the clinking of ice against crystal and jazz playing faintly in the background.", 12);
            AddLine(conv, 12, AlvarezId, RomusId, "Alvarez_Greeting",
                "Romus! Still holding the crown, I see? My staff tells me your artillery is giving my dear friend Wiktor a hell of a beating in Zille. I must admit, watching him sweat is the best entertainment I've had all season.", 13);

            var alvarezOptions = AddLine(conv, 13, AlvarezId, RomusId, "Alvarez_Prompt",
                "So, what brings the King of Rizia to my ear while his tanks are rolling?");
            alvarezOptions.outgoingLinks.Add(CreateLink(conv.id, 13, 14)); // Ask for troops (Lore check: Alvarez REFUSES!)
            alvarezOptions.outgoingLinks.Add(CreateLink(conv.id, 13, 16)); // Shrewd Leverage (Intel & Veto)

            // Alvarez Troops Refusal (STRICT LORE COMPLIANCE)
            AddChoice(conv, 14, AlvarezId, "Alvarez_Ask_Troops",
                "\"Will Lespia commit ground divisions or airstrikes to help us finish off Wehlen?\"",
                "Will Lespia deploy forces to assist us in breaking Smolak's remaining defenses?", 15);
            AddLine(conv, 15, AlvarezId, RomusId, "Alvarez_Refuse_Troops",
                "Alvarez burst into loud, mocking laughter. \"Send Lespian soldiers into Wehlen? What do you take me for, Romus, an amateur? If I put one boot across that border, Malenyev's submarines will blockade my coastline and Arcasia will hold me responsible for World War Three! No, no, no. Lespian boys don't die for your royal pride. You started this fight—you finish it.\"", 13);

            // Alvarez Leverage
            AddChoice(conv, 16, AlvarezId, "Alvarez_Leverage",
                "\"Patricio, if you won't provide intelligence and an AN veto, I will sign a ceasefire right now and leave Wehlen armed on your border.\"",
                "Patricio, let us speak as realists. If Lespia does not provide high-altitude reconnaissance and guarantee a veto against CSP sanctions at the AN, I will sign an armistice with Smolak today. Wehlen will keep its army intact, and you will be left dealing with an enraged dictator on your frontier alone.", 17);
            AddLine(conv, 17, AlvarezId, RomusId, "Alvarez_Leverage_Yield",
                "A tense silence fell over the line. Alvarez sighed, the sound of ice swirling in his glass. \"You drive a ruthless bargain, Your Majesty. Fine. My defense ministry will transmit our latest aerial reconnaissance photographs of Valdez's bunkers, and Lespian envoys in Kyrute will kill any resolution pushing for economic sanctions against Rizia. Just make sure Smolak is thoroughly humiliated before you put down the pen.\"", 18);
            AddLine(conv, 18, AlvarezId, RomusId, "Alvarez_Hangup",
                "\"Good luck, Romus. Don't make me regret this.\" The line went dead with a soft click.", 5);

            // ---------------- CALL 2: EMMERICH HEGEL (VALGSLAND / CSP) ----------------
            AddChoice(conv, 20, HegelId, "Call_Hegel",
                "Place an encrypted call to Chancellor Emmerich Hegel of Valgsland.",
                "Connect me with Chancellor Hegel in Valgsland.", 21);

            AddLine(conv, 21, NarratorId, RomusId, "Hegel_Connect",
                "The line buzzed with heavy static. After two rings, Hegel's fiery voice boomed through the receiver.", 22);
            AddLine(conv, 22, HegelId, RomusId, "Hegel_Rage",
                "Toras! Have you completely lost your royal mind? Bombarding cities, marching troops across borders, and playing feudal warlord right under the nose of the international community! The working people of South Merkopa are not pawns for your dynastic games!", 23);

            var hegelOptions = AddLine(conv, 23, HegelId, RomusId, "Hegel_Prompt",
                "Give me one good reason why the Red Fleet shouldn't steam into the Southern Gulf this very afternoon!");
            hegelOptions.outgoingLinks.Add(CreateLink(conv.id, 23, 24)); // Soothing & Neutrality
            hegelOptions.outgoingLinks.Add(CreateLink(conv.id, 23, 26)); // Naval De-escalation Offer

            AddChoice(conv, 24, HegelId, "Hegel_Sovereignty",
                "\"Rizia is merely reclaiming stolen sovereign soil. We have no interest in mainland Wehlen or threatening maritime trade.\"",
                "Chancellor Hegel, calm yourself. Wehlen occupied our territory unlawfully for thirty years. Rizia has no designs on mainland Wehlen, nor will we interfere with international shipping. We seek only our rightful borders.", 25);
            AddLine(conv, 25, HegelId, RomusId, "Hegel_Sovereignty_Reply",
                "A muffled thud echoed over the line—Hegel slamming his pipe against his desk. \"Words are cheap, King! But if you keep your armor strictly on your side of the river and do not dare threaten commercial vessels in the straits, Valgsland will stay its hand. We have no love for Smolak's clownish brutality, but we will not tolerate imperialist conquest!\"", 23);

            AddChoice(conv, 26, HegelId, "Hegel_Deescalation_Deal",
                "\"If we conclude a swift treaty that guarantees naval demilitarization in Zille waters, can we establish stable relations?\"",
                "Let us be pragmatic, Chancellor. If the upcoming treaty guarantees demilitarized naval access in Zille waters and respects free trade, Rizia is prepared to conclude the fighting immediately. A stable South Merkopa benefits your trade routes.", 27);
            AddLine(conv, 27, HegelId, RomusId, "Hegel_Deal_Reply",
                "Hegel grunted, his tone shifting from outrage to shrewd socialist calculation. \"Now you are speaking like a statesman rather than a despot, Toras. If you guarantee naval demilitarization in the Zille gulf, Valgsland will discreetly authorize the export of modern coastal patrol escorts and fuel stabilization shipments to balance the region. Sign your treaty and withdraw your guns from the border!\"", 28);
            AddLine(conv, 28, HegelId, RomusId, "Hegel_Hangup",
                "\"Remember my words, Romus. We are watching you.\" The call terminated abruptly.", 5);

            // ---------------- CALL 3: QUEEN BEATRICE LIVINGSTON (RUMBURG) ----------------
            AddChoice(conv, 30, BeatriceId, "Call_Beatrice",
                "Place an encrypted call to Queen Beatrice Livingston of Rumburg.",
                "Patch me through to Thornbourgh. I wish to speak with Queen Beatrice.", 31);

            AddLine(conv, 31, NarratorId, RomusId, "Beatrice_Connect",
                "After a series of royal exchange operators verified the cipher, Beatrice's cool, aristocratic voice came over the speaker.", 32);
            AddLine(conv, 32, BeatriceId, RomusId, "Beatrice_Greeting",
                "Romus. I trust you are calling with favorable dispatches from the south. The chancellery in Thornbourgh has been monitoring your military maneuvers with great interest.", 33);

            var beatriceOptions = AddLine(conv, 33, BeatriceId, RomusId, "Beatrice_Prompt",
                "How stands your campaign, Cousin?");
            beatriceOptions.outgoingLinks.Add(CreateLink(conv.id, 33, 34)); // Report on Zille
            beatriceOptions.outgoingLinks.Add(CreateLink(conv.id, 33, 36)); // Request Oil Backing

            AddChoice(conv, 34, BeatriceId, "Beatrice_Report",
                "\"Our forces have broken Valdez's forward line. Smolak is ready to negotiate.\"",
                "Our forces have shattered Wehzek resistance across the peninsula. Smolak has requested a parley, and we are preparing to dictate terms.", 35);
            AddLine(conv, 35, BeatriceId, RomusId, "Beatrice_Report_Reply",
                "\"Splendid news,\" Beatrice replied with measured warmth. \"A monarch who demonstrates the will to wield the sword commands the respect of every crowned head in the world. Smolak is a dangerous radical; seeing him humbled brings stability to GRACE's southern flank.\"", 33);

            AddChoice(conv, 36, BeatriceId, "Beatrice_Oil_Pledge",
                "\"Once Zille is secured, Rizia will guarantee Rumburg favorable oil contracts to assist our post-war recovery.\"",
                "Once the oil fields of Zille are back under royal control, the Crown is prepared to guarantee Rumburg long-term petroleum concessions at favorable rates, securing our economic revival.", 37);
            AddLine(conv, 37, BeatriceId, RomusId, "Beatrice_Oil_Reply",
                "\"A mutually beneficial arrangement, Romus,\" she approved. \"Rumburg will instruct our envoys to back Rizia unequivocally at the Alliance of Nations. Reclaim your birthright and restore order to the south. You have the full blessing of the Kingdom of Rumburg.\"", 38);
            AddLine(conv, 38, BeatriceId, RomusId, "Beatrice_Hangup",
                "\"Give my fondest regards to your mother. Stand firm, Romus.\" The queen ended the connection.", 5);

            // ---------------- PROCEED TO PARLEY ----------------
            AddChoice(conv, 50, LaurentoId, "Proceed_To_Parley",
                "\"I have gathered all the diplomatic leverage I need. Have the car prepared—I will meet Smolak at the parley.\"",
                "I have gathered all the diplomatic leverage I need. Have the escort prepared—I will meet Smolak face to face.", 51);

            AddLine(conv, 51, LucitaId, RomusId, "PreNeg_Closing",
                "\"The royal armored motorcade is standing by, Sire,\" Lucita reported, adjusting her sidearm. \"The Golden Guard and our forward battalions will secure the perimeter. Let us settle this once and for all.\"", -1);

            db.AddConversation(conv);
            MelonLogger.Msg("[ZILLE DIALOGUE] Re-injected Pre-Negotiations Briefing (ID 9991) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 5: Turn_Zille_WarSmolakFinalParley (ID 9992) - FRONTLINE PARLEY
        // Tense frontline meeting with Wiktor Smolak in a neutral field tent.
        // Peak Smolak characterization: smiling tyrant, cynical humor, tea & smokes.
        // =========================================================================
        public static void RegisterWarSmolakFinalParley(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarSmolakFinalParley") != null || db.GetConversation("Zille/SmolakFinalParley") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarSmolakParley;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Turn_Zille_WarSmolakFinalParley";
            conv.ActorID = RomusId;
            conv.ConversantID = SmolakId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, SmolakId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Parley_Intro_1",
                "A neutral canvas military pavilion had been erected in the shell-cratered no-man's land between the lines, flanked by armed Golden Guards and grim Wehzek Republican Guards. Outside, distant smoke rose from the burning oil storage tanks of Wiktrany.", 2);
            AddLine(conv, 2, NarratorId, RomusId, "Parley_Intro_2",
                "President Wiktor Smolak sat across a battered wooden field table, casually pouring steaming black tea into two tin cups. His signature olive-green military tunic was dusty at the elbows, but his grin was as wide and irreverent as ever.", 3);

            AddLine(conv, 3, SmolakId, RomusId, "Smolak_Parley_1",
                "Romus! Your Majesty! Look at us! Meeting like two brigands in a muddy tent instead of drinking fine Cantuavo wine in your glittering palace.", 4);
            AddLine(conv, 4, SmolakId, RomusId, "Smolak_Parley_2",
                "Tea? It's authentic Wehzek mountain tea. Strong enough to strip engine grease, but wonderful for clearing the smell of cordite from the nostrils. Here, take a cup.", 5);

            var parleyHub = AddLine(conv, 5, SmolakId, RomusId, "Smolak_Parley_Prompt",
                "He slid the steaming tin cup across the scarred wood, his dark eyes twinkling with dangerous curiosity.");

            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 5, 10)); // Cold & Direct
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 5, 20)); // Ironical & Mocking
            parleyHub.outgoingLinks.Add(CreateLink(conv.id, 5, 30)); // Take the tea & Negotiate

            // Choice 10: Cold & Direct
            AddChoice(conv, 10, SmolakId, "Parley_Cold",
                "\"I did not come here to share tea, Wiktor. Your army is broken. Sign the evacuation order and leave Zille.\"",
                "I did not come here to share tea, Wiktor. Your forward line at Wiktrany is in ruins, and your garrison is cut off. Sign the evacuation order and return our province.", 11);
            AddLine(conv, 11, SmolakId, RomusId, "Smolak_Cold_Reply",
                "Smolak chuckled softly, taking a leisurely sip from his own cup. \"Always so formal, Romus! 'Your army is broken, leave Zille!' Do you think winning a few trenches makes you Alexander the Great? In Wehlen, my people have eaten tree bark and fought through civil wars for twenty years without blinking!\"", 40);

            // Choice 20: Mocking
            AddChoice(conv, 20, SmolakId, "Parley_Mocking",
                "\"You seemed much fonder of parades when we met in Zille, Wiktor. What happened to all your tanks?\"",
                "You seemed remarkably fond of military parades when we met in Zille, Wiktor. What happened to all those gleaming tanks you bragged about?", 21);
            AddLine(conv, 21, SmolakId, RomusId, "Smolak_Mocking_Reply",
                "Smolak threw his head back and laughed heartily, slapping the table. \"Ha! A direct hit! Touché, Your Majesty! Turns out diesel engines don't like artillery shells very much! But that's the beauty of tanks—they can always be replaced. What can't be replaced is a friendship between neighboring statesmen, right?\"", 40);

            // Choice 30: Take tea
            AddChoice(conv, 30, SmolakId, "Parley_TakeTea",
                "Accept the cup of tea and sit down calmly.",
                "I will take the tea, Wiktor. But let us not pretend this is a social visit. Our cannons are still aimed at your headquarters.", 31);
            AddLine(conv, 31, SmolakId, RomusId, "Smolak_Tea_Reply",
                "\"Now that is the mark of a civilized sovereign!\" Smolak beamed, raising his cup in a mock toast. \"Two men of destiny, settling the fate of South Merkopa over a tin of boiling herbs while the guns stay quiet for an hour.\"", 40);

            // Smolak drops the mask
            AddLine(conv, 40, NarratorId, RomusId, "Smolak_Mask_Drop_1",
                "Suddenly, Smolak's jovial expression evaporated like mist. His face hardened, the playful clown vanishing instantly into the calculating dictator who had survived coups, uprisings, and foreign plots.", 41);
            AddLine(conv, 41, SmolakId, RomusId, "Smolak_Mask_Drop_2",
                "Let us stop fencing, Romus. You have proven you have teeth. House Toras is not the toothless tiger your father was. But neither is Wehlen a province waiting to be carved up like roast mutton.", 42);
            AddLine(conv, 42, SmolakId, RomusId, "Smolak_Mask_Drop_3",
                "Both of our nations are bleeding money and men every single hour this front stays open. Our diplomats are waiting in the adjoining tent with the treaty instruments. Let us see what kind of peace your army has earned.", 43);

            AddChoice(conv, 43, SmolakId, "Enter_Peace_Treaty",
                "\"Lead the way. Let us put an end to this war on terms the Crown can accept.\"",
                "Lead the way. Let us put an end to this war on terms the Kingdom of Rizia can accept.", 44);

            AddLine(conv, 44, SmolakId, RomusId, "Smolak_Enter_Treaty",
                "\"After you, Your Majesty,\" Smolak gestured toward the flap leading to the treaty chamber with an ironic bow. \"History is waiting for our signatures.\"", -1);

            db.AddConversation(conv);
            MelonLogger.Msg("[ZILLE DIALOGUE] Re-injected Smolak Final Parley (ID 9992) into masterDatabase!");
        }

        // =========================================================================
        // SCENE 6: Turn_Zille_WarPeaceTreaty (ID 9993) - THE PEACE TREATY (5 OUTCOMES)
        // Formal signing of the war treaty based on tactical performance:
        // 1 = Total Fiasco, 2 = Tactical Defeat, 3 = Bloody Stalemate,
        // 4 = Decisive Victory, 5 = Overwhelming Triumph.
        // =========================================================================
        public static void RegisterWarPeaceTreaty(DialogueDatabase db)
        {
            if (db.GetConversation("Turn_Zille_WarPeaceTreaty") != null || db.GetConversation("Zille/PeaceTreaty") != null)
                return;

            var conv = new Conversation();
            conv.id = ConvId_WarPeaceTreaty;
            conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
            conv.Title = "Turn_Zille_WarPeaceTreaty";
            conv.ActorID = RomusId;
            conv.ConversantID = SmolakId;

            var entry0 = CreateEntry(conv.id, 0, RomusId, SmolakId, "START", "", "", "Continue()");
            entry0.isRoot = true;
            entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
            conv.dialogueEntries.Add(entry0);

            AddLine(conv, 1, NarratorId, RomusId, "Treaty_Intro",
                "The treaty table was draped in neutral green baize. Diplomatic aides from Rizia and Wehlen stood arranged with fountain pens, official parchment, and the royal seal of Rizia. Smolak sat back in his chair, tapping a gold cigarette case against the armrest.", 2);

            var branchOutcome = AddLine(conv, 2, NarratorId, RomusId, "Treaty_Branch_Prompt",
                "The outcome of the operational campaign on the battlefield dictated the terms of the treaty before you.");

            branchOutcome.outgoingLinks.Add(CreateLink(conv.id, 2, 100)); // Outcome 1: Total Fiasco
            branchOutcome.outgoingLinks.Add(CreateLink(conv.id, 2, 200)); // Outcome 2: Tactical Defeat
            branchOutcome.outgoingLinks.Add(CreateLink(conv.id, 2, 300)); // Outcome 3: Stalemate
            branchOutcome.outgoingLinks.Add(CreateLink(conv.id, 2, 400)); // Outcome 4: Decisive Victory
            branchOutcome.outgoingLinks.Add(CreateLink(conv.id, 2, 500)); // Outcome 5: Overwhelming Triumph

            // ---------------- OUTCOME 1: TOTAL FIASCO ----------------
            var f100 = AddLine(conv, 100, SmolakId, RomusId, "Outcome1_Smolak",
                "Smolak smiled with predatory satisfaction. \"Well, well, Your Majesty. Your bold invasion collapsed before it even reached Wiktrany, and my Republican Guards are currently billeted in your border towns of Brenas. These terms are non-negotiable.\"");
            f100.conditionsString = "Variable[\"Zille_War_Outcome\"] == 1";

            AddLine(conv, 101, NarratorId, RomusId, "Outcome1_Terms",
                "The treaty dictated unconditional surrender of Rizian claims to Zille, the cession of a demilitarized buffer zone inside Brenas to Wehlen, and an astronomical indemnity of 5 Budget. In Porte Drazon, the royal guards were already preparing for violent unrest and military mutiny.", 102);

            AddChoice(conv, 102, SmolakId, "Sign_Outcome1",
                "Sign the humiliating treaty to prevent Wehzek forces from marching on Porte Drazon.",
                "With trembling fingers and a heavy heart, you sign the document, knowing House Toras will never recover from this disgrace.", 103,
                "Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] - 5; Variable[\"RiziaDLC.Resources_Authority\"] = Variable[\"RiziaDLC.Resources_Authority\"] - 5; Variable[\"RiziaDLC.Country_PublicOpinion\"] = Variable[\"RiziaDLC.Country_PublicOpinion\"] - 3;");

            AddLine(conv, 103, SmolakId, RomusId, "Outcome1_End",
                "\"A pleasure doing business with you, Romus. Give my regards to the coup leaders when you get back to your capital.\" Smolak took his parchment and walked out.", -1);

            // ---------------- OUTCOME 2: TACTICAL DEFEAT ----------------
            var f200 = AddLine(conv, 200, SmolakId, RomusId, "Outcome2_Smolak",
                "Smolak leaned across the table, shaking his head with mock pity. \"You fought hard, Romus. But you lost key positions, and your supply lines collapsed. Wehlen holds the high ground.\"");
            f200.conditionsString = "Variable[\"Zille_War_Outcome\"] == 2";

            AddLine(conv, 201, NarratorId, RomusId, "Outcome2_Terms",
                "The treaty required the immediate withdrawal of all Rizian troops from Zille, substantial reparations to Wehlen (-3 Budget), and the continuation of the lease under Wehzek administration. The campaign had ended in bitter failure.", 202);

            AddChoice(conv, 202, SmolakId, "Sign_Outcome2",
                "Sign the treaty to save the remnants of your army.",
                "You affix your signature, accepting bitter defeat to prevent further useless bloodshed.", 203,
                "Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] - 3; Variable[\"RiziaDLC.Resources_Authority\"] = Variable[\"RiziaDLC.Resources_Authority\"] - 3;");

            AddLine(conv, 203, SmolakId, RomusId, "Outcome2_End",
                "\"Next time, Romus, stick to diplomacy. War is an expensive hobby for princes.\" Smolak nodded curtly and departed.", -1);

            // ---------------- OUTCOME 3: BLOODY STALEMATE ----------------
            var f300 = AddLine(conv, 300, SmolakId, RomusId, "Outcome3_Smolak",
                "Smolak rubbed his bloodshot eyes, genuinely exhausted. \"We have pounded each other into the mud for weeks, Romus. Neither of us can deliver a knockout punch without bankrupting our nations.\"");
            f300.conditionsString = "Variable[\"Zille_War_Outcome\"] == 3";

            AddLine(conv, 301, NarratorId, RomusId, "Outcome3_Terms",
                "The treaty established a compromise armistice: an immediate ceasefire, a demilitarized zone along the central peninsula, and a 50/50 joint revenue sharing agreement over the Zille oil facilities. Neither side achieved total victory, but the bloodshed was halted.", 302);

            AddChoice(conv, 302, SmolakId, "Sign_Outcome3",
                "Sign the mutual armistice and compromise agreement.",
                "You sign the treaty, securing half of Zille's wealth while ending a bloody and exhausting stalemate.", 303,
                "Variable[\"RiziaDLC.Resources_Authority\"] = Variable[\"RiziaDLC.Resources_Authority\"] + 1;");

            AddLine(conv, 303, SmolakId, RomusId, "Outcome3_End",
                "\"Not what either of us dreamed of, but our soldiers get to go home alive. Safe travels back to Porte Drazon, Romus.\" He offered a brief, weary handshake.", -1);

            // ---------------- OUTCOME 4: DECISIVE VICTORY ----------------
            var f400 = AddLine(conv, 400, SmolakId, RomusId, "Outcome4_Smolak",
                "Smolak stared down at the treaty with clenched teeth, his usual smile utterly gone. \"Your divisions have encircled Zille City and captured Wiktrany. You hold the cards, Romus.\"");
            f400.conditionsString = "Variable[\"Zille_War_Outcome\"] == 4 || Variable[\"Zille_War_Outcome\"] == 0"; // Default victorious path

            AddLine(conv, 401, NarratorId, RomusId, "Outcome4_Terms",
                "The treaty dictated the complete, unconditional, and immediate return of the Zille province to the Kingdom of Rizia. All Wehzek garrisons must evacuate within 48 hours, leaving all port infrastructure, gold mines, and oil refineries intact under royal ownership. No concessions or reparations granted to Wehlen.", 402);

            AddChoice(conv, 402, SmolakId, "Sign_Outcome4",
                "Sign the instrument of liberation. Zille returns to the Crown!",
                "With a steady hand and quiet royal majesty, you sign the Treaty of Zille, ending thirty years of foreign occupation.", 403,
                "Variable[\"RiziaDLC.Zille_Returned\"] = true; Variable[\"RiziaDLC.Resources_Authority\"] = Variable[\"RiziaDLC.Resources_Authority\"] + 3; Variable[\"RiziaDLC.Country_PublicOpinion\"] = Variable[\"RiziaDLC.Country_PublicOpinion\"] + 2;");

            AddLine(conv, 403, SmolakId, RomusId, "Outcome4_End",
                "Smolak signed with a bitter scrawl, tossing his pen onto the table. \"Take your province, Your Majesty. You fought like demons for it. But remember... South Merkopa has a very long memory.\" He turned on his heel and strode out into the rain.", -1);

            // ---------------- OUTCOME 5: OVERWHELMING TRIUMPH ----------------
            var f500 = AddLine(conv, 500, SmolakId, RomusId, "Outcome5_Smolak",
                "Smolak looked pale, his hands trembling slightly as his aides whispered frantic reports of Rizian armored columns advancing deep into Wehlen territory. \"You broke my army, Romus. You took the port, you took Wiktrany, and your guns are aimed at my homeland.\"");
            f500.conditionsString = "Variable[\"Zille_War_Outcome\"] == 5";

            AddLine(conv, 501, NarratorId, RomusId, "Outcome5_Terms",
                "The Treaty of Porte Drazon was a total triumph: unconditional return of Zille, complete handover of all extraction infrastructure, renunciation of all future Wehzek border claims, and the payment of heavy war indemnities (+4 Budget, +3 Energy) from Wehlen's central oil reserves. Romus Toras had achieved the greatest military triumph in modern Rizian history.", 502);

            AddChoice(conv, 502, SmolakId, "Sign_Outcome5",
                "Sign the historic treaty of triumph. Rizia stands as the undisputed power of South Merkopa!",
                "You press the royal wax seal into the parchment. The realm has not merely survived—it has triumphed with overwhelming glory.", 503,
                "Variable[\"RiziaDLC.Zille_Returned\"] = true; Variable[\"RiziaDLC.Resources_Budget\"] = Variable[\"RiziaDLC.Resources_Budget\"] + 4; Variable[\"RiziaDLC.Resources_Energy\"] = Variable[\"RiziaDLC.Resources_Energy\"] + 3; Variable[\"RiziaDLC.Resources_Authority\"] = Variable[\"RiziaDLC.Resources_Authority\"] + 4; Variable[\"RiziaDLC.Country_PublicOpinion\"] = Variable[\"RiziaDLC.Country_PublicOpinion\"] + 3;");

            AddLine(conv, 503, SmolakId, RomusId, "Outcome5_End",
                "Smolak affixed his presidential seal in silence, his defiance completely broken. As your escort formed up, the church bells of Brenas and Zille began to chime in unison, proclaiming the dawn of Romus the Restorer.", -1);

            db.AddConversation(conv);
            MelonLogger.Msg("[ZILLE DIALOGUE] Re-injected Peace Treaty (ID 9993) into masterDatabase!");
        }

        // =========================================================================
        // SURGICAL INJECTIONS INTO VANILLA DIALOGUE TREES
        // Seamlessly integrates war pathways across Turns 1 through 10.
        // =========================================================================
        public static void InjectAllVanillaConversationPatches()
        {
            try
            {
                var db = DialogueManager.masterDatabase;
                if (db == null || db.conversations == null || db.conversations.Count == 0) return;

                int patchedCount = 0;
                for (int i = 0; i < db.conversations.Count; i++)
                {
                    var conv = db.conversations[i];
                    if (conv == null || string.IsNullOrEmpty(conv.Title)) continue;

                    // 1. Turn 1 Council Meeting on Economy & State (EnT_CouncilBriefing)
                    if (conv.Title.IndexOf("EnT_CouncilBriefing", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn1ZilleCouncilChoice(conv, db)) patchedCount++;
                    }
                    // 2. Turn 1 Military & Security Meeting (SnO_SecurityMilitaryMeeting)
                    else if (conv.Title.IndexOf("SnO_SecurityMilitaryMeeting", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn1MilitaryPlanningChoice(conv, db)) patchedCount++;
                    }
                    // 3. Turn 2 Council Meeting on Foreign Relations (FPnT_DiplomacyBriefing)
                    else if (conv.Title.IndexOf("FPnT_DiplomacyBriefing", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectWehlenUltimatumOption(conv, db)) patchedCount++;
                    }
                    // 4. Turn 2 Wehzek-Rizian Friendship Day in Zille (FPnT_ZilleVisit)
                    else if (conv.Title.IndexOf("FPnT_ZilleVisit", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectSmolakFaceToFaceUltimatum(conv, db)) patchedCount++;
                    }
                    // 5. Turn 3 Debrief after the Zille Bombing (SnO_ZilleSecurityDebrief)
                    else if (conv.Title.IndexOf("SnO_ZilleSecurityDebrief", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn3EarlyWarMobilizationChoice(conv, db)) patchedCount++;
                    }
                    // 6. Turn 4 Alvarez Call (FPnT_AlvarezCall)
                    else if (conv.Title.IndexOf("FPnT_AlvarezCall", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn4AlvarezLeverageOption(conv, db)) patchedCount++;
                    }
                    // 7. Turn 4 Pales Council Discussion (A_CouncilTalkAboutPales)
                    else if (conv.Title.IndexOf("A_CouncilTalkAboutPales", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn4TwoFrontWarWarning(conv, db)) patchedCount++;
                    }
                    // 8. Turn 8 Zille Negotiations (FPnT_ZilleNegotiations)
                    else if (conv.Title.IndexOf("FPnT_ZilleNegotiations", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn8ReferendumRejectionUltimatum(conv, db)) patchedCount++;
                    }
                }

                MelonLogger.Msg($"[ZILLE DIALOGUE] Successfully audited and injected custom options into {patchedCount} vanilla dialogue trees!");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[ZILLE DIALOGUE] InjectAllVanillaConversationPatches error: {ex.Message}");
            }
        }

        private static bool InjectTurn1ZilleCouncilChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn1_Council_Choice") return true;
            }

            DialogueEntry parent = FindSuitableParent(conv, "Zille", "Elena", "territory", "reign");
            if (parent == null) return false;

            int choiceId = 99101;
            int replyId = 99102;

            var choice = CreateEntry(conv.id, choiceId, RomusId, HugoId, "Zille_Turn1_Council_Choice",
                "Zille must return to our kingdom when the lease expires. I expect the Council to prepare for any contingency—including force if Smolak reneges.",
                "\"Zille must return to our kingdom when the lease expires. I expect the Council to prepare for any contingency—including force if Smolak reneges.\"");

            var reply = CreateEntry(conv.id, replyId, HugoId, RomusId, "Zille_Turn1_Council_Reply",
                "Your Majesty... the recovery of Zille is close to all our hearts, but the Alliance of Nations holds treaties sacred. Let us pray it does not come to open war.",
                "Your Majesty... the recovery of Zille is close to all our hearts, but the Alliance of Nations holds treaties sacred. Let us pray it does not come to open war.");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            if (parent.outgoingLinks.Count > 0)
            {
                reply.outgoingLinks.Add(CreateLink(conv.id, replyId, parent.outgoingLinks[0].destinationDialogueID));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn1MilitaryPlanningChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn1_Military_Choice") return true;
            }

            DialogueEntry parent = FindSuitableParent(conv, "Azaro", "forces", "reforms", "Montaklar");
            if (parent == null) return false;

            int choiceId = 99103;
            int replyId = 99104;

            var choice = CreateEntry(conv.id, choiceId, RomusId, LucitaId, "Zille_Turn1_Military_Choice",
                "Councilor Azaro, I want the General Staff to begin drawing up contingency operational dossiers for the liberation of Zille.",
                "\"Councilor Azaro, I want the General Staff to begin drawing up contingency operational dossiers for the liberation of Zille.\"");
            choice.userScript = "Variable[\"Zille_Staff_Planning\"] = true;";

            var reply = CreateEntry(conv.id, replyId, LucitaId, RomusId, "Zille_Turn1_Military_Reply",
                "A prudent directive, Your Majesty. House Azaro will quietly assess the Brenas staging grounds and Wehzek redoubts across the river.",
                "A prudent directive, Your Majesty. House Azaro will quietly assess the Brenas staging grounds and Wehzek redoubts across the river.");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            if (parent.outgoingLinks.Count > 0)
            {
                reply.outgoingLinks.Add(CreateLink(conv.id, replyId, parent.outgoingLinks[0].destinationDialogueID));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectWehlenUltimatumOption(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_War_Ultimatum_Choice") return true;
            }

            DialogueEntry targetParent = FindSuitableParent(conv, "Wehlen", "Smolak", "Zille");
            if (targetParent == null) return false;

            int choiceId = 99201;
            int replyId = 99202;

            var choice = CreateEntry(conv.id, choiceId, RomusId, LaurentoId, "Zille_War_Ultimatum_Choice",
                "If Smolak does not return Zille on schedule, we will reclaim our ancestral province by force of arms. The armed forces must be placed on alert.",
                "\"If Smolak does not return Zille on schedule, we will reclaim our ancestral province by force of arms. The armed forces must be placed on alert.\"");
            choice.userScript = "Variable[\"RiziaDLC.CountryRelation_Wehlen_AtWar\"] = true; Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_War_Ultimatum_Given\"] = true;";

            var reply = CreateEntry(conv.id, replyId, LaurentoId, RomusId, "Zille_War_Ultimatum_Reply",
                "Your Majesty, an armed invasion of Zille risks triggering a severe diplomatic backlash from the Contanan Security Pact. Nevertheless, the General Staff shall prepare contingency offensive plans should the agreement collapse.",
                "Your Majesty, an armed invasion of Zille risks triggering a severe diplomatic backlash from the Contanan Security Pact. Nevertheless, the General Staff shall prepare contingency offensive plans should the agreement collapse.");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            if (targetParent.outgoingLinks.Count > 0)
            {
                reply.outgoingLinks.Add(CreateLink(conv.id, replyId, targetParent.outgoingLinks[0].destinationDialogueID));
            }
            targetParent.outgoingLinks.Add(CreateLink(conv.id, targetParent.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectSmolakFaceToFaceUltimatum(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Smolak_FaceToFace_Choice") return true;
            }

            DialogueEntry targetParent = FindSuitableParent(conv, "Smolak", "Zille", "Friendship");
            if (targetParent == null) return false;

            int choiceId = 99203;
            int replyId = 99204;

            var choice = CreateEntry(conv.id, choiceId, RomusId, SmolakId, "Zille_Smolak_FaceToFace_Choice",
                "This is Rizian soil, Wiktor. If you do not leave Zille voluntarily when the lease expires, our tanks will remove you.",
                "\"This is Rizian soil, Wiktor. If you do not leave Zille voluntarily when the lease expires, our tanks will remove you.\"");
            choice.userScript = "Variable[\"Zille_Smolak_Threatened\"] = true;";

            var reply = CreateEntry(conv.id, replyId, SmolakId, RomusId, "Zille_Smolak_FaceToFace_Reply",
                "Threats, Romus? In my own city? Wehlen does not fear your parade-ground uniforms. Just dare to cross that river, and you will see South Merkopa burn!",
                "Threats, Romus? In my own city? Wehlen does not fear your parade-ground uniforms. Just dare to cross that river, and you will see South Merkopa burn!");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            if (targetParent.outgoingLinks.Count > 0)
            {
                reply.outgoingLinks.Add(CreateLink(conv.id, replyId, targetParent.outgoingLinks[0].destinationDialogueID));
            }
            targetParent.outgoingLinks.Add(CreateLink(conv.id, targetParent.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn3EarlyWarMobilizationChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn3_Mobilize_Choice") return true;
            }

            DialogueEntry parent = FindSuitableParent(conv, "bombing", "Su Omina", "investigation", "Titus");
            if (parent == null) return false;

            int choiceId = 99301;
            int replyId = 99302;

            var choice = CreateEntry(conv.id, choiceId, RomusId, TitusId, "Zille_Turn3_Mobilize_Choice",
                "Smolak arranged this bombing to fabricate an excuse to steal Zille! Order the III Corps in Brenas onto full combat footing immediately!",
                "\"Smolak arranged this bombing to fabricate an excuse to steal Zille! Order the III Corps in Brenas onto full combat footing immediately!\"");
            choice.userScript = "Variable[\"Zille_EarlyWar_Triggered\"] = true; Variable[\"Zille_War_Alfa\"] = true;";

            var reply = CreateEntry(conv.id, replyId, TitusId, RomusId, "Zille_Turn3_Mobilize_Reply",
                "At once, Your Majesty! I will alert War Councilor Azaro and reinforce the border checkpoints. The General Staff will prepare for immediate combat operations.",
                "At once, Your Majesty! I will alert War Councilor Azaro and reinforce the border checkpoints. The General Staff will prepare for immediate combat operations.");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            if (parent.outgoingLinks.Count > 0)
            {
                reply.outgoingLinks.Add(CreateLink(conv.id, replyId, parent.outgoingLinks[0].destinationDialogueID));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn4AlvarezLeverageOption(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn4_Alvarez_Leverage") return true;
            }

            DialogueEntry parent = FindSuitableParent(conv, "Smolak", "Wehlen", "MITZ", "Alvarez");
            if (parent == null) return false;

            int choiceId = 99401;
            int replyId = 99402;

            var choice = CreateEntry(conv.id, choiceId, RomusId, AlvarezId, "Zille_Turn4_Alvarez_Leverage",
                "Patricio, Smolak is your biggest headache in South Merkopa. If Rizia is to humble him, Lespia must provide intelligence and diplomatic cover at the AN.",
                "\"Patricio, Smolak is your biggest headache in South Merkopa. If Rizia is to humble him, Lespia must provide intelligence and diplomatic cover at the AN.\"");
            choice.userScript = "Variable[\"Zille_LespiaPact_Signed\"] = true;";

            var reply = CreateEntry(conv.id, replyId, AlvarezId, RomusId, "Zille_Turn4_Alvarez_Reply",
                "Ha! You have some spine after all, Romus. I won't send my boys into Wehlen to die for your crown, but my spies will keep you informed, and Lespia will ensure the AN doesn't choke you with sanctions.",
                "Ha! You have some spine after all, Romus. I won't send my boys into Wehlen to die for your crown, but my spies will keep you informed, and Lespia will ensure the AN doesn't choke you with sanctions.");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            if (parent.outgoingLinks.Count > 0)
            {
                reply.outgoingLinks.Add(CreateLink(conv.id, replyId, parent.outgoingLinks[0].destinationDialogueID));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn4TwoFrontWarWarning(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn4_TwoFront_Warning") return true;
            }

            DialogueEntry parent = FindSuitableParent(conv, "Pales", "Aureus", "Reinhart", "fleet");
            if (parent == null) return false;

            int choiceId = 99403;
            int replyId = 99404;

            var choice = CreateEntry(conv.id, choiceId, RomusId, ElenaId, "Zille_Turn4_TwoFront_Warning",
                "If we mobilize against Pales, will our supply networks be able to maintain both frontiers?",
                "\"If we mobilize against Pales, will our supply networks be able to maintain both frontiers?\"");

            var reply = CreateEntry(conv.id, replyId, ElenaId, RomusId, "Zille_Turn4_TwoFront_Reply",
                "For Dast's sake, Your Majesty, absolutely not without severe economic hemorrhaging. Waging war on Pales while our troops are mobilized against Wehlen would double our fuel burn and bring immediate rationing to the capital.",
                "For Dast's sake, Your Majesty, absolutely not without severe economic hemorrhaging. Waging war on Pales while our troops are mobilized against Wehlen would double our fuel burn and bring immediate rationing to the capital.");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            if (parent.outgoingLinks.Count > 0)
            {
                reply.outgoingLinks.Add(CreateLink(conv.id, replyId, parent.outgoingLinks[0].destinationDialogueID));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn8ReferendumRejectionUltimatum(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn8_WarUltimatum_Choice") return true;
            }

            DialogueEntry parent = FindSuitableParent(conv, "referendum", "Smolak", "Zille", "agreement");
            if (parent == null) return false;

            int choiceId = 99801;
            int replyId = 99802;

            var choice = CreateEntry(conv.id, choiceId, RomusId, SmolakId, "Zille_Turn8_WarUltimatum_Choice",
                "There will be no referendum, Wiktor! You will return Zille by sunset tomorrow, or our artillery will settle this treaty for us!",
                "\"There will be no referendum, Wiktor! You will return Zille by sunset tomorrow, or our artillery will settle this treaty for us!\"");
            choice.userScript = "Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Variant\"] = 2;";

            var reply = CreateEntry(conv.id, replyId, SmolakId, RomusId, "Zille_Turn8_WarUltimatum_Reply",
                "So the King wants blood! Very well, Romus! Wehlen has fought giants and survived. Let us see how your shiny crown fares when our guns answer yours across the Brenas!",
                "So the King wants blood! Very well, Romus! Wehlen has fought giants and survived. Let us see how your shiny crown fares when our guns answer yours across the Brenas!");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            if (parent.outgoingLinks.Count > 0)
            {
                reply.outgoingLinks.Add(CreateLink(conv.id, replyId, parent.outgoingLinks[0].destinationDialogueID));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static DialogueEntry FindSuitableParent(Conversation conv, params string[] keywords)
        {
            if (conv == null || conv.dialogueEntries == null) return null;

            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e == null || e.outgoingLinks == null || e.outgoingLinks.Count == 0) continue;

                string fullText = (e.DialogueText ?? "") + " " + (e.Title ?? "") + " " + (e.MenuText ?? "");
                foreach (var kw in keywords)
                {
                    if (fullText.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return e;
                    }
                }
            }

            // Fallback: any node with multiple choice links
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e != null && e.outgoingLinks != null && e.outgoingLinks.Count >= 2)
                {
                    return e;
                }
            }

            return null;
        }
    }
}
