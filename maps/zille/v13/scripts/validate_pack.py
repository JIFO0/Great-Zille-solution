#!/usr/bin/env python3
"""Check the v13 Zille data pack: counts, symmetry, forts, and deployment rules.

Run from the repo root:
  python3 maps/zille/v13/scripts/validate_pack.py
"""
import json
import sys
from collections import Counter, deque
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
REG = ROOT / "regions"
CITIES = {
    "ZilleTile_2", "ZilleTile_9", "ZilleTile_11", "ZilleTile_28",
    "ZilleTile_35", "ZilleTile_71", "ZilleTile_94",
}
SHIP = {
    "ZilleTile_S26", "ZilleTile_S30", "ZilleTile_S31", "ZilleTile_S32",
    "ZilleTile_S37", "ZilleTile_S56", "ZilleTile_S57",
}
HEAVY = {"ZilleTile_36", "ZilleTile_37", "ZilleTile_39", "ZilleTile_117", "ZilleTile_118"}
LIGHT_EAST = {"ZilleTile_20", "ZilleTile_26", "ZilleTile_33", "ZilleTile_104", "ZilleTile_108", "ZilleTile_114"}
LIGHT_NORTH = {"ZilleTile_8", "ZilleTile_13", "ZilleTile_17", "ZilleTile_21", "ZilleTile_97"}
STRAITS = {frozenset(p) for p in (
    ("ZilleTile_2", "ZilleTile_3"),
    ("ZilleTile_3", "ZilleTile_5"),
    ("ZilleTile_72", "ZilleTile_75"),
)}


def fail(errors, msg):
    errors.append(msg)


def load(path):
    with open(path, encoding="utf-8") as f:
        return json.load(f)


def main():
    errors = []
    manifest = load(REG / "provinces_manifest.json")
    provs = manifest["provinces"]
    if len(provs) != 175:
        fail(errors, f"province count {len(provs)} != 175")
    by_id = {p["id"]: p for p in provs}
    if len(by_id) != len(provs):
        fail(errors, "duplicate province ids")
    kinds = Counter((p["type"], p["region"]) for p in provs)
    expect_kinds = {
        ("land", "Zille"): 60, ("land", "Brenas"): 29,
        ("land", "Wehlen"): 29, ("sea", "Sea"): 57,
    }
    if dict(kinds) != expect_kinds:
        fail(errors, f"type/region counts {dict(kinds)}")
    owners = Counter(p.get("owner") for p in provs)
    if owners != Counter({"Rizia": 29, "Wehlen": 89, "neutral": 57}):
        fail(errors, f"owners {dict(owners)}")
    land = sorted(int(i[len("ZilleTile_"):]) for i in by_id if not i.startswith("ZilleTile_S"))
    sea = sorted(int(i[len("ZilleTile_S"):]) for i in by_id if i.startswith("ZilleTile_S"))
    if land != list(range(1, 119)) or sea != list(range(1, 58)):
        fail(errors, f"id ranges land {land[:3]}..{land[-3:]} sea {sea[:3]}..{sea[-3:]}")
    png = list((REG).glob("ZilleTile_*.png"))
    svg = list((REG).glob("ZilleTile_*.svg"))
    if len(png) != 175 or len(svg) != 175:
        fail(errors, f"tile files png {len(png)} svg {len(svg)}")
    missing_art = [i for i in by_id if not (REG / f"{i}.png").exists() or not (REG / f"{i}.svg").exists()]
    if missing_art:
        fail(errors, f"missing tile art {missing_art[:8]}")
    ships = {p["id"] for p in provs if p.get("rizia_ship_placement")}
    if ships != SHIP:
        fail(errors, f"ship seas {sorted(ships)}")

    adj = load(REG / "provinces_adjacency.json")
    graph = adj["provinces"]
    if set(graph) != set(by_id):
        fail(errors, "adjacency province set != manifest")
    undirected = {}
    for pid, node in graph.items():
        for n in node["neighbours"]:
            key = tuple(sorted((pid, n["id"])))
            undirected.setdefault(key, set()).add(n["type"])
            back = [b for b in graph.get(n["id"], {}).get("neighbours", []) if b["id"] == pid]
            if len(back) != 1:
                fail(errors, f"asymmetric {pid} -> {n['id']}")
            elif back[0]["type"] != n["type"]:
                fail(errors, f"type mismatch {pid} {n['id']}")
    if len(undirected) != 471:
        fail(errors, f"undirected edges {len(undirected)} != 471")
    types = Counter()
    for typeset in undirected.values():
        if len(typeset) != 1:
            fail(errors, f"edge has mixed types {typeset}")
        types[next(iter(typeset))] += 1
    if dict(types) != {"land": 279, "sea": 111, "coastal": 78, "strait": 3}:
        fail(errors, f"edge types {dict(types)}")
    if min(len(n["neighbours"]) for n in graph.values()) < 2:
        fail(errors, "a province has fewer than 2 neighbours")
    seen = set()
    q = deque([next(iter(graph))])
    seen.add(q[0])
    while q:
        cur = q.popleft()
        for n in graph[cur]["neighbours"]:
            if n["id"] not in seen:
                seen.add(n["id"])
                q.append(n["id"])
    if len(seen) != 175:
        fail(errors, f"components: reached {len(seen)} of 175")
    strait_edges = {frozenset(k) for k, t in ((k, next(iter(v))) for k, v in undirected.items()) if t == "strait"}
    if strait_edges != STRAITS:
        fail(errors, f"straits {strait_edges}")
    if ("ZilleTile_34", "ZilleTile_38") in undirected or ("ZilleTile_38", "ZilleTile_34") in undirected:
        fail(errors, "v12 link 34-38 is still present")
    for pair in (("ZilleTile_5", "ZilleTile_9"), ("ZilleTile_38", "ZilleTile_115")):
        if tuple(sorted(pair)) not in undirected:
            fail(errors, f"missing manual link {pair}")

    forts = load(REG / "forts.json")["forts"]
    got = {(f["province_id"], f["fort"], f["defense_line"]) for f in forts}
    expect_forts = {(i, "heavy", "border_west") for i in HEAVY}
    expect_forts |= {(i, "light", "border_east") for i in LIGHT_EAST}
    expect_forts |= {(i, "light", "north_line") for i in LIGHT_NORTH}
    if got != expect_forts:
        fail(errors, f"forts differ: extra {got - expect_forts} missing {expect_forts - got}")
    for pid, kind, line in got:
        if by_id[pid].get("fort") != kind or by_id[pid].get("defense_line") != line:
            fail(errors, f"manifest fort mismatch {pid}")

    for variant, n_expect in (("minimal", 55), ("suspicious", 66), ("prepared", 73)):
        doc = load(REG / "deployments" / f"deployment_{variant}.json")
        units = doc["deployment"]
        if len(units) != n_expect:
            fail(errors, f"{variant} count {len(units)} != {n_expect}")
        seen_p = set()
        flags = 0
        for u in units:
            pid = u["province_id"]
            if pid in seen_p:
                fail(errors, f"{variant} duplicate {pid}")
            seen_p.add(pid)
            if pid not in by_id:
                fail(errors, f"{variant} unknown {pid}")
                continue
            if pid in CITIES or by_id[pid].get("is_city"):
                fail(errors, f"{variant} unit on city {pid}")
            if pid in SHIP:
                fail(errors, f"{variant} unit on Rizia ship sea {pid}")
            owner = by_id[pid].get("owner")
            if by_id[pid]["type"] == "land" and owner != "Wehlen":
                fail(errors, f"{variant} land unit not on Wehlen {pid}")
            if u["unit_type"] == "flagship":
                flags += 1
        if flags != 1:
            fail(errors, f"{variant} flagships {flags}")
        summary = doc["summary"]["totals_by_type"]
        got_types = Counter(u["unit_type"] for u in units)
        if dict(got_types) != summary:
            fail(errors, f"{variant} summary mismatch {dict(got_types)} vs {summary}")

    if errors:
        print("FAIL")
        for e in errors:
            print(" -", e)
        return 1
    print("OK v13 pack: 175 provinces, 471 symmetric links, deployments obey 1 unit and no cities")
    return 0


if __name__ == "__main__":
    sys.exit(main())
