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
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true && (BaseGam..."*)

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
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_QualityRuralHealthServices == ..."*)

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
  - -> `[39]` (*Narrator: "During street clashes <b><size=26>52</size></b> police of..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "<b><size=26>228</size></b> police officers and <b><size=26>819</size></b> Bludish militants were killed in firefights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "<b><size=26>99</size></b> police officers and <b><size=26>640</size></b> Bludish militants were killed in firefights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "During street clashes <b><size=26>39</size></b> police officers and <b><size=26>109</size></b> protesters were killed, <b><size=26>11,823</size></b> protesters were arrested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "<b><size=26>1,1 million</size></b> civilians have died in..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarLost == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarLost == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarLost == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "<b><size=26>2,2 million</size></b> civilians have died in..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_Sordi..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "During street clashes <b><size=26>52</size></b> police officers and <b><size=26>228</size></b> protesters were killed, <b><size=26>8,821</size></b> protesters were arrested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "<b><size=26>1,1 million</size></b> civilians have died in the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "<b><size=26>2,2 million</size></b> civilians have died in the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_WorldWar == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "<b><size=26>63 million</size></b> people died during the ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_WorldWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "<b><size=26>63 million</size></b> people died during the world war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_Sordi..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_Sor..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "During the coup <b><size=26>33</size></b> soldiers and <b..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true && BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_UnemploymentCrisis == true"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "During the coup <b><size=26>33</size></b> soldiers and <b><size=26>1,430</size></b> protesters were killed, <b><size=26>146,399</size></b> protesters were detained."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "<b><size=26>633</size></b> ATO officers arrived in Sordland."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "<b><size=26>998</size></b> CSP officers arrived in Sordland."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Si..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Si..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_UCAid == true || BaseGame...."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_UCAid"] == true  or  Variable["BaseGame.Situation_Diplomacy_ArcasiaAid"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "<b><size=26>29,472</size></b> tonnes of material aid was ..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_UCAid == true || BaseGame.Situation_Diplomacy_ArcasiaAid == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_UCAid"] == true  or  Variable["BaseGame.Situation_Diplomacy_ArcasiaAid"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality == true"*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Neutrality == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "<b><size=26>12</size></b> countries opened embassies in S..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Neutrality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Neutrality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FundingDisruption == true"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "<b><size=26>12</size></b> countries opened embassies in Sordland."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FundingDisruption == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FundingDisruption == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FundingDisruption == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FundingDisruption == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FundingDisruption"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "<b><size=26>86,391</size></b> government welfare payments..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FundingDisruption == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FundingDisruption"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_IncreasedDepression == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_IncreasedDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_IncreasedDepression == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_IncreasedDepression == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_IncreasedDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_IncreasedDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "<b><size=26>693</size></b> accounts of suicide were repor..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_IncreasedDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_IncreasedDepression"] == true) == false`
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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard == true && BaseGame...."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_OldGuard == true && BaseGam..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Investigations were launched on <b><size=26>311</size></b..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_OldGuard == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_OldGuard"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true && BaseGam..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true && BaseGam..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Opposition == true && BaseG..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Investigations were launched on <b><size=26>22</size></b>..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Opposition == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Oligarchs == true && BaseGa..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Investigations were launched on <b><size=26>48</size></b>..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_EfficientJusticeSystem == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_EfficientJusticeSystem == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_EfficientJusticeSystem == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_EfficientJusticeSystem == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_EfficientJusticeSystem == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_EfficientJusticeSystem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "<b><size=26>2,389</size></b> legal cases were closed."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_EfficientJusticeSystem == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_EfficientJusticeSystem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "<b><size=26>3,899</size></b> legal cases were delayed."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "<b><size=26>328</size></b> people disappeared without a trace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "<b><size=26>4,109</size></b> state officials were arrested for corruption charges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>311</size></b> state officials."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>22</size></b> opposition politicians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Investigations were launched on <b><size=26>48</size></b> businessmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[91]`
Mówca: **Narrator**
> "<b><size=26>2,389</size></b> legal cases were closed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[92]`
Mówca: **Narrator**
> "<b><size=26>3,899</size></b> legal cases were delayed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Signed == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "<b><size=26>614,470</size></b> women joined the workforce..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && B..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && B..."*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true &&..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  and  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "<b><size=26>1,340</size></b> women won a domestic violenc..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true && BaseGame.Situation_Welfare_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true  and  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_WeakWomensRights_Signed == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_WeakWomensRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "<b><size=26>1,340</size></b> women won a domestic violenc..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_WeakWomensRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_WeakWomensRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "<b><size=26>11,340</size></b> domestic violence cases wer..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "<b><size=26>614,470</size></b> women joined the workforce and <b><size=26>805,380</size></b> girls were enrolled at secondary education for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_SmallBusiness_Growth == true..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "<b><size=26>13,142</size></b> businesses were founded."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_SmallBusiness_Growth == true && BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs == tr..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs == tr..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == ..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "<b><size=26>409,784</size></b> jobs were created by four ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs == tr..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "<b><size=26>13,142</size></b> businesses were founded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[110]`
Mówca: **Narrator**
> "<b><size=26>409,784</size></b> jobs were created by four largest companies of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[111]`
Mówca: **Narrator**
> "<b><size=26>1,340</size></b> women won a domestic violence case at the courts and <b><size=26>403,380</size></b> girls were enrolled at secondary education for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "<b><size=26>1,340</size></b> women won a domestic violence case at the courts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "<b><size=26>11,340</size></b> domestic violence cases were reported."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth == true &..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "<b><size=26>5 million</size></b> people lost their state ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true && B..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true && B..."*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true &&..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true  and  Variable["BaseGame.EconomyAction_PayBackStudentDebt"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "<b><size=26>259,498</size></b> students left secondary ed..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true && BaseGame.EconomyAction_PayBackStudentDebt == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true  and  Variable["BaseGame.EconomyAction_PayBackStudentDebt"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true && ..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true && ..."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true &..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "<b><size=26>5 million</size></b> people lost their state ..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization + BaseGa..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "<b><size=26>2,300</size></b> state employees lost their j..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization + BaseGa..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "<b><size=26>5,200</size></b> state employees lost their j..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization + BaseGa..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "<b><size=26>10,400</size></b> state employees lost their ..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization + BaseGame.NedamMiningGroup_Privatization >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] + Variable["BaseGame.NedamMiningGroup_Privatization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "<b><size=26>5 million</size></b> people lost their state healthcare coverage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "<b><size=26>259,498</size></b> students left secondary education without graduating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "<b><size=26>5 million</size></b> people lost their state healthcare coverage and <b><size=26>400,030</size></b> students left secondary education without graduating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization + BaseGame..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "<b><size=26>10,400</size></b> state employees lost their jobs while 3 oligarchs obtained 40% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumburg..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "<b><size=26>156,332</size></b> soldiers died during the R..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumburg..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "<b><size=26>99,332</size></b> soldiers died during the Ru..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 1 && BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 1  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumburg..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "<b><size=26>433,165</size></b> soldiers died during the R..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Military_ReduceSize == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumburg..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "<b><size=26>189,229</size></b> soldiers died during the R..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 2 && BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 2  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 2 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Military_ReduceSize == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Military_ReduceSize == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Military_ReduceSize == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Military_ReduceSize == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Military_ReduceSize"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "<b><size=26>86,450</size></b> soldiers became unemployed."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Military_ReduceSize == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Military_ReduceSize"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_GreenGenerals == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_GreenGenerals == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_GreenGenerals == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Military_GreenGenerals == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_GreenGenerals == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Military_GreenGenerals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "<b><size=26>6,894</size></b> military personnel were forc..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Military_GreenGenerals == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Military_GreenGenerals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_SnO_Conscription_Removed == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "<b><size=26>102,345</size></b> conscripts joined the work..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_SnO_Conscription_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "<b><size=26>1,314</size></b> conscripts died in training."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "<b><size=26>589,112</size></b> Sordish lives were lost during the Rumburg invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[158]`
Mówca: **Narrator**
> "<b><size=26>99,332</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[159]`
Mówca: **Narrator**
> "<b><size=26>156,332</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[160]`
Mówca: **Narrator**
> "<b><size=26>189,229</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[161]`
Mówca: **Narrator**
> "<b><size=26>433,165</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[162]`
Mówca: **Narrator**
> "<b><size=26>86,450</size></b> soldiers became unemployed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "<b><size=26>6,894</size></b> military personnel were forcibly retired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[164]`
Mówca: **Narrator**
> "<b><size=26>102,345</size></b> conscripts joined the work force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[165]`
Mówca: **Narrator**
> "<b><size=26>1,314</size></b> conscripts died in training."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs == tr..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGame.Reform_PresiPower_Weak_FairTradeCommission"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "<b><size=26>409,784</size></b> jobs were created by four ..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_LargeBusiness_CreateJobs == true && BaseGame.Turn09_EnT_SordishRecovery == true && BaseGame.Reform_PresiPower_Weak_FairTradeCommission == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] == true  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGame.Reform_PresiPower_Weak_FairTradeCommission"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "<b><size=26>81,340</size></b> companies declared bankruptcy."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Stagnate == true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Stagnate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Stagnate == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_SmallBusiness_Stagnate == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Stagnate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "<b><size=26>9,340</size></b> small businesses declared ba..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_SmallBusiness_Stagnate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_Downsize == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_Downsize == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_Downsize == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_LargeBusiness_Downsize == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_Downsize == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Foreign investors have pulled out around <b><size=26>3 bi..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_LargeBusiness_Downsize == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "<b><size=26>81,340</size></b> companies declared bankruptcy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[179]`
Mówca: **Narrator**
> "<b><size=26>9,340</size></b> small businesses declared bankruptcy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Foreign investors have pulled out around <b><size=26>3 billion</size></b> SR from the Sordish market."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization + BaseGame.Ber..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Private assets worth <b><size=26>1 billion</size></b> SR ..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization + BaseGame.Ber..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Private assets worth <b><size=26>5 billion</size></b> SR ..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization + BaseGame.Ber..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "Private assets worth <b><size=26>10 billion</size></b> SR..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization + BaseGame.BergiaSteel_Nationalization >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] + Variable["BaseGame.BergiaSteel_Nationalization"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization + BaseGame.Bergi..."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "<b><size=26>5,200</size></b> state employees lost their jobs while 3 oligarchs obtained 20% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[191]`
Mówca: **Narrator**
> "<b><size=26>2,300</size></b> state employees lost their jobs while 3 oligarchs obtained 10% of the Sordish economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[192]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>10 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[193]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>5 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[194]`
Mówca: **Narrator**
> "Private assets worth <b><size=26>1 billion</size></b> SR were seized by the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "<b><size=26>5,143</size></b> news articles were censored."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "<b><size=26>1,143</size></b> news articles were altered."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[201]`
Mówca: **Narrator**
> "<b><size=26>5,143</size></b> news articles were censored."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[202]`
Mówca: **Narrator**
> "<b><size=26>1,143</size></b> news articles were altered."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true && (BaseGam..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true && (BaseG..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Price of bread increased from 0,5 SR to <b><size=26>4 SR...."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomyAction_HousingAssistance == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomyAction_HousingAssistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomyAction_HousingAssistance == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomyAction_HousingAssistance == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomyAction_HousingAssistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomyAction_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "<b><size=26>110,467</size></b> people benefitted from sta..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomyAction_HousingAssistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomyAction_HousingAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "<b><size=26>2,5 million</size></b> workers benefitted fro..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "<b><size=26>304,754</size></b> people lost their jobs."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "<b><size=26>2,5 million</size></b> workers benefitted from minimum wage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[213]`
Mówca: **Narrator**
> "<b><size=26>110,467</size></b> people benefitted from state housing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Price of bread increased from 0,5 SR to <b><size=26>4 SR.</size></b>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true &..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "<b><size=26>42,316</size></b> teachers lost their jobs."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[218]`
Mówca: **Narrator**
> "<b><size=26>304,754</size></b> people lost their jobs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_QualityRuralHealthServices == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_QualityRuralHealthServices == ..."*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_QualityRuralHealthServices =..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_QualityRuralHealthServices == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "<b><size=26>81%</size></b> fewer maternal deaths were rec..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_QualityRuralHealthServices == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_NewHospitals == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_NewHospitals == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_NewHospitals == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_NewHospitals == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_NewHospitals == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_NewHospitals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "More than <b><size=26>721,699</size></b> people gained ac..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_NewHospitals == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_NewHospitals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "<b><size=26>57%</size></b> fewer maternal deaths were rec..."*)

### Węzeł `[225]`
Mówca: **Narrator**
> "<b><size=26>57%</size></b> fewer maternal deaths were recorded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)

### Węzeł `[226]`
Mówca: **Narrator**
> "More than <b><size=26>721,699</size></b> people gained access to healthcare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Turn09_U..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn..."*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Violent_Happened == true && BaseGame.Tu..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "During street clashes <b><size=26>39</size></b> police of..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Violent_Happened == true && BaseGame.Turn09_UnrestStopped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Tur..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Tur..."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.T..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "During protests, <b><size=26>3 billion SR</size></b> wort..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Tur..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Tur..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.T..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "During protests, <b><size=26>2 billion SR</size></b> wort..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Peaceful_Happened == true && BaseGame.Turn09_UnrestStopped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  and  Variable["BaseGame.Turn09_UnrestStopped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Decisio..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "<b><size=26>13,439</size></b> people were detained withou..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "<b><size=26>18,220</size></b> people were arrested for pr..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrimeContained == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrimeContained == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_OrganisedCrimeContained == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrimeContained == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "<b><size=26>1,278</size></b> people were arrested for the..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_OrganisedCrimeContained == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "<b><size=26>3,278</size></b> people were arrested for the..."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "During protests, <b><size=26>3 billion SR</size></b> worth public property damage was done and <b><size=26>2,822</size></b> arrests were made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "<b><size=26>311</size></b> people were reported to have been killed by the Sordish law enforcement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "<b><size=26>1,278</size></b> people were arrested for their ties to organized crime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "<b><size=26>3,278</size></b> people were arrested for their ties to organized crime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && Ba..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "<b><size=26>33,760</size></b> people were arrested for th..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "<b><size=26>18,320</size></b> people were arrested for th..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "<b><size=26>15,440</size></b> people were arrested for th..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "<b><size=26>779</size></b> people were killed during the ..."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "<b><size=26>33,760</size></b> people were arrested for their suspected ties to Red Youth and Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[259]`
Mówca: **Narrator**
> "<b><size=26>18,320</size></b> people were arrested for their suspected ties to Red Youth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[260]`
Mówca: **Narrator**
> "<b><size=26>8,222</size></b> people died to criminal violence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "<b><size=26>311</size></b> people were reported to have b..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_CrimeWave == true"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Decisio..."*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decis..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "<b><size=26>51,091</size></b> people were arrested in acc..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Decisio..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Decisio..."*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decis..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "<b><size=26>22,934</size></b> people were arrested in acc..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_CrimeWave == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_CrimeWave == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_CrimeWave == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_CrimeWave == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_CrimeWave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "<b><size=26>13,438</size></b> people died to criminal vio..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_CrimeWave == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_CrimeWave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrime == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_OrganisedCrime == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrime == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "<b><size=26>8,222</size></b> people died to criminal viol..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_OrganisedCrime == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_OrganisedCrime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrimeContained == true"*)

### Węzeł `[276]`
Mówca: **Narrator**
> "<b><size=26>13,438</size></b> people died to criminal violence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[277]`
Mówca: **Narrator**
> "<b><size=26>779</size></b> people were killed during the clashes between Red Youth and Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[278]`
Mówca: **Narrator**
> "<b><size=26>13,439</size></b> people were detained without trial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[279]`
Mówca: **Narrator**
> "<b><size=26>409,784</size></b> jobs were created by four largest companies of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[280]`
Mówca: **Narrator**
> "<b><size=26>15,440</size></b> people were arrested for their suspected ties to Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "During protests, <b><size=26>2 billion SR</size></b> worth public property damage was done and <b><size=26>821</size></b> arrests were made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "<b><size=26>22,934</size></b> people were arrested in accordance to the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "<b><size=26>51,091</size></b> people were arrested in accordance to the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "<b><size=26>18,220</size></b> people were arrested for protesting the state of emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "<b><size=26>589,112</size></b> Sordish lives were lost du..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 1 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "<b><size=26>12,390</size></b> people were arrested for their ties to the Workers Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumbu..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "<b><size=26>73,632</size></b> soldiers died during the Ru..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordlandArmySize == 0 && BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordlandArmySize"] == 0  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordlandArmySize == 0 && BaseGame.Ending_Rumburg..."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "<b><size=26>73,632</size></b> soldiers died during the Rumburg Invasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishOppression == true)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "<b><size=26>11,222</size></b> people with Bludish descent..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishOppression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishProblem == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishProblem == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishProblem == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishProblem == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishProblem == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishProblem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "<b><size=26>3,390</size></b> people with Bludish descent ..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishProblem == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishProblem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)

### Węzeł `[299]`
Mówca: **Narrator**
> "<b><size=26>108,863</size></b> new Bludish voters registered to vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "<b><size=26>12,390</size></b> people were arrested for th..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)

### Węzeł `[303]`
Mówca: **Narrator**
> "More than <b><size=26>15,899</size></b> people with Bludish descent were released from prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[304]`
Mówca: **Narrator**
> "<b><size=26>3,390</size></b> people with Bludish descent were jailed and <b><size=26>239</size></b> were killed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "More than <b><size=26>15,899</size></b> people with Bludi..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "<b><size=26>108,863</size></b> new Bludish voters registe..."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "<b><size=26>11,222</size></b> people with Bludish descent were jailed and <b><size=26>663</size></b> were killed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "<b><size=26>328</size></b> people disappeared without a t..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOffici..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOffici..."*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOffi..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "<b><size=26>4,109</size></b> state officials were arreste..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_GovernmentOfficialsPurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard == true && BaseGame...."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_UnemploymentCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_UnemploymentCrisis == true"*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_UnemploymentCrisis == true)"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_UnemploymentCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_UnemploymentCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "<b><size=26>1,6 million</size></b> people lost their jobs."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_UnemploymentCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_UnemploymentCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_HighEmployment == true"*)

### Węzeł `[318]`
Mówca: **Narrator**
> "<b><size=26>1,6 million</size></b> people lost their jobs."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_HighEmployment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_HighEmployment == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_HighEmployment == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_HighEmployment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_HighEmployment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "<b><size=26>2,2 million</size></b> people found a job."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_HighEmployment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_HighEmployment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true && (BaseGam..."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "<b><size=26>2,2 million</size></b> people found a job."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[323]`
Mówca: **Narrator**
> "<b><size=26>42,316</size></b> teachers lost their jobs."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarLost == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarLost == true)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "3 million civilians have died in the Rummo-Sordish War. M..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[327]`
Mówca: **Narrator**
> "3 million civilians have died in the Rummo-Sordish War. More than 2 million Sords were killed by the invading Rumburgian forces. The numbers are highly disputed."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_WorldWar == true)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "63 million people died during the world war."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_WorldWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true && BaseGame.Rumbur..."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "63 million people died during the world war."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "During the coup, 33 soldiers and 1,430 protesters were ki..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "During the sporadic border clashes with Rumburg, 2 milita..."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "During the coup, 33 soldiers and 1,430 protesters were killed, more than a hundred thousand people were detained."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true && (BaseGam..."*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true && (BaseG..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Price of bread increased from 0,5 SR to <b><size=26>4 SR...."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true && (BaseGame.EconomyAction_PrintMoney == true || BaseGame.Turn09_EnT_HyperInflation == true || BaseGame.Situation_Economy_DebtCrisis == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  (Variable["BaseGame.EconomyAction_PrintMoney"] == true  or  Variable["BaseGame.Turn09_EnT_HyperInflation"] == true  or  Variable["BaseGame.Situation_Economy_DebtCrisis"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomyAction_HousingAssistance == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomyAction_HousingAssistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomyAction_HousingAssistance == true"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomyAction_HousingAssistance == true)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomyAction_HousingAssistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomyAction_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "<b><size=26>110,467</size></b> people benefitted from sta..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomyAction_HousingAssistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomyAction_HousingAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "<b><size=26>2,5 million</size></b> workers benefitted fro..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "<b><size=26>304,754</size></b> people lost their jobs."*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true && ..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true &..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "<b><size=26>42,316</size></b> teachers lost their jobs."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Privatization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[351]`
Mówca: **Narrator**
> "<b><size=26>304,754</size></b> people lost their jobs."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Lespia_Alliance == true || 
BaseGame.Valgsland_Alliance == true) && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true ||  BaseGame.Valgsland_..."*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Lespia_Alliance == true ||  BaseGame.Valgslan..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Lespia_Alliance == true || 
BaseGame.Valgsland_Alliance == true) && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  
Variable["BaseGame.Valgsland_Alliance"] == true)  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "1,5 million civilians have died in the Rummo-Sordish War."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Lespia_Alliance == true || 
BaseGame.Valgsland_Alliance == true) && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Lespia_Alliance"] == true  or  
Variable["BaseGame.Valgsland_Alliance"] == true)  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true && BaseGame.Rumbur..."*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true && BaseGame.Rumb..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true  and  Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "2,2 million civilians have died in the Rummo-Sordish War...."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true && BaseGame.Rumburg_AlliesCalledToWar == true && BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true  and  Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true ||  BaseGame.Valgsland_..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "1,1 million civilians have died in the Rummo-Sordish War."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarLost == true"*)

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
