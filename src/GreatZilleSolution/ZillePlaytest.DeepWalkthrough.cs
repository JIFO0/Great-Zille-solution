using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static partial class ZillePlaytest
    {
        private static readonly string DeepReportPath =
            @"C:\Users\iwo\.gemini\antigravity\brain\92cf9b04-fe39-43f2-a000-fd1a073e796e\scratch\playtest_deep_walkthrough_report.txt";

        private static readonly string DeepShotDir =
            @"C:\Users\iwo\.gemini\antigravity\brain\92cf9b04-fe39-43f2-a000-fd1a073e796e\scratch";

        private class DeepReport
        {
            public readonly StringBuilder Lines = new StringBuilder();
            public int Pass;
            public int Warn;
            public int Fail;

            public void Header(string title)
            {
                string bar = new string('=', 74);
                Lines.AppendLine();
                Lines.AppendLine(bar);
                Lines.AppendLine(title);
                Lines.AppendLine(bar);
                MelonLogger.Msg("[DEEP TEST] " + title);
            }

            public void LogPass(string check, string detail = "")
            {
                Pass++;
                string msg = string.IsNullOrEmpty(detail) ? $"[PASS] {check}" : $"[PASS] {check} :: {detail}";
                Lines.AppendLine(msg);
                MelonLogger.Msg("[DEEP TEST] " + msg);
            }

            public void LogWarn(string check, string detail = "")
            {
                Warn++;
                string msg = string.IsNullOrEmpty(detail) ? $"[WARN] {check}" : $"[WARN] {check} :: {detail}";
                Lines.AppendLine(msg);
                MelonLogger.Warning("[DEEP TEST] " + msg);
            }

            public void LogFail(string check, string detail = "")
            {
                Fail++;
                string msg = string.IsNullOrEmpty(detail) ? $"[FAIL] {check}" : $"[FAIL] {check} :: {detail}";
                Lines.AppendLine(msg);
                MelonLogger.Error("[DEEP TEST] " + msg);
            }

            public void LogInfo(string detail)
            {
                Lines.AppendLine("[INFO] " + detail);
                MelonLogger.Msg("[DEEP TEST] [INFO] " + detail);
            }

            public void Flush()
            {
                try
                {
                    if (!Directory.Exists(DeepShotDir)) Directory.CreateDirectory(DeepShotDir);
                    var sb = new StringBuilder();
                    sb.AppendLine("Great Zille Solution - Deep Brute-Force Conversation & Multi-Campaign Walkthrough Report");
                    sb.AppendLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    sb.AppendLine($"SUMMARY: PASS={Pass}, WARN={Warn}, FAIL={Fail}");
                    sb.Append(Lines.ToString());
                    sb.AppendLine();
                    sb.AppendLine($"FINAL RESULT: {(Fail == 0 && Warn == 0 ? "ALL DEEP CHECKS PASSED" : $"PASS={Pass}, WARN={Warn}, FAIL={Fail}")}");
                    File.WriteAllText(DeepReportPath, sb.ToString(), Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MelonLogger.Error("[DEEP TEST] Flush failed: " + ex.Message);
                }
            }
        }

        private static IEnumerator SaveDeepShotCoroutine(string filename)
        {
            yield return new WaitForEndOfFrame();
            try
            {
                if (!Directory.Exists(DeepShotDir)) Directory.CreateDirectory(DeepShotDir);
                string path = Path.Combine(DeepShotDir, filename);
                int w = Screen.width > 0 ? Screen.width : 1920;
                int h = Screen.height > 0 ? Screen.height : 1080;
                var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
                tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
                tex.Apply();
                byte[] bytes = ImageConversion.EncodeToPNG(tex);
                UnityEngine.Object.Destroy(tex);
                if (bytes != null)
                {
                    File.WriteAllBytes(path, bytes);
                    MelonLogger.Msg($"[DEEP SHOT] Saved {path} ({w}x{h}, {bytes.Length} bytes)");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DEEP SHOT] Failed {filename}: {ex.Message}");
            }
        }

        private static Token FindActiveCityToken(string namePart)
        {
            var tokens = UnityEngine.Object.FindObjectsOfType<Token>();
            if (tokens == null) return null;
            for (int i = 0; i < tokens.Length; i++)
            {
                var tok = tokens[i];
                if (tok == null || !tok.gameObject.activeInHierarchy) continue;
                string en = "";
                try { en = tok.GetTokenDataEntityName() ?? tok.name; } catch { en = tok.name; }
                if (en.IndexOf(namePart, StringComparison.OrdinalIgnoreCase) >= 0)
                    return tok;
            }
            return null;
        }

        private static TemplateInteractionButton FindPanelButton(TokenInteractionPanel tip, string titleSubstring)
        {
            if (tip?.instantiatedInteractionButtons == null) return null;
            for (int i = 0; i < tip.instantiatedInteractionButtons.Count; i++)
            {
                var btn = tip.instantiatedInteractionButtons[i];
                if (btn == null || !btn.gameObject.activeInHierarchy) continue;
                string t = btn.titleText?.text ?? "";
                if (t.IndexOf(titleSubstring, StringComparison.OrdinalIgnoreCase) >= 0)
                    return btn;
            }
            return null;
        }

        private static SaveFile FindRealSave(PersistenceManager pm, string campaign, int turnNo)
        {
            if (pm?.AllSaveFiles == null) return null;
            SaveFile fallback = null;
            for (int i = 0; i < pm.AllSaveFiles.Count; i++)
            {
                var sf = pm.AllSaveFiles[i];
                if (sf?.saveData == null) continue;
                if (sf.saveData.currentStoryPack != "StoryPack_Rizia") continue;
                if (sf.saveData.turnNo != turnNo) continue;
                if (!string.IsNullOrEmpty(sf.fileName) && sf.fileName.StartsWith("Autosave_", StringComparison.OrdinalIgnoreCase)) continue;
                if (string.Equals(sf.saveData.campaignName, campaign, StringComparison.OrdinalIgnoreCase))
                    return sf;
                if (fallback == null) fallback = sf;
            }
            return fallback;
        }

        private static IEnumerator LoadRealSaveCoroutine(PersistenceManager pm, SaveFile sf)
        {
            if (pm == null || sf == null) yield break;
            pm.LoadSaveFile(sf);
            yield return new WaitForSeconds(1.5f);
            float wait = 1.5f;
            while (wait < 25f)
            {
                var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                string activeFn = pm.activeSaveFile?.fileName ?? "";
                if (string.Equals(sc.name, "Rizia", StringComparison.OrdinalIgnoreCase)
                    && (string.Equals(activeFn, sf.fileName, StringComparison.OrdinalIgnoreCase) || wait > 12f))
                {
                    break;
                }
                yield return new WaitForSeconds(0.5f);
                wait += 0.5f;
            }
            yield return new WaitForSeconds(2.5f);

            ZilleDialogueSystem.EnsureAllConversationsRegistered();
            ZilleDialogueSystem.InjectAllVanillaConversationPatches();
            WarOperationZilleManager.RegisterNativeZilleEntities();
            WarOperationZilleManager.CurrentTheatre = ActiveWarTheatre.Civilian;
            ZilleWarTable.ScenarioStarted = false;
            ZilleDecisions.EnsureRegistered();
            ZilleReportsAndSituations.EnsureRegisteredAndSynced();
            ZilleCampaignState.SyncFromLua(resetMissing: true);
        }

        private static readonly Regex DeepSireRegex = new Regex(@"\bSire\b", RegexOptions.IgnoreCase);
        private static readonly Regex DeepGodRegex = new Regex(@"\bGod\b", RegexOptions.IgnoreCase);

        private static string CheckTextAnomalies(string txt)
        {
            if (string.IsNullOrWhiteSpace(txt)) return "empty rendered text";
            if (txt.IndexOf("Valdez", StringComparison.OrdinalIgnoreCase) >= 0) return "contains 'Valdez'";
            if (txt.IndexOf("For Dast", StringComparison.OrdinalIgnoreCase) >= 0) return "contains 'For Dast'";
            if (txt.IndexOf("High Wiser", StringComparison.OrdinalIgnoreCase) >= 0) return "contains 'High Wiser'";
            if (txt.IndexOf("harrying", StringComparison.OrdinalIgnoreCase) >= 0) return "contains 'harrying'";
            if (txt.IndexOf("Queen Lena Livingston", StringComparison.OrdinalIgnoreCase) >= 0) return "contains 'Queen Lena Livingston'";
            if (DeepSireRegex.IsMatch(txt)) return "contains 'Sire'";
            if (DeepGodRegex.IsMatch(txt)) return "contains 'God'";
            return null;
        }

        private static IEnumerator WalkActiveConversationCoroutine(
            DeepReport rep,
            string label,
            string[] preferredKeys,
            string screenshotName = null,
            bool expectCleanFinish = true)
        {
            var convPanel = Panels.Instance?.ConversationPanel ?? UnityEngine.Object.FindObjectOfType<ConversationPanel>();
            var handler = convPanel != null ? convPanel.conversationHandler : UnityEngine.Object.FindObjectOfType<ConversationHandler>();

            float startWait = 0f;
            while (startWait < 3.0f)
            {
                if (DialogueManager.isConversationActive
                    && handler != null
                    && handler.instantiatedConversationTexts != null
                    && handler.instantiatedConversationTexts.Count > 0)
                {
                    break;
                }
                yield return new WaitForSeconds(0.08f);
                startWait += 0.08f;
            }

            if (!DialogueManager.isConversationActive || convPanel == null || handler == null)
            {
                rep.LogFail($"Walk [{label}] Start", $"isActive={DialogueManager.isConversationActive}, panel={(convPanel != null)}, handler={(handler != null)}");
                yield break;
            }

            // Wait for contentCanvasGroup fade-in (>= 0.9f) AND TemplateConversationText.ShowText (yields 7 frames)
            float renderWait = 0f;
            while (renderWait < 1.2f && DialogueManager.isConversationActive)
            {
                float cAlpha = convPanel.contentCanvasGroup != null ? convPanel.contentCanvasGroup.alpha : 1f;
                string firstTmp = "";
                if (handler.instantiatedConversationTexts != null && handler.instantiatedConversationTexts.Count > 0)
                {
                    var t0 = handler.instantiatedConversationTexts[0];
                    if (t0?.conversationText != null) firstTmp = t0.conversationText.text ?? "";
                }
                if (cAlpha >= 0.9f && !string.IsNullOrEmpty(firstTmp))
                    break;
                yield return new WaitForSeconds(0.05f);
                renderWait += 0.05f;
            }

            if (label == "Turn4_Clicked_WarPlanning" || label == "03_DerdiaStateVisit")
            {
                try
                {
                    float cAlpha = convPanel.contentCanvasGroup != null ? convPanel.contentCanvasGroup.alpha : -1f;
                    var t0 = (handler.instantiatedConversationTexts != null && handler.instantiatedConversationTexts.Count > 0)
                        ? handler.instantiatedConversationTexts[0] : null;
                    bool tmpActive = t0?.conversationText != null && t0.conversationText.gameObject.activeInHierarchy;
                    string tmpText = t0?.conversationText != null ? (t0.conversationText.text ?? "") : "";
                    int tmpLen = tmpText.Length;
                    string snippet = tmpText.Replace("\n", " ").Replace("\r", "");
                    if (snippet.Length > 60) snippet = snippet.Substring(0, 60) + "...";
                    rep.LogInfo($"UI Render [{label}]: contentAlpha={cAlpha:F2}, tmpActive={tmpActive}, tmpLen={tmpLen}, snippet='{snippet}'");
                }
                catch (Exception ex)
                {
                    rep.LogWarn($"UI Render [{label}]", ex.Message);
                }
            }

            int seenTexts = 0;
            int renderedLines = 0;
            int maxTmpChars = 0;
            int steps = 0;
            int choicesClicked = 0;
            int stuckTicks = 0;
            int overlapErrors = 0;
            string shotSaved = null;
            var textAnomalies = new List<string>();
            var clickedIds = new HashSet<int>();

            while (DialogueManager.isConversationActive && steps < 90)
            {
                steps++;

                // Audit newly rendered text blocks & wait up to 0.6s for ShowText's 7-frame coroutine to populate TMP
                int curTextCount = handler.instantiatedConversationTexts != null ? handler.instantiatedConversationTexts.Count : 0;
                if (curTextCount > seenTexts)
                {
                    var latest = handler.instantiatedConversationTexts[curTextCount - 1];
                    float twWait = 0f;
                    while (twWait < 0.6f && latest != null && latest.conversationText != null && string.IsNullOrEmpty(latest.conversationText.text))
                    {
                        yield return new WaitForSeconds(0.04f);
                        twWait += 0.04f;
                    }

                    for (int i = seenTexts; i < curTextCount; i++)
                    {
                        var t = handler.instantiatedConversationTexts[i];
                        if (t == null) continue;
                        try { t.SkipTypewriter(); } catch { }
                        yield return null;
                        string raw = "";
                        int tmpChars = 0;
                        try
                        {
                            raw = !string.IsNullOrEmpty(t.unformattedText) ? t.unformattedText : (t.conversationText != null ? t.conversationText.text : "");
                            if (t.conversationText != null && !string.IsNullOrEmpty(t.conversationText.text))
                                tmpChars = t.conversationText.text.Length;
                        }
                        catch { }
                        if (tmpChars > maxTmpChars) maxTmpChars = tmpChars;
                        renderedLines++;
                        string anom = CheckTextAnomalies(raw);
                        if (anom != null)
                        {
                            string snippet = raw.Length > 70 ? raw.Substring(0, 70) + "..." : raw;
                            textAnomalies.Add($"{anom}: '{snippet}'");
                        }
                    }
                    seenTexts = curTextCount;
                    stuckTicks = 0;
                }

                // Check Continue vs Response buttons
                int respCount = handler.instantiatedResponses != null ? handler.instantiatedResponses.Count : 0;
                bool respShown = handler.responsesContainer != null && handler.responsesContainer.gameObject.activeInHierarchy && respCount > 0;
                bool contShown = handler.continueButton != null && handler.continueButton.gameObject.activeInHierarchy;

                if (respShown && contShown)
                {
                    yield return new WaitForSeconds(0.12f);
                    respCount = handler.instantiatedResponses != null ? handler.instantiatedResponses.Count : 0;
                    respShown = handler.responsesContainer != null && handler.responsesContainer.gameObject.activeInHierarchy && respCount > 0;
                    contShown = handler.continueButton != null && handler.continueButton.gameObject.activeInHierarchy;
                    if (respShown && contShown)
                    {
                        overlapErrors++;
                    }
                }

                // Take visual verification screenshot once choices or >=2 lines are rendered & fade-in completed
                float nowAlpha = convPanel.contentCanvasGroup != null ? convPanel.contentCanvasGroup.alpha : 1f;
                if (!string.IsNullOrEmpty(screenshotName) && shotSaved == null && (respShown || curTextCount >= 2) && nowAlpha >= 0.9f)
                {
                    try
                    {
                        if (handler.instantiatedConversationTexts != null)
                        {
                            for (int ti = 0; ti < handler.instantiatedConversationTexts.Count; ti++)
                                handler.instantiatedConversationTexts[ti]?.SkipTypewriter();
                        }
                    }
                    catch { }
                    yield return new WaitForSeconds(0.45f);
                    shotSaved = screenshotName;
                    yield return SaveDeepShotCoroutine(screenshotName);
                }

                int curEntryId = -1;
                try { curEntryId = DialogueManager.currentConversationState?.subtitle?.dialogueEntry?.id ?? -1; } catch { }

                if (respShown)
                {
                    TemplateConversationResponse chosen = null;
                    var enabledResps = new List<TemplateConversationResponse>();
                    for (int ri = 0; ri < handler.instantiatedResponses.Count; ri++)
                    {
                        var r = handler.instantiatedResponses[ri];
                        if (r != null && r.gameObject.activeInHierarchy && r.response != null)
                            enabledResps.Add(r);
                    }

                    // 1) Prefer preferredKeys among unclicked entries
                    if (preferredKeys != null)
                    {
                        foreach (var pk in preferredKeys)
                        {
                            if (string.IsNullOrEmpty(pk)) continue;
                            for (int ri = 0; ri < enabledResps.Count; ri++)
                            {
                                var r = enabledResps[ri];
                                int did = r.response.destinationEntry != null ? r.response.destinationEntry.id : -1;
                                if (clickedIds.Contains(did)) continue;
                                string title = r.response.destinationEntry?.Title ?? "";
                                string mtxt = r.unformattedText ?? (r.text != null ? r.text.text : "");
                                if (title.IndexOf(pk, StringComparison.OrdinalIgnoreCase) >= 0
                                    || mtxt.IndexOf(pk, StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    chosen = r;
                                    break;
                                }
                            }
                            if (chosen != null) break;
                        }
                    }

                    // 2) Else pick last unclicked choice (hub "Proceed" / forward options sit at the end), or first unclicked
                    if (chosen == null)
                    {
                        for (int ri = enabledResps.Count - 1; ri >= 0; ri--)
                        {
                            var r = enabledResps[ri];
                            int did = r.response.destinationEntry != null ? r.response.destinationEntry.id : -1;
                            if (!clickedIds.Contains(did))
                            {
                                chosen = r;
                                break;
                            }
                        }
                    }

                    // 3) Fallback if everything in hub clicked before
                    if (chosen == null && enabledResps.Count > 0)
                        chosen = enabledResps[enabledResps.Count - 1];

                    if (chosen != null)
                    {
                        int did = chosen.response.destinationEntry != null ? chosen.response.destinationEntry.id : -1;
                        if (did >= 0) clickedIds.Add(did);
                        choicesClicked++;
                        stuckTicks = 0;
                        try
                        {
                            if (chosen.responseButton != null && chosen.responseButton.interactable)
                                chosen.responseButton.onClick.Invoke();
                            else
                                handler.OnResponseClick(chosen.response);
                        }
                        catch
                        {
                            try { handler.OnResponseClick(chosen.response); } catch { }
                        }
                        yield return new WaitForSeconds(0.15f);
                        continue;
                    }
                }

                // Wait for any in-flight OnContinueCoroutine to complete before calling OnContinue() once
                float preContWait = 0f;
                while (handler.continueCoroutine != null && preContWait < 0.85f && DialogueManager.isConversationActive)
                {
                    yield return new WaitForSeconds(0.06f);
                    preContWait += 0.06f;
                }

                int prevTextCount = handler.instantiatedConversationTexts != null ? handler.instantiatedConversationTexts.Count : 0;
                int prevEntryId = curEntryId;

                try { handler.OnContinue(); } catch { }

                // Poll for OnContinueCoroutine completion + state transition
                float postContWait = 0f;
                int nowTextCount = prevTextCount;
                int nowEntryId = prevEntryId;
                bool nowRespShown = false;
                while (postContWait < 0.85f)
                {
                    yield return new WaitForSeconds(0.06f);
                    postContWait += 0.06f;

                    if (!DialogueManager.isConversationActive)
                        break;

                    nowTextCount = handler.instantiatedConversationTexts != null ? handler.instantiatedConversationTexts.Count : 0;
                    nowEntryId = -1;
                    try { nowEntryId = DialogueManager.currentConversationState?.subtitle?.dialogueEntry?.id ?? -1; } catch { }
                    int rcNow = handler.instantiatedResponses != null ? handler.instantiatedResponses.Count : 0;
                    nowRespShown = handler.responsesContainer != null && handler.responsesContainer.gameObject.activeInHierarchy && rcNow > 0;

                    if ((nowEntryId != prevEntryId || nowTextCount != prevTextCount || nowRespShown) && handler.continueCoroutine == null)
                        break;
                }

                if (DialogueManager.isConversationActive
                    && nowTextCount == prevTextCount
                    && nowEntryId == prevEntryId
                    && !nowRespShown)
                {
                    stuckTicks++;
                }
                else
                {
                    stuckTicks = 0;
                }

                if (stuckTicks >= 4)
                {
                    bool cbAct = handler.continueButton != null && handler.continueButton.gameObject.activeInHierarchy;
                    bool otherCenter = false;
                    try { otherCenter = Panels.Instance != null && Panels.Instance.IsAnyCenterPanelOtherThanConversationPanelShowing(); } catch { }
                    bool waitingCont = false;
                    try { waitingCont = DialogueManager.conversationView != null && DialogueManager.conversationView.isWaitingForContinue; } catch { }
                    rep.LogFail($"Walk [{label}] Stuck", $"Stuck after {steps} steps at entryId={nowEntryId}, renderedLines={renderedLines}, maxTmpChars={maxTmpChars}, contBtnActive={cbAct}, isOtherCenterShowing={otherCenter}, isWaitingForContinue={waitingCont}");
                    try { DialogueManager.StopConversation(); convPanel.Hide(); } catch { }
                    yield break;
                }
            }

            if (!string.IsNullOrEmpty(screenshotName) && shotSaved == null)
            {
                yield return SaveDeepShotCoroutine(screenshotName);
            }

            yield return new WaitForSeconds(0.20f);

            if (DialogueManager.isConversationActive && expectCleanFinish)
            {
                rep.LogFail($"Walk [{label}] Timeout", $"Still active after {steps} steps, renderedLines={renderedLines}");
                try { DialogueManager.StopConversation(); convPanel.Hide(); } catch { }
                yield break;
            }

            try
            {
                if (convPanel.IsShowing() && !DialogueManager.isConversationActive)
                    convPanel.Hide();
            }
            catch { }

            if (overlapErrors > 0)
            {
                rep.LogFail($"Walk [{label}] UI Overlap", $"Continue & Responses simultaneously active {overlapErrors}x!");
            }
            else if (textAnomalies.Count > 0)
            {
                rep.LogFail($"Walk [{label}] Text Anomaly", string.Join(" | ", textAnomalies));
            }
            else if (renderedLines < 2 || maxTmpChars == 0)
            {
                rep.LogFail($"Walk [{label}] Blank/Short Render", $"renderedLines={renderedLines}, maxTmpChars={maxTmpChars} in {steps} steps.");
            }
            else
            {
                rep.LogPass($"Walk [{label}]", $"completed cleanly: steps={steps}, renderedLines={renderedLines}, maxTmpChars={maxTmpChars}, choices={choicesClicked}, overlap=0");
            }
        }

        private static IEnumerator WalkSceneCoroutine(
            DeepReport rep,
            string label,
            string dbName,
            string titlePath,
            string profileName,
            string[] preferredKeys = null,
            string screenshotName = null,
            Action<EventsAuditReport_Dummy> extraSetup = null)
        {
            ApplyAuditProfile(profileName);
            if (extraSetup != null) extraSetup(null);
            ZilleCampaignState.SyncToLua();
            ZilleReportsAndSituations.SyncVariables();

            bool launched = false;
            try
            {
                if (dbName == "Turn_Zille_WarBriefing")
                    launched = WarOperationZilleManager.TriggerZilleWarBriefingConversation();
                else
                    launched = WarOperationZilleManager.TriggerConversation(dbName, titlePath);
            }
            catch (Exception ex)
            {
                rep.LogFail($"Launch [{label}]", ex.Message);
            }

            if (!launched) yield break;

            yield return WalkActiveConversationCoroutine(rep, label, preferredKeys, screenshotName);
            yield return new WaitForSeconds(0.75f);
            float hideWait = 0f;
            var cp = Panels.Instance?.ConversationPanel ?? UnityEngine.Object.FindObjectOfType<ConversationPanel>();
            while (cp != null && cp.IsShowing() && hideWait < 1.0f)
            {
                yield return new WaitForSeconds(0.1f);
                hideWait += 0.1f;
            }
        }

        private class EventsAuditReport_Dummy { }

        public static IEnumerator RunDeepWalkthroughSuiteCoroutine()
        {
            Application.runInBackground = true;
            var rep = new DeepReport();
            rep.Header("PHASE 0: Booting Game for Deep Walkthrough & Multi-Campaign Save Audit");

            float bootWait = 0f;
            while (bootWait < 60f)
            {
                var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                if (string.Equals(sc.name, "Main Menu", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(sc.name, "Rizia", StringComparison.OrdinalIgnoreCase))
                    break;
                yield return new WaitForSeconds(0.5f);
                bootWait += 0.5f;
            }
            yield return new WaitForSeconds(4.0f);

            var initSc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if (string.Equals(initSc.name, "Main Menu", StringComparison.OrdinalIgnoreCase))
            {
                float w = 0f;
                while (w < 50f)
                {
                    var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                    if (!string.Equals(sc.name, "Main Menu", StringComparison.OrdinalIgnoreCase)
                        && !string.Equals(sc.name, "Initialize", StringComparison.OrdinalIgnoreCase))
                        break;
                    var mm = UnityEngine.Object.FindObjectOfType<MainMenuPanel>();
                    bool showing = false;
                    try { showing = mm != null && mm.IsShowing(); } catch { }
                    if (mm != null && showing)
                    {
                        try { mm.OnContinueClick(); } catch { }
                    }
                    yield return new WaitForSeconds(3.0f);
                    w += 3.0f;
                }
                yield return new WaitForSeconds(3.0f);
            }

            var activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if (string.Equals(activeScene.name, "Main Menu", StringComparison.OrdinalIgnoreCase)
                || string.Equals(activeScene.name, "Initialize", StringComparison.OrdinalIgnoreCase))
            {
                rep.LogFail("Boot", $"Timed out in '{activeScene.name}'");
                rep.Flush();
                Application.Quit();
                yield break;
            }
            rep.LogPass("Boot", $"Entered scene '{activeScene.name}' cleanly.");

            var pm = PersistenceManager.Instance ?? UnityEngine.Object.FindObjectOfType<PersistenceManager>();

            // =========================================================================
            // PHASE A: Real Multi-Campaign Saves + Clicking Real Buttons & Decisions
            // =========================================================================
            rep.Header("PHASE A: Real Multi-Campaign Savegames, Native Button Clicks & Decisions");

            // A1: Turn 4 ("The context of Authority") - Decision click + WarPlanning click-through
            var sfT4 = FindRealSave(pm, "The context of Authority", 4);
            if (sfT4 != null)
            {
                rep.LogInfo($"Loading Campaign='{sfT4.saveData.campaignName}', Turn={sfT4.saveData.turnNo} ({sfT4.fileName})...");
                yield return LoadRealSaveCoroutine(pm, sfT4);
                int turn = ZilleCampaignState.GetCurrentTurn();
                var pd = FindActiveCityToken("PorteDrazon");
                var tip = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();

                if (turn != 4 || pd == null || tip == null || WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Civilian)
                {
                    rep.LogFail("Turn 4 Setup", $"turn={turn}, theatre={WarOperationZilleManager.CurrentTheatre}, pd={(pd != null)}, tip={(tip != null)}");
                }
                else
                {
                    tip.gameObject.SetActive(true);
                    tip.Setup(pd);
                    yield return null;

                    // 1. Verify peaceful no-war gating BEFORE enabling any war intent!
                    bool plannedInitial = ZilleCampaignState.IsZilleWarPlanned();
                    bool leakedPlanning = FindPanelButton(tip, "Emergency Crown Council: The Fate of Zille") != null;
                    bool leakedLogistics = FindPanelButton(tip, "Supply Lines of Brenas") != null;
                    bool leakedBriefing = FindPanelButton(tip, "A royal briefing before the invasion of Zille") != null;
                    bool leakedLespia = FindPanelButton(tip, "Lespian Hotline") != null;
                    bool leakedRumburg = FindPanelButton(tip, "Imperial Trunk Line") != null;
                    bool leakedSmolakSit = DialogueHelper.GetBoolVariable("Zille_Sit_SmolakMinimal")
                        || DialogueHelper.GetBoolVariable("Zille_Sit_SmolakSuspicious")
                        || DialogueHelper.GetBoolVariable("Zille_Sit_SmolakPrepared");
                    if (!plannedInitial && !leakedPlanning && !leakedLogistics && !leakedBriefing && !leakedLespia && !leakedRumburg && !leakedSmolakSit)
                        rep.LogPass("Turn 4 Peaceful No-War Gating", "Untouched peaceful Turn 4 save hides Emergency Crown Council, Supply Lines, War Briefing, Hotlines, and Smolak Suspicion situations.");
                    else
                        rep.LogFail("Turn 4 Peaceful No-War Gating", $"planned={plannedInitial}, plan={leakedPlanning}, log={leakedLogistics}, brief={leakedBriefing}, lespia={leakedLespia}, rumb={leakedRumburg}, smolakSit={leakedSmolakSit}");

                    var sabBtn = FindPanelButton(tip, "Sabotage Along the Derdia-Wehlen Border");
                    if (sabBtn != null && sabBtn.button != null)
                    {
                        sabBtn.button.onClick.Invoke();
                        yield return null;
                        if (ZilleDecisions.ActiveModalDecision != null && ZilleDecisions.ActiveModalDecision.Options.Count >= 2)
                        {
                            var opt = ZilleDecisions.ActiveModalDecision.Options[1]; // Launch full investigation
                            opt.OnSelected?.Invoke();
                            yield return null;
                            bool doneVar = DialogueHelper.GetBoolVariable("Zille_Derdia_InvestigationDone");
                            bool modalClosed = ZilleDecisions.ActiveModalDecision == null;

                            // Re-open Porte Drazon and ensure completed decision disappeared
                            tip.Setup(pd);
                            yield return null;
                            var sabBtnAfter = FindPanelButton(tip, "Sabotage Along the Derdia-Wehlen Border");

                            if (doneVar && modalClosed && sabBtnAfter == null)
                                rep.LogPass("Turn 4 Real Decision Click", "Clicked Sabotage decision on Porte Drazon -> executed -> DoneVar=true -> button removed on refresh.");
                            else
                                rep.LogFail("Turn 4 Real Decision Click", $"doneVar={doneVar}, modalClosed={modalClosed}, btnStillPresent={(sabBtnAfter != null)}");
                        }
                        else
                        {
                            rep.LogFail("Turn 4 Decision Modal", "ActiveModalDecision did not open on native button click.");
                        }
                    }
                    else
                    {
                        var foundTitles = new List<string>();
                        if (tip.instantiatedInteractionButtons != null)
                        {
                            for (int bi = 0; bi < tip.instantiatedInteractionButtons.Count; bi++)
                            {
                                var b = tip.instantiatedInteractionButtons[bi];
                                if (b != null && b.gameObject.activeInHierarchy)
                                    foundTitles.Add(b.titleText?.text ?? "?");
                            }
                        }
                        rep.LogFail("Turn 4 Decision Button Missing", $"Sabotage Along the Derdia-Wehlen Border not found on Porte Drazon (theatre={WarOperationZilleManager.CurrentTheatre}, buttons=[{string.Join(" | ", foundTitles)}]).");
                    }

                    // 2. Simulate explicit war intent -> Emergency Crown Council unlocks -> choose Stand Down!
                    DialogueHelper.SetVariable("Zille_StaffPlanning_Started", true);
                    ZilleCampaignState.SyncFromLua();
                    tip.gameObject.SetActive(true);
                    tip.Setup(pd);
                    yield return null;

                    var standDownPlanBtn = FindPanelButton(tip, "Emergency Crown Council: The Fate of Zille");
                    if (standDownPlanBtn != null && standDownPlanBtn.button != null)
                    {
                        standDownPlanBtn.button.onClick.Invoke();
                        yield return WalkActiveConversationCoroutine(rep, "Turn4_WarPlanning_StandDown", new[] { "Conclude_Planning_StandDown", "Stand down", "Proceed_To_" });
                        yield return new WaitForSeconds(0.4f);

                        bool declinedAfter = DialogueHelper.GetBoolVariable("Zille_War_Declined");
                        bool plannedAfterStandDown = ZilleCampaignState.IsZilleWarPlanned();
                        tip.gameObject.SetActive(true);
                        tip.Setup(pd);
                        yield return null;
                        bool planBtnGone = FindPanelButton(tip, "Emergency Crown Council: The Fate of Zille") == null;
                        bool briefBtnGone = FindPanelButton(tip, "A royal briefing before the invasion of Zille") == null;
                        if (declinedAfter && !plannedAfterStandDown && planBtnGone && briefBtnGone)
                            rep.LogPass("Turn 4 WarPlanning Stand-Down Exit", "Choosing Conclude_Planning_StandDown hid Emergency Crown Council & War Briefing with zero mandatory lock.");
                        else
                            rep.LogFail("Turn 4 WarPlanning Stand-Down Exit", $"declined={declinedAfter}, planned={plannedAfterStandDown}, planBtnGone={planBtnGone}, briefBtnGone={briefBtnGone}");
                    }
                    else
                    {
                        rep.LogFail("Turn 4 WarPlanning Unlock", "Emergency Crown Council button missing even after Zille_StaffPlanning_Started=true.");
                    }

                    // 3. Re-opt into war planning -> Emergency Crown Council -> proceed to WarPlanning_Done -> Supply Lines & Briefing unlock!
                    DialogueHelper.SetVariable("Zille_War_Declined", false);
                    DialogueHelper.SetVariable("Zille_War_Postpone", false);
                    DialogueHelper.SetVariable("Zille_StaffPlanning_Started", true);
                    ZilleCampaignState.SyncFromLua();
                    tip.gameObject.SetActive(true);
                    tip.Setup(pd);
                    yield return null;

                    var planBtn = FindPanelButton(tip, "Emergency Crown Council: The Fate of Zille");
                    if (planBtn != null && planBtn.button != null)
                    {
                        planBtn.button.onClick.Invoke();
                        yield return WalkActiveConversationCoroutine(rep, "Turn4_Clicked_WarPlanning", new[] { "Conclude_Planning_Discreet", "Proceed_To_" });
                        yield return new WaitForSeconds(0.4f);

                        bool planDone = DialogueHelper.GetBoolVariable("Zille_War_Planning_Done");
                        tip.gameObject.SetActive(true);
                        tip.Setup(pd);
                        yield return null;
                        var logBtn = FindPanelButton(tip, "Supply Lines of Brenas");
                        var briefBtn = FindPanelButton(tip, "A royal briefing before the invasion of Zille");
                        if (planDone && logBtn != null && briefBtn != null)
                            rep.LogPass("Turn 4 Real Button -> WarPlanning Progression", "Walking WarPlanning via real button click set Zille_War_Planning_Done=true and unlocked Supply Lines of Brenas & Royal Briefing!");
                        else
                            rep.LogFail("Turn 4 Real Button -> WarPlanning Progression", $"planDone={planDone}, logisticsBtn={(logBtn != null)}, briefBtn={(briefBtn != null)}");
                    }
                    else
                    {
                        rep.LogFail("Turn 4 WarPlanning Button", "Emergency Crown Council button missing after re-enabling war intent.");
                    }

                    try { tip.Hide(); } catch { }
                }
            }
            else rep.LogFail("Turn 4 Save Discovery", "Missing Turn 4 save");

            // A2: Turn 6 ("Malenkevist dream") - Verify clean cross-save state reset!
            var sfT6 = FindRealSave(pm, "Malenkevist dream", 6);
            if (sfT6 != null)
            {
                rep.LogInfo($"Loading Campaign='{sfT6.saveData.campaignName}', Turn={sfT6.saveData.turnNo} ({sfT6.fileName})...");
                yield return LoadRealSaveCoroutine(pm, sfT6);
                int t6 = ZilleCampaignState.GetCurrentTurn();
                bool bledOver = DialogueHelper.GetBoolVariable("Zille_War_Planning_Done") || DialogueHelper.GetBoolVariable("Zille_Derdia_InvestigationDone");
                if (t6 == 6 && !bledOver)
                    rep.LogPass("Turn 6 Clean Save Load", $"Campaign='Malenkevist dream', loadedTurn={t6}, zero cross-save bleed-over.");
                else
                    rep.LogFail("Turn 6 Clean Save Load", $"loadedTurn={t6}, bledOver={bledOver}");
            }

            // A3: Turn 8 ("Main") - Verify Turn 8 + click Gulf Escorts decision on Sallabes!
            var sfT8 = FindRealSave(pm, "Main", 8);
            if (sfT8 != null)
            {
                rep.LogInfo($"Loading Campaign='{sfT8.saveData.campaignName}', Turn={sfT8.saveData.turnNo} ({sfT8.fileName})...");
                yield return LoadRealSaveCoroutine(pm, sfT8);
                int t8 = ZilleCampaignState.GetCurrentTurn();
                var sal = FindActiveCityToken("Sallabes");
                var tip = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();
                if (t8 == 8 && sal != null && tip != null)
                {
                    tip.gameObject.SetActive(true);
                    tip.Setup(sal);
                    yield return null;
                    var gulfBtn = FindPanelButton(tip, "Harassment of Rizian Freighters");
                    if (gulfBtn != null && gulfBtn.button != null)
                    {
                        gulfBtn.button.onClick.Invoke();
                        yield return null;
                        if (ZilleDecisions.ActiveModalDecision != null && ZilleDecisions.ActiveModalDecision.Options.Count > 0)
                        {
                            ZilleDecisions.ActiveModalDecision.Options[0].OnSelected?.Invoke();
                            yield return null;
                            bool gulfDone = DialogueHelper.GetBoolVariable("Zille_Dec_GulfEscorts_Done");
                            if (gulfDone)
                                rep.LogPass("Turn 8 Sallabes Decision Click", "Clicked Gulf Escorts decision cleanly on Campaign='Main' -> Done=true.");
                            else
                                rep.LogFail("Turn 8 Sallabes Decision Click", "Zille_Dec_GulfEscorts_Done stayed false.");
                        }
                        else rep.LogFail("Turn 8 Sallabes Decision Click", "Decision modal did not open.");
                    }
                    else rep.LogFail("Turn 8 Sallabes Decision Button", "Harassment of Rizian Freighters missing on Sallabes.");
                    try { tip.Hide(); } catch { }
                }
                else rep.LogFail("Turn 8 Load", $"t8={t8}, sal={(sal != null)}");
            }

            // A4: Turn 9 ("Divine Nature")
            var sfT9 = FindRealSave(pm, "Divine Nature", 9);
            if (sfT9 != null)
            {
                rep.LogInfo($"Loading Campaign='{sfT9.saveData.campaignName}', Turn={sfT9.saveData.turnNo} ({sfT9.fileName})...");
                yield return LoadRealSaveCoroutine(pm, sfT9);
                int t9 = ZilleCampaignState.GetCurrentTurn();
                bool t9Planned = ZilleCampaignState.IsZilleWarPlanned();
                var pd9 = FindActiveCityToken("PorteDrazon");
                var tip9 = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();
                bool t9Leaked = false;
                if (pd9 != null && tip9 != null)
                {
                    tip9.gameObject.SetActive(true);
                    tip9.Setup(pd9);
                    yield return null;
                    t9Leaked = FindPanelButton(tip9, "Emergency Crown Council") != null
                            || FindPanelButton(tip9, "A royal briefing before the invasion of Zille") != null;
                    try { tip9.Hide(); } catch { }
                }
                if (t9 == 9 && !t9Planned && !t9Leaked)
                    rep.LogPass("Turn 9 Clean Save Load", $"Campaign='Divine Nature', loadedTurn={t9}, peaceful no-war gating clean.");
                else
                    rep.LogFail("Turn 9 Clean Save Load", $"t9={t9}, planned={t9Planned}, leaked={t9Leaked}.");
            }

            // =========================================================================
            // PHASE B: Brute-Force Full Walkthrough of All 18 Scenes Across 24 Branches
            // =========================================================================
            rep.Header("PHASE B: Brute-Force Walkthrough of All 18 Scenes (24 Branches)");

            yield return WalkSceneCoroutine(rep, "00A_SovereigntyDeclaration_HawkishMarch", "Turn_Zille_SovereigntyDeclaration", "Zille/SovereigntyDeclaration",
                "P1_Baseline_Op1", new[] { "MarchAnnouncement", "MarchIntoZille" });

            yield return WalkSceneCoroutine(rep, "00B_SovereigntyDeclaration_Peaceful", "Turn_Zille_SovereigntyDeclaration", "Zille/SovereigntyDeclaration",
                "P1_Baseline_Op1", new[] { "Peaceful" });

            yield return WalkSceneCoroutine(rep, "00C_SovereigntyDeclaration_Legalist", "Turn_Zille_SovereigntyDeclaration", "Zille/SovereigntyDeclaration",
                "P1_Baseline_Op1", new[] { "Legalist" });

            yield return WalkSceneCoroutine(rep, "01_DerdiaInvestigation", "Turn_Zille_DerdiaInvestigation", "Zille/DerdiaInvestigation",
                "P1_Baseline_Op1", new[] { "DerdiaInv_GoldenGuard", "DerdiaInv_Proceed_Action" });

            yield return WalkSceneCoroutine(rep, "02_DerdiaTalks", "Turn_Zille_DerdiaTalks", "Zille/DerdiaTalks",
                "P7_EarlyWar_Turn3_Turn4_ArtSword", new[] { "Choice_Sabotage_Solidarity", "Ask_", "Proceed", "Invite" });

            yield return WalkSceneCoroutine(rep, "03_DerdiaStateVisit", "Turn_Zille_DerdiaStateVisit", "Zille/DerdiaStateVisit",
                "P1_Baseline_Op1", new[] { "DerdiaVisit_Proceed_Sign", "DerdiaVisit_Sign_FullPipeline", "DerdiaVisit_Sign_Corridor" }, "deep_02_derdia_visit.png");

            yield return WalkSceneCoroutine(rep, "04_LespiaTalks", "Turn_Zille_LespiaTalks", "Zille/LespiaTalks",
                "P1_Baseline_Op1", new[] { "Lespia", "Accept" });

            yield return WalkSceneCoroutine(rep, "05_RumburgTalks", "Turn_Zille_RumburgTalks", "Zille/RumburgTalks",
                "P1_Baseline_Op1", new[] { "Rumburg", "GRACE", "Pledge" });

            yield return WalkSceneCoroutine(rep, "06_WarPlanning_Baseline", "Turn_Zille_WarPlanning", "Zille/WarPlanning",
                "P1_Baseline_Op1", new[] { "Sword", "Azaro" }, "deep_01_warplanning.png");

            yield return WalkSceneCoroutine(rep, "07_WarLogisticsDispute", "Turn_Zille_WarLogisticsDispute", "Zille/WarLogisticsDispute",
                "P1_Baseline_Op1", new[] { "Compromise", "Azaro" });

            yield return WalkSceneCoroutine(rep, "08_WarBriefing_Sword", "Turn_Zille_WarBriefing", "Zille/WarCouncil_Briefing",
                "P1_Baseline_Op1", new[] { "Sword" }, null, _ => {
                    DialogueHelper.SetVariable("Zille_War_PlanType", "Romulus");
                    DialogueHelper.SetVariable("Zille_War_RomulusPlan", "Sword");
                });

            yield return WalkSceneCoroutine(rep, "09_WarBriefing_Ark", "Turn_Zille_WarBriefing", "Zille/WarCouncil_Briefing",
                "P7_EarlyWar_Turn3_Turn4_ArtSword", new[] { "Ark" }, null, _ => {
                    DialogueHelper.SetVariable("Zille_War_PlanType", "Romulus");
                    DialogueHelper.SetVariable("Zille_War_RomulusPlan", "Ark");
                });

            yield return WalkSceneCoroutine(rep, "10_WarBalconySpeech", "Turn_Zille_WarBalconySpeech", "Zille/WarBalconySpeech",
                "P1_Baseline_Op1", new[] { "Proclaim" });

            yield return WalkSceneCoroutine(rep, "11_HomeFrontCrisis", "Turn_Zille_HomeFrontCrisis", "Zille/HomeFrontCrisis",
                "P8_HomeFrontCrisis_HighAN", new[] { "Ration", "Diesel", "White Paper" });

            yield return WalkSceneCoroutine(rep, "12_MaveNortusHQ", "Turn_Zille_MaveNortusHQ", "Zille/MaveNortusHQ",
                "P1_Baseline_Op1", new[] { "Order_Refugee_Aid", "Order_Phase2_Launch", "Regroup_RestRefit" }, null, _ => {
                    ZilleCampaignState.RecordZilleLosses(1, 3, 12);
                    ZilleCampaignState.SyncToLua();
                });

            yield return WalkSceneCoroutine(rep, "13_Op1Aftermath_VictoryCeasefire", "Turn_Zille_Op1AftermathCouncil", "Zille/Op1AftermathCouncil",
                "P3_Op1_DecisiveVictory_VinaDead", new[] { "Op1_Accept_Ceasefire_Sword" }, null, _ => {
                    ZilleCampaignState.CapZilleCity = true;
                    ZilleCampaignState.CapWiktrany = true;
                    ZilleCampaignState.SyncToLua();
                });

            yield return WalkSceneCoroutine(rep, "14_Op1Aftermath_TotalRepayment", "Turn_Zille_Op1AftermathCouncil", "Zille/Op1AftermathCouncil",
                "P1_Baseline_Op1", new[] { "Op1_Force_TotalRepayment_Armor" }, null, _ => {
                    ZilleCampaignState.CapZilleCity = false;
                    ZilleCampaignState.CapGrodzizg = false;
                    ZilleCampaignState.SyncToLua();
                });

            yield return WalkSceneCoroutine(rep, "15_WarPreNegotiationsBriefing", "Turn_Zille_WarPreNegotiationsBriefing", "Zille/WarPreNegotiationsBriefing",
                "P4_Op2_TotalRepayment_Stalemate", new[] { "Proceed", "Finish" });

            yield return WalkSceneCoroutine(rep, "16_SmolakFinalParley_Victory", "Turn_Zille_WarSmolakFinalParley", "Zille/WarSmolakFinalParley",
                "P3_Op1_DecisiveVictory_VinaDead", new[] { "Accept_Decisive_Surrender", "Demand_Leveraged_Reparations" }, "deep_03_smolak_parley.png", _ => {
                    DialogueHelper.SetVariable("Zille_War_Outcome", 4);
                });

            yield return WalkSceneCoroutine(rep, "17_SmolakFinalParley_RefuseCollapse", "Turn_Zille_WarSmolakFinalParley", "Zille/WarSmolakFinalParley",
                "P5_Op2_TacticalDefeat_CollapseWarning", new[] { "Refuse_Parley_Collapse" });

            yield return WalkSceneCoroutine(rep, "18_WarPeaceTreaty", "Turn_Zille_WarPeaceTreaty", "Zille/WarPeaceTreaty",
                "P3_Op1_DecisiveVictory_VinaDead", new[] { "Sign_" });

            yield return WalkSceneCoroutine(rep, "19_ZilleLiberation", "Turn_Zille_ZilleLiberation", "Zille/ZilleLiberation",
                "P3_Op1_DecisiveVictory_VinaDead", new[] { "Charter", "Clean" });

            yield return WalkSceneCoroutine(rep, "20_ExileEpilogue_ReturnIntervene", "Turn_Zille_ExileEpilogue", "Zille/ExileEpilogue",
                "P6_TotalFiasco_Collapse_Exile", new[] { "Exile_Return_To_Intervene" }, "deep_04_exile_return.png");

            yield return WalkSceneCoroutine(rep, "21_ExileEpilogue_AirportVinaManus", "Turn_Zille_ExileEpilogue", "Zille/ExileEpilogue",
                "P6_TotalFiasco_Collapse_Exile", new[] { "Exile_Work_As_AN_Official" }, "deep_05_exile_airport.png");

            // =========================================================================
            // PHASE C: Chained TriggerSmolakParley() under Collapse State (Zero Stale UI)
            // =========================================================================
            rep.Header("PHASE C: Chained TriggerSmolakParley() Collapse -> Exile Epilogue");
            ApplyAuditProfile("P6_TotalFiasco_Collapse_Exile");
            DialogueHelper.SetVariable("Zille_Exile_Choice", "");
            WarOperationZilleManager.TriggerSmolakParley();
            yield return WalkActiveConversationCoroutine(rep, "Chained_TriggerSmolakParley_Collapse", new[] { "Exile_Work_As_AN_Official" });
            string exileChoice = DialogueHelper.GetStringVariable("Zille_Exile_Choice");
            bool exileDone = DialogueHelper.GetBoolVariable("Zille_ExileEpilogue_Done");
            if (exileChoice == "ANDiplomat" && exileDone)
                rep.LogPass("Chained Parley Collapse Routing", $"TriggerSmolakParley() routed directly to ExileEpilogue cleanly -> Zille_Exile_Choice='{exileChoice}', Done={exileDone}.");
            else
                rep.LogFail("Chained Parley Collapse Routing", $"exileChoice='{exileChoice}', Done={exileDone}");

            // =========================================================================
            // PHASE D: Vanilla Patched Nodes Live Lua Evaluation
            // =========================================================================
            rep.Header("PHASE D: Vanilla Referendum Interrupt & Vanilla Exile Collapse Conditions");
            try
            {
                var db = DialogueManager.masterDatabase;
                int refChecked = 0, refPassed = 0;
                int exileChecked = 0, exilePassed = 0;
                ApplyAuditProfile("P6_TotalFiasco_Collapse_Exile");
                if (db?.conversations != null)
                {
                    for (int ci = 0; ci < db.conversations.Count; ci++)
                    {
                        var c = db.conversations[ci];
                        if (c?.dialogueEntries == null) continue;
                        string ct = c.Title ?? "";
                        if (ct.StartsWith("Zille/") || ct.StartsWith("Turn_Zille_")) continue;

                        if (ct.IndexOf("ZilleReferendum", StringComparison.OrdinalIgnoreCase) >= 0
                            || ct.IndexOf("ZilleHandback", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            for (int ei = 0; ei < c.dialogueEntries.Count; ei++)
                            {
                                var e = c.dialogueEntries[ei];
                                if (e != null && ((e.DialogueText ?? "").Contains("INTERRUPT") || (e.conditionsString ?? "").Contains("Zille_War_Active")))
                                {
                                    refChecked++;
                                    if (string.IsNullOrWhiteSpace(e.conditionsString) || Lua.IsTrue(e.conditionsString))
                                        refPassed++;
                                }
                            }
                        }
                        else if (ct.IndexOf("Exile", StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            for (int ei = 0; ei < c.dialogueEntries.Count; ei++)
                            {
                                var e = c.dialogueEntries[ei];
                                if (e != null && ((e.conditionsString ?? "").Contains("Zille_Azaro_Coup_Collapse") || (e.conditionsString ?? "").Contains("Ending_Coup_Azaro")))
                                {
                                    exileChecked++;
                                    if (Lua.IsTrue(e.conditionsString))
                                        exilePassed++;
                                }
                            }
                        }
                    }
                }
                if (refChecked > 0 && refPassed > 0 && exileChecked > 0 && exilePassed > 0)
                    rep.LogPass("Vanilla Patches Lua Conditions", $"Referendum/Handback interrupt passed={refPassed}/{refChecked}, Vanilla Exile collapse passed={exilePassed}/{exileChecked}.");
                else
                    rep.LogFail("Vanilla Patches Lua Conditions", $"Referendum={refPassed}/{refChecked}, Exile={exilePassed}/{exileChecked}");
            }
            catch (Exception ex)
            {
                rep.LogFail("Vanilla Patches Eval", ex.Message);
            }

            rep.Flush();
            MelonLogger.Msg($"[DEEP TEST] Finished! PASS={rep.Pass}, WARN={rep.Warn}, FAIL={rep.Fail}. Report saved to: {DeepReportPath}");
            yield return new WaitForSeconds(0.8f);
            Application.Quit();
        }
    }
}
