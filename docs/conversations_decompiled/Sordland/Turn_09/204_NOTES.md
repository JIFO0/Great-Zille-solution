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
Mówca: **Narrator**
> "Impeached for constitutional violation. Extra topics in trial. 

Election winner: TBD"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Lileas announces nomination. Congress happens. Lileas bec..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!()"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!()`
- **Warunek bezpośredni (`conditionsString`):** `false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_LeakedScandals == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_LeakedScandals == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Enable_LeakedScandals == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_LeakedScandals == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Enable_LeakedScandals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Impeached for constitutional violation. Extra topics in t..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Enable_LeakedScandals == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Enable_LeakedScandals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Impeached for constitutional violation  Election winner: TBD"*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!()"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Effects of the scandal remains.   Election winner: You"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!()`
- **Warunek bezpośredni (`conditionsString`):** `false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Effects of the scandal remains.   Election winner: Anothe..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!()"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "You win the elections by ridiculous margin  Election winn..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!()`
- **Warunek bezpośredni (`conditionsString`):** `false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "You win the elections  Election winner: You"*)

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
  - -> `[10]` (*Węzeł Logiki Narracyjnej*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Lileas announces nomination. Congress happens. Lileas becomes party leader."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_LeakedScandals == true"*)
