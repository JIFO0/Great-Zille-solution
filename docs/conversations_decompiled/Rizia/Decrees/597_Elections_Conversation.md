# Rizia/Elections/Elections Conversation

- **ID konwersacji:** `597`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (Elections)`
- **Lokalizacja pliku:** `Rizia/Decrees/597_Elections_Conversation.md`
- **Liczba węzłów dialogowych:** 113
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Policy_RD_Economy_LandOwnersTax`
- `RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.RNCElection_Supported`
- `RiziaDLC.Reform_Diplomatic_Success`
- `RiziaDLC.Reform_Movement_Radicalism`
- `RiziaDLC.Reform_Movement_Strength`
- `RiziaDLC.Reform_PrimeMinister_Adarfo`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Situation_Law_Media_Censored`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Situation_Order_SuOmina_Destabilizing`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
- `RiziaDLC.Situation_Welfare_WorkersRights_Bad`
- `RiziaDLC.Situation_Welfare_WorkersRights_Horrible`
- `RiziaDLC.TalkWithPM_EndorseAdarfo`
- `RiziaDLC.TalkWithPM_Endorse_Daria`
- `RiziaDLC.TalkWithPM_Endorse_DariaPlan`
- `RiziaDLC.TalkWithPM_Endorse_Manus`
- `RiziaDLC.TalkWithPM_Endorse_ManusPlan`
- `RiziaDLC.War_BorderOutcome_Peace_Annexation`
- `RiziaDLC.ZilleOwnership_Brenas`
- `RiziaDLC.ZilleOwnership_RiziaImperii`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.Ending_RPP_Vote`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Epilogue_PrimeMinister_Adarfo`
- `RiziaDLC.Epilogue_PrimeMinister_Daria`
- `RiziaDLC.Epilogue_PrimeMinister_Manus`
- `RiziaDLCIsolated.Ending_RNC_Vote`
- `RiziaDLCIsolated.Ending_RPP_Vote`
- `RiziaDLCText.EpiloguePM`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[425] Rizia/Epilogue** (../Epilogue/425_Epilogue.md), Węzeł `[25]`

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
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_Annexation == true"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote >= 7"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_RPP_Vote >= 7)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_RPP_Vote >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_RPP_Vote"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Daria = true; RiziaDLCTex..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true ||RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true ||RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.T..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true ||RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.T..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true && RiziaDLC.TalkWithPM_Endorse_Daria == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaD..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_Destabilizing || (Rizi..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true && RiziaDLC.TalkWithPM_Endorse_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_Destabilizing"]  or  (Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  and  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote -= 1"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true && RiziaDLC.TalkWithPM_Endorse_Daria == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_Destabilizing"]  or  (Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  and  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_Annexation == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Strength >= 7)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 3"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Strength >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 4"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Radicalism >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Radicalism >= 7"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Radicalism >= 7)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Radicalism >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Radicalism >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 1"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_PrimeMinister_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Refo..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_PrimeMinister_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 1"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_PrimeMinister_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_Brenas"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaDLC..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_Annexation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_Annexation == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_BorderOutcome_Peace_Annexation == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_Annexation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_BorderOutcome_Peace_Annexation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.RNCElection_Supported == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 1"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.RNCElection_Supported == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.RNCElection_Supported == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.RNCElection_Supported == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.RNCElection_Supported == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.RNCElection_Supported"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.RNCElection_Supported == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.RNCElection_Supported"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.S..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_Annexation == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Cou..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaDLC.RNCElection_Supported == true || RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaDLC..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaD..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaDLC.RNCElection_Supported == true || RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true  and  (Variable["RiziaDLC.RNCElection_Supported"] == true  or  Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaDLC.RNCElection_Supported == true || RiziaDLC.Reform_PrimeMinister_Daria == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true  and  (Variable["RiziaDLC.RNCElection_Supported"] == true  or  Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Cou..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Cou..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.Situation_Law_Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.S..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.Situation_Law_Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  and  Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.Situation_Law_Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  and  Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength < 6"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.RNCElection_Supported == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength < 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength < 6"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Strength < 6)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength < 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] < 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Strength < 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] < 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 1"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.T..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] == true  or  Variable["RiziaDLC.RNCElection_Supported"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 3"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] == true  or  Variable["RiziaDLC.RNCElection_Supported"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.Tal..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_Endorse_ManusPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.Tal..."*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.T..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_Endorse_ManusPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_ManusPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 2; RiziaDLCIsolated.E..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_Endorse_ManusPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_ManusPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_EndorseAdarfo == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 2;
RiziaDLCIsolated.Ending_RPP_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 2;
Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_EndorseAdarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_EndorseAdarfo == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.TalkWithPM_EndorseAdarfo == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_EndorseAdarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 2; RiziaDLCIsolated.E..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.TalkWithPM_EndorseAdarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1; RiziaDLCIsolated.E..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 1;
RiziaDLCIsolated.Ending_RPP_Vote += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;
Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.T..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] == true  or  Variable["RiziaDLC.RNCElection_Supported"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 3"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] == true  or  Variable["RiziaDLC.RNCElection_Supported"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 3"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaD..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 4"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Strength >= 4)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 2; RiziaDLCIsolated.E..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Strength >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 2"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 2;
RiziaDLCIsolated.Ending_RNC_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 2;
Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaD..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Radicalism >= 7"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaD..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Re..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC...."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic_Success"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 2; RiziaDLCIsolated.E..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic_Success"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 3;"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 2;
RiziaDLCIsolated.Ending_RNC_Vote += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 2;
Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaD..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.War_BorderOutcome_Peace_Annexation == true || RiziaDLC.Pales_Rizia_Unification == true) && RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_BorderOutcome_Peace_Annexation == true || R..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.War_BorderOutcome_Peace_Annexation == true ||..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.War_BorderOutcome_Peace_Annexation == true || RiziaDLC.Pales_Rizia_Unification == true) && RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true)  and  Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote >= 7"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.War_BorderOutcome_Peace_Annexation == true || RiziaDLC.Pales_Rizia_Unification == true) && RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true)  and  Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote >= 6"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote >= 6"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_RPP_Vote >= 6)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_RPP_Vote >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_RPP_Vote"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Daria = true; RiziaDLCTex..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Daria = true;
RiziaDLCText.EpiloguePM = "Daria";`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Daria"] = true;
Variable["RiziaDLCText.EpiloguePM"] ="Daria";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Adarfo = true; RiziaDLCTe..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Manus = true; RiziaDLCTex..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Adarfo = true;
RiziaDLCText.EpiloguePM = "Adarfo";`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] = true;
Variable["RiziaDLCText.EpiloguePM"] ="Adarfo";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Manus = true;
RiziaDLCText.EpiloguePM = "Manus";`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] = true;
Variable["RiziaDLCText.EpiloguePM"] ="Manus";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Daria == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Re..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Daria == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.TalkWithPM_Endorse_Daria == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 1"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.TalkWithPM_Endorse_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.Tal..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Re..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_EndorseAdarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.Tal..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.T..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_EndorseAdarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  or  Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 1"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_EndorseAdarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  or  Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Re..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Re..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Country_PublicOpinion >= 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Cou..."*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.C..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Country_PublicOpinion >= 16`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  and  Variable["RiziaDLC.Country_PublicOpinion"] >= 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RNC_Vote += 2"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Country_PublicOpinion >= 16)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  and  Variable["RiziaDLC.Country_PublicOpinion"] >= 16) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.Cou..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.Country_PublicOpinion >= 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.Cou..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.C..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.Country_PublicOpinion >= 16`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  and  Variable["RiziaDLC.Country_PublicOpinion"] >= 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_RPP_Vote += 2"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.Country_PublicOpinion >= 16)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  and  Variable["RiziaDLC.Country_PublicOpinion"] >= 16) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_BorderOutcome_Peace_Annexation == true || R..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RNC_Vote += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_BorderOutcome_Peace_Annexation == true || R..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_RPP_Vote += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.War_BorderOutcome_Peace_Annexation == true || R..."*)
