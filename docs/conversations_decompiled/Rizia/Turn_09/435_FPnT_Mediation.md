# Rizia/Turn 9/FPnT_Mediation

- **ID konwersacji:** `435`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/435_FPnT_Mediation.md`
- **Liczba węzłów dialogowych:** 13
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort`
- `RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort`
- `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort`
- `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort`
- `RiziaDLC.ZilleReturn_Success`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[4]` -> **[436] Rizia/Turn 9/Morella Derdia Mediation** (../Turn_09/436_Morella_Derdia_Mediation.md), Węzeł `[1]`
- Węzeł `[7]` -> **[437] Rizia/Turn 9/Wehlen Derdia Meditation** (../Turn_09/437_Wehlen_Derdia_Meditation.md), Węzeł `[1]`
- Węzeł `[8]` -> **[438] Rizia/Turn 9/Pabel Extradition** (../Turn_09/438_Pabel_Extradition.md), Węzeł `[1]`

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Mediating a regional conflict", "Diploma..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffo..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEf..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffo..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true) && RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffo..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEf..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true) && RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true)  and  Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true) && RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true)  and  Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Laurento and I sat in Palas Rezna's diplomatic suite, awaiting our foreign guests."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffo..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Laurento and I sat in Palas Rezna's diplomatic suite, awa..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Mediating a regional conflict", "Diplomatic Suite", "Palace Rezna");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Mediating a regional conflict","Diplomatic Suite","Palace Rezna");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");"*)
