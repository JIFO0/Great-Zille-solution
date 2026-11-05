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
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("In the Epilogue", "", "");"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_Election_Win == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_Election_Win == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_Election_Win == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_Election_Win == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_Election_Win"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Onward");"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_Election_Win == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_Election_Win"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_Election_Lose == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_Election_Lose == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_Election_Lose == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_Election_Lose == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_Election_Lose == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_Election_Lose"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Persevere");"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_Election_Lose == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_Election_Lose"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_Election_Death == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_Election_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_Election_Death == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Epilogue_Election_Death == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Epilogue_Election_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Epilogue_Election_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Downfall");"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Epilogue_Election_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Epilogue_Election_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_A_ImpeachmentTrial == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_A_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_A_ImpeachmentTrial == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn11_A_ImpeachmentTrial == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_A_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn11_A_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Downfall");"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn11_A_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn11_A_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_P_Exile == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_P_Exile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_P_Exile == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn11_P_Exile == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_P_Exile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn11_P_Exile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Downfall");"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn11_P_Exile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn11_P_Exile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_P_Retirement == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_P_Retirement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_P_Retirement == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn11_P_Retirement == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_P_Retirement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn11_P_Retirement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Onward");"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn11_P_Retirement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn11_P_Retirement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_CoupTrial == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_SnO_CoupTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_CoupTrial == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn11_SnO_CoupTrial == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_SnO_CoupTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn11_SnO_CoupTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Downfall");"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn11_SnO_CoupTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn11_SnO_CoupTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_SnO_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn11_SnO_RumburgWarLost == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_SnO_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn11_SnO_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Downfall");"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn11_SnO_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn11_SnO_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Downfall");"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("In the Epilogue", "", "");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("In the Epilogue","","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Chapter4_Finish");"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Onward");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Onward");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Persevere");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Persevere");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Downfall");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Downfall");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Downfall");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Onward");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Onward");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Downfall");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Downfall");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Downfall");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Downfall");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Chapter4_Finish");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Chapter4_Finish");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Epilogue_Election_Win == true"*)
