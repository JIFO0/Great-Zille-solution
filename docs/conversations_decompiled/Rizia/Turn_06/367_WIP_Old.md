# Rizia/Turn 6/WIP_Old

- **ID konwersacji:** `367`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/367_WIP_Old.md`
- **Liczba węzłów dialogowych:** 129
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Country_HouseSazon`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Decision_Turn05_RNCElectionFund_Generous`
- `RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Situation_Welfare_Housing_LackOfAffordable`
- `RiziaDLC.Situation_Welfare_Housing_WorseningCrisis`
- `RiziaDLC.Situation_Welfare_LivingStandards_Average`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Situation_Welfare_WorkersRights_Acceptable`
- `RiziaDLC.Situation_Welfare_WorkersRights_Bad`
- `RiziaDLC.Situation_Welfare_WorkersRights_Good`
- `RiziaDLC.Situation_Welfare_WorkersRights_Horrible`
- `RiziaDLCIsolated.Turn06_VotingCalc_RNC`
- `RiziaDLCIsolated.Turn06_VotingCalc_RPP`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.HouseElections_RNCWinsSeats`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.HouseElections_StatusQuo`
- `RiziaDLCIsolated.Turn06_VotingCalc_RNC`
- `RiziaDLCIsolated.Turn06_VotingCalc_RPP`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 37

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[12]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- Węzeł `[13]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- Węzeł `[17]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- Węzeł `[18]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- Węzeł `[22]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- Węzeł `[26]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- Węzeł `[27]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- Węzeł `[28]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- *...oraz 29 innych węzłów ze skryptami.*

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
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 6;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 4)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 6;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 3;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 7)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 3;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 20)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 9)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 9;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 20;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EvaluateConditionalInstruction("HouseElection_RPPWins");)*
- **Efekt (`userScript`):** `EvaluateConditionalInstruction("HouseElection_RPPWins");`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 8;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 8;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 30)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 20)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 30)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC  += 15;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 5)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]  =  + 15;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) >= 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) >= 15)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] -Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]) >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) >= 15))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] -Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]) >= 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) < 0)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] -Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]) < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) < 0))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] -Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]) < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_StatusQuo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.HouseElections_StatusQuo"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EvaluateConditionalInstruction("HouseElection_RNCWins");)*
- **Efekt (`userScript`):** `EvaluateConditionalInstruction("HouseElection_RNCWins");`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC -= 15)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] - 15;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 30)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 30)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 20)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 15;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 5)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 15;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
