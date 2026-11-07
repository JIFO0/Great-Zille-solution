import re
import json
import os

BASE_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
CS_PATH = os.path.join(BASE_DIR, "src", "GreatZilleSolution", "ZilleDialogueSystem.cs")
CONV_DIR = os.path.join(BASE_DIR, "editor", "data", "conversations")
CATALOG_PATH = os.path.join(BASE_DIR, "editor", "data", "catalog.json")

ACTOR_NAMES = {
    10: "Narrator",
    95: "Player_Romus",
    93: "Player_Romus_Italic",
    68: "Hugo Toras",
    73: "Lucita Azaro",
    80: "Elena Werner",
    70: "Laurento Esquibel",
    81: "Titus Gordion",
    75: "Manus Sazon",
    98: "Angelica Sazon",
    77: "Wiktor Smolak",
    99: "Patricio Alvarez",
    78: "Emmerich Hegel",
    92: "Beatrice Livingston",
    64: "Queen Mother Estela",
    79: "Princess Vina",
    69: "Jorga Azmal",
    83: "Taddeus Azaro"
}

SCENE_DEFS = [
    (9988, "Turn_Zille_WarBriefing", "RegisterWarCouncilBriefing", "Królewska Narada Wojenna w Palas Rezna"),
    (9989, "Turn_Zille_WarBalconySpeech", "RegisterWarBalconySpeech", "Przemówienie z Balkonu do Narodu"),
    (9990, "Turn_Zille_WarLogisticsDispute", "RegisterWarLogisticsDispute", "Spór Logistyczny: Azaro vs Sazon"),
    (9991, "Turn_Zille_WarPreNegotiationsBriefing", "RegisterWarPreNegotiationsBriefing", "Odprawa Wywiadu i Telefony Dyplomatyczne"),
    (9992, "Turn_Zille_WarSmolakFinalParley", "RegisterWarSmolakFinalParley", "Pojedynek ze Smolakiem w Namiocie Polowym"),
    (9993, "Turn_Zille_WarPeaceTreaty", "RegisterWarPeaceTreaty", "Traktat Pokojowy w Zille (5 Artykułów)")
]

with open(CS_PATH, "r", encoding="utf-8") as f:
    cs_content = f.read()

# Robust pattern for AddLine
line_pattern = re.compile(r'AddLine\s*\(\s*conv\s*,\s*(\d+)\s*,\s*(\w+)\s*,\s*(\w+)\s*,\s*"([^"]*)"\s*,\s*(.*?)(?:\s*,\s*(-?\d+))?\s*\)\s*;', re.DOTALL)
# Robust pattern for AddChoice
choice_pattern = re.compile(r'AddChoice\s*\(\s*conv\s*,\s*(\d+)\s*,\s*(\w+)\s*,\s*"([^"]*)"\s*,\s*"((?:\\.|[^"\\])*)"\s*,\s*"((?:\\.|[^"\\])*)"\s*,\s*(-?\d+)(?:\s*,\s*"((?:\\.|[^"\\])*)")?(?:\s*,\s*"((?:\\.|[^"\\])*)")?\s*\)', re.MULTILINE)
createlink_pattern = re.compile(r'CreateLink\s*\(\s*conv\.id\s*,\s*(\d+)\s*,\s*(\d+)\s*\)', re.MULTILINE)

actor_consts = {
    "NarratorId": 10, "RomusId": 95, "RomusItalicId": 93, "HugoId": 68, "LucitaId": 73,
    "ElenaId": 80, "LaurentoId": 70, "TitusId": 81, "ManusId": 75, "AngelicaId": 98,
    "SmolakId": 77, "AlvarezId": 99, "HegelId": 78, "BeatriceId": 92, "EstelaId": 64,
    "VinaId": 79, "AzmalId": 69, "TaddeusId": 83
}

def resolve_actor_id(val):
    if val in actor_consts: return actor_consts[val]
    if val.isdigit(): return int(val)
    return 10

def clean_str(s):
    if not s: return ""
    return s.encode().decode('unicode_escape', 'ignore').replace('\\"', '"')

for i, (cid, title, meth_name, desc) in enumerate(SCENE_DEFS):
    m_start = cs_content.find("void " + meth_name)
    if m_start == -1: continue
    next_m = len(cs_content)
    if i + 1 < len(SCENE_DEFS):
        next_m = cs_content.find("void " + SCENE_DEFS[i+1][2])
    else:
        next_m = cs_content.find("InjectAllVanillaConversationPatches")

    snippet = cs_content[m_start:next_m]

    entries_map = {}
    # Entry 0
    entries_map[0] = {
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
        "isModInjected": True,
        "isModEdited": True,
        "isRoot": True
    }

    speakers_set = set()
    read_vars = set()
    written_vars = set()
    choices_count = 0

    # Parse AddLine
    for match in line_pattern.finditer(snippet):
        eid = int(match.group(1))
        speaker_id = resolve_actor_id(match.group(2))
        entry_title = match.group(4)
        raw_body = match.group(5).strip()
        next_id = int(match.group(6)) if match.group(6) else -1

        # Extract representative string
        str_matches = re.findall(r'"((?:\\.|[^"\\])*)"', raw_body)
        diag_text = clean_str(str_matches[0]) if str_matches else f"[{raw_body}]"

        speaker_name = ACTOR_NAMES.get(speaker_id, f"Actor_{speaker_id}")
        speakers_set.add(speaker_name)
        outgoing = [next_id] if next_id >= 0 else []

        if eid in entries_map:
            # Preserve existing outgoing if any
            outgoing = list(set(entries_map[eid]["outgoing"] + outgoing))

        entries_map[eid] = {
            "id": eid,
            "actorId": speaker_id,
            "speaker": speaker_name,
            "title": entry_title,
            "dialogueText": diag_text,
            "menuText": "",
            "conditions": "",
            "userScript": "",
            "outgoing": outgoing,
            "isPlayer": False,
            "isModInjected": True,
            "isModEdited": True,
            "isRoot": False
        }

    # Parse AddChoice
    for match in choice_pattern.finditer(snippet):
        eid = int(match.group(1))
        entry_title = match.group(3)
        menu_text = clean_str(match.group(4))
        spoken_text = clean_str(match.group(5))
        next_id = int(match.group(6))
        script = clean_str(match.group(7)) if match.group(7) else ""
        cond = clean_str(match.group(8)) if match.group(8) else ""

        choices_count += 1
        speakers_set.add("Player_Romus")
        outgoing = [next_id] if next_id >= 0 else []

        if eid in entries_map:
            outgoing = list(set(entries_map[eid]["outgoing"] + outgoing))

        if cond:
            for v in re.findall(r'Variable\[[\'"]([^\'"]+)[\'"]\]', cond): read_vars.add(v)
        if script:
            for v in re.findall(r'Variable\[[\'"]([^\'"]+)[\'"]\]', script): written_vars.add(v)

        entries_map[eid] = {
            "id": eid,
            "actorId": 95,
            "speaker": "Player_Romus",
            "title": entry_title,
            "dialogueText": spoken_text,
            "menuText": menu_text,
            "conditions": cond,
            "userScript": script,
            "outgoing": outgoing,
            "isPlayer": True,
            "isModInjected": True,
            "isModEdited": True,
            "isRoot": False
        }

    # Parse explicit CreateLink(conv.id, src, dst)
    for match in createlink_pattern.finditer(snippet):
        src_id = int(match.group(1))
        dst_id = int(match.group(2))
        if src_id in entries_map:
            if dst_id not in entries_map[src_id]["outgoing"]:
                entries_map[src_id]["outgoing"].append(dst_id)

    entries = list(entries_map.values())
    entries.sort(key=lambda x: x["id"])

    conv_file = os.path.join(CONV_DIR, f"{cid}.json")
    conv_data = {
        "id": cid,
        "title": title,
        "description": desc,
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "modStatus": "MODNEW",
        "modNote": desc,
        "actors": sorted(list(speakers_set)),
        "readVariables": sorted(list(read_vars)),
        "writtenVariables": sorted(list(written_vars)),
        "choicesCount": choices_count,
        "entriesCount": len(entries),
        "entries": entries
    }

    with open(conv_file, "w", encoding="utf-8") as f:
        json.dump(conv_data, f, indent=2, ensure_ascii=False)

    print(f"Parsed {title} (ID {cid}): {len(entries)} entries, {choices_count} choices. (Explicit links included)")

# Update catalog.json
if os.path.exists(CATALOG_PATH):
    with open(CATALOG_PATH, "r", encoding="utf-8") as f:
        catalog = json.load(f)
    cat_map = {c["id"]: c for c in catalog}
    for cid, title, _, desc in SCENE_DEFS:
        conv_file = os.path.join(CONV_DIR, f"{cid}.json")
        if os.path.exists(conv_file):
            cdata = json.load(open(conv_file, encoding="utf-8"))
            if cid in cat_map:
                cat_map[cid]["entriesCount"] = cdata["entriesCount"]
                cat_map[cid]["choicesCount"] = cdata["choicesCount"]
    with open(CATALOG_PATH, "w", encoding="utf-8") as f:
        json.dump(list(cat_map.values()), f, indent=2, ensure_ascii=False)

print("All C# scenes re-parsed with complete entries and full branching links!")
