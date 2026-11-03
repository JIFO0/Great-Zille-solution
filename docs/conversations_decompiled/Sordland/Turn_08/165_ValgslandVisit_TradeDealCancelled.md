# Sordland/Turn08/ValgslandVisit_TradeDealCancelled

- **ID konwersacji:** `165`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/165_ValgslandVisit_TradeDealCancelled.md`
- **Liczba węzłów dialogowych:** 37
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_TradeDeal`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[160] Sordland/Turn08/FPnT_ValgslandVisit** (../Turn_08/160_FPnT_ValgslandVisit.md), Węzeł `[35]`

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
  - -> `[13]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `160` (*Sordland/Turn08/FPnT_ValgslandVisit*), Węzeł `[35]`

### Węzeł `[3]`
Mówca: **Deivid Wisci**
> "“They are trying to economically weaken us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I put down the document and slammed the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“It looks like we have made an adversary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Deivid Wisci**
> "“Because of our alliance with Lespia, they have decided to cancel the negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[7]`
  - -> `[9]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“I was expecting this to happen.”"]** — Mówca: **Player**
> "“I was expecting this to happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Is there anyway we can still get them on the table?”"]** — Mówca: **Player**
> "“Is there anyway we can still get them on the table?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“God damn it.”"]** — Mówca: **Player**
> "“God damn it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
Mówca: **Deivid Wisci**
> "“Unfortunately not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I started unpacking my briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[12]`
Mówca: **Deivid Wisci**
> "“It seems like the trade deal with Valgsland fell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[13]`
Mówca: **Narrator**
> "I was in my office preparing my briefcase for the trip ahead to Haelm in Valgsland to discuss the trade deal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“Me too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I'm not going to like this, am I?”"]** — Mówca: **Player**
> "“I'm not going to like this, am I?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[16]`
Mówca: **Deivid Wisci**
> "“It is unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[17]`
Mówca: **Narrator**
> "I heard two knocks and I turned around to see Deivid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
Mówca: **Deivid Wisci**
> "“It is unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true && BaseGame.Lespia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true && BaseGame.Lespia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  and  Variable["BaseGame.Lespia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true && BaseGame.Lespia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  and  Variable["BaseGame.Lespia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[22]`
Mówca: **Deivid Wisci**
> "“I have just received a communication from the Ministry of Foreign Affairs of Valgsland about our trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He was panting heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“Because of our alliance and trade deal with Lespia, they have decided to cancel the negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[7]`
  - -> `[9]`

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[34]`

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“That's not all, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[15]`
  - -> `[32]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Narrator**
> "He handed me a document with the emblem of the Ministry of Economy of Valgsland on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Go ahead.”"]** — Mówca: **Player**
> "“Go ahead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“What happened?”"]** — Mówca: **Player**
> "“What happened?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[33]`
Mówca: **Deivid Wisci**
> "“Because of our trade deal with Lespia, they have decided to cancel the negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[7]`
  - -> `[9]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Is something wrong?”"]** — Mówca: **Player**
> "“Is something wrong?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Deivid. Ready for the trip?”"]** — Mówca: **Player**
> "“Deivid. Ready for the trip?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[36]`
Mówca: **Deivid Wisci**
> "“Valgsland has put tariffs on our trade in retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
