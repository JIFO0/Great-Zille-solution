# Rizia/Turn 6/Calculations

- **ID konwersacji:** `366`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/366_Calculations.md`
- **Liczba węzłów dialogowych:** 204
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
- `RiziaDLC.HODElection_RustyInfluence_RNC`
- `RiziaDLC.HODElection_RustyInfluence_RPP`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax`
- `RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized`
- `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners`
- `RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Reform_Movement_Radicalism`
- `RiziaDLC.Reform_Movement_Strength`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Situation_Economy_GlobalEnergyPrice_High`
- `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise`
- `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_DastnuristCommunity_Happy`
- `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_GolcondistCommunity_Happy`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied`
- `RiziaDLC.Situation_Welfare_Housing_WorseningCrisis`
- `RiziaDLC.Situation_Welfare_LivingStandards_Acceptable`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Good`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
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
- `RiziaDLCIsolated.Voting_Foreigners_RNC`
- `RiziaDLCIsolated.Voting_Foreigners_RPP`
- `RiziaDLCIsolated.Voting_LowerClass_RNC`
- `RiziaDLCIsolated.Voting_LowerClass_RPP`
- `RiziaDLCIsolated.Voting_MiddleClass_RNC`
- `RiziaDLCIsolated.Voting_MiddleClass_RPP`
- `RiziaDLCIsolated.Voting_Nobility_RNC`
- `RiziaDLCIsolated.Voting_Nobility_RPP`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[365] Rizia/Turn 6/ELECTION CALCULATIONS** (../Turn_06/365_ELECTION_CALCULATIONS.md), Węzeł `[2]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 54

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Paskal Beniwoll): `EvaluateConditionalInstruction("HouseElection_RNCWins");`
- Węzeł `[4]` (Paskal Beniwoll): `Variable["RiziaDLC.HouseElections_StatusQuo"] = true;`
- Węzeł `[5]` (Paskal Beniwoll): `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] = true;`
- Węzeł `[6]` (Paskal Beniwoll): `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] = true;`
- Węzeł `[7]` (Paskal Beniwoll): `EvaluateConditionalInstruction("HouseElection_RPPWins");`
- Węzeł `[8]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc...`
- Węzeł `[18]` (Paskal Beniwoll): `--;`
- Węzeł `[22]` (Paskal Beniwoll): `-- HAS 5 VOTE;`
- *...oraz 46 innych węzłów ze skryptami.*

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
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `365` (*Rizia/Turn 6/ELECTION CALCULATIONS*), Węzeł `[2]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EvaluateConditionalInstruction("HouseElection_RNCWins");)*
- **Efekt (`userScript`):** `EvaluateConditionalInstruction("HouseElection_RNCWins");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_StatusQuo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.HouseElections_StatusQuo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EvaluateConditionalInstruction("HouseElection_RPPWins");)*
- **Efekt (`userScript`):** `EvaluateConditionalInstruction("HouseElection_RPPWins");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAS 5 VOTE)*
- **Efekt (`userScript`):** `-- HAS 5 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAS 2 VOTES)*
- **Efekt (`userScript`):** `-- HAS 2 VOTES;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAS 4 VOTES)*
- **Efekt (`userScript`):** `-- HAS 4 VOTES;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true) == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true) == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] <= 0  and  (Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true) == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] <= 0  and  (Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_HouseToras <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_HouseToras <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] <= 10  or  Variable["RiziaDLC.Country_HouseToras"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_HouseToras <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] <= 10  or  Variable["RiziaDLC.Country_HouseToras"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Nobility_RPP += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] = Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2;
RiziaDLCIsolated.Voting_Nobility_RNC += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 2;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Nobility_RPP += 1;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] = Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] + 1;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2;
RiziaDLCIsolated.Voting_Nobility_RNC += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 2;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] <= 10  and  Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] <= 10  and  Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Nobility_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] = Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAS 4 VOTE)*
- **Efekt (`userScript`):** `-- HAS 4 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 15  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 15  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 5  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 5  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true &&  RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true &&  RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  and   Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true &&  RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  and   Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true && RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == false && RiziaDLC.Situation_Economy_GlobalEnergyPrice_High == false && RiziaDLC.Situation_Welfare_LivingStandards_Horrible == false && RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true && RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == false && RiziaDLC.Situation_Economy_GlobalEnergyPrice_High == false && RiziaDLC.Situation_Welfare_LivingStandards_Horrible == false && RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true  and  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == false  and  Variable["RiziaDLC.Situation_Economy_GlobalEnergyPrice_High"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == false  and  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true && RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == false && RiziaDLC.Situation_Economy_GlobalEnergyPrice_High == false && RiziaDLC.Situation_Welfare_LivingStandards_Horrible == false && RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true  and  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == false  and  Variable["RiziaDLC.Situation_Economy_GlobalEnergyPrice_High"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == false  and  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HODElection_RustyInfluence_RNC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HODElection_RustyInfluence_RNC == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HODElection_RustyInfluence_RNC == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HODElection_RustyInfluence_RPP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HODElection_RustyInfluence_RPP == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HODElection_RustyInfluence_RPP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HODElection_RustyInfluence_RPP == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HODElection_RustyInfluence_RPP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength > 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Strength > 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAS 2 VOTE)*
- **Efekt (`userScript`):** `-- HAS 2 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAS 3 VOTE)*
- **Efekt (`userScript`):** `-- HAS 3 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HODElection_RustyInfluence_RNC == true && (RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Policy_RD_Welfare_FreePress == false || RiziaDLC.Reform_Movement_Radicalism <= 3))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HODElection_RustyInfluence_RNC == true && (RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Policy_RD_Welfare_FreePress == false || RiziaDLC.Reform_Movement_Radicalism <= 3))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true  and  (Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == false  or  Variable["RiziaDLC.Reform_Movement_Radicalism"] <= 3)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HODElection_RustyInfluence_RNC == true && (RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Policy_RD_Welfare_FreePress == false || RiziaDLC.Reform_Movement_Radicalism <= 3)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true  and  (Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == false  or  Variable["RiziaDLC.Reform_Movement_Radicalism"] <= 3)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_LowerClass_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_LowerClass_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_LowerClass_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_LowerClass_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_LowerClass_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Strength >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_LowerClass_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Reform_Movement_Radicalism > 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Reform_Movement_Radicalism > 6)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] > 5  or  Variable["RiziaDLC.Reform_Movement_Radicalism"] > 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Reform_Movement_Radicalism > 6))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] > 5  or  Variable["RiziaDLC.Reform_Movement_Radicalism"] > 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.HODElection_RustyInfluence_RPP == true) &&  RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.HODElection_RustyInfluence_RPP == true) &&  RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.HODElection_RustyInfluence_RPP"] == true)  and   Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.HODElection_RustyInfluence_RPP == true) &&  RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.HODElection_RustyInfluence_RPP"] == true)  and   Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false && RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false && RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false && RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_LowerClass_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAS 2 VOTE)*
- **Efekt (`userScript`):** `-- HAS 2 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAS 3 VOTE)*
- **Efekt (`userScript`):** `-- HAS 3 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Foreigners_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.HODElection_RustyInfluence_RNC == true) && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.HODElection_RustyInfluence_RNC == true) && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true  or  Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true)  and  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.HODElection_RustyInfluence_RNC == true) && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true  or  Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true)  and  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Foreigners_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] <= -5  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] <= -5  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.LeaningValue_Democratic <= -10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.LeaningValue_Democratic <= -10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] <= -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.LeaningValue_Democratic <= -10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] <= -10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true || RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true || RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true || RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Foreigners_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Foreigners_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Foreigners_RPP += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Foreigners_RNC += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] - Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] - Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] - Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] - Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true ||RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true) && (RiziaDLC.Situation_Order_DastnuristCommunity_Happy == false && RiziaDLC.Situation_Order_GolcondistCommunity_Happy == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true ||RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true) && (RiziaDLC.Situation_Order_DastnuristCommunity_Happy == false && RiziaDLC.Situation_Order_GolcondistCommunity_Happy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true  or Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true)  and  (Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == false  and  Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Happy"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true ||RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true) && (RiziaDLC.Situation_Order_DastnuristCommunity_Happy == false && RiziaDLC.Situation_Order_GolcondistCommunity_Happy == false)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true  or Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true)  and  (Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == false  and  Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Happy"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AnalyticsEvent("Analytics_Rizia_HouseOfDelegates");)*
- **Efekt (`userScript`):** `AnalyticsEvent("Analytics_Rizia_HouseOfDelegates");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
