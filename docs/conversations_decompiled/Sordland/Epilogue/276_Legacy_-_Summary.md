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
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_UnemploymentCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_UnemploymentCrisis == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_UnemploymentCrisis == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_UnemploymentCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_UnemploymentCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "<b><size=26>1,6 million</size></b> people lost their jobs."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_UnemploymentCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_UnemploymentCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_HighEmployment == true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "<b><size=26>1,6 million</size></b> people lost their jobs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_HighEmployment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_HighEmployment == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_HighEmployment == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_HighEmployment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_HighEmployment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "<b><size=26>2,2 million</size></b> people found a job."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_HighEmployment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_HighEmployment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true && (BaseGam..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "<b><size=26>2,2 million</size></b> people found a job."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "<b><size=26>42,316</size></b> teachers lost their jobs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EpidemicSpreads == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_EpidemicSpreads == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EpidemicSpreads == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "<b><size=26>29,213</size></b> people died due to complica..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_EpidemicSpreads == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicControlled == true"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "<b><size=26>29,213</size></b> people died due to complications related to Polio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EpidemicControlled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicControlled == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_EpidemicControlled == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EpidemicControlled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_EpidemicControlled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "<b><size=26>9,822</size></b> people died due to complicat..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_EpidemicControlled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_EpidemicControlled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_QualityRuralHealthServices == ..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "<b><size=26>9,822</size></b> people died due to complications related to Polio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "<b><size=26>81%</size></b> fewer maternal deaths were recorded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "<b><size=26>228</size></b> police officers and <b><size=2..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "<b><size=26>99</size></b> police officers and <b><size=26..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_UnrestStopped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Violent_Happened == true && BaseGame.Tu..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "During street clashes <b><size=26>52</size></b> police of..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "<b><size=26>228</size></b> police officers and <b><size=26>819</size></b> Bludish militants were killed in firefights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "<b><size=26>99</size></b> police officers and <b><size=26>640</size></b> Bludish militants were killed in firefights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "During street clashes <b><size=26>52</size></b> police officers and <b><size=26>228</size></b> protesters were killed, <b><size=26>8,821</size></b> protesters were arrested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "During street clashes <b><size=26>39</size></b> police officers and <b><size=26>109</size></b> protesters were killed, <b><size=26>11,823</size></b> protesters were arrested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true &..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "<b><size=26>42,316</size></b> teachers lost their jobs."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "<b><size=26>304,754</size></b> people lost their jobs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_QualityRuralHealthServices == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_QualityRuralHealthServices == ..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_QualityRuralHealthServices =..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_QualityRuralHealthServices == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "<b><size=26>81%</size></b> fewer maternal deaths were rec..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_QualityRuralHealthServices == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_NewHospitals == true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_NewHospitals == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_NewHospitals == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_NewHospitals == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_NewHospitals == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_NewHospitals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "More than <b><size=26>721,699</size></b> people gained ac..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_NewHospitals == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_NewHospitals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "<b><size=26>57%</size></b> fewer maternal deaths were rec..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "<b><size=26>57%</size></b> fewer maternal deaths were recorded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "More than <b><size=26>721,699</size></b> people gained access to healthcare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Violent_Happened == true && BaseGame.Tu..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "During street clashes <b><size=26>39</size></b> police of..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Tur..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Tur..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.T..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "During protests, <b><size=26>3 billion SR</size></b> wort..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Tur..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Tur..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.T..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "During protests, <b><size=26>2 billion SR</size></b> wort..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Decisio..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "<b><size=26>13,439</size></b> people were detained withou..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "<b><size=26>18,220</size></b> people were arrested for pr..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "<b><size=26>311</size></b> people were reported to have b..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_CrimeWave == true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Decisio..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decis..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "<b><size=26>51,091</size></b> people were arrested in acc..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Decisio..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Decisio..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decis..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "<b><size=26>22,934</size></b> people were arrested in acc..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_CrimeWave == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_CrimeWave == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_CrimeWave == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_CrimeWave == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_CrimeWave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "<b><size=26>13,438</size></b> people died to criminal vio..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_CrimeWave == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_CrimeWave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime == true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrime == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_OrganisedCrime == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrime == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "<b><size=26>8,222</size></b> people died to criminal viol..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_OrganisedCrime == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_OrganisedCrime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrimeContained == true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrimeContained == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrimeContained == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_OrganisedCrimeContained == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrimeContained == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "<b><size=26>1,278</size></b> people were arrested for the..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_OrganisedCrimeContained == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "<b><size=26>3,278</size></b> people were arrested for the..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "During protests, <b><size=26>3 billion SR</size></b> worth public property damage was done and <b><size=26>2,822</size></b> arrests were made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "During protests, <b><size=26>2 billion SR</size></b> worth public property damage was done and <b><size=26>821</size></b> arrests were made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "<b><size=26>51,091</size></b> people were arrested in accordance to the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "<b><size=26>22,934</size></b> people were arrested in accordance to the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "<b><size=26>13,439</size></b> people were detained without trial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "<b><size=26>18,220</size></b> people were arrested for protesting the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "<b><size=26>311</size></b> people were reported to have been killed by the Sordish law enforcement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "<b><size=26>13,438</size></b> people died to criminal violence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "<b><size=26>8,222</size></b> people died to criminal violence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "<b><size=26>1,278</size></b> people were arrested for their ties to organized crime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "<b><size=26>3,278</size></b> people were arrested for their ties to organized crime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && Ba..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "<b><size=26>33,760</size></b> people were arrested for th..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "<b><size=26>18,320</size></b> people were arrested for th..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "<b><size=26>15,440</size></b> people were arrested for th..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "<b><size=26>779</size></b> people were killed during the ..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "<b><size=26>33,760</size></b> people were arrested for their suspected ties to Red Youth and Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "<b><size=26>18,320</size></b> people were arrested for their suspected ties to Red Youth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "<b><size=26>15,440</size></b> people were arrested for their suspected ties to Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "<b><size=26>779</size></b> people were killed during the clashes between Red Youth and Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "<b><size=26>73,632</size></b> soldiers died during the Ru..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "<b><size=26>589,112</size></b> Sordish lives were lost du..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "<b><size=26>12,390</size></b> people were arrested for their ties to the Workers Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[110]`
Mówca: **Narrator**
> "<b><size=26>73,632</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "<b><size=26>12,390</size></b> people were arrested for th..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishOppression == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "<b><size=26>11,222</size></b> people with Bludish descent..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishOppression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishProblem == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishProblem == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishProblem == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishProblem == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishProblem == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishProblem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "<b><size=26>3,390</size></b> people with Bludish descent ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishProblem == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishProblem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "More than <b><size=26>15,899</size></b> people with Bludi..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "<b><size=26>108,863</size></b> new Bludish voters registe..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "<b><size=26>11,222</size></b> people with Bludish descent were jailed and <b><size=26>663</size></b> were killed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "<b><size=26>3,390</size></b> people with Bludish descent were jailed and <b><size=26>239</size></b> were killed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[125]`
Mówca: **Narrator**
> "More than <b><size=26>15,899</size></b> people with Bludish descent were released from prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[126]`
Mówca: **Narrator**
> "<b><size=26>108,863</size></b> new Bludish voters registered to vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "<b><size=26>328</size></b> people disappeared without a t..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOffici..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOffici..."*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOffi..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "<b><size=26>4,109</size></b> state officials were arreste..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard == true && BaseGame...."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard == true && BaseGame...."*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_OldGuard == true && BaseGam..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Investigations were launched on <b><size=26>311</size></b..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_OldGuard"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true && BaseGam..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true && BaseGam..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Opposition == true && BaseG..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Investigations were launched on <b><size=26>22</size></b>..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Oligarchs == true && BaseGa..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "Investigations were launched on <b><size=26>48</size></b>..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_EfficientJusticeSystem == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_EfficientJusticeSystem == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_EfficientJusticeSystem == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_EfficientJusticeSystem == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_EfficientJusticeSystem == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_EfficientJusticeSystem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "<b><size=26>2,389</size></b> legal cases were closed."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_EfficientJusticeSystem == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_EfficientJusticeSystem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "<b><size=26>3,899</size></b> legal cases were delayed."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "<b><size=26>328</size></b> people disappeared without a trace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[146]`
Mówca: **Narrator**
> "<b><size=26>4,109</size></b> state officials were arrested for corruption charges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>311</size></b> state officials."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[148]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>22</size></b> opposition politicians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[149]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>48</size></b> businessmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[150]`
Mówca: **Narrator**
> "<b><size=26>2,389</size></b> legal cases were closed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[151]`
Mówca: **Narrator**
> "<b><size=26>3,899</size></b> legal cases were delayed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "<b><size=26>614,470</size></b> women joined the workforce..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && B..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && B..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true &&..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  and  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "<b><size=26>1,340</size></b> women won a domestic violenc..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  and  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "<b><size=26>1,340</size></b> women won a domestic violenc..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "<b><size=26>11,340</size></b> domestic violence cases wer..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "<b><size=26>614,470</size></b> women joined the workforce and <b><size=26>805,380</size></b> girls were enrolled at secondary education for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_SmallBusiness_Growth == true..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "<b><size=26>13,142</size></b> businesses were founded."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs == tr..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs == tr..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "<b><size=26>409,784</size></b> jobs were created by four ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs == tr..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "<b><size=26>13,142</size></b> businesses were founded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[169]`
Mówca: **Narrator**
> "<b><size=26>409,784</size></b> jobs were created by four largest companies of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[170]`
Mówca: **Narrator**
> "<b><size=26>409,784</size></b> jobs were created by four largest companies of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[171]`
Mówca: **Narrator**
> "<b><size=26>1,340</size></b> women won a domestic violence case at the courts and <b><size=26>403,380</size></b> girls were enrolled at secondary education for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "<b><size=26>1,340</size></b> women won a domestic violence case at the courts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "<b><size=26>11,340</size></b> domestic violence cases were reported."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "<b><size=26>5 million</size></b> people lost their state ..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true && B..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true && B..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true &&..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true  and  Variable["BaseGame.EconomyAction_PayBackStudentDebt"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "<b><size=26>259,498</size></b> students left secondary ed..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true  and  Variable["BaseGame.EconomyAction_PayBackStudentDebt"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true && ..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true && ..."*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true &..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "<b><size=26>5 million</size></b> people lost their state ..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization + BaseGa..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "<b><size=26>2,300</size></b> state employees lost their j..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization + BaseGa..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "<b><size=26>5,200</size></b> state employees lost their j..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization + BaseGa..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "<b><size=26>10,400</size></b> state employees lost their ..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "<b><size=26>5 million</size></b> people lost their state healthcare coverage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "<b><size=26>259,498</size></b> students left secondary education without graduating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "<b><size=26>5 million</size></b> people lost their state healthcare coverage and <b><size=26>400,030</size></b> students left secondary education without graduating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "<b><size=26>10,400</size></b> state employees lost their jobs while 3 oligarchs obtained 40% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumburg..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "<b><size=26>156,332</size></b> soldiers died during the R..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumburg..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "<b><size=26>99,332</size></b> soldiers died during the Ru..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumburg..."*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "<b><size=26>433,165</size></b> soldiers died during the R..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Military_ReduceSize == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumburg..."*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "<b><size=26>189,229</size></b> soldiers died during the R..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Military_ReduceSize == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Military_ReduceSize == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Military_ReduceSize == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Military_ReduceSize == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Military_ReduceSize"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "<b><size=26>86,450</size></b> soldiers became unemployed."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Military_ReduceSize == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Military_ReduceSize"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_GreenGenerals == true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_GreenGenerals == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_GreenGenerals == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Military_GreenGenerals == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_GreenGenerals == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Military_GreenGenerals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "<b><size=26>6,894</size></b> military personnel were forc..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Military_GreenGenerals == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Military_GreenGenerals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_SnO_Conscription_Removed == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "<b><size=26>102,345</size></b> conscripts joined the work..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_SnO_Conscription_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "<b><size=26>1,314</size></b> conscripts died in training."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "<b><size=26>589,112</size></b> Sordish lives were lost during the Rumburg invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[218]`
Mówca: **Narrator**
> "<b><size=26>99,332</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[219]`
Mówca: **Narrator**
> "<b><size=26>156,332</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[220]`
Mówca: **Narrator**
> "<b><size=26>189,229</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[221]`
Mówca: **Narrator**
> "<b><size=26>433,165</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[222]`
Mówca: **Narrator**
> "<b><size=26>86,450</size></b> soldiers became unemployed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[223]`
Mówca: **Narrator**
> "<b><size=26>6,894</size></b> military personnel were forcibly retired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[224]`
Mówca: **Narrator**
> "<b><size=26>102,345</size></b> conscripts joined the work force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[225]`
Mówca: **Narrator**
> "<b><size=26>1,314</size></b> conscripts died in training."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs == tr..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == ..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGame.Reform_PresiPower_Weak_FairTradeCommission"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "<b><size=26>409,784</size></b> jobs were created by four ..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGame.Reform_PresiPower_Weak_FairTradeCommission"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "<b><size=26>81,340</size></b> companies declared bankruptcy."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Stagnate == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Stagnate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Stagnate == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_SmallBusiness_Stagnate == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Stagnate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "<b><size=26>9,340</size></b> small businesses declared ba..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_SmallBusiness_Stagnate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_Downsize == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_Downsize == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_Downsize == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_LargeBusiness_Downsize == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_Downsize == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Foreign investors have pulled out around <b><size=26>3 bi..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_LargeBusiness_Downsize == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[238]`
Mówca: **Narrator**
> "<b><size=26>81,340</size></b> companies declared bankruptcy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[239]`
Mówca: **Narrator**
> "<b><size=26>9,340</size></b> small businesses declared bankruptcy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Foreign investors have pulled out around <b><size=26>3 billion</size></b> SR from the Sordish market."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization + BaseGame.Ber..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Private assets worth <b><size=26>1 billion</size></b> SR ..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization + BaseGame.Ber..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "Private assets worth <b><size=26>5 billion</size></b> SR ..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization + BaseGame.Ber..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Private assets worth <b><size=26>10 billion</size></b> SR..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "<b><size=26>5,200</size></b> state employees lost their jobs while 3 oligarchs obtained 20% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[251]`
Mówca: **Narrator**
> "<b><size=26>2,300</size></b> state employees lost their jobs while 3 oligarchs obtained 10% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>10 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[253]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>5 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>1 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "<b><size=26>5,143</size></b> news articles were censored."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "<b><size=26>1,143</size></b> news articles were altered."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[261]`
Mówca: **Narrator**
> "<b><size=26>5,143</size></b> news articles were censored."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[262]`
Mówca: **Narrator**
> "<b><size=26>1,143</size></b> news articles were altered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true && (BaseGam..."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true && (BaseG..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Price of bread increased from 0,5 SR to <b><size=26>4 SR...."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomyAction_HousingAssistance == true"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomyAction_HousingAssistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomyAction_HousingAssistance == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomyAction_HousingAssistance == true)"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomyAction_HousingAssistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomyAction_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "<b><size=26>110,467</size></b> people benefitted from sta..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomyAction_HousingAssistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomyAction_HousingAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "<b><size=26>2,5 million</size></b> workers benefitted fro..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "<b><size=26>304,754</size></b> people lost their jobs."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "<b><size=26>2,5 million</size></b> workers benefitted from minimum wage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[273]`
Mówca: **Narrator**
> "<b><size=26>110,467</size></b> people benefitted from state housing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[274]`
Mówca: **Narrator**
> "Price of bread increased from 0,5 SR to <b><size=26>4 SR.</size></b>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "<b><size=26>1,1 million</size></b> civilians have died in..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarLost == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarLost == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarLost == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "<b><size=26>2,2 million</size></b> civilians have died in..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_Sordi..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "<b><size=26>1,1 million</size></b> civilians have died in the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[282]`
Mówca: **Narrator**
> "<b><size=26>2,2 million</size></b> civilians have died in the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_WorldWar == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "<b><size=26>63 million</size></b> people died during the ..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_WorldWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true"*)

### Węzeł `[286]`
Mówca: **Narrator**
> "<b><size=26>63 million</size></b> people died during the world war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_Sordi..."*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_Sor..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "During the coup <b><size=26>33</size></b> soldiers and <b..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_UnemploymentCrisis == true"*)

### Węzeł `[290]`
Mówca: **Narrator**
> "During the coup <b><size=26>33</size></b> soldiers and <b><size=26>1,430</size></b> protesters were killed, <b><size=26>146,399</size></b> protesters were detained."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "<b><size=26>633</size></b> ATO officers arrived in Sordland."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "<b><size=26>998</size></b> CSP officers arrived in Sordland."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Si..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Si..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_UCAid == true || BaseGame...."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_UCAid"] == true  or  Variable["BaseGame.Situation_Diplomacy_ArcasiaAid"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "<b><size=26>29,472</size></b> tonnes of material aid was ..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_UCAid"] == true  or  Variable["BaseGame.Situation_Diplomacy_ArcasiaAid"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality == true"*)

### Węzeł `[300]`
Mówca: **Narrator**
> "<b><size=26>633</size></b> ATO officers arrived in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[301]`
Mówca: **Narrator**
> "<b><size=26>998</size></b> CSP officers arrived in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[302]`
Mówca: **Narrator**
> "<b><size=26>29,472</size></b> tonnes of material aid was received."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Neutrality == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "<b><size=26>12</size></b> countries opened embassies in S..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Neutrality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FundingDisruption == true"*)

### Węzeł `[306]`
Mówca: **Narrator**
> "<b><size=26>12</size></b> countries opened embassies in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FundingDisruption == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FundingDisruption == true"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FundingDisruption == true)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FundingDisruption == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FundingDisruption"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "<b><size=26>86,391</size></b> government welfare payments..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FundingDisruption == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FundingDisruption"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_IncreasedDepression == true"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_IncreasedDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_IncreasedDepression == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_IncreasedDepression == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_IncreasedDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_IncreasedDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "<b><size=26>693</size></b> accounts of suicide were repor..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_IncreasedDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_IncreasedDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[313]`
Mówca: **Narrator**
> "<b><size=26>86,391</size></b> government welfare payments bounced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[314]`
Mówca: **Narrator**
> "<b><size=26>693</size></b> accounts of suicide were reported to the police."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
