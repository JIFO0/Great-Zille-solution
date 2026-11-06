#!/usr/bin/env python3
"""Check the v14 Zille data pack: counts, symmetry, straits, Derdia/Yol, Lespia's territorial
waters, bottom edge, forts and deployment rules. Standard library only.

Run from the repo root (or anywhere):
  python3 maps/zille/v14/scripts/validate_pack.py
"""
import json
import math
import re
import sys
from collections import Counter, deque
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
REG = ROOT / "regions"
P = "ZilleTile_"
EXPECT_TOTAL = 186
EXPECT_KINDS = {("land", "Zille"): 60, ("land", "Brenas"): 29, ("land", "Wehlen"): 33,
                ("land", "Derdia"): 7, ("sea", "Sea"): 57}
EXPECT_OWNERS = {"Rizia": 29, "Wehlen": 93, "Derdia": 7, "neutral": 57}
EXPECT_EDGES = 496
EXPECT_TYPES = {"land": 303, "sea": 111, "coastal": 79, "strait": 3}
CITIES = {P + i for i in ("2", "9", "11", "28", "35", "71", "94")}
SHIP = {P + i for i in ("S26", "S30", "S31", "S32", "S37", "S56", "S57")}
HEAVY = {P + i for i in ("36", "37", "39", "117", "118")}
LIGHT_EAST = {P + i for i in ("20", "26", "33", "104", "108", "114")}
LIGHT_NORTH = {P + i for i in ("8", "13", "17", "21", "97")}
STRAITS = {frozenset((P + a, P + b)) for a, b in (("2", "3"), ("3", "5"), ("72", "75"))}
MANUAL = [(P + "5", P + "9"), (P + "38", P + "115")]
NEW_WEHLEN = {P + i for i in ("119", "120", "121", "122")}
DERDIA_CELLS = {P + str(i) for i in range(123, 129)}
YOL = P + "129"
COASTAL_CITIES = {P + "71": "Kratsna", P + "94": "Grodzizg"}
ROTSLA = P + "96"
DEPLOY = (("minimal", 57), ("suspicious", 66), ("prepared", 81))
LESPIA_SLACK = 2.0      # map px (coast export is simplified with 1 px tolerance)
FRAME_BOTTOM = 7877
MAX_PROVINCES = 224


def load(path):
    with open(path, encoding="utf-8") as f:
        return json.load(f)


def seg_dist(px, py, ax, ay, bx, by):
    dx, dy = bx - ax, by - ay
    L = dx * dx + dy * dy
    t = 0.0 if L == 0 else max(0.0, min(1.0, ((px - ax) * dx + (py - ay) * dy) / L))
    return math.hypot(px - (ax + t * dx), py - (ay + t * dy))


def ring_dist(pts_a, pts_b):
    """min distance between two closed polylines (vertex-to-segment both ways)."""
    best = math.inf
    for src, dst in ((pts_a, pts_b), (pts_b, pts_a)):
        segs = list(zip(dst, dst[1:] + dst[:1]))
        for x, y in src:
            for (ax, ay), (bx, by) in segs:
                d = seg_dist(x, y, ax, ay, bx, by)
                if d < best:
                    best = d
    return best


def point_in(x, y, ring):
    inside = False
    n = len(ring)
    for i in range(n):
        x1, y1 = ring[i]
        x2, y2 = ring[(i + 1) % n]
        if (y1 > y) != (y2 > y) and x < (x2 - x1) * (y - y1) / (y2 - y1) + x1:
            inside = not inside
    return inside


def overlay_paths():
    svg = (REG / "provinces_overlay.svg").read_text(encoding="utf-8")
    out = {}
    for pid, d in re.findall(r'<path id="(ZilleTile_[^"]+)"[^>]*?\sd="([^"]+)"', svg):
        rings = []
        for sub in re.split(r"[Mm]", d):
            nums = [float(v) for v in re.findall(r"-?\d+(?:\.\d+)?", sub)]
            if len(nums) >= 6:
                rings.append(list(zip(nums[0::2], nums[1::2])))
        out[pid] = rings
    return out


def main():
    errors = []
    fail = errors.append
    info = []
    manifest = load(REG / "provinces_manifest.json")
    provs = manifest["provinces"]
    by_id = {p["id"]: p for p in provs}
    if len(provs) != EXPECT_TOTAL or len(provs) > MAX_PROVINCES:
        fail(f"province count {len(provs)} != {EXPECT_TOTAL} (max {MAX_PROVINCES})")
    if len(by_id) != len(provs):
        fail("duplicate province ids")
    names = Counter(p["name"] for p in provs)
    dup = [n for n, c in names.items() if c > 1]
    if dup:
        fail(f"duplicate names {dup}")
    kinds = Counter((p["type"], p["region"]) for p in provs)
    if dict(kinds) != EXPECT_KINDS:
        fail(f"type/region counts {dict(kinds)}")
    owners = Counter(p.get("owner") for p in provs)
    if dict(owners) != EXPECT_OWNERS:
        fail(f"owners {dict(owners)}")
    land = sorted(int(i[len(P):]) for i in by_id if not i.startswith(P + "S"))
    sea = sorted(int(i[len(P) + 1:]) for i in by_id if i.startswith(P + "S"))
    if land != list(range(1, 130)) or sea != list(range(1, 58)):
        fail(f"id ranges land {land[:3]}..{land[-3:]} sea {sea[:3]}..{sea[-3:]}")
    png = list(REG.glob(P + "*.png"))
    svg = list(REG.glob(P + "*.svg"))
    if len(png) != EXPECT_TOTAL or len(svg) != EXPECT_TOTAL:
        fail(f"tile files png {len(png)} svg {len(svg)}")
    missing_art = [i for i in by_id if not (REG / f"{i}.png").exists() or not (REG / f"{i}.svg").exists()]
    if missing_art:
        fail(f"missing tile art {missing_art[:8]}")
    ships = {p["id"] for p in provs if p.get("rizia_ship_placement")}
    if ships != SHIP:
        fail(f"ship seas {sorted(ships)}")
    for p in provs:
        ext = p["map_extent_incl_effects"]
        small_ok = p.get("island") or p.get("is_city")
        if ext >= 980 or (ext <= 512 and not small_ok):
            fail(f"size rule {p['id']} {p['name']} extent {ext}")
    for pid, nm in COASTAL_CITIES.items():
        p = by_id.get(pid, {})
        if not (p.get("is_city") and p.get("is_coastal") and p.get("city_name") == nm):
            fail(f"{nm} is not a coastal city province ({pid})")
    # Derdia strip + Yol
    der = {p["id"] for p in provs if p["region"] == "Derdia"}
    if der != DERDIA_CELLS | {YOL}:
        fail(f"Derdia ids {sorted(der)}")
    if any(by_id[i].get("owner") != "Derdia" for i in der):
        fail("a Derdia province is not owned by Derdia")
    if not by_id[YOL].get("impassable") or [i for i in der - {YOL} if by_id[i].get("impassable")]:
        fail("impassable flag: only Yol must be impassable")
    for i in NEW_WEHLEN:
        if by_id.get(i, {}).get("region") != "Wehlen":
            fail(f"new Wehlen province {i} missing")
    # bottom edge flush
    for p in provs:
        bottom = p["map_bbox_y"] + p["bbox_h"]
        if bottom > FRAME_BOTTOM + 0.6:
            fail(f"{p['id']} extends below the frame ({bottom:.1f})")
    for pid in (P + "S56", P + "S57"):
        b = by_id[pid]["map_bbox_y"] + by_id[pid]["bbox_h"]
        if abs(b - FRAME_BOTTOM) > 0.6:
            fail(f"bottom sea {pid} not flush ({b:.1f})")

    # adjacency
    adj = load(REG / "provinces_adjacency.json")
    graph = adj["provinces"]
    if set(graph) != set(by_id):
        fail("adjacency province set != manifest")
    undirected = {}
    for pid, node in graph.items():
        for n in node["neighbours"]:
            key = tuple(sorted((pid, n["id"])))
            undirected.setdefault(key, set()).add(n["type"])
            back = [b for b in graph.get(n["id"], {}).get("neighbours", []) if b["id"] == pid]
            if len(back) != 1:
                fail(f"asymmetric {pid} -> {n['id']}")
            elif back[0]["type"] != n["type"]:
                fail(f"type mismatch {pid} {n['id']}")
    if len(undirected) != EXPECT_EDGES:
        fail(f"undirected edges {len(undirected)} != {EXPECT_EDGES}")
    types = Counter()
    for typeset in undirected.values():
        if len(typeset) != 1:
            fail(f"edge has mixed types {typeset}")
        types[next(iter(typeset))] += 1
    if dict(types) != EXPECT_TYPES:
        fail(f"edge types {dict(types)}")
    if graph[YOL]["neighbours"]:
        fail(f"Yol {YOL} has links {[n['id'] for n in graph[YOL]['neighbours']]}")
    passable = [k for k in graph if k != YOL]
    if min(len(graph[k]["neighbours"]) for k in passable) < 2:
        fail("a passable province has fewer than 2 neighbours")
    seen = {passable[0]}
    q = deque(seen)
    while q:
        cur = q.popleft()
        for n in graph[cur]["neighbours"]:
            if n["id"] not in seen:
                seen.add(n["id"])
                q.append(n["id"])
    if len(seen) != len(passable):
        fail(f"passable components: reached {len(seen)} of {len(passable)}")
    sea_ids = [k for k in graph if k.startswith(P + "S")]
    sseen = {sea_ids[0]}
    q = deque(sseen)
    while q:
        cur = q.popleft()
        for n in graph[cur]["neighbours"]:
            if n["type"] == "sea" and n["id"] not in sseen:
                sseen.add(n["id"])
                q.append(n["id"])
    if len(sseen) != len(sea_ids):
        fail(f"sea network split: {len(sseen)} of {len(sea_ids)} reachable by sea links")
    strait_edges = {frozenset(k) for k, v in undirected.items() if next(iter(v)) == "strait"}
    if strait_edges != STRAITS:
        fail(f"straits {strait_edges}")
    for pair in MANUAL:
        if tuple(sorted(pair)) not in undirected:
            fail(f"missing manual link {pair}")
    if any(n["type"] not in ("coastal",) for n in graph[ROTSLA]["neighbours"]) or not graph[ROTSLA]["neighbours"]:
        fail("Rotsla (96) must be reachable by sea only")
    dw = sorted(k for k in undirected if (k[0] in DERDIA_CELLS) != (k[1] in DERDIA_CELLS)
                and by_id[k[0]]["region"] in ("Wehlen", "Derdia") and by_id[k[1]]["region"] in ("Wehlen", "Derdia"))
    front = sorted({a if a not in DERDIA_CELLS else b for a, b in dw}, key=lambda s: int(s[len(P):]))
    if not dw:
        fail("no Wehlen-Derdia land links")
    info.append(f"Derdia-Wehlen links {len(dw)}, Wehlen southern front {[f[len(P):] for f in front]}")

    # Lespia's territorial waters
    lw = load(REG / "lespia_territorial_waters.json")
    gap = lw["min_distance_map_px"]
    coast = lw["lespia_coast_polygons"]
    cxs = [x for r in coast for x, _ in r]
    cys = [y for r in coast for _, y in r]
    cbox = (min(cxs) - gap, min(cys) - gap, max(cxs) + gap, max(cys) + gap)
    paths = overlay_paths()
    if set(paths) != set(by_id):
        fail(f"overlay paths {len(paths)} != manifest")
    closest = []
    for pid, rings in paths.items():
        xs = [x for r in rings for x, _ in r]
        ys = [y for r in rings for _, y in r]
        if max(xs) < cbox[0] or min(xs) > cbox[2] or max(ys) < cbox[1] or min(ys) > cbox[3]:
            continue
        d = min(ring_dist(r, c) for r in rings for c in coast)
        if any(point_in(x, y, r) for c in coast for x, y in c[:1] for r in rings) or \
           any(point_in(x, y, c) for r in rings for x, y in r[:1] for c in coast):
            d = 0.0
        closest.append((round(d, 1), pid))
        if d < gap - LESPIA_SLACK:
            fail(f"{pid} {by_id[pid]['name']} is {d:.1f} px from Lespia (< {gap})")
    closest.sort()
    if not lw.get("label_paths") or len(lw["label_paths"]) < 2:
        fail("Lespia's Territorial Waters label must repeat (>= 2 labels)")
    base = (ROOT / "map" / "T_Map_Zille_Full_Composite.svg")
    if base.exists() and base.read_text(encoding="utf-8").count("Lespia\u2019s Territorial Waters") < 2:
        fail("map svg lacks the repeated Lespia's Territorial Waters labels")
    info.append("Lespia closest seas " + ", ".join(f"{p[len(P):]} {d}" for d, p in closest[:5]))

    # forts
    forts = load(REG / "forts.json")["forts"]
    got = {(f["province_id"], f["fort"], f["defense_line"]) for f in forts}
    expect_forts = {(i, "heavy", "border_west") for i in HEAVY}
    expect_forts |= {(i, "light", "border_east") for i in LIGHT_EAST}
    expect_forts |= {(i, "light", "north_line") for i in LIGHT_NORTH}
    if got != expect_forts:
        fail(f"forts differ: extra {got - expect_forts} missing {expect_forts - got}")
    for pid, kind, line in got:
        if by_id[pid].get("fort") != kind or by_id[pid].get("defense_line") != line:
            fail(f"manifest fort mismatch {pid}")

    # deployments
    dep_info = []
    for variant, n_expect in DEPLOY:
        doc = load(REG / "deployments" / f"deployment_{variant}.json")
        units = doc["deployment"]
        if len(units) != n_expect:
            fail(f"{variant} count {len(units)} != {n_expect}")
        seen_p = set()
        flags = 0
        for u in units:
            pid = u["province_id"]
            if pid in seen_p:
                fail(f"{variant} duplicate {pid}")
            seen_p.add(pid)
            if pid not in by_id:
                fail(f"{variant} unknown {pid}")
                continue
            if pid in CITIES or by_id[pid].get("is_city"):
                fail(f"{variant} unit on city {pid}")
            if pid in SHIP:
                fail(f"{variant} unit on Rizia ship sea {pid}")
            if by_id[pid].get("impassable"):
                fail(f"{variant} unit on impassable {pid}")
            if by_id[pid]["type"] == "land" and by_id[pid].get("owner") != "Wehlen":
                fail(f"{variant} land unit not on Wehlen {pid}")
            if u["unit_type"] == "flagship":
                flags += 1
        if flags != 1:
            fail(f"{variant} flagships {flags}")
        summary = doc["summary"]["totals_by_type"]
        got_types = Counter(u["unit_type"] for u in units)
        if dict(got_types) != summary:
            fail(f"{variant} summary mismatch {dict(got_types)} vs {summary}")
        on_front = len(seen_p & set(front))
        dep_info.append(f"{variant} {len(units)} (front {on_front}/{len(front)})")
    info.append("deployments " + ", ".join(dep_info))

    if errors:
        print("FAIL")
        for e in errors:
            print(" -", e)
        return 1
    print(f"OK v14 pack: {len(provs)} provinces, {len(undirected)} symmetric links "
          f"({', '.join(f'{k} {v}' for k, v in sorted(types.items()))}), Yol impassable, "
          f"seas >= {gap} px from Lespia, deployments obey 1 unit and no cities")
    for line in info:
        print("  " + line)
    return 0


if __name__ == "__main__":
    sys.exit(main())
