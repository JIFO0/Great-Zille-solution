import os
import re
import json
import time
import UnityPy

DATABASE_BUNDLE = r"H:\SteamLibrary\steamapps\common\Suzerain\Suzerain_Data\StreamingAssets\aa\StandaloneWindows64\database_assets_all_2c5c6df453acd4d096b216389ddafa9b.bundle"
OUTPUT_DIR = r"C:\Projects\Great Zille solution\docs\conversations_decompiled"

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

def process_all():
    start_time = time.time()
    print("=" * 60)
    print("Rozpoczynanie dekompilacji bazy dialogowej Suzerain...")
    print(f"Pakiet źródłowy: {DATABASE_BUNDLE}")
    print(f"Katalog wyjściowy: {OUTPUT_DIR}")
    print("=" * 60)

    os.makedirs(OUTPUT_DIR, exist_ok=True)

    # 1. Załaduj bundle UnityPy
    print("Ładowanie AssetBundle...")
    env = UnityPy.load(DATABASE_BUNDLE)
    
    database_obj = None
    for obj in env.objects:
        if obj.type.name == "MonoBehaviour":
            database_obj = obj
            break

    if not database_obj:
        raise RuntimeError("Nie znaleziono obiektu MonoBehaviour w bundle!")

    tree = database_obj.read_typetree()
    
    # 2. Parsuj Aktorów
    actors_map = {}
    for a in tree.get("actors", []):
        aid = a["id"]
        name = next((f["value"] for f in a.get("fields", []) if f["title"] == "Name"), f"Actor_{aid}")
        actors_map[aid] = name
    print(f"Wczytano {len(actors_map)} aktorów.")

    # 3. Parsuj tytuły konwersacji do szybkiego wyszukiwania powiązań
    raw_convs = tree.get("conversations", [])
    print(f"Wczytano {len(raw_convs)} konwersacji z bazy.")

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

    # 4. Generuj pliki Markdown dla każdej konwersacji
    index_records = []
    total_entries_count = 0
    total_choices_count = 0

    print("Generowanie plików dekompilacji Markdown (.md)...")
    
    for idx, conv in enumerate(raw_convs):
        cid = conv["id"]
        meta = conv_metadata_map[cid]
        pack = meta["pack"]
        folder = meta["folder"]
        turn_str = meta["turn_str"]
        file_name = meta["file_name"]
        rel_path = meta["rel_path"]
        title = meta["title"]

        entries = conv.get("dialogueEntries", [])
        total_entries_count += len(entries)

        read_vars = set()
        written_vars = set()
        speaking_actors = set()
        cross_links = []
        player_choice_count = 0
        terminal_nodes = []
        script_nodes = []

        # Analiza węzłów
        for e in entries:
            eid = e["id"]
            fdict = {f["title"]: f["value"] for f in e.get("fields", [])}
            
            aid_str = fdict.get("Actor", "")
            aid = int(aid_str) if aid_str.isdigit() else None
            
            en_text = fdict.get("en", "").strip()
            menu_text = fdict.get("Menu Text en", "").strip() or fdict.get("Menu Text", "").strip()

            if aid in PLAYER_ACTOR_IDS or menu_text:
                if eid not in [0, 1, 2]:
                    player_choice_count += 1

            if en_text or menu_text:
                if aid is not None:
                    speaking_actors.add(aid)

            cond = e.get("conditionsString", "").strip()
            script = e.get("userScript", "").strip()

            if cond:
                for v in extract_vars(cond):
                    read_vars.add(v)
            if script:
                for v in extract_vars(script):
                    written_vars.add(v)
                script_nodes.append((eid, aid, script))

            links = e.get("outgoingLinks", [])
            active_links = [l for l in links if l.get("destinationDialogueID") != 2]
            if not active_links and eid not in [0, 1, 2]:
                terminal_nodes.append(eid)

            for l in links:
                dest_cid = l.get("destinationConversationID")
                dest_eid = l.get("destinationDialogueID")
                if dest_cid != cid:
                    cross_links.append((eid, dest_cid, dest_eid))

        total_choices_count += player_choice_count

        # Generowanie treści MD
        lines = []
        lines.append(f"# {title}")
        lines.append("")
        lines.append(f"- **ID konwersacji:** `{cid}`")
        lines.append(f"- **StoryPack:** `{pack}`")
        lines.append(f"- **Tura:** `{turn_str}`")
        lines.append(f"- **Lokalizacja pliku:** `{rel_path}`")
        lines.append(f"- **Liczba węzłów dialogowych:** {len(entries)}")
        lines.append(f"- **Liczba wyborów gracza:** {player_choice_count}")
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
        lines.append("## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia")
        lines.append("")
        lines.append(f"- **Węzły kończące (Terminal Nodes):** {len(terminal_nodes)}")
        lines.append(f"- **Węzły modyfikujące stan gry:** {len(script_nodes)}")
        
        # Kluczowe zmienne
        key_vars = [v for v in written_vars if any(k in v.lower() for k in [
            "budget", "authority", "energy", "economy", "relations", "wealth", 
            "war", "zille", "pales", "smolak", "decree", "unrest", "corruption", "soll"
        ])]
        if key_vars:
            lines.append("\n**Główne modyfikowane wskaźniki i kluczowe flagi:**")
            for v in sorted(key_vars)[:12]:
                lines.append(f"- `{v}`")
            if len(key_vars) > 12:
                lines.append(f"- *...oraz {len(key_vars) - 12} innych wskaźników.*")

        if script_nodes:
            lines.append("\n**Węzły wykonujące kluczowe operacje skryptowe:**")
            for seid, said, s_code in script_nodes[:8]:
                saname = actors_map.get(said, "System") if said is not None else "System"
                s_summary = s_code.replace("\n", " ").strip()
                if len(s_summary) > 100:
                    s_summary = s_summary[:97] + "..."
                lines.append(f"- Węzeł `[{seid}]` ({saname}): `{s_summary}`")
            if len(script_nodes) > 8:
                lines.append(f"- *...oraz {len(script_nodes) - 8} innych węzłów ze skryptami.*")
        lines.append("")

        lines.append("---")
        lines.append("")
        lines.append("## 4. Pełna Struktura Grafu Dialogowego")
        lines.append("")
        lines.append("Punkt wejścia: `Entry 0 [START]`")
        lines.append("")

        for e in sorted(entries, key=lambda x: x["id"]):
            eid = e["id"]
            fdict = {f["title"]: f["value"] for f in e.get("fields", [])}
            aid_str = fdict.get("Actor", "")
            aid = int(aid_str) if aid_str.isdigit() else None
            speaker_name = actors_map.get(aid, "System") if aid is not None else "System"

            node_title = fdict.get("Title", "")
            en_text = fdict.get("en", "").strip()
            menu_text = fdict.get("Menu Text en", "").strip() or fdict.get("Menu Text", "").strip()
            cond = e.get("conditionsString", "").strip()
            script = e.get("userScript", "").strip()
            links = e.get("outgoingLinks", [])

            is_player_node = (aid in PLAYER_ACTOR_IDS) or bool(menu_text)

            lines.append(f"### Węzeł `[{eid}]`")
            if eid == 0:
                lines.append(f"**[START / ROOT]** ({speaker_name})")
            elif eid == 1 and node_title == "input":
                lines.append(f"**[INPUT / WEJŚCIE SCENY]** ({speaker_name})")
            elif eid == 2 and node_title == "output":
                lines.append(f"**[OUTPUT / WYJŚCIE ZE SCENY]** ({speaker_name})")
            elif is_player_node:
                if menu_text:
                    lines.append(f"**[WYBÓR GRACZA: \"{menu_text}\"]** — Mówca: **{speaker_name}**")
                else:
                    lines.append(f"**[WYBÓR GRACZA]** — Mówca: **{speaker_name}**")
            else:
                lines.append(f"Mówca: **{speaker_name}**")

            if en_text:
                lines.append(f"> \"{en_text}\"")
            elif eid not in [0, 1, 2]:
                clean_node_title = node_title.strip() if node_title else "Węzeł pośredni / warunkowy"
                lines.append(f"*(Węzeł logiki narracyjnej: {clean_node_title})*")

            if cond:
                lines.append(f"- **Warunek (`conditionsString`):** `{cond}`")
            if script:
                lines.append(f"- **Efekt (`userScript`):** `{script}`")

            if links:
                lines.append("- **Połączenia wychodzące (`outgoingLinks`):**")
                for l in links:
                    dest_cid = l.get("destinationConversationID")
                    dest_eid = l.get("destinationDialogueID")
                    if dest_cid == cid:
                        lines.append(f"  - -> `[{dest_eid}]`")
                    else:
                        target_title = conv_titles_map.get(dest_cid, f"Conversation_{dest_cid}")
                        lines.append(f"  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `{dest_cid}` (*{target_title}*), Węzeł `[{dest_eid}]`")
            else:
                lines.append("- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*")

            lines.append("")

        # Zapisz plik na dysku
        target_dir = os.path.join(OUTPUT_DIR, pack, folder)
        os.makedirs(target_dir, exist_ok=True)
        target_file = os.path.join(target_dir, file_name)

        with open(target_file, "w", encoding="utf-8") as f:
            f.write("\n".join(lines))

        # Zapisz rekord indeksu
        speaking_actor_names = [actors_map.get(aid, f"Actor_{aid}") for aid in sorted(speaking_actors)]
        index_records.append({
            "id": cid,
            "title": title,
            "pack": pack,
            "folder": folder,
            "turn": turn_str,
            "file_name": file_name,
            "rel_path": rel_path,
            "entries_count": len(entries),
            "player_choices_count": player_choice_count,
            "speakers": speaking_actor_names,
            "read_variables": sorted(list(read_vars)),
            "written_variables": sorted(list(written_vars)),
            "cross_links_count": len(cross_links)
        })

        if (idx + 1) % 50 == 0 or (idx + 1) == len(raw_convs):
            print(f"Przetworzono {idx + 1}/{len(raw_convs)} konwersacji...")

    print(f"\nWygenerowano 521 plików Markdown! Łącznie {total_entries_count} węzłów, {total_choices_count} wyborów gracza.")

    # 5. Generuj index.json
    print("Zapisywanie index.json...")
    index_json_path = os.path.join(OUTPUT_DIR, "index.json")
    with open(index_json_path, "w", encoding="utf-8") as f:
        json.dump(index_records, f, indent=2, ensure_ascii=False)
    print(f"Zapisano index.json ({len(index_records)} rekordów).")

    # 6. Generuj INDEX.md z wyszukiwarką tematyczną
    print("Generowanie nadrzędnego INDEX.md...")
    generate_index_markdown(index_records, OUTPUT_DIR)
    print("INDEX.md został pomyślnie utworzony!")

    elapsed = time.time() - start_time
    print("=" * 60)
    print(f"DEKOMPILACJA ZAKOŃCZONA SUKCESEM W {elapsed:.2f} SEKUND!")
    print(f"Katalog wyników: {OUTPUT_DIR}")
    print("=" * 60)

def generate_index_markdown(records, output_dir):
    lines = []
    lines.append("# Kompletny Indeks Bazy Dialogowej Suzerain (521 Konwersacji)")
    lines.append("")
    lines.append("> Dekompilacja wsteczna silnika PixelCrushers Dialogue System / Articy:Draft 4.1.2.")
    lines.append("> Wszystkie węzły, lokalizacja językowa `en`, wybory gracza oraz skrypty Lua.")
    lines.append("")
    
    # Statystyki globalne
    total_convs = len(records)
    total_entries = sum(r["entries_count"] for r in records)
    total_choices = sum(r["player_choices_count"] for r in records)
    rizia_records = [r for r in records if r["pack"] == "Rizia"]
    sordland_records = [r for r in records if r["pack"] == "Sordland"]

    lines.append("## Statystyki Globalne")
    lines.append("")
    lines.append(f"- **Łączna liczba konwersacji:** `{total_convs}`")
    lines.append(f"  - **Kingdom of Rizia DLC:** `{len(rizia_records)}` konwersacji")
    lines.append(f"  - **Sordland (Kampania Główna):** `{len(sordland_records)}` konwersacji")
    lines.append(f"- **Łączna liczba węzłów dialogowych (`dialogueEntries`):** `{total_entries:,}`")
    lines.append(f"- **Łączna liczba decyzji i wyborów gracza:** `{total_choices:,}`")
    lines.append("")

    lines.append("---")
    lines.append("")

    # Szybka nawigacja tematyczna (Wyszukiwarka)
    lines.append("## Szybka Nawigacja Tematyczna (Wyszukiwarka Słów Kluczowych)")
    lines.append("")

    themes = [
        ("Kwestia Zille i Wehlen (Smolak / Negocjacje / Zamach / Referendum)", ["zille", "smolak", "wehlen"]),
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
            lines.append(f"- `[{m['id']}]` [{m['title']}]({m['rel_path']}) — *Tura:* {m['turn']} | *Aktorzy:* {', '.join(m['speakers'][:4])}")
        if len(matching) > 10:
            lines.append(f"- *...oraz {len(matching) - 10} kolejnych rozmów w pełnym indeksie poniżej.*")
        lines.append("")

    lines.append("---")
    lines.append("")

    # Indeks Aktorów
    lines.append("## Indeks Wystąpień Postaci Kluczowych")
    lines.append("")
    key_actors = [
        "Wiktor Smolak (R)", "Wiktor Smolak", "Lucita Azaro", "Hugo Toras", "Vina Toras", 
        "Titus Gordion", "Sal Ignacius", "Laurento Esquibel", "Pabel Adria", "Axel Reinhart",
        "Marcel Koronti", "Walter Tusk", "Lucian Galade", "Petr Vectern", "Nia Morgna",
        "Ciara Walda", "Lileas Graf", "Symon Holl", "Iosef Lancea", "Valken Kruger", "Tarquin Soll"
    ]
    for kname in key_actors:
        matching = [r for r in records if kname in r["speakers"]]
        lines.append(f"- **{kname}:** `{len(matching)}` scen dialogowych")
    lines.append("")

    lines.append("---")
    lines.append("")

    # Tabela Rizia
    lines.append("## Kingdom of Rizia — Pełna Lista Rozmów (229)")
    lines.append("")
    lines.append("| ID | Tura / Sekcja | Tytuł Sceny | Węzły | Wybory | Główni Uczestnicy | Plik |")
    lines.append("|---|---|---|---|---|---|---|")
    for r in sorted(rizia_records, key=lambda x: (x["folder"], x["id"])):
        speakers_short = ", ".join(r["speakers"][:3])
        if len(r["speakers"]) > 3:
            speakers_short += "..."
        lines.append(f"| `{r['id']}` | {r['turn']} | {r['title'].split('/')[-1]} | {r['entries_count']} | {r['player_choices_count']} | {speakers_short} | [Otwórz]({r['rel_path']}) |")
    lines.append("")

    lines.append("---")
    lines.append("")

    # Tabela Sordland
    lines.append("## Sordland (Kampania Główna) — Pełna Lista Rozmów (292)")
    lines.append("")
    lines.append("| ID | Tura / Sekcja | Tytuł Sceny | Węzły | Wybory | Główni Uczestnicy | Plik |")
    lines.append("|---|---|---|---|---|---|---|")
    for r in sorted(sordland_records, key=lambda x: (x["folder"], x["id"])):
        speakers_short = ", ".join(r["speakers"][:3])
        if len(r["speakers"]) > 3:
            speakers_short += "..."
        lines.append(f"| `{r['id']}` | {r['turn']} | {r['title'].split('/')[-1]} | {r['entries_count']} | {r['player_choices_count']} | {speakers_short} | [Otwórz]({r['rel_path']}) |")
    lines.append("")

    index_md_path = os.path.join(output_dir, "INDEX.md")
    with open(index_md_path, "w", encoding="utf-8") as f:
        f.write("\n".join(lines))

if __name__ == "__main__":
    process_all()
