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

        public static void IsInitialDeploymentTilePostfix(WarTile __instance, ref bool __result)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return;
            __result = ZilleWarTable.IsZilleDeploymentTile(__instance);
        }

        public static bool IsSelectedDeploymentUnitDeployableToTilePrefix(WarTile __instance, ref bool __result)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (ForcedDeploy(__instance))
            {
                __result = true;
                return false;
            }
            return true;
        }

        public static bool CanDeploySelectedUnitToTilePrefix(WarTile targetTile, ref bool __result)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (ForcedDeploy(targetTile))
            {
                __result = true;
                return false;
            }
            return true;
        }

        /// <summary>Ships only on the naval starts. Land units only on Rizian land. A ship must not light up the coast.</summary>
        private static bool ForcedDeploy(WarTile tile)
        {
            if (tile == null) return false;
            if (tile.GetCurrentToken() != null) return false;
            var td = ZilleWarTable.TileDataOf(tile);
            if (td == null) return false;
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : UnityEngine.Object.FindObjectOfType<WarDeploymentPanel>();
                if (panel == null || !panel.IsDeploymentUnitSelected()) return false;
                var unit = panel.GetSelectedUnitTypeData();
                if (unit == null) return false;
                if (unit.unitType == WarUnitTypeData.UnitType.NavalUnit) return td.IsNavalStart;
                if (unit.unitType == WarUnitTypeData.UnitType.LandUnit) return (td.Allegiance == "Rizia" || td.Allegiance == "Derdia") && !td.IsSea && !td.IsCity;
            }
            catch { }
            return false;
        }

        /// <summary>Reinforcement uses the same deploy colours and rules, without the opening frontline requirement.</summary>
        public static void TileActionPostfix(WarTile __instance, ref WarTile.TileActionType __result)
        {
            if (ZilleWarTable.EnemyMayAct())
            {
                __result = WarTile.TileActionType.None;
                return;
            }
            if (ZilleWarTable.IsImpassableTile(__instance))
            {
                __result = WarTile.TileActionType.None;
                return;
            }
            if (ZilleWarTable.IsDeploymentRefund(__instance))
            {
                __result = WarTile.TileActionType.Refund;
                return;
            }
            if ((__result == WarTile.TileActionType.None || __result == WarTile.TileActionType.Select)
                && ZilleWarTable.IsDeploymentTarget(__instance))
            {
                __result = WarTile.TileActionType.Deploy;
                return;
            }
            if (!ZilleWarTable.TurnHasPoints()
                && __result != WarTile.TileActionType.None
                && __result != WarTile.TileActionType.Select
                && __result != WarTile.TileActionType.Refund
                && __result != WarTile.TileActionType.Deploy)
            {
                __result = WarTile.TileActionType.None;
                return;
            }
            if (__result == WarTile.TileActionType.Fortify && !ZilleWarTable.FortifyArmed)
                __result = WarTile.TileActionType.Select;
            if (__result == WarTile.TileActionType.Attack && ZilleWarTable.AllySupportTarget(__instance))
                __result = WarTile.TileActionType.Support;
            if (__result == WarTile.TileActionType.Support && !ZilleWarTable.LiveSupport(__instance))
                __result = ZilleWarTable.CanMoveOnto(__instance) ? WarTile.TileActionType.Move : WarTile.TileActionType.None;
            var sel = ZilleWarTable.SelectedUnit();
            if (sel != null && __instance != null)
            {
                var occ = __instance.GetCurrentToken();
                if (occ != null && occ != sel && ZilleWarTable.CanOverrun(sel, occ))
                {
                    if (ZilleWarTable.CanReachTile(sel, __instance))
                    {
                        __result = WarTile.TileActionType.Overrun;
                        return;
                    }
                }
            }
            if (__result == WarTile.TileActionType.Move && !ZilleWarTable.CanMoveOnto(__instance))
                __result = WarTile.TileActionType.None;
        }

        public static void ArmFortifyPrefix() => ZilleWarTable.ArmFortify();

        public static void ClearFortifyPostfix() => ZilleWarTable.ClearFortify();

        public static bool SelectionShowPrefix() => ZilleWarTable.FortifyArmed;

        /// <summary>Deployment picks units from the side list. An enemy figure is never selectable: selecting the defender cancels the attack.</summary>
        public static bool BlockTokenSelectPrefix(WarToken __instance, bool state)
        {
            if (__instance != null && __instance.animator == null)
            {
                try { __instance.animator = __instance.GetComponentInChildren<UnityEngine.Animator>(); } catch { }
                if (__instance.animator == null)
                {
                    __instance.isSelected = state;
                    return false;
                }
            }
            if (!state) return true;
            if (DeploymentPanelShowing()) return false;
            if (ZilleWarTable.EnemyMayAct()) return false;
            try
            {
                if (__instance != null && __instance.GetTokenAllegiance() != WarToken.WarAllegiance.Player)
                    return false;
            }
            catch { }
            return true;
        }

        public static bool BlockManagerSelectPrefix()
        {
            if (DeploymentPanelShowing()) return false;
            if (ZilleWarTable.EnemyMayAct()) return false;
            return true;
        }

        public static void IsRefundablePostfix(WarToken __instance, ref bool __result)
        {
            if (__result || __instance == null) return;
            WarTile tile = null;
            try { tile = __instance.GetCurrentWarTile(); } catch { return; }
            if (ZilleWarTable.IsDeploymentRefund(tile)) __result = true;
        }

        private static bool DeploymentPanelShowing()
        {
            var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
            return panel != null && panel.IsShowing();
        }

        /// <summary>Block player interactions during enemy turn or while enemy actions are resolving.</summary>
        public static bool BlockUntilHoldPrefix(object __instance)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;

            // Only allow live battles to resolve during enemy phase, block player actions during enemy turn
            if (ZilleWarTable.IsEnemyTurnActive())
            {
                return __instance is WarTile wt && ZilleWarTable.BattleMayResolve(wt);
            }

            if (__instance is WarTile wtCommit)
            {
                var sel = ZilleWarTable.SelectedUnit();
                if (sel != null) ZilleWarTable.RecordCommittedAttackTile(sel, wtCommit);
            }

            return true;
        }

        /// <summary>Pixel-perfect province hover for Zille theatre using baked ID grid.</summary>
        public static bool HoverRaycastPrefix(WarTileRaycaster __instance)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (__instance == null) return true;

            try
            {
                if (ZilleWarTable.EnemyMayAct())
                {
                    if (__instance.raycastedWarTile != null)
                    {
                        try { __instance.raycastedWarTile.OnTileExit(); } catch { }
                        __instance.raycastedWarTile = null;
                    }
                    try { __instance.HideAllHoverPanels(); } catch { }
                    ZilleWarTable.NoteGameHover(null);
                    return false;
                }

                var cam = __instance.mainCamera != null ? __instance.mainCamera : ZilleWarTable.WarCamera();
                var pos = ZilleWarTable.CursorPos();
                var best = ZilleWarTable.GetProvinceAt(cam, pos);

                var previous = __instance.raycastedWarTile;
                if (best != previous)
                {
                    if (previous != null)
                    {
                        try { previous.OnTileExit(); } catch { }
                    }
                    __instance.raycastedWarTile = best;
                    if (best != null)
                    {
                        try { best.OnTileEnter(); } catch { }
                    }
                }

                ZilleWarTable.NoteGameHover(best);

                if (best != null)
                {
                    var token = best.GetCurrentToken();
                    if (token != null)
                    {
                        try { __instance.OnTokenHover(token); } catch { }
                    }
                }
                else
                {
                    try { __instance.HideAllHoverPanels(); } catch { }
                }

                return false;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[Great Zille] HoverRaycastPrefix: " + ex.Message);
                return true;
            }
        }

        public static bool IsBorderTilePrefix(ref bool __result)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
            if (panel == null || !panel.IsShowing()) return true;
            __result = false;
            return false;
        }

        private static bool DeploymentAllows(WarTile tile)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
            return panel != null && panel.IsShowing();
        }

        private static bool IsRiziaLand(WarTile tile)
        {
            var t = TileData(tile);
            return t != null && t.Allegiance == "Rizia" && !t.IsSea && !t.IsCity;
        }

        private static bool IsNavalStart(WarTile tile)
        {
            var t = TileData(tile);
            return t != null && t.IsNavalStart;
        }

        private static ZilleTileData TileData(WarTile tile)
        {
            string name = tile != null && tile.gameObject != null ? tile.gameObject.name : "";
            if (name.StartsWith("Tile_")) name = name.Substring("Tile_".Length);
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg?.Tiles == null) return null;
            for (int i = 0; i < cfg.Tiles.Count; i++)
                if (cfg.Tiles[i].TileNumber == name) return cfg.Tiles[i];
            return null;
        }

        public static void SupplyLineSetupTilesPostfix(WarSupplyLine __instance)
        {
            if (__instance?.tileNames == null || __instance.tileNames.Count < 2) return;
            var list = new Il2CppSystem.Collections.Generic.List<WarTile>();
            for (int i = 0; i < __instance.tileNames.Count; i++)
            {
                var wt = ZilleWarTable.FindLiveTile(__instance.tileNames[i]);
                if (wt != null) list.Add(wt);
            }
            if (list.Count >= 2) __instance.Tiles = list;
        }

        public static void OnInitialDeploymentFinishedPostfix()
        {
            ZilleWarTable.MarkOperationBegun();
        }

        /// <summary>A supply line whose tile list was never built used to throw inside every allegiance change.</summary>
        public static void SetupSupplyLinesPrefix(ref Il2CppSystem.Collections.Generic.List<WarSupplyLine> supplyLines)
        {
            supplyLines = ZilleWarTable.SanitizeSupplyLines(supplyLines);
        }

        /// <summary>EndBattle is the stock end of a fight. Settle it even when the method itself throws before it can clear the prompt.</summary>
        public static Exception EndBattleFinalizer(WarBattleManager.WarBattle __0, Exception __exception)
        {
            try { ZilleWarTable.FinishBattle(__0); }
            catch (Exception ex) { MelonLogger.Warning("[ZTABLE] battle end: " + ex.GetBaseException().Message); }
            return __exception;
        }

        private static int _pointsGrantedForTurn = int.MinValue;

        /// <summary>PlayerTurn is the return from the enemy phase. The phase flag has to be down or the next hold commits nothing.</summary>
        public static void PlayerTurnPostfix(WarFlowManager __instance)
        {
            if (__instance == null) return;
            try
            {
                __instance.isDisplayingEnemyMoves = false;
                int turn = __instance.currentWarTurn;
                int want = Math.Max(3, __instance.ActionPointsPerTurn > 0 ? __instance.ActionPointsPerTurn : 3);
                __instance.currentActionPoints = want;
                var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (mgr != null)
                {
                    mgr.ResetTokenMovements();
                    mgr.ResetPlayerTokens();
                    var tokens = mgr.instantiatedWarTokens;
                    if (tokens != null)
                    {
                        for (int i = 0; i < tokens.Count; i++)
                        {
                            var t = tokens[i];
                            if (t == null || t.IsDead()) continue;
                            if (t.GetTokenAllegiance() == WarToken.WarAllegiance.Player)
                            {
                                if (t.IsMovementLocked())
                                {
                                    t.RemoveTokenStatusEffect(WarToken.WarTokenStatusEffectType.MovementLocked);
                                }
                            }
                        }
                    }
                    mgr.SetAllTokenActions();
                }
                ZilleWarTable.UnlockAllTiles();
                ZilleWarTable.RefreshAllTokenStatusEffects();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] player turn: " + ex.GetBaseException().Message);
            }
        }

        /// <summary>A unit that already moved is locked out of a second move, but it still has to be clickable.</summary>
        public static void IsSelectablePostfix(WarToken __instance, ref bool __result)
        {
            if (ZilleWarTable.IsEnemyTurnActive())
            {
                __result = false;
                return;
            }
            if (__result || __instance == null || !ZilleWarTable.ScenarioStarted) return;
            try
            {
                if (__instance.GetTokenAllegiance() != WarToken.WarAllegiance.Player) return;
                if (__instance.IsDead() || !__instance.IsMovementLocked()) return;
                var tile = __instance.GetCurrentWarTile();
                if (tile != null && (tile.IsLocked() || tile.IsActionLocked())) return;
                var battle = __instance.GetCurrentBattle();
                if (battle != null && !battle.isBattleOver) return;
                __result = true;
            }
            catch { }
        }

        /// <summary>An enemy move has to pan the camera. The arriving unit is the only one the province keeps.</summary>
        public static void MovePostfix(WarToken __instance, WarTile targetTile)
        {
            if (__instance == null || targetTile == null) return;
            try
            {
                if (__instance.IsDead()) return;
                if (__instance.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy)
                    ZilleWarTable.ShowEnemyMove(targetTile);
                var occ = targetTile.GetCurrentToken();
                if (occ == null || occ == __instance || occ.IsDead())
                    targetTile.SetCurrentWarToken(__instance);
                ZilleWarTable.OnUnitMovedToTile(__instance, targetTile);
                ZilleWarTable.RequestBoardRefresh();
            }
            catch { }
        }

        /// <summary>
        /// A defeated unit retreats to an empty passable tile without opposing units.
        /// Priority is given to friendly tiles, but any free adjacent passable tile without enemy units is valid
        /// so units don't die needlessly.
        /// </summary>
        public static void GetBattleLossTilePostfix(WarToken __instance, ref WarTile __result)
        {
            if (__instance == null) return;
            if (!ZilleWarTable.ScenarioStarted && WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille) return;
            try
            {
                var battle = __instance.GetCurrentBattle();
                WarTile atkTile = null;
                if (battle != null && battle.attacker != null)
                {
                    try { atkTile = battle.attacker.GetCurrentWarTile(); } catch { }
                }

                var curTile = __instance.GetCurrentWarTile();
                if (curTile == null) return;
                var adj = curTile.adjacentWarTiles;
                if (adj == null) return;

                var unitAlleg = __instance.GetTokenAllegiance();
                string friendlyAlleg = unitAlleg == WarToken.WarAllegiance.Player ? "Rizia" : "Wehlen";

                var ut = __instance.GetWarUnitTypeData();
                bool isNaval = false;
                try { isNaval = __instance.IsNavalUnit(); } catch { }

                // Check if current candidate is valid
                if (__result != null)
                {
                    bool invalid = false;
                    if (__result == atkTile || __result == curTile) invalid = true;
                    var occ = __result.GetCurrentToken();
                    if (occ != null && occ != __instance && !occ.IsDead()) invalid = true;
                    var tdRes = ZilleWarTable.TileDataOf(__result);
                    if (tdRes == null) invalid = true;
                    else if (isNaval && !tdRes.IsSea) invalid = true;
                    else if (!isNaval && tdRes.IsSea) invalid = true;

                    if (!invalid) return;
                    __result = null;
                }

                WarTile friendlyCandidate = null;
                WarTile neutralOrEnemyCandidate = null;

                for (int i = 0; i < adj.Count; i++)
                {
                    var t = adj[i];
                    if (t == null || t == curTile || t == atkTile) continue;
                    var occ = t.GetCurrentToken();
                    if (occ != null && occ != __instance && !occ.IsDead()) continue;

                    var td = ZilleWarTable.TileDataOf(t);
                    if (td == null) continue;

                    if (isNaval && !td.IsSea) continue;
                    if (!isNaval && td.IsSea) continue;

                    if (ut != null && !ut.CanMoveToTileType(t.GetTileType())) continue;

                    bool isFriendly = false;
                    if (unitAlleg == WarToken.WarAllegiance.Player)
                        isFriendly = td.Allegiance == "Rizia" || t.GetTileAllegiance() == WarToken.WarAllegiance.Player;
                    else
                        isFriendly = td.Allegiance == "Wehlen" || t.GetTileAllegiance() == WarToken.WarAllegiance.Enemy;

                    if (isFriendly)
                    {
                        friendlyCandidate = t;
                        break;
                    }
                    else if (neutralOrEnemyCandidate == null)
                    {
                        neutralOrEnemyCandidate = t;
                    }
                }

                __result = friendlyCandidate ?? neutralOrEnemyCandidate;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR RETREAT] GetBattleLossTilePostfix error: {ex.Message}");
            }
        }

        public static void StartBattlePrefix(WarToken attacker, WarToken defender, bool shouldSpendActionPoints)
        {
            if (defender != null)
            {
                var tile = defender.GetCurrentWarTile();
                if (tile != null)
                {
                    ZilleWarTable.RecordDefenderStartingTile(attacker, defender, tile);
                }
            }
        }

        public static void CreateBattlePostfix(WarToken attacker, WarToken defender, WarBattleManager.WarBattle __result)
        {
            if (__result != null && defender != null)
            {
                var tile = defender.GetCurrentWarTile();
                if (tile != null)
                {
                    ZilleWarTable.RecordBattleContestedTile(__result, attacker, defender, tile);
                }
            }
        }

        public static bool MakeTokensLookAtEachOtherPrefix(WarTokenManager __instance)
        {
            if (__instance == null) return false;
            try
            {
                var tokens = __instance.instantiatedWarTokens;
                if (tokens == null) return false;
                for (int i = 0; i < tokens.Count; i++)
                {
                    var tok = tokens[i];
                    if (tok != null && !tok.IsDead() && tok.gameObject != null && tok.gameObject.activeInHierarchy)
                    {
                        try { tok.LookAtClosestOpponentToken(); } catch { }
                    }
                }
            }
            catch { }
            return false;
        }

        public static void PlayerActionsPanelSetupPostfix(WarPlayerActionsPanel __instance, WarPlayerActionsPanel.WarActionPanelValues actionValues)
        {
            if (__instance == null) return;
            int strikeCd = actionValues.airStrikeCooldown;
            int airCd = actionValues.airSupportCooldown;
            ZilleWarTable.UpdateCooldownDisplay(__instance.bombButtonData, strikeCd);
            ZilleWarTable.UpdateCooldownDisplay(__instance.airSupportButtonData, airCd);
            ZilleWarTable.LockAbility(__instance.bombButtonData, strikeCd <= 0);
            ZilleWarTable.LockAbility(__instance.airSupportButtonData, airCd <= 0);
        }

        public static bool OnWarAirStrikePrefix()
        {
            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow != null && flow.currentAirStrikeCooldown > 0)
            {
                return false;
            }
            return true;
        }

        public static bool OnWarAirSupportPrefix()
        {
            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow != null && flow.currentAirSupportCooldown > 0)
            {
                return false;
            }
            return true;
        }

        public static bool WarTokenHoverPrefix(WarToken __instance, bool state)
        {
            if (__instance == null) return false;
            if (__instance.animator == null)
            {
                try { __instance.animator = __instance.GetComponentInChildren<UnityEngine.Animator>(); } catch { }
                if (__instance.animator == null) return false;
            }
            return true;
        }


        public static bool CanMovePrefix(WarToken __instance, WarTile targetTile, ref bool __result)
        {
            if (__instance != null)
            {
                if (__instance.IsDead() || __instance.IsOrganizationDepleted() || ZilleWarTable.IsOverrun(__instance))
                {
                    __result = false;
                    return false;
                }
            }
            return true;
        }

        public static bool EvaluateActionPrefix(WarToken enemyToken, ref WarToken.TokenAction __result)
        {
            if (enemyToken != null)
            {
                if (enemyToken.IsDead() || enemyToken.IsOrganizationDepleted() || ZilleWarTable.IsOverrun(enemyToken))
                {
                    var noneAction = new WarToken.TokenAction();
                    noneAction.actionType = WarToken.TokenActionType.None;
                    noneAction.tile = enemyToken.GetCurrentWarTile();
                    __result = noneAction;
                    return false;
                }
            }
            return true;
        }

        public static void IsMovementLockedPostfix(WarToken __instance, ref bool __result)
        {
            if (!__result && __instance != null)
            {
                if (__instance.IsOrganizationDepleted() || ZilleWarTable.IsOverrun(__instance))
                    __result = true;
            }
        }

        /// <summary>The Wehlen behaviour executes the action list. Rebuild it from the Zille neighbours first, or every planned move is skipped.</summary>
        public static void EnemyBehaviourPrefix(WarTokenManager __instance)
        {
            try { if (__instance != null) __instance.SetAllTokenActions(); }
            catch (Exception ex) { MelonLogger.Warning("[ZTABLE] enemy actions: " + ex.GetBaseException().Message); }
        }

        /// <summary>
        /// The stock walk InsertRange's a null collection and aborts the line.
        /// A road we built is connected; the manager can instantiate the animated segment.
        /// </summary>
        public static bool SupplyConnectPrefix(ref bool __result)
        {
            __result = true;
            return false;
        }

        public static bool CanFastMoveOnSupplyTilePrefix(ref bool __result)
        {
            __result = false;
            return false;
        }

        /// <summary>
        /// Accurately test if cursor raycast hits inside province boundaries.
        /// BoxCollider hit confirms tile hover cleanly without requiring MeshCollider UV texture sampling.
        /// </summary>
        public static bool IsHoveringPrefix(RaycastHit hit, ref bool __result)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            __result = true;
            return false;
        }

        public static bool EndWarTurnPrefix()
        {
            if (ZilleWarTable.IsEnemyTurnActive())
            {
                MelonLogger.Msg("[ZTABLE] End turn blocked: enemy turn is active.");
                return false;
            }
            return true;
        }

        public static bool OnWarHUDButtonClickPrefix()
        {
            if (ZilleWarTable.IsEnemyTurnActive())
            {
                return false;
            }
            return true;
        }

        public static bool OnWarHUDScriptEndTurnPrefix()
        {
            if (ZilleWarTable.IsEnemyTurnActive())
            {
                return false;
            }
            return true;
        }

        public static void WarTurnPanelSetupPrefix(ref string title, int turn)
        {
            try
            {
                if (!string.IsNullOrEmpty(title))
                {
                    if (title.Contains("Phase 0") || title.Equals("Phase 0", StringComparison.OrdinalIgnoreCase))
                        title = title.Replace("Phase 0", "Phase I");
                    else if (title.Contains("Phase 1") || title.Equals("Phase 1", StringComparison.OrdinalIgnoreCase))
                        title = title.Replace("Phase 1", "Phase I");
                    else if (title.Contains("Phase 2") || title.Equals("Phase 2", StringComparison.OrdinalIgnoreCase))
                        title = title.Replace("Phase 2", "Phase II");
                    else if (title.Contains("Phase 3") || title.Equals("Phase 3", StringComparison.OrdinalIgnoreCase))
                        title = title.Replace("Phase 3", "Phase III");
                }
            }
            catch { }
        }

        public static void WarTurnPanelSetupPostfix(WarTurnPanel __instance)
        {
            try
            {
                if (__instance != null && __instance.titleText != null && __instance.titleText.text != null)
                {
                    string t = __instance.titleText.text;
                    if (t.Contains("Phase 0")) __instance.titleText.text = t.Replace("Phase 0", "Phase I");
                    else if (t.Contains("Phase 1")) __instance.titleText.text = t.Replace("Phase 1", "Phase I");
                }
            }
            catch { }
        }

        public static void ObjectiveIndicatorSetupTokenPostfix(TemplateWarObjectiveIndicator __instance, WarToken cityToken, WarTile warTile)
        {
            UpdateObjectiveIndicatorTitle(__instance, cityToken, warTile);
        }

        public static void ObjectiveIndicatorSetupObjectivePostfix(TemplateWarObjectiveIndicator __instance, WarObjectiveData warObjectiveData, WarTile warTile)
        {
            UpdateObjectiveIndicatorTitle(__instance, null, warTile);
        }

        public static void UpdateObjectiveIndicatorTitle(TemplateWarObjectiveIndicator indicator, WarToken cityToken, WarTile warTile)
        {
            if (indicator == null) return;
            try
            {
                if (warTile == null && cityToken != null)
                    warTile = cityToken.GetCurrentWarTile();

                string cityName = null;
                if (warTile != null)
                {
                    var td = ZilleWarTable.TileDataOf(warTile);
                    if (td != null)
                        cityName = !string.IsNullOrEmpty(td.CityName) ? td.CityName : td.Name;
                }

                if (string.IsNullOrEmpty(cityName) && cityToken != null)
                {
                    try
                    {
                        var ut = cityToken.GetWarUnitTypeData();
                        if (ut != null && !string.IsNullOrEmpty(ut.UnitName) && ut.UnitName != "Arces")
                            cityName = ut.UnitName;
                    }
                    catch { }
                }

                if (string.IsNullOrEmpty(cityName)) cityName = "City";

                bool playerOwned = false;
                if (warTile != null)
                    playerOwned = warTile.GetTileAllegiance() == WarToken.WarAllegiance.Player;
                else if (cityToken != null)
                    playerOwned = cityToken.GetTokenAllegiance() == WarToken.WarAllegiance.Player;

                string verb = playerOwned ? "Defend" : "Capture";
                if (indicator.tooltipTitle != null)
                {
                    indicator.tooltipTitle.text = $"{verb} {cityName}";
                }
                var tmps = indicator.GetComponentsInChildren<Il2CppTMPro.TextMeshProUGUI>(true);
                if (tmps != null)
                {
                    for (int i = 0; i < tmps.Length; i++)
                    {
                        if (tmps[i] != null && tmps[i].text != null && tmps[i].text.Contains("Arces"))
                        {
                            tmps[i].text = tmps[i].text.Replace("Arces", cityName);
                        }
                    }
                }
            }
            catch { }
        }

        public static void BattleSettledStatusEffectsPostfix()
        {
            if (WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Zille && ZilleWarTable.ScenarioStarted)
            {
                ZilleWarTable.RefreshAllTokenStatusEffects();
            }
        }

        public static void TemplateWarTokenCityStatsSetupPostfix(TemplateWarTokenCityStats __instance, WarToken warToken)
        {
            if (__instance == null || warToken == null) return;
            try
            {
                var tile = warToken.GetCurrentWarTile();
                string name = null;
                if (tile != null)
                {
                    var td = ZilleWarTable.TileDataOf(tile);
                    if (td != null) name = !string.IsNullOrEmpty(td.CityName) ? td.CityName : td.Name;
                }
                if (string.IsNullOrEmpty(name))
                {
                    var ut = warToken.GetWarUnitTypeData();
                    if (ut != null && !string.IsNullOrEmpty(ut.UnitName) && ut.UnitName != "Arces")
                        name = ut.UnitName;
                }
                if (!string.IsNullOrEmpty(name) && __instance.cityName != null)
                {
                    __instance.cityName.text = name;
                }
            }
            catch { }
        }

        public static bool FinishOperationCoroutinePrefix(WarFlowManager __instance, ref Il2CppSystem.Collections.IEnumerator __result)
        {
            if (!ZilleWarTable.ScenarioStarted && WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille)
                return true;

            MelonLogger.Msg("[WAR ENGINE] Intercepted FinishOperationCoroutine for Zille! Transitioning to civilian map...");
            MelonCoroutines.Start(FinishZilleOperationCoroutine());
            __result = null;
            return false;
        }

        public static bool EndWarFragmentButtonClickCoroutinePrefix(WarFlowManager __instance, ref Il2CppSystem.Collections.IEnumerator __result)
        {
            if (!ZilleWarTable.ScenarioStarted && WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille)
                return true;

            MelonLogger.Msg("[WAR ENGINE] Intercepted EndWarFragmentButtonClickCoroutine for Zille! Transitioning to civilian map...");
            MelonCoroutines.Start(FinishZilleOperationCoroutine());
            __result = null;
            return false;
        }

        private static System.Collections.IEnumerator FinishZilleOperationCoroutine()
        {
            yield return new WaitForSeconds(0.4f);
            try { Panels.Instance?.ContinueButtonPanel?.Hide(); } catch { }
            ZilleWarTable.CheckCityVictory(true);
            WarOperationZilleManager.ReturnToCivilianMapWithReport();
        }

        public static void ContinueButtonPanelClickPostfix()
        {
            if (!ZilleWarTable.ScenarioStarted && WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille) return;
            try
            {
                MelonLogger.Msg("[WAR ENGINE] Continue clicked in Zille theatre! Transitioning to civilian map...");
                try { Panels.Instance?.ContinueButtonPanel?.Hide(); } catch { }
                ZilleWarTable.CheckCityVictory(true);
                WarOperationZilleManager.ReturnToCivilianMapWithReport();
            }
            catch { }
        }

        public static bool IsCurrentOperationTutorialPrefix(WarOperationManager __instance, ref bool __result)
        {
            try
            {
                var op = __instance != null ? __instance.GetCurrentOperation() : null;
                var data = op != null ? op.GetOperationData() : null;
                __result = data != null && data.OperationProperties != null && data.OperationProperties.IsTutorial;
            }
            catch
            {
                __result = false;
            }
            return false;
        }

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

                var startConvMethod = AccessTools.Method(typeof(DialogueManager), nameof(DialogueManager.StartConversation), new Type[] { typeof(string) });
                if (startConvMethod != null)
                {
                    var prefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(StartConversationPrefix));
                    harmony.Patch(startConvMethod, prefix: new HarmonyMethod(prefix));
                    MelonLogger.Msg("[Great Zille] Successfully hooked DialogueManager.StartConversation!");
                }

                // 2. TokenInteractionPanel.Setup (Native Action Button Injection)
                var panelSetupMethod = AccessTools.Method(
                    typeof(TokenInteractionPanel),
                    nameof(TokenInteractionPanel.Setup),
                    new Type[] { typeof(Token) }
                );

                var deployFlag = AccessTools.Method(typeof(WarTile), nameof(WarTile.IsInitialDeploymentTile));
                if (deployFlag != null)
                {
                    var post = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsInitialDeploymentTilePostfix));
                    harmony.Patch(deployFlag, postfix: new HarmonyMethod(post));
                    MelonLogger.Msg("[Great Zille] Rizian provinces stay deployable from the side menu.");
                }
                var selectedFlag = AccessTools.Method(typeof(WarTile), nameof(WarTile.IsSelectedDeploymentUnitDeployableToTile));
                if (selectedFlag != null)
                {
                    var pre = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsSelectedDeploymentUnitDeployableToTilePrefix));
                    harmony.Patch(selectedFlag, prefix: new HarmonyMethod(pre));
                }
                var canDeploy = AccessTools.Method(typeof(WarFlowManager), "CanDeploySelectedUnitToTile");
                if (canDeploy != null)
                {
                    var pre = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CanDeploySelectedUnitToTilePrefix));
                    harmony.Patch(canDeploy, prefix: new HarmonyMethod(pre));
                    MelonLogger.Msg("[Great Zille] Hooked WarFlowManager.CanDeploySelectedUnitToTile for Zille deployment.");
                }

                var connect = AccessTools.Method(typeof(WarSupplyLineManager), "IsTileConnectedToSupplySource");
                if (connect != null)
                {
                    harmony.Patch(connect, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(SupplyConnectPrefix))));
                    MelonLogger.Msg("[Great Zille] Supply lines get a list before the connection walk.");
                }

                var fastMove = AccessTools.Method(typeof(WarToken), "CanFastMoveOnSupplyTile");
                if (fastMove != null)
                {
                    var fastPrefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CanFastMoveOnSupplyTilePrefix));
                    harmony.Patch(fastMove, prefix: new HarmonyMethod(fastPrefix));
                    MelonLogger.Msg("[Great Zille] Supply-line check no longer aborts deployment.");
                }

                var action = AccessTools.Method(typeof(WarTile), nameof(WarTile.GetTileActionType));
                if (action != null)
                {
                    var actionPost = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(TileActionPostfix));
                    harmony.Patch(action, postfix: new HarmonyMethod(actionPost));
                    MelonLogger.Msg("[Great Zille] Move and fortify prompts follow the real action.");
                }
                var armFortify = AccessTools.Method(typeof(WarPlayerActionsPanel), nameof(WarPlayerActionsPanel.OnWarFortify));
                if (armFortify != null)
                    harmony.Patch(armFortify, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(ArmFortifyPrefix))));
                foreach (var name in new[] { "OnWarAirStrike", "OnWarAirSupport", "OnWarParatrooper", "OnWarNavalInvasion" })
                {
                    var other = AccessTools.Method(typeof(WarPlayerActionsPanel), name);
                    if (other != null)
                    {
                        harmony.Patch(other, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(ClearFortifyPostfix))));
                        if (name == "OnWarAirStrike")
                            harmony.Patch(other, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(OnWarAirStrikePrefix))));
                        else if (name == "OnWarAirSupport")
                            harmony.Patch(other, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(OnWarAirSupportPrefix))));
                    }
                }
                var tokenHover = AccessTools.Method(typeof(WarToken), nameof(WarToken.Hover));
                if (tokenHover != null)
                    harmony.Patch(tokenHover, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTokenHoverPrefix))));
                var hover = AccessTools.Method(typeof(WarTileRaycaster), "HoverRaycast");
                if (hover != null)
                {
                    harmony.Patch(hover, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(HoverRaycastPrefix))));
                    MelonLogger.Msg("[Great Zille] Hooked WarTileRaycaster.HoverRaycast (pixel-perfect ID grid).");
                }
                var block = new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(BlockUntilHoldPrefix)));
                foreach (var gate in new[]
                {
                    AccessTools.Method(typeof(WarTileRaycaster), "OnClickWarTile"),
                    AccessTools.Method(typeof(WarTile), nameof(WarTile.OnTileCommitAction)),
                    AccessTools.Method(typeof(WarDeploymentPanel), "DeployToken"),
                    AccessTools.Method(typeof(WarTokenManager), "DeployToken"),
                    AccessTools.Method(typeof(WarActionHoverPanel), "PerformAction")
                })
                {
                    if (gate != null) harmony.Patch(gate, prefix: block);
                }
                MelonLogger.Msg("[Great Zille] Deploy and move wait until the mouse has been held.");

                var selectionShow = AccessTools.Method(typeof(WarTokenSelectionPanel), nameof(WarTokenSelectionPanel.Show));
                if (selectionShow != null)
                    harmony.Patch(selectionShow, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(SelectionShowPrefix))));
                var tokenSelect = AccessTools.Method(typeof(WarToken), nameof(WarToken.Select));
                if (tokenSelect != null)
                    harmony.Patch(tokenSelect, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(BlockTokenSelectPrefix))));
                var managerSelect = AccessTools.Method(typeof(WarTokenManager), nameof(WarTokenManager.SelectToken));
                if (managerSelect != null)
                    harmony.Patch(managerSelect, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(BlockManagerSelectPrefix))));
                var refundable = AccessTools.Method(typeof(WarToken), nameof(WarToken.IsRefundable));
                if (refundable != null)
                    harmony.Patch(refundable, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsRefundablePostfix))));

                var border = AccessTools.Method(typeof(WarTile), nameof(WarTile.IsBorderTile));
                if (border != null)
                {
                    var borderPrefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsBorderTilePrefix));
                    harmony.Patch(border, prefix: new HarmonyMethod(borderPrefix));
                    MelonLogger.Msg("[Great Zille] Reinforcement deployment does not demand a full frontline.");
                }

                var hovering = AccessTools.Method(typeof(WarTileRaycaster), "IsHovering");
                if (hovering != null)
                {
                    var hoverPrefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsHoveringPrefix));
                    harmony.Patch(hovering, prefix: new HarmonyMethod(hoverPrefix));
                    MelonLogger.Msg("[Great Zille] Province hover uses the tile under the cursor.");
                }

                var setupTiles = AccessTools.Method(typeof(WarSupplyLine), nameof(WarSupplyLine.SetupTiles));
                if (setupTiles != null)
                {
                    var tilesPost = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(SupplyLineSetupTilesPostfix));
                    harmony.Patch(setupTiles, postfix: new HarmonyMethod(tilesPost));
                }

                var begun = AccessTools.Method(typeof(WarFlowManager), nameof(WarFlowManager.OnInitialDeploymentFinished));
                if (begun != null)
                {
                    var begunPost = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(OnInitialDeploymentFinishedPostfix));
                    harmony.Patch(begun, postfix: new HarmonyMethod(begunPost));
                }
                var supplySetup = AccessTools.Method(typeof(WarSupplyLineManager), "SetupSupplyLines");
                if (supplySetup != null)
                    harmony.Patch(supplySetup, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(SetupSupplyLinesPrefix))));
                var endBattle = AccessTools.Method(typeof(WarBattleManager), "EndBattle");
                if (endBattle != null)
                {
                    harmony.Patch(endBattle, finalizer: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(EndBattleFinalizer))),
                                             postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(BattleSettledStatusEffectsPostfix))));
                }
                var startBattle = AccessTools.Method(typeof(WarBattleManager), "StartBattle");
                if (startBattle != null)
                    harmony.Patch(startBattle, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(StartBattlePrefix))));
                var canMove = AccessTools.Method(typeof(WarToken), nameof(WarToken.CanMove));
                if (canMove != null)
                    harmony.Patch(canMove, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CanMovePrefix))));
                var evalAction = AccessTools.Method(typeof(EnemyTokenActionEvaluator), nameof(EnemyTokenActionEvaluator.EvaluateAction));
                if (evalAction != null)
                    harmony.Patch(evalAction, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(EvaluateActionPrefix))));
                var isMoveLocked = AccessTools.Method(typeof(WarToken), nameof(WarToken.IsMovementLocked));
                if (isMoveLocked != null)
                    harmony.Patch(isMoveLocked, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsMovementLockedPostfix))));
                var playerTurn = AccessTools.Method(typeof(WarFlowManager), "PlayerTurn");
                if (playerTurn != null)
                    harmony.Patch(playerTurn, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(PlayerTurnPostfix))));
                var enemyBehaviour = AccessTools.Method(typeof(WarTokenManager), "EnemyTokenBehaviourCoroutine");
                if (enemyBehaviour != null)
                    harmony.Patch(enemyBehaviour, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(EnemyBehaviourPrefix))));
                var selectable = AccessTools.Method(typeof(WarToken), "IsSelectable");
                if (selectable != null)
                    harmony.Patch(selectable, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsSelectablePostfix))));
                var move = AccessTools.Method(typeof(WarToken), "Move");
                if (move != null)
                    harmony.Patch(move, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(MovePostfix))));
                var getBattleLossTile = AccessTools.Method(typeof(WarToken), nameof(WarToken.GetBattleLossTile));
                if (getBattleLossTile != null)
                    harmony.Patch(getBattleLossTile, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(GetBattleLossTilePostfix))));
                var createBattle = AccessTools.Method(typeof(WarBattleManager), "CreateBattle");
                if (createBattle != null)
                    harmony.Patch(createBattle, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CreateBattlePostfix))));
                var makeTokensLook = AccessTools.Method(typeof(WarTokenManager), nameof(WarTokenManager.MakeTokensLookAtEachOther));
                if (makeTokensLook != null)
                    harmony.Patch(makeTokensLook, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(MakeTokensLookAtEachOtherPrefix))));
                var actionsSetup = AccessTools.Method(typeof(WarPlayerActionsPanel), "Setup");
                if (actionsSetup != null)
                    harmony.Patch(actionsSetup, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(PlayerActionsPanelSetupPostfix))));

                // Status effects persistence across all battles (Issue #1)
                var calcBattle = AccessTools.Method(typeof(WarBattleManager), nameof(WarBattleManager.CalculateAndFinalizeBattle));
                if (calcBattle != null)
                    harmony.Patch(calcBattle, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(BattleSettledStatusEffectsPostfix))));
                var removeAllEff = AccessTools.Method(typeof(WarTokenStatusEffectsPanel), nameof(WarTokenStatusEffectsPanel.RemoveAllInstances));
                if (removeAllEff != null)
                    harmony.Patch(removeAllEff, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(BattleSettledStatusEffectsPostfix))));

                // Lock End Turn when enemy is moving or acting (Issue #4)
                var endWarTurn = AccessTools.Method(typeof(WarFlowManager), nameof(WarFlowManager.EndWarTurn));
                if (endWarTurn != null)
                    harmony.Patch(endWarTurn, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(EndWarTurnPrefix))));
                var hudButtonClick = AccessTools.Method(typeof(WarHUDPanel), "OnButtonClick");
                if (hudButtonClick != null)
                    harmony.Patch(hudButtonClick, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(OnWarHUDButtonClickPrefix))));
                var hudEndTurn = AccessTools.Method(typeof(WarHUDPanel), "OnEndTurn");
                if (hudEndTurn != null)
                    harmony.Patch(hudEndTurn, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(OnWarHUDScriptEndTurnPrefix))));

                // Phase 0 -> Phase I (Issue #7)
                var turnPanelSetup = AccessTools.Method(typeof(WarTurnPanel), nameof(WarTurnPanel.Setup), new Type[] { typeof(string), typeof(int) });
                if (turnPanelSetup != null)
                {
                    harmony.Patch(turnPanelSetup, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTurnPanelSetupPrefix))));
                    harmony.Patch(turnPanelSetup, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTurnPanelSetupPostfix))));
                }

                // Objective Indicators: Dynamic city names instead of "Capture Arces" (Issue #5)
                var indSetupToken = AccessTools.Method(typeof(TemplateWarObjectiveIndicator), nameof(TemplateWarObjectiveIndicator.Setup), new Type[] { typeof(WarToken), typeof(WarTile) });
                if (indSetupToken != null)
                    harmony.Patch(indSetupToken, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(ObjectiveIndicatorSetupTokenPostfix))));
                var indSetupObj = AccessTools.Method(typeof(TemplateWarObjectiveIndicator), nameof(TemplateWarObjectiveIndicator.Setup), new Type[] { typeof(WarObjectiveData), typeof(WarTile) });
                if (indSetupObj != null)
                    harmony.Patch(indSetupObj, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(ObjectiveIndicatorSetupObjectivePostfix))));
                var cityStatsSetup = AccessTools.Method(typeof(TemplateWarTokenCityStats), nameof(TemplateWarTokenCityStats.Setup), new Type[] { typeof(WarToken) });
                if (cityStatsSetup != null)
                    harmony.Patch(cityStatsSetup, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(TemplateWarTokenCityStatsSetupPostfix))));

                // Retreat tile fallback (Issue #6)
                var getRetreatTile = AccessTools.Method(typeof(WarToken), nameof(WarToken.GetRetreatTile));
                if (getRetreatTile != null)
                    harmony.Patch(getRetreatTile, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(GetBattleLossTilePostfix))));

                // End of Campaign return to civilian map (Issue #8)
                var finishOp = AccessTools.Method(typeof(WarFlowManager), nameof(WarFlowManager.FinishOperationCoroutine));
                if (finishOp != null)
                    harmony.Patch(finishOp, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(FinishOperationCoroutinePrefix))));
                var endFragBtn = AccessTools.Method(typeof(WarFlowManager), nameof(WarFlowManager.EndWarFragmentButtonClickCoroutine));
                if (endFragBtn != null)
                    harmony.Patch(endFragBtn, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(EndWarFragmentButtonClickCoroutinePrefix))));
                var continueBtnClick = AccessTools.Method(typeof(ContinueButtonPanel), nameof(ContinueButtonPanel.OnContinueButtonClick));
                if (continueBtnClick != null)
                    harmony.Patch(continueBtnClick, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(ContinueButtonPanelClickPostfix))));

                var tutorialMethod = AccessTools.Method(typeof(WarOperationManager), nameof(WarOperationManager.IsCurrentOperationTutorial));
                if (tutorialMethod != null)
                {
                    var tutorialPrefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsCurrentOperationTutorialPrefix));
                    harmony.Patch(tutorialMethod, prefix: new HarmonyMethod(tutorialPrefix));
                    MelonLogger.Msg("[Great Zille] Hooked IsCurrentOperationTutorial so unit placement does not crash.");
                }

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

        public static void WarFlowManagerSetupWarFragmentPrefix(WarFragmentData warFragmentData, WarFlowManager __instance)
        {
            try
            {
                if (warFragmentData != null && warFragmentData.NameInDatabase == "WarFragment_Zille_1_1")
                {
                    MelonLogger.Msg("[WAR ENGINE] Intercepted SetupWarFragment for WarFragment_Zille_1_1! Activating Zille Theatre...");
                    WarOperationZilleManager.CurrentTheatre = ActiveWarTheatre.Zille;
                    WarOperationZilleManager.EnsureWarSave();
                    ZilleMapLayoutManager.EnsureTexturesLoaded();
                    WarOperationZilleManager.RegisterNativeZilleEntities();
                    WarOperationZilleManager.SetupCustomZilleOperation();
                    if (__instance != null)
                    {
                        try
                        {
                            __instance.RegisterToEndWarFragment(new Action(() =>
                            {
                                MelonLogger.Msg("[WAR ENGINE] WarFlowManager EndWarFragment callback fired! Returning to civilian map...");
                                ZilleWarTable.CheckCityVictory(true);
                                WarOperationZilleManager.ReturnToCivilianMapWithReport();
                            }));
                        }
                        catch { }
                    }
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
                ZilleDialogueSystem.InjectAllVanillaConversationPatches();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[WAR DIALOGUE] InjectWarOptionsIntoVanillaConversations: {ex.Message}");
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

                // Case 1: Porte Drazon (Capital Royal War Council Briefing & Event Spawner)
                if (tName.Contains("PorteDrazon") || tName.Contains("Porte Drazon") || entityName.Contains("PorteDrazon"))
                {
                    ZilleEventSpawnerManager.EnsureInitialized();

                    ConversationData cd = null;
                    var convs = EntityDataManager.AllConversationsData;
                    if (convs != null)
                    {
                        for (int i = 0; i < convs.Count; i++)
                        {
                            if (convs[i] != null && convs[i].NameInDatabase == "Turn_Zille_WarBriefing")
                            {
                                cd = convs[i];
                                break;
                            }
                        }
                    }

                    EnsureButtonExists(__instance, "(MODNEW) A royal briefing before the invasion of Zille", "Council Chambers, Palas Rezna", cd, () => {
                        MelonLogger.Msg("[TOKEN PANEL] Starting Royal Briefing conversation from Porte Drazon event button!");
                        WarOperationZilleManager.TriggerZilleWarBriefingConversation();
                    });

                    // Injected spawned events from Spawner
                    var spawned = ZilleEventSpawnerManager.SpawnedInPorteDrazon;
                    if (spawned != null)
                    {
                        for (int i = 0; i < spawned.Count; i++)
                        {
                            var entry = spawned[i];
                            if (entry == null || entry.ConvIdOrName == "Turn_Zille_WarBriefing") continue;

                            string titleText = $"{entry.Tag} {entry.DisplayTitle}";
                            string subText = entry.Subtitle ?? "";
                            var fragData = entry.FragmentData;
                            var localEntry = entry;

                            EnsureButtonExists(__instance, titleText, subText, fragData, () => {
                                MelonLogger.Msg($"[TOKEN PANEL] Starting spawned event '{localEntry.DisplayTitle}' from Porte Drazon!");
                                localEntry.Launch();
                            });
                        }
                    }
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

                    EnsureButtonExists(__instance, "Operation: Righteous Sword - Phase I", "Invasion of Zille", null, () => {
                        MelonLogger.Msg("[TOKEN PANEL] Operation: Righteous Sword opens the Zille war table.");
                        WarOperationZilleManager.EnterZilleWarTheatre();
                    });
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[TOKEN PANEL] Postfix error: {ex.Message}");
            }
        }

        private static readonly HashSet<int> _nativeClickArmed = new HashSet<int>();
        private static readonly List<object> _pinnedActionDelegates = new List<object>();

        private static void EnsureButtonExists(TokenInteractionPanel panel, string title, string subtitle, StoryFragmentData fragmentData, Action onClick, bool keepNativeClick = false)
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
                        if (fragmentData != null) existing.storyFragmentData = fragmentData;
                        WireButton(existing.button, onClick, keepNativeClick);
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
                if (fragmentData != null) tib.storyFragmentData = fragmentData;
                if (tib.titleText != null) tib.titleText.text = title;
                if (tib.subtitleText != null) tib.subtitleText.text = subtitle;
                WireButton(tib.button, onClick, keepNativeClick);

                MakeButtonVisible(tib, panel);

                if (panel.instantiatedInteractionButtons != null)
                {
                    panel.instantiatedInteractionButtons.Add(tib);
                }

                MelonLogger.Msg($"[TOKEN PANEL] Successfully injected visible native action button: '{title}'");
            }
        }

        private static void WireButton(UnityEngine.UI.Button button, Action onClick, bool keepNativeClick)
        {
            if (button == null) return;
            if (!keepNativeClick)
            {
                try { button.onClick?.RemoveAllListeners(); } catch { }
            }
            int id = button.GetInstanceID();
            if (keepNativeClick && !_nativeClickArmed.Add(id)) return;

            UnityEngine.Events.UnityAction action = (UnityEngine.Events.UnityAction)(() => {
                try
                {
                    MelonLogger.Msg($"[TOKEN BUTTON CLICK] Native button clicked (instance ID: {id})! Invoking action...");
                    onClick?.Invoke();
                }
                catch (Exception ex)
                {
                    MelonLogger.Error($"[TOKEN BUTTON CLICK] Error executing onClick: {ex}");
                }
            });
            _pinnedActionDelegates.Add(action);
            button.onClick.AddListener(action);
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

        public static void StartConversationPrefix(string title)
        {
            try
            {
                DialogueOverrideManager.ApplyAllOverrides();
            }
            catch { }
        }

        public static void OnSelectedResponsePrefix(Il2CppSystem.Object sender, SelectedResponseEventArgs e)
        {
            try
            {
                if (e == null || e.DestinationEntry == null) return;

                string script = e.DestinationEntry.userScript ?? "";
                string title = e.DestinationEntry.Title ?? "";
                string menuText = e.DestinationEntry.MenuText ?? "";

                // Check for war initiation via native Royal War Council Briefing or vanilla choice
                if (script.Contains("Zille_War_Alfa") || title.Contains("Choice_Plan_Alpha") || title.Contains("Choice_Alpha") || menuText.Contains("Plan Alpha"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Plan Alpha chosen by player in native dialogue! Will spawn Zille war event token after briefing.");
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = true;
                }
                else if (script.Contains("Zille_War_Beta") || title.Contains("Choice_Plan_Beta") || title.Contains("Choice_Beta") || menuText.Contains("Plan Beta"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Plan Beta chosen by player in native dialogue! Will spawn Zille war event token after briefing.");
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = true;
                }
                else if (script.Contains("Zille_War_Postpone") || title.Contains("Choice_Plan_Postpone") || title.Contains("Choice_Postpone") || menuText.Contains("Postpone") || menuText.Contains("Wstrzymajmy"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Postponing Zille invasion as requested by player.");
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = false;
                }
                else if (title.Contains("Zille_War_Ultimatum") || title.Contains("Zille_Smolak_FaceToFace"))
                {
                    MelonLogger.Msg("[DIPLOMACY] Player threatened Wehlen with military invasion! Activating Zille war pathway.");
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
