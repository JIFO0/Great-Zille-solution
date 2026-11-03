# Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/HOUSE STRIKE FAIL Conversation

- **ID konwersacji:** `566`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/566_HOUSE_STRIKE_FAIL_Conversation.md`
- **Liczba węzłów dialogowych:** 13
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_TitusBetrays`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.SkipToEpilogue`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[195]`
- Węzeł `[4]` -> **[570] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Titus Betrayal Branch/Titus Betrayal Branch Conversation** (../Turn_10/570_Titus_Betrayal_Branch_Conversation.md), Węzeł `[1]`
- Węzeł `[7]` -> **[569] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Revolution Fail Branch/Revolution Fail Branch Conversation** (../Turn_10/569_Revolution_Fail_Branch_Conversation.md), Węzeł `[1]`
- Węzeł `[8]` -> **[568] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/House Shootout Branch/House Shootout Branch Conversation** (../Turn_10/568_House_Shootout_Branch_Conversation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[9]` (Paskal Beniwoll): `--;`
- Węzeł `[10]` (Paskal Beniwoll): `Variable["RiziaDLC.SkipToEpilogue"] = true;`
- Węzeł `[12]` (Paskal Beniwoll): `UnlockAchievement("Rizia_EtTuTitus");`

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `555` (*Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation*), Węzeł `[195]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_TitusBetrays == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_TitusBetrays == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `570` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Titus Betrayal Branch/Titus Betrayal Branch Conversation*), Węzeł `[1]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_TitusBetrays == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `569` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Revolution Fail Branch/Revolution Fail Branch Conversation*), Węzeł `[1]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `568` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/House Shootout Branch/House Shootout Branch Conversation*), Węzeł `[1]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SkipToEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: END OF STRIKE FAIL)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_EtTuTitus");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_EtTuTitus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
