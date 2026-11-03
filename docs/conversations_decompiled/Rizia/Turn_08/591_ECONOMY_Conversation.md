# Rizia/Turn 8/ECONOMY/ECONOMY Conversation

- **ID konwersacji:** `591`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/591_ECONOMY_Conversation.md`
- **Liczba węzłów dialogowych:** 483
- **Liczba wyborów gracza:** 62

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena`
- `RiziaDLC.EnergyCrisis_Happened_BeforeTurn8`
- `RiziaDLC.Focus_Economy_Diversification`
- `RiziaDLC.Focus_Economy_Resource`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Economy_Diversified`
- `RiziaDLC.Policy_Economy_ResourceBased`
- `RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange`
- `RiziaDLC.Policy_RD_Economy_WarProfitsTax`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_BudgetModifiersTotal`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_Arrested`
- `RiziaDLC.Rusty_GrantROGStake`
- `RiziaDLC.Rusty_Hostile`
- `RiziaDLC.Rusty_KnownLespianAgent`
- `RiziaDLC.Situation_Diplomacy_GlobalImage_Good`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLC.Situation_Economy_NewBusiness_MassiveRise`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth`
- `RiziaDLC.Situation_Economy_ProductionCapacity_Average`
- `RiziaDLC.Situation_Economy_ProductionCapacity_High`
- `RiziaDLC.Situation_Economy_ProductionCapacity_Low`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Effective`
- `RiziaDLC.Situation_Welfare_LivingStandards_Good`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Situation_Welfare_WorkersRights_Bad`
- `RiziaDLC.Situation_Welfare_WorkersRights_Horrible`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Unrest_Nationalist_Grows`
- `RiziaDLC.Unrest_Religious_Grows`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLC.War_Pales_LespianSupport`
- `RiziaDLCIsolated.Turn08_Council_RustyAgent`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_RizianGoldIndustry`
- `RiziaDLC.Enable_RRG_Nationalization`
- `RiziaDLC.Energy_Modifier_SoldROGStake`
- `RiziaDLC.NationalizeRRG_War`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_Arrested`
- `RiziaDLC.Rusty_Fled`
- `RiziaDLC.Turn08_A_CouncilEconomy_BigBoost`
- `RiziaDLC.Turn08_A_CouncilEconomy_SmallBoost`
- `RiziaDLCSupport.Journal_Turn08_CouncilEconomy_BigBoost`
- `RiziaDLCSupport.Journal_Turn08_CouncilEconomy_SmallBoost`
- `RiziaDLCSupport.News_Turn08_G_RustyArrested`
- `RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost`
- `RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusinessRise`
- `RiziaDLCSupport.News_Turn08_RH_Economy_NewBusiness_SlowGrowth`
- `RiziaDLCSupport.News_Turn08_RH_RustyArrested`
- `RiziaDLCSupport.News_Turn08_V_CouncilEconomy_NewBusinessCollapse`
- `RiziaDLCSupport.News_Turn08_V_Economy_NewBusiness_ReductionCollapse`
- `RiziaDLCSupport.News_Turn08_V_RRGNationalization`
- `RiziaDLCSupport.Reports_Turn08_Bronaz_NewBusinessRise`
- `RiziaDLCSupport.Reports_Turn08_Bronaz_RustyFled`
- `RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest`
- `RiziaDLCSupport.Reports_Turn08_Qalus_NewBusiness_SlowGrowth`
- `RiziaDLCSupport.Reports_Turn08_Sallabes_NewBusinessCollapse`
- `RiziaDLCSupport.Reports_Turn08_Topes_NewBusinessReductionCollapse`
- `RiziaDLCText.RustyArrestReason`
- `RiziaDLCText.RustyFate`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[419] Rizia/Turn 8/A_GeneralCouncilMeeting** (../Turn_08/419_A_GeneralCouncilMeeting.md), Węzeł `[282]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 16

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_RizianGoldIndustry`
- `RiziaDLC.Energy_Modifier_SoldROGStake`
- `RiziaDLC.NationalizeRRG_War`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Turn08_A_CouncilEconomy_BigBoost`
- `RiziaDLC.Turn08_A_CouncilEconomy_SmallBoost`
- `RiziaDLCSupport.Journal_Turn08_CouncilEconomy_BigBoost`
- `RiziaDLCSupport.Journal_Turn08_CouncilEconomy_SmallBoost`
- `RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost`
- `RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusinessRise`
- `RiziaDLCSupport.News_Turn08_RH_Economy_NewBusiness_SlowGrowth`
- `RiziaDLCSupport.News_Turn08_V_CouncilEconomy_NewBusinessCollapse`
- *...oraz 1 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[51]` (Paskal Beniwoll): `--;`
- Węzeł `[68]` (Paskal Beniwoll): `--;`
- Węzeł `[87]` (Paskal Beniwoll): `--;`
- Węzeł `[112]` (Paskal Beniwoll): `--;`
- Węzeł `[137]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusinessRise"] = true; Variable["Rizia...`
- Węzeł `[138]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn08_Topes_NewBusinessReductionCollapse"] = true; Variable["R...`
- Węzeł `[139]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn08_Sallabes_NewBusinessCollapse"] = true; Variable["RiziaDL...`
- Węzeł `[153]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4; Variable["Rizi...`
- *...oraz 8 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `419` (*Rizia/Turn 8/A_GeneralCouncilMeeting*), Węzeł `[282]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Elena took out her ledger, placed it on the table and opened it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[4]`
Mówca: **Elena Werner**
> ""We have a very significant amount of money flowing into our economy. This is a great indicator for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Elena Werner**
> ""As already mentioned, living standards in Rizia have improved by leaps and bounds thanks to the Crown's economic policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[15]`
Mówca: **Elena Werner**
> ""As already mentioned, living standards in Rizia are in a very healthy position as a result of a combination of economic policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] == 0  and  Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal == 0 && RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] == 0  and  Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[31]`
Mówca: **Elena Werner**
> ""However, we are rapidly losing money. We should try to get out of our current deficit situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[32]`
Mówca: **Elena Werner**
> ""However, we're not seeing a net increase in government income. We're keeping a budgetary balance at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[33]`
Mówca: **Elena Werner**
> ""We have a significant amount of money flowing into our economy. This is a good indicator for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[34]`
Mówca: **Elena Werner**
> ""We have a balanced budget at the moment. Our economy could be better, but this isn't a bad indicator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[35]`
Mówca: **Elena Werner**
> ""We are rapidly losing money. We should try to get out of our current deficit situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
Mówca: **Elena Werner**
> ""Luckily, we have enough reserves to give us time to make improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[46]`
Mówca: **Elena Werner**
> ""And our reserves may not be enough to give us the time we need to make improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[47]`
Mówca: **Elena Werner**
> ""We also have enough funds in reserve that we can begin planning more ambitious projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
Mówca: **Elena Werner**
> ""We also have some reserves with which we can fund projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Elena Werner**
> ""But at the moment, we don't have any money to spend on new projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Elena Werner**
> ""And unfortunately, we lack the funds to make any improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "She turned a page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_WarProfitsTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_WarProfitsTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_WarProfitsTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_WarProfitsTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_WarProfitsTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[59]`
Mówca: **Elena Werner**
> ""Of course, the war has influenced my department very negatively, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[60]`
Mówca: **Elena Werner**
> ""While the war profits tax is helping with our immediate finances, it is stifling the growth of our economy. This may have lasting effects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`
  - -> `[64]`
  - -> `[205]`

### Węzeł `[61]`
Mówca: **Elena Werner**
> ""The war expenses are putting a crimp in our economy. If this continues for much longer, it may have a lasting impact on our growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`
  - -> `[64]`
  - -> `[205]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to hear excuses. I want to hear solutions and results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your comments are appreciated, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are doing our best to end the war as quickly as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Elena Werner**
> ""I don't doubt it, Your Majesty. I know our military will come out on top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[66]`
Mówca: **Elena Werner**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[67]`
Mówca: **Elena Werner**
> ""Unfortunately, the energy crisis continues with no end in sight. I believe this should be our most significant concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Elena Werner**
> ""As long as our industries' energy demands are not being met, they will not operate at full capacity. And our economy will suffer for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[73]`
Mówca: **Elena Werner**
> ""Fortunately, we've managed to rescue ourselves from the energy crisis of a few years ago. The demands of our industries are finally being met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ProductionCapacity_High == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ProductionCapacity_High == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ProductionCapacity_High"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_ProductionCapacity_High == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ProductionCapacity_High"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[77]`
Mówca: **Elena Werner**
> ""I'm pleased to say our production capacity has increased significantly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`
  - -> `[118]`

### Węzeł `[78]`
Mówca: **Elena Werner**
> ""Unfortunately, we are still only seeing average production capacity. This is something to work on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[118]`
  - -> `[117]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ProductionCapacity_Low == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ProductionCapacity_Low == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ProductionCapacity_Low"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_ProductionCapacity_Low == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ProductionCapacity_Low"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Elena Werner**
> ""I am afraid our production capacity has already suffered significantly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[83]`
Mówca: **Elena Werner**
> ""Fortunately, our production capacity hasn't collapsed just yet -- which is surprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[115]`
  - -> `[116]`
  - -> `[114]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[88]`
Mówca: **Elena Werner**
> ""With the current wave of robust economic growth, buoyed by market incentives to attract fresh investments, we are witnessing the formation of thousands of new businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Elena Werner**
> ""In light of the recent slowdown in growth, paired with forecasts suggesting the potential onset of a recession next year, we are observing a notable decline in investment activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[93]`
Mówca: **Elena Werner**
> ""As we find ourselves increasingly mired in what appears to be a deepening recession, there is an alarming trend of substantial withdrawal of investments across the board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[94]`
Mówca: **Elena Werner**
> ""So far, we have managed to greatly diversify our energy sources. This helps our economic options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_Diversified == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_Diversified == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_Diversified"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_Diversified == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_Diversified"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_ResourceBased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_ResourceBased == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_ResourceBased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_ResourceBased == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_ResourceBased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[104]`
Mówca: **Elena Werner**
> ""Despite this, however, the energy crisis continues with no end in sight. Tackling this should be our number-one concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[105]`
Mówca: **Elena Werner**
> ""Currently, we have a very rigid energy economy with heavy reliance on certain sources. Our future is looking strong -- as long as access to those resources remains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[106]`
Mówca: **Elena Werner**
> ""So far, we seem to have a mixed energy economy. But I believe we must diversify our sources further in order to cover potential weaknesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Elena Werner**
> ""Therefore, the energy crisis continues with no end in sight. I believe this should be our most significant concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[111]`
Mówca: **Elena Werner**
> ""Despite this, however, we've managed to dig ourselves out of the energy crisis. The demands of our industries are finally being met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is worrying news. I'll look into ways to solve this energy crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surprising? Are you saying you expect our production to collapse?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for sharing this, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a significant problem. What should we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is worrying news. I'll look into ways to increase our production capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for sharing this, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is still good news. Thank you for your contributions, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is great news. Thank you for all your contributions, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[122]`
Mówca: **Elena Werner**
> ""We should either seek new sources of energy or improve our current extraction capacity. Or both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Elena Werner**
> ""If the energy crisis continues, that is our projection, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[124]`
Mówca: **Laurento Esquibel**
> ""We could look to our neighbors. Perhaps we can work out an import deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Diversification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Diversification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Diversification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Economy_Diversification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Diversification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Resource == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Economy_Resource == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Resource"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Economy_Resource == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Resource"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[131]`
Mówca: **Elena Werner**
> ""When you ascended the throne, we set a focus to diversify the Rizian economy away from resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[132]`
Mówca: **Elena Werner**
> ""When you ascended the throne, we set a focus to further the Rizian resource economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[133]`
Mówca: **Elena Werner**
> ""When you ascended the throne, we agreed to focus on a mixed approach for the Rizian economy -- balancing resources and other industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusinessRise = true;
RiziaDLCSupport.Reports_Turn08_Bronaz_NewBusinessRise = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_NewBusinessRise"] = true;
Variable["RiziaDLCSupport.Reports_Turn08_Bronaz_NewBusinessRise"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn08_Topes_NewBusinessReductionCollapse = true;
RiziaDLCSupport.News_Turn08_V_Economy_NewBusiness_ReductionCollapse = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_Topes_NewBusinessReductionCollapse"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_Economy_NewBusiness_ReductionCollapse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn08_Sallabes_NewBusinessCollapse = true;
RiziaDLCSupport.News_Turn08_V_CouncilEconomy_NewBusinessCollapse = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_Sallabes_NewBusinessCollapse"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_CouncilEconomy_NewBusinessCollapse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Elena Werner**
> ""Jobs are being created; employment rates are skyrocketing. It's a good time to be an entrepreneur in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`
  - -> `[208]`

### Węzeł `[144]`
Mówca: **Elena Werner**
> ""This downturn is harming new businesses and forcing cutbacks, resulting in a shrinking job market and posing serious challenges to our economic stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[154]`
  - -> `[150]`
  - -> `[147]`
  - -> `[219]`

### Węzeł `[145]`
Mówca: **Elena Werner**
> ""This economic climate is dire for new businesses, leading to increased insolvencies and a significant rise in unemployment, which is severely impacting our workforce and marking a tough phase for Rizia’s overall economic health.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[154]`
  - -> `[150]`
  - -> `[147]`
  - -> `[219]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the Lord guide us through these fiscally trying times and set us once more on a path to prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is disconcerting news. We must act decisively to prevent our country from faltering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We couldn't have done it without you, Ms. Werner. You should be proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as nobody makes *too* much money. We don't want another Rusty on our hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 4;
RiziaDLC.Turn08_A_CouncilEconomy_BigBoost = true;
RiziaDLCSupport.Journal_Turn08_CouncilEconomy_BigBoost = true;
RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;
Variable["RiziaDLC.Turn08_A_CouncilEconomy_BigBoost"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_CouncilEconomy_BigBoost"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal >= 5 && RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 5  and  Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 2;
RiziaDLC.Turn08_A_CouncilEconomy_SmallBoost = true;
RiziaDLCSupport.Journal_Turn08_CouncilEconomy_SmallBoost = true;
RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLC.Turn08_A_CouncilEconomy_SmallBoost"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_CouncilEconomy_SmallBoost"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_CouncilEconomy_Boost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[158]`
Mówca: **Elena Werner**
> ""That's an incredible gesture of trust, Your Majesty. I will not let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[159]`
Mówca: **Elena Werner**
> ""Thank you for your gesture of trust, Your Majesty. I'll be sure to use these funds judiciously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And a horrible time to be a worker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There must be additional strategies we can employ, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""We have reserves in our treasury. Let’s strategically invest them to bolster our economic standing." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""We have reserves in our treasury. Let’s strategically invest them to bolster our economic standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""Allocate several billion guilders to mitigate this economic downturn. I entrust you with overseeing this crucial initiative." [-4 Budget]"]** — Mówca: **Player_Romus**
> ""Allocate several billion guilders to mitigate this economic downturn. I entrust you with overseeing this crucial initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[164]`
Mówca: **Elena Werner**
> ""You're too modest, Your Majesty. You had the final say on all of these decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[165]`
Mówca: **Elena Werner**
> ""Rusty was a special case, Your Majesty. I foresee only gains coming from this growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[166]`
Mówca: **Elena Werner**
> ""We've been over this, Your Majesty. If you want to improve workers' rights, I will assist you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[167]`
Mówca: **Elena Werner**
> ""I agree wholeheartedly. I'm exploring every possible option to strengthen our economy further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[168]`
Mówca: **Elena Werner**
> ""Rest assured, I am fully dedicated to preventing any further economic decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[169]`
Mówca: **Elena Werner**
> ""Yes. In the meantime, I will see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_BudgetModifiersTotal >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_BudgetModifiersTotal >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[173]`
Mówca: **Elena Werner**
> ""We have a small budget surplus at the moment. This isn't a bad indicator for our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ProductionCapacity_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_ProductionCapacity_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_ProductionCapacity_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_ProductionCapacity_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_ProductionCapacity_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Elena Werner**
> ""Sadly, our goods are no longer in demand around the country and the world. Our industrial production capacity has fallen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[117]`
  - -> `[178]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not worried. We will bounce back eventually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.EnergyCrisis_Happened_BeforeTurn8 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.EnergyCrisis_Happened_BeforeTurn8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[192]`
Mówca: **Elena Werner**
> ""Unfortunately, however, we are now slipping into an energy crisis. I believe this must be our most significant concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Unrest_Nationalist_Grows"] == true  or  Variable["RiziaDLC.Unrest_Religious_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Unrest_Nationalist_Grows"] == true  or  Variable["RiziaDLC.Unrest_Religious_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[196]`
Mówca: **Elena Werner**
> ""I'm happy to report that the Crown's economic policies have drastically improved living standards in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Unrest_Nationalist_Grows"] == true  or  Variable["RiziaDLC.Unrest_Religious_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Unrest_Nationalist_Grows == true || RiziaDLC.Unrest_Religious_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Unrest_Nationalist_Grows"] == true  or  Variable["RiziaDLC.Unrest_Religious_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[200]`
Mówca: **Elena Werner**
> ""I'm happy to report that living standards in Rizia are in a very healthy position as a result of a combination of economic policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[204]`
Mówca: **Elena Werner**
> ""We don't have enough funds to tackle the situation the way I'd like to. But selling energy is still an option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what will have a lasting impact? Claiming Pales and all the resources that come with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[206]`
Mówca: **Elena Werner**
> ""Moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[207]`
Mówca: **Elena Werner**
> ""As for our business climate...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And a good time to be a worker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Elena Werner**
> ""A rising tide lifts all boats, as the Alphonso administration was fond of saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Elena Werner**
> ""Yes, if the economy's good enough, everyone wins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[217]`
Mówca: **Narrator**
> "A look of incredulity spread across Elena's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[218]`
Mówca: **Narrator**
> "A confident smile spread across Elena's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_KnownLespianAgent == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_Council_RustyAgent == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_Council_RustyAgent == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_Council_RustyAgent == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[229]`
Mówca: **Elena Werner**
> ""There is one major economic factor we have not discussed yet. Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Narrator**
> "The others around the table exchanged significant looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Elena Werner**
> ""But I assume we'll get to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[232]`
Mówca: **Elena Werner**
> ""All this is not taking into account the potential impact of nationalizing Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Narrator**
> "She and Lucita exchanged looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Narrator**
> "She and Titus exchanged looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[241]`
Mówca: **Narrator**
> "She and Taddeus exchanged looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Elena Werner**
> ""Assuming all goes well with Rusty Montoro's arrest, a government takeover of the company will be relatively easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[246]`
Mówca: **Elena Werner**
> ""It will cost us some resources in the short term, but gain us a considerable amount of income that we'll be able to reinvest into other sectors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_MassiveRise == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_MassiveRise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[253]`
Mówca: **Elena Werner**
> ""Inevitably, some investors will be scared off. But in the current climate, we can afford to lose them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`
  - -> `[273]`
  - -> `[262]`

### Węzeł `[254]`
Mówca: **Elena Werner**
> ""Inevitably, though, some investors will be scared off. Which is something to consider in our current economic climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[273]`
  - -> `[262]`

### Węzeł `[255]`
Mówca: **Elena Werner**
> ""Inevitably, though, investors will be scared off. Which is something we can ill afford in today's economic climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[273]`
  - -> `[262]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To hell with what investors think. We ought to put the 'Royal' back in Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have to nationalize the company by force. We can buy our way to a stakeholder majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty isn't even in prison yet. We'll decide this later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Elena Werner**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[260]`
Mówca: **Elena Werner**
> ""That won't be cheap. But it may be worth it to keep Rizia's other business owners on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[261]`
Mówca: **Elena Werner**
> ""We'll make our move after our security forces make theirs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever losses we incur will be worth it for the chance to pry our resources out of the hands of greedy oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Elena Werner**
> ""My goodness. You're starting to sound like Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[267]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Elena Werner**
> ""If we decide to imprison Rusty Montoro, a government takeover of the company will be relatively easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Elena Werner**
> ""If it comes to that, I will have the documents ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A little overeager, aren't you? I haven't even spoken to Rusty about all this yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Elena Werner**
> ""You're right. The decision can wait.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[281]`
Mówca: **Hugo Toras**
> ""There is one economic factor we have not discussed yet. Rizian Royal Gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Narrator**
> "Everyone turned towards Hugo. Elena gestured for him to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Hugo Toras**
> ""In times of emergency -- such as war -- the Crown reserves the right to nationalize any corporation deemed essential to the defense and security of the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[284]`
Mówca: **Elena Werner**
> ""That's it for the economy, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[285]`
Mówca: **Narrator**
> "She closed her book."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""One could argue that Rizian Royal Gold belongs to this category.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[289]`
  - -> `[294]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty does have known ties to Arcasia. And ATO is taking Pales' side in the war...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we want to keep funding this war, such a measure may be necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget < 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget < 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can fund this war without resorting to such measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One could. But I would rather stay on Rusty Montoro's good side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Hostile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Hostile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Hostile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Hostile == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Hostile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I know Rusty Montoro, he won't allow this without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[298]`
Mówca: **Laurento Esquibel**
> ""We have no reason to believe Arcasia is involved in Pales, Your Majesty. Directly or indirectly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[299]`
Mówca: **Elena Werner**
> ""I believe so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[300]`
Mówca: **Elena Werner**
> ""Legally, he won't have any recourse to oppose such a measure. But he can definitely make it very difficult for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[301]`
Mówca: **Elena Werner**
> ""Your Grace, as it stands, Rizian Royal Gold is a valuable asset to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[302]`
Mówca: **Lucita Azaro**
> ""But Lespia is supporting the Palesians. And everyone knows they're Arcasia's lapdog.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_LespianSupport > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_LespianSupport > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_LespianSupport"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_LespianSupport > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_LespianSupport"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Lucita Azaro**
> ""But Lespia may still be covertly supporting the Palesians. And everyone knows they're Arcasia's lapdog.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""Yes, thank you for bringing this up, Your Grace. The extra funds provided by nationalization would indeed be of immense help to the war effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Narrator**
> "Elena looked at them both uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Elena Werner**
> ""We should not underestimate the difficulty of this endeavor. The resources we spend on nationalizing RRG may not be worth the long-term gains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[310]`
Mówca: **Elena Werner**
> ""Be that as it may, we should not underestimate the difficulty of this endeavor. The resources we spend on nationalizing RRG may not be worth the long-term gains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[311]`
Mówca: **Elena Werner**
> ""The effort we expend on this may not be worth the long-term gains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[312]`
Mówca: **Narrator**
> "She paused thoughtfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[313]`
Mówca: **Elena Werner**
> ""Nationalization would allow us to extract more value from it, it's true. But at quite a large upfront cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[317]`
Mówca: **Elena Werner**
> ""Then again, if your goal is to keep the left-wingers in the RPP from causing a stir, taking Rizia's most renowned corporation out of private hands might do the trick. For a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`
  - -> `[320]`
  - -> `[321]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have the feeling Soletato's people will not be appeased that easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sotelato is a former miner, isn't he? It'll make him happy to see his ex-boss lose everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nationalization means putting RRG *into* the hands of the Royal Family. They'd hate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So all of a sudden a ragtag bunch of radicals are more important to please than Rizian business owners?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[322]`
Mówca: **Lucita Azaro**
> ""Yes, and there are other ways to deal with Sotelato.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[323]`
Mówca: **Elena Werner**
> ""Maybe not. But in combination with other policies, perhaps...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[324]`
Mówca: **Vina Toras**
> ""Father. Do you really think the reformists are that petty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Lucita Azaro**
> ""Happy enough to drop his threats against the crown? I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Lucita Azaro**
> ""Of course not, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Lucita Azaro**
> ""With that said, nationalization isn't as complicated as Ms. Werner is making it out to be. A swift raid on Montoro's Bronaz palace, and we'll have all the necessary assets secured before he can blink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`
  - -> `[342]`
  - -> `[380]`

### Węzeł `[331]`
Mówca: **Lucita Azaro**
> ""There are other ways to deal with Sotelato. We don't need to acknowledge the demands of him or his 'movement'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[332]`
Mówca: **Lucita Azaro**
> ""Please, Your Highness. Sotelato's no more of a saint than Manus Sazon was. But we shouldn't feel compelled to nationalize RRG solely on his behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[333]`
Mówca: **Lucita Azaro**
> ""If I may chime in, nationalization isn't as complicated as Ms. Werner is making it out to be. A swift raid on Montoro's Bronaz palace, and we'll have all the necessary assets secured before he can blink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`
  - -> `[342]`
  - -> `[380]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Lucita Azaro**
> ""Sotelato's no saint, Your Highness. But we shouldn't feel compelled to nationalize RRG solely on his behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty put his heart and soul into RRG. If we're to nationalize, he and the other stakeholders should be justly compensated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A dangerous proposition, Duchess Azaro. What if he and his guards get wind of the operation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Montoro was just starting to become useful to me. I don't want to throw away our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Elena Werner**
> ""Sensible, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That will take manpower. We can't afford to pull people from the front lines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[343]`
Mówca: **Hugo Toras**
> ""His heart and soul... As if Montoro was in possession of either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Lucita Azaro**
> ""There's always that risk. We'd have to make wise use of our intelligence services to gauge the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[345]`
Mówca: **Elena Werner**
> ""Compensation would put Rizia's other business owners at ease. But I fear Montoro won't grant us even that opportunity unless he is forced to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Lucita Azaro**
> ""With sufficient intelligence, we can complete the task with a small core team.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Narrator**
> "Elena looked around the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[348]`
Mówca: **Elena Werner**
> ""It is His Majesty's decision. I admit we could use the extra budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`
  - -> `[355]`
  - -> `[361]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget < 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget < 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Elena Werner**
> ""It is His Majesty's decision. Keeping in mind that we don't strictly need the extra budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`
  - -> `[355]`
  - -> `[361]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For the security of the kingdom, it is vital that we nationalize Rizian Royal Gold. Lucita, you have my permission to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to thank His Grace Hugo for bringing up the matter. Rusty's had this coming for a long time. I say we do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am satisfied with the Crown's current stake in Rizian Royal Gold. Nationalization is not worth the effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[356]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[357]`
Mówca: **Hugo Toras**
> ""Very good, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Elena Werner**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.NationalizeRRG_War = true;
RiziaDLC.Enable_RRG_Nationalization = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.NationalizeRRG_War"] = true;
Variable["RiziaDLC.Enable_RRG_Nationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the current state of our intelligence services, this is a risk we cannot afford to take. We will leave RRG alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested = true;
RiziaDLC.Rusty_Allied = false;
RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest = true;
EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested");
RiziaDLC.Enable_RRG_Nationalization = true;
RiziaDLCText.RustyArrestReason = "as part of a sweeping wartime seizure of the Rizian Royal Gold corporation";
RiziaDLCSupport.News_Turn08_G_RustyArrested = true;
RiziaDLCSupport.News_Turn08_RH_RustyArrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rusty_Arrested"] = true;
Variable["RiziaDLC.Rusty_Allied"] = false;
Variable["RiziaDLCSupport.Reports_Turn08_Bronaz_RustyLespiaArrest"] = true;
EnableCodexEntry("Characters_Business_RusselloMontoro_Arrested");
Variable["RiziaDLC.Enable_RRG_Nationalization"] = true;
Variable["RiziaDLCText.RustyArrestReason"] ="as part of a sweeping wartime seizure of the Rizian Royal Gold corporation";
Variable["RiziaDLCSupport.News_Turn08_G_RustyArrested"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_RustyArrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_GrantROGStake == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_GrantROGStake == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_GrantROGStake"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_GrantROGStake == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_GrantROGStake"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Energy_Modifier_SoldROGStake = 0)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Energy_Modifier_SoldROGStake"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn08_Bronaz_RustyFled = true;
RiziaDLCText.RustyFate = "departure";
RiziaDLC.Rusty_Allied = false;
RiziaDLC.Rusty_Fled = true;
RiziaDLC.Budget_Modifier_RizianGoldIndustry -= 2; 
RiziaDLC.Enable_RRG_Nationalization = true;
EnableCodexEntry("Characters_Business_RustyMontoro_Fled");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_Bronaz_RustyFled"] = true;
Variable["RiziaDLCText.RustyFate"] ="departure";
Variable["RiziaDLC.Rusty_Allied"] = false;
Variable["RiziaDLC.Rusty_Fled"] = true;
Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] = Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] - 2;
Variable["RiziaDLC.Enable_RRG_Nationalization"] = true;
EnableCodexEntry("Characters_Business_RustyMontoro_Fled");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_SlowGrowth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn08_Qalus_NewBusiness_SlowGrowth = true;
RiziaDLCSupport.News_Turn08_RH_Economy_NewBusiness_SlowGrowth = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_Qalus_NewBusiness_SlowGrowth"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_Economy_NewBusiness_SlowGrowth"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_V_RRGNationalization = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_V_RRGNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[378]`
Mówca: **Elena Werner**
> ""One last thing to keep in mind...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[379]`
Mówca: **Elena Werner**
> ""Rusty Montoro's name was floated as a candidate to chair it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[383]`
Mówca: **Hugo Toras**
> ""You'd trust that man with the Rizian stock market?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[405]`
  - -> `[386]`
  - -> `[409]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course not. It's a terrible idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? He could make us a lot of money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I never much liked the idea of gambling with our kingdom's finances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's high time we established such a draw for investors. But I'm not sold on the idea of Rusty heading it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[388]`
Mówca: **Elena Werner**
> ""It can be someone else. But Mr. Montoro does have the right connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[389]`
Mówca: **Elena Werner**
> ""Nor do I. But I admit that if done right, this could open the door to a flood of international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
Mówca: **Hugo Toras**
> ""Us, or himself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Elena Werner**
> ""I have doubts about it myself, Your Majesty. But its proponents say it could open the door to a flood of international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Laurento Esquibel**
> ""If we established such an exchange, Rizia's economy would be tied to our global image more strongly than ever before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[396]`
Mówca: **Laurento Esquibel**
> ""As it stands, we have the potential to win big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[397]`
Mówca: **Narrator**
> "He smiled impishly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[398]`
Mówca: **Laurento Esquibel**
> ""As it stands, we have to think carefully before taking that risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Elena Werner**
> ""Correct as usual, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[403]`
Mówca: **Elena Werner**
> ""But we're getting off track. I'd like to know His Majesty's verdict on the wartime nationalization of RRG.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[404]`
Mówca: **Elena Werner**
> ""While we're on the subject...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_KnownLespianAgent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the leverage we now have over him, he could make us a lot of money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_KnownLespianAgent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's high time we established such a draw for investors. But I have other plans for Rusty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[413]`
Mówca: **Elena Werner**
> ""Understood. It doesn't have to be him leading it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[417]`
Mówca: **Elena Werner**
> ""Speaking of all this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[418]`
Mówca: **Elena Werner**
> ""Rusty Montoro's name was floated as a candidate to chair it. Obviously, that's not going to happen now. But the general idea still stands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Laurento Esquibel**
> ""If we established such an exchange, Rizia's economy would be tied to our global image more strongly than ever before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[423]`
Mówca: **Laurento Esquibel**
> ""As it stands, we have the potential to win big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[424]`
Mówca: **Narrator**
> "He smiled impishly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[425]`
Mówca: **Laurento Esquibel**
> ""As it stands, we have to think carefully before taking that risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Elena Werner**
> ""Correct as usual, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Elena Stock Exchange Convo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_FormPorteDrazonStockExchange"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[431]`
Mówca: **Elena Werner**
> ""As you may have heard, I was talking to some business owners about the idea of forming a stock exchange in Porte Drazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Elena Stock Exchange Convo])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[436]`
Mówca: **Elena Werner**
> ""I'm glad you took my advice to form the Porte Drazon Stock Exchange. Once it opens, our kingdom will finally be fully integrated into the global market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Laurento Esquibel**
> ""With all the diplomatic benefits that entails.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Laurento Esquibel**
> ""With all the risks and perils that entails.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Elena Werner**
> ""And I thought I'd let you know that Rusty Montoro's name has been floated as a candidate to chair it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[443]`
Mówca: **Hugo Toras**
> ""You'd trust that man with the Rizian stock market?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[450]`
  - -> `[446]`
  - -> `[454]`

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course not. It's a terrible idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? He could make us a lot of money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our kingdom's finances are to be gambled with, I'd prefer you be the one rolling the dice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[447]`
Mówca: **Elena Werner**
> ""That's very kind. But I admit that with Mr. Montoro's connections, he could open the door to a flood of international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[448]`
Mówca: **Hugo Toras**
> ""Us, or himself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
Mówca: **Elena Werner**
> ""He's a known name in Arcasian circles, for better or worse. Appointing him could open the door to a flood of international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_KnownLespianAgent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the leverage we now have over him, he could make us a lot of money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLespianAgent == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLespianAgent == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Allied"] == true  and  Variable["RiziaDLC.Rusty_KnownLespianAgent"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Allied == true && RiziaDLC.Rusty_KnownLespianAgent == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Allied"] == true  and  Variable["RiziaDLC.Rusty_KnownLespianAgent"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give Rusty a chance, Hugo. He's done more for Rizia than you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Elena Werner**
> ""And he has the right connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[462]`
Mówca: **Elena Werner**
> ""That is, if we don't nationalize his company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Hugo Toras**
> ""Which, again, I highly recommend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`
  - -> `[355]`
  - -> `[361]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_KnownLespianAgent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_KnownLespianAgent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_KnownLespianAgent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[467]`
Mówca: **Elena Werner**
> ""Although of course there is the matter of his... allegiance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[468]`
Mówca: **Hugo Toras**
> ""Ms. Werner, are you seriously suggesting handing our financial reins to a traitor for the sake of a few guilder?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[476]`
  - -> `[479]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_Council_RustyAgent == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_Council_RustyAgent == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[473]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_Council_RustyAgent == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_Council_RustyAgent"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have other plans for Rusty, Hugo. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Montoro's fate will be discussed shortly. I'll keep this information in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our treasury is shrinking. This is worth taking into consideration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[475]`
Mówca: **Elena Werner**
> ""But it's your decision, Your Majesty. The appointment will be made a few months from now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget < 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget < 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with you, Hugo. This is absurd.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[480]`
Mówca: **Elena Werner**
> ""I would be happy to chair the exchange myself, Your Majesty. I'm just conveying business owners' opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not just a few. Long-lasting financial security for Rizia is finally within our grasp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll decide for myself whether he's a traitor. Then we'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
