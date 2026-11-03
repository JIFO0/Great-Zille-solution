# Sordland/Turn09/NOTES

- **ID konwersacji:** `204`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/204_NOTES.md`
- **Liczba węzłów dialogowych:** 28
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Enable_LeakedScandals`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Reform_Autocrat_Path`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
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
Mówca: **Narrator**
> "Impeached for constitutional violation. Extra topics in trial. 

Election winner: TBD"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !())*
- **Warunek (`conditionsString`):** `false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Enable_LeakedScandals == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Enable_LeakedScandals == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Enable_LeakedScandals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Enable_LeakedScandals == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Enable_LeakedScandals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Impeached for constitutional violation

Election winner: TBD"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
Mówca: **Narrator**
> "Effects of the scandal remains. 

Election winner: Another party leader"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
Mówca: **Narrator**
> "Effects of the scandal remains. 

Election winner: You"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !())*
- **Warunek (`conditionsString`):** `false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !())*
- **Warunek (`conditionsString`):** `false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Narrator**
> "You win the elections by ridiculous margin

Election winner: You"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[26]`
Mówca: **Narrator**
> "You win the elections

Election winner: You"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
Mówca: **Narrator**
> "Lileas doesn't announce nomination. Congress doesn't happen. You are the party leader."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Lileas announces nomination. Congress happens. Lileas becomes party leader."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
