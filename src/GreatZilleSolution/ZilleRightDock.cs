using System;
using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace GreatZilleSolution
{
    /// <summary>
    /// Small authoring strip on the right of the war table: coastal guns, no-air zones,
    /// no-landing zones, and reinforcement triggers. Rects only — GUILayout is stripped in this build.
    /// </summary>
    public static class ZilleRightDock
    {
        private static int _unit;
        private static int _turn = 2;
        private static string _trigger = "Turn";
        private static string _side = "Player";
        private static string _status = "Kliknij prowincje, potem strefe albo trigger.";
        private static int _orderScroll;

        public static void Draw()
        {
            if (!ZilleWarTable.HasLiveMap || !ZilleWarTable.SkinEnabled || ZilleWarTable.NativeDeploymentOpen()) return;
            if (ZilleWarMapEditorUI.AnyOpen) return;
            float x = Screen.width - 248f;
            float y = 48f;
            GUI.Box(new Rect(x, y, 236f, 360f), "Zille — strefy i triggery");
            var td = ZilleWarTable.SelectedProvince;
            GUI.Label(new Rect(x + 8f, y + 22f, 220f, 18f), td == null ? "Brak prowincji" : "<b>" + td.Name + "</b>");
            float row = y + 42f;
            if (td != null)
            {
                if (GUI.Button(new Rect(x + 8f, row, 220f, 22f), td.HasCoastalArtillery ? "[Obrona wybrzeza]" : "Obrona wybrzeza"))
                {
                    ZilleWarTable.ToggleZone(td, "coast");
                    _status = td.Name + (td.HasCoastalArtillery ? ": dziala wybrzeza." : ": zdjeto dziala.");
                }
                row += 24f;
                if (GUI.Button(new Rect(x + 8f, row, 220f, 22f), td.HasNoAirZone ? "[Strefa bez lotow]" : "Strefa bez lotow"))
                {
                    ZilleWarTable.ToggleZone(td, "air");
                    _status = td.Name + (td.HasNoAirZone ? ": zakaz lotow." : ": loty dozwolone.");
                }
                row += 24f;
                if (GUI.Button(new Rect(x + 8f, row, 220f, 22f), td.HasNoNavalLanding ? "[Zakaz desantu]" : "Zakaz desantu"))
                {
                    ZilleWarTable.ToggleZone(td, "naval");
                    _status = td.Name + (td.HasNoNavalLanding ? ": desant zablokowany." : ": desant dozwolony.");
                }
                row += 28f;
            }

            GUI.Label(new Rect(x + 8f, row, 220f, 18f), "<b>Trigger jednostki</b>");
            row += 20f;
            var types = ZilleWarTable.UnitTypes();
            if (types != null && types.Count > 0)
            {
                _unit = Mathf.Clamp(_unit, 0, types.Count - 1);
                if (GUI.Button(new Rect(x + 8f, row, 24f, 22f), "<")) _unit = (_unit + types.Count - 1) % types.Count;
                string uname = types[_unit] != null ? (types[_unit].UnitName ?? types[_unit].name) : "?";
                GUI.Label(new Rect(x + 36f, row, 150f, 22f), uname);
                if (GUI.Button(new Rect(x + 190f, row, 24f, 22f), ">")) _unit = (_unit + 1) % types.Count;
                row += 26f;
            }
            if (GUI.Button(new Rect(x + 8f, row, 70f, 22f), _side == "Player" ? "[Rizia]" : "Rizia")) _side = "Player";
            if (GUI.Button(new Rect(x + 82f, row, 78f, 22f), _side == "Enemy" ? "[Wehlen]" : "Wehlen")) _side = "Enemy";
            row += 26f;
            if (GUI.Button(new Rect(x + 8f, row, 68f, 22f), _trigger == "Start" ? "[Start]" : "Start")) _trigger = "Start";
            if (GUI.Button(new Rect(x + 80f, row, 64f, 22f), _trigger == "Turn" ? "[Tura]" : "Tura")) _trigger = "Turn";
            if (GUI.Button(new Rect(x + 148f, row, 76f, 22f), _trigger == "Manual" ? "[Reczny]" : "Reczny")) _trigger = "Manual";
            row += 26f;
            if (_trigger == "Turn")
            {
                if (GUI.Button(new Rect(x + 8f, row, 24f, 22f), "-")) _turn = Mathf.Max(1, _turn - 1);
                GUI.Label(new Rect(x + 36f, row, 80f, 22f), "Tura " + _turn);
                if (GUI.Button(new Rect(x + 120f, row, 24f, 22f), "+")) _turn++;
                row += 26f;
            }
            if (GUI.Button(new Rect(x + 8f, row, 220f, 22f), "Dodaj trigger") && td != null && types != null && types.Count > 0 && types[_unit] != null)
                AddOrder(td, types[_unit]);
            row += 26f;

            var orders = ZilleMapLayoutManager.CurrentConfig?.Orders;
            if (orders != null && orders.Count > 0)
            {
                int shown = Mathf.Min(3, orders.Count);
                _orderScroll = Mathf.Clamp(_orderScroll, 0, Mathf.Max(0, orders.Count - shown));
                for (int n = 0; n < shown; n++)
                {
                    int i = _orderScroll + n;
                    if (i >= orders.Count) break;
                    var o = orders[i];
                    if (o == null) continue;
                    GUI.Label(new Rect(x + 8f, row, 180f, 20f), "<size=10>" + o.Label + "</size>");
                    if (GUI.Button(new Rect(x + 190f, row, 22f, 18f), "x"))
                    {
                        orders.RemoveAt(i);
                        ZilleMapLayoutManager.SaveConfig();
                    }
                    row += 20f;
                }
            }
            GUI.Label(new Rect(x + 8f, y + 332f, 220f, 22f), "<size=10>" + _status + "</size>");
        }

        private static void AddOrder(ZilleTileData td, WarUnitTypeData ut)
        {
            var cfg = ZilleMapLayoutManager.CurrentConfig;
            if (cfg.Orders == null) cfg.Orders = new List<ZilleUnitOrder>();
            string when = _trigger == "Turn" ? "Tura " + _turn : _trigger;
            cfg.Orders.Add(new ZilleUnitOrder
            {
                Id = "ord_" + DateTime.UtcNow.Ticks,
                Label = (_side == "Enemy" ? "Wehlen " : "Rizia ") + (ut.UnitName ?? ut.name) + " @ " + td.Name + " (" + when + ")",
                Side = _side,
                UnitAssetName = ut.name,
                TileId = td.Id,
                Trigger = _trigger,
                Turn = _turn,
                Armed = _trigger != "Manual",
                Fired = false
            });
            ZilleMapLayoutManager.SaveConfig();
            _status = "Trigger zapisany: " + td.Name + ", " + when + ".";
        }
    }
}
