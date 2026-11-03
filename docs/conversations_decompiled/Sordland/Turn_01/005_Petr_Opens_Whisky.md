# Sordland/Turn01/Petr Opens Whisky

- **ID konwersacji:** `5`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/005_Petr_Opens_Whisky.md`
- **Liczba węzłów dialogowych:** 24
- **Liczba wyborów gracza:** 10

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[4] Sordland/Turn01/A_PoliticalOverview** (../Turn_01/004_A_PoliticalOverview.md), Węzeł `[226]`
- Węzeł `[13]` -> **[4] Sordland/Turn01/A_PoliticalOverview** (../Turn_01/004_A_PoliticalOverview.md), Węzeł `[223]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
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
  - -> `[10]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `4` (*Sordland/Turn01/A_PoliticalOverview*), Węzeł `[226]`

### Węzeł `[3]`
Mówca: **Narrator**
> "He let out a nervous laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "“I assure you it won't. We will not make the same mistakes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[5]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“I sure do hope so.”"]** — Mówca: **Player**
> "“I sure do hope so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Relax. I'm just joking.”"]** — Mówca: **Player**
> "“Relax. I'm just joking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“We wouldn't get much done. Remember the last administration?”"]** — Mówca: **Player**
> "“We wouldn't get much done. Remember the last administration?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“We can't make the same mistakes again.”"]** — Mówca: **Player**
> "“We can't make the same mistakes again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Petr Vectern**
> "“We learned from it all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I opened the expensive bottle of whiskey and poured it in the two glasses I prepared. The exquisite smell filled the room immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Yes, we did.”"]** — Mówca: **Player**
> "“Yes, we did.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“The future awaits, Petr.”"]** — Mówca: **Player**
> "“The future awaits, Petr.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lucian Arrives For Political Overview])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `4` (*Sordland/Turn01/A_PoliticalOverview*), Węzeł `[223]`

### Węzeł `[14]`
Mówca: **Petr Vectern**
> "“Maybe not. But thanks for the drink. This is really amazing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“We could, but maybe we shouldn't.”"]** — Mówca: **Player**
> "“We could, but maybe we shouldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Toast."]** — Mówca: **Player_Italic**
> "I raised my glass and toasted with Petr before smelling the whiskey and taking a sip. The sweet vanilla tone combined with an oaky taste developed into a lingering smokiness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Petr really seemed to be enjoying himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
> "“Yeah, but we are different. All they did was enjoy the privilege.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[8]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> "“What a taste! This is how we should start all meetings, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[15]`

### Węzeł `[20]`
Mówca: **Narrator**
> "He suddenly looked a bit anxious on his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Screw 1924. It is tainting this moment.”"]** — Mówca: **Player**
> "“Screw 1924. It is tainting this moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I hope it won't be the case for my cabinet.”"]** — Mówca: **Player**
> "“I hope it won't be the case for my cabinet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“The 1924? That was my freshman year. Also the year after the revolution. Very difficult times, to be honest, but this smells like heaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[21]`
