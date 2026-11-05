import json
import os

with open("docs/raw_database_dumps/DecisionData.json", "r", encoding="utf-8") as f:
    dec = json.load(f)

r_dec = [it for it in dec["items"] if "Rizia" in it.get("Path", "")]
turn_dec = [it for it in r_dec if it.get("NameInDatabase", "").startswith("Turn")]
print(f"Total Decisions in Rizia: {len(r_dec)} (Turn-based: {len(turn_dec)}, Floating: {len(r_dec) - len(turn_dec)})")

by_turn = {}
for it in turn_dec:
    name = it.get("NameInDatabase", "")
    turn_prefix = name[:6]
    by_turn.setdefault(turn_prefix, []).append(it)

for t in sorted(by_turn.keys()):
    print(f"\n=== {t} ({len(by_turn[t])} decisions) ===")
    for d in by_turn[t]:
        dp = d.get("DecisionProperties", {})
        title = dp.get("Title", "")
        opts = dp.get("Options", [])
        print(f"  [{d.get('NameInDatabase')}] : \"{title}\" ({len(opts)} options)")
