import re

def update_war_operation_manager():
    with open('src/GreatZilleSolution/WarOperationZilleManager.cs', 'r', encoding='utf-8') as f:
        content = f.read()

    new_methods = '''        public static bool TriggerConversation(string nameInDb, string dialogueTitle, Action onFinish = null)
        {
            try
            {
                ZilleDialogueSystem.EnsureAllConversationsRegistered();
                var convPanel = Panels.Instance?.ConversationPanel ?? UnityEngine.Object.FindObjectOfType<ConversationPanel>();
                if (convPanel == null)
                {
                    var allPanels = Resources.FindObjectsOfTypeAll<ConversationPanel>();
                    if (allPanels != null && allPanels.Length > 0) convPanel = allPanels[0];
                }

                if (convPanel != null)
                {
                    Panels.Instance?.TokenInteractionPanel?.Hide();
                    Panels.Instance?.HideAllRightPanels();
                    Panels.Instance?.HideAllCenterPanels();
                    Managers.Instance?.GameFlowManager?.OnStoryFragmentStart();

                    convPanel.isWarConversation = false;
                    convPanel.isMinimizable = false;
                    convPanel.gameObject.SetActive(true);
                    if (convPanel.inputBlockerPanel != null)
                    {
                        convPanel.inputBlockerPanel.gameObject.SetActive(true);
                    }

                    ConversationData cd = null;
                    var convList = EntityDataManager.AllConversationsData ?? EntityDataManager.ConversationsData;
                    if (convList != null)
                    {
                        for (int i = 0; i < convList.Count; i++)
                        {
                            var c = convList[i];
                            if (c != null && (c.NameInDatabase == nameInDb || c.ConversationProperties?.Dialogue == dialogueTitle))
                            {
                                cd = c;
                                break;
                            }
                        }
                    }

                    System.Action finishAction = () => {
                        try
                        {
                            var gfm = Managers.Instance?.GameFlowManager ?? UnityEngine.Object.FindObjectOfType<GameFlowManager>();
                            if (gfm != null && cd != null)
                            {
                                gfm.FinishStoryFragment(cd, null);
                            }
                            Panels.Instance?.ShowHUD();
                            onFinish?.Invoke();
                        }
                        catch (Exception ex)
                        {
                            MelonLogger.Warning($"[WAR ENGINE] OnFinish conversation error: {ex.Message}");
                        }
                    };

                    if (cd != null)
                    {
                        convPanel.Setup(cd, finishAction, false);
                    }
                    else
                    {
                        convPanel.ForceStartConversation(dialogueTitle);
                    }

                    if (!DialogueManager.isConversationActive)
                    {
                        DialogueManager.StartConversation(dialogueTitle);
                    }

                    convPanel.Show();
                    MelonLogger.Msg($"[WAR ENGINE] Triggered conversation \'{dialogueTitle}\' ({nameInDb})!");
                    return true;
                }
                else
                {
                    DialogueManager.StartConversation(dialogueTitle);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[WAR ENGINE] TriggerConversation failed for {dialogueTitle}: {ex.Message}");
                return false;
            }
        }

        public static void TriggerMaveNortusHQ()
        {
            MelonLogger.Msg("[WAR ENGINE] Returning to civilian map to open Mave Nortus Field HQ...");
            ReturnToCivilianMap();
            TriggerConversation("Turn_Zille_MaveNortusHQ", "Zille/MaveNortusHQ", () => {
                MelonLogger.Msg("[WAR ENGINE] Mave Nortus Field HQ concluded! Phase II unlocked.");
                ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2;
                ZilleCampaignState.CurrentPhaseNumber = 2;
                ScheduleWarTheatreTransition();
            });
        }

        public static void TriggerSmolakParley()
        {
            MelonLogger.Msg("[WAR ENGINE] Returning to civilian map for Wartime Peace Parley with Wiktor Smolak...");
            ReturnToCivilianMap();
            TriggerConversation("Turn_Zille_WarSmolakFinalParley", "Zille/SmolakFinalParley", () => {
                MelonLogger.Msg("[WAR ENGINE] Smolak Parley finished. Proceeding to Treaty of Zille ceremony...");
                TriggerConversation("Turn_Zille_WarPeaceTreaty", "Zille/PeaceTreaty", () => {
                    MelonLogger.Msg("[WAR ENGINE] Treaty of Zille concluded!");
                });
            });
        }
'''

    if 'public static void TriggerMaveNortusHQ()' not in content:
        content = content.replace('// ================= SCHEDULED THEATRE TRANSITION =================',
                                  new_methods + '\n        // ================= SCHEDULED THEATRE TRANSITION =================')

    # Also update WarTurnPanel dynamic title
    old_title_code = '''                var turnPanel = Panels.Instance?.WarTurnPanel;
                if (turnPanel != null && turnPanel.titleText != null)
                {
                    var txt = turnPanel.titleText.text;
                    if (!string.IsNullOrEmpty(txt) && txt.Contains("Phase 0"))
                    {
                        turnPanel.titleText.text = txt.Replace("Phase 0", "Phase I");
                    }
                }'''

    new_title_code = '''                var turnPanel = Panels.Instance?.WarTurnPanel;
                if (turnPanel != null && turnPanel.titleText != null)
                {
                    string opName = "Operation: Golden Sword";
                    if (ZilleCampaignState.RomulusPlan == ZilleRomulusPlan.GoldenArk) opName = "Operation: Golden Ark";
                    else if (ZilleCampaignState.RomulusPlan == ZilleRomulusPlan.TotalRepayment) opName = "Operation: Total Repayment";
                    else if (ZilleCampaignState.PlanType == ZillePlanType.Staff) opName = "Operation: " + ZilleCampaignState.StaffPlan;

                    string phaseStr = ZilleCampaignState.CurrentPhaseNumber == 2 ? "Phase II" : "Phase I";
                    turnPanel.titleText.text = $"{opName} - {phaseStr}";
                }'''

    content = content.replace(old_title_code, new_title_code)

    with open('src/GreatZilleSolution/WarOperationZilleManager.cs', 'w', encoding='utf-8') as f:
        f.write(content)
    print("WarOperationZilleManager.cs updated.")

def update_zille_war_table():
    with open('src/GreatZilleSolution/ZilleWarTable.cs', 'r', encoding='utf-8') as f:
        content = f.read()

    # Find EvaluateTableOutcome block
    pattern_eval = r'public static ZilleWarOutcome EvaluateTableOutcome\(out string summary\).*?public static void CheckCityVictory\(bool force = false\)'
    
    # We want to replace from EvaluateTableOutcome to end of CheckCityVictory
    # Let's inspect the exact lines
    lines = content.splitlines(keepends=True)
    start_eval = -1
    end_check = -1
    for i, line in enumerate(lines):
        if 'public static ZilleWarOutcome EvaluateTableOutcome(out string summary)' in line:
            start_eval = i
        if 'public static void CheckCityVictory(bool force = false)' in line:
            # find end of CheckCityVictory method
            # CheckCityVictory ends right before 'private static bool _unitChromeLogged;'
            for j in range(i, len(lines)):
                if 'private static bool _unitChromeLogged;' in lines[j]:
                    end_check = j
                    break
            break

    if start_eval != -1 and end_check != -1:
        new_eval_and_check = '''        /// <summary>
        /// Evaluates current city control across Brenas, Zille, and Wehlen to compute the 5 war outcomes.
        /// </summary>
        public static ZilleWarOutcome EvaluateTableOutcome(out string summary)
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null)
            {
                summary = "Config missing";
                return ZilleWarOutcome.BloodyStalemate;
            }

            int brenasTotal = 0, brenasHeld = 0;
            int zilleTotal = 0, zilleHeld = 0;
            int wehlenDeepHeld = 0;
            bool zilleCityHeld = false;

            for (int i = 0; i < cfg.Tiles.Count; i++)
            {
                var td = cfg.Tiles[i];
                if (td == null || !td.IsCity) continue;

                var wt = FindLiveTile(td.TileNumber);
                WarToken tok = null;
                try { tok = wt != null ? wt.GetCurrentToken() : null; } catch { }

                bool heldByPlayer = (td.Allegiance == "Rizia" && (tok == null || tok.GetTokenAllegiance() != WarToken.WarAllegiance.Enemy))
                                    || (tok != null && tok.GetTokenAllegiance() == WarToken.WarAllegiance.Player);

                string name = td.Name ?? "";

                // Brenas cities (Home territory)
                if (name == "Mave Nortus" || name == "Dapalle" || name == "Marbelas")
                {
                    brenasTotal++;
                    if (heldByPlayer) brenasHeld++;
                }
                // Zille peninsula cities
                else if (name == "Zille City" || name == "Wiktrany" || name == "Munat" || name == "Nanta")
                {
                    zilleTotal++;
                    if (heldByPlayer)
                    {
                        zilleHeld++;
                        if (name == "Zille City") zilleCityHeld = true;
                    }
                }
                // Deep Wehlen cities
                else if (name == "Grodzizg" || name == "Kratsna" || name == "Rotsla")
                {
                    if (heldByPlayer) wehlenDeepHeld++;
                }
            }

            int brenasLost = Math.Max(0, brenasTotal - brenasHeld);

            // Record captured state in campaign
            ZilleCampaignState.ZilleCityCaptured = zilleCityHeld;
            if (ZilleCampaignState.CurrentPhaseNumber == 1)
                ZilleCampaignState.Phase1CitiesCaptured = zilleHeld;
            else
                ZilleCampaignState.Phase2CitiesCaptured = zilleHeld;

            try
            {
                DialogueHelper.SetVariable("Zille_Cities_Held", zilleHeld);
                DialogueHelper.SetVariable("Zille_Brenas_Lost", brenasLost);
                DialogueHelper.SetVariable("Zille_City_Held", zilleCityHeld);
            }
            catch { }

            // 1. Total Fiasco: Enemy captured >= 2 Brenas cities
            if (brenasLost >= 2)
            {
                summary = $"Total Fiasco: Brenas collapsed ({brenasLost} cities lost to Wehlen).";
                return ZilleWarOutcome.TotalFiasco;
            }

            // 2. Overwhelming Triumph: Zille City held, at least 3 Zille cities held, Brenas secure, plus deep Wehlen target captured!
            if (brenasLost == 0 && zilleCityHeld && zilleHeld >= 3 && wehlenDeepHeld >= 1)
            {
                summary = $"Overwhelming Triumph: Zille liberated + deep Wehlen target captured ({zilleHeld}/4 Zille cities, {wehlenDeepHeld} deep targets)!";
                return ZilleWarOutcome.OverwhelmingTriumph;
            }

            // 3. Decisive Victory: Zille City held, at least 3 Zille cities held (majority, at most 1 minor city left), Brenas secure
            if (brenasLost == 0 && zilleCityHeld && zilleHeld >= 3)
            {
                summary = $"Decisive Victory: Zille reclaimed ({zilleHeld}/4 cities held including Zille City)!";
                return ZilleWarOutcome.DecisiveVictory;
            }

            // 4. Tactical Defeat: Brenas held, but zero gains in Wehlen/Zille, or 1 Brenas city lost without gains
            if ((brenasLost == 0 && zilleHeld == 0 && wehlenDeepHeld == 0) || (brenasLost == 1 && zilleHeld == 0 && wehlenDeepHeld == 0))
            {
                summary = $"Tactical Defeat: Zero territorial gains achieved in Zille (Status Quo failure).";
                return ZilleWarOutcome.TacticalDefeat;
            }

            // 5. Bloody Stalemate: Partial gains (1-2 cities, or Zille City not held)
            summary = $"Bloody Stalemate: Partial capture ({zilleHeld}/4 Zille cities, Zille City held: {zilleCityHeld}, Brenas lost: {brenasLost}).";
            return ZilleWarOutcome.BloodyStalemate;
        }

        private static float _nextVictoryCheckTime;
        public static void CheckCityVictory(bool force = false)
        {
            if ((_victoryShown && !force) || !ScenarioStarted || DeploymentPanelOpen()) return;
            if (!force && Time.unscaledTime < _nextVictoryCheckTime) return;
            _nextVictoryCheckTime = Time.unscaledTime + 2.0f;
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return;

            var outcome = EvaluateTableOutcome(out string summary);

            // Total Fiasco: Brenas collapsed
            if (outcome == ZilleWarOutcome.TotalFiasco)
            {
                _victoryShown = true;
                MelonLogger.Error($"[ZTABLE] Hex Campaign Collapse detected! Outcome: {outcome} ({summary})");
                try { WarOperationZilleManager.TriggerOutcome(outcome, summary); } catch { }
                try { DialogueHelper.ShowAlert($"Catastrophic Defeat: {summary}"); } catch { }
                try { WarOperationZilleManager.TriggerSmolakParley(); } catch { }
                return;
            }

            // Phase 1 handling
            if (ZilleCampaignState.CurrentPhaseNumber == 1)
            {
                if (outcome == ZilleWarOutcome.DecisiveVictory || outcome == ZilleWarOutcome.OverwhelmingTriumph)
                {
                    _victoryShown = true;
                    MelonLogger.Msg($"[ZTABLE] Early Decisive Victory achieved in Phase I! Outcome: {outcome} ({summary})");
                    try { WarOperationZilleManager.TriggerOutcome(outcome, summary); } catch { }
                    try { DialogueHelper.ShowAlert($"Decisive Victory: {summary}"); } catch { }
                }
                else if (force)
                {
                    // Phase I ended with partial gains -> Advance to Phase II via Mave Nortus Field HQ!
                    MelonLogger.Msg($"[ZTABLE] Phase I complete ({summary}). Transitioning to Mave Nortus Frontline HQ...");
                    try { DialogueHelper.ShowAlert("Phase I Complete: Convening at Mave Nortus HQ..."); } catch { }
                    try { WarOperationZilleManager.TriggerMaveNortusHQ(); } catch { }
                }
                return;
            }

            // Phase 2 handling
            if (outcome == ZilleWarOutcome.DecisiveVictory || outcome == ZilleWarOutcome.OverwhelmingTriumph)
            {
                _victoryShown = true;
                MelonLogger.Msg($"[ZTABLE] Hex Campaign Victory achieved! Outcome: {outcome} ({summary})");
                try { WarOperationZilleManager.TriggerOutcome(outcome, summary); } catch { }
                try { DialogueHelper.ShowAlert($"Zille Operation Victory: {summary}"); } catch { }
            }
            else if (force)
            {
                _victoryShown = true;
                MelonLogger.Msg($"[ZTABLE] Phase II concluded without full victory. Outcome: {outcome} ({summary}). Initiating peace parley...");
                try { WarOperationZilleManager.TriggerOutcome(outcome, summary); } catch { }
                try { DialogueHelper.ShowAlert($"Armistice Talks: {summary}"); } catch { }
                try { WarOperationZilleManager.TriggerSmolakParley(); } catch { }
            }
        }
'''
        lines[start_eval:end_check] = [new_eval_and_check + '\n']
        with open('src/GreatZilleSolution/ZilleWarTable.cs', 'w', encoding='utf-8') as f:
            f.writelines(lines)
        print("ZilleWarTable.cs updated.")
    else:
        print(f"Could not find eval/check blocks in ZilleWarTable.cs: start={start_eval}, end={end_check}")

update_war_operation_manager()
update_zille_war_table()
