# Sordland/Turn04/PSnW_EducationReform

- **ID konwersacji:** `57`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/057_PSnW_EducationReform.md`
- **Liczba węzłów dialogowych:** 289
- **Liczba wyborów gracza:** 20

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[40]** Ciara Walda

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed`
- `BaseGame.Country_Unrest`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Economy`
- `BaseGame.Gasom_Bankrupt`
- `BaseGame.Gasom_Default`
- `BaseGame.Gasom_Downsized`
- `BaseGame.GovernmentBudget`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_EmbargoingArcasia`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana`
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_None`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_Economy_FreeMarket`
- `BaseGame.Promise_Economy_Planned`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Education_Budget_Increase`
- `BaseGame.Turn03_EnT_Education_Budget_Maintain`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BlackTuesdayHappened`
- `BaseGame.Capitalist`
- `BaseGame.Education`
- `BaseGame.FinancialAid_Arcasia`
- `BaseGame.FinancialAid_Both`
- `BaseGame.FinancialAid_UC`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Welfare_EducationPrivatization`
- `BaseGame.Policy_Welfare_EducationReform`
- `BaseGame.Policy_Welfare_TraditionalEducation`
- `BaseGame.Situation_Economy_Tourism_Average`
- `BaseGame.Situation_Economy_Tourism_Booming`
- `BaseGame.Situation_Economy_Tourism_Declining`
- `BaseGame.Situation_Welfare_EducationGap`
- `BaseGame.Situation_Welfare_ModernEducationTechniques`
- `BaseGame.Situation_Welfare_SollistTeachings`
- `BaseGame.Sollist`
- `BaseGame.SuperpowerTradeWarHappened`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellite`
- `BaseGameSupport.Journal_Turn04_EducationReform_Maintain`
- `BaseGameSupport.Journal_Turn04_EducationReform_PrivatisedEducation`
- `BaseGameSupport.Journal_Turn04_EducationReform_Reform`
- `BaseGameSupport.Journal_Turn04_EducationReform_StateEducation`
- `BaseGameSupport.News_Turn04_E_Gasom_BankruptcyLooms`
- `BaseGameSupport.News_Turn04_E_Gasom_Downsizes`
- `BaseGameSupport.News_Turn04_E_Gasom_Stagnates`
- `BaseGameSupport.News_Turn04_HP_FreeOfProtests`
- `BaseGameSupport.News_Turn04_LT_EducationPrivatization_KeptPromise`
- `BaseGameSupport.News_Turn04_LT_Kibener_R`
- `BaseGameSupport.News_Turn04_LT_Ricter_D`
- `BaseGameSupport.News_Turn04_R_EducationPrivatization_BrokenPromise`
- `BaseGameSupport.News_Turn04_R_ProtestersArrested`
- `BaseGameSupport.News_Turn04_ST_TerroristsDealtWith_Deal`
- `BaseGameSupport.News_Turn04_ST_ThousandsofArrests_NoDeal`
- `BaseGameSupport.Report_Turn04_Benfi_DoctorsStrike`
- `BaseGameSupport.Report_Turn04_Holsord_DismissedForLinks`
- `BaseGameSupport.Report_Turn04_Holsord_EducationReformStart`
- `BaseGameSupport.Report_Turn04_Lachaven_CrackdownTeachersStrike`
- `BaseGameSupport.Report_Turn04_Lachaven_LabourViolatesCurfew`
- `BaseGameSupport.Report_Turn04_Lachaven_TeachersStrike`
- `GameCondition.Turn04_PSnW_EducationReform`
- `GameCondition.Turn05_Decision_FinancialAid`
- `GameCondition.Turn05_Decision_Penalty`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 56

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.GovernmentBudget`
- `BaseGame.Situation_Economy_Tourism_Average`
- `BaseGame.Situation_Economy_Tourism_Booming`
- `BaseGame.Situation_Economy_Tourism_Declining`
- `BaseGame.Situation_Welfare_SollistTeachings`
- `BaseGame.Sollist`
- `BaseGame.SuperpowerTradeWarHappened`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[51]` (Ciara Walda): `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = false;`
- Węzeł `[52]` (Ciara Walda): `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = true;`
- Węzeł `[53]` (Ciara Walda): `Variable["BaseGame.Policy_Welfare_EducationReform"] = true; Variable["BaseGame.Situation_Welfare_...`
- Węzeł `[54]` (Ciara Walda): `Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = true; Variable["BaseGame.Situation_Wel...`
- Węzeł `[101]` (Ciara Walda): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- Węzeł `[102]` (Ciara Walda): `Variable["BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellite"] = true;`
- Węzeł `[104]` (Ciara Walda): `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2; Variable["BaseGame.Malenye...`
- Węzeł `[105]` (Ciara Walda): `Variable["BaseGame.Situation_Welfare_EducationGap"] = true;`
- *...oraz 48 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Ciara Walda)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian was seated across from me at the table, going through documents. Ciara entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "We were still in Leiren, staying at a modest guesthouse for state employees. Ciara set up a meeting with me and Lucian to go over her plans for education reform after our school visit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Ciara Walda**
> "“After the visit yesterday, I couldn't even sleep thinking about that little boy and girl.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Ciara Walda**
> "“I have never been more sure of my intentions to reform our education system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Lucian took off his reading glasses and put it on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“I agree. An educational reform is necessary.”"]** — Mówca: **Player**
> "“I agree. An educational reform is necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I don't see what's wrong with our education system.”"]** — Mówca: **Player**
> "“I don't see what's wrong with our education system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Ciara Walda**
> "“You don't?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Ciara Walda**
> "“Can't you look at it objectively and see what's wrong with it? You can't be serious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> "“Ciara. Check your tone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Ciara Walda**
> ""Would you say that to a man, Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Ciara Walda**
> "“Those students have to repeat that same Sollist propaganda every single day. They are being brainwashed at an age when their minds need to be free.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Ciara Walda**
> "“Exactly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Ciara Walda**
> "“Those students have to repeat that same Sollist propaganda every single day. They are being brainwashed at an age when their minds need to be free.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Ciara Walda**
> "“On top of that, young girls are denied the same opportunity as boys. They're forced into the role of housewife before they even reach puberty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[18]`
Mówca: **Ciara Walda**
> "“On top of that, young girls are denied the same opportunity as boys. They're forced into the role of housewife before they even reach puberty! Nothing's changed since I went to school.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[19]`
Mówca: **Ciara Walda**
> "“Mr. President. We need to bring change. We need to free the minds of these young people. They are our future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Very well. What do we need to do for an education reform?”"]** — Mówca: **Player**
> "“Very well. What do we need to do for an education reform?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Everything is fine as it is. Why change it?”"]** — Mówca: **Player**
> "“Everything is fine as it is. Why change it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Ciara Walda**
> "“I don't think my words are getting through to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Ciara Walda**
> "“Are you really fine with filling the heads of our children with Sollist propaganda? With teaching girls like Deana that their only value to this country is as vessels for childbearing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Ciara Walda**
> "“You know the words of Artor S. Wisci. You know them better than I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Ciara Walda**
> "“Education is the premise of progress, in all societies, in all families.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Ciara Walda**
> "“We need to reform our education system. Otherwise, Sordland's future is bleak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[27]`
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“We have more important matters to think about than education for a bunch of kids.”"]** — Mówca: **Player**
> "“We have more important matters to think about than education for a bunch of kids.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“We will not stray away from Soll's path.”"]** — Mówca: **Player**
> "“We will not stray away from Soll's path.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[32]`
Mówca: **Ciara Walda**
> "“I can't believe it. This will be seen as a huge mistake when people look back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“You have a point. Alright. So what's your plan?”"]** — Mówca: **Player**
> "“You have a point. Alright. So what's your plan?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Ciara slumped in defeat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[35]`
Mówca: **Ciara Walda**
> "“I'm glad you have seen reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Ciara Walda**
> "“This is actively poisoning young bright minds. Instead of thinking for themselves, they're learning to take things at face value.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Ciara Walda**
> "“We also need to ensure boys and girls receive the same instruction. Handcrafts like knitting and sewing should be taught to both sexes, or not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Ciara Walda**
> "“We need to keep politics out of the curriculum. Soll should only be viewed as a historical figure. Children shouldn't have to repeat his name everyday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Ciara Walda**
> "“Sordland's youth must be technically skilled and capable for the next decade. That won't be possible with the amount of nationalistic indoctrination and narrow-minded thinking found in schools today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Ciara Walda**
> "“Either we raise a generation ready for the challenges of the future or not. What will it be, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[44]`
  - -> `[43]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“As much as I respect Colonel Soll, his time has passed. Now is our time. I do think this might be the first step of a larger plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Lucian, what do you think?”"]** — Mówca: **Player**
> "“Lucian, what do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Maintain the traditional education system.”"]** — Mówca: **Player**
> "“Maintain the traditional education system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Reform the education system.”"]** — Mówca: **Player**
> "“Reform the education system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[45]`
Mówca: **Ciara Walda**
> "“You will not regret it. I will get to work immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Ciara Walda**
> "“I am utterly disappointed. Especially after yesterday's school visit. I thought it would awaken something in you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[47]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[50]`
Mówca: **Ciara Walda**
> "“It will be an uphill battle, considering that the education budget was lowered against my recommendations. But I will give it my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[51]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EducationReform = true;
BaseGame.Situation_Welfare_ModernEducationTechniques = true;
BaseGame.Policy_Welfare_TraditionalEducation = false;
BaseGame.Situation_Welfare_SollistTeachings = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Welfare_EducationReform"] = true;
Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] = true;
Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = false;
Variable["BaseGame.Situation_Welfare_SollistTeachings"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[54]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_TraditionalEducation = true;
BaseGame.Situation_Welfare_SollistTeachings = true;
BaseGame.Policy_Welfare_EducationReform = false;
BaseGame.Situation_Welfare_ModernEducationTechniques = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = true;
Variable["BaseGame.Situation_Welfare_SollistTeachings"] = true;
Variable["BaseGame.Policy_Welfare_EducationReform"] = false;
Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
> "“Now that the decision was made, let's move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[56]`
Mówca: **Ciara Walda**
> "“After the budget increase, the ministry quickly began formulating plans on how to effectively use the money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[57]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[59]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Maintain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Maintain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Maintain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[63]`
Mówca: **Ciara Walda**
> "“With no change in budget, the ministry was left to its own devices. We made some tough choices but still lack additional funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[64]`
Mówca: **Ciara Walda**
> "“So, what is your decision?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[113]`

### Węzeł `[65]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[67]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[68]`
Mówca: **Ciara Walda**
> "“But before moving forward, the question of keeping education fully state-funded or allowing for new private schools remains open.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[69]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Education should remain as a state service only. Certainly this is the most ideal situation.”"]** — Mówca: **Player**
> "“Education should remain as a state service only. Certainly this is the most ideal situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“There is a possibility of privatization having negative side effects.”"]** — Mówca: **Player**
> "“There is a possibility of privatization having negative side effects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Maintain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Maintain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[73]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Maintain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[74]`
Mówca: **Ciara Walda**
> "“Trust me, I know that. It could increase the cost of a quality education, but that is hardly avoidable now anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Tell us about the benefits of allowing private schools.”"]** — Mówca: **Player**
> "“Tell us about the benefits of allowing private schools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[76]`
Mówca: **Narrator**
> "Ciara skimmed over her documents before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[77]`
Mówca: **Ciara Walda**
> "“This has led us to think about allowing privatization to at least keep vital education services unaffected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[70]`

### Węzeł `[78]`
Mówca: **Ciara Walda**
> "“Therefore we are investigating if privatizing education would draw enough funds to conduct investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[70]`

### Węzeł `[79]`
Mówca: **Ciara Walda**
> "“It would be a lie to say that a decrease in the budget didn't force us to consider this. We just need the funds even though we don't like privatization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[80]`
Mówca: **Ciara Walda**
> "“We can manage without additional funds. The only reason I wanted to consider it is to have more money to improve education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[81]`
Mówca: **Ciara Walda**
> "“We have enough money to improve education in Sordland. We do not need to complicate things further with a privatization incentive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[82]`
Mówca: **Ciara Walda**
> "“I've made my opinion clear: I'm against it. But it would give us additional funds for education while increasing competition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[83]`
Mówca: **Ciara Walda**
> "“I agree. The government should be responsible of managing education completely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“State education is contrary to our overall economic strategy of promoting a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[87]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[88]`
Mówca: **Narrator**
> "A few minutes of deliberation passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[91]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[92]`
Mówca: **Ciara Walda**
> "“There aren't many. But it would give us sorely needed funds and increase competition among schools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“What are the advantages of privatization?""]** — Mówca: **Player**
> "“What are the advantages of privatization?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> "“Private education is inconsistent with our overall economic strategy of a planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
> "“It would go against our overall economic strategy of a planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[96]`
Mówca: **Ciara Walda**
> "“The reduction of the education budget left our hands completely tied. We are in a budget crisis management situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> "“It would support our overall economic strategy of promoting a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[98]`
Mówca: **Narrator**
> "She let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[99]`
Mówca: **Ciara Walda**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Initiate privatization to draw more funds. This should allow for more competition and quality.” [+2 Government Budget]"]** — Mówca: **Player**
> "“Initiate privatization to draw more funds. This should allow for more competition and quality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[101]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[102]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellite = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn04_CSP_UCLaunchSatellite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“This has been a very productive day. I will be returning to Holsord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[116]`
  - -> `[115]`

### Węzeł `[104]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist -= 2;
BaseGame.Malenyevist += 2;
BaseGame.Sollist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[105]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_EducationGap = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_EducationGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EducationPrivatization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Welfare_EducationPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Thank you for your time.”"]** — Mówca: **Player**
> "“Thank you for your time everybody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[108]`
Mówca: **Ciara Walda**
> "“Will do. That should be it for now. I will get to work and report back later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[109]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Education += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Education"] = Variable["BaseGame.Education"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[110]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[112]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Keep education solely a matter of the state. We need to prevent interference from private interests.""]** — Mówca: **Player**
> "“Keep education solely a matter of the state. We need to prevent interference from private interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[114]`
Mówca: **Narrator**
> "We dispersed after spending nearly the entire day together. I took a moment simply to breathe the fresh evening air of Leiren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Have a good day.”"]** — Mówca: **Player**
> "“Have a good day and safe travels.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“See you later.”"]** — Mówca: **Player**
> "“See you both later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[117]`
Mówca: **Ciara Walda**
> "“Great. That should be it for now. I will get to work and report back later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[118]`
Mówca: **Narrator**
> "I felt calmer here, somehow. But I would have to return to the chaos of Holsord soon enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[119]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_EducationReform_Maintain = true;
BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_EducationReform_Maintain"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[120]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_EducationReform_Reform = true;
BaseGame.Sollist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_EducationReform_Reform"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[121]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_EducationReform_PrivatisedEducation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_EducationReform_PrivatisedEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[122]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_EducationReform_StateEducation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_EducationReform_StateEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[123]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[125]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[126]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[129]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_Kibener_R = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_Kibener_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[130]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_Ricter_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_Ricter_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[131]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_ST_TerroristsDealtWith_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_TerroristsDealtWith_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[132]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_ST_ThousandsofArrests_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_ThousandsofArrests_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[136]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Country_Unrest <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_HP_FreeOfProtests = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_FreeOfProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[140]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_DecreasedInteriorFunding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[143]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[146]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_ProtestersArrested = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_ProtestersArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[147]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true && BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[150]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[152]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[153]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_EducationPrivatization_BrokenPromise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_EducationPrivatization_BrokenPromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[154]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_EducationPrivatization_KeptPromise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_EducationPrivatization_KeptPromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[155]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_PSnW_EducationReform = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_PSnW_EducationReform"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[156]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Lachaven_LabourViolatesCurfew = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Lachaven_LabourViolatesCurfew"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_EducationReformStart = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_EducationReformStart"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[167]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_DismissedForLinks = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_DismissedForLinks"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[168]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[170]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[171]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[174]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Benfi_DoctorsStrike = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Benfi_DoctorsStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[175]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Lachaven_TeachersStrike = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Lachaven_TeachersStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true && BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[179]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Lachaven_CrackdownTeachersStrike = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Lachaven_CrackdownTeachersStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[180]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -8)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[182]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= -8))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[183]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[185]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_Decision_Penalty = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_Decision_Penalty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[187]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerTradeWarHappened = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.BlackTuesdayHappened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false &&
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false &&
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false  and  
Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and 
Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false &&
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false  and  
Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and 
Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.FinancialAid_UC = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.FinancialAid_UC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[196]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.FinancialAid_Arcasia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.FinancialAid_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[200]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true && 
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true && 
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  
Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[202]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_None == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true && 
BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  
Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true  and   Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false  and  
Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_None == true &&  BaseGame.Reform_EmergencyDecree_Embargo_UC == false && 
BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true  and   Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == false  and  
Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.FinancialAid_Both = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.FinancialAid_Both"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[207]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_Decision_FinancialAid = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_Decision_FinancialAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Ciara looked furious. She shook her head slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[209]`
Mówca: **Ciara Walda**
> "“The only way people like me, Nia, Lileas, Gloria, even your wife were able to escape that is because our families were fortunate and well-connected enough to be able to educate us outside of the public school system. Is that the kind of country you want your daughter to grow up in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[210]`
Mówca: **Ciara Walda**
> "“Women like me, Lileas, Nia, even your wife -- we had to study twice as hard to receive the same university education that you and Lucian took for granted. Is that the kind of country you want your daughter to grow up in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[211]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[213]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true && BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[214]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true  and  Variable["BaseGame.Policy_Economy_PromotePlanned"] == true)  or  (Variable["BaseGame.Promise_Economy_FreeMarket"] == true  and  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[216]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !((BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Promise_Economy_Planned"] == true  and  Variable["BaseGame.Policy_Economy_PromotePlanned"] == true)  or  (Variable["BaseGame.Promise_Economy_FreeMarket"] == true  and  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[217]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true  and  Variable["BaseGame.Policy_Economy_PromotePlanned"] == true)  or  (Variable["BaseGame.Promise_Economy_FreeMarket"] == true  and  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[219]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !((BaseGame.Promise_Economy_Planned == true && BaseGame.Policy_Economy_PromotePlanned == true) || (BaseGame.Promise_Economy_FreeMarket == true && BaseGame.Policy_Economy_PromoteMarket == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Promise_Economy_Planned"] == true  and  Variable["BaseGame.Policy_Economy_PromotePlanned"] == true)  or  (Variable["BaseGame.Promise_Economy_FreeMarket"] == true  and  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[220]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -7)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[222]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= -7))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[223]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[225]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget >= 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[226]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[228]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_DecreasedInteriorFunding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[229]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Lachaven", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Lachaven","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Erlory", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Erlory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Laren", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[232]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Benfi", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Benfi","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[239]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Anrica", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Arvory", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Benfi", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Benfi","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Holsord", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Valgen", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Valgen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[246]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[247]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_EmergencyDecree == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_EmergencyDecree == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] >= 4  or  Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Country_Unrest >= 4 || BaseGame.Policy_Law_EmergencyDecree == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] >= 4  or  Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Booming = false;
BaseGame.Situation_Economy_Tourism_Average = false;
BaseGame.Situation_Economy_Tourism_Declining = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] = false;
Variable["BaseGame.Situation_Economy_Tourism_Average"] = false;
Variable["BaseGame.Situation_Economy_Tourism_Declining"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[251]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Booming = true;
BaseGame.Situation_Economy_Tourism_Average = false;
BaseGame.Situation_Economy_Tourism_Declining = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] = true;
Variable["BaseGame.Situation_Economy_Tourism_Average"] = false;
Variable["BaseGame.Situation_Economy_Tourism_Declining"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_Tourism_Booming = false;
BaseGame.Situation_Economy_Tourism_Average = true;
BaseGame.Situation_Economy_Tourism_Declining = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] = false;
Variable["BaseGame.Situation_Economy_Tourism_Average"] = true;
Variable["BaseGame.Situation_Economy_Tourism_Declining"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Gasom_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Gasom_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Gasom_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_E_Gasom_Stagnates = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Gasom_Stagnates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[260]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Bankrupt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Bankrupt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Gasom_Bankrupt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Gasom_Bankrupt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Gasom_Bankrupt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_E_Gasom_BankruptcyLooms = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Gasom_BankruptcyLooms"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[264]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Downsized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Downsized == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Gasom_Downsized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Gasom_Downsized == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Gasom_Downsized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[267]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_E_Gasom_Downsizes = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Gasom_Downsizes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[268]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 4)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[270]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 4))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
**[WYBÓR GRACZA: "“Initiate privatization to draw more funds. This should allow for more competition and quality.” [+1 Government Budget]"]** — Mówca: **Player**
> "“Initiate privatization to draw more funds. This should allow for more competition and quality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[272]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization = true;
BaseGame.Capitalist += 5;
BaseGame.Malenyevist -= 4;
BaseGame.Sollist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] = true;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 5;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 4;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[273]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[274]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[277]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -9)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -9)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -9`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[279]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= -9))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -9) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[280]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[282]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[285]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= -6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[286]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[288]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
