#!/usr/bin/env python3
"""Deterministic generator + validator for Zille v14 operation-plan region lists.

Reads (read-only) the v14 source pack:
  versions/v14/regions/provinces_manifest.json
  versions/v14/regions/provinces_adjacency.json
  versions/v14/regions/starting_provinces.json
Writes into this folder:
  operation_regions_v14.json, operation_regions_v14.txt,
  operation_regions_v14_validation.json, operation_regions_v14_matrix.csv,
  operation_regions_v14_preview.png (if Pillow + adjacency_preview.png available)
Usage: python3 generate_operation_regions_v14.py [path/to/v14/regions]
"""
import collections, csv, hashlib, json, os, sys

HERE = os.path.dirname(os.path.abspath(__file__))
SRC = sys.argv[1] if len(sys.argv) > 1 else os.path.join(HERE, '..', 'versions', 'v14', 'regions')
SRC = os.path.abspath(SRC)
F_MAN, F_ADJ, F_START = 'provinces_manifest.json', 'provinces_adjacency.json', 'starting_provinces.json'

STATUS = 'FINAL'

# ---- Sword phase-1 sea boundary: CONFIRMED by the user (2026-11-09):
# "Wszystko minus (S1, S2, S3, S38, S39, S40, S27, S33, S34, S53)"
SWORD_P1_EXCLUDED_SEAS = ['S1', 'S2', 'S3', 'S38', 'S39', 'S40', 'S27', 'S33', 'S34', 'S53']
USER_QUOTE_SWORD = 'Wszystko minus (S1, S2, S3, S38, S39, S40, S27, S33, S34, S53)'


def tid(x):
    return x if x.startswith('ZilleTile_') else 'ZilleTile_' + x

def short(x):
    return x.replace('ZilleTile_', '')

def sortkey(x):
    s = short(x)
    return (1, int(s[1:])) if s.startswith('S') else (0, int(s))

def srt(it):
    return sorted(set(it), key=sortkey)

def game_tile(x):
    # Project convention noted during v14 integration: ZilleTile_N -> Tile_N, ZilleTile_SN -> Tile_SN.
    return 'Tile_' + short(x)

def sha(path):
    return hashlib.sha256(open(path, 'rb').read()).hexdigest()


def main():
    man = json.load(open(os.path.join(SRC, F_MAN)))
    adj = json.load(open(os.path.join(SRC, F_ADJ)))
    start = json.load(open(os.path.join(SRC, F_START)))
    P = {p['id']: p for p in man['provinces']}
    ALL = srt(P)
    LAND = srt(i for i in ALL if P[i]['type'] == 'land')
    SEA = srt(i for i in ALL if P[i]['type'] == 'sea')
    BY_REG = collections.defaultdict(list)
    for i in ALL:
        BY_REG[P[i]['region']].append(i)
    BY_REG = {k: srt(v) for k, v in BY_REG.items()}
    ZILLE, BRENAS, WEHLEN, DERDIA = BY_REG['Zille'], BY_REG['Brenas'], BY_REG['Wehlen'], BY_REG['Derdia']
    IMPASSABLE = srt(i for i in ALL if P[i].get('impassable'))
    EDGES = [(e['a'], e['b'], e['type']) for e in adj['edges']]
    G = collections.defaultdict(set)
    for a, b, t in EDGES:
        G[a].add((b, t)); G[b].add((a, t))

    # ---- Ark border band: Zille provinces at graph distance 1 from Brenas over TRUE LAND edges only
    band_edges = []
    band = set()
    for a, b, t in EDGES:
        if t != 'land':
            continue
        ra, rb = P[a]['region'], P[b]['region']
        if {ra, rb} == {'Zille', 'Brenas'}:
            z = a if ra == 'Zille' else b
            band.add(z); band_edges.append(srt([a, b]))
    BAND = srt(band)
    band_detail = {z: srt(n for n, t in G[z] if t == 'land' and P[n]['region'] == 'Brenas') for z in BAND}

    # ---- Sword seas
    sword_excl = srt(tid(s) for s in SWORD_P1_EXCLUDED_SEAS)
    SWORD_SEAS = srt(s for s in SEA if s not in sword_excl)
    ROTSLA = 'ZilleTile_96'

    def stage(land, sea, note):
        land, sea = srt(land), srt(sea)
        return {'land': land, 'sea': sea, 'note': note}

    arkD1 = stage(WEHLEN + DERDIA + BRENAS + BAND, SEA, 'Phase 1: all seas + all Wehlen + Derdia strip (incl. impassable Yol) + all Brenas + 1-province Zille band')
    ark1 = stage(WEHLEN + BRENAS + BAND, SEA, 'Phase 1: as Ark (Derdia) but without the Derdia strip')
    sword1 = stage(ZILLE + [ROTSLA] + BRENAS, SWORD_SEAS, 'Phase 1: whole Zille region (incl. Manes Riuz 3) + Rotsla 96 island + all Brenas (always active) + 47 seas (user-confirmed: all except 10)')
    full = stage(LAND, SEA, 'Phase 2: whole map incl. Derdia')
    full_noD = stage([i for i in LAND if i not in DERDIA], SEA, 'Phase 2: whole map WITHOUT Derdia')

    plan_defs = [
        ('ark_derdia', 'Plan Ark (Derdia)', 'Ark (D) -> cała mapa (+D)', arkD1, full),
        ('ark', 'Plan Ark', 'Ark -> cała mapa', ark1, full_noD),
        ('sword', 'Plan Sword', 'Sword -> cała mapa', sword1, full_noD),
    ]

    passable_edges = [(a, b, t) for a, b, t in EDGES if a not in IMPASSABLE and b not in IMPASSABLE]

    def components(ids):
        s = set(ids) - set(IMPASSABLE)
        seen, comps = set(), []
        for v in srt(s):
            if v in seen: continue
            stack, comp = [v], []
            seen.add(v)
            while stack:
                u = stack.pop(); comp.append(u)
                for w, _ in G[u]:
                    if w in s and w not in seen:
                        seen.add(w); stack.append(w)
            comps.append(srt(comp))
        return comps

    def boundary(ids):
        s = set(ids)
        out = []
        for a, b, t in passable_edges:
            if (a in s) != (b in s):
                inside, outside = (a, b) if a in s else (b, a)
                out.append({'active': inside, 'inactive': outside, 'type': t})
        return sorted(out, key=lambda e: (sortkey(e['active']), sortkey(e['inactive'])))

    def build_stage(st, prev=None):
        ids = srt(st['land'] + st['sea'])
        d = {
            'note': st['note'],
            'counts': {'total': len(ids), 'land': len(st['land']), 'sea': len(st['sea']),
                       'by_region': {r: sum(1 for i in ids if P[i]['region'] == r) for r in ['Zille', 'Brenas', 'Wehlen', 'Derdia', 'Sea']},
                       'impassable_active': len([i for i in ids if i in IMPASSABLE]),
                       'disabled': len(ALL) - len(ids)},
            'active_region_ids': ids,
            'active_land_ids': st['land'],
            'active_sea_ids': st['sea'],
            'active_game_tiles': [game_tile(i) for i in ids],
            'impassable_active_ids': [i for i in ids if i in IMPASSABLE],
            'disabled_ids': [i for i in ALL if i not in set(ids)],
            'boundary_edges_to_disabled': boundary(ids),
        }
        if prev is not None:
            d['newly_unlocked_ids'] = [i for i in ids if i not in set(prev)]
            d['counts']['newly_unlocked'] = len(d['newly_unlocked_ids'])
        return d, ids

    scenarios = {}
    for key, label, notation, p1, p2 in plan_defs:
        s1, ids1 = build_stage(p1)
        s2, ids2 = build_stage(p2, ids1)
        scenarios[key] = {'label': label, 'user_notation': notation,
                          'status': 'derived_from_user_brief' + ('; sea list confirmed by user' if key == 'sword' else ''),
                          'phase1': s1, 'phase2': s2}

    catalogue = []
    for i in ALL:
        p = P[i]
        catalogue.append({
            'id': i, 'short_id': short(i), 'game_tile': game_tile(i), 'name': p['name'], 'type': p['type'],
            'group': p['region'], 'start_owner': p['start_owner'], 'is_city': p['is_city'],
            'island': p['island'] or None, 'impassable': bool(p['impassable']),
            'in_ark_border_band': i in set(BAND),
            'sword_p1_sea_status': (None if p['type'] != 'sea' else ('included' if i in set(SWORD_SEAS) else 'excluded')),
            'svg_file': p['svg_file'], 'png_file': p['png_file'],
            'membership': {f'{k}.{ph}': i in set(scenarios[k][ph]['active_region_ids']) for k in scenarios for ph in ('phase1', 'phase2')},
        })

    coast = lambda s: srt(n for n, t in G[s] if t == 'coastal')
    sword_sea_table = [{'id': s, 'name': P[s]['name'], 'decision': 'exclude' if s in sword_excl else 'include',
                        'coast_neighbours': [f"{short(n)} {P[n]['name']} ({P[n]['region']})" for n in coast(s)],
                        'reason': ('excluded by user' if s in sword_excl else '')} for s in SEA]
    rizia_ship = start.get('rizia_ship_placement', {})
    rizia_ship_ids = srt(x['id'] for side in rizia_ship.values() for x in side)

    out = {
        'version': 'v14', 'document': 'operation_regions_v14', 'status': STATUS,
        'status_note': 'Ark (D) and Ark follow the user brief literally. Sword phase-1 seas = all 57 minus the 10 seas the user listed (confirmed). Remaining interpretation points are listed in assumptions_and_decisions with confirmed=false.',
        'semantics': 'Active theatre / availability per scenario phase. NOT starting ownership, NOT deployment. Ownership stays in regions/starting_provinces.json, units in regions/deployments/.',
        'id_convention': {'canonical': 'ZilleTile_N (land), ZilleTile_SN (sea)', 'game_tile': 'Tile_N / Tile_SN (project convention: ZilleTile_ prefix -> Tile_; verify against the loader)'},
        'source': {'folder': 'versions/v14/regions', 'files': {f: sha(os.path.join(SRC, f)) for f in (F_MAN, F_ADJ, F_START)}},
        'source_facts': {
            'total': len(ALL), 'land': len(LAND), 'sea': len(SEA),
            'groups': {k: len(v) for k, v in BY_REG.items()},
            'group_ids': BY_REG,
            'impassable_ids': IMPASSABLE,
            'yol_rule': 'ZilleTile_129 Yol (Derdia) is impassable: manifest impassable=true, 0 adjacency links (4 dropped). Included in Derdia theatre lists only as a visible/impassable tile: never movable, never a unit slot. Do not remove that rule.',
            'zille_vs_wehlen': 'Manifest field "region" is the authority. Zille (60) = peninsula incl. island 3 Manes Riuz (start_owner Wehlen). Wehlen (33) = continental Wehlen 68-71,73-95,119-122 + islands 72 Kreleck Islands and 96 Rotsla. Zille and continental Wehlen share NO land edge (separated by sea).',
            'brenas': 'Brenas (29) = Rizia-owned land 23, 40-67 (incl. city 23 Mave Nortus). Zille<->Brenas land border has %d land edges.' % len(band_edges),
            'rotsla': 'ZilleTile_96 Rotsla is group Wehlen, island, sea-only links (coastal to S27, S28, S34, S35). It has no land edge, so it can never enter the Ark band.',
            'rizia_ship_placement_seas': rizia_ship_ids,
        },
        'ark_border_band': {
            'method': 'Zille provinces at graph distance exactly 1 from any Brenas province using only adjacency edges with type=="land" (sea, coastal and strait edges ignored; manual land links count as land only if typed land - none touch Brenas).',
            'ids': BAND, 'count': len(BAND),
            'names': {i: P[i]['name'] for i in BAND},
            'brenas_neighbours': band_detail,
            'zille_brenas_land_edges': sorted(band_edges, key=lambda e: [sortkey(x) for x in e]),
        },
        'sword_sea_boundary': {
            'status': 'CONFIRMED by user',
            'user_quote': USER_QUOTE_SWORD,
            'rule': 'Sword phase 1 = all 57 seas minus the 10 listed by the user. Phase 2 = all 57 seas.',
            'included_ids': SWORD_SEAS, 'excluded_ids': sword_excl,
            'included_count': len(SWORD_SEAS), 'excluded_count': len(sword_excl),
            'table': sword_sea_table,
        },
        'assumptions_and_decisions': [
            {'id': 'A1', 'topic': 'semantics', 'decision': 'Lists define active/available theatre, not ownership or deployment.', 'confirmed': True},
            {'id': 'A2', 'topic': 'Wehlen scope', 'decision': '"Wszystkie prowincje w Wehlen" = all 33 provinces of manifest group Wehlen, incl. islands 72 Kreleck Islands and 96 Rotsla.', 'confirmed': False},
            {'id': 'A3', 'topic': 'Derdia strip', 'decision': 'Derdia = all 7 group-Derdia ids 123-129; 129 Yol stays included as an impassable visible tile. ArkD minus Ark = exactly these 7 in both phases.', 'confirmed': False},
            {'id': 'A4', 'topic': 'Ark band', 'decision': 'One-province Zille band = Zille provinces with a true land edge to Brenas (11 ids). No sea/strait path is used, Rotsla 96 and Manes Riuz 3 are not in it.', 'confirmed': False},
            {'id': 'A5', 'topic': 'Sword land', 'decision': 'Sword phase 1 land = whole Zille group (60, incl. island 3 Manes Riuz reached by straits) + Rotsla 96 + all Brenas (29).', 'confirmed': False},
            {'id': 'A11', 'topic': 'Brenas invariant', 'decision': 'Brenas (all 29 provinces) is ALWAYS active, in every plan and every phase (user: "Brenas jest w obu scenariuszach ... Brenas Zawsze jest dostepne").', 'confirmed': True},
            {'id': 'A6', 'topic': 'Sword seas', 'decision': 'Phase 1: 47 seas = all 57 minus S1, S2, S3, S27, S33, S34, S38, S39, S40, S53 (user quote: ' + USER_QUOTE_SWORD + '). Phase 2: all 57. Rotsla 96 keeps sea access via S28 and S35.', 'confirmed': True},
            {'id': 'A7', 'topic': 'Phase 2', 'decision': 'Ark (D) phase 2 = whole map incl. Derdia (186). Ark and Sword phase 2 = whole map without Derdia (179), per user notation "(+D)" only on Ark (D).', 'confirmed': False},
            {'id': 'A8', 'topic': 'Boundary edges', 'decision': 'Edges from an active to a disabled province are listed per stage; the implementer should block movement/attack across them (or treat disabled tiles as non-existent).', 'confirmed': False},
            {'id': 'A9', 'topic': 'Out of scope', 'decision': 'Phase-2 militia spawning in Wehlen every 2 turns is NOT implemented here (deferred; user handles it).', 'confirmed': True},
            {'id': 'A10', 'topic': 'Game tile names', 'decision': 'game_tile = Tile_N / Tile_SN from project convention; verify against the mod loader.', 'confirmed': False},
        ],
        'scenarios': scenarios,
        'catalogue': catalogue,
    }

    # ---------------- validation ----------------
    checks = []
    def chk(name, ok, detail=None):
        checks.append({'check': name, 'ok': bool(ok), **({'detail': detail} if detail is not None else {})})
    S = lambda k, ph: set(scenarios[k][ph]['active_region_ids'])
    chk('source totals 186/129/57', (len(ALL), len(LAND), len(SEA)) == (186, 129, 57))
    chk('source groups Zille60 Brenas29 Wehlen33 Derdia7 Sea57', {k: len(v) for k, v in BY_REG.items()} == {'Zille': 60, 'Brenas': 29, 'Wehlen': 33, 'Derdia': 7, 'Sea': 57}, {k: len(v) for k, v in BY_REG.items()})
    chk('impassable is exactly [ZilleTile_129]', IMPASSABLE == ['ZilleTile_129'])
    chk('Yol 129 has 0 adjacency edges', not any('ZilleTile_129' in (a, b) for a, b, _ in EDGES))
    for k in scenarios:
        for ph in ('phase1', 'phase2'):
            st = scenarios[k][ph]
            ids = st['active_region_ids']
            chk(f'{k}.{ph}: all ids exist', all(i in P for i in ids))
            chk(f'{k}.{ph}: no duplicates', len(ids) == len(set(ids)))
            chk(f'{k}.{ph}: land/sea split matches manifest type', set(st['active_land_ids']) == {i for i in ids if P[i]['type'] == 'land'} and set(st['active_sea_ids']) == {i for i in ids if P[i]['type'] == 'sea'})
            chk(f'{k}.{ph}: active + disabled = 186 disjoint', len(ids) + len(st['disabled_ids']) == 186 and not set(ids) & set(st['disabled_ids']))
            chk(f'{k}.{ph}: game tile list aligned', st['active_game_tiles'] == [game_tile(i) for i in ids])
            comps = components(ids)
            chk(f'{k}.{ph}: passable active set is one connected component', len(comps) == 1, [len(c) for c in comps])
        chk(f'{k}: phase1 subset of phase2', S(k, 'phase1') <= S(k, 'phase2'))
        chk(f'{k}: phase2 = phase1 + newly_unlocked', S(k, 'phase2') == S(k, 'phase1') | set(scenarios[k]['phase2']['newly_unlocked_ids']) and not S(k, 'phase1') & set(scenarios[k]['phase2']['newly_unlocked_ids']))
    chk('ark_derdia.phase1 - ark.phase1 == Derdia(7)', S('ark_derdia', 'phase1') - S('ark', 'phase1') == set(DERDIA) and S('ark', 'phase1') <= S('ark_derdia', 'phase1'))
    chk('ark_derdia.phase2 - ark.phase2 == Derdia(7)', S('ark_derdia', 'phase2') - S('ark', 'phase2') == set(DERDIA) and S('ark', 'phase2') <= S('ark_derdia', 'phase2'))
    chk('ark_derdia.phase2 == whole map (186)', S('ark_derdia', 'phase2') == set(ALL))
    chk('ark.phase2 == sword.phase2 == whole map minus Derdia (179)', S('ark', 'phase2') == S('sword', 'phase2') == set(ALL) - set(DERDIA))
    chk('Derdia absent from ark and sword in both phases', not (set(DERDIA) & (S('ark', 'phase1') | S('ark', 'phase2') | S('sword', 'phase1') | S('sword', 'phase2'))))
    chk('Ark phase1 has all seas, all Wehlen, all Brenas', set(SEA) | set(WEHLEN) | set(BRENAS) <= S('ark', 'phase1'))
    chk('Ark phase1 Zille part == band exactly', S('ark', 'phase1') & set(ZILLE) == set(BAND))
    chk('band ids all group Zille', all(P[i]['region'] == 'Zille' for i in BAND))
    chk('band built from land edges only (each member has >=1 land edge to Brenas)', all(band_detail[i] for i in BAND))
    chk('Rotsla 96 not in band; 96 has no land edges', ROTSLA not in BAND and all(t != 'land' for _, t in G[ROTSLA]))
    chk('Manes Riuz 3 not in band', 'ZilleTile_3' not in BAND)
    chk('Sword phase1 land == whole Zille + Rotsla 96 + all Brenas (no other Wehlen, no Derdia)', S('sword', 'phase1') & set(LAND) == set(ZILLE) | {ROTSLA} | set(BRENAS))
    for k in scenarios:
        for ph in ('phase1', 'phase2'):
            chk(f'{k}.{ph}: Brenas (29) always active, none disabled', set(BRENAS) <= S(k, ph) and not set(BRENAS) & set(scenarios[k][ph]['disabled_ids']))
    chk('Sword phase1 counts 137/90/47, phase2 179 with 42 newly unlocked', (scenarios['sword']['phase1']['counts']['total'], scenarios['sword']['phase1']['counts']['land'], scenarios['sword']['phase1']['counts']['sea'], scenarios['sword']['phase2']['counts']['total'], scenarios['sword']['phase2']['counts']['newly_unlocked']) == (137, 90, 47, 179, 42))
    chk('Sword excluded seas == user list (10), included == 47', set(sword_excl) == {tid(x) for x in SWORD_P1_EXCLUDED_SEAS} and len(sword_excl) == 10 and len(SWORD_SEAS) == 47)
    chk('Sword seas: every sea touching Zille is included', all(s in set(SWORD_SEAS) for s in SEA if any(n in set(ZILLE) for n, t in G[s] if t == 'coastal')))
    chk('Sword: Rotsla 96 keeps >=1 active sea neighbour', [n for n, t in G[ROTSLA] if n in set(SWORD_SEAS)], srt(n for n, t in G[ROTSLA] if n in set(SWORD_SEAS)))
    chk('Sword seas: all Rizia ship-placement seas included', set(rizia_ship_ids) <= set(SWORD_SEAS), rizia_ship_ids)
    chk('Sword seas form one sea-connected network', len([c for c in components(SWORD_SEAS)]) == 1)
    chk('Sword excluded seas exist and are sea', all(s in P and P[s]['type'] == 'sea' for s in sword_excl))
    chk('impassable never in a movable list without flag', all(set(scenarios[k][ph]['impassable_active_ids']) == S(k, ph) & set(IMPASSABLE) for k in scenarios for ph in ('phase1', 'phase2')))
    val = {'ok': all(c['ok'] for c in checks), 'n_checks': len(checks), 'n_failed': sum(not c['ok'] for c in checks), 'checks': checks,
           'stage_totals': {f'{k}.{ph}': scenarios[k][ph]['counts'] for k in scenarios for ph in ('phase1', 'phase2')}}
    out['validation_summary'] = {'ok': val['ok'], 'n_checks': val['n_checks'], 'n_failed': val['n_failed']}

    json.dump(out, open(os.path.join(HERE, 'operation_regions_v14.json'), 'w'), ensure_ascii=False, indent=1)
    json.dump(val, open(os.path.join(HERE, 'operation_regions_v14_validation.json'), 'w'), ensure_ascii=False, indent=1)

    # CSV matrix
    with open(os.path.join(HERE, 'operation_regions_v14_matrix.csv'), 'w', newline='', encoding='utf-8') as f:
        w = csv.writer(f)
        cols = [f'{k}.{ph}' for k in scenarios for ph in ('phase1', 'phase2')]
        w.writerow(['id', 'game_tile', 'name', 'type', 'group', 'impassable', 'ark_band', 'sword_sea_proposal'] + cols)
        for c in catalogue:
            w.writerow([c['id'], c['game_tile'], c['name'], c['type'], c['group'], int(c['impassable']), int(c['in_ark_border_band']), c['sword_p1_sea_status'] or ''] + [int(c['membership'][x]) for x in cols])

    write_txt(out, P, scenarios, BAND, band_detail, sword_sea_table, val)
    write_preview(P, scenarios)
    print('validation ok' if val['ok'] else 'VALIDATION FAILED', val['n_checks'], 'checks')
    for k in scenarios:
        for ph in ('phase1', 'phase2'):
            print(k, ph, scenarios[k][ph]['counts'])
    return 0 if val['ok'] else 1


def fmt_ids(ids, P, per_line=6):
    items = [f"{short(i)} {P[i]['name']}" + (' [NIEPRZEJEZDNA]' if P[i].get('impassable') else '') for i in ids]
    lines = []
    for n in range(0, len(items), per_line):
        lines.append('    ' + ', '.join(items[n:n + per_line]))
    return '\n'.join(lines) if lines else '    (brak)'


def write_txt(out, P, sc, BAND, band_detail, table, val):
    L = []
    a = L.append
    a('ZILLE v14 - WYKAZ REGIONÓW DLA PLANÓW OPERACYJNYCH')
    a('Status: WERSJA KOŃCOWA. Morza w Sword (faza 1) potwierdzone przez Ciebie: wszystkie oprócz S1, S2, S3, S27, S33, S34, S38, S39, S40, S53.')
    a('Znaczenie: lista prowincji AKTYWNYCH w danej fazie (teatr działań), a NIE własność startowa ani rozstawienie jednostek.')
    a('Identyfikatory: ZilleTile_N (ląd), ZilleTile_SN (morze); w grze Tile_N / Tile_SN. Poniżej w skrócie: numer + nazwa.')
    a('Źródło: versions/v14/regions (provinces_manifest.json, provinces_adjacency.json, starting_provinces.json).')
    a('')
    a('PODSUMOWANIE (aktywne: razem / ląd / morze)')
    for k, s in sc.items():
        for ph, lbl in (('phase1', 'Faza 1'), ('phase2', 'Faza 2')):
            c = s[ph]['counts']
            a(f"  {s['label']:<18} {lbl}: {c['total']:>3} / {c['land']:>3} / {c['sea']:>2}   (Zille {c['by_region']['Zille']}, Brenas {c['by_region']['Brenas']}, Wehlen {c['by_region']['Wehlen']}, Derdia {c['by_region']['Derdia']})")
    a('')
    a('FAKTY ZE ŹRÓDŁA')
    a('  - Zille (60): półwysep, w tym wyspa 3 Manes Riuz. Na starcie należy do Wehlen.')
    a('  - Wehlen (33): kontynentalne Wehlen + wyspy 72 Kreleck Islands i 96 Rotsla. Z Zille nie ma granicy lądowej.')
    a('  - Brenas (29): ziemie Rizii 23, 40-67. ZAWSZE AKTYWNE we wszystkich planach i fazach (potwierdzone).')
    a('  - Derdia (7): 123-128 (pas) + 129 Yol - ZAWSZE NIEPRZEJEZDNA (0 połączeń, bez jednostek, bez ruchu).')
    a('  - 96 Rotsla ma tylko połączenia morskie (S27, S28, S34, S35), więc nie może wejść do pasa Ark.')
    a('')
    a('PAS 1 PROWINCJI W GŁĄB ZILLE (Ark, Ark D)')
    a('  Metoda: prowincje regionu Zille sąsiadujące z Brenas przez krawędź typu "land" (bez mórz, wybrzeży i cieśnin).')
    for z in BAND:
        a(f"    {short(z)} {P[z]['name']}  <- graniczy z: " + ', '.join(f"{short(b)} {P[b]['name']}" for b in band_detail[z]))
    a('')
    a('MORZA W SWORD, FAZA 1 (POTWIERDZONE)')
    a('  Twoja decyzja: "' + USER_QUOTE_SWORD + '".')
    a('  Wyłączone (10):')
    for r in table:
        if r['decision'] == 'exclude':
            a(f"    {short(r['id'])} {r['name']}: wybrzeże " + (', '.join(r['coast_neighbours']) or 'brak (otwarte morze)'))
    a('  Aktywne (47): wszystkie pozostałe. Rotsla 96 ma nadal dostęp do morza przez S28 i S35.')
    a('  W fazie 2 aktywne są wszystkie 57 mórz.')
    a('')
    a('ZAŁOŻENIA I USTALENIA')
    a('  - Ark: "wszystkie prowincje w Wehlen" obejmują też wyspy 72 i 96.')
    a('  - Ark (D): pas Derdii to 7 prowincji 123-129; Yol 129 jest widoczny, ale nieprzejezdny.')
    a('  - Sword, faza 1: cały region Zille (z wyspą 3 Manes Riuz) + wyspa 96 Rotsla + całe Brenas.')
    a('  - Faza 2: Ark (D) = cała mapa z Derdią (186). Ark i Sword = cała mapa bez Derdii (179).')
    a('  - Krawędzie między prowincjami aktywnymi i nieaktywnymi trzeba zablokować; ich lista jest w JSON (boundary_edges_to_disabled).')
    a('  - Milicja w Wehlen co 2 tury (faza 2) nie jest tu zaimplementowana.')
    a('')
    for k, s in sc.items():
        a('=' * 78)
        a(f"{s['label'].upper()}   [{s['user_notation']}]" )
        for ph, lbl in (('phase1', 'FAZA 1'), ('phase2', 'FAZA 2')):
            st = s[ph]; c = st['counts']
            a(f"--- {lbl}: aktywne {c['total']} (ląd {c['land']}, morze {c['sea']}), nieaktywne {c['disabled']}")
            a('  Ląd:'); a(fmt_ids(st['active_land_ids'], P))
            a('  Morze:'); a(fmt_ids(st['active_sea_ids'], P))
            if ph == 'phase2':
                a(f"  Nowo odblokowane w fazie 2 ({c['newly_unlocked']}):"); a(fmt_ids(st['newly_unlocked_ids'], P))
            a(f"  Nieaktywne ({c['disabled']}):"); a(fmt_ids(st['disabled_ids'], P))
            a('')
    a('=' * 78)
    a(f"WALIDACJA: {'OK' if val['ok'] else 'BŁĄD'} - {val['n_checks']} testów, {val['n_failed']} nieudanych (szczegóły: operation_regions_v14_validation.json)")
    open(os.path.join(HERE, 'operation_regions_v14.txt'), 'w', encoding='utf-8').write('\n'.join(L) + '\n')


def write_preview(P, sc):
    try:
        from PIL import Image, ImageDraw
    except ImportError:
        return
    base = os.path.join(SRC, 'adjacency_preview.png')
    if not os.path.exists(base):
        return
    im0 = Image.open(base).convert('RGB')
    W = 1400; f = W / 12288.0
    im0 = im0.resize((W, int(im0.size[1] * W / im0.size[0])))
    sy = im0.size[1] / 8192.0
    panels = []
    for k, s in sc.items():
        for ph in ('phase1', 'phase2'):
            im = im0.copy(); d = ImageDraw.Draw(im)
            act = set(s[ph]['active_region_ids'])
            for i, p in P.items():
                x, y = p['centroid_x'] * f, p['centroid_y'] * sy
                col = (128, 128, 128) if p.get('impassable') and i in act else ((0, 170, 0) if i in act else (20, 20, 20))
                r = 7 if i in act else 4
                d.ellipse([x - r, y - r, x + r, y + r], fill=col, outline=(255, 255, 255))
            d.rectangle([0, 0, W, 34], fill=(255, 255, 255))
            d.text((10, 10), f"{s['label']} - {ph}  active {len(act)} (green=active, black=disabled, grey=active impassable)" + '', fill=(0, 0, 0))
            panels.append(im)
    w, h = panels[0].size
    sheet = Image.new('RGB', (w * 2, h * 3), 'white')
    for n, p in enumerate(panels):
        sheet.paste(p, ((n % 2) * w, (n // 2) * h))
    sheet.save(os.path.join(HERE, 'operation_regions_v14_preview.png'))


if __name__ == '__main__':
    sys.exit(main())
