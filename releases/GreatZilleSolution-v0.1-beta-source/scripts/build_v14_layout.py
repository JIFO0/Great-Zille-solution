import json
import os

manifest_path = r'assets/regions/provinces_manifest.json'
adjacency_path = r'assets/regions/provinces_adjacency.json'

with open(manifest_path, 'r', encoding='utf-8') as f:
    manifest = json.load(f)

with open(adjacency_path, 'r', encoding='utf-8') as f:
    adjacency = json.load(f)

cfg = {
    'MapTitle': 'Great Zille Theatre of War',
    'Version': 'v14.0',
    'BackgroundTexture': 'T_Map_Zille_Full_Composite.png',
    'Tiles': [],
    'Orders': []
}

by_province = {}
for p in manifest['provinces']:
    pid = p.get('id', '')
    if not pid.startswith('ZilleTile_'):
        continue
    number = pid[len('ZilleTile_'):]
    sea = (p.get('type') == 'sea')
    region = p.get('region', '')
    terrain = p.get('terrain', '')
    city = bool(p.get('is_city', False))
    cx = float(p.get('tile_center_x', 0))
    cy = float(p.get('tile_center_y', 0))
    owner = p.get('owner', '')
    if sea or owner == 'neutral':
        allegiance = 'EmptySea'
    elif owner == 'Rizia':
        allegiance = 'Rizia'
    elif owner == 'Derdia':
        allegiance = 'Derdia'
    else:
        allegiance = 'Wehlen'
    impassable = bool(p.get('impassable', False))
    fort_kind = p.get('fort') or 'none'
    fort = 2 if fort_kind == 'heavy' else (1 if fort_kind == 'light' else 0)
    display = p.get('name', '')

    tile = {
        'Id': 'tile_' + number.lower(),
        'Name': display,
        'TextureFile': p.get('png_file') or (pid + '.png'),
        'NormalizedX': cx / 12288.0,
        'NormalizedY': cy / 8192.0,
        'Width': 60.0,
        'Height': 60.0,
        'Allegiance': allegiance,
        'FortLevel': fort,
        'FortKind': fort_kind,
        'DefenseLine': p.get('defense_line', '') or '',
        'IsPort': bool(p.get('is_port', False)),
        'IsAirfield': False,
        'IsSupplyHub': city and display in ['Wiktrany', 'Zille City', 'Kratsna'],
        'IsReinforcementTile': display in ['Kratsna', 'Grodzizg'],
        'IsSea': sea,
        'IsImpassable': impassable,
        'IsCity': city,
        'CityName': p.get('city_name', '') if city else '',
        'IsCoastal': bool(p.get('is_coastal', False)),
        'HasCoastalArtillery': False,
        'HasNoAirZone': False,
        'HasNoNavalLanding': False,
        'IsBorder': False,
        'IsNavalStart': bool(p.get('rizia_ship_placement', False)),
        'IsCitySurroundings': False,
        'Region': region,
        'Terrain': terrain,
        'RoadClass': p.get('road_class', 'none') or 'none',
        'HasMainRoad': bool(p.get('has_main_road', False)),
        'HasRailway': bool(p.get('has_railway', False)),
        'RoadLinkCount': 0,
        'RoadToIds': [],
        'AdjacentIds': [],
        'TileNumber': number,
        'MapPxX': cx,
        'MapPxY': cy,
        'WorldScale': 980.0 * 0.666 / 4096.0
    }
    cfg['Tiles'].append(tile)
    by_province[pid] = tile

by_id = {t['Id']: t for t in cfg['Tiles']}

road_links = 0
adj_root = adjacency.get('provinces', {})
for pname, pdata in adj_root.items():
    if pname not in by_province:
        continue
    tile = by_province[pname]
    seen = set()
    for nb in pdata.get('neighbours', []):
        nid = nb.get('id', '')
        if nid not in by_province:
            continue
        other = by_province[nid]
        if tile['IsImpassable'] or other['IsImpassable']:
            continue
        if other['Id'] not in seen:
            seen.add(other['Id'])
            tile['AdjacentIds'].append(other['Id'])
        if nb.get('road_link', False):
            tile['RoadLinkCount'] += 1
            road_links += 1
            if other['Id'] not in tile['RoadToIds']:
                tile['RoadToIds'].append(other['Id'])

mountains, borders = 0, 0
for tile in cfg['Tiles']:
    if tile['Terrain'] == 'mountains':
        mountains += 1
    if tile['IsSea'] or tile['Region'] != 'Brenas':
        continue
    for aid in tile['AdjacentIds']:
        other = by_id.get(aid)
        if other and not other['IsSea'] and other['Region'] in ('Zille', 'Wehlen'):
            tile['IsBorder'] = True
            borders += 1
            break

for tile in cfg['Tiles']:
    if tile['IsSea'] or tile['IsCity'] or tile['Terrain'] in ('mountains', 'hills'):
        continue
    for aid in tile['AdjacentIds']:
        other = by_id.get(aid)
        if other and other['IsCity'] and not other['IsSea']:
            tile['IsCitySurroundings'] = True
            break

land_count = sum(1 for t in cfg['Tiles'] if not t['IsSea'])
sea_count = sum(1 for t in cfg['Tiles'] if t['IsSea'])
heavy = sum(1 for t in cfg['Tiles'] if t['FortLevel'] >= 2)
light = sum(1 for t in cfg['Tiles'] if t['FortLevel'] == 1)

print(f"Built v14 theatre: {len(cfg['Tiles'])} provinces ({land_count} land, {sea_count} sea), {mountains} mountain, {borders} Brenas border flags, {road_links // 2} road crossings, forts {heavy} heavy and {light} light.")

out_path = r'assets/zille_tiles_layout.json'
with open(out_path, 'w', encoding='utf-8') as f:
    json.dump(cfg, f, indent=2)
print(f"Saved {out_path} successfully!")
