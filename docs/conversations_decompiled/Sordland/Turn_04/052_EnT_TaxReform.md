# Sordland/Turn04/EnT_TaxReform

- **ID konwersacji:** `52`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/052_EnT_TaxReform.md`
- **Liczba węzłów dialogowych:** 501
- **Liczba wyborów gracza:** 44

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[13]** Mikail Aven
- **[25]** Edith Agnoc
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Country_Unrest`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Relations_Walter_Promise_Privatization`
- `BaseGame.Relations_Walter_Promise_Tax`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations`
- `BaseGame.Turn04_InT_Issue_SSC_Money`
- `BaseGame.Turn04_SnO_LE_Justice_Increased`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Increase`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Question`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Economy`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Economy_IncreasedTaxCorps`
- `BaseGame.Policy_Economy_IncreasedTaxSME`
- `BaseGame.Policy_Economy_TaxBreakForSME`
- `BaseGame.Policy_Economy_TaxBreaksForPrivateCorps`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Walter_Promise_TaxFulfilled`
- `BaseGame.Situation_Economy_LargeBusiness_CreateJobs`
- `BaseGame.Situation_Economy_LargeBusiness_Downsize`
- `BaseGame.Situation_Economy_SmallBusiness_Growth`
- `BaseGame.Situation_Economy_SmallBusiness_Stagnate`
- `BaseGame.Situation_Economy_TaxAvoidance`
- `BaseGame.Situation_Economy_TaxEfficientEconomy`
- `BaseGame.Situation_Economy_TaxEvasion`
- `BaseGame.Sollist`
- `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxMaintain_SmallMediumBusinesses`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Increase`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Question`
- `BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat`
- `BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat2`
- `BaseGameSupport.FactionReport_Turn04_ATO_DwightWalkerSupport`
- `BaseGameSupport.FactionReport_Turn04_ATO_EconomicSummit`
- `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease`
- `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase`
- `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Maintain`
- `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease`
- `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase`
- `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Maintain`
- `BaseGameSupport.News_Turn04_E_TaxReform_Decreased_Large`
- `BaseGameSupport.News_Turn04_E_TaxReform_Increased_Large`
- `BaseGameSupport.News_Turn04_G_SmolakThreatensBFF`
- `BaseGameSupport.News_Turn04_HP_RemusRelaxedMigration`
- `BaseGameSupport.News_Turn04_HP_RemusTightMigration`
- `BaseGameSupport.News_Turn04_HP_TaxReform_Decreased_Small`
- `BaseGameSupport.News_Turn04_HP_TaxReform_Increased_Small`
- `BaseGameSupport.News_Turn04_LT_DeyrLockdown`
- `BaseGameSupport.News_Turn04_LT_PoliceShotProtester`
- `BaseGameSupport.News_Turn04_LT_ProtestersTraitors`
- `BaseGameSupport.News_Turn04_LT_TorrenSchoolAward`
- `BaseGameSupport.News_Turn04_LT_YSDeclaration`
- `BaseGameSupport.News_Turn04_R_RYDeclaration`
- `BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small`
- `BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small_Decreased_Large`
- `BaseGameSupport.Report_Turn04_Holsord_ArcasiaEmbargo`
- `BaseGameSupport.Report_Turn04_Holsord_ConstructionFixed`
- `BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo`
- `BaseGameSupport.Report_Turn04_Holsord_UnitedContanaEmbargo`
- `BaseGameSupport.Report_Turn04_Valgen_GruniRuralDev`
- `GameCondition.Turn04_EnT_TaxReform`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 11
- **Węzły modyfikujące stan gry:** 100

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Economy_IncreasedTaxCorps`
- `BaseGame.Policy_Economy_IncreasedTaxSME`
- `BaseGame.Policy_Economy_TaxBreakForSME`
- `BaseGame.Policy_Economy_TaxBreaksForPrivateCorps`
- `BaseGame.Relations_Walter_Promise_TaxFulfilled`
- `BaseGame.Situation_Economy_LargeBusiness_CreateJobs`
- `BaseGame.Situation_Economy_LargeBusiness_Downsize`
- `BaseGame.Situation_Economy_SmallBusiness_Growth`
- `BaseGame.Situation_Economy_SmallBusiness_Stagnate`
- `BaseGame.Situation_Economy_TaxAvoidance`
- *...oraz 5 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[41]` (Symon Holl): `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] = true;`
- Węzeł `[42]` (Symon Holl): `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] = true;`
- Węzeł `[43]` (Symon Holl): `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] = true;`
- Węzeł `[77]` (Symon Holl): `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] = true;`
- Węzeł `[106]` (Symon Holl): `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] = true;`
- Węzeł `[121]` (Symon Holl): `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] = true;`
- Węzeł `[125]` (Symon Holl): `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] = true;`
- Węzeł `[143]` (Symon Holl): `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] = true;`
- *...oraz 92 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We were at the top floor of the business council building which had a great view of the beautiful Lachaven. I looked outside from the tall glass windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Tracing back the paths of the ships, I looked at the harbour. Lachaven was home to one of the largest harbours in the entire continent. Many dockyard workers were loading or unloading the containers. Work never stopped here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The Markian Sea stretched as far as the eye could see and it was dotted with many ships towards the horizon. They were mostly cargo ships, carrying precious goods in and out of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The door opened. Symon, Mikail and Edith entered the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Symon put down his bag on the table and started collecting his documents while the others slowly took their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Symon waited patiently. Once everyone was ready, he adjusted his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Mikail Aven**
> "“Good afternoon, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[15]`

### Węzeł `[11]`
Mówca: **Edith Agnoc**
> "“Mr. President. So nice to see you again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[12]`
Mówca: **Symon Holl**
> "“First of all, I would like to thank everyone here for their work on our tax system reform.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Good afternoon.”"]** — Mówca: **Player**
> "“Good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“It's great to see you all again.”"]** — Mówca: **Player**
> "“It's great to see you all again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Take a seat and let's begin.”"]** — Mówca: **Player**
> "“Take a seat and let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“We all know how complicated our current system is and this work wouldn't be possible without you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“Before we move ahead and start formulating a plan, we need you to determine our direction, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“We have a few possibilities as a result of the work we have done so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“We can increase, maintain or decrease the taxes for large corporations. I believe some of us in the room have a few strong opinions about this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“In parallel, we can increase, maintain or decrease the taxes for small and medium businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Symon Holl**
> "“The ultimate goal here is to end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“Let's start with the large corporations. And we'll move on to small businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“What is the outcome if we increase the taxes for large corporations?”"]** — Mówca: **Player**
> "“What is the outcome if we increase the taxes for large corporations?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“What if we decrease the taxes for large corporations?”"]** — Mówca: **Player**
> "“What if we decrease the taxes for large corporations?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“What does everyone think we should do?”"]** — Mówca: **Player**
> "“What does everyone think we should do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[28]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: LargeCorpTaxQuestions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[32]`
  - -> `[48]`
  - -> `[35]`
  - -> `[38]`

### Węzeł `[29]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[31]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[34]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[37]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[40]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[42]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[43]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“Simply put, if we increase the taxes, we will have more government budget to spend which may come in handy. On the other hand, it's not directly helping us revitalise the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“Our government is already in debt. This might be a way to get out of that debt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[46]`
Mówca: **Symon Holl**
> "“Our government budget will be hit. But in return, due to the sheer size of the economic contribution coming from these companies, it should be helpful in curbing the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Symon Holl**
> "“I do think this is definitely a good option if we want to end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[48]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Is there any downside to keeping the things as they are?”"]** — Mówca: **Player**
> "“Is there any downside to keeping the things as they are?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“I am of the opinion that if we don't make any changes, nothing will change. To stop the recession, we need to do something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“My personal opinion is that we should decrease the taxes for large corporations. Although in short term it would cost us, in the long run it would be the most helpful option in ending the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[54]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[56]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“We already have a budget surplus. I don't see much value in increasing our capital without investing it in possibilities that might help end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[58]`
Mówca: **Symon Holl**
> "“However, there is one problem. The status of our budget. This might not be the greatest idea although it has its benefits. You will have to decide if it's worth the risk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[59]`
Mówca: **Symon Holl**
> "“Especially with the current state of our budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[60]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget == 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[62]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget == 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[63]`
Mówca: **Edith Agnoc**
> "“I do believe there is one way to get out of recession. It is through the trade and the economic contribution of large corporations. Increasing their taxes will turn them on you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Mikail Aven**
> "“I will go a step further. Increasing their taxes will have disastrous results and it will make you an enemy of them. Trust me, Mr. President. Nobody wants to make an enemy of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[74]`

### Węzeł `[65]`
Mówca: **Edith Agnoc**
> "“I think this is a viable idea. Upsetting the existing balance might be less than ideal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Mikail Aven**
> "“Me too. You would have the Group on your good side on top of solving the recession crisis, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[72]`

### Węzeł `[67]`
Mówca: **Edith Agnoc**
> "“I think so too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Mikail Aven**
> "“Agreed. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[69]`
Mówca: **Edith Agnoc**
> "“Our international trade is driven mostly by the products of these corporations. They are the backbone of our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Mikail Aven**
> "“Exactly. If we let them perform better by decreasing their taxes, this should in turn lead to Sordland receiving more investment. This means more capital which means a quicker way out of the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[71]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. We want to ensure the economy is on a balanced track as further destabilization might have drastic consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[304]`
  - -> `[83]`
  - -> `[82]`
  - -> `[305]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“They better try to stay on *my* good side.”"]** — Mówca: **Player**
> "“They better try to stay on *my* good side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“I have to agree. Being their ally would come in handy.”"]** — Mówca: **Player**
> "“I have to agree. Being their ally would come in handy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“It goes both ways, Mr. Aven.”"]** — Mówca: **Player**
> "“It goes both ways, Mr. Aven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Maybe you are right.”"]** — Mówca: **Player**
> "“Maybe you are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[76]`
Mówca: **Mikail Aven**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[77]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [LargeCorpTaxQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[79]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [LargeCorpTaxQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[80]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [LargeCorpTaxQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[81]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [LargeCorpTaxQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Decrease the taxes for large corporations.” [-4 Government Budget]"]** — Mówca: **Player**
> "“Decrease the taxes for large corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Maintain the taxes for large corporations.”"]** — Mówca: **Player**
> "“Maintain the taxes for large corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Increase the taxes for large corporations.” [+3 Government Budget]"]** — Mówca: **Player**
> "“Increase the taxes for large corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[85]`
Mówca: **Mikail Aven**
> "“You are making a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Mikail Aven**
> "“This will not change anything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Mikail Aven**
> "“An excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Edith Agnoc**
> "“This is going to have outrageous effects down the road.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Edith Agnoc**
> "“We won't gain anything by standing still where we are. I protest against this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Edith Agnoc**
> "“I agree. Thanks to this, the recession will be solved in no time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Symon Holl**
> "“Enough. The President has made his choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Symon Holl**
> "“I also think this was a good choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Symon Holl**
> "“Well then. I have taken a note of our action and I will put it to implementation as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Symon opened his briefcase and swapped out the stack of papers he had in front with another stack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Symon Holl**
> "“Let's move on to the small and medium businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
**[WYBÓR GRACZA: "“What is the outcome if we increase the taxes for small and medium businesses?”"]** — Mówca: **Player**
> "“What is the outcome if we increase the taxes for small and medium businesses?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“What if we decrease the taxes for small and medium businesses?”"]** — Mówca: **Player**
> "“What if we decrease the taxes for small and medium businesses?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[101]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: SmallMediumBusinessTaxQuestions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[102]`
  - -> `[116]`
  - -> `[140]`
  - -> `[144]`

### Węzeł `[102]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[104]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [SmallMediumBusinessTaxQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[106]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[107]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [SmallMediumBusinessTaxQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[108]`
Mówca: **Symon Holl**
> "“My personal opinion is, we should increase the taxes for small and medium corporations. It will make people angry, yes. But we can make them happier in the future *after* we end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Increase the taxes for small and medium businesses.” [+2 Government Budget]"]** — Mówca: **Player**
> "“Increase the taxes for small and medium businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“You might be right.”"]** — Mówca: **Player**
> "“You might be right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“People need their hard earned money.”"]** — Mówca: **Player**
> "“People need their hard earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[112]`
Mówca: **Symon Holl**
> "“They are the backbone of our economy and they are comprised of mostly regular people. If we start demanding more money from them in taxes, it might cause the public to harbour ill will towards the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[113]`
Mówca: **Symon Holl**
> "“It should be helpful in curbing the recession for sure. Of course that will come at the cost of losing some of our government budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Is there any downside to keeping the things as they are?”"]** — Mówca: **Player**
> "“Is there any downside to keeping the things as they are?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[115]`
Mówca: **Symon Holl**
> "“Sordland needs change to get out of recession. One way or another. I don't think we will come back on our feet by not doing anything to change our status quo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[116]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[118]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[119]`
Mówca: **Symon Holl**
> "“Very well. I have taken another note. We will look into how to go about implementing these changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Decrease the taxes for small and medium businesses.” [-3 Government Budget]"]** — Mówca: **Player**
> "“Decrease the taxes for small and medium businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[121]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Increase = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[126]`
Mówca: **Symon Holl**
> "“On the other hand, we need to get out of debt one way or another. This can be a solution for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[127]`
Mówca: **Symon Holl**
> "“Our budget is in a good shape. I don't see the need to increase the taxes at the cost of popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[130]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[131]`
Mówca: **Symon Holl**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[147]`
  - -> `[120]`

### Węzeł `[132]`
Mówca: **Mikail Aven**
> "“In the long run, increasing the taxes for small and medium businesses would make people happier with the services the government provides.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[149]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“What does everyone think we should do?”"]** — Mówca: **Player**
> "“What does everyone think we should do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [SmallMediumBusinessTaxQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[136]`
Mówca: **Symon Holl**
> "“It is risky when we have no money left, and we still have loans to pay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[137]`
Mówca: **Edith Agnoc**
> "“I think increasing taxes for these smaller corporations is a good way to earn some extra capital so that the government can give it back to people in due time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[138]`
Mówca: **Edith Agnoc**
> "“People tend to be... forgetful as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Mikail Aven**
> "“I am with Edith and Symon on that one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[140]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Question == false && BaseGame.GovernmentBudget >= 0 &&
BaseGame.Economy >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Question == false && BaseGame.GovernmentBudget >= 0 &&
BaseGame.Economy >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == false  and  Variable["BaseGame.GovernmentBudget"] >= 0  and 
Variable["BaseGame.Economy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_SmallMedium_Question == false && BaseGame.GovernmentBudget >= 0 &&
BaseGame.Economy >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == false  and  Variable["BaseGame.GovernmentBudget"] >= 0  and 
Variable["BaseGame.Economy"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Question = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Question == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_EnT_SmallMedium_Question == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[146]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_EnT_SmallMedium_Question == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
**[WYBÓR GRACZA: "“Maintain the taxes for small and medium businesses.”"]** — Mówca: **Player**
> "“Maintain the taxes for small and medium businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[148]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [SmallMediumBusinessTaxQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "“I can't risk the popularity loss.”"]** — Mówca: **Player**
> "“I can't risk the popularity loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[150]`
Mówca: **Symon Holl**
> "“Well then... Thank you everyone. That will be all for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`
  - -> `[153]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“Enjoy Lachaven.”"]** — Mówca: **Player**
> "“Enjoy Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Thanks Symon.”"]** — Mówca: **Player**
> "“Thanks Symon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Narrator**
> "They left the meeting room. I decided to stay a bit longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[155]`
Mówca: **Narrator**
> "I went by the windows again and kept watching the sea in silence for some more time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[156]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_EnT_TaxReform = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_EnT_TaxReform"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[157]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[160]`
Mówca: **Mikail Aven**
> "“Mr. President. Before we start, I would like to mention some rumours that I heard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Mikail Aven**
> "“Especially the first section about the minimum wages.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Mikail Aven**
> "“Workers' Rights Act did not sit well with many business holders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[163]`
Mówca: **Edith Agnoc**
> "“I heard the same. This has caused these businesses to lose millions of Rens just overnight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Edith Agnoc**
> "“Unfortunate, really. Especially during a recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`
  - -> `[172]`

### Węzeł `[165]`
Mówca: **Mikail Aven**
> "“Mr. President. Before we start, I would like to mention some rumours that I heard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Mikail Aven**
> "“The first section about the minimum wages would've been very damaging to many corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Mikail Aven**
> "“Vetoing the recent Workers' Rights Act was welcomed by a lot of business owners.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[168]`
Mówca: **Edith Agnoc**
> "“A good decision I'd say. Especially during a recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[467]`
  - -> `[175]`
  - -> `[176]`

### Węzeł `[169]`
Mówca: **Edith Agnoc**
> "“I heard the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“What is unfortunate was that this bill was enacted this late.”"]** — Mówca: **Player**
> "“What is really unfortunate, Ms. Edith, was that this bill was enacted this late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
**[WYBÓR GRACZA: "“You are in no position to question my decision.”"]** — Mówca: **Player**
> "“You are in no position to question my decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "“I don't care about rumours. If someone wants to say something, they can say it to me directly.”"]** — Mówca: **Player**
> "“I don't care about rumours. If someone wants to say something, they can say it to me directly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Neither of them responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“I wanted to sign it but I had to make the right call.”"]** — Mówca: **Player**
> "“I wanted to sign it but I had to make the right call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“You are in no position to evaluate my decision.”"]** — Mówca: **Player**
> "“You are in no position to evaluate my decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "“I don't care about rumours. If someone wants to say something, they can say it to me directly.”"]** — Mówca: **Player**
> "“I don't care about rumours. If someone wants to say something, they can say it to me directly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Edith Agnoc**
> "“You have done the right thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Neither of them responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[179]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[180]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[181]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations = true;
BaseGame.Policy_Economy_TaxBreaksForPrivateCorps = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] = true;
Variable["BaseGame.Policy_Economy_TaxBreaksForPrivateCorps"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[182]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[183]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxMaintain_SmallMediumBusinesses = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxMaintain_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[184]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[185]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[186]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Maintain = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Maintain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[187]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[188]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[189]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Maintain = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Maintain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[190]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[191]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_G_SmolakThreatensBFF = true; BaseGameSupport.FactionReport_Turn04_ATO_EconomicSummit = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_G_SmolakThreatensBFF"] = true;
Variable["BaseGameSupport.FactionReport_Turn04_ATO_EconomicSummit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_DeyrLockdown = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_DeyrLockdown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[198]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_RYDeclaration = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_RYDeclaration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[203]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[205]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_YSDeclaration = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_YSDeclaration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[207]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[209]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Country_Unrest > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[213]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[215]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[219]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_PoliceShotProtester = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_PoliceShotProtester"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[220]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_ProtestersTraitors = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_ProtestersTraitors"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[221]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[223]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[226]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[227]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_E_TaxReform_Increased_Large = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_TaxReform_Increased_Large"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[228]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_E_TaxReform_Decreased_Large = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_TaxReform_Decreased_Large"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[229]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[231]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[235]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_HP_TaxReform_Increased_Small = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_TaxReform_Increased_Small"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[236]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_HP_TaxReform_Decreased_Small = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_TaxReform_Decreased_Small"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[237]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  and  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  and  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[240]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small_Decreased_Large = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small_Decreased_Large"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[241]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[242]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[244]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[247]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[248]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.FactionReport_Turn04_ATO_DwightWalkerSupport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn04_ATO_DwightWalkerSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[249]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Money == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Money == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_Issue_SSC_Money == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[253]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_ConstructionFixed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_ConstructionFixed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_ArcasiaEmbargo = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_ArcasiaEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[255]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[257]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[258]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_TaxBreakForSME = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Economy_TaxBreakForSME"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[259]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_IncreasedTaxSME = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxSME"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[260]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_IncreasedTaxCorps = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[261]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[263]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Symon Holl**
> "“It's not an option at this point. Our economy is in shambles.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Symon Holl**
> "“Taking what's remaining from the businesses will destroy the economy further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[268]`
  - -> `[269]`

### Węzeł `[266]`
**[WYBÓR GRACZA: "“We could balance it by decreasing taxes of small businesses to put some relief on them.”"]** — Mówca: **Player**
> "“We could balance it by decreasing taxes of small businesses to put some relief on them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Symon Holl**
> "“I see. I'm not sure if that's a good idea with the current state of our economy...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[268]`
**[WYBÓR GRACZA: "“I see.”"]** — Mówca: **Player**
> "“I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[269]`
**[WYBÓR GRACZA: "“So, we can't do it?”"]** — Mówca: **Player**
> "“So, we can't do it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Symon Holl**
> "“It's not a possibility. Unless if we try and balance it with a tax decrease for small and medium businesses...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Symon Holl**
> "“I do not advise that though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[272]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= -1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[274]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget >= -1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Symon Holl**
> "“It's not an option at this point. Our state is broke.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Symon Holl**
> "“We are barely functioning with the help of the taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[278]`
  - -> `[277]`

### Węzeł `[277]`
**[WYBÓR GRACZA: "“So, we can't do it?”"]** — Mówca: **Player**
> "“So, we can't do it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[278]`
**[WYBÓR GRACZA: "“I see.”"]** — Mówca: **Player**
> "“I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[279]`
Mówca: **Symon Holl**
> "“I see. I'm not sure if that's a good idea with the current state of our economy...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[280]`
**[WYBÓR GRACZA: "“We could balance it by increasing the taxes of small businesses.”"]** — Mówca: **Player**
> "“We could balance it by increasing the taxes of small businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[281]`
Mówca: **Symon Holl**
> "“I do not advise that though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[282]`
Mówca: **Symon Holl**
> "“It's not a possibility. Unless if we try and balance it with a tax increase for small and medium businesses...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[283]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -1  and  Variable["BaseGame.Economy"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -1  and  Variable["BaseGame.Economy"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[286]`
Mówca: **Symon Holl**
> "“Unfortunately, that's the only thing we can do at this point anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Edith Agnoc**
> "“The economy is completely destroyed, Mr. President. I don't know how we'll get out of this mess...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[288]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[290]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget >= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Symon Holl**
> "“I don't think we can do anything at this point. Although I would have preferred a decrease in taxes, it doesn't seem to be the best option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Edith Agnoc**
> "“Our international trade is driven mostly by the products of these corporations. They are the backbone of our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Mikail Aven**
> "“Exactly. An increase should be out of the question. These companies are the backbone of our economy and our way out of the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[294]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[296]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[297]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  and  Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[299]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  and  Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and 
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[302]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and 
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[303]`
Mówca: **Symon Holl**
> "“We will be giving people some relief by enacting tax breaks for small and medium businesses. And there will be an increase for large corporation taxes, which will help us sustain our balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[304]`
**[WYBÓR GRACZA: "“We'll increase the taxes for large corporations and balance it with a decrease for small businesses.”"]** — Mówca: **Player**
> "“We'll increase the taxes for large corporations and balance it with a decrease for small businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
**[WYBÓR GRACZA: "“We'll decrease the taxes for large corporations and balance the budget with an increase for smaller businesses.” [-2 Government Budget]"]** — Mówca: **Player**
> "“We'll decrease the taxes for large corporations and balance the budget with an increase for smaller businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[306]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations = true;
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] = true;
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_IncreasedTaxCorps = true;
BaseGame.Policy_Economy_TaxBreakForSME = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] = true;
Variable["BaseGame.Policy_Economy_TaxBreakForSME"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase = true;
BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase"] = true;
Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[309]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations = true;
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] = true;
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_IncreasedTaxSME = true; BaseGame.Policy_Economy_TaxBreaksForPrivateCorps = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxSME"] = true;
Variable["BaseGame.Policy_Economy_TaxBreaksForPrivateCorps"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease = true;
BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease"] = true;
Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[312]`
Mówca: **Mikail Aven**
> "“An excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Edith Agnoc**
> "“I agree. Thanks to this, the recession will be solved in no time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Symon Holl**
> "“I think this will actually have negative effects on our economy. People will suffer... But anyway...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[315]`
Mówca: **Symon Holl**
> "“We will be increasing taxes for smaller businesses. And there will be a tax break large corporations. This will drain a lot from the smaller businesses to balance the state budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Narrator**
> "Symon organized the stack of papers he had in front and placed them back into his briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[317]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -1  or  Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[319]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -1  or  Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Symon Holl**
> "“Unfortunately this is not a possibility. People have no money left to give to the state. Our economic development cannot support this. There's not much value in circulation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[321]`
Mówca: **Symon Holl**
> "“Unfortunately this is not a possibility. Our state is broke. We are barely functioning with the current taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[322]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= -1 &&
BaseGame.Economy >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= -1 &&
BaseGame.Economy >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -1  and 
Variable["BaseGame.Economy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[324]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget >= -1 &&
BaseGame.Economy >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -1  and 
Variable["BaseGame.Economy"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Symon Holl**
> "“Sordland needs change to get out of recession. But the current state of the economy is in shambles. There is not much change we can do about taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[326]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[328]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Symon Holl**
> "“Unfortunately there is not much to do but to maintain their taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[330]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Tax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Tax == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Tax == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Tax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[333]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_TaxFulfilled = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[334]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Tax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Tax == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Tax == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Tax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[337]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_TaxFulfilled = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[338]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[342]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[345]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_UnitedContanaEmbargo = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_UnitedContanaEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[346]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[348]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[349]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[350]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[352]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[357]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[360]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && 
BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && 
BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && 
BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[365]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1;
BaseGame.Capitalist -= 3; BaseGame.Sollist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Empty instruction to organize nodes)*
- **Efekt (`userScript`):** `-- Empty instruction to organize nodes;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[368]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_TorrenSchoolAward = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_TorrenSchoolAward"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[369]`
Mówca: **Narrator**
> "I went by the windows again and kept watching the sea in silence for some more time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[370]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[372]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Narrator**
> "I went by the windows again and kept watching the sea in silence for some more time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[374]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[376]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[377]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true || BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true || BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true  and (Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  or  Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true || BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true  and (Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  or  Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_TaxEvasion = false;
BaseGame.Situation_Economy_TaxEfficientEconomy = false;
BaseGame.Situation_Economy_TaxAvoidance = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_TaxEvasion"] = false;
Variable["BaseGame.Situation_Economy_TaxEfficientEconomy"] = false;
Variable["BaseGame.Situation_Economy_TaxAvoidance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[381]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Increased == true && (BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true || BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Increased == true && (BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true || BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true  and  (Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Justice_Increased == true && (BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true || BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true  and  (Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_TaxEvasion = false;
BaseGame.Situation_Economy_TaxEfficientEconomy = false;
BaseGame.Situation_Economy_TaxAvoidance = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_TaxEvasion"] = false;
Variable["BaseGame.Situation_Economy_TaxEfficientEconomy"] = false;
Variable["BaseGame.Situation_Economy_TaxAvoidance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_CreateJobs = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[389]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[392]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_LargeBusiness_Downsize = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[393]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[395]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[396]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[399]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Growth = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_SmallBusiness_Stagnate = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[402]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist -= 2;
BaseGame.Capitalist += 3; BaseGame.Sollist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[406]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist -= 3;
BaseGame.Capitalist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 3;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[410]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 2;
BaseGame.Capitalist -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[414]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist -= 1;
BaseGame.Capitalist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[418]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[420]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 2;
BaseGame.Capitalist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[422]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1;
BaseGame.Capitalist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[426]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[429]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist -= 2;
BaseGame.Capitalist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[430]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[431]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[433]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[434]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[435]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[437]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[438]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[439]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[441]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[442]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[445]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 4;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 4;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[446]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 3;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[447]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[449]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[450]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[452]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 3;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[454]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[456]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[457]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[459]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Privatization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Privatization == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[461]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Privatization == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[462]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Privatization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Privatization == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Privatization == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[465]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[466]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[467]`
**[WYBÓR GRACZA: "“I didn't want to hamper our businesses and their employment drive.”"]** — Mówca: **Player**
> "“I didn't want to hamper our businesses and their employment drive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[468]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Highway", 75);)*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Highway", 75);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[469]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Railway", 75);)*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Railway", 75);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[470]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[473]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[474]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Arvory", "City_RapidGrowth");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_RapidGrowth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[475]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[477]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[478]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Laren", "City_HighLevelsofPoverty");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_HighLevelsofPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[479]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[480]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // filler node)*
- **Efekt (`userScript`):** `-- filler node;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[481]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[483]`

### Węzeł `[482]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[483]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[484]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Deyr", "City_DecreasingHomelessness");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Deyr","City_DecreasingHomelessness");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Deyr", "City_Homelessness");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Deyr","City_Homelessness");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[486]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Sarna", "City_AgriculturalGrowth");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","City_AgriculturalGrowth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[487]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Deyr", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Deyr","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[488]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`
  - -> `[490]`

### Węzeł `[489]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[490]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[491]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Morna", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Morna","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Morna", "City_DecreasingUnemployment");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Morna","City_DecreasingUnemployment");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[493]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Morna", "City_DecreasingJobOpenings");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_DecreasingJobOpenings");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[494]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[495]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Relaxed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Relaxed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Immigration_Relaxed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[498]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_HP_RemusRelaxedMigration = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_RemusRelaxedMigration"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_HP_RemusTightMigration = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_RemusTightMigration"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[500]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Valgen_GruniRuralDev = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Valgen_GruniRuralDev"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`
