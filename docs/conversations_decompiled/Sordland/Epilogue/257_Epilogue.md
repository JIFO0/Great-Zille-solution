# Sordland/Epilogue

- **ID konwersacji:** `257`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue)`
- **Lokalizacja pliku:** `Sordland/Epilogue/257_Epilogue.md`
- **Liczba węzłów dialogowych:** 37
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Epilogue_Election_Death`
- `BaseGame.Epilogue_Election_Lose`
- `BaseGame.Epilogue_Election_Win`
- `GameCondition.Turn11_A_ImpeachmentTrial`
- `GameCondition.Turn11_P_Exile`
- `GameCondition.Turn11_P_Retirement`
- `GameCondition.Turn11_SnO_CoupTrial`
- `GameCondition.Turn11_SnO_RumburgWarLost`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[28]` -> **[259] Sordland/Epilogue_ElectionWin** (../Epilogue/259_Epilogue_ElectionWin.md), Węzeł `[1]`
- Węzeł `[29]` -> **[271] Sordland/Epilogue_ElectionLose** (../Epilogue/271_Epilogue_ElectionLose.md), Węzeł `[1]`
- Węzeł `[30]` -> **[258] Sordland/Epilogue_ElectionDeath** (../Epilogue/258_Epilogue_ElectionDeath.md), Węzeł `[1]`
- Węzeł `[31]` -> **[262] Sordland/Epilogue_ImpeachmentTrial** (../Epilogue/262_Epilogue_ImpeachmentTrial.md), Węzeł `[1]`
- Węzeł `[32]` -> **[260] Sordland/Epilogue_Exile** (../Epilogue/260_Epilogue_Exile.md), Węzeł `[1]`
- Węzeł `[33]` -> **[264] Sordland/Epilogue_Retirement** (../Epilogue/264_Epilogue_Retirement.md), Węzeł `[1]`
- Węzeł `[34]` -> **[263] Sordland/Epilogue_CoupTrial** (../Epilogue/263_Epilogue_CoupTrial.md), Węzeł `[1]`
- Węzeł `[35]` -> **[270] Sordland/Epilogue_RumburgWarLost** (../Epilogue/270_Epilogue_RumburgWarLost.md), Węzeł `[1]`
- Węzeł `[36]` -> **[261] Sordland/Epilogue_WorldWar** (../Epilogue/261_Epilogue_WorldWar.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 0
- **Węzły modyfikujące stan gry:** 11

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[27]` (Paskal Beniwoll): `SetRichPresence("In the Epilogue","","");`
- Węzeł `[28]` (Paskal Beniwoll): `PlayMusic("Onward");`
- Węzeł `[29]` (Paskal Beniwoll): `PlayMusic("Persevere");`
- Węzeł `[30]` (Paskal Beniwoll): `PlayMusic("Downfall");`
- Węzeł `[31]` (Paskal Beniwoll): `PlayMusic("Downfall");`
- Węzeł `[32]` (Paskal Beniwoll): `PlayMusic("Downfall");`
- Węzeł `[33]` (Paskal Beniwoll): `PlayMusic("Onward");`
- Węzeł `[34]` (Paskal Beniwoll): `PlayMusic("Downfall");`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> `[27]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_Election_Win == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_Election_Win == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_Election_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_Election_Win == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_Election_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_Election_Lose == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_Election_Lose == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_Election_Lose"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_Election_Lose == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_Election_Lose"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_Election_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_Election_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_Election_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_Election_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_Election_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_A_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_A_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn11_A_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn11_A_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn11_A_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_P_Exile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_P_Exile == true)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn11_P_Exile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn11_P_Exile == true))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn11_P_Exile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_P_Retirement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_P_Retirement == true)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn11_P_Retirement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn11_P_Retirement == true))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn11_P_Retirement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_SnO_CoupTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_SnO_CoupTrial == true)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn11_SnO_CoupTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn11_SnO_CoupTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn11_SnO_CoupTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_SnO_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_SnO_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn11_SnO_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn11_SnO_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn11_SnO_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("In the Epilogue", "", "");)*
- **Efekt (`userScript`):** `SetRichPresence("In the Epilogue","","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Onward");)*
- **Efekt (`userScript`):** `PlayMusic("Onward");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `259` (*Sordland/Epilogue_ElectionWin*), Węzeł `[1]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Persevere");)*
- **Efekt (`userScript`):** `PlayMusic("Persevere");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `271` (*Sordland/Epilogue_ElectionLose*), Węzeł `[1]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Downfall");)*
- **Efekt (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `258` (*Sordland/Epilogue_ElectionDeath*), Węzeł `[1]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Downfall");)*
- **Efekt (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `262` (*Sordland/Epilogue_ImpeachmentTrial*), Węzeł `[1]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Downfall");)*
- **Efekt (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `260` (*Sordland/Epilogue_Exile*), Węzeł `[1]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Onward");)*
- **Efekt (`userScript`):** `PlayMusic("Onward");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `264` (*Sordland/Epilogue_Retirement*), Węzeł `[1]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Downfall");)*
- **Efekt (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `263` (*Sordland/Epilogue_CoupTrial*), Węzeł `[1]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Downfall");)*
- **Efekt (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `270` (*Sordland/Epilogue_RumburgWarLost*), Węzeł `[1]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Downfall");)*
- **Efekt (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `261` (*Sordland/Epilogue_WorldWar*), Węzeł `[1]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Chapter4_Finish");)*
- **Efekt (`userScript`):** `UnlockAchievement("Chapter4_Finish");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
