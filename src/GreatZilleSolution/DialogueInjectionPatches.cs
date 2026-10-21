using System;
using System.Collections.Generic;
using HarmonyLib;
using MelonLoader;
using PixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    [HarmonyPatch(typeof(AbstractDialogueUI), nameof(AbstractDialogueUI.ShowResponses), new Type[] { typeof(Subtitle), typeof(Response[]), typeof(float) })]
    public static class Patch_AbstractDialogueUI_ShowResponses
    {
        public static void Prefix(AbstractDialogueUI __instance, Subtitle subtitle, ref Response[] responses, float timeout)
        {
            try
            {
                if (responses == null) return;

                string convTitle = DialogueManager.lastConversationStarted;
                if (string.IsNullOrEmpty(convTitle)) return;

                // 1. TURN 01: Zille Visit / Speech
                if (convTitle.Contains("Turn01_ZilleVisit") || convTitle.Contains("ZilleVisit_HostileSpeech"))
                {
                    InjectTurn01Response(ref responses);
                }
                // 2. TURN 02: Friendship Day / Trade Demands
                else if (convTitle.Contains("Turn02_Zille") || convTitle.Contains("FriendshipDayPrep"))
                {
                    InjectTurn02Response(ref responses);
                }
                // 3. TURN 03: Bombing Incident in Zille
                else if (convTitle.Contains("Turn03_Zille") || convTitle.Contains("ZilleIncidentRespons"))
                {
                    InjectTurn03Response(ref responses);
                }
                // 4. TURN 04 / TURN 08: Lespia / Alvarez Backchannel Deal regarding Pales & Zille
                else if (convTitle.Contains("Turn04_Pales_NavalWithdrawal") || convTitle.Contains("Turn08_AlvarezVisit"))
                {
                    InjectLespiaProposal(ref responses);
                }
                // 5. TURN 05: Morella MITZ Reaction to Military Buildup
                else if (convTitle.Contains("Turn05_MorellaITZ") || convTitle.Contains("MorellaITZ_Shares"))
                {
                    InjectMorellaWarning(ref responses);
                }
                // 6. TURN 06 / TURN 08: Crown Council Debates (Rico vs Angelica Sazon)
                else if (convTitle.Contains("Turn06_CouncilMeeting") || convTitle.Contains("Turn08_Council"))
                {
                    InjectCouncilDebate(ref responses);
                }
                // 7. TURN 08: Final Negotiations / Breakout of War
                else if (convTitle.Contains("Turn08_Zille") || convTitle.Contains("ZilleNegotiat") || convTitle.Contains("ZilleNeg_Agree"))
                {
                    InjectTurn08WarResponse(ref responses);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Great Zille] Dialogue patch prefix exception: {ex.Message}");
            }
        }

        private static void InjectTurn01Response(ref Response[] responses)
        {
            if (HasOption(responses, "odbierzemy ją siłą")) return;

            string choiceText = "[Great Zille] \"Jeśli ten klaun nie odda naszej ziemi po dobroci, odbierzemy ją siłą i żelazem.\"";
            DialogueEntry entry = CreateCustomEntry(1001, choiceText, "Zille_Mil_T1");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected military dialogue choice into Turn 01.");
        }

        private static void InjectTurn02Response(ref Response[] responses)
        {
            if (HasOption(responses, "uderzenia prewencyjnego")) return;

            string choiceText = "[Great Zille] \"Żądania Smolaka są bezczelne. Sztab musi natychmiast przygotować plan uderzenia prewencyjnego.\"";
            DialogueEntry entry = CreateCustomEntry(1002, choiceText, "Zille_Mil_T2");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected staff study dialogue choice into Turn 02.");
        }

        private static void InjectTurn03Response(ref Response[] responses)
        {
            if (HasOption(responses, "stan podwyższonej gotowości bojowej")) return;

            string choiceText = "[Great Zille] \"Ten zamach to prowokacja Smolaka. Ogłaszam stan podwyższonej gotowości na granicy Brenas!\"";
            DialogueEntry entry = CreateCustomEntry(1003, choiceText, "Zille_Mil_T3");
            AddResponse(ref responses, choiceText, entry);
            MelonLogger.Msg("[Great Zille] Injected border mobilization dialogue choice into Turn 03.");
        }

        private static void InjectLespiaProposal(ref Response[] responses)
        {
            if (HasOption(responses, "Układ z Lespią") || ZilleCampaignState.IsLespiaPactAccepted) return;

            // Alvarez proposes backchannel deal
            string choiceAccept = "[Great Zille] \"[Układ z Lespią] 'Zgoda, Alvarez. Odpuszczamy Pales, ale w zamian Lespia i Arcasia dadzą nam wolną rękę i wsparcie przeciwko Wehlen.'\"";
            DialogueEntry entryAccept = CreateCustomEntry(10041, choiceAccept, "Lespia_Pact_Accept");
            AddResponse(ref responses, choiceAccept, entryAccept);

            string choiceRefuse = "[Great Zille] \"'Rizia nie będzie tańczyć pod dyktando Lespii. Poradzimy sobie zarówno z Pales, jak i ze Smolakiem.'\"";
            DialogueEntry entryRefuse = CreateCustomEntry(10042, choiceRefuse, "Lespia_Pact_Refuse");
            AddResponse(ref responses, choiceRefuse, entryRefuse);

            MelonLogger.Msg("[Great Zille] Injected Alvarez backchannel proposal into diplomatic talks.");
        }

        private static void InjectMorellaWarning(ref Response[] responses)
        {
            if (HasOption(responses, "spraw wewnętrznych Rizii")) return;

            string choiceText = "[Great Zille] \"Nasza obecność wojskowa w Brenas to kwestia bezpieczeństwa narodowego, nie sprawa Morelli.\"";
            DialogueEntry entry = CreateCustomEntry(10051, choiceText, "Morella_Mil_Warn");
            AddResponse(ref responses, choiceText, entry);
        }

        private static void InjectCouncilDebate(ref Response[] responses)
        {
            if (HasOption(responses, "kwestię obrony Brenas")) return;

            string choiceText = "[Great Zille] \"Rico, powstrzymaj bojówki Su Omina. Brenas musi pozostać pod ścisłą kontrolą armii regularnej.\"";
            DialogueEntry entry = CreateCustomEntry(10061, choiceText, "Council_Brenas_Debate");
            AddResponse(ref responses, choiceText, entry);
        }

        private static void InjectTurn08WarResponse(ref Response[] responses)
        {
            if (HasOption(responses, "Operację Righteous Sword")) return;

            string choiceA = "[Great Zille] \"Dość upokorzeń. Operacja Righteous Sword — Wariant Alfa: Frontalny szturm na Zille!\"";
            DialogueEntry entryA = CreateCustomEntry(10081, choiceA, "Zille_War_Alfa");
            AddResponse(ref responses, choiceA, entryA);

            string choiceB = "[Great Zille] \"Dość upokorzeń. Operacja Righteous Sword — Wariant Beta: Obejście przez Viktrany i port Munat!\"";
            DialogueEntry entryB = CreateCustomEntry(10082, choiceB, "Zille_War_Beta");
            AddResponse(ref responses, choiceB, entryB);

            MelonLogger.Msg("[Great Zille] Injected Operation Righteous Sword war options into Turn 08.");
        }

        private static bool HasOption(Response[] responses, string snippet)
        {
            foreach (var r in responses)
            {
                if (r != null && r.formattedText != null && r.formattedText.text != null && r.formattedText.text.Contains(snippet))
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

    [HarmonyPatch(typeof(ConversationController), nameof(ConversationController.OnSelectedResponse))]
    public static class Patch_ConversationController_OnSelectedResponse
    {
        public static void Prefix(ConversationController __instance, object sender, SelectedResponseEventArgs e)
        {
            try
            {
                if (e == null || e.DestinationEntry == null) return;

                string script = e.DestinationEntry.userScript;
                if (string.IsNullOrEmpty(script)) return;

                if (script == "Zille_Mil_T1")
                {
                    HandleTurn01Reaction();
                }
                else if (script == "Zille_Mil_T2")
                {
                    HandleTurn02Reaction();
                }
                else if (script == "Zille_Mil_T3")
                {
                    HandleTurn03Reaction();
                }
                else if (script == "Lespia_Pact_Accept")
                {
                    HandleLespiaPactAccept();
                }
                else if (script == "Lespia_Pact_Refuse")
                {
                    HandleLespiaPactRefuse();
                }
                else if (script == "Morella_Mil_Warn")
                {
                    HandleMorellaWarning();
                }
                else if (script == "Council_Brenas_Debate")
                {
                    HandleCouncilDebate();
                }
                else if (script == "Zille_War_Alfa")
                {
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                }
                else if (script == "Zille_War_Beta")
                {
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Great Zille] Response selection handling error: {ex.Message}");
            }
        }

        private static void HandleTurn01Reaction()
        {
            ZilleCampaignState.MilitarySentimentLevel = 1;
            DialogueManager.ShowAlert("Hugo: 'Wasza Wysokość, traktat z Wehlen to prawo międzynarodowe! Sankcje AN zniszczą nas w zarodku.'");
            DialogueManager.ShowAlert("Lucita: 'Armia po wojnie domowej nie jest gotowa na uderzenie w Wehlen. Potrzebujemy floty i czasu.'");
            ZilleCampaignState.SyncToLua();
        }

        private static void HandleTurn02Reaction()
        {
            ZilleCampaignState.MilitarySentimentLevel = 2;
            DialogueManager.ShowAlert("Lucita: 'Smolak przesadził. Sztab sporządzi tajne plany, lecz pamiętaj: otwarcie frontu z Pales pokrzyżuje wszystko.'");
            DialogueManager.ShowAlert("Sal: 'Zille należy do Rizii z boskiego nadania. Miecz Wruheca zetrze bezbożników.'");
            ZilleCampaignState.SyncToLua();
        }

        private static void HandleTurn03Reaction()
        {
            ZilleCampaignState.MilitarySentimentLevel = 3;

            if (ZilleCampaignState.IsTwoFrontWarThreat())
            {
                MelonLogger.Warning("[Great Zille] PANIC TRIGGERED: Active Two-Front War Threat detected!");
                DialogueManager.ShowAlert("Hugo: 'CZYŚ TY OSZALAŁ?! Wojska szykują się na Pales! Wojna na dwa fronty to wyrok śmierci dla Korony!'");
                DialogueManager.ShowAlert("Lucita: 'Wasza Królewska Mość, błagam o rozsądek! Nie mamy batalionów na oba teatry jednocześnie!'");
            }
            else
            {
                DialogueManager.ShowAlert("Lucita: 'Bataliony Południowe zajmują pozycje w Brenas. Czekamy na rozkaz uderzenia.'");
            }

            ZilleCampaignState.SyncToLua();
        }

        private static void HandleLespiaPactAccept()
        {
            ZilleCampaignState.IsLespiaPactAccepted = true;
            MelonLogger.Msg("[Great Zille] Lespia Backchannel Pact Accepted: Standing down on Pales in exchange for Zille backing.");

            // Call off Pales invasion
            DialogueLua.SetVariable("Diplomacy_Pales_PrepareForWar", false);
            DialogueLua.SetVariable("Diplomacy_Pales_DeclareWar", false);

            DialogueManager.ShowAlert("Alvarez: 'Mądry wybór, Romus. Kupujesz gaz w Pales, a my dopilnujemy, by Smolak pożałował każdego dnia okupacji Zille. Dostaniecie nasze satelity i sprzęt.'");
            ZilleCampaignState.SyncToLua();
        }

        private static void HandleLespiaPactRefuse()
        {
            ZilleCampaignState.IsLespiaPactAccepted = false;
            DialogueManager.ShowAlert("Alvarez: 'Cóż, twoja duma będzie cię drogo kosztować, Wasza Wysokość. Zobaczymy, jak twoja korona zniesie walkę na dwa fronty naraz.'");
            ZilleCampaignState.SyncToLua();
        }

        private static void HandleMorellaWarning()
        {
            DialogueManager.ShowAlert("Salva: 'Morella ostrzega: jeśli wasz militaryzm podpali południe, zapomnijcie o jakiejkolwiek współpracy przy MITZ.'");
        }

        private static void HandleCouncilDebate()
        {
            DialogueManager.ShowAlert("Rico: 'Wuju! Su Omina jest gotowa przelać krew za Zille!'");
            DialogueManager.ShowAlert("Angelica Sazon: 'Rico jest szaleńcem! Jeśli Wehzekowie przełamią Brenas, ród Sazonów obciąży winą Koronę!'");
        }
    }
}
