using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static class ZillePlaytest
    {
        private static readonly string ScreenshotDir = @"C:\Users\iwo\.gemini\antigravity\brain\48356619-f2a2-453f-8a43-85ce37e0404b\scratch";

        private static void SaveShot(string name)
        {
            try
            {
                if (!Directory.Exists(ScreenshotDir)) Directory.CreateDirectory(ScreenshotDir);
                string path = Path.Combine(ScreenshotDir, name);
                Camera cam = ZilleWarTable.HasLiveMap ? ZilleWarTable.WarCamera() : Camera.main;
                if (cam == null) cam = Camera.main;
                if (cam == null && Camera.allCamerasCount > 0) cam = Camera.allCameras[0];
                if (cam == null)
                {
                    MelonLogger.Warning($"[PLAYTEST SHOT] No camera for {name}");
                    return;
                }
                var t35 = ZilleWarTable.HasLiveMap ? ZilleWarTable.FindLiveTile("35") : null;
                string vpStr = t35 != null ? cam.WorldToViewportPoint(t35.transform.position).ToString() : "n/a";
                MelonLogger.Msg($"[PLAYTEST SHOT] {name}: cam='{cam.name}' pos={cam.transform.position} rot={cam.transform.eulerAngles} tile35_vp={vpStr} (totalCams={Camera.allCamerasCount})");
                int w = 1280, h = 720;
                var rt = new RenderTexture(w, h, 24);
                var prevTarget = cam.targetTexture;
                var prevActive = RenderTexture.active;
                cam.targetTexture = rt;
                cam.Render();
                RenderTexture.active = rt;
                var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
                tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
                tex.Apply();
                cam.targetTexture = prevTarget;
                RenderTexture.active = prevActive;
                UnityEngine.Object.Destroy(rt);
                byte[] bytes = ImageConversion.EncodeToPNG(tex);
                UnityEngine.Object.Destroy(tex);
                if (bytes != null)
                {
                    File.WriteAllBytes(path, bytes);
                    MelonLogger.Msg($"[PLAYTEST SHOT] Saved {path} ({bytes.Length} bytes)");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[PLAYTEST SHOT] Failed {name}: {ex.Message}");
            }
        }

        private static int CountActiveWarTiles()
        {
            var tiles = UnityEngine.Object.FindObjectsOfType<WarTile>();
            int n = 0;
            if (tiles != null)
            {
                for (int i = 0; i < tiles.Length; i++)
                    if (tiles[i] != null && tiles[i].gameObject != null && tiles[i].gameObject.activeInHierarchy) n++;
            }
            return n;
        }

        private static List<WarToken> SnapshotLivingTokens()
        {
            var res = new List<WarToken>();
            var tm = ZilleWarTable.TokenMgr() ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            var list = tm != null ? tm.instantiatedWarTokens : null;
            if (list == null) return res;
            for (int i = 0; i < list.Count; i++)
            {
                var t = list[i];
                if (t != null && t.Pointer != IntPtr.Zero && t.gameObject != null && t.gameObject.activeInHierarchy && !t.IsDead())
                    res.Add(t);
            }
            return res;
        }

        private static void LogUnitTotals(string tag)
        {
            int toras = 0, azaro = 0, sazon = 0, inf = 0, torasDead = 0;
            try { toras = DialogueLua.GetVariable("RiziaDLC.Army_Unit_Toras_Total").asInt; } catch { }
            try { azaro = DialogueLua.GetVariable("RiziaDLC.Army_Unit_Azaro_Total").asInt; } catch { }
            try { sazon = DialogueLua.GetVariable("RiziaDLC.Army_Unit_Sazon_Total").asInt; } catch { }
            try { inf = DialogueLua.GetVariable("RiziaDLC.Army_Unit_Infantry_Total").asInt; } catch { }
            try { torasDead = DialogueLua.GetVariable("RiziaDLC.Army_Unit_Toras_Dead").asInt; } catch { }
            MelonLogger.Msg($"[PLAYTEST TOTALS] ({tag}) Lua Toras={toras}(dead={torasDead}), Azaro={azaro}, Sazon={sazon}, Inf={inf}");
        }

        private static void AuditUnitCounts()
        {
            string activeSave = "(unknown)";
            try
            {
                var pm = UnityEngine.Object.FindObjectOfType<PersistenceManager>();
                if (pm != null) activeSave = pm.ToString();
            }
            catch { }
            int turnNo = 0;
            try { turnNo = DialogueLua.GetVariable("RiziaDLC.Turn").asInt; } catch { }
            MelonLogger.Msg($"[PLAYTEST UNITS] --- Auditing save='{activeSave}', RiziaDLC.Turn={turnNo}, Lua variables & WarUnitTypeData ---");
            string[] vars = {
                "RiziaDLC.Army_Unit_Infantry_Total", "RiziaDLC.Army_Unit_Infantry_Dead", "RiziaDLC.Army_Unit_Infantry_OnMission",
                "RiziaDLC.Army_Unit_Support_Total", "RiziaDLC.Army_Unit_Tank_Total", "RiziaDLC.Army_Unit_Mountaineer_Total",
                "RiziaDLC.Army_Unit_Militia_Total", "RiziaDLC.Army_Unit_Toras_Total", "RiziaDLC.Army_Unit_Azaro_Total",
                "RiziaDLC.Army_Unit_Sazon_Total", "RiziaDLC.Army_Unit_GoldenGuard_Total", "RiziaDLC.Army_Unit_Mercenary_Total",
                "RiziaDLC.Army_Unit_Paratrooper_Total", "RiziaDLC.Army_Unit_Marine_Total",
                "RiziaDLC.Army_Unit_Ship_Total", "RiziaDLC.Army_Unit_Submarine_Total", "RiziaDLC.Army_Unit_Flagship_Total",
                "RiziaDLC.Army_Unit_Bomber_Total", "RiziaDLC.Army_Unit_Fighter_Total"
            };
            foreach (var v in vars)
            {
                int lv = 0;
                try { lv = DialogueLua.GetVariable(v).asInt; } catch { }
                int lvRaw = 0;
                try
                {
                    var r = Lua.Run($"return Variable[\"{v}\"]");
                    if (r.Equals(default(Lua.Result)) == false) lvRaw = r.asInt;
                }
                catch { }
                MelonLogger.Msg($"[PLAYTEST LUA] {v}: GetVariable={lv}, LuaRun={lvRaw}");
            }

            var all = Resources.FindObjectsOfTypeAll<WarUnitTypeData>();
            if (all != null)
            {
                for (int i = 0; i < all.Length; i++)
                {
                    var u = all[i];
                    if (u == null) continue;
                    if (!ZilleWarTable.IsPlayerUnit(u) && u.unitType != WarUnitTypeData.UnitType.AirUnit) continue;
                    MelonLogger.Msg($"[PLAYTEST UTD] '{u.name}' ({u.UnitName}) align={u.unitAlignment} type={u.unitType} total={u.UnitTotalCount} deployed={u.UnitDeployedCount} dead={u.UnitDeadCount} onMission={u.UnitOnMissionCount}");
                }
            }

            var panel = Panels.Instance?.WarDeploymentPanel ?? UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
            if (panel != null && panel.availableDeploymentUnits != null)
            {
                MelonLogger.Msg($"[PLAYTEST PANEL] WarDeploymentPanel.IsShowing={panel.IsShowing()}, availableDeploymentUnits={panel.availableDeploymentUnits.Count}");
                for (int i = 0; i < panel.availableDeploymentUnits.Count; i++)
                {
                    var u = panel.availableDeploymentUnits[i];
                    if (u != null)
                        MelonLogger.Msg($"[PLAYTEST PANEL]   [{i}] {u.name} ({u.UnitName}): total={u.UnitTotalCount}, deployed={u.UnitDeployedCount}");
                }
            }
        }

        private static void AuditRoadsAndSupplyLines(string tag)
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            var lines = UnityEngine.Object.FindObjectsOfType<TemplateMapLine>();
            int activeLines = 0;
            int badLines = 0;

            var tilePosMap = new Dictionary<string, Vector3>();
            var disabledTilePos = new List<(string name, Vector3 pos)>();
            if (cfg?.Tiles != null)
            {
                foreach (var td in cfg.Tiles)
                {
                    var wt = ZilleWarTable.FindLiveTile(td.TileNumber);
                    if (wt == null) continue;
                    if (td.IsDisabled)
                        disabledTilePos.Add((wt.gameObject.name, wt.transform.position));
                    else
                        tilePosMap[wt.gameObject.name] = wt.transform.position;
                }
            }

            if (lines != null)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    var l = lines[i];
                    if (l == null || l.gameObject == null || !l.gameObject.activeInHierarchy) continue;
                    activeLines++;
                    var sl = l.GetCurrentSupplyLine();
                    if (sl != null && sl.Tiles != null && sl.Tiles.Count >= 2)
                    {
                        var a = sl.Tiles[0];
                        var b = sl.Tiles[1];
                        var tdA = ZilleWarTable.TileDataOf(a);
                        var tdB = ZilleWarTable.TileDataOf(b);
                        if (a == null || b == null || !a.gameObject.activeInHierarchy || !b.gameObject.activeInHierarchy
                            || (tdA != null && tdA.IsDisabled) || (tdB != null && tdB.IsDisabled))
                        {
                            badLines++;
                            MelonLogger.Error($"[PLAYTEST ROADS FAIL] ({tag}) Line '{l.name}' links inactive/disabled tile: {a?.name}(disabled={tdA?.IsDisabled}) -> {b?.name}(disabled={tdB?.IsDisabled})");
                        }
                        else
                        {
                            float dist = Vector3.Distance(a.transform.position, b.transform.position);
                            if (dist > 0.35f)
                            {
                                badLines++;
                                MelonLogger.Error($"[PLAYTEST ROADS FAIL] ({tag}) Line '{l.name}' too long ({dist:F3}): {a.name}@{a.transform.position} -> {b.name}@{b.transform.position}");
                            }
                        }
                    }
                    else
                    {
                        var lrs = l.GetComponentsInChildren<LineRenderer>(true);
                        for (int r = 0; r < lrs.Length; r++)
                        {
                            var lr = lrs[r];
                            if (lr == null || !lr.gameObject.activeInHierarchy || lr.positionCount < 2) continue;
                            Vector3 p0 = lr.GetPosition(0);
                            Vector3 p1 = lr.GetPosition(lr.positionCount - 1);
                            float dist = Vector3.Distance(p0, p1);
                            if (dist > 0.35f)
                            {
                                badLines++;
                                MelonLogger.Error($"[PLAYTEST ROADS FAIL] ({tag}) Unbound LineRenderer '{l.name}' dist={dist:F3} from {p0} to {p1}");
                            }
                        }
                    }
                }
            }

            MelonLogger.Msg($"[PLAYTEST ROADS] ({tag}) active TemplateMapLine={activeLines}, badLines={badLines}, activeTiles={tilePosMap.Count}, disabledTiles={disabledTilePos.Count}");
        }

        private static void AuditStickyStatusEffects(string tag)
        {
            var panel = Panels.Instance?.WarTokenStatusEffectsPanel ?? UnityEngine.Object.FindObjectOfType<WarTokenStatusEffectsPanel>();
            if (panel == null) return;
            var list = panel.instantiatedWarTokenStatusEffects;
            int count = list != null ? list.Count : 0;
            int stickyDead = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var eff = list[i];
                    if (eff == null || eff.gameObject == null) { stickyDead++; continue; }
                    var tok = eff.currentWarToken;
                    bool bad = tok == null || tok.Pointer == IntPtr.Zero || tok.gameObject == null || !tok.gameObject.activeInHierarchy || tok.IsDead();
                    if (bad)
                    {
                        stickyDead++;
                        MelonLogger.Error($"[PLAYTEST STICKY FAIL] ({tag}) Sticky status effect icon left on screen for dead/null token! eff={eff.name}, tok={tok?.name}");
                    }
                }
            }
            MelonLogger.Msg($"[PLAYTEST STATUS] ({tag}) statusEffectIcons={count}, stickyDead={stickyDead}");
        }

        private static void AuditHudAndTurnState(string tag)
        {
            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            var hud = Panels.Instance?.WarHUDPanel ?? UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
            var turnPanel = Panels.Instance?.WarTurnPanel ?? UnityEngine.Object.FindObjectOfType<WarTurnPanel>();
            string title = turnPanel?.titleText != null ? turnPanel.titleText.text : "null";
            string hudState = hud != null ? $"active={hud.gameObject.activeInHierarchy}, showing={hud.isShowing}, interactable={hud.IsInteractable()}, curState={hud.currentState}, btnText='{hud.buttonText?.text}'" : "null";
            MelonLogger.Msg($"[PLAYTEST HUD] ({tag}) turn={flow?.GetCurrentWarTurn()}, AP={flow?.GetCurrentActionPoints()}, warState={flow?.GetWarState()}, enemyMoving={flow?.IsDisplayingEnemyMoves()}, title='{title}', HUD=[{hudState}]");
        }

        public static IEnumerator RunFullSuiteCoroutine()
        {
            MelonLogger.Msg("=================================================");
            MelonLogger.Msg("[PLAYTEST] Starting comprehensive Zille playtest suite!");
            MelonLogger.Msg("=================================================");

            // 1. Wait for Main Menu & load latest save
            while (true)
            {
                var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                if (sc != null && string.Equals(sc.name, "Main Menu", StringComparison.OrdinalIgnoreCase))
                    break;
                if (sc != null && string.Equals(sc.name, "Rizia", StringComparison.OrdinalIgnoreCase))
                    break;
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(2.0f);

            var curSc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if (string.Equals(curSc.name, "Main Menu", StringComparison.OrdinalIgnoreCase))
            {
                MelonLogger.Msg("[PLAYTEST] Main Menu active -> clicking Continue...");
                float w = 0f;
                while (w < 40f)
                {
                    var sc = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                    if (sc != null && !string.Equals(sc.name, "Main Menu", StringComparison.OrdinalIgnoreCase) && !string.Equals(sc.name, "Initialize", StringComparison.OrdinalIgnoreCase))
                        break;
                    var mm = UnityEngine.Object.FindObjectOfType<MainMenuPanel>();
                    if (mm != null)
                    {
                        try { mm.OnContinueClick(); } catch (Exception ex) { MelonLogger.Warning("[PLAYTEST] OnContinueClick: " + ex.Message); }
                    }
                    yield return new WaitForSeconds(2.0f);
                    w += 2.0f;
                }
                yield return new WaitForSeconds(3.0f);
            }

            // 2. On Rizia civilian map: spawn Zille event token, CLICK IT, then click Operation button to enter map!
            MelonLogger.Msg("[PLAYTEST] Step 1: Spawning Zille war event token on civilian map...");
            bool spawned = WarOperationZilleManager.SpawnZilleWarEventToken();
            yield return new WaitForSeconds(1.0f);

            var zilleGo = WarOperationZilleManager.SpawnedZilleWarToken ?? GameObject.Find("InvasionOfZille Event Variant");
            var zilleTok = zilleGo != null ? zilleGo.GetComponent<Token>() : null;
            MelonLogger.Msg($"[PLAYTEST] Zille event token: spawned={spawned}, go={zilleGo != null}, tok={zilleTok != null}, active={zilleGo?.activeInHierarchy}");

            if (zilleTok != null)
            {
                var tm = Managers.Instance?.TokenManager ?? UnityEngine.Object.FindObjectOfType<TokenManager>();
                if (tm != null) tm.SelectToken(zilleTok);
                var tip = Panels.Instance?.TokenInteractionPanel ?? UnityEngine.Object.FindObjectOfType<TokenInteractionPanel>();
                if (tip != null)
                {
                    tip.gameObject.SetActive(true);
                    tip.Setup(zilleTok);
                    tip.Show();
                }
                yield return new WaitForSeconds(0.8f);
                SaveShot("pt_01_civilian_event_panel.png");
                yield return new WaitForSeconds(0.3f);

                bool clickedOpBtn = false;
                if (tip != null && tip.instantiatedInteractionButtons != null)
                {
                    for (int i = 0; i < tip.instantiatedInteractionButtons.Count; i++)
                    {
                        var btn = tip.instantiatedInteractionButtons[i];
                        if (btn == null || !btn.gameObject.activeInHierarchy) continue;
                        string btxt = btn.titleText != null ? btn.titleText.text : "";
                        MelonLogger.Msg($"[PLAYTEST] Found TokenInteractionButton: '{btxt}'");
                        if (btxt.Contains("Operation") || btxt.Contains("Righteous Sword") || btxt.Contains("Zille"))
                        {
                            MelonLogger.Msg($"[PLAYTEST] Clicking Zille event button '{btxt}'...");
                            btn.button.onClick.Invoke();
                            clickedOpBtn = true;
                            break;
                        }
                    }
                }
                if (!clickedOpBtn)
                {
                    MelonLogger.Error("[PLAYTEST FAIL] Could not find Zille operation button on TokenInteractionPanel! Fallback entering theatre.");
                    WarOperationZilleManager.EnterZilleWarTheatre();
                }
            }
            else
            {
                MelonLogger.Error("[PLAYTEST FAIL] Zille event token not found!");
                WarOperationZilleManager.EnterZilleWarTheatre();
            }

            yield return new WaitForSeconds(4.0f);
            if (!ZilleWarTable.HasLiveMap)
            {
                MelonLogger.Error("[PLAYTEST FAIL] Zille War Theatre did not open after clicking event button!");
                yield break;
            }
            SaveShot("pt_02_war_theatre_opened.png");
            yield return new WaitForSeconds(0.3f);

            // 3. Audit Unit Counts on open
            AuditUnitCounts();

            // 4. Test all 5 Operation Variants (Ark, Sword, Ark (D), Repay (D), Repay)
            ZilleOperationVariant[] variants = {
                ZilleOperationVariant.PlanArk,
                ZilleOperationVariant.PlanSword,
                ZilleOperationVariant.PlanArkDerdia,
                ZilleOperationVariant.TotalRepaymentDerdia,
                ZilleOperationVariant.TotalRepaymentNoDerdia
            };
            foreach (var v in variants)
            {
                MelonLogger.Msg($"[PLAYTEST VARIANT] Switching to {v}...");
                ZilleCampaignState.SetOperationVariant(v);
                yield return new WaitForSeconds(1.2f);
                int actTiles = CountActiveWarTiles();
                int tokensCount = SnapshotLivingTokens().Count;
                MelonLogger.Msg($"[PLAYTEST VARIANT] {v}: activeWarTiles={actTiles}, livingTokens={tokensCount}");
                AuditRoadsAndSupplyLines(v.ToString());
                SaveShot($"pt_03_variant_{v}.png");
                yield return new WaitForSeconds(0.3f);
            }

            // 5. Switch back to PlanSword (Phase 1) and run a full 3-turn campaign test!
            MelonLogger.Msg("[PLAYTEST] === SCENARIO A: PlanSword (3 turns) ===");
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1;
            ZilleCampaignState.CurrentPhaseNumber = 1;
            ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanSword);
            yield return new WaitForSeconds(1.2f);
            AuditRoadsAndSupplyLines("PlanSword_Ready");

            // Deploy player units via WarDeploymentPanel onto valid Rizian frontline/border tiles
            yield return DeployAvailablePlayerUnitsCoroutine();
            LogUnitTotals("Sword_AfterDeploy");
            SaveShot("pt_04_sword_deployed.png");
            yield return new WaitForSeconds(0.3f);

            // Click Operation Start (via WarHUDPanel if possible, else StartScenario)
            var hudStart = Panels.Instance?.WarHUDPanel ?? UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
            if (hudStart != null && hudStart.isShowing)
            {
                MelonLogger.Msg($"[PLAYTEST] Clicking WarHUDPanel.OnButtonClick() (state={hudStart.currentState})...");
                hudStart.OnButtonClick();
            }
            if (!ZilleWarTable.ScenarioStarted)
            {
                MelonLogger.Warning("[PLAYTEST WARN] WarHUDPanel.OnButtonClick() did not start scenario; calling StartScenario().");
                ZilleWarTable.StartScenario();
            }
            yield return new WaitForSeconds(2.0f);
            LogUnitTotals("Sword_AfterStart");
            AuditHudAndTurnState("Sword_AfterStart");

            // Play 3 full turns in PlanSword
            yield return PlayTurnsCoroutine("Sword", 3, testNoRetreatKill: true);
            LogUnitTotals("Sword_After3Turns");
            SaveShot("pt_05_sword_after3turns.png");

            // 6. Test Phase 2: Repay (D) (TotalRepaymentDerdia) from civilian return or re-entry
            MelonLogger.Msg("[PLAYTEST] === SCENARIO B: TotalRepaymentDerdia / Repay (D) (3 turns) ===");
            ZilleWarTable.SavePhaseBoardState();
            WarOperationZilleManager.ReturnToCivilianMap();
            LogUnitTotals("After_Sword_ReturnToCivilian");
            yield return new WaitForSeconds(2.5f);
            ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.TotalRepaymentDerdia);
            WarOperationZilleManager.EnterZilleWarTheatre();
            yield return new WaitForSeconds(4.0f);
            LogUnitTotals("RepayD_AfterEnter");
            AuditRoadsAndSupplyLines("RepayD_Enter");
            AuditHudAndTurnState("RepayD_Enter");
            SaveShot("pt_06_repayD_enter.png");
            yield return PlayTurnsCoroutine("RepayD", 3, testNoRetreatKill: false);
            LogUnitTotals("RepayD_After3Turns");
            SaveShot("pt_07_repayD_after3turns.png");

            // 7. Test PlanArk (3 turns)
            MelonLogger.Msg("[PLAYTEST] === SCENARIO C: PlanArk (3 turns) ===");
            WarOperationZilleManager.ReturnToCivilianMap();
            LogUnitTotals("After_RepayD_ReturnToCivilian");
            yield return new WaitForSeconds(2.5f);
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1;
            ZilleCampaignState.CurrentPhaseNumber = 1;
            ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanArk);
            WarOperationZilleManager.EnterZilleWarTheatre();
            yield return new WaitForSeconds(4.0f);
            AuditRoadsAndSupplyLines("Ark_Enter");
            yield return DeployAvailablePlayerUnitsCoroutine();
            var hudArk = Panels.Instance?.WarHUDPanel ?? UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
            if (hudArk != null) hudArk.OnButtonClick();
            yield return new WaitForSeconds(2.0f);
            AuditHudAndTurnState("Ark_AfterStart");
            yield return PlayTurnsCoroutine("Ark", 3, testNoRetreatKill: false);
            SaveShot("pt_08_ark_after3turns.png");

            // 8. Test Ark (D) & Repay (No Derdia) (2 turns each)
            MelonLogger.Msg("[PLAYTEST] === SCENARIO D: PlanArkDerdia (2 turns) ===");
            WarOperationZilleManager.ReturnToCivilianMap();
            yield return new WaitForSeconds(2.5f);
            ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase1;
            ZilleCampaignState.CurrentPhaseNumber = 1;
            ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanArkDerdia);
            WarOperationZilleManager.EnterZilleWarTheatre();
            yield return new WaitForSeconds(4.0f);
            AuditRoadsAndSupplyLines("ArkD_Enter");
            yield return DeployAvailablePlayerUnitsCoroutine();
            var hudArkD = Panels.Instance?.WarHUDPanel ?? UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
            if (hudArkD != null) hudArkD.OnButtonClick();
            yield return new WaitForSeconds(2.0f);
            yield return PlayTurnsCoroutine("ArkD", 1, testNoRetreatKill: false);

            MelonLogger.Msg("[PLAYTEST] === SCENARIO E: TotalRepaymentNoDerdia Phase 2 (1 turn) ===");
            ZilleWarTable.SavePhaseBoardState();
            WarOperationZilleManager.ReturnToCivilianMap();
            yield return new WaitForSeconds(2.5f);
            ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.TotalRepaymentNoDerdia);
            WarOperationZilleManager.EnterZilleWarTheatre();
            yield return new WaitForSeconds(4.0f);
            AuditRoadsAndSupplyLines("RepayNoD_Enter");
            AuditHudAndTurnState("RepayNoD_Enter");
            yield return PlayTurnsCoroutine("RepayNoD", 1, testNoRetreatKill: false);

            // Clean return to civilian map at end
            WarOperationZilleManager.ReturnToCivilianMap();
            yield return new WaitForSeconds(2.0f);

            MelonLogger.Msg("=================================================");
            MelonLogger.Msg("[PLAYTEST DONE] Full multi-scenario 3-turn suite completed!");
            MelonLogger.Msg("=================================================");
        }

        private static IEnumerator DeployAvailablePlayerUnitsCoroutine()
        {
            var panel = Panels.Instance?.WarDeploymentPanel ?? UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (panel == null || cfg?.Tiles == null) yield break;

            var avail = panel.availableDeploymentUnits;
            if (avail == null) yield break;

            // Collect valid Rizian land border/interior tiles and naval start tiles
            var landTiles = new List<WarTile>();
            var seaTiles = new List<WarTile>();
            foreach (var td in cfg.Tiles)
            {
                if (td == null || td.IsDisabled || td.IsCity || td.IsImpassable) continue;
                var wt = ZilleWarTable.FindLiveTile(td.TileNumber);
                if (wt == null || wt.GetCurrentToken() != null) continue;
                if (td.IsSea && td.IsNavalStart) seaTiles.Add(wt);
                else if (!td.IsSea && td.Allegiance == "Rizia")
                {
                    if (td.IsBorder) landTiles.Insert(0, wt);
                    else landTiles.Add(wt);
                }
            }

            int li = 0, si = 0, deployedTotal = 0;
            for (int u = 0; u < avail.Count; u++)
            {
                var ut = avail[u];
                if (ut == null) continue;
                int remain = Math.Max(0, ut.UnitTotalCount);
                for (int k = 0; k < remain; k++)
                {
                    WarTile target = null;
                    if (ut.unitType == WarUnitTypeData.UnitType.NavalUnit)
                    {
                        while (si < seaTiles.Count && seaTiles[si].GetCurrentToken() != null) si++;
                        if (si < seaTiles.Count) target = seaTiles[si++];
                    }
                    else
                    {
                        while (li < landTiles.Count && landTiles[li].GetCurrentToken() != null) li++;
                        if (li < landTiles.Count) target = landTiles[li++];
                    }
                    if (target == null) break;

                    bool wasReinf = target.IsReinforcementTile();
                    target.SetIsReinforcementTile(true);
                    ZilleWarTable.RunScripted(() => panel.DeployToken(ut, target));
                    target.SetIsReinforcementTile(wasReinf);
                    deployedTotal++;
                    yield return null;
                }
            }
            try { panel.UpdateDeployingUnitCount(); } catch { }
            MelonLogger.Msg($"[PLAYTEST DEPLOY] Deployed {deployedTotal} player units onto board.");
        }

        private static IEnumerator PlayTurnsCoroutine(string label, int numTurns, bool testNoRetreatKill)
        {
            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            var tm = ZilleWarTable.TokenMgr() ?? UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            if (flow == null || tm == null) yield break;

            for (int turnIdx = 1; turnIdx <= numTurns; turnIdx++)
            {
                AuditHudAndTurnState($"{label}_Turn{turnIdx}_Start");
                AuditStickyStatusEffects($"{label}_Turn{turnIdx}_Start");

                var beforeTokens = SnapshotLivingTokens();
                int beforePlayer = 0, beforeEnemy = 0;
                foreach (var t in beforeTokens)
                {
                    if (ZilleWarTable.IsCityToken(t)) continue;
                    if (t.GetTokenAllegiance() == WarToken.WarAllegiance.Player) beforePlayer++;
                    else if (t.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy) beforeEnemy++;
                }
                MelonLogger.Msg($"[PLAYTEST TURN] {label} T{turnIdx} start: playerUnits={beforePlayer}, enemyUnits={beforeEnemy}");

                // Try moving or attacking with up to 2 player units
                int actionsDone = 0;
                for (int i = 0; i < beforeTokens.Count && actionsDone < 2; i++)
                {
                    var tok = beforeTokens[i];
                    if (tok == null || tok.IsDead() || ZilleWarTable.IsCityToken(tok)) continue;
                    if (tok.GetTokenAllegiance() != WarToken.WarAllegiance.Player) continue;
                    if (tok.IsMovementLocked()) continue;
                    var cur = tok.GetCurrentWarTile();
                    if (cur == null || cur.adjacentWarTiles == null) continue;

                    // Prefer an adjacent tile with a non-city enemy or empty passable tile
                    WarTile targetTile = null;
                    for (int a = 0; a < cur.adjacentWarTiles.Count; a++)
                    {
                        var nb = cur.adjacentWarTiles[a];
                        if (nb == null || ZilleWarTable.IsImpassableTile(nb)) continue;
                        var ut = tok.GetWarUnitTypeData();
                        if (ut != null && !ut.CanMoveToTileType(nb.GetTileType())) continue;
                        var occ = nb.GetCurrentToken();
                        if (occ != null && occ.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy && !ZilleWarTable.IsCityToken(occ))
                        {
                            targetTile = nb;
                            break;
                        }
                        if (occ == null && targetTile == null)
                            targetTile = nb;
                    }

                    if (targetTile != null)
                    {
                        var occ = targetTile.GetCurrentToken();
                        if (occ != null && occ.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy)
                        {
                            MelonLogger.Msg($"[PLAYTEST ACTION] {label} T{turnIdx}: {tok.name}@{cur.name} attacking {occ.name}@{targetTile.name}");
                            var bm = ZilleWarTable.BattleMgr();
                            if (bm != null)
                            {
                                try { bm.StartBattle(tok, occ, true); actionsDone++; }
                                catch (Exception ex) { MelonLogger.Warning("[PLAYTEST ACTION] StartBattle: " + ex.Message); }
                            }
                        }
                        else if (occ == null)
                        {
                            MelonLogger.Msg($"[PLAYTEST ACTION] {label} T{turnIdx}: {tok.name}@{cur.name} moving -> {targetTile.name}");
                            try { tok.Move(targetTile, false); flow.SpendActionPoints(1); actionsDone++; }
                            catch (Exception ex) { MelonLogger.Warning("[PLAYTEST ACTION] Move: " + ex.Message); }
                        }
                        yield return new WaitForSeconds(0.8f);
                    }
                }

                // Specifically test depleted-org + kill (no-retreat death) on Turn 1 of Sword
                if (testNoRetreatKill && turnIdx == 1)
                {
                    WarToken victim = null;
                    var nowTokens = SnapshotLivingTokens();
                    for (int i = 0; i < nowTokens.Count; i++)
                    {
                        var t = nowTokens[i];
                        if (t != null && !t.IsDead() && t.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy && !ZilleWarTable.IsCityToken(t))
                        {
                            victim = t;
                            break;
                        }
                    }
                    if (victim != null)
                    {
                        MelonLogger.Msg($"[PLAYTEST DEPLETED TEST] Applying DepletedOrganization then killing {victim.name} (simulating no-retreat death)...");
                        victim.AddTokenStatusEffect(WarToken.WarTokenStatusEffectType.DepletedOrganization);
                        try { Panels.Instance?.WarTokenStatusEffectsPanel?.Add(victim, WarToken.WarTokenStatusEffectType.DepletedOrganization); } catch { }
                        yield return new WaitForSeconds(0.4f);
                        AuditStickyStatusEffects($"{label}_BeforeKill");
                        victim.Kill(true);
                        yield return new WaitForSeconds(0.8f);
                        AuditStickyStatusEffects($"{label}_AfterKill");
                    }
                }

                // End Turn via real WarHUDPanel.OnButtonClick()!
                var hud = Panels.Instance?.WarHUDPanel ?? UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
                int prevTurn = flow.GetCurrentWarTurn();
                MelonLogger.Msg($"[PLAYTEST END TURN] {label} T{turnIdx} (warTurn={prevTurn}): invoking WarHUDPanel.OnButtonClick()...");
                float startEnemyTime = Time.unscaledTime;
                if (hud != null)
                {
                    hud.OnButtonClick();
                }
                else
                {
                    flow.EndWarTurn();
                }

                // Wait for enemy turn to finish & inspect why if it takes > 5s
                float waited = 0f;
                while (waited < 38f)
                {
                    yield return new WaitForSeconds(1.0f);
                    waited += 1.0f;
                    bool disp = flow.IsDisplayingEnemyMoves();
                    bool liveB = ZilleWarTable.AnyLiveBattle();
                    bool moving = ZilleWarTable.IsAnyTokenMoving();
                    bool act = ZilleWarTable.IsEnemyTurnActive();
                    if (!disp && !moving && !act && flow.GetCurrentWarTurn() > prevTurn)
                    {
                        MelonLogger.Msg($"[PLAYTEST END TURN] {label} T{turnIdx} finished cleanly in {waited:F1}s! New warTurn={flow.GetCurrentWarTurn()}, AP={flow.GetCurrentActionPoints()}");
                        break;
                    }
                    if (((int)waited) % 3 == 0)
                    {
                        var bm = ZilleWarTable.BattleMgr();
                        var curB = bm != null ? bm.GetCurrentBattles() : null;
                        int bc = curB != null ? curB.Count : -1;
                        var sb = new StringBuilder();
                        if (moving && tm != null && tm.instantiatedWarTokens != null)
                        {
                            for (int ti = 0; ti < tm.instantiatedWarTokens.Count; ti++)
                            {
                                var tok = tm.instantiatedWarTokens[ti];
                                if (tok != null && !tok.IsDead() && tok.IsMoving())
                                    sb.Append($" mov:{tok.name}@{tok.GetCurrentWarTile()?.name}");
                            }
                        }
                        if (curB != null && curB.Count > 0)
                        {
                            for (int bi = 0; bi < curB.Count; bi++)
                            {
                                var b = curB[bi];
                                if (b != null)
                                    sb.Append($" b{bi}:({b.attacker?.name} vs {b.defender?.name} over={b.isBattleOver})");
                            }
                        }
                        MelonLogger.Msg($"[PLAYTEST WAIT {waited:F0}s] disp={disp} liveB={liveB} moving={moving} act={act} battles={bc} curTurn={flow.GetCurrentWarTurn()}{sb}");
                    }
                }

                yield return new WaitForSeconds(0.5f);
                AuditStickyStatusEffects($"{label}_Turn{turnIdx}_End");
                var afterTokens = SnapshotLivingTokens();
                int afterPlayer = 0, afterEnemy = 0;
                foreach (var t in afterTokens)
                {
                    if (ZilleWarTable.IsCityToken(t)) continue;
                    if (t.GetTokenAllegiance() == WarToken.WarAllegiance.Player) afterPlayer++;
                    else if (t.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy) afterEnemy++;
                }
                MelonLogger.Msg($"[PLAYTEST TURN] {label} T{turnIdx} end: playerUnits={afterPlayer} (was {beforePlayer}), enemyUnits={afterEnemy} (was {beforeEnemy})");
                if (afterPlayer < beforePlayer - 2)
                {
                    MelonLogger.Error($"[PLAYTEST UNIT LOSS ALERT] Player units dropped sharply from {beforePlayer} to {afterPlayer}!");
                }
            }
        }
    }
}
