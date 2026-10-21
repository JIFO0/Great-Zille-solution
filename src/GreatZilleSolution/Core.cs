using MelonLoader;
using HarmonyLib;
using GreatZilleSolution;

[assembly: MelonInfo(typeof(GreatZilleMod), "Great Zille Solution", "0.2.0", "RIOT")]
[assembly: MelonGame("Torpor Games", "Suzerain")]

namespace GreatZilleSolution
{
    public class GreatZilleMod : MelonMod
    {
        public static MelonLogger.Instance Log { get; private set; }

        public override void OnInitializeMelon()
        {
            Log = LoggerInstance;

            Log.Msg("=================================================");
            Log.Msg(" [Great Zille Solution] Military & Narrative Mod ");
            Log.Msg(" Version: 0.2.0 (Geopolitics & Derdia Support)   ");
            Log.Msg(" Initializing Dialogue & War Hooks manually...   ");
            Log.Msg("=================================================");

            DialogueHelper.Init();
            DialogueInjectionPatches.RegisterManualPatches(HarmonyInstance);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            Log.Msg($"[Great Zille] Scene loaded: {sceneName} (Index: {buildIndex})");
        }
    }
}
