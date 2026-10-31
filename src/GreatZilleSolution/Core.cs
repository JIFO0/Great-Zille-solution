using MelonLoader;
using UnityEngine;
using Il2Cpp;
using System.Reflection;

[assembly: MelonInfo(typeof(GreatZilleSolution.GreatZilleMod), "Great Zille Solution", "0.4.9", "RIOT")]
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
        private bool _dockExpanded = true;

        public override void OnInitializeMelon()
        {
            Log = LoggerInstance;
            Log.Msg("=================================================");
            Log.Msg(" [Great Zille Solution] Military & Narrative Mod ");
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
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            Log.Msg($"[Great Zille] Scene loaded: {sceneName} (Index: {buildIndex})");
            
            // Once game scene loads (DirectX is fully active), trigger texture loading and register entities
            try
            {
                ZilleMapLayoutManager.EnsureTexturesLoaded();
                WarOperationZilleManager.RegisterNativeZilleEntities();
                DialogueInjectionPatches.InjectWarOptionsIntoVanillaConversations();
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
                WarOperationZilleManager.CheckScheduledTransition(Time.deltaTime);
                WarOperationZilleManager.UpdateWarTheatreState();
                WarOperationZilleManager.UpdateEventTokenInteractions();
                ZilleTheatreMenu.TickOrders();
            }
            catch { }
        }

        public override void OnLateUpdate()
        {
            try { ZilleWarTable.LatePass(); } catch { }
        }

        public override void OnGUI()
        {
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
                        ZilleWarTable.Diagnose("F8");
                    }
                    else if (Event.current.keyCode == KeyCode.F11)
                    {
                        if (_theatreMenu != null) _theatreMenu.IsOpen = !_theatreMenu.IsOpen;
                    }
                }

                ZilleWarTable.HandlePlacementEvent(Event.current);
                ZilleWarTable.HandleMapEdit(Event.current);
                bool nativeDeployment = ZilleWarTable.NativeDeploymentOpen();
                if (nativeDeployment) _dockExpanded = false;
                ZilleWarTable.DrawMapEditBar();
                ZilleRightDock.Draw();
                if (!nativeDeployment && (Event.current.type == EventType.Repaint || Event.current.type == EventType.Layout))
                    ZilleWarTable.DrawPlacementHud();

                if (!nativeDeployment)
                {
                    GUI.color = Color.white;
                    string statusText = "[ Great Zille v0.4.9 | F9 Wojna | F10 Mapa | F11 Teatr ]";
                    GUI.Box(new Rect(Screen.width - 470, 10, 460, 28), statusText);
                    DrawBottomLeftToolbar();
                }

                // Draw Debug War Menu
                if (_showDebugMenu)
                {
                    _debugWindowRect = GUI.Window(9901, _debugWindowRect, (GUI.WindowFunction)DrawDebugWindow, "[Great Zille Solution] Tactical & Story War Debugger");
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
            }
            catch (System.Exception ex)
            {
                Log.Error($"[Great Zille OnGUI Error]: {ex.Message}");
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
            float panelHeight = 428f;
            float panelX = padding;
            float panelY = Screen.height - panelHeight - padding;
            Rect panelRect = new Rect(panelX, panelY, panelWidth, panelHeight);

            GUI.Box(panelRect, "<b>GREAT ZILLE DOCK</b>");

            float btnX = panelX + 8f;
            float btnW = panelWidth - 16f;
            float curY = panelY + 24f;

            // Button 1: Spawn Native War Event Token at Zille
            GUI.color = new Color(0.4f, 0.95f, 0.5f);
            if (GUI.Button(new Rect(btnX, curY, btnW, 30f), "[SPAWN EVENT ZILLE]"))
            {
                WarOperationZilleManager.SpawnZilleWarEventToken();
            }
            GUI.color = Color.white;
            curY += 34f;

            // Button 2: Focus Porte Drazon War Council Briefing Event
            GUI.color = new Color(0.3f, 0.8f, 1f);
            if (GUI.Button(new Rect(btnX, curY, btnW, 32f), "[NARADA WOJENNA]"))
            {
                WarOperationZilleManager.FocusPorteDrazonBriefing();
            }
            GUI.color = Color.white;
            curY += 36f;

            // Button 3: Direct Independent Zille 3D War Theatre
            GUI.color = new Color(1f, 0.85f, 0.2f);
            if (GUI.Button(new Rect(btnX, curY, btnW, 34f), "[TEATR 3D ZILLE]"))
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
            if (GUI.Button(new Rect(btnX, curY, btnW, 28f), "[TEATR MENU (F11)]"))
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
        }

        private void DrawDebugWindow(int windowId)
        {
            float x = 16f;
            float w = 418f;
            float y = 26f;

            GUI.Label(new Rect(x, y, w, 20f), $"<b>Campaign Phase:</b> {ZilleCampaignState.CurrentPhase}"); y += 20f;
            GUI.Label(new Rect(x, y, w, 20f), $"<b>Sentiment Level:</b> {ZilleCampaignState.MilitarySentimentLevel}"); y += 20f;
            GUI.Label(new Rect(x, y, w, 20f), $"<b>Chosen Doctrine:</b> {ZilleCampaignState.ChosenPath}"); y += 20f;
            GUI.Label(new Rect(x, y, w, 20f), $"<b>Lespia:</b> {ZilleCampaignState.IsLespiaPactAccepted} | <b>Derdia:</b> {ZilleCampaignState.IsDerdiaHybridSupportActive}"); y += 20f;
            GUI.Label(new Rect(x, y, w, 20f), $"<b>Units:</b> Zille={ZilleCampaignState.UnitsCommittedToZille} | Pales={ZilleCampaignState.UnitsCommittedToPales}"); y += 20f;
            GUI.Label(new Rect(x, y, w, 20f), $"<b>Brenas Lost:</b> {ZilleCampaignState.IsBrenasLost} | <b>Estela Dead:</b> {ZilleCampaignState.IsMotherCaptured}"); y += 24f;

            GUI.Box(new Rect(x, y, w, 2f), GUIContent.none); y += 6f;
            GUI.Label(new Rect(x, y, w, 20f), "<b>--- TEATR WOJENNY ZILLE (3D REAL WAR) ---</b>"); y += 22f;

            GUI.color = new Color(0.4f, 0.95f, 0.5f);
            if (GUI.Button(new Rect(x, y, w, 32f), "[Zrespij Token Eventu w Prowincji Zille]"))
            {
                WarOperationZilleManager.SpawnZilleWarEventToken();
            }
            y += 36f;

            GUI.color = new Color(1f, 0.85f, 0.2f);
            if (GUI.Button(new Rect(x, y, w, 34f), "[TEATR 3D ZILLE (Operacja 1: Righteous Sword - Frontal)]"))
            {
                WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                WarOperationZilleManager.EnterZilleWarTheatre();
            }
            y += 38f;

            if (GUI.Button(new Rect(x, y, w, 32f), "[TEATR 3D ZILLE (Operacja 2: Kleszcze Munat / Wiktrany)]"))
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
    }
}
