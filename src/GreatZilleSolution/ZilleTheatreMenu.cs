using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;
using Il2Cpp;

namespace GreatZilleSolution
{
    /// <summary>
    /// In-game authoring menu (F11) for the live Zille table: province scale, extra provinces
    /// borrowed from unused vanilla WarTiles, and player/enemy units with reinforcement triggers.
    /// </summary>
    public class ZilleTheatreMenu
    {
        public bool IsOpen { get; set; }

        private Rect _window = new Rect(24, 36, 540, 760);
        private int _tab;
        private int _prov;
        private int _unit;
        private int _spawnTile;
        private int _watchTile;
        private string _side = "Player";
        private string _trigger = "Turn";
        private int _turn = 2;
        private string _watchSide = "Player";
        private Vector2 _scroll;
        private string _status = "F11 toggles this menu. Open the Zille theatre (F6) before placing units.";
        private readonly List<WarUnitTypeData> _unitTypes = new List<WarUnitTypeData>();

        public void DrawGUI()
        {
            if (!IsOpen) return;
            _window = GUI.Window(9903, _window, (GUI.WindowFunction)DrawWindow, "[Zille Theatre] Live Authoring | JIFO (jifo.dev)");
        }

        private static float _nextOrderTick;

        public static void TickOrders()
        {
            try
            {
                if (Time.unscaledTime < _nextOrderTick) return;
                _nextOrderTick = Time.unscaledTime + 0.5f;
                var orders = ZilleMapLayoutManager.CurrentConfig?.Orders;
                if (orders == null || orders.Count == 0) return;
                if (!ZilleWarTable.HasLiveMap) return;

                int turn = -1;
                var flow = UnityEngine.Object.FindObjectOfType<WarFlowManager>();
                if (flow != null) turn = flow.GetCurrentWarTurn();

                bool dirty = false;
                for (int i = 0; i < orders.Count; i++)
                {
                    var o = orders[i];
                    if (o == null || !o.Armed || o.Fired) continue;
                    bool due = false;
                    if (o.Trigger == "Start") due = true;
                    else if (o.Trigger == "Turn") due = turn >= o.Turn && turn > 0;
                    else if (o.Trigger == "Allegiance") due = AllegianceMatches(o);
                    if (!due) continue;
                    if (StorySpawn(o, out _))
                    {
                        o.Fired = true;
                        dirty = true;
                    }
                }
                if (dirty) ZilleMapLayoutManager.SaveConfig();
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZMENU] Trigger tick: " + ex.Message);
            }
        }

        private void DrawWindow(int id)
        {
            // 5 Operation Variants selector bar
            GUI.Label(new Rect(8, 22, 60, 20), "<b>Variant:</b>");
            var curVar = ZilleCampaignState.CurrentVariant;
            if (GUI.Button(new Rect(65, 20, 75, 22), curVar == ZilleOperationVariant.PlanArk ? "<b>[Ark]</b>" : "Ark"))
            {
                ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanArk);
                _status = "Operation Variant: Plan Ark (130 provinces).";
            }
            if (GUI.Button(new Rect(145, 20, 80, 22), curVar == ZilleOperationVariant.PlanSword ? "<b>[Sword]</b>" : "Sword"))
            {
                ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanSword);
                _status = "Operation Variant: Plan Sword (137 provinces).";
            }
            if (GUI.Button(new Rect(230, 20, 85, 22), curVar == ZilleOperationVariant.PlanArkDerdia ? "<b>[Ark (D)]</b>" : "Ark (D)"))
            {
                ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.PlanArkDerdia);
                _status = "Operation Variant: Plan Ark (Derdia) (137 provinces).";
            }
            if (GUI.Button(new Rect(320, 20, 105, 22), curVar == ZilleOperationVariant.TotalRepaymentDerdia ? "<b>[Repay (D)]</b>" : "Repay (D)"))
            {
                ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.TotalRepaymentDerdia);
                _status = "Operation Variant: Total Repayment (Derdia) (186 provinces).";
            }
            if (GUI.Button(new Rect(430, 20, 102, 22), curVar == ZilleOperationVariant.TotalRepaymentNoDerdia ? "<b>[Repay]</b>" : "Repay"))
            {
                ZilleCampaignState.SetOperationVariant(ZilleOperationVariant.TotalRepaymentNoDerdia);
                _status = "Operation Variant: Total Repayment (bez Derdii) (179 provinces).";
            }

            if (GUI.Button(new Rect(8, 46, 168, 24), _tab == 0 ? "[ Provinces ]" : "Provinces")) _tab = 0;
            if (GUI.Button(new Rect(182, 46, 168, 24), _tab == 1 ? "[ Units ]" : "Units")) _tab = 1;
            if (GUI.Button(new Rect(356, 46, 174, 24), _tab == 2 ? "[ Reinforcements ]" : "Reinforcements")) _tab = 2;

            float contentH = _tab == 0 ? 980f : (_tab == 1 ? 860f : 980f);
            var orders = Orders();
            contentH += orders.Count * 26f;
            _scroll = GUI.BeginScrollView(new Rect(8, 74, 524, 624), _scroll, new Rect(0, 0, 500, contentH));
            if (_tab == 0) DrawProvinces();
            else if (_tab == 1) DrawUnits();
            else DrawReinforcements();
            GUI.EndScrollView();

            GUI.Label(new Rect(10, 704, 520, 36), "<size=11><color=#d6d3c4>" + _status + "</color></size>");
            ZilleBranding.DrawIcon(new Rect(518, 1, 18, 18));
            GUI.DragWindow(new Rect(0, 0, 540, 20));
        }

        private void DrawProvinces()
        {
            var tiles = Tiles();
            float y = 4f;
            GUI.Label(new Rect(4, y, 490, 20), $"<b>Provinces on the table: {tiles.Count}</b>  (vanilla tiles left: {CountFree()})");
            y += 24f;

            if (tiles.Count == 0)
            {
                GUI.Label(new Rect(4, y, 480, 20), "No provinces in the layout.");
                return;
            }
            _prov = Mathf.Clamp(_prov, 0, tiles.Count - 1);
            var sel = tiles[_prov];

            for (int i = 0; i < tiles.Count; i++)
            {
                var t = tiles[i];
                string mark = i == _prov ? "> " : "  ";
                if (GUI.Button(new Rect(4, y, 490, 22), $"{mark}{t.Name}   Tile_{t.TileNumber}   scale {t.WorldScale:F3}"))
                    _prov = i;
                y += 24f;
            }
            y += 8f;
            sel = tiles[_prov];

            GUI.Label(new Rect(4, y, 70, 20), "Name");
            sel.Name = GUI.TextField(new Rect(78, y, 410, 20), sel.Name ?? "");
            y += 26f;

            GUI.Label(new Rect(4, y, 490, 18), $"<b>3D scale:</b> {sel.WorldScale:F3}   (Pales land 0.15, sea 0.28)");
            y += 18f;
            float ns = GUI.HorizontalSlider(new Rect(4, y, 490, 18), sel.WorldScale, 0.05f, 0.70f);
            if (Mathf.Abs(ns - sel.WorldScale) > 0.0005f)
            {
                sel.WorldScale = ns;
                ZilleWarTable.RequestApply();
            }
            y += 22f;
            if (GUI.Button(new Rect(4, y, 90, 22), "0.15 land")) { sel.WorldScale = 0.1543f; ZilleWarTable.RequestApply(); }
            if (GUI.Button(new Rect(100, y, 90, 22), "0.22")) { sel.WorldScale = 0.22f; ZilleWarTable.RequestApply(); }
            if (GUI.Button(new Rect(196, y, 90, 22), "0.28 sea")) { sel.WorldScale = 0.2761f; ZilleWarTable.RequestApply(); }
            if (GUI.Button(new Rect(292, y, 200, 22), "Apply this scale to ALL"))
            {
                float s = sel.WorldScale;
                for (int i = 0; i < tiles.Count; i++) tiles[i].WorldScale = s;
                ZilleWarTable.RequestApply();
                _status = $"Every province set to scale {s:F3}.";
            }
            y += 28f;

            GUI.Label(new Rect(4, y, 490, 18), $"Map px  X {sel.MapPxX:F0}   Y {sel.MapPxY:F0}   (full-res 12288 x 8192)");
            y += 20f;
            if (GUI.Button(new Rect(4, y, 70, 22), "X -")) sel.MapPxX -= 40f;
            if (GUI.Button(new Rect(78, y, 70, 22), "X +")) sel.MapPxX += 40f;
            if (GUI.Button(new Rect(156, y, 70, 22), "Y -")) sel.MapPxY -= 40f;
            if (GUI.Button(new Rect(230, y, 70, 22), "Y +")) sel.MapPxY += 40f;
            if (GUI.Button(new Rect(308, y, 180, 22), "Nudge applied")) ZilleWarTable.RequestApply();
            y += 28f;

            GUI.Label(new Rect(4, y, 200, 18), "<b>Allegiance</b>");
            y += 20f;
            if (GUI.Button(new Rect(4, y, 120, 22), sel.Allegiance == "Rizia" ? "[Rizia]" : "Rizia")) sel.Allegiance = "Rizia";
            if (GUI.Button(new Rect(130, y, 120, 22), sel.Allegiance == "Wehlen" ? "[Wehlen]" : "Wehlen")) sel.Allegiance = "Wehlen";
            if (GUI.Button(new Rect(256, y, 140, 22), sel.Allegiance == "Contested" ? "[Contested]" : "Contested")) sel.Allegiance = "Contested";
            y += 28f;

            bool reinf = GUI.Toggle(new Rect(4, y, 480, 20), sel.IsReinforcementTile, " Enemy reinforcement tile (vanilla waves may spawn here)");
            if (reinf != sel.IsReinforcementTile)
            {
                sel.IsReinforcementTile = reinf;
                ZilleWarTable.RequestApply();
            }
            y += 26f;

            if (GUI.Button(new Rect(4, y, 240, 26), "Write allegiance into the game"))
                _status = ZilleWarTable.PushTileSetup(sel);
            if (GUI.Button(new Rect(250, y, 240, 26), "Save layout"))
                _status = ZilleMapLayoutManager.SaveConfig() ? "Layout saved." : "Save failed.";
            y += 34f;

            if (GUI.Button(new Rect(4, y, 156, 28), "+ Add province"))
                _status = AddSome(1);
            if (GUI.Button(new Rect(166, y, 156, 28), "+ Add 4"))
                _status = AddSome(4);
            if (GUI.Button(new Rect(328, y, 166, 28), "- Remove selected"))
            {
                if (ZilleMapLayoutManager.RemoveProvinceAt(_prov))
                {
                    _prov = Mathf.Clamp(_prov, 0, Tiles().Count - 1);
                    _status = "Province removed from the layout. Its vanilla tile is hidden until you leave Zille.";
                }
                else _status = "Need at least one province.";
            }
            y += 34f;
            GUI.Label(new Rect(4, y, 490, 48), "<size=11>Added provinces reuse unused Pales tiles (Tile_6 onward, then sea tiles). The shader still paints them; the red/green PNG is only the mask. F4 still nudges with the keyboard.</size>");
        }

        private void DrawUnits()
        {
            float y = 4f;
            EnsureUnitTypes();
            var tiles = Tiles();
            GUI.Label(new Rect(4, y, 490, 20), "<b>Place a unit on a province</b>");
            y += 22f;
            GUI.Label(new Rect(4, y, 490, 32), "<size=11>Deployment place uses the game's DeployToken. Story spawn uses the same call the war scripts use, so it also works after deployment is over.</size>");
            y += 36f;

            if (GUI.Button(new Rect(4, y, 150, 22), _side == "Player" ? "[My units]" : "My units")) _side = "Player";
            if (GUI.Button(new Rect(160, y, 150, 22), _side == "Enemy" ? "[Enemy]" : "Enemy")) _side = "Enemy";
            if (GUI.Button(new Rect(320, y, 170, 22), "Refresh unit types"))
            {
                _unitTypes.Clear();
                EnsureUnitTypes();
                _status = _unitTypes.Count + " unit types in memory.";
            }
            y += 28f;

            if (_unitTypes.Count == 0)
            {
                GUI.Label(new Rect(4, y, 490, 40), "No WarUnitTypeData loaded yet. Enter the war map once, then press Refresh.");
                y += 44f;
            }
            else
            {
                _unit = Mathf.Clamp(_unit, 0, _unitTypes.Count - 1);
                var ut = _unitTypes[_unit];
                if (GUI.Button(new Rect(4, y, 36, 22), "<")) _unit = (_unit + _unitTypes.Count - 1) % _unitTypes.Count;
                GUI.Label(new Rect(44, y, 410, 22), UnitLabel(ut));
                if (GUI.Button(new Rect(458, y, 36, 22), ">")) _unit = (_unit + 1) % _unitTypes.Count;
                y += 28f;
            }

            if (tiles.Count > 0)
            {
                _spawnTile = Mathf.Clamp(_spawnTile, 0, tiles.Count - 1);
                if (GUI.Button(new Rect(4, y, 36, 22), "<")) _spawnTile = (_spawnTile + tiles.Count - 1) % tiles.Count;
                GUI.Label(new Rect(44, y, 410, 22), "On: " + tiles[_spawnTile].Name + "  (Tile_" + tiles[_spawnTile].TileNumber + ")");
                if (GUI.Button(new Rect(458, y, 36, 22), ">")) _spawnTile = (_spawnTile + 1) % tiles.Count;
                y += 30f;
            }

            if (GUI.Button(new Rect(4, y, 240, 28), "Place now (deployment)"))
                _status = DeploySelected();
            if (GUI.Button(new Rect(250, y, 240, 28), "Story spawn"))
                _status = StorySpawnSelected();
            y += 36f;

            GUI.Label(new Rect(4, y, 490, 18), "<b>Units currently on the table</b>");
            y += 20f;
            y = DrawLiveTokens(y);
        }

        private void DrawReinforcements()
        {
            float y = 4f;
            EnsureUnitTypes();
            var tiles = Tiles();
            GUI.Label(new Rect(4, y, 490, 18), "<b>Arm a reinforcement trigger</b>");
            y += 20f;
            GUI.Label(new Rect(4, y, 490, 44), "<size=11>Start fires when the Zille map is up. Turn fires on that war turn. Allegiance fires when the watched province flips. Each armed order spawns once, through the story spawn path.</size>");
            y += 46f;

            if (GUI.Button(new Rect(4, y, 156, 22), _trigger == "Start" ? "[On map start]" : "On map start")) _trigger = "Start";
            if (GUI.Button(new Rect(166, y, 156, 22), _trigger == "Turn" ? "[On war turn]" : "On war turn")) _trigger = "Turn";
            if (GUI.Button(new Rect(328, y, 166, 22), _trigger == "Allegiance" ? "[On capture]" : "On capture")) _trigger = "Allegiance";
            y += 28f;

            if (_trigger == "Turn")
            {
                GUI.Label(new Rect(4, y, 490, 18), "War turn >= " + _turn);
                y += 18f;
                _turn = Mathf.RoundToInt(GUI.HorizontalSlider(new Rect(4, y, 490, 16), _turn, 1f, 8f));
                y += 22f;
            }
            else if (_trigger == "Allegiance" && tiles.Count > 0)
            {
                _watchTile = Mathf.Clamp(_watchTile, 0, tiles.Count - 1);
                if (GUI.Button(new Rect(4, y, 36, 22), "<")) _watchTile = (_watchTile + tiles.Count - 1) % tiles.Count;
                GUI.Label(new Rect(44, y, 300, 22), "Watch: " + tiles[_watchTile].Name);
                if (GUI.Button(new Rect(350, y, 36, 22), ">")) _watchTile = (_watchTile + 1) % tiles.Count;
                y += 26f;
                if (GUI.Button(new Rect(4, y, 150, 22), _watchSide == "Player" ? "[Becomes ours]" : "Becomes ours")) _watchSide = "Player";
                if (GUI.Button(new Rect(160, y, 170, 22), _watchSide == "Enemy" ? "[Becomes enemy]" : "Becomes enemy")) _watchSide = "Enemy";
                y += 28f;
            }

            GUI.Label(new Rect(4, y, 490, 18), "Spawns the unit and province chosen on the Units tab. Side: " + _side);
            y += 22f;
            if (GUI.Button(new Rect(4, y, 240, 26), "Arm this trigger"))
            {
                var order = BuildOrderFromSelection(_trigger);
                if (order == null) _status = "Pick a unit type and a province on the Units tab first.";
                else
                {
                    Orders().Add(order);
                    ZilleMapLayoutManager.SaveConfig();
                    _status = "Armed: " + order.Label;
                }
            }
            if (GUI.Button(new Rect(250, y, 240, 26), "Vanilla wave on supply line"))
                _status = VanillaWave();
            y += 34f;

            GUI.Label(new Rect(4, y, 490, 18), "<b>Armed orders</b>");
            y += 20f;
            var orders = Orders();
            if (orders.Count == 0) GUI.Label(new Rect(4, y, 480, 20), "None yet.");
            for (int i = 0; i < orders.Count; i++)
            {
                var o = orders[i];
                string flag = !o.Armed ? "off" : (o.Fired ? "fired" : "armed");
                GUI.Label(new Rect(4, y, 330, 22), $"<size=11>[{flag}] {o.Label}</size>");
                if (GUI.Button(new Rect(336, y, 52, 20), "Fire"))
                {
                    if (StorySpawn(o, out string msg)) { o.Fired = true; _status = msg; }
                    else _status = msg;
                }
                if (GUI.Button(new Rect(392, y, 52, 20), o.Armed ? "Disarm" : "Arm"))
                    o.Armed = !o.Armed;
                if (GUI.Button(new Rect(448, y, 46, 20), "Del"))
                {
                    orders.RemoveAt(i);
                    i--;
                }
                y += 24f;
            }
        }

        private float DrawLiveTokens(float y)
        {
            WarTokenManager mgr = null;
            try { mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>(); } catch { }
            if (mgr == null)
            {
                GUI.Label(new Rect(4, y, 480, 20), "WarTokenManager is not in the scene.");
                return y + 24f;
            }
            var list = mgr.GetWarTokens();
            if (list == null || list.Count == 0)
            {
                GUI.Label(new Rect(4, y, 480, 20), "No war tokens instantiated.");
                return y + 24f;
            }
            int shown = 0;
            for (int i = 0; i < list.Count && shown < 18; i++)
            {
                var tok = list[i];
                if (tok == null) continue;
                bool dead = false;
                try { dead = tok.IsDead(); } catch { }
                if (dead) continue;
                string unit = "?";
                string side = "?";
                try
                {
                    var ut = tok.GetWarUnitTypeData();
                    if (ut != null) unit = string.IsNullOrEmpty(ut.UnitName) ? ut.name : ut.UnitName;
                    side = tok.GetTokenAllegiance().ToString();
                }
                catch { }
                GUI.Label(new Rect(4, y, 390, 20), $"{side}  {unit}");
                if (GUI.Button(new Rect(400, y, 90, 20), "Remove"))
                {
                    try { mgr.DestroyToken(tok); _status = "Remove requested for " + unit + "."; }
                    catch (Exception ex) { _status = "Remove failed: " + ex.Message; }
                }
                y += 22f;
                shown++;
            }
            if (list.Count > shown) GUI.Label(new Rect(4, y, 400, 18), $"… {list.Count - shown} more not listed");
            return y;
        }

        private string AddSome(int count)
        {
            var tiles = Tiles();
            string anchor = tiles.Count > 0 ? tiles[Mathf.Clamp(_prov, 0, tiles.Count - 1)].Id : null;
            int made = 0;
            string last = "";
            for (int i = 0; i < count; i++)
            {
                var t = ZilleMapLayoutManager.AddProvinceNear(anchor, i);
                if (t == null) break;
                made++;
                last = ZilleWarTable.PushTileSetup(t);
                _prov = Tiles().Count - 1;
            }
            if (made == 0) return "No free vanilla tile numbers left (1-100 and S1-S33 are all claimed).";
            ZilleWarTable.RequestApply();
            return $"Added {made} province(s). {last}";
        }

        private string DeploySelected()
        {
            if (!TrySelection(out var ut, out var tile, out string err)) return err;
            var wt = ZilleWarTable.FindLiveTile(tile.TileNumber);
            if (wt == null) return "That tile is not on the live map. Open the Zille theatre (F6) first.";
            var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            if (mgr == null) return "WarTokenManager is not loaded.";
            try
            {
                var alleg = _side == "Enemy" ? WarToken.WarAllegiance.Enemy : WarToken.WarAllegiance.Player;
                ZilleWarTable.RunScripted(() => mgr.DeployToken(ut, wt, alleg));
                return $"DeployToken: {UnitLabel(ut)} on {tile.Name} ({_side}).";
            }
            catch (Exception ex)
            {
                return "DeployToken failed: " + ex.Message;
            }
        }

        private string StorySpawnSelected()
        {
            var order = BuildOrderFromSelection("Manual");
            if (order == null) return "Pick a unit type and a province first.";
            if (StorySpawn(order, out string msg)) return msg;
            return msg;
        }

        private static bool StorySpawn(ZilleUnitOrder order, out string msg)
        {
            msg = "";
            if (order == null) { msg = "No order."; return false; }
            try
            {
                var tiles = ZilleMapLayoutManager.CurrentConfig?.Tiles;
                ZilleTileData tile = null;
                if (tiles != null)
                    for (int i = 0; i < tiles.Count; i++)
                        if (tiles[i].Id == order.TileId) { tile = tiles[i]; break; }
                if (tile == null) { msg = "Order province is missing from the layout."; return false; }
                var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
                if (mgr == null) { msg = "WarTokenManager is not loaded."; return false; }
                string side = order.Side == "Enemy" ? "Enemy" : "Player";
                mgr.SpawnWarToken(order.UnitAssetName, tile.TileNumber, side);
                msg = $"Story spawn '{order.UnitAssetName}' on Tile_{tile.TileNumber} ({side}).";
                MelonLogger.Msg("[ZMENU] " + msg);
                return true;
            }
            catch (Exception ex)
            {
                msg = "Story spawn failed: " + ex.Message;
                return false;
            }
        }

        private string VanillaWave()
        {
            if (_unitTypes.Count == 0) return "Refresh unit types first.";
            _unit = Mathf.Clamp(_unit, 0, _unitTypes.Count - 1);
            var mgr = UnityEngine.Object.FindObjectOfType<WarTokenManager>();
            if (mgr == null) return "WarTokenManager is not loaded.";
            try
            {
                mgr.SpawnEnemyReinforcementTokenOnSupplyLine(_unitTypes[_unit].name);
                return "Asked the game to spawn an enemy reinforcement (" + _unitTypes[_unit].name + ") on a supply line.";
            }
            catch (Exception ex)
            {
                return "Vanilla wave failed: " + ex.Message;
            }
        }

        private ZilleUnitOrder BuildOrderFromSelection(string trigger)
        {
            if (!TrySelection(out var ut, out var tile, out _)) return null;
            var tiles = Tiles();
            string watchId = "";
            if (tiles.Count > 0)
            {
                _watchTile = Mathf.Clamp(_watchTile, 0, tiles.Count - 1);
                watchId = tiles[_watchTile].Id;
            }
            string when = trigger;
            if (trigger == "Turn") when = "Turn " + _turn;
            else if (trigger == "Allegiance") when = "When " + (tiles.Count > 0 ? tiles[_watchTile].Name : "?") + " -> " + _watchSide;
            return new ZilleUnitOrder
            {
                Id = "ord_" + DateTime.UtcNow.Ticks,
                Label = _side + " " + ut.name + " @ " + tile.Name + " (" + when + ")",
                Side = _side,
                UnitAssetName = ut.name,
                TileId = tile.Id,
                Trigger = trigger,
                Turn = _turn,
                WatchTileId = watchId,
                WatchAllegiance = _watchSide,
                Armed = trigger != "Manual",
                Fired = false
            };
        }

        private bool TrySelection(out WarUnitTypeData ut, out ZilleTileData tile, out string err)
        {
            ut = null;
            tile = null;
            err = "";
            EnsureUnitTypes();
            var tiles = Tiles();
            if (_unitTypes.Count == 0) { err = "No unit types loaded. Enter the war map and press Refresh."; return false; }
            if (tiles.Count == 0) { err = "No provinces."; return false; }
            _unit = Mathf.Clamp(_unit, 0, _unitTypes.Count - 1);
            _spawnTile = Mathf.Clamp(_spawnTile, 0, tiles.Count - 1);
            ut = _unitTypes[_unit];
            tile = tiles[_spawnTile];
            if (ut == null) { err = "Unit type was unloaded. Press Refresh."; return false; }
            return true;
        }

        private void EnsureUnitTypes()
        {
            if (_unitTypes.Count > 0 && _unitTypes[0] != null) return;
            _unitTypes.Clear();
            WarUnitTypeData[] all = null;
            try { all = Resources.FindObjectsOfTypeAll<WarUnitTypeData>(); } catch { }
            if (all == null) return;
            var seen = new HashSet<string>();
            for (int i = 0; i < all.Length; i++)
            {
                var u = all[i];
                if (u == null || string.IsNullOrEmpty(u.name)) continue;
                if (!seen.Add(u.name)) continue;
                _unitTypes.Add(u);
            }
            _unitTypes.Sort((a, b) => string.Compare(a.name, b.name, StringComparison.Ordinal));
        }

        private static string UnitLabel(WarUnitTypeData ut)
        {
            if (ut == null) return "(none)";
            string nice = ut.name;
            try { if (!string.IsNullOrEmpty(ut.UnitName)) nice = ut.UnitName; } catch { }
            string kind = ut.unitType.ToString();
            return nice + "   [" + ut.name + " / " + kind + "]";
        }

        private static bool AllegianceMatches(ZilleUnitOrder order)
        {
            if (string.IsNullOrEmpty(order.WatchTileId)) return false;
            var tiles = ZilleMapLayoutManager.CurrentConfig?.Tiles;
            if (tiles == null) return false;
            ZilleTileData td = null;
            for (int i = 0; i < tiles.Count; i++)
                if (tiles[i].Id == order.WatchTileId) { td = tiles[i]; break; }
            if (td == null) return false;
            var wt = ZilleWarTable.FindLiveTile(td.TileNumber);
            if (wt == null || !wt.gameObject.activeInHierarchy) return false;
            var have = wt.GetTileAllegiance();
            if (order.WatchAllegiance == "Player") return have == WarToken.WarAllegiance.Player;
            return have == WarToken.WarAllegiance.Enemy;
        }

        private static List<ZilleTileData> Tiles()
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg == null) return new List<ZilleTileData>();
            if (cfg.Tiles == null) cfg.Tiles = new List<ZilleTileData>();
            return cfg.Tiles;
        }

        private static List<ZilleUnitOrder> Orders()
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg.Orders == null) cfg.Orders = new List<ZilleUnitOrder>();
            return cfg.Orders;
        }

        private static int CountFree()
        {
            int n = 0;
            var used = new HashSet<string>();
            var tiles = Tiles();
            for (int i = 0; i < tiles.Count; i++)
                if (!string.IsNullOrEmpty(tiles[i].TileNumber)) used.Add(tiles[i].TileNumber);
            for (int i = 1; i <= 100; i++) if (!used.Contains(i.ToString())) n++;
            for (int i = 1; i <= 33; i++) if (!used.Contains("S" + i)) n++;
            return n;
        }
    }
}
