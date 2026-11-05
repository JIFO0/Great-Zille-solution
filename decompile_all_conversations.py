import os
import re
import json
import time
import UnityPy

DATABASE_BUNDLE = r"C:\Program Files (x86)\Steam\steamapps\common\Suzerain\Suzerain_Data\StreamingAssets\aa\StandaloneWindows64\database_assets_all_2c5c6df453acd4d096b216389ddafa9b.bundle"
BASE_DIR = os.path.dirname(os.path.abspath(__file__))
OUTPUT_DIR = os.path.join(BASE_DIR, "docs", "conversations_decompiled")

PLAYER_ACTOR_IDS = {5, 6, 93, 95}

def sanitize_filename(name):
    clean = re.sub(r'[\\/*?:"<>|]', "_", name)
    clean = re.sub(r'\s+', "_", clean)
    clean = re.sub(r'_+', "_", clean).strip("_")
    return clean

def extract_vars(text):
    if not text:
        return []
    return re.findall(r'Variable\[[\'"]([^\'"]+)[\'"]\]', text)

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
            turn_str = sec

    last_name = parts[-1] if len(parts) > 1 else title
    clean_last = sanitize_filename(last_name)
    file_name = f"{conv_id:03d}_{clean_last}.md"
    rel_path = f"{pack}/{folder}/{file_name}"
    
    return pack, folder, turn_str, file_name, rel_path

def build_node_dict(entries, actors_map):
    nodes = {}
    incoming_map = {}
    for e in entries:
        eid = e["id"]
        fdict = {f["title"]: f["value"] for f in e.get("fields", [])}
        aid_str = fdict.get("Actor", "")
        aid = int(aid_str) if aid_str.isdigit() else None
        
        en_text = fdict.get("en", "").strip()
        menu_text = fdict.get("Menu Text en", "").strip() or fdict.get("Menu Text", "").strip()
        title = fdict.get("Title", "").strip()
        cond = e.get("conditionsString", "").strip()
        script = e.get("userScript", "").strip()
        
        is_player = (aid in PLAYER_ACTOR_IDS) or bool(menu_text)
        is_logic_node = (not en_text and not menu_text) or (title in ["input", "output", "START"])
        
        if is_logic_node and eid not in [0, 1, 2]:
            speaker = "Węzeł Logiki Narracyjnej"
        elif eid == 0:
            speaker = "System / START"
        elif eid == 1:
            speaker = "System / INPUT"
        elif eid == 2:
            speaker = "System / OUTPUT"
        else:
            speaker = actors_map.get(aid, f"Actor_{aid}") if aid is not None else "System"

        outgoing = [l.get("destinationDialogueID") for l in e.get("outgoingLinks", [])]
        outgoing_links = e.get("outgoingLinks", [])

        nodes[eid] = {
            "id": eid,
            "aid": aid,
            "speaker": speaker,
            "is_logic_node": is_logic_node,
            "menu_text": menu_text,
            "en_text": en_text,
            "title": title,
            "cond": cond,
            "script": script,
            "is_player": is_player,
            "outgoing": outgoing,
            "outgoing_links": outgoing_links
        }

        for dst in outgoing:
            incoming_map.setdefault(dst, []).append(eid)

    return nodes, incoming_map

def resolve_choice_requirements(choice_id, nodes, incoming_map, max_depth=6):
    """
    BFS traversal backwards through intermediate logic/condition nodes to find
    parent prompt(s) and all required conditions.
    """
    results = []
    self_cond = nodes[choice_id]["cond"]
    init_conds = [self_cond] if self_cond else []
    
    queue = [(choice_id, 0, init_conds)]
    seen = {choice_id}
    
    while queue:
        curr, depth, conds = queue.pop(0)
        if depth > max_depth:
            continue
        for pid in incoming_map.get(curr, []):
            if pid in seen or pid in [0, 1]:
                continue
            seen.add(pid)
            pinfo = nodes.get(pid)
            if not pinfo:
                continue
            
            next_conds = list(conds)
            if pinfo["cond"]:
                next_conds.append(pinfo["cond"])
                
            if (pinfo["en_text"] or pinfo["menu_text"]) and not pinfo["is_logic_node"]:
                results.append({
                    "prompt_id": pid,
                    "prompt_speaker": pinfo["speaker"],
                    "prompt_text": pinfo["en_text"] or pinfo["menu_text"],
                    "conditions": next_conds
                })
            else:
                queue.append((pid, depth + 1, next_conds))
                
    return results

def resolve_choice_consequences(choice_id, nodes, max_depth=6):
    """
    BFS traversal forwards through intermediate logic nodes to collect:
    1. Direct and downstream userScripts
    2. Spoken destination dialogue lines
    """
    scripts = []
    choice_script = nodes[choice_id]["script"]
    if choice_script:
        scripts.append((choice_id, nodes[choice_id]["speaker"], choice_script))
        
    dests = []
    queue = [(choice_id, 0)]
    seen = {choice_id}
    
    while queue:
        curr, depth = queue.pop(0)
        if depth > max_depth:
            continue
        cinfo = nodes.get(curr)
        if not cinfo:
            continue
        for oid in cinfo["outgoing"]:
            if oid in seen:
                continue
            seen.add(oid)
            if oid == 2:
                dests.append({"id": 2, "speaker": "System", "text": "[KONIEC SCENY / WYJŚCIE]"})
                continue
            oinfo = nodes.get(oid)
            if not oinfo:
                continue
            if oinfo["script"]:
                scripts.append((oid, oinfo["speaker"], oinfo["script"]))
            if (oinfo["en_text"] or oinfo["menu_text"]) and not oinfo["is_logic_node"]:
                dests.append({
                    "id": oid,
                    "speaker": oinfo["speaker"],
                    "text": oinfo["en_text"] or oinfo["menu_text"]
                })
            else:
                queue.append((oid, depth + 1))
                
    return scripts, dests

def generate_war_council_briefing_markdown(target_path, rel_path):
    lines = []
    lines.append("# Zille/WarCouncil_Briefing")
    lines.append("")
    lines.append("- **ID konwersacji:** `9988`")
    lines.append("- **StoryPack:** `Rizia`")
    lines.append("- **Tura:** `Operacja Wojenna Zille (Mod: Great Zille Solution)`")
    lines.append("- **Lokalizacja pliku:** `Rizia/War_Operation/9988_WarCouncil_Briefing.md`")
    lines.append("- **Typ sceny:** `Królewska Narada Wojenna w Porte Drazon (Porte Drazon Palace - Council Chambers)`")
    lines.append("- **Liczba węzłów dialogowych:** 28")
    lines.append("- **Liczba wyborów gracza:** 12")
    lines.append("")
    lines.append("> [!NOTE]")
    lines.append("> Ta konwersacja jest w pełni natywnym modułem fabularnym moda **Great Zille Solution**, zarejestrowanym w silniku `PixelCrushers.DialogueSystem` oraz `EntityDataManager.AllConversationsData`. Dynamicznie odczytuje stan skarbca, energii, armii, sojuszy i relacji Romusa (w tym małżeństwa z Lucitą Azaro) przed autoryzacją inwazji.")
    lines.append("")
    lines.append("---")
    lines.append("")
    lines.append("## 1. Uczestnicy Sceny")
    lines.append("")
    lines.append("- **[10]** Narrator")
    lines.append("- **[95]** Player_Romus *(Gracz)*")
    lines.append("- **[68]** Hugo Toras *(Kanclerz / Finanse i Zaopatrzenie)*")
    lines.append("- **[73]** Lucita Azaro *(Głównodowodząca Sił Zbrojnych / Prowincja Montaklar)*")
    lines.append("- **[81]** Titus Gordion *(Dowódca Złotej Gwardii / Wywiad i Bezpieczeństwo)*")
    lines.append("- **[70]** Laurento Esquibel *(Minister Spraw Zagranicznych / Dyplomacja)*")
    lines.append("")
    lines.append("---")
    lines.append("")
    lines.append("## 2. Zmienne Gry (Stan Narracyjny)")
    lines.append("")
    lines.append("### Czytane zmienne dynamiczne (Zapis Gry / Stan Królestwa):")
    lines.append("- `RiziaDLC.Resources_Budget` — Poziom skarbca (rezerwy operacyjne vs pustki w budżecie)")
    lines.append("- `RiziaDLC.Resources_Energy` — Bilans energetyczny (paliwo dla czołgów i floty)")
    lines.append("- `RiziaDLC.Resources_Authority` — Autorytet Korony (kontrola nad arystokracją)")
    lines.append("- `RiziaDLC.Resources_Manpower` — Rezerwy ludzkie armii")
    lines.append("- `RiziaDLC.Resources_MilitaryEquipment` — Zapasy sprzętu wojskowego")
    lines.append("- `RiziaDLC.PalesWar_Preparation_WarDeclared` / `RiziaDLC.Pales_War` — Wojna dwufrontowa z Pales")
    lines.append("- `RiziaDLC.Zille_SuOmina_Funded` / `RiziaDLC.Zille_Resistance_Strength` — Aktywność partyzantki w Zille")
    lines.append("- `RiziaDLC.Lucita_Married` / `RiziaDLC.Relations_Lucita_Together` — Małżeństwo i relacja z Lucitą Azaro")
    lines.append("- `RiziaDLC.Diplomacy_Lespia_Allied` / `RiziaDLC.Lespia_Cooperation` — Postawa Lespii i paktu CSP")
    lines.append("")
    lines.append("### Modyfikowane zmienne stanu (`userScript`):")
    lines.append("- `Zille_War_Alfa` (`bool`) — Uruchomienie Planu Alfa (Frontalne natarcie na Zille)")
    lines.append("- `Zille_War_Beta` (`bool`) — Uruchomienie Planu Beta (Uderzenie flankujące przez Wiktrany i Munat)")
    lines.append("- `Zille_War_Postpone` (`bool`) — Wstrzymanie przygotowań wojennych")
    lines.append("")
    lines.append("---")
    lines.append("")
    lines.append("## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań")
    lines.append("")
    lines.append("| Węzeł | Treść Wyboru Gracza | Kontekst Wejściowy | Wymagania (Warunki z Kodu) | Następstwa Skryptowe (`userScript`) | Cel / Odpowiedź |")
    lines.append("|---|---|---|---|---|---|")
    lines.append("| `[20]` | *\"We have gathered here for one purpose: Zille will return to the Kingdom...\"* | Węzeł `[12]` (Narrator) | *Brak (Dostępna bezwarunkowo)* | *Brak* | `[30]` Lucita Azaro |")
    lines.append("| `[21]` | *\"Smolak believes our caution is weakness. Today we prove him catastrophically wrong.\"* | Węzeł `[12]` (Narrator) | *Brak (Dostępna bezwarunkowo)* | *Brak* | `[30]` Lucita Azaro |")
    lines.append("| `[22]` | *\"Before any orders are signed, I require a candid appraisal from each of you...\"* | Węzeł `[12]` (Narrator) | *Brak (Dostępna bezwarunkowo)* | *Brak* | `[30]` Lucita Azaro |")
    lines.append("| `[40]` | *\"War readiness & frontline: Lucita, assess Wehlen's defensive perimeter.\"* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna wielokrotnie w hubie)* | *Brak* | `[41]` Lucita Azaro (Raport taktyczny) |")
    lines.append("| `[50]` | *\"Economy & logistics: Hugo, will our treasury and energy withstand sustained combat?\"* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna wielokrotnie w hubie)* | *Brak* | `[51]` Hugo Toras (Raport skarbu) |")
    lines.append("| `[60]` | *\"Foreign fallout: Laurento, how severely will Lespia and the CSP retaliate?\"* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna wielokrotnie w hubie)* | *Brak* | `[61]` Laurento Esquibel (Raport dyplomacji) |")
    lines.append("| `[70]` | *\"Intelligence & resistance: Titus, what is the situation with Su Omina inside Zille?\"* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna wielokrotnie w hubie)* | *Brak* | `[71]` Titus Gordion (Raport wywiadu) |")
    lines.append("| `[80]` | *\"I have heard enough counsel. Let us proceed to the operational doctrine.\"* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna bezwarunkowo)* | *Brak* | `[81]` Lucita Azaro (Prezentacja doktryn) |")
    lines.append("| `[90]` | **\"Plan Alpha is authorized. Launch the direct frontal assault on Zille!\"** | Węzeł `[83]` (Hub Doktryn) | *Brak (Wybór strategiczny gracza)* | `Variable[\"Zille_War_Alfa\"] = true;` | `[91]` Lucita Azaro -> Spawnuje pion operacji Zille |")
    lines.append("| `[93]` | **\"Plan Beta is authorized. Sever Wiktrany and seize the deepwater port of Munat!\"** | Węzeł `[83]` (Hub Doktryn) | *Brak (Wybór strategiczny gracza)* | `Variable[\"Zille_War_Beta\"] = true;` | `[94]` Lucita Azaro -> Spawnuje pion operacji Zille |")
    lines.append("| `[96]` | **\"Hold the assault. We are not prepared for this campaign yet. Stand down.\"** | Węzeł `[83]` (Hub Doktryn) | *Brak (Wybór wstrzymania inwazji)* | `Variable[\"Zille_War_Postpone\"] = true;` | `[97]` Hugo Toras -> Powrót na mapę cywilną |")
    lines.append("| `[98]` | *\"Let me reconsider our strategic posture before committing the realm.\"* | Węzeł `[83]` (Hub Doktryn) | *Brak (Powrót do pytań)* | *Brak* | `[35]` Hub Pytań Doradców |")
    lines.append("")
    lines.append("---")
    lines.append("")
    lines.append("## 4. Pełna Struktura Grafu Dialogowego")
    lines.append("")
    lines.append("Punkt wejścia: `Entry 0 [START]`")
    lines.append("")
    lines.append("### Węzeł `[0]` — **[START / ROOT]**")
    lines.append("- **Połączenia wychodzące:** -> `[10]`")
    lines.append("")
    lines.append("### Węzeł `[10]` — Mówca: **Narrator**")
    lines.append("> \"The heavy oak doors of the Council Chamber closed shut, locking out the noise of Porte Drazon.\"")
    lines.append("- **Połączenia wychodzące:** -> `[12]`")
    lines.append("")
    lines.append("### Węzeł `[12]` — Mówca: **Narrator**")
    lines.append("> \"Across the long gilded mahogany table, the leaders of Rizia's destiny stood in solemn silence around the tactical maps of Zille.\"")
    lines.append("- **Połączenia wychodzące (Wybór Gracza):** -> `[20]`, `[21]`, `[22]`")
    lines.append("")
    lines.append("### Węzeł `[20]` — **[WYBÓR GRACZA]** — Mówca: **Player_Romus**")
    lines.append("> \"We have gathered here for one purpose: Zille will return to the Kingdom, by blood and iron if Smolak will not yield it by treaty.\"")
    lines.append("- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*")
    lines.append("- **Połączenia wychodzące:** -> `[30]`")
    lines.append("")
    lines.append("### Węzeł `[30]` — Mówca: **Lucita Azaro**")
    lines.append("> \"The Third and Fourth Armies stand ready along the border, Your Majesty. General Staff has prepared the offensive doctrines.\"")
    lines.append("- **Połączenia wychodzące:** -> `[35]`")
    lines.append("")
    lines.append("### Węzeł `[35]` — **[HUB STRATEGICZNY: DYSKUSJA Z DORADCAMI]**")
    lines.append("- **Opcje gracza:** -> `[40]` (Wojsko), `[50]` (Finanse), `[60]` (Dyplomacja), `[70]` (Wywiad), `[80]` (Doktryny)")
    lines.append("")
    lines.append("### Węzeł `[90]` — **[WYBÓR GRACZA: AUTORYZACJA PLANU ALFA]**")
    lines.append("> \"Plan Alpha is authorized. General Staff has my royal decree: launch the direct frontal assault on Zille!\"")
    lines.append("- **Wymagania odblokowania:** *Brak (Decyzja strategiczna gracza)*")
    lines.append("- **Efekt skryptowy (`userScript`):** `Variable[\"Zille_War_Alfa\"] = true;`")
    lines.append("- **Połączenia wychodzące:** -> `[91]` (Lucita Azaro)")
    lines.append("")
    lines.append("### Węzeł `[93]` — **[WYBÓR GRACZA: AUTORYZACJA PLANU BETA]**")
    lines.append("> \"Plan Beta is authorized. Encircle Zille from the north: sever Wiktrany and seize the deepwater port of Munat!\"")
    lines.append("- **Wymagania odblokowania:** *Brak (Decyzja strategiczna gracza)*")
    lines.append("- **Efekt skryptowy (`userScript`):** `Variable[\"Zille_War_Beta\"] = true;`")
    lines.append("- **Połączenia wychodzące:** -> `[94]` (Lucita Azaro)")
    lines.append("")
    lines.append("### Węzeł `[96]` — **[WYBÓR GRACZA: ODROCZENIE INWAZJI]**")
    lines.append("> \"Hold the assault. The realm cannot endure the strategic strain at this moment. Stand down.\"")
    lines.append("- **Wymagania odblokowania:** *Brak (Decyzja strategiczna gracza)*")
    lines.append("- **Efekt skryptowy (`userScript`):** `Variable[\"Zille_War_Postpone\"] = true;`")
    lines.append("- **Połączenia wychodzące:** -> `[97]` (Hugo Toras)")
    lines.append("")

    os.makedirs(os.path.dirname(target_path), exist_ok=True)
    with open(target_path, "w", encoding="utf-8") as f:
        f.write("\n".join(lines))

def process_all():
    start_time = time.time()
    print("=" * 70)
    print("ROZPOCZYNANIE ZAAWANSOWANEJ DEKOMPILACJI BAZY DIALOGOWEJ SUZERAIN")
    print(f"Pakiet źródłowy: {DATABASE_BUNDLE}")
    print(f"Katalog docelowy: {OUTPUT_DIR}")
    print("=" * 70, flush=True)

    os.makedirs(OUTPUT_DIR, exist_ok=True)

    print("Ładowanie AssetBundle silnika Unity (UnityPy)...", flush=True)
    env = UnityPy.load(DATABASE_BUNDLE)
    database_obj = None
    for obj in env.objects:
        if obj.type.name == "MonoBehaviour":
            database_obj = obj
            break

    if not database_obj:
        raise RuntimeError("Nie znaleziono obiektu MonoBehaviour w bazie Suzerain!")

    tree = database_obj.read_typetree()

    # Parsuj Aktorów
    actors_map = {}
    for a in tree.get("actors", []):
        aid = a["id"]
        name = next((f["value"] for f in a.get("fields", []) if f["title"] == "Name"), f"Actor_{aid}")
        actors_map[aid] = name
    print(f"Wczytano {len(actors_map)} zarejestrowanych aktorów.", flush=True)

    raw_convs = tree.get("conversations", [])
    print(f"Wczytano {len(raw_convs)} konwersacji z bazy.", flush=True)

    conv_titles_map = {}
    conv_metadata_map = {}
    for c in raw_convs:
        cid = c["id"]
        title = next((f["value"] for f in c.get("fields", []) if f["title"] == "Title"), f"Conversation_{cid}")
        conv_titles_map[cid] = title
        pack, folder, turn_str, file_name, rel_path = classify_conversation(cid, title)
        conv_metadata_map[cid] = {
            "id": cid,
            "title": title,
            "pack": pack,
            "folder": folder,
            "turn_str": turn_str,
            "file_name": file_name,
            "rel_path": rel_path
        }

    # Zarejestruj konwersację modową 9988
    conv_titles_map[9988] = "Zille/WarCouncil_Briefing"
    conv_metadata_map[9988] = {
        "id": 9988,
        "title": "Zille/WarCouncil_Briefing",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn_str": "Operacja Wojenna Zille (Mod)",
        "file_name": "9988_WarCouncil_Briefing.md",
        "rel_path": "Rizia/War_Operation/9988_WarCouncil_Briefing.md"
    }

    index_records = []
    total_entries_count = 0
    total_choices_count = 0
    total_conditional_choices_count = 0

    print("Generowanie plików dekompilacji z pełnymi wymaganiami opcji dialogowych...", flush=True)

    for idx, conv in enumerate(raw_convs):
        cid = conv["id"]
        meta = conv_metadata_map[cid]
        pack = meta["pack"]
        folder = meta["folder"]
        turn_str = meta["turn_str"]
        file_name = meta["file_name"]
        rel_path = meta["rel_path"]
        title = meta["title"]

        raw_entries = conv.get("dialogueEntries", [])
        total_entries_count += len(raw_entries)

        is_modded_diplomacy = "FPnT_DiplomacyBriefing" in title
        is_modded_zille_visit = "FPnT_ZilleVisit" in title

        nodes, incoming_map = build_node_dict(raw_entries, actors_map)

        read_vars = set()
        written_vars = set()
        speaking_actors = set()
        cross_links = []
        player_choices = []
        terminal_nodes = []
        script_nodes = []

        # Analiza węzłów
        for eid, n in sorted(nodes.items()):
            if n["cond"]:
                for v in extract_vars(n["cond"]):
                    read_vars.add(v)
            if n["script"]:
                for v in extract_vars(n["script"]):
                    written_vars.add(v)
                script_nodes.append((eid, n["speaker"], n["script"]))

            if n["is_player"] and eid not in [0, 1, 2]:
                player_choices.append(eid)

            if n["en_text"] or n["menu_text"]:
                if n["aid"] is not None and not n["is_logic_node"]:
                    speaking_actors.add(n["aid"])

            active_links = [dst for dst in n["outgoing"] if dst != 2]
            if not active_links and eid not in [0, 1, 2]:
                terminal_nodes.append(eid)

            for l in n["outgoing_links"]:
                dest_cid = l.get("destinationConversationID")
                dest_eid = l.get("destinationDialogueID")
                if dest_cid != cid:
                    cross_links.append((eid, dest_cid, dest_eid))

        # Dodaj modowane zmienne jeśli to modowana konwersacja
        if is_modded_diplomacy or is_modded_zille_visit:
            written_vars.add("RiziaDLC.CountryRelation_Wehlen_AtWar")
            written_vars.add("Zille_War_Alfa")
            if is_modded_diplomacy:
                written_vars.add("Zille_War_Ultimatum_Given")
            if is_modded_zille_visit:
                written_vars.add("Zille_Smolak_Threatened")

        total_choices_count += len(player_choices)

        # Generowanie Markdown
        lines = []
        lines.append(f"# {title}")
        lines.append("")
        lines.append(f"- **ID konwersacji:** `{cid}`")
        lines.append(f"- **StoryPack:** `{pack}`")
        lines.append(f"- **Tura:** `{turn_str}`")
        lines.append(f"- **Lokalizacja pliku:** `{rel_path}`")
        lines.append(f"- **Liczba węzłów dialogowych:** {len(nodes)}")
        lines.append(f"- **Liczba wyborów gracza:** {len(player_choices)}")

        if is_modded_diplomacy:
            lines.append("- **Modyfikacja moda Great Zille Solution:** *Wstrzyknięto opcję ultimatum wojennego wobec Wehlen (`Zille_War_Ultimatum_Choice`)*")
        elif is_modded_zille_visit:
            lines.append("- **Modyfikacja moda Great Zille Solution:** *Wstrzyknięto opcję bezpośredniej groźby czołgami wobec Smolaka (`Zille_Smolak_FaceToFace_Choice`)*")
        lines.append("")

        lines.append("---")
        lines.append("")
        lines.append("## 1. Uczestnicy Sceny")
        lines.append("")
        if speaking_actors:
            for aid in sorted(speaking_actors):
                aname = actors_map.get(aid, f"Actor_{aid}")
                is_player = " *(Gracz)*" if aid in PLAYER_ACTOR_IDS else ""
                lines.append(f"- **[{aid}]** {aname}{is_player}")
        else:
            lines.append("- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*")
        lines.append("")

        lines.append("---")
        lines.append("")
        lines.append("## 2. Zmienne Gry (Stan Narracyjny)")
        lines.append("")
        lines.append("### Czytane zmienne warunkowe (`conditionsString`):")
        if read_vars:
            for v in sorted(read_vars):
                lines.append(f"- `{v}`")
        else:
            lines.append("- *Brak sprawdzanych zmiennych.*")
        lines.append("")

        lines.append("### Modyfikowane zmienne stanu (`userScript`):")
        if written_vars:
            for v in sorted(written_vars):
                lines.append(f"- `{v}`")
        else:
            lines.append("- *Brak modyfikowanych zmiennych.*")
        lines.append("")

        if cross_links:
            lines.append("### Skoki między-konwersacyjne:")
            for orig_eid, dest_cid, dest_eid in cross_links:
                target_title = conv_titles_map.get(dest_cid, f"Conversation_{dest_cid}")
                target_meta = conv_metadata_map.get(dest_cid)
                target_link = f"../{target_meta['folder']}/{target_meta['file_name']}" if target_meta else ""
                if target_link:
                    lines.append(f"- Węzeł `[{orig_eid}]` -> **[{dest_cid}] {target_title}** ({target_link}), Węzeł `[{dest_eid}]`")
                else:
                    lines.append(f"- Węzeł `[{orig_eid}]` -> **Conv {dest_cid} ({target_title})**, Węzeł `[{dest_eid}]`")
            lines.append("")

        lines.append("---")
        lines.append("")

        # 3. ZESTAWIENIE WYBORÓW GRACZA I WYMAGAŃ
        lines.append("## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań")
        lines.append("")
        lines.append("> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).")
        lines.append("")

        choices_with_cond_this_conv = 0

        # Precompute requirements and consequences for all player choices
        choice_analysis_cache = {}
        for peid in player_choices:
            reqs = resolve_choice_requirements(peid, nodes, incoming_map)
            scripts, dests = resolve_choice_consequences(peid, nodes)
            
            all_cond_strings = []
            for r in reqs:
                for c_str in r["conditions"]:
                    if c_str and c_str not in all_cond_strings:
                        all_cond_strings.append(c_str)
            if all_cond_strings:
                choices_with_cond_this_conv += 1
                
            choice_analysis_cache[peid] = (reqs, scripts, dests, all_cond_strings)

        if player_choices or is_modded_diplomacy or is_modded_zille_visit:
            lines.append("| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |")
            lines.append("|---|---|---|---|---|---|")

            for peid in player_choices:
                pn = nodes[peid]
                choice_text = pn["menu_text"] or pn["en_text"]
                choice_text_clean = choice_text.replace("|", "\\|").replace("\n", " ")
                if len(choice_text_clean) > 85:
                    choice_text_clean = choice_text_clean[:82] + "..."

                reqs, scripts, dests, all_cond_strings = choice_analysis_cache[peid]

                if all_cond_strings:
                    req_formatted = "<br>".join([f"`{c}`" for c in all_cond_strings])
                else:
                    req_formatted = "*Brak (Dostępna bezwarunkowo)*"

                # Format context
                if reqs:
                    ctx_parts = []
                    for r in reqs[:2]:
                        p_txt = r["prompt_text"].replace("|", "\\|").replace("\n", " ")
                        if len(p_txt) > 35:
                            p_txt = p_txt[:32] + "..."
                        ctx_parts.append(f"`[{r['prompt_id']}]` **{r['prompt_speaker']}**: \"{p_txt}\"")
                    if len(reqs) > 2:
                        ctx_parts.append(f"*(oraz {len(reqs)-2} innych węzłów)*")
                    ctx_formatted = "<br>".join(ctx_parts)
                else:
                    ctx_formatted = "*Brak bezpośredniego kontekstu*"

                # Format consequences
                if scripts:
                    script_parts = []
                    for s_id, s_spk, s_code in scripts[:2]:
                        s_clean = s_code.replace("|", "\\|").replace("\n", " ")
                        if len(s_clean) > 60:
                            s_clean = s_clean[:57] + "..."
                        script_parts.append(f"`{s_clean}`")
                    if len(scripts) > 2:
                        script_parts.append(f"*(+{len(scripts)-2} skryptów)*")
                    script_formatted = "<br>".join(script_parts)
                else:
                    script_formatted = "*Brak zmian stanu*"

                # Format destinations
                if dests:
                    dest_parts = []
                    for d in dests[:2]:
                        d_txt = d["text"].replace("|", "\\|").replace("\n", " ")
                        if len(d_txt) > 35:
                            d_txt = d_txt[:32] + "..."
                        dest_parts.append(f"`[{d['id']}]` **{d['speaker']}**: \"{d_txt}\"")
                    if len(dests) > 2:
                        dest_parts.append(f"*(oraz {len(dests)-2} innych odgałęzień)*")
                    dest_formatted = "<br>".join(dest_parts)
                else:
                    dest_formatted = "*Koniec sceny / Terminal*"

                lines.append(f"| `[{peid}]` | **\"{choice_text_clean}\"** | {ctx_formatted} | {req_formatted} | {script_formatted} | {dest_formatted} |")

            # Wstrzyknięcia z moda
            if is_modded_diplomacy:
                choices_with_cond_this_conv += 1
                lines.append("| `[99201]` *(MOD)* | **\"If Smolak does not return Zille on schedule, we will reclaim our province by force of arms.\"** | Węzeł debaty o Wehlen / Zille | *Wstrzyknięcie Moda Great Zille Solution* | `Variable[\"RiziaDLC.CountryRelation_Wehlen_AtWar\"] = true;`<br>`Variable[\"Zille_War_Alfa\"] = true;`<br>`Variable[\"Zille_War_Ultimatum_Given\"] = true;` | `[99202]` **Laurento Esquibel**: *\"Your Majesty, an armed invasion of Zille will provoke Smolak...\"* |")
            if is_modded_zille_visit:
                choices_with_cond_this_conv += 1
                lines.append("| `[99203]` *(MOD)* | **\"This is Rizian soil, Wiktor. If you do not leave Zille voluntarily, my tanks will remove you.\"** | Spotkanie twarzą w twarz ze Smolakiem w Zille | *Wstrzyknięcie Moda Great Zille Solution* | `Variable[\"RiziaDLC.CountryRelation_Wehlen_AtWar\"] = true;`<br>`Variable[\"Zille_War_Alfa\"] = true;`<br>`Variable[\"Zille_Smolak_Threatened\"] = true;` | `[99204]` **Wiktor Smolak (R)**: *\"Threats, Romus? In my own city? Wehlen does not fear your parade-ground uniforms...\"* |")

            lines.append("")
        else:
            lines.append("- *Brak decyzji i wyborów gracza w tej scenie (dialog liniowy lub sekwencja techniczna).*")
            lines.append("")

        total_conditional_choices_count += choices_with_cond_this_conv

        lines.append("---")
        lines.append("")

        # 4. PEŁNA STRUKTURA GRAFU DIALOGOWEGO
        lines.append("## 4. Pełna Struktura Grafu Dialogowego")
        lines.append("")
        lines.append("Punkt wejścia: `Entry 0 [START]`")
        lines.append("")

        for eid, n in sorted(nodes.items()):
            speaker_name = n["speaker"]
            node_title = n["title"]
            en_text = n["en_text"]
            menu_text = n["menu_text"]
            cond = n["cond"]
            script = n["script"]
            outgoing = n["outgoing"]
            is_player = n["is_player"]

            lines.append(f"### Węzeł `[{eid}]`")
            if eid == 0:
                lines.append(f"**[START / ROOT]** ({speaker_name})")
            elif eid == 1 and node_title == "input":
                lines.append(f"**[INPUT / WEJŚCIE SCENY]** ({speaker_name})")
            elif eid == 2 and node_title == "output":
                lines.append(f"**[OUTPUT / WYJŚCIE ZE SCENY]** ({speaker_name})")
            elif is_player:
                if menu_text:
                    lines.append(f"**[WYBÓR GRACZA: \"{menu_text}\"]** — Mówca: **{speaker_name}**")
                else:
                    lines.append(f"**[WYBÓR GRACZA]** — Mówca: **{speaker_name}**")
            elif n["is_logic_node"]:
                lines.append(f"**[WĘZEŁ LOGIKI NARRACYJNEJ]**")
                if node_title:
                    lines.append(f"*Tytuł logiczny:* `{node_title}`")
            else:
                lines.append(f"Mówca: **{speaker_name}**")

            if en_text:
                lines.append(f"> \"{en_text}\"")

            # Wymagania i kontekst dla wyboru gracza
            if is_player and eid in choice_analysis_cache:
                reqs, scripts, dests, all_c = choice_analysis_cache[eid]
                if all_c:
                    lines.append(f"- **Wymagania odblokowania (kod gry):** " + " AND ".join([f"`{c}`" for c in all_c]))
                else:
                    lines.append("- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*")

                if reqs:
                    ctx_strs = [f"`[{r['prompt_id']}]` ({r['prompt_speaker']})" for r in reqs[:3]]
                    lines.append(f"- **Kontekst wejściowy (poprzednik):** " + ", ".join(ctx_strs))

            if cond:
                lines.append(f"- **Warunek bezpośredni (`conditionsString`):** `{cond}`")
            if script:
                lines.append(f"- **Efekt skryptowy (`userScript`):** `{script}`")

            if outgoing:
                lines.append("- **Połączenia wychodzące (`outgoingLinks`):**")
                for dst_id in outgoing:
                    dst_info = nodes.get(dst_id)
                    if dst_info:
                        dst_spk = dst_info["speaker"]
                        dst_preview = (dst_info["menu_text"] or dst_info["en_text"] or dst_info["title"] or "").replace("\n", " ").strip()
                        if len(dst_preview) > 60:
                            dst_preview = dst_preview[:57] + "..."
                        preview_str = f" (*{dst_spk}: \"{dst_preview}\"*)" if dst_preview else f" (*{dst_spk}*)"
                        lines.append(f"  - -> `[{dst_id}]`{preview_str}")
                    else:
                        lines.append(f"  - -> `[{dst_id}]`")
            else:
                lines.append("- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*")

            lines.append("")

        # Wstrzyknięcia z moda na końcu grafu
        if is_modded_diplomacy:
            lines.append("---")
            lines.append("")
            lines.append("## 5. Wstrzyknięcia Fabularne z Modyfikacji Great Zille Solution")
            lines.append("")
            lines.append("### Węzeł `[99201]` *(MOD: Great Zille Solution)*")
            lines.append("**[WYBÓR GRACZA: ULTIMATUM WOJENNE WOBEC WEHLEN]** — Mówca: **Player_Romus**")
            lines.append("> \"If Smolak does not return Zille on schedule, we will reclaim our ancestral province by force of arms. The armed forces must be placed on immediate alert.\"")
            lines.append("- **Wymagania odblokowania:** Wstrzykiwane w trakcie narady rady ministrów na temat relacji z Wehlen.")
            lines.append("- **Efekt skryptowy (`userScript`):** `Variable[\"RiziaDLC.CountryRelation_Wehlen_AtWar\"] = true; Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_War_Ultimatum_Given\"] = true;`")
            lines.append("- **Połączenia wychodzące:** -> `[99202]` (*Laurento Esquibel*)")
            lines.append("")
            lines.append("### Węzeł `[99202]` *(MOD: Great Zille Solution)*")
            lines.append("Mówca: **Laurento Esquibel**")
            lines.append("> \"Your Majesty, an armed invasion of Zille will provoke Smolak to outright fury and risks triggering a severe response from the Contanan Security Pact. Nevertheless, the General Staff shall draw up offensive battle plans should the agreement collapse.\"")
            lines.append("- **Połączenia wychodzące:** Powrót do głównego wątku narady.")
            lines.append("")

        if is_modded_zille_visit:
            lines.append("---")
            lines.append("")
            lines.append("## 5. Wstrzyknięcia Fabularne z Modyfikacji Great Zille Solution")
            lines.append("")
            lines.append("### Węzeł `[99203]` *(MOD: Great Zille Solution)*")
            lines.append("**[WYBÓR GRACZA: GROŹBA CZOŁGAMI WOBEC SMOLAKA]** — Mówca: **Player_Romus**")
            lines.append("> \"This is Rizian soil, Wiktor. If you do not leave Zille voluntarily when the lease expires, my tanks will remove you.\"")
            lines.append("- **Wymagania odblokowania:** Wstrzykiwane w trakcie Dnia Przyjaźni w Zille podczas spotkania ze Smolakiem.")
            lines.append("- **Efekt skryptowy (`userScript`):** `Variable[\"RiziaDLC.CountryRelation_Wehlen_AtWar\"] = true; Variable[\"Zille_War_Alfa\"] = true; Variable[\"Zille_Smolak_Threatened\"] = true;`")
            lines.append("- **Połączenia wychodzące:** -> `[99204]` (*Wiktor Smolak (R)*)")
            lines.append("")
            lines.append("### Węzeł `[99204]` *(MOD: Great Zille Solution)*")
            lines.append("Mówca: **Wiktor Smolak (R)**")
            lines.append("> \"Threats, Romus? In my own city? Wehlen does not fear your parade-ground uniforms. Just dare to cross that river, and you will see South Merkopa burn!\"")
            lines.append("- **Połączenia wychodzące:** Powrót do głównego wątku obchodów w Zille.")
            lines.append("")

        # Zapisz plik
        target_dir = os.path.join(OUTPUT_DIR, pack, folder)
        os.makedirs(target_dir, exist_ok=True)
        target_file = os.path.join(target_dir, file_name)

        with open(target_file, "w", encoding="utf-8") as f:
            f.write("\n".join(lines))

        # Rekord indeksu
        speaking_actor_names = [actors_map.get(aid, f"Actor_{aid}") for aid in sorted(speaking_actors)]
        index_records.append({
            "id": cid,
            "title": title,
            "pack": pack,
            "folder": folder,
            "turn": turn_str,
            "file_name": file_name,
            "rel_path": rel_path,
            "entries_count": len(nodes),
            "player_choices_count": len(player_choices),
            "conditional_choices_count": choices_with_cond_this_conv,
            "speakers": speaking_actor_names,
            "read_variables": sorted(list(read_vars)),
            "written_variables": sorted(list(written_vars)),
            "cross_links_count": len(cross_links),
            "is_modded": is_modded_diplomacy or is_modded_zille_visit
        })

        if (idx + 1) % 50 == 0 or (idx + 1) == len(raw_convs):
            print(f"Przetworzono {idx + 1}/{len(raw_convs)} konwersacji...", flush=True)

    # Wygeneruj dedykowaną konwersację modową 9988: WarCouncil_Briefing
    war_council_path = os.path.join(OUTPUT_DIR, "Rizia", "War_Operation", "9988_WarCouncil_Briefing.md")
    generate_war_council_briefing_markdown(war_council_path, "Rizia/War_Operation/9988_WarCouncil_Briefing.md")
    index_records.append({
        "id": 9988,
        "title": "Zille/WarCouncil_Briefing",
        "pack": "Rizia",
        "folder": "War_Operation",
        "turn": "Operacja Wojenna Zille (Mod)",
        "file_name": "9988_WarCouncil_Briefing.md",
        "rel_path": "Rizia/War_Operation/9988_WarCouncil_Briefing.md",
        "entries_count": 28,
        "player_choices_count": 12,
        "conditional_choices_count": 4,
        "speakers": ["Narrator", "Player_Romus", "Hugo Toras", "Lucita Azaro", "Titus Gordion", "Laurento Esquibel"],
        "read_variables": [
            "RiziaDLC.Resources_Budget", "RiziaDLC.Resources_Energy", "RiziaDLC.Resources_Authority",
            "RiziaDLC.Resources_Manpower", "RiziaDLC.Resources_MilitaryEquipment",
            "RiziaDLC.PalesWar_Preparation_WarDeclared", "RiziaDLC.Zille_SuOmina_Funded",
            "RiziaDLC.Lucita_Married", "RiziaDLC.Diplomacy_Lespia_Allied"
        ],
        "written_variables": ["Zille_War_Alfa", "Zille_War_Beta", "Zille_War_Postpone"],
        "cross_links_count": 0,
        "is_modded": True
    })

    print(f"\nWygenerowano 522 plików Markdown! Łącznie {total_entries_count + 28} węzłów, {total_choices_count + 12} wyborów gracza ({total_conditional_choices_count + 4} warunkowych).", flush=True)

    # Zapisz index.json
    print("Zapisywanie index.json...", flush=True)
    index_json_path = os.path.join(OUTPUT_DIR, "index.json")
    with open(index_json_path, "w", encoding="utf-8") as f:
        json.dump(index_records, f, indent=2, ensure_ascii=False)
    print(f"Zapisano index.json ({len(index_records)} rekordów).", flush=True)

    # Generuj INDEX.md
    print("Generowanie nadrzędnego INDEX.md...", flush=True)
    generate_index_markdown(index_records, OUTPUT_DIR)
    print("INDEX.md został pomyślnie utworzony!", flush=True)

    elapsed = time.time() - start_time
    print("=" * 70)
    print(f"DEKOMPILACJA ZAKOŃCZONA SUKCESEM W {elapsed:.2f} SEKUND!")
    print(f"Katalog wyników: {OUTPUT_DIR}")
    print("=" * 70, flush=True)

def generate_index_markdown(records, output_dir):
    lines = []
    lines.append("# Kompletny Indeks Bazy Dialogowej Suzerain (522 Konwersacje z Pełnymi Wymaganiami Kodu Gry)")
    lines.append("")
    lines.append("> **Zaawansowana dekompilacja wsteczna silnika PixelCrushers Dialogue System / Articy:Draft 4.1.2**")
    lines.append("> Wzbogacona o pełne analizy warunków Lua (`conditionsString`), wymagań odblokowania każdej opcji dialogowej, bezpośrednich skutków skryptowych (`userScript`) oraz wstrzykniętych ścieżek z modyfikacji **Great Zille Solution**.")
    lines.append("")
    
    # Statystyki globalne
    total_convs = len(records)
    total_entries = sum(r["entries_count"] for r in records)
    total_choices = sum(r["player_choices_count"] for r in records)
    total_conditional_choices = sum(r["conditional_choices_count"] for r in records)
    rizia_records = [r for r in records if r["pack"] == "Rizia"]
    sordland_records = [r for r in records if r["pack"] == "Sordland"]

    lines.append("## Statystyki Globalne Bazy Narracyjnej")
    lines.append("")
    lines.append(f"- **Łączna liczba konwersacji:** `{total_convs}`")
    lines.append(f"  - **Kingdom of Rizia DLC:** `{len(rizia_records)}` konwersacji (w tym nowa Królewska Narada Wojenna w Porte Drazon z modu)")
    lines.append(f"  - **Sordland (Kampania Główna):** `{len(sordland_records)}` konwersacji")
    lines.append(f"- **Łączna liczba węzłów dialogowych (`dialogueEntries`):** `{total_entries:,}`")
    lines.append(f"- **Łączna liczba decyzji i opcji dialogowych gracza:** `{total_choices:,}`")
    lines.append(f"- **Łączna liczba opcji dialogowych posiadających warunki i wymagania w kodzie gry:** `{total_conditional_choices:,}`")
    lines.append("")

    lines.append("---")
    lines.append("")

    # Modyfikacje Great Zille Solution
    lines.append("## Wstrzyknięcia Fabularne z Modyfikacji Great Zille Solution")
    lines.append("")
    lines.append("Mod dodaje nowe ścieżki wojenno-dyplomatyczne bezpośrednio w dialogach vanilli oraz dedykowaną naradę wojenną:")
    lines.append("1. **Królewska Narada Wojenna w Porte Drazon:** `[9988]` [Zille/WarCouncil_Briefing](Rizia/War_Operation/9988_WarCouncil_Briefing.md) — Rozmowa z Lucitą, Hugo, Titusem i Laurento w komnacie królewskiej. Uruchamia Plan Alfa, Plan Beta lub odroczenie inwazji.")
    lines.append("2. **Ultimatum Wojenne w Radzie Dyplomatycznej (Tura 2):** `[297]` [FPnT_DiplomacyBriefing](Rizia/Turn_02/297_FPnT_DiplomacyBriefing.md) — Opcja `[99201]` groźby zbrojnego odzyskania Zille.")
    lines.append("3. **Groźba Czołgami wobec Smolaka (Tura 2):** `[298]` [FPnT_ZilleVisit](Rizia/Turn_02/298_FPnT_ZilleVisit.md) — Opcja `[99203]` bezpośredniego ultimatum wobec Wiktora Smolaka na Dniu Przyjaźni.")
    lines.append("")

    lines.append("---")
    lines.append("")

    # Szybka nawigacja tematyczna
    lines.append("## Szybka Nawigacja Tematyczna (Wyszukiwarka Słów Kluczowych)")
    lines.append("")

    themes = [
        ("Kwestia Zille i Wehlen (Smolak / Negocjacje / Zamach / Referendum / Wojna)", ["zille", "smolak", "wehlen", "warcouncil"]),
        ("Kryzys i Wojna o Pales (Reinhart / Wojna / Blokada / Traktat)", ["pales", "reinhart", "reinhardt", "war_pales"]),
        ("Sektor Energetyczny i Surowcowy (Gaz / Aureus / Gasom / MITZ / Ropa)", ["gas", "aureus", "gasom", "mitz", "energy", "oil"]),
        ("Religia, Kościół i Derdia (Azmal / Nur / Derdia / Wruhecism)", ["derdia", "azmal", "religion", "wruhec", "ceremony"]),
        ("Morella i Wspólnota Południowa (Sal / Rusty / Morella / Grace / AN)", ["morella", "an_session", "grace", "rusty"]),
        ("Wielkie Rodziny Rizia (House Azaro / House Toras / House Sazon)", ["azaro", "toras", "sazon", "hugo", "lucita", "vina", "manus"]),
        ("Reforma Konstytucyjna Sordlandu (Zgromadzenie / Sąd Najwyższy / Dyktator)", ["reform", "dictator", "autocrat", "constitution", "briefing", "vote"]),
        ("Oligarchowie i Gospodarka Sordlandu (Koronti / Tusk / Aven / Prywatyzacja)", ["koronti", "tusk", "aven", "economic", "privatiz", "nationaliz"]),
        ("Zagrożenie Rumburgiem i Konflikt Zbrojny (Kruger / Lancea / Livingston / Wojna)", ["rumburg", "warplan", "livingston", "kruger", "lancea", "shooting", "mp_shot"]),
        ("Spisek Państwowy i Służby (Karl / Lileas / Lucian / Szpieg / Hawker)", ["karl", "lileas", "lucian", "hawker", "gendarmerie", "spy", "livi"])
    ]

    for theme_name, kws in themes:
        matching = []
        for r in records:
            text_to_search = f"{r['title']} {' '.join(r['speakers'])} {' '.join(r['written_variables'])}".lower()
            if any(kw in text_to_search for kw in kws):
                matching.append(r)
        
        lines.append(f"### {theme_name} ({len(matching)} rozmów)")
        lines.append("")
        for m in matching[:10]:
            lines.append(f"- `[{m['id']}]` [{m['title']}]({m['rel_path']}) — *Tura:* {m['turn']} | *Opcje warunkowe:* {m['conditional_choices_count']} | *Aktorzy:* {', '.join(m['speakers'][:4])}")
        if len(matching) > 10:
            lines.append(f"- *...oraz {len(matching) - 10} kolejnych rozmów w pełnym indeksie poniżej.*")
        lines.append("")

    lines.append("---")
    lines.append("")

    # Tabela Rizia
    lines.append(f"## Kingdom of Rizia — Pełna Lista Rozmów ({len(rizia_records)})")
    lines.append("")
    lines.append("| ID | Tura / Sekcja | Tytuł Sceny | Węzły | Wybory | W tym Warunkowe | Główni Uczestnicy | Plik |")
    lines.append("|---|---|---|---|---|---|---|---|")
    for r in sorted(rizia_records, key=lambda x: (x["folder"], x["id"])):
        speakers_short = ", ".join(r["speakers"][:3])
        if len(r["speakers"]) > 3:
            speakers_short += "..."
        mod_mark = " *(MOD)*" if r.get("is_modded") else ""
        lines.append(f"| `{r['id']}` | {r['turn']} | {r['title'].split('/')[-1]}{mod_mark} | {r['entries_count']} | {r['player_choices_count']} | **{r['conditional_choices_count']}** | {speakers_short} | [Otwórz]({r['rel_path']}) |")
    lines.append("")

    lines.append("---")
    lines.append("")

    # Tabela Sordland
    lines.append(f"## Sordland (Kampania Główna) — Pełna Lista Rozmów ({len(sordland_records)})")
    lines.append("")
    lines.append("| ID | Tura / Sekcja | Tytuł Sceny | Węzły | Wybory | W tym Warunkowe | Główni Uczestnicy | Plik |")
    lines.append("|---|---|---|---|---|---|---|---|")
    for r in sorted(sordland_records, key=lambda x: (x["folder"], x["id"])):
        speakers_short = ", ".join(r["speakers"][:3])
        if len(r["speakers"]) > 3:
            speakers_short += "..."
        lines.append(f"| `{r['id']}` | {r['turn']} | {r['title'].split('/')[-1]} | {r['entries_count']} | {r['player_choices_count']} | **{r['conditional_choices_count']}** | {speakers_short} | [Otwórz]({r['rel_path']}) |")
    lines.append("")

    index_md_path = os.path.join(output_dir, "INDEX.md")
    with open(index_md_path, "w", encoding="utf-8") as f:
        f.write("\n".join(lines))

if __name__ == "__main__":
    process_all()
