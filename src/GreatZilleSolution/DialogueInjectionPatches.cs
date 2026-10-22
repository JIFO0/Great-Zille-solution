using System;
using System.Collections.Generic;
using HarmonyLib;
using MelonLoader;
using Il2CppPixelCrushers.DialogueSystem;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace GreatZilleSolution
{
    public static class DialogueInjectionPatches
    {
        public static void RegisterManualPatches(HarmonyLib.Harmony harmony)
        {
            try
            {
                var startResponsesMethod = AccessTools.Method(
                    typeof(ConversationView), 
                    nameof(ConversationView.StartResponses), 
                    new Type[] { typeof(Subtitle), typeof(Il2CppReferenceArray<Response>) }
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

                var onSelectedMethod = AccessTools.Method(
                    typeof(ConversationView), 
                    nameof(ConversationView.OnSelectedResponse), 
                    new Type[] { typeof(Il2CppSystem.Object), typeof(SelectedResponseEventArgs) }
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

        public static void StartResponsesPrefix(ConversationView __instance, Subtitle subtitle, ref Il2CppReferenceArray<Response> responses)
        {
            try
            {
                if (responses == null) return;

                string convTitle = DialogueHelper.GetCurrentConversationTitle();
                if (string.IsNullOrEmpty(convTitle)) return;

                // 1. Turn 1: Initial King's Council Briefing & Military Meeting
                // Exact game titles: "Rizia/Turn 1/SnO_SecurityMilitaryMeeting" or "Rizia/Turn 1/EnT_CouncilBriefing"
                if (convTitle.Contains("Turn 1/SnO_SecurityMilitaryMeeting") || convTitle.Contains("Turn 1/EnT_CouncilBriefing"))
                {
                    InjectTurn01Response(ref responses);
                }
                // 2. Turn 2: King's Council Diplomacy Briefing (foreign policy / international situation)
                // Exact game title: "Rizia/Turn 2/FPnT_DiplomacyBriefing"
                else if (convTitle.Contains("Turn 2/FPnT_DiplomacyBriefing"))
                {
                    InjectTurn02CouncilResponse(ref responses);
                }
                // 3. Turn 2: Friendship Day Celebration in Zille
                // Exact game title: "Rizia/Turn 2/FPnT_ZilleVisit"
                else if (convTitle.Contains("Turn 2/FPnT_ZilleVisit"))
                {
                    InjectTurn02VisitResponse(ref responses);
                }
                // 4. Turn 3: Security Council Debriefing after the Zille Bombing
                // Exact game title: "Rizia/Turn 3/SnO_ZilleSecurityDebrief"
                else if (convTitle.Contains("Turn 3/SnO_ZilleSecurityDebrief"))
                {
                    InjectTurn03Responses(ref responses);
                }
                // 5. Turn 4 / Turn 8: Alvarez Backchannel Pact
                // Exact game titles: "Rizia/Turn 4/FPnT_AlvarezCall" or "Rizia/Turn 8/FPnT_AlvarezVisit"
                else if (convTitle.Contains("Turn 4/FPnT_AlvarezCall") || convTitle.Contains("Turn 8/FPnT_AlvarezVisit"))
                {
                    InjectLespiaProposal(ref responses);
                }
                // 6. Turn 5: Direct Wehlen Negotiations
                // Exact game title: "Rizia/Turn 5/FPnT_WehlenNegotiations"
                else if (convTitle.Contains("Turn 5/FPnT_WehlenNegotiations"))
                {
                    InjectTurn05Response(ref responses);
                }
                // 7. Turn 7: Derdia Negotiations & Zille Treaty Discussion
                // Exact game titles: "Rizia/Turn 7/FPnT_DerdiaNegotiations" or "Rizia/Turn 7/Zille Treaty Discussion"
                else if (convTitle.Contains("Turn 7/FPnT_DerdiaNegotiations") || convTitle.Contains("Zille Treaty Discussion"))
                {
                    InjectDerdiaOffer(ref responses);
                }
                // 8. Turn 8: Final Breakdown / Outbreak of War
                // Exact game titles: "Rizia/Turn 8/FPnT_ZilleNegotiations" or "Rizia/Turn 8/SnO_SecurityBriefAndZille" or "Rizia/Turn 8/Zille Territory Issue"
                else if (convTitle.Contains("Turn 8/FPnT_ZilleNegotiations") || convTitle.Contains("SnO_SecurityBriefAndZille") || convTitle.Contains("Zille Territory Issue"))
                {
                    InjectTurn08WarResponse(ref responses);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Great Zille] StartResponsesPrefix error: {ex.Message}");
            }
        }

        private static void InjectTurn01Response(ref Il2CppReferenceArray<Response> responses)
        {
            if (HasOption(responses, "Zille_Mil_T1")) return;

            string choiceText = "[MOD] \"Let me be unequivocal with my council: We will recover Zille, even if it requires force of arms.\"";
            DialogueEntry entry = CreateCustomEntry(1001, choiceText, "Zille_Mil_T1");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected Turn 01 King's Council military resolve dialogue option.");
        }

        private static void InjectTurn02CouncilResponse(ref Il2CppReferenceArray<Response> responses)
        {
            if (HasOption(responses, "Zille_Mil_T2_Council")) return;

            string choiceText = "[MOD] \"Regarding Wehlen: I want the General Staff to draft a preemptive operational invasion plan for Zille before I meet Smolak.\"";
            DialogueEntry entry = CreateCustomEntry(10021, choiceText, "Zille_Mil_T2_Council");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected Turn 02 Council staff study dialogue option.");
        }

        private static void InjectTurn02VisitResponse(ref Il2CppReferenceArray<Response> responses)
        {
            if (HasOption(responses, "Zille_Mil_T2_Visit")) return;

            string choiceText = "[MOD] \"Smolak's insulting jokes and outrageous demands will not stand. Rizia's patience has limits, Wiktor.\"";
            DialogueEntry entry = CreateCustomEntry(10022, choiceText, "Zille_Mil_T2_Visit");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected Turn 02 Friendship Day defiant dialogue option.");
        }

        private static void InjectTurn03Responses(ref Il2CppReferenceArray<Response> responses)
        {
            // Option A: Prepared Border Mobilization
            if (!HasOption(responses, "Zille_Mil_T3"))
            {
                string choiceText = "[MOD] \"This bombing is Smolak's blatant false-flag. I declare heightened combat readiness along the Brenas border!\"";
                DialogueEntry entry = CreateCustomEntry(10031, choiceText, "Zille_Mil_T3");
                AddResponse(ref responses, choiceText, entry);
                MelonLogger.Msg("[Great Zille] Injected Turn 03 mobilization dialogue option.");
            }

            // Option B: Immediate Unprepared War ("Głupia opcja" / Instant Catastrophic Defeat)
            if (!HasOption(responses, "Zille_War_Reckless_T3"))
            {
                string suicideText = "[MOD] [SUICIDAL] \"Enough talk! Order the Third and Fourth Corps across the border immediately! We take Zille by force TODAY!\"";
                DialogueEntry suicideEntry = CreateCustomEntry(10032, suicideText, "Zille_War_Reckless_T3");
                AddResponse(ref responses, suicideText, suicideEntry);
                MelonLogger.Msg("[Great Zille] Injected Turn 03 immediate reckless war option.");
            }
        }

        private static void InjectTurn05Response(ref Il2CppReferenceArray<Response> responses)
        {
            if (HasOption(responses, "Zille_Mil_T5")) return;

            string choiceText = "[MOD] \"We know about your military buildup near Zille, Smolak. Back down or face royal artillery.\"";
            DialogueEntry entry = CreateCustomEntry(10051, choiceText, "Zille_Mil_T5");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected Turn 05 Wehlen negotiations military pressure option.");
        }

        private static void InjectLespiaProposal(ref Il2CppReferenceArray<Response> responses)
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

        private static void InjectDerdiaOffer(ref Il2CppReferenceArray<Response> responses)
        {
            if (HasOption(responses, "Derdia_Hybrid_Accept") || ZilleCampaignState.IsDerdiaHybridSupportActive) return;

            string choiceAccept = "[MOD] [Derdia Intervention] \"'Accept Azmal's offer: Unleash holy irregulars behind Wehzek lines to sabotage their refineries.'\"";
            DialogueEntry entryAccept = CreateCustomEntry(10071, choiceAccept, "Derdia_Hybrid_Accept");
            AddResponse(ref responses, choiceAccept, entryAccept);
            MelonLogger.Msg("[Great Zille] Injected Derdia hybrid warfare proposal.");
        }

        private static void InjectTurn08WarResponse(ref Il2CppReferenceArray<Response> responses)
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

        public static void OnSelectedResponsePrefix(Il2CppSystem.Object sender, SelectedResponseEventArgs e)
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
                else if (script == "Zille_Mil_T2_Council")
                {
                    ZilleCampaignState.MilitarySentimentLevel = 2;
                    DialogueHelper.ShowAlert("[MOD] Lucita: 'Understood, Your Majesty. House Azaro staff officers will quietly begin reconnaissance of the southern approaches.'");
                    DialogueHelper.ShowAlert("[MOD] Hugo: 'Recklessness, Romus! Whispers of troop concentrations will poison the entire Friendship Day delegation!'");
                    ZilleCampaignState.SyncToLua();
                }
                else if (script == "Zille_Mil_T2_Visit")
                {
                    DialogueHelper.ShowAlert("[MOD] Smolak: 'Hahaha! The young King rattles his gilded saber! But remember, Romus, sabers don't pump oil.'");
                    DialogueHelper.ShowAlert("[MOD] Hugo: 'Smile and wave, sire, for God's sake! The international press is watching every move.'");
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
                else if (script == "Zille_War_Reckless_T3")
                {
                    DialogueHelper.ShowAlert("[MOD] Hugo (screaming): 'MADNESS! OUR UNPREPARED TROOPS MARCHED STRAIGHT INTO A WEHZEK TRAP!'");
                    DialogueHelper.ShowAlert("[MOD] Lucita: 'Our lines have collapsed! Smolak's armored columns have broken through into Brenas!'");
                    WarOperationZilleManager.TriggerCatastrophicDefeat(motherDied: true, brenasLost: true);
                }
                else if (script == "Zille_Mil_T5")
                {
                    DialogueHelper.ShowAlert("[MOD] Smolak: 'Threats, Romus? In my own residence? Let us see how long your little kingdom survives without Wehlen's goodwill.'");
                    DialogueHelper.SetVariable("Diplomacy_Wehlen_Hostile", true);
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

        private static bool HasOption(Il2CppReferenceArray<Response> responses, string scriptSnippet)
        {
            if (responses == null) return false;
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

        private static void AddResponse(ref Il2CppReferenceArray<Response> responses, string text, DialogueEntry entry)
        {
            FormattedText ft = FormattedText.Parse(text, null);
            Response newResp = new Response(ft, entry, true);

            var list = new List<Response>();
            if (responses != null)
            {
                foreach (var r in responses)
                {
                    if (r != null) list.Add(r);
                }
            }
            list.Add(newResp);
            responses = new Il2CppReferenceArray<Response>(list.ToArray());
        }
    }
}
