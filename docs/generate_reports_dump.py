import json
import os

out_dir = r"docs\dumps"
os.makedirs(out_dir, exist_ok=True)

print("Generowanie REPORTS_SYSTEM_DUMP.md...")
with open("docs/raw_database_dumps/ReportData.json", "r", encoding="utf-8") as f:
    rep_data = json.load(f)

r_rep = [it for it in rep_data["items"] if "Rizia" in it.get("Path", "")]

by_token = {}
for it in r_rep:
    tok = it.get("AssignedTokenProperties", {}).get("AssignedToken", "Unassigned")
    by_token.setdefault(tok, []).append(it)

lines = []
lines.append("# The Great Zille Solution: Dump i Architektura Systemu Raportów (ReportData)")
lines.append("")
lines.append("*Oficjalny zrzut struktury raportów mapowych z silnika gry Suzerain: Kingdom of Rizia oraz specyfikacja nowych raportów wojennych.*")
lines.append("")
lines.append("## 1. Architektura Raportów w Grze Suzerain: Gdzie, Kiedy i Dlaczego?")
lines.append("")
lines.append("W grze *Suzerain* 'Raporty' (`ReportData`) to interaktywne notatki wywiadowcze, wojskowe i administracyjne przypięte do konkretnych punktów na mapie świata.")
lines.append("")
lines.append("### Trzy Fundamenty Raportu:")
lines.append("1. **GDZIE (Map Token):** Raport jest zawsze powiązany z fizycznym tokenem na mapie (`AssignedTokenProperties.AssignedToken`), np.:")
lines.append("   - Miasta stołeczne i prowincjonalne: `Rizia_City_PorteDrazon`, `Rizia_City_Montaklar`, `Rizia_City_Sallabes`, `Rizia_City_Zille`, `Rizia_City_Nanta`, `Rizia_City_MaveNortus`.")
lines.append("   - Państwa ościenne: `Rizia_Country_Wehlen`, `Rizia_Country_Lespia`, `Rizia_Country_Derdia`, `Rizia_Country_Morella`.")
lines.append("   - Teatry operacyjne i sojusze: `Rizia_Event_Zille`, `Rizia_Event_InvasionOfPales`, `Rizia_Faction_Event_CSP`, `Rizia_Faction_Event_ATO`.")
lines.append("2. **KIEDY (Timing & Triggers):**")
lines.append("   - W określonym kroku tury (`TurnNo` lub zdefiniowany krok w `GameFlow`).")
lines.append("   - W wyniku decyzji gracza (poprzez funkcję `EnableReport(\"Report_ID\")` wywoływaną w instrukcji `Instruction`).")
lines.append("   - W rezultacie bitwy wojennej (`Operation_1_Result_Won` / `Lost`).")
lines.append("3. **DLACZEGO (Kontekst Fabularny):**")
lines.append("   - Informuje gracza o bezpośrednich konsekwencjach jego wyborów na prowincji.")
lines.append("   - Buduje realizm świata i prezentuje perspektywę lokalnych dowódców, burmistrzów i szpiegów.")
lines.append("")
lines.append(f"### Statystyki Bazy Raportów DLC Rizia: `{len(r_rep)}` raportów na `{len(by_token)}` unikalnych tokenach mapy")
lines.append("")
lines.append("---")
lines.append("")
lines.append("## 2. Zestawienie Raportów Vanilla Według Tokenów Mapy")
lines.append("")

for tok in sorted(by_token.keys(), key=lambda t: len(by_token[t]), reverse=True):
    tok_clean = tok.replace("Rizia_", "").replace("City_", "Miasto: ").replace("Country_", "Państwo: ").replace("Event_", "Wydarzenie: ").replace("Faction_Event_", "Sojusz: ")
    lines.append(f"### Token: `{tok}` — {tok_clean} ({len(by_token[tok])} raportów)")
    lines.append("")
    lines.append("| ID w Bazie | Tytuł Raportu | Tura (`TurnNo`) | Krótka Treść Raportu |")
    lines.append("|---|---|---|---|")
    for r in by_token[tok][:8]: # top 8 na token
        rp = r.get("ReportProperties", {})
        title = rp.get("Title", "Bez Tytułu")
        turn = rp.get("TurnNo", -1)
        turn_str = f"Tura {turn}" if turn > 0 else "Trigger z Kodu / Decyzji"
        desc = rp.get("Description", "").replace("\n", " ").strip()
        if len(desc) > 85:
            desc = desc[:82] + "..."
        lines.append(f"| `{r.get('NameInDatabase')}` | **{title}** | {turn_str} | {desc} |")
    if len(by_token[tok]) > 8:
        lines.append(f"| *...* | *Kolejne {len(by_token[tok]) - 8} raportów* | *...* | *...* |")
    lines.append("")

lines.append("---")
lines.append("")
lines.append("## 3. Nowe i Modyfikowane Raporty Wojenne Modu „Great Zille Solution”")
lines.append("")
lines.append("Modyfikacja wstrzykuje raporty taktyczne, wywiadowcze i prowincjonalne reagujące na przebieg inwazji:")
lines.append("")

new_reports = [
    {
        "id": "War_Report_Nanta_Captured",
        "title": "Szpica Pancerna Azaro Zdobywa Nantę",
        "token": "Rizia_City_Nanta",
        "timing": "Po wygranej bitwie o kafelki Nanty",
        "why": "Informuje o przełamaniu wschodniego skrzydła obrony Wehlen i zabezpieczeniu magazynów paliwowych.",
        "desc": "3. Dywizja Pancerna Montaklar po sześciogodzinnym pojedynku artyleryjskim przełamała obronę posterunków granicznych w Nancie. Wehzekie oddziały wycofały się w stronę węzła Wiktrany, pozostawiając nienaruszone instalacje naftowe i składy amunicji. Flaga Korony powiewa nad ratuszem."
    },
    {
        "id": "War_Report_Wiktrany_Junction_Severed",
        "title": "Węzeł Komunikacyjny Wiktrany Odcięty",
        "token": "Rizia_City_Zille",
        "timing": "Po zdobyciu centralnego węzła Wiktrany",
        "why": "Oznacza strategiczne odcięcie garnizonu miasta Zille od dostaw posiłków z terytorium Wehlen.",
        "desc": "Królewscy saperzy zabezpieczyli centralną stację rozrządową i mosty na rzece Wiktrany. Główna magistrala kolejowa łącząca Wehlen z Półwyspem Zille została przecięta. W mieście Wiktrany zlikwidowano placówkę Wehzek Secret Police, uwalniając ponad dwustu uwięzionych rojalistów."
    },
    {
        "id": "War_Report_Munat_Docks_Secured",
        "title": "Port Munat pod Kontrolą Królewskiej Marynarki",
        "token": "Rizia_City_Zille",
        "timing": "Po zdobyciu portu Munat (Plan Beta / Desant)",
        "why": "Potwierdza zablokowanie morskich dróg zaopatrzeniowych Smolaka i otwarcie portu dla statków sojuszniczych.",
        "desc": "Połączony atak piechoty morskiej i jednostek desantowych doprowadził do kapitulacji garnizonu portowego w Munat. Trzy uzbrojone kutry Wehlen zostały internowane. Port jest gotowy na przyjęcie konwojów logistycznych z zaopatrzeniem i ciężką amunicją z Arcasii i Lespii."
    },
    {
        "id": "War_Report_Zille_Citadel_Liberated",
        "title": "Wyzwolenie Zille: Miasto Wraca do Korony",
        "token": "Rizia_City_Zille",
        "timing": "Po zdobyciu stolicy Zille",
        "why": "Oznacza ostateczne militarne złamanie okupacji i spełnienie celu wojennego Korony.",
        "desc": "Tłumy mieszkańców Zille wyległy na ulice, zasypując kwiatami czołgi Złotej Gwardii i pułków Azaro. Po dwudziestu ośmiu latach obcej okupacji, z gmachu prefektury zerwano flagi Wehlen. Generał Wehzek Guards podpisał akt kapitulacji garnizonu miejskiego."
    },
    {
        "id": "War_Report_Brenas_Marbelas_Under_Shelling",
        "title": "Ostrzał Artyleryjski Marbelas przez Siły Wehlen",
        "token": "Rizia_City_MaveNortus",
        "timing": "Gdy Wehlen uruchamia kontrnastawienie artyleryjskie",
        "why": "Alarmuje gracza o zagrożeniu włości rodu Sazonów i stratach wśród ludności cywilnej.",
        "desc": "Ciężkie haubice Wehlen ostrzelały przedmieścia Marbelas i składy zbożowe. Burmistrz miasta ogłosił ewakuację do Sallabes. Księżna Angelica Sazon wystosowała pilny telegram do Rady Królewskiej, domagając się natychmiastowej osłony przeciwbateryjnej."
    },
    {
        "id": "War_Report_PortRotsla_Raid_Success",
        "title": "Rajd Torpedowy na Port Rotsla",
        "token": "Rizia_Country_Wehlen",
        "timing": "W Wariancie 5 (Triumf Totalny) po uderzeniu na terytorium wroga",
        "why": "Wyjaśnia panikę w rządzie Smolaka i zmusza go do bezwarunkowych reparacji wojennych.",
        "desc": "Królewskie kutry torpedowe i bombowce dokonały bezprecedensowego uderzenia na bazę morską Port Rotsla na rdzennym terytorium Wehlen. Dwa zbiornikowce paliwowe oraz wehzekie doki remontowe stanęły w ogniu. Prezydent Smolak opuścił stolicę, udając się do bunkra w interiorze."
    },
    {
        "id": "War_Report_Lespia_Radar_Intel_Received",
        "title": "Satelitarne Dane Rozpoznawcze z Lespii",
        "token": "Rizia_Country_Lespia",
        "timing": "W Turze 5/8 po ratyfikacji Paktu z Alvarezem",
        "why": "Przekazuje graczowi odblokowanie bonusów celnościowych i wsparcia spadochronowego.",
        "desc": "Królewski ataszat wojskowy w Lachaven odebrał zaszyfrowane taśmy z arcasiańskich samolotów szpiegowskich U-2 operujących z Lespii. Zdjęcia ujawniły dokładne współrzędne zamaskowanych baterii rakietowych Smolaka pod Zille, dając naszej artylerii pełną przewagę celności."
    },
    {
        "id": "War_Report_Derdia_Volunteers_Cross_Yol",
        "title": "Oddziały Bojowników Nurystów Przekraczają Przełęcz Yol",
        "token": "Rizia_Country_Derdia",
        "timing": "Po zawarciu porozumienia wojskowego z Wisemanem Azmalem",
        "why": "Informuje o otwarciu zachodniego wektora dywersyjnego wiążącego rezerwy Wehlen.",
        "desc": "Około tysiąca uzbrojonych ochotników golcondyjskich pod zielonymi sztandarami Nur wkroczyło na pustynne szlaki południowo-zachodniego Wehlen. Partyzanci zaatakowali konwoje zaopatrzeniowe wroga zmierzające do Zille, zmuszając Smolaka do wycofania dwóch pułków z linii frontu."
    }
]

for nr in new_reports:
    lines.append(f"### `[{nr['id']}]` — **{nr['title']}**")
    lines.append(f"- **Token na Mapie (`AssignedToken`):** `{nr['token']}`")
    lines.append(f"- **Kiedy się pojawia (`Timing`):** {nr['timing']}")
    lines.append(f"- **Dlaczego (`Warunek i Cel`):** {nr['why']}")
    lines.append(f"- **Treść raportu:** *„{nr['desc']}”*")
    lines.append("")

with open(os.path.join(out_dir, "REPORTS_SYSTEM_DUMP.md"), "w", encoding="utf-8") as f:
    f.write("\n".join(lines))

print("Zapisano REPORTS_SYSTEM_DUMP.md!")
