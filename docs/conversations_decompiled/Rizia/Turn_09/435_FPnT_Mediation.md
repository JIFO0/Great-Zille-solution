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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[9]` (Paskal Beniwoll): `End();`
- Węzeł `[11]` (Paskal Beniwoll): `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- Węzeł `[12]` (Paskal Beniwoll): `SetRichPresence("Mediating a regional conflict","Diplomatic Suite","Palace Rezna"); ;`

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
  - -> `[12]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `436` (*Rizia/Turn 9/Morella Derdia Mediation*), Węzeł `[1]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaMorella_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true) && RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true) && RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true)  and  Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `437` (*Rizia/Turn 9/Wehlen Derdia Meditation*), Węzeł `[1]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true) && RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true)  and  Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `438` (*Rizia/Turn 9/Pabel Extradition*), Węzeł `[1]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Laurento and I sat in Palas Rezna's diplomatic suite, awaiting our foreign guests."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Mediating a regional conflict", "Diplomatic Suite", "Palace Rezna");)*
- **Efekt (`userScript`):** `SetRichPresence("Mediating a regional conflict","Diplomatic Suite","Palace Rezna");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
