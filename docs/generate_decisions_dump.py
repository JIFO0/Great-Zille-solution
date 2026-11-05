import json
import os

out_dir = r"docs\dumps"
os.makedirs(out_dir, exist_ok=True)

# 1. GENEROWANIE DECISIONS_EVENT_SYSTEM_DUMP.md
print("Generowanie DECISIONS_EVENT_SYSTEM_DUMP.md...")
with open("docs/raw_database_dumps/DecisionData.json", "r", encoding="utf-8") as f:
    dec_data = json.load(f)

r_dec = [it for it in dec_data["items"] if "Rizia" in it.get("Path", "")]
turn_dec = [it for it in r_dec if it.get("NameInDatabase", "").startswith("Turn")]
floating_dec = [it for it in r_dec if not it.get("NameInDatabase", "").startswith("Turn")]

lines = []
lines.append("# The Great Zille Solution: Dump i Architektura Systemu Eventów / Decyzji (DecisionData)")
lines.append("")
lines.append("*Oficjalny zrzut struktury decyzji z silnika gry Suzerain: Kingdom of Rizia oraz specyfikacja nowych i modyfikowanych eventów wojennych.*")
lines.append("")
lines.append("## 1. Architektura Systemu Decyzji w Silniku Suzeraina")
lines.append("")
lines.append("W grze *Suzerain* 'Decyzje' (`DecisionData`) to interaktywne pop-upy / karty wyboru pojawiające się na mapie lub w trakcie kroków tury (`Steps`).")
lines.append("Każda decyzja składa się z:")
lines.append("- **Tytułu i Opisu:** Prezentują dylemat fabularno-polityczny.")
lines.append("- **Opcji / Przycisków (`Options`):** Zestaw guzików do kliknięcia przez gracza.")
lines.append("- **Warunków Odblokowania (`Condition`):** Sprawdzają zasoby (`Budget`, `Energy`, `Authority`) lub flagi fabularne.")
lines.append("- **Instrukcji / Skutków (`Instruction`):** Modyfikują zmienne państwa, relacje rodów, odpalają raporty (`EnableReport`) i wiadomości w prasie (`EnableNews`).")
lines.append("")
lines.append("### Statystyki Bazy Decyzji DLC Rizia:")
lines.append(f"- **Łączna liczba decyzji w Rizia:** `{len(r_dec)}`")
lines.append(f"  - **Decyzje Turowe (`Turn-based`):** `{len(turn_dec)}` (powiązane ściśle z krokami gry)")
lines.append(f"  - **Decyzje Pływające (`Floating / Situation-based`):** `{len(floating_dec)}` (pojawiające się w reakcji na kryzysy)")
lines.append("")
lines.append("---")
lines.append("")
lines.append("## 2. Katalog Oficjalnych Decyzji Rizia (Zestawienie Turn-by-Turn)")
lines.append("")

by_turn = {}
for it in turn_dec:
    name = it.get("NameInDatabase", "")
    t_prefix = name[:6]
    by_turn.setdefault(t_prefix, []).append(it)

for t in sorted(by_turn.keys()):
    t_num = int(t.replace("Turn0", "").replace("Turn", ""))
    lines.append(f"### Tura {t_num:02d} ({len(by_turn[t])} decyzji)")
    lines.append("")
    lines.append("| ID w Bazie | Tytuł Decyzji | Liczba Opcji | Podsumowanie Dylematu |")
    lines.append("|---|---|---|---|")
    for d in by_turn[t]:
        dp = d.get("DecisionProperties", {})
        title = dp.get("Title", "Bez Tytułu")
        opts_count = len(dp.get("Options", []))
        desc = dp.get("Description", "").replace("\n", " ").strip()
        if len(desc) > 90:
            desc = desc[:87] + "..."
        lines.append(f"| `{d.get('NameInDatabase')}` | **{title}** | {opts_count} | {desc} |")
    lines.append("")

lines.append("---")
lines.append("")
lines.append("## 3. Nowe i Modyfikowane Eventy / Decyzje Modu „The Great Zille Solution”")
lines.append("")
lines.append("Modyfikacja wprowadza pakiet decyzji operacyjnych, mobilizacyjnych oraz **kluczowych decyzji po zdobyciu poszczególnych miast i węzłów na froncie**.")
lines.append("")

new_decisions = [
    {
        "id": "Turn04_Decision_Zille_Mobilization_Decree",
        "title": "Nadzwyczajny Pobór w Prowincji Brenas",
        "timing": "Tura 4 (Wariant A) / Tura 8 (Wariant B)",
        "desc": "W związku z rozpoczęciem operacji w Zille, Sztab Generalny przedkłada wniosek o zarządzenie mobilizacji rezerwistów w południowych okręgach.",
        "options": [
            {
                "text": "Mobilizacja Powszechna z funduszy Korony [-2 Budget, +2 Manpower, -1 Opinion]",
                "cond": "RiziaDLC.Resources_Budget >= 2",
                "out": "Zwiększenie rezerw ludzkich, spadek nastrojów wśród chłopstwa Brenas."
            },
            {
                "text": "Pobór Selektywny z rezerw Rodu Azaro [+1 Azaro Levy, +1 HouseAzaro_Opinion]",
                "cond": "",
                "out": "Zacieśnienie sojuszu z Azaro, wzmocnienie szpicy uderzeniowej."
            },
            {
                "text": "Odrzucić pobór i oprzeć się wyłącznie na zawodowej armii [+1 Authority]",
                "cond": "",
                "out": "Ograniczone siły na froncie, ale brak niezadowolenia społecznego."
            }
        ]
    },
    {
        "id": "War_Decision_Capture_Nanta",
        "title": "Wyzwolenie Nanty: Los Magazynów Naftowych Wehlen",
        "timing": "Po zdobyciu prowincji Nanta (Wschód Półwyspu)",
        "desc": "Nasze oddziały wyparły garnizon Wehlen z Nanty. Zdobyto nienaruszone składy paliwowe oraz instalacje przepompowe.",
        "options": [
            {
                "text": "Przekazać paliwo dywizjom pancernym Azaro na natychmiastowe natarcie [+1 AP w następnej turze, -1 Zille_Destruction]",
                "cond": "",
                "out": "Zwiększenie tempa natarcia w kierunku Wiktrany."
            },
            {
                "text": "Zabezpieczyć ropę i przetransportować do magazynów Korony [+2 Energy, +1 Budget]",
                "cond": "",
                "out": "Zasilenie skarbca państwowego kosztem tempa operacji."
            },
            {
                "text": "Rozdzielić paliwo i zapasy wśród wyzwolonej ludności cywilnej [+2 PublicOpinion, +1 Authority]",
                "cond": "",
                "out": "Wzrost poparcia mieszkańców Zille dla monarchii."
            }
        ]
    },
    {
        "id": "War_Decision_Capture_Wiktrany",
        "title": "Zajęcie Węzła Wiktrany: Blokada Kolejowa",
        "timing": "Po zdobyciu centralnego węzła Wiktrany",
        "desc": "Centralny węzeł komunikacyjny Wiktrany został odcięty. Wehzekie linie zaopatrzeniowe z północy zostały przerwane. W ręce Rizii wpadły archiwa Wehzek Secret Police.",
        "options": [
            {
                "text": "Wysadzić wiadukty i zaryglować garnizon Zille w kotle [Wróg traci 2 punkty zaopatrzenia]",
                "cond": "",
                "out": "Paraliż garnizonu Zille, zniszczenie infrastruktury regionalnej."
            },
            {
                "text": "Uruchomić pociągi pancerne i uderzyć na Port Munat [Plan Beta: Odblokowanie natarcia na północ]",
                "cond": "RiziaDLC.Resources_Energy >= 1",
                "out": "Oskrzydlenie wroga i przygotowanie do desantu morskiego."
            },
            {
                "text": "Opublikować archiwa zbrodni Smolaka w Zille [+2 AN_Diplomatic_Support, +1 Authority]",
                "cond": "",
                "out": "Międzynarodowa tarcza dyplomatyczna przeciwko sankcjom CSP."
            }
        ]
    },
    {
        "id": "War_Decision_Capture_Munat",
        "title": "Zdobycie Portu Munat: Odcięcie Wehlen od Morza",
        "timing": "Po opanowaniu portu Munat",
        "desc": "Głęboki port morski Munat jest pod kontrolą Królewskiej Marynarki Wojennej. Wehzekie statki transportowe zostały internowane.",
        "options": [
            {
                "text": "Zezwolić statkom Lespii i Arcasii na bezcłowy rozładunek zaopatrzenia [+2 Budget, Odblokowanie Desantu ATO]",
                "cond": "RiziaDLC.Diplomacy_Lespia_Allied == true",
                "out": "Pełna integracja z Lespią, gniew Valgslandu."
            },
            {
                "text": "Ustanowić bazę Królewskiej Marynarki i ogłosić strefę blokady morskiej [+1 Naval_Superiority, -1 Energy]",
                "cond": "RiziaDLC.Resources_Energy >= 1",
                "out": "Całkowite odcięcie posiłków dla Smolaka."
            },
            {
                "text": "Zezwolić flocie handlowej CSP na bezpieczną ewakuację pod banderą neutralną [+1 Valgsland_Opinion]",
                "cond": "",
                "out": "Złagodzenie napięć z Chancellorem Hegelem."
            }
        ]
    },
    {
        "id": "War_Decision_Liberation_Zille_City",
        "title": "Triumf w Mieście Zille: Kwestia Kolaborantów i Rafinerii",
        "timing": "Po zdobyciu stolicy Zille",
        "desc": "Sztandar Domu Torasów powiewa nad ratuszem Zille. Wehzekie posterunki skapitulowały. Pozostaje kwestia aparatu kolaboracyjnego i zaminowanych szybów.",
        "options": [
            {
                "text": "Amnestia dla urzędników i natychmiastowe uruchomienie wydobycia [+3 Budget, +2 Energy, -1 HouseToras_Opinion]",
                "cond": "",
                "out": "Błyskawiczny zysk ekonomiczny, gniew rojalistycznych twardogłowych."
            },
            {
                "text": "Trybunał wojenny i publiczne procesy kolaborantów Smolaka [+2 Authority, +2 HouseAzaro_Opinion]",
                "cond": "",
                "out": "Satysfakcja wojskowych, ryzyko partyzantki podziemnej."
            },
            {
                "text": "Przekazać administrację tymczasową Radzie Miejskiej Zille [+2 Democratic_Leaning, +2 PublicOpinion]",
                "cond": "",
                "out": "Uspokojenie nastrojów demokratycznych, poparcie Manusa Sazona."
            }
        ]
    },
    {
        "id": "War_Decision_Brenas_Border_Breach",
        "title": "Przełamanie Pod Marbelas: Reakcja na Kontratak Wehlen",
        "timing": "Gdy Wehlen przeprowadza kontratak na miasta Brenas",
        "desc": "Wehzekie kolumny zmechanizowane przekroczyły granicę Brenas i zagrażają Marbelas. Ród Sazonów błaga o natychmiastową odsiecz.",
        "options": [
            {
                "text": "Przekierować Złotą Gwardię Titusa do obrony Marbelas [Ocalenie Brenas, spowolnienie ofensywy w Zille]",
                "cond": "",
                "out": "Brenas obronione, utrata impetu natarcia na Zille."
            },
            {
                "text": "Ignorować dywersję i przeć całą siłą na Zille [Ryzyko utraty Marbelas, ale zdobycie stolicy wroga]",
                "cond": "",
                "out": "Wysokie ryzyko buntu Sazonów, ale szansa na natychmiastowe zakończenie wojny."
            },
            {
                "text": "Sformować milicję chłopską pod wodzą Manusa Sazona [-1 Budget, +1 Sazon_Levy]",
                "cond": "RiziaDLC.Resources_Budget >= 1",
                "out": "Obrona lokalna kosztem wydatków państwowych."
            }
        ]
    }
]

for nd in new_decisions:
    lines.append(f"### `{nd['id']}` — **{nd['title']}**")
    lines.append(f"- **Timing / Trigger:** `{nd['timing']}`")
    lines.append(f"- **Opis dylematu:** *„{nd['desc']}”*")
    lines.append("- **Opcje wyboru gracza:**")
    for opt in nd["options"]:
        cond_str = f" *(Wymóg: `{opt['cond']}`)*" if opt["cond"] else " *(Bezwarunkowa)*"
        lines.append(f"  - **Guzik:** `{opt['text']}`{cond_str}")
        lines.append(f"    - *Skutek:* {opt['out']}")
    lines.append("")

with open(os.path.join(out_dir, "DECISIONS_EVENT_SYSTEM_DUMP.md"), "w", encoding="utf-8") as f:
    f.write("\n".join(lines))

print("Zapisano DECISIONS_EVENT_SYSTEM_DUMP.md!")
