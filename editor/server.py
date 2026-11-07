import os
import sys
import json
import webbrowser
from http.server import HTTPServer, SimpleHTTPRequestHandler
import urllib.parse
import shutil

PORT = 5050
BASE_DIR = os.path.dirname(os.path.abspath(__file__))
REPO_DIR = os.path.dirname(BASE_DIR)
DATA_DIR = os.path.join(BASE_DIR, "data")
CONV_DIR = os.path.join(DATA_DIR, "conversations")
ASSETS_DIR = os.path.join(REPO_DIR, "assets")
OVERRIDES_FILE_REPO = os.path.join(ASSETS_DIR, "mod_dialogue_overrides.json")
STEAM_MODS_DIR = r"C:\Program Files (x86)\Steam\steamapps\common\Suzerain\Mods\GreatZilleAssets"
OVERRIDES_FILE_GAME = os.path.join(STEAM_MODS_DIR, "mod_dialogue_overrides.json")

def ensure_overrides_file():
    if not os.path.exists(OVERRIDES_FILE_REPO):
        initial = {
            "version": "1.0",
            "lastModified": "",
            "conversations": [],
            "decisions": [],
            "reports": [],
            "situations": [],
            "customVariables": []
        }
        with open(OVERRIDES_FILE_REPO, "w", encoding="utf-8") as f:
            json.dump(initial, f, indent=2, ensure_ascii=False)

def sync_to_game():
    if os.path.exists(OVERRIDES_FILE_REPO) and os.path.exists(STEAM_MODS_DIR):
        try:
            shutil.copy2(OVERRIDES_FILE_REPO, OVERRIDES_FILE_GAME)
            return True
        except Exception as e:
            print(f"[WARN] Failed to copy to game directory: {e}")
            return False
    return False

def load_overrides():
    ensure_overrides_file()
    try:
        with open(OVERRIDES_FILE_REPO, "r", encoding="utf-8") as f:
            return json.load(f)
    except:
        return {"conversations": [], "decisions": [], "reports": [], "situations": [], "customVariables": []}

def save_overrides(data):
    import time
    data["lastModified"] = time.strftime("%Y-%m-%d %H:%M:%S")
    with open(OVERRIDES_FILE_REPO, "w", encoding="utf-8") as f:
        json.dump(data, f, indent=2, ensure_ascii=False)
    sync_to_game()

class EditorRequestHandler(SimpleHTTPRequestHandler):
    def __init__(self, *args, **kwargs):
        super().__init__(*args, directory=BASE_DIR, **kwargs)

    def do_GET(self):
        parsed = urllib.parse.urlparse(self.path)
        path = parsed.path
        query = urllib.parse.parse_qs(parsed.query)

        if path == "/api/manifest":
            self.send_json_file(os.path.join(DATA_DIR, "manifest.json"))
        elif path == "/api/catalog":
            self.send_json_file(os.path.join(DATA_DIR, "catalog.json"))
        elif path == "/api/conversation":
            cid = query.get("id", [None])[0]
            if cid:
                file_path = os.path.join(CONV_DIR, f"{cid}.json")
                if os.path.exists(file_path):
                    self.send_json_file(file_path)
                else:
                    self.send_error(404, "Conversation not found")
            else:
                self.send_error(400, "Missing conversation id")
        elif path == "/api/decisions":
            self.send_json_file(os.path.join(DATA_DIR, "decisions.json"))
        elif path == "/api/reports":
            self.send_json_file(os.path.join(DATA_DIR, "reports.json"))
        elif path == "/api/situations":
            self.send_json_file(os.path.join(DATA_DIR, "situations.json"))
        elif path == "/api/variables":
            self.send_json_file(os.path.join(DATA_DIR, "variables.json"))
        elif path == "/api/actors":
            self.send_json_file(os.path.join(DATA_DIR, "actors.json"))
        elif path == "/api/overrides":
            self.send_json_data(load_overrides())
        elif path == "/" or path == "":
            self.path = "/index.html"
            return super().do_GET()
        else:
            return super().do_GET()

    def do_POST(self):
        parsed = urllib.parse.urlparse(self.path)
        path = parsed.path

        content_length = int(self.headers.get('Content-Length', 0))
        post_body = self.rfile.read(content_length).decode('utf-8')
        try:
            req_data = json.loads(post_body) if post_body else {}
        except Exception as e:
            self.send_error(400, f"Invalid JSON: {e}")
            return

        if path == "/api/conversation/save":
            self.handle_save_conversation(req_data)
        elif path == "/api/decision/save":
            self.handle_save_decision(req_data)
        elif path == "/api/report/save":
            self.handle_save_report(req_data)
        elif path == "/api/situation/save":
            self.handle_save_situation(req_data)
        elif path == "/api/prerequisites/create":
            self.handle_create_prerequisite(req_data)
        elif path == "/api/search":
            self.handle_search(req_data)
        elif path == "/api/deploy":
            synced = sync_to_game()
            self.send_json_data({"success": True, "syncedToGame": synced})
        else:
            self.send_error(404, "Unknown endpoint")

    def handle_save_conversation(self, data):
        cid = data.get("id")
        if not cid:
            self.send_error(400, "Missing conversation ID")
            return

        conv_file = os.path.join(CONV_DIR, f"{cid}.json")
        # Ensure mod status is at least MODEDIT if it was VANILLA
        if data.get("modStatus") == "VANILLA":
            data["modStatus"] = "MODEDIT"
            data["modNote"] = "Zmodyfikowano przez Edytor Dialogów Great Zille"

        # Save to individual conversation cache
        with open(conv_file, "w", encoding="utf-8") as f:
            json.dump(data, f, indent=2, ensure_ascii=False)

        # Update catalog.json
        cat_file = os.path.join(DATA_DIR, "catalog.json")
        if os.path.exists(cat_file):
            catalog = json.load(open(cat_file, encoding="utf-8"))
            for item in catalog:
                if str(item.get("id")) == str(cid):
                    item["modStatus"] = data["modStatus"]
                    item["entriesCount"] = len(data.get("entries", []))
                    item["choicesCount"] = len([e for e in data.get("entries", []) if e.get("isPlayer")])
                    item["modNote"] = data.get("modNote", "")
                    break
            with open(cat_file, "w", encoding="utf-8") as f:
                json.dump(catalog, f, indent=2, ensure_ascii=False)

        # Record in overrides
        overrides = load_overrides()
        conv_overrides = overrides.setdefault("conversations", [])
        # Find existing or append
        existing = next((c for c in conv_overrides if str(c.get("id")) == str(cid)), None)
        conv_override_record = {
            "id": cid,
            "title": data.get("title", ""),
            "entries": []
        }
        for e in data.get("entries", []):
            if data.get("modStatus") == "MODNEW" or e.get("isModEdited") or e.get("isModInjected"):
                conv_override_record["entries"].append({
                    "id": e.get("id"),
                    "actorId": e.get("actorId"),
                    "dialogueText": e.get("dialogueText", ""),
                    "menuText": e.get("menuText", ""),
                    "conditions": e.get("conditions", ""),
                    "userScript": e.get("userScript", ""),
                    "outgoing": e.get("outgoing", [])
                })

        if existing:
            conv_overrides[conv_overrides.index(existing)] = conv_override_record
        else:
            conv_overrides.append(conv_override_record)

        save_overrides(overrides)
        synced = sync_to_game()

        self.send_json_data({
            "success": True,
            "message": f"Konwersacja '{data.get('title')}' zapisana!",
            "syncedToGame": synced,
            "modStatus": data["modStatus"]
        })

    def handle_save_decision(self, data):
        dec_id = data.get("id")
        if not dec_id:
            self.send_error(400, "Missing decision ID")
            return

        dec_file = os.path.join(DATA_DIR, "decisions.json")
        decisions = json.load(open(dec_file, encoding="utf-8")) if os.path.exists(dec_file) else []

        found = False
        for idx, d in enumerate(decisions):
            if d.get("id") == dec_id or d.get("name") == dec_id:
                if d.get("modStatus") == "VANILLA":
                    data["modStatus"] = "MODEDIT"
                decisions[idx] = data
                found = True
                break
        if not found:
            data["modStatus"] = "MODNEW"
            decisions.insert(0, data)

        with open(dec_file, "w", encoding="utf-8") as f:
            json.dump(decisions, f, indent=2, ensure_ascii=False)

        # Update overrides
        overrides = load_overrides()
        dec_overrides = overrides.setdefault("decisions", [])
        existing = next((d for d in dec_overrides if d.get("id") == dec_id), None)
        override_record = {
            "id": dec_id,
            "title": data.get("title", ""),
            "description": data.get("description", ""),
            "condition": data.get("condition", ""),
            "options": data.get("options", [])
        }
        if existing:
            dec_overrides[dec_overrides.index(existing)] = override_record
        else:
            dec_overrides.append(override_record)

        save_overrides(overrides)
        synced = sync_to_game()
        self.send_json_data({"success": True, "message": f"Decyzja '{data.get('title')}' zapisana!", "syncedToGame": synced})

    def handle_save_report(self, data):
        rep_id = data.get("id")
        if not rep_id:
            self.send_error(400, "Missing report ID")
            return

        rep_file = os.path.join(DATA_DIR, "reports.json")
        reports = json.load(open(rep_file, encoding="utf-8")) if os.path.exists(rep_file) else []

        found = False
        for idx, r in enumerate(reports):
            if r.get("id") == rep_id or r.get("name") == rep_id:
                if r.get("modStatus") == "VANILLA":
                    data["modStatus"] = "MODEDIT"
                reports[idx] = data
                found = True
                break
        if not found:
            data["modStatus"] = "MODNEW"
            reports.insert(0, data)

        with open(rep_file, "w", encoding="utf-8") as f:
            json.dump(reports, f, indent=2, ensure_ascii=False)

        overrides = load_overrides()
        rep_overrides = overrides.setdefault("reports", [])
        existing = next((r for r in rep_overrides if r.get("id") == rep_id), None)
        override_record = {
            "id": rep_id,
            "title": data.get("title", ""),
            "description": data.get("description", ""),
            "condition": data.get("condition", "")
        }
        if existing:
            rep_overrides[rep_overrides.index(existing)] = override_record
        else:
            rep_overrides.append(override_record)

        save_overrides(overrides)
        synced = sync_to_game()
        self.send_json_data({"success": True, "message": f"Raport '{data.get('title')}' zapisany!", "syncedToGame": synced})

    def handle_save_situation(self, data):
        sit_id = data.get("id")
        if not sit_id:
            self.send_error(400, "Missing situation ID")
            return

        sit_file = os.path.join(DATA_DIR, "situations.json")
        situations = json.load(open(sit_file, encoding="utf-8")) if os.path.exists(sit_file) else []

        found = False
        for idx, s in enumerate(situations):
            if s.get("id") == sit_id or s.get("name") == sit_id:
                if s.get("modStatus") == "VANILLA":
                    data["modStatus"] = "MODEDIT"
                situations[idx] = data
                found = True
                break
        if not found:
            data["modStatus"] = "MODNEW"
            situations.insert(0, data)

        with open(sit_file, "w", encoding="utf-8") as f:
            json.dump(situations, f, indent=2, ensure_ascii=False)

        overrides = load_overrides()
        sit_overrides = overrides.setdefault("situations", [])
        existing = next((s for s in sit_overrides if s.get("id") == sit_id), None)
        override_record = {
            "id": sit_id,
            "title": data.get("title", ""),
            "description": data.get("description", ""),
            "condition": data.get("condition", "")
        }
        if existing:
            sit_overrides[sit_overrides.index(existing)] = override_record
        else:
            sit_overrides.append(override_record)

        save_overrides(overrides)
        synced = sync_to_game()
        self.send_json_data({"success": True, "message": f"Sytuacja '{data.get('title')}' zapisana!", "syncedToGame": synced})

    def handle_create_prerequisite(self, data):
        tag_name = data.get("name", "").strip()
        if not tag_name:
            self.send_error(400, "Missing tag name")
            return

        var_file = os.path.join(DATA_DIR, "variables.json")
        vars_map = json.load(open(var_file, encoding="utf-8")) if os.path.exists(var_file) else {}

        tag_obj = {
            "name": tag_name,
            "type": data.get("type", "Boolean"),
            "defaultValue": data.get("defaultValue", "False"),
            "description": data.get("description", "Nowy tag / zmienna zdefiniowana przez gracza"),
            "category": data.get("category", "Własne Tagi Gracza (Custom)"),
            "isCustom": True
        }
        vars_map[tag_name] = tag_obj

        with open(var_file, "w", encoding="utf-8") as f:
            json.dump(vars_map, f, indent=2, ensure_ascii=False)

        # Update overrides
        overrides = load_overrides()
        custom_vars = overrides.setdefault("customVariables", [])
        if not any(v.get("name") == tag_name for v in custom_vars):
            custom_vars.append(tag_obj)
        save_overrides(overrides)
        sync_to_game()

        self.send_json_data({"success": True, "message": f"Tag warunku '{tag_name}' został pomyślnie utworzony!", "tag": tag_obj})

    def handle_search(self, data):
        query = data.get("query", "").strip().lower()
        tag_filter = data.get("tag", "").strip()
        category = data.get("category", "conversations") # conversations, decisions, reports, situations

        results = []
        if not query and not tag_filter:
            self.send_json_data({"results": []})
            return

        if category == "conversations":
            cat_file = os.path.join(DATA_DIR, "catalog.json")
            catalog = json.load(open(cat_file, encoding="utf-8")) if os.path.exists(cat_file) else []

            for item in catalog:
                match = False
                matched_snippet = ""

                # Check title, id, turn
                if query:
                    if query in item.get("title", "").lower() or query in str(item.get("id")) or query in item.get("turn", "").lower():
                        match = True
                        matched_snippet = f"Tytuł: {item.get('title')}"

                # Check tag filter
                if tag_filter:
                    r_vars = [v.lower() for v in item.get("readVariables", [])]
                    w_vars = [v.lower() for v in item.get("writtenVariables", [])]
                    if tag_filter.lower() in r_vars or tag_filter.lower() in w_vars:
                        match = True
                        matched_snippet = f"Zawiera tag warunku: {tag_filter}"
                    elif not query:
                        match = False

                # Deep search in conversation entries if not yet matched and query is long enough
                if not match and query and len(query) >= 3:
                    c_path = os.path.join(CONV_DIR, f"{item['id']}.json")
                    if os.path.exists(c_path):
                        try:
                            c_data = json.load(open(c_path, encoding="utf-8"))
                            for e in c_data.get("entries", []):
                                dt = e.get("dialogueText", "").lower()
                                mt = e.get("menuText", "").lower()
                                sp = e.get("speaker", "").lower()
                                cond = e.get("conditions", "").lower()
                                if query in dt or query in mt or query in cond:
                                    match = True
                                    snip = e.get("dialogueText") or e.get("menuText")
                                    matched_snippet = f"[{e.get('speaker')}]: {snip[:120]}..."
                                    break
                        except:
                            pass

                if match:
                    results.append({
                        "id": item["id"],
                        "title": item["title"],
                        "turn": item["turn"],
                        "pack": item["pack"],
                        "modStatus": item["modStatus"],
                        "snippet": matched_snippet or item.get("description", "")
                    })
                    if len(results) >= 50:
                        break

        elif category == "decisions":
            dec_file = os.path.join(DATA_DIR, "decisions.json")
            decs = json.load(open(dec_file, encoding="utf-8")) if os.path.exists(dec_file) else []
            for d in decs:
                txt = (d.get("title", "") + " " + d.get("description", "") + " " + d.get("condition", "")).lower()
                opts_txt = " ".join([o.get("text", "") + " " + o.get("condition", "") for o in d.get("options", [])]).lower()
                full = txt + " " + opts_txt
                if (query and query in full) or (tag_filter and tag_filter.lower() in full):
                    results.append({
                        "id": d.get("id"),
                        "title": d.get("title"),
                        "turn": d.get("pack"),
                        "pack": d.get("pack"),
                        "modStatus": d.get("modStatus"),
                        "snippet": d.get("description", "")[:120]
                    })

        self.send_json_data({"results": results})

    def send_json_file(self, file_path):
        if not os.path.exists(file_path):
            self.send_error(404, "File not found")
            return
        with open(file_path, "r", encoding="utf-8") as f:
            content = f.read()
        self.send_response(200)
        self.send_header('Content-Type', 'application/json; charset=utf-8')
        self.send_header('Access-Control-Allow-Origin', '*')
        self.end_headers()
        self.wfile.write(content.encode('utf-8'))

    def send_json_data(self, data):
        content = json.dumps(data, ensure_ascii=False)
        self.send_response(200)
        self.send_header('Content-Type', 'application/json; charset=utf-8')
        self.send_header('Access-Control-Allow-Origin', '*')
        self.end_headers()
        self.wfile.write(content.encode('utf-8'))

def run_server():
    ensure_overrides_file()
    sync_to_game()
    server_address = ('', PORT)
    httpd = HTTPServer(server_address, EditorRequestHandler)
    print("=" * 65)
    print(" [GREAT ZILLE SOLUTION] - NARRATIVE & DIALOGUE WEB EDITOR")
    print(f" Server running at: http://localhost:{PORT}")
    print(f" Overrides saved to: {OVERRIDES_FILE_REPO}")
    if os.path.exists(STEAM_MODS_DIR):
        print(f" Auto-syncing live with Game directory: {STEAM_MODS_DIR}")
    else:
        print(f" Note: Game directory not detected at {STEAM_MODS_DIR}")
    print("=" * 65)
    
    url = f"http://localhost:{PORT}/index.html"
    try:
        webbrowser.open(url)
    except:
        pass

    try:
        httpd.serve_forever()
    except KeyboardInterrupt:
        print("\nStopping editor server...")
        httpd.server_close()

if __name__ == "__main__":
    run_server()
