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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

- *Brak decyzji i wyborów gracza w tej scenie (dialog liniowy lub sekwencja techniczna).*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_ChiefJustice_Ovid = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_ChiefJustice_Ovid"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_ChiefJustice_Heron = true && (BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true)`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_ChiefJustice_Heron"] = true  and  (Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true);`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
