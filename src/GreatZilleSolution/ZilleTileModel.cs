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
        // none | light | heavy. Light is fort level 1, heavy is fort level 2. Not drawn on the map.
        public string FortKind { get; set; } = "none";
        // border_west | border_east | north_line, or empty. Data only.
        public string DefenseLine { get; set; } = "";
        public bool IsPort { get; set; } = false;
        public bool IsAirfield { get; set; } = false;
        public bool IsSupplyHub { get; set; } = false;

        // Enemy reinforcement waves may spawn on this province (WarTile.SetIsReinforcementTile).
        public bool IsReinforcementTile { get; set; } = false;

        // From the v13 manifest. Sea provinces use Allegiance "EmptySea" (open water, as in the Pales war).
        public bool IsSea { get; set; } = false;
        public bool IsCity { get; set; } = false;
        // The name printed above the star. The province can be "Zille City" while the label is "Zille".
        public string CityName { get; set; } = "";
        public bool IsCoastal { get; set; } = false;
        // Placed from the right-hand authoring menu. The game already understands these tile roles.
        public bool HasCoastalArtillery { get; set; } = false;
        public bool HasNoAirZone { get; set; } = false;
        public bool HasNoNavalLanding { get; set; } = false;
        public bool IsBorder { get; set; } = false;
        // Sea from rizia_ship_placement. Ships may deploy here at the start; it is not enemy water.
        public bool IsNavalStart { get; set; } = false;
        public bool IsCitySurroundings { get; set; } = false;
        public string Region { get; set; } = "";
        // plains | hills | mountains. Mountains become WarTile.GroundType.Mountain.
        public string Terrain { get; set; } = "";
        // main | secondary | minor | none — the best road drawn inside the province.
        public string RoadClass { get; set; } = "none";
        public bool HasMainRoad { get; set; } = false;
        public bool HasRailway { get; set; } = false;
        public int RoadLinkCount { get; set; } = 0;
        // Neighbour tile ids this province has a drawn road to.
        public List<string> RoadToIds { get; set; } = new List<string>();

        // IDs of adjacent connected tiles (the v13 movement graph, including road and strait links).
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

    /// <summary>One Wehlen unit from the selected v13 deployment preset.</summary>
    [Serializable]
    public class ZilleDeploymentUnit
    {
        public string ProvinceId { get; set; } = "";
        public string ProvinceName { get; set; } = "";
        public string UnitType { get; set; } = "";
        public string TileNumber { get; set; } = "";
    }
}
