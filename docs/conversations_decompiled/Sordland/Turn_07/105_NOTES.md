# Sordland/Turn07/NOTES

- **ID konwersacji:** `105`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/105_NOTES.md`
- **Liczba węzłów dialogowych:** 22
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[36]** Heron Garaci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
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
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Heron Garaci**
> ""I'm offering my help in exchange for a position in the cabinet. As the Minister of Law and Justice in the next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Heron Garaci**
> ""You know I have both the expertise and the influence. It's a huge offer, Mr. President. For both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[13]`
  - -> `[11]`
  - -> `[9]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[8]`
Mówca: **Heron Garaci**
> ""I think you'd also agree that Mrs. Morgna isn't doing much to justify the retainment of her position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""I don't like this offer, Mr. Garaci. I need something better than that.""]** — Mówca: **Player**
> ""I don't like this offer, Mr. Garaci. I need something better than that.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WYBÓR GRACZA: ""It is an interesting offer.""]** — Mówca: **Player**
> ""It is an interesting offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
**[WYBÓR GRACZA: ""You're asking too much.""]** — Mówca: **Player**
> ""You're asking too much.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I don't know if I can trust you more than Mrs. Morgna.""]** — Mówca: **Player**
> ""I don't know if I can trust you more than Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I like your offer.""]** — Mówca: **Player**
> ""I like your offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Heron Garaci**
> ""I think it's mutually beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Heron Garaci**
> ""I'll show you my influence and my reliability at the vote as long as you can promise me that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Heron Garaci**
> ""So... What do you say, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""It's a deal. I'll make you the next minister of justice.""]** — Mówca: **Player**
> ""It's a deal. I'll make you the next minister of justice.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Agreed. I'll give you the seat if we pass the vote.""]** — Mówca: **Player**
> ""Agreed. I'll give you the seat if we pass the vote.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I'm conflicted.""]** — Mówca: **Player**
> ""I'm conflicted.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
