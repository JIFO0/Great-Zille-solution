# Sordland/Summary Draft WIP/Summary Draft WIP Conversation

- **ID konwersacji:** `542`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Summary Draft WIP)`
- **Lokalizacja pliku:** `Sordland/Epilogue/542_Summary_Draft_WIP_Conversation.md`
- **Liczba węzłów dialogowych:** 364
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
- `BaseGame.Lespia_Alliance`
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
- `BaseGame.Rumburg_AlliesCalledToWar`
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
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Wehlen_JointOperation`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 23
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
  - -> `[203]`

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
  - -> `[219]`

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
  - -> `[39]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[30]`
Mówca: **Narrator**
> "<b><size=26>228</size></b> police officers and <b><size=26>819</size></b> Bludish militants were killed in firefights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[31]`
Mówca: **Narrator**
> "<b><size=26>99</size></b> police officers and <b><size=26>640</size></b> Bludish militants were killed in firefights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[32]`
Mówca: **Narrator**
> "During street clashes <b><size=26>39</size></b> police officers and <b><size=26>109</size></b> protesters were killed, <b><size=26>11,823</size></b> protesters were arrested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[39]`
Mówca: **Narrator**
> "During street clashes <b><size=26>52</size></b> police officers and <b><size=26>228</size></b> protesters were killed, <b><size=26>8,821</size></b> protesters were arrested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[40]`
Mówca: **Narrator**
> "<b><size=26>1,1 million</size></b> civilians have died in the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[41]`
Mówca: **Narrator**
> "<b><size=26>2,2 million</size></b> civilians have died in the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_WorldWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[45]`
Mówca: **Narrator**
> "<b><size=26>63 million</size></b> people died during the world war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[49]`
Mówca: **Narrator**
> "During the coup <b><size=26>33</size></b> soldiers and <b><size=26>1,430</size></b> protesters were killed, <b><size=26>146,399</size></b> protesters were detained."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_UCAid"] == true  or  Variable["BaseGame.Situation_Diplomacy_ArcasiaAid"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_UCAid"] == true  or  Variable["BaseGame.Situation_Diplomacy_ArcasiaAid"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[59]`
Mówca: **Narrator**
> "<b><size=26>633</size></b> ATO officers arrived in Sordland."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
Mówca: **Narrator**
> "<b><size=26>998</size></b> CSP officers arrived in Sordland."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Narrator**
> "<b><size=26>29,472</size></b> tonnes of material aid was received."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Neutrality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Neutrality == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Neutrality == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Narrator**
> "<b><size=26>12</size></b> countries opened embassies in Sordland."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FundingDisruption == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FundingDisruption == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FundingDisruption"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_FundingDisruption == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FundingDisruption"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_IncreasedDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_IncreasedDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_IncreasedDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_IncreasedDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_IncreasedDepression"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
Mówca: **Narrator**
> "<b><size=26>86,391</size></b> government welfare payments bounced."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
Mówca: **Narrator**
> "<b><size=26>693</size></b> accounts of suicide were reported to the police."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_OldGuard"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_EfficientJusticeSystem == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_EfficientJusticeSystem == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_EfficientJusticeSystem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_EfficientJusticeSystem == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_EfficientJusticeSystem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[86]`
Mówca: **Narrator**
> "<b><size=26>328</size></b> people disappeared without a trace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[87]`
Mówca: **Narrator**
> "<b><size=26>4,109</size></b> state officials were arrested for corruption charges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>311</size></b> state officials."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>22</size></b> opposition politicians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>48</size></b> businessmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Narrator**
> "<b><size=26>2,389</size></b> legal cases were closed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Narrator**
> "<b><size=26>3,899</size></b> legal cases were delayed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  and  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  and  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[102]`
Mówca: **Narrator**
> "<b><size=26>614,470</size></b> women joined the workforce and <b><size=26>805,380</size></b> girls were enrolled at secondary education for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[109]`
Mówca: **Narrator**
> "<b><size=26>13,142</size></b> businesses were founded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[110]`
Mówca: **Narrator**
> "<b><size=26>409,784</size></b> jobs were created by four largest companies of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Narrator**
> "<b><size=26>1,340</size></b> women won a domestic violence case at the courts and <b><size=26>403,380</size></b> girls were enrolled at secondary education for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[112]`
Mówca: **Narrator**
> "<b><size=26>1,340</size></b> women won a domestic violence case at the courts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[113]`
Mówca: **Narrator**
> "<b><size=26>11,340</size></b> domestic violence cases were reported."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true  and  Variable["BaseGame.EconomyAction_PayBackStudentDebt"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true  and  Variable["BaseGame.EconomyAction_PayBackStudentDebt"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[132]`
Mówca: **Narrator**
> "<b><size=26>5 million</size></b> people lost their state healthcare coverage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[133]`
Mówca: **Narrator**
> "<b><size=26>259,498</size></b> students left secondary education without graduating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[134]`
Mówca: **Narrator**
> "<b><size=26>5 million</size></b> people lost their state healthcare coverage and <b><size=26>400,030</size></b> students left secondary education without graduating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[135]`
Mówca: **Narrator**
> "<b><size=26>10,400</size></b> state employees lost their jobs while 3 oligarchs obtained 40% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Military_ReduceSize == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Military_ReduceSize == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Military_ReduceSize"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Military_ReduceSize == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Military_ReduceSize"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_GreenGenerals == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_GreenGenerals == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Military_GreenGenerals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Military_GreenGenerals == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Military_GreenGenerals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_SnO_Conscription_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[157]`
Mówca: **Narrator**
> "<b><size=26>589,112</size></b> Sordish lives were lost during the Rumburg invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[158]`
Mówca: **Narrator**
> "<b><size=26>99,332</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[159]`
Mówca: **Narrator**
> "<b><size=26>156,332</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[160]`
Mówca: **Narrator**
> "<b><size=26>189,229</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[161]`
Mówca: **Narrator**
> "<b><size=26>433,165</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[162]`
Mówca: **Narrator**
> "<b><size=26>86,450</size></b> soldiers became unemployed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[163]`
Mówca: **Narrator**
> "<b><size=26>6,894</size></b> military personnel were forcibly retired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[164]`
Mówca: **Narrator**
> "<b><size=26>102,345</size></b> conscripts joined the work force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[165]`
Mówca: **Narrator**
> "<b><size=26>1,314</size></b> conscripts died in training."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGame.Reform_PresiPower_Weak_FairTradeCommission"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGame.Reform_PresiPower_Weak_FairTradeCommission"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Stagnate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Stagnate == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_SmallBusiness_Stagnate == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_Downsize == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_Downsize == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_LargeBusiness_Downsize == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[178]`
Mówca: **Narrator**
> "<b><size=26>81,340</size></b> companies declared bankruptcy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[179]`
Mówca: **Narrator**
> "<b><size=26>9,340</size></b> small businesses declared bankruptcy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Foreign investors have pulled out around <b><size=26>3 billion</size></b> SR from the Sordish market."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[190]`
Mówca: **Narrator**
> "<b><size=26>5,200</size></b> state employees lost their jobs while 3 oligarchs obtained 20% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
Mówca: **Narrator**
> "<b><size=26>2,300</size></b> state employees lost their jobs while 3 oligarchs obtained 10% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[192]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>10 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[193]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>5 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>1 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[201]`
Mówca: **Narrator**
> "<b><size=26>5,143</size></b> news articles were censored."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[202]`
Mówca: **Narrator**
> "<b><size=26>1,143</size></b> news articles were altered."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomyAction_HousingAssistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomyAction_HousingAssistance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomyAction_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomyAction_HousingAssistance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomyAction_HousingAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[212]`
Mówca: **Narrator**
> "<b><size=26>2,5 million</size></b> workers benefitted from minimum wage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[213]`
Mówca: **Narrator**
> "<b><size=26>110,467</size></b> people benefitted from state housing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Price of bread increased from 0,5 SR to <b><size=26>4 SR.</size></b>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[218]`
Mówca: **Narrator**
> "<b><size=26>304,754</size></b> people lost their jobs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_QualityRuralHealthServices == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_QualityRuralHealthServices == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_QualityRuralHealthServices == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_NewHospitals == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_NewHospitals == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_NewHospitals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_NewHospitals == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_NewHospitals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Narrator**
> "<b><size=26>57%</size></b> fewer maternal deaths were recorded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[226]`
Mówca: **Narrator**
> "More than <b><size=26>721,699</size></b> people gained access to healthcare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrimeContained == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrimeContained == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_OrganisedCrimeContained == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[245]`
Mówca: **Narrator**
> "During protests, <b><size=26>3 billion SR</size></b> worth public property damage was done and <b><size=26>2,822</size></b> arrests were made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
Mówca: **Narrator**
> "<b><size=26>311</size></b> people were reported to have been killed by the Sordish law enforcement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[247]`
Mówca: **Narrator**
> "<b><size=26>1,278</size></b> people were arrested for their ties to organized crime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Narrator**
> "<b><size=26>3,278</size></b> people were arrested for their ties to organized crime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[258]`
Mówca: **Narrator**
> "<b><size=26>33,760</size></b> people were arrested for their suspected ties to Red Youth and Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[259]`
Mówca: **Narrator**
> "<b><size=26>18,320</size></b> people were arrested for their suspected ties to Red Youth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[260]`
Mówca: **Narrator**
> "<b><size=26>8,222</size></b> people died to criminal violence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_CrimeWave == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_CrimeWave == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_CrimeWave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_CrimeWave == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_CrimeWave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrime == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrime == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_OrganisedCrime == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_OrganisedCrime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[276]`
Mówca: **Narrator**
> "<b><size=26>13,438</size></b> people died to criminal violence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[277]`
Mówca: **Narrator**
> "<b><size=26>779</size></b> people were killed during the clashes between Red Youth and Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[278]`
Mówca: **Narrator**
> "<b><size=26>13,439</size></b> people were detained without trial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[279]`
Mówca: **Narrator**
> "<b><size=26>409,784</size></b> jobs were created by four largest companies of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[280]`
Mówca: **Narrator**
> "<b><size=26>15,440</size></b> people were arrested for their suspected ties to Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[281]`
Mówca: **Narrator**
> "During protests, <b><size=26>2 billion SR</size></b> worth public property damage was done and <b><size=26>821</size></b> arrests were made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[282]`
Mówca: **Narrator**
> "<b><size=26>22,934</size></b> people were arrested in accordance to the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[283]`
Mówca: **Narrator**
> "<b><size=26>51,091</size></b> people were arrested in accordance to the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[284]`
Mówca: **Narrator**
> "<b><size=26>18,220</size></b> people were arrested for protesting the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[288]`
Mówca: **Narrator**
> "<b><size=26>12,390</size></b> people were arrested for their ties to the Workers Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[292]`
Mówca: **Narrator**
> "<b><size=26>73,632</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishOppression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishProblem == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishProblem == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishProblem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishProblem == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishProblem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[299]`
Mówca: **Narrator**
> "<b><size=26>108,863</size></b> new Bludish voters registered to vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[303]`
Mówca: **Narrator**
> "More than <b><size=26>15,899</size></b> people with Bludish descent were released from prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[304]`
Mówca: **Narrator**
> "<b><size=26>3,390</size></b> people with Bludish descent were jailed and <b><size=26>239</size></b> were killed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[308]`
Mówca: **Narrator**
> "<b><size=26>11,222</size></b> people with Bludish descent were jailed and <b><size=26>663</size></b> were killed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_UnemploymentCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_UnemploymentCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_UnemploymentCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_UnemploymentCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_UnemploymentCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Narrator**
> "<b><size=26>1,6 million</size></b> people lost their jobs."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_HighEmployment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_HighEmployment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Economy_HighEmployment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Economy_HighEmployment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_HighEmployment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[322]`
Mówca: **Narrator**
> "<b><size=26>2,2 million</size></b> people found a job."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[323]`
Mówca: **Narrator**
> "<b><size=26>42,316</size></b> teachers lost their jobs."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarLost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[327]`
Mówca: **Narrator**
> "3 million civilians have died in the Rummo-Sordish War. More than 2 million Sords were killed by the invading Rumburgian forces. The numbers are highly disputed."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_WorldWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[331]`
Mówca: **Narrator**
> "63 million people died during the world war."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[335]`
Mówca: **Narrator**
> "During the coup, 33 soldiers and 1,430 protesters were killed, more than a hundred thousand people were detained."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomyAction_HousingAssistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomyAction_HousingAssistance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomyAction_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomyAction_HousingAssistance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomyAction_HousingAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[345]`
Mówca: **Narrator**
> "<b><size=26>2,5 million</size></b> workers benefitted from minimum wage."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[346]`
Mówca: **Narrator**
> "<b><size=26>110,467</size></b> people benefitted from state housing."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[347]`
Mówca: **Narrator**
> "Price of bread increased from 0,5 SR to <b><size=26>4 SR.</size></b>"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[351]`
Mówca: **Narrator**
> "<b><size=26>304,754</size></b> people lost their jobs."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Lespia_Alliance == true || 
BaseGame.Valgsland_Alliance == true) && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Lespia_Alliance == true || 
BaseGame.Valgsland_Alliance == true) && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  
Variable["BaseGame.Valgsland_Alliance"] == true)  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Lespia_Alliance == true || 
BaseGame.Valgsland_Alliance == true) && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Lespia_Alliance"] == true  or  
Variable["BaseGame.Valgsland_Alliance"] == true)  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[361]`
Mówca: **Narrator**
> "1,5 million civilians have died in the Rummo-Sordish War."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[362]`
Mówca: **Narrator**
> "2,2 million civilians have died in the Rummo-Sordish War. About half of it were ethnic Rums and Bluds that were killed by the Wehzek forces."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[363]`
Mówca: **Narrator**
> "1,1 million civilians have died in the Rummo-Sordish War."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
Mówca: **Narrator**
> "During the sporadic border clashes with Rumburg, 2 military pilots and 3 border patrol officers were declared KIA."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
