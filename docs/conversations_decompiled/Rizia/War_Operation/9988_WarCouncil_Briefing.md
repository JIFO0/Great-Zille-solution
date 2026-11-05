# Zille/WarCouncil_Briefing

- **ID konwersacji:** `9988`
- **StoryPack:** `Rizia`
- **Tura:** `Operacja Wojenna Zille (Mod: Great Zille Solution)`
- **Lokalizacja pliku:** `Rizia/War_Operation/9988_WarCouncil_Briefing.md`
- **Typ sceny:** `Królewska Narada Wojenna w Porte Drazon (Porte Drazon Palace - Council Chambers)`
- **Liczba węzłów dialogowych:** 28
- **Liczba wyborów gracza:** 12

> [!NOTE]
> Ta konwersacja jest w pełni natywnym modułem fabularnym moda **Great Zille Solution**, zarejestrowanym w silniku `PixelCrushers.DialogueSystem` oraz `EntityDataManager.AllConversationsData`. Dynamicznie odczytuje stan skarbca, energii, armii, sojuszy i relacji Romusa (w tym małżeństwa z Lucitą Azaro) przed autoryzacją inwazji.

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*
- **[68]** Hugo Toras *(Kanclerz / Finanse i Zaopatrzenie)*
- **[73]** Lucita Azaro *(Głównodowodząca Sił Zbrojnych / Prowincja Montaklar)*
- **[81]** Titus Gordion *(Dowódca Złotej Gwardii / Wywiad i Bezpieczeństwo)*
- **[70]** Laurento Esquibel *(Minister Spraw Zagranicznych / Dyplomacja)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne dynamiczne (Zapis Gry / Stan Królestwa):
- `RiziaDLC.Resources_Budget` — Poziom skarbca (rezerwy operacyjne vs pustki w budżecie)
- `RiziaDLC.Resources_Energy` — Bilans energetyczny (paliwo dla czołgów i floty)
- `RiziaDLC.Resources_Authority` — Autorytet Korony (kontrola nad arystokracją)
- `RiziaDLC.Resources_Manpower` — Rezerwy ludzkie armii
- `RiziaDLC.Resources_MilitaryEquipment` — Zapasy sprzętu wojskowego
- `RiziaDLC.PalesWar_Preparation_WarDeclared` / `RiziaDLC.Pales_War` — Wojna dwufrontowa z Pales
- `RiziaDLC.Zille_SuOmina_Funded` / `RiziaDLC.Zille_Resistance_Strength` — Aktywność partyzantki w Zille
- `RiziaDLC.Lucita_Married` / `RiziaDLC.Relations_Lucita_Together` — Małżeństwo i relacja z Lucitą Azaro
- `RiziaDLC.Diplomacy_Lespia_Allied` / `RiziaDLC.Lespia_Cooperation` — Postawa Lespii i paktu CSP

### Modyfikowane zmienne stanu (`userScript`):
- `Zille_War_Alfa` (`bool`) — Uruchomienie Planu Alfa (Frontalne natarcie na Zille)
- `Zille_War_Beta` (`bool`) — Uruchomienie Planu Beta (Uderzenie flankujące przez Wiktrany i Munat)
- `Zille_War_Postpone` (`bool`) — Wstrzymanie przygotowań wojennych

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

| Węzeł | Treść Wyboru Gracza | Kontekst Wejściowy | Wymagania (Warunki z Kodu) | Następstwa Skryptowe (`userScript`) | Cel / Odpowiedź |
|---|---|---|---|---|---|
| `[20]` | *"We have gathered here for one purpose: Zille will return to the Kingdom..."* | Węzeł `[12]` (Narrator) | *Brak (Dostępna bezwarunkowo)* | *Brak* | `[30]` Lucita Azaro |
| `[21]` | *"Smolak believes our caution is weakness. Today we prove him catastrophically wrong."* | Węzeł `[12]` (Narrator) | *Brak (Dostępna bezwarunkowo)* | *Brak* | `[30]` Lucita Azaro |
| `[22]` | *"Before any orders are signed, I require a candid appraisal from each of you..."* | Węzeł `[12]` (Narrator) | *Brak (Dostępna bezwarunkowo)* | *Brak* | `[30]` Lucita Azaro |
| `[40]` | *"War readiness & frontline: Lucita, assess Wehlen's defensive perimeter."* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna wielokrotnie w hubie)* | *Brak* | `[41]` Lucita Azaro (Raport taktyczny) |
| `[50]` | *"Economy & logistics: Hugo, will our treasury and energy withstand sustained combat?"* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna wielokrotnie w hubie)* | *Brak* | `[51]` Hugo Toras (Raport skarbu) |
| `[60]` | *"Foreign fallout: Laurento, how severely will Lespia and the CSP retaliate?"* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna wielokrotnie w hubie)* | *Brak* | `[61]` Laurento Esquibel (Raport dyplomacji) |
| `[70]` | *"Intelligence & resistance: Titus, what is the situation with Su Omina inside Zille?"* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna wielokrotnie w hubie)* | *Brak* | `[71]` Titus Gordion (Raport wywiadu) |
| `[80]` | *"I have heard enough counsel. Let us proceed to the operational doctrine."* | Węzeł `[35]` (Hub Pytań) | *Brak (Dostępna bezwarunkowo)* | *Brak* | `[81]` Lucita Azaro (Prezentacja doktryn) |
| `[90]` | **"Plan Alpha is authorized. Launch the direct frontal assault on Zille!"** | Węzeł `[83]` (Hub Doktryn) | *Brak (Wybór strategiczny gracza)* | `Variable["Zille_War_Alfa"] = true;` | `[91]` Lucita Azaro -> Spawnuje pion operacji Zille |
| `[93]` | **"Plan Beta is authorized. Sever Wiktrany and seize the deepwater port of Munat!"** | Węzeł `[83]` (Hub Doktryn) | *Brak (Wybór strategiczny gracza)* | `Variable["Zille_War_Beta"] = true;` | `[94]` Lucita Azaro -> Spawnuje pion operacji Zille |
| `[96]` | **"Hold the assault. We are not prepared for this campaign yet. Stand down."** | Węzeł `[83]` (Hub Doktryn) | *Brak (Wybór wstrzymania inwazji)* | `Variable["Zille_War_Postpone"] = true;` | `[97]` Hugo Toras -> Powrót na mapę cywilną |
| `[98]` | *"Let me reconsider our strategic posture before committing the realm."* | Węzeł `[83]` (Hub Doktryn) | *Brak (Powrót do pytań)* | *Brak* | `[35]` Hub Pytań Doradców |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]` — **[START / ROOT]**
- **Połączenia wychodzące:** -> `[10]`

### Węzeł `[10]` — Mówca: **Narrator**
> "The heavy oak doors of the Council Chamber closed shut, locking out the noise of Porte Drazon."
- **Połączenia wychodzące:** -> `[12]`

### Węzeł `[12]` — Mówca: **Narrator**
> "Across the long gilded mahogany table, the leaders of Rizia's destiny stood in solemn silence around the tactical maps of Zille."
- **Połączenia wychodzące (Wybór Gracza):** -> `[20]`, `[21]`, `[22]`

### Węzeł `[20]` — **[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "We have gathered here for one purpose: Zille will return to the Kingdom, by blood and iron if Smolak will not yield it by treaty."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** -> `[30]`

### Węzeł `[30]` — Mówca: **Lucita Azaro**
> "The Third and Fourth Armies stand ready along the border, Your Majesty. General Staff has prepared the offensive doctrines."
- **Połączenia wychodzące:** -> `[35]`

### Węzeł `[35]` — **[HUB STRATEGICZNY: DYSKUSJA Z DORADCAMI]**
- **Opcje gracza:** -> `[40]` (Wojsko), `[50]` (Finanse), `[60]` (Dyplomacja), `[70]` (Wywiad), `[80]` (Doktryny)

### Węzeł `[90]` — **[WYBÓR GRACZA: AUTORYZACJA PLANU ALFA]**
> "Plan Alpha is authorized. General Staff has my royal decree: launch the direct frontal assault on Zille!"
- **Wymagania odblokowania:** *Brak (Decyzja strategiczna gracza)*
- **Efekt skryptowy (`userScript`):** `Variable["Zille_War_Alfa"] = true;`
- **Połączenia wychodzące:** -> `[91]` (Lucita Azaro)

### Węzeł `[93]` — **[WYBÓR GRACZA: AUTORYZACJA PLANU BETA]**
> "Plan Beta is authorized. Encircle Zille from the north: sever Wiktrany and seize the deepwater port of Munat!"
- **Wymagania odblokowania:** *Brak (Decyzja strategiczna gracza)*
- **Efekt skryptowy (`userScript`):** `Variable["Zille_War_Beta"] = true;`
- **Połączenia wychodzące:** -> `[94]` (Lucita Azaro)

### Węzeł `[96]` — **[WYBÓR GRACZA: ODROCZENIE INWAZJI]**
> "Hold the assault. The realm cannot endure the strategic strain at this moment. Stand down."
- **Wymagania odblokowania:** *Brak (Decyzja strategiczna gracza)*
- **Efekt skryptowy (`userScript`):** `Variable["Zille_War_Postpone"] = true;`
- **Połączenia wychodzące:** -> `[97]` (Hugo Toras)
