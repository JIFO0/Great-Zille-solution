# Rizia/Turn 10/ExecutionDecisions

- **ID konwersacji:** `334`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/334_ExecutionDecisions.md`
- **Liczba węzłów dialogowych:** 18
- **Liczba wyborów gracza:** 3

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[93]** Player_Romus_Italic *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCSupport.Journal_Turn10_ExecutionDecisions_NoOne`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[8]` (Paskal Beniwoll): `ShowPagedDecisionsPanel("Panel_Executions");`
- Węzeł `[12]` (Paskal Beniwoll): `End();`
- Węzeł `[15]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn10_ExecutionDecisions_NoOne"] = true;`
- Węzeł `[16]` (Paskal Beniwoll): `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- Węzeł `[17]` (Paskal Beniwoll): `SetRichPresence("Ordering the execution of those who failed them","Porte Drazon Citadel","Porte D...`

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
  - -> `[17]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I always found the Porte Drazon Citadel as majestic as it was unnerving. With its long metal spires, the building emanated an aura of terrifying grandiosity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Just looking at it sent a shiver down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "In my study, a stack of papers were waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "A matter of life and death."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "In that impenetrable prison, there were people residing on my orders. I had to decide on their fates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Executions");)*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Executions");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I reviewed the papers once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "Press your seal on the wax."]** — Mówca: **Player_Romus_Italic**
> "I pressed my ring on the wax, sealing the order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "It was done. The decision had been made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Do not execute anyone."]** — Mówca: **Player_Romus_Italic**
> "I decided not to execute anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "Punishment by execution."]** — Mówca: **Player_Romus_Italic**
> "I decided to punish these prisoners by execution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_ExecutionDecisions_NoOne = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_ExecutionDecisions_NoOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Ordering the execution of those who failed them", "Porte Drazon Citadel", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Ordering the execution of those who failed them","Porte Drazon Citadel","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
