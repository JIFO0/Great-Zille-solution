# Sordland/Turn02/InT_RailwayContract

- **ID konwersacji:** `25`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/025_InT_RailwayContract.md`
- **Liczba węzłów dialogowych:** 221
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Promise_Economy_FreeMarket`
- `BaseGame.Promise_Economy_Planned`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy_Consistent`
- `BaseGame.GovernmentBudget`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`
- `BaseGameSupport.Journal_Turn02_ConstructionSSC`
- `BaseGameSupport.Journal_Turn02_ConstructionTaurus`
- `BaseGameSupport.Journal_Turn02_ConstructionUnderhall`
- `BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand`
- `BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand`
- `BaseGameSupport.News_Turn02_HP_L1_SSC`
- `BaseGameSupport.News_Turn02_HP_L1_Taurus`
- `BaseGameSupport.News_Turn02_HP_L1_Underhall`
- `BaseGameSupport.News_Turn02_ST_L1_SSC`
- `BaseGameSupport.News_Turn02_ST_L1_Taurus`
- `GameCondition.Turn02_InT_Contract`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 31

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Consistent`
- `BaseGame.GovernmentBudget`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[22]` (Symon Holl): `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- Węzeł `[80]` (Symon Holl): `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- Węzeł `[90]` (Symon Holl): `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] = true;`
- Węzeł `[96]` (Symon Holl): `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] = true; Variable["BaseGame.Turn...`
- Węzeł `[97]` (Symon Holl): `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] = true;`
- Węzeł `[98]` (Symon Holl): `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- Węzeł `[109]` (Symon Holl): `Variable["GameCondition.Turn02_InT_Contract"] = true;`
- Węzeł `[136]` (Symon Holl): `Variable["BaseGame.Economy_Consistent"] = true;`
- *...oraz 23 innych węzłów ze skryptami.*

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
  - -> `[8]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We were here for a significant meeting about the L-1 project. Several construction companies sent their representatives to the city hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "“I hope so, Gus.”"]** — Mówca: **Player**
> "“I hope so, Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "Look at the files."]** — Mówca: **Player_Italic**
> "I looked at the files. Three corporations were listed. The Sordish State Corporation, Underhall Construction and Taurus Holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[6]`
Mówca: **Gus Manger**
> "“That is a given. But we'll also see improvements in everything from logistics to growth. You made the right choice for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Symon Holl**
> "“I came by train yesterday and it was a little uncomfortable. Besides starting our economic recovery, this project will make the journey here much more pleasant, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[8]`
Mówca: **Narrator**
> "We arrived in Anrica by train. After being greeted by crowds of cheering citizens and the local government officials, we headed to the city hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Even though Lileas Graf couldn't make the meeting, I had Symon Holl and Gus Manger by my side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I trust your economic plans, Symon.”"]** — Mówca: **Player**
> "“I trust your economic plans, Symon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“I am glad to hear that. We should be able to slow down the recession if we finish this project successfully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[12]`
Mówca: **Gus Manger**
> "“This project will help along my rural development plans by attracting new businesses to the area. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“I have the overview of the companies here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Gus Manger**
> "“I reviewed the listed corporations. I also wrote down some notes and ideas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Symon handed the files over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“Which corporation should we talk about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Railway Companies Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[24]`
  - -> `[28]`
  - -> `[35]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“The Sordish State Corporation.”"]** — Mówca: **Player**
> "“The Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[19]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[21]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Railway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[24]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Underhall Construction.”"]** — Mówca: **Player**
> "“Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[28]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Taurus Holding.”"]** — Mówca: **Player**
> "“Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
Mówca: **Symon Holl**
> "“The respected Sordish State Corporation, also known as the SSC, was founded in 1891.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“The real estate and construction giant was founded in 1925 and expanded during the economic boom of the '30s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[34]`
Mówca: **Symon Holl**
> "“Taurus Holding was founded in 1946 and is owned by the entrepreneur Geralt Fais.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[35]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[37]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Gus Manger**
> "“The SSC is the primary reason why our current infrastructure is outdated. We need more adaptive construction companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“I had the chance to work with Underhall Construction in Holsord. They took several contracts for the central station renovation and excelled at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[40]`
Mówca: **Gus Manger**
> "“They are a very interesting corporation, especially because of their innovative construction methods. But I don't think they're suitable for large projects like these.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[41]`
Mówca: **Gus Manger**
> "“I am sure we will. According to your document many citizens will be employed because of business expansions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“According to my estimations, the new railway will give about 50.000 citizens from the Greater Holsord and Gelsland areas employment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“What will it take to stop the recession?”"]** — Mówca: **Player**
> "“What will it take to stop the recession?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“What kind of end results do we expect?”"]** — Mówca: **Player**
> "“What kind of end results do we expect?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Failure during this project is not an option.”"]** — Mówca: **Player**
> "“Failure during this project is not an option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Do you need additional support?”"]** — Mówca: **Player**
> "“Do you need additional support?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Symon Holl**
> "“This is just the beginning. We will need to follow this project up with several other economic investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
Mówca: **Symon Holl**
> "“Not as of right now. However, things might come up if the project doesn't go according to plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“You are right. We need to work together and think things through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“Short-term employment and long-term economic development in the Gelsland and Greater Holsord regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Gus Manger**
> "“Which is dependent on our government budget, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[52]`
Mówca: **Gus Manger**
> "“There are so many forgotten people living in the less developed areas between Lachaven and Holsord. They will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“Our economic revitalization plan is set to be a success. Failure is indeed not an option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[54]`
Mówca: **Gus Manger**
> "“I agree with Symon. Additional financial or political support might be necessary if certain parties or issues block us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“Yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“They have experience, knowledge and manpower for a project this size. I'm not so sure about their efficiency, though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Gus Manger**
> "“The Sordish State Corporation lacks a modern way of thinking. They also under-perform with their slow construction methods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[58]`
Mówca: **Gus Manger**
> "“There is also the fact that construction times are long. Which is mostly due to their outdated methods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[122]`

### Węzeł `[59]`
Mówca: **Symon Holl**
> "“I have no great admiration for the SSC, but their track record clearly shows completed contracts with thousands of employees who have experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[60]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“The disadvantage would be going against your election promises of moving away from a state-dominant economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[64]`
Mówca: **Symon Holl**
> "“However, this would fulfil your initial election promise of using a state-dominant planned economy to improve the bleak recession situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I am on the fence about the SSC.”"]** — Mówca: **Player**
> "“I am on the fence about the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“I like the SSC, but want to hear about the others.”"]** — Mówca: **Player**
> "“I like the SSC, but want to hear about the others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I would like to hear your thoughts, Symon.”"]** — Mówca: **Player**
> "“I would like to hear your thoughts, Symon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“How was your experience with them?”"]** — Mówca: **Player**
> "“How was your experience with them?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
Mówca: **Symon Holl**
> "“I think that they have been doing relatively well in the private sector, where they are dominating the construction industry with successful projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Symon Holl**
> "“Nonetheless, they subjected their workers to conditions below our working standards during the Holsord Central Station contract. Which is troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[118]`

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“Having worked on the renovation project, I can say that the conditions were not bad. Extra effort was needed to finish it on time, which they did. That is all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“Out of all three, this is the company I can trust. They work hard, long and fast to accomplish their contracts. They will get this done if we give it to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-2 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[74]`
Mówca: **Symon Holl**
> "“I am not so sure about trusting them with such a big contract. Especially after certain issues surrounding the treatment of their workers. But at least they have worked on several mega-projects and always delivered on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[118]`

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“They worked on two infrastructure projects in Gelsland and one in Greater Holsord that were worth two billion Ren in total.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I am not sure about Underhall Construction.”"]** — Mówca: **Player**
> "“I am not sure about Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Underhall seems interesting, but let's see the others.”"]** — Mówca: **Player**
> "“Underhall seems interesting, but let's see the others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I have settled on Underhall Construction. [-2 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[79]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Railway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[80]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Why should we pick Taurus?”"]** — Mówca: **Player**
> "“Why should we pick Taurus?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Why shouldn't we go with Taurus?”"]** — Mówca: **Player**
> "“Why shouldn't we go with Taurus?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Gus Manger**
> "“To be frank, what was the largest mega-project they worked on? I don't even remember.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[87]`
Mówca: **Symon Holl**
> "“Taurus has completed fewer projects than the other companies. However, they are slightly faster and cheaper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[88]`
Mówca: **Symon Holl**
> "“It would fit our election promises of switching to a free-market economy. Awarding contracts to privately owned corporations would be a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[89]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Railway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[90]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“I don't feel confident about Taurus Holding.”"]** — Mówca: **Player**
> "“I don't feel confident about Taurus Holdings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Taurus is definitely worth considering.”"]** — Mówca: **Player**
> "“Taurus is definitely worth considering.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“I have settled on Taurus Holding.”"]** — Mówca: **Player**
> "“I have settled on Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
Mówca: **Gus Manger**
> "“Exactly. And why take such a risk now? We need to play it safer with companies like Underhall. They've always delivered for the government on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[95]`
Mówca: **Symon Holl**
> "“If we are going to try a different company, this one is the most unique.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[96]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction = true; BaseGame.Turn04_InT_RailwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] = true;
Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[97]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[98]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[99]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this, but the contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[100]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group will be pleased. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[101]`
Mówca: **Narrator**
> "It was time to make a decision about which company to award the L-1 High-Speed Railway contract to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[78]`
  - -> `[93]`

### Węzeł `[102]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Gus Manger**
> "“No hard feelings, Mr. President. At the end of the day, the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Gus Manger**
> "“You made the right choice. I can tell from my experience that we will be very satisfied with this company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Gus Manger**
> "“No hard feelings, Mr. President. At the end of the day the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Symon Holl**
> "“The company will be notified today, and construction work will begin immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[107]`
Mówca: **Narrator**
> "The meeting ended and we spent the remainder of the day attending events in Anrica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Thank you. This concludes the meeting.”"]** — Mówca: **Player**
> "“Thank you. This concludes the meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_InT_Contract = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_InT_Contract"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“I think we are off to a good start.”"]** — Mówca: **Player**
> "“I think we are off to a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Gus Manger**
> "“It will be a pleasure to celebrate together. For now, I'll return to my duties and visit some foreign partners in Rizia. See you soon, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[112]`
Mówca: **Symon Holl**
> "“My expectations are that the grand opening ceremony will be late next year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“That's great news.”"]** — Mówca: **Player**
> "“That is great news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Good luck to us.”"]** — Mówca: **Player**
> "“Good luck to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[115]`
Mówca: **Symon Holl**
> "“It is the main state corporation tasked with running the day-to-day construction services of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[116]`
Mówca: **Symon Holl**
> "“The CEO of Underhall is Kris Schar, the mayor of Conriat. He sold half of his shares a few years ago but seemed very eager about the L-1 bid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[117]`
Mówca: **Symon Holl**
> "“It is a new holding company whose subsidiaries use cutting-edge technology from Arcasia to reduce construction costs and prices. They are known to provide for their workers, who are part of the Labour Union of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“We need to be able to trust the corporation. This is a base requirement for the contract.”"]** — Mówca: **Player**
> "“We need to be able to trust the corporation. This is a base requirement for the contract.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Working conditions must be respected. This doesn't inspire confidence.”"]** — Mówca: **Player**
> "“Working conditions must be respected. This doesn't inspire confidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Gus Manger**
> ""Let me just point out that some of the workers were Agnolian and Wehzek. Technically, Sordish labor laws didn't apply to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[121]`
Mówca: **Gus Manger**
> "“I think their capabilities are very suitable for the L-1 Railway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“The lack of a dynamic attitude is disappointing.”"]** — Mówca: **Player**
> "“The lack of a dynamic attitude is disappointing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“The regional railway system has no relation to this.”"]** — Mówca: **Player**
> "“The regional railway system has no relation to this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“The experience they bring to the table is beneficial.”"]** — Mówca: **Player**
> "“The experience they bring to the table is beneficial.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“They do have a wealth of knowledge in infrastructure.”"]** — Mówca: **Player**
> "“They do have a wealth of knowledge in infrastructure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“The innovative aspect is refreshing. Especially if they can deliver.”"]** — Mówca: **Player**
> "“The innovative aspect is refreshing. Especially if they can deliver.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "“It seems like they lack the necessary experience.”"]** — Mówca: **Player**
> "“It seems like they lack the necessary experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "“We shouldn't put our first project at risk. There is too much at stake here.”"]** — Mówca: **Player**
> "“We shouldn't put our first project at risk. There is too much at stake here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"]** — Mówca: **Player**
> "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[130]`
Mówca: **Symon Holl**
> "“Picking this corporation would fit our market economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[131]`
Mówca: **Symon Holl**
> "“Picking this corporation would go against our planned economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[132]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[134]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[135]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[137]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[139]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[140]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[145]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[147]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[149]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[150]`
Mówca: **Narrator**
> "It was very refreshing to attend cultural dance events and hear the traditional Sordish music of the region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[151]`
Mówca: **Gus Manger**
> "“Choosing this corporation is too risky for a project like this. What if things were to go wrong?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[152]`
Mówca: **Gus Manger**
> "“Look at the abysmal regional railway system!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[125]`

### Węzeł `[153]`
Mówca: **Symon Holl**
> "“They took a joint contract in Arcasia for restructuring the highway intersection of one of the major cities. It went well, but it is their only large-scale success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[154]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[156]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[157]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[160]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[161]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[162]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[165]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[166]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this, but the contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[167]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[168]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[169]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[170]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Gus shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Gus stopped and laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[173]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[174]`
Mówca: **Narrator**
> "Symon searched through the documents he was holding and found the one he was looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[175]`
Mówca: **Symon Holl**
> "“It won several awards internationally for being one of the fastest growing and advanced companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[176]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_L1_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_L1_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[177]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[180]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_L1_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_L1_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[181]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_L1_Underhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_L1_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[182]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[184]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[185]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_L1_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_L1_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[186]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_L1_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_L1_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[187]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_ConstructionUnderhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionUnderhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[188]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_ConstructionTaurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionTaurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[189]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_ConstructionSSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[190]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[191]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[192]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[193]`
Mówca: **Symon Holl**
> "“According to the preliminary calculations of the SSC, they would need more resources to finish a project of this size.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`
  - -> `[199]`

### Węzeł `[194]`
Mówca: **Symon Holl**
> "“Underhall has specifically mentioned their solid track record and highlighted that they do anticipate to go over budget, but that they will finish on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[195]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[196]`
Mówca: **Symon Holl**
> "“The project manager from Taurus Holding mentioned that they would be able to finish the project with the allocated funding. They are the only company who found the budget sufficient, making them a cheaper alternative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[197]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[199]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[201]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[202]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_ConstructionSSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[203]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[204]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[206]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Narrator**
> "Gus was first to arrive. He greeted me with a heartwarming smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Gus Manger**
> "“Hello Mr President. Good to see you again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Gus Manger**
> "“Appreciate you taking up my offer on the stock investment. Armadine is a very promising corporation, and if everything goes well you will make solid returns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[215]`
  - -> `[210]`

### Węzeł `[210]`
**[WYBÓR GRACZA: "“Just wanted to try my chances.""]** — Mówca: **Player**
> "“Just wanted to try my chances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "“Thanks for arranging the opportunity. I'll treat you to a 30-year-old Erlory Maroon if they make solid profits.”"]** — Mówca: **Player**
> "“Thanks for arranging the opportunity. I'll treat you to a 30-year-old Erlory Maroon if they make solid profits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Gus Manger**
> "“My pleasure, Mr. President. I'm looking forward to that Erlory Maroon already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Gus Manger**
> "“One has to play the game to be able to win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Symon Holl joined us. After settling down, we moved on to discuss the details of the L-1 Railway project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "“*If* being the key word. I might lose all the money I put in.”"]** — Mówca: **Player**
> "“*If* being the key word. I might lose all the money I put in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Gus Manger**
> "“The least likely scenario. You can trust me on these subjects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[217]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Railway", 25);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Railway", 25);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[113]`
  - -> `[114]`

### Węzeł `[218]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[219]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[220]`
Mówca: **Gus Manger**
> "“That's a big 'if', Mr. President. We need to play it safer with companies like Underhall. They've always delivered for the government on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
