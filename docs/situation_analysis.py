import json

with open("docs/raw_database_dumps/SituationData.json", "r", encoding="utf-8") as f:
    sit = json.load(f)

r_sit = [it for it in sit["items"] if "Rizia" in it.get("Path", "")]
print(f"Total Situations in Rizia: {len(r_sit)}")

by_cat = {}
for it in r_sit:
    path = it.get("Path", "")
    # e.g. Rizia/Situations/Economy/Starting Situations
    parts = path.split("/")
    cat = parts[2] if len(parts) > 2 else "Other"
    by_cat.setdefault(cat, []).append(it)

for c in sorted(by_cat.keys()):
    print(f"\n=== Category: {c} ({len(by_cat[c])} situations) ===")
    for s in by_cat[c][:6]:
        sp = s.get("SituationProperties", {})
        title = sp.get("Title", "")
        sev = sp.get("SituationSeverityString", "")
        var = sp.get("IsEnabledVariable", "")
        print(f"  [{s.get('NameInDatabase')}] : \"{title}\" (Sev: {sev}) -> Var: {var}")
