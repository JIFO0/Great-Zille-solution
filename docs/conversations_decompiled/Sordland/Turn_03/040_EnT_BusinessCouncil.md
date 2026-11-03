# Sordland/Turn03/EnT_BusinessCouncil

- **ID konwersacji:** `40`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/040_EnT_BusinessCouncil.md`
- **Liczba węzłów dialogowych:** 695
- **Liczba wyborów gracza:** 179

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[13]** Mikail Aven
- **[19]** Walter Tusk
- **[25]** Edith Agnoc
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_Funeral_Attend`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn03_EnT_Business_GuardsOutside`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Relations_Walter_Promise_Privatization`
- `BaseGame.Relations_Walter_Promise_Tax`
- `BaseGame.Situation_Order_Nationwide_Protests`
- `BaseGame.Situation_Order_Nationwide_Quelled`
- `BaseGame.Situation_Order_Nationwide_Revolt`
- `BaseGameIsolated.Turn03_EnT_Business_GuardsOutside`
- `BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall`
- `BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_BludBan`
- `BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_Poisoned`
- `BaseGameSupport.CountryReport_Turn03_Rumburg_Emergency_BannedRumburg`
- `BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk`
- `BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTusk`
- `BaseGameSupport.Journal_Turn03_BusinessCouncil_RejectedTusk`
- `BaseGameSupport.News_Turn03_HP_Emergency_WPBArrests`
- `BaseGameSupport.News_Turn03_HP_WorkerBillDrafted`
- `BaseGameSupport.News_Turn03_LT_LeagueWomenMarch`
- `BaseGameSupport.News_Turn03_LT_LeagueWomenStrike`
- `BaseGameSupport.News_Turn03_LT_MorbelMineDisaster`
- `BaseGameSupport.News_Turn03_ST_BusinessCouncil`
- `BaseGameSupport.Report_Turn03_Anrica_Emergency_SuspendedProtests`
- `BaseGameSupport.Report_Turn03_Arvory_BombAttack`
- `BaseGameSupport.Report_Turn03_Jen_Emergency_YSBanned`
- `BaseGameSupport.Report_Turn03_Laren_Emergency_DetentionWithoutTrial`
- `BaseGameSupport.Report_Turn03_Lenkurg_Emergency_PoliceAuthority`
- `BaseGameSupport.Report_Turn03_Ribel_SchoolPoisoning`
- `BaseGameSupport.Report_Turn03_Sarna_Emergency_Surveillance`
- `GameCondition.Turn03_EnT_BusinessCouncil`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 34

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Walter_Promise_Privatization`
- `BaseGame.Relations_Walter_Promise_Tax`
- `BaseGameSupport.Report_Turn03_Lenkurg_Emergency_PoliceAuthority`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[21]` (Serge Wolkner): `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- Węzeł `[30]` (Serge Wolkner): `Variable["GameCondition.Turn03_EnT_BusinessCouncil"] = true;`
- Węzeł `[63]` (Serge Wolkner): `Variable["BaseGame.Relations_Walter_Promise_Privatization"] = true;`
- Węzeł `[64]` (Serge Wolkner): `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- Węzeł `[68]` (Serge Wolkner): `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- Węzeł `[98]` (Serge Wolkner): `Variable["BaseGame.Relations_Walter_Promise_Privatization"] = true;`
- Węzeł `[99]` (Serge Wolkner): `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- Węzeł `[104]` (Serge Wolkner): `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- *...oraz 26 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "Enter the car."]** — Mówca: **Player_Italic**
> "I entered the car and we drove to our residence in Lachaven. Serge took the seaside route."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[4]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“I'm all ears.”"]** — Mówca: **Player**
> "“Go ahead, I'm all ears.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Sure, if you have to.”"]** — Mówca: **Player**
> "“Sure, if you have to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Walter lit his cigar and took a few drags before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
Mówca: **Walter Tusk**
> "“The consensus is that we see eye to eye in the economic direction you have taken by promoting a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[60]`
  - -> `[75]`

### Węzeł `[11]`
Mówca: **Walter Tusk**
> "“Many in the group are disappointed in the economic direction that you took by promoting an inefficient planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[74]`
  - -> `[76]`
  - -> `[635]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“I'm glad that the group is supportive.”"]** — Mówca: **Player**
> "“I'm glad that the group is supportive of the decision. It was calculated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“What can be done to amend the situation?”"]** — Mówca: **Player**
> "“I want the situation to be resolved. What can be done to amend the situation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Promises made during the election had to be upheld. That was the main reason behind the decision.”"]** — Mówca: **Player**
> "“Promises made during the election had to be upheld. That was the main reason behind the decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“The opinions of the Lotherberg group don't concern me. I will make choices on my own accord.”"]** — Mówca: **Player**
> "“The opinions of the Lotherberg group don't concern me. I will make choices on my own accord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Walter Tusk**
> "“If the administration were to pass a private corporation tax cut and privatise both healthcare and education, it would do wonders in the attitude of Lotherberg towards the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[17]`
Mówca: **Walter Tusk**
> "“Dissatisfaction of Lotherberg should concern you, Mr. President. It should concern you very much. Especially after you took our 'contribution' and didn't act on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[18]`
Mówca: **Walter Tusk**
> "“They represent a large collective of economic power. Cooperation would be helpful in solving the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Walter didn't look satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[20]`
Mówca: **Walter Tusk**
> "“Political motivations are admirable but economics is about numbers and the current reality, not the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[21]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Tax = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I will give large private corporations a tax reduction.” [Promise Tax Cut]"]** — Mówca: **Player**
> "“I will give large private corporations a tax reduction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“I will make tax decisions objectively. Can't promise you anything.”"]** — Mówca: **Player**
> "“I will make tax decisions objectively. Can't promise you anything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“I'm very satisfied to hear this. To us and the prosperous future of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[25]`
Mówca: **Walter Tusk**
> "“Oh let's not be hasty. The recession will end if Lotherberg is on your side, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[26]`
Mówca: **Walter Tusk**
> "“It's hard to argue against compromise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Maybe meeting in the middle is the solution.”"]** — Mówca: **Player**
> "“Maybe meeting in the middle is the solution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“This time it isn't. I won't change my mind.”"]** — Mówca: **Player**
> "“This time it isn't. I won't change my mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Walter smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[30]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_EnT_BusinessCouncil = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_EnT_BusinessCouncil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Walter left and Serge came to pick me up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[32]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[35]`
Mówca: **Walter Tusk**
> "“It seems that you have decided to tackle the Old Guard in the new Constitution. That is brave indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Walter Tusk**
> ""We are really concerned about the state of emergency. We found ourselves worrying about the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Walter Tusk**
> "“Finally a President that listens to the people. It won't be easy to pass the new Constitution through the Assembly and the Supreme Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Walter Tusk**
> ""We could be a strong ally in breaking that status quo, if you fulfil our requests. We can help with the Assembly and perhaps the Court...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[39]`
Mówca: **Walter Tusk**
> "“We could help you get it through, if you in return help us with a few economic requests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[40]`
Mówca: **Walter Tusk**
> "“We need stability for business to function. So if you want us on your side with our capital there are a few requests on our end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[41]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[44]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Walter Tusk**
> "“We had a deal about the first mega infrastructure project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[48]`
Mówca: **Walter Tusk**
> "“You rejected our previous discrete offer to pick Underhall Construction for the execution of the first mega infrastructure project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
Mówca: **Walter Tusk**
> "“You held on to that promise and awarded the contract to Underhall Construction. This went well in our book.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[50]`
Mówca: **Walter Tusk**
> "“You broke that promise and didn't award the contract to Underhall Construction. This action led to a huge disappointment in the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[15]`

### Węzeł `[51]`
Mówca: **Walter Tusk**
> "“However, you still made the right choice. Your party not getting that donation is unfortunate though. Why someone wouldn't want that money is beyond me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[52]`
Mówca: **Walter Tusk**
> "“We are aware of the upcoming tax meeting and it would be a step in the right direction if private corporations would get a tax cut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Walter Tusk**
> "“To boost the economy with job creation, of course... And the positive side effect would be our support to the administration throughout the entire term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`
  - -> `[644]`

### Węzeł `[54]`
Mówca: **Walter Tusk**
> "“Usually the Lotherberg spokesman doesn't directly comment on the administration, but I'd like to say a few things since this was a special evening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[637]`

### Węzeł `[55]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[57]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Walter Tusk**
> "“This action led to disappointment in the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[59]`
Mówca: **Walter Tusk**
> "“From our end the previous mishap would be cleared and confidence in the new administration from the business community would be restored.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[61]`
  - -> `[62]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I'm interested to collaborate further in our shared interests.”"]** — Mówca: **Player**
> "“I'm interested to collaborate further in our shared interests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“I will give a private corporation tax cut and enable privatization in health and education.” [Promise Tax Cut]"]** — Mówca: **Player**
> "“I will give a private corporation tax cut and enable privatization in health and education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I will make tax and privatization decisions objectively. Can't promise you anything.”"]** — Mówca: **Player**
> "“I will make tax and privatization decisions objectively. Can't promise you anything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[63]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Privatization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Tax = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“Privatization can lead to a many good things, President Rayne. It is certainly an opportunity to raise further money inside the welfare branches.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[66]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[67]`
Mówca: **Narrator**
> "There was an awkward silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[68]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[69]`
Mówca: **Narrator**
> "He gestured at the guards and then called me inside the small VIP lounge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`
  - -> `[632]`

### Węzeł `[70]`
Mówca: **Narrator**
> "He called me inside the small VIP lounge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`
  - -> `[632]`
  - -> `[631]`

### Węzeł `[71]`
Mówca: **Walter Tusk**
> "“President. A moment alone please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[72]`
Mówca: **Walter Tusk**
> "“Either way... President, we are here and always ready to work with you if you change your mind. Don't forget that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[83]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“[Request Bribe] I would want a financial contribution from your end.”"]** — Mówca: **Player**
> "“I would want a financial contribution from your end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“We are certainly interested in maintaining a good relationship with Lotherberg.”"]** — Mówca: **Player**
> "“We are certainly interested in maintaining a good relationship with Lotherberg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Good to know but not sure how this concerns me.”"]** — Mówca: **Player**
> "“Good to know but not sure how this concerns me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“We don't share similar interests with Lotherberg.”"]** — Mówca: **Player**
> "“We don't share similar interests with Lotherberg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
Mówca: **Walter Tusk**
> "“Then we have the right attitude!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
Mówca: **Walter Tusk**
> "“Oh it definitely should, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Walter Tusk**
> "“In that case we can move towards a better future together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Walter Tusk**
> "“Yet we live in the same country don't we? Let's settle our differences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "He looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[82]`
Mówca: **Walter Tusk**
> "“There are many who put their trust in you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“I will think about it but not now.”"]** — Mówca: **Player**
> "“I will think about it but not now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“There is nothing to work together on. Good evening.”"]** — Mówca: **Player**
> "“There is nothing to work together on. Good evening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“It is assuring to know that we are allies.”"]** — Mówca: **Player**
> "“It is assuring to know that we are allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Glad we could come to an agreement, Walter.”"]** — Mówca: **Player**
> "“Glad we could come to an agreement, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[87]`
Mówca: **Walter Tusk**
> "“The last time obviously caused some trust issues between us. We would love to contribute in the future if you agree to the terms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[88]`
Mówca: **Walter Tusk**
> "“That's a shame. I did offer you a peace branch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[89]`
Mówca: **Walter Tusk**
> "“Why can't we all just be friends?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[90]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“I don't think so, I have other plans for the economy.”"]** — Mówca: **Player**
> "“I don't think so, I have other plans for the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Maybe we can. I'll see what I can do.""]** — Mówca: **Player**
> ""Maybe we can. I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[92]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Walter Tusk**
> "“Excellent! Glad to hear this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[96]`
Mówca: **Walter Tusk**
> "“The group wants a private corporation tax cut and privatization in healthcare and education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[97]`
Mówca: **Walter Tusk**
> "“The only thing the Group wants is a private corporation tax cut and we will fully support your administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[98]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Privatization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Tax = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I will give a private corporation tax cut and enable privatization in health and education.” [Promise Tax Cut]"]** — Mówca: **Player**
> "“I will give a private corporation tax cut and enable privatization in health and education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“That is too much of an ask. On third thought, I have to reject.”"]** — Mówca: **Player**
> "“That is too much of an ask. On third thought, I have to reject.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“I will pass a private corporation tax cut.” [Promise Tax Cut]"]** — Mówca: **Player**
> "“I will pass a private corporation tax cut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“That is too much of an ask. On third thought, I have to reject.”"]** — Mówca: **Player**
> "“That is too much of an ask. On third thought, I have to reject.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[104]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Tax = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[105]`
Mówca: **Walter Tusk**
> "“See you, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[106]`
Mówca: **Narrator**
> "We were in Lachaven to work with the Business Council to assess weaknesses in the economy. Symon organised a dinner with the affluent economic figureheads of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[109]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Beaming with pride, he led us to a private room and got us seated at a large table, covered for the occasion with a maroon tablecloth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[111]`
Mówca: **Narrator**
> "When we arrived, the streets were quiet and police forces were patrolling everywhere. The emergency was felt in the vacant city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Narrator**
> "When we arrived, the streets were bustling with activity even though the atmosphere in the country was tense. Lachaveners didn't seem very worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Together with Walter Tusk, Edith Agnoc, Mikail Aven and Symon Holl, we entered the renowned Esteria restaurant by the coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Narrator**
> "A short blonde man whose embroidered pocket read "Manager," greeted us and waved his arms in excitement as he told us how pleased he was to have us in his establishment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[115]`
Mówca: **Narrator**
> "We were quickly served by a group of servers. Walter spoke as they started taking our orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
Mówca: **Walter Tusk**
> "“I recommend the Lachaven Salmon, President. You have to taste this local delicacy here, the best in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[123]`
  - -> `[126]`
  - -> `[124]`

### Węzeł `[117]`
Mówca: **Symon Holl**
> ""No need for that. I hope everybody enjoys the evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Don't get me wrong, Mr. Tusk, but of course I've tasted this greatness many times here already."]** — Mówca: **Player**
> "“Don't get me wrong, Mr. Tusk, but of course I've tasted this greatness many times here already."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[119]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[122]`
Mówca: **Walter Tusk**
> "“I recommend the Lachaven Salmon of this place, President. I know that you're from Lachaven, but I bet you haven't tasted anything like this before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`
  - -> `[118]`
  - -> `[123]`
  - -> `[126]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "Order Lachaven Salmon."]** — Mówca: **Player_Italic**
> "I ordered Lachaven Salmon for the main course. The servers took their notes and asked about the second dish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[130]`
  - -> `[129]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "Order Lespian Pasta."]** — Mówca: **Player_Italic**
> "I ordered Lespian pasta for the main course. The servers took their notes and asked about the second dish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[129]`
  - -> `[132]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“I appreciate the advice but I don't like salmon.""]** — Mówca: **Player**
> "“I appreciate the advice but I don't like salmon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "Order traditional Sordish bean stew."]** — Mówca: **Player_Italic**
> "I ordered traditional Sordish bean stew for the main course. The servers took their notes and asked about the second dish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[130]`
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Walter Tusk**
> "“Really? Too bad. I guess that's your loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[124]`

### Węzeł `[128]`
Mówca: **Walter Tusk**
> "“Excuse me, President. I should have known that a man of your calibre would be a regular at Esteria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[126]`
  - -> `[124]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "Order no more."]** — Mówca: **Player_Italic**
> "I did not order any other dish and thanked the servers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "Order salad."]** — Mówca: **Player_Italic**
> "I ordered salad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "Order rice."]** — Mówca: **Player_Italic**
> "I ordered rice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "Order rice."]** — Mówca: **Player_Italic**
> "I ordered rice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Walter Tusk**
> ""You should couple that dish with some Lespian salad, President. It's no good when it's by itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`
  - -> `[141]`

### Węzeł `[134]`
Mówca: **Walter Tusk**
> ""That's two starch dishes, President. That's no good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`
  - -> `[142]`

### Węzeł `[135]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_Funeral_Attend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_Funeral_Attend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[137]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_Funeral_Attend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[138]`
Mówca: **Narrator**
> "The servers placed glasses in front of each of us and served bread and water. After they were done taking orders, they quickly left us alone in the private room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“Thank you but I'm fine.""]** — Mówca: **Player**
> "“Thank you but I'm fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""You're right. I'll get some salad too.""]** — Mówca: **Player**
> ""You're right. I'll get some salad too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Why don't you focus on your own order, Mr. Tusk?""]** — Mówca: **Player**
> ""Why don't you focus on your own order, Mr. Tusk?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Why don't you focus on your own order, Mr. Tusk?""]** — Mówca: **Player**
> ""Why don't you focus on your own order, Mr. Tusk?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "“Thank you, but this is fine.""]** — Mówca: **Player**
> "“Thank you, but this is fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""What is your suggestion?""]** — Mówca: **Player**
> ""What is your suggestion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "One of the servers quickly jumped in the conversation and told me that Mr. Tusk was right, and went on to explain why two starch dishes do not go together. He then offered to prepare me something special."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[146]`
Mówca: **Walter Tusk**
> ""It was just a suggestion, President... Come now, relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Walter Tusk**
> ""I only wanted you to have the best possible experience!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[148]`
Mówca: **Walter Tusk**
> ""However you please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[149]`
Mówca: **Walter Tusk**
> ""Good choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""No, I want exactly what I ordered.""]** — Mówca: **Player**
> ""No, I want exactly what I ordered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Well... Okay then. Thank you.""]** — Mówca: **Player**
> ""Well... Okay then. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""What is this? Can't I order what I want anymore?""]** — Mówca: **Player**
> ""What is this? Can't I order what I want anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Walter Tusk**
> ""Oh come on. He is the President! Serve him what he wants!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Narrator**
> "The server looked uneasy. He replied, "I'm sorry, Mr. President. This is a very special establishment and we want to provide the best quality service. Therefore, we cannot serve two starch dishes as they do not complement each ot-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[155]`
Mówca: **Narrator**
> "The server respectfully bowed his head and took notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[156]`
Mówca: **Narrator**
> "After a brief argument, the server agreed to prepare my order and apologized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[157]`
Mówca: **Edith Agnoc**
> "“Mr. President, I didn't have the possibility to thank you for coming today. Your presence means a great deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Mikail Aven**
> ""Indeed, sir. It's an honor to dine with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`
  - -> `[161]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
**[WYBÓR GRACZA: ""It's great to be here with the members of the Business Council.""]** — Mówca: **Player**
> ""It's great to be here with the members of the Business Council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
**[WYBÓR GRACZA: ""Likewise.""]** — Mówca: **Player**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Mikail Aven**
> ""We should thank Symon for organizing this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[163]`
Mówca: **Walter Tusk**
> ""Well, it tastes even better! Best of Lespia, the Chateau de Falenco 1934.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[164]`
Mówca: **Symon Holl**
> ""Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[166]`
  - -> `[168]`
  - -> `[169]`

### Węzeł `[165]`
Mówca: **Narrator**
> "Symon gestured at the expensive looking red wine bottle that one of the servers had just brought to the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""That looks amazing.""]** — Mówca: **Player**
> ""That looks amazing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded at him. He started to carefully pour some wine in my glass and waited for me to taste it before filling it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[168]`
**[WYBÓR GRACZA: ""Yes?""]** — Mówca: **Player**
> ""Yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""No, thank you.""]** — Mówca: **Player**
> ""No, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Symon Holl**
> ""Do you want some, sir? It is Chateau de Falenco, from 1934.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Walter Tusk**
> ""Are you serious, Mr. Rayne? Are you going to pass on a Chateau de Falenco 1934?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`
  - -> `[175]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""What kind of question is that? Of course.""]** — Mówca: **Player**
> ""What kind of question is that? Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Let's try it.""]** — Mówca: **Player**
> ""Let's try it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Thank you, but I'm not going to drink this evening.""]** — Mówca: **Player**
> ""Thank you, but I'm not going to drink this evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""I'd prefer something regional or at least Sordish.""]** — Mówca: **Player**
> ""I'd prefer something regional or at least Sordish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Walter Tusk**
> ""I see. Wine patriotism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[177]`
Mówca: **Walter Tusk**
> ""I have to insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`
  - -> `[181]`

### Węzeł `[178]`
Mówca: **Narrator**
> "After filling everybody's glasses, Symon stood up and raised his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[179]`
**[WYBÓR GRACZA: ""As I've said, I'm not going to drink.""]** — Mówca: **Player**
> ""As I've said, I'm not going to drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Fine... I can't turn down a man like you, Mr. Tusk.""]** — Mówca: **Player**
> ""Fine... I can't turn down a man like you, Mr. Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""I can't drink now when the country is suffering.""]** — Mówca: **Player**
> ""I can't drink now when the country is suffering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[182]`
Mówca: **Narrator**
> "He laughed and gestured at the waiter to bring the best Sordish wine that they had."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Walter Tusk**
> ""It is solved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "The waiter brought a bottle of 'Dandelion.' The world famous red wine from Borin. Symon went ahead and grabbed the bottle from the waiter. He poured some in my glass and waited for me to taste it before filling it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[185]`
Mówca: **Walter Tusk**
> ""Alright, President. Nobody is forcing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[186]`
Mówca: **Walter Tusk**
> ""Well said, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[187]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Walter Tusk**
> ""Sad times, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Walter Tusk**
> ""Sad times, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
Mówca: **Walter Tusk**
> ""But don't you think you overreacted with this emergency situation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Narrator**
> "Symon cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Narrator**
> "There was a brief silence at the table before Symon cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Symon Holl**
> ""Let's not get ourselves down, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Narrator**
> "After everybody was served their preferred drinks, Symon stood up with his glass raised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Symon Holl**
> ""I'd like to raise a toast to all of you here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Symon Holl**
> ""We will get through this period as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[199]`
Mówca: **Symon Holl**
> ""We're meeting here tonight in difficult times. But I believe that, with hard work, cooperation and trust...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[200]`
Mówca: **Symon Holl**
> ""I'd like to thank Mr. Rayne again for his decisiveness when it comes to economic policies... I'm sure we will stop this recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Symon Holl**
> ""I also thank Mr. Tusk for being here with us today... His presence is an honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Symon Holl**
> ""And of course, my colleagues from the Business Council, Mrs. Agnoc and Mr. Aven. Without you, none of these would have been possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Symon Holl**
> ""Let's drink to future cooperation and growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Symon Holl**
> ""For a prosperous Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Narrator**
> "Everybody raised their glasses and toasted each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Narrator**
> "After a couple of more minutes, the servers arrived with our meals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Narrator**
> "When I tasted the food, I went back to my past. It reminded me of my childhood in this city. Even though I couldn't recall much about my father, I remembered that he also loved the food of Esteria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[208]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[210]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Narrator**
> "The food tasted amazing. Walter was right, this place must have been the best place in all of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[212]`
Mówca: **Edith Agnoc**
> ""So, how did you find the food of the best fine dining restaurant in Lachaven, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[216]`
  - -> `[217]`
  - -> `[213]`

### Węzeł `[213]`
**[WYBÓR GRACZA: "“This can't get old. It's an experience. The chef must be tipped.”"]** — Mówca: **Player**
> "“This can't get old. It's an experience. The chef must be tipped.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Walter Tusk**
> ""Definitely it doesn't. But I will take care of the tip. Don't you worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[215]`
Mówca: **Mikail Aven**
> ""Tipping is no small thing. I actually don't like giving tips. People have salaries for a reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[216]`
**[WYBÓR GRACZA: "“Fine food is like fine art. But this particular one is a masterpiece.”"]** — Mówca: **Player**
> "“Fine food is like fine art. But this particular one is a masterpiece.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
**[WYBÓR GRACZA: ""It's okay.""]** — Mówca: **Player**
> ""It's okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Edith Agnoc**
> ""I know exactly what you mean. Art is something else, it embodies so much about us and the world surrounding our lives. And food ca-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[219]`
Mówca: **Walter Tusk**
> ""Oh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[220]`
Mówca: **Walter Tusk**
> "“Says the man visiting one of the finest restaurants in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[221]`
Mówca: **Walter Tusk**
> ""There is an art of everything. The art of making money, food, wine and love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[222]`
Mówca: **Edith Agnoc**
> "“Always generous when it comes to small things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[223]`
Mówca: **Edith Agnoc**
> "“Don't blame it on him. Mr. President didn't choose the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[224]`
**[WYBÓR GRACZA: "“Not a big fan of fancy food, but I must admit that it's very tasty.”"]** — Mówca: **Player**
> "“Not a big fan of fancy food, but I must admit that it's very tasty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[225]`
Mówca: **Edith Agnoc**
> ""You didn't like the food?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""No, I loved it. I just don't like this luxurious fine dining culture.""]** — Mówca: **Player**
> ""No, I loved it. I just don't like this luxurious fine dining culture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""I liked it but it is nothing special.""]** — Mówca: **Player**
> ""I liked it but it is nothing special.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Edith Agnoc**
> ""Oh, I understand what you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[229]`
Mówca: **Walter Tusk**
> ""I hope the manager did not hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[230]`
Mówca: **Mikail Aven**
> ""How are things going in the Maroon Palace? The pressure must have increased after you attended that funeral.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[231]`
Mówca: **Mikail Aven**
> ""But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[232]`
Mówca: **Mikail Aven**
> ""How are things going in the Maroon Palace? The pressure must have increased after you did not attend that funeral.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[233]`
**[WYBÓR GRACZA: ""The pressure was already high. Not much has changed.""]** — Mówca: **Player**
> ""The pressure was already high. Not much has changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[234]`
**[WYBÓR GRACZA: ""It did. But it was the right decision.""]** — Mówca: **Player**
> ""It did. But it was the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[235]`
**[WYBÓR GRACZA: ""I have to say, the future is looking good.""]** — Mówca: **Player**
> ""I have to say, the future is looking good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[236]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
**[WYBÓR GRACZA: ""It's tough but our work on the new constitution continues.""]** — Mówca: **Player**
> ""It's tough but our work on the new constitution continues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[240]`
**[WYBÓR GRACZA: ""It's tough but the new laws will fix it.""]** — Mówca: **Player**
> ""It's tough but the new laws will fix it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[241]`
Mówca: **Narrator**
> "We were escorted by heavily armed police forces as well as the presidential guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[242]`
Mówca: **Mikail Aven**
> ""You will get through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
Mówca: **Mikail Aven**
> ""Of course. I didn't mean to criticise your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[244]`
Mówca: **Mikail Aven**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Mikail Aven**
> ""We all hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Narrator**
> "As we conversed with Mikail, I heard Walter raise his voice in an apparent argument with Edith and Symon. We both stopped to listen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Walter Tusk**
> ""...Arcasia knows the right way of doing business. Their approach to the world is real and raw. I'd prefer that cutthroat approach in comparison to the niceties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Symon Holl**
> ""I mean... It's a nice country to visit too. I have travelled there often in business trips. Their attitude on-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[249]`
Mówca: **Edith Agnoc**
> ""Well-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[250]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[251]`
Mówca: **Edith Agnoc**
> ""All countries are nice to visit if you have the cash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[259]`
  - -> `[263]`
  - -> `[262]`

### Węzeł `[252]`
Mówca: **Walter Tusk**
> ""Why would you, President? Or why wouldn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[253]`
Mówca: **Mikail Aven**
> ""Where is this pile of gold you keep talking about Walter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[254]`
Mówca: **Mikail Aven**
> ""By the way...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[255]`
**[WYBÓR GRACZA: "“Make sure to lay a good foundation for our negotiations to start on.”"]** — Mówca: **Player**
> "“Make sure to lay a good foundation for our negotiations to start on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[256]`
**[WYBÓR GRACZA: "“I am looking forward to those visits. It's been a long time since I left the country.”"]** — Mówca: **Player**
> "“I am looking forward to those visits. It's been a long time since I left the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[257]`
Mówca: **Symon Holl**
> "“Walter is taking us down the rabbit hole again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[258]`
Mówca: **Symon Holl**
> "“Our talented team is lead by Mr. Wisci. His wealth of knowledge and extensive connections will aid in our endeavour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[259]`
**[WYBÓR GRACZA: "“Money does turn the world around. Travel is the least you can buy with it.”"]** — Mówca: **Player**
> "“Money does turn the world around. Travel is the least you can buy with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[260]`
Mówca: **Symon Holl**
> "“Staalport is a relatively calm and nice seaside city. I'm sure you'll like it there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[261]`
Mówca: **Walter Tusk**
> "“The picture would have been very different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Exactly. How about the people who don't have extra cash to spend?""]** — Mówca: **Player**
> ""Exactly. How about the people who don't have extra cash to spend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[263]`
**[WYBÓR GRACZA: "“Certainly not all.”"]** — Mówca: **Player**
> "“Certainly not all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[264]`
Mówca: **Mikail Aven**
> ""Can't disagree. The President deserves a better wage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Symon Holl**
> "“Walter is taking us down the rabbit hole again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[266]`
**[WYBÓR GRACZA: "“Old men plant trees whose shade they shall never sit under.”"]** — Mówca: **Player**
> "“Old men plant trees whose shade they shall never sit under.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[267]`
Mówca: **Walter Tusk**
> "“Hear, hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[268]`
**[WYBÓR GRACZA: "“Truly an egotistical way to look at the world.”"]** — Mówca: **Player**
> "“Truly an egotistical way to look at the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[269]`
Mówca: **Walter Tusk**
> "“What about disease? What about death? What about everything that is wrong with the world?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[270]`
**[WYBÓR GRACZA: "“You are right, Walter. We only live once.”"]** — Mówca: **Player**
> "“You are right, Walter. We only live once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[271]`
Mówca: **Walter Tusk**
> ""You work day and night for the nation, surely you deserve a higher salary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[272]`
Mówca: **Walter Tusk**
> "“Half the globe isn't worth our time nor attention. That won't change unless profitability increases.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[273]`
Mówca: **Walter Tusk**
> ""As long as you hold the treasure the country is yours. We are all part of that treasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[274]`
**[WYBÓR GRACZA: "“Power controls money.”"]** — Mówca: **Player**
> "“Power controls money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[275]`
**[WYBÓR GRACZA: "“Money holds real power.”"]** — Mówca: **Player**
> "“Money holds real power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[276]`
Mówca: **Walter Tusk**
> ""So you're saying money is power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[274]`
  - -> `[275]`

### Węzeł `[277]`
Mówca: **Walter Tusk**
> "“These are matters beyond our lives. We should focus on the betterment of ourselves and enjoy what we have, instead of worrying about what others don't have.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[270]`
  - -> `[268]`
  - -> `[266]`

### Węzeł `[278]`
Mówca: **Mikail Aven**
> "“Walter's classic absolutes. But I do agree with you investment-wise. There are only a select group of countries that guarantee a return on investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[279]`
**[WYBÓR GRACZA: "“The world isn't black and white.”"]** — Mówca: **Player**
> "“The world isn't black and white.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[280]`
**[WYBÓR GRACZA: "“I am not a person to be motivated or influenced by money.”"]** — Mówca: **Player**
> "“I am not a person to be motivated or influenced by money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[281]`
Mówca: **Walter Tusk**
> "“There we go! You have to let loose of that burden of yours or it will consume you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[282]`
Mówca: **Symon Holl**
> "“Talking of which, we are preparing our visit to Agnolia and Wehlen where we will meet their governments to settle our trade negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[283]`
Mówca: **Walter Tusk**
> ""We see eye to eye! What a privilege to agree with the President of Sordland himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[284]`
Mówca: **Walter Tusk**
> "“It's just facts. Life is short and there is only so much we can do. Why not focus all the energy on ourselves?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[285]`
Mówca: **Walter Tusk**
> "“An idealist at heart. You know what they say, being a romantic idealist is easy when you have the time and money to be able to just sit down, relax and dream.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[286]`
Mówca: **Walter Tusk**
> "“You would be surprised how much it is so, it is but a matter of price.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[287]`
Mówca: **Walter Tusk**
> "“Yet rulers always use their treasure to maintain power. If you did not control the Ministry of Economy or the Central Bank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[288]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[290]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[291]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "Mikail joined in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Walter Tusk**
> "“Last time I went somewhere for that sort of thing was at university. And even then we had our wild times thanks to Konrath's connected entourage. Also-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[293]`
Mówca: **Mikail Aven**
> "“It certainly depends on what you are looking for. Cultural tourism doesn't require a fancy hotel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[294]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[296]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[297]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[299]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[300]`
Mówca: **Mikail Aven**
> ""I have to congratulate Mr. Rayne for starting such a massive project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`
  - -> `[338]`

### Węzeł `[301]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[303]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[304]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[306]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[307]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[309]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[310]`
Mówca: **Mikail Aven**
> ""I saw that Underhall Construction has already started with the highway construction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Mikail Aven**
> ""Hopefully that project will bring new investments from Agnolia. The mood is already becoming positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[312]`
Mówca: **Mikail Aven**
> ""I saw that the construction of the highway has already started. I have my concerns about the company, but I hope they do a good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Mikail Aven**
> ""I expect that the project will bring new investments from Agnolia. The mood is already becoming positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[314]`
Mówca: **Mikail Aven**
> ""I saw that Underhall Construction has already started with the railway construction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Mikail Aven**
> ""That project will surely boost our economy. The mood is already very positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[316]`
Mówca: **Mikail Aven**
> ""I saw that the construction of the railway has already started. I have my concerns about the company, but I hope they do a good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Mikail Aven**
> ""That project will surely boost our economy if done correctly. The mood is already becoming positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[318]`
Mówca: **Mikail Aven**
> ""The business bailout package was a great investment. I have already seen some positive results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[319]`
Mówca: **Narrator**
> "Symon poured some wine in my glass and waited for me to taste it before filling it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Narrator**
> "I took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[324]`
Mówca: **Narrator**
> "The taste of the wine was immediately stimulating and delightful to my palate. It immediately reminded me of our visits to my father's vineyard when I was a little kid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Narrator**
> "The wine's sweet and bitter flavours exploded in my mouth. The aroma of gooseberries and lilacs tumbled across my tongue, and my mouth tingled with them long after I'd swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[326]`
Mówca: **Narrator**
> "It was bitter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Narrator**
> "Honestly, it tasted like any other wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[328]`
Mówca: **Symon Holl**
> ""How is it? Is the taste to your liking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[331]`
  - -> `[334]`
  - -> `[335]`

### Węzeł `[329]`
**[WYBÓR GRACZA: ""It tastes like heaven. Reminds me of my father's vineyard.""]** — Mówca: **Player**
> ""It tastes like heaven. Reminds me of my father's vineyard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[330]`
Mówca: **Symon Holl**
> ""How is it? Is the taste to your liking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`
  - -> `[334]`
  - -> `[335]`

### Węzeł `[331]`
**[WYBÓR GRACZA: ""Fine balance and a nice touch of gooseberries... I like it.""]** — Mówca: **Player**
> ""Fine balance and a nice touch of gooseberries... I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[332]`
**[WYBÓR GRACZA: ""It has a sour and delicate vegetal character. Is it Arcasia I'm tasting?""]** — Mówca: **Player**
> ""It has a sour and delicate vegetal character. Is it Arcasia I'm tasting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[333]`
**[WYBÓR GRACZA: ""It tastes like heaven.""]** — Mówca: **Player**
> ""It tastes like heaven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[334]`
**[WYBÓR GRACZA: ""It's fine.""]** — Mówca: **Player**
> ""It's fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[335]`
**[WYBÓR GRACZA: ""It tastes like any other wine.""]** — Mówca: **Player**
> ""It tastes like any other wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[336]`
**[WYBÓR GRACZA: ""Thank you for your support, Mr. Aven.""]** — Mówca: **Player**
> ""Thank you for your support, Mr. Aven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[337]`
**[WYBÓR GRACZA: ""No need for that, Mr. Aven. The State is just doing its job.""]** — Mówca: **Player**
> ""No need for that, Mr. Aven. The State is just doing its job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[338]`
**[WYBÓR GRACZA: ""I hope the investment returns will be great.""]** — Mówca: **Player**
> ""I hope the investment returns will be great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[339]`
Mówca: **Mikail Aven**
> ""It has already saved many businesses from declaring bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Mikail Aven**
> ""I have to congratulate Mr. Rayne for spending a massive amount of money for the businesses. This sets a good atmosphere for trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`
  - -> `[338]`
  - -> `[341]`

### Węzeł `[341]`
**[WYBÓR GRACZA: ""That's good to hear.""]** — Mówca: **Player**
> ""That's good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[342]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[345]`
Mówca: **Mikail Aven**
> ""The relief package was also a great investment. It has already saved many businesses from declaring bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Mikail Aven**
> ""I have to congratulate Mr. Rayne for such major projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`
  - -> `[338]`

### Węzeł `[347]`
Mówca: **Mikail Aven**
> ""I've heard that you've bought a new villa, Symon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
**[WYBÓR GRACZA: "“Where is the property?”"]** — Mówca: **Player**
> "“Where is the property?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[349]`
Mówca: **Symon Holl**
> "“I don't comment on rumours, but I'll make an exception since we are among friends. It's true.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`
  - -> `[348]`
  - -> `[467]`

### Węzeł `[350]`
**[WYBÓR GRACZA: "“You are doing a great job so you deserve it.”"]** — Mówca: **Player**
> "“You are doing a great job so you deserve it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[351]`
**[WYBÓR GRACZA: "“A new villa is a bit much. Especially in this economy when people are suffering.”"]** — Mówca: **Player**
> "“A new villa is a bit much. Especially in this economy when people are suffering.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[352]`
**[WYBÓR GRACZA: "“Maybe it shows overcompensation somewhat. Everybody is free to do whatever they want.”"]** — Mówca: **Player**
> "“Maybe it shows overcompensation somewhat. Everybody is free to do whatever they want.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[353]`
Mówca: **Walter Tusk**
> "“Where there is demand there is supply. The market rules supreme as always.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[354]`
Mówca: **Symon Holl**
> "“It is a small seaside villa at the outskirts of Conriat. It's just a modest house with a swimming pool and a small golf course in the property.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`
  - -> `[414]`

### Węzeł `[355]`
Mówca: **Walter Tusk**
> "“So what? My car collection is nearing the forty mark. They are all old timer models.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[365]`
  - -> `[413]`

### Węzeł `[356]`
Mówca: **Edith Agnoc**
> "“He *is* one of the hardest working ministers in the government. He has surely deserved it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[367]`
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Walter Tusk**
> "“Depends who you work for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
**[WYBÓR GRACZA: "“Rewards give the motivation to ensure people go that extra mile.”"]** — Mówca: **Player**
> "“Rewards give the motivation to ensure people go that extra mile.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[359]`
Mówca: **Walter Tusk**
> "“But talking about rewards... It is a fact that the government pays far less than the private sector.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[360]`
**[WYBÓR GRACZA: "“Great city to buy real estate in. Conriat is seeing a surge of investments.”"]** — Mówca: **Player**
> "“Great city to buy real estate in. Conriat is seeing a surge of investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
**[WYBÓR GRACZA: ""So you're becoming a neighbour to Marcel Koronti?""]** — Mówca: **Player**
> ""So you're becoming a neighbour to Marcel Koronti?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[362]`
Mówca: **Edith Agnoc**
> "“Underhall Construction made a fortune constructing houses there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[363]`
Mówca: **Walter Tusk**
> "“Don't expect the rich to become modest in the near future. That would be a pipe dream.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`
  - -> `[465]`
  - -> `[463]`

### Węzeł `[364]`
Mówca: **Symon Holl**
> "“That's true but that was a change made on purpose to push for improvements from the inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[365]`
**[WYBÓR GRACZA: "“I always advocate against ostentatious behaviour. Money shouldn't be wasted for luxury.""]** — Mówca: **Player**
> "“I always advocate against ostentatious behaviour. Money shouldn't be wasted for luxury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[366]`
Mówca: **Symon Holl**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[367]`
**[WYBÓR GRACZA: "“Some prefer the carrot and stick approach. I'm more result oriented.”"]** — Mówca: **Player**
> "“Some prefer the carrot and stick approach. I'm more result oriented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[368]`
Mówca: **Walter Tusk**
> ""What? No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Symon Holl**
> ""You may be tasting the oak from the barrels, or maybe its the gooseberries. It's definitely not Arcasia, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[370]`
Mówca: **Walter Tusk**
> ""See?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[371]`
Mówca: **Walter Tusk**
> ""What? This wine doesn't even need testing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Symon Holl**
> ""Should I fill your glass or would you want another drink, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[373]`

### Węzeł `[373]`
**[WYBÓR GRACZA: ""I think I'm good. I won't have anything for now.""]** — Mówca: **Player**
> ""I think I'm good. I won't have anything for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[374]`
**[WYBÓR GRACZA: ""It's okay. I'll drink it.""]** — Mówca: **Player**
> ""It's okay. I'll drink it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[375]`
Mówca: **Walter Tusk**
> ""I've heard that he was a big wine connoisseur. May he rest in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`
  - -> `[380]`

### Węzeł `[376]`
Mówca: **Walter Tusk**
> ""You know your wine, Mr. Rayne. I respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Narrator**
> "Symon filled up my glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[379]`
**[WYBÓR GRACZA: ""Honestly, I was never close to him. I can't recall too much apart from his lavish parties.""]** — Mówca: **Player**
> ""Honestly, I was never close to him. I can't recall too much apart from his lavish parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[381]`
Mówca: **Walter Tusk**
> ""I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[382]`
Mówca: **Symon Holl**
> ""As you wish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Narrator**
> "He grabbed the bottle again to pour some into Walter Tusk's glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[384]`
Mówca: **Walter Tusk**
> ""You didn't have to serve us, Mr. Holl. There are servers around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[385]`
**[WYBÓR GRACZA: ""I couldn't agree more.""]** — Mówca: **Player**
> ""I couldn't agree more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[386]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[389]`
Mówca: **Narrator**
> "Several of the heavily armed guards were also inside with us, protecting every entrance and exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[390]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[392]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[393]`
Mówca: **Narrator**
> "The guards bowed their heads and went outside. Walter sighed in relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[394]`
Mówca: **Narrator**
> "As all of us started eating. Walter stopped and looked at the guards before turning to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Walter Tusk**
> ""I know that we are in a state of emergency, Mr. Rayne. But can't we even eat alone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Walter Tusk**
> ""What are they protecting here? They have already surrounded the whole restaurant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`
  - -> `[399]`
  - -> `[400]`

### Węzeł `[397]`
**[WYBÓR GRACZA: ""It is a necessity, Mr. Tusk. There's nothing I can do about it.""]** — Mówca: **Player**
> ""It is a necessity, Mr. Tusk. There's nothing I can do about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[398]`
**[WYBÓR GRACZA: ""They have to be prepared for everything.""]** — Mówca: **Player**
> ""They have to be prepared for everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[399]`
**[WYBÓR GRACZA: ""I can take them out, if you want, Mr. Tusk.""]** — Mówca: **Player**
> ""I can take them out, if you want, Mr. Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[400]`
**[WYBÓR GRACZA: ""You're right. Can you guys leave us alone here, please?""]** — Mówca: **Player**
> ""You're right. Can you guys leave us alone here, please?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[401]`
Mówca: **Walter Tusk**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`
  - -> `[404]`

### Węzeł `[402]`
**[WYBÓR GRACZA: ""Can you guys leave us alone here, please?""]** — Mówca: **Player**
> ""Can you guys leave us alone here, please?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[403]`
**[WYBÓR GRACZA: ""You can stay outside the door.""]** — Mówca: **Player**
> ""You can stay outside the door.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[404]`
**[WYBÓR GRACZA: ""Please leave the room. You scared Mr. Tusk.""]** — Mówca: **Player**
> ""Please leave the room. You scared Mr. Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[405]`
Mówca: **Walter Tusk**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Narrator**
> "He didn't look too pleased about the whole situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[407]`
Mówca: **Mikail Aven**
> ""We all hope so, Mr. President. But I think it will work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Mikail Aven**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Mikail Aven**
> ""Mr. Holl also deserves credit, of course. Our *great* economy minister...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Symon Holl**
> ""Is there a joke coming?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Mikail Aven**
> ""Why? I thought you said you were great at economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[412]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[413]`
**[WYBÓR GRACZA: ""How can you speak like that?""]** — Mówca: **Player**
> ""How can you speak like that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[414]`
**[WYBÓR GRACZA: ""Modest? Are you being sarcastic with me?""]** — Mówca: **Player**
> ""Modest? Are you being sarcastic with me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[415]`
Mówca: **Edith Agnoc**
> ""I've heard that your father was a very wealthy man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[416]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[418]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[421]`

### Węzeł `[420]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[421]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[422]`
Mówca: **Narrator**
> "Edith, who was sitting to my left, gently put her hand over my arm for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[423]`
Mówca: **Walter Tusk**
> ""A correction. It wasn't his policies that destroyed him. It was the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[441]`
  - -> `[443]`
  - -> `[527]`

### Węzeł `[424]`
**[WYBÓR GRACZA: ""The kid can handle himself. He doesn't need anybody else.”"]** — Mówca: **Player**
> ""The kid can handle himself. He doesn't need anybody else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[425]`
Mówca: **Narrator**
> "Everyone went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[426]`
Mówca: **Edith Agnoc**
> ""I've heard that you had a difficult life in Deyr. Is that right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[430]`
  - -> `[431]`

### Węzeł `[427]`
Mówca: **Walter Tusk**
> ""That's a good choice. Having a degree in Sordland separates you from the rabble. And we especially need more people who understand economics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[428]`
Mówca: **Edith Agnoc**
> ""I've heard that you were brought up in the capital and experienced all the power shift as it happened. Is that right? It must have been tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[482]`
  - -> `[483]`

### Węzeł `[429]`
Mówca: **Mikail Aven**
> ""But I agree that we need more economists to enter politics. It's unfortunate that Ewald Alphonso was the only leader who actually studied economics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[430]`
**[WYBÓR GRACZA: ""My childhood was very difficult. But it definitely made me stronger.""]** — Mówca: **Player**
> ""My childhood was very difficult. But it definitely made me stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[431]`
**[WYBÓR GRACZA: "“My family cared for me as much as they could. I couldn't ask for more than that.”"]** — Mówca: **Player**
> "“My family cared for me as much as they could. I couldn't ask for more than that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[432]`
**[WYBÓR GRACZA: "“I try to leave my past behind and focus on today. It's who we have become that matters.”"]** — Mówca: **Player**
> "“I try to leave my past behind and focus on today. It's who we have become that matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[433]`
Mówca: **Mikail Aven**
> "“Walter stop with the conspiracy theories. I think we've had enough drinks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[434]`
Mówca: **Mikail Aven**
> "“Talking of which, it's great that we have another leader who actually studied economics and understands it. Like Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[456]`
  - -> `[453]`
  - -> `[506]`

### Węzeł `[435]`
Mówca: **Walter Tusk**
> "“He threatened their economic power base over the country through a vast privatization plan. They removed him and backed you after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[436]`
Mówca: **Mikail Aven**
> "“True, but I think it was his ambition that brought him down. Too many big changes in a short time frame.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[437]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[439]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Lachaven_Economics == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[440]`
Mówca: **Mikail Aven**
> "“That's what I say after a good night of drinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[441]`
**[WYBÓR GRACZA: "“I always had a gut feeling about his sudden fall.”"]** — Mówca: **Player**
> "“I always had a gut feeling about his sudden fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[442]`
Mówca: **Walter Tusk**
> "“Sometimes it impacts people more negatively. My father used to beat me up good when I crossed the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[443]`
**[WYBÓR GRACZA: ""Of course it was. They are a big threat.""]** — Mówca: **Player**
> ""Of course it was. They are a big threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[444]`
Mówca: **Edith Agnoc**
> ""That's very humble of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[445]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[446]`
Mówca: **Symon Holl**
> "“I never met your family, Mr. President. How are they doing, if you don't mind me asking?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`
  - -> `[449]`
  - -> `[490]`

### Węzeł `[447]`
**[WYBÓR GRACZA: "“Look at what he caused. Studying doesn't get you to the finish line.”"]** — Mówca: **Player**
> "“Look at what he caused. Studying doesn't get you to the finish line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[448]`
Mówca: **Edith Agnoc**
> "“We are here because of him. I don't think we had a chance, if he hadn't screwed up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[449]`
**[WYBÓR GRACZA: ""We don't talk much since I became President.""]** — Mówca: **Player**
> ""We don't talk much since I became President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[450]`
Mówca: **Mikail Aven**
> ""It can happen. Sometimes work can get in the way. Don't stress yourself over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[451]`
Mówca: **Mikail Aven**
> ""Well, the rascal didn't even ask for permission to use the yacht and just took it. He basically stole it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[452]`
**[WYBÓR GRACZA: ""I prefer not to talk about my family.""]** — Mówca: **Player**
> ""I prefer not to talk about my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[453]`
**[WYBÓR GRACZA: "“We are in this mess because of him. His political failure nearly destroyed us.”"]** — Mówca: **Player**
> "“We are in this mess because of him. His political failure nearly destroyed us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[454]`
**[WYBÓR GRACZA: ""He is going through the teenager period. It's difficult to connect with him, he's a little shy.""]** — Mówca: **Player**
> ""He is going through the teenager period. It's difficult to connect with him, he's a little shy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[455]`
**[WYBÓR GRACZA: ""Mikail. What did you just say to me?""]** — Mówca: **Player**
> ""Mikail. What did you just say to me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[456]`
**[WYBÓR GRACZA: "“Alphonso was an inspiration for all reformists.""]** — Mówca: **Player**
> "“Alphonso was an inspiration for all reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[457]`
Mówca: **Mikail Aven**
> "“Wish that was my son's biggest problem...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Edith Agnoc**
> ""Darron seemed to be doing fine. I saw that his yacht party in Benfi made the local news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[459]`
Mówca: **Mikail Aven**
> "“He was, he truly wanted to transform this country to a modern nation. His term was very difficult though. He got destroyed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[460]`
Mówca: **Walter Tusk**
> "“Family is everything. My advice would be to make sure that Franc has a solid relationship with you. He is your future, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`
  - -> `[462]`
  - -> `[454]`

### Węzeł `[461]`
Mówca: **Edith Agnoc**
> ""I said that about my daughter too. And she dropped out of university...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[462]`
**[WYBÓR GRACZA: "“I'm trying my best to be a good father to him. He seems to be somewhat introverted.”"]** — Mówca: **Player**
> "“I'm trying my best to be a good father to him. He seems to be somewhat introverted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[463]`
**[WYBÓR GRACZA: ""We'll see about that.""]** — Mówca: **Player**
> ""We'll see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[464]`
**[WYBÓR GRACZA: ""Some people are more sensible. I believe balance is possible.""]** — Mówca: **Player**
> ""Some people are more sensible. I believe balance is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[465]`
**[WYBÓR GRACZA: ""The gap between the rich and the poor is the root cause of this.""]** — Mówca: **Player**
> ""The gap between the rich and the poor is the root cause of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[466]`
Mówca: **Symon Holl**
> "“Some of us are more sensible than others. Balance is possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[467]`
**[WYBÓR GRACZA: ""Why?""]** — Mówca: **Player**
> ""Why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[468]`
Mówca: **Symon Holl**
> ""I already had my eye on the area. Plus it wasn't intended to be public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[469]`
Mówca: **Edith Agnoc**
> ""Come on, let's not talk about finance or politics for now. We came here to relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[470]`
Mówca: **Walter Tusk**
> ""I'm just saying that he's free to do what he please with his hard earned money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[471]`
Mówca: **Walter Tusk**
> ""What's that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[472]`
Mówca: **Symon Holl**
> ""Not really. His place is very remote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Walter Tusk**
> ""Conriat has a way of pulling certain people in, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[474]`
Mówca: **Symon Holl**
> ""No. Is there a problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[475]`
Mówca: **Walter Tusk**
> ""Oh come on! Leave the man be, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[476]`
Mówca: **Edith Agnoc**
> ""Isn't that right, gentlemen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Narrator**
> "She turned to Walter and Symon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[478]`
Mówca: **Narrator**
> "They nodded at her and took a sip from their drinks. She slightly leaned towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[479]`
Mówca: **Edith Agnoc**
> ""So, Mr. Rayne, why don't you tell us what's behind that strong character of yours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[480]`
**[WYBÓR GRACZA: ""It didn't contribute much. My success has nothing to do with that.""]** — Mówca: **Player**
> ""It didn't contribute much. My success has nothing to do with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[481]`
Mówca: **Edith Agnoc**
> "“Would you say that it contributed a lot to your success?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[485]`
  - -> `[486]`
  - -> `[623]`

### Węzeł `[482]`
**[WYBÓR GRACZA: ""It was difficult times in the capital. But I've learned a lot about politics.""]** — Mówca: **Player**
> ""It was difficult times in the capital. But I've learned a lot about politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[483]`
**[WYBÓR GRACZA: ""I didn't suffer much thanks to my family. We didn't have much but we were stable.""]** — Mówca: **Player**
> ""I didn't suffer much thanks to my family. We didn't have much but we were stable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[484]`
Mówca: **Walter Tusk**
> ""It all makes sense now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[485]`
**[WYBÓR GRACZA: ""It certainly helped. Money opened a lot of doors.""]** — Mówca: **Player**
> ""It certainly helped. Money opened a lot of doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[486]`
**[WYBÓR GRACZA: ""We had money but we weren't happy. I learned a lot about life thanks to my absent father.""]** — Mówca: **Player**
> ""We had money but we weren't happy. I learned a lot about life thanks to my absent father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[487]`
Mówca: **Walter Tusk**
> ""Of course not. You've worked hard for it. After all, money can't buy diligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[488]`
Mówca: **Walter Tusk**
> ""Of course it did. What kind of question is that, Edith?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[489]`
Mówca: **Edith Agnoc**
> ""I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[490]`
**[WYBÓR GRACZA: ""They're doing great. We have no problems.""]** — Mówca: **Player**
> ""They're doing great. We have no problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Symon Holl**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[492]`
Mówca: **Symon Holl**
> ""That's great to hear. Your son must be very proud of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[493]`
Mówca: **Walter Tusk**
> "“Family is everything. My advice would be to make sure that Franc has a solid relationship with you. He is your future, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[454]`
  - -> `[424]`
  - -> `[496]`

### Węzeł `[494]`
**[WYBÓR GRACZA: ""I said: I don't want to talk about my family.""]** — Mówca: **Player**
> ""I said: I don't want to talk about my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[495]`
Mówca: **Walter Tusk**
> ""I'm sorry, President. Let me know if I can help with anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[496]`
**[WYBÓR GRACZA: ""Why do you even care?""]** — Mówca: **Player**
> ""Why do you even care?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[497]`
Mówca: **Walter Tusk**
> ""I'm just giving advice, President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[498]`
Mówca: **Walter Tusk**
> ""Nobody would want a son that steals your yacht and make the local news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Mikail Aven**
> ""Good news is that I finally convinced him to go to university. He will study economics in Lachaven Business School.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[500]`
Mówca: **Narrator**
> "He looked at Mikail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[501]`
Mówca: **Walter Tusk**
> ""Maybe your son will be a great future economist!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[502]`
Mówca: **Mikail Aven**
> ""I wouldn't count on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[503]`
Mówca: **Mikail Aven**
> ""Not that I mean anything against you, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[456]`
  - -> `[453]`
  - -> `[455]`

### Węzeł `[504]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[505]`
Mówca: **Mikail Aven**
> ""I'm very confident in your abilities to fix our recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[456]`
  - -> `[453]`
  - -> `[506]`

### Węzeł `[506]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[507]`
Mówca: **Mikail Aven**
> ""I hope we can repair the damages to our economy. We can't fail like Alphonso did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[508]`
**[WYBÓR GRACZA: ""I believe that too.""]** — Mówca: **Player**
> ""I believe that too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[509]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Business_GuardsOutside = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Business_GuardsOutside"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[510]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[512]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[513]`
Mówca: **Edith Agnoc**
> ""Maybe you should help Mikail instead. I saw Darron made the local news with his yacht party in Benfi.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[514]`
Mówca: **Narrator**
> "She looked at Mikail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[515]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Business_GuardsOutside"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[517]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Business_GuardsOutside"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[518]`
Mówca: **Narrator**
> "Walter looked at the guards inside the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`
  - -> `[522]`
  - -> `[521]`
  - -> `[524]`

### Węzeł `[519]`
Mówca: **Walter Tusk**
> ""A correction. It wasn't his policies that destroyed him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[520]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[521]`
**[WYBÓR GRACZA: "“I always had a bad feeling about his sudden fall.”"]** — Mówca: **Player**
> "“I always had a bad feeling about his sudden fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[522]`
**[WYBÓR GRACZA: "“Everybody knows that.”"]** — Mówca: **Player**
> "“Everybody knows that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Walter Tusk**
> ""Let's just say that he threatened the economic power base of some powerful figures within the government with his vast privatization plan. And they removed him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[524]`
**[WYBÓR GRACZA: ""And?""]** — Mówca: **Player**
> ""And?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[525]`
Mówca: **Walter Tusk**
> ""And now they're backing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[526]`
Mówca: **Narrator**
> "He lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[527]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`
  - -> `[529]`

### Węzeł `[528]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[530]`
**[WYBÓR GRACZA: ""You don't want to say this again in public.""]** — Mówca: **Player**
> ""You don't want to say this again in public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[531]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[532]`
Mówca: **Narrator**
> "After a long silence, followed by some chit-chat, Walter ordered a bottle of whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[533]`
**[WYBÓR GRACZA: "“Symon would you give a toast again?”"]** — Mówca: **Player**
> "“Symon would you give a toast again?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[534]`
Mówca: **Symon Holl**
> "“Sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[535]`
Mówca: **Mikail Aven**
> ""That's one good looking bottle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Narrator**
> "The waiters brought one of the finest Arcasian whiskeys. It was time for a toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`
  - -> `[558]`
  - -> `[533]`

### Węzeł `[537]`
**[WYBÓR GRACZA: "“I raise to our health and happiness.”"]** — Mówca: **Player**
> "“I raise to our health and happiness. The two things that one needs for a happy life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[538]`
**[WYBÓR GRACZA: "“To a constructive and beneficial future!”"]** — Mówca: **Player**
> "“To a constructive and beneficial future! May our differences be set aside for a good future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[539]`
**[WYBÓR GRACZA: "“To our wealth and success!”"]** — Mówca: **Player**
> "“To our wealth and success! Let's be honest, that's all that truly matters to any of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[540]`
Mówca: **Narrator**
> "Edith stood up. Most of us were all a little tipsy at this point."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[541]`
Mówca: **Walter Tusk**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[542]`
Mówca: **Narrator**
> "The moon was shining bright as everyone except Walter left in their luxury cars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[543]`
**[WYBÓR GRACZA: "“It's getting late. Let's call it a night.”"]** — Mówca: **Player**
> "“It's getting late. Let's call it a night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[544]`
Mówca: **Edith Agnoc**
> "“I would gladly drink to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[545]`
Mówca: **Mikail Aven**
> "“Me too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[546]`
Mówca: **Walter Tusk**
> "“Cheers to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[547]`
Mówca: **Symon Holl**
> "“Aye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[548]`
Mówca: **Walter Tusk**
> "“They say hope dies last, to the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[549]`
Mówca: **Symon Holl**
> "“I think it's time we call it a night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[550]`
Mówca: **Edith Agnoc**
> "“I want to thank you, Mr. President for joining us and you Symon, for putting all this together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`
  - -> `[555]`
  - -> `[543]`

### Węzeł `[551]`
Mówca: **Mikail Aven**
> "“Raised.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[552]`
Mówca: **Symon Holl**
> "“May the wheels of fortune always turn in our favour! The future of abundance awaits us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[553]`
Mówca: **Mikail Aven**
> ""That's definitely not me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[554]`
Mówca: **Edith Agnoc**
> "“Good night everybody. It was a pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[555]`
**[WYBÓR GRACZA: ""Thank you Edith, for joining with a bunch of ugly rich men.""]** — Mówca: **Player**
> ""Thank you Edith, for joining with a bunch of ugly rich men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[556]`
Mówca: **Walter Tusk**
> ""The President of jokes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[557]`
**[WYBÓR GRACZA: "Toast."]** — Mówca: **Player_Italic**
> "I stood up to give a toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[538]`
  - -> `[539]`
  - -> `[560]`

### Węzeł `[558]`
**[WYBÓR GRACZA: ""I'm not going to drink.""]** — Mówca: **Player**
> ""I'm not going to drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[559]`
Mówca: **Narrator**
> "Symon stood up. He seemed to have a slight issue with his balance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[560]`
**[WYBÓR GRACZA: "“To an equal society without class differences. A Morgna wes core!""]** — Mówca: **Player**
> "“To an equal society without class differences. A Morgna wes core!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[561]`
Mówca: **Narrator**
> "Nobody else responded. And Symon looked like he had a little too much alcohol."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[562]`
Mówca: **Symon Holl**
> ""Aye!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[563]`
Mówca: **Narrator**
> "There was an awkward silence as they looked at each other with glasses in their hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[564]`
Mówca: **Edith Agnoc**
> ""Vectern sis da...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[565]`
Mówca: **Walter Tusk**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[566]`
Mówca: **Walter Tusk**
> ""Let's just drink this up and leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[567]`
Mówca: **Walter Tusk**
> ""Symon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[568]`
**[WYBÓR GRACZA: ""Thank you all for being here.""]** — Mówca: **Player**
> ""Thank you all for being here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[569]`
Mówca: **Walter Tusk**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Mikail Aven**
> ""It was great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[571]`
Mówca: **Mikail Aven**
> ""Thanks for being here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[572]`
Mówca: **Narrator**
> "After bidding our farewells, we slowly walked out the restaurant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[573]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[575]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[576]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[578]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[579]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`
  - -> `[581]`

### Węzeł `[580]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[581]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusiness == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[582]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`
  - -> `[584]`

### Węzeł `[583]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[584]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[585]`
Mówca: **Walter Tusk**
> "“You rejected our previous discrete offer to bail out businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[586]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[588]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[589]`
Mówca: **Walter Tusk**
> "“We had a deal about the business bailout package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[590]`
Mówca: **Walter Tusk**
> "“You held on to that promise. This went well in our book.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[591]`
Mówca: **Walter Tusk**
> "“This action led to disappointment in the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[592]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[593]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`
  - -> `[595]`

### Węzeł `[594]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[595]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[596]`
Mówca: **Walter Tusk**
> "“However, you still made the right choice. Your party not getting that donation is unfortunate though. Why someone wouldn't want that money is beyond me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[597]`
Mówca: **Walter Tusk**
> "“You broke that promise. This action led to a huge disappointment in the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[15]`

### Węzeł `[598]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[599]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_BusinessCouncil_RejectedTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_RejectedTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[600]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[601]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[602]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_BusinessCouncil = true; BaseGameSupport.News_Turn03_LT_MorbelMineDisaster = true;
BaseGameSupport.News_Turn03_HP_WorkerBillDrafted = true;
BaseGameSupport.Report_Turn03_Ribel_SchoolPoisoning = true;
BaseGameSupport.Report_Turn03_Arvory_BombAttack = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_BusinessCouncil"] = true;
Variable["BaseGameSupport.News_Turn03_LT_MorbelMineDisaster"] = true;
Variable["BaseGameSupport.News_Turn03_HP_WorkerBillDrafted"] = true;
Variable["BaseGameSupport.Report_Turn03_Ribel_SchoolPoisoning"] = true;
Variable["BaseGameSupport.Report_Turn03_Arvory_BombAttack"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[603]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`
  - -> `[605]`

### Węzeł `[604]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[605]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[606]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`
  - -> `[608]`

### Węzeł `[607]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[608]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[609]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Jen_Emergency_YSBanned = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Jen_Emergency_YSBanned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[610]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_WPBArrests = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_WPBArrests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[611]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[613]`

### Węzeł `[612]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[613]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[614]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`
  - -> `[616]`

### Węzeł `[615]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[616]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[617]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`
  - -> `[619]`

### Węzeł `[618]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[619]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[620]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Laren_Emergency_DetentionWithoutTrial = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Laren_Emergency_DetentionWithoutTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[621]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Lenkurg_Emergency_PoliceAuthority = true; BaseGameSupport.Report_Turn03_Sarna_Emergency_Surveillance = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Lenkurg_Emergency_PoliceAuthority"] = true;
Variable["BaseGameSupport.Report_Turn03_Sarna_Emergency_Surveillance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[622]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Anrica_Emergency_SuspendedProtests = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Anrica_Emergency_SuspendedProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[623]`
**[WYBÓR GRACZA: ""What's that supposed to mean?""]** — Mówca: **Player**
> ""What's that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[624]`
Mówca: **Edith Agnoc**
> ""Oh. N-Nothing, Mr. President. I'm sorry if it came across wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[625]`
Mówca: **Narrator**
> "The table went quiet for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[626]`
Mówca: **Narrator**
> "Walter stared at me as the guards bowed their heads and went outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[627]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[630]`
Mówca: **Symon Holl**
> ""I'd like to thank Mr. Rayne again for his decisiveness in office... I'm sure we will get through this emergency period and come out stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[631]`
**[WYBÓR GRACZA: ""What do you want?""]** — Mówca: **Player**
> ""What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[632]`
**[WYBÓR GRACZA: "Follow him."]** — Mówca: **Player_Italic**
> "I followed him inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[633]`
**[WYBÓR GRACZA: "Ignore him and leave."]** — Mówca: **Player_Italic**
> "I ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[634]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: Jump to: [Player_Italic: "I entered the car and we drove to o..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[635]`
**[WYBÓR GRACZA: "“I couldn't care less.”"]** — Mówca: **Player**
> "“I couldn't care less.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[636]`
Mówca: **Walter Tusk**
> "“Oh but you definitely should, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[637]`
**[WYBÓR GRACZA: "“I don't want to hear your comments, Mr. Tusk.”"]** — Mówca: **Player**
> "“I don't want to hear your comments, Mr. Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[638]`
Mówca: **Walter Tusk**
> "“You don't mean that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[639]`
Mówca: **Walter Tusk**
> "“The comments of the Lotherberg Group should matter to you, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[640]`
Mówca: **Walter Tusk**
> "“Please let me briefly explain myself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[641]`

### Węzeł `[641]`
**[WYBÓR GRACZA: ""Maybe some other time. Good evening.""]** — Mówca: **Player**
> ""Maybe some other time. Good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[642]`
Mówca: **Narrator**
> "I ignored him and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[643]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: Jump to: [Player_Italic: "I entered the car and we drove to o..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[644]`
**[WYBÓR GRACZA: "“Lotherberg will not influence me.”"]** — Mówca: **Player**
> "“Lotherberg will not influence me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[645]`
Mówca: **Narrator**
> "Everyone fell silent and looked at Mikail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[646]`
Mówca: **Walter Tusk**
> ""Oh, excuse him, President! He didn't mean anything bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[647]`
Mówca: **Mikail Aven**
> ""Er... No. I didn't mean t-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[648]`
Mówca: **Narrator**
> "Walter laughed and Mikail joined in with a nervous laughter soon after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`
  - -> `[651]`

### Węzeł `[649]`
Mówca: **Edith Agnoc**
> "“Enough with this Alphonso talk. His policies already destroyed him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[650]`
**[WYBÓR GRACZA: ""Fine.""]** — Mówca: **Player**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[651]`
**[WYBÓR GRACZA: ""No. What did he just say?""]** — Mówca: **Player**
> ""No. What did he just say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[652]`
Mówca: **Narrator**
> "Nobody responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`
  - -> `[655]`
  - -> `[654]`

### Węzeł `[653]`
**[WYBÓR GRACZA: ""I thought so.""]** — Mówca: **Player**
> ""I thought so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[654]`
**[WYBÓR GRACZA: ""WILL SOMEBODY ANSWER ME?""]** — Mówca: **Player**
> ""WILL SOMEBODY ANSWER ME?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[655]`
**[WYBÓR GRACZA: ""Looks like a cat caught our friend's tongue.""]** — Mówca: **Player**
> ""Looks like a cat caught our friend's tongue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[656]`
Mówca: **Mikail Aven**
> ""No need to shout at the table, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`
  - -> `[657]`

### Węzeł `[657]`
**[WYBÓR GRACZA: ""Enough. I'm done with this dinner.""]** — Mówca: **Player**
> ""Enough. I'm done with this dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[658]`
**[WYBÓR GRACZA: ""You still didn't give me a response.""]** — Mówca: **Player**
> ""You still didn't give me a response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[659]`
Mówca: **Mikail Aven**
> ""I said 'Ewald Alphonso was the only leader who was well-versed in economics'. Please forgive me, I didn't mean to offend you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`
  - -> `[657]`

### Węzeł `[660]`
**[WYBÓR GRACZA: ""Fine. Watch your words next time.""]** — Mówca: **Player**
> ""Fine. Watch your words next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[661]`
Mówca: **Narrator**
> "I stood up and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[662]`
Mówca: **Narrator**
> "Walter came running behind me as I walked outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[663]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`
  - -> `[665]`

### Węzeł `[664]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[665]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[666]`
Mówca: **Mikail Aven**
> ""But I agree that we need more economists to enter politics. Thankfully we have a president who seems to be as well-versed in economics as Alphonso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[667]`
**[WYBÓR GRACZA: "“I appreciate the advice but I don't like salmon.""]** — Mówca: **Player**
> "“I appreciate the advice but I don't like salmon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[668]`
Mówca: **Walter Tusk**
> "“Really? As a Lachavener, too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[669]`
Mówca: **Walter Tusk**
> "“I guess that's your loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[124]`

### Węzeł `[670]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[671]`
Mówca: **Walter Tusk**
> ""Ah, of course. Nobody can say no to a bottle of wine by Giralt of Ribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[672]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`
  - -> `[674]`

### Węzeł `[673]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[674]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[675]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_LeagueWomenStrike = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_LeagueWomenStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[676]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_LeagueWomenMarch = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_LeagueWomenMarch"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[677]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`
  - -> `[679]`

### Węzeł `[678]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[679]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[680]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Revolt = false;
BaseGame.Situation_Order_Nationwide_Quelled = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[681]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall = false; BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_BludBan = true; BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_Poisoned = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall"] = false;
Variable["BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_BludBan"] = true;
Variable["BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_Poisoned"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[682]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[683]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Anrica", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[684]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Laren", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[685]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Lenkurg", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Lenkurg","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[686]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[687]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Jen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[688]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Anrica", "City_Lockdown");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_Lockdown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[689]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`
  - -> `[691]`

### Węzeł `[690]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[691]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[692]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn03_Rumburg_Emergency_BannedRumburg = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn03_Rumburg_Emergency_BannedRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[693]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[694]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Fetih Ejall", "Inmate 64284");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Fetih Ejall","Inmate 64284");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`
