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
            var selFort = ZilleWarTable.SelectedUnit();
            if (ZilleWarTable.FortifyArmed && selFort != null && __instance == selFort.GetCurrentWarTile()
                && !selFort.IsDead() && !selFort.IsFortified() && !ZilleWarTable.IsTokenEngagedInBattle(selFort)
                && ZilleWarTable.TurnHasPoints())
            {
                __result = WarTile.TileActionType.Fortify;
                return;
            }
            if (__result == WarTile.TileActionType.Attack && ZilleWarTable.AllySupportTarget(__instance))
                __result = WarTile.TileActionType.Support;
            if (__result == WarTile.TileActionType.Support && !ZilleWarTable.LiveSupport(__instance))
                __result = ZilleWarTable.CanMoveOnto(__instance) ? WarTile.TileActionType.Move : WarTile.TileActionType.None;
            var sel = ZilleWarTable.SelectedUnit();
            if (__instance != null && !ZilleWarTable.IsEnemyTurnActive() && !ZilleWarTable.BattleLive(__instance.GetCurrentBattle()))
            {
                try
                {
                    if (__instance.IsLocked()) __instance.SetLockState(false);
                    if (__instance.IsActionLocked()) __instance.SetActionLockState(false);
                }
                catch { }
            }
            if (sel != null && __instance != null)
            {
                var occ = __instance.GetCurrentToken();
                if (occ != null && occ != sel && !occ.IsDead())
                {
                    if (ZilleWarTable.CanOverrun(sel, occ) && ZilleWarTable.CanReachTile(sel, __instance))
                    {
                        __result = WarTile.TileActionType.Overrun;
                        return;
                    }
                    if (__result == WarTile.TileActionType.None
                        && occ.GetTokenAllegiance() == WarToken.WarAllegiance.Enemy
                        && sel.GetTokenAllegiance() == WarToken.WarAllegiance.Player
                        && !sel.IsMovementLocked() && !sel.IsOrganizationDepleted()
                        && ZilleWarTable.CanReachTile(sel, __instance)
                        && ZilleWarTable.TurnHasPoints())
                    {
                        __result = WarTile.TileActionType.Attack;
                        return;
                    }
                }
            }
            if (__result == WarTile.TileActionType.Move && !ZilleWarTable.CanMoveOnto(__instance))
                __result = WarTile.TileActionType.None;
            else if (__result == WarTile.TileActionType.None
                && sel != null && sel.GetTokenAllegiance() == WarToken.WarAllegiance.Player
                && !sel.IsMovementLocked() && !sel.IsOrganizationDepleted()
                && ZilleWarTable.CanMoveOnto(__instance) && ZilleWarTable.TurnHasPoints())
            {
                __result = WarTile.TileActionType.Move;
            }
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
            if (ZilleWarTable.IsEnemyTurnActive() || ZilleWarTable.IsFlowEnemyMoving())
            {
                return __instance is WarTile wt && ZilleWarTable.BattleMayResolve(wt);
            }

            // If player has 0 action points during active war gameplay and deployment is not open, block actions
            if (ZilleWarTable.ScenarioStarted && !DeploymentPanelShowing())
            {
                var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (flow != null && flow.GetCurrentActionPoints() <= 0)
                {
                    return false;
                }
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

        public static bool ResetTokenMovementsPrefix(WarTokenManager __instance)
        {
            if (__instance == null || __instance.instantiatedWarTokens == null) return false;
            try
            {
                var list = __instance.instantiatedWarTokens;
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    var tok = list[i];
                    if (tok == null || tok.Pointer == IntPtr.Zero || tok.gameObject == null || tok.IsDead())
                    {
                        list.RemoveAt(i);
                    }
                }
            }
            catch { }
            return true;
        }

        /// <summary>PlayerTurn is the return from the enemy phase. The phase flag has to be down or the next hold commits nothing.</summary>
        public static void PlayerTurnPostfix(WarFlowManager __instance)
        {
            if (__instance == null) return;
            try
            {
                ZilleWarTable.OnBeginPlayerHalfTurn();
                __instance.isDisplayingEnemyMoves = false;
                int turn = __instance.currentWarTurn;
                int want = Math.Max(3, __instance.ActionPointsPerTurn > 0 ? __instance.ActionPointsPerTurn : 5);
                __instance.currentActionPoints = want;
                var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (mgr != null && mgr.instantiatedWarTokens != null)
                {
                    var list = mgr.instantiatedWarTokens;
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        var tok = list[i];
                        if (tok == null || tok.Pointer == IntPtr.Zero || tok.gameObject == null || tok.IsDead())
                        {
                            list.RemoveAt(i);
                        }
                    }

                    try { mgr.ResetTokenMovements(); } catch { }
                    // NEVER call ResetPlayerTokens() here as it erases the player's board units!
                    var tokens = mgr.instantiatedWarTokens;
                    if (tokens != null)
                    {
                        for (int i = 0; i < tokens.Count; i++)
                        {
                            var t = tokens[i];
                            if (t == null || t.IsDead()) continue;
                            if (t.GetTokenAllegiance() == WarToken.WarAllegiance.Player)
                            {
                                if (t.IsMovementLocked() && !ZilleWarTable.IsDepletedProtectionActive(t) && !t.IsOrganizationDepleted() && !ZilleWarTable.IsTokenEngagedInBattle(t))
                                {
                                    try { t.RemoveTokenStatusEffect(WarToken.WarTokenStatusEffectType.MovementLocked); } catch { }
                                }
                            }
                        }
                    }
                    try { mgr.SetAllTokenActions(); } catch { }
                }
                ZilleWarTable.UnlockAllTiles();
                ZilleWarTable.RefreshAllTokenStatusEffects();
                ZilleWarTable.RequestBoardRefresh();
                ZilleWarTable.EnsurePlayerActionsPanelVisible();
                var hud = Panels.Instance != null ? Panels.Instance.WarHUDPanel : UnityEngine.Object.FindObjectOfType<WarHUDPanel>();
                if (hud != null && ZilleWarTable.ScenarioStarted)
                {
                    try { hud.SetInteractable(true); } catch { }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] player turn: " + ex.GetBaseException().Message);
            }
        }

        /// <summary>A unit that already moved or has depleted organization is locked out of moving, but it still has to be clickable so the player can fortify it.</summary>
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
                if (__instance.IsDead() || ZilleWarTable.IsCityToken(__instance)) return;
                if (ZilleWarTable.IsTokenEngagedInBattle(__instance)) return;
                if (!__instance.IsMovementLocked() && !__instance.IsOrganizationDepleted()) return;
                var battle = __instance.GetCurrentBattle();
                if (battle != null && !battle.isBattleOver) return;
                __result = true;
            }
            catch { }
        }

        public static void SetFortifyButtonInteractablePrefix(ref bool state, WarToken token)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return;
            if (token == null) return;
            try
            {
                if (token.GetTokenAllegiance() == WarToken.WarAllegiance.Player && !token.IsDead()
                    && !token.IsFortified() && !ZilleWarTable.IsTokenEngagedInBattle(token)
                    && ZilleWarTable.TurnHasPoints())
                {
                    state = true;
                }
            }
            catch { }
        }

        public static void CanFortifyPostfix(WarToken __instance, WarTile targetTile, ref bool __result)
        {
            if (__result || __instance == null) return;
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return;
            try
            {
                if (__instance.GetTokenAllegiance() == WarToken.WarAllegiance.Player && !__instance.IsDead()
                    && !__instance.IsFortified() && !ZilleWarTable.IsTokenEngagedInBattle(__instance)
                    && targetTile == __instance.GetCurrentWarTile() && ZilleWarTable.TurnHasPoints())
                {
                    __result = true;
                }
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
                    ZilleWarTable.ShowEnemyMove(tile);
                }
            }
            else if (attacker != null)
            {
                var tile = attacker.GetCurrentWarTile();
                if (tile != null)
                {
                    ZilleWarTable.ShowEnemyMove(tile);
                }
            }
            ZilleWarTable.RequestBoardRefresh();
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
            ZilleWarTable.SyncBattleMovementLocks();
            ZilleWarTable.RequestBoardRefresh();
        }

        public static void SupportBattleChangedPostfix(WarBattleManager.WarBattle battle)
        {
            ZilleWarTable.SyncBattleMovementLocks();
            ZilleWarTable.SyncBattleStatsUI(battle);
            ZilleWarTable.RequestBoardRefresh();
            if (ZilleWarTable.IsEnemyTurnActive() || ZilleWarTable.IsFlowEnemyMoving())
            {
                ZilleWarTable.FocusBattleCamera(battle);
            }
        }

        public static bool PlayTokenAnimationPrefix(WarToken __instance, WarToken.TokenAnimationType tokenAnimationType, UnityEngine.Events.UnityAction onAnimationEnd)
        {
            if (__instance != null && ZilleWarTable.IsCityToken(__instance))
            {
                if (tokenAnimationType != WarToken.TokenAnimationType.Death && tokenAnimationType != WarToken.TokenAnimationType.Bombed)
                {
                    MelonLogger.Msg($"[ZTABLE] Skipped city animation '{tokenAnimationType}' on {__instance.name}.");
                    try { onAnimationEnd?.Invoke(); } catch { }
                    return false;
                }
            }
            return true;
        }

        public static bool MovePrefix(WarToken __instance, UnityEngine.Events.UnityAction onAnimationEnd)
        {
            if (__instance != null && ZilleWarTable.IsCityToken(__instance))
            {
                try { onAnimationEnd?.Invoke(); } catch { }
                return false;
            }
            return true;
        }

        public static bool SwapPrefix(WarToken __instance, WarToken token)
        {
            if ((__instance != null && ZilleWarTable.IsCityToken(__instance))
                || (token != null && ZilleWarTable.IsCityToken(token)))
            {
                return false;
            }
            return true;
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
                if (__instance.IsDead() || __instance.IsOrganizationDepleted() || ZilleWarTable.IsOverrun(__instance) || ZilleWarTable.IsTokenEngagedInBattle(__instance))
                {
                    __result = false;
                    return false;
                }
                if ((WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Zille || ZilleWarTable.SkinEnabled)
                    && __instance == ZilleWarTable.SelectedUnit()
                    && !__instance.IsMovementLocked()
                    && ZilleWarTable.CanMoveOnto(targetTile))
                {
                    __result = true;
                    return false;
                }
            }
            return true;
        }

        public static bool EvaluateActionPrefix(WarToken enemyToken, ref WarToken.TokenAction __result)
        {
            if (enemyToken != null)
            {
                if (enemyToken.IsDead() || enemyToken.IsOrganizationDepleted() || ZilleWarTable.IsOverrun(enemyToken) || ZilleWarTable.IsTokenEngagedInBattle(enemyToken))
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
            if (!__result && __instance != null && !__instance.IsDead())
            {
                if (__instance.IsOrganizationDepleted() || ZilleWarTable.IsOverrun(__instance) || ZilleWarTable.IsTokenEngagedInBattle(__instance))
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
        public static bool SupplyConnectPrefix(WarSupplyLine supplyLine, WarTile tile, bool isCheckingAllSupplyLines, ref bool __result)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            __result = ZilleWarTable.IsTileConnectedOnSupplyLine(supplyLine, tile, isCheckingAllSupplyLines);
            return false;
        }

        public static bool IsTileConnectedToAnySupplySourcePrefix(WarTile tile, ref bool __result)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            __result = ZilleWarTable.IsTileSuppliedForCurrentAllegiance(tile);
            return false;
        }

        public static bool CanFastMoveOnSupplyTilePrefix(WarToken __instance, WarTile targetTile, ref bool __result)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            __result = ZilleWarTable.CanFastMoveOnRoad(__instance, targetTile);
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

        private static float _lastEndTurnClickTime;

        public static bool EndWarTurnPrefix()
        {
            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow != null && flow.IsDisplayingEnemyMoves())
            {
                MelonLogger.Msg("[ZTABLE] End turn blocked: enemy moves are currently displaying.");
                return false;
            }

            if (flow != null)
            {
                flow.currentActionPoints = 0;
            }
            ZilleWarTable.MarkEnemyTurnStarted();
            ZilleWarTable.OnBeginEnemyHalfTurn();
            return true;
        }

        public static bool OnWarHUDButtonClickPrefix(WarHUDPanel __instance)
        {
            if (!ZilleWarTable.ScenarioStarted && (WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Zille || ZilleWarTable.SkinEnabled))
            {
                // Operation Start button during deployment phase: bypass vanilla frontline border count lock
                MelonLogger.Msg("[ZTABLE] Native Operation Start HUD button clicked -> starting Zille scenario!");
                ZilleWarTable.StartScenario();
                if (__instance != null)
                {
                    try { __instance.Setup(WarHUDPanel.WarHUDButtonState.EndTurn); } catch { }
                    try { __instance.SetInteractable(true); } catch { }
                    try { __instance.Show(); } catch { }
                }
                return false;
            }
            if (!ZilleWarTable.ScenarioStarted)
            {
                return true;
            }

            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow != null && flow.IsDisplayingEnemyMoves())
            {
                return false;
            }

            if (Time.unscaledTime - _lastEndTurnClickTime < 1.0f && _lastEndTurnClickTime > 0f)
            {
                return false;
            }

            _lastEndTurnClickTime = Time.unscaledTime;
            if (flow != null)
            {
                flow.currentActionPoints = 0;
            }
            // Do not set MarkEnemyTurnStarted here — vanilla OnButtonClick calls EndWarTurn() which sets it in EndWarTurnPrefix
            return true;
        }

        public static bool ScreenBorderMovementPrefix()
        {
            if (WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Zille || ZilleWarTable.SkinEnabled)
            {
                if (!Application.isFocused) return false;
                var mp = Input.mousePosition;
                if (mp.x <= 1f && mp.y <= 1f) return false;
            }
            return true;
        }

        public static bool OnWarHUDScriptEndTurnPrefix()
        {
            if (!ZilleWarTable.ScenarioStarted)
            {
                return true;
            }

            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            if (flow != null && flow.IsDisplayingEnemyMoves())
            {
                return false;
            }

            if (flow != null)
            {
                flow.currentActionPoints = 0;
            }
            // Do not set MarkEnemyTurnStarted here — EndWarTurnPrefix sets it when EndWarTurn executes
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

        public static void EvaluateBattleCoroutinePrefix(WarBattleManager.WarBattle battle)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return;
            ZilleWarTable.FocusBattleCamera(battle);
        }

        public static void PlayDamageAnimationsPrefix(WarBattleManager.WarBattleTurnResult battleTurnResult)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return;
            if (battleTurnResult != null && battleTurnResult.battle != null)
            {
                ZilleWarTable.FocusBattleCamera(battleTurnResult.battle);
            }
        }

        public static void CalculateAndFinalizeBattlePrefix(WarBattleManager.WarBattle battle)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return;
            ZilleWarTable.FocusBattleCamera(battle);
        }

        public static void CalculateAndFinalizeBattlePostfix(WarBattleManager __instance, WarBattleManager.WarBattle battle)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return;
            try
            {
                ZilleWarTable.RecordBattleTurnResult(__instance, battle);
                BattleSettledStatusEffectsPostfix();
            }
            catch { }
        }

        public static bool WarTokenAddStatusEffectPrefix(WarToken __instance, WarToken.WarTokenStatusEffectType warTokenStatusEffectType)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (__instance == null || warTokenStatusEffectType != WarToken.WarTokenStatusEffectType.DepletedOrganization) return true;
            if (ZilleWarTable.IsBypassingDepletedGuard) return true;
            try
            {
                if (ZilleWarTable.IsBattleWinner(__instance))
                {
                    MelonLogger.Msg($"[ZTABLE] Blocked erroneous DepletedOrganization on battle winner {__instance.name}.");
                    ZilleWarTable.ClearDepletedStatus(__instance, ensureMinOrg: true);
                    return false;
                }
                ZilleWarTable.RegisterDepletedToken(__instance);
            }
            catch { }
            return true;
        }

        public static bool WarTokenRemoveStatusEffectPrefix(WarToken __instance, WarToken.WarTokenStatusEffectType warTokenStatusEffectType)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (__instance == null) return true;
            if (warTokenStatusEffectType == WarToken.WarTokenStatusEffectType.DepletedOrganization && ZilleWarTable.IsDepletedProtectionActive(__instance)) return false;
            if (warTokenStatusEffectType == WarToken.WarTokenStatusEffectType.MovementLocked && ZilleWarTable.IsTokenEngagedInBattle(__instance)) return false;
            return true;
        }

        public static bool WarTokenRemoveAllStatusEffectsPrefix(WarToken __instance)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (__instance != null && (ZilleWarTable.IsDepletedProtectionActive(__instance) || ZilleWarTable.IsTokenEngagedInBattle(__instance))) return false;
            return true;
        }

        public static bool WarTokenHealDamagePrefix(WarToken __instance)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (__instance != null && ZilleWarTable.IsDepletedProtectionActive(__instance)) return false;
            return true;
        }

        public static bool StatusEffectsPanelRemovePrefix(WarToken warToken, WarToken.WarTokenStatusEffectType warTokenStatusEffectType)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (warToken != null && warTokenStatusEffectType == WarToken.WarTokenStatusEffectType.DepletedOrganization
                && ZilleWarTable.IsDepletedProtectionActive(warToken))
            {
                return false;
            }
            if (warToken != null && warTokenStatusEffectType == WarToken.WarTokenStatusEffectType.MovementLocked
                && ZilleWarTable.IsTokenEngagedInBattle(warToken))
            {
                return false;
            }
            return true;
        }

        public static void BattleSettledStatusEffectsPostfix()
        {
            if (WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Zille && ZilleWarTable.ScenarioStarted)
            {
                ZilleWarTable.CleanupDeadStatusEffectIcons();
                ZilleWarTable.SyncBattleMovementLocks();
                ZilleWarTable.SyncBattleStatsUI();
                ZilleWarTable.RefreshAllTokenStatusEffects();
                ZilleWarTable.RequestBoardRefresh();
            }
        }

        public static void MapManagerLoadMapPrefix()
        {
            ZilleWarTable.CleanupAllWarUIAndMarkers();
        }

        public static void WarTokenKillPrefix(WarToken __instance, out ZilleWarTable.UnitLedgerSnapshot __state)
        {
            __state = default;
            if (__instance == null) return;
            try
            {
                if (WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Zille || ZilleWarTable.SkinEnabled)
                {
                    __state = ZilleWarTable.CaptureEnemyLedger(__instance.GetWarUnitTypeData(), __instance.GetTokenAllegiance());
                    var panel = Panels.Instance != null ? Panels.Instance.WarTokenStatusEffectsPanel : null;
                    if (panel != null) panel.RemoveAllForToken(__instance);
                }
            }
            catch { }
        }

        public static void WarTokenKillPostfix(WarToken __instance, ZilleWarTable.UnitLedgerSnapshot __state)
        {
            try
            {
                ZilleWarTable.RestoreEnemyLedger(__state);
                if (WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Zille || ZilleWarTable.SkinEnabled)
                {
                    ZilleWarTable.CleanupDeadStatusEffectIcons(__instance);
                }
            }
            catch { }
        }

        public static void DestroyTokenPrefix(WarToken token, out ZilleWarTable.UnitLedgerSnapshot __state)
        {
            __state = default;
            if (token == null) return;
            try
            {
                if (WarOperationZilleManager.CurrentTheatre == ActiveWarTheatre.Zille || ZilleWarTable.SkinEnabled)
                {
                    __state = ZilleWarTable.CaptureEnemyLedger(token.GetWarUnitTypeData(), token.GetTokenAllegiance());
                    var panel = Panels.Instance != null ? Panels.Instance.WarTokenStatusEffectsPanel : null;
                    if (panel != null) panel.RemoveAllForToken(token);
                    ZilleWarTable.CleanupDeadStatusEffectIcons(token);
                }
            }
            catch { }
        }

        public static void DestroyTokenPostfix(ZilleWarTable.UnitLedgerSnapshot __state)
        {
            ZilleWarTable.RestoreEnemyLedger(__state);
        }

        public static void DeployTokenLedgerPrefix(WarUnitTypeData warUnitTypeData, WarToken.WarAllegiance allegiance, out ZilleWarTable.UnitLedgerSnapshot __state)
        {
            __state = ZilleWarTable.CaptureEnemyLedger(warUnitTypeData, allegiance);
        }

        public static void DeployTokenLedgerPostfix(ZilleWarTable.UnitLedgerSnapshot __state)
        {
            ZilleWarTable.RestoreEnemyLedger(__state);
        }

        public static void CreateWarTokenLedgerPrefix(WarTokenData warTokenData, out ZilleWarTable.UnitLedgerSnapshot __state)
        {
            __state = warTokenData != null
                ? ZilleWarTable.CaptureEnemyLedger(warTokenData.unitType, warTokenData.allegiance)
                : default;
        }

        public static void CreateWarTokenLedgerPostfix(ZilleWarTable.UnitLedgerSnapshot __state)
        {
            ZilleWarTable.RestoreEnemyLedger(__state);
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
                    var postfix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(OnSelectedResponsePostfix));
                    harmony.Patch(onSelectedMethod, prefix: new HarmonyMethod(prefix), postfix: new HarmonyMethod(postfix));
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
                    MelonLogger.Msg("[Great Zille] Supply lines use live Zille graph connectivity.");
                }
                var connectAny = AccessTools.Method(typeof(WarSupplyLineManager), "IsTileConnectedToAnySupplySource");
                if (connectAny != null)
                {
                    harmony.Patch(connectAny, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsTileConnectedToAnySupplySourcePrefix))));
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
                var setFortifyBtn = AccessTools.Method(typeof(WarPlayerActionsPanel), nameof(WarPlayerActionsPanel.SetFortifyButtonInteractable));
                if (setFortifyBtn != null)
                    harmony.Patch(setFortifyBtn, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(SetFortifyButtonInteractablePrefix))));
                var canFortify = AccessTools.Method(typeof(WarToken), "CanFortify");
                if (canFortify != null)
                    harmony.Patch(canFortify, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CanFortifyPostfix))));
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
                var resetTokens = AccessTools.Method(typeof(WarTokenManager), nameof(WarTokenManager.ResetTokenMovements));
                if (resetTokens != null)
                {
                    harmony.Patch(resetTokens, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(ResetTokenMovementsPrefix))));
                    MelonLogger.Msg("[Great Zille] Protected WarTokenManager.ResetTokenMovements from null/dead tokens.");
                }
                var enemyBehaviour = AccessTools.Method(typeof(WarTokenManager), "EnemyTokenBehaviourCoroutine");
                if (enemyBehaviour != null)
                    harmony.Patch(enemyBehaviour, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(EnemyBehaviourPrefix))));
                var selectable = AccessTools.Method(typeof(WarToken), "IsSelectable");
                if (selectable != null)
                    harmony.Patch(selectable, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsSelectablePostfix))));
                var move = AccessTools.Method(typeof(WarToken), "Move");
                if (move != null)
                {
                    harmony.Patch(move,
                        prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(MovePrefix))),
                        postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(MovePostfix))));
                }
                var playAnim = AccessTools.Method(typeof(WarToken), nameof(WarToken.PlayTokenAnimation),
                    new Type[] { typeof(WarToken.TokenAnimationType), typeof(UnityEngine.Events.UnityAction) });
                if (playAnim != null)
                    harmony.Patch(playAnim, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(PlayTokenAnimationPrefix))));
                var swapTok = AccessTools.Method(typeof(WarToken), nameof(WarToken.Swap), new Type[] { typeof(WarToken) });
                if (swapTok != null)
                    harmony.Patch(swapTok, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(SwapPrefix))));
                var getBattleLossTile = AccessTools.Method(typeof(WarToken), nameof(WarToken.GetBattleLossTile));
                if (getBattleLossTile != null)
                    harmony.Patch(getBattleLossTile, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(GetBattleLossTilePostfix))));
                var createBattle = AccessTools.Method(typeof(WarBattleManager), "CreateBattle");
                if (createBattle != null)
                    harmony.Patch(createBattle, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CreateBattlePostfix))));
                foreach (string supName in new[] { "SupportAttacker", "SupportDefender", "RemoveSupporterFromBattle" })
                {
                    var supM = AccessTools.Method(typeof(WarBattleManager), supName);
                    if (supM != null)
                        harmony.Patch(supM, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(SupportBattleChangedPostfix))));
                }
                var makeTokensLook = AccessTools.Method(typeof(WarTokenManager), nameof(WarTokenManager.MakeTokensLookAtEachOther));
                if (makeTokensLook != null)
                    harmony.Patch(makeTokensLook, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(MakeTokensLookAtEachOtherPrefix))));
                var actionsSetup = AccessTools.Method(typeof(WarPlayerActionsPanel), "Setup");
                if (actionsSetup != null)
                    harmony.Patch(actionsSetup, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(PlayerActionsPanelSetupPostfix))));

                // Status effects persistence across all battles & 1-turn DepletedOrganization guard
                var evalBattle = AccessTools.Method(typeof(WarBattleManager), "EvaluateBattleCoroutine");
                if (evalBattle != null)
                    harmony.Patch(evalBattle, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(EvaluateBattleCoroutinePrefix))));
                var playDmg = AccessTools.Method(typeof(WarBattleManager), "PlayDamageAnimations");
                if (playDmg != null)
                    harmony.Patch(playDmg, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(PlayDamageAnimationsPrefix))));
                var calcBattle = AccessTools.Method(typeof(WarBattleManager), nameof(WarBattleManager.CalculateAndFinalizeBattle));
                if (calcBattle != null)
                    harmony.Patch(calcBattle,
                        prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CalculateAndFinalizeBattlePrefix))),
                        postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CalculateAndFinalizeBattlePostfix))));
                var addStat = AccessTools.Method(typeof(WarToken), nameof(WarToken.AddTokenStatusEffect));
                if (addStat != null)
                    harmony.Patch(addStat, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTokenAddStatusEffectPrefix))));
                var remStat = AccessTools.Method(typeof(WarToken), nameof(WarToken.RemoveTokenStatusEffect));
                if (remStat != null)
                    harmony.Patch(remStat, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTokenRemoveStatusEffectPrefix))));
                var remAllStat = AccessTools.Method(typeof(WarToken), nameof(WarToken.RemoveAllTokenStatusEffect));
                if (remAllStat != null)
                    harmony.Patch(remAllStat, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTokenRemoveAllStatusEffectsPrefix))));
                var healDmg = AccessTools.Method(typeof(WarToken), nameof(WarToken.HealDamage));
                if (healDmg != null)
                    harmony.Patch(healDmg, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTokenHealDamagePrefix))));
                var panelRem = AccessTools.Method(typeof(WarTokenStatusEffectsPanel), nameof(WarTokenStatusEffectsPanel.Remove),
                    new Type[] { typeof(WarToken), typeof(WarToken.WarTokenStatusEffectType) });
                if (panelRem != null)
                    harmony.Patch(panelRem, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(StatusEffectsPanelRemovePrefix))));
                var removeAllEff = AccessTools.Method(typeof(WarTokenStatusEffectsPanel), nameof(WarTokenStatusEffectsPanel.RemoveAllInstances));
                if (removeAllEff != null)
                    harmony.Patch(removeAllEff, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(BattleSettledStatusEffectsPostfix))));
                var mapLoad = AccessTools.Method(typeof(MapManager), nameof(MapManager.LoadMap));
                if (mapLoad != null)
                    harmony.Patch(mapLoad, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(MapManagerLoadMapPrefix))));
                var warTokenKill = AccessTools.Method(typeof(WarToken), nameof(WarToken.Kill));
                if (warTokenKill != null)
                {
                    harmony.Patch(warTokenKill,
                        prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTokenKillPrefix))),
                        postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(WarTokenKillPostfix))));
                }
                var destroyToken = AccessTools.Method(typeof(WarTokenManager), nameof(WarTokenManager.DestroyToken), new Type[] { typeof(WarToken) });
                if (destroyToken != null)
                {
                    harmony.Patch(destroyToken,
                        prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(DestroyTokenPrefix))),
                        postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(DestroyTokenPostfix))));
                }
                var deployTokenLedger = AccessTools.Method(typeof(WarTokenManager), nameof(WarTokenManager.DeployToken),
                    new Type[] { typeof(WarUnitTypeData), typeof(WarTile), typeof(WarToken.WarAllegiance) });
                if (deployTokenLedger != null)
                {
                    harmony.Patch(deployTokenLedger,
                        prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(DeployTokenLedgerPrefix))),
                        postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(DeployTokenLedgerPostfix))));
                }
                foreach (string createName in new[] { "CreateWarToken", "CreateWarTokenOperationStart" })
                {
                    var createMethod = AccessTools.Method(typeof(WarTokenManager), createName, new Type[] { typeof(WarTokenData) });
                    if (createMethod != null)
                    {
                        harmony.Patch(createMethod,
                            prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CreateWarTokenLedgerPrefix))),
                            postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CreateWarTokenLedgerPostfix))));
                    }
                }

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
                var screenBorderMove = AccessTools.Method(typeof(MapScroller), "ScreenBorderMovement");
                if (screenBorderMove != null)
                    harmony.Patch(screenBorderMove, prefix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(ScreenBorderMovementPrefix))));

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

                var tokenSetup = AccessTools.Method(typeof(Token), nameof(Token.Setup), Type.EmptyTypes);
                if (tokenSetup != null)
                    harmony.Patch(tokenSetup, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CivilianTokenSetupPostfix))));

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
                var panelShowMethod = AccessTools.Method(typeof(TokenInteractionPanel), nameof(TokenInteractionPanel.Show));
                if (panelShowMethod != null)
                    harmony.Patch(panelShowMethod, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(TokenInteractionPanelShowPostfix))));

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

                // 5. WarTokenManager.AddEnemyTokenAction (Enemy Turn Limiter & Frontline Objective Focus)
                var addEnemyActionMethod = AccessTools.Method(
                    typeof(WarTokenManager),
                    nameof(WarTokenManager.AddEnemyTokenAction),
                    new Type[] { typeof(WarToken), typeof(WarToken.TokenAction) }
                );
                if (addEnemyActionMethod != null)
                {
                    var prefix = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(AddEnemyTokenActionPrefix));
                    harmony.Patch(addEnemyActionMethod, prefix: new HarmonyMethod(prefix));
                    MelonLogger.Msg("[Great Zille] Successfully hooked WarTokenManager.AddEnemyTokenAction (Enemy turn limiter active)!");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[Great Zille] Manual patch registration error: {ex.Message}");
            }
        }

        private static int _enemyActionsThisTurn = 0;
        private static int _lastEnemyActionTurn = -1;

        public static bool AddEnemyTokenActionPrefix(WarToken token, WarToken.TokenAction action)
        {
            if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Zille && !ZilleWarTable.SkinEnabled) return true;
            if (token == null || action == null) return true;

            var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
            int curTurn = flow != null ? flow.currentWarTurn : 0;
            if (curTurn != _lastEnemyActionTurn)
            {
                _lastEnemyActionTurn = curTurn;
                _enemyActionsThisTurn = 0;
            }

            // High-priority combat and retreat actions are always allowed
            try
            {
                if (token.GetRemainingOrganization() <= 0) return true;
            }
            catch { }

            var aType = action.actionType;
            if (aType == WarToken.TokenActionType.SupportAttacker ||
                aType == WarToken.TokenActionType.SupportDefender ||
                aType == WarToken.TokenActionType.SupportLandBattleAttackerFromSea ||
                aType == WarToken.TokenActionType.SupportLandBattleDefenderFromSea ||
                aType == WarToken.TokenActionType.Fortify)
            {
                _enemyActionsThisTurn++;
                return true;
            }

            // Pales campaign pacing: enemy takes 5 to 7 actions per turn total
            if (_enemyActionsThisTurn >= 6)
            {
                return false; // Discard excess actions beyond budget
            }

            var targetTile = action.tile;
            if (targetTile != null)
            {
                // NEVER allow enemy to simple Move directly onto an existing player token without battle!
                try
                {
                    var occ = targetTile.GetCurrentToken();
                    if (occ != null && occ.GetTokenAllegiance() == WarToken.WarAllegiance.Player)
                    {
                        if (aType == WarToken.TokenActionType.Move) return false;
                    }
                }
                catch { }

                // Frontline relevance: only move if current tile or target tile touches player territory or border
                try
                {
                    var curTile = token.GetCurrentWarTile();
                    if (!IsNearFrontline(curTile) && !IsNearFrontline(targetTile))
                    {
                        return false; // Rear garrisons hold position
                    }
                }
                catch { }
            }

            _enemyActionsThisTurn++;
            return true;
        }

        private static bool IsNearFrontline(WarTile wt)
        {
            if (wt == null) return false;
            var td = ZilleWarTable.TileDataOf(wt);
            if (td == null) return false;
            if (td.Allegiance == "Rizia" || td.IsBorder) return true;
            var adj = wt.adjacentWarTiles;
            if (adj != null)
            {
                for (int i = 0; i < adj.Count; i++)
                {
                    var nb = adj[i];
                    if (nb == null) continue;
                    var ntd = ZilleWarTable.TileDataOf(nb);
                    if (ntd != null && (ntd.Allegiance == "Rizia" || ntd.IsBorder)) return true;
                    var tok = nb.GetCurrentToken();
                    if (tok != null && tok.GetTokenAllegiance() == WarToken.WarAllegiance.Player) return true;
                }
            }
            return false;
        }

        public static void TokenNamePanelSetupPostfix(TokenNamePanel __instance, Token token)
        {
            try
            {
                if (__instance == null || token == null || token.gameObject == null) return;
                string tName = token.gameObject.name ?? "";
                string entityName = token.GetTokenDataEntityName() ?? "";

                if (tName.Contains("MaveNortusHQ") || entityName.Contains("MaveNortusHQ"))
                {
                    if (__instance.tokenNameText != null)
                    {
                        __instance.tokenNameText.text = "Mave Nortus Field HQ";
                    }
                }
                else if (tName.Contains("DerdiaVisit") || entityName.Contains("DerdiaVisit"))
                {
                    if (__instance.tokenNameText != null)
                    {
                        __instance.tokenNameText.text = "State Visit: Derdia";
                    }
                }
                else if (tName.Contains("InvasionOfZille") || entityName.Contains("InvasionOfZille") || entityName.Contains("WarFragment_Zille") || tName.Contains("Zille War"))
                {
                    if (__instance.tokenNameText != null)
                    {
                        __instance.tokenNameText.text = ZilleCampaignState.CurrentPhaseNumber == 2
                            ? $"{WarOperationZilleManager.GetOperationDisplayName()} - Phase II"
                            : "Invasion of Zille";
                    }
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[TOKEN NAME PANEL] Postfix error: {ex.Message}");
            }
        }

        public static void CivilianTokenSetupPostfix(Token __instance)
        {
            try
            {
                if (__instance == null || __instance.gameObject == null) return;
                if (WarOperationZilleManager.CurrentTheatre != ActiveWarTheatre.Civilian) return;
                string n = __instance.gameObject.name ?? "";
                string ent = __instance.GetTokenDataEntityName() ?? "";
                if (n == "InvasionOfZille Event Variant" || ent == "Rizia_Event_InvasionOfZille")
                {
                    bool wantActive = (ZilleCampaignState.CurrentPhaseNumber == 1 && !ZilleCampaignState.Phase1Finished)
                                   || (ZilleCampaignState.CurrentPhaseNumber == 2 && ZilleCampaignState.Phase2EventUnlocked);
                    if (wantActive && !__instance.gameObject.activeSelf)
                    {
                        __instance.gameObject.SetActive(true);
                        __instance.enabled = true;
                    }
                    else if (!wantActive && ZilleCampaignState.Phase1Finished)
                    {
                        __instance.gameObject.SetActive(false);
                    }
                }
                else if (n == "MaveNortusHQ Event Variant" || ent == "Rizia_Event_MaveNortusHQ")
                {
                    // Never spawn a separate MaveNortusHQ token next to Mave Nortus city;
                    // the Frontline Council action is attached directly to the existing Mave Nortus city token.
                    if (__instance.gameObject.activeSelf)
                    {
                        __instance.gameObject.SetActive(false);
                    }
                }
                else if (n == "DerdiaVisit Event Variant" || ent == "Rizia_Event_DerdiaVisit")
                {
                    bool wantVisit = DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitUnlocked")
                                  && !DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitDone")
                                  && !ZilleCampaignState.IsDerdiaStateVisitDone;
                    if (wantVisit && !__instance.gameObject.activeSelf)
                    {
                        __instance.gameObject.SetActive(true);
                        __instance.enabled = true;
                    }
                    else if (!wantVisit)
                    {
                        __instance.gameObject.SetActive(false);
                    }
                }
            }
            catch { }
        }

        public static void WarFlowManagerSetupWarFragmentPrefix(WarFragmentData warFragmentData, WarFlowManager __instance)
        {
            try
            {
                if (warFragmentData != null && warFragmentData.NameInDatabase == "WarFragment_Zille_1_1")
                {
                    MelonLogger.Msg("[WAR ENGINE] Intercepted SetupWarFragment for WarFragment_Zille_1_1! Activating Zille Theatre...");
                    ZilleWarTable.SnapshotPreZilleMilitaryLedger();
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

                ZilleDecisions.EnsureRegistered();
                ZilleReportsAndSituations.EnsureRegisteredAndSynced();

                if (DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitUnlocked")
                    && !DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitDone")
                    && !ZilleCampaignState.IsDerdiaStateVisitDone)
                {
                    WarOperationZilleManager.SpawnDerdiaVisitEventToken();
                }

                MelonLogger.Msg($"[TOKEN PANEL] SetupPostfix: Token='{tName}', Entity='{entityName}'");

                if (WarOperationZilleManager.PendingPhase2TokenSpawn
                    && !tName.Contains("MaveNortusHQ") && !entityName.Contains("MaveNortusHQ")
                    && !tName.Contains("InvasionOfZille") && !entityName.Contains("InvasionOfZille"))
                {
                    WarOperationZilleManager.NotifyCivilianStepProgressed();
                }

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

                    int turn = ZilleCampaignState.GetCurrentTurn();
                    bool earlyWar = DialogueHelper.GetBoolVariable("Zille_War_EarlyLaunch") || DialogueHelper.GetBoolVariable("Zille_War_Active");
                    bool planningDone = DialogueHelper.GetBoolVariable("Zille_War_Planning_Done");

                    if ((planningDone || earlyWar) && !DialogueHelper.GetBoolVariable("Zille_War_Active"))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) A royal briefing before the invasion of Zille", "Council Chambers, Palas Rezna", cd, () => {
                            MelonLogger.Msg("[TOKEN PANEL] Starting Royal Briefing conversation from Porte Drazon event button!");
                            WarOperationZilleManager.TriggerZilleWarBriefingConversation();
                        });
                    }

                    // Progression-driven Zille Council & Diplomatic Events on Porte Drazon
                    if (!planningDone && (turn == 0 || turn >= 2 || earlyWar))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) Emergency Crown Council: The Fate of Zille", "Council Chamber, Palas Rezna", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_WarPlanning", "Zille/WarPlanning");
                        });
                    }
                    else if (planningDone && string.IsNullOrEmpty(DialogueHelper.GetStringVariable("Zille_Logistics_Route")))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) Supply Lines of Brenas: Azaro vs Sazon", "State Dining Hall, Palas Rezna", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_WarLogisticsDispute", "Zille/WarLogisticsDispute");
                        });
                    }

                    // Turn 4+ Derdia-Wehlen Border Sabotage Investigation (available earlier if early war started in Turn 3)
                    if (!DialogueHelper.GetBoolVariable("Zille_Derdia_BriefingDone") && (turn == 0 || turn >= 4 || earlyWar))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) Sabotage Inquiry: Derdia-Wehlen Border Briefing", "Golden Guard Briefing Room", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_DerdiaInvestigation", "Zille/DerdiaInvestigation");
                        });
                    }

                    // Turn 5+ Long Derdia Talks (or immediately after Investigation during early war)
                    if (!DialogueHelper.GetBoolVariable("Zille_DerdiaTalks_Done")
                        && (turn == 0 || turn >= 5 || (earlyWar && (DialogueHelper.GetBoolVariable("Zille_Derdia_InvestigationDone") || DialogueHelper.GetBoolVariable("Zille_Derdia_BriefingDone")))))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) Derdian Mission: The Yol-Qerzan Sabotage", "Telecommunications Chamber", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_DerdiaTalks", "Zille/DerdiaTalks");
                        });
                    }

                    // Turn 6+ Warm Diplomatic Visit to Derdia (also accessible via world map token)
                    if (DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitUnlocked") && !DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitDone"))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) State Visit to Derdia: Silver Garrison", "Silver Garrison, Naeal", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_DerdiaStateVisit", "Zille/DerdiaStateVisit");
                        });
                    }

                    if (planningDone || earlyWar)
                    {
                        if (!DialogueHelper.GetBoolVariable("Zille_LespiaTalks_Done"))
                        {
                            EnsureButtonExists(__instance, "(MODNEW) Lespian Hotline: Air Recon and Munitions", "Foreign Ministry Communications", null, () => {
                                WarOperationZilleManager.TriggerConversation("Turn_Zille_LespiaTalks", "Zille/LespiaTalks");
                            });
                        }
                        if (!DialogueHelper.GetBoolVariable("Zille_RumburgTalks_Done"))
                        {
                            EnsureButtonExists(__instance, "(MODNEW) Imperial Trunk Line: Rumburgian Munitions", "Imperial Diplomatic Cabinet", null, () => {
                                WarOperationZilleManager.TriggerConversation("Turn_Zille_RumburgTalks", "Zille/RumburgTalks");
                            });
                        }
                    }

                    if ((ZilleCampaignState.CurrentPhase != ZilleOperationPhase.NotStarted || DialogueHelper.GetBoolVariable("Zille_War_Active")) && !DialogueHelper.GetBoolVariable("Zille_BalconySpeech_Done"))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) A Royal Proclamation of War", "Palas Rezna Balcony", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_WarBalconySpeech", "Zille/WarBalconySpeech");
                        });
                    }

                    if ((ZilleCampaignState.CurrentPhase != ZilleOperationPhase.NotStarted || ZilleCampaignState.Phase1Finished) && !DialogueHelper.GetBoolVariable("Zille_HomeFrontCrisis_Done"))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) Wartime Home Front: Energy & AN Pressure", "Cabinet Room, Palas Rezna", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_HomeFrontCrisis", "Zille/HomeFrontCrisis");
                        });
                    }

                    if (ZilleCampaignState.Op1CouncilAvailable && !ZilleCampaignState.Op1CouncilCompleted)
                    {
                        EnsureButtonExists(__instance, "(MODNEW) Post-Operation I High Command Council", "War Room, Palas Rezna", null, () => {
                            WarOperationZilleManager.ResolvePostOperation1Flow(ZilleCampaignState.Outcome, "Council Resumed");
                        });
                    }

                    if ((ZilleCampaignState.Outcome >= ZilleWarOutcome.DecisiveVictory || DialogueHelper.GetBoolVariable("RiziaDLC.ZilleReturn_Success"))
                        && DialogueHelper.GetBoolVariable("Zille_PeaceTreaty_Signed")
                        && !DialogueHelper.GetBoolVariable("Zille_Liberation_Done"))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) Homecoming in Zille City: Harbor Quarter", "Zille City Harbor", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_ZilleLiberation", "Zille/ZilleLiberation");
                        });
                    }

                    if ((DialogueHelper.GetBoolVariable("Zille_Azaro_Coup_Collapse") || DialogueHelper.GetBoolVariable("Zille_Parley_Refused"))
                        && !DialogueHelper.GetBoolVariable("Zille_ExileEpilogue_Done"))
                    {
                        EnsureButtonExists(__instance, "(MODNEW) Exile in Kyrute: The Shattered Kingdom", "Konstantium & Kyrute Airport", null, () => {
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_ExileEpilogue", "Zille/ExileEpilogue");
                        });
                    }

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
                // Case 2: Mave Nortus Field HQ (Post-Phase I standalone event token OR Mave Nortus city while active)
                else if (tName.Contains("MaveNortusHQ") || entityName.Contains("MaveNortusHQ")
                    || ((tName.IndexOf("Mave", StringComparison.OrdinalIgnoreCase) >= 0 || entityName.IndexOf("Mave", StringComparison.OrdinalIgnoreCase) >= 0)
                        && ZilleCampaignState.MaveNortusHQAvailable && !ZilleCampaignState.MaveNortusHQCompleted))
                {
                    if (__instance.titleText != null) __instance.titleText.text = "Mave Nortus Field HQ";
                    if (__instance.subtitleText != null) __instance.subtitleText.text = "Post-Phase I Council & Regrouping";

                    if (!ZilleCampaignState.MaveNortusHQCompleted)
                    {
                        EnsureButtonExists(__instance, "Frontline Council: Mave Nortus HQ", "Assess Phase I & Regroup for Phase II", null, () => {
                            MelonLogger.Msg("[TOKEN PANEL] Opening Mave Nortus Field HQ conversation!");
                            WarOperationZilleManager.TriggerMaveNortusHQ();
                        });
                    }
                }
                // Case 2B: Derdia State Visit Event Token
                else if (tName.Contains("DerdiaVisit") || entityName.Contains("DerdiaVisit"))
                {
                    if (__instance.titleText != null) __instance.titleText.text = "State Visit: Derdia";
                    if (__instance.subtitleText != null) __instance.subtitleText.text = "Silver Garrison Alliance Talks";

                    if (!DialogueHelper.GetBoolVariable("Zille_Derdia_StateVisitDone"))
                    {
                        EnsureButtonExists(__instance, "Diplomatic State Visit: Silver Garrison", "Seal the Southern Corridor & Pipeline Alliance", null, () => {
                            MelonLogger.Msg("[TOKEN PANEL] Opening Derdia State Visit conversation!");
                            WarOperationZilleManager.TriggerConversation("Turn_Zille_DerdiaStateVisit", "Zille/DerdiaStateVisit");
                        });
                    }
                }
                // Case 3: Zille (War Operation Event)
                else if (tName.Contains("InvasionOfZille") || entityName.Contains("InvasionOfZille") || entityName.Contains("WarFragment_Zille") || tName.Contains("Zille War"))
                {
                    string opName = WarOperationZilleManager.GetOperationDisplayName();
                    if (__instance.titleText != null)
                    {
                        __instance.titleText.text = ZilleCampaignState.CurrentPhaseNumber == 2
                            ? $"{opName} - Phase II"
                            : "Invasion of Zille";
                    }
                    if (__instance.subtitleText != null)
                    {
                        __instance.subtitleText.text = ZilleCampaignState.CurrentPhaseNumber == 2
                            ? "Breakthrough & Encirclement"
                            : "Military Operation";
                    }

                    if (ZilleCampaignState.CurrentPhaseNumber == 1 && ZilleCampaignState.Phase1Finished)
                    {
                        EnsureButtonExists(__instance, "Phase I Concluded", "Convene at Mave Nortus Field HQ", null, () => {
                            DialogueHelper.ShowAlert("Phase I has ended. Report to the Field HQ event in Mave Nortus to regroup for Phase II.");
                        });
                        return;
                    }

                    string opButtonTitle = ZilleCampaignState.CurrentPhaseNumber == 2
                        ? $"{opName} - Phase II"
                        : $"{opName} - Phase I";

                    string opButtonSub = ZilleCampaignState.CurrentPhaseNumber == 2
                        ? "Phase II Offensive"
                        : "Invasion of Zille";

                    EnsureButtonExists(__instance, opButtonTitle, opButtonSub, null, () => {
                        MelonLogger.Msg($"[TOKEN PANEL] {opButtonTitle} opens the Zille war table.");
                        WarOperationZilleManager.EnterZilleWarTheatre();
                    });
                }

                // Inject normal-map Decisions matching the clicked city & turn timing
                foreach (var dec in ZilleDecisions.AllDecisions)
                {
                    if (ZilleDecisions.IsDecisionAvailableForToken(dec, tName, entityName))
                    {
                        var localDec = dec;
                        EnsureButtonExists(__instance, $"(DECISION) {localDec.Title}", "Royal Decree / Frontier Dilemma", null, () => {
                            ZilleDecisions.OpenDecision(localDec);
                        });
                    }
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

        public static void TokenInteractionPanelShowPostfix(TokenInteractionPanel __instance)
        {
            ExpandInteractionPanelToFitButtons(__instance);
        }

        private static void ExpandInteractionPanelToFitButtons(TokenInteractionPanel panel)
        {
            if (panel == null) return;
            try
            {
                int activeCount = 0;
                if (panel.instantiatedInteractionButtons != null)
                {
                    for (int i = 0; i < panel.instantiatedInteractionButtons.Count; i++)
                    {
                        var b = panel.instantiatedInteractionButtons[i];
                        if (b != null && b.gameObject != null && b.gameObject.activeSelf) activeCount++;
                    }
                }
                if (activeCount <= 0) return;

                if (panel.scrollRect != null) panel.scrollRect.gameObject.SetActive(true);
                if (panel.contentHolder != null)
                {
                    panel.contentHolder.gameObject.SetActive(true);
                    if (panel.contentHolder.parent != null) panel.contentHolder.parent.gameObject.SetActive(true);
                    float wantContentH = Mathf.Max(panel.contentHolder.sizeDelta.y, 84f * (activeCount + 1));
                    panel.contentHolder.sizeDelta = new Vector2(panel.contentHolder.sizeDelta.x, wantContentH);
                }
                if (panel.choicesContainerRect != null)
                {
                    panel.choicesContainerRect.gameObject.SetActive(true);
                    float interval = panel.panelHeightInterval > 1f ? panel.panelHeightInterval : 84f;
                    float wantChoicesH = Mathf.Max(panel.choicesContainerRect.sizeDelta.y, 122f + interval * activeCount);
                    panel.choicesContainerRect.sizeDelta = new Vector2(panel.choicesContainerRect.sizeDelta.x, wantChoicesH);
                }
                if (panel.panelRect != null)
                {
                    float wantPanelH = Mathf.Max(panel.panelRect.sizeDelta.y, 290f + 84f * activeCount);
                    panel.panelRect.sizeDelta = new Vector2(panel.panelRect.sizeDelta.x, wantPanelH);
                }
                if (panel.contentHolder != null)
                    UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(panel.contentHolder);
                if (panel.choicesContainerRect != null)
                    UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(panel.choicesContainerRect);
                if (panel.panelRect != null)
                    UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(panel.panelRect);
            }
            catch { }
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
                ExpandInteractionPanelToFitButtons(panel);
            }
        }

        // ================= RESPONSE SELECTION HOOK =================

        public static void StartConversationPrefix(string title)
        {
            try
            {
                ZilleDialogueSystem.EnsureAllConversationsRegistered();
                DialogueOverrideManager.ApplyAllOverrides();
                ZilleCampaignState.SyncFromLua();
                ZilleCampaignState.SyncToLua();
                ZilleReportsAndSituations.EnsureRegisteredAndSynced();
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

                // 1. Operational doctrine / war initiation choices
                if (title == "Choice_Golden_Sword" || script.Contains("Choice_Romulus_Sword") || title.Contains("Choice_Romulus_Sword") || menuText.Contains("Righteous Sword") || menuText.Contains("Operation Golden Sword"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Operation Golden Sword chosen by player! Initializing Sword variant.");
                    ZilleCampaignState.PlanType = ZillePlanType.Romulus;
                    ZilleCampaignState.RomulusPlan = ZilleRomulusPlan.Sword;
                    ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanSword);
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = true;
                }
                else if (title == "Choice_Golden_Ark_Derdia")
                {
                    MelonLogger.Msg("[WAR COUNCIL] Operation Golden Ark (Derdia Southern Corridor) chosen by player!");
                    ZilleCampaignState.PlanType = ZillePlanType.Romulus;
                    ZilleCampaignState.RomulusPlan = ZilleRomulusPlan.Ark;
                    ZilleCampaignState.IsDerdiaPactSigned = true;
                    ZilleCampaignState.IsDerdiaHybridSupportActive = true;
                    ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanArkDerdia);
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = true;
                }
                else if (title == "Choice_Golden_Ark" || title == "Choice_Golden_Ark_WeakFleet" || script.Contains("Choice_Romulus_Ark") || title.Contains("Choice_Romulus_Ark") || menuText.Contains("Plan Romulus: Ark") || menuText.Contains("Operation Golden Ark"))
                {
                    var variant = (ZilleCampaignState.IsDerdiaPactSigned || DialogueHelper.GetBoolVariable("Zille_DerdiaPact_Signed"))
                        ? ZilleOperationVariant.PlanArkDerdia
                        : ZilleOperationVariant.PlanArk;
                    MelonLogger.Msg($"[WAR COUNCIL] Operation Golden Ark chosen by player! Initializing variant {variant}.");
                    ZilleCampaignState.PlanType = ZillePlanType.Romulus;
                    ZilleCampaignState.RomulusPlan = ZilleRomulusPlan.Ark;
                    ZilleCampaignState.SetOperationVariant(variant);
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = true;
                }
                else if (title == "Authorize_Staff_Hawk" || title == "Choice_Staff_Hawk")
                {
                    WarOperationZilleManager.InitializeStaffPlan(ZilleStaffPlan.Hawk);
                }
                else if (title == "Authorize_Staff_Sword" || title == "Choice_Staff_Sword")
                {
                    WarOperationZilleManager.InitializeStaffPlan(ZilleStaffPlan.Sword);
                }
                else if (title == "Authorize_Staff_Ark" || title == "Authorize_Staff_Ark_WeakFleet" || title == "Choice_Staff_Ark")
                {
                    WarOperationZilleManager.InitializeStaffPlan(ZilleStaffPlan.Ark);
                }
                else if (title == "Authorize_Staff_Spear" || title == "Choice_Staff_Spear")
                {
                    WarOperationZilleManager.InitializeStaffPlan(ZilleStaffPlan.Spear);
                }
                else if (script.Contains("Zille_War_Alfa") || title.Contains("Choice_Plan_Alpha") || title.Contains("Choice_Alpha") || menuText.Contains("Plan Alpha"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Plan Alpha chosen by player in native dialogue! Will spawn Zille war event token after briefing.");
                    ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanSword);
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FrontalAssault);
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = true;
                }
                else if (script.Contains("Zille_War_Beta") || title.Contains("Choice_Plan_Beta") || title.Contains("Choice_Beta") || menuText.Contains("Plan Beta"))
                {
                    var variant = ZilleCampaignState.IsDerdiaHybridSupportActive ? ZilleOperationVariant.PlanArkDerdia : ZilleOperationVariant.PlanArk;
                    MelonLogger.Msg($"[WAR COUNCIL] Plan Beta chosen by player in native dialogue! Initializing variant {variant}.");
                    ZilleCampaignState.SetOperationVariant(variant);
                    WarOperationZilleManager.InitializeOperation(ZilleOperationPath.FlankViktranyMunat);
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = true;
                }
                else if (script.Contains("Zille_War_Postpone") || title.Contains("Choice_Plan_Postpone") || title.Contains("Choice_Postpone") || menuText.Contains("Postpone") || menuText.Contains("Wstrzymajmy"))
                {
                    MelonLogger.Msg("[WAR COUNCIL] Postponing Zille invasion as requested by player.");
                    WarOperationZilleManager.PendingZilleTokenSpawnAfterBriefing = false;
                }
                // 2. Logistics dispute choices
                else if (title == "Choice_Sazon_Route" || title == "Choice_Sazon_Debt_Route")
                {
                    ZilleCampaignState.LogisticsRoute = "Sazon";
                }
                else if (title == "Choice_Azaro_Route" || title == "Choice_Azaro_Rationing")
                {
                    ZilleCampaignState.LogisticsRoute = "Azaro";
                }
                else if (title == "Choice_Compromise_Route")
                {
                    ZilleCampaignState.LogisticsRoute = "Compromise";
                }
                // 3. Diplomatic pacts (Derdia, Lespia, Rumburg)
                else if (title == "DerdiaInv_GoldenGuard" || title == "DerdiaInv_MilitaryIntel" || title == "DerdiaInv_DiplomaticChannel")
                {
                    ZilleCampaignState.HasDerdiaSabotageEvidence = true;
                }
                else if (title == "Derdia_Accept_StateVisit")
                {
                    ZilleCampaignState.IsDerdiaIncidentShared = true;
                }
                else if (title == "Derdia_WarActive_VisitAndRaids" || title == "Deal_Derdia_Weapons")
                {
                    ZilleCampaignState.IsDerdiaHybridSupportActive = true;
                }
                else if (title == "DerdiaVisit_Sign_FullPipeline" || title == "DerdiaVisit_Sign_DiscountPipeline")
                {
                    ZilleCampaignState.IsDerdiaPactSigned = true;
                    ZilleCampaignState.IsDerdiaHybridSupportActive = true;
                    ZilleCampaignState.IsDerdiaPipelineInvested = true;
                    ZilleCampaignState.IsDerdiaMissilesAgreed = true;
                    ZilleCampaignState.IsDerdiaStateVisitDone = true;
                }
                else if (title == "DerdiaVisit_Sign_CorridorOnly")
                {
                    ZilleCampaignState.IsDerdiaPactSigned = true;
                    ZilleCampaignState.IsDerdiaHybridSupportActive = true;
                    ZilleCampaignState.IsDerdiaStateVisitDone = true;
                }
                else if (title == "Accept_Holy_Coalition" || title == "Deal_Derdia_Budget" || title == "Counter_Pragmatic_Derdia")
                {
                    ZilleCampaignState.IsDerdiaHybridSupportActive = true;
                }
                else if (title == "Reject_Derdia_Demands")
                {
                    ZilleCampaignState.IsDerdiaHybridSupportActive = false;
                }
                else if (title == "Accept_Alvarez_Pact" || title == "Hard_Bargain_Alvarez" || title == "Blackmail_Alvarez_Zille")
                {
                    ZilleCampaignState.IsLespiaPactAccepted = true;
                    ZilleCampaignState.IsLespiaIntelActive = true;
                }
                else if (title == "Reject_Alvarez_Greed")
                {
                    ZilleCampaignState.IsLespiaPactAccepted = false;
                    ZilleCampaignState.IsLespiaIntelActive = false;
                }
                else if (title == "Pledge_GRACE_Solidarity" || title == "Purchase_Rumburg_Expansion" || title == "Grateful_Sovereign")
                {
                    ZilleCampaignState.IsRumburgMunitionsActive = true;
                }
                // 4. Phase II launch & Parley / Treaty outcomes
                else if (title == "Order_Phase2_Launch" || title == "Order_Phase2_Controlled")
                {
                    ZilleCampaignState.CurrentPhase = ZilleOperationPhase.Phase2;
                    ZilleCampaignState.CurrentPhaseNumber = 2;
                }
                else if (title == "Op1_Accept_Ark_Exchange")
                {
                    ZilleCampaignState.Outcome = ZilleWarOutcome.DecisiveVictory;
                    ZilleCampaignState.ZilleCityCaptured = true;
                    ZilleCampaignState.IsIndependentZilleAgreed = false;
                }
                else if (title == "Op1_Reject_Ceasefire_Sword" || title == "Op1_Reject_Ark_Exchange"
                    || title == "Op1_Desperate_CounterOffensive" || title == "Op1_Desperate_CounterOffensive_NoGold"
                    || title == "Op1_Force_TotalRepayment_Armor" || title == "Op1_Force_TotalRepayment_Siege")
                {
                    ZilleCampaignState.TotalRepaymentUnlocked = true;
                }
                else if (title == "Accept_Decisive_Surrender" || title == "Demand_Leveraged_Reparations" || title == "Force_Zille_Return_Leverage" || title == "Sign_Decisive_Victory" || title == "Sign_Victory_Reparations")
                {
                    ZilleCampaignState.Outcome = ZilleWarOutcome.DecisiveVictory;
                    ZilleCampaignState.IsIndependentZilleAgreed = false;
                }
                else if (title == "Demand_Overwhelming_Triumph" || title == "Sign_Overwhelming_Triumph")
                {
                    ZilleCampaignState.Outcome = ZilleWarOutcome.OverwhelmingTriumph;
                    ZilleCampaignState.IsIndependentZilleAgreed = false;
                }
                else if (title == "Accept_Independent_Buffer" || title == "Sign_Independent_Buffer")
                {
                    ZilleCampaignState.Outcome = ZilleWarOutcome.BloodyStalemate;
                    ZilleCampaignState.IsIndependentZilleAgreed = true;
                }
                else if (title == "Reject_Buffer_Ceasefire" || title == "Accept_Tactical_Defeat" || title == "Accept_Tactical_Defeat_Defiant" || title == "Salvage_Brenas_Leverage" || title == "Sign_Tactical_Defeat" || title == "Sign_Tactical_Defeat_Warning")
                {
                    ZilleCampaignState.Outcome = ZilleWarOutcome.TacticalDefeat;
                    ZilleCampaignState.IsBrenasLost = false;
                    ZilleCampaignState.IsIndependentZilleAgreed = false;
                }
                else if (title == "Accept_Total_Fiasco" || title == "Accept_Total_Fiasco_Silent" || title == "Sign_Total_Fiasco" || title == "Sign_Total_Fiasco_Silent" || title == "Refuse_Parley_Collapse")
                {
                    ZilleCampaignState.Outcome = ZilleWarOutcome.TotalFiasco;
                    ZilleCampaignState.IsBrenasLost = true;
                    ZilleCampaignState.IsIndependentZilleAgreed = false;
                }
                // 5. Vanilla conversation war posture injections
                else if (title.Contains("Zille_Turn3_Bombing_WarOption") || title.Contains("Zille_Turn8_War_Ultimatum"))
                {
                    MelonLogger.Msg("[DIPLOMACY] Player chose immediate military escalation over Zille!");
                    ZilleCampaignState.MilitarySentimentLevel = 3;
                }
                else if (title.Contains("Zille_War_Ultimatum") || title.Contains("Zille_Smolak_FaceToFace"))
                {
                    MelonLogger.Msg("[DIPLOMACY] Player threatened Wehlen with military invasion! Activating Zille war pathway.");
                    ZilleCampaignState.MilitarySentimentLevel = 2;
                }
                else if (title == "Choice_Naval_Blockade" || script.Contains("Zille_NavalBlockadeActive = true"))
                {
                    ZilleCampaignState.IsNavalBlockadeActive = true;
                }
                else
                {
                    goto SkipSyncToLua;
                }

                // Sync any C# mutations into Lua before the node script / Postfix runs
                ZilleCampaignState.SyncToLua();

                SkipSyncToLua:
                // Sync back any Lua micro-effect deltas (Leverage, WarReadiness, Pressure, AN Legitimacy)
                if (script.Contains("Zille_Leverage") || script.Contains("Zille_War_Readiness")
                    || script.Contains("Zille_Smolak_Pressure") || script.Contains("Zille_AN_Legitimacy"))
                {
                    ZilleCampaignState.SyncFromLua();
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[Great Zille] Response selection error: {ex.Message}");
            }
        }

        public static void OnSelectedResponsePostfix(Il2CppSystem.Object sender, SelectedResponseEventArgs e)
        {
            try
            {
                string last = DialogueHelper.GetCurrentConversationTitle() ?? "";
                string sc = e?.DestinationEntry?.userScript ?? "";
                if (last.Contains("Zille") || sc.Contains("Zille_"))
                {
                    ZilleCampaignState.SyncFromLua();
                    ZilleReportsAndSituations.EnsureRegisteredAndSynced();
                }
            }
            catch { }
        }
    }
}
