using System;
using System.Collections.Generic;

namespace GreatZilleSolution
{
    [Serializable]
    public class ZilleTileData
    {
        public string Id { get; set; } = "tile_1";
        public string Name { get; set; } = "Region";
        public string TextureFile { get; set; } = "Frame 41.png";
        
        // Normalized map coordinates (0.0f - 1.0f)
        public float NormalizedX { get; set; } = 0.5f;
        public float NormalizedY { get; set; } = 0.5f;
        
        // Render size on editor canvas
        public float Width { get; set; } = 90f;
        public float Height { get; set; } = 90f;
        
        // Allegiance: Rizia, Wehlen, Contested
        public string Allegiance { get; set; } = "Contested";
        
        // Tactical attributes
        public int FortLevel { get; set; } = 0;
        public bool IsPort { get; set; } = false;
        public bool IsAirfield { get; set; } = false;
        public bool IsSupplyHub { get; set; } = false;

        // "land" or "sea". Sea provinces use Tile_S* and are not shore tiles.
        public string ProvinceType { get; set; } = "";

        // Land province that shares a border with a sea province. Pales reads this as WarTileData.isShoreTile
        // (embark / landing). Ports are coastal cities and are also shore tiles.
        public bool IsCoastal { get; set; } = false;

        // From the v12 manifest. The Pales WarTile has no terrain or road field, so these are data only.
        public string Terrain { get; set; } = "";
        public string RoadClass { get; set; } = "";
        public bool HasMainRoad { get; set; } = false;
        public bool HasRailway { get; set; } = false;

        public bool CountsAsShore => ProvinceType != "sea" && (IsPort || IsCoastal);

        // Enemy reinforcement waves may spawn on this province (WarTile.SetIsReinforcementTile).
        public bool IsReinforcementTile { get; set; } = false;
        
        // IDs of adjacent connected tiles
        public List<string> AdjacentIds { get; set; } = new List<string>();

        // ---- In-game placement (see docs/ZILLE_MAP_INTEGRATION.md) ----
        // The game identifies a tile by the suffix of its GameObject name: "Tile_" + TileNumber (string.Format("Tile_{0}")).
        // Operation data must therefore use these numbers ("1", "2", ...), NOT free-form ids like "tile_zille".
        public string TileNumber { get; set; } = "";

        // Tile centre in FULL-RES map pixels of the 3x2 grid of 4096x4096 map textures (x 0..12288, y 0..8192, y down).
        // Negative = not set yet (falls back to the built-in default placement).
        public float MapPxX { get; set; } = -1f;
        public float MapPxY { get; set; } = -1f;

        // World size of the tile quad (root-local units). Vanilla Pales land tiles use 0.1543, sea tiles 0.2761.
        public float WorldScale { get; set; } = 0.30f;
    }

    [Serializable]
    public class ZilleMapConfig
    {
        public string MapTitle { get; set; } = "Great Zille Theatre of War";
        public string Version { get; set; } = "1.0";
        public string BackgroundTexture { get; set; } = "T_Map_Zille_01.png";
        public List<ZilleTileData> Tiles { get; set; } = new List<ZilleTileData>();

        // Author-placed units. Triggers are evaluated while the Zille war table is live.
        public List<ZilleUnitOrder> Orders { get; set; } = new List<ZilleUnitOrder>();
    }

    /// <summary>
    /// A unit the author wants on the table.
    /// Trigger: Manual (button only), Start (as soon as the war map is up), Turn (war turn &gt;= Turn),
    /// Allegiance (watch province flips to WatchAllegiance).
    /// </summary>
    [Serializable]
    public class ZilleUnitOrder
    {
        public string Id { get; set; } = "";
        public string Label { get; set; } = "Unit";
        public string Side { get; set; } = "Player";
        public string UnitAssetName { get; set; } = "";
        public string TileId { get; set; } = "";
        public string Trigger { get; set; } = "Manual";
        public int Turn { get; set; } = 2;
        public string WatchTileId { get; set; } = "";
        public string WatchAllegiance { get; set; } = "Player";
        public bool Armed { get; set; } = true;
        public bool Fired { get; set; } = false;
    }

    /// <summary>
    /// One directed neighbour from provinces_adjacency.json.
    /// The file is symmetric, so each undirected border is stored twice.
    /// Pales has a single adjacentWarTiles list and no road-bonus or terrain-cost field.
    /// LinkType is recorded here and also used when that list is filled:
    /// land and strait are land-land steps, sea is a naval step, coastal is an embark/landing step
    /// (the land end is isShoreTile). RoadLink and RailLink are not applied as modifiers.
    /// </summary>
    [Serializable]
    public class ZilleProvinceLink
    {
        public string FromId { get; set; } = "";
        public string ToId { get; set; } = "";
        public string LinkType { get; set; } = "";
        public bool RoadLink { get; set; } = false;
        public string RoadLinkClass { get; set; } = "";
        public bool RailLink { get; set; } = false;
    }
}
