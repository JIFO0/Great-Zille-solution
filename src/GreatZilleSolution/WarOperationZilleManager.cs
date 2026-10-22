using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public enum ActiveWarTheatre
    {
        None,
        Civilian,
        Pales,
        Zille
    }

    public static class WarOperationZilleManager
    {
        public const string OPERATION_PHASE_1_ID = "OP_Zille_RighteousSword";
        public const string OPERATION_PHASE_2_ID = "OP_Zille_TotalRepayment";

        public static ActiveWarTheatre CurrentTheatre { get; set; } = ActiveWarTheatre.None;

        public static GameObject SpawnedZilleWarToken => _spawnedZilleWarToken;
        public static Vector3 TokenBasePos { get; set; } = new Vector3(0.4673f, 0.08f, 0.8262f);
        public static bool IsTokenHovered { get; set; } = false;

        private static GameObject _spawnedZilleWarToken = null;
        private static Texture _originalPalesTexture = null;
        private static readonly List<Vector3> _originalTilePositions = new List<Vector3>();
        private static readonly List<Vector3> _originalTileScales = new List<Vector3>();
        private static bool _tilesConfiguredForZille = false;
        private static bool _tableTextureApplied = false;

        private static bool _transitionScheduled = false;
        private static float _transitionTimer = 0f;

        private static bool _customOperationConfigured = false;
        private static WarOperation _zilleWarOp = null;

        public static void InitializeOperation(ZilleOperationPath path)
        {
            ZilleCampaignState.ChosenPath = path;
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1_RighteousSword;

            MelonLogger.Msg("============================================================");
            MelonLogger.Msg($"[WAR ENGINE] Initializing Zille Campaign: Phase 1 (Righteous Sword)");
            MelonLogger.Msg($"[WAR ENGINE] Doctrine Selected: {path}");
            MelonLogger.Msg("============================================================");

            ZilleCampaignState.ApplyGeopoliticalShifts();

            if (ZilleCampaignState.IsTwoFrontWarThreat())
            {
                MelonLogger.Warning("[WAR ENGINE] WARNING: Two-Front War Active! Pales theatre has committed royal assets.");
                CalculateUnitReserves();
            }

            ZilleCampaignState.SyncToLua();
        }

        public static void AdvanceToPhase2()
        {
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2_TotalRepayment;
            MelonLogger.Msg("[WAR ENGINE] Advancing to Phase 2: Total Repayment. Encirclement of Wehlen forces.");
            ZilleCampaignState.SyncToLua();
        }

        public static void TriggerVictory()
        {
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Completed_Victory;
            MelonLogger.Msg("[WAR ENGINE] VICTORY IN ZILLE! Crown forces secured the territory.");

            try
            {
                DialogueHelper.SetVariable("ZilleReturn_Success", true);
                DialogueHelper.SetVariable("_Zille_OwnState", 1);
                DialogueHelper.SetVariable("Zille_PromisedToHouseToras", true);
                DialogueHelper.SetVariable("Diplomacy_Wehlen_Hostile", true);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"Error setting victory flags: {ex.Message}");
            }

            ZilleCampaignState.SyncToLua();
        }

        public static void TriggerCatastrophicDefeat(bool motherDied, bool brenasLost)
        {
            ZilleCampaignState.IsMotherCaptured = motherDied;
            ZilleCampaignState.IsBrenasLost = brenasLost;
            ZilleCampaignState.CurrentPhase = brenasLost ? ZilleOperationPhase.Defeat_BrenasLost : ZilleOperationPhase.Defeat_MotherCaptured;

            MelonLogger.Error("============================================================");
            MelonLogger.Error($"[WAR ENGINE] CATASTROPHIC DEFEAT IN ZILLE!");
            if (motherDied) MelonLogger.Error("[WAR ENGINE] Queen Mother Estela captured and killed by Smolak's troops!");
            if (brenasLost) MelonLogger.Error("[WAR ENGINE] Province of Brenas ceded to Wehlen!");
            MelonLogger.Error("============================================================");

            try
            {
                DialogueHelper.SetVariable("ZilleReturn_Success", false);
                DialogueHelper.SetVariable("ZilleReferendum_Lost", true);
                if (brenasLost) DialogueHelper.SetVariable("Brenas_Lost_To_Wehlen", true);
                if (motherDied) DialogueHelper.SetVariable("QueenMother_Estela_Dead", true);
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"Error setting defeat flags: {ex.Message}");
            }

            ZilleCampaignState.SyncToLua();
        }

        public static void CalculateUnitReserves()
        {
            int totalBattalions = 8;
            try
            {
                totalBattalions += DialogueHelper.GetIntVariable("Military_Expanded_Infantry") * 2;
                totalBattalions += DialogueHelper.GetIntVariable("Military_Expanded_Tanks") * 2;
            }
            catch { }

            int palesTokens = 0;
            if (ZilleCampaignState.IsTwoFrontWarThreat())
            {
                palesTokens = 5;
            }

            ZilleCampaignState.UnitsCommittedToPales = palesTokens;
            ZilleCampaignState.UnitsCommittedToZille = Math.Max(1, totalBattalions - palesTokens);

            MelonLogger.Msg($"[WAR ENGINE] Unit Allocation: Total={totalBattalions}, Pales={palesTokens}, Available for Zille={ZilleCampaignState.UnitsCommittedToZille}");
        }

        // ================= REGISTER NATIVE SUZERAIN ENTITIES =================

        public static void RegisterNativeZilleEntities()
        {
            try
            {
                // 1. Ensure Conversation is registered in PixelCrushers masterDatabase
                EnsureWarCouncilConversationRegistered();

                // 2. Register ConversationData for Porte Drazon in EntityDataManager
                var convList = EntityDataManager.ConversationsData;
                var allConvList = EntityDataManager.AllConversationsData;

                ConversationData cd = null;
                if (convList != null)
                {
                    for (int i = 0; i < convList.Count; i++)
                    {
                        var c = convList[i];
                        if (c != null && c.NameInDatabase == "Turn_Zille_WarBriefing")
                        {
                            cd = c;
                            break;
                        }
                    }
                }

                if (cd == null)
                {
                    cd = new ConversationData();
                    cd.Id = "Conv_Zille_RoyalBriefing";
                    cd.NameInDatabase = "Turn_Zille_WarBriefing";
                    cd.Path = "Rizia/Conversations";
                    cd.AssignedTokenProperties = new AssignedTokenProperties();
                    cd.AssignedTokenProperties.AssignedToken = "Rizia_City_PorteDrazon";
                    cd.StoryFragmentProperties = new StoryFragmentProperties();
                    cd.StoryFragmentProperties.IsDone = false;
                    cd.StoryFragmentProperties.StoryFragmentCondition = "";
                    cd.ConversationProperties = new ConversationProperties();
                    cd.ConversationProperties.Title = "A royal briefing before the invasion of Zille";
                    cd.ConversationProperties.Subtitle = "Council Chambers, Palas Rezna";
                    cd.ConversationProperties.Dialogue = "Zille/WarCouncil_Briefing";
                    cd.ConversationProperties.TypeString = "SecurityAndOrder";
                    cd.ConversationProperties.IsOnStart = false;
                    cd.AppBundleProperties = new AppBundleProperties("StoryPack_Rizia");

                    if (convList != null) convList.Add(cd);
                    if (allConvList != null && !allConvList.Contains(cd)) allConvList.Add(cd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'A royal briefing before the invasion of Zille' to EntityDataManager.ConversationsData!");
                }

                // 3. Register WarFragmentData for Zille invasion in EntityDataManager
                var warList = EntityDataManager.WarFragmentsData;
                var allWarList = EntityDataManager.AllWarFragmentsData;

                WarFragmentData wfd = null;
                if (warList != null)
                {
                    for (int i = 0; i < warList.Count; i++)
                    {
                        var w = warList[i];
                        if (w != null && w.NameInDatabase == "WarFragment_Zille_1_1")
                        {
                            wfd = w;
                            break;
                        }
                    }
                }

                if (wfd == null)
                {
                    wfd = new WarFragmentData();
                    wfd.Id = "WarFragment_Zille_1_1";
                    wfd.NameInDatabase = "WarFragment_Zille_1_1";
                    wfd.Path = "Rizia/War Fragments";
                    wfd.AssignedTokenProperties = new AssignedTokenProperties();
                    wfd.AssignedTokenProperties.AssignedToken = "Rizia_Event_InvasionOfZille";
                    wfd.StoryFragmentProperties = new StoryFragmentProperties();
                    wfd.StoryFragmentProperties.IsDone = false;
                    wfd.StoryFragmentProperties.StoryFragmentCondition = "";
                    wfd.WarFragmentProperties = new WarFragmentProperties();
                    wfd.WarFragmentProperties.Operation = "Operation_Zille_1";
                    wfd.WarFragmentProperties.HubWarFragmentTitle = "Operation: Righteous Sword - Phase I";
                    wfd.WarFragmentProperties.HubWarFragmentSubtitle = "Invasion of Zille";
                    wfd.AppBundleProperties = new AppBundleProperties("StoryPack_Rizia");

                    if (warList != null) warList.Add(wfd);
                    if (allWarList != null && !allWarList.Contains(wfd)) allWarList.Add(wfd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'Operation: Righteous Sword - Phase I' to EntityDataManager.WarFragmentsData!");
                }
                else
                {
                    if (wfd.WarFragmentProperties != null)
                    {
                        wfd.WarFragmentProperties.Operation = "Operation_Zille_1";
                        wfd.WarFragmentProperties.HubWarFragmentTitle = "Operation: Righteous Sword - Phase I";
                        wfd.WarFragmentProperties.HubWarFragmentSubtitle = "Invasion of Zille";
                    }
                }

                // 4. Register MapTokenData for Rizia_Event_InvasionOfZille
                var tokenList = EntityDataManager.MapTokensData;

                MapTokenData zilleMtd = null;
                if (tokenList != null)
                {
                    for (int i = 0; i < tokenList.Count; i++)
                    {
                        var t = tokenList[i];
                        if (t != null && t.NameInDatabase == "Rizia_Event_InvasionOfZille")
                        {
                            zilleMtd = t;
                            break;
                        }
                    }
                }

                if (zilleMtd == null)
                {
                    zilleMtd = new MapTokenData();
                    zilleMtd.Id = "Rizia_Event_InvasionOfZille";
                    zilleMtd.NameInDatabase = "Rizia_Event_InvasionOfZille";
                    zilleMtd.Path = "Rizia/Tokens";
                    zilleMtd.MapTokenProperties = new MapTokenProperties();
                    zilleMtd.MapTokenProperties.Title = "Invasion of Zille";
                    zilleMtd.MapTokenProperties.Subtitle = "Military Operation";
                    zilleMtd.MapTokenProperties.Type = "Event";
                    zilleMtd.MapTokenProperties.IsTokenEnabled = true;
                    zilleMtd.Title = "Invasion of Zille";
                    zilleMtd.Subtitle = "Military Operation";
                    zilleMtd.IsTokenEnabled = true;
                    zilleMtd.AppBundleProperties = new AppBundleProperties("StoryPack_Rizia");

                    if (tokenList != null) tokenList.Add(zilleMtd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'Rizia_Event_InvasionOfZille' to EntityDataManager.MapTokensData!");
                }

                // 5. Register dedicated OperationData for Operation_Zille_1 (Operation: Righteous Sword)
                var ops = EntityDataManager.OperationData;

                OperationData zilleOp = null;
                if (ops != null)
                {
                    for (int i = 0; i < ops.Count; i++)
                    {
                        var op = ops[i];
                        if (op != null && (op.NameInDatabase == "Operation_Zille_1" || op.Id == "Operation_Zille_1"))
                        {
                            zilleOp = op;
                            break;
                        }
                    }
                }

                if (zilleOp == null)
                {
                    zilleOp = new OperationData();
                    zilleOp.Id = "Operation_Zille_1";
                    zilleOp.NameInDatabase = "Operation_Zille_1";
                    zilleOp.Path = "Rizia/Operations";
                    zilleOp.OperationProperties = new OperationProperties();
                    zilleOp.OperationProperties.OperationName = "Operation: Righteous Sword";
                    zilleOp.OperationProperties.Phases = new Il2CppSystem.Collections.Generic.List<string>();
                    zilleOp.OperationProperties.Phases.Add("WarFragment_Zille_1_1");
                    zilleOp.OperationProperties.ResultVariable = "War_Zille_Result";
                    zilleOp.OperationProperties.TotalEnemyDeadVariable = "War_Zille_TotalEnemyDead";
                    zilleOp.OperationProperties.TotalPlayerDeadVariable = "War_Zille_TotalPlayerDead";
                    zilleOp.OperationProperties.IsTutorial = false;
                    zilleOp.OperationProperties.IsFinished = false;
                    zilleOp.AppBundleProperties = new AppBundleProperties("StoryPack_Rizia");

                    if (ops != null) ops.Add(zilleOp);
                    MelonLogger.Msg("[WAR ENGINE] Added dedicated 'Operation_Zille_1' (Operation: Righteous Sword) to EntityDataManager.OperationData!");
                }
                else
                {
                    if (zilleOp.OperationProperties?.Phases != null && !zilleOp.OperationProperties.Phases.Contains("WarFragment_Zille_1_1"))
                    {
                        zilleOp.OperationProperties.Phases.Add("WarFragment_Zille_1_1");
                    }
                }

                // Clean up any previous injection into Operation_1 (so Pales is completely separate)
                if (ops != null)
                {
                    for (int i = 0; i < ops.Count; i++)
                    {
                        var op = ops[i];
                        if (op != null && (op.NameInDatabase == "Operation_1" || op.Id == "Operation_1"))
                        {
                            if (op.OperationProperties?.Phases != null && op.OperationProperties.Phases.Contains("WarFragment_Zille_1_1"))
                            {
                                op.OperationProperties.Phases.Remove("WarFragment_Zille_1_1");
                            }
                            break;
                        }
                    }
                }

                // 6. Register both story fragments into GameFlowManager.enabledNotDoneStoryFragments
                var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                if (gfm != null)
                {
                    var enabledFrags = gfm.GetEnabledNotDoneStoryFragments();
                    if (enabledFrags != null)
                    {
                        if (cd != null && !enabledFrags.Contains(cd))
                        {
                            enabledFrags.Add(cd);
                            MelonLogger.Msg("[WAR ENGINE] Registered Turn_Zille_WarBriefing into GameFlowManager.enabledNotDoneStoryFragments!");
                        }
                        if (wfd != null && !enabledFrags.Contains(wfd))
                        {
                            enabledFrags.Add(wfd);
                            MelonLogger.Msg("[WAR ENGINE] Registered WarFragment_Zille_1_1 into GameFlowManager.enabledNotDoneStoryFragments!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] RegisterNativeZilleEntities error: {ex.Message}");
            }
        }

        // ================= FOCUS PORTE DRAZON BRIEFING EVENT =================

        public static bool FocusPorteDrazonBriefing()
        {
            RegisterNativeZilleEntities();

            try
            {
                // 1. Move camera & focus on Porte Drazon token
                Token porteToken = null;
                var allTokens = Resources.FindObjectsOfTypeAll<Token>();
                if (allTokens != null)
                {
                    for (int i = 0; i < allTokens.Length; i++)
                    {
                        var t = allTokens[i];
                        if (t != null && t.gameObject != null)
                        {
                            string n = t.gameObject.name ?? "";
                            string e = t.GetTokenDataEntityName() ?? "";
                            if (n.Contains("PorteDrazon") || n.Contains("Porte Drazon") || e.Contains("PorteDrazon"))
                            {
                                porteToken = t;
                                break;
                            }
                        }
                    }
                }

                var tokenMgr = Managers.Instance?.TokenManager ?? UnityEngine.Object.FindObjectOfType<TokenManager>();
                if (tokenMgr != null && porteToken != null)
                {
                    tokenMgr.SelectToken(porteToken);
                    var tip = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();
                    if (tip != null)
                    {
                        tip.gameObject.SetActive(true);
                        tip.Setup(porteToken);
                        tip.Show();
                    }
                    DialogueHelper.ShowAlert("[Porte Drazon] Wybierz event 'A royal briefing before the invasion of Zille' aby rozpoczac narade.");
                    return true;
                }

                // Fallback: If token not found, start conversation directly
                return TriggerZilleWarBriefingConversation();
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] FocusPorteDrazonBriefing failed: {ex.Message}");
                return TriggerZilleWarBriefingConversation();
            }
        }

        // ================= SPAWN / FOCUS WAR EVENT AT ZILLE =================

        public static bool SpawnZilleWarEventToken()
        {
            RegisterNativeZilleEntities();

            try
            {
                TokenManager tokenMgr = Managers.Instance?.TokenManager ?? UnityEngine.Object.FindObjectOfType<TokenManager>();

                // Coordinates placed nicely next to Zille city token on land (Zille city is at 0.4673, 0.08, 0.8262)
                Vector3 zilleWarPos = new Vector3(0.405f, 0.08f, 0.775f);
                TokenBasePos = zilleWarPos;

                // 1. First, search for existing cloned InvasionOfZille Event Variant
                if (_spawnedZilleWarToken == null)
                {
                    _spawnedZilleWarToken = GameObject.Find("InvasionOfZille Event Variant");
                    if (_spawnedZilleWarToken == null)
                    {
                        var allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
                        for (int i = 0; i < allObjs.Length; i++)
                        {
                            if (allObjs[i] != null && allObjs[i].name == "InvasionOfZille Event Variant")
                            {
                                _spawnedZilleWarToken = allObjs[i];
                                break;
                            }
                        }
                    }
                }

                // 2. If not found, clone InvasionOfPales Event Variant to get the exact identical war pawn!
                if (_spawnedZilleWarToken == null)
                {
                    GameObject palesWarTemplate = GameObject.Find("InvasionOfPales Event Variant");
                    if (palesWarTemplate == null)
                    {
                        var allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
                        for (int i = 0; i < allObjs.Length; i++)
                        {
                            if (allObjs[i] != null && allObjs[i].name == "InvasionOfPales Event Variant")
                            {
                                palesWarTemplate = allObjs[i];
                                break;
                            }
                        }
                    }

                    if (palesWarTemplate != null)
                    {
                        // Ensure Pales template remains untouched and inactive in Turn 2!
                        palesWarTemplate.SetActive(false);

                        Transform parent = palesWarTemplate.transform.parent;
                        _spawnedZilleWarToken = UnityEngine.Object.Instantiate(palesWarTemplate, parent);
                        _spawnedZilleWarToken.name = "InvasionOfZille Event Variant";
                        _spawnedZilleWarToken.transform.position = zilleWarPos;
                        _spawnedZilleWarToken.transform.rotation = palesWarTemplate.transform.rotation;
                        _spawnedZilleWarToken.transform.localScale = palesWarTemplate.transform.localScale;
                        _spawnedZilleWarToken.layer = palesWarTemplate.layer;

                        var allTrans = _spawnedZilleWarToken.GetComponentsInChildren<Transform>(true);
                        for (int i = 0; i < allTrans.Length; i++)
                        {
                            if (allTrans[i] != null) allTrans[i].gameObject.layer = palesWarTemplate.layer;
                        }

                        _spawnedZilleWarToken.SetActive(true);
                        palesWarTemplate.SetActive(false); // Double ensure Pales template stays hidden in Turn 2!
                        MelonLogger.Msg($"[WAR ENGINE] Successfully instantiated separate InvasionOfZille Event Variant at {zilleWarPos} (Pales marker untouched)!");
                    }
                }

                if (_spawnedZilleWarToken != null)
                {
                    _spawnedZilleWarToken.transform.position = zilleWarPos;
                    _spawnedZilleWarToken.SetActive(true);

                    // Fetch or verify zilleMtd from EntityDataManager
                    MapTokenData zilleMtd = null;
                    var tokenList = EntityDataManager.MapTokensData;
                    if (tokenList != null)
                    {
                        for (int i = 0; i < tokenList.Count; i++)
                        {
                            if (tokenList[i] != null && tokenList[i].NameInDatabase == "Rizia_Event_InvasionOfZille")
                            {
                                zilleMtd = tokenList[i];
                                break;
                            }
                        }
                    }

                    var tok = _spawnedZilleWarToken.GetComponent<Token>();
                    if (tok != null)
                    {
                        tok.tokenDataEntityName = "Rizia_Event_InvasionOfZille";
                        tok.tokenType = Token.TokenType.Event;
                        if (zilleMtd != null) tok.tokenData = zilleMtd;
                        tok.gameObject.SetActive(true);
                        tok.Setup();

                        if (Managers.Instance?.Tokens != null && !Managers.Instance.Tokens.Contains(tok))
                        {
                            Managers.Instance.Tokens.Add(tok);
                        }

                        if (tokenMgr != null)
                        {
                            tokenMgr.SelectToken(tok);
                        }

                        var tip = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();
                        if (tip != null)
                        {
                            tip.gameObject.SetActive(true);
                            tip.Setup(tok);
                            tip.Show();
                        }
                    }

                    DialogueHelper.ShowAlert("[Zille] Pionek wojenny i operacja Operation Righteous Sword Phase I aktywne w Zille.");
                    return true;
                }

                MelonLogger.Warning("[WAR ENGINE] Could not find or instantiate InvasionOfZille Event Variant.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] SpawnZilleWarEventToken failed: {ex.Message}\n{ex.StackTrace}");
            }
            return false;
        }

        // ================= HOVER AND CLICK RAYCAST INTERACTION =================

        public static void UpdateEventTokenInteractions()
        {
            // Native EventSystem & Suzerain TokenManager handle hover, click, and tooltips via MapTokenData.
        }

        // ================= NATIVE DIALOGUE ENGINE INJECTION =================

        private static Link CreateLink(int convId, int fromId, int toId)
        {
            var link = new Link(convId, fromId, convId, toId);
            link.priority = ConditionPriority.Normal;
            link.isConnector = false;
            return link;
        }

        private static DialogueEntry CreateDialogueEntry(int convId, int entryId, int actorId, int conversantId, string title, string text, string menuText = null, string sequence = "")
        {
            var entry = new DialogueEntry();
            entry.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            entry.outgoingLinks = new Il2CppSystem.Collections.Generic.List<Link>();
            entry.id = entryId;
            entry.conversationID = convId;
            entry.ActorID = actorId;
            entry.ConversantID = conversantId;
            entry.Title = title ?? "";
            entry.DialogueText = text ?? "";
            entry.MenuText = menuText ?? text ?? "";
            entry.Sequence = sequence ?? "";
            entry.conditionPriority = ConditionPriority.Normal;
            entry.isGroup = false;

            entry.fields.Add(new Field("Title", title ?? "", FieldType.Text));
            entry.fields.Add(new Field("Actor", actorId.ToString(), FieldType.Actor));
            entry.fields.Add(new Field("Conversant", conversantId.ToString(), FieldType.Actor));
            entry.fields.Add(new Field("Dialogue Text", text ?? "", FieldType.Text));
            entry.fields.Add(new Field("en", text ?? "", FieldType.Localization));
            entry.fields.Add(new Field("Menu Text", menuText ?? text ?? "", FieldType.Text));
            entry.fields.Add(new Field("Sequence", sequence ?? "", FieldType.Text));
            entry.fields.Add(new Field("Articy Id", $"0x0100005A_Zille_{entryId}", FieldType.Text));

            return entry;
        }

        public static bool EnsureWarCouncilConversationRegistered()
        {
            try
            {
                var db = DialogueManager.masterDatabase;
                if (db == null)
                {
                    MelonLogger.Warning("[WAR ENGINE] DialogueManager.masterDatabase not ready yet.");
                    return false;
                }

                const string convTitle = "Zille/WarCouncil_Briefing";
                var existing = db.GetConversation(convTitle);
                if (existing != null)
                {
                    db.conversations.Remove(existing);
                }

                MelonLogger.Msg("[WAR ENGINE] Injecting native Royal War Council Briefing conversation into masterDatabase...");

                // Default accurate actor IDs in Suzerain database
                int romusId = 95;   // Player_Romus
                int titusId = 81;   // Titus Gordion
                int lucitaId = 73;  // Lucita Azaro
                int hugoId = 68;    // Hugo Toras

                if (db.actors != null)
                {
                    for (int i = 0; i < db.actors.Count; i++)
                    {
                        var a = db.actors[i];
                        if (a == null) continue;
                        string aName = a.Name ?? "";
                        if (aName.Equals("Player_Romus", StringComparison.OrdinalIgnoreCase)) romusId = a.id;
                        else if (aName.IndexOf("Titus", StringComparison.OrdinalIgnoreCase) >= 0) titusId = a.id;
                        else if (aName.IndexOf("Lucita", StringComparison.OrdinalIgnoreCase) >= 0) lucitaId = a.id;
                        else if (aName.IndexOf("Hugo", StringComparison.OrdinalIgnoreCase) >= 0) hugoId = a.id;
                    }
                }

                var conv = new Conversation();
                conv.id = 9988;
                conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
                conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
                conv.Title = convTitle;
                conv.ActorID = romusId;
                conv.ConversantID = lucitaId;

                int totalBattalions = 8;
                try
                {
                    totalBattalions += DialogueHelper.GetIntVariable("Military_Expanded_Infantry") * 2;
                    totalBattalions += DialogueHelper.GetIntVariable("Military_Expanded_Tanks") * 2;
                }
                catch { }

                int budget = DialogueHelper.GetIntVariable("Budget");
                bool lespiaPact = DialogueHelper.GetBoolVariable("Diplomacy_Lespia_Alliance") || DialogueHelper.GetBoolVariable("Lespia_Intelligence_Pact") || ZilleCampaignState.IsLespiaPactAccepted;

                // Entry 0: START
                var entry0 = CreateDialogueEntry(conv.id, 0, romusId, lucitaId, "START", "", "", "Continue()");
                entry0.isRoot = true;
                entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
                conv.dialogueEntries.Add(entry0);

                // Entry 1: Titus Gordion (Security / Su Omina)
                string titusText = $"Wasza Krolewska Mosc, zbliza sie moment ostatecznego rozstrzygniecia w kwestii Zille. " +
                                   $"Komorki Su Omina w prowincji melduja o pelnej mobilizacji. Garnizon Wehlen pod dowodztwem plk. Valdeza " +
                                   $"liczy okolo 4 regularnych brygad oraz oddzialy OBT Smolaka. Jezeli wydacie rozkaz, rebelianci uderza od wewnatrz w punkty zaopatrzenia wroga.";
                var entry1 = CreateDialogueEntry(conv.id, 1, titusId, romusId, "Titus_Report", titusText);
                entry1.outgoingLinks.Add(CreateLink(conv.id, 1, 2));
                conv.dialogueEntries.Add(entry1);

                // Entry 2: Lucita Azaro (War Ministry / Military Balance)
                string lespiaNote = lespiaPact 
                    ? "Prezydent Alvarez potwierdzil wsparcie radarowe i blokade w wodach Zille." 
                    : "Brak formalnego paktu z Lespia rodzi ryzyko wtracenia sie Contanan Security Pact (CSP) na korzysc Wehlenu.";
                string lucitaText = $"Sztab generalny dokonal przegladu wojsk. Do operacji mozemy rzucic {totalBattalions} pelnych batalionow. " +
                                    $"Smolak okopal sie na wezlach komunikacyjnych, lecz nasza przewaga w manewrze pancernym jest wyrazna. {lespiaNote} " +
                                    $"Przedstawiam dwa warianty doktryny wojennej — decyzja nalezy do Was, Wasza Wysokosc.";
                var entry2 = CreateDialogueEntry(conv.id, 2, lucitaId, romusId, "Lucita_Report", lucitaText);
                entry2.outgoingLinks.Add(CreateLink(conv.id, 2, 3));
                conv.dialogueEntries.Add(entry2);

                // Entry 3: Hugo Toras (Crown Treasury / House Politics)
                string hugoText = $"Skarbiec krolestwa dysponuje obecnie rezerwa {budget} jednostek budzetowych. Kazdy dzien dzialan wojennych to gigantyczny koszt logistyczny. " +
                                  $"Dom Toras oczekuje, ze ziemie Zille powroca do Korony, ale bez zrujnowania naszej gospodarki. Podpiszcie rozkaz lub dajcie nam wiecej czasu.";
                var entry3 = CreateDialogueEntry(conv.id, 3, hugoId, romusId, "Hugo_Report", hugoText);
                entry3.outgoingLinks.Add(CreateLink(conv.id, 3, 10));
                entry3.outgoingLinks.Add(CreateLink(conv.id, 3, 20));
                entry3.outgoingLinks.Add(CreateLink(conv.id, 3, 30));
                conv.dialogueEntries.Add(entry3);

                // Option 10: Plan Alpha (Frontal Assault)
                var choiceAlpha = CreateDialogueEntry(conv.id, 10, romusId, lucitaId, "Choice_Alpha", 
                    "Wydajcie rozkazy do natarcia. Przelamujemy linie Smolaka frontalnym uderzeniem.", 
                    "Plan Alpha: Zmasowane natarcie frontalne na pozycje Smolaka w Zille.");
                choiceAlpha.userScript = "Zille_War_Alfa";
                choiceAlpha.outgoingLinks.Add(CreateLink(conv.id, 10, 11));
                conv.dialogueEntries.Add(choiceAlpha);

                // Entry 11: Lucita Alpha Ack
                var lucitaAlpha = CreateDialogueEntry(conv.id, 11, lucitaId, romusId, "Lucita_Alpha_Ack", 
                    "Rozkaz przyjety, moj Krolu! Glowne uderzenie ruszy poludniowa flanka. Przenosze dowodztwo na stol operacyjny teatru Zille.");
                lucitaAlpha.userScript = "Zille_War_Alfa_Execute";
                conv.dialogueEntries.Add(lucitaAlpha);

                // Option 20: Plan Beta (Flanking Munat)
                var choiceBeta = CreateDialogueEntry(conv.id, 20, romusId, lucitaId, "Choice_Beta", 
                    "Oskrzydlimy Wehlen. Skierujmy glowne sily przez Viktrany i wzgorza Munat.", 
                    "Plan Beta: Manewr oskrzydlajacy przez Viktrany i port Munat.");
                choiceBeta.userScript = "Zille_War_Beta";
                choiceBeta.outgoingLinks.Add(CreateLink(conv.id, 20, 21));
                conv.dialogueEntries.Add(choiceBeta);

                // Entry 21: Lucita Beta Ack
                var lucitaBeta = CreateDialogueEntry(conv.id, 21, lucitaId, romusId, "Lucita_Beta_Ack", 
                    "Blyskotliwy manewr, Wasza Wysokosc! Obejdziemy ich glowne umocnienia od zachodu. Otwieram stol operacyjny.");
                lucitaBeta.userScript = "Zille_War_Beta_Execute";
                conv.dialogueEntries.Add(lucitaBeta);

                // Option 30: Postpone
                var choicePostpone = CreateDialogueEntry(conv.id, 30, romusId, hugoId, "Choice_Postpone", 
                    "Wstrzymajmy uderzenie. Armia potrzebuje jeszcze przegrupowania i zapasow.", 
                    "Wstrzymajmy uderzenie. Potrzebujemy wiecej czasu na przygotowania.");
                choicePostpone.userScript = "Zille_War_Postpone";
                choicePostpone.outgoingLinks.Add(CreateLink(conv.id, 30, 31));
                conv.dialogueEntries.Add(choicePostpone);

                // Entry 31: Hugo Postpone Ack
                var hugoPostpone = CreateDialogueEntry(conv.id, 31, hugoId, romusId, "Hugo_Postpone_Ack", 
                    "Madra i roztropna decyzja, Wasza Krolewska Mosc. Skarbnik i generalicja zyskaja bezcenny czas na konsolidacje rezerw.");
                conv.dialogueEntries.Add(hugoPostpone);

                db.AddConversation(conv);
                MelonLogger.Msg("[WAR ENGINE] Native Royal War Council Briefing conversation injected successfully!");
                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] Error injecting conversation: {ex.Message}\n{ex.StackTrace}");
                return false;
            }
        }

        public static bool TriggerZilleWarBriefingConversation()
        {
            MelonLogger.Msg("[WAR ENGINE] Launching native Royal War Council Briefing via ConversationPanel...");
            EnsureWarCouncilConversationRegistered();

            try
            {
                var convPanel = Panels.Instance?.ConversationPanel ?? UnityEngine.Object.FindObjectOfType<ConversationPanel>();
                if (convPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<ConversationPanel>();
                    if (allPanels != null && allPanels.Length > 0) convPanel = allPanels[0];
                }

                if (convPanel != null)
                {
                    Panels.Instance?.TokenInteractionPanel?.Hide();
                    Panels.Instance?.HideAllRightPanels();
                    Panels.Instance?.HideAllCenterPanels();
                    Managers.Instance?.GameFlowManager?.OnStoryFragmentStart();

                    convPanel.isWarConversation = false;
                    convPanel.isMinimizable = false;
                    convPanel.gameObject.SetActive(true);
                    if (convPanel.inputBlockerPanel != null)
                    {
                        convPanel.inputBlockerPanel.gameObject.SetActive(true);
                    }

                    ConversationData cd = null;
                    var convList = EntityDataManager.ConversationsData;
                    if (convList != null)
                    {
                        for (int i = 0; i < convList.Count; i++)
                        {
                            var c = convList[i];
                            if (c != null && (c.NameInDatabase == "Turn_Zille_WarBriefing" || c.NameInDatabase == "Zille/WarCouncil_Briefing"))
                            {
                                cd = c;
                                break;
                            }
                        }
                    }

                    if (cd != null)
                    {
                        var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                        if (gfm != null)
                        {
                            gfm.OnStoryFragmentStart();
                        }
                    }

                    System.Action onFinish = () => {
                        try
                        {
                            var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                            if (gfm != null && cd != null)
                            {
                                gfm.FinishStoryFragment(cd, null);
                            }
                            Panels.Instance?.ShowHUD();
                        }
                        catch (Exception ex)
                        {
                            MelonLogger.Warning($"[WAR ENGINE] OnFinish briefing error: {ex.Message}");
                        }
                    };

                    if (cd != null)
                    {
                        convPanel.Setup(cd, onFinish, false);
                    }
                    else
                    {
                        convPanel.ForceStartConversation("Zille/WarCouncil_Briefing");
                    }

                    // Populate conversant portraits for Titus, Lucita, and Hugo in ConversationPanel
                    var chars = EntityDataManager.CharactersData;
                    if (chars != null)
                    {
                        for (int i = 0; i < chars.Count; i++)
                        {
                            var ch = chars[i];
                            if (ch == null) continue;
                            string cName = ch.CharacterName ?? ch.NameInDatabase ?? "";
                            if (cName.IndexOf("Titus", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                cName.IndexOf("Lucita", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                cName.IndexOf("Hugo", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                convPanel.AddConversant(ch);
                            }
                        }
                    }

                    convPanel.Show();
                    MelonLogger.Msg("[WAR ENGINE] Native ConversationPanel opened for Zille War Council!");
                    return true;
                }
                else
                {
                    MelonLogger.Warning("[WAR ENGINE] ConversationPanel not found, using DialogueManager fallback.");
                    DialogueManager.StartConversation("Zille/WarCouncil_Briefing");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] DialogueManager.StartConversation failed: {ex.Message}");
                return false;
            }
        }

        // ================= SCHEDULED THEATRE TRANSITION =================

        public static void ScheduleWarTheatreTransition()
        {
            _transitionScheduled = true;
            _transitionTimer = 0.5f;
        }

        public static void CheckScheduledTransition(float deltaTime)
        {
            if (!_transitionScheduled) return;

            _transitionTimer -= deltaTime;
            if (_transitionTimer <= 0f)
            {
                _transitionScheduled = false;
                EnterZilleWarTheatre();
            }
        }

        // ================= NATIVE 3D ZILLE WAR THEATRE =================

        public static WarOperation SetupCustomZilleOperation()
        {
            if (_customOperationConfigured && _zilleWarOp != null && _zilleWarOp.gameObject != null)
            {
                return _zilleWarOp;
            }

            try
            {
                var palesOps = GameObject.Find("Pales Operations Container");
                if (palesOps == null)
                {
                    var allContainers = Resources.FindObjectsOfTypeAll<GameObject>();
                    for (int i = 0; i < allContainers.Length; i++)
                    {
                        if (allContainers[i] != null && allContainers[i].name == "Pales Operations Container")
                        {
                            palesOps = allContainers[i];
                            break;
                        }
                    }
                }

                if (palesOps == null) return null;

                palesOps.SetActive(true);

                // 1. Find Operation_1 template
                GameObject op1Obj = null;
                GameObject zilleOpObj = null;
                for (int i = 0; i < palesOps.transform.childCount; i++)
                {
                    var child = palesOps.transform.GetChild(i);
                    if (child == null) continue;
                    if (child.name == "Operation_1") op1Obj = child.gameObject;
                    else if (child.name == "Operation_Zille_1") zilleOpObj = child.gameObject;
                }

                if (op1Obj == null)
                {
                    var allOps = Resources.FindObjectsOfTypeAll<GameObject>();
                    for (int i = 0; i < allOps.Length; i++)
                    {
                        if (allOps[i] != null && allOps[i].name == "Operation_1")
                        {
                            op1Obj = allOps[i];
                            break;
                        }
                    }
                }

                if (op1Obj == null) return null;

                var palesWarOp = op1Obj.GetComponent<WarOperation>();
                if (palesWarOp == null) return null;

                // 2. Instantiate or get Operation_Zille_1
                if (zilleOpObj == null)
                {
                    zilleOpObj = UnityEngine.Object.Instantiate(op1Obj, palesOps.transform);
                    zilleOpObj.name = "Operation_Zille_1";
                    MelonLogger.Msg("[WAR ENGINE] Instantiated new Operation_Zille_1 GameObject under Pales Operations Container!");
                }

                var zilleWarOp = zilleOpObj.GetComponent<WarOperation>();
                if (zilleWarOp == null)
                {
                    zilleWarOp = zilleOpObj.AddComponent<WarOperation>();
                }

                // 3. Clone and configure WarOperationData ScriptableObject
                WarOperationData zilleOpData = null;
                if (palesWarOp.warOperationData != null)
                {
                    zilleOpData = ScriptableObject.Instantiate(palesWarOp.warOperationData);
                }
                else
                {
                    zilleOpData = ScriptableObject.CreateInstance<WarOperationData>();
                }

                zilleOpData.name = "Operation_Zille_1_Data";
                zilleOpData.operationNameInDatabase = "Operation_Zille_1";

                // Configure included tile names
                var config = ZilleMapLayoutManager.CurrentConfig;
                zilleOpData.includedTileNames = new Il2CppSystem.Collections.Generic.List<string>();
                if (config != null && config.Tiles != null)
                {
                    for (int i = 0; i < config.Tiles.Count; i++)
                    {
                        zilleOpData.includedTileNames.Add(config.Tiles[i].Id);
                    }
                }
                else
                {
                    zilleOpData.includedTileNames.Add("tile_zille");
                    zilleOpData.includedTileNames.Add("tile_munat");
                    zilleOpData.includedTileNames.Add("tile_wiktrany");
                    zilleOpData.includedTileNames.Add("tile_nanta");
                    zilleOpData.includedTileNames.Add("tile_brenas");
                }

                // Configure tactical tile data
                zilleOpData.tileData = new Il2CppSystem.Collections.Generic.List<ConditionalWarTileData>();
                var condTileData = new ConditionalWarTileData();
                condTileData.condition = "";
                condTileData.tiles = new Il2CppSystem.Collections.Generic.List<WarTileData>();

                var tBrenas = new WarTileData();
                tBrenas.tileName = "tile_brenas";
                tBrenas.startingAllegiance = WarToken.WarAllegiance.Player;
                tBrenas.isInitialDeploymentTile = true;
                tBrenas.isBorderTile = true;
                tBrenas.fortLevel = 0;
                condTileData.tiles.Add(tBrenas);

                var tWiktrany = new WarTileData();
                tWiktrany.tileName = "tile_wiktrany";
                tWiktrany.startingAllegiance = WarToken.WarAllegiance.Enemy;
                tWiktrany.isInitialDeploymentTile = false;
                tWiktrany.fortLevel = 1;
                condTileData.tiles.Add(tWiktrany);

                var tMunat = new WarTileData();
                tMunat.tileName = "tile_munat";
                tMunat.startingAllegiance = WarToken.WarAllegiance.Enemy;
                tMunat.isInitialDeploymentTile = false;
                tMunat.isShoreTile = true;
                tMunat.fortLevel = 0;
                condTileData.tiles.Add(tMunat);

                var tNanta = new WarTileData();
                tNanta.tileName = "tile_nanta";
                tNanta.startingAllegiance = WarToken.WarAllegiance.Enemy;
                tNanta.isInitialDeploymentTile = false;
                tNanta.fortLevel = 0;
                condTileData.tiles.Add(tNanta);

                var tZille = new WarTileData();
                tZille.tileName = "tile_zille";
                tZille.startingAllegiance = WarToken.WarAllegiance.Enemy;
                tZille.isInitialDeploymentTile = false;
                tZille.fortLevel = 2;
                tZille.tileDefenceType = WarTile.TileDefenceType.FortifiedDefencePoint;
                condTileData.tiles.Add(tZille);

                zilleOpData.tileData.Add(condTileData);

                // Extract City Unit Type from Pales operation template
                WarUnitTypeData cityUnitType = null;
                if (palesWarOp.warOperationData?.playerCityTokens != null && palesWarOp.warOperationData.playerCityTokens.Count > 0)
                {
                    var c = palesWarOp.warOperationData.playerCityTokens[0];
                    if (c?.tokens != null && c.tokens.Count > 0) cityUnitType = c.tokens[0].unitType;
                }
                if (cityUnitType == null && palesWarOp.warOperationData?.enemyCityTokens != null && palesWarOp.warOperationData.enemyCityTokens.Count > 0)
                {
                    var c = palesWarOp.warOperationData.enemyCityTokens[0];
                    if (c?.tokens != null && c.tokens.Count > 0) cityUnitType = c.tokens[0].unitType;
                }

                // Configure Player Cities (Brenas staging base)
                zilleOpData.playerCityTokens = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                if (cityUnitType != null)
                {
                    var playerCities = new ConditionalWarTokenData();
                    playerCities.condition = "";
                    playerCities.tokens = new Il2CppSystem.Collections.Generic.List<WarTokenData>();

                    var brenasCity = new WarTokenData();
                    brenasCity.startingTileName = "tile_brenas";
                    brenasCity.guid = "city_brenas";
                    brenasCity.allegiance = WarToken.WarAllegiance.Player;
                    brenasCity.unitType = cityUnitType;
                    playerCities.tokens.Add(brenasCity);

                    zilleOpData.playerCityTokens.Add(playerCities);
                }

                // Configure Enemy Cities (Zille, Munat, Wiktrany, Nanta)
                zilleOpData.enemyCityTokens = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                if (cityUnitType != null)
                {
                    var enemyCities = new ConditionalWarTokenData();
                    enemyCities.condition = "";
                    enemyCities.tokens = new Il2CppSystem.Collections.Generic.List<WarTokenData>();

                    string[] enemyCityTiles = new string[] { "tile_zille", "tile_munat", "tile_wiktrany", "tile_nanta" };
                    for (int c = 0; c < enemyCityTiles.Length; c++)
                    {
                        var cToken = new WarTokenData();
                        cToken.startingTileName = enemyCityTiles[c];
                        cToken.guid = $"city_{enemyCityTiles[c]}";
                        cToken.allegiance = WarToken.WarAllegiance.Enemy;
                        cToken.unitType = cityUnitType;
                        enemyCities.tokens.Add(cToken);
                    }

                    zilleOpData.enemyCityTokens.Add(enemyCities);
                }

                // Extract Infantry and Tank Unit Types for Wehlen garrisons
                WarUnitTypeData infUnitType = null;
                WarUnitTypeData tankUnitType = null;
                if (palesWarOp.warOperationData?.enemyTokens != null)
                {
                    for (int e = 0; e < palesWarOp.warOperationData.enemyTokens.Count; e++)
                    {
                        var cond = palesWarOp.warOperationData.enemyTokens[e];
                        if (cond?.tokens != null)
                        {
                            for (int t = 0; t < cond.tokens.Count; t++)
                            {
                                var ut = cond.tokens[t]?.unitType;
                                if (ut == null) continue;
                                string uName = (ut.unitName ?? ut.name ?? "").ToLowerInvariant();
                                if (infUnitType == null && uName.Contains("infantry")) infUnitType = ut;
                                if (tankUnitType == null && (uName.Contains("tank") || uName.Contains("armor") || uName.Contains("panzer"))) tankUnitType = ut;
                            }
                        }
                    }
                }

                zilleOpData.enemyTokens = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                var garrisonCond = new ConditionalWarTokenData();
                garrisonCond.condition = "";
                garrisonCond.tokens = new Il2CppSystem.Collections.Generic.List<WarTokenData>();

                if (infUnitType != null)
                {
                    var infWik = new WarTokenData();
                    infWik.startingTileName = "tile_wiktrany";
                    infWik.guid = "wehlen_inf_wiktrany";
                    infWik.allegiance = WarToken.WarAllegiance.Enemy;
                    infWik.unitType = infUnitType;
                    garrisonCond.tokens.Add(infWik);

                    var infZille = new WarTokenData();
                    infZille.startingTileName = "tile_zille";
                    infZille.guid = "wehlen_inf_zille";
                    infZille.allegiance = WarToken.WarAllegiance.Enemy;
                    infZille.unitType = infUnitType;
                    garrisonCond.tokens.Add(infZille);
                }

                if (tankUnitType != null)
                {
                    var tankZille = new WarTokenData();
                    tankZille.startingTileName = "tile_zille";
                    tankZille.guid = "wehlen_tank_zille";
                    tankZille.allegiance = WarToken.WarAllegiance.Enemy;
                    tankZille.unitType = tankUnitType;
                    garrisonCond.tokens.Add(tankZille);
                }

                if (garrisonCond.tokens.Count > 0)
                {
                    zilleOpData.enemyTokens.Add(garrisonCond);
                }

                zilleWarOp.warOperationData = zilleOpData;

                // 4. Register in Managers.Instance.Operations
                if (Managers.Instance?.Operations != null && !Managers.Instance.Operations.Contains(zilleWarOp))
                {
                    Managers.Instance.Operations.Add(zilleWarOp);
                    MelonLogger.Msg("[WAR ENGINE] Added Operation_Zille_1 to Managers.Instance.Operations!");
                }

                // 5. Activate Operation_Zille_1 and deactivate Pales operations
                zilleOpObj.SetActive(true);
                op1Obj.SetActive(false);

                for (int i = 0; i < palesOps.transform.childCount; i++)
                {
                    var child = palesOps.transform.GetChild(i);
                    if (child != null && child.name != "Operation_Zille_1")
                    {
                        child.gameObject.SetActive(false);
                    }
                }

                // 6. Point WarOperationManager to our custom operation
                var wom = Managers.Instance?.WarOperationManager ?? UnityEngine.Object.FindObjectOfType<WarOperationManager>();
                if (wom != null)
                {
                    wom.currentOperation = zilleWarOp;
                }

                _customOperationConfigured = true;
                _zilleWarOp = zilleWarOp;
                MelonLogger.Msg("[WAR ENGINE] Dedicated Operation_Zille_1 active and synchronized!");
                return zilleWarOp;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] SetupCustomZilleOperation: {ex.Message}");
                return null;
            }
        }

        public static bool EnterZilleWarTheatre()
        {
            MelonLogger.Msg("============================================================");
            MelonLogger.Msg("[WAR ENGINE] Entering Native 3D Zille War Theatre via WarFlowManager...");
            MelonLogger.Msg("============================================================");

            try
            {
                CurrentTheatre = ActiveWarTheatre.Zille;
                _tilesConfiguredForZille = false;
                _tableTextureApplied = false;

                // Ensure textures are loaded into GPU memory and native entities registered
                ZilleMapLayoutManager.EnsureTexturesLoaded();
                RegisterNativeZilleEntities();

                // 1. Fetch WarFragmentData for Zille
                WarFragmentData wfd = null;
                var warFragments = EntityDataManager.WarFragmentsData;
                if (warFragments != null)
                {
                    for (int i = 0; i < warFragments.Count; i++)
                    {
                        if (warFragments[i] != null && warFragments[i].NameInDatabase == "WarFragment_Zille_1_1")
                        {
                            wfd = warFragments[i];
                            break;
                        }
                    }
                }

                // 2. Setup custom Zille 3D operation in scene
                SetupCustomZilleOperation();

                // 3. Ensure Map is switched to 3D War Map
                var mapManager = Managers.Instance?.MapManager ?? UnityEngine.Object.FindObjectOfType<MapManager>();
                if (mapManager != null)
                {
                    mapManager.LoadMap(MapConfiguration.MapType.War);
                }

                // 4. Launch native WarFlowManager!
                var warFlowMgr = Managers.Instance?.WarFlowManager ?? UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (warFlowMgr != null && wfd != null)
                {
                    MelonLogger.Msg("[WAR ENGINE] Starting native WarFlowManager with WarFragment_Zille_1_1!");
                    warFlowMgr.SetupWarFragment(wfd);
                }

                // 5. Lock table background to Zille composite map & modular tiles
                ApplyWarTableTexture();

                // 6. Setup and Show WarDeploymentPanel
                ActivateWarDeploymentPanel();

                DialogueHelper.ShowAlert("[Teatr Zille] Operacja: Righteous Sword - Faza I aktywna. Obsadz sektory operacyjne.");
                return true;
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] Error entering Zille War Theatre: {ex.Message}\n{ex.StackTrace}");
                DialogueHelper.ShowAlert($"[Blad Wojny Zille]: {ex.Message}");
            }
            return false;
        }

        // ================= PERSISTENT THEATRE SYNCHRONIZATION (CALLED EVERY FRAME) =================

        public static void UpdateWarTheatreState()
        {
            if (CurrentTheatre != ActiveWarTheatre.Zille) return;

            try
            {
                // 1. Maintain Table Texture
                ApplyWarTableTexture();

                // 2. Configure WarTiles once WarTileManager has active tiles ready
                if (!_tilesConfiguredForZille)
                {
                    var tileMgr = UnityEngine.Object.FindObjectOfType<WarTileManager>() ?? Managers.Instance?.WarTileManager;
                    if (tileMgr != null && tileMgr.allTiles != null && tileMgr.allTiles.Count > 0)
                    {
                        var palesBg = GameObject.Find("PalesWarMapBackground");
                        AlignNativeWarTilesWithZilleLayout(palesBg);
                        _tilesConfiguredForZille = true;
                        MelonLogger.Msg($"[WAR THEATRE] Successfully configured {tileMgr.allTiles.Count} war tiles for Zille campaign!");
                    }
                }

                // 3. Ensure WarDeploymentPanel is active for placing units
                ActivateWarDeploymentPanel();
            }
            catch { }
        }

        private static void ApplyWarTableTexture()
        {
            var zilleTex = ZilleMapLayoutManager.FullMapTexture ?? ZilleMapLayoutManager.MapBackgroundTexture;
            if (zilleTex == null) return;

            GameObject palesBg = GameObject.Find("PalesWarMapBackground");
            if (palesBg == null)
            {
                var all = Resources.FindObjectsOfTypeAll<GameObject>();
                for (int i = 0; i < all.Length; i++)
                {
                    if (all[i] != null && all[i].name == "PalesWarMapBackground") { palesBg = all[i]; break; }
                }
            }

            if (palesBg != null)
            {
                palesBg.SetActive(true);
                var renderers = palesBg.GetComponentsInChildren<Renderer>(true);
                for (int r = 0; r < renderers.Length; r++)
                {
                    var rend = renderers[r];
                    if (rend != null) ApplyTexturesToRenderer(rend, zilleTex);
                }
            }

            // Also inspect Map Container and Pales Operations Container
            var containers = new string[] { "Map Container", "Pales Operations Container", "War Map" };
            for (int c = 0; c < containers.Length; c++)
            {
                var cnt = GameObject.Find(containers[c]);
                if (cnt != null)
                {
                    var renderers = cnt.GetComponentsInChildren<Renderer>(true);
                    for (int r = 0; r < renderers.Length; r++)
                    {
                        var rend = renderers[r];
                        if (rend == null) continue;
                        string rName = rend.gameObject.name ?? "";
                        if (rName.Contains("Map") || rName.Contains("Background") || rName.Contains("Plane") || rName.Contains("Table"))
                        {
                            ApplyTexturesToRenderer(rend, zilleTex);
                        }
                    }
                }
            }
        }

        private static void ApplyTexturesToRenderer(Renderer rend, Texture2D fallbackTex)
        {
            if (rend == null) return;

            string rName = rend.gameObject.name ?? "";
            Texture2D specificTile = null;
            for (int t = 1; t <= 6; t++)
            {
                if (rName.Contains($"0{t}") || rName.Contains($"Tile_{t}") || rName.Contains($"_{t}"))
                {
                    if (ZilleMapLayoutManager.GridMapTiles.TryGetValue(t, out var tileTex))
                    {
                        specificTile = tileTex;
                        break;
                    }
                }
            }

            var texToUse = specificTile ?? fallbackTex;

            if (rend.materials != null)
            {
                for (int m = 0; m < rend.materials.Length; m++)
                {
                    var mat = rend.materials[m];
                    if (mat == null) continue;
                    ApplyTextureToMaterial(mat, texToUse);
                }
            }

            if (rend.sharedMaterials != null)
            {
                for (int m = 0; m < rend.sharedMaterials.Length; m++)
                {
                    var mat = rend.sharedMaterials[m];
                    if (mat == null) continue;
                    ApplyTextureToMaterial(mat, texToUse);
                }
            }
        }

        private static void ApplyTextureToMaterial(Material mat, Texture2D tex)
        {
            if (mat == null || tex == null) return;
            if (mat.HasProperty("_BaseMap")) mat.SetTexture("_BaseMap", tex);
            if (mat.HasProperty("_MainTex")) mat.SetTexture("_MainTex", tex);
            if (mat.HasProperty("_Tile_Texture")) mat.SetTexture("_Tile_Texture", tex);
            if (mat.HasProperty("_BaseColor")) mat.SetColor("_BaseColor", Color.white);
            if (mat.HasProperty("_Color")) mat.SetColor("_Color", Color.white);
        }

        private static void AlignNativeWarTilesWithZilleLayout(GameObject palesBg)
        {
            try
            {
                var tileMgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
                if (tileMgr == null && Managers.Instance != null) tileMgr = Managers.Instance.WarTileManager;
                if (tileMgr == null)
                {
                    var allTileMgrs = Resources.FindObjectsOfTypeAll<WarTileManager>();
                    if (allTileMgrs.Length > 0) tileMgr = allTileMgrs[0];
                }

                List<WarTile> tilesList = new List<WarTile>();
                if (tileMgr != null && tileMgr.allTiles != null && tileMgr.allTiles.Count > 0)
                {
                    for (int i = 0; i < tileMgr.allTiles.Count; i++)
                    {
                        var t = tileMgr.allTiles[i];
                        if (t != null) tilesList.Add(t);
                    }
                }
                else
                {
                    var found = Resources.FindObjectsOfTypeAll<WarTile>();
                    if (found != null)
                    {
                        for (int i = 0; i < found.Length; i++)
                        {
                            if (found[i] != null) tilesList.Add(found[i]);
                        }
                    }
                }

                if (tilesList.Count == 0) return;

                var config = ZilleMapLayoutManager.CurrentConfig;
                if (config == null || config.Tiles == null || config.Tiles.Count == 0) return;

                Vector3 tablePos = palesBg != null ? palesBg.transform.position : new Vector3(0f, 0.05f, 0f);
                Vector3 tableScale = palesBg != null ? palesBg.transform.localScale : new Vector3(2.4f, 1.6f, 1f);

                int zilleCount = config.Tiles.Count;
                int totalTiles = tilesList.Count;

                MelonLogger.Msg($"[WAR ENGINE] Positioning {zilleCount} Zille WarTiles on table...");

                if (_originalTilePositions.Count == 0)
                {
                    for (int i = 0; i < totalTiles; i++)
                    {
                        var t = tilesList[i];
                        _originalTilePositions.Add(t.transform.position);
                        _originalTileScales.Add(t.transform.localScale);
                    }
                }

                for (int i = 0; i < totalTiles; i++)
                {
                    var warTile = tilesList[i];
                    if (warTile == null) continue;

                    if (i < zilleCount)
                    {
                        var tileData = config.Tiles[i];
                        warTile.gameObject.name = tileData.Id;
                        warTile.gameObject.SetActive(true);

                        // Position aligned with 3x2 map table coordinate space
                        float normX = tileData.NormalizedX - 0.5f;
                        float normY = 0.5f - tileData.NormalizedY;
                        Vector3 targetPos = tablePos + new Vector3(normX * tableScale.x * 0.72f, 0.005f, normY * tableScale.y * 0.72f);
                        warTile.transform.position = targetPos;

                        // Native tactical scale derived from original Pales tile dimensions
                        Vector3 baseScale = (_originalTileScales.Count > i && _originalTileScales[i].magnitude > 0.001f) 
                            ? _originalTileScales[i] 
                            : new Vector3(0.08f, 0.08f, 0.08f);
                        float scaleMult = (tileData.Width > 100f) ? (tileData.Width / 512f) : (tileData.Width / 32f);
                        if (scaleMult < 0.8f) scaleMult = 0.8f;
                        if (scaleMult > 1.25f) scaleMult = 1.25f;
                        warTile.transform.localScale = baseScale * scaleMult;

                        // Region Texture & Material Opacity (No magenta shader errors)
                        if (ZilleMapLayoutManager.LoadedTextures.TryGetValue(tileData.TextureFile, out Texture2D regionTex) && regionTex != null)
                        {
                            warTile.warTileTexture = regionTex;
                            var rend = warTile.GetWarTileRenderer();
                            if (rend != null && rend.material != null)
                            {
                                if (rend.material.HasProperty("_BaseMap")) rend.material.SetTexture("_BaseMap", regionTex);
                                if (rend.material.HasProperty("_MainTex")) rend.material.SetTexture("_MainTex", regionTex);
                                if (rend.material.HasProperty("_BaseColor")) rend.material.SetColor("_BaseColor", new Color(1f, 1f, 1f, 0.88f));
                                if (rend.material.HasProperty("_Color")) rend.material.SetColor("_Color", new Color(1f, 1f, 1f, 0.88f));
                            }
                        }

                        // Tactical Allegiance & Initial Deployment Permissions
                        bool isPlayerZone = (i < 2 || tileData.Allegiance == "Rizia");
                        if (warTile.currentWarTileData != null)
                        {
                            warTile.currentWarTileData.isInitialDeploymentTile = isPlayerZone;
                            warTile.currentWarTileData.startingAllegiance = isPlayerZone ? WarToken.WarAllegiance.Player : WarToken.WarAllegiance.Enemy;
                        }

                        if (isPlayerZone)
                        {
                            warTile.SetTilePlayer();
                            warTile.SetIsReinforcementTile(true);
                        }
                        else
                        {
                            warTile.SetTileEnemy();
                            warTile.SetIsReinforcementTile(false);
                        }
                    }
                    else
                    {
                        // Hide excess tiles belonging to Pales theatre
                        warTile.gameObject.SetActive(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] Error aligning WarTiles: {ex.Message}");
            }
        }

        private static void ActivateWarDeploymentPanel()
        {
            try
            {
                var deployPanel = UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
                if (deployPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<WarDeploymentPanel>();
                    if (allPanels.Length > 0) deployPanel = allPanels[0];
                }

                if (deployPanel != null && !deployPanel.gameObject.activeInHierarchy)
                {
                    deployPanel.gameObject.SetActive(true);
                    MelonLogger.Msg("[WAR THEATRE] WarDeploymentPanel successfully activated for Zille campaign!");
                }
            }
            catch { }
        }

        public static void ReturnToCivilianMap()
        {
            MelonLogger.Msg("[WAR ENGINE] Returning to civilian map...");
            CurrentTheatre = ActiveWarTheatre.Civilian;
            _tilesConfiguredForZille = false;
            _tableTextureApplied = false;

            try
            {
                // Restore PalesWarMapBackground texture
                if (_originalPalesTexture != null)
                {
                    var palesBg = GameObject.Find("PalesWarMapBackground");
                    if (palesBg != null)
                    {
                        var rend = palesBg.GetComponent<Renderer>();
                        if (rend != null && rend.material != null)
                        {
                            if (rend.material.HasProperty("_BaseMap")) rend.material.SetTexture("_BaseMap", _originalPalesTexture);
                            if (rend.material.HasProperty("_MainTex")) rend.material.SetTexture("_MainTex", _originalPalesTexture);
                        }
                    }
                }

                // Restore Pales Operations Container
                var palesOps = GameObject.Find("Pales Operations Container");
                if (palesOps != null) palesOps.SetActive(true);

                // Restore tile positions and scales
                var tileMgr = UnityEngine.Object.FindObjectOfType<WarTileManager>();
                if (tileMgr != null && tileMgr.allTiles != null && _originalTilePositions.Count == tileMgr.allTiles.Count)
                {
                    for (int i = 0; i < tileMgr.allTiles.Count; i++)
                    {
                        var t = tileMgr.allTiles[i];
                        if (t != null)
                        {
                            t.gameObject.SetActive(true);
                            t.transform.position = _originalTilePositions[i];
                            t.transform.localScale = _originalTileScales[i];
                        }
                    }
                }

                var mapManager = UnityEngine.Object.FindObjectOfType<MapManager>();
                if (mapManager != null)
                {
                    mapManager.LoadMap(MapConfiguration.MapType.Base);
                }

                DialogueHelper.ShowAlert("[Zille] Powrot do mapy cywilnej.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] ReturnToCivilianMap error: {ex.Message}");
            }
        }
    }
}
