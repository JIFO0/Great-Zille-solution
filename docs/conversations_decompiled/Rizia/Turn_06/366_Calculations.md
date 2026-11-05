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
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EvaluateConditionalInstruction("HouseElection_RNCWins");`
- **Efekt skryptowy (`userScript`):** `EvaluateConditionalInstruction("HouseElection_RNCWins");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "AnalyticsEvent("Analytics_Rizia_HouseOfDelegates");"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_StatusQuo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.HouseElections_StatusQuo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "AnalyticsEvent("Analytics_Rizia_HouseOfDelegates");"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "EvaluateConditionalInstruction("HouseElection_RNCWins");"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "EvaluateConditionalInstruction("HouseElection_RPPWins");"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EvaluateConditionalInstruction("HouseElection_RPPWins");`
- **Efekt skryptowy (`userScript`):** `EvaluateConditionalInstruction("HouseElection_RPPWins");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "AnalyticsEvent("Analytics_Rizia_HouseOfDelegates");"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "// HAS 2 VOTES"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "// HAS 2 VOTES"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "// HAS 4 VOTES"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decision..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decision_..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAS 5 VOTE`
- **Efekt skryptowy (`userScript`):** `-- HAS 5 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAS 2 VOTES`
- **Efekt skryptowy (`userScript`):** `-- HAS 2 VOTES;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Gover..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAS 4 VOTES`
- **Efekt skryptowy (`userScript`):** `-- HAS 4 VOTES;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Gover..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Gov..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true) == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] <= 0  and  (Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_Hou..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro <= 0 && (RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true) == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] <= 0  and  (Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2; RiziaDLCIsol..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras <= 0"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras <= 0)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2; RiziaDLCIsol..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_HouseToras <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_Hou..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_H..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_HouseToras <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] <= 10  or  Variable["RiziaDLC.Country_HouseToras"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon <= 10 || RiziaDLC.Country_HouseToras <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] <= 10  or  Variable["RiziaDLC.Country_HouseToras"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2; RiziaDLCIsol..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Nobility_RPP += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] = Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2;
RiziaDLCIsolated.Voting_Nobility_RNC += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 2;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras <= 0"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Nobility_RPP += 1;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] = Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] + 1;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_H..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2;
RiziaDLCIsolated.Voting_Nobility_RNC += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 2;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_H..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_H..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] <= 10  and  Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon <= 10 && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] <= 10  and  Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Nobility_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] = Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Nobility_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] = Variable["RiziaDLCIsolated.Voting_Nobility_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && R..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "// HAS 5 VOTE"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "// HAS 4 VOTE"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAS 4 VOTE`
- **Efekt skryptowy (`userScript`):** `-- HAS 4 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decision..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decisi..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 15  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion >= 15 || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 15  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decision_..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decisio..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 5  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion >= 5 || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 5  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true &&  RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == tru..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == t..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true &&  RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  and   Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true &&  RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  and   Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfie..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == tru..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied ..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied ..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true && RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == false && RiziaDLC.Situation_Economy_GlobalEnergyPrice_High == false && RiziaDLC.Situation_Welfare_LivingStandards_Horrible == false && RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == tru..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == t..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true && RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == false && RiziaDLC.Situation_Economy_GlobalEnergyPrice_High == false && RiziaDLC.Situation_Welfare_LivingStandards_Horrible == false && RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true  and  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == false  and  Variable["RiziaDLC.Situation_Economy_GlobalEnergyPrice_High"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == false  and  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true && RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == false && RiziaDLC.Situation_Economy_GlobalEnergyPrice_High == false && RiziaDLC.Situation_Welfare_LivingStandards_Horrible == false && RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true  and  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == false  and  Variable["RiziaDLC.Situation_Economy_GlobalEnergyPrice_High"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == false  and  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied ..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfie..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == tru..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RNC == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RNC == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HODElection_RustyInfluence_RNC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RNC == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HODElection_RustyInfluence_RNC == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HODElection_RustyInfluence_RNC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HODElection_RustyInfluence_RNC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RPP == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HODElection_RustyInfluence_RPP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RPP == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HODElection_RustyInfluence_RPP == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HODElection_RustyInfluence_RPP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HODElection_RustyInfluence_RPP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HODElection_RustyInfluence_RPP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HODElection_RustyInfluence_RPP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength > 5"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_MiddleClass_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_MiddleClass_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] = Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength > 5"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Strength > 5)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Strength > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && R..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "// HAS 3 VOTE"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "// HAS 2 VOTE"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAS 2 VOTE`
- **Efekt skryptowy (`userScript`):** `-- HAS 2 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAS 3 VOTE`
- **Efekt skryptowy (`userScript`):** `-- HAS 3 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RNC == true && (Rizia..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "// HAS 3 VOTE"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "// HAS 2 VOTE"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HODElection_RustyInfluence_RNC == true && (RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Policy_RD_Welfare_FreePress == false || RiziaDLC.Reform_Movement_Radicalism <= 3)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HODElection_RustyInfluence_RNC == true && (Rizia..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HODElection_RustyInfluence_RNC == true && (Riz..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HODElection_RustyInfluence_RNC == true && (RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Policy_RD_Welfare_FreePress == false || RiziaDLC.Reform_Movement_Radicalism <= 3)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true  and  (Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == false  or  Variable["RiziaDLC.Reform_Movement_Radicalism"] <= 3)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HODElection_RustyInfluence_RNC == true && (RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true || RiziaDLC.Policy_RD_Welfare_FreePress == false || RiziaDLC.Reform_Movement_Radicalism <= 3))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true  and  (Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true  or  Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == false  or  Variable["RiziaDLC.Reform_Movement_Radicalism"] <= 3)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_LowerClass_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_LowerClass_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Good == true || ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true..."*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == tr..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == false"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_LowerClass_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == false"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == false)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Good == true || ..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Good == true |..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_LowerClass_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_LowerClass_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Strength >= 7)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Strength >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_LowerClass_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Reform_Movement_Radicalism > 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Reform_..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Refor..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Reform_Movement_Radicalism > 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] > 5  or  Variable["RiziaDLC.Reform_Movement_Radicalism"] > 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == false..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Reform_Movement_Radicalism > 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] > 5  or  Variable["RiziaDLC.Reform_Movement_Radicalism"] > 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.HODElection_RustyInfluence_RPP == true) &&  RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaD..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.HODElection_RustyInfluence_RPP == true) &&  RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.HODElection_RustyInfluence_RPP"] == true)  and   Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.HODElection_RustyInfluence_RPP == true) &&  RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.HODElection_RustyInfluence_RPP"] == true)  and   Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength > 5 || RiziaDLC.Reform_..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false && RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == false..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == fal..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false && RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == false && RiziaDLC.Situation_Welfare_LivingStandards_Good == false && RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == false  and  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_LowerClass_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] = Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == tr..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAS 2 VOTE`
- **Efekt skryptowy (`userScript`):** `-- HAS 2 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Policy..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAS 3 VOTE`
- **Efekt skryptowy (`userScript`):** `-- HAS 3 VOTE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == tru..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Foreigners_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "// HAS 2 VOTE"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.HODElection_RustyInfluence_RNC == true) && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == tru..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == t..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.HODElection_RustyInfluence_RNC == true) && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true  or  Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true)  and  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true || RiziaDLC.HODElection_RustyInfluence_RNC == true) && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true  or  Variable["RiziaDLC.HODElection_RustyInfluence_RNC"] == true)  and  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Foreigners_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "// HAS 2 VOTE"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Policy..."*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Poli..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] <= -5  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic <= -5 || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] <= -5  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.LeaningValue_Democratic <= -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.LeaningValue_Democratic <= -10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] <= -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.LeaningValue_Democratic <= -10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] <= -10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true |..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigran..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true || RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining =..."*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true || RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining == true || RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllExceptMining"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Foreigners_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Foreigners_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1;
RiziaDLCIsolated.Voting_Foreigners_RPP += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true |..."*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_WorkersRights_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Voting_Foreigners_RNC += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] = Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants == true || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ResidenceWorkPermitForMigrants"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolat..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] - Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_StatusQuo = true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] - Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolat..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] - Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats = true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_VotingCalc_RPP - RiziaDLCIsolated.Turn06_VotingCalc_RNC > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] - Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats = true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true ||RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true) && (RiziaDLC.Situation_Order_DastnuristCommunity_Happy == false && RiziaDLC.Situation_Order_GolcondistCommunity_Happy == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfie..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisf..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true ||RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true) && (RiziaDLC.Situation_Order_DastnuristCommunity_Happy == false && RiziaDLC.Situation_Order_GolcondistCommunity_Happy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true  or Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true)  and  (Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == false  and  Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Happy"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 1; RiziaDLCIsol..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true ||RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true) && (RiziaDLC.Situation_Order_DastnuristCommunity_Happy == false && RiziaDLC.Situation_Order_GolcondistCommunity_Happy == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true  or Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true)  and  (Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Happy"] == false  and  Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Happy"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AnalyticsEvent("Analytics_Rizia_HouseOfDelegates");`
- **Efekt skryptowy (`userScript`):** `AnalyticsEvent("Analytics_Rizia_HouseOfDelegates");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == ..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_LaunchCrownSupremeCampaign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)
