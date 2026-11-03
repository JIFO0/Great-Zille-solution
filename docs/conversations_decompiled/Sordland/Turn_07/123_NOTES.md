# Sordland/Turn07/NOTES

- **ID konwersacji:** `123`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/123_NOTES.md`
- **Liczba węzłów dialogowych:** 50
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reform_AssemblyVote_LostBy1`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub`
- `BaseGameIsolated.Turn07_CourtResults_ReportsHub`
- `BaseGameIsolated.Turn07_CourtResults_SpeechHub`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_CourtResults_SpeechHub`

### Skoki między-konwersacyjne:
- Węzeł `[5]` -> **[117] Sordland/Turn07/PlayerHub** (../Turn_07/117_PlayerHub.md), Węzeł `[30]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 12
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_CourtResults_SpeechHub"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: ""I'll also start with a short speech.""]** — Mówca: **Player**
> ""I'll also start with a short speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""I'd like to finish the meeting with a speech.""]** — Mówca: **Player**
> ""I'd like to finish the meeting with a speech.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [PlayerAnnounceHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `117` (*Sordland/Turn07/PlayerHub*), Węzeł `[30]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_SpeechHub = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_SpeechHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true && BaseGameIsolated.Turn07_CourtResults_SpeechHub == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true && BaseGameIsolated.Turn07_CourtResults_SpeechHub == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_SpeechHub"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_CourtResults_ReportsHub == true && BaseGameIsolated.Turn07_CourtResults_PlansHub == true && BaseGameIsolated.Turn07_CourtResults_SpeechHub == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_CourtResults_ReportsHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub"] == true  and  Variable["BaseGameIsolated.Turn07_CourtResults_SpeechHub"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""We have reasons to believe that this was an organized effort which Mr. Soll himself was implicated in.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have worked long and hard but we couldn't reform the Sordish Constitution...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""The deep state has acted once more. Our proposal had gathered 166 votes, but was unlawfully rejected. The very parliament we control has stabbed us in the back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""Our organization was flawed. Our party was not united. The very parliament we control has denied us the reforms.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""Even though some people inside of us had hoped to see us fail at the Court... We did succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "The cabinet members looked at each other. Petr glanced at Nia and Ciara."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Narrator**
> "The cabinet members looked at each other and eventually set their eyes on Nia."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Petr Vectern**
> ""The Supreme Court blocked us once again. Unfortunately, some people within our team had also worked towards this goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have successfully made changes to the Sordish Constitution. This is a historic accomplishment. Without this team, it couldn't have been possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sadly and for reasons outside of our control, Sordland had plunged into violent terror in the beginning of our term. It became our duty to save Sordland. We all knew it was an emergency.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As we all know, the state of emergency that was declared against the chaos in the beginning of our term, is no longer in place.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sadly and for reasons outside of our control, Sordland had plunged into violent terror in the beginning of our term. It became our duty to save Sordland. We all knew it was an emergency.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Petr Vectern**
> ""The Supreme Court blocked us once again. Another stain on our democracy.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As we all know, the beginning of our term saw an extraordinary period of violence that led us to a state of emergency.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
