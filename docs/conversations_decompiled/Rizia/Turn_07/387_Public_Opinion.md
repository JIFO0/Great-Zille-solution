# Rizia/Turn 7/Public Opinion

- **ID konwersacji:** `387`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/387_Public_Opinion.md`
- **Liczba węzłów dialogowych:** 548
- **Liczba wyborów gracza:** 60

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Country_HouseSazon`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Country_QuelledProtests`
- `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban`
- `RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike`
- `RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest`
- `RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_ProBusiness`
- `RiziaDLC.MITZ_Nationalization_NoShare`
- `RiziaDLC.MITZ_Nationalization_SmallerShare`
- `RiziaDLC.MITZ_Renegotiation_Failed`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Law_Media_State`
- `RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization`
- `RiziaDLC.Policy_RD_Economy_BusinessTaxCredits`
- `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax`
- `RiziaDLC.Policy_RD_Economy_LandOwnersTax`
- `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed`
- `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax`
- `RiziaDLC.Policy_RD_Order_ExpandBorderGuards`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds`
- `RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws`
- `RiziaDLC.Protests_AntiAureus_Happened`
- `RiziaDLC.Protests_LivingStandards_Happened`
- `RiziaDLC.Protests_MalenyevistStrike_Happened`
- `RiziaDLC.Protests_MediaCensorship_Happened`
- `RiziaDLC.Protests_PoliceBrutality_Happened`
- `RiziaDLC.Protests_Welfare_Happened`
- `RiziaDLC.Reform_Movement_Radicalism`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair`
- `RiziaDLC.Situation_Welfare_Housing_LackOfAffordable`
- `RiziaDLC.Situation_Welfare_Housing_WorseningCrisis`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
- `RiziaDLC.Situation_Welfare_WorkersRights_Bad`
- `RiziaDLC.Situation_Welfare_WorkersRights_Horrible`
- `RiziaDLC.Trait_TyrantKing`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[384] Rizia/Turn 7/A_HouseOfDelegatesII** (../Turn_07/384_A_HouseOfDelegatesII.md), Węzeł `[145]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 29
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
  - -> `[81]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `384` (*Rizia/Turn 7/A_HouseOfDelegatesII*), Węzeł `[145]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""Finally... it is imperative that we discuss the growing radicalism among the populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Despite the King's efforts to ban propaganda from Valgsland and United Contana, it appears talk of a 'worker's movement' has begun to percolate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""Talk of a 'worker's movement' has begun to percolate, undoubtedly aided by propaganda from Valgsland and United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""The recent Malenyevist union strike was only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Protests_MalenyevistStrike_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Protests_MalenyevistStrike_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Protests_MalenyevistStrike_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Protests_MalenyevistStrike_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Protests_MalenyevistStrike_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""Despite few overt protests, I assure you citizens' dissatisfaction is growing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[17]`
Mówca: **Daria de Rava**
> ""Objection. You are suggesting our government appease an extremist fringe movement that does not represent the majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[18]`
Mówca: **Daria de Rava**
> ""Furthermore, at least some of the Malenyevist activity might be the work of foreign provocateurs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[22]`
  - -> `[26]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is correct. What we are seeing is nothing but retaliation from Morella after we refused to support their PM's half-baked nationalization plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both of you are getting worked up over nothing. The 'red menace' is not going to touch us here in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no appeasing Malenyevists. This movement must be crushed, or it's all of our heads on the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Protests or no protests, reducing inequality in Rizian society is a worthy goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyevism started as a fringe movement in United Contana, too. And look what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[27]`
Mówca: **Manus Sazon**
> ""Even if that were true, the Morellan agents could not produce a movement from thin air. These sentiments are already deeply felt within Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[28]`
Mówca: **Daria de Rava**
> ""That's simply not true, Your Majesty. The East and its allies have their sights trained on all monarchies, including us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""Your Majesty, my party's election gains should be proof that oppression is not the answer. If we want Rizia's monarchy to survive, it must evolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[30]`
Mówca: **Daria de Rava**
> ""Inequality exists, yes. But we can address it without giving in to the demands of a radical minority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""We have Rumburg and GRACE on our side. As long as we hew close to our monarchist allies, we will not meet the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[32]`
Mówca: **Daria de Rava**
> ""As long as we retain their favor, we will not have to worry about the threat of an uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[33]`
Mówca: **Daria de Rava**
> ""Finally... it is imperative that we discuss the growing Malenyevist movement within Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Daria de Rava**
> ""Despite the King's efforts to ban propaganda from Valgsland and United Contana, it is still reaching our shores.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[38]`
Mówca: **Daria de Rava**
> ""We are seeing an uptick in pamphlets and other propaganda from Valgsland and United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[39]`
Mówca: **Daria de Rava**
> ""I fear the recent Malenyevist strike was only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true || RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true || RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true  or  Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true || RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true  or  Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Daria de Rava**
> ""I fear giving in to the recent workers' strike has only made this faction more determined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Daria de Rava**
> ""Do not be naive, Mr. Sazon. This is obviously the work of foreign agents seeking to destabilize us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`
  - -> `[49]`
  - -> `[58]`
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Manus Sazon**
> ""Madame Speaker, I must point out that this movement is protesting the existing inequalities within Rizian society. Work to address those, and Malenyevist revolution will no longer be a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both of you are getting worked up over nothing. The 'red menace' is not going to touch us here in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no appeasing Malenyevists. This movement must be crushed, or it's all of our heads on the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Protests or no protests, reducing inequality in Rizian society is a worthy goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyevism started as a fringe movement in United Contana, too. And look what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""Even if that were true, the Morellans could not produce a movement from thin air. They are playing on sentiments that are deeply felt in our populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[54]`
Mówca: **Daria de Rava**
> ""That's simply not true, Your Majesty. The East and its allies have their sights trained on all monarchies, including us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[55]`
Mówca: **Daria de Rava**
> ""Yes, Mr. Sazon, we should not compromise the values of this monarchy simply to meet the demands of a radical fringe group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[56]`
Mówca: **Daria de Rava**
> ""Inequality exists, yes. But not to the extent that this radical fringe group would have us believe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[57]`
Mówca: **Daria de Rava**
> ""We have Rumburg and GRACE on our side. As long as we hew close to our monarchist allies, we will not meet the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Correct. What we are seeing is nothing but retaliation from Morella after we refused to support their PM's half-baked nationalization plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[62]`
Mówca: **Manus Sazon**
> ""Go out on the streets of our cities, and you will hear citizens openly mentioning revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""My constituents have informed me of covert gatherings where revolution is discussed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Manus Sazon**
> ""And I believe the protesters have a point. We should be passing more measures to address the inequality in Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[71]`
Mówca: **Manus Sazon**
> ""I applaud His Majesty's efforts to address the inequality in Rizian society. But obviously, we still have some way to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[75]`
Mówca: **Daria de Rava**
> ""Go out on the streets of our cities, and you will hear citizens openly mentioning revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Daria de Rava**
> ""We have received reports of covert gatherings where revolution is discussed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[80]`
Mówca: **Daria de Rava**
> ""We can beat back the Malenyevist threat by doing more to support the beating heart of this country. Its employers and landowners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Radicalism >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Radicalism >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Radicalism >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[87]`
Mówca: **Manus Sazon**
> ""Finally... it is imperative that we discuss the growing dissatisfaction within our populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""Unless workers' rights improve, I fear strikes like the one we had recently will become more common.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Manus Sazon**
> ""Suppressing the recent Malenyevist strike has only made this faction more determined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[96]`
Mówca: **Manus Sazon**
> ""Despite our promise of better conditions, we are still facing dissent from workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[97]`
Mówca: **Daria de Rava**
> ""Objection. Our efforts as a kingdom should be focused on winning the war in Pales, not on costly policies that will satisfy no one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't focus on them while overlooking the plight of the commoners who actually generate their wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More often than not, the gentry class has been the source of those crises. It doesn't need the government's help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The commoners have nothing to complain about. They live in a rich country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to throw the commoners a bone. I don't want to have to contend with another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""Agreed. My party's election gains are proof that Rizia wants the era of nobility privilege to come to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[103]`
Mówca: **Manus Sazon**
> ""Exactly. My party's election gains are proof that the people of this country no longer trust the nobility to solve their problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[104]`
Mówca: **Daria de Rava**
> ""If we begin giving into their demands now, where will it end? You must be careful not to overindulge them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""And yet so little of that wealth reaches them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Manus Sazon**
> ""The fact is, Rizian society is still rife with inequality. If we do not do more to address it, the demand for change will only grow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[113]`
Mówca: **Manus Sazon**
> ""I applaud His Majesty's efforts to address the inequality in Rizian society. But we still have some way to go before commoners feel empowered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[117]`
Mówca: **Manus Sazon**
> ""The continuing energy crisis has sparked complaints from citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[121]`
Mówca: **Manus Sazon**
> ""Rizia's unfair treatment of foreigners is still a sticking point for many.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Daria de Rava**
> ""Objection. We cannot let the policy of this kingdom be dictated by a few dissenting voices, no matter how loud they make themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Daria de Rava**
> ""If anything, we should be doing more to protect the landowners and employers who keep this country afloat even in times of crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[127]`
  - -> `[99]`
  - -> `[101]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""But it took centuries before they began seeing the benefits of that wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. We need to boost our economy before we can even talk about helping commoners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Manus Sazon**
> ""If the populace is suffering, our economy will as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[133]`
Mówca: **Daria de Rava**
> ""Finally... I have to bring up the rising sentiments of discontent among our lower orders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""I fear the recent Malenyevist strike was a bellwether of what's to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Daria de Rava**
> ""We suppressed the recent Malenyevist strike, but I fear more will follow in its wake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[142]`
Mówca: **Daria de Rava**
> ""Giving in to workers' demands for unsustainably luxurious conditions has only made them want more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[143]`
Mówca: **Daria de Rava**
> ""Mr Sazon. Our efforts as a kingdom should be focused on winning the war in Pales, not on costly policies that will satisfy no one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't focus on them while overlooking the plight of the commoners who actually generate their wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More often than not, the gentry class has been the source of those crises. It doesn't need the government's help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The commoners have nothing to complain about. They live in a rich country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to throw the commoners a bone. I don't want to have to contend with another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[148]`
Mówca: **Daria de Rava**
> ""I'm sorry, Your Majesty, but there is no 'plight'. This could well be the work of foreign agents trying to sow instability within our population.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""We have no evidence that's the case. And even if it was, foreign agents cannot create unrest out of thin air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[150]`
Mówca: **Manus Sazon**
> ""Exactly. I have spoken to constituents who no longer trust the nobility to solve their problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[151]`
Mówca: **Daria de Rava**
> ""If we begin giving into their demands now, where will it end? You must be careful not to overindulge them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[152]`
Mówca: **Manus Sazon**
> ""And yet so little of that wealth reaches them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""The fact is, Madame Speaker, Rizian society is still rife with inequality. If we do not do more to address it, the demand for change will only grow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[160]`
Mówca: **Manus Sazon**
> ""We should look at the success of the King's decrees aimed at empowering commoners. It is clear they are hungry for more of the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[161]`
Mówca: **Daria de Rava**
> ""Mr. Sazon. We cannot let the policy of this kingdom be dictated by a few dissenting voices, no matter how loud they make themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Daria de Rava**
> ""If anything, we should be doing more to protect the landowners and employers who keep this country afloat even in times of crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[163]`
  - -> `[145]`
  - -> `[147]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Manus Sazon**
> ""But it took centuries before they began seeing the benefits of that wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. We need to boost our economy before we can even talk about helping commoners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Manus Sazon**
> ""If the populace is suffering, our economy will as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[175]`
Mówca: **Daria de Rava**
> ""The continuing energy crisis has sparked many complaints.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[176]`
Mówca: **Daria de Rava**
> ""Foreigners continue to protest what they claim is unfair treatment, despite the fact that they are guests in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[180]`
Mówca: **Daria de Rava**
> ""If anything, we should be doing more to empower the landowners and employers who keep our kingdom's heart beating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[181]`
Mówca: **Daria de Rava**
> ""They have already begun to lose faith in the Crown in the wake of certain royal decrees. It would behoove us not to offend them any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[182]`
Mówca: **Daria de Rava**
> ""As long as we retain their favor, we will not have to worry about the threat of an uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[186]`
Mówca: **Daria de Rava**
> ""They have already begun to lose faith in the Crown in the wake of certain royal decrees. It would behoove us not to offend them any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[187]`
Mówca: **Manus Sazon**
> ""We cannot forget that we serve the people of Rizia. To lose their allegiance is to lose hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[188]`
Mówca: **Manus Sazon**
> ""My party -- which I will remind you is the majority -- has already suggested a number of proposals that might benefit ordinary citizens and the Crown alike. It is my hope that His Majesty reviews them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`
  - -> `[191]`
  - -> `[543]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. Sazon. But I doubt any of them will help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I will see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll think about it. But I have a hunch this can only be solved with Morella's cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Next to me, Hugo shook his head adamantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[196]`
Mówca: **Manus Sazon**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[197]`
Mówca: **Manus Sazon**
> ""Whether or not Morella admits to interference, the underlying problems will still be there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[198]`
Mówca: **Daria de Rava**
> ""I don't recall asking you for your input, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Manus Sazon**
> ""It is not 'overindulgence' to grant people rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Daria de Rava**
> ""You may have the ear of a certain Princess of Rizia, but you do not control this assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Narrator**
> "She turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Daria de Rava**
> ""My party -- which I will remind you is the majority party in Rizia -- has already suggested a number of proposals to strengthen our kingdom and quell the unrest. It is our hope His Majesty will enact them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[206]`
  - -> `[207]`
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Madame Speaker. But I doubt any of that will help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll think about it. But I have a hunch this can only be solved with Morella's cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Daria de Rava**
> ""Unrest or not, it is worth trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[213]`
Mówca: **Daria de Rava**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""Whether or not Morella admits to interference, the underlying problems will still be there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please refrain from personal jabs at the opposition leader. Mr. Sazon's relationship with Princess Vina has no impact on what happens in this building.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Daria de Rava**
> ""You're right, Your Majesty. I apologize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[223]`
Mówca: **Daria de Rava**
> ""Commoners have been hurling accusations of subpar living standards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[230]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes remain less than satisfactory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[231]`
Mówca: **Manus Sazon**
> ""Please, Madame Speaker...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[235]`
Mówca: **Manus Sazon**
> ""Our citizens are worried about how to heat their homes in winter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[239]`
Mówca: **Manus Sazon**
> ""Foreigners still do not have access to basic services.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[243]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes are worse than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[244]`
Mówca: **Manus Sazon**
> ""We cannot forget that we serve the people of Rizia. To lose their allegiance is to lose hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[245]`
Mówca: **Manus Sazon**
> ""Please, Ms. de Rava...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[249]`
Mówca: **Manus Sazon**
> ""Our citizens are worried about how to heat their homes in winter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[253]`
Mówca: **Manus Sazon**
> ""Foreigners still do not have access to basic services.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[257]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes are worse than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Manus Sazon**
> ""To end on a more positive note... The House of Delegates is pleased to report that the Rizian public has a favorable opinion of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Daria de Rava**
> ""To end on a more positive note... I am happy to inform His Majesty that the Rizian public has a favorable opinion of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Manus Sazon**
> ""Even despite the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Manus Sazon**
> ""Living standards for the lower classes have improved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes unfortunately remain subpar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[275]`
Mówca: **Manus Sazon**
> ""Our energy stores are no longer a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Manus Sazon**
> ""But our energy stores are thankfully no longer a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[280]`
Mówca: **Manus Sazon**
> ""And our energy stores are still a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""But our energy stores are still a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[285]`
Mówca: **Manus Sazon**
> ""And Rizians of foreign descent are finally beginning to gain the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Manus Sazon**
> ""Happily, Rizians of foreign descent are finally beginning to gain the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[290]`
Mówca: **Manus Sazon**
> ""Sadly, Rizians of foreign descent still lack the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[291]`
Mówca: **Manus Sazon**
> ""Sadly, Rizians of foreign descent still lack the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Bad == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Bad == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[298]`
Mówca: **Manus Sazon**
> ""Satisfaction among our workers is higher than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[299]`
Mówca: **Manus Sazon**
> ""We still have some way to go before workers are treated with the respect they deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[300]`
Mówca: **Manus Sazon**
> ""And we still have some way to go before workers are treated with the respect they deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Manus Sazon**
> ""But satisfaction among our workers is higher than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Manus Sazon**
> ""Overall, our government cannot rest on our laurels. We are still trying to make up for hundreds of years of inequality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[306]`
Mówca: **Daria de Rava**
> ""The majority of citizens support the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_ProBusiness > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[310]`
Mówca: **Daria de Rava**
> ""They are happy that our energy stores are stable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[311]`
Mówca: **Daria de Rava**
> ""Our energy stores are, unfortunately, still a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[315]`
Mówca: **Daria de Rava**
> ""Business owners are appreciative of all we have done for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_ProBusiness > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[319]`
Mówca: **Daria de Rava**
> ""Business owners feel we could be doing more for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[320]`
Mówca: **Daria de Rava**
> ""But business owners are appreciative of all we have done for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Daria de Rava**
> ""And business owners feel we could be doing more for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_HouseAzaro > 0 && RiziaDLC.Country_HouseSazon > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_HouseAzaro > 0 && RiziaDLC.Country_HouseSazon > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] > 0  and  Variable["RiziaDLC.Country_HouseAzaro"] > 0  and  Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_HouseAzaro > 0 && RiziaDLC.Country_HouseSazon > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] > 0  and  Variable["RiziaDLC.Country_HouseAzaro"] > 0  and  Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[325]`
Mówca: **Daria de Rava**
> ""Surprisingly, all three royal houses approve of His Majesty's reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[326]`
Mówca: **Daria de Rava**
> ""As expected, the Valenqiris nobility still approves of His Majesty's reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras > 0 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro> 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro> 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"]> 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro> 0 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"]> 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Daria de Rava**
> ""As expected, the nobility of Cardesse-Montaklar still approves of His Majesty's reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Daria de Rava**
> ""Only the nobility of Brenas approves of His Majesty's reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[338]`
Mówca: **Daria de Rava**
> ""Support for His Majesty's reign is lacking among the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[339]`
Mówca: **Daria de Rava**
> ""As does that of Cardesse-Montaklar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Daria de Rava**
> ""As does that of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Daria de Rava**
> ""Support is lacking among the rest of the nobility, however.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Daria de Rava**
> ""All in all, we cannot rest on our laurels. We are still far from the universal approval of the Lyza era.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_Media_State == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_Media_State == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_Media_State"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_Media_State == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_Media_State"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Manus Sazon**
> ""Objection. How can we gauge approval when our people lack freedom of speech?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[359]`

### Węzeł `[353]`
Mówca: **Manus Sazon**
> ""Excuse me. All of this talk about nobles, and none about commoners?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`
  - -> `[356]`
  - -> `[363]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Madame Speaker said that public opinion of me was high. That includes commoners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A very good point. Tell me, what do the commoners think of me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All of my subjects love me. End of conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust my House Speaker to know what's going on in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I suppose you have a better sense of what the public thinks of me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My subjects love me. End of conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will refrain from speaking out of turn, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[367]`
Mówca: **Manus Sazon**
> ""Some commoners, perhaps. But not all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[368]`
Mówca: **Manus Sazon**
> ""That may happen to be true. But to only focus on the nobility, while making no mention of the improved situation of the less fortunate--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Daria de Rava**
> ""The fortune of the nobility trickles down to the very bottom rungs of our society. We are seeing that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[376]`
Mówca: **Manus Sazon**
> ""As a matter of fact, Your Majesty--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Daria de Rava**
> ""The King has spoken, Mr. Sazon. There will be no further interruptions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[378]`
Mówca: **Manus Sazon**
> ""As it happens, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[379]`
Mówca: **Manus Sazon**
> ""As a matter of fact, I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes unfortunately remain subpar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Manus Sazon**
> ""Affordable housing has become increasingly hard to secure, to the point of impending crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[397]`
Mówca: **Manus Sazon**
> ""After all this time, our workers are still demanding the most basic of protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[398]`
Mówca: **Manus Sazon**
> ""Rizians of foreign descent still lack the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[399]`
Mówca: **Manus Sazon**
> ""Not quite as rosy a picture as Madame Speaker is painting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`
  - -> `[429]`
  - -> `[431]`

### Węzeł `[400]`
Mówca: **Manus Sazon**
> ""As a matter of fact, commoners are fairly satisfied with your reign. But the fact that they are not allowed to express dissent--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[401]`
Mówca: **Daria de Rava**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[402]`
Mówca: **Manus Sazon**
> ""You're not wrong, Your Majesty, but--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[403]`
Mówca: **Manus Sazon**
> ""Of course. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[407]`
Mówca: **Manus Sazon**
> ""Compounding their misery is the fact that they cannot speak out about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[408]`
Mówca: **Daria de Rava**
> ""Now please refrain from any further interruptions, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Daria de Rava**
> ""What dissent? You said yourself that they are satisfied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Daria de Rava**
> ""You may have the ear of a certain Princess of Rizia, but you do not control this assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Narrator**
> "She turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I suppose you know how to fix everything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't sound bad at all. Certainly not bad enough to make me lose sleep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[417]`
Mówca: **Daria de Rava**
> ""My party -- which I will remind you is the majority -- has already suggested a number of proposals to strengthen our kingdom and keep public satisfaction high.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[520]`
  - -> `[419]`
  - -> `[420]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already enacted plenty of RNC proposals. Don't get too greedy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about that. Perhaps I should be paying more attention to the plight of the common man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[421]`
Mówca: **Daria de Rava**
> ""We are grateful your Majesty. We won't. That is my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[422]`
Mówca: **Daria de Rava**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[423]`
Mówca: **Daria de Rava**
> ""A rising tide lifts all boats, Your Majesty -- pardon the inappropriate metaphor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[424]`
Mówca: **Daria de Rava**
> ""You're right, Your Majesty. I apologize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please refrain from personal jabs at the opposition leader. Mr. Sazon's relationship with Princess Vina has no impact on what happens in this building.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's true, then I have work to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop spewing lies. The commoners in Rizia are happier than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
Mówca: **Manus Sazon**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[435]`
Mówca: **Manus Sazon**
> ""Not everything, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[436]`
Mówca: **Manus Sazon**
> ""I am glad you see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Manus Sazon**
> ""As a matter of fact, they are fairly satisfied with your reign. But to only focus on the nobility, while making no mention of the improved situation of the less fortunate--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[438]`
Mówca: **Manus Sazon**
> ""My party has suggested a number of proposals that might improve the situation. It is our hope His Majesty will enact them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[440]`
  - -> `[441]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. Sazon. But I doubt any of them will help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not promise the opposition anything. But I will think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Narrator**
> "Next to me, Hugo shook his head adamantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[443]`
Mówca: **Manus Sazon**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[444]`
Mówca: **Daria de Rava**
> ""Objection. You speak of the improved lot of commoners while ignoring the businesses and noble institutions that make up the beating heart of this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`
  - -> `[447]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Speaker said that public opinion of me was high. That includes the wealthy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A very good point. Tell me, Ms. de Rava, what do the rich and famous think of me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All of my subjects love me. End of conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[448]`
Mówca: **Narrator**
> "Manus spoke animatedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
Mówca: **Manus Sazon**
> ""Corporations and landowners are doing just fine, Your Majesty. They always have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0  or  Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0  or  Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[453]`
Mówca: **Daria de Rava**
> ""Not necessarily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0  or  Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0  or  Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[457]`
Mówca: **Daria de Rava**
> ""As it happens...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_ProBusiness < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_ProBusiness < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[461]`
Mówca: **Daria de Rava**
> ""Rizia's business owners are quite unhappy with some of the policies you've enacted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[462]`
Mówca: **Daria de Rava**
> ""Your approval has been slipping among the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[463]`
Mówca: **Daria de Rava**
> ""As it happens, they're quite satisfied with your reign thus far. But to fail to even mention them--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Manus Sazon**
> ""I didn't mention them because they're doing just fine. They always have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Daria de Rava**
> ""As it happens, Your Majesty, you're right. But for the House Speaker to not even mention the nobility--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[466]`
Mówca: **Manus Sazon**
> ""Now. My party -- which I will remind you is the majority -- has suggested a number of proposals to further improve the status of ordinary Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`
  - -> `[469]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already enacted plenty of RPP proposals. Don't get too greedy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about that. Perhaps I should be paying more attention to the plight of nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[470]`
Mówca: **Manus Sazon**
> ""No, Your Majesty. We won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[471]`
Mówca: **Manus Sazon**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[472]`
Mówca: **Manus Sazon**
> ""Respectfully, Your Majesty, my party is in charge of this assembly precisely because nobles were getting too much attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[476]`
Mówca: **Daria de Rava**
> ""Your handling of the MITZ renegotiations has them fearing that their own companies will undergo nationalization as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Daria de Rava**
> ""The reduction in the number of new businesses being founded is sure to hurt us in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[483]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[484]`
Mówca: **Daria de Rava**
> ""Furthermore, your approval has been slipping among the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_HouseAzaro < 0 && RiziaDLC.Country_HouseSazon < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_HouseAzaro < 0 && RiziaDLC.Country_HouseSazon < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0  and  Variable["RiziaDLC.Country_HouseAzaro"] < 0  and  Variable["RiziaDLC.Country_HouseSazon"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_HouseAzaro < 0 && RiziaDLC.Country_HouseSazon < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0  and  Variable["RiziaDLC.Country_HouseAzaro"] < 0  and  Variable["RiziaDLC.Country_HouseSazon"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[488]`
Mówca: **Daria de Rava**
> ""You've lost support from every single noble house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[489]`
Mówca: **Daria de Rava**
> ""You've lost the support of your own province's noble families.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`
  - -> `[495]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro < 0 ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Daria de Rava**
> ""The nobles of Cardesse-Montaklar have signalled their disproval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`
  - -> `[499]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[500]`
Mówca: **Daria de Rava**
> ""The Sazons of Brenas now seem to despise you overtly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[501]`
Mówca: **Narrator**
> "I looked at Hugo. He avoided my gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[502]`
Mówca: **Narrator**
> "I looked at Hugo. He avoided my gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[503]`
Mówca: **Narrator**
> "She looked pointedly at Manus. He gaped in outrage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[504]`
Mówca: **Daria de Rava**
> ""Not quite as rosy a picture as Mr. Speaker is painting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`
  - -> `[507]`
  - -> `[508]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I suppose you know how to fix everything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't sound bad at all. Certainly not bad enough to make me lose sleep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's true, then I have work to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[508]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let the bourgeoisie suffer a little bit. They've had their time on top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[509]`
Mówca: **Daria de Rava**
> ""I'm happy you see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[510]`
Mówca: **Daria de Rava**
> ""No, not everything, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[511]`
Mówca: **Daria de Rava**
> ""It's a mistake not to take this seriously, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[512]`
Mówca: **Manus Sazon**
> ""You've made your point. Madame Speaker. Please don't interrupt any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[513]`
Mówca: **Daria de Rava**
> ""My party has suggested a number of proposals to improve the situation. It is our hope you will enact them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`
  - -> `[515]`
  - -> `[516]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already enacted plenty of RNC proposals. Don't get too greedy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[515]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about that. Perhaps I should be paying more attention to the plight of the common man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[517]`
Mówca: **Daria de Rava**
> ""No, Your Majesty. We won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[518]`
Mówca: **Daria de Rava**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[519]`
Mówca: **Daria de Rava**
> ""A rising tide lifts all boats, Your Majesty -- pardon the inappropriate metaphor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true && RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true) || (RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true && (RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[522]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true && RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true) || (RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true && (RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true)  or  (Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  and  (Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true && RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true) || (RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true && (RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true))))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true)  or  (Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  and  (Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already enacted a RNC proposal. We can do more, but in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true ||   RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true ||   RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  or    Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true ||   RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  or    Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[527]`
Mówca: **Daria de Rava**
> ""The RNC is here to aid the crown. Our proposals will ease your burden and help our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_QuelledProtests > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_QuelledProtests > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_QuelledProtests"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_QuelledProtests > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_QuelledProtests"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[531]`
Mówca: **Manus Sazon**
> ""Suppressing the recent protests has only made this faction more determined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC.Protests_LivingStandards_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC.Protests_LivingStandards_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Protests_Welfare_Happened"] == true  or  Variable["RiziaDLC.Protests_LivingStandards_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC.Protests_LivingStandards_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Protests_Welfare_Happened"] == true  or  Variable["RiziaDLC.Protests_LivingStandards_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Manus Sazon**
> ""The recent citizen welfare protests were only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Protests_PoliceBrutality_Happened == true || RiziaDLC.Protests_AntiAureus_Happened == true || RiziaDLC.Protests_MediaCensorship_Happened)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Protests_PoliceBrutality_Happened == true || RiziaDLC.Protests_AntiAureus_Happened == true || RiziaDLC.Protests_MediaCensorship_Happened)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Protests_PoliceBrutality_Happened"] == true  or  Variable["RiziaDLC.Protests_AntiAureus_Happened"] == true  or  Variable["RiziaDLC.Protests_MediaCensorship_Happened"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Protests_PoliceBrutality_Happened == true || RiziaDLC.Protests_AntiAureus_Happened == true || RiziaDLC.Protests_MediaCensorship_Happened))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Protests_PoliceBrutality_Happened"] == true  or  Variable["RiziaDLC.Protests_AntiAureus_Happened"] == true  or  Variable["RiziaDLC.Protests_MediaCensorship_Happened"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[539]`
Mówca: **Manus Sazon**
> ""The recent protests against Crown policies were only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[22]`
  - -> `[26]`

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will have a look. But I am wary of granting the public too many favors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Manus Sazon**
> ""Be kind to them, and they will support the Crown in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
