# Sordland/Epilogue_WorldWar

- **ID konwersacji:** `261`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_WorldWar)`
- **Lokalizacja pliku:** `Sordland/Epilogue/261_Epilogue_WorldWar.md`
- **Liczba węzłów dialogowych:** 17
- **Liczba wyborów gracza:** 5

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 4

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[13]` (Paskal Beniwoll): `PrologueImage("pe_light");`
- Węzeł `[14]` (Paskal Beniwoll): `PrologueImage("pe_light");`
- Węzeł `[15]` (Paskal Beniwoll): `PrologueImage("pe_red");`
- Węzeł `[16]` (Paskal Beniwoll): `PrologueImage("pe_burning");`

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
  - -> `[14]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "You rose to your feet as the bright light enveloped you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The only thing you could do was to look away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[5]`
Mówca: **Narrator**
> "What had started as a rumble in the distance was now a deafening roar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Narrator**
> "It took all of your strength and courage to rise to your feet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You looked outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[8]`
Mówca: **Narrator**
> "A mushroom-shaped cloud many skyscrapers tall was towering above Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Narrator**
> "You barely registered the shockwave as the wall of extreme heat and pressure destroyed everything in its path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You couldn't believe what you were seeing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was the last thing you saw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You closed your ears and crouched down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_light");)*
- **Efekt (`userScript`):** `PrologueImage("pe_light");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_light");)*
- **Efekt (`userScript`):** `PrologueImage("pe_light");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_red");)*
- **Efekt (`userScript`):** `PrologueImage("pe_red");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_burning");)*
- **Efekt (`userScript`):** `PrologueImage("pe_burning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
