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
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon > 0)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 8; RiziaDLCIsol..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 5"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras >= 5)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 6; RiziaDLCIsol..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 0"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Refo..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Re..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Refo..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 10"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras >= 10)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 5"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 6;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 4`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 6;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 0"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras >= 0)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 3; RiziaDLCIsol..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1; RiziaDLCIsol..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 3;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 7`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 3;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 30"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 20`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 1;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 9`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 1;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 9;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Refo..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Average == t..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Good == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == t..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 20;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 5"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion >= 5)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Generous"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 5"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 0"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC  += 15; RiziaDLCIs..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 20"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EvaluateConditionalInstruction("HouseElection_RPPWins");`
- **Efekt skryptowy (`userScript`):** `EvaluateConditionalInstruction("HouseElection_RPPWins");`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro < 0)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Refo..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Refo..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Refo..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Re..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true || RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true  or  Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 8;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 8;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 30`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 30"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 20`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10; RiziaDLCIso..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 30"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 30`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC  += 15;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 5`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]  =  + 15;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolat..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) >= 15`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] -Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]) >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats = true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) >= 15)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] -Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]) >= 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "EvaluateConditionalInstruction("HouseElection_RPPWins");"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "EvaluateConditionalInstruction("HouseElection_RNCWins");"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolat..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] -Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]) < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats = true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated.Turn06_VotingCalc_RNC) < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] -Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"]) < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_StatusQuo = true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_StatusQuo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.HouseElections_StatusQuo"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EvaluateConditionalInstruction("HouseElection_RNCWins");`
- **Efekt skryptowy (`userScript`):** `EvaluateConditionalInstruction("HouseElection_RNCWins");`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC -= 15`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] - 15;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_RNCElectionFund_Moderate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion >= 0"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion >= 0)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20; RiziaDLCIso..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == ..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10; RiziaDLCIso..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Acceptable == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 30"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 30`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 30`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 30;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 20`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Good == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Good == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20; RiziaDLCIso..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 30"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10; RiziaDLCIso..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC  += 15; RiziaDLCIs..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn05_RNCElectionFund_Generous == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RNC -= 15"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "(RiziaDLCIsolated.Turn06_VotingCalc_RPP -RiziaDLCIsolated..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RNC += 10;
RiziaDLCIsolated.Turn06_VotingCalc_RPP += 10`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 10;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 20;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 15; RiziaDLCIso..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_VotingCalc_RPP += 15;
RiziaDLCIsolated.Turn06_VotingCalc_RNC += 5`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RPP"] + 15;
Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] = Variable["RiziaDLCIsolated.Turn06_VotingCalc_RNC"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_VotingCalc_RPP += 20"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "//"*)
