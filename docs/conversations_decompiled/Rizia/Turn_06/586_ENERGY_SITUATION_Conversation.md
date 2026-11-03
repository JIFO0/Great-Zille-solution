# Rizia/Turn 6/ENERGY SITUATION/ENERGY SITUATION Conversation

- **ID konwersacji:** `586`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/586_ENERGY_SITUATION_Conversation.md`
- **Liczba węzłów dialogowych:** 338
- **Liczba wyborów gracza:** 10

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[80]** Elena Werner
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Economy_EnergyProtectionAct_49Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Energy_ProjectedIncome`
- `RiziaDLC.Energy_Promised`
- `RiziaDLC.MITZ_Demand_EnergyAgreement`
- `RiziaDLC.Policy_Economy_MorellaPipeline_Project`
- `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys`
- `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed`
- `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project`
- `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed`
- `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project`
- `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed`
- `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Resources_EnergyModifiersTotal`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3`
- `RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Energy_ProjectedIncome`
- `RiziaDLC.Energy_Promised`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2`
- `RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection`
- `RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[361] Rizia/Turn 6/A_CouncilMeeting** (../Turn_06/361_A_CouncilMeeting.md), Węzeł `[77]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 39

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Energy_ProjectedIncome`
- `RiziaDLC.Energy_Promised`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2`
- `RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection`
- `RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[20]` (Paskal Beniwoll): `-- ESQIRIS CLOSURE;`
- Węzeł `[27]` (Paskal Beniwoll): `-- NO ZPANA;`
- Węzeł `[34]` (Paskal Beniwoll): `-- NO HAVAS;`
- Węzeł `[35]` (Paskal Beniwoll): `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- Węzeł `[36]` (Paskal Beniwoll): `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- Węzeł `[37]` (Paskal Beniwoll): `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 1;`
- Węzeł `[44]` (Paskal Beniwoll): `-- INVESTED IN GASOM;`
- Węzeł `[45]` (Paskal Beniwoll): `-- INVESTED IN GASOM WITH SORDLAND;`
- *...oraz 31 innych węzłów ze skryptami.*

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
  - -> `[317]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `361` (*Rizia/Turn 6/A_CouncilMeeting*), Węzeł `[77]`

### Węzeł `[3]`
Mówca: **Elena Werner**
> ""That is correct. We are heading straight into an energy crisis and we are in need of new sources as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_MorellaPipeline_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_MorellaPipeline_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_MorellaPipeline_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_MorellaPipeline_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_MorellaPipeline_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Demand_EnergyAgreement == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Demand_EnergyAgreement == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Demand_EnergyAgreement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Demand_EnergyAgreement == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Demand_EnergyAgreement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[13]`
Mówca: **Elena Werner**
> ""Thank you, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // ESQIRIS CLOSURE)*
- **Efekt (`userScript`):** `-- ESQIRIS CLOSURE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NO ZPANA)*
- **Efekt (`userScript`):** `-- NO ZPANA;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NO HAVAS)*
- **Efekt (`userScript`):** `-- NO HAVAS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // INVESTED IN GASOM)*
- **Efekt (`userScript`):** `-- INVESTED IN GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // INVESTED IN GASOM WITH SORDLAND)*
- **Efekt (`userScript`):** `-- INVESTED IN GASOM WITH SORDLAND;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // SORDLAND DIDNT LET US INVEST IN GASOM)*
- **Efekt (`userScript`):** `-- SORDLAND DIDNT LET US INVEST IN GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""It is definitely worrying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Elena Werner**
> ""But perhaps, we should start with an overview of our situation first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[51]`
Mówca: **Elena Werner**
> ""I will start with an overview of our energy situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[58]`
Mówca: **Elena Werner**
> ""Our entire energy stockpile has been exhausted. We currently have no extra energy to spare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Elena Werner**
> ""Everything is working to its limit and the situation can become alarming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[63]`
Mówca: **Elena Werner**
> ""We are rapidly exhausting all of our energy stockpile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Elena Werner**
> ""If nothing's done to reverse the situation, we may end up in a destructive situation for Rizian industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[68]`
Mówca: **Elena Werner**
> ""Despite our high energy reserves, our current consumption rate will deplete them in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[69]`
Mówca: **Elena Werner**
> ""The current size of our reserves is not at a desirable level. Our current consumption rate can deplete them in little time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[70]`
Mówca: **Elena Werner**
> ""Luckily, we are still producing enough energy to meet our demands and stay above the balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[71]`
Mówca: **Elena Werner**
> ""We are not producing enough energy to keep up with the demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Elena Werner**
> ""If this continues, our industries and the whole of our economy will suffer immensely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[76]`
Mówca: **Narrator**
> "She placed a stack of papers on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Narrator**
> "She placed a stack of papers on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[78]`
Mówca: **Elena Werner**
> ""What's worse is that our current projection for the future doesn't look any better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
Mówca: **Elena Werner**
> ""But there is a problem. Our current projection for the future doesn't look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Elena Werner**
> ""Based on our current deals and promises, including our projected energy production, we won't be able to meet the demand of our industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[84]`
Mówca: **Elena Werner**
> ""Based on our current deals and promises, including our projected energy production, we will be able to meet the demand of our industries -- if our current projects succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[85]`
Mówca: **Elena Werner**
> ""The good news is that our current projection for the future is still promising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_Promised += 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_Promised"] = Variable["RiziaDLC.Energy_Promised"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_Promised += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_Promised"] = Variable["RiziaDLC.Energy_Promised"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // INVESTED IN GASOM)*
- **Efekt (`userScript`):** `-- INVESTED IN GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // INVESTED IN GASOM WITH SORDLAND)*
- **Efekt (`userScript`):** `-- INVESTED IN GASOM WITH SORDLAND;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // SORDLAND DIDNT LET US INVEST IN GASOM)*
- **Efekt (`userScript`):** `-- SORDLAND DIDNT LET US INVEST IN GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_Promised >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_Promised >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Energy_Promised"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Energy_Promised >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_Promised"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[111]`
Mówca: **Elena Werner**
> ""I have to underline the importance of this. We cannot afford to fail our energy projects -- if we want to meet the demands of our industries and our international partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[112]`
Mówca: **Elena Werner**
> ""I have to underline the significance of this. If we cannot find new sources of energy -- we will not be able to meet the demands of our industries and our international partners at the same time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Energy_ProjectedIncome >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Elena Werner**
> ""I have to underline the significance of this. The projected energy production from our current projects are not enough to meet the demands of our industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[117]`
Mówca: **Elena Werner**
> ""I have to underline the significance of this. If we cannot find new sources of energy, we may reach a point of no return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have to deal with the energy problem immediately. What are your suggestions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true || (RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true || (RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true  or  (Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true || (RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true  or  (Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is the current projection for our future energy production?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Ms. Werner. I have enough information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Energy_ProjectedIncome >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Elena Werner**
> ""Fortunately, at the moment, our energy demands are being met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[134]`
Mówca: **Elena Werner**
> ""At the moment, our energy demands are not being met...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Energy_ProjectedIncome >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Elena Werner**
> ""...And unfortunately we don't have any ongoing projects or deals that will result in more energy output.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[139]`
Mówca: **Elena Werner**
> ""Since there are no active projects, our prediction is that our energy output will stay stagnant in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[140]`
Mówca: **Elena Werner**
> ""...But unfortunately we don't have any ongoing projects or deals that will result in more energy output.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[141]`
Mówca: **Elena Werner**
> ""...But we have additional projects that we're predicting more energy returns from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Elena Werner**
> ""...Fortunately, we have additional projects that we're predicting some energy returns from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // ESQIRIS CLOSURE)*
- **Efekt (`userScript`):** `-- ESQIRIS CLOSURE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NO ZPANA)*
- **Efekt (`userScript`):** `-- NO ZPANA;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NO HAVAS)*
- **Efekt (`userScript`):** `-- NO HAVAS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[173]`
Mówca: **Elena Werner**
> ""Our negotiations with Sordland about the Gasom deal also fell flat. The new Sordish president decided not to allow us to invest. So there's no projected income from there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[174]`
Mówca: **Elena Werner**
> ""Thanks to Your Majesty's decision to expand the Esqiris Gas Field, our facilities in Esqiris will be able to continue their production with no problems -- and with a higher output than before when it is finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[175]`
Mówca: **Elena Werner**
> ""The Zpana Hydroelectric Dam Project is continuing with speed. If it succeeds, our projection is that it will provide some relief for our energy industry. As a renewable alternative, it will provide a strategic value for us as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[176]`
Mówca: **Elena Werner**
> ""Although not much by itself, the ongoing Havas Coal Mine Project is projected to bring a little relief to our energy situation when it starts working.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Elena Werner**
> ""...But we may still have additional opportunities that we may get more energy returns from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NO PROJECTION OF GASOM)*
- **Efekt (`userScript`):** `-- NO PROJECTION OF GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[188]`
Mówca: **Elena Werner**
> ""Firstly, I want to talk about our deal with Gasom, the Sordish gas giant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NO PROJECTION OF GASOM)*
- **Efekt (`userScript`):** `-- NO PROJECTION OF GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[196]`
Mówca: **Elena Werner**
> ""Additionally, there is our deal with Gasom, the Sordish gas giant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[197]`
Mówca: **Elena Werner**
> ""Thanks to President Rayne's removal of their laws that previously limited foreign investment, we were able to obtain the majority of the shares together with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[198]`
Mówca: **Elena Werner**
> ""Thanks to President Rayne's changes to their laws that previously limited foreign investment, we were able to obtain a good portion of their company together with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[199]`
Mówca: **Elena Werner**
> ""Additionally, there was our deal with Gasom, the Sordish gas giant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Elena Werner**
> ""Unfortunately, the Sordish Energy Protection Act seriously limits foreign investment, so we weren't able to obtain the amount of shares we wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Elena Werner**
> ""Although it could still provide us with some finances, we are not expecting too much from that deal in terms of energy output.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[202]`
Mówca: **Elena Werner**
> ""Therefore, we would be able to execute our original plan and divert some of the Sordish gas to Rizia. It is expected that the returns can provide some relief for our energy production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
Mówca: **Elena Werner**
> ""Although we may not be able to execute our original plan and divert most of the Sordish gas to Rizia, it is still expected that the returns may provide a little relief for our energy production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
Mówca: **Elena Werner**
> ""Unfortunately, the only projection we can currently make is about the disputed Aureus Gas Field. Therefore, it is of immense value to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[205]`
Mówca: **Elena Werner**
> ""Most importantly, there is the issue with the disputed Aureus Gas Field. The predicted gas output from that field is of immense value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[206]`
Mówca: **Elena Werner**
> ""And finally, there is the disputed Aureus Gas Field. The predicted gas output from that field is of immense value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Elena Werner**
> ""There is, of course, the disputed Aureus Gas Field. The predicted gas output from that field is of immense value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Elena Werner**
> ""But with our current situation, we won't be able to reap much benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Narrator**
> "She took a look at her notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[224]`
  - -> `[227]`
  - -> `[228]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In light of the current energy situation, we may need to rethink our strategy about the field. We cannot allow Lespia or Pales to take it from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is the current situation with our extraction of gas there? I believe the Duke is respecting our purchase deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how does the estimated value fit into our current projection?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is the predicted gas output from Aureus enough to support our energy demands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Elena Werner**
> ""We own the rights to the entire field. That's enough energy to supply us for decades to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Elena Werner**
> ""Now that preliminary drilling is almost complete, I am confident that we will be reaping the benefits sooner than later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[237]`
Mówca: **Elena Werner**
> ""But unfortunately, given the concessions we made to the Duke of Pales, any energy we'll receive from the field will be of negligible importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[238]`
Mówca: **Elena Werner**
> ""But we can get into the details of that in a second. I believe Mr. Esquibel has some news from the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[239]`
Mówca: **Elena Werner**
> ""Even half of that field would grant us immense relief from our energy woes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[240]`
Mówca: **Elena Werner**
> ""Do you have any other questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[252]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but in light of the current energy situation, we may need to rethink our strategy about the field. We cannot allow Lespia or Pales to take it from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Hub_EnergyProjection)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[300]`
  - -> `[126]`
  - -> `[309]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hub_EnergyProjection])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[253]`
Mówca: **Elena Werner**
> ""So far, we have worked in cooperation to prepare our side of the field for extraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Elena Werner**
> ""As negotiated with Duke Reinhart, the entire rights will be officially transferred to us after we sign the official treaty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[307]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Player_Romus: ""And how does the estimated value f..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Player_Romus: ""Is the predicted gas output from A..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[261]`
Mówca: **Narrator**
> "Elena looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Hugo Toras**
> ""I fully agree with His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Hugo Toras**
> ""But perhaps we should first talk about the news from Pales, if we're done with the energy overview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[265]`
Mówca: **Elena Werner**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Narrator**
> "She bowed in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have any suggestions on how to improve our energy situation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true) && (RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true) && (RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true)  and  (Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true) && (RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true)  and  (Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[271]`
Mówca: **Elena Werner**
> ""The only potential new energy source on the horizon is the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[275]`
Mówca: **Elena Werner**
> ""Therefore, it is very important that we sign the official treaty as soon as possible and make our purchase recognized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[276]`
Mówca: **Elena Werner**
> ""I believe Mr. Esquibel has some news to share about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Elena Werner**
> ""But of course, we're ceding our claim to it, so there's not much space for movement there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Laurento Esquibel**
> ""We can always negotiate better deals and import energy from our partners when necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hub_EnergyProjection])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[283]`
Mówca: **Narrator**
> "Laurento nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[293]`
Mówca: **Elena Werner**
> ""Unfortunately, the closure of the Esqiris Gas Field was a huge blow for our energy production. We have to find new sources to replace it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[294]`
Mówca: **Elena Werner**
> ""One suggestion I have is to sign the plans for the Zpana Hydroelectic Dam. Not only will it provide some relief for our energy industry, it has strategic value as a renewable alternative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[295]`
Mówca: **Elena Werner**
> ""I wouldn't say coal is a long-term energy solution, but constructing a new mine in Havas would help us out to some degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Elena Werner**
> ""Vast stretches of Rizia remain unexplored where resources are concerned. Commissioning a mining survey could uncover their potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[297]`
Mówca: **Elena Werner**
> ""And then there's the Aureus gas field...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[306]`
Mówca: **Elena Werner**
> ""Of course. Did you have any other questions about our energy situation, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hub_EnergyProjection])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hub_EnergyProjection])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true && RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true &&
RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true && RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true &&
RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true  and  Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true && RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true &&
RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true  and  Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's good enough. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // ESQIRIS OPEN)*
- **Efekt (`userScript`):** `-- ESQIRIS OPEN;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // ZPANA OPEN)*
- **Efekt (`userScript`):** `-- ZPANA OPEN;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HAVAS OPEN)*
- **Efekt (`userScript`):** `-- HAVAS OPEN;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // PROJECTED ENERGY INCOME ENDS)*
- **Efekt (`userScript`):** `-- PROJECTED ENERGY INCOME ENDS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // PROJECTED ENERGY INCOME)*
- **Efekt (`userScript`):** `-- PROJECTED ENERGY INCOME;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // PROMISED ENERGY EXPORTS)*
- **Efekt (`userScript`):** `-- PROMISED ENERGY EXPORTS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NO GASOM GAINS)*
- **Efekt (`userScript`):** `-- NO GASOM GAINS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_ProjectedIncome += 4)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Elena Werner**
> ""The current size of our reserves is already very troubling. Our current consumption rate will deplete them in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[332]`
Mówca: **Elena Werner**
> ""The energy reserves already depleted and we are struggling to find new reserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Elena Werner**
> ""We are fearing significant blackouts or other issues that might arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[337]`
Mówca: **Elena Werner**
> ""Experts say we could have untapped coal deposits in the south, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
