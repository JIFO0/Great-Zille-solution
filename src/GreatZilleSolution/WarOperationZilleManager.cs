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
        public static bool PendingZilleTokenSpawnAfterBriefing { get; set; } = false;

        private static GameObject _spawnedZilleWarToken = null;
        private static Texture _originalPalesTexture = null;
        private static readonly List<Vector3> _originalTilePositions = new List<Vector3>();
        private static readonly List<Vector3> _originalTileScales = new List<Vector3>();
        private static bool _tilesConfiguredForZille = false;
        private static float _theatreEnteredAt = -1000f;

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

        private static Il2CppSystem.Collections.Generic.List<T> GetEntityBackingList<T>(string fieldName)
        {
            try
            {
                var prop = HarmonyLib.AccessTools.Property(typeof(EntityDataManager), "All" + char.ToUpper(fieldName[0]) + fieldName.Substring(1));
                if (prop != null)
                {
                    var val = prop.GetValue(null) as Il2CppSystem.Collections.Generic.List<T>;
                    if (val != null) return val;
                }
                var field = HarmonyLib.AccessTools.Field(typeof(EntityDataManager), fieldName);
                if (field != null)
                {
                    var val = field.GetValue(null) as Il2CppSystem.Collections.Generic.List<T>;
                    if (val != null) return val;
                }
            }
            catch { }
            return null;
        }

        private static AppBundleProperties CreateRiziaBundleProps()
        {
            var props = new AppBundleProperties("StoryPack_Rizia");
            if (props.StoryPacks == null)
            {
                props.StoryPacks = new Il2CppSystem.Collections.Generic.List<string>();
            }
            if (!props.StoryPacks.Contains("StoryPack_Rizia"))
            {
                props.StoryPacks.Add("StoryPack_Rizia");
            }
            return props;
        }

        public static void RegisterNativeZilleEntities()
        {
            try
            {
                // 1. Ensure Conversation is registered in PixelCrushers masterDatabase
                EnsureWarCouncilConversationRegistered();

                // 2. Register ConversationData for Porte Drazon in EntityDataManager
                var allConvList = EntityDataManager.AllConversationsData ?? GetEntityBackingList<ConversationData>("conversationsData");

                ConversationData cd = null;
                if (allConvList != null)
                {
                    for (int i = 0; i < allConvList.Count; i++)
                    {
                        var c = allConvList[i];
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
                    cd.IsWIP = false;
                    cd.Notes = "";
                    cd.AssignedTokenProperties = new AssignedTokenProperties();
                    cd.AssignedTokenProperties.AssignedToken = "Rizia_City_PorteDrazon";
                    cd.StoryFragmentProperties = new StoryFragmentProperties();
                    cd.StoryFragmentProperties.IsDone = false;
                    cd.StoryFragmentProperties.StoryFragmentCondition = "";
                    cd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
                    cd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
                    cd.ConversationProperties = new ConversationProperties();
                    cd.ConversationProperties.Title = "A royal briefing before the invasion of Zille";
                    cd.ConversationProperties.Subtitle = "Council Chambers, Palas Rezna";
                    cd.ConversationProperties.Dialogue = "Zille/WarCouncil_Briefing";
                    cd.ConversationProperties.TypeString = "SecurityAndOrder";
                    cd.ConversationProperties.IsOnStart = false;
                    cd.AppBundleProperties = CreateRiziaBundleProps();

                    if (allConvList != null) allConvList.Add(cd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'A royal briefing before the invasion of Zille' to EntityDataManager.AllConversationsData!");
                }

                // 3. Register WarFragmentData for Zille invasion in EntityDataManager
                var allWarList = EntityDataManager.AllWarFragmentsData ?? GetEntityBackingList<WarFragmentData>("warFragmentData");

                WarFragmentData wfd = null;
                if (allWarList != null)
                {
                    for (int i = 0; i < allWarList.Count; i++)
                    {
                        var w = allWarList[i];
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
                    wfd.IsWIP = false;
                    wfd.Notes = "";
                    wfd.AssignedTokenProperties = new AssignedTokenProperties();
                    wfd.AssignedTokenProperties.AssignedToken = "Rizia_Event_InvasionOfZille";
                    wfd.StoryFragmentProperties = new StoryFragmentProperties();
                    wfd.StoryFragmentProperties.IsDone = false;
                    wfd.StoryFragmentProperties.StoryFragmentCondition = "";
                    wfd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
                    wfd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
                    wfd.WarFragmentProperties = new WarFragmentProperties();
                    wfd.WarFragmentProperties.Operation = "Operation_Zille_1";
                    wfd.WarFragmentProperties.HubWarFragmentTitle = "Operation: Righteous Sword - Phase I";
                    wfd.WarFragmentProperties.HubWarFragmentSubtitle = "Invasion of Zille";
                    wfd.AppBundleProperties = CreateRiziaBundleProps();

                    if (allWarList != null) allWarList.Add(wfd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'Operation: Righteous Sword - Phase I' to EntityDataManager.AllWarFragmentsData!");
                }
                else
                {
                    if (wfd.StoryFragmentProperties != null)
                    {
                        if (wfd.StoryFragmentProperties.StoryFragmentCondition == null) wfd.StoryFragmentProperties.StoryFragmentCondition = "";
                        if (wfd.StoryFragmentProperties.OnStoryFragmentBeginInstruction == null) wfd.StoryFragmentProperties.OnStoryFragmentBeginInstruction = "";
                        if (wfd.StoryFragmentProperties.OnStoryFragmentEndInstruction == null) wfd.StoryFragmentProperties.OnStoryFragmentEndInstruction = "";
                    }
                    if (wfd.WarFragmentProperties != null)
                    {
                        wfd.WarFragmentProperties.Operation = "Operation_Zille_1";
                        wfd.WarFragmentProperties.HubWarFragmentTitle = "Operation: Righteous Sword - Phase I";
                        wfd.WarFragmentProperties.HubWarFragmentSubtitle = "Invasion of Zille";
                    }
                }

                // 4. Register MapTokenData for Rizia_Event_InvasionOfZille into backing list mapTokensData
                var allTokenList = GetEntityBackingList<MapTokenData>("mapTokensData") ?? EntityDataManager.MapTokensData;

                MapTokenData zilleMtd = null;
                if (allTokenList != null)
                {
                    for (int i = 0; i < allTokenList.Count; i++)
                    {
                        var t = allTokenList[i];
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
                    zilleMtd.IsWIP = false;
                    zilleMtd.Notes = "";
                    zilleMtd.MapTokenProperties = new MapTokenProperties();
                    zilleMtd.MapTokenProperties.Title = "Invasion of Zille";
                    zilleMtd.MapTokenProperties.Subtitle = "Military Operation";
                    zilleMtd.MapTokenProperties.ImagePath = "";
                    zilleMtd.MapTokenProperties.SoundEffect = "";
                    zilleMtd.MapTokenProperties.Type = "Event";
                    zilleMtd.MapTokenProperties.IsTokenEnabled = true;
                    zilleMtd.StatusEffectsProperties = new StatusEffectsProperties();
                    zilleMtd.StatusEffectsProperties.HasNewStatusEffect = false;
                    zilleMtd.StatusEffectsProperties.StatusEffects = new Il2CppSystem.Collections.Generic.List<string>();
                    zilleMtd.StatusEffectsProperties.ConditionalStatusEffectGroups = new Il2CppSystem.Collections.Generic.List<string>();
                    zilleMtd.Title = "Invasion of Zille";
                    zilleMtd.Subtitle = "Military Operation";
                    zilleMtd.IsTokenEnabled = true;
                    zilleMtd.AppBundleProperties = CreateRiziaBundleProps();

                    if (allTokenList != null) allTokenList.Add(zilleMtd);
                    MelonLogger.Msg("[WAR ENGINE] Added 'Rizia_Event_InvasionOfZille' to EntityDataManager backing mapTokensData!");
                }

                // 5. Register dedicated OperationData for Operation_Zille_1 into backing list operationData
                var allOps = GetEntityBackingList<OperationData>("operationData") ?? EntityDataManager.OperationData;

                OperationData zilleOp = null;
                if (allOps != null)
                {
                    for (int i = 0; i < allOps.Count; i++)
                    {
                        var op = allOps[i];
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
                    zilleOp.IsWIP = false;
                    zilleOp.Notes = "";
                    zilleOp.OperationProperties = new OperationProperties();
                    zilleOp.OperationProperties.OperationName = "Operation: Righteous Sword";
                    zilleOp.OperationProperties.OperationStartCondition = "";
                    zilleOp.OperationProperties.IsOperationFinishedEarly = "";
                    zilleOp.OperationProperties.ResultConditionalInstruction = "";
                    zilleOp.OperationProperties.WinReport = "";
                    zilleOp.OperationProperties.LoseReport = "";
                    zilleOp.OperationProperties.Phases = new Il2CppSystem.Collections.Generic.List<string>();
                    zilleOp.OperationProperties.Phases.Add("WarFragment_Zille_1_1");
                    zilleOp.OperationProperties.ResultVariable = "War_Zille_Result";
                    zilleOp.OperationProperties.TotalEnemyDeadVariable = "War_Zille_TotalEnemyDead";
                    zilleOp.OperationProperties.TotalPlayerDeadVariable = "War_Zille_TotalPlayerDead";
                    zilleOp.OperationProperties.IsTutorial = false;
                    zilleOp.OperationProperties.IsFinished = false;
                    zilleOp.AppBundleProperties = CreateRiziaBundleProps();

                    if (allOps != null) allOps.Add(zilleOp);
                    MelonLogger.Msg("[WAR ENGINE] Added dedicated 'Operation_Zille_1' (Operation: Righteous Sword) to EntityDataManager backing operationData!");
                }
                else
                {
                    if (zilleOp.OperationProperties != null)
                    {
                        if (zilleOp.OperationProperties.OperationStartCondition == null) zilleOp.OperationProperties.OperationStartCondition = "";
                        if (zilleOp.OperationProperties.IsOperationFinishedEarly == null) zilleOp.OperationProperties.IsOperationFinishedEarly = "";
                        if (zilleOp.OperationProperties.ResultConditionalInstruction == null) zilleOp.OperationProperties.ResultConditionalInstruction = "";
                        if (zilleOp.OperationProperties.WinReport == null) zilleOp.OperationProperties.WinReport = "";
                        if (zilleOp.OperationProperties.LoseReport == null) zilleOp.OperationProperties.LoseReport = "";
                        if (zilleOp.OperationProperties.Phases != null && !zilleOp.OperationProperties.Phases.Contains("WarFragment_Zille_1_1"))
                        {
                            zilleOp.OperationProperties.Phases.Add("WarFragment_Zille_1_1");
                        }
                    }
                }

                // Clean up any previous injection into Operation_1 (so Pales is completely separate)
                if (allOps != null)
                {
                    for (int i = 0; i < allOps.Count; i++)
                    {
                        var op = allOps[i];
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

                Vector3 zilleWarPos = BorderEventPosition();
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
                        MatchTokenHeight(_spawnedZilleWarToken, _borderAnchor);

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

        /// <summary>Prepares Operation_Zille_1 so the pawn's own Suzerain button can play the Pales deployment intro.</summary>
        public static void ArmNativeZilleDeployment()
        {
            EnsureWarSave();
            SetupCustomZilleOperation();
            ZilleWarTable.SkinEnabled = true;
            MelonLogger.Msg("[WAR ENGINE] Armed native Zille deployment. The operation button keeps the Pales intro.");
        }

        /// <summary>SetupWarFragment dies without a war save, which is why the event click never plays the Pales intro.</summary>
        public static void EnsureWarSave()
        {
            try
            {
                var file = PersistenceManager.Instance != null ? PersistenceManager.Instance.activeSaveFile : null;
                var save = file != null ? file.saveData : null;
                if (save == null)
                {
                    MelonLogger.Warning("[WAR ENGINE] No active save file, so the Pales intro cannot store the war.");
                    return;
                }
                var cur = save.warSaveData;
                if (cur == null)
                {
                    cur = new WarSaveData();
                    cur.warFragmentName = "WarFragment_Zille_1_1";
                    save.warSaveData = cur;
                    MelonLogger.Msg("[WAR ENGINE] Created war save data on the active campaign.");
                }
                if (cur.warTokenSaveData == null) cur.warTokenSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarTokenSaveData>();
                if (cur.warBattleSaveData == null) cur.warBattleSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarBattleSaveData>();
                if (cur.warObjectiveSaveData == null) cur.warObjectiveSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarObjectiveSaveData>();
                if (cur.warTileSaveData == null) cur.warTileSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarTileSaveData>();
                if (cur.tileAllegianceChangeSaveData == null) cur.tileAllegianceChangeSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.TileAllegianceChangeSaveData>();
                if (cur.warStartBattleEventSaveData == null) cur.warStartBattleEventSaveData = new Il2CppSystem.Collections.Generic.List<WarSaveData.WarStartBattleEventSaveData>();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[WAR ENGINE] War save: " + ex.Message);
            }
        }

        private static Token _borderAnchor;

        private static Vector3 BorderEventPosition()
        {
            var zille = FindCityToken("zille");
            // Bronaz is the Rizian province that touches Zille. Porte Drazon is the capital, far past that border.
            var rizia = FindCityToken("bronaz") ?? FindCityToken("brenas") ?? FindCityToken("iza");
            _borderAnchor = rizia ?? zille;
            Vector3 zillePos = zille != null ? zille.transform.position : new Vector3(0.4673f, 0.02f, 0.8262f);
            if (rizia != null && zille != null)
            {
                var p = Vector3.Lerp(zillePos, rizia.transform.position, 0.5f);
                p.y = rizia.transform.position.y;
                MelonLogger.Msg($"[WAR ENGINE] Event marker on the Zille–Rizia border at {p} (midpoint of {zille.name} and {rizia.name}).");
                return p;
            }
            var fallback = zillePos + new Vector3(0f, 0f, -0.04f);
            MelonLogger.Msg($"[WAR ENGINE] Event marker south of Zille at {fallback}.");
            return fallback;
        }

        private static Token FindCityToken(string needle)
        {
            Token[] tokens = null;
            try { tokens = UnityEngine.Object.FindObjectsOfType<Token>(); } catch { return null; }
            if (tokens == null) return null;
            needle = needle.ToLowerInvariant();
            for (int i = 0; i < tokens.Length; i++)
            {
                var t = tokens[i];
                if (t == null) continue;
                string name = t.gameObject.name ?? "";
                string blob = (name + " " + (t.tokenDataEntityName ?? "")).ToLowerInvariant();
                if (blob.Contains("event") || blob.Contains("invasion")) continue;
                if (blob.Contains(needle)) return t;
            }
            return null;
        }

        /// <summary>Puts the pawn's collider at the same height as a city token the player can already click.</summary>
        private static void MatchTokenHeight(GameObject go, Token reference)
        {
            if (go == null) return;
            if (reference == null)
            {
                MelonLogger.Warning("[WAR ENGINE] No city token to copy the event height from.");
                return;
            }
            var refCol = reference.GetComponentInChildren<Collider>();
            var cols = go.GetComponentsInChildren<Collider>(true);
            float refY = refCol != null ? refCol.bounds.center.y : reference.transform.position.y;
            float myY = refY;
            if (cols != null && cols.Length > 0 && cols[0] != null) myY = cols[0].bounds.center.y;
            float dy = refY - myY;
            if (Mathf.Abs(dy) > 0.002f)
                go.transform.position += new Vector3(0f, dy, 0f);
            MelonLogger.Msg($"[WAR ENGINE] Event hitbox matched to {reference.name}. Collider center {go.transform.position}.");
        }

        /// <summary>Drops the pawn so the bottom of its collider sits on the map, not above the province.</summary>
        private static void SeatTokenOnMap(GameObject go, float mapY)
        {
            if (go == null) return;
            var cols = go.GetComponentsInChildren<Collider>(true);
            float minY = float.MaxValue;
            bool any = false;
            for (int i = 0; i < cols.Length; i++)
            {
                var c = cols[i];
                if (c == null) continue;
                any = true;
                if (c.bounds.min.y < minY) minY = c.bounds.min.y;
            }
            if (!any)
            {
                var p = go.transform.position;
                go.transform.position = new Vector3(p.x, mapY, p.z);
                return;
            }
            float dy = minY - mapY;
            if (Mathf.Abs(dy) > 0.004f)
                go.transform.position -= new Vector3(0f, dy, 0f);
            MelonLogger.Msg($"[WAR ENGINE] Event hitbox seated. Bottom was {minY:F3}, map Y {mapY:F3}, now {go.transform.position}.");
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
                int narratorId = 10; // Narrator
                int romusId = 95;    // Player_Romus
                int titusId = 81;    // Titus Gordion
                int lucitaId = 73;   // Lucita Azaro
                int hugoId = 68;     // Hugo Toras
                int laurentoId = 70; // Laurento Esquibel

                if (db.actors != null)
                {
                    for (int i = 0; i < db.actors.Count; i++)
                    {
                        var a = db.actors[i];
                        if (a == null) continue;
                        string aName = a.Name ?? "";
                        if (aName.Equals("Narrator", StringComparison.OrdinalIgnoreCase)) narratorId = a.id;
                        else if (aName.Equals("Player_Romus", StringComparison.OrdinalIgnoreCase)) romusId = a.id;
                        else if (aName.IndexOf("Titus", StringComparison.OrdinalIgnoreCase) >= 0) titusId = a.id;
                        else if (aName.IndexOf("Lucita", StringComparison.OrdinalIgnoreCase) >= 0) lucitaId = a.id;
                        else if (aName.IndexOf("Hugo", StringComparison.OrdinalIgnoreCase) >= 0) hugoId = a.id;
                        else if (aName.IndexOf("Laurento", StringComparison.OrdinalIgnoreCase) >= 0) laurentoId = a.id;
                    }
                }

                var conv = new Conversation();
                conv.id = 9988;
                conv.fields = new Il2CppSystem.Collections.Generic.List<Field>();
                conv.dialogueEntries = new Il2CppSystem.Collections.Generic.List<DialogueEntry>();
                conv.Title = convTitle;
                conv.ActorID = romusId;
                conv.ConversantID = lucitaId;

                // --- Query Savegame Variables ---
                int budget = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Budget");
                if (budget == 0) budget = DialogueHelper.GetIntVariable("Budget");
                int energy = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Energy");
                int authority = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Authority");
                int manpower = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Military_Manpower");
                int equipment = DialogueHelper.GetIntVariable("RiziaDLC.Resources_Military_Equipment");

                bool lucitaMarried = DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Married") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Marriage_Happened") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLCSupport.Journal_Turn08_Lucita_Married");
                bool lucitaRomance = lucitaMarried ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.Relations_Lucita_Together") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_RomanceHappened") ||
                                     DialogueHelper.GetIntVariable("RiziaDLC.Relations_Lucita_Romance") > 0;
                bool lucitaPregnant = DialogueHelper.GetBoolVariable("RiziaDLC.Lucita_Pregnant");

                bool lespiaAllied = DialogueHelper.GetBoolVariable("RiziaDLC.CountryRelation_Lespia_Allied") ||
                                    DialogueHelper.GetBoolVariable("RiziaDLC.CountryRelation_Lespia_Friendly") ||
                                    DialogueHelper.GetBoolVariable("RiziaDLC.Diplomacy_Lespia_WehlenHelp") ||
                                    DialogueHelper.GetBoolVariable("RiziaDLCIsolated.Lespia_Alvarez_Cooperative") ||
                                    ZilleCampaignState.IsLespiaPactAccepted;
                bool lespiaHostile = DialogueHelper.GetBoolVariable("RiziaDLC.CountryRelation_Lespia_Hostile") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.MITZ_ScrewedOverLespia");

                bool suOminaStrong = DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Zille_StrongArmedResistance") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Zille_GrowingArmedResistance") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.Decision_Turn05_ZilleResistanceFunding_BeginSOFund") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.Decision_Turn05_ZilleResistanceFunding_IncreasedSOFund") ||
                                     DialogueHelper.GetBoolVariable("RiziaDLC.Prologue_JoinedSuOmina");
                bool ataFunded = DialogueHelper.GetBoolVariable("RiziaDLC.Decision_Turn05_ZilleResistanceFunding_BeginATAFund") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Decision_Turn05_ZilleResistanceFunding_IncreasedATAFund") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Zille_GrowingRiziaMovement") ||
                                 DialogueHelper.GetBoolVariable("RiziaDLC.Situation_Diplomacy_Zille_MassiveRiziaMovement");
                bool palesWarActive = DialogueHelper.GetBoolVariable("RiziaDLC.Pales_War") || ZilleCampaignState.IsTwoFrontWarThreat();

                DialogueEntry AddLine(int id, int speaker, int listener, string title, string text, int nextId = -1)
                {
                    var e = CreateDialogueEntry(conv.id, id, speaker, listener, title, text);
                    if (nextId >= 0) e.outgoingLinks.Add(CreateLink(conv.id, id, nextId));
                    conv.dialogueEntries.Add(e);
                    return e;
                }

                DialogueEntry AddChoice(int id, int listener, string title, string menuText, string spokenText, int nextId, string script = "")
                {
                    var e = CreateDialogueEntry(conv.id, id, romusId, listener, title, spokenText, menuText);
                    if (!string.IsNullOrEmpty(script)) e.userScript = script;
                    if (nextId >= 0) e.outgoingLinks.Add(CreateLink(conv.id, id, nextId));
                    conv.dialogueEntries.Add(e);
                    return e;
                }

                // Entry 0: START
                var entry0 = CreateDialogueEntry(conv.id, 0, romusId, lucitaId, "START", "", "", "Continue()");
                entry0.isRoot = true;
                entry0.outgoingLinks.Add(CreateLink(conv.id, 0, 1));
                conv.dialogueEntries.Add(entry0);

                // --- OPENING SEQUENCE (Entries 1 to 16) ---
                AddLine(1, narratorId, romusId, "Intro_Narrator_1",
                    "The heavy oak doors of the Palas Rezna war chamber were bolted shut. Across the polished mahogany table lay an expansive topographical relief map of the Zille province, marked with brass pins and crimson operational arrows.", 2);

                AddLine(2, hugoId, romusId, "Intro_Hugo_1",
                    "Your Majesty. The Grand Vizier's office and the High Command have finalized the operational dossiers for the reclamation of Zille.", 3);

                AddLine(3, hugoId, romusId, "Intro_Hugo_2",
                    "For too long, President Wiktor Smolak has treated our ancestral homeland as his personal bargaining chip. Yet crossing the river with royal divisions will alter the balance of South Merkopa forever.", 4);

                if (lucitaMarried)
                {
                    AddLine(4, narratorId, romusId, "Intro_Lucita_Narrator",
                        "Lucita stood at the head of the tactical map. As both your War Councilor and your Queen Consort, her gaze carried a rare blend of fierce Azaro resolve and quiet personal devotion.", 5);
                    AddLine(5, lucitaId, romusId, "Intro_Lucita_Greeting",
                        "My love—Your Majesty. The General Staff has completed its mobilization schedule along the Brenas frontier. Our commanders await only the Crown's word.", 6);
                }
                else if (lucitaRomance)
                {
                    AddLine(4, narratorId, romusId, "Intro_Lucita_Narrator",
                        "Lucita leaned over the southern sector of the map. Catching your eye, her expression softened for a fleeting heartbeat before returning to the crisp composure of a general.", 5);
                    AddLine(5, lucitaId, romusId, "Intro_Lucita_Greeting",
                        "Your Majesty. Everything we have discussed in private is now positioned on the field. The Azaro levies and the Royal Army are primed along the Brenas staging grounds.", 6);
                }
                else
                {
                    AddLine(4, narratorId, romusId, "Intro_Lucita_Narrator",
                        "War Councilor Lucita Azaro stood rigid beside the southern frontier markers, her baton resting against the fortified hills of Zille.", 5);
                    AddLine(5, lucitaId, romusId, "Intro_Lucita_Greeting",
                        "Your Majesty. The Ministry of War has concluded its readiness audit. Our forward divisions are positioned along the Brenas line, awaiting your operational directive.", 6);
                }

                // Military readiness line based on savegame state
                string milReadinessLine;
                if (palesWarActive)
                {
                    milReadinessLine = "I must be candid: with a substantial portion of our royal forces already committed to the Palesian theatre, opening a second front against Wehlen will stretch our reserves thin.";
                }
                else if (manpower >= 3000 && equipment >= 1500)
                {
                    milReadinessLine = "Our barracks are well-staffed and our arsenals are thoroughly stocked. We possess the armored mobility and firepower needed to overwhelm Smolak's garrison before reinforcement columns can arrive.";
                }
                else
                {
                    milReadinessLine = "While our frontline brigades are disciplined, our equipment stockpiles and trained reserves are modest. We cannot afford a protracted war of attrition in the hills.";
                }
                AddLine(6, lucitaId, romusId, "Intro_Lucita_Readiness", milReadinessLine, 7);

                // Titus Gordion (Intelligence & Internal Resistance)
                AddLine(7, titusId, romusId, "Intro_Titus_1",
                    "From an intelligence standpoint, Sire, the Golden Guard's couriers inside Zille confirm that Colonel Valdez commands four regular Wehzek brigades, backed by Smolak's irregular security detachments.", 8);

                string resistanceLine;
                if (suOminaStrong && ataFunded)
                {
                    resistanceLine = "Fortunately, our covert investments have paid off handsomely. Both the Su Omina cells and the Zille Association networks are deeply entrenched. The moment our guns open fire, they will sever Wehzek rail lines and paralyze Valdez's rear.";
                }
                else if (suOminaStrong)
                {
                    resistanceLine = "The Su Omina underground in Zille is armed and eager for blood. At your signal, their militants will strike Wehzek supply depots and communication relays from within.";
                }
                else if (ataFunded)
                {
                    resistanceLine = "While our armed cells are limited, the Zille Association has rallied strong civic sympathy for the Crown. Local dockworkers and railwaymen are prepared to stage strikes to hinder Wehzek troop movements.";
                }
                else
                {
                    resistanceLine = "However, our local underground in the province remains weak and fragmented. Smolak's secret police have kept the population under a tight curfew, so our troops will have to rely on their own firepower.";
                }
                AddLine(8, titusId, romusId, "Intro_Titus_2", resistanceLine, 9);

                // Laurento Esquibel (Geopolitics & Lespia / CSP)
                AddLine(9, laurentoId, romusId, "Intro_Laurento_1",
                    "And then there is the diplomatic chessboard, Your Majesty. An armed incursion into Wehzek-occupied territory will send shockwaves from Kyrute to United Contana.", 10);

                string lespiaLine;
                if (lespiaAllied)
                {
                    lespiaLine = "Our understanding with Prime Minister Patricio Alvarez is a decisive asset here. Lespia has quietly agreed to share high-altitude reconnaissance and block any Contanan resupply efforts through the gulf.";
                }
                else if (lespiaHostile)
                {
                    lespiaLine = "With Alvarez openly hostile toward the Crown, we must expect Lespia to denounce our campaign at the Alliance of Nations and push for immediate economic sanctions.";
                }
                else
                {
                    lespiaLine = "Alvarez remains noncommittal. Without a formal understanding with Lespia, we walk a tightrope—both ATO and the Contanan Security Pact will be watching for any sign of Rizian weakness.";
                }
                AddLine(10, laurentoId, romusId, "Intro_Laurento_2", lespiaLine, 11);

                // Hugo Toras (Treasury & Energy Reserves - qualitative, NO raw numbers!)
                string budgetLine;
                if (budget >= 8)
                {
                    budgetLine = "As for the Crown Treasury, Your Majesty, our fiscal position is remarkably strong. The royal coffers are overflowing with abundant reserves, more than capable of absorbing the heavy logistical costs of a military campaign.";
                }
                else if (budget >= 4)
                {
                    budgetLine = "Turning to the Crown Treasury, we currently hold acceptable financial reserves. We can fund the offensive without immediate crisis, provided the operation is swift and decisive.";
                }
                else if (budget >= 1)
                {
                    budgetLine = "I must urge caution regarding the Crown Treasury. Our fiscal reserves are noticeably strained; a prolonged campaign in Zille could force painful austerity across the kingdom.";
                }
                else
                {
                    budgetLine = "Your Majesty, I would be remiss if I did not sound the alarm on our finances. The Crown Treasury is virtually depleted, and waging war on credit will place immense strain on the realm.";
                }
                AddLine(11, hugoId, romusId, "Intro_Hugo_Budget", budgetLine, 12);

                string energyLine;
                if (energy >= 8)
                {
                    energyLine = "Our strategic fuel depots and energy reserves are likewise abundant. Our mechanized columns and air wings will face no shortages at the front.";
                }
                else if (energy >= 3)
                {
                    energyLine = "Our national energy stockpiles are at an acceptable level—sufficient to keep our tanks and transport trucks moving through the first phases of the assault.";
                }
                else
                {
                    energyLine = "More worryingly, our fuel and energy reserves are dangerously low. If our armored spearheads stall in the hills, keeping them supplied with fuel will be a severe challenge.";
                }
                AddLine(12, hugoId, romusId, "Intro_Hugo_Energy", energyLine, 15);

                // --- FIRST ATTITUDE / REACTION HUB (Entry 15) ---
                var hub15 = AddLine(15, lucitaId, romusId, "Intro_Lucita_Prompt",
                    "The operational maps are before you, Your Majesty. Before we examine the specific battle plans, how do you view our strategic position?");
                hub15.outgoingLinks.Add(CreateLink(conv.id, 15, 20));
                hub15.outgoingLinks.Add(CreateLink(conv.id, 15, 23));
                hub15.outgoingLinks.Add(CreateLink(conv.id, 15, 26));
                hub15.outgoingLinks.Add(CreateLink(conv.id, 15, 29));

                // Attitude 1: Decisive / Royal Pride
                AddChoice(20, lucitaId, "Attitude_Decisive",
                    "\"Smolak has tested our patience long enough. Zille is Rizian soil, and we will reclaim it by force of arms.\"",
                    "Smolak has tested our patience long enough. Zille is Rizian soil, and we will reclaim it by force of arms.", 21);
                AddLine(21, lucitaId, romusId, "Attitude_Decisive_Lucita",
                    lucitaRomance
                        ? "A smile of fierce pride touched Lucita's lips. \"Spoken like a true King of Rizia. The troops will fight twice as hard knowing their sovereign does not waver.\""
                        : "\"Spoken like a true sovereign,\" Lucita replied, her eyes gleaming with approval. \"Decisiveness at the top is worth an entire division in the field.\"", 22);
                AddLine(22, hugoId, romusId, "Attitude_Decisive_Hugo",
                    "House Toras shares your resolve, Sire. Reclaiming our birthplace by the sword will silence every critic in Porte Drazon—so long as we prevail.", 35);

                // Attitude 2: Cautious / Economy & Lives
                AddChoice(23, hugoId, "Attitude_Cautious",
                    "\"I do not take this step lightly. Every Rizian soldier and every guilder spent must be weighed carefully.\"",
                    "I do not take this step lightly. Every Rizian soldier and every guilder spent must be weighed carefully.", 24);
                AddLine(24, hugoId, romusId, "Attitude_Cautious_Hugo",
                    "A prudent and kingly perspective, Your Majesty. A monarch who counts the cost before drawing the blade rarely loses his crown.", 25);
                AddLine(25, lucitaId, romusId, "Attitude_Cautious_Lucita",
                    "Precision and preparation save lives, Sire. That is why our operational plans focus on rapid encirclement rather than senseless attrition.", 35);

                // Attitude 3: Diplomatic Concern
                AddChoice(26, laurentoId, "Attitude_Diplomatic",
                    "\"My primary concern is isolating Wehlen diplomatically so foreign powers cannot rob us of our victory.\"",
                    "My primary concern is isolating Wehlen diplomatically so foreign powers cannot rob us of our victory.", 27);
                AddLine(27, laurentoId, romusId, "Attitude_Diplomatic_Laurento",
                    "Wise words, Your Majesty. Wars are won on the battlefield, but peace is secured in the chancelleries. If we strike fast and present the Alliance of Nations with a fait accompli, even Smolak's friends will hesitate.", 28);
                AddLine(28, titusId, romusId, "Attitude_Diplomatic_Titus",
                    "And if our agents secure the municipal archives in Zille City immediately, we will have plenty of evidence of Wehzek abuses to justify our intervention.", 35);

                // Attitude 4: Personal / Warm to Lucita (especially if romanced/married)
                string personalMenu = lucitaRomance
                    ? "\"I place my trust in you, Lucita. Together, we will bring Zille back to the Crown.\""
                    : "\"I have full confidence in the General Staff, Councilor Azaro. Proceed with the briefing.\"";
                string personalSpoken = lucitaRomance
                    ? "I place my trust in you, Lucita. Together, we will bring Zille back to the Crown."
                    : "I have full confidence in the General Staff, Councilor Azaro. Proceed with the briefing.";
                AddChoice(29, lucitaId, "Attitude_Personal", personalMenu, personalSpoken, 30);
                if (lucitaMarried)
                {
                    AddLine(30, lucitaId, romusId, "Attitude_Personal_Lucita",
                        "\"I will not fail you, Romus—nor our kingdom,\" she said softly, her hand briefly brushing yours over the map border before she straightened. (Hugo cleared his throat discreetly, looking away.)", 35);
                }
                else if (lucitaRomance)
                {
                    AddLine(30, lucitaId, romusId, "Attitude_Personal_Lucita",
                        "\"You have my sword and my heart, Your Majesty,\" she murmured, a subtle warmth in her voice that earned a raised eyebrow from Laurento.", 35);
                }
                else
                {
                    AddLine(30, lucitaId, romusId, "Attitude_Personal_Lucita",
                        "\"House Azaro and the Royal Armed Forces are honored by your trust, Your Majesty. We shall not disappoint you.\"", 35);
                }

                // --- MAIN INTERACTIVE DISCUSSION HUB (Entry 35) ---
                var hub35 = AddLine(35, lucitaId, romusId, "Discussion_Hub",
                    "What aspect of Operation Righteous Sword would you like the Council to elaborate on, Your Majesty, or are you ready to review the final attack doctrines?");
                hub35.outgoingLinks.Add(CreateLink(conv.id, 35, 40)); // Military & Terrain
                hub35.outgoingLinks.Add(CreateLink(conv.id, 35, 50)); // Economy & Logistics
                hub35.outgoingLinks.Add(CreateLink(conv.id, 35, 60)); // Diplomacy & Lespia/CSP
                hub35.outgoingLinks.Add(CreateLink(conv.id, 35, 70)); // Intelligence, Su Omina & Queen Mother
                hub35.outgoingLinks.Add(CreateLink(conv.id, 35, 80)); // Proceed to Final Doctrines

                // Branch 40: Military & Terrain Analysis (Lucita)
                AddChoice(40, lucitaId, "Ask_Military",
                    "\"Walk me through the military balance and the terrain of Zille. How will Wehlen defend the province?\"",
                    "Walk me through the military balance and the terrain of Zille. How will Wehlen defend the province?", 41);
                AddLine(41, lucitaId, romusId, "Mil_Lucita_1",
                    "Zille is divided into five key operational sectors: our southern staging ground at the Brenas border, the central logistics hub of Wiktrany, the eastern gate at Nanta, the northern deepwater port of Munat, and Zille City itself in the west.", 42);
                AddLine(42, lucitaId, romusId, "Mil_Lucita_2",
                    "Colonel Valdez has concentrated his heaviest fortifications and armor around Zille City and entrenched infantry brigades at Wiktrany to block the main highway.", 43);
                var milSubHub = AddLine(43, lucitaId, romusId, "Mil_Lucita_3",
                    "However, Munat Port in the north and the eastern approaches through Nanta are more lightly held. Once we breach Wiktrany or seize Munat, Zille City will be completely cut off from Wehlen proper.");
                milSubHub.outgoingLinks.Add(CreateLink(conv.id, 43, 44));
                milSubHub.outgoingLinks.Add(CreateLink(conv.id, 43, 46));
                milSubHub.outgoingLinks.Add(CreateLink(conv.id, 43, 35));

                AddChoice(44, lucitaId, "Mil_Opinion_Armor",
                    "\"Our armored brigades must lead the spearhead. I don't want our infantry bogged down in trench warfare.\"",
                    "Our armored brigades must lead the spearhead. I don't want our infantry bogged down in trench warfare.", 45);
                AddLine(45, lucitaId, romusId, "Mil_Opinion_Armor_Reply",
                    "Agreed, Your Majesty. Shock and mobility are our greatest advantages over Smolak's conscripts. We will concentrate our tanks on the primary breakthrough sector.", 35);

                AddChoice(46, lucitaId, "Mil_Opinion_Civilians",
                    "\"Zille is a Rizian city. Instruct our commanders to avoid indiscriminate bombardment of civilian quarters.\"",
                    "Zille is a Rizian city. Instruct our commanders to avoid indiscriminate bombardment of civilian quarters.", 47);
                AddLine(47, hugoId, romusId, "Mil_Opinion_Civilians_Hugo",
                    "A vital instruction, Sire. The citizens of Zille must greet our soldiers as liberators, not destroyers.", 48);
                AddLine(48, lucitaId, romusId, "Mil_Opinion_Civilians_Lucita",
                    "Strict rules of engagement will be issued to all artillery and air squadrons. We will target only Wehzek military depots and command bunkers.", 35);

                // Branch 50: Economic & Logistical Impact (Hugo)
                AddChoice(50, hugoId, "Ask_Economy",
                    "\"Hugo, give me a frank assessment of the economic consequences. Can the realm sustain this war?\"",
                    "Hugo, give me a frank assessment of the economic consequences. Can the realm sustain this war?", 51);
                string hugoEconDetail = (budget >= 6 && energy >= 6)
                    ? "Because your governance has kept both our treasury and energy reserves in a healthy state, the immediate shock to the Rizian economy will be manageable. Commercial shipping in the south will face temporary insurance spikes, but the state can absorb the cost."
                    : "Candor compels me to warn you, Sire: with our reserves already under pressure, wartime requisitions will pinch the provinces. Fuel rationing and emergency war bonds may become necessary if the fighting drags on.";
                AddLine(51, hugoId, romusId, "Econ_Hugo_1", hugoEconDetail, 52);
                var econSubHub = AddLine(52, hugoId, romusId, "Econ_Hugo_2",
                    "Yet we must also consider the prize. Reclaiming Zille restores its lucrative gold mines, customs revenues, and port facilities directly to the Crown—ending Smolak's extortion once and for all.");
                econSubHub.outgoingLinks.Add(CreateLink(conv.id, 52, 53));
                econSubHub.outgoingLinks.Add(CreateLink(conv.id, 52, 55));
                econSubHub.outgoingLinks.Add(CreateLink(conv.id, 52, 35));

                AddChoice(53, hugoId, "Econ_Opinion_Gold",
                    "\"Once Zille is secured, its gold mines will more than repay the cost of this campaign.\"",
                    "Once Zille is secured, its gold mines will more than repay the cost of this campaign.", 54);
                AddLine(54, hugoId, romusId, "Econ_Opinion_Gold_Reply",
                    "Precisely, Your Majesty. House Toras and the Royal Treasury stand ready to reintegrate Zille's mining administration the moment the guns fall silent.", 35);

                AddChoice(55, hugoId, "Econ_Opinion_Rationing",
                    "\"Ensure that wartime logistics do not disrupt civilian energy supplies in Porte Drazon and Brenas.\"",
                    "Ensure that wartime logistics do not disrupt civilian energy supplies in Porte Drazon and Brenas.", 56);
                AddLine(56, hugoId, romusId, "Econ_Opinion_Rationing_Reply",
                    "I shall coordinate with Elena and the Ministry of Economy to prioritize domestic heating and industrial stability while routing military fuel through dedicated depots.", 35);

                // Branch 60: Geopolitics, Lespia & Superpowers (Laurento)
                AddChoice(60, laurentoId, "Ask_Diplomacy",
                    "\"Laurento, what are the diplomatic repercussions? How will Lespia, Morella, and the superpowers react?\"",
                    "Laurento, what are the diplomatic repercussions? How will Lespia, Morella, and the superpowers react?", 61);
                string laurentoDetail = lespiaAllied
                    ? "Our diplomatic groundwork with Lespia shields our western flank. Alvarez views Smolak as an unpredictable irritant; with Lespian intelligence sharing and diplomatic cover at the AN,ATO will quietly look the other way while we settle scores."
                    : "The diplomatic waters are treacherous, Sire. Smolak will immediately cry foul at the Alliance of Nations. Without Lespia's backing, Alvarez may try to leverage our distraction, while Contana will protest the attack on their Wehzek client.";
                AddLine(61, laurentoId, romusId, "Dip_Laurento_1", laurentoDetail, 62);
                var dipSubHub = AddLine(62, laurentoId, romusId, "Dip_Laurento_2",
                    "However, every chancellery in Merkopa knows that the original lease of Zille was supposed to end in peaceful return. If our campaign is swift and we frame it as restoring lawful order after Wehzek treaty violations, international outrage will remain rhetorical.");
                dipSubHub.outgoingLinks.Add(CreateLink(conv.id, 62, 63));
                dipSubHub.outgoingLinks.Add(CreateLink(conv.id, 62, 35));

                AddChoice(63, laurentoId, "Dip_Opinion_AN",
                    "\"Draft a formal declaration to the Alliance of Nations: Rizia is merely enforcing the sovereign return of its own territory.\"",
                    "Draft a formal declaration to the Alliance of Nations: Rizia is merely enforcing the sovereign return of its own territory.", 64);
                AddLine(64, laurentoId, romusId, "Dip_Opinion_AN_Reply",
                    "The communiqué is already drafted, Your Majesty. The moment our forces cross the border, our envoys in Kyrute will present a full dossier of Smolak's provocations.", 35);

                // Branch 70: Intelligence, Su Omina & Queen Mother Estela (Titus & Hugo)
                AddChoice(70, titusId, "Ask_Intel",
                    "\"Titus, what of the internal security situation—and the safety of my mother's childhood estate in Zille?\"",
                    "Titus, what of the internal security situation—and the safety of my mother's childhood estate in Zille?", 71);
                AddLine(71, titusId, romusId, "Intel_Titus_1",
                    "Your Majesty, the Golden Guard has placed a special detachment on standby to secure Queen Mother Estela's ancestral home in Zille the moment we enter the city. And should the campaign falter, we have evacuation protocols prepared for Brenas.", 72);
                AddLine(72, hugoId, romusId, "Intel_Hugo_1",
                    "That is no small matter, Romus. If our offensive were to collapse and allow Wehzek troops to counterattack into Brenas, the humiliation—and the danger to the royal family—would be unthinkable.", 73);
                AddLine(73, titusId, romusId, "Intel_Titus_2",
                    suOminaStrong
                        ? "With Su Omina cells rising up behind enemy lines, Colonel Valdez will be fighting fires in his own rear quarters from hour one. He will have no capacity for a counteroffensive."
                        : "Even with limited partisans inside the city, our Golden Guard operatives have mapped every Wehzek command post. We will strike their leadership blind.", 35);

                // --- FINAL DOCTRINE SELECTION (Entry 80) ---
                AddChoice(80, lucitaId, "Proceed_To_Doctrines",
                    "\"I have heard enough. Present the final operational doctrines for Operation Righteous Sword.\"",
                    "I have heard enough. Present the final operational doctrines for Operation Righteous Sword.", 81);

                AddLine(81, lucitaId, romusId, "Doctrine_Lucita_1",
                    "At once, Your Majesty. The General Staff has prepared two primary operational doctrines for Phase I of Operation Righteous Sword.", 82);

                AddLine(82, lucitaId, romusId, "Doctrine_Lucita_2",
                    "Plan Alpha calls for a concentrated frontal breakthrough from the Brenas staging grounds straight into the central logistics hub of Wiktrany, shattering Smolak's main defensive line before driving west into Zille City.", 83);

                var finalHub = AddLine(83, lucitaId, romusId, "Doctrine_Lucita_3",
                    "Plan Beta emphasizes an enveloping maneuver—pinning their central forces while driving our mobile columns toward the eastern gate at Nanta and the northern port of Munat to sever Wehzek sea and land supply lines. Which doctrine do you authorize, Sire?");
                finalHub.outgoingLinks.Add(CreateLink(conv.id, 83, 90)); // Plan Alpha
                finalHub.outgoingLinks.Add(CreateLink(conv.id, 83, 93)); // Plan Beta
                finalHub.outgoingLinks.Add(CreateLink(conv.id, 83, 96)); // Postpone
                finalHub.outgoingLinks.Add(CreateLink(conv.id, 83, 35)); // Back to questions

                // Option 90: Authorize Plan Alpha
                AddChoice(90, lucitaId, "Choice_Alpha",
                    "Authorize Plan Alpha: Launch a decisive frontal breakthrough through Wiktrany toward Zille City.",
                    "I authorize Plan Alpha. Concentrate our armor and smash straight through their central line at Wiktrany.", 91, "Zille_War_Alfa");
                AddLine(91, lucitaId, romusId, "Alpha_Ack_Lucita",
                    lucitaMarried
                        ? "\"It shall be done, my King,\" Lucita said, her voice ringing with steel. \"I will have the operational markers placed on the Zille frontier immediately. Join me at the war table when you are ready to deploy our divisions.\""
                        : "\"Understood, Your Majesty!\" Lucita saluted sharply. \"The directive for Operation Righteous Sword is signed. The war marker is now active at Zille—awaiting your command to begin Phase I deployment.\"", 92);
                AddLine(92, hugoId, romusId, "Alpha_Ack_Hugo",
                    "May Saint Wruhec guide our banners to victory, Your Majesty.");

                // Option 93: Authorize Plan Beta
                AddChoice(93, lucitaId, "Choice_Beta",
                    "Authorize Plan Beta: Execute an enveloping maneuver through Nanta and the port of Munat.",
                    "I authorize Plan Beta. Outflank their defenses through Nanta and seize the port of Munat to cut them off.", 94, "Zille_War_Beta");
                AddLine(94, lucitaId, romusId, "Beta_Ack_Lucita",
                    lucitaMarried
                        ? "\"A brilliant maneuver, my love,\" Lucita replied, her eyes shining. \"We will strangle Valdez's garrison before they know where the main blow fell. The operation marker is now ready at Zille whenever you wish to commence Phase I.\""
                        : "\"A textbook encirclement, Your Majesty,\" Lucita said with a crisp nod. \"Orders are being transmitted to the Brenas staging grounds. You may initiate Phase I from the Zille operation marker at your discretion.\"", 95);
                AddLine(95, laurentoId, romusId, "Beta_Ack_Laurento",
                    "Seizing the port of Munat early will also prevent any foreign ships from meddling. Godspeed to our troops, Sire.");

                // Option 96: Postpone
                AddChoice(96, hugoId, "Choice_Postpone",
                    "Hold the offensive for now. We need more time to prepare before crossing the border.",
                    "Hold the offensive for now. Keep our divisions on standby along the border, but do not cross until I give the word.", 97, "Zille_War_Postpone");
                AddLine(97, hugoId, romusId, "Postpone_Ack_Hugo",
                    "A measured and prudent decision, Your Majesty. The Council and the General Staff will remain ready whenever you choose to reconvene.");

                // Option: Return to questions
                AddChoice(98, lucitaId, "Back_To_Questions",
                    "\"Wait—let us review the council reports once more before I sign the directive.\"",
                    "Wait—let us review the council reports once more before I sign the directive.", 35);
                finalHub.outgoingLinks.Add(CreateLink(conv.id, 83, 98));

                db.AddConversation(conv);
                MelonLogger.Msg("[WAR ENGINE] Native Royal War Council Briefing conversation (English, dynamic Suzerain style) injected successfully!");
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

                            if (PendingZilleTokenSpawnAfterBriefing)
                            {
                                PendingZilleTokenSpawnAfterBriefing = false;
                                SpawnZilleWarEventToken();
                            }
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

                    // Populate conversant portraits for Titus, Lucita, Hugo, and Laurento in ConversationPanel
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
                                cName.IndexOf("Hugo", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                cName.IndexOf("Laurento", StringComparison.OrdinalIgnoreCase) >= 0)
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
                        zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName(config.Tiles[i].Id));
                    }
                }
                else
                {
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_zille"));
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_munat"));
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_wiktrany"));
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_nanta"));
                    zilleOpData.includedTileNames.Add(ZilleMapLayoutManager.GameTileName("tile_brenas"));
                }

                // Every layout province, including ones added from the theatre menu, becomes real tile data.
                zilleOpData.tileData = new Il2CppSystem.Collections.Generic.List<ConditionalWarTileData>();
                var condTileData = new ConditionalWarTileData();
                condTileData.condition = "";
                condTileData.tiles = new Il2CppSystem.Collections.Generic.List<WarTileData>();
                if (config != null && config.Tiles != null)
                {
                    for (int i = 0; i < config.Tiles.Count; i++)
                    {
                        var src = config.Tiles[i];
                        var wtd = new WarTileData();
                        ZilleWarTable.FillWarTileData(src, wtd);
                        if (string.IsNullOrEmpty(wtd.tileName))
                            wtd.tileName = ZilleMapLayoutManager.GameTileName(src.Id);
                        condTileData.tiles.Add(wtd);
                    }
                }
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

                    if (config?.Tiles != null)
                    {
                        for (int i = 0; i < config.Tiles.Count; i++)
                        {
                            var src = config.Tiles[i];
                            if (!src.IsCity || src.Allegiance != "Rizia" || string.IsNullOrEmpty(src.TileNumber)) continue;
                            if (!ZilleMapLayoutManager.IsScenarioCity(src.Name)) continue;
                            var token = new WarTokenData();
                            token.startingTileName = src.TileNumber;
                            token.guid = "city_" + src.Id;
                            token.allegiance = WarToken.WarAllegiance.Player;
                            token.unitType = cityUnitType;
                            playerCities.tokens.Add(token);
                        }
                    }
                    if (playerCities.tokens.Count > 0)
                        zilleOpData.playerCityTokens.Add(playerCities);
                }

                // Configure Enemy Cities (Zille, Munat, Wiktrany, Nanta)
                zilleOpData.enemyCityTokens = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                if (cityUnitType != null)
                {
                    var enemyCities = new ConditionalWarTokenData();
                    enemyCities.condition = "";
                    enemyCities.tokens = new Il2CppSystem.Collections.Generic.List<WarTokenData>();

                    var enemyCityTiles = new List<string>();
                    if (config?.Tiles != null)
                    {
                        for (int i = 0; i < config.Tiles.Count; i++)
                        {
                            var src = config.Tiles[i];
                            if (src.IsCity && src.Allegiance != "Rizia" && !string.IsNullOrEmpty(src.TileNumber)
                                && ZilleMapLayoutManager.IsScenarioCity(src.Name))
                                enemyCityTiles.Add(src.TileNumber);
                        }
                    }
                    if (enemyCityTiles.Count == 0)
                    {
                        enemyCityTiles.Add(ZilleMapLayoutManager.GameTileName("tile_zille"));
                        enemyCityTiles.Add(ZilleMapLayoutManager.GameTileName("tile_munat"));
                        enemyCityTiles.Add(ZilleMapLayoutManager.GameTileName("tile_wiktrany"));
                        enemyCityTiles.Add(ZilleMapLayoutManager.GameTileName("tile_nanta"));
                    }
                    for (int c = 0; c < enemyCityTiles.Count; c++)
                    {
                        var cToken = new WarTokenData();
                        cToken.startingTileName = enemyCityTiles[c];
                        cToken.guid = $"city_zille_{enemyCityTiles[c]}";
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

                string TileNum(string provinceName, string fallbackId)
                {
                    var found = ZilleMapLayoutManager.FindByName(provinceName);
                    if (found != null && !string.IsNullOrEmpty(found.TileNumber)) return found.TileNumber;
                    return ZilleMapLayoutManager.GameTileName(fallbackId);
                }
                string wiktranyTile = TileNum("Wiktrany", "tile_wiktrany");
                string zilleTile = TileNum("Zille City", "tile_zille");
                string kratsnaTile = TileNum("Kratsna", "tile_nanta");

                if (infUnitType != null)
                {
                    void AddInf(string tileName, string guid)
                    {
                        var inf = new WarTokenData();
                        inf.startingTileName = tileName;
                        inf.guid = guid;
                        inf.allegiance = WarToken.WarAllegiance.Enemy;
                        inf.unitType = infUnitType;
                        garrisonCond.tokens.Add(inf);
                    }
                    AddInf(wiktranyTile, "wehlen_inf_wiktrany");
                    AddInf(zilleTile, "wehlen_inf_zille");
                    AddInf(kratsnaTile, "wehlen_inf_kratsna");
                }

                if (tankUnitType != null)
                {
                    var tankZille = new WarTokenData();
                    tankZille.startingTileName = zilleTile;
                    tankZille.guid = "wehlen_tank_zille";
                    tankZille.allegiance = WarToken.WarAllegiance.Enemy;
                    tankZille.unitType = tankUnitType;
                    garrisonCond.tokens.Add(tankZille);
                }

                if (garrisonCond.tokens.Count > 0)
                {
                    zilleOpData.enemyTokens.Add(garrisonCond);
                }

                // Initialize remaining lists on WarOperationData so WarFlowManager & WarOperationManager never NullRef
                zilleOpData.supplyLines = ZilleWarTable.BuildSupplyLines();
                zilleOpData.tileAllegianceChangeEvents = new Il2CppSystem.Collections.Generic.List<ConditionalTileAllegianceChangeEvent>();
                zilleOpData.warFlowEvents = new Il2CppSystem.Collections.Generic.List<ConditionalWarFlowEvent>();
                zilleOpData.onStartBattleEvents = new Il2CppSystem.Collections.Generic.List<ConditionalWarStartBattleEvent>();
                zilleOpData.tileUnitActionEvents = new Il2CppSystem.Collections.Generic.List<ConditionalTileUnitActionEvent>();
                zilleOpData.tileDataOverrides = new Il2CppSystem.Collections.Generic.List<ConditionalWarTileData>();
                zilleOpData.enemyTokenOverrides = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                zilleOpData.playerCityTokenOverrides = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();
                zilleOpData.enemyCityTokenOverrides = new Il2CppSystem.Collections.Generic.List<ConditionalWarTokenData>();

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

                // IMPORTANT: "Pales Operations Container" also holds the war "Map Container" (the Addressables loader of
                // Map_Rizia_PalesWar) and the table background. Disabling those stops the map from ever loading
                // (a coroutine cannot run on an inactive object) - this was the long-standing "no map" bug.
                // So only switch off the OTHER WarOperation objects, and make sure the map loader stays enabled.
                for (int i = 0; i < palesOps.transform.childCount; i++)
                {
                    var child = palesOps.transform.GetChild(i);
                    if (child == null || child.name == "Operation_Zille_1") continue;
                    bool isOperation = child.GetComponent<WarOperation>() != null || child.name.StartsWith("Operation_");
                    if (isOperation)
                    {
                        child.gameObject.SetActive(false);
                    }
                    else if (child.GetComponent<MapContainer>() != null && !child.gameObject.activeSelf)
                    {
                        child.gameObject.SetActive(true);
                        MelonLogger.Msg($"[WAR ENGINE] Re-enabled '{child.name}' (war map loader).");
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

        public static bool EnterZilleWarTheatre(bool editOnly = false)
        {
            ZilleWarTable.EditMode = editOnly;
            MelonLogger.Msg("============================================================");
            MelonLogger.Msg(editOnly
                ? "[WAR ENGINE] Entering the Zille table in edit mode."
                : "[WAR ENGINE] Entering Native 3D Zille War Theatre (Golden Shield Parity)...");
            MelonLogger.Msg("============================================================");

            try
            {
                CurrentTheatre = ActiveWarTheatre.Zille;
                _tilesConfiguredForZille = false;

                // 1. Deselect tokens & hide all panels (matching vanilla TemplateInteractionButton.OnClick)
                try
                {
                    var tokenMgr = Managers.Instance?.TokenManager ?? UnityEngine.Object.FindObjectOfType<TokenManager>();
                    tokenMgr?.DeselectAllTokens();
                    Panels.Instance?.TokenInteractionPanel?.Hide();
                    Panels.Instance?.HideAllRightPanels();
                    Panels.Instance?.HideAllCenterPanels();
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning($"[WAR ENGINE] Deselect/Hide warning: {ex.Message}");
                }

                // 2. Ensure textures are loaded into GPU memory and native entities registered
                ZilleMapLayoutManager.EnsureTexturesLoaded();
                RegisterNativeZilleEntities();

                // 3. Fetch WarFragmentData for Zille
                WarFragmentData wfd = null;
                var warFragments = EntityDataManager.AllWarFragmentsData ?? EntityDataManager.WarFragmentsData;
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
                if (wfd != null && wfd.StoryFragmentProperties != null)
                {
                    wfd.StoryFragmentProperties.IsDone = false;
                }

                // Ensure Operation_Zille_1 IsFinished is false so WarFlowManager runs full initial deployment!
                var allOps = GetEntityBackingList<OperationData>("operationData") ?? EntityDataManager.OperationData;
                if (allOps != null)
                {
                    for (int i = 0; i < allOps.Count; i++)
                    {
                        var op = allOps[i];
                        if (op != null && (op.NameInDatabase == "Operation_Zille_1" || op.Id == "Operation_Zille_1"))
                        {
                            if (op.OperationProperties != null) op.OperationProperties.IsFinished = false;
                            break;
                        }
                    }
                }

                // 4. Setup custom Zille 3D operation in scene
                SetupCustomZilleOperation();

                // 5. The Pales intro reads the campaign war save. Without it the coroutine stops before the Start button.
                EnsureWarSave();

                // 6. Explicitly load War Map via MapManager (unloads Map_Rizia_Base civilian map and instantiates Map_Rizia_PalesWar)
                var mapManager = Managers.Instance?.MapManager ?? UnityEngine.Object.FindObjectOfType<MapManager>();
                if (mapManager != null)
                {
                    mapManager.LoadMap(MapConfiguration.MapType.War);
                    MelonLogger.Msg("[WAR ENGINE] Called MapManager.LoadMap(MapConfiguration.MapType.War)!");
                }

                // 7. Launch native WarFlowManager (which sets up HUD, deployment panel, unit tokens, and objectives)
                var warFlowMgr = Managers.Instance?.WarFlowManager ?? UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (warFlowMgr != null && wfd != null)
                {
                    MelonLogger.Msg("[WAR ENGINE] Starting native WarFlowManager with WarFragment_Zille_1_1!");
                    warFlowMgr.SetupWarFragment(wfd);
                }

                // 8. Start War Music and stop civilian ambience
                try
                {
                    var audioMgr = Managers.Instance?.AudioManager ?? UnityEngine.Object.FindObjectOfType<AudioManager>();
                    if (audioMgr != null)
                    {
                        audioMgr.StopMapMusic();
                        audioMgr.StopMapAmbience();
                        string intro = warFlowMgr?.warConfiguration?.WarMapIntroTrackName ?? "Track_War_Intro";
                        string loop = warFlowMgr?.warConfiguration?.WarMapLoopTrackName ?? "Track_War_Loop";
                        if (!string.IsNullOrEmpty(intro) && !string.IsNullOrEmpty(loop))
                        {
                            audioMgr.PlayLoopedMusic(intro, loop);
                            MelonLogger.Msg($"[WAR ENGINE] War music started: {intro} / {loop}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MelonLogger.Warning($"[WAR ENGINE] War music start: {ex.Message}");
                }

                // 9. Skin the live (vanilla Pales) war table with the Zille map + provinces; kept alive by ZilleWarTable.Tick()
                ZilleWarTable.SkinEnabled = true;
                _theatreEnteredAt = Time.unscaledTime;

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
            // The table skin handles its own enable/disable (restores vanilla Pales when disabled).
            ZilleWarTable.Tick();

            if (CurrentTheatre != ActiveWarTheatre.Zille) return;
            try
            {
                if (ZilleWarTable.EditMode)
                    ZilleWarTable.SuppressInvasionChrome();
                else if (ZilleWarTable.HasLiveMap)
                    ActivateWarDeploymentPanel();
            }
            catch { }
        }

        private static bool _deploymentOpened;

        private static void ActivateWarDeploymentPanel()
        {
            if (_deploymentOpened) return;
            try
            {
                var deployPanel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (deployPanel == null) deployPanel = UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
                if (deployPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<WarDeploymentPanel>();
                    if (allPanels != null && allPanels.Length > 0) deployPanel = allPanels[0];
                }
                if (deployPanel == null) return;
                if (!deployPanel.gameObject.activeSelf) deployPanel.gameObject.SetActive(true);
                ZilleWarTable.EnsurePlayerPool();
                try { deployPanel.Setup(); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Deployment Setup: " + ex.Message); }
                try { deployPanel.Show(); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Deployment Show: " + ex.Message); }
                var hud = Panels.Instance != null ? Panels.Instance.WarHUDPanel : UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
                if (hud != null && !ZilleWarTable.ScenarioStarted)
                {
                    if (!hud.gameObject.activeSelf) hud.gameObject.SetActive(true);
                    try { hud.Setup(WarHUDPanel.WarHUDButtonState.OperationStart); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Start button setup: " + ex.Message); }
                    try { hud.Show(); } catch (Exception ex) { MelonLogger.Warning("[WAR THEATRE] Start button show: " + ex.Message); }
                }
                var portraits = UnityEngine.Object.FindObjectsOfType<PortraitPanel>();
                if (portraits != null)
                {
                    for (int i = 0; i < portraits.Length; i++)
                        if (portraits[i] != null) portraits[i].gameObject.SetActive(false);
                }
                _deploymentOpened = true;
                MelonLogger.Msg("[WAR THEATRE] Pales deployment panel and Start button opened for Zille.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[WAR THEATRE] Deployment panel: " + ex.Message);
            }
        }

        public static void ReturnToCivilianMap()
        {
            MelonLogger.Msg("[WAR ENGINE] Returning to civilian map...");
            CurrentTheatre = ActiveWarTheatre.Civilian;
            _tilesConfiguredForZille = false;
            _deploymentOpened = false;

            try
            {
                // Put the live war table back to vanilla Pales (per-renderer material instances are dropped, tiles restored).
                ZilleWarTable.SkinEnabled = false;
                ZilleWarTable.Restore();

                // Re-enable the Pales operations that SetupCustomZilleOperation switched off, and forget our cached operation
                // (the war map scene objects are destroyed when the base map is loaded again).
                _customOperationConfigured = false;
                _zilleWarOp = null;

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
