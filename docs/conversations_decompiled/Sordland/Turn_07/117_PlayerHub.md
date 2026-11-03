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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[21]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] = true;`
- Węzeł `[43]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] = true;`
- Węzeł `[45]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[5]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Petr smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Mr. Vice President. Thank you for the opening.""]** — Mówca: **Player**
> ""Mr. Vice President. Thank you for the opening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[5]`
Mówca: **Narrator**
> "He sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[7]`
  - -> `[8]`
  - -> `[6]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "Clap."]** — Mówca: **Player_Italic**
> "I clapped after Petr's speech, which made everyone join in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Thank you Petr.""]** — Mówca: **Player**
> ""Thank you, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Alright. Let's start the meeting.""]** — Mówca: **Player**
> ""Alright. Let's start the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Everyone's eyes were focused on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[16]`
  - -> `[11]`
  - -> `[12]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""First, I'll make an important announcement. I have decided to form an alliance with the PFJP.""]** — Mówca: **Player**
> ""First, I'll make an important announcement. I have decided to form an alliance with the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `118` (*Sordland/Turn07/AnnounceAlliance*), Węzeł `[1]`

### Węzeł `[11]`
**[WYBÓR GRACZA: ""First, I want to hear brief reports from each ministry.""]** — Mówca: **Player**
> ""First, I want to hear brief reports from each ministry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `119` (*Sordland/Turn07/MinistryReports*), Węzeł `[1]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""First, I want to talk about our new focus and some of my plans going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[1]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
**[WYBÓR GRACZA: ""First, I'll make an important announcement. I have decided to form an alliance with the NFP.""]** — Mówca: **Player**
> ""First, I'll make an important announcement. I have decided to form an alliance with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `118` (*Sordland/Turn07/AnnounceAlliance*), Węzeł `[1]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [PlayerAnnounceHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_AllianceHub = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Kesaro_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Next, I'll make an important announcement. I have decided to form an alliance with the PFJP.""]** — Mówca: **Player**
> ""Next, I'll make an important announcement. I have decided to form an alliance with the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `118` (*Sordland/Turn07/AnnounceAlliance*), Węzeł `[1]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Alliance == true && BaseGameIsolated.Turn07_CourtResults_AllianceHub == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_AllianceHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[29]`
**[WYBÓR GRACZA: ""Next, I'll make an important announcement. I have decided to form an alliance with the NFP.""]** — Mówca: **Player**
> ""Next, I'll make an important announcement. I have decided to form an alliance with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `118` (*Sordland/Turn07/AnnounceAlliance*), Węzeł `[1]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayerAnnounceHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[22]`
  - -> `[31]`
  - -> `[35]`
  - -> `[39]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_ReportsHub == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_ReportsHub == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Next, I want to hear brief reports from each ministry.""]** — Mówca: **Player**
> ""Next, I want to hear brief reports from each ministry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `119` (*Sordland/Turn07/MinistryReports*), Węzeł `[1]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_PlansHub == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_PlansHub == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_CourtResults_PlansHub == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Hmm, I believe that is everything.""]** — Mówca: **Player**
> ""Hmm, I believe that is everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Next, I want to talk about our new focus and some of my plans going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[1]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_ReportsHub = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [PlayerAnnounceHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_PlansHub = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [PlayerAnnounceHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
