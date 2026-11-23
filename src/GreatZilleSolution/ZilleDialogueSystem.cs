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
        public static int NarratorId = 10;
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
        public const int ConvId_DerdiaInvestigation = 10001;
        public const int ConvId_DerdiaStateVisit = 10002;
        public const int ConvId_Op1AftermathCouncil = 10003;
        public const int ConvId_ExileEpilogue = 10004;
        public const int ConvId_SovereigntyDeclaration = 10005;

        private static bool _conversationsRegistered = false;

        public static void EnsureAllConversationsRegistered()
        {
            try
            {
                var db = DialogueManager.masterDatabase;
                if (db == null) return;

                try
                {
                    var narr = db.GetActor("Narrator");
                    if (narr == null && db.actors != null)
                    {
                        for (int i = 0; i < db.actors.Count; i++)
                        {
                            var a = db.actors[i];
                            if (a != null && a.Name != null && a.Name.IndexOf("Narrator", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                narr = a;
                                break;
                            }
                        }
                    }
                    if (narr != null && narr.id > 0) NarratorId = narr.id;
                }
                catch { }

                if (db.GetConversation("Turn_Zille_WarPlanning") != null &&
                    db.GetConversation("Turn_Zille_WarBriefing") != null &&
                    db.GetConversation("Turn_Zille_WarBalconySpeech") != null &&
                    db.GetConversation("Turn_Zille_MaveNortusHQ") != null &&
                    db.GetConversation("Turn_Zille_Op1AftermathCouncil") != null &&
                    db.GetConversation("Turn_Zille_DerdiaTalks") != null &&
                    db.GetConversation("Turn_Zille_DerdiaInvestigation") != null &&
                    db.GetConversation("Turn_Zille_DerdiaStateVisit") != null &&
                    db.GetConversation("Turn_Zille_LespiaTalks") != null &&
                    db.GetConversation("Turn_Zille_RumburgTalks") != null &&
                    db.GetConversation("Turn_Zille_WarLogisticsDispute") != null &&
                    db.GetConversation("Turn_Zille_WarPreNegotiationsBriefing") != null &&
                    db.GetConversation("Turn_Zille_WarSmolakFinalParley") != null &&
                    db.GetConversation("Turn_Zille_WarPeaceTreaty") != null &&
                    db.GetConversation("Turn_Zille_HomeFrontCrisis") != null &&
                    db.GetConversation("Turn_Zille_ZilleLiberation") != null &&
                    db.GetConversation("Turn_Zille_ExileEpilogue") != null &&
                    db.GetConversation("Turn_Zille_SovereigntyDeclaration") != null)
                {
                    return;
                }

                MelonLogger.Msg("[ZILLE DIALOGUE] Registering all 18 Great Zille narrative scenes into masterDatabase...");

                RegisterWarPlanning(db);
                RegisterWarLogisticsDispute(db);
                RegisterWarCouncilBriefing(db);
                RegisterWarBalconySpeech(db);
                RegisterMaveNortusHQ(db);
                RegisterOp1AftermathCouncil(db);
                RegisterDerdiaInvestigation(db);
                RegisterDerdiaTalks(db);
                RegisterDerdiaStateVisit(db);
                RegisterLespiaTalks(db);
                RegisterRumburgTalks(db);
                RegisterWarPreNegotiationsBriefing(db);
                RegisterWarSmolakFinalParley(db);
                RegisterWarPeaceTreaty(db);
                RegisterHomeFrontCrisis(db);
                RegisterZilleLiberation(db);
                RegisterExileEpilogue(db);
                RegisterSovereigntyDeclaration(db);

                _conversationsRegistered = true;
                DialogueOverrideManager.ApplyAllOverrides();
                MelonLogger.Msg("[ZILLE DIALOGUE] All 18 custom scenes successfully registered into masterDatabase!");
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
                    // 5B. Turn 4 Alliance of Nations South Merkopa Session (FPnT_ANSouthMerkopa)
                    else if (conv.Title.IndexOf("FPnT_ANSouthMerkopa", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn4ANSpeechChoices(conv, db)) patchedCount++;
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
                    else if (conv.Title.IndexOf("FPnT_ZilleNegotiations", StringComparison.OrdinalIgnoreCase) >= 0
                          || conv.Title.IndexOf("ZilleNegotiations", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn8ZilleNegotiationsWarChoice(conv, db)) patchedCount++;
                    }
                    // 8B. Turn 5 Bilateral Wehlen Negotiations (FPnT_WehlenNegotiations) [INTERRUPT] when war active/done
                    else if (conv.Title.IndexOf("FPnT_WehlenNegotiations", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectWehlenWarSupersedesInterrupt(conv, db, "Zille_Turn5_WehlenNeg_Interrupt", 99301,
                            "\"[DISPATCH] With Rizian and Wehzek forces already bound by open conflict and the Crown's war footing over Zille, President Smolak's scheduled bilateral trade delegation to Porte Drazon has been formally canceled.\"",
                            "There is nothing left to haggle over with Wraclawitz while steel speaks on the frontier.")) patchedCount++;
                    }
                    // 8C. Turn 5 MITZ Hegel Call (FPnT_MITZHegelCall) [FLAVOR INJECT]
                    else if (conv.Title.IndexOf("FPnT_MITZHegelCall", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn5HegelZilleWarFlavor(conv, db)) patchedCount++;
                    }
                    // 8D. Turn 7 Zille Treaty Discussion (Zille_Treaty_Discussion) [INTERRUPT] when war active/done
                    else if (conv.Title.IndexOf("Zille_Treaty_Discussion", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectWehlenWarSupersedesInterrupt(conv, db, "Zille_Turn7_TreatyDisc_Interrupt", 99311,
                            "\"[COUNCIL BRIEF] Because the Crown has already pursued the reclamation of Zille by arms, the pre-war treaty negotiation agenda has been superseded by our active military command and post-war settlement protocols.\"",
                            "Good. Keep the Council focused on the reality at the frontier, not obsolete diplomatic drafts.")) patchedCount++;
                    }
                    // 8E. Turn 8 AN General Assembly (FPnT_ANSession) [FLAVOR INJECT]
                    else if (conv.Title.IndexOf("FPnT_ANSession", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn8ANSessionZilleWarFlavor(conv, db)) patchedCount++;
                    }
                    // 8F. Turn 9 Casual Call With Smolak (FPnT_CallWithSmolak) [INTERRUPT] when war active/done
                    else if (conv.Title.IndexOf("FPnT_CallWithSmolak", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectWehlenWarSupersedesInterrupt(conv, db, "Zille_Turn9_SmolakCall_Interrupt", 99321,
                            "\"[TELEGRAPH DISPATCH] Diplomatic trunk lines between Monqiz and Wraclawitz remain severed following the Zille war. Any communication with President Smolak proceeds strictly through formal military parley channels.\"",
                            "As expected. Smolak's evening pleasantries ended the day our divisions crossed the border.")) patchedCount++;
                    }
                    // 8G. Turn 9 Wehlen-Derdia Mediation (Wehlen_Derdia_Meditation) [INTERRUPT] when war active/done
                    else if (conv.Title.IndexOf("Wehlen_Derdia_Meditation", StringComparison.OrdinalIgnoreCase) >= 0
                          || conv.Title.IndexOf("Wehlen_Derdia_Mediation", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectWehlenWarSupersedesInterrupt(conv, db, "Zille_Turn9_WehlenDerdiaMed_Interrupt", 99331,
                            "\"[DISPATCH] With Rizia having engaged Wehlen in open war over Zille, Wraclawitz has withdrawn its request for Rizian arbitration with Derdia. Naeal and Porte Drazon now speak directly as sovereign neighbors.\"",
                            "Smolak never sought honest mediation anyway. Let Derdia know Rizia stands by its word.")) patchedCount++;
                    }
                    // 9. Turn 9 Zille Referendum & Handback [INTERRUPT] guards when military campaign supersedes diplomacy
                    else if (conv.Title.IndexOf("ZilleReferendum", StringComparison.OrdinalIgnoreCase) >= 0
                          || conv.Title.IndexOf("ZilleHandback", StringComparison.OrdinalIgnoreCase) >= 0
                          || conv.Title.IndexOf("ZilleReturnedSpeech", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectZilleReferendumWarInterrupt(conv, db)) patchedCount++;
                    }
                    // 9B. Turn 10 Queen Mother Estela's Birthday Gathering (Birthday_Gathering) [FLAVOR INJECT]
                    else if (conv.Title.IndexOf("Birthday_Gathering", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn10BirthdayZilleWarFlavor(conv, db)) patchedCount++;
                    }
                    // 9C. Turn 11 Ending Speech (Ending_Speech) [FLAVOR INJECT]
                    else if (conv.Title.IndexOf("Ending_Speech", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectTurn11EndingSpeechZilleWarFlavor(conv, db)) patchedCount++;
                    }
                    // 10. Vanilla Exile Epilogue (426_Exile / Exile): Zille Azaro Collapse Branch
                    else if ((conv.Title.IndexOf("426_Exile", StringComparison.OrdinalIgnoreCase) >= 0
                              || (conv.Title.IndexOf("Exile", StringComparison.OrdinalIgnoreCase) >= 0
                                  && conv.Title.IndexOf("EarlyExile", StringComparison.OrdinalIgnoreCase) < 0))
                          && conv.Title.IndexOf("Zille/", StringComparison.OrdinalIgnoreCase) < 0
                          && conv.Title.IndexOf("Turn_Zille_", StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        if (InjectVanillaExileCollapseBranch(conv, db)) patchedCount++;
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
            int replyRichId = 99102;
            int replyTightId = 99103;

            var choice = CreateEntry(conv.id, choiceId, RomusId, HugoId, "Zille_Turn1_Council_Choice",
                "Zille must return to our kingdom when the 1927 agreement expires. I expect the Council to prepare for any contingency-including force if Smolak reneges.",
                "\"Zille must return to our kingdom when the 1927 agreement expires. I expect the Council to prepare for any contingency-including force if Smolak reneges.\"");
            SetEntryScript(choice, "Variable[\"Zille_Military_Posture\"] = 1; Variable[\"Zille_MilitarySentiment\"] = 1; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            var replyRich = CreateEntry(conv.id, replyRichId, HugoId, RomusId, "Hugo_Turn1_Zille_Response_Funded",
                "\"A resolute sentiment, Your Majesty,\" Hugo inclined his head slowly. \"With our treasury presently holding healthy reserves, discreet contingency planning will not alarm the markets—though taking Zille by the sword would still invite AN outcry.\"");
            SetEntryCondition(replyRich, "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) >= 4");

            var replyTight = CreateEntry(conv.id, replyTightId, HugoId, RomusId, "Hugo_Turn1_Zille_Response_Tight",
                "\"A resolute sentiment, Your Majesty,\" Hugo inclined his head with a worried crease above his brow. \"Yet with our royal coffers already strained, mobilizing for war would demand ruthless fiscal discipline before a single shot is fired.\"");
            SetEntryCondition(replyTight, "(Variable[\"RiziaDLC.Resources_Budget\"] or 0) < 4");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyRichId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyTightId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyRich.outgoingLinks.Add(CreateLink(conv.id, replyRichId, nextId));
                replyTight.outgoingLinks.Add(CreateLink(conv.id, replyTightId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyRich);
            conv.dialogueEntries.Add(replyTight);
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
            int replyArmedId = 99112;
            int replyLowId = 99113;

            var choice = CreateEntry(conv.id, choiceId, RomusId, LucitaId, "Zille_Turn1_Lucita_BorderChoice",
                "Councilor Azaro, review our garrisons along the Brenas frontier and audit our armories. If diplomacy fails, the army must be ready to march on Zille.",
                "\"Councilor Azaro, review our garrisons along the Brenas frontier and audit our armories. If diplomacy fails, the army must be ready to march on Zille.\"");
            SetEntryScript(choice, "Variable[\"Zille_StaffPlanning_Started\"] = true; Variable[\"Zille_MilitarySentiment\"] = 2; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            var replyArmed = CreateEntry(conv.id, replyArmedId, LucitaId, RomusId, "Lucita_Turn1_Border_Armed",
                "\"Understood, Your Majesty!\" Lucita's eyes flashed with fierce enthusiasm. \"With over a thousand reserve weapons already stacked in the royal arsenals, House Azaro can begin covert topographical surveys of the Brenas-Zille frontier and Wehzek positions immediately.\"");
            SetEntryCondition(replyArmed, "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000");
            SetEntryScript(replyArmed, "Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            var replyLow = CreateEntry(conv.id, replyLowId, LucitaId, RomusId, "Lucita_Turn1_Border_LowEquip",
                "\"At once, Your Majesty,\" Lucita saluted, though her jaw tightened. \"We will map the Brenas-Zille approaches quietly, yet I must be candid: our depots hold under a thousand reserve rifles. Without serious arms procurement or domestic factories, our brigades cannot sustain an offensive.\"");
            SetEntryCondition(replyLow, "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyArmedId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyLowId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyArmed.outgoingLinks.Add(CreateLink(conv.id, replyArmedId, nextId));
                replyLow.outgoingLinks.Add(CreateLink(conv.id, replyLowId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyArmed);
            conv.dialogueEntries.Add(replyLow);
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
                "Smolak should be reminded that the 1927 agreement has an expiration date, not a renegotiation clause. Rizia will assert her lawful sovereignty.",
                "\"Smolak should be reminded that the 1927 agreement has an expiration date, not a renegotiation clause. Rizia will assert her lawful sovereignty.\"");
            SetEntryScript(choice, "Variable[\"Zille_Diplomatic_Firmness\"] = 2; Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 2; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            var reply = CreateEntry(conv.id, replyId, LaurentoId, RomusId, "Laurento_Turn2_Ultimatum_Response",
                "\"A legally unassailable posture, Your Majesty. Putting the 1927 expiration clauses on the official diplomatic record strengthens our standing before the Alliance of Nations in Konstantium, Kyrute.\"");

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
            int replyStrongId = 99132;
            int replyWeakId = 99133;

            var choice = CreateEntry(conv.id, choiceId, RomusId, SmolakId, "Zille_Turn2_Smolak_Confrontation",
                "Enjoy your parade, President Smolak. When the 1927 agreement expires, Rizian flags will fly above this city-one way or another.",
                "\"Enjoy your parade, President Smolak. When the 1927 agreement expires, Rizian flags will fly above this city-one way or another.\"");
            SetEntryScript(choice, "Variable[\"Smolak_Zille_Threatened\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;");

            var replyStrong = CreateEntry(conv.id, replyStrongId, SmolakId, RomusId, "Smolak_Turn2_Confrontation_Strong",
                "Smolak's smile twitched as his gaze flicked to the Golden Guard escorting you. \"Careful, King Romus. I hear your arsenals are filling up in Porte Drazon—but taking these coastal hills against dug-in veterans would still cost you dearly.\"");
            SetEntryCondition(replyStrong, "Variable[\"RiziaDLC.Situation_Diplomacy_PowerProjection_Strong\"] == true or Variable[\"RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming\"] == true or (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000");
            SetEntryScript(replyStrong, "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            var replyWeak = CreateEntry(conv.id, replyWeakId, SmolakId, RomusId, "Smolak_Turn2_Confrontation_Weak",
                "Smolak let out a barking, mocking laugh. \"Bold words from a monarch whose warehouses can barely equip a parade! Before threatening Wehlen, Romus, count how many rifles you actually have in Porte Drazon!\"");
            SetEntryCondition(replyWeak, "Variable[\"RiziaDLC.Situation_Diplomacy_PowerProjection_Strong\"] ~= true and Variable[\"RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming\"] ~= true and (Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyStrongId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyWeakId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyStrong.outgoingLinks.Add(CreateLink(conv.id, replyStrongId, nextId));
                replyWeak.outgoingLinks.Add(CreateLink(conv.id, replyWeakId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyStrong);
            conv.dialogueEntries.Add(replyWeak);
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
            int replyLucitaId = 99142;
            int replyTitusId = 99143;

            var choice = CreateEntry(conv.id, choiceId, RomusId, LucitaId, "Zille_Turn3_Bombing_WarOption",
                "This bombing is a blatant provocation by Wehlen. Order the Third and Fourth Corps to advance across the border immediately!",
                "\"This bombing is a blatant Wehzek provocation! Order our divisions to cross the border and reclaim Zille immediately!\"");
            SetEntryScript(choice, "Variable[\"Zille_War_EarlyLaunch\"] = true; Variable[\"Zille_War_Variant\"] = \"Early\"; Variable[\"Zille_War_IsEarly\"] = true; Variable[\"Zille_War_IsLate\"] = false; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1;");

            var replyLucita = CreateEntry(conv.id, replyLucitaId, LucitaId, RomusId, "Lucita_Turn3_EarlyWar_Response",
                "\"Your Majesty, launching an unprepared offensive right now—before securing fuel corridors, munitions, and diplomatic cover—would invite slaughter against Wehlen's coastal redoubts! Let us prepare properly first.\"");
            SetEntryCondition(replyLucita, "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            var replyTitus = CreateEntry(conv.id, replyTitusId, TitusId, RomusId, "Titus_Turn3_EarlyWar_Response",
                "\"Your Majesty, with all due duty—marching across the frontier before the General Staff completes supply staging and arsenal readiness would waste our men in uncoordinated assaults.\"");
            SetEntryCondition(replyTitus, "Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyLucitaId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyTitusId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyLucita.outgoingLinks.Add(CreateLink(conv.id, replyLucitaId, nextId));
                replyTitus.outgoingLinks.Add(CreateLink(conv.id, replyTitusId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyLucita);
            conv.dialogueEntries.Add(replyTitus);

            // Also inject Turn 3 Derdia-Wehlen border sabotage signal inquiry
            int derdiaChoiceId = 99144;
            int derdiaReplyTitusId = 99145;
            int derdiaReplyCarlosId = 99146;

            var derdiaChoice = CreateEntry(conv.id, derdiaChoiceId, RomusId, TitusId, "Zille_Turn3_DerdiaSabotageSignal",
                "\"Before we react only to Zille—what were those explosions reported along the Derdia-Wehlen frontier near Yol last night?\"",
                "\"Before we react only to Zille—what were those mysterious explosions reported along the Derdia-Wehlen border near Yol last night?\"");
            SetEntryScript(derdiaChoice, "Variable[\"Zille_Derdia_SabotageSignals\"] = true;");

            var derdiaReplyTitus = CreateEntry(conv.id, derdiaReplyTitusId, TitusId, RomusId, "Titus_Turn3_DerdiaSabotage_Reply",
                "\"A curious coincidence, Your Majesty,\" Titus answered grimly. \"While Zille burned, saboteurs struck a Derdian pipeline pumping station and Silver Garrison supply dumps near Yol and Qerzan. Wraclawitz blames BFF smugglers, yet the timing smells of Wehzek diversion. Our agents can investigate properly next turn.\"");
            SetEntryCondition(derdiaReplyTitus, "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            var derdiaReplyCarlos = CreateEntry(conv.id, derdiaReplyCarlosId, CarlosId, RomusId, "Carlos_Turn3_DerdiaSabotage_Reply",
                "\"Military dispatches noted twin explosions along the Yol-Qerzan passes last night, Your Majesty—targeting Derdian pipeline pumps and Silver Garrison depots. Smolak blames smugglers, though our intelligence officers suspect Wehzek saboteurs.\"");
            SetEntryCondition(derdiaReplyCarlos, "Variable[\"RiziaDLC.Titus_Arrested\"] == true or Variable[\"RiziaDLC.Titus_Executed\"] == true");

            derdiaChoice.outgoingLinks.Add(CreateLink(conv.id, derdiaChoiceId, derdiaReplyTitusId));
            derdiaChoice.outgoingLinks.Add(CreateLink(conv.id, derdiaChoiceId, derdiaReplyCarlosId));
            if (nextId >= 0)
            {
                derdiaReplyTitus.outgoingLinks.Add(CreateLink(conv.id, derdiaReplyTitusId, nextId));
                derdiaReplyCarlos.outgoingLinks.Add(CreateLink(conv.id, derdiaReplyCarlosId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, derdiaChoiceId));
            conv.dialogueEntries.Add(derdiaChoice);
            conv.dialogueEntries.Add(derdiaReplyTitus);
            conv.dialogueEntries.Add(derdiaReplyCarlos);

            // Turn 3 Aggressive Posture 1: Vehemently refuse any apologies / denounce Smolak's accusations
            int noApolChoiceId = 99147;
            int noApolReplyLucitaId = 99148;
            int noApolReplyHugoId = 99149;

            var noApolChoice = CreateEntry(conv.id, noApolChoiceId, RomusId, LucitaId, "Zille_Turn3_NoApologies_Choice",
                "Under no circumstances will Rizia apologize to Wiktor Smolak! His accusations are grotesque lies.",
                "\"Under no circumstances will Rizia apologize to Wiktor Smolak! His accusations are grotesque lies, and yielding an inch invites further Wehzek insolence.\"");
            SetEntryScript(noApolChoice, "Variable[\"Zille_Turn3_RefuseApologies\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1; Variable[\"RiziaDLC.HouseAzaro_Opinion\"] = (Variable[\"RiziaDLC.HouseAzaro_Opinion\"] or 0) + 1; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            var noApolReplyLucita = CreateEntry(conv.id, noApolReplyLucitaId, LucitaId, RomusId, "Lucita_Turn3_NoApologies_Reply",
                "\"Well spoken, Your Majesty. If we grovel before Smolak's insults, he will only smell fear and demand more concessions before 1955. House Azaro stands with you.\"");
            SetEntryCondition(noApolReplyLucita, "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            var noApolReplyHugo = CreateEntry(conv.id, noApolReplyHugoId, HugoId, RomusId, "Hugo_Turn3_NoApologies_Reply",
                "\"I only caution that hot blood must not blind us to the risks, Your Majesty. Wehlen controls the border checkpoints today; pride will not shield our merchants from reprisal.\"");
            SetEntryCondition(noApolReplyHugo, "Variable[\"RiziaDLC.Lucita_Arrested\"] == true or Variable[\"RiziaDLC.Lucita_Executed\"] == true");

            noApolChoice.outgoingLinks.Add(CreateLink(conv.id, noApolChoiceId, noApolReplyLucitaId));
            noApolChoice.outgoingLinks.Add(CreateLink(conv.id, noApolChoiceId, noApolReplyHugoId));
            if (nextId >= 0)
            {
                noApolReplyLucita.outgoingLinks.Add(CreateLink(conv.id, noApolReplyLucitaId, nextId));
                noApolReplyHugo.outgoingLinks.Add(CreateLink(conv.id, noApolReplyHugoId, nextId));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, noApolChoiceId));
            conv.dialogueEntries.Add(noApolChoice);
            conv.dialogueEntries.Add(noApolReplyLucita);
            conv.dialogueEntries.Add(noApolReplyHugo);

            // Turn 3 Aggressive Posture 2: Valero Pact Non-Negotiable Ultimatum
            int valeroChoiceId = 99150;
            int valeroReplyLucitaId = 99151;
            int valeroReplyHugoId = 99152;

            var valeroChoice = CreateEntry(conv.id, valeroChoiceId, RomusId, LucitaId, "Zille_Turn3_ValeroUltimatum_Choice",
                "The Valero treaty is non-negotiable. If Wehlen refuses to prepare the handover, their soldiers will be treated as illegal occupiers.",
                "\"The Valero treaty is non-negotiable. If Wehlen refuses to prepare the handover of Zille, Smolak's soldiers will be treated as an illegal hostile occupation.\"");
            SetEntryScript(valeroChoice, "Variable[\"Zille_Turn3_ValeroUltimatum\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1; Variable[\"Zille_War_EarlyLaunch\"] = true; Variable[\"Zille_War_Variant\"] = \"Early\"; Variable[\"Zille_War_IsEarly\"] = true; Variable[\"Zille_War_IsLate\"] = false; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"RiziaDLC.Diplomacy_Wehlen_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Wehlen_NegotiatingPower\"] or 0) - 1;");

            var valeroReplyLucita = CreateEntry(conv.id, valeroReplyLucitaId, LucitaId, RomusId, "Lucita_Turn3_ValeroUltimatum_Reply",
                "\"That is the iron language Smolak understands, Your Majesty. If the General Staff begins strategic reconnaissance along the border ridges now, Wehlen will realize their lease is running out in blood if not in ink.\"");
            SetEntryCondition(valeroReplyLucita, "Variable[\"RiziaDLC.Lucita_Arrested\"] ~= true and Variable[\"RiziaDLC.Lucita_Executed\"] ~= true");

            var valeroReplyHugo = CreateEntry(conv.id, valeroReplyHugoId, HugoId, RomusId, "Hugo_Turn3_ValeroUltimatum_Reply",
                "\"Sweet Drezet... Such rhetoric borders on an ultimatum of war! If foreign ambassadors hear of this, Smolak will claim Rizia is sabotaging the peace before the AN!\"");

            valeroChoice.outgoingLinks.Add(CreateLink(conv.id, valeroChoiceId, valeroReplyLucitaId));
            valeroChoice.outgoingLinks.Add(CreateLink(conv.id, valeroChoiceId, valeroReplyHugoId));
            if (nextId >= 0)
            {
                valeroReplyLucita.outgoingLinks.Add(CreateLink(conv.id, valeroReplyLucitaId, nextId));
                valeroReplyHugo.outgoingLinks.Add(CreateLink(conv.id, valeroReplyHugoId, nextId));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, valeroChoiceId));
            conv.dialogueEntries.Add(valeroChoice);
            conv.dialogueEntries.Add(valeroReplyLucita);
            conv.dialogueEntries.Add(valeroReplyHugo);

            // Turn 3 Aggressive Posture 3: Demand Armed Royal Commission into Zille
            int commChoiceId = 99153;
            int commReplyTitusId = 99154;
            int commReplyLucitaId = 99155;

            var commChoice = CreateEntry(conv.id, commChoiceId, RomusId, TitusId, "Zille_Turn3_DemandArmedCommission_Choice",
                "We demand an armed Rizian royal commission be permitted into Zille to inspect the blast site immediately.",
                "\"We will not let Wehzek butcher-police control the narrative. We demand an armed Rizian royal commission be permitted into Zille to inspect the blast site immediately.\"");
            SetEntryScript(commChoice, "Variable[\"Zille_Turn3_ArmedCommissionDemanded\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1;");

            var commReplyTitus = CreateEntry(conv.id, commReplyTitusId, TitusId, RomusId, "Titus_Turn3_ArmedCommission_Reply",
                "\"The Golden Guard is ready to deploy an armed detachment to the blast epicenter within hours, Your Majesty. We will not allow Wehzek agents to tamper with physical evidence or plant false leads.\"");
            SetEntryCondition(commReplyTitus, "Variable[\"RiziaDLC.Titus_Arrested\"] ~= true and Variable[\"RiziaDLC.Titus_Executed\"] ~= true");

            var commReplyLucita = CreateEntry(conv.id, commReplyLucitaId, LucitaId, RomusId, "Lucita_Turn3_ArmedCommission_Reply",
                "\"A bold demand, Your Majesty. Smolak will either refuse and expose his guilt to the world, or yield and let our investigators uncover the truth.\"");

            commChoice.outgoingLinks.Add(CreateLink(conv.id, commChoiceId, commReplyTitusId));
            commChoice.outgoingLinks.Add(CreateLink(conv.id, commChoiceId, commReplyLucitaId));
            if (nextId >= 0)
            {
                commReplyTitus.outgoingLinks.Add(CreateLink(conv.id, commReplyTitusId, nextId));
                commReplyLucita.outgoingLinks.Add(CreateLink(conv.id, commReplyLucitaId, nextId));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, commChoiceId));
            conv.dialogueEntries.Add(commChoice);
            conv.dialogueEntries.Add(commReplyTitus);
            conv.dialogueEntries.Add(commReplyLucita);

            return true;
        }

        private static bool InjectTurn4ANSpeechChoices(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn4_AN_AggressiveUltimatum") return true;
            }

            // Find hub where Romus addresses the assembly regarding Zille & Smolak (vanilla entry 326 or similar)
            DialogueEntry parent = null;
            bool has428 = false;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e == null) continue;
                if (e.id == 428) has428 = true;
                if (parent == null && (e.id == 326 || (e.ActorID == RomusId && ((e.Title != null && e.Title.Contains("bombing")) || (e.DialogueText != null && e.DialogueText.Contains("bombing"))))))
                {
                    parent = e;
                }
            }
            if (parent == null) parent = FindSuitableHub(conv, "bombing", "tragedy", "Wehlen", "Smolak");
            if (parent == null) return false;

            int targetNextId = has428 ? 428 : FindConvergenceTarget(conv, parent);

            // Option 1: Aggressive Ultimatum & Denunciation of Smolak's Terror
            int ultChoiceId = 99201;
            int ultReplyNarrId = 99202;

            var ultChoice = CreateEntry(conv.id, ultChoiceId, RomusId, NarratorId, "Zille_Turn4_AN_AggressiveUltimatum",
                "President Smolak has orchestrated a terror campaign on our doorstep to extort Rizia! Rizia will reclaim Zille, and no bomb will stay our hand.",
                "\"President Smolak has orchestrated a terror campaign on our doorstep to extort Rizia and deny us what is lawfully ours under the 1927 Pact! Let this Assembly hear me clearly: Rizia will reclaim Zille, and no dictator's bomb will stay our hand.\"");
            SetEntryScript(ultChoice, "Variable[\"Zille_AN_AggressiveUltimatum\"] = true; Variable[\"RiziaDLC.Diplomacy_Wehlen_ANSpeech_Aggression\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"RiziaDLC.Resources_Authority\"] = (Variable[\"RiziaDLC.Resources_Authority\"] or 0) + 1; Variable[\"RiziaDLC.Country_PublicOpinion\"] = (Variable[\"RiziaDLC.Country_PublicOpinion\"] or 0) + 1; Variable[\"RiziaDLC.Diplomacy_Wehlen_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Wehlen_NegotiatingPower\"] or 0) - 2;");

            var ultReplyNarr = CreateEntry(conv.id, ultReplyNarrId, NarratorId, RomusId, "Narrator_Turn4_AN_UltimatumReaction",
                "A stunned silence fell upon the great hall in Kyrute. Delegates from Arcasia and Contana exchanged sharp glances, while Wiktor Smolak's smile twisted into a venomous scowl. President Ephraim Nines rapped his gavel twice, calling for order amidst a crescendo of murmurs.");

            ultChoice.outgoingLinks.Add(CreateLink(conv.id, ultChoiceId, ultReplyNarrId));
            if (targetNextId >= 0)
            {
                ultReplyNarr.outgoingLinks.Add(CreateLink(conv.id, ultReplyNarrId, targetNextId));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, ultChoiceId));
            conv.dialogueEntries.Add(ultChoice);
            conv.dialogueEntries.Add(ultReplyNarr);

            // Option 2: International Notice of Automatic Sovereignty Reversion
            int noticeChoiceId = 99203;
            int noticeReplyNarrId = 99204;

            var noticeChoice = CreateEntry(conv.id, noticeChoiceId, RomusId, NarratorId, "Zille_Turn4_AN_ValeroNotice",
                "I officially place this Assembly on notice: when the 1927 pact expires, any Wehzek soldiers remaining in Zille will be an illegal foreign occupation.",
                "\"I officially place the Alliance of Nations on notice: when the 1927 Valero treaty expires, Rizian sovereignty resumes automatically. Any Wehzek armed presence beyond that date will be classified as a foreign military occupation, and met accordingly.\"");
            SetEntryScript(noticeChoice, "Variable[\"Zille_AN_ValeroNotice\"] = true; Variable[\"RiziaDLC.Diplomacy_Wehlen_ANSpeech_Aggression\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 1; Variable[\"Zille_War_EarlyLaunch\"] = true; Variable[\"Zille_War_Variant\"] = \"Early\"; Variable[\"Zille_War_IsEarly\"] = true; Variable[\"Zille_War_IsLate\"] = false; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"RiziaDLC.Diplomacy_Wehlen_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Wehlen_NegotiatingPower\"] or 0) - 1;");

            var noticeReplyNarr = CreateEntry(conv.id, noticeReplyNarrId, NarratorId, RomusId, "Narrator_Turn4_AN_NoticeReaction",
                "Chancellor Hegel tilted his head, watching with keen amusement, while Patricio Alvarez scowled openly. The legal gauntlet had been thrown before the eyes of the international community.");

            noticeChoice.outgoingLinks.Add(CreateLink(conv.id, noticeChoiceId, noticeReplyNarrId));
            if (targetNextId >= 0)
            {
                noticeReplyNarr.outgoingLinks.Add(CreateLink(conv.id, noticeReplyNarrId, targetNextId));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, noticeChoiceId));
            conv.dialogueEntries.Add(noticeChoice);
            conv.dialogueEntries.Add(noticeReplyNarr);

            // Option 3: Expose Yol Sabotage and Wraclawitz False Flags
            int sabChoiceId = 99205;
            int sabReplyNarrId = 99206;

            var sabChoice = CreateEntry(conv.id, sabChoiceId, RomusId, NarratorId, "Zille_Turn4_AN_ExposeBorderSabotage",
                "What of the coordinated pipeline bombings near Yol? We have intelligence of false flag operations staged by Wehzek intelligence!",
                "\"And while President Smolak points fingers across the sea, what of the coordinated pipeline bombings on the Derdia-Wehlen border near Yol? We have intelligence of false flag operations staged by Wraclawitz. We will not be blackmailed by state terror!\"");
            SetEntryCondition(sabChoice, "Variable[\"Zille_Derdia_SabotageSignals\"] == true or Variable[\"Zille_Derdia_SabotageEvidence\"] == true");
            SetEntryScript(sabChoice, "Variable[\"Zille_AN_ExposeBorderSabotage\"] = true; Variable[\"RiziaDLC.Diplomacy_Wehlen_ANSpeech_Aggression\"] = true; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2; Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] = (Variable[\"RiziaDLC.Diplomacy_Derdia_NegotiatingPower\"] or 0) + 1;");

            var sabReplyNarr = CreateEntry(conv.id, sabReplyNarrId, NarratorId, RomusId, "Narrator_Turn4_AN_SabotageReaction",
                "Supreme Wiseman Jorga Azmal nodded vigorously in the gallery, his acolytes whispering loudly. Smolak gripped his armrest, visibly caught off guard by the public revelation of the Yol explosions.");

            sabChoice.outgoingLinks.Add(CreateLink(conv.id, sabChoiceId, sabReplyNarrId));
            if (targetNextId >= 0)
            {
                sabReplyNarr.outgoingLinks.Add(CreateLink(conv.id, sabReplyNarrId, targetNextId));
            }
            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, sabChoiceId));
            conv.dialogueEntries.Add(sabChoice);
            conv.dialogueEntries.Add(sabReplyNarr);

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
            int replyNormalId = 99152;
            int replyBlackmailId = 99153;

            var choice = CreateEntry(conv.id, choiceId, RomusId, AlvarezId, "Zille_Turn4_Alvarez_AntiSmolakChoice",
                "Patricio, Wehlen is a rogue regime threatening regional commerce. If Rizia must take action in Zille, can we count on Lespian intelligence?",
                "\"Patricio, Wehlen is a rogue regime threatening regional commerce. If Rizia must take action in Zille, can we count on Lespian intelligence?\"");
            SetEntryScript(choice, "Variable[\"Lespia_Zille_Intelligence_Asked\"] = true; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            var replyNormal = CreateEntry(conv.id, replyNormalId, AlvarezId, RomusId, "Alvarez_Turn4_AntiSmolak_Response",
                "Alvarez chuckled over the static of the line. \"Smolak is a nuisance, Romus, but intelligence isn't free. Help Lespia in the MITZ talks, and maybe our reconnaissance planes will happen to photograph Wehlen's bunker network for you.\"");
            SetEntryCondition(replyNormal, "Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] ~= true and Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] ~= true");

            var replyBlackmail = CreateEntry(conv.id, replyBlackmailId, AlvarezId, RomusId, "Alvarez_Turn4_Blackmail_Response",
                "Alvarez went quiet for a beat before clearing his throat. \"Ah... considering the delicate intelligence files resting in your Golden Guard's safe regarding Zille, Romus, I suppose Lespian reconnaissance could look the other way and share Wehlen's coordinates.\"");
            SetEntryCondition(replyBlackmail, "Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement\"] == true or Variable[\"RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty\"] == true");
            SetEntryScript(replyBlackmail, "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 2; Variable[\"Zille_Lespia_Intel\"] = true;");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyNormalId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyBlackmailId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyNormal.outgoingLinks.Add(CreateLink(conv.id, replyNormalId, nextId));
                replyBlackmail.outgoingLinks.Add(CreateLink(conv.id, replyBlackmailId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyNormal);
            conv.dialogueEntries.Add(replyBlackmail);
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
            int replyLowId = 99162;
            int replyReadyId = 99163;

            var choice = CreateEntry(conv.id, choiceId, RomusId, ElenaId, "Zille_Turn4_Council_TwoFrontWarning",
                "We must audit our reserves carefully before escalating in Pales. Zille remains our sovereign territory, and Smolak will exploit any overextension.",
                "\"We must audit our reserves carefully before escalating in Pales. Zille remains our sovereign territory, and Smolak will exploit any overextension.\"");
            SetEntryScript(choice, "Variable[\"Zille_Priority_Over_Pales\"] = true; Variable[\"Zille_War_Readiness\"] = (Variable[\"Zille_War_Readiness\"] or 0) + 1;");

            var replyLow = CreateEntry(conv.id, replyLowId, ElenaId, RomusId, "Elena_Turn4_TwoFront_LowStock",
                "\"In Saint Wruhec's name, Your Majesty, you are entirely right! With fewer than a thousand reserve arms or thin energy cushions, fighting on both Pales' eastern frontier and Zille would drain our exchequer and stall every tank.\"");
            SetEntryCondition(replyLow, "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000 or (Variable[\"RiziaDLC.Resources_Energy\"] or 0) <= 3");

            var replyReady = CreateEntry(conv.id, replyReadyId, ElenaId, RomusId, "Elena_Turn4_TwoFront_Equipped",
                "\"A sound check, Your Majesty. Even though our warehouses hold over a thousand weapons and adequate energy for one campaign, splitting divisions between Pales and Zille would still double our wartime budget burn.\"");
            SetEntryCondition(replyReady, "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 and (Variable[\"RiziaDLC.Resources_Energy\"] or 0) > 3");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyLowId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyReadyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyLow.outgoingLinks.Add(CreateLink(conv.id, replyLowId, nextId));
                replyReady.outgoingLinks.Add(CreateLink(conv.id, replyReadyId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyLow);
            conv.dialogueEntries.Add(replyReady);
            return true;
        }

        private static bool InjectTurn8ZilleNegotiationsWarChoice(Conversation conv, DialogueDatabase db)
        {
            // First, insert a root [INTERRUPT] so peaceful Turn 8 airship negotiations with Smolak
            // NEVER run if the Early War is active or has already concluded!
            InjectWehlenWarSupersedesInterrupt(conv, db, "Zille_Turn8_Negotiations_Interrupt", 99178,
                "\"[DISPATCH] With the question of Zille already decided by armed conflict and the Crown's war settlement, President Smolak's scheduled Turn 8 airship summit has been formally voided.\"",
                "History moved past Smolak's airship bargaining the day our banners crossed the frontier.");

            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn8_War_Ultimatum") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "referendum", "discuss", "Smolak", "outcome");
            if (parent == null) parent = FindSuitableHub(conv, "Smolak", "Zille", "deal");
            if (parent == null) return false;

            int choiceId = 99171;
            int replyLeverId = 99172;
            int replyBluffId = 99173;

            var choice = CreateEntry(conv.id, choiceId, RomusId, SmolakId, "Zille_Turn8_War_Ultimatum",
                "Enough of your extortion, Smolak! The 1927 agreement expired years ago. Order your troops to vacate Zille immediately, or the Royal Army will reclaim our sovereign land by force!",
                "\"Enough of your extortion, Smolak! The 1927 agreement expired years ago. Order your troops to vacate Zille immediately, or the Royal Army will reclaim our sovereign land by force!\"");
            SetEntryCondition(choice, "Variable[\"Zille_War_Active\"] ~= true and Variable[\"Zille_War_Completed\"] ~= true and Variable[\"Zille_PeaceTreaty_Signed\"] ~= true and (Variable[\"Zille_War_Outcome\"] or 0) == 0");
            SetEntryScript(choice, "Variable[\"Zille_War_UltimatumGiven\"] = true; Variable[\"Zille_War_Mobilization\"] = true; Variable[\"Zille_War_Variant\"] = \"Late\"; Variable[\"Zille_War_IsLate\"] = true; Variable[\"Zille_War_IsEarly\"] = false; Variable[\"Zille_War_Declined\"] = false; Variable[\"Zille_War_Postpone\"] = false; Variable[\"Zille_MilitarySentiment\"] = 3; Variable[\"Zille_Smolak_Pressure\"] = (Variable[\"Zille_Smolak_Pressure\"] or 0) + 2;");

            var replyLever = CreateEntry(conv.id, replyLeverId, SmolakId, RomusId, "Smolak_Turn8_Ultimatum_Shaken",
                "Smolak's face darkened as he gripped the table inside the airship cabin, his eyes darting to the thick dossier in your hand. \"So you're actually ready to bleed for it, Romus? Go ahead then—send your well-armed nobles! My Zille garrisons will fight you for every hillside!\"");
            SetEntryCondition(replyLever, "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) >= 1000 or Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] == true or (Variable[\"Zille_Leverage\"] or 0) >= 2");
            SetEntryScript(replyLever, "Variable[\"Zille_Leverage\"] = (Variable[\"Zille_Leverage\"] or 0) + 1;");

            var replyBluff = CreateEntry(conv.id, replyBluffId, SmolakId, RomusId, "Smolak_Turn8_Ultimatum_Bluff",
                "Smolak slammed his glass down and barked a harsh laugh inside the airship gondola. \"Threats with half-empty depots and no real leverage? Send your shiny parade brigades if you dare, King Romus—we will bury them in the mud of Zille!\"");
            SetEntryCondition(replyBluff, "(Variable[\"RiziaDLC.Resources_Military_Equipment\"] or 0) < 1000 and Variable[\"RiziaDLC.Wehlen_Zille_SharedEvidence\"] ~= true and (Variable[\"Zille_Leverage\"] or 0) < 2");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyLeverId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyBluffId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyLever.outgoingLinks.Add(CreateLink(conv.id, replyLeverId, nextId));
                replyBluff.outgoingLinks.Add(CreateLink(conv.id, replyBluffId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyLever);
            conv.dialogueEntries.Add(replyBluff);
            return true;
        }

        private static bool InjectWehlenWarSupersedesInterrupt(Conversation conv, DialogueDatabase db, string entryTitle, int baseId, string dispatchText, string ackText)
        {
            if (conv?.dialogueEntries == null) return false;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == entryTitle) return true;
            }

            DialogueEntry root = null;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e != null && (e.isRoot || e.id == 0))
                {
                    root = e;
                    break;
                }
            }
            if (root == null || root.outgoingLinks == null || root.outgoingLinks.Count == 0) return false;

            int interruptId = baseId;
            int ackId = baseId + 1;

            var interruptEntry = CreateEntry(conv.id, interruptId, LaurentoId, RomusId, entryTitle, dispatchText, "", "");
            SetEntryCondition(interruptEntry, "Variable[\"Zille_War_Active\"] == true or Variable[\"Zille_War_Completed\"] == true or Variable[\"Zille_PeaceTreaty_Signed\"] == true or (Variable[\"Zille_War_Outcome\"] or 0) > 0");
            interruptEntry.outgoingLinks.Add(CreateLink(conv.id, interruptId, ackId));

            var ackEntry = CreateEntry(conv.id, ackId, RomusId, LaurentoId, entryTitle + "_Close", ackText);
            conv.dialogueEntries.Add(interruptEntry);
            conv.dialogueEntries.Add(ackEntry);

            root.outgoingLinks.Insert(0, CreateLink(conv.id, root.id, interruptId));
            return true;
        }

        private static bool InjectTurn5HegelZilleWarFlavor(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn5_Hegel_WarClash") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "MITZ", "Morella", "Lespia", "Wehlen", "shares");
            if (parent == null) return false;

            int choiceId = 99341;
            int replyArkId = 99342;
            int replyStdId = 99343;

            var choice = CreateEntry(conv.id, choiceId, RomusId, HegelId, "Zille_Turn5_Hegel_WarClash",
                "Before we speak of MITZ, Chancellor—Valgsland should stay clear of our lawful enforcement of the 1927 Zille treaty.",
                "\"Before we discuss MITZ shares, Chancellor Hegel: Valgsland would do well to stay out of our lawful reclamation of Zille.\"");
            SetEntryCondition(choice, "Variable[\"Zille_War_Active\"] == true or Variable[\"Zille_War_Completed\"] == true or Variable[\"Zille_PeaceTreaty_Signed\"] == true");

            var replyArk = CreateEntry(conv.id, replyArkId, HegelId, RomusId, "Hegel_Turn5_EarlyArk_Fury",
                "Hegel's shoe slammed onto his desk across the wire. \"Lawful reclamation?! Your warships landed troops on mainland Wehlen while your palace spoke of a peaceful lease handover! Contana and Valgsland will not forget this imperialist hypocrisy, King Romus!\"");
            SetEntryCondition(replyArk, "Variable[\"Zille_EarlyArk_Backlash\"] == true");

            var replyStd = CreateEntry(conv.id, replyStdId, HegelId, RomusId, "Hegel_Turn5_ZilleWar_Warning",
                "Hegel snorted sharply over the static. \"Monarchs always call artillery 'law,' Your Majesty. Smolak is no saint, yet shedding blood across South Merkopa tests Contana's patience. Keep your cannons far from Morellan refineries!\"");
            SetEntryCondition(replyStd, "Variable[\"Zille_EarlyArk_Backlash\"] ~= true");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyArkId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyStdId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyArk.outgoingLinks.Add(CreateLink(conv.id, replyArkId, nextId));
                replyStd.outgoingLinks.Add(CreateLink(conv.id, replyStdId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyArk);
            conv.dialogueEntries.Add(replyStd);
            return true;
        }

        private static bool InjectTurn8ANSessionZilleWarFlavor(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn8_AN_DefendWar") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Zille", "Assembly", "Wehlen", "peace", "South Merkopa");
            if (parent == null) return false;

            int choiceId = 99351;
            int replyId = 99352;

            var choice = CreateEntry(conv.id, choiceId, RomusId, NarratorId, "Zille_Turn8_AN_DefendWar",
                "Address the Assembly on Rizia's military enforcement of the 1927 Zille treaty and our post-war commitment to regional peace.",
                "\"Delegates of the Alliance of Nations: Rizia never sought bloodshed in Zille, yet no sovereign crown can permit an expired treaty to become permanent occupation. Our actions upheld international law, and we stand ready to rebuild South Merkopa in peace.\"");
            SetEntryCondition(choice, "Variable[\"Zille_War_Active\"] == true or Variable[\"Zille_War_Completed\"] == true or Variable[\"Zille_PeaceTreaty_Signed\"] == true");
            SetEntryScript(choice, "Variable[\"Zille_AN_Legitimacy\"] = (Variable[\"Zille_AN_Legitimacy\"] or 0) + 1;");

            var reply = CreateEntry(conv.id, replyId, NarratorId, RomusId, "Narrator_Turn8_AN_ZilleWar_Reaction",
                "Mixed applause and tense murmurs swept the great hall in Konstantium. GRACE delegates applauded firmly, while Contanan and Wehzek envoys glared across the aisle at Rizia's banner.");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectTurn10BirthdayZilleWarFlavor(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn10_Birthday_Toast") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Mother", "Estela", "toast", "birthday", "Zille");
            if (parent == null) return false;

            int choiceId = 99361;
            int replyWinId = 99362;
            int replyHardId = 99363;

            var choice = CreateEntry(conv.id, choiceId, RomusId, EstelaId, "Zille_Turn10_Birthday_Toast",
                "Raise your glass to Queen Mother Estela and remember what Rizia endured in the Zille War.",
                "\"To you, Mother—and to every Rizian soldier and family who carried us through the fire of the Zille War.\"");
            SetEntryCondition(choice, "Variable[\"Zille_War_Completed\"] == true or Variable[\"Zille_PeaceTreaty_Signed\"] == true or (Variable[\"Zille_War_Outcome\"] or 0) > 0");

            var replyWin = CreateEntry(conv.id, replyWinId, EstelaId, RomusId, "Estela_Turn10_Birthday_Victory",
                "Queen Mother Estela's eyes shone warmly over her crystal glass. \"You brought my childhood harbor home beneath our own flag, Romus—not by begging Wiktor Smolak, but with the courage of a true King. Your father would be so proud tonight.\"");
            SetEntryCondition(replyWin, "(Variable[\"Zille_War_Outcome\"] or 0) >= 4 or Variable[\"RiziaDLC.ZilleReturn_Success\"] == true");

            var replyHard = CreateEntry(conv.id, replyHardId, EstelaId, RomusId, "Estela_Turn10_Birthday_Bitter",
                "Queen Mother Estela's smile softened with quiet sorrow as she lifted her glass. \"The war over Zille cost this kingdom dearly, my son... Let us pray our houses find the strength to heal what the guns left behind.\"");
            SetEntryCondition(replyHard, "(Variable[\"Zille_War_Outcome\"] or 0) < 4 and Variable[\"RiziaDLC.ZilleReturn_Success\"] ~= true");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyWinId));
            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyHardId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0)
            {
                replyWin.outgoingLinks.Add(CreateLink(conv.id, replyWinId, nextId));
                replyHard.outgoingLinks.Add(CreateLink(conv.id, replyHardId, nextId));
            }

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(replyWin);
            conv.dialogueEntries.Add(replyHard);
            return true;
        }

        private static bool InjectTurn11EndingSpeechZilleWarFlavor(Conversation conv, DialogueDatabase db)
        {
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_Turn11_EndingSpeech_Legacy") return true;
            }

            DialogueEntry parent = FindSuitableHub(conv, "Zille", "reign", "Rizia", "legacy", "future");
            if (parent == null) return false;

            int choiceId = 99371;
            int replyId = 99372;

            var choice = CreateEntry(conv.id, choiceId, RomusId, NarratorId, "Zille_Turn11_EndingSpeech_Legacy",
                "\"History will remember how Rizia stood firm in the Zille War—refusing to bow to Wehlen's extortion!\"",
                "\"When history writes the chronicle of my reign, let it remember our resolve in the Zille War: that Rizia refused to kneel before foreign extortion, honored the fallen, and defended her sovereign destiny!\"");
            SetEntryCondition(choice, "Variable[\"Zille_War_Completed\"] == true or Variable[\"Zille_PeaceTreaty_Signed\"] == true or (Variable[\"Zille_War_Outcome\"] or 0) > 0");

            var reply = CreateEntry(conv.id, replyId, NarratorId, RomusId, "Narrator_Turn11_EndingSpeech_Reaction",
                "A resonant cheer rolled through the assembly hall, veterans of the Brenas-Zille front rising to salute as your words echoed into history.");

            choice.outgoingLinks.Add(CreateLink(conv.id, choiceId, replyId));
            int nextId = FindConvergenceTarget(conv, parent);
            if (nextId >= 0) reply.outgoingLinks.Add(CreateLink(conv.id, replyId, nextId));

            parent.outgoingLinks.Add(CreateLink(conv.id, parent.id, choiceId));
            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);
            return true;
        }

        private static bool InjectZilleReferendumWarInterrupt(Conversation conv, DialogueDatabase db)
        {
            if (conv?.dialogueEntries == null) return false;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_WarSupersedes_Interrupt") return true;
            }

            DialogueEntry root = null;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e != null && (e.isRoot || e.id == 0))
                {
                    root = e;
                    break;
                }
            }
            if (root == null || root.outgoingLinks == null || root.outgoingLinks.Count == 0) return false;

            int interruptId = 99181;
            int ackId = 99182;

            var interruptEntry = CreateEntry(conv.id, interruptId, LaurentoId, RomusId, "Zille_WarSupersedes_Interrupt",
                "\"[DISPATCH] With the Zille frontier already settled by open arms and the Crown's military accords, Smolak's referendum timetable in Konstantium has been formally voided by events on the ground.\"",
                "", "");
            SetEntryCondition(interruptEntry, "Variable[\"Zille_War_Active\"] == true or Variable[\"Zille_War_UltimatumGiven\"] == true or Variable[\"Zille_PeaceTreaty_Signed\"] == true or (Variable[\"Zille_War_Outcome\"] or 0) > 0");
            SetEntryScript(interruptEntry, "Variable[\"RiziaDLC.ZilleReferendum_StoppedByAN\"] = true;");
            interruptEntry.outgoingLinks.Add(CreateLink(conv.id, interruptId, ackId));

            var ackEntry = CreateEntry(conv.id, ackId, RomusId, LaurentoId, "Zille_WarSupersedes_Close",
                "So be it. History in Zille has already passed beyond ballot boxes.");
            conv.dialogueEntries.Add(interruptEntry);
            conv.dialogueEntries.Add(ackEntry);

            // Insert at index 0 so PixelCrushers checks the war-supersedes interrupt BEFORE vanilla referendum flow
            root.outgoingLinks.Insert(0, CreateLink(conv.id, root.id, interruptId));
            return true;
        }

        private static bool InjectVanillaExileCollapseBranch(Conversation conv, DialogueDatabase db)
        {
            if (conv?.dialogueEntries == null) return false;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                if (conv.dialogueEntries[i]?.Title == "Zille_VanillaExile_CoupReport") return true;
            }

            DialogueEntry root = null;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e != null && (e.isRoot || e.id == 0))
                {
                    root = e;
                    break;
                }
            }
            if (root == null || root.outgoingLinks == null) return false;

            int repId = 99191;
            int optInterveneId = 99192;
            int optANId = 99193;
            int airportId = 99194;
            int airportEndId = 99195;
            int interveneEndId = 99196;

            string exileCond = "Variable[\"Zille_Azaro_Coup_Collapse\"] == true or Variable[\"Zille_Parley_Refused\"] == true";

            var rep = CreateEntry(conv.id, repId, NarratorId, RomusId, "Zille_VanillaExile_CoupReport",
                "Across the Antacean Sea in Kyrute, morning dispatches bring bitter truth from Rizia: after you refused to capitulate in the border pavilion, House Azaro seized the crumbling realm, nearly drowned Porte Drazon and Brenas in blood, and still signed a rotten armistice ceding large swaths of territory to Wehlen. Now full civil war among the great houses threatens to tear Rizia apart.",
                "", "");
            SetEntryCondition(rep, exileCond);
            rep.outgoingLinks.Add(CreateLink(conv.id, repId, optInterveneId));
            rep.outgoingLinks.Add(CreateLink(conv.id, repId, optANId));

            var optIntervene = CreateEntry(conv.id, optInterveneId, RomusId, NarratorId, "Zille_Exile_VanillaReturn",
                "Book passage aboard a smugglers' vessel and return to Rizia to intervene personally.",
                "\"I will not watch Rizia burn from a hotel room in Konstantium. Book a secret crossing back to the coast—I will rally Toras banners and stop this madness myself!\"");
            SetEntryScript(optIntervene, "Variable[\"Zille_Exile_Choice\"] = \"ReturnIntervene\"; Variable[\"RiziaDLC.Epilogue_CivilWar_AzaroEnemy\"] = true; Variable[\"RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue\"] = true;");
            optIntervene.outgoingLinks.Add(CreateLink(conv.id, optInterveneId, interveneEndId));

            var interveneEnd = CreateEntry(conv.id, interveneEndId, NarratorId, RomusId, "Zille_Exile_VanillaReturn_End",
                "Under moonless skies off Valenqiris, you stepped back onto fractured homeland soil—casting your last die into a kingdom consumed by fratricide.");

            var optAN = CreateEntry(conv.id, optANId, RomusId, NarratorId, "Zille_Exile_VanillaANOfficial",
                "Remain in Kyrute as a lowly Alliance of Nations official and try to defuse the crisis through diplomacy.",
                "\"More Rizian blood will not mend Rizia. As an AN diplomatic advisor here in Konstantium, I will petition every commission on earth to halt this civil war before there is nothing left to save.\"");
            SetEntryScript(optAN, "Variable[\"Zille_Exile_Choice\"] = \"ANDiplomat\";");
            optAN.outgoingLinks.Add(CreateLink(conv.id, optANId, airportId));

            var airport = CreateEntry(conv.id, airportId, VinaId, RomusId, "Zille_Exile_VanillaAirportEncounter",
                "At Kyrute's rain-swept airport terminal, trying to board a modest envoy flight as a side-lined AN clerk, you collide with Vina and Manus arriving off a battered refugee charter from Valenqiris. Smoke still clings to their coats. \"Father—Look at what is left of Rizia!\" Vina snaps, Manus nodding grimly beside her. \"Azaro shells flatten Brenas while Sazon and Toras levies tear the heartland in half—and every pamphlet lays the ruin at your feet! If you set foot in Porte Drazon, there is no restoration—only a summary tribunal and a certain sentence of death!\"",
                "", "");
            SetEntryCondition(airport, "Variable[\"RiziaDLC.Vina_FuneralHappened\"] ~= true and Variable[\"RiziaDLC.Vina_Dead\"] ~= true");
            airport.outgoingLinks.Add(CreateLink(conv.id, airportId, airportEndId));

            int airportAltId = 99197;
            var airportAlt = CreateEntry(conv.id, airportAltId, NarratorId, RomusId, "Zille_Exile_VanillaAirportEncounter_Alt",
                "On the wet tarmac of Kyrute's airport, diplomatic couriers arriving off the last evacuation plane from Valenqiris block your way in grim disgust: Azaro shells fall across rebel provinces, half of Rizia curses the day you walked away from that tent, and any plane carrying Romus Toras into Porte Drazon ends before a firing squad.",
                "", "");
            SetEntryCondition(airportAlt, "Variable[\"RiziaDLC.Vina_FuneralHappened\"] == true or Variable[\"RiziaDLC.Vina_Dead\"] == true");
            airportAlt.outgoingLinks.Add(CreateLink(conv.id, airportAltId, airportEndId));
            optAN.outgoingLinks.Add(CreateLink(conv.id, optANId, airportAltId));

            var airportEnd = CreateEntry(conv.id, airportEndId, NarratorId, RomusId, "Zille_Exile_VanillaANDiplomat_End",
                "Watching the evacuation tail-lights fade across the wet concrete of Kyrute, you realized how small an exiled king becomes—a minor AN clerk in a borrowed trenchcoat, begging foreign secretaries to spare a homeland that would execute him at the border.");

            conv.dialogueEntries.Add(rep);
            conv.dialogueEntries.Add(optIntervene);
            conv.dialogueEntries.Add(interveneEnd);
            conv.dialogueEntries.Add(optAN);
            conv.dialogueEntries.Add(airport);
            conv.dialogueEntries.Add(airportAlt);
            conv.dialogueEntries.Add(airportEnd);

            root.outgoingLinks.Insert(0, CreateLink(conv.id, root.id, repId));
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
