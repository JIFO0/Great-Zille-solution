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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 29

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[27]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- Węzeł `[34]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- Węzeł `[35]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] - 1;`
- Węzeł `[36]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- Węzeł `[37]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- Węzeł `[41]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- Węzeł `[45]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- Węzeł `[46]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- *...oraz 21 innych węzłów ze skryptami.*

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
  - -> `[93]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `425` (*Rizia/Epilogue*), Węzeł `[25]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_RPP_Vote >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_RPP_Vote"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true ||RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true ||RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true ||RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true && RiziaDLC.TalkWithPM_Endorse_Daria == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true && RiziaDLC.TalkWithPM_Endorse_Daria == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_Destabilizing"]  or  (Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  and  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_Destabilizing || (RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true && RiziaDLC.TalkWithPM_Endorse_Daria == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_Destabilizing"]  or  (Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  and  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Strength >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Radicalism >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Radicalism >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Radicalism >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_PrimeMinister_Adarfo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_PrimeMinister_Adarfo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_PrimeMinister_Adarfo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_Brenas"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_Annexation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_Annexation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_BorderOutcome_Peace_Annexation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.RNCElection_Supported == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.RNCElection_Supported == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.RNCElection_Supported"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.RNCElection_Supported == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.RNCElection_Supported"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaDLC.RNCElection_Supported == true || RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaDLC.RNCElection_Supported == true || RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true  and  (Variable["RiziaDLC.RNCElection_Supported"] == true  or  Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleOwnership_RiziaImperii == true && (RiziaDLC.RNCElection_Supported == true || RiziaDLC.Reform_PrimeMinister_Daria == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true  and  (Variable["RiziaDLC.RNCElection_Supported"] == true  or  Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.Situation_Law_Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.Situation_Law_Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  and  Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true && RiziaDLC.Situation_Law_Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  and  Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength < 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength < 6)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] < 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Strength < 6))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] < 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] == true  or  Variable["RiziaDLC.RNCElection_Supported"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] == true  or  Variable["RiziaDLC.RNCElection_Supported"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_Endorse_ManusPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_Endorse_ManusPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_ManusPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_Endorse_ManusPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_ManusPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 2;
RiziaDLCIsolated.Ending_RPP_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 2;
Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_EndorseAdarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_EndorseAdarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.TalkWithPM_EndorseAdarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 1;
RiziaDLCIsolated.Ending_RPP_Vote += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;
Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] == true  or  Variable["RiziaDLC.RNCElection_Supported"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true || RiziaDLC.TalkWithPM_Endorse_Daria == true || RiziaDLC.TalkWithPM_Endorse_DariaPlan == true || RiziaDLC.RNCElection_Supported == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  or  Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] == true  or  Variable["RiziaDLC.RNCElection_Supported"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Strength >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 2;
RiziaDLCIsolated.Ending_RNC_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 2;
Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic_Success"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Diplomatic_Success == true && RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic_Success"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 2;
RiziaDLCIsolated.Ending_RNC_Vote += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 2;
Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.War_BorderOutcome_Peace_Annexation == true || RiziaDLC.Pales_Rizia_Unification == true) && RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.War_BorderOutcome_Peace_Annexation == true || RiziaDLC.Pales_Rizia_Unification == true) && RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true)  and  Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.War_BorderOutcome_Peace_Annexation == true || RiziaDLC.Pales_Rizia_Unification == true) && RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true)  and  Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote >= 6)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_RPP_Vote >= 6))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_RPP_Vote"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Daria = true;
RiziaDLCText.EpiloguePM = "Daria";)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Daria"] = true;
Variable["RiziaDLCText.EpiloguePM"] ="Daria";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Adarfo = true;
RiziaDLCText.EpiloguePM = "Adarfo";)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] = true;
Variable["RiziaDLCText.EpiloguePM"] ="Adarfo";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_PrimeMinister_Manus = true;
RiziaDLCText.EpiloguePM = "Manus";)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] = true;
Variable["RiziaDLCText.EpiloguePM"] ="Manus";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.TalkWithPM_Endorse_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_EndorseAdarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_EndorseAdarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  or  Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.TalkWithPM_Endorse_Manus == true || RiziaDLC.TalkWithPM_EndorseAdarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  or  Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Country_PublicOpinion >= 16)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Country_PublicOpinion >= 16)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  and  Variable["RiziaDLC.Country_PublicOpinion"] >= 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.TalkWithPM_Endorse_Daria == true && RiziaDLC.Country_PublicOpinion >= 16))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] == true  and  Variable["RiziaDLC.Country_PublicOpinion"] >= 16) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.Country_PublicOpinion >= 16)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.Country_PublicOpinion >= 16)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  and  Variable["RiziaDLC.Country_PublicOpinion"] >= 16`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.TalkWithPM_Endorse_Manus == true && RiziaDLC.Country_PublicOpinion >= 16))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] == true  and  Variable["RiziaDLC.Country_PublicOpinion"] >= 16) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RNC_Vote += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RNC_Vote"] = Variable["RiziaDLCIsolated.Ending_RNC_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_RPP_Vote += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Ending_RPP_Vote"] = Variable["RiziaDLCIsolated.Ending_RPP_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
