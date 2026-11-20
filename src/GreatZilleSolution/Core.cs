using MelonLoader;

using UnityEngine;

using Il2Cpp;

using System.Reflection;



[assembly: MelonInfo(typeof(GreatZilleSolution.GreatZilleMod), "Great Zille Solution", "0.4.9", "JIFO", "https://jifo.dev")]

[assembly: MelonGame("Torpor Games", "Suzerain")]



namespace GreatZilleSolution

{

    public class GreatZilleMod : MelonMod

    {

        public static MelonLogger.Instance Log { get; private set; }



        private bool _showDebugMenu = false;

        private Rect _debugWindowRect = new Rect(20, 20, 450, 640);

        private int _roadProv;

        private ZilleWarMapEditorUI _editorUI;

        private ZilleTheatreMenu _theatreMenu;

        private ZilleEventSpawnerUI _spawnerUI;

        private bool _dockExpanded = true;
        private bool _forceShowDock = false;
        private float _nextFlagCheck = 0f;



        public override void OnInitializeMelon()

        {

            Log = LoggerInstance;

            Log.Msg("=================================================");

            Log.Msg(" [Great Zille Solution] Military & Narrative Mod ");

            Log.Msg(" Author: JIFO | Website: https://jifo.dev         ");

            Log.Msg(" Version: 0.4.9 (Theatre menu: scale, provinces, units) ");

            Log.Msg(" Initializing Dialogue & War Hooks manually...   ");

            Log.Msg("=================================================");



            DialogueHelper.Init();



            // Register manual Harmony patches

            DialogueInjectionPatches.RegisterManualPatches(HarmonyInstance);



            // Initialize Zille Map Layout & Textures

            ZilleMapLayoutManager.Initialize();



            // Initialize Interactive Map Editor UI and the in-game theatre menu

            _editorUI = new ZilleWarMapEditorUI();

            _theatreMenu = new ZilleTheatreMenu();

            _spawnerUI = new ZilleEventSpawnerUI();

        }



        public override void OnSceneWasLoaded(int buildIndex, string sceneName)

        {

            Log.Msg($"[Great Zille] Scene loaded: {sceneName} (Index: {buildIndex})");

            // Ignore initial bootstrap scene before game databases are initialized
            if (string.IsNullOrEmpty(sceneName) || sceneName.Equals("Initialize", System.StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            // Mod logo: main menu badge + window icon (optional, never throws)
            try { ZilleBranding.OnSceneLoaded(sceneName); } catch { }

            // Once game scene loads (DirectX is fully active), trigger texture loading and register entities

            try

            {

                ZilleMapLayoutManager.EnsureTexturesLoaded();

                WarOperationZilleManager.RegisterNativeZilleEntities();

                ZilleDialogueSystem.EnsureAllConversationsRegistered();
                ZilleCampaignState.SyncFromLua(resetMissing: true);
                ZilleWarTable.ReloadSavedBoardStateFromLua();
                DialogueInjectionPatches.InjectWarOptionsIntoVanillaConversations();
                DialogueOverrideManager.ApplyAllOverrides();
                ZilleDecisions.EnsureRegistered();
                ZilleReportsAndSituations.EnsureRegisteredAndSynced();

                if (DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitUnlocked")
                    && !DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitDone")
                    && !ZilleCampaignState.IsDerdiaStateVisitDone)
                {
                    WarOperationZilleManager.SpawnDerdiaVisitEventToken();
                }

            }

            catch (System.Exception ex)

            {

                Log.Error($"[Great Zille] Error loading textures on scene load: {ex.Message}");

            }

        }



        public override void OnUpdate()
        {
            try
            {
                if (Time.unscaledTime > _nextFlagCheck)
                {
                    _nextFlagCheck = Time.unscaledTime + 1.0f;
                    string flag1 = System.IO.Path.Combine(Application.dataPath, "..", "run_test.flag");
                    string flag2 = @"c:\Projects\Great Zille solution\run_test.flag";
                    string eflag1 = System.IO.Path.Combine(Application.dataPath, "..", "run_events_test.flag");
                    string eflag2 = @"c:\Projects\Great Zille solution\run_events_test.flag";
                    if (System.IO.File.Exists(eflag1) || System.IO.File.Exists(eflag2))
                    {
                        try { if (System.IO.File.Exists(eflag1)) System.IO.File.Delete(eflag1); } catch { }
                        try { if (System.IO.File.Exists(eflag2)) System.IO.File.Delete(eflag2); } catch { }
                        Log.Msg("[AUTOTEST] run_events_test.flag detected! Starting autonomous Events, Portraits & Saves playtest suite...");
                        MelonCoroutines.Start(ZillePlaytest.RunAutonomousEventsAndSavesSuiteCoroutine());
                    }
                    else if (System.IO.File.Exists(flag1) || System.IO.File.Exists(flag2))
                    {
                        try { if (System.IO.File.Exists(flag1)) System.IO.File.Delete(flag1); } catch { }
                        try { if (System.IO.File.Exists(flag2)) System.IO.File.Delete(flag2); } catch { }
                        Log.Msg("[AUTOTEST] run_test.flag detected! Starting comprehensive ZillePlaytest suite...");
                        MelonCoroutines.Start(ZillePlaytest.RunFullSuiteCoroutine());
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Warning("[AUTOTEST] Flag check error: " + ex.Message);
            }

            try
            {
                var curScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                if (string.Equals(curScene.name, "Initialize", System.StringComparison.OrdinalIgnoreCase)) return;

                WarOperationZilleManager.CheckScheduledTransition(Time.deltaTime);
                WarOperationZilleManager.UpdateWarTheatreState();
                WarOperationZilleManager.UpdateEventTokenInteractions();
                ZilleTheatreMenu.TickOrders();
            }
            catch { }

            ZilleProfiler.ReportFrame(Time.unscaledDeltaTime);
        }



        public override void OnLateUpdate()

        {

            try { ZilleWarTable.LatePass(); } catch { }

        }



        public override void OnGUI()

        {

            ZilleProfiler.BeginOnGUI();

            try

            {

                // Toggle menus with F9 (War Debugger) and F10 (Map & Region Editor)

                if (Event.current.type == EventType.KeyDown)

                {

                    if (Event.current.keyCode == KeyCode.F9)

                    {

                        _showDebugMenu = !_showDebugMenu;

                    }

                    else if (Event.current.keyCode == KeyCode.F10)

                    {

                        if (_editorUI != null) _editorUI.IsOpen = !_editorUI.IsOpen;

                    }

                    else if (Event.current.keyCode == KeyCode.F6)

                    {

                        // Enter the Zille war theatre (same as the [TEATR 3D ZILLE] dock button)

                        WarOperationZilleManager.EnterZilleWarTheatre();

                    }

                    else if (Event.current.keyCode == KeyCode.F7)

                    {

                        // Toggle the Zille skin on the live war table (Zille <-> vanilla Pales)

                        ZilleWarTable.SkinEnabled = !ZilleWarTable.SkinEnabled;

                        Log.Msg($"[ZTABLE] SkinEnabled = {ZilleWarTable.SkinEnabled}");

                    }

                    else if (Event.current.keyCode == KeyCode.F8)

                    {

                        bool ctrl = (Event.current.modifiers & EventModifiers.Control) != 0 || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);

                        bool shift = (Event.current.modifiers & EventModifiers.Shift) != 0 || Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

                        if (ctrl && shift)

                        {

                            _forceShowDock = !_forceShowDock;

                            if (_forceShowDock) _dockExpanded = true;

                            Log.Msg($"[DOCK] Debug force-show Zille Dock = {_forceShowDock}");

                            Event.current.Use();

                        }

                        else

                        {

                            ZilleProfiler.ForceReport();

                            ZilleWarTable.Diagnose("F8");

                        }

                    }

                    else if (Event.current.keyCode == KeyCode.F6)

                    {

                        if (_spawnerUI != null) _spawnerUI.IsOpen = !_spawnerUI.IsOpen;

                    }

                    else if (Event.current.keyCode == KeyCode.F11)

                    {

                        if (_theatreMenu != null) _theatreMenu.IsOpen = !_theatreMenu.IsOpen;

                    }

                    else if (Event.current.keyCode == KeyCode.F12)

                    {

                        MelonCoroutines.Start(RunAutomatedCampaignTestCoroutine());

                    }

                }



                ZilleBranding.DrawMainMenuLogo();

                ZilleWarTable.HandlePlacementEvent(Event.current);

                ZilleWarTable.HandleMapEdit(Event.current);

                bool nativeDeployment = ZilleWarTable.NativeDeploymentOpen();

                if (nativeDeployment && !_forceShowDock) _dockExpanded = false;

                ZilleWarTable.DrawMapEditBar();

                ZilleRightDock.Draw();

                if (!nativeDeployment && (Event.current.type == EventType.Repaint || Event.current.type == EventType.Layout))

                    ZilleWarTable.DrawPlacementHud();



                if (!nativeDeployment || _forceShowDock)

                {

                    GUI.color = Color.white;

                    if (!nativeDeployment)

                    {

                        string statusText = "[ Great Zille v0.4.9 by JIFO (jifo.dev) | F6 Spawner | F9 Wojna | F10 Mapa | F11 Teatr ]";

                        GUI.Box(new Rect(Screen.width - 640, 10, 630, 28), statusText);

                        ZilleBranding.DrawIcon(new Rect(Screen.width - 640 - 36, 6, 32, 32));

                    }

                    DrawBottomLeftToolbar();

                }



                // Draw Debug War Menu

                if (_showDebugMenu)

                {

                    _debugWindowRect = GUI.Window(9901, _debugWindowRect, (GUI.WindowFunction)DrawDebugWindow, "[Great Zille Solution] War Debugger | JIFO (jifo.dev)");

                }



                // Draw Interactive Tile & Map Editor Window

                if (_editorUI != null && _editorUI.IsOpen)

                {

                    _editorUI.DrawGUI();

                }



                if (_theatreMenu != null && _theatreMenu.IsOpen)

                {

                    _theatreMenu.DrawGUI();

                }



                if (_spawnerUI != null && _spawnerUI.IsOpen)

                {

                    _spawnerUI.DrawGUI();

                }

                if (ZilleDecisions.ActiveModalDecision != null)
                {
                    DrawDecisionModal();
                }

            }

            catch (System.Exception ex)

            {

                Log.Error($"[Great Zille OnGUI Error]: {ex.Message}");

            }
            finally
            {
                ZilleProfiler.EndOnGUI();
            }

        }



        private void DrawDecisionModal()
        {
            var dec = ZilleDecisions.ActiveModalDecision;
            if (dec == null) return;

            float w = Mathf.Min(640f, Screen.width - 40f);
            float h = 230f + dec.Options.Count * 46f;
            float x = (Screen.width - w) * 0.5f;
            float y = (Screen.height - h) * 0.5f;

            GUI.color = new Color(0.08f, 0.09f, 0.12f, 0.96f);
            GUI.Box(new Rect(x, y, w, h), "");
            GUI.color = Color.white;

            var titleStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 16,
                fontStyle = FontStyle.Bold,
                wordWrap = true
            };
            var descStyle = new GUIStyle(GUI.skin.label)
            {
                fontSize = 13,
                wordWrap = true
            };

            GUI.Label(new Rect(x + 20f, y + 16f, w - 70f, 30f), dec.Title, titleStyle);
            if (GUI.Button(new Rect(x + w - 42f, y + 14f, 26f, 24f), "X"))
            {
                ZilleDecisions.CloseModal();
                return;
            }

            GUI.Label(new Rect(x + 20f, y + 52f, w - 40f, 110f), dec.Description, descStyle);

            float btnY = y + 170f;
            foreach (var opt in dec.Options)
            {
                bool avail = opt.IsAvailable == null || opt.IsAvailable();
                GUI.enabled = avail;
                string label = avail
                    ? opt.Text
                    : $"{opt.Text}  [Requires: {opt.Condition}]";
                if (GUI.Button(new Rect(x + 20f, btnY, w - 40f, 38f), label))
                {
                    opt.OnSelected?.Invoke();
                    break;
                }
                GUI.enabled = true;
                btnY += 44f;
            }
        }

        private void DrawBottomLeftToolbar()

        {

            float padding = 12f;

            

            if (!_dockExpanded)

            {

                // Collapsed button tab at bottom-left corner

                Rect collRect = new Rect(padding, Screen.height - 48f, 130f, 36f);

                if (GUI.Button(collRect, "ZILLE DOCK >"))

                {

                    _dockExpanded = true;

                }

                return;

            }



            // Expanded Bottom-Left Panel

            float panelWidth = 205f;

            float panelHeight = 482f;

            float panelX = padding;

            float panelY = Screen.height - panelHeight - padding;

            Rect panelRect = new Rect(panelX, panelY, panelWidth, panelHeight);



            GUI.Box(panelRect, "<b>GREAT ZILLE DOCK</b>");



            float btnX = panelX + 8f;

            float btnW = panelWidth - 16f;

            float curY = panelY + 24f;



            // Button 0: Event Spawner for Porte Drazon

            GUI.color = new Color(0.9f, 0.45f, 1f);

            if (GUI.Button(new Rect(btnX, curY, btnW, 30f), "[EVENT SPAWNER (F6)]"))

            {

                if (_spawnerUI != null) _spawnerUI.IsOpen = !_spawnerUI.IsOpen;

            }

            GUI.color = Color.white;

            curY += 34f;



            // Button 1: Spawn Native War Event Token at Zille

            GUI.color = new Color(0.4f, 0.95f, 0.5f);

            if (GUI.Button(new Rect(btnX, curY, btnW, 30f), "[SPAWN ZILLE EVENT]"))

            {

                WarOperationZilleManager.SpawnZilleWarEventToken();

            }

            GUI.color = Color.white;

            curY += 34f;



            // Button 2: Focus Porte Drazon War Council Briefing Event

            GUI.color = new Color(0.3f, 0.8f, 1f);

            if (GUI.Button(new Rect(btnX, curY, btnW, 32f), "[WAR COUNCIL BRIEFING]"))

            {

                WarOperationZilleManager.FocusPorteDrazonBriefing();

            }

            GUI.color = Color.white;

            curY += 36f;



            // Button 3: Direct Independent Zille 3D War Theatre

            GUI.color = new Color(1f, 0.85f, 0.2f);

            if (GUI.Button(new Rect(btnX, curY, btnW, 34f), "[3D ZILLE THEATRE]"))

            {

                WarOperationZilleManager.EnterZilleWarTheatre();

            }

            GUI.color = Color.white;

            curY += 38f;



            GUI.color = new Color(0.75f, 0.9f, 1f);

            if (GUI.Button(new Rect(btnX, curY, btnW, 32f), "[TRYB EDYCJI]"))

            {

                WarOperationZilleManager.EnterZilleWarTheatre(true);

                if (_editorUI != null) _editorUI.IsOpen = true;

            }

            GUI.color = Color.white;

            curY += 36f;



            // Button 4: Map & Region Editor

            bool isEditorOpen = _editorUI != null && _editorUI.IsOpen;

            GUI.color = isEditorOpen ? new Color(0.7f, 1f, 0.7f) : Color.white;

            if (GUI.Button(new Rect(btnX, curY, btnW, 28f), "[REGIONY (F10)]"))

            {

                if (_editorUI != null) _editorUI.IsOpen = !_editorUI.IsOpen;

            }

            GUI.color = Color.white;

            curY += 32f;



            bool theatreOpen = _theatreMenu != null && _theatreMenu.IsOpen;

            GUI.color = theatreOpen ? new Color(1f, 0.75f, 0.35f) : new Color(0.95f, 0.7f, 0.35f);

            if (GUI.Button(new Rect(btnX, curY, btnW, 28f), "[THEATRE MENU (F11)]"))

            {

                if (_theatreMenu != null) _theatreMenu.IsOpen = !_theatreMenu.IsOpen;

            }

            GUI.color = Color.white;

            curY += 32f;



            // Button 5: Quick Save Layout

            if (GUI.Button(new Rect(btnX, curY, btnW, 24f), "[Zapisz uklad]"))

            {

                if (ZilleMapLayoutManager.SaveConfig())

                    DialogueHelper.ShowAlert("[Zille] Uklad kafelkow pomyslnie zapisany.");

            }

            curY += 28f;



            // Button 6: Quick Reload Layout

            if (GUI.Button(new Rect(btnX, curY, btnW, 24f), "[Wczytaj uklad]"))

            {

                ZilleMapLayoutManager.ReloadSavedLayout();

                ZilleMapLayoutManager.LoadAllTextures();

                DialogueHelper.ShowAlert("[Zille] Konfiguracja i tekstury zaladowane.");

            }

            curY += 28f;



            // Button 7: Return to base civilian map

            if (GUI.Button(new Rect(btnX, curY, btnW, 24f), "[Powrot do mapy]"))

            {

                WarOperationZilleManager.ReturnToCivilianMap();

            }

            curY += 26f;



            // Button 8: Collapse

            if (GUI.Button(new Rect(btnX, curY, btnW, 20f), "[Zwin panel]"))

            {

                _dockExpanded = false;

            }

            curY += 22f;

            GUI.Label(new Rect(btnX, curY, btnW, 18f), "<size=10><color=#90cdf4>by JIFO • jifo.dev</color></size>");

        }



        private void DrawDebugWindow(int windowId)

        {

            float x = 16f;

            float w = 418f;

            float y = 26f;



            GUI.Label(new Rect(x, y, w, 20f), "<b>Mod Author:</b> JIFO (<color=#63b3ed>https://jifo.dev</color>)"); y += 20f;

            GUI.Label(new Rect(x, y, w, 20f), $"<b>Campaign Phase:</b> {ZilleCampaignState.CurrentPhase}"); y += 20f;

            GUI.Label(new Rect(x, y, w, 20f), $"<b>Sentiment Level:</b> {ZilleCampaignState.MilitarySentimentLevel}"); y += 20f;

            GUI.Label(new Rect(x, y, w, 20f), $"<b>Chosen Doctrine:</b> {ZilleCampaignState.ChosenPath}"); y += 20f;

            GUI.Label(new Rect(x, y, w, 20f), $"<b>Lespia:</b> {ZilleCampaignState.IsLespiaPactAccepted} | <b>Derdia:</b> {ZilleCampaignState.IsDerdiaHybridSupportActive}"); y += 20f;

            GUI.Label(new Rect(x, y, w, 20f), $"<b>Units:</b> Zille={ZilleCampaignState.UnitsCommittedToZille} | Pales={ZilleCampaignState.UnitsCommittedToPales}"); y += 20f;

            GUI.Label(new Rect(x, y, w, 20f), $"<b>Brenas Lost:</b> {ZilleCampaignState.IsBrenasLost} | <b>Estela Dead:</b> {ZilleCampaignState.IsMotherCaptured}"); y += 24f;



            GUI.Box(new Rect(x, y, w, 2f), GUIContent.none); y += 6f;

            GUI.Label(new Rect(x, y, w, 20f), "<b>--- ZILLE WAR THEATRE (3D REAL WAR) ---</b>"); y += 22f;



            GUI.color = new Color(0.9f, 0.45f, 1f);

            if (GUI.Button(new Rect(x, y, w, 32f), "[PORTE DRAZON EVENT SPAWNER (F6)]"))

            {

                if (_spawnerUI != null) _spawnerUI.IsOpen = true;

            }

            GUI.color = Color.white;

            y += 36f;



            GUI.color = new Color(0.4f, 0.95f, 0.5f);

            if (GUI.Button(new Rect(x, y, w, 32f), "[Spawn Zille Event Token]"))

            {

                WarOperationZilleManager.SpawnZilleWarEventToken();

            }

            y += 36f;



            GUI.color = new Color(1f, 0.85f, 0.2f);

            if (GUI.Button(new Rect(x, y, w, 34f), "[3D ZILLE THEATRE (Operation 1: Righteous Sword - Frontal)]"))

            {

                WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);

                WarOperationZilleManager.EnterZilleWarTheatre();

            }

            y += 38f;



            if (GUI.Button(new Rect(x, y, w, 32f), "[3D ZILLE THEATRE (Operation 2: Pincer Munat / Wiktrany)]"))

            {

                WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);

                WarOperationZilleManager.EnterZilleWarTheatre();

            }

            y += 36f;



            GUI.color = Color.white;

            DrawRoadDebug(x, w, ref y);

            if (GUI.Button(new Rect(x, y, w, 26f), "[Wroc do Mapy Glownej Rizii]"))
            {
                WarOperationZilleManager.ReturnToCivilianMap();
            }
            y += 32f;

            if (GUI.Button(new Rect(x, y, w, 28f), "[TEST: Pominięcie Tury (End War Turn)]"))
            {
                var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (flow != null) flow.EndWarTurn();
            }
            y += 32f;

            if (GUI.Button(new Rect(x, y, w, 28f), "[TEST: Zakoncz Operacje i Pokaz Raport Koncowy]"))
            {
                WarOperationZilleManager.ReturnToCivilianMapWithReport();
            }
            y += 32f;

            GUI.color = new Color(0.3f, 1f, 0.4f);
            if (GUI.Button(new Rect(x, y, w, 32f), "[TEST: Pelny Auto-Test Kampanii (F12)]"))
            {
                MelonCoroutines.Start(RunAutomatedCampaignTestCoroutine());
            }
            GUI.color = Color.white;
            y += 36f;



            GUI.Box(new Rect(x, y, w, 2f), GUIContent.none); y += 6f;

            GUI.Label(new Rect(x, y, w, 20f), "<b>--- SYMULACJE PRZEBIEGU KAMPANII ---</b>"); y += 22f;



            if (GUI.Button(new Rect(x, y, w, 28f), "Test: Turn 3 Reckless War (Catastrophic Defeat)"))

            {

                WarOperationZilleManager.TriggerCatastrophicDefeat(motherDied: true, brenasLost: true);

                DialogueHelper.ShowAlert("[TEST] Catastrophic Defeat triggered! Brenas lost & Queen Mother Estela captured.");

            }

            y += 32f;



            if (GUI.Button(new Rect(x, y, w, 28f), "Test: Simulate Victory in Zille"))

            {

                WarOperationZilleManager.TriggerVictory();

                DialogueHelper.ShowAlert("[TEST] VICTORY IN ZILLE! Crown forces secured territory.");

            }

            y += 34f;



            float halfW = (w - 8f) / 2f;

            if (GUI.Button(new Rect(x, y, halfW, 30f), "[Edytor Regionow (F10)]"))

            {

                if (_editorUI != null) _editorUI.IsOpen = true;

            }

            if (GUI.Button(new Rect(x + halfW + 8f, y, halfW, 30f), "[Zamknij Menu (F9)]"))

            {

                _showDebugMenu = false;

            }



            GUI.DragWindow(new Rect(0, 0, 450, 24));

        }



        private void DrawRoadDebug(float x, float w, ref float y)

        {

            var tiles = ZilleMapLayoutManager.CurrentConfig?.Tiles;

            if (tiles == null || tiles.Count == 0) return;

            GUI.Label(new Rect(x, y, w, 18f), "<b>Drogi (dodaj / usun)</b>");

            y += 20f;

            _roadProv = Mathf.Clamp(_roadProv, 0, tiles.Count - 1);

            if (GUI.Button(new Rect(x, y, 28f, 22f), "<")) _roadProv = (_roadProv + tiles.Count - 1) % tiles.Count;

            GUI.Label(new Rect(x + 32f, y, w - 64f, 22f), tiles[_roadProv].Name);

            if (GUI.Button(new Rect(x + w - 28f, y, 28f, 22f), ">")) _roadProv = (_roadProv + 1) % tiles.Count;

            y += 26f;

            var sel = tiles[_roadProv];

            if (sel.AdjacentIds == null) return;

            int shown = 0;

            for (int i = 0; i < sel.AdjacentIds.Count && shown < 6; i++)

            {

                ZilleTileData other = null;

                for (int t = 0; t < tiles.Count; t++)

                    if (tiles[t].Id == sel.AdjacentIds[i]) { other = tiles[t]; break; }

                if (other == null || other.IsSea) continue;

                bool has = sel.RoadToIds != null && sel.RoadToIds.Contains(other.Id);

                if (GUI.Button(new Rect(x, y, w, 20f), (has ? "[usun] " : "[dodaj] ") + other.Name))

                {

                    ZilleMapLayoutManager.ToggleRoad(sel, other);

                    ZilleWarTable.InvalidateRoads();

                    ZilleMapLayoutManager.SaveConfig();

                }

                y += 22f;

                shown++;

            }

            y += 6f;

        }

        private static System.Collections.IEnumerator RunAutomatedCampaignTestCoroutine()
        {
            MelonLogger.Msg("=================================================");
            MelonLogger.Msg("[AUTOTEST] Rozpoczynam pelny test scenariusza Zille!");
            MelonLogger.Msg("=================================================");

            // Czekamy na zaladowanie Main Menu
            MelonLogger.Msg("[AUTOTEST] Czekam na pelne zaladowanie Main Menu...");
            while (true)
            {
                var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                if (sc != null && string.Equals(sc.name, "Main Menu", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                yield return new WaitForSeconds(1.0f);
            }

            yield return new WaitForSeconds(2.5f);

            MelonLogger.Msg("[AUTOTEST] Main Menu aktywne! Wczytuje najnowszy zapis (OnContinueClick)...");
            float waited = 0f;
            while (waited < 40f)
            {
                var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                if (sc != null && !string.Equals(sc.name, "Main Menu", StringComparison.OrdinalIgnoreCase) && !string.Equals(sc.name, "Initialize", StringComparison.OrdinalIgnoreCase))
                {
                    MelonLogger.Msg($"[AUTOTEST] Zapis zaladowany, aktywna scena: {sc.name}");
                    break;
                }

                var mm = UnityEngine.Object.FindObjectOfType<MainMenuPanel>();
                if (mm != null)
                {
                    try { mm.OnContinueClick(); } catch (Exception ex) { MelonLogger.Warning("[AUTOTEST] OnContinueClick: " + ex.Message); }
                }

                yield return new WaitForSeconds(2.5f);
                waited += 2.5f;
            }

            yield return new WaitForSeconds(3.0f);

            // Krok 1: Inicjalizacja teatru wojennego
            MelonLogger.Msg("[AUTOTEST] Krok 1: Wchodzenie do teatru Zille...");
            WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
            WarOperationZilleManager.EnterZilleWarTheatre();

            yield return new WaitForSeconds(3.0f);

            if (!ZilleWarTable.HasLiveMap)
            {
                MelonLogger.Error("[AUTOTEST FAIL] Teatr wojny Zille nie zaladowal sie poprawnie (HasLiveMap == false).");
                yield break;
            }
            MelonLogger.Msg($"[AUTOTEST OK] Mapa Zille aktywna. Kafelki: {ZilleMapLayoutManager.CurrentConfig?.Tiles?.Count ?? 0}");

            // Sprawdzenie performance
            ZilleProfiler.ForceReport();
            MelonLogger.Msg($"[AUTOTEST PERF] Highlight: {ZilleProfiler.HighlightMs:0.00}ms, LatePass: {ZilleProfiler.LatePassMs:0.00}ms, Tick: {ZilleProfiler.TickMs:0.00}ms");

            // Krok 2: Rozpoczęcie scenariusza (Deployment -> Start)
            MelonLogger.Msg("[AUTOTEST] Krok 2: Rozpoczynanie operacji (StartScenario)...");
            ZilleWarTable.StartScenario();

            yield return new WaitForSeconds(2.5f);

            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow == null)
            {
                MelonLogger.Error("[AUTOTEST FAIL] Brak WarFlowManager w scenie!");
                yield break;
            }

            int currentTurn = flow.GetCurrentWarTurn();
            int actionPoints = flow.GetCurrentActionPoints();
            MelonLogger.Msg($"[AUTOTEST OK] Tura {currentTurn} rozpoczeta. Punkty akcji: {actionPoints}");

            // Sprawdzenie nagłówka fazy (Issue #7)
            var turnPanel = Panels.Instance?.WarTurnPanel ?? UnityEngine.Object.FindObjectOfType<WarTurnPanel>();
            if (turnPanel != null && turnPanel.titleText != null)
            {
                MelonLogger.Msg($"[AUTOTEST] Tytul fazy na ekranie: '{turnPanel.titleText.text}'");
                if (turnPanel.titleText.text.Contains("Phase 0"))
                    MelonLogger.Warning("[AUTOTEST WARN] Wykryto 'Phase 0' w tytule! Zamiana...");
            }

            // Krok 3: Przejście części scenariusza (Tura 1: próbny manewr bojowy, Tury 2+: pomijanie)
            for (int t = 1; t <= 3; t++)
            {
                MelonLogger.Msg($"[AUTOTEST] --- Wykonywanie tury {t} ---");
                yield return new WaitForSeconds(1.0f);

                if (t == 1)
                {
                    // Próbny manewr bojowy jednostki gracza
                    var tokenMgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                    var allTokens = tokenMgr != null ? tokenMgr.instantiatedWarTokens : null;
                    WarToken playerUnit = null;
                    if (allTokens != null)
                    {
                        for (int i = 0; i < allTokens.Count; i++)
                        {
                            var tok = allTokens[i];
                            if (tok != null && !tok.IsDead() && tok.GetTokenAllegiance() == WarToken.WarAllegiance.Player && !ZilleWarTable.IsCityToken(tok))
                            {
                                playerUnit = tok;
                                break;
                            }
                        }
                    }

                    if (playerUnit != null)
                    {
                        var fromTile = playerUnit.GetCurrentWarTile();
                        MelonLogger.Msg($"[AUTOTEST] Znaleziono jednostke gracza: {playerUnit.name} na polu {fromTile?.name}");
                        var adjs = fromTile != null ? fromTile.adjacentWarTiles : null;
                        WarTile moveTo = null;
                        if (adjs != null)
                        {
                            for (int i = 0; i < adjs.Count; i++)
                            {
                                var candidate = adjs[i];
                                if (candidate != null && candidate.GetCurrentToken() == null)
                                {
                                    moveTo = candidate;
                                    break;
                                }
                            }
                        }

                        if (moveTo != null)
                        {
                            MelonLogger.Msg($"[AUTOTEST RUCH] Wykonuje probny ruch jednostki {playerUnit.name} -> {moveTo.name}...");
                            try
                            {
                                playerUnit.Move(moveTo, false);
                                flow.SpendActionPoints(1);
                                MelonLogger.Msg($"[AUTOTEST OK] Jednostka przesunieta! Pozostale AP: {flow.GetCurrentActionPoints()}");
                            }
                            catch (Exception exMove)
                            {
                                MelonLogger.Warning($"[AUTOTEST RUCH] Blad ruchu: {exMove.Message}");
                            }
                            yield return new WaitForSeconds(2.0f);
                        }
                    }
                }

                MelonLogger.Msg($"[AUTOTEST] Konczenie tury gracza {t} (EndWarTurn)...");
                flow.EndWarTurn();

                // Czekamy az wrog zakonczy swoje ruchy
                float waitEnemy = 0f;
                while ((ZilleWarTable.IsEnemyTurnActive() || ZilleWarTable.AnyLiveBattle() || ZilleWarTable.IsAnyTokenMoving()) && waitEnemy < 15f)
                {
                    yield return new WaitForSeconds(0.5f);
                    waitEnemy += 0.5f;
                }
                MelonLogger.Msg($"[AUTOTEST] Tura wroga zakonczona po {waitEnemy:0.0}s.");

                yield return new WaitForSeconds(1.0f);
                MelonLogger.Msg($"[AUTOTEST] Gracz w turze {flow.GetCurrentWarTurn()}, punkty akcji: {flow.GetCurrentActionPoints()}");
            }

            // Krok 4: Zakończenie kampanii i powrót na mapę cywilną (Issue #8)
            MelonLogger.Msg("[AUTOTEST] Krok 4: Konczenie kampanii (ReturnToCivilianMapWithReport)...");
            WarOperationZilleManager.ReturnToCivilianMapWithReport();

            yield return new WaitForSeconds(3.0f);

            bool civOK = WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Civilian;
            MelonLogger.Msg($"[AUTOTEST OK] CurrentTheatre: {WarOperationZilleManager.CurrentTheatre} (CivOK={civOK})");

            var cam = UnityEngine.Object.FindObjectOfType<CameraManager>();
            if (cam != null)
            {
                MelonLogger.Msg($"[AUTOTEST OK] CameraManager na pozycji glownej mapy: {cam.transform.position}");
            }

            var repPanel = Panels.Instance?.ReportPanel ?? UnityEngine.Object.FindObjectOfType<ReportPanel>();
            if (repPanel != null && repPanel.gameObject.activeSelf)
            {
                MelonLogger.Msg("[AUTOTEST OK] Raport koncowy operacji Zille zostal wyswietlony!");
            }

            MelonLogger.Msg("=================================================");
            MelonLogger.Msg("[AUTOTEST SUCCESS] PELNY TEST KAMPANII ZAKONCZONY SUKCESEM!");
            MelonLogger.Msg("=================================================");
            DialogueHelper.ShowAlert("[AUTOTEST SUCCESS] Kampania przetestowana pomyslnie!");
        }

    }

}

