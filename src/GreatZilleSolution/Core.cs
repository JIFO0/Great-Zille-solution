using MelonLoader;
using UnityEngine;
using Il2Cpp;
using System.Reflection;

[assembly: MelonInfo(typeof(GreatZilleSolution.GreatZilleMod), "Great Zille Solution", "0.4.3", "RIOT")]
[assembly: MelonGame("Torpor Games", "Suzerain")]

namespace GreatZilleSolution
{
    public class GreatZilleMod : MelonMod
    {
        public static MelonLogger.Instance Log { get; private set; }

        private bool _showDebugMenu = false;
        private Rect _debugWindowRect = new Rect(20, 20, 450, 480);
        private ZilleWarMapEditorUI _editorUI;
        private bool _dockExpanded = false;

        public override void OnInitializeMelon()
        {
            Log = LoggerInstance;
            Log.Msg("=================================================");
            Log.Msg(" [Great Zille Solution] Military & Narrative Mod ");
            Log.Msg(" Version: 0.4.3 (War Event & 3D Units Injection) ");
            Log.Msg(" Initializing Dialogue & War Hooks manually...   ");
            Log.Msg("=================================================");

            DialogueHelper.Init();

            // Register manual Harmony patches
            DialogueInjectionPatches.RegisterManualPatches(HarmonyInstance);

            // Initialize Zille Map Layout & Textures
            ZilleMapLayoutManager.Initialize();

            // Initialize Interactive Map Editor UI
            _editorUI = new ZilleWarMapEditorUI();
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            Log.Msg($"[Great Zille] Scene loaded: {sceneName} (Index: {buildIndex})");
            
            // Once game scene loads (DirectX is fully active), trigger texture loading and register entities
            try
            {
                ZilleMapLayoutManager.EnsureTexturesLoaded();
                WarOperationZilleManager.RegisterNativeZilleEntities();
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
            }
            catch { }
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
                }

                // Top-right watermark indicator
                GUI.color = Color.white;
                string statusText = "[ Great Zille Solution v0.4.3 | ACTIVE (F9: Wojna | F10: Mapa) ]";
                GUI.Box(new Rect(Screen.width - 440, 10, 430, 28), statusText);

                // Draw Bottom-Left Quick Action Toolbar
                DrawBottomLeftToolbar();

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
            float panelHeight = 350f;
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

            // Button 4: Map & Region Editor
            bool isEditorOpen = _editorUI != null && _editorUI.IsOpen;
            GUI.color = isEditorOpen ? new Color(0.7f, 1f, 0.7f) : Color.white;
            if (GUI.Button(new Rect(btnX, curY, btnW, 28f), "[REGIONY (F10)]"))
            {
                if (_editorUI != null) _editorUI.IsOpen = !_editorUI.IsOpen;
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
                ZilleMapLayoutManager.LoadConfig();
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
    }
}
