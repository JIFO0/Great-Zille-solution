import json
import os

out_dir = r"docs\dumps"
os.makedirs(out_dir, exist_ok=True)

print("Generowanie SITUATIONS_INDEX_DUMP.md...")
with open("docs/raw_database_dumps/SituationData.json", "r", encoding="utf-8") as f:
    sit_data = json.load(f)

r_sit = [it for it in sit_data["items"] if "Rizia" in it.get("Path", "")]

by_cat = {}
for it in r_sit:
    path = it.get("Path", "")
    parts = path.split("/")
    cat = parts[2] if len(parts) > 2 else "Other"
    by_cat.setdefault(cat, []).append(it)

lines = []
lines.append("# The Great Zille Solution: Dump i Indeks Sytuacji Kraju (SituationData)")
lines.append("")
lines.append("*Oficjalny zrzut sytuacji z prawego panelu interfejsu (kolorowe wskaźniki stanu państwa) oraz specyfikacja nowych i modyfikowanych sytuacji wojennych.*")
lines.append("")
lines.append("## 1. Czym jest 'Indeks Sytuacji' w Suzerainie?")
lines.append("")
lines.append("W grze *Suzerain* 'Sytuacje' (`SituationData`) to zestaw kart informacyjnych wyświetlanych po prawej stronie interfejsu.")
lines.append("Każda sytuacja posiada:")
lines.append("- **Tytuł i Opis:** Szczegółowe wyjaśnienie zjawiska społeczno-gospodarczego.")
lines.append("- **Kolor / Stopień Istotności (`SituationSeverityString`):**")
lines.append("  - **Zielony / Pozytywny (`Low` lub `High` zależnie od kontekstu):** Sukcesy, przewaga militarna, zyski.")
lines.append("  - **Żółty / Ostrzegawczy (`Medium`):** Napięcia, rosnące koszty, przejściowe trudności.")
lines.append("  - **Czerwony / Kryzysowy (`High` dla negatywnych):** Klęski, blokady, rebelie, katastrofy budżetowe.")
lines.append("- **Zmienną Aktywującą (`IsEnabledVariable`):** Flaga logiczna sterująca widocznością karty.")
lines.append("")
lines.append(f"### Statystyki Bazy Sytuacji DLC Rizia: `{len(r_sit)}` sytuacji")
for c in sorted(by_cat.keys()):
    lines.append(f"- **Kategoria {c}:** `{len(by_cat[c])}` sytuacji")
lines.append("")
lines.append("---")
lines.append("")
lines.append("## 2. Oficjalne Sytuacje w DLC Rizia (Podział na Kategorie)")
lines.append("")

for c in sorted(by_cat.keys()):
    lines.append(f"### Kategoria: {c} ({len(by_cat[c])} sytuacji)")
    lines.append("")
    lines.append("| ID w Bazie | Tytuł Sytuacji | Kolor / Stopień | Flaga Sterująca | Krótki Opis |")
    lines.append("|---|---|---|---|---|")
    for s in by_cat[c]:
        sp = s.get("SituationProperties", {})
        title = sp.get("Title", "Bez Tytułu")
        sev = sp.get("SituationSeverityString", "Brak")
        var = sp.get("IsEnabledVariable", "")
        desc = sp.get("Description", "").replace("\n", " ").strip()
        if len(desc) > 80:
            desc = desc[:77] + "..."
        lines.append(f"| `{s.get('NameInDatabase')}` | **{title}** | `{sev}` | `{var}` | {desc} |")
    lines.append("")

lines.append("---")
lines.append("")
lines.append("## 3. Nowe i Modyfikowane Sytuacje Wojenne Modu „Great Zille Solution”")
lines.append("")
lines.append("Poniższy zestaw kart sytuacji dynamicznie reaguje na stan operacji w Zille, bilans energetyczny i reakcje mocarstw:")
lines.append("")

new_situations = [
    {
        "cat": "Military",
        "name": "Situation_Military_Zille_War_Active",
        "title": "Wojna o Zille (Kampania Południowa)",
        "sev": "Yellow (Medium) / Red (High przy stratach)",
        "var": "Zille_War_Active",
        "desc": "Królewska Armia Rizii prowadzi operację zbrojną mającą na celu wyzwolenie prowincji Zille spod okupacji Wehlen. Działania bojowe wymagają stałych dostaw amunicji i paliwa oraz angażują elitarne dywizje pancerne."
    },
    {
        "cat": "Military",
        "name": "Situation_Military_Two_Front_Overextension",
        "title": "Koszmar Dwufrontowości (Rozciągnięcie Linii)",
        "sev": "Red (High)",
        "var": "Zille_TwoFrontWar",
        "desc": "Równoległe prowadzenie wojny z Pales na północy oraz Wehlen na południu doprowadziło riziański aparat wojskowy na skraj załamania. Rezerwy amunicji są na wyczerpaniu, a oficerowie sztabowi alarmują o braku sił osłonowych w centrum kraju."
    },
    {
        "cat": "Military",
        "name": "Situation_Military_Azaro_Command_Superiority",
        "title": "Supremacja Ogniowa Rodu Azaro",
        "sev": "Green (Low)",
        "var": "Zille_Azaro_Superiority",
        "desc": "Dywizje pancerne i artyleria z Montaklar osiągnęły pełną przewagę taktyczną nad siłami Wehlen. Koordynacja nalotów i zmasowanego ostrzału pozwoliła na przełamanie wehzekich bunkrów w rekordowym tempie."
    },
    {
        "cat": "Military",
        "name": "Situation_Military_Zille_Liberated",
        "title": "Triumf Oręża: Zille Wyzwolone",
        "sev": "Green (Low)",
        "var": "Zille_Liberation_Success",
        "desc": "Prowincja Zille powróciła w granice Królestwa drogą militarnego triumfu. Sztandary Korony powiewają nad odzyskanymi miastami, a weterani kampanii witani są jak bohaterowie narodowi."
    },
    {
        "cat": "Economy",
        "name": "Situation_Economy_Brenas_Supply_Drain",
        "title": "Wojenny Drenaż Zasobów w Brenas",
        "sev": "Red (High)",
        "var": "Zille_Economy_BrenasDrain",
        "desc": "Koncentracja sił zbrojnych i transport materiałów wojennych paraliżują gospodarkę południa. Magazyny paliwowe i rezerwy dewizowe Korony kurczą się w zastraszającym tempie."
    },
    {
        "cat": "Economy",
        "name": "Situation_Economy_Sazon_Granary_Depots",
        "title": "Zaopatrzenie Kupieckie Rodu Sazon",
        "sev": "Green (Low)",
        "var": "Zille_Sazon_Logistics_Active",
        "desc": "Oparcie logistyki na sieci spichlerzy i transportu rzecznego Brenas pozwoliło ustabilizować wydatki państwa. Wojsko otrzymuje regularne racje bez grabieży lokalnych rolników."
    },
    {
        "cat": "Economy",
        "name": "Situation_Economy_Zille_Oil_Reclaimed",
        "title": "Naftowy Skarb Zille Odzyskany",
        "sev": "Green (Low)",
        "var": "Zille_Oil_Reclaimed",
        "desc": "Pola naftowe i rafinerie Zille pompują surowiec bezpośrednio do zbiorników Korony. Zniesienie narzutów tranzytowych Wehlen przynosi skarbcowi 3 punkty budżetu i 2 punkty energii rocznie."
    },
    {
        "cat": "Diplomacy",
        "name": "Situation_Diplomacy_AN_Zille_Aggression_Condemnation",
        "title": "Groźba Sankcji AN za Inwazję",
        "sev": "Red (High)",
        "var": "Zille_AN_Condemnation_Active",
        "desc": "Zgromadzenie Ogólne AN debatuje nad wnioskiem United Contana o objęcie Rizii międzynarodowym embargiem handlowym za użycie siły w sporze terytorialnym."
    },
    {
        "cat": "Diplomacy",
        "name": "Situation_Diplomacy_Lespia_ATO_Veto_Shield",
        "title": "Dyplomatyczna Tarcza Sojuszu z Lespią",
        "sev": "Green (Low)",
        "var": "Zille_LespiaPact_Signed",
        "desc": "Dzięki tajnemu paktowi z prezydentem Alvarezem, Lespia i Arcasia paraliżują wszelkie próby ukarania Rizii w Radzie Bezpieczeństwa AN. Dodatkowo Lespia dostarcza dane wywiadowcze o ruchach wroga."
    },
    {
        "cat": "Diplomacy",
        "name": "Situation_Diplomacy_CSP_Valgsland_Naval_Tension",
        "title": "Napięcie z Czerwoną Flotą Valgslandu",
        "sev": "Red (High)",
        "var": "Zille_Valgsland_Naval_Threat",
        "desc": "Chancellor Hegel rozkazał eskadrze pancerników Valgslandu patrolowanie wód u ujścia Zatoki Zille. Każde ostrzelanie statków neutralnych grozi otwartym starciem z flotą CSP."
    },
    {
        "cat": "Order",
        "name": "Situation_Order_House_Sazon_Brenas_Alarm",
        "title": "Panika i Wstrząs w Rodzie Sazon",
        "sev": "Red (High)",
        "var": "Zille_HouseSazon_Panic",
        "desc": "Zbliżenie się linii frontu do miast Brenas wywołało wściekłość księżnej Angeliki Sazon. Dworzanie z Sallabes oskarżają króla o narażenie ich ziem na pastwę wehzekich rajdów."
    },
    {
        "cat": "Order",
        "name": "Situation_Order_Refugee_Crisis_Southern_Border",
        "title": "Kryzys Uchodźczy na Granicy Brenas",
        "sev": "Yellow (Medium)",
        "var": "Zille_Refugee_Crisis",
        "desc": "Tysiące mieszkańców Zille ucieka przed walkami miejskimi na terytorium Rizii. Przygraniczne miasteczka pękają w szwach, wymagając interwencji Czerwonego Krzyża i dodatkowych funduszy socjalnych."
    }
]

for ns in new_situations:
    lines.append(f"### `[{ns['name']}]` — **{ns['title']}**")
    lines.append(f"- **Kategoria:** `{ns['cat']}` | **Stopień / Kolor w UI:** `{ns['sev']}`")
    lines.append(f"- **Flaga aktywująca (`IsEnabledVariable`):** `{ns['var']}`")
    lines.append(f"- **Opis w panelu:** *„{ns['desc']}”*")
    lines.append("")

with open(os.path.join(out_dir, "SITUATIONS_INDEX_DUMP.md"), "w", encoding="utf-8") as f:
    f.write("\n".join(lines))

print("Zapisano SITUATIONS_INDEX_DUMP.md!")
