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

### v6

v5 with the Zille urban area shrunk to 0.76×, plus game province tiles.

212 provinces in total:

- 93 Zille-region land provinces (`ZilleTile_1`–`93`)
- 22 northern Brenas (`ZilleTile_94`–`115`)
- 44 Wehlen (`ZilleTile_116`–`159`)
- 53 sea provinces (`ZilleTile_S1`–`S53`) in the channel between Rizia and Wehlen

14 of them are city provinces.

Tile style: fill `#FF0000`, stroke `#00F800` at width 20, layer blur 12 (`feGaussianBlur` with `stdDeviation` 6). Each tile is at most 512×512, including effects. `provinces/` holds each tile as `ZilleTile_N` or `ZilleTile_SN` in both `.svg` and `.png`.

`provinces_manifest.json` and `provinces_manifest.csv` give `tile_x` / `tile_y` map position, region, type (`land` or `sea`), `is_city`, and neighbours. `provinces_overlay.svg`, `provinces_preview.png`, and `provinces_zille_crop.png` show the set. `provinces_validation.json` records the check. `scripts/` holds the build and export scripts that produced this set.

Files: `v6/zille_vector.svg`, `v6/zille_preview.png`, and the province files above.

### v7

Province revision on the unchanged v6 map. 214 provinces.

Land:

- 117 Zille (`ZilleTile_1`–`117`)
- 21 northern Brenas (`ZilleTile_118`–`138`)
- 40 Wehlen (`ZilleTile_139`–`178`)

Sea: 36 provinces (`ZilleTile_S1`–`S36`).

Land cells are organic: a compact watershed over the relief, rivers, and roads, with variable-density seeds. City provinces exist only for Zille, Wiktrany, Mave Nortus, Dapalle, Nanta, Isor, Munat, and Kratsna, shaped from their urban outlines. Zille uses its core outline. Inland zone edges are smooth, and tiny cells are merged where the 512 limit allows.

Sea provinces form an irregular angular corridor from the Rizia north coast to Kratsna, and along the Rizia coast to Isor and Port Rotsla.

Tiles stay 512×512, fill `#FF0000`, stroke `#00F800` at width 20, blur `stdDeviation` 6.

Files: `v7/zille_vector.svg`, `v7/zille_preview.png`, and the province set (`provinces/`, manifests, overlay, previews, validation, `scripts/`).

### v8

Province revision on the unchanged v6/v7 map, exported at true tile scale. 190 provinces (limit 224).

Land:

- 79 Zille (`ZilleTile_1`–`79`)
- 42 northern Brenas (`ZilleTile_80`–`121`)
- 42 Wehlen (`ZilleTile_122`–`163`)

Sea: 27 provinces (`ZilleTile_S1`–`S27`).

One tile covers 980 map px and is stored as 512×512 px, so each province is exported scaled by 512/980 (about 0.5224). Every province, blur included, fits within 980 map px (the largest is 863). The manifest records the scale, the map bbox, and the tile placement (`tile_x` / `tile_y` is the top-left of the 980 px footprint).

Tile style is unchanged at 512 px: fill `#FF0000`, stroke `#00F800` at width 20, layer blur 12 (`stdDeviation` 6). `provinces_overlay.svg` draws the tiles at map scale (stroke about 38.28, `stdDeviation` about 11.48).

City provinces are the same 8 cities. Zille covers the whole urban area, sprawl included. Kratsna has a proper margin again.

Tiny provinces are merged: Manes Riuz is one province, and the two Kreleck islets form one Kreleck Islands province. Thin coastal pockets (Bellacosta) are attached to a neighbour. A Brenas cell is still named Mave Nortus South (`ZilleTile_84`).

Zones: the Brenas border zone is at least 2 provinces deep, Marbelas included. The Zille zone is at least 2 deep. Wehlen is at least 2 deep toward Kratsna.

Sea is an angular, coast-hugging lane from Mave Nortus north around the Munat cape and down to Isor, plus 1–2 tile straits to Kratsna (the northern Brenas link) and Port Rotsla. There are no sea provinces elsewhere.

Files: `v8/zille_vector.svg`, `v8/zille_preview.png`, and the province set (`provinces/`, manifests, overlay, previews, validation, `scripts/`).

### v9

A new province partition at true tile scale, built from scratch on the unchanged v6–v8 map. 127 provinces.

Land:

- 40 Zille (`ZilleTile_1`–`40`)
- 28 northern Brenas (`ZilleTile_41`–`68`)
- 29 Wehlen (`ZilleTile_69`–`97`)

Sea: 30 provinces (`ZilleTile_S1`–`S30`).

On the 12288×8192 map, every province’s longest bbox side, including stroke and blur, is under 980 px (max 961) and over 512 px (median 808; 114 of 127 fall in 650–950). The allowed exceptions are the small cities Munat, Isor, and Dapalle, and the small island Rotsla.

Tiles are 512×512, with the province scaled by 512/980. Style: fill `#FF0000`, stroke `#00F800` at width 20, blur `stdDeviation` 6. The map overlay uses stroke about 38.28 and `stdDeviation` about 11.48. The manifest records the scale, the map bbox, and the tile placement.

Land cells are organic watershed fragments, agglomerated under a min/max bbox rule, then rebalanced and edge-smoothed. The same 8 city provinces remain. Zille covers the whole urban area and is named Zille City. Wiktrany, Mave Nortus, and Nanta are grown around their urban outlines to reach the size rule.

Zones are deeper for the bigger provinces: Brenas at least 2 deep, including Marbelas; Zille about the same extent; Wehlen 2 or more deep toward Kratsna.

Sea tiles cover the whole channel between Isor and Kratsna, including Port Rotsla. The lane from the Munat cape to Mave Nortus and the northern Brenas link are kept.

All province names are unique.

Files: `v9/zille_vector.svg`, `v9/zille_preview.png`, and the province set (`provinces/`, manifests, overlay, previews, validation, `scripts/`).

### v10

Final candidate. Edits on top of the v9 partition, on the unchanged base map. 135 provinces.

Land:

- 39 Zille (`ZilleTile_1`–`39`)
- 28 northern Brenas (`ZilleTile_40`–`67`)
- 29 Wehlen (`ZilleTile_68`–`96`)

Sea: 39 provinces (`ZilleTile_S1`–`S39`).

The north-east sea is re-tiled. The route from Tarnes and Mave Nortus north round the bay to Munat is 2–3 provinces wide, and the Nanta bay is tiled. 16 provinces replace the 9 earlier ones there. The Isor–Kratsna channel is extended south with 2 provinces (Yol Waters and Yol Roads), so the Yol bay is reachable by water.

City provinces are reshaped from the urban outline, the main road directions, and the coast, with lobes instead of round blobs. Mave Nortus, Nanta, Isor, and Wiktrany are multi-lobed. Munat is a hook along its cape. Isor and Munat are now normal-size provinces. The land cells around Wiktrany and Mave Nortus were re-grown to fit the new forms.

The size rule is unchanged: every province is under 980 map px including stroke and blur (max 961) and over 512. The exceptions are Dapalle (small city) and Rotsla (small island).

Deliverable layout:

- `map/` — the main map without provinces. `T_Map_Zille_01`–`06` are a 3×2 grid of 4096×4096 tiles, numbered row by row from the top-left. `T_Map_Zille_Full_Composite` is 12288×8192. Each comes as a native PNG and as an SVG cropped by `viewBox`.
- `regions/` — `ZilleTile_N` / `ZilleTile_SN` at 512×512, PNG and SVG, scaled 512/980; fill `#FF0000`, stroke `#00F800` width 20, blur `stdDeviation` 6. The manifest (JSON and CSV), overlay, and validation sit alongside.

Files: `v10/map/` (`T_Map_Zille_01`–`06` and `T_Map_Zille_Full_Composite`, each as `.png` and `.svg`), `v10/regions/` (135 tiles, manifest, overlay, validation), `v10/previews/`, and `v10/scripts/`.

### v11

A fix round on top of v10. 136 provinces. Ids stay stable versus v10.

Land:

- 39 Zille (`ZilleTile_1`–`39`)
- 28 northern Brenas (`ZilleTile_40`–`67`)
- 29 Wehlen (`ZilleTile_68`–`96`)

Sea: 40 provinces (`ZilleTile_S1`–`S40`).

**Grodzizg** is a new Wehlen port on the Yol-bay coast, where `ZilleTile_94` (Brannitz East) was. On the base map it is about Nanta-sized (urban area about 219×177, Nanta 190×166), with a Nanta-tier label (108 bold). A new double road links it to the Kratsna–Yol road at Brannitz. In the regions it is city province `ZilleTile_94` (the id is reused, `is_city` true): the urban outline plus coast and road-directed lobes, covering the headland. Neighbours 86, 90, and 91 were redrawn around it.

The bay between Brannitz, Yol, and the Grodzizg shore is sea province `ZilleTile_S40` (Grodzizg Waters). `S38` (Yol Waters) was re-cut with it, so `S38` now holds the Yol coast. Both connect to `S39` and the channel (`S33`).

`T_Map_Zille_01`–`06` and `T_Map_Zille_Full_Composite` are regenerated from the updated base map, as native PNG and viewBox-cropped SVG. The manifest adds `tile_center_x` / `tile_center_y` and a `fields` block describing every field.

The size rule is unchanged: every province is over 512 and under 980 map px including stroke and blur (max 961). The exceptions are Dapalle (small city) and Rotsla (small island). No overlaps, no gaps, and all names are unique.

Files: `v11/map/` (`T_Map_Zille_01`–`06` and `T_Map_Zille_Full_Composite`, each as `.png` and `.svg`), `v11/regions/` (136 tiles, manifest, overlay, validation), `v11/previews/`, and `v11/scripts/`.
