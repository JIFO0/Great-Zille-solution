# Sordland/Legacy - Summary

- **ID konwersacji:** `276`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Legacy - Summary)`
- **Lokalizacja pliku:** `Sordland/Epilogue/276_Legacy_-_Summary.md`
- **Liczba węzłów dialogowych:** 315
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Bill_Turn09_StrongWomensRights_Signed`
- `BaseGame.Bill_Turn09_WeakWomensRights_Signed`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.EconomyAction_HousingAssistance`
- `BaseGame.EconomyAction_PayBackStudentDebt`
- `BaseGame.EconomyAction_PrintMoney`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_RumburgWarLost`
- `BaseGame.Ending_RumburgWarWin`
- `BaseGame.Ending_WorldWar`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.NedamMiningGroup_Privatization`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_PresiPower_Weak_FairTradeCommission`
- `BaseGame.Situation_Diplomacy_ArcasiaAid`
- `BaseGame.Situation_Diplomacy_UCAid`
- `BaseGame.Situation_Economy_DebtCrisis`
- `BaseGame.Situation_Economy_HighEmployment`
- `BaseGame.Situation_Economy_LargeBusiness_CreateJobs`
- `BaseGame.Situation_Economy_LargeBusiness_Downsize`
- `BaseGame.Situation_Economy_SmallBusiness_Growth`
- `BaseGame.Situation_Economy_SmallBusiness_Stagnate`
- `BaseGame.Situation_Economy_UnemploymentCrisis`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_EfficientJusticeSystem`
- `BaseGame.Situation_Military_GreenGenerals`
- `BaseGame.Situation_Order_CrimeWave`
- `BaseGame.Situation_Order_OrganisedCrime`
- `BaseGame.Situation_Order_OrganisedCrimeContained`
- `BaseGame.Situation_Welfare_EpidemicControlled`
- `BaseGame.Situation_Welfare_EpidemicSpreads`
- `BaseGame.Situation_Welfare_FundingDisruption`
- `BaseGame.Situation_Welfare_GenderEqualityInEducation`
- `BaseGame.Situation_Welfare_IncreasedDepression`
- `BaseGame.Situation_Welfare_NewHospitals`
- `BaseGame.Situation_Welfare_QualityRuralHealthServices`
- `BaseGame.SordishStateCorporation_Privatization`
- `BaseGame.SordlandArmySize`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn05_SnO_Military_ReduceSize`
- `BaseGame.Turn06_PSnW_Healthcare_Privatization`
- `BaseGame.Turn06_SnO_Conscription_Removed`
- `BaseGame.Turn07_Investigate_OldGuard`
- `BaseGame.Turn07_Investigate_Oligarchs`
- `BaseGame.Turn07_Investigate_Opposition`
- `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge`
- `BaseGame.Turn09_EnT_HyperInflation`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 0

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
  - -> `[283]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_UnemploymentCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_UnemploymentCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_UnemploymentCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_UnemploymentCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_UnemploymentCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Narrator**
> "<b><size=26>1,6 million</size></b> people lost their jobs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_HighEmployment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_HighEmployment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_HighEmployment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_HighEmployment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_HighEmployment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[10]`
Mówca: **Narrator**
> "<b><size=26>2,2 million</size></b> people found a job."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "<b><size=26>42,316</size></b> teachers lost their jobs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_EpidemicSpreads == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_EpidemicSpreads == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_EpidemicSpreads == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Narrator**
> "<b><size=26>29,213</size></b> people died due to complications related to Polio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_EpidemicControlled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_EpidemicControlled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_EpidemicControlled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_EpidemicControlled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_EpidemicControlled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[19]`
Mówca: **Narrator**
> "<b><size=26>9,822</size></b> people died due to complications related to Polio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Narrator**
> "<b><size=26>81%</size></b> fewer maternal deaths were recorded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[30]`
Mówca: **Narrator**
> "<b><size=26>228</size></b> police officers and <b><size=26>819</size></b> Bludish militants were killed in firefights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[31]`
Mówca: **Narrator**
> "<b><size=26>99</size></b> police officers and <b><size=26>640</size></b> Bludish militants were killed in firefights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[32]`
Mówca: **Narrator**
> "During street clashes <b><size=26>52</size></b> police officers and <b><size=26>228</size></b> protesters were killed, <b><size=26>8,821</size></b> protesters were arrested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[33]`
Mówca: **Narrator**
> "During street clashes <b><size=26>39</size></b> police officers and <b><size=26>109</size></b> protesters were killed, <b><size=26>11,823</size></b> protesters were arrested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[37]`
Mówca: **Narrator**
> "<b><size=26>304,754</size></b> people lost their jobs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_QualityRuralHealthServices == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_QualityRuralHealthServices == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_QualityRuralHealthServices == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_NewHospitals == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_NewHospitals == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_NewHospitals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_NewHospitals == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_NewHospitals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "<b><size=26>57%</size></b> fewer maternal deaths were recorded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[45]`
Mówca: **Narrator**
> "More than <b><size=26>721,699</size></b> people gained access to healthcare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_CrimeWave == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_CrimeWave == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_CrimeWave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_CrimeWave == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_CrimeWave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrime == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrime == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_OrganisedCrime == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_OrganisedCrime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrimeContained == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrimeContained == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_OrganisedCrimeContained == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[79]`
Mówca: **Narrator**
> "During protests, <b><size=26>3 billion SR</size></b> worth public property damage was done and <b><size=26>2,822</size></b> arrests were made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[80]`
Mówca: **Narrator**
> "During protests, <b><size=26>2 billion SR</size></b> worth public property damage was done and <b><size=26>821</size></b> arrests were made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[81]`
Mówca: **Narrator**
> "<b><size=26>51,091</size></b> people were arrested in accordance to the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[82]`
Mówca: **Narrator**
> "<b><size=26>22,934</size></b> people were arrested in accordance to the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[83]`
Mówca: **Narrator**
> "<b><size=26>13,439</size></b> people were detained without trial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[84]`
Mówca: **Narrator**
> "<b><size=26>18,220</size></b> people were arrested for protesting the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[85]`
Mówca: **Narrator**
> "<b><size=26>311</size></b> people were reported to have been killed by the Sordish law enforcement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[86]`
Mówca: **Narrator**
> "<b><size=26>13,438</size></b> people died to criminal violence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
Mówca: **Narrator**
> "<b><size=26>8,222</size></b> people died to criminal violence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Narrator**
> "<b><size=26>1,278</size></b> people were arrested for their ties to organized crime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Narrator**
> "<b><size=26>3,278</size></b> people were arrested for their ties to organized crime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Narrator**
> "<b><size=26>33,760</size></b> people were arrested for their suspected ties to Red Youth and Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[100]`
Mówca: **Narrator**
> "<b><size=26>18,320</size></b> people were arrested for their suspected ties to Red Youth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[101]`
Mówca: **Narrator**
> "<b><size=26>15,440</size></b> people were arrested for their suspected ties to Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Narrator**
> "<b><size=26>779</size></b> people were killed during the clashes between Red Youth and Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[109]`
Mówca: **Narrator**
> "<b><size=26>12,390</size></b> people were arrested for their ties to the Workers Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[110]`
Mówca: **Narrator**
> "<b><size=26>73,632</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishOppression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishProblem == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishProblem == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishProblem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishProblem == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishProblem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[123]`
Mówca: **Narrator**
> "<b><size=26>11,222</size></b> people with Bludish descent were jailed and <b><size=26>663</size></b> were killed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
Mówca: **Narrator**
> "<b><size=26>3,390</size></b> people with Bludish descent were jailed and <b><size=26>239</size></b> were killed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
Mówca: **Narrator**
> "More than <b><size=26>15,899</size></b> people with Bludish descent were released from prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Narrator**
> "<b><size=26>108,863</size></b> new Bludish voters registered to vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_OldGuard"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_EfficientJusticeSystem == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_EfficientJusticeSystem == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_EfficientJusticeSystem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_EfficientJusticeSystem == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_EfficientJusticeSystem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[145]`
Mówca: **Narrator**
> "<b><size=26>328</size></b> people disappeared without a trace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[146]`
Mówca: **Narrator**
> "<b><size=26>4,109</size></b> state officials were arrested for corruption charges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>311</size></b> state officials."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>22</size></b> opposition politicians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>48</size></b> businessmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
Mówca: **Narrator**
> "<b><size=26>2,389</size></b> legal cases were closed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Narrator**
> "<b><size=26>3,899</size></b> legal cases were delayed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  and  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  and  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[161]`
Mówca: **Narrator**
> "<b><size=26>614,470</size></b> women joined the workforce and <b><size=26>805,380</size></b> girls were enrolled at secondary education for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[168]`
Mówca: **Narrator**
> "<b><size=26>13,142</size></b> businesses were founded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[169]`
Mówca: **Narrator**
> "<b><size=26>409,784</size></b> jobs were created by four largest companies of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[170]`
Mówca: **Narrator**
> "<b><size=26>409,784</size></b> jobs were created by four largest companies of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[171]`
Mówca: **Narrator**
> "<b><size=26>1,340</size></b> women won a domestic violence case at the courts and <b><size=26>403,380</size></b> girls were enrolled at secondary education for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[172]`
Mówca: **Narrator**
> "<b><size=26>1,340</size></b> women won a domestic violence case at the courts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[173]`
Mówca: **Narrator**
> "<b><size=26>11,340</size></b> domestic violence cases were reported."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true  and  Variable["BaseGame.EconomyAction_PayBackStudentDebt"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true  and  Variable["BaseGame.EconomyAction_PayBackStudentDebt"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[192]`
Mówca: **Narrator**
> "<b><size=26>5 million</size></b> people lost their state healthcare coverage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[193]`
Mówca: **Narrator**
> "<b><size=26>259,498</size></b> students left secondary education without graduating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[194]`
Mówca: **Narrator**
> "<b><size=26>5 million</size></b> people lost their state healthcare coverage and <b><size=26>400,030</size></b> students left secondary education without graduating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[195]`
Mówca: **Narrator**
> "<b><size=26>10,400</size></b> state employees lost their jobs while 3 oligarchs obtained 40% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Military_ReduceSize == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Military_ReduceSize == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Military_ReduceSize"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Military_ReduceSize == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Military_ReduceSize"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_GreenGenerals == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_GreenGenerals == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Military_GreenGenerals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Military_GreenGenerals == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Military_GreenGenerals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_SnO_Conscription_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[217]`
Mówca: **Narrator**
> "<b><size=26>589,112</size></b> Sordish lives were lost during the Rumburg invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[218]`
Mówca: **Narrator**
> "<b><size=26>99,332</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[219]`
Mówca: **Narrator**
> "<b><size=26>156,332</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[220]`
Mówca: **Narrator**
> "<b><size=26>189,229</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[221]`
Mówca: **Narrator**
> "<b><size=26>433,165</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[222]`
Mówca: **Narrator**
> "<b><size=26>86,450</size></b> soldiers became unemployed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[223]`
Mówca: **Narrator**
> "<b><size=26>6,894</size></b> military personnel were forcibly retired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[224]`
Mówca: **Narrator**
> "<b><size=26>102,345</size></b> conscripts joined the work force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[225]`
Mówca: **Narrator**
> "<b><size=26>1,314</size></b> conscripts died in training."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGame.Reform_PresiPower_Weak_FairTradeCommission"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGame.Reform_PresiPower_Weak_FairTradeCommission"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Stagnate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Stagnate == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_SmallBusiness_Stagnate == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_Downsize == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_Downsize == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_LargeBusiness_Downsize == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[238]`
Mówca: **Narrator**
> "<b><size=26>81,340</size></b> companies declared bankruptcy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[239]`
Mówca: **Narrator**
> "<b><size=26>9,340</size></b> small businesses declared bankruptcy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Foreign investors have pulled out around <b><size=26>3 billion</size></b> SR from the Sordish market."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[250]`
Mówca: **Narrator**
> "<b><size=26>5,200</size></b> state employees lost their jobs while 3 oligarchs obtained 20% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[251]`
Mówca: **Narrator**
> "<b><size=26>2,300</size></b> state employees lost their jobs while 3 oligarchs obtained 10% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[252]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>10 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[253]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>5 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>1 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[261]`
Mówca: **Narrator**
> "<b><size=26>5,143</size></b> news articles were censored."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[262]`
Mówca: **Narrator**
> "<b><size=26>1,143</size></b> news articles were altered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomyAction_HousingAssistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomyAction_HousingAssistance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomyAction_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomyAction_HousingAssistance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomyAction_HousingAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[272]`
Mówca: **Narrator**
> "<b><size=26>2,5 million</size></b> workers benefitted from minimum wage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[273]`
Mówca: **Narrator**
> "<b><size=26>110,467</size></b> people benefitted from state housing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[274]`
Mówca: **Narrator**
> "Price of bread increased from 0,5 SR to <b><size=26>4 SR.</size></b>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[281]`
Mówca: **Narrator**
> "<b><size=26>1,1 million</size></b> civilians have died in the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[282]`
Mówca: **Narrator**
> "<b><size=26>2,2 million</size></b> civilians have died in the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_WorldWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[286]`
Mówca: **Narrator**
> "<b><size=26>63 million</size></b> people died during the world war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[290]`
Mówca: **Narrator**
> "During the coup <b><size=26>33</size></b> soldiers and <b><size=26>1,430</size></b> protesters were killed, <b><size=26>146,399</size></b> protesters were detained."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_UCAid"] == true  or  Variable["BaseGame.Situation_Diplomacy_ArcasiaAid"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_UCAid"] == true  or  Variable["BaseGame.Situation_Diplomacy_ArcasiaAid"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[300]`
Mówca: **Narrator**
> "<b><size=26>633</size></b> ATO officers arrived in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[301]`
Mówca: **Narrator**
> "<b><size=26>998</size></b> CSP officers arrived in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[302]`
Mówca: **Narrator**
> "<b><size=26>29,472</size></b> tonnes of material aid was received."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Neutrality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Neutrality == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Neutrality == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Narrator**
> "<b><size=26>12</size></b> countries opened embassies in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FundingDisruption == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FundingDisruption == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FundingDisruption"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_FundingDisruption == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FundingDisruption"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_IncreasedDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_IncreasedDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_IncreasedDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_IncreasedDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_IncreasedDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[313]`
Mówca: **Narrator**
> "<b><size=26>86,391</size></b> government welfare payments bounced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[314]`
Mówca: **Narrator**
> "<b><size=26>693</size></b> accounts of suicide were reported to the police."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
