using System;
using System.Collections.Generic;
using UnityEngine;
using Il2Cpp;

namespace GreatZilleSolution
{
    public class ZilleWarMapEditorUI
    {
        public static bool AnyOpen { get; private set; }
        private bool _open;
        public bool IsOpen
        {
            get => _open;
            set { _open = value; AnyOpen = value; }
        }

        private Rect _windowRect = new Rect(30, 20, 1130, 760);
        private int _selectedTileIndex = 0;
        private bool _isDraggingTile = false;
        private int _draggedTileIndex = -1;
        private Vector2 _dragOffset;
        private Texture2D _whitePixel;
        private Vector2 _inspectorScroll = Vector2.zero;

        // Zoom & Pan controls for map canvas
        private float _zoom = 1.0f;
        private Vector2 _pan = Vector2.zero;
        private bool _isPanning = false;
        private Vector2 _lastMousePos;
        private int _unitPick;
        private bool _spawnEnemy;
        private int _unitKind;
        private string _spawnStatus = "Wybierz region, strone i jednostke.";
        private int _roadSourceIndex = -1;
        private readonly List<WarUnitTypeData> _units = new List<WarUnitTypeData>();

        public void Initialize()
        {
            if (_whitePixel == null)
            {
                _whitePixel = new Texture2D(1, 1, TextureFormat.RGBA32, false);
                _whitePixel.SetPixel(0, 0, Color.white);
                _whitePixel.Apply();
            }

            // Ensure textures are loaded via active graphics pipeline
            ZilleMapLayoutManager.EnsureTexturesLoaded();
        }

        public void DrawGUI()
        {
            if (!IsOpen) return;
            Initialize();
            _windowRect = GUI.Window(9902, _windowRect, (GUI.WindowFunction)DrawWindowContent, "[Zille War Engine] Full Map & Region Layout Editor | JIFO (jifo.dev)");
        }

        private void DrawWindowContent(int id)
        {
            var config = ZilleMapLayoutManager.CurrentConfig;
            var tiles = config.Tiles;

            // ================= TOP TOOLBAR =================
            GUI.Label(new Rect(15, 24, 250, 24), "<b>Zille Full Map (6 Kafelkow Grid)</b>");
            
            // Zoom Controls
            if (GUI.Button(new Rect(260, 22, 30, 26), "-"))
            {
                _zoom = Mathf.Clamp(_zoom - 0.15f, 0.4f, 3.0f);
            }
            GUI.Label(new Rect(295, 26, 75, 20), $"Zoom: {Mathf.RoundToInt(_zoom * 100)}%");
            if (GUI.Button(new Rect(375, 22, 30, 26), "+"))
            {
                _zoom = Mathf.Clamp(_zoom + 0.15f, 0.4f, 3.0f);
            }
            if (GUI.Button(new Rect(410, 22, 75, 26), "100% (Reset)"))
            {
                _zoom = 1.0f;
                _pan = Vector2.zero;
            }

            if (GUI.Button(new Rect(495, 22, 105, 26), "Zapisz uklad"))
            {
                if (ZilleMapLayoutManager.SaveConfig())
                    DialogueHelper.ShowAlert("[Zille Map] Uklad regionow pomyslnie zapisany.");
            }
            if (GUI.Button(new Rect(605, 22, 75, 26), "Wczytaj"))
            {
                ZilleMapLayoutManager.ReloadSavedLayout();
            }
            if (GUI.Button(new Rect(685, 22, 140, 26), "Uklad 4 Miast"))
            {
                ZilleMapLayoutManager.CurrentConfig = ZilleMapLayoutManager.CreateDefaultConfig();
                ZilleMapLayoutManager.SaveConfig();
            }
            if (GUI.Button(new Rect(1015, 22, 95, 26), "Zamknij (F10)"))
            {
                IsOpen = false;
            }

            // ================= LEFT: MAP CANVAS VIEWPORT (750x610) =================
            Rect canvasViewport = new Rect(15, 55, 750, 615);
            GUI.Box(canvasViewport, GUIContent.none);

            Event currentEvent = Event.current;
            Vector2 mousePos = currentEvent.mousePosition;

            // Handle Zoom via ScrollWheel over canvas
            if (canvasViewport.Contains(mousePos))
            {
                if (currentEvent.type == EventType.ScrollWheel)
                {
                    float zoomDelta = -currentEvent.delta.y * 0.08f;
                    _zoom = Mathf.Clamp(_zoom + zoomDelta, 0.4f, 3.0f);
                    currentEvent.Use();
                }

                // Pan with Right Mouse Button (button 1) or Middle Mouse Button (button 2)
                if (currentEvent.type == EventType.MouseDown && (currentEvent.button == 1 || currentEvent.button == 2))
                {
                    _isPanning = true;
                    _lastMousePos = mousePos;
                    currentEvent.Use();
                }
            }

            if (_isPanning)
            {
                if (currentEvent.type == EventType.MouseDrag)
                {
                    _pan += mousePos - _lastMousePos;
                    _lastMousePos = mousePos;
                    currentEvent.Use();
                }
                else if (currentEvent.type == EventType.MouseUp)
                {
                    _isPanning = false;
                }
            }

            // Begin Group clipping for Canvas
            GUI.BeginGroup(canvasViewport);

            // Virtual map size inside group: 3:2 aspect ratio (750x500 base)
            float baseW = 750f;
            float baseH = 500f;
            float mapW = baseW * _zoom;
            float mapH = baseH * _zoom;
            Vector2 mapCenter = new Vector2(baseW * 0.5f, 615f * 0.5f) + _pan;
            Rect mapRect = new Rect(mapCenter.x - mapW * 0.5f, mapCenter.y - mapH * 0.5f, mapW, mapH);

            // Draw Background Map Texture: 6 individual tiles 3x2 grid takes priority, fallback to composite
            if (ZilleMapLayoutManager.GridMapTiles != null && ZilleMapLayoutManager.GridMapTiles.Count == 6)
            {
                float cellW = mapRect.width / 3f;
                float cellH = mapRect.height / 2f;
                // Top row (y: 0..0.5): 01, 02, 03
                GUI.DrawTexture(new Rect(mapRect.x + 0f * cellW, mapRect.y + 0f * cellH, cellW, cellH), ZilleMapLayoutManager.GridMapTiles[1], ScaleMode.StretchToFill);
                GUI.DrawTexture(new Rect(mapRect.x + 1f * cellW, mapRect.y + 0f * cellH, cellW, cellH), ZilleMapLayoutManager.GridMapTiles[2], ScaleMode.StretchToFill);
                GUI.DrawTexture(new Rect(mapRect.x + 2f * cellW, mapRect.y + 0f * cellH, cellW, cellH), ZilleMapLayoutManager.GridMapTiles[3], ScaleMode.StretchToFill);
                // Bottom row (y: 0.5..1.0): 04, 05, 06
                GUI.DrawTexture(new Rect(mapRect.x + 0f * cellW, mapRect.y + 1f * cellH, cellW, cellH), ZilleMapLayoutManager.GridMapTiles[4], ScaleMode.StretchToFill);
                GUI.DrawTexture(new Rect(mapRect.x + 1f * cellW, mapRect.y + 1f * cellH, cellW, cellH), ZilleMapLayoutManager.GridMapTiles[5], ScaleMode.StretchToFill);
                GUI.DrawTexture(new Rect(mapRect.x + 2f * cellW, mapRect.y + 1f * cellH, cellW, cellH), ZilleMapLayoutManager.GridMapTiles[6], ScaleMode.StretchToFill);
            }
            else if (ZilleMapLayoutManager.MapBackgroundTexture != null)
            {
                GUI.DrawTexture(mapRect, ZilleMapLayoutManager.MapBackgroundTexture, ScaleMode.StretchToFill);
            }
            else
            {
                GUI.Box(mapRect, "Loading Zille map texture (6 tiles)...");
            }

            // Mouse position relative to group
            Vector2 localMousePos = mousePos - new Vector2(canvasViewport.x, canvasViewport.y);

            // 1. Draw Adjacency Connection Lines
            for (int i = 0; i < tiles.Count; i++)
            {
                var tileA = tiles[i];
                Vector2 posA = GetTileCenterLocal(tileA, mapRect);

                if (tileA.AdjacentIds != null)
                {
                    foreach (var neighborId in tileA.AdjacentIds)
                    {
                        var neighbor = tiles.Find(t => t.Id == neighborId);
                        if (neighbor != null)
                        {
                            Vector2 posB = GetTileCenterLocal(neighbor, mapRect);
                            Color lineColor = (i == _selectedTileIndex || tiles.IndexOf(neighbor) == _selectedTileIndex)
                                ? new Color(1f, 0.85f, 0.2f, 0.95f)
                                : new Color(0.2f, 0.8f, 1f, 0.65f);
                            DrawLine(posA, posB, lineColor, 3.5f * Mathf.Clamp(_zoom, 0.7f, 1.8f));
                        }
                    }
                }
            }

            // 2. Draw Tiles & Handle Dragging
            for (int i = 0; i < tiles.Count; i++)
            {
                var tile = tiles[i];
                Rect tileRect = GetTileRectLocal(tile, mapRect);

                // Mouse Down on Tile (Left Click = Select & Drag)
                if (!ZilleWarTable.LayoutLocked && currentEvent.type == EventType.MouseDown && currentEvent.button == 0 && tileRect.Contains(localMousePos))
                {
                    if (_roadSourceIndex >= 0 && _roadSourceIndex != i && _roadSourceIndex < tiles.Count)
                    {
                        var from = tiles[_roadSourceIndex];
                        ZilleMapLayoutManager.ToggleRoad(from, tile);
                        _roadSourceIndex = -1;
                        _spawnStatus = "Droga: " + from.Name + " — " + tile.Name + ".";
                        currentEvent.Use();
                        _selectedTileIndex = i;
                        continue;
                    }
                    _selectedTileIndex = i;
                    _isDraggingTile = true;
                    _draggedTileIndex = i;
                    _dragOffset = localMousePos - new Vector2(tileRect.x, tileRect.y);
                    currentEvent.Use();
                }

                // Dragging Tile
                if (!ZilleWarTable.LayoutLocked && _isDraggingTile && _draggedTileIndex == i && currentEvent.type == EventType.MouseDrag)
                {
                    float newPxX = localMousePos.x - _dragOffset.x + tileRect.width * 0.5f;
                    float newPxY = localMousePos.y - _dragOffset.y + tileRect.height * 0.5f;

                    tile.NormalizedX = Mathf.Clamp01((newPxX - mapRect.x) / mapRect.width);
                    tile.NormalizedY = Mathf.Clamp01((newPxY - mapRect.y) / mapRect.height);
                    ZilleWarTable.CommitEditorPosition(tile);
                    currentEvent.Use();
                }

                // Tile Background Backing
                Color allegColor = GetAllegianceColor(tile.Allegiance);
                Color backColor = allegColor;
                backColor.a = ZilleWarTable.LayoutLocked ? 0.25f : 0.28f;
                DrawSolidRect(tileRect, backColor);

                // Draw Tile Texture
                Texture2D tileTex = null;
                if (!string.IsNullOrEmpty(tile.TextureFile) && ZilleMapLayoutManager.LoadedTextures.ContainsKey(tile.TextureFile))
                {
                    tileTex = ZilleMapLayoutManager.LoadedTextures[tile.TextureFile];
                }

                if (tileTex != null)
                {
                    Color savedTex = GUI.color;
                    if (ZilleWarTable.LayoutLocked) GUI.color = new Color(1f, 1f, 1f, 0.25f);
                    GUI.DrawTexture(tileRect, tileTex, ScaleMode.ScaleToFit);
                    GUI.color = savedTex;
                }

                // Outline
                if (i == _selectedTileIndex)
                {
                    DrawRectOutline(tileRect, Color.yellow, 3f);
                }
                else
                {
                    DrawRectOutline(tileRect, allegColor, 1.5f);
                }

                // Names only on the selected province once the full partition is on the table,
                // otherwise the labels sit on top of the map.
                if (i == _selectedTileIndex || tiles.Count <= 12)
                {
                    Color savedC = GUI.color;
                    GUI.color = allegColor;
                    GUI.Label(new Rect(tileRect.x - 30, tileRect.yMax - 4, tileRect.width + 60, 22),
                        $"<b>{tile.Name}</b>");
                    GUI.color = savedC;
                }
            }

            if (currentEvent.type == EventType.MouseUp)
            {
                _isDraggingTile = false;
                _draggedTileIndex = -1;
            }

            GUI.EndGroup();

            // Outline around viewport
            DrawRectOutline(canvasViewport, new Color(0.4f, 0.35f, 0.25f, 0.9f), 2f);

            // Help tooltip under canvas
            string lockHint = ZilleWarTable.LayoutLocked
                ? "Uklad ZABLOKOWANY. Regiony sa na 25% opacity i nie da sie ich przesuwac."
                : "LPM: Przesun sektor | PPM / SPM: Pan | Kolko: Zoom";
            GUI.Label(new Rect(20, 672, 740, 20), "<size=11><color=#a0aec0>" + lockHint + "</color></size>");

            // ================= RIGHT: INSPECTOR & CONTROLS =================
            Rect inspectorBox = new Rect(780, 55, 335, 360);
            GUI.Box(inspectorBox, GUIContent.none);

            float scrollHeight = 420f + (tiles.Count * 24f);
            _inspectorScroll = GUI.BeginScrollView(
                new Rect(785, 60, 325, 350),
                _inspectorScroll,
                new Rect(0, 0, 305, scrollHeight)
            );

            float iy = 4f;
            bool locked = ZilleWarTable.LayoutLocked;
            if (GUI.Button(new Rect(4, iy, 295, 26), locked ? "[Uklad zablokowany]" : "Zablokuj uklad"))
            {
                ZilleWarTable.LayoutLocked = !ZilleWarTable.LayoutLocked;
                ZilleWarTable.RequestApply();
            }
            iy += 30f;
            GUI.Label(new Rect(4, iy, 295, 32), "<size=10>" + (locked
                ? "Kazdy region ma 25% opacity. Przesuwanie jest wylaczone."
                : "Po zablokowaniu regiony bledna i nie da sie ich ruszyc.") + "</size>");
            iy += 34f;

            if (tiles.Count > 0 && _selectedTileIndex >= 0 && _selectedTileIndex < tiles.Count)
            {
                var selTile = tiles[_selectedTileIndex];

                GUI.Label(new Rect(4, iy, 300, 20), "<b>--- INSPEKTOR REGIONU ---</b>"); iy += 24f;
                GUI.Label(new Rect(4, iy, 300, 20), $"<b>ID:</b> {selTile.Id}"); iy += 22f;

                GUI.Label(new Rect(4, iy, 60, 20), "Nazwa:");
                selTile.Name = GUI.TextField(new Rect(65, iy, 235, 20), selTile.Name); iy += 26f;

                // Texture file buttons
                GUI.Label(new Rect(4, iy, 300, 18), "<b>Tekstura regionu:</b>"); iy += 20f;
                for (int f = 41; f <= 45; f++)
                {
                    string fname = $"Frame {f}.png";
                    bool isCur = selTile.TextureFile == fname;
                    Color bc = GUI.color;
                    if (isCur) GUI.color = Color.cyan;
                    if (GUI.Button(new Rect(4 + (f - 41) * 60, iy, 56, 24), $"{f}"))
                    {
                        selTile.TextureFile = fname;
                    }
                    GUI.color = bc;
                }
                iy += 30f;

                // Position X
                GUI.Label(new Rect(4, iy, 300, 18), $"<b>Pozycja X:</b> {selTile.NormalizedX:F3}"); iy += 18f;
                float nx = GUI.HorizontalSlider(new Rect(4, iy, 290, 18), selTile.NormalizedX, 0.05f, 0.95f);
                if (!locked && Mathf.Abs(nx - selTile.NormalizedX) > 0.0001f)
                {
                    selTile.NormalizedX = nx;
                    ZilleWarTable.CommitEditorPosition(selTile);
                }
                iy += 22f;

                // Position Y
                GUI.Label(new Rect(4, iy, 300, 18), $"<b>Pozycja Y:</b> {selTile.NormalizedY:F3}"); iy += 18f;
                float ny = GUI.HorizontalSlider(new Rect(4, iy, 290, 18), selTile.NormalizedY, 0.05f, 0.95f);
                if (!locked && Mathf.Abs(ny - selTile.NormalizedY) > 0.0001f)
                {
                    selTile.NormalizedY = ny;
                    ZilleWarTable.CommitEditorPosition(selTile);
                }
                iy += 22f;

                // Size
                float displayWidth = (selTile.Width > 100f) ? 512f : selTile.Width;
                GUI.Label(new Rect(4, iy, 300, 18), $"<b>Rozmiar:</b> {displayWidth:F0}px (Asset 512x512)"); iy += 18f;
                float sliderVal = (selTile.Width > 100f) ? (selTile.Width / 512f) * 48f : selTile.Width;
                float newSize = GUI.HorizontalSlider(new Rect(4, iy, 290, 18), sliderVal, 20f, 90f);
                if (!locked && Mathf.Abs(newSize - sliderVal) > 0.5f)
                {
                    selTile.Width = (newSize / 48f) * 512f;
                    selTile.Height = selTile.Width;
                }
                iy += 24f;

                GUI.Label(new Rect(4, iy, 300, 18), $"<b>Skala w grze (3D):</b> {selTile.WorldScale:F3}"); iy += 18f;
                float shownWorld = selTile.WorldScale <= 0f ? 0.22f : selTile.WorldScale;
                float newWorld = GUI.HorizontalSlider(new Rect(4, iy, 290, 18), shownWorld, 0.05f, 0.70f);
                if (!locked && Mathf.Abs(newWorld - selTile.WorldScale) > 0.0005f)
                {
                    selTile.WorldScale = newWorld;
                    ZilleWarTable.RequestApply();
                }
                iy += 24f;

                // Allegiance selector
                GUI.Label(new Rect(4, iy, 300, 18), "<b>Frakcja kontrolujaca:</b>"); iy += 20f;
                if (GUI.Button(new Rect(4, iy, 95, 24), selTile.Allegiance == "Rizia" ? "[V Rizia]" : "Rizia"))
                { selTile.Allegiance = "Rizia"; ZilleWarTable.RequestApply(); }
                if (GUI.Button(new Rect(103, iy, 95, 24), selTile.Allegiance == "Wehlen" ? "[V Wehlen]" : "Wehlen"))
                { selTile.Allegiance = "Wehlen"; ZilleWarTable.RequestApply(); }
                if (GUI.Button(new Rect(202, iy, 95, 24), selTile.Allegiance == "EmptySea" ? "[V Morze]" : "Morze"))
                { selTile.Allegiance = "EmptySea"; ZilleWarTable.RequestApply(); }
                iy += 30f;

                // Strategic attributes
                GUI.Label(new Rect(4, iy, 300, 18), "<b>Wlasciwosci taktyczne:</b>"); iy += 20f;
                selTile.IsSupplyHub = GUI.Toggle(new Rect(4, iy, 290, 20), selTile.IsSupplyHub, " Wezel zaopatrzenia (Hub)"); iy += 22f;
                selTile.IsPort = GUI.Toggle(new Rect(4, iy, 290, 20), selTile.IsPort, " Port morski"); iy += 22f;
                bool air = GUI.Toggle(new Rect(4, iy, 290, 20), selTile.IsAirfield, " Lotnisko wojskowe");
                if (air != selTile.IsAirfield) { selTile.IsAirfield = air; ZilleWarTable.RequestApply(); }
                iy += 24f;

                // Fort level
                GUI.Label(new Rect(4, iy, 120, 20), $"Fortyfikacje: {selTile.FortLevel}");
                if (GUI.Button(new Rect(130, iy, 30, 20), "-") && selTile.FortLevel > 0) selTile.FortLevel--;
                if (GUI.Button(new Rect(165, iy, 30, 20), "+") && selTile.FortLevel < 3) selTile.FortLevel++;
                iy += 28f;

                // ============ ADJACENCY / CONNECTIONS ============
                GUI.Box(new Rect(4, iy, 295, 2f), GUIContent.none); iy += 6f;
                GUI.Label(new Rect(4, iy, 300, 18), "<b>Polaczenia z innymi regionami:</b>"); iy += 18f;
                GUI.Label(new Rect(4, iy, 300, 16), "<size=10>Kliknij aby polaczyc/rozlaczyc linie frontu:</size>"); iy += 18f;

                for (int o = 0; o < tiles.Count; o++)
                {
                    if (o == _selectedTileIndex) continue;
                    var other = tiles[o];
                    bool isConnected = selTile.AdjacentIds != null && selTile.AdjacentIds.Contains(other.Id);
                    bool hasRoad = selTile.RoadToIds != null && selTile.RoadToIds.Contains(other.Id);
                    bool toggle = GUI.Toggle(new Rect(8, iy, 200, 20), isConnected, $" Polacz: {other.Name}");
                    if (isConnected)
                    {
                        bool roadNow = GUI.Toggle(new Rect(210, iy, 80, 20), hasRoad, hasRoad ? "[Droga]" : "Droga");
                        if (roadNow != hasRoad)
                        {
                            ZilleMapLayoutManager.ToggleRoad(selTile, other);
                            ZilleWarTable.InvalidateRoads();
                        }
                    }
                    iy += 22f;

                    if (toggle != isConnected)
                    {
                        if (toggle)
                        {
                            if (!selTile.AdjacentIds.Contains(other.Id)) selTile.AdjacentIds.Add(other.Id);
                            if (!other.AdjacentIds.Contains(selTile.Id)) other.AdjacentIds.Add(selTile.Id);
                        }
                        else
                        {
                            selTile.AdjacentIds.Remove(other.Id);
                            other.AdjacentIds.Remove(selTile.Id);
                        }
                    }
                }
            }

            GUI.EndScrollView();

            if (tiles.Count > 0 && _selectedTileIndex >= 0 && _selectedTileIndex < tiles.Count)
                DrawUnitPlacement(tiles[_selectedTileIndex]);

            // Bottom action buttons under Inspector
            float botY = 720f;
            if (GUI.Button(new Rect(780, botY, 160, 30), "+ Nowy Region"))
            {
                string anchor = tiles.Count > 0 ? tiles[Mathf.Clamp(_selectedTileIndex, 0, tiles.Count - 1)].Id : null;
                var added = ZilleMapLayoutManager.AddProvinceNear(anchor, 0);
                if (added != null) _selectedTileIndex = tiles.Count - 1;
            }

            if (GUI.Button(new Rect(955, botY, 160, 30), "- Usun Region") && tiles.Count > 1)
            {
                if (ZilleMapLayoutManager.RemoveProvinceAt(_selectedTileIndex))
                    _selectedTileIndex = Mathf.Clamp(_selectedTileIndex, 0, tiles.Count - 1);
            }

            GUI.DragWindow(new Rect(0, 0, 1130, 24));
        }

        private void DrawUnitPlacement(ZilleTileData selTile)
        {
            EnsureUnits();
            const float x = 785f;
            float y = 420f;
            GUI.Box(new Rect(780, y, 335, 248), GUIContent.none);
            y += 4f;
            GUI.Label(new Rect(x, y, 320, 18), "<b>Stawianie na mapie — " + selTile.Name + "</b>");
            y += 20f;
            if (GUI.Button(new Rect(x, y, 155, 22), _spawnEnemy ? "Rizia" : "[Rizia]")) _spawnEnemy = false;
            if (GUI.Button(new Rect(x + 160, y, 155, 22), _spawnEnemy ? "[Wehlen]" : "Wehlen")) _spawnEnemy = true;
            y += 26f;

            string[] kinds = { "Wszystkie", "Miasta", "Lotniska", "Wojska" };
            for (int k = 0; k < kinds.Length; k++)
            {
                if (GUI.Button(new Rect(x + k * 78, y, 76, 20), _unitKind == k ? "[" + kinds[k] + "]" : kinds[k]))
                {
                    _unitKind = k;
                    _unitPick = 0;
                }
            }
            y += 24f;

            var shown = FilteredUnits();
            if (shown.Count == 0)
            {
                GUI.Label(new Rect(x, y, 320, 32), "<size=10>Brak jednostek tej kategorii. Wejdz do teatru (F6).</size>");
                y += 34f;
            }
            else
            {
                _unitPick = Mathf.Clamp(_unitPick, 0, shown.Count - 1);
                if (GUI.Button(new Rect(x, y, 28, 22), "<")) _unitPick = (_unitPick + shown.Count - 1) % shown.Count;
                GUI.Label(new Rect(x + 32, y, 250, 22), ZilleWarTable.UnitLabel(shown[_unitPick]));
                if (GUI.Button(new Rect(x + 286, y, 28, 22), ">")) _unitPick = (_unitPick + 1) % shown.Count;
                y += 26f;
                string side = _spawnEnemy ? "Wehlen" : "Rizia";
                if (GUI.Button(new Rect(x, y, 314, 24), "Postaw (" + side + "): " + ZilleWarTable.UnitLabel(shown[_unitPick])))
                {
                    var ut = shown[_unitPick];
                    if (ZilleWarTable.IsCityUnit(ut)) selTile.IsCity = true;
                    if (ZilleWarTable.IsAirUnit(ut)) selTile.IsAirfield = true;
                    ZilleWarTable.RequestApply();
                    _spawnStatus = ZilleWarTable.PlaceUnit(selTile, ut, _spawnEnemy);
                }
                y += 28f;
            }

            string roadLabel = _roadSourceIndex == _selectedTileIndex ? "[Droga z tej prowincji]" : "Droga z tej prowincji";
            if (GUI.Button(new Rect(x, y, 314, 22), roadLabel))
                _roadSourceIndex = _roadSourceIndex == _selectedTileIndex ? -1 : _selectedTileIndex;
            y += 26f;
            if (GUI.Button(new Rect(x, y, 154, 22), "Miasto tutaj"))
            {
                selTile.IsCity = true;
                if (!_spawnEnemy) selTile.Allegiance = "Rizia";
                else if (selTile.Allegiance == "Rizia") selTile.Allegiance = "Wehlen";
                ZilleWarTable.RequestApply();
                var city = ZilleWarTable.FindUnit(ZilleWarTable.IsCityUnit, _spawnEnemy ? "arces" : "rizia");
                _spawnStatus = city == null ? "Brak typu miasta." : ZilleWarTable.PlaceUnit(selTile, city, _spawnEnemy);
            }
            if (GUI.Button(new Rect(x + 160, y, 154, 22), "Lotnisko tutaj"))
            {
                selTile.IsAirfield = true;
                ZilleWarTable.RequestApply();
                var air = ZilleWarTable.FindUnit(ZilleWarTable.IsAirUnit, null);
                _spawnStatus = air == null
                    ? "Lotnisko oznaczone. Brak modelu samolotu w pamieci."
                    : ZilleWarTable.PlaceUnit(selTile, air, _spawnEnemy);
            }
            y += 26f;
            GUI.Label(new Rect(x, y, 320, 36), "<size=10>Rizia to twoje jednostki z menu po lewej. Wehlen to wrog. Droga: zaznacz prowincje, potem kliknij druga.</size>");
            y += 36f;
            GUI.Label(new Rect(x, y, 320, 32), "<size=10><color=#d6d3c4>" + _spawnStatus + "</color></size>");
        }

        private List<WarUnitTypeData> FilteredUnits()
        {
            var list = new List<WarUnitTypeData>();
            for (int i = 0; i < _units.Count; i++)
            {
                var u = _units[i];
                if (u == null) continue;
                if (_unitKind == 1 && !ZilleWarTable.IsCityUnit(u)) continue;
                if (_unitKind == 2 && !ZilleWarTable.IsAirUnit(u)) continue;
                if (_unitKind == 3 && !ZilleWarTable.IsTroopUnit(u)) continue;
                list.Add(u);
            }
            return list;
        }

        private void EnsureUnits()
        {
            if (_units.Count > 0 && _units[0] != null) return;
            _units.Clear();
            var src = ZilleWarTable.UnitTypes();
            for (int i = 0; i < src.Count; i++)
                if (src[i] != null) _units.Add(src[i]);
        }

        private Vector2 GetTileCenterLocal(ZilleTileData tile, Rect mapRect)
        {
            float cx = mapRect.x + tile.NormalizedX * mapRect.width;
            float cy = mapRect.y + tile.NormalizedY * mapRect.height;
            return new Vector2(cx, cy);
        }

        private Rect GetTileRectLocal(ZilleTileData tile, Rect mapRect)
        {
            Vector2 center = GetTileCenterLocal(tile, mapRect);
            float effectiveWidth = (tile.Width > 100f) ? (tile.Width / 512f) * 48f : tile.Width;
            float effectiveHeight = (tile.Height > 100f) ? (tile.Height / 512f) * 48f : tile.Height;
            float w = effectiveWidth * _zoom;
            float h = effectiveHeight * _zoom;
            return new Rect(center.x - w * 0.5f, center.y - h * 0.5f, w, h);
        }

        private Color GetAllegianceColor(string allegiance)
        {
            return allegiance switch
            {
                "Rizia" => new Color(0.45f, 0.75f, 0.95f),
                "Wehlen" => new Color(0.85f, 0.45f, 0.40f),
                "Derdia" => new Color(0.72f, 0.52f, 0.22f),
                "Empty" => new Color(0.75f, 0.75f, 0.75f),
                "EmptySea" => new Color(0.55f, 0.62f, 0.68f),
                _ => new Color(0.75f, 0.75f, 0.75f)
            };
        }

        private void DrawLine(Vector2 pointA, Vector2 pointB, Color color, float width)
        {
            Color savedColor = GUI.color;
            GUI.color = color;

            Vector2 diff = pointB - pointA;
            float length = diff.magnitude;
            float angle = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

            Matrix4x4 matrix = GUI.matrix;
            GUIUtility.RotateAroundPivot(angle, pointA);
            GUI.DrawTexture(new Rect(pointA.x, pointA.y - width * 0.5f, length, width), _whitePixel);
            GUI.matrix = matrix;

            GUI.color = savedColor;
        }

        private void DrawSolidRect(Rect r, Color color)
        {
            Color saved = GUI.color;
            GUI.color = color;
            GUI.DrawTexture(r, _whitePixel);
            GUI.color = saved;
        }

        private void DrawRectOutline(Rect r, Color color, float thickness)
        {
            Color saved = GUI.color;
            GUI.color = color;
            GUI.DrawTexture(new Rect(r.x, r.y, r.width, thickness), _whitePixel);
            GUI.DrawTexture(new Rect(r.x, r.yMax - thickness, r.width, thickness), _whitePixel);
            GUI.DrawTexture(new Rect(r.x, r.y, thickness, r.height), _whitePixel);
            GUI.DrawTexture(new Rect(r.xMax - thickness, r.y, thickness, r.height), _whitePixel);
            GUI.color = saved;
        }
    }
}
