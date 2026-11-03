# Sordland/Epilogue_ElectionDeath

- **ID konwersacji:** `258`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_ElectionDeath)`
- **Lokalizacja pliku:** `Sordland/Epilogue/258_Epilogue_ElectionDeath.md`
- **Liczba węzłów dialogowych:** 23
- **Liczba wyborów gracza:** 4

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_RumburgWarWin`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 0

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Time froze. You saw the crowd looking at you in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[4]`
Mówca: **Narrator**
> "You heard someone yell "Or Dax Querna! Qival Rumburgia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[11]`
Mówca: **Narrator**
> "A dull pain engulfed your body. You felt weak and tired.

You closed your eyes for one last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Narrator**
> "You heard someone yell "For Free Bludia! Yollak Bluderat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You looked down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your vision started fading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The end had come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt cold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Your shirt was stained with blood.

You lost your balance and fell to the floor. People started screaming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Your shirt was stained with blood.

You fell into Monica's arms. She screamed while holding your bloodied hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "You heard someone scream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
