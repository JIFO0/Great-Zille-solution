# Sordland/Turn09/NOTES

- **ID konwersacji:** `185`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/185_NOTES.md`
- **Liczba węzłów dialogowych:** 8
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Security_Unrest_Military`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Reform_Reform_Heron_Convinced`
- `BaseGameIsolated.Turn09_A_ChiefJustice_Heron`
- `BaseGameIsolated.Turn09_A_ChiefJustice_Ovid`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn09_A_ChiefJustice_Ovid"] = true;`
- Węzeł `[7]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn09_A_ChiefJustice_Heron"] = true  and  (Variable["BaseGame.Faction...`
- Węzeł `[8]` (Paskal Beniwoll): `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] = true;`

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
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_ChiefJustice_Ovid = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_ChiefJustice_Ovid"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_ChiefJustice_Heron = true && (BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true))*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_ChiefJustice_Heron"] = true  and  (Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true);`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
