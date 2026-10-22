using System;
using System.Collections.Generic;
using HarmonyLib;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static class DialogueInjectionPatches
    {
        private static bool _vanillaConvsPatched = false;

        public static void RegisterManualPatches(HarmonyLib.Harmony harmony)
        {
            try
            {
                // 1. ConversationView.OnSelectedResponse (Detect War Choices in Native Royal War Council & Vanilla Dialogues)
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

                // 2. TokenInteractionPanel.Setup (Native Action Button Injection)
                var panelSetupMethod = AccessTools.Method(
                    typeof(TokenInteractionPanel),
                    nameof(TokenInteractionPanel.Setup),
                    new Type[] { typeof(Token) }
                );

                if (panelSetupMethod != null)
                {
                    var postfix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(TokenInteractionPanelSetupPostfix));
                    harmony.Patch(panelSetupMethod, postfix: new HarmonyMethod(postfix));
                    MelonLogger.Msg("[Great Zille] Successfully hooked TokenInteractionPanel.Setup!");
                }

                // 3. WarFlowManager.SetupWarFragment (Ensure custom Zille operation is prepared when Zille war is launched)
                var warSetupMethod = AccessTools.Method(
                    typeof(WarFlowManager),
                    nameof(WarFlowManager.SetupWarFragment),
                    new Type[] { typeof(WarFragmentData) }
                );

                if (warSetupMethod != null)
                {
                    var prefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarFlowManagerSetupWarFragmentPrefix));
                    harmony.Patch(warSetupMethod, prefix: new HarmonyMethod(prefix));
                    MelonLogger.Msg("[Great Zille] Successfully hooked WarFlowManager.SetupWarFragment!");
                }

                // 4. TokenNamePanel.Setup (Native Hover Tooltip for Tokens)
                var namePanelSetupMethod = AccessTools.Method(
                    typeof(TokenNamePanel),
                    nameof(TokenNamePanel.Setup),
                    new Type[] { typeof(Token) }
                );

                if (namePanelSetupMethod != null)
                {
                    var postfix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(TokenNamePanelSetupPostfix));
                    harmony.Patch(namePanelSetupMethod, postfix: new HarmonyMethod(postfix));
                    MelonLogger.Msg("[Great Zille] Successfully hooked TokenNamePanel.Setup!");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Great Zille] Manual patch registration error: {ex.Message}");
            }
        }

        public static void TokenNamePanelSetupPostfix(TokenNamePanel __instance, Token token)
        {
            try
            {
                if (__instance == null || token == null || token.gameObject == null) return;
                string tName = token.gameObject.name ?? "";
                string entityName = token.GetTokenDataEntityName() ?? "";

                if (tName.Contains("InvasionOfZille") || entityName.Contains("InvasionOfZille") || entityName.Contains("WarFragment_Zille") || tName.Contains("Zille War"))
                {
                    if (__instance.tokenNameText != null)
                    {
                        __instance.tokenNameText.text = "Invasion of Zille";
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[TOKEN NAME PANEL] Postfix error: {ex.Message}");
            }
        }

        public static void WarFlowManagerSetupWarFragmentPrefix(WarFragmentData warFragmentData)
        {
            try
            {
                if (warFragmentData != null && warFragmentData.NameInDatabase == "WarFragment_Zille_1_1")
                {
                    MelonLogger.Msg("[WAR ENGINE] Intercepted SetupWarFragment for WarFragment_Zille_1_1! Activating Zille Theatre...");
                    WarOperationZilleManager.CurrentTheatre = ActiveWarTheatre.Zille;
                    ZilleMapLayoutManager.EnsureTexturesLoaded();
                    WarOperationZilleManager.RegisterNativeZilleEntities();
                    WarOperationZilleManager.SetupCustomZilleOperation();
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR ENGINE] WarFlowManagerSetupWarFragmentPrefix error: {ex.Message}");
            }
        }

        // ================= INJECT WAR CHOICES INTO VANILLA CONVERSATIONS =================

        public static void InjectWarOptionsIntoVanillaConversations()
        {
            try
            {
                var db = DialogueManager.masterDatabase;
                if (db == null || db.conversations == null || db.conversations.Count == 0) return;

                int patchedCount = 0;
                for (int i = 0; i < db.conversations.Count; i++)
                {
                    var conv = db.conversations[i];
                    if (conv == null || string.IsNullOrEmpty(conv.Title)) continue;

                    // 1. Turn 2 Council Meeting on Foreign Relations (FPnT_DiplomacyBriefing)
                    if (conv.Title.IndexOf("FPnT_DiplomacyBriefing", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectWehlenUltimatumOption(conv, db)) patchedCount++;
                    }
                    // 2. Turn 2 Wehzek-Rizian Friendship Day in Zille (FPnT_ZilleVisit)
                    else if (conv.Title.IndexOf("FPnT_ZilleVisit", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        if (InjectSmolakFaceToFaceUltimatum(conv, db)) patchedCount++;
                    }
                }

                if (patchedCount > 0 && !_vanillaConvsPatched)
                {
                    _vanillaConvsPatched = true;
                    MelonLogger.Msg($"[WAR DIALOGUE] Successfully injected custom war pathways into {patchedCount} vanilla dialogue trees!");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR DIALOGUE] InjectWarOptionsIntoVanillaConversations: {ex.Message}");
            }
        }

        private static bool InjectWehlenUltimatumOption(Conversation conv, DialogueDatabase db)
        {
            if (conv == null || conv.dialogueEntries == null) return false;

            // Check if already injected
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e != null && e.Title == "Zille_War_Ultimatum_Choice") return true;
            }

            // Find parent entry discussing Wehlen, Smolak, or Zille
            DialogueEntry targetParent = null;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e == null || e.outgoingLinks == null || e.outgoingLinks.Count == 0) continue;

                string text = (e.DialogueText ?? "") + " " + (e.Title ?? "") + " " + (e.MenuText ?? "");
                if (text.IndexOf("Wehlen", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    text.IndexOf("Smolak", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    text.IndexOf("Zille", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    targetParent = e;
                    break;
                }
            }

            // Fallback: player choice hub
            if (targetParent == null)
            {
                for (int i = 0; i < conv.dialogueEntries.Count; i++)
                {
                    var e = conv.dialogueEntries[i];
                    if (e != null && e.outgoingLinks != null && e.outgoingLinks.Count >= 2)
                    {
                        targetParent = e;
                        break;
                    }
                }
            }

            if (targetParent == null) return false;

            int choiceId = 99201;
            int replyId = 99202;
            int romusId = conv.ActorID;
            int laurentoId = conv.ConversantID;

            // 1. Player choice entry
            var choice = new DialogueEntry();
            choice.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            choice.outgoingLinks = new Il2CppSystem.Collections.Generic.List<Link>();
            choice.id = choiceId;
            choice.conversationID = conv.id;
            choice.ActorID = romusId;
            choice.ConversantID = laurentoId;
            choice.Title = "Zille_War_Ultimatum_Choice";
            choice.MenuText = "Jezeli Smolak nie odda Zille w terminie, odbierzemy prowincje sila militarna.";
            choice.DialogueText = "Jezeli Smolak nie odda Zille w wyznaczonym terminie, odbierzemy prowincje sila militarna. Armia musi byc w pelnej gotowosci.";
            choice.userScript = "Variable[\"RiziaDLC.CountryRelation_Wehlen_AtWar\"] = true; Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_War_Ultimatum_Given\"] = true;";

            // 2. Laurento response entry
            var reply = new DialogueEntry();
            reply.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            reply.outgoingLinks = new Il2CppSystem.Collections.Generic.List<Link>();
            reply.id = replyId;
            reply.conversationID = conv.id;
            reply.ActorID = laurentoId;
            reply.ConversantID = romusId;
            reply.Title = "Zille_War_Ultimatum_Reply";
            reply.DialogueText = "Wasza Krolewska Mosc, otwarta inwazja na Zille wywola wscieklosc Smolaka i grozi interwencja CSP. Jednakze sztab generalny Azaro przygotuje plany natarcia na wypadek zerwania ukladu.";
            reply.MenuText = reply.DialogueText;

            choice.outgoingLinks.Add(new Link(conv.id, choiceId, conv.id, replyId));

            if (targetParent.outgoingLinks.Count > 0)
            {
                var nextLink = targetParent.outgoingLinks[0];
                reply.outgoingLinks.Add(new Link(conv.id, replyId, conv.id, nextLink.destinationDialogueID));
            }

            targetParent.outgoingLinks.Add(new Link(conv.id, targetParent.id, conv.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);

            MelonLogger.Msg($"[WAR DIALOGUE] Successfully injected Wehlen Ultimatum choice into '{conv.Title}' (parent id={targetParent.id})");
            return true;
        }

        private static bool InjectSmolakFaceToFaceUltimatum(Conversation conv, DialogueDatabase db)
        {
            if (conv == null || conv.dialogueEntries == null) return false;

            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e != null && e.Title == "Zille_Smolak_FaceToFace_Choice") return true;
            }

            DialogueEntry targetParent = null;
            for (int i = 0; i < conv.dialogueEntries.Count; i++)
            {
                var e = conv.dialogueEntries[i];
                if (e == null || e.outgoingLinks == null || e.outgoingLinks.Count == 0) continue;

                string text = (e.DialogueText ?? "") + " " + (e.Title ?? "");
                if (text.IndexOf("Smolak", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    text.IndexOf("Zille", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    text.IndexOf("Friendship", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    targetParent = e;
                    break;
                }
            }

            if (targetParent == null)
            {
                for (int i = 0; i < conv.dialogueEntries.Count; i++)
                {
                    var e = conv.dialogueEntries[i];
                    if (e != null && e.outgoingLinks != null && e.outgoingLinks.Count >= 2)
                    {
                        targetParent = e;
                        break;
                    }
                }
            }

            if (targetParent == null) return false;

            int choiceId = 99203;
            int replyId = 99204;
            int romusId = conv.ActorID;
            int smolakId = conv.ConversantID;

            var choice = new DialogueEntry();
            choice.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            choice.outgoingLinks = new Il2CppSystem.Collections.Generic.List<Link>();
            choice.id = choiceId;
            choice.conversationID = conv.id;
            choice.ActorID = romusId;
            choice.ConversantID = smolakId;
            choice.Title = "Zille_Smolak_FaceToFace_Choice";
            choice.MenuText = "To nasza ziemia, Wiktorze. Jezeli nie opuscicie Zille dobrowolnie, wkrocza tu moje czolgi.";
            choice.DialogueText = "To nasza ziemia, Wiktorze. Jezeli nie opuscicie Zille dobrowolnie, wkrocza tu moje czolgi.";
            choice.userScript = "Variable[\"RiziaDLC.CountryRelation_Wehlen_AtWar\"] = true; Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_Smolak_Threatened\"] = true;";

            var reply = new DialogueEntry();
            reply.fields = new Il2CppSystem.Collections.Generic.List<Field>();
            reply.outgoingLinks = new Il2CppSystem.Collections.Generic.List<Link>();
            reply.id = replyId;
            reply.conversationID = conv.id;
            reply.ActorID = smolakId;
            reply.ConversantID = romusId;
            reply.Title = "Zille_Smolak_FaceToFace_Reply";
            reply.DialogueText = "Grozby, Romusie? W moim wlasnym miescie? Wehlen nie boi sie Waszych paradnych mundurow. Sprobujcie tylko przekroczyc rzeke, a zobaczycie, jak plonie poludnie!";
            reply.MenuText = reply.DialogueText;

            choice.outgoingLinks.Add(new Link(conv.id, choiceId, conv.id, replyId));

            if (targetParent.outgoingLinks.Count > 0)
            {
                var nextLink = targetParent.outgoingLinks[0];
                reply.outgoingLinks.Add(new Link(conv.id, replyId, conv.id, nextLink.destinationDialogueID));
            }

            targetParent.outgoingLinks.Add(new Link(conv.id, targetParent.id, conv.id, choiceId));

            conv.dialogueEntries.Add(choice);
            conv.dialogueEntries.Add(reply);

            MelonLogger.Msg($"[WAR DIALOGUE] Successfully injected Smolak face-to-face ultimatum option into '{conv.Title}'");
            return true;
        }

        // ================= TOKEN INTERACTION PANEL POSTFIX =================

        public static void TokenInteractionPanelSetupPostfix(TokenInteractionPanel __instance, Token token)
        {
            try
            {
                if (__instance == null || token == null || token.gameObject == null) return;
                string tName = token.gameObject.name ?? "";
                string entityName = token.GetTokenDataEntityName() ?? "";

                MelonLogger.Msg($"[TOKEN PANEL] SetupPostfix: Token='{tName}', Entity='{entityName}'");

                // Case 1: Porte Drazon (Capital Royal War Council Briefing)
                if (tName.Contains("PorteDrazon") || tName.Contains("Porte Drazon") || entityName.Contains("PorteDrazon"))
                {
                    EnsureButtonExists(__instance, "A royal briefing before the invasion of Zille", "Council Chambers, Palas Rezna", () => {
                        MelonLogger.Msg("[TOKEN PANEL] Starting Royal Briefing conversation from Porte Drazon event button!");
                        WarOperationZilleManager.TriggerZilleWarBriefingConversation();
                    });
                }
                // Case 2: Zille (War Operation Event)
                else if (tName.Contains("InvasionOfZille") || entityName.Contains("InvasionOfZille") || entityName.Contains("WarFragment_Zille") || tName.Contains("Zille War"))
                {
                    if (__instance.titleText != null)
                    {
                        __instance.titleText.text = "Invasion of Zille";
                    }
                    if (__instance.subtitleText != null)
                    {
                        __instance.subtitleText.text = "Military Operation";
                    }

                    EnsureButtonExists(__instance, "Operation: Righteous Sword - Phase I", "Invasion of Zille", () => {
                        MelonLogger.Msg("[TOKEN PANEL] Starting Zille War Theatre from Zille war event button!");
                        WarOperationZilleManager.EnterZilleWarTheatre();
                    });
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[TOKEN PANEL] Postfix error: {ex.Message}");
            }
        }

        private static void EnsureButtonExists(TokenInteractionPanel panel, string title, string subtitle, Action onClick)
        {
            if (panel == null || panel.templateInteractionButton == null || panel.contentHolder == null) return;

            // Check if already injected
            if (panel.instantiatedInteractionButtons != null)
            {
                for (int i = 0; i < panel.instantiatedInteractionButtons.Count; i++)
                {
                    var existing = panel.instantiatedInteractionButtons[i];
                    if (existing != null && existing.titleText != null && existing.titleText.text == title)
                    {
                        if (existing.button != null)
                        {
                            existing.button.onClick = new UnityEngine.UI.Button.ButtonClickedEvent();
                            existing.button.onClick.AddListener((UnityEngine.Events.UnityAction)(() => {
                                onClick?.Invoke();
                            }));
                        }
                        MakeButtonVisible(existing, panel);
                        return;
                    }
                }
            }

            var btnObj = UnityEngine.Object.Instantiate(panel.templateInteractionButton.gameObject, panel.contentHolder.transform);
            btnObj.name = "Custom_Zille_Action_Button";
            btnObj.SetActive(true);

            var tib = btnObj.GetComponent<TemplateInteractionButton>();
            if (tib != null)
            {
                if (tib.titleText != null) tib.titleText.text = title;
                if (tib.subtitleText != null) tib.subtitleText.text = subtitle;
                if (tib.button != null)
                {
                    tib.button.onClick = new UnityEngine.UI.Button.ButtonClickedEvent();
                    tib.button.onClick.AddListener((UnityEngine.Events.UnityAction)(() => {
                        onClick?.Invoke();
                    }));
                }

                MakeButtonVisible(tib, panel);

                if (panel.instantiatedInteractionButtons != null)
                {
                    panel.instantiatedInteractionButtons.Add(tib);
                }

                MelonLogger.Msg($"[TOKEN PANEL] Successfully injected visible native action button: '{title}'");
            }
        }

        private static void MakeButtonVisible(TemplateInteractionButton tib, TokenInteractionPanel panel)
        {
            if (tib != null)
            {
                tib.gameObject.SetActive(true);
                if (tib.canvasGroup != null)
                {
                    tib.canvasGroup.alpha = 1f;
                    tib.canvasGroup.interactable = true;
                    tib.canvasGroup.blocksRaycasts = true;
                }
                if (tib.button != null)
                {
                    tib.button.interactable = true;
                }
                if (tib.background != null)
                {
                    tib.background.gameObject.SetActive(true);
                }
            }

            if (panel != null)
            {
                panel.gameObject.SetActive(true);
                if (panel.canvasGroup != null)
                {
                    panel.canvasGroup.alpha = 1f;
                    panel.canvasGroup.interactable = true;
                    panel.canvasGroup.blocksRaycasts = true;
                }
                panel.Show();

                if (panel.panelRect != null)
                {
                    panel.panelRect.sizeDelta = new Vector2(panel.panelRect.sizeDelta.x, Mathf.Max(panel.panelRect.sizeDelta.y, 220f) + 70f);
                }
                UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(panel.contentHolder);
            }
        }

        // ================= RESPONSE SELECTION HOOK =================

        public static void OnSelectedResponsePrefix(Il2CppSystem.Object sender, SelectedResponseEventArgs e)
        {
            try
            {
                if (e == null || e.DestinationEntry == null) return;

                string script = e.DestinationEntry.userScript ?? "";
                string title = e.DestinationEntry.Title ?? "";
                string menuText = e.DestinationEntry.MenuText ?? "";

                // Check for war initiation via native Royal War Council Briefing or vanilla choice
                if (script.Contains("Zille_War_Alfa") || title.Contains("Choice_Alpha") || menuText.Contains("Plan Alpha"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Plan Alpha chosen by player in native dialogue! Scheduling War Theatre transition...");
                    DialogueHelper.ShowAlert("[Zille] Rozkaz natarcia frontalnego wydany. Sztab otwiera teatr wojenny.");
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                    WarOperationZilleManager.ScheduleWarTheatreTransition();
                }
                else if (script.Contains("Zille_War_Beta") || title.Contains("Choice_Beta") || menuText.Contains("Plan Beta"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Plan Beta chosen by player in native dialogue! Scheduling War Theatre transition...");
                    DialogueHelper.ShowAlert("[Zille] Rozkaz manewru oskrzydlajacego wydany. Sztab otwiera teatr wojenny.");
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                    WarOperationZilleManager.ScheduleWarTheatreTransition();
                }
                else if (script.Contains("Zille_War_Postpone") || title.Contains("Choice_Postpone") || menuText.Contains("Wstrzymajmy"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Postponing Zille invasion as requested by player.");
                    DialogueHelper.ShowAlert("[Zille] Operacja wstrzymana w oczekiwaniu na dalsze przygotowania.");
                }
                else if (title.Contains("Zille_War_Ultimatum") || title.Contains("Zille_Smolak_FaceToFace"))
                {
                    MelonLogger.Msg("[DIPLOMACY] Player threatened Wehlen with military invasion! Activating Zille war pathway.");
                    DialogueHelper.ShowAlert("[Zille] Postawiono ultimatum Wehlenowi. Sztab krolewski rozpoczyna mobilizacje.");
                    ZilleCampaignState.MilitarySentimentLevel = 2;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Great Zille] Response selection error: {ex.Message}");
            }
        }
    }
}
