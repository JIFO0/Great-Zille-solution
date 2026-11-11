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
        // ================= ACTOR IDS (1:1 Vanilla Rizia Metadata) =================
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
        public const int LeonaId = 72;           // Leona Sazon (Countess of Sallabes)
        public const int CarlosId = 88;          // General Carlos Robles Azaro (Chief of the General Staff)
        public const int SmolakId = 77;          // Wiktor Smolak (President of Wehlen)
        public const int AlvarezId = 99;         // Patricio Alvarez (Prime Minister of Lespia)
        public const int HegelId = 78;           // Emmerich Hegel (Chancellor of Valgsland)
        public const int BeatriceId = 92;        // Queen Beatrice Livingston (Rumburg)
        public const int EstelaId = 64;          // Queen Mother Estela Toras
        public const int VinaId = 79;            // Princess Vina Toras
        public const int AzmalId = 69;           // Supreme Wiseman Jorga Azmal (Derdia)
        public const int TaddeusId = 83;         // Taddeus Azaro (Duke of Montaklar)
        public const int SalId = 87;             // Grand Wiseman Sal Ignacius of Rizia

        // ================= 10 MASTER EXPANSION SCENE IDS =================
        public const int ConvId_WarPlanning = 9987;
        public const int ConvId_WarBriefing = 9988;
        public const int ConvId_WarBalconySpeech = 9989;
        public const int ConvId_WarLogisticsDispute = 9990;
        public const int ConvId_WarPreNegotiations = 9991;
        public const int ConvId_WarSmolakParley = 9992;
        public const int ConvId_WarPeaceTreaty = 9993;
        public const int ConvId_MaveNortusHQ = 9994;
        public const int ConvId_DerdiaTalks = 9995;
        public const int ConvId_LespiaTalks = 9996;
        public const int ConvId_RumburgTalks = 9997;

        private static bool _conversationsRegistered = false;

        public static void EnsureAllConversationsRegistered()
        {
            try
            {
                var db = DialogueManager.masterDatabase;
                if (db == null) return;

                if (db.GetConversation("Turn_Zille_WarPlanning") != null &&
                    db.GetConversation("Turn_Zille_WarBriefing") != null &&
                    db.GetConversation("Turn_Zille_MaveNortusHQ") != null &&
                    db.GetConversation("Turn_Zille_DerdiaTalks") != null &&
                    db.GetConversation("Turn_Zille_LespiaTalks") != null &&
                    db.GetConversation("Turn_Zille_RumburgTalks") != null &&
                    db.GetConversation("Turn_Zille_WarLogisticsDispute") != null)
                {
                    return;
                }

                MelonLogger.Msg("[ZILLE DIALOGUE] Registering all 10 master Great Zille narrative scenes into masterDatabase...");

                RegisterWarPlanning(db);
                RegisterWarLogisticsDispute(db);
                RegisterWarCouncilBriefing(db);
                RegisterWarBalconySpeech(db);
                RegisterMaveNortusHQ(db);
                RegisterDerdiaTalks(db);
                RegisterLespiaTalks(db);
                RegisterRumburgTalks(db);
                RegisterWarPreNegotiationsBriefing(db);
                RegisterWarSmolakFinalParley(db);
                RegisterWarPeaceTreaty(db);

                _conversationsRegistered = true;
                DialogueOverrideManager.ApplyAllOverrides();
                MelonLogger.Msg("[ZILLE DIALOGUE] All 10 custom scenes successfully registered into masterDatabase!");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[ZILLE DIALOGUE] EnsureAllConversationsRegistered error: {ex.Message}\n{ex.StackTrace}");
            }
        }

        // ================= HELPER BUILDERS =================

        internal static void EnsureConvField(Conversation conv, string title, string val, FieldType type)
        {
            if (conv.fields == null) conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            for (int i = 0; i < conv.fields.Count; i++)
            {
                if (conv.fields[i] != null && conv.fields[i].title == title)
                {
                    conv.fields[i].value = val;
                    return;
                }
            }
            conv.fields.Add(new Field(title, val, type));
        }

        internal static void AddConversationWithAlias(DialogueDatabase db, Conversation conv, string canonicalTitle, string aliasTitle)
        {
            conv.Title = canonicalTitle;
            EnsureConvField(conv, "Title", canonicalTitle, FieldType.Text);
            EnsureConvField(conv, "Actor", conv.ActorID.ToString(), FieldType.Actor);
            EnsureConvField(conv, "Conversant", conv.ConversantID.ToString(), FieldType.Actor);

            if (db.GetConversation(canonicalTitle) == null)
            {
                db.AddConversation(conv);
            }

            if (!string.IsNullOrEmpty(aliasTitle) && aliasTitle != canonicalTitle && db.GetConversation(aliasTitle) == null)
            {
                var alias = new Conversation();
                alias.id = conv.id + 10000;
                alias.fields = new Il2CppSystem.Collections.Generic.List<Field>();
                alias.dialogueEntries = conv.dialogueEntries;
                alias.ActorID = conv.ActorID;
                alias.ConversantID = conv.ConversantID;
                alias.Title = aliasTitle;
                EnsureConvField(alias, "Title", aliasTitle, FieldType.Text);
                EnsureConvField(alias, "Actor", conv.ActorID.ToString(), FieldType.Actor);
                EnsureConvField(alias, "Conversant", conv.ConversantID.ToString(), FieldType.Actor);
                db.AddConversation(alias);
            }
        }

        internal static DialogueEntry CreateEntry(int convId, int entryId, int actorId, int conversantId, string title, string dialogueText, string menuText = "", string sequence = "")
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

        internal static Link CreateLink(int convId, int fromId, int toId)
        {
            var link = new Link();
            link.originConversationID = convId;
            link.originDialogueID = fromId;
            link.destinationConversationID = convId;
            link.destinationDialogueID = toId;
            link.isConnector = false;
            link.priority = ConditionPriority.Normal;
            return link;
        }

        internal static void SetEntryScript(DialogueEntry e, string script)
        {
            if (e == null || string.IsNullOrEmpty(script)) return;
            e.userScript = script;
            if (e.fields == null) e.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            for (int i = 0; i < e.fields.Count; i++)
            {
                if (e.fields[i] != null && e.fields[i].title == "Script")
                {
                    e.fields[i].value = script;
                    return;
                }
            }
            e.fields.Add(new Field("Script", script, FieldType.Text));
        }

        internal static void SetEntryCondition(DialogueEntry e, string condition)
        {
            if (e == null || string.IsNullOrEmpty(condition)) return;
            e.conditionsString = condition;
            if (e.fields == null) e.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            for (int i = 0; i < e.fields.Count; i++)
            {
                if (e.fields[i] != null && e.fields[i].title == "Conditions")
                {
                    e.fields[i].value = condition;
                    return;
                }
            }
            e.fields.Add(new Field("Conditions", condition, FieldType.Text));
        }

        internal static void AddLink(Conversation conv, int fromId, int toId)
        {
            var fromEntry = conv.GetDialogueEntry(fromId);
            if (fromEntry != null)
            {
                fromEntry.outgoingLinks.Add(CreateLink(conv.id, fromId, toId));
            }
        }

        internal static DialogueEntry AddLine(Conversation conv, int id, int speaker, int listener, string title, string text, int nextId = -1, string condition = "", string script = "")
        {
            var e = CreateEntry(conv.id, id, speaker, listener, title, text);
            SetEntryCondition(e, condition);
            SetEntryScript(e, script);
            if (nextId >= 0) e.outgoingLinks.Add(CreateLink(conv.id, id, nextId));
            conv.dialogueEntries.Add(e);
            return e;
        }

        internal static DialogueEntry AddChoice(Conversation conv, int id, int listener, string title, string menuText, string spokenText, int nextId, string script = "", string condition = "")
        {
            var e = CreateEntry(conv.id, id, RomusId, listener, title, spokenText, menuText);
            SetEntryScript(e, script);
            SetEntryCondition(e, condition);
            if (nextId >= 0) e.outgoingLinks.Add(CreateLink(conv.id, id, nextId));
            conv.dialogueEntries.Add(e);
            return e;
        }

        // =========================================================================
        // SURGICAL INJECTIONS INTO VANILLA DIALOGUE TREES
        // Integrates war pathways across Turns 1 through 10.
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
                        if (InjectTurn1MilitaryChoice(conv, db)) patchedCount++;
                    }
                    // 3. Turn 2 Diplomacy Briefing (FPnT_DiplomacyBriefing)
                    else if (conv.Title.IndexOf("FPnT_DiplomacyBriefing", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn2DiplomacyChoice(conv, db)) patchedCount++;
                    }
                    // 4. Turn 2 Zille Visit & Friendship Day (FPnT_ZilleVisit)
                    else if (conv.Title.IndexOf("FPnT_ZilleVisit", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn2ZilleVisitChoice(conv, db)) patchedCount++;
                    }
                    // 5. Turn 3 Post-Bombing Security Debrief (SnO_ZilleSecurityDebrief)
                    else if (conv.Title.IndexOf("SnO_ZilleSecurityDebrief", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn3BombingWarChoice(conv, db)) patchedCount++;
                    }
                    // 6. Turn 4 Alvarez Phone Call (FPnT_AlvarezCall)
                    else if (conv.Title.IndexOf("FPnT_AlvarezCall", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn4AlvarezCallChoice(conv, db)) patchedCount++;
                    }
                    // 7. Turn 4 Pales Council Discussion (A_CouncilTalkAboutPales)
                    else if (conv.Title.IndexOf("A_CouncilTalkAboutPales", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn4PalesCouncilChoice(conv, db)) patchedCount++;
                    }
                    // 8. Turn 8 Zille Final Negotiations (FPnT_ZilleNegotiations)
                    else if (conv.Title.IndexOf("FPnT_ZilleNegotiations", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn8ZilleNegotiationsWarChoice(conv, db)) patchedCount++;
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

            DialogueEntry parent = FindSuitableHub(conv, "energy", "Elena", "grid", "treasury", "Zille");
            if (parent == null) return false;

            int choiceId = 99101;
            int replyId = 99102;

            var choice = CreateEntry(conv.id, choiceId, RomusId, HugoId, "Zille_Turn1_Council_Choice",
                "Zille must return to our kingdom when the 1927 agreement expires. I expect the Council to prepare for any contingency-including force if Smolak reneges.",
                "\"Zille must return to our kingdom when the 1927 agreement expires. I expect the Council to prepare for any contingency-including force if Smolak reneges.\"");
            SetEntryScript(choice, "Variable[\"Zille_Military_Posture\"] = 1; Variable[\"Zille_MilitarySentiment\"] = 1;");

            var reply = CreateEntry(conv.id, replyId, HugoId, RomusId, "Hugo_Turn1_Zille_Response",
                "\"A resolute sentiment, Your Majesty,\" Hugo inclined his head slowly. \"The Crown cannot appear weak before Wehlen. Yet taking back Zille by the sword would invite international outcry. Let us pray it does not come to bloodshed.\"");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn1MilitaryChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn1_Lucita_BorderChoice") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Zille", "Pales", "Valero", "presence", "border");
            if (parent == null) return false;

            int choiceId = 99111;
            int replyId = 99112;

            var choice = CreateEntry(conv.id, choiceId, RomusId, LucitaId, "Zille_Turn1_Lucita_BorderChoice",
                "Councilor Azaro, review our garrisons along the Brenas frontier. If diplomacy breaks down, the army must be ready to march on Zille.",
                "\"Councilor Azaro, review our garrisons along the Brenas frontier. If diplomacy breaks down, the army must be ready to march on Zille.\"");
            SetEntryScript(choice, "Variable[\"Zille_StaffPlanning_Started\"] = true; Variable[\"Zille_MilitarySentiment\"] = 2;");

            var reply = CreateEntry(conv.id, replyId, LucitaId, RomusId, "Lucita_Turn1_Border_Response",
                "\"Understood, Your Majesty!\" Lucita's eyes flashed with fierce enthusiasm. \"The Azaro divisions in Brenas will begin covert topographical surveys of the border approaches and Wehzek forward positions immediately.\"");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn2DiplomacyChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn2_Diplomacy_Ultimatum") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Wehlen", "Zille", "partnership", "abandon", "return");
            if (parent == null) return false;

            int choiceId = 99121;
            int replyId = 99122;

            var choice = CreateEntry(conv.id, choiceId, RomusId, LaurentoId, "Zille_Turn2_Diplomacy_Ultimatum",
                "Smolak should be reminded that the 1927 lease has an expiration date, not a renegotiation clause. Rizia will take back what is hers.",
                "\"Smolak should be reminded that the 1927 lease has an expiration date, not a renegotiation clause. Rizia will take back what is hers.\"");
            SetEntryScript(choice, "Variable[\"Zille_Diplomatic_Firmness\"] = 2;");

            var reply = CreateEntry(conv.id, replyId, LaurentoId, RomusId, "Laurento_Turn2_Ultimatum_Response",
                "\"A firm stance, Your Majesty. I will draft a memorandum emphasizing our sovereign legal rights under the 1927 treaty.\"");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn2ZilleVisitChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn2_Smolak_Confrontation") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Friendship", "tanks", "square", "terms", "Zille");
            if (parent == null) parent = FindSuitableHub(conv, "Wehlen", "home", "President");
            if (parent == null) return false;

            int choiceId = 99131;
            int replyId = 99132;

            var choice = CreateEntry(conv.id, choiceId, RomusId, SmolakId, "Zille_Turn2_Smolak_Confrontation",
                "Enjoy your parade, President Smolak. When the 1927 lease expires, Rizian flags will fly above this city-one way or another.",
                "\"Enjoy your parade, President Smolak. When the 1927 lease expires, Rizian flags will fly above this city-one way or another.\"");
            SetEntryScript(choice, "Variable[\"Smolak_Zille_Threatened\"] = true;");

            var reply = CreateEntry(conv.id, replyId, SmolakId, RomusId, "Smolak_Turn2_Confrontation_Response",
                "Smolak's smile froze for a fraction of a second before he let out a harsh, barking laugh. \"Bold words, King Romus! But remember: flags require soldiers to raise them, and soldiers bleed very easily on these coastal hills.\"");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn3BombingWarChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn3_Bombing_WarOption") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Wehlen", "bombing", "proof", "testing", "accusations");
            if (parent == null) return false;

            int choiceId = 99141;
            int replyId = 99142;

            var choice = CreateEntry(conv.id, choiceId, RomusId, LucitaId, "Zille_Turn3_Bombing_WarOption",
                "This bombing is a blatant provocation by Wehlen. Order the Third and Fourth Corps to advance across the border immediately!",
                "\"This bombing is a blatant Wehzek provocation! Order our divisions to cross the border and reclaim Zille immediately!\"");
            SetEntryScript(choice, "Variable[\"Zille_War_EarlyLaunch\"] = true;");

            var reply = CreateEntry(conv.id, replyId, LucitaId, RomusId, "Lucita_Turn3_EarlyWar_Response",
                "\"Your Majesty, launching an unprepared offensive without securing our supply lines or international backing would be catastrophic! Smolak's garrisons are dug in behind fortified border redoubts and coastal bunkers!\"");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn4AlvarezCallChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn4_Alvarez_AntiSmolakChoice") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Zille", "debacle", "Wehlen", "agreement", "help");
            if (parent == null) return false;

            int choiceId = 99151;
            int replyId = 99152;

            var choice = CreateEntry(conv.id, choiceId, RomusId, AlvarezId, "Zille_Turn4_Alvarez_AntiSmolakChoice",
                "Patricio, Wehlen is a rogue regime threatening regional commerce. If Rizia must take action in Zille, can we count on Lespian intelligence?",
                "\"Patricio, Wehlen is a rogue regime threatening regional commerce. If Rizia must take action in Zille, can we count on Lespian intelligence?\"");
            SetEntryScript(choice, "Variable[\"Lespia_Zille_Intelligence_Asked\"] = true;");

            var reply = CreateEntry(conv.id, replyId, AlvarezId, RomusId, "Alvarez_Turn4_AntiSmolak_Response",
                "Alvarez chuckled over the static of the line. \"Smolak is a nuisance, Romus, but intelligence isn't free. Help Lespia in the MITZ negotiations, and maybe our reconnaissance planes will happen to photograph Valdez's bunker network for you.\"");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn4PalesCouncilChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn4_Council_TwoFrontWarning") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Pales", "arbitration", "Aureus", "escalation", "field");
            if (parent == null) return false;

            int choiceId = 99161;
            int replyId = 99162;

            var choice = CreateEntry(conv.id, choiceId, RomusId, HugoId, "Zille_Turn4_Council_TwoFrontWarning",
                "We must not overcommit in Pales. Zille remains our sovereign territory, and Smolak will exploit any sign of overextension.",
                "\"We must not overcommit in Pales. Zille remains our sovereign territory, and Smolak will exploit any sign of overextension.\"");
            SetEntryScript(choice, "Variable[\"Zille_Priority_Over_Pales\"] = true;");

            var reply = CreateEntry(conv.id, replyId, HugoId, RomusId, "Hugo_Turn4_TwoFront_Response",
                "\"Wise counsel, Romus. A two-front confrontation against both Pales and Wehlen would bleed our kingdom dry. We must choose our battles with care.\"");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn8ZilleNegotiationsWarChoice(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn8_War_Ultimatum") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "referendum", "discuss", "Smolak", "outcome");
            if (parent == null) parent = FindSuitableHub(conv, "Smolak", "Zille", "deal");
            if (parent == null) return false;

            int choiceId = 99171;
            int replyId = 99172;

            var choice = CreateEntry(conv.id, choiceId, RomusId, SmolakId, "Zille_Turn8_War_Ultimatum",
                "Enough of your extortion, Smolak! The 1927 lease has expired. Order your troops to vacate Zille immediately, or the Royal Army will reclaim our sovereign land by force!",
                "\"Enough of your extortion, Smolak! The 1927 lease has expired. Order your troops to vacate Zille immediately, or the Royal Army will reclaim our sovereign land by force!\"");
            SetEntryScript(choice, "Variable[\"Zille_War_UltimatumGiven\"] = true; Variable[\"Zille_War_Active\"] = true; Variable[\"Zille_War_Mobilization\"] = true;");

            var reply = CreateEntry(conv.id, replyId, SmolakId, RomusId, "Smolak_Turn8_Ultimatum_Response",
                "Smolak's face darkened, veins bulging along his neck as he slammed his fist onto the cabin table. \"You dare threaten Wehlen aboard my own airship?! Go on then, King Romus! Send your spoiled nobles and shiny tanks! General Valdez will bury them in the mud of Zille!\"");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static DialogueEntry FindSuitableHub(Conversation conv, params string[] keywords)
        {
            if (conv?.dialogueEntries == null) return null;

            DialogueEntry bestHub = null;
            int maxScore = 0;

            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var entry = conv.dialogueEntries[i];
                if (entry == null || entry.id == 0) continue;
                if (entry.ActorID == RomusId || entry.ActorID == RomusItalicId) continue;
                if (entry.outgoingLinks == null || entry.outgoingLinks.Count < 2) continue;

                int playerChildCount = 0;
                string combinedText = (entry.DialogueText ?? "") + " " + (entry.Title ?? "");

                for (int j = 0; j < entry.outgoingLinks.Count; j++)
                {
                    var child = conv.GetDialogueEntry(entry.outgoingLinks[j].destinationDialogueID);
                    if (child != null && child.ActorID == RomusId)
                    {
                        playerChildCount++;
                        combinedText += " " + (child.MenuText ?? child.DialogueText ?? "");
                    }
                }

                if (playerChildCount < 2) continue;

                int score = 0;
                foreach (var kw in keywords)
                {
                    if (combinedText.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        score++;
                    }
                }

                if (score > maxScore)
                {
                    maxScore = score;
                    bestHub = entry;
                }
            }

            return maxScore >= 1 ? bestHub : null;
        }

        private static int FindConvergenceTarget(Conversation conv, DialogueEntry hub)
        {
            if (conv == null || hub?.outgoingLinks == null) return -1;
            for (int i = 0; i < hub.outgoingLinks.Count; i++)
            {
                var child = conv.GetDialogueEntry(hub.outgoingLinks[i].destinationDialogueID);
                if (child != null && child.ActorID == RomusId && child.outgoingLinks != null && child.outgoingLinks.Count > 0)
                {
                    return child.outgoingLinks[0].destinationDialogueID;
                }
            }
            return hub.outgoingLinks.Count > 0 ? hub.outgoingLinks[0].destinationDialogueID : -1;
        }

        private static DialogueEntry FindEntryWithText(Conversation conv, string partialText)
        {
            if (conv?.dialogueEntries == null) return null;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var entry = conv.dialogueEntries[i];
                if (entry != null && entry.id > 0 && entry.DialogueText != null &&
                    entry.DialogueText.IndexOf(partialText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return entry;
                }
            }
            return null;
        }
    }
}
