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

        public static ActiveWarTheatre CurrentTheatre { get; private set; } = ActiveWarTheatre.None;

        public static GameObject SpawnedZilleWarToken => _spawnedZilleWarToken;
        public static Vector3 TokenBasePos { get; set; } = new Vector3(0.44f, 0.08f, 0.80f);
        public static bool IsTokenHovered { get; set; } = false;

        private static GameObject _spawnedZilleWarToken = null;
        private static Texture _originalPalesTexture = null;
        private static readonly List<Vector3> _originalTilePositions = new List<Vector3>();
        private static readonly List<Vector3> _originalTileScales = new List<Vector3>();
        private static bool _tilesConfiguredForZille = false;
        private static bool _tableTextureApplied = false;

        private static bool _transitionScheduled = false;
        private static float _transitionTimer = 0f;

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
                if (convList != null)
                {
                    bool convExists = false;
                    for (int i = 0; i < convList.Count; i++)
                    {
                        var c = convList[i];
                        if (c != null && c.NameInDatabase == "Zille/WarCouncil_Briefing")
                        {
                            convExists = true;
                            break;
                        }
                    }

                    if (!convExists)
                    {
                        var cd = new ConversationData();
                        cd.Id = "Conv_Zille_WarCouncil";
                        cd.NameInDatabase = "Zille/WarCouncil_Briefing";
                        cd.Path = "Rizia/Conversations";
                        cd.AssignedTokenProperties = new AssignedTokenProperties();
                        cd.AssignedTokenProperties.AssignedToken = "Rizia_City_PorteDrazon";
                        cd.StoryFragmentProperties = new StoryFragmentProperties();
                        cd.StoryFragmentProperties.IsDone = false;
                        cd.StoryFragmentProperties.StoryFragmentCondition = "";
                        cd.ConversationProperties = new ConversationProperties();
                        cd.ConversationProperties.Title = "Narada Wojenna: Zille";
                        cd.ConversationProperties.Subtitle = "Sztab Generalny i Rada Krolewska";
                        cd.ConversationProperties.Dialogue = "Zille/WarCouncil_Briefing";
                        cd.ConversationProperties.TypeString = "Counsel";
                        cd.AppBundleProperties = new AppBundleProperties("StoryPack_Rizia");

                        convList.Add(cd);
                        MelonLogger.Msg("[WAR ENGINE] Added native ConversationData to EntityDataManager.ConversationsData!");
                    }
                }

                // 3. Register WarFragmentData for Zille invasion in EntityDataManager
                var warList = EntityDataManager.WarFragmentsData;
                if (warList != null)
                {
                    bool warFragExists = false;
                    for (int i = 0; i < warList.Count; i++)
                    {
                        var w = warList[i];
                        if (w != null && w.NameInDatabase == "WarFragment_Zille_1_1")
                        {
                            warFragExists = true;
                            break;
                        }
                    }

                    if (!warFragExists)
                    {
                        var wfd = new WarFragmentData();
                        wfd.Id = "WarFragment_Zille_1_1";
                        wfd.NameInDatabase = "WarFragment_Zille_1_1";
                        wfd.Path = "Rizia/War Fragments";
                        wfd.AssignedTokenProperties = new AssignedTokenProperties();
                        wfd.AssignedTokenProperties.AssignedToken = "Rizia_Event_Zille";
                        wfd.StoryFragmentProperties = new StoryFragmentProperties();
                        wfd.StoryFragmentProperties.IsDone = false;
                        wfd.StoryFragmentProperties.StoryFragmentCondition = "";
                        wfd.WarFragmentProperties = new WarFragmentProperties();
                        wfd.WarFragmentProperties.Operation = "Operation_1";
                        wfd.WarFragmentProperties.HubWarFragmentTitle = "Operacja: Prawy Miecz - Faza I";
                        wfd.WarFragmentProperties.HubWarFragmentSubtitle = "Inwazja na Zille";
                        wfd.AppBundleProperties = new AppBundleProperties("StoryPack_Rizia");

                        warList.Add(wfd);
                        MelonLogger.Msg("[WAR ENGINE] Added native WarFragmentData to EntityDataManager.WarFragmentsData!");
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
                TokenManager tokenMgr = null;
                if (Managers.Instance != null && Managers.Instance.TokenManager != null)
                    tokenMgr = Managers.Instance.TokenManager;
                if (tokenMgr == null)
                    tokenMgr = UnityEngine.Object.FindObjectOfType<TokenManager>();

                Token targetToken = null;
                if (tokenMgr != null)
                {
                    targetToken = tokenMgr.GetTokenByTokenDataNameInDatabase("Rizia_City_PorteDrazon");
                }

                if (targetToken != null && tokenMgr != null)
                {
                    MelonLogger.Msg("[WAR ENGINE] Selecting Porte Drazon token via native TokenManager.SelectToken...");
                    tokenMgr.SelectToken(targetToken);
                }

                // Immediately trigger native Royal War Council Briefing conversation
                TriggerZilleWarBriefingConversation();
                DialogueHelper.ShowAlert("[Porte Drazon] Otwarto narade wojenna w stolicy.");
                return true;
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
                TokenManager tokenMgr = null;
                if (Managers.Instance != null && Managers.Instance.TokenManager != null)
                    tokenMgr = Managers.Instance.TokenManager;
                if (tokenMgr == null)
                    tokenMgr = UnityEngine.Object.FindObjectOfType<TokenManager>();

                // 1. Locate Pales war event token template to clone native model and collider
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

                // 2. Locate Zille coordinates on civilian map
                Vector3 zillePos = new Vector3(-3.2f, 0.45f, 1.8f);
                Token zilleBaseToken = null;
                if (tokenMgr != null)
                {
                    zilleBaseToken = tokenMgr.GetTokenByTokenDataNameInDatabase("Rizia_City_Zille")
                                  ?? tokenMgr.GetTokenByTokenDataNameInDatabase("Rizia_Country_Zille");
                }
                if (zilleBaseToken != null)
                {
                    zillePos = zilleBaseToken.transform.position;
                }
                else
                {
                    var zilleCityObj = GameObject.Find("Rizia_City_Zille") ?? GameObject.Find("Zille Variant");
                    if (zilleCityObj != null) zillePos = zilleCityObj.transform.position;
                }

                // 3. Instantiate or activate InvasionOfZille Event Variant
                if (_spawnedZilleWarToken == null)
                {
                    _spawnedZilleWarToken = GameObject.Find("InvasionOfZille Event Variant");
                }

                if (_spawnedZilleWarToken == null && palesWarTemplate != null)
                {
                    _spawnedZilleWarToken = UnityEngine.Object.Instantiate(palesWarTemplate);
                    _spawnedZilleWarToken.name = "InvasionOfZille Event Variant";
                    MelonLogger.Msg("[WAR ENGINE] Cloned native InvasionOfPales Event Variant into InvasionOfZille Event Variant!");
                }

                if (_spawnedZilleWarToken != null)
                {
                    _spawnedZilleWarToken.transform.position = zillePos + new Vector3(-0.35f, 0.15f, -0.25f);
                    if (palesWarTemplate != null) _spawnedZilleWarToken.transform.localScale = palesWarTemplate.transform.localScale;
                    _spawnedZilleWarToken.SetActive(true);

                    var tok = _spawnedZilleWarToken.GetComponent<Token>();
                    if (tok != null)
                    {
                        tok.tokenDataEntityName = "Rizia_Event_Zille";
                        tok.tokenType = Token.TokenType.Event;
                        tok.gameObject.SetActive(true);

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

                    DialogueHelper.ShowAlert("[Zille] Znacznik operacji wojennej aktywny w Zille.");
                    return true;
                }

                MelonLogger.Warning("[WAR ENGINE] Could not instantiate InvasionOfZille Event Variant.");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] SpawnZilleWarEventToken failed: {ex.Message}");
            }
            return false;
        }

        // ================= HOVER AND CLICK RAYCAST INTERACTION =================

        public static void UpdateEventTokenInteractions()
        {
            if (_spawnedZilleWarToken == null || !_spawnedZilleWarToken.activeInHierarchy) return;

            try
            {
                var cameras = Camera.allCameras;
                if (cameras == null || cameras.Length == 0) return;

                bool hitFound = false;

                for (int c = 0; c < cameras.Length; c++)
                {
                    var cam = cameras[c];
                    if (cam == null || !cam.isActiveAndEnabled) continue;

                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit[] hits = Physics.RaycastAll(ray, 500f);
                    if (hits == null || hits.Length == 0) continue;

                    for (int h = 0; h < hits.Length; h++)
                    {
                        var hit = hits[h];
                        if (hit.collider != null && (hit.collider.gameObject == _spawnedZilleWarToken || hit.collider.transform.IsChildOf(_spawnedZilleWarToken.transform)))
                        {
                            hitFound = true;
                            if (!IsTokenHovered)
                            {
                                IsTokenHovered = true;
                                _spawnedZilleWarToken.transform.position = TokenBasePos + new Vector3(0f, 0.03f, 0f);
                            }

                            if (Input.GetMouseButtonDown(0))
                            {
                                EnterZilleWarTheatre();
                            }
                            break;
                        }
                    }

                    if (hitFound) break;
                }

                if (!hitFound && IsTokenHovered)
                {
                    IsTokenHovered = false;
                    _spawnedZilleWarToken.transform.position = TokenBasePos;
                }
            }
            catch { }
        }

        // ================= NATIVE DIALOGUE ENGINE INJECTION =================

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
                    return true;
                }

                MelonLogger.Msg("[WAR ENGINE] Injecting native Royal War Council Briefing conversation into masterDatabase...");

                int romusId = 1;
                int titusId = 2;
                int lucitaId = 3;
                int hugoId = 4;

                if (db.actors != null)
                {
                    for (int i = 0; i < db.actors.Count; i++)
                    {
                        var a = db.actors[i];
                        if (a == null) continue;
                        string aName = a.Name ?? "";
                        if (aName.IndexOf("Romus", StringComparison.OrdinalIgnoreCase) >= 0) romusId = a.id;
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
                conv.fields.Add(new Field("Title", convTitle, FieldType.Text));

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
                var entry0 = CreateDialogueEntry(conv.id, 0, romusId, lucitaId, "START", "");
                entry0.isRoot = true;
                entry0.outgoingLinks.Add(new Link(conv.id, 0, conv.id, 1));
                conv.dialogueEntries.Add(entry0);

                // Entry 1: Titus Gauth (Security / Su Omina)
                string titusText = $"Wasza Krolewska Mosc, zbliza sie moment ostatecznego rozstrzygniecia w kwestii Zille. " +
                                   $"Komorki Su Omina w prowincji melduja o pelnej mobilizacji. Garnizon Wehlen pod dowodztwem plk. Valdeza " +
                                   $"liczy okolo 4 regularnych brygad oraz oddzialy OBT Smolaka. Jezeli wydacie rozkaz, rebelianci uderza od wewnatrz w punkty zaopatrzenia wroga.";
                var entry1 = CreateDialogueEntry(conv.id, 1, titusId, romusId, "Titus_Report", titusText);
                entry1.outgoingLinks.Add(new Link(conv.id, 1, conv.id, 2));
                conv.dialogueEntries.Add(entry1);

                // Entry 2: Lucita Azaro (War Ministry / Military Balance)
                string lespiaNote = lespiaPact 
                    ? "Prezydent Alvarez potwierdzil wsparcie radarowe i blokade w wodach Zille." 
                    : "Brak formalnego paktu z Lespia rodzi ryzyko wtracenia sie Contanan Security Pact (CSP) na korzysc Wehlenu.";
                string lucitaText = $"Sztab generalny dokonal przegladu wojsk. Do operacji mozemy rzucic {totalBattalions} pelnych batalionow. " +
                                    $"Smolak okopal sie na wezlach komunikacyjnych, lecz nasza przewaga w manewrze pancernym jest wyrazna. {lespiaNote} " +
                                    $"Przedstawiam dwa warianty doktryny wojennej — decyzja nalezy do Was, Wasza Wysokosc.";
                var entry2 = CreateDialogueEntry(conv.id, 2, lucitaId, romusId, "Lucita_Report", lucitaText);
                entry2.outgoingLinks.Add(new Link(conv.id, 2, conv.id, 3));
                conv.dialogueEntries.Add(entry2);

                // Entry 3: Hugo Toras (Crown Treasury / House Politics)
                string hugoText = $"Skarbiec krolestwa dysponuje obecnie rezerwa {budget} jednostek budzetowych. Kazdy dzien dzialan wojennych to gigantyczny koszt logistyczny. " +
                                  $"Dom Toras oczekuje, ze ziemie Zille powroca do Korony, ale bez zrujnowania naszej gospodarki. Podpiszcie rozkaz lub dajcie nam wiecej czasu.";
                var entry3 = CreateDialogueEntry(conv.id, 3, hugoId, romusId, "Hugo_Report", hugoText);
                entry3.outgoingLinks.Add(new Link(conv.id, 3, conv.id, 10));
                entry3.outgoingLinks.Add(new Link(conv.id, 3, conv.id, 20));
                entry3.outgoingLinks.Add(new Link(conv.id, 3, conv.id, 30));
                conv.dialogueEntries.Add(entry3);

                // Option 10: Plan Alpha (Frontal Assault)
                var choiceAlpha = CreateDialogueEntry(conv.id, 10, romusId, lucitaId, "Choice_Alpha", "Wydajcie rozkazy do natarcia. Przelamujemy linie Smolaka frontalnym uderzeniem.");
                choiceAlpha.MenuText = "Plan Alpha: Zmasowane natarcie frontalne na pozycje Smolaka w Zille.";
                choiceAlpha.userScript = "Zille_War_Alfa";
                choiceAlpha.outgoingLinks.Add(new Link(conv.id, 10, conv.id, 11));
                conv.dialogueEntries.Add(choiceAlpha);

                // Entry 11: Lucita Alpha Ack
                var lucitaAlpha = CreateDialogueEntry(conv.id, 11, lucitaId, romusId, "Lucita_Alpha_Ack", "Rozkaz przyjety, moj Krolu! Glowne uderzenie ruszy poludniowa flanka. Przenosze dowodztwo na stol operacyjny teatru Zille.");
                conv.dialogueEntries.Add(lucitaAlpha);

                // Option 20: Plan Beta (Flanking Munat)
                var choiceBeta = CreateDialogueEntry(conv.id, 20, romusId, lucitaId, "Choice_Beta", "Oskrzydlimy Wehlen. Skierujmy glowne sily przez Viktrany i wzgorza Munat.");
                choiceBeta.MenuText = "Plan Beta: Manewr oskrzydlajacy przez Viktrany i port Munat.";
                choiceBeta.userScript = "Zille_War_Beta";
                choiceBeta.outgoingLinks.Add(new Link(conv.id, 20, conv.id, 21));
                conv.dialogueEntries.Add(choiceBeta);

                // Entry 21: Lucita Beta Ack
                var lucitaBeta = CreateDialogueEntry(conv.id, 21, lucitaId, romusId, "Lucita_Beta_Ack", "Blyskotliwy manewr, Wasza Wysokosc! Obejdziemy ich glowne umocnienia od zachodu. Otwieram stol operacyjny.");
                conv.dialogueEntries.Add(lucitaBeta);

                // Option 30: Postpone
                var choicePostpone = CreateDialogueEntry(conv.id, 30, romusId, hugoId, "Choice_Postpone", "Wstrzymajmy uderzenie. Armia potrzebuje jeszcze przegrupowania i zapasow.");
                choicePostpone.MenuText = "Wstrzymajmy uderzenie. Potrzebujemy wiecej czasu na przygotowania.";
                choicePostpone.userScript = "Zille_War_Postpone";
                choicePostpone.outgoingLinks.Add(new Link(conv.id, 30, conv.id, 31));
                conv.dialogueEntries.Add(choicePostpone);

                // Entry 31: Hugo Postpone Ack
                var hugoPostpone = CreateDialogueEntry(conv.id, 31, hugoId, romusId, "Hugo_Postpone_Ack", "Madra i roztropna decyzja, Wasza Krolewska Mosc. Skarbnik i generalicja zyskaja bezcenny czas na konsolidacje rezerw.");
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

        private static DialogueEntry CreateDialogueEntry(int convId, int entryId, int actorId, int conversantId, string title, string text)
        {
            var entry = new DialogueEntry();
            entry.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            entry.outgoingLinks = new Il2CppSystem.Collections.Generic.List<Link>();
            entry.id = entryId;
            entry.conversationID = convId;
            entry.ActorID = actorId;
            entry.ConversantID = conversantId;
            entry.Title = title;
            entry.DialogueText = text;
            entry.MenuText = text;

            entry.fields.Add(new Field("Title", title, FieldType.Text));
            entry.fields.Add(new Field("Dialogue Text", text, FieldType.Text));
            return entry;
        }

        public static bool TriggerZilleWarBriefingConversation()
        {
            MelonLogger.Msg("[WAR ENGINE] Launching native Royal War Council Briefing via ConversationPanel...");
            EnsureWarCouncilConversationRegistered();

            try
            {
                var convPanel = UnityEngine.Object.FindObjectOfType<ConversationPanel>();
                if (convPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<ConversationPanel>();
                    if (allPanels != null && allPanels.Length > 0) convPanel = allPanels[0];
                }

                if (convPanel != null)
                {
                    convPanel.isWarConversation = false;
                    convPanel.gameObject.SetActive(true);
                    convPanel.ForceStartConversation("Zille/WarCouncil_Briefing");
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

        public static bool EnterZilleWarTheatre()
        {
            MelonLogger.Msg("============================================================");
            MelonLogger.Msg("[WAR ENGINE] Entering Native 3D Zille War Theatre...");
            MelonLogger.Msg("============================================================");

            try
            {
                CurrentTheatre = ActiveWarTheatre.Zille;
                _tilesConfiguredForZille = false;
                _tableTextureApplied = false;

                // Ensure textures are loaded into GPU memory
                ZilleMapLayoutManager.EnsureTexturesLoaded();

                // 1. Switch MapManager to War mode
                var mapManager = UnityEngine.Object.FindObjectOfType<MapManager>();
                if (mapManager == null && Managers.Instance != null) mapManager = Managers.Instance.MapManager;
                if (mapManager != null)
                {
                    MelonLogger.Msg("[WAR ENGINE] Switching MapManager to War mode...");
                    mapManager.LoadMap(MapConfiguration.MapType.War);
                }

                // 2. Fetch native OperationData
                OperationData opData = null;
                var allOps = EntityDataManager.OperationData;
                if (allOps != null && allOps.Count > 0)
                {
                    for (int i = 0; i < allOps.Count; i++)
                    {
                        if (allOps[i] != null && allOps[i].NameInDatabase == "Operation_1")
                        {
                            opData = allOps[i];
                            break;
                        }
                    }
                    if (opData == null) opData = allOps[0];
                }

                // 3. Find WarOperationManager and invoke Setup to arm tiles and supply lines!
                var warOpMgr = UnityEngine.Object.FindObjectOfType<WarOperationManager>();
                if (warOpMgr == null && Managers.Instance != null) warOpMgr = Managers.Instance.WarOperationManager;
                if (warOpMgr == null)
                {
                    var all = Resources.FindObjectsOfTypeAll<WarOperationManager>();
                    if (all != null && all.Length > 0) warOpMgr = all[0];
                }

                if (warOpMgr != null && opData != null)
                {
                    MelonLogger.Msg($"[WAR ENGINE] Setting up WarOperationManager with operation: {opData.NameInDatabase}...");
                    warOpMgr.Setup(opData);
                }

                // 4. Hide Pales specific container if active
                var palesOps = GameObject.Find("Pales Operations Container");
                if (palesOps != null) palesOps.SetActive(false);

                // 5. Lock table background to Zille composite map
                ApplyWarTableTexture();

                // 6. Align native WarTiles with Zille layout
                var palesBg = GameObject.Find("PalesWarMapBackground");
                AlignNativeWarTilesWithZilleLayout(palesBg);
                _tilesConfiguredForZille = true;

                // 7. Setup and Show WarDeploymentPanel
                var deployPanel = UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
                if (deployPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<WarDeploymentPanel>();
                    if (allPanels.Length > 0) deployPanel = allPanels[0];
                }

                if (deployPanel != null)
                {
                    deployPanel.gameObject.SetActive(true);
                    deployPanel.Setup();
                    deployPanel.Show();
                    MelonLogger.Msg("[WAR THEATRE] WarDeploymentPanel successfully setup and shown!");
                }

                DialogueHelper.ShowAlert("[Teatr Zille] Faza rozstawienia sil aktywna. Wybierz bataliony i obsadz sektory operacyjne.");
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
                // 1. Maintain Table Texture (guarded to apply once)
                ApplyWarTableTexture();

                // 2. Configure WarTiles once WarTileManager.allTiles or any WarTile is active
                if (!_tilesConfiguredForZille)
                {
                    var palesBg = GameObject.Find("PalesWarMapBackground");
                    if (palesBg != null)
                    {
                        AlignNativeWarTilesWithZilleLayout(palesBg);
                        _tilesConfiguredForZille = true;
                    }
                }

                // 3. Ensure WarDeploymentPanel is active for placing units
                ActivateWarDeploymentPanel();
            }
            catch { }
        }

        private static void ApplyWarTableTexture()
        {
            if (_tableTextureApplied) return;

            GameObject palesBg = GameObject.Find("PalesWarMapBackground");
            if (palesBg == null)
            {
                var all = Resources.FindObjectsOfTypeAll<GameObject>();
                foreach (var g in all)
                {
                    if (g.name == "PalesWarMapBackground") { palesBg = g; break; }
                }
            }

            if (palesBg != null)
            {
                palesBg.SetActive(true);
                var rend = palesBg.GetComponent<Renderer>();
                if (rend != null && rend.material != null)
                {
                    var zilleTex = ZilleMapLayoutManager.FullMapTexture ?? ZilleMapLayoutManager.MapBackgroundTexture;
                    if (zilleTex != null)
                    {
                        if (_originalPalesTexture == null)
                        {
                            _originalPalesTexture = rend.material.mainTexture;
                        }

                        // Apply to material using URP and standard properties
                        if (rend.material.HasProperty("_BaseMap")) rend.material.SetTexture("_BaseMap", zilleTex);
                        if (rend.material.HasProperty("_MainTex")) rend.material.SetTexture("_MainTex", zilleTex);
                        if (rend.material.HasProperty("_BaseColor")) rend.material.SetColor("_BaseColor", Color.white);
                        if (rend.material.HasProperty("_Color")) rend.material.SetColor("_Color", Color.white);

                        if (rend.sharedMaterial != null)
                        {
                            if (rend.sharedMaterial.HasProperty("_BaseMap")) rend.sharedMaterial.SetTexture("_BaseMap", zilleTex);
                            if (rend.sharedMaterial.HasProperty("_MainTex")) rend.sharedMaterial.SetTexture("_MainTex", zilleTex);
                            if (rend.sharedMaterial.HasProperty("_BaseColor")) rend.sharedMaterial.SetColor("_BaseColor", Color.white);
                        }

                        _tableTextureApplied = true;
                        MelonLogger.Msg($"[WAR THEATRE] War table background locked to Zille Composite Map ({zilleTex.width}x{zilleTex.height})!");
                    }
                }
            }
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
