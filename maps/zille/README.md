# Zille vector map

Fictional vector map of the Zille region, drawn in the Pales war-map style for the Great Zille Solution project. Each version is a standalone SVG plus a raster preview.

## Version log

### v1

First vectorization of the Zille map.

Layers, bottom to top:

- `background`
- `sea`
- `land`
- `rivers`
- `coastline_original` (hidden)
- `coastline` (decorated)
- `borders`
- `roads`
- `main_roads`
- `railways`
- `sea_dotted_lines`
- `frame`

Files: `v1/zille_vector.svg`, `v1/zille_preview.png`.

### v2

Cleanup of tangles and gaps left by the first vectorization.

Named fixes:

- Yol hub
- road west of Yol
- road under the WEHLEN letters
- Jardim river joined to the lake
- reconstructed top-right railway
- about ten further small gap and duplicate fixes

A line-by-line record is in `v2/fixes_v2_log.txt`. `v2/fixes_before_after.png` shows the before/after of those edits.

Files: `v2/zille_vector.svg`, `v2/zille_preview.png`, `v2/fixes_before_after.png`, `v2/fixes_v2_log.txt`.

### v3

v2 plus a Pales-style topography layer and a road to the northern cape.

`topography` sits between `land` and `rivers`. It is split by region:

- `topo_wehlen`
- `topo_lerdia`
- `topo_zille_peninsula`
- `topo_olive_country`

Wehlen, Lerdia, and the Zille peninsula each have 8 low-opacity nested contour bands. Olive country uses the two lowest bands (`L1` and `L2`). Mountains sit on the east of the Zille peninsula, with small hills in the west. Ranges follow the Wehlen–Lerdia border, and valleys follow the existing rivers and roads.

A new double road, `road_to_cape`, runs to the northern cape beyond Nanta for a future city.

`v3/topography_only.svg` and `v3/topography_preview.png` isolate the relief. `v3/style_compare.png` compares the styled result.

Files: `v3/zille_vector.svg`, `v3/zille_preview.png`, `v3/topography_preview.png`, `v3/topography_only.svg`, `v3/style_compare.png`.

### v4

v3 plus more mountains and hills, and cities drawn in the Pales style.

Urban areas, markers, and labels are editable SVG text in Times New Roman. Groups:

- `urban_areas`
- `city_markers`
- `labels` / `labels_major`
- `labels_key`
- `labels_towns`
- `towns_invented`

Key strategic cities are drawn like Ziqes and Arces in Pales: a major label and a small urban area.

- **WIKTRANY** — road junction north of Zille
- **MUNAT** — northern cape

A new double road, `road_mave_nortus_wiktrany`, runs through a mountain valley.

27 invented villages in Wehlen, the Zille peninsula, and Brenas are kept in `towns_invented` so they can be renamed.

`v4/crops_cities.png` crops the city treatment. `v4/style_compare.png` compares the styled result.

Files: `v4/zille_vector.svg`, `v4/zille_preview.png`, `v4/crops_cities.png`, `v4/style_compare.png`.

### v5

v4 plus larger cities, new roads, and more settlements.

- The Zille urban area is enlarged to the dotted-outline extent from the source map.
- Kratsna, capital of Wehlen, is much larger and has five road connections, including roads that leave the map to the north and west.
- Nanta, Mave Nortus, and Munat are slightly larger.
- New Wehlen roads run south, including the single road `road_kratsna_yol`, plus `road_lerlow_south` and `road_strebna_south`.
- 16 diverse resort towns sit on the west coast of the Zille peninsula and Brenas.
- Port Rotsla and Walsholm, on Rotsla island, are linked by `road_rotsla`.
- More invented villages were added in Wehlen.
- Label placement was adjusted.

`v5/crops_cities.png` crops the city treatment.

Files: `v5/zille_vector.svg`, `v5/zille_preview.png`, `v5/crops_cities.png`.
