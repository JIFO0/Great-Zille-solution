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
        
        // IDs of adjacent connected tiles
        public List<string> AdjacentIds { get; set; } = new List<string>();
    }

    [Serializable]
    public class ZilleMapConfig
    {
        public string MapTitle { get; set; } = "Great Zille Theatre of War";
        public string Version { get; set; } = "1.0";
        public string BackgroundTexture { get; set; } = "T_Map_Zille_01.png";
        public List<ZilleTileData> Tiles { get; set; } = new List<ZilleTileData>();
    }
}
