# Sordland/Turn07/PlayerHub

- **ID konwersacji:** `117`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/117_PlayerHub.md`
- **Liczba węzłów dialogowych:** 47
- **Liczba wyborów gracza:** 13

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Frens_Promise_Alliance`
- `BaseGame.Relations_Kesaro_Promise_Alliance`
- `BaseGameIsolated.Turn07_CourtResults_AllianceHub`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub`
- `BaseGameIsolated.Turn07_CourtResults_ReportsHub`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_CourtResults_AllianceHub`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub`
- `BaseGameIsolated.Turn07_CourtResults_ReportsHub`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[5]`
- Węzeł `[10]` -> **[118] Sordland/Turn07/AnnounceAlliance** (../Turn_07/118_AnnounceAlliance.md), Węzeł `[1]`
- Węzeł `[11]` -> **[119] Sordland/Turn07/MinistryReports** (../Turn_07/119_MinistryReports.md), Węzeł `[1]`
- Węzeł `[12]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[1]`
- Węzeł `[19]` -> **[118] Sordland/Turn07/AnnounceAlliance** (../Turn_07/118_AnnounceAlliance.md), Węzeł `[1]`
- Węzeł `[25]` -> **[118] Sordland/Turn07/AnnounceAlliance** (../Turn_07/118_AnnounceAlliance.md), Węzeł `[1]`
- Węzeł `[29]` -> **[118] Sordland/Turn07/AnnounceAlliance** (../Turn_07/118_AnnounceAlliance.md), Węzeł `[1]`
- Węzeł `[34]` -> **[119] Sordland/Turn07/MinistryReports** (../Turn_07/119_MinistryReports.md), Węzeł `[1]`
- Węzeł `[42]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Mr. Vice President. Thank you for the opening.""** | `[3]` **Narrator**: "Petr smiled."<br>`[5]` **Narrator**: "He sat down." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "Everyone's eyes were focused on me." |
| `[6]` | **"Clap."** | `[5]` **Narrator**: "He sat down." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Petr smiled." |
| `[7]` | **""Thank you Petr.""** | `[3]` **Narrator**: "Petr smiled."<br>`[5]` **Narrator**: "He sat down." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "Everyone's eyes were focused on me." |
| `[8]` | **""Alright. Let's start the meeting.""** | `[3]` **Narrator**: "Petr smiled."<br>`[5]` **Narrator**: "He sat down." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "Everyone's eyes were focused on me." |
| `[10]` | **""First, I'll make an important announcement. I have decided to form an alliance wi..."** | `[9]` **Narrator**: "Everyone's eyes were focused on me." | `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false` | *Brak zmian stanu* | `[5]` **Narrator**: "He sat down." |
| `[11]` | **""First, I want to hear brief reports from each ministry.""** | `[9]` **Narrator**: "Everyone's eyes were focused on me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "He sat down." |
| `[12]` | **""First, I want to talk about our new focus and some of my plans going forward.""** | `[9]` **Narrator**: "Everyone's eyes were focused on me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "He sat down." |
| `[19]` | **""First, I'll make an important announcement. I have decided to form an alliance wi..."** | `[9]` **Narrator**: "Everyone's eyes were focused on me." | `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false` | *Brak zmian stanu* | `[5]` **Narrator**: "He sat down." |
| `[25]` | **""Next, I'll make an important announcement. I have decided to form an alliance wit..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "He sat down." |
| `[29]` | **""Next, I'll make an important announcement. I have decided to form an alliance wit..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "He sat down." |
| `[34]` | **""Next, I want to hear brief reports from each ministry.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "He sat down." |
| `[38]` | **""Hmm, I believe that is everything.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[42]` | **""Next, I want to talk about our new focus and some of my plans going forward.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "He sat down." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He sat down."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He sat down."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Petr smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Mr. Vice President. Thank you for the opening.""*)
  - -> `[7]` (*Player: ""Thank you Petr.""*)
  - -> `[8]` (*Player: ""Alright. Let's start the meeting.""*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Mr. Vice President. Thank you for the opening.""]** — Mówca: **Player**
> ""Mr. Vice President. Thank you for the opening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Everyone's eyes were focused on me."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "He sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Mr. Vice President. Thank you for the opening.""*)
  - -> `[7]` (*Player: ""Thank you Petr.""*)
  - -> `[8]` (*Player: ""Alright. Let's start the meeting.""*)
  - -> `[6]` (*Player_Italic: "Clap."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "Clap."]** — Mówca: **Player_Italic**
> "I clapped after Petr's speech, which made everyone join in."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Petr smiled."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Thank you Petr.""]** — Mówca: **Player**
> ""Thank you, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Everyone's eyes were focused on me."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Alright. Let's start the meeting.""]** — Mówca: **Player**
> ""Alright. Let's start the meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator), `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Everyone's eyes were focused on me."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Everyone's eyes were focused on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true && Base..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance == true && Bas..."*)
  - -> `[11]` (*Player: ""First, I want to hear brief reports from each ministry.""*)
  - -> `[12]` (*Player: ""First, I want to talk about our new focus and some of my..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""First, I'll make an important announcement. I have decided to form an alliance with the PFJP.""]** — Mówca: **Player**
> ""First, I'll make an important announcement. I have decided to form an alliance with the PFJP.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""First, I want to hear brief reports from each ministry.""]** — Mówca: **Player**
> ""First, I want to hear brief reports from each ministry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""First, I want to talk about our new focus and some of my plans going forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true && Base..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Alliance == true && Ba..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""First, I'll make an important announcement. I have decid..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance == true && Bas..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Kesaro_Promise_Alliance == true && B..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""First, I'll make an important announcement. I have decid..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
**[WYBÓR GRACZA: ""First, I'll make an important announcement. I have decided to form an alliance with the NFP.""]** — Mówca: **Player**
> ""First, I'll make an important announcement. I have decided to form an alliance with the NFP.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PlayerAnnounceHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "PlayerAnnounceHub"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_AllianceHub = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "Jump to: [PlayerAnnounceHub]"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance == true && Bas..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Kesaro_Promise_Alliance == true && B..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: ""Next, I'll make an important announcement. I have decide..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Next, I'll make an important announcement. I have decided to form an alliance with the PFJP.""]** — Mówca: **Player**
> ""Next, I'll make an important announcement. I have decided to form an alliance with the PFJP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true && Base..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Alliance == true && Ba..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""Next, I'll make an important announcement. I have decide..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[29]`
**[WYBÓR GRACZA: ""Next, I'll make an important announcement. I have decided to form an alliance with the NFP.""]** — Mówca: **Player**
> ""Next, I'll make an important announcement. I have decided to form an alliance with the NFP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayerAnnounceHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true && Base..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance == true && Bas..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_CourtResults_ReportsHub == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_CourtResults_PlansHub == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_CourtResults_ReportsHub == true &..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_ReportsHub == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_CourtResults_ReportsHub == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_ReportsHub == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Next, I want to hear brief reports from each ministry.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Next, I want to hear brief reports from each ministry.""]** — Mówca: **Player**
> ""Next, I want to hear brief reports from each ministry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_PlansHub == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_CourtResults_PlansHub == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_CourtResults_PlansHub == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_PlansHub == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_CourtResults_PlansHub == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Next, I want to talk about our new focus and some of my ..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Hmm, I believe that is everything.""]** — Mówca: **Player**
> ""Hmm, I believe that is everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_CourtResults_ReportsHub == true &..."*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""Hmm, I believe that is everything.""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Next, I want to talk about our new focus and some of my plans going forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_ReportsHub = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "Jump to: [PlayerAnnounceHub]"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PlayerAnnounceHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "PlayerAnnounceHub"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_CourtResults_PlansHub = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "Jump to: [PlayerAnnounceHub]"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PlayerAnnounceHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "PlayerAnnounceHub"*)
