using MelonLoader;
using HarmonyLib;
using UnityEngine;
using GreatZilleSolution;

[assembly: MelonInfo(typeof(GreatZilleMod), "Great Zille Solution", "0.3.0", "RIOT")]
[assembly: MelonGame("Torpor Games", "Suzerain")]

namespace GreatZilleSolution
{
    public class GreatZilleMod : MelonMod
    {
        public static MelonLogger.Instance Log { get; private set; }
        private bool _showDebugMenu = false;
        private Rect _debugWindowRect = new Rect(30, 30, 420, 440);

        public override void OnInitializeMelon()
        {
            Log = LoggerInstance;

            Log.Msg("=================================================");
            Log.Msg(" [Great Zille Solution] Military & Narrative Mod ");
            Log.Msg(" Version: 0.3.0 (Accurate Timeline & Zille War)  ");
            Log.Msg(" Initializing Dialogue & War Hooks manually...   ");
            Log.Msg("=================================================");

            DialogueHelper.Init();
            DialogueInjectionPatches.RegisterManualPatches(HarmonyInstance);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            Log.Msg($"[Great Zille] Scene loaded: {sceneName} (Index: {buildIndex})");
        }

        public override void OnGUI()
        {
            // Toggle test menu with F9
            if (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.F9)
            {
                _showDebugMenu = !_showDebugMenu;
            }

            // Top-right watermark indicator
            GUI.color = Color.white;
            string statusText = "[ Great Zille Solution v0.3.0 | ACTIVE (F9: Menu) ]";
            GUI.Box(new Rect(Screen.width - 360, 10, 350, 28), statusText);

            if (_showDebugMenu)
            {
                _debugWindowRect = GUI.Window(9901, _debugWindowRect, (GUI.WindowFunction)DrawDebugWindow, "[Great Zille Solution] Tactical & Story Debugger");
            }
        }

        private void DrawDebugWindow(int windowId)
        {
            GUILayout.BeginVertical();

            GUILayout.Label($"<b>Campaign Phase:</b> {ZilleCampaignState.CurrentPhase}");
            GUILayout.Label($"<b>Sentiment Level:</b> {ZilleCampaignState.MilitarySentimentLevel}");
            GUILayout.Label($"<b>Chosen Doctrine:</b> {ZilleCampaignState.ChosenPath}");
            GUILayout.Label($"<b>Lespia Pact:</b> {ZilleCampaignState.IsLespiaPactAccepted} | <b>Derdia Support:</b> {ZilleCampaignState.IsDerdiaHybridSupportActive}");
            GUILayout.Label($"<b>Unit Allocation:</b> Zille={ZilleCampaignState.UnitsCommittedToZille} | Pales={ZilleCampaignState.UnitsCommittedToPales}");
            GUILayout.Label($"<b>Catastrophe Status:</b> BrenasLost={ZilleCampaignState.IsBrenasLost} | EstelaDead={ZilleCampaignState.IsMotherCaptured}");

            GUILayout.Space(8);
            GUILayout.Label("<b>--- MANUAL WAR TRIGGER TEST ---</b>");

            if (GUILayout.Button("Test: Turn 3 Reckless War (Catastrophic Defeat)"))
            {
                WarOperationZilleManager.TriggerCatastrophicDefeat(motherDied: true, brenasLost: true);
                DialogueHelper.ShowAlert("[TEST] Catastrophic Defeat triggered! Brenas lost & Queen Mother Estela captured.");
            }

            if (GUILayout.Button("Test: Turn 8 War - Plan Alpha (Direct Assault)"))
            {
                WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                DialogueHelper.ShowAlert("[TEST] Operation Righteous Sword: Plan Alpha (Frontal Assault) initiated!");
            }

            if (GUILayout.Button("Test: Turn 8 War - Plan Beta (Munat & Viktrany Pincer)"))
            {
                WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                DialogueHelper.ShowAlert("[TEST] Operation Righteous Sword: Plan Beta (Munat / Viktrany Flank) initiated!");
            }

            if (GUILayout.Button("Test: Simulate Victory in Zille"))
            {
                WarOperationZilleManager.TriggerVictory();
                DialogueHelper.ShowAlert("[TEST] VICTORY IN ZILLE! Crown forces secured territory.");
            }

            GUILayout.Space(10);
            if (GUILayout.Button("Close Menu (F9)"))
            {
                _showDebugMenu = false;
            }

            GUILayout.EndVertical();
            GUI.DragWindow();
        }
    }
}
