using System;
using System.Collections.Generic;
using HarmonyLib;
using MelonLoader;
using PixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static class DialogueInjectionPatches
    {
        public static void RegisterManualPatches(HarmonyLib.Harmony harmony)
        {
            try
            {
                // Patch ConversationView.StartResponses
                var startResponsesMethod = AccessTools.Method(
                    typeof(ConversationView), 
                    nameof(ConversationView.StartResponses), 
                    new Type[] { typeof(Subtitle), typeof(Response[]) }
                );

                if (startResponsesMethod != null)
                {
                    var prefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(StartResponsesPrefix));
                    harmony.Patch(startResponsesMethod, prefix: new HarmonyMethod(prefix));
                    MelonLogger.Msg("[Great Zille] Successfully hooked ConversationView.StartResponses!");
                }
                else
                {
                    MelonLogger.Warning("[Great Zille] Failed to locate ConversationView.StartResponses!");
                }

                // Patch ConversationView.OnSelectedResponse
                var onSelectedMethod = AccessTools.Method(
                    typeof(ConversationView), 
                    "OnSelectedResponse", 
                    new Type[] { typeof(object), typeof(SelectedResponseEventArgs) }
                );

                if (onSelectedMethod != null)
                {
                    var prefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(OnSelectedResponsePrefix));
                    harmony.Patch(onSelectedMethod, prefix: new HarmonyMethod(prefix));
                    MelonLogger.Msg("[Great Zille] Successfully hooked ConversationView.OnSelectedResponse!");
                }
                else
                {
                    MelonLogger.Warning("[Great Zille] Failed to locate ConversationView.OnSelectedResponse!");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Great Zille] Manual patch registration error: {ex.Message}");
            }
        }

        public static void StartResponsesPrefix(ConversationView __instance, Subtitle subtitle, ref Response[] responses)
        {
            try
            {
                if (responses == null) return;

                string convTitle = DialogueHelper.GetCurrentConversationTitle();
                if (string.IsNullOrEmpty(convTitle)) return;

                // 1. Turn 01: Zille Visit / Speech
                if (convTitle.Contains("Turn01_ZilleVisit") || convTitle.Contains("ZilleVisit_HostileSpeech"))
                {
                    InjectTurn01Response(ref responses);
                }
                // 2. Turn 02: Friendship Day / Trade Demands
                else if (convTitle.Contains("Turn02_Zille") || convTitle.Contains("FriendshipDayPrep"))
                {
                    InjectTurn02Response(ref responses);
                }
                // 3. Turn 03: Bombing Incident in Zille
                else if (convTitle.Contains("Turn03_Zille") || convTitle.Contains("ZilleIncidentRespons"))
                {
                    InjectTurn03Response(ref responses);
                }
                // 4. Turn 04 / Turn 08: Lespia Backchannel Offer
                else if (convTitle.Contains("Turn04_Pales_NavalWithdrawal") || convTitle.Contains("Turn08_AlvarezVisit"))
                {
                    InjectLespiaProposal(ref responses);
                }
                // 5. Turn 07: Derdia Hybrid Warfare Offer
                else if (convTitle.Contains("Turn07_Derdia") || convTitle.Contains("Derdia_FavorsDone"))
                {
                    InjectDerdiaOffer(ref responses);
                }
                // 6. Turn 08: Final Breakdown / Outbreak of War
                else if (convTitle.Contains("Turn08_Zille") || convTitle.Contains("ZilleNegotiat") || convTitle.Contains("ZilleNeg_Agree"))
                {
                    InjectTurn08WarResponse(ref responses);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Great Zille] StartResponsesPrefix error: {ex.Message}");
            }
        }

        private static void InjectTurn01Response(ref Response[] responses)
        {
            if (HasOption(responses, "Zille_Mil_T1")) return;

            string choiceText = "[MOD] \"If this clown won't return our land willingly, we will take it by blood and iron.\"";
            DialogueEntry entry = CreateCustomEntry(1001, choiceText, "Zille_Mil_T1");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected Turn 01 military dialogue option.");
        }

        private static void InjectTurn02Response(ref Response[] responses)
        {
            if (HasOption(responses, "Zille_Mil_T2")) return;

            string choiceText = "[MOD] \"Smolak's demands are an insult to the Crown. Order the General Staff to draft a preemptive invasion plan.\"";
            DialogueEntry entry = CreateCustomEntry(1002, choiceText, "Zille_Mil_T2");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected Turn 02 staff study dialogue option.");
        }

        private static void InjectTurn03Response(ref Response[] responses)
        {
            if (HasOption(responses, "Zille_Mil_T3")) return;

            string choiceText = "[MOD] \"This bombing is Smolak's blatant false-flag. I declare heightened combat readiness along the Brenas border!\"";
            DialogueEntry entry = CreateCustomEntry(1003, choiceText, "Zille_Mil_T3");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected Turn 03 mobilization dialogue option.");
        }

        private static void InjectLespiaProposal(ref Response[] responses)
        {
            if (HasOption(responses, "Lespia_Pact_Accept") || ZilleCampaignState.IsLespiaPactAccepted) return;

            string choiceAccept = "[MOD] [Lespia Backchannel] \"'Agreed, Alvarez. We stand down on Pales, but Lespia and Arcasia must back us against Wehlen with intel and heavy munitions.'\"";
            DialogueEntry entryAccept = CreateCustomEntry(10041, choiceAccept, "Lespia_Pact_Accept");
            AddResponse(ref responses, choiceAccept, entryAccept);

            string choiceRefuse = "[MOD] \"'Rizia does not need Lespian charity. We will handle both Pales and Smolak on our sovereign terms.'\"";
            DialogueEntry entryRefuse = CreateCustomEntry(10042, choiceRefuse, "Lespia_Pact_Refuse");
            AddResponse(ref responses, choiceRefuse, entryRefuse);
            MelonLogger.Msg("[Great Zille] Injected Alvarez backchannel proposal.");
        }

        private static void InjectDerdiaOffer(ref Response[] responses)
        {
            if (HasOption(responses, "Derdia_Hybrid_Accept") || ZilleCampaignState.IsDerdiaHybridSupportActive) return;

            string choiceAccept = "[MOD] [Derdia Intervention] \"'Accept Azmal's offer: Unleash holy irregulars behind Wehzek lines to sabotage their refineries.'\"";
            DialogueEntry entryAccept = CreateCustomEntry(10071, choiceAccept, "Derdia_Hybrid_Accept");
            AddResponse(ref responses, choiceAccept, entryAccept);
            MelonLogger.Msg("[Great Zille] Injected Derdia hybrid warfare proposal.");
        }

        private static void InjectTurn08WarResponse(ref Response[] responses)
        {
            if (HasOption(responses, "Zille_War_Alfa")) return;

            string choiceA = "[MOD] \"Order: Operation Righteous Sword — Plan Alpha: Direct frontal assault on Zille!\"";
            DialogueEntry entryA = CreateCustomEntry(10081, choiceA, "Zille_War_Alfa");
            AddResponse(ref responses, choiceA, entryA);

            string choiceB = "[MOD] \"Order: Operation Righteous Sword — Plan Beta: Flank through Viktrany and seize the deepwater port of Munat!\"";
            DialogueEntry entryB = CreateCustomEntry(10082, choiceB, "Zille_War_Beta");
            AddResponse(ref responses, choiceB, entryB);
            MelonLogger.Msg("[Great Zille] Injected Operation Righteous Sword war commands into Turn 08.");
        }

        public static void OnSelectedResponsePrefix(object sender, SelectedResponseEventArgs e)
        {
            try
            {
                if (e == null || e.DestinationEntry == null) return;

                string script = e.DestinationEntry.userScript;
                if (string.IsNullOrEmpty(script)) return;

                if (script == "Zille_Mil_T1")
                {
                    ZilleCampaignState.MilitarySentimentLevel = 1;
                    DialogueHelper.ShowAlert("[MOD] Hugo: 'Your Majesty, in the name of God! The treaty with Wehlen is international law. AN embargoes will crush us before our guns even unlimber!'");
                    DialogueHelper.ShowAlert("[MOD] Lucita: 'I admire your resolve, sire, but our army is still reconstituting after the civil crisis. Give me time to draft plans.'");
                    ZilleCampaignState.SyncToLua();
                }
                else if (script == "Zille_Mil_T2")
                {
                    ZilleCampaignState.MilitarySentimentLevel = 2;
                    DialogueHelper.ShowAlert("[MOD] Lucita: 'Smolak has crossed the line. I will quietly begin operational war studies for the southern front. But do not provoke Pales at the same time.'");
                    DialogueHelper.ShowAlert("[MOD] Grand Archon Sal: 'Zille is sanctified Rizian soil. The righteous sword of Saint Wruhec will purge the infidel occupiers!'");
                    ZilleCampaignState.SyncToLua();
                }
                else if (script == "Zille_Mil_T3")
                {
                    ZilleCampaignState.MilitarySentimentLevel = 3;
                    if (ZilleCampaignState.IsTwoFrontWarThreat())
                    {
                        DialogueHelper.ShowAlert("[MOD] Hugo (shouting): 'HAVE YOU LOST YOUR SENSES, ROMUS?! Our battalions are assembling against Pales! A two-front war is a death sentence for the House of Toras!'");
                        DialogueHelper.ShowAlert("[MOD] Lucita: 'Your Majesty, I plead with you! We do not have the manpower to besiege Pales while fighting Wehlen! Our supply lines will snap!'");
                    }
                    else
                    {
                        DialogueHelper.ShowAlert("[MOD] Lucita: 'Southern Command acknowledges. Artillery regiments are fortifying Brenas heights. We await your word of command.'");
                    }
                    ZilleCampaignState.SyncToLua();
                }
                else if (script == "Lespia_Pact_Accept")
                {
                    ZilleCampaignState.IsLespiaPactAccepted = true;
                    DialogueHelper.SetVariable("Diplomacy_Pales_PrepareForWar", false);
                    DialogueHelper.SetVariable("Diplomacy_Pales_DeclareWar", false);
                    DialogueHelper.ShowAlert("[MOD] Alvarez: 'A wise trade, Romus. Reinhard keeps his gas, and we ensure Smolak chokes on every barrel in Zille. Arcasian satellite feeds and heavy munitions are yours.'");
                    ZilleCampaignState.SyncToLua();
                }
                else if (script == "Lespia_Pact_Refuse")
                {
                    ZilleCampaignState.IsLespiaPactAccepted = false;
                    DialogueHelper.ShowAlert("[MOD] Alvarez: 'Pride is expensive, Your Majesty. Let us see how long your crown lasts under the weight of two simultaneous wars.'");
                    ZilleCampaignState.SyncToLua();
                }
                else if (script == "Derdia_Hybrid_Accept")
                {
                    ZilleCampaignState.IsDerdiaHybridSupportActive = true;
                    DialogueHelper.ShowAlert("[MOD] Grand Council Azmal: 'The fire of the righteous shall consume the oil fields of Zille. Smolak will find no rest behind his lines.'");
                    ZilleCampaignState.SyncToLua();
                }
                else if (script == "Zille_War_Alfa")
                {
                    DialogueHelper.ShowAlert("[MOD] WAR DECLARED: Operation Righteous Sword initiated! Crown forces assault Zille directly.");
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                }
                else if (script == "Zille_War_Beta")
                {
                    DialogueHelper.ShowAlert("[MOD] WAR DECLARED: Operation Righteous Sword initiated! Pincer maneuver through Viktrany & port Munat.");
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Great Zille] Response selection error: {ex.Message}");
            }
        }

        private static bool HasOption(Response[] responses, string scriptSnippet)
        {
            foreach (var r in responses)
            {
                if (r != null && r.destinationEntry != null && r.destinationEntry.userScript != null && r.destinationEntry.userScript.Contains(scriptSnippet))
                    return true;
            }
            return false;
        }

        private static DialogueEntry CreateCustomEntry(int id, string text, string userScript)
        {
            DialogueEntry entry = new DialogueEntry();
            entry.id = id;
            entry.DialogueText = text;
            entry.userScript = userScript;
            return entry;
        }

        private static void AddResponse(ref Response[] responses, string text, DialogueEntry entry)
        {
            FormattedText ft = new FormattedText(text);
            Response newResp = new Response(ft, entry, true);

            var list = new List<Response>(responses);
            list.Add(newResp);
            responses = list.ToArray();
        }
    }
}
