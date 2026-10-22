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
        public static void RegisterManualPatches(HarmonyLib.Harmony harmony)
        {
            try
            {
                // 1. ConversationView.OnSelectedResponse (Detect War Choices in Native Royal War Council)
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
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Great Zille] Manual patch registration error: {ex.Message}");
            }
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
                    EnsureButtonExists(__instance, "Narada Wojenna: Zille", "Sztab Generalny i Rada Krolewska", () => {
                        WarOperationZilleManager.TriggerZilleWarBriefingConversation();
                    });
                }
                // Case 2: Zille (War Operation Event)
                else if (tName.Contains("Zille") || entityName.Contains("Zille"))
                {
                    EnsureButtonExists(__instance, "Operacja: Prawy Miecz - Faza I", "Inwazja na Zille", () => {
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

                // Check for war initiation via native Royal War Council Briefing
                if (script == "Zille_War_Alfa" || title.Contains("Choice_Alpha") || menuText.Contains("Plan Alpha"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Plan Alpha chosen by player in native dialogue! Scheduling War Theatre transition...");
                    DialogueHelper.ShowAlert("[Zille] Rozkaz natarcia frontalnego wydany. Sztab otwiera teatr wojenny.");
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                    WarOperationZilleManager.ScheduleWarTheatreTransition();
                }
                else if (script == "Zille_War_Beta" || title.Contains("Choice_Beta") || menuText.Contains("Plan Beta"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Plan Beta chosen by player in native dialogue! Scheduling War Theatre transition...");
                    DialogueHelper.ShowAlert("[Zille] Rozkaz manewru oskrzydlajacego wydany. Sztab otwiera teatr wojenny.");
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                    WarOperationZilleManager.ScheduleWarTheatreTransition();
                }
                else if (script == "Zille_War_Postpone" || title.Contains("Choice_Postpone") || menuText.Contains("Wstrzymajmy"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Postponing Zille invasion as requested by player.");
                    DialogueHelper.ShowAlert("[Zille] Operacja wstrzymana w oczekiwaniu na dalsze przygotowania.");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Great Zille] Response selection error: {ex.Message}");
            }
        }
    }
}
