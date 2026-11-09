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
            if (!ZilleWarTable.ScenarioStarted) return;
            __result = ZilleWarTable.IsZilleFrontTile(__instance);
        }

        public static void IsSelectedDeploymentUnitDeployableToTilePostfix(WarTile __instance, ref bool __result)
        {
            if (__result || !ForcedDeploy(__instance)) return;
            __result = true;
        }

        public static void CanDeploySelectedUnitToTilePostfix(WarTile __0, ref bool __result)
        {
            if (__result || !ForcedDeploy(__0)) return;
            __result = true;
        }

        /// <summary>Ships only on the naval starts. Land units only on Rizian land. A ship must not light up the coast.</summary>
        private static bool ForcedDeploy(WarTile tile)
        {
            if (tile == null || !DeploymentAllows(tile)) return false;
            try
            {
                var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
                if (panel == null || !panel.IsDeploymentUnitSelected()) return false;
                var unit = panel.GetSelectedUnitTypeData();
                if (unit == null) return false;
                if (unit.unitType == WarUnitTypeData.UnitType.NavalUnit) return IsNavalStart(tile);
                if (unit.unitType == WarUnitTypeData.UnitType.LandUnit) return IsRiziaLand(tile);
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

        /// <summary>A raw click must not deploy or move. Those run only after the hold opens the gate.</summary>
        public static bool BlockUntilHoldPrefix(object __instance)
        {
            if (ZilleWarTable.EnemyMayAct())
            {
                // Only allow live battles to resolve during enemy phase, block all player clicks/commits/deployments
                return __instance is WarTile wt && ZilleWarTable.BattleMayResolve(wt);
            }
            if (ZilleWarTable.CommitAllowed) return true;
            return __instance is WarTile tile && ZilleWarTable.BattleMayResolve(tile);
        }

        /// <summary>The raycaster clears its tile at the end of Update. Remember the province it actually hit.</summary>
        public static void RememberHoverPostfix(WarTileRaycaster __instance)
        {
            WarTile tile = null;
            try { tile = __instance != null ? __instance.raycastedWarTile : null; } catch { }
            ZilleWarTable.NoteGameHover(tile);
        }

        public static bool IsBorderTilePrefix(ref bool __result)
        {
            if (!ZilleWarTable.ScenarioStarted) return true;
            var panel = Panels.Instance != null ? Panels.Instance.WarDeploymentPanel : null;
            if (panel == null || !panel.IsShowing()) return true;
            __result = false;
            return false;
        }

        private static bool DeploymentAllows(WarTile tile)
        {
            if (!ZilleWarTable.ScenarioStarted) return true;
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
                if (turn != _pointsGrantedForTurn)
                {
                    _pointsGrantedForTurn = turn;
                    if (__instance.GetCurrentActionPoints() <= 0)
                        __instance.currentActionPoints = Math.Max(1, __instance.ActionPointsPerTurn);
                }
                var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (mgr != null) mgr.SetAllTokenActions();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZTABLE] player turn: " + ex.GetBaseException().Message);
            }
        }

        /// <summary>A unit that already moved is locked out of a second move, but it still has to be clickable.</summary>
        public static void IsSelectablePostfix(WarToken __instance, ref bool __result)
        {
            if (ZilleWarTable.EnemyMayAct())
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
            }
            catch { }
        }

        /// <summary>
        /// A defeated unit retreats to an empty friendly tile. It must never retreat onto an occupied tile,
        /// onto the attacker's starting tile, or across into hostile player territory.
        /// </summary>
        public static void GetBattleLossTilePostfix(WarToken __instance, ref WarTile __result)
        {
            if (__instance == null || !ZilleWarTable.ScenarioStarted) return;
            try
            {
                var battle = __instance.GetCurrentBattle();
                WarTile atkTile = null;
                if (battle != null && battle.attacker != null)
                {
                    try { atkTile = battle.attacker.GetCurrentWarTile(); } catch { }
                }

                // If candidate is attacker's tile, occupied, or across allegiance border, reject it
                if (__result != null)
                {
                    bool invalid = false;
                    if (__result == atkTile) invalid = true;
                    var occ = __result.GetCurrentToken();
                    if (occ != null && occ != __instance) invalid = true;

                    var td = ZilleWarTable.TileDataOf(__result);
                    var alleg = __instance.GetTokenAllegiance();
                    if (alleg == WarToken.WarAllegiance.Enemy && td != null && td.Allegiance == "Rizia")
                        invalid = true;
                    else if (alleg == WarToken.WarAllegiance.Player && td != null && td.Allegiance == "Wehlen")
                        invalid = true;

                    if (!invalid) return;
                    __result = null;
                }

                // If invalid or null, try to find an adjacent empty tile of the same allegiance
                var curTile = __instance.GetCurrentWarTile();
                if (curTile == null) return;
                var adj = curTile.adjacentWarTiles;
                if (adj == null) return;

                var unitAlleg = __instance.GetTokenAllegiance();
                string wantAlleg = unitAlleg == WarToken.WarAllegiance.Player ? "Rizia" : "Wehlen";

                for (int i = 0; i < adj.Count; i++)
                {
                    var t = adj[i];
                    if (t == null || t == curTile || t == atkTile) continue;
                    if (t.GetCurrentToken() != null && t.GetCurrentToken() != __instance) continue;
                    var td = ZilleWarTable.TileDataOf(t);
                    if (td == null || td.IsSea) continue;
                    if (td.Allegiance == wantAlleg)
                    {
                        __result = t;
                        return;
                    }
                }

                // If no retreat tile is available, the defeated defending unit is killed!
                // But a city must NEVER be destroyed or killed!
                if (__result == null)
                {
                    if (ZilleWarTable.IsCityToken(__instance))
                    {
                        MelonLogger.Msg("[ZTABLE] Defeated city token stays in place and does not retreat: " + __instance.gameObject.name);
                        return;
                    }
                    MelonLogger.Msg("[ZTABLE] Defeated unit has nowhere to retreat! Dying in battle: " + __instance.gameObject.name);
                    ZilleWarTable.KillUnit(__instance, curTile);
                }
            }
            catch { }
        }

        public static void StartBattlePrefix(WarToken attacker, WarToken defender)
        {
            if (defender != null)
            {
                var tile = defender.GetCurrentWarTile();
                if (tile != null)
                {
                    ZilleWarTable.RecordBattleContestedTile(attacker, defender, tile);
                }
            }
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
        /// The stock check samples the mask alpha and rejects our provinces, so the outline and the hold timer never start.
        /// A hit on the province mesh is already inside that province.
        /// </summary>
        public static bool IsHoveringPrefix(RaycastHit hit, ref bool __result)
        {
            try
            {
                var tile = hit.collider != null ? hit.collider.GetComponentInParent<WarTile>() : null;
                if (tile == null) return true;
                var rend = tile.GetWarTileRenderer();
                var tex = rend != null ? rend.material.GetTexture("_Tile_Texture") as Texture2D : null;
                if (tex != null && tex.isReadable)
                {
                    var sample = tex.GetPixelBilinear(hit.textureCoord.x, hit.textureCoord.y);
                    __result = sample.a >= 0.5f;
                    return false;
                }
                __result = true;
                return false;
            }
            catch { }
            return true;
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
                    var post = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(IsSelectedDeploymentUnitDeployableToTilePostfix));
                    harmony.Patch(selectedFlag, postfix: new HarmonyMethod(post));
                }
                var canDeploy = typeof(WarDeploymentPanel).GetMethod("CanDeploySelectedUnitToTile");
                if (canDeploy != null)
                {
                    var post = AccessTools.Method(typeof(DialogueInjectionPatches), nameof(CanDeploySelectedUnitToTilePostfix));
                    harmony.Patch(canDeploy, postfix: new HarmonyMethod(post));
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
                        harmony.Patch(other, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(ClearFortifyPostfix))));
                }
                var hover = AccessTools.Method(typeof(WarTileRaycaster), "HoverRaycast");
                if (hover != null)
                    harmony.Patch(hover, postfix: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(RememberHoverPostfix))));
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
                    harmony.Patch(endBattle, finalizer: new HarmonyMethod(AccessTools.Method(typeof(DialogueInjectionPatches), nameof(EndBattleFinalizer))));
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

        public static void WarFlowManagerSetupWarFragmentPrefix(WarFragmentData warFragmentData)
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
