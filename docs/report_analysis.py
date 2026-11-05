import json

with open("docs/raw_database_dumps/ReportData.json", "r", encoding="utf-8") as f:
    rep = json.load(f)

r_rep = [it for it in rep["items"] if "Rizia" in it.get("Path", "")]
print(f"Total Reports in Rizia: {len(r_rep)}")

by_cat = {}
for it in r_rep:
    path = it.get("Path", "")
    parts = path.split("/")
    cat = parts[2] if len(parts) > 2 else "Other"
    by_cat.setdefault(cat, []).append(it)

for c in sorted(by_cat.keys()):
    print(f"\n=== Report Category: {c} ({len(by_cat[c])} reports) ===")
    for r in by_cat[c][:4]:
        rp = r.get("ReportProperties", {})
        title = rp.get("Title", "")
        tok = r.get("AssignedTokenProperties", {}).get("AssignedToken", "None")
        print(f"  [{r.get('NameInDatabase')}] : \"{title}\" (Token: {tok})")
