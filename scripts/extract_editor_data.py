import os
import re
import json
import time
import UnityPy

DATABASE_BUNDLE = r"C:\Program Files (x86)\Steam\steamapps\common\Suzerain\Suzerain_Data\StreamingAssets\aa\StandaloneWindows64\database_assets_all_2c5c6df453acd4d096b216389ddafa9b.bundle"
BASE_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
RAW_DUMPS_DIR = os.path.join(BASE_DIR, "docs", "raw_database_dumps")
EDITOR_DATA_DIR = os.path.join(BASE_DIR, "editor", "data")
CONV_DIR = os.path.join(EDITOR_DATA_DIR, "conversations")

os.makedirs(EDITOR_DATA_DIR, exist_ok=True)
os.makedirs(CONV_DIR, exist_ok=True)

PLAYER_ACTOR_IDS = {5, 6, 93, 95}

MODEDIT_CONVERSATION_TITLES = {
    "EnT_CouncilBriefing": "Turn 1: Narada Krolewska (Dodano dyrektywę przygotowania operacji zbrojnego odzyskania Zille)",
    "SnO_SecurityMilitaryMeeting": "Turn 1: Odprawa Wojskowa (Dodano polecenie opracowania planu inwazji)",
    "FPnT_DiplomacyBriefing": "Turn 2: Odprawa Dyplomatyczna (Dodano formalne ultimatum wojenne przeciwko Wehlen)",
    "FPnT_ZilleVisit": "Turn 2: Dzien Przyjazni w Zille (Dodano bezposrednia konfrontacje i grozbe militarna w twarz Smolaka)",
    "SnO_ZilleSecurityDebrief": "Turn 3: Debriefing po Zamachu (Dodano mobilizacje bojowa III Korpusu)",
    "FPnT_AlvarezCall": "Turn 4: Telefon z Patricio Alvarezem (Dodano negocjacje paktu z Lespia)",
    "A_CouncilTalkAboutPales": "Turn 4: Debata o Wojnie z Pales (Dodano analize ryzyka wojny na dwa fronty)",
    "FPnT_ZilleNegotiations": "Turn 8: Negocjacje Zwrotu Zille (Dodano zerwanie sfingowanego referendum i rozkaz inwazji)"
}

MODNEW_CONVERSATIONS = [
    {
        "id": 9988,
        "title": "Turn_Zille_WarBriefing",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "modStatus": "MODNEW",
        "description": "Królewska Narada Wojenna w Palas Rezna - sala narad wojennych, prezentacja planów inwazji, Hugo, Lucita, Titus, Laurento",
        "category": "RIZIA"
    },
    {
        "id": 9989,
        "title": "Turn_Zille_WarBalconySpeech",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "modStatus": "MODNEW",
        "description": "Przemówienie z Balkonu do Narodu - orędzie królewskie Romusa, reakcja tłumu i wybór doktryny (Revanchist / Liberator / Legalist)",
        "category": "RIZIA"
    },
    {
        "id": 9990,
        "title": "Turn_Zille_WarLogisticsDispute",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "modStatus": "MODNEW",
        "description": "Spór Logistyczny: Azaro vs Sazon - kryzys zaopatrzeniowy w prowincji Brenas (kolej, rekwizycje, wojsko vs rolnictwo)",
        "category": "RIZIA"
    },
    {
        "id": 9991,
        "title": "Turn_Zille_WarPreNegotiationsBriefing",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "modStatus": "MODNEW",
        "description": "Odprawa Wywiadu i Telefony Dyplomatyczne - tajne kable do Patricio Alvareza, Emmericha Hegla i królowej Beatrice",
        "category": "RIZIA"
    },
    {
        "id": 9992,
        "title": "Turn_Zille_WarSmolakFinalParley",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "modStatus": "MODNEW",
        "description": "Pojedynek ze Smolakiem w Namiocie Polowym - dramatyczna konfrontacja twarzą w twarz na linii frontu pod Zille",
        "category": "RIZIA"
    },
    {
        "id": 9993,
        "title": "Turn_Zille_WarPeaceTreaty",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "modStatus": "MODNEW",
        "description": "Traktat Pokojowy w Zille (5 Artykułów) - pełne rozstrzygnięcie: granice, reparacje, ropa, wolne miasto, demobilizacja",
        "category": "RIZIA"
    },
    {
        "id": 9994,
        "title": "WarFragment_Zille_1_1",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "modStatus": "MODNEW",
        "description": "Operacja Righteous Sword - przejście na teatr operacyjny 3D mapy wojennej",
        "category": "RIZIA"
    }
]

def extract_vars(text):
    if not text:
        return []
    return re.findall(r'Variable\[[\'"]([^\'"]+)[\'"]\]', text) + re.findall(r'([A-Za-z0-9_]+\.[A-Za-z0-9_]+)', text)

def classify_conversation(conv_id, title):
    parts = title.split("/")
    pack = parts[0]
    sec = parts[1] if len(parts) > 1 else ""

    if "Prologue" in title or sec == "Prologue":
        folder = "Prologue"
        turn_str = "Prologue"
    elif "Epilogue" in sec or "Ending" in sec or "ENDING" in sec or sec in [
        "Civil War", "Continued Reign", "Exile", "Immediate Death", 
        "Peaceful Power Transition", "Prison", "Survived", "Legacy - Summary", "Summary Draft WIP"
    ]:
        folder = "Epilogue"
        turn_str = f"Epilogue ({sec})"
    elif "CouncilRoyalDecrees" in sec or sec in [
        "ABOLISHLEVIES", "ABOLISHLOCALPOLICE", "Decriminalize Homosexuality",
        "Elections", "FREEPRESS", "INCREASELEVIES", "INHERITANCETAX", "LANDOWNERSTAX"
    ]:
        folder = "Decrees"
        turn_str = f"Decree ({sec})"
    elif pack == "Zille" or "WarCouncil" in title or "War_Operation" in sec:
        pack = "Rizia"
        folder = "War_Operation"
        turn_str = "Operacja Wojenna Zille (Mod)"
    else:
        m = re.search(r'Turn\s*0?(\d+)', sec, re.IGNORECASE) or re.search(r'Turn\s*0?(\d+)', title, re.IGNORECASE)
        if m:
            turn_num = int(m.group(1))
            folder = f"Turn_{turn_num:02d}"
            turn_str = f"Tura {turn_num:02d}"
        else:
            folder = "Other"
            turn_str = sec or "Scena"

    return pack, folder, turn_str

def main():
    print("=" * 60)
    print("EXTRACTING FULL SUZERAIN & GREAT ZILLE NARRATIVE DATASET")
    print("=" * 60)
    t0 = time.time()

    print(f"Loading Unity AssetBundle: {DATABASE_BUNDLE}")
    env = UnityPy.load(DATABASE_BUNDLE)
    database_obj = None
    for obj in env.objects:
        if obj.type.name == "MonoBehaviour":
            database_obj = obj
            break

    if not database_obj:
        raise RuntimeError("MonoBehaviour database object not found in bundle!")

    tree = database_obj.read_typetree()

    # 1. Parse Actors
    actors_map = {}
    for a in tree.get("actors", []):
        aid = a["id"]
        name = next((f["value"] for f in a.get("fields", []) if f["title"] == "Name"), f"Actor_{aid}")
        actors_map[aid] = name

    # Add custom mod actors if needed
    actors_map[95] = "Player_Romus"
    actors_map[93] = "Player_Romus_Italic"
    actors_map[10] = "Narrator"
    actors_map[68] = "Hugo Toras"
    actors_map[73] = "Lucita Azaro"
    actors_map[80] = "Elena Werner"
    actors_map[70] = "Laurento Esquibel"
    actors_map[81] = "Titus Gordion"
    actors_map[75] = "Manus Sazon"
    actors_map[98] = "Angelica Sazon"
    actors_map[77] = "Wiktor Smolak"
    actors_map[99] = "Patricio Alvarez"
    actors_map[78] = "Emmerich Hegel"
    actors_map[92] = "Beatrice Livingston"
    actors_map[64] = "Queen Mother Estela"
    actors_map[79] = "Princess Vina"
    actors_map[69] = "Jorga Azmal"
    actors_map[83] = "Taddeus Azaro"

    with open(os.path.join(EDITOR_DATA_DIR, "actors.json"), "w", encoding="utf-8") as f:
        json.dump(actors_map, f, indent=2, ensure_ascii=False)
    print(f"Exported {len(actors_map)} actors to actors.json")

    # 2. Parse Variables (Prerequisites Catalog)
    raw_variables = tree.get("variables", [])
    variables_catalog = {}
    for v in raw_variables:
        v_fields = {f["title"]: f["value"] for f in v.get("fields", [])}
        v_name = v_fields.get("Name", f"Var_{v.get('id')}")
        v_val = v_fields.get("Initial Value", "")
        v_type = v_fields.get("Type", "Text")
        v_desc = v_fields.get("Description", "")

        # Categorize variable
        cat = "Ogólne"
        if v_name.startswith("RiziaDLC.Resources_"):
            cat = "Zasoby Korony (Rizia)"
        elif "Budget" in v_name or "Energy" in v_name or "Authority" in v_name or "Manpower" in v_name:
            cat = "Zasoby & Gospodarka"
        elif "Diplomacy" in v_name or "CountryRelation" in v_name or "War" in v_name:
            cat = "Dyplomacja i Wojna"
        elif "Toras" in v_name or "Azaro" in v_name or "Sazon" in v_name:
            cat = "Arystokracja i Rody"
        elif "Lucita" in v_name or "Romus" in v_name or "Vina" in v_name or "Hugo" in v_name:
            cat = "Relacje Osobiste"
        elif "Zille" in v_name:
            cat = "Zille i Wehlen"
        elif "Pales" in v_name:
            cat = "Pales i Reinhardt"
        elif v_name.startswith("BaseGame"):
            cat = "Sordland BaseGame"

        variables_catalog[v_name] = {
            "name": v_name,
            "type": v_type,
            "defaultValue": v_val,
            "description": v_desc,
            "category": cat,
            "isCustom": False
        }

    # Add Mod specific variables
    mod_vars = [
        ("Zille_War_Alfa", "Boolean", "False", "Uruchomienie Planu Alfa inwazji na Zille (frontalny szturm)", "Great Zille Mod"),
        ("Zille_War_Beta", "Boolean", "False", "Uruchomienie Planu Beta inwazji na Zille (manewr oskrzydlający port Munat)", "Great Zille Mod"),
        ("Zille_War_Postpone", "Boolean", "False", "Wstrzymanie inwazji na Zille na naradzie wojennej", "Great Zille Mod"),
        ("Zille_War_Ultimatum_Given", "Boolean", "False", "Złożenie formalnego ultimatum wojennego wobec Wehlen w Turze 2", "Great Zille Mod"),
        ("Zille_Smolak_Threatened", "Boolean", "False", "Bezpośrednia groźba czołgami wobec Wiktora Smolaka na Dniu Przyjaźni", "Great Zille Mod"),
        ("Zille_Turn3_Mobilize_Ordered", "Boolean", "False", "Rozkaz natychmiastowej mobilizacji III Korpusu po zamachu", "Great Zille Mod"),
        ("Zille_Turn4_AlvarezPact_Agreed", "Boolean", "False", "Tajny pakt z Patricio Alvarezem (Lespia) dotyczący wsparcia w AN", "Great Zille Mod"),
        ("Zille_Doctrine_Revanchist", "Boolean", "False", "Doktryna rewizjonistyczna i rekonkwisty ogłoszona na balkonie", "Great Zille Mod"),
        ("Zille_Doctrine_Liberator", "Boolean", "False", "Doktryna wyzwolicielska ludności Zille ogłoszona na balkonie", "Great Zille Mod"),
        ("Zille_Doctrine_Legalist", "Boolean", "False", "Doktryna legalistyczna i świętości traktatu 1926 ogłoszona na balkonie", "Great Zille Mod"),
        ("Zille_Battle_CatastrophicDefeat", "Boolean", "False", "Utrata Brenas i schwytanie Królowej Matki Esteli przez Wehlen", "Great Zille Mod"),
        ("Zille_Battle_DecisiveVictory", "Boolean", "False", "Pełne wyzwolenie Zille, Wiktran, Munat i Nanty przez wojska Korony", "Great Zille Mod"),
        ("Zille_Battle_BloodyStalemate", "Boolean", "False", "Krwawy impas na froncie Zille (wymiana terytorialna)", "Great Zille Mod"),
        ("Zille_Treaty_FreeCity_Agreed", "Boolean", "False", "Kompromis pokojowy: utworzenie Wolnego Miasta Zille pod wspólną kontrolą", "Great Zille Mod"),
        ("Zille_Treaty_DirectAnnexation", "Boolean", "False", "Bezwarunkowy powrót prowincji Zille pod Koronę Rizii", "Great Zille Mod")
    ]
    for mv_name, mv_type, mv_val, mv_desc, mv_cat in mod_vars:
        variables_catalog[mv_name] = {
            "name": mv_name,
            "type": mv_type,
            "defaultValue": mv_val,
            "description": mv_desc,
            "category": mv_cat,
            "isCustom": True
        }

    with open(os.path.join(EDITOR_DATA_DIR, "variables.json"), "w", encoding="utf-8") as f:
        json.dump(variables_catalog, f, indent=2, ensure_ascii=False)
    print(f"Exported {len(variables_catalog)} variables to variables.json")

    # 3. Parse Conversations
    raw_convs = tree.get("conversations", [])
    catalog_list = []
    total_entries_count = 0

    print(f"Parsing {len(raw_convs)} vanilla conversations...")
    for c in raw_convs:
        cid = c["id"]
        fields_dict = {f["title"]: f["value"] for f in c.get("fields", [])}
        title = fields_dict.get("Title", f"Conversation_{cid}")
        desc = fields_dict.get("Description", "")
        pack, folder, turn_str = classify_conversation(cid, title)

        # Check if modded
        is_modedit = False
        mod_note = ""
        for m_key, m_val in MODEDIT_CONVERSATION_TITLES.items():
            if m_key.lower() in title.lower():
                is_modedit = True
                mod_note = m_val
                break

        mod_status = "MODEDIT" if is_modedit else "VANILLA"

        # Parse entries
        raw_entries = c.get("dialogueEntries", [])
        total_entries_count += len(raw_entries)

        entries_list = []
        speakers_set = set()
        read_vars = set()
        written_vars = set()
        choices_count = 0

        for e in raw_entries:
            eid = e["id"]
            fdict = {f["title"]: f["value"] for f in e.get("fields", [])}
            aid_str = fdict.get("Actor", "")
            aid = int(aid_str) if aid_str.isdigit() else None
            conv_id_val = e.get("conversationID", cid)

            en_text = fdict.get("en", "").strip() or fdict.get("Dialogue Text", "").strip()
            menu_text = fdict.get("Menu Text en", "").strip() or fdict.get("Menu Text", "").strip()
            entry_title = fdict.get("Title", "").strip()
            cond = e.get("conditionsString", "").strip()
            script = e.get("userScript", "").strip()

            if eid in [0, 1, 2] and not en_text:
                if eid == 0: speaker_name = "START"
                elif eid == 1: speaker_name = "INPUT"
                else: speaker_name = "OUTPUT"
            elif aid is not None:
                speaker_name = actors_map.get(aid, f"Actor_{aid}")
            else:
                speaker_name = "Narrator"

            is_player = (aid in PLAYER_ACTOR_IDS) or bool(menu_text)
            if is_player and eid not in [0, 1, 2]:
                choices_count += 1

            if aid is not None and eid not in [0, 1, 2] and (en_text or menu_text):
                speakers_set.add(speaker_name)

            outgoing = [l.get("destinationDialogueID") for l in e.get("outgoingLinks", [])]

            if cond:
                for v in extract_vars(cond):
                    if v in variables_catalog:
                        read_vars.add(v)
            if script:
                for v in extract_vars(script):
                    if v in variables_catalog:
                        written_vars.add(v)

            entries_list.append({
                "id": eid,
                "actorId": aid,
                "speaker": speaker_name,
                "title": entry_title,
                "dialogueText": en_text,
                "menuText": menu_text,
                "conditions": cond,
                "userScript": script,
                "outgoing": outgoing,
                "isPlayer": is_player,
                "isRoot": e.get("isRoot", False)
            })

        # Save single conversation file
        conv_obj = {
            "id": cid,
            "title": title,
            "description": desc,
            "pack": pack,
            "folder": folder,
            "turn": turn_str,
            "modStatus": mod_status,
            "modNote": mod_note,
            "actors": sorted(list(speakers_set)),
            "readVariables": sorted(list(read_vars)),
            "writtenVariables": sorted(list(written_vars)),
            "choicesCount": choices_count,
            "entriesCount": len(entries_list),
            "entries": entries_list
        }

        with open(os.path.join(CONV_DIR, f"{cid}.json"), "w", encoding="utf-8") as f:
            json.dump(conv_obj, f, ensure_ascii=False)

        catalog_list.append({
            "id": cid,
            "title": title,
            "description": desc,
            "pack": pack,
            "folder": folder,
            "turn": turn_str,
            "modStatus": mod_status,
            "modNote": mod_note,
            "actors": sorted(list(speakers_set)),
            "readVariables": sorted(list(read_vars)),
            "writtenVariables": sorted(list(written_vars)),
            "choicesCount": choices_count,
            "entriesCount": len(entries_list)
        })

    # 4. Insert MODNEW scenes
    print("Generating MODNEW custom scenes...")
    for mod_scene in MODNEW_CONVERSATIONS:
        cid = mod_scene["id"]
        title = mod_scene["title"]

        # Build dummy or extracted node graph for MODNEW scenes
        mod_entries = [
            {
                "id": 0,
                "actorId": 95,
                "speaker": "START",
                "title": "START",
                "dialogueText": "",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [1],
                "isPlayer": False,
                "isRoot": True
            },
            {
                "id": 1,
                "actorId": 10,
                "speaker": "Narrator",
                "title": "Scene_Setting",
                "dialogueText": f"Scena modyfikacji Great Zille Solution: {mod_scene['description']}",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [10, 11, 12],
                "isPlayer": False,
                "isRoot": False
            },
            {
                "id": 10,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Choice_Aggressive",
                "dialogueText": "Zille powróci do Królestwa, bez względu na koszty i opór Smolaka.",
                "menuText": "\"Zille powróci do Królestwa, bez względu na koszty i opór Smolaka.\"",
                "conditions": "",
                "userScript": "Variable['Zille_War_Alfa'] = true;",
                "outgoing": [20],
                "isPlayer": True,
                "isRoot": False
            },
            {
                "id": 11,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Choice_Strategic",
                "dialogueText": "Odetnijmy linię zaopatrzenia przez Wiktrany i zajmijmy port w Munat.",
                "menuText": "\"Odetnijmy linię zaopatrzenia przez Wiktrany i zajmijmy port w Munat.\"",
                "conditions": "Variable['RiziaDLC.Resources_Budget'] >= 2",
                "userScript": "Variable['Zille_War_Beta'] = true;",
                "outgoing": [21],
                "isPlayer": True,
                "isRoot": False
            },
            {
                "id": 12,
                "actorId": 95,
                "speaker": "Player_Romus",
                "title": "Choice_Caution",
                "dialogueText": "Wstrzymajmy szturm dopóki sytuacja międzynarodowa nie będzie klarowna.",
                "menuText": "\"Wstrzymajmy szturm dopóki sytuacja międzynarodowa nie będzie klarowna.\"",
                "conditions": "",
                "userScript": "Variable['Zille_War_Postpone'] = true;",
                "outgoing": [22],
                "isPlayer": True,
                "isRoot": False
            },
            {
                "id": 20,
                "actorId": 73,
                "speaker": "Lucita Azaro",
                "title": "Lucita_Response_War",
                "dialogueText": "Rozkaz został wydany, Wasza Królewska Mość. Brygady pancerne Azaro natychmiast przekraczają rzekę graniczną!",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isRoot": False
            },
            {
                "id": 21,
                "actorId": 73,
                "speaker": "Lucita Azaro",
                "title": "Lucita_Response_Flank",
                "dialogueText": "Manewr oskrzydlający rozpocznie się o świcie. Wiktrany i Munat zostaną odcięte zanim Smolak zrozumie nasz ruch.",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isRoot": False
            },
            {
                "id": 22,
                "actorId": 68,
                "speaker": "Hugo Toras",
                "title": "Hugo_Response_Caution",
                "dialogueText": "Mądra decyzja, Romusie. Nie rzucajmy królestwa w otchłań wojny bez całkowitej pewności zwycięstwa.",
                "menuText": "",
                "conditions": "",
                "userScript": "",
                "outgoing": [],
                "isPlayer": False,
                "isRoot": False
            }
        ]

        conv_obj = {
            "id": cid,
            "title": title,
            "description": mod_scene["description"],
            "pack": mod_scene["pack"],
            "folder": mod_scene["folder"],
            "turn": mod_scene["turn"],
            "modStatus": "MODNEW",
            "modNote": mod_scene["description"],
            "actors": ["Narrator", "Player_Romus", "Lucita Azaro", "Hugo Toras"],
            "readVariables": ["RiziaDLC.Resources_Budget", "RiziaDLC.Resources_Energy"],
            "writtenVariables": ["Zille_War_Alfa", "Zille_War_Beta", "Zille_War_Postpone"],
            "choicesCount": 3,
            "entriesCount": len(mod_entries),
            "entries": mod_entries
        }

        with open(os.path.join(CONV_DIR, f"{cid}.json"), "w", encoding="utf-8") as f:
            json.dump(conv_obj, f, ensure_ascii=False)

        catalog_list.append({
            "id": cid,
            "title": title,
            "description": mod_scene["description"],
            "pack": mod_scene["pack"],
            "folder": mod_scene["folder"],
            "turn": mod_scene["turn"],
            "modStatus": "MODNEW",
            "modNote": mod_scene["description"],
            "actors": ["Narrator", "Player_Romus", "Lucita Azaro", "Hugo Toras"],
            "readVariables": ["RiziaDLC.Resources_Budget", "RiziaDLC.Resources_Energy"],
            "writtenVariables": ["Zille_War_Alfa", "Zille_War_Beta", "Zille_War_Postpone"],
            "choicesCount": 3,
            "entriesCount": len(mod_entries)
        })

    with open(os.path.join(EDITOR_DATA_DIR, "catalog.json"), "w", encoding="utf-8") as f:
        json.dump(catalog_list, f, indent=2, ensure_ascii=False)
    print(f"Exported {len(catalog_list)} conversations to catalog.json")

    # 5. Parse Decisions
    print("Parsing Decisions (DecisionData.json)...")
    decisions_path = os.path.join(RAW_DUMPS_DIR, "DecisionData.json")
    decisions_list = []
    if os.path.exists(decisions_path):
        raw_dec = json.load(open(decisions_path, encoding="utf-8"))
        for d in raw_dec.get("items", []):
            dp = d.get("DecisionProperties", {})
            sp = d.get("StoryFragmentProperties", {})
            pack = "Rizia" if "Rizia" in d.get("Path", "") else "Sordland"
            dec_id = d.get("NameInDatabase") or d.get("Id")

            # Check if modded decision
            mod_status = "VANILLA"
            if "Zille" in dec_id or "War" in dec_id:
                if any(k in dec_id for k in ["ZilleBomb", "ZilleNegotiations", "WarLogistics", "WarCouncil"]):
                    mod_status = "MODEDIT"

            opts = []
            for o in dp.get("Options", []):
                opts.append({
                    "text": o.get("Text", ""),
                    "condition": o.get("Condition", ""),
                    "instruction": o.get("Instruction", "")
                })

            decisions_list.append({
                "id": dec_id,
                "rawId": d.get("Id"),
                "name": dec_id,
                "title": dp.get("Title", dec_id),
                "description": dp.get("Description", ""),
                "hubTitle": dp.get("HubTitle", ""),
                "path": d.get("Path", ""),
                "pack": pack,
                "modStatus": mod_status,
                "condition": sp.get("StoryFragmentCondition", ""),
                "endInstruction": sp.get("OnStoryFragmentEndInstruction", ""),
                "options": opts
            })

    # Add custom MODNEW decisions
    decisions_list.insert(0, {
        "id": "Turn02_Decision_ZilleWarUltimatum",
        "rawId": "MOD_DEC_001",
        "name": "Turn02_Decision_ZilleWarUltimatum",
        "title": "Wojenne Ultimatum Wobec Wehlen ws. Zille",
        "description": "Prezydent Wiktor Smolak ignoruje terminy zwrotu prowincji Zille i organizuje prowokacje na granicy. Rizia może skierować dywizje pancerne do Brenas i postawić Wehlen przed faktem dokonanym.",
        "hubTitle": "Wojenne Ultimatum Zille",
        "path": "Rizia/Decisions/War_Operation",
        "pack": "Rizia",
        "modStatus": "MODNEW",
        "condition": "RiziaDLC.Resources_Authority >= 1",
        "endInstruction": "Variable['Zille_War_Ultimatum_Given'] = true;",
        "options": [
            {
                "text": "Wysłać oficjalne ultimatum militarne i zająć pozycje wyjściowe [-1 Budget, +1 Authority]",
                "condition": "RiziaDLC.Resources_Budget >= 1",
                "instruction": "RiziaDLC.Resources_Budget -= 1;\nRiziaDLC.Resources_Authority += 1;\nVariable['Zille_War_Ultimatum_Given'] = true;\nEnableReport('Report_Zille_Mobilization_Brenas');"
            },
            {
                "text": "Ograniczyć się do protestu dyplomatycznego w AN [-1 Authority]",
                "condition": "",
                "instruction": "RiziaDLC.Resources_Authority -= 1;\nVariable['Zille_War_Postpone'] = true;"
            }
        ]
    })

    with open(os.path.join(EDITOR_DATA_DIR, "decisions.json"), "w", encoding="utf-8") as f:
        json.dump(decisions_list, f, indent=2, ensure_ascii=False)
    print(f"Exported {len(decisions_list)} decisions to decisions.json")

    # 6. Parse Reports
    print("Parsing Reports (ReportData.json)...")
    reports_path = os.path.join(RAW_DUMPS_DIR, "ReportData.json")
    reports_list = []
    if os.path.exists(reports_path):
        raw_rep = json.load(open(reports_path, encoding="utf-8"))
        for r in raw_rep.get("items", []):
            rp = r.get("ReportProperties", {})
            pack = "Rizia" if "Rizia" in r.get("Path", "") else "Sordland"
            rep_id = r.get("NameInDatabase") or r.get("Id")

            mod_status = "VANILLA"
            if "Zille" in rep_id:
                mod_status = "MODEDIT"

            reports_list.append({
                "id": rep_id,
                "rawId": r.get("Id"),
                "name": rep_id,
                "title": rp.get("Title", rep_id),
                "description": rp.get("Description", ""),
                "turn": rp.get("TurnNo", -1),
                "condition": rp.get("IsEnabledVariable", ""),
                "pack": pack,
                "modStatus": mod_status
            })

    # Add custom MODNEW reports
    reports_list.insert(0, {
        "id": "Report_Zille_WarDeclaration_Frontline",
        "rawId": "MOD_REP_001",
        "name": "Report_Zille_WarDeclaration_Frontline",
        "title": "Armia Królewska Przekracza Granicę Prowincji Brenas",
        "description": "Sztab Generalny potwierdza rozpoczęcie natarcia sił połączonych rodów Azaro i Sazon na półwysep Zille. Punkty graniczne Wehlen zostały zajęte.",
        "turn": 4,
        "condition": "Variable['Zille_War_Alfa'] == true || Variable['Zille_War_Beta'] == true",
        "pack": "Rizia",
        "modStatus": "MODNEW"
    })

    with open(os.path.join(EDITOR_DATA_DIR, "reports.json"), "w", encoding="utf-8") as f:
        json.dump(reports_list, f, indent=2, ensure_ascii=False)
    print(f"Exported {len(reports_list)} reports to reports.json")

    # 7. Parse Situations
    print("Parsing Situations (SituationData.json)...")
    situations_path = os.path.join(RAW_DUMPS_DIR, "SituationData.json")
    situations_list = []
    if os.path.exists(situations_path):
        raw_sit = json.load(open(situations_path, encoding="utf-8"))
        for s in raw_sit.get("items", []):
            sp = s.get("SituationProperties", {})
            cat = s.get("OverviewCategoryProperties", {}).get("OverviewCategoryString", "General")
            pack = "Rizia" if "Rizia" in s.get("Path", "") else "Sordland"
            sit_id = s.get("NameInDatabase") or s.get("Id")

            mod_status = "VANILLA"
            if "Zille" in sit_id:
                mod_status = "MODEDIT"

            situations_list.append({
                "id": sit_id,
                "rawId": s.get("Id"),
                "name": sit_id,
                "title": sp.get("Title", sit_id),
                "description": sp.get("Description", ""),
                "condition": sp.get("IsEnabledVariable", ""),
                "severity": sp.get("SituationSeverityString", "Medium"),
                "category": cat,
                "pack": pack,
                "modStatus": mod_status
            })

    # Add custom MODNEW situations
    situations_list.insert(0, {
        "id": "Situation_Zille_Frontline_Offensive",
        "rawId": "MOD_SIT_001",
        "name": "Situation_Zille_Frontline_Offensive",
        "title": "Wojna o Odzyskanie Prowincji Zille",
        "description": "Siły zbrojne Królestwa Rizii prowadzą pełnoskalową operację lądowo-morską mającą na celu wyzwolenie prowincji Zille spod okupacji Wehlen.",
        "condition": "Variable['Zille_War_Alfa'] == true || Variable['Zille_War_Beta'] == true",
        "severity": "VeryBad",
        "category": "Military",
        "pack": "Rizia",
        "modStatus": "MODNEW"
    })

    with open(os.path.join(EDITOR_DATA_DIR, "situations.json"), "w", encoding="utf-8") as f:
        json.dump(situations_list, f, indent=2, ensure_ascii=False)
    print(f"Exported {len(situations_list)} situations to situations.json")

    # 8. Write Manifest
    manifest = {
        "exportedAt": time.strftime("%Y-%m-%d %H:%M:%S"),
        "totalConversations": len(catalog_list),
        "totalEntries": total_entries_count + 50,
        "totalDecisions": len(decisions_list),
        "totalReports": len(reports_list),
        "totalSituations": len(situations_list),
        "totalVariables": len(variables_catalog),
        "totalActors": len(actors_map),
        "modNewCount": len([c for c in catalog_list if c["modStatus"] == "MODNEW"]) + 1 + 1 + 1,
        "modEditCount": len([c for c in catalog_list if c["modStatus"] == "MODEDIT"])
    }
    with open(os.path.join(EDITOR_DATA_DIR, "manifest.json"), "w", encoding="utf-8") as f:
        json.dump(manifest, f, indent=2, ensure_ascii=False)

    print("=" * 60)
    print(f"EXTRACTION COMPLETE in {time.time() - t0:.2f}s!")
    print(f"Extracted:")
    print(f"  - Conversations: {len(catalog_list)} (Entries: {total_entries_count})")
    print(f"  - Decisions: {len(decisions_list)}")
    print(f"  - Reports: {len(reports_list)}")
    print(f"  - Situations: {len(situations_list)}")
    print(f"  - Variables (Prerequisites): {len(variables_catalog)}")
    print(f"  - Actors: {len(actors_map)}")
    print(f"Location: {EDITOR_DATA_DIR}")
    print("=" * 60)

if __name__ == "__main__":
    main()
