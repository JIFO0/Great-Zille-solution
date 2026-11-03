# Sordland/Turn02/InT_HighwayContract

- **ID konwersacji:** `24`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/024_InT_HighwayContract.md`
- **Liczba węzłów dialogowych:** 215
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
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
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`
- `BaseGameSupport.Journal_Turn02_ConstructionSSC`
- `BaseGameSupport.Journal_Turn02_ConstructionTaurus`
- `BaseGameSupport.Journal_Turn02_ConstructionUnderhall`
- `BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand`
- `BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand`
- `BaseGameSupport.News_Turn02_HP_H3_SSC`
- `BaseGameSupport.News_Turn02_HP_H3_Taurus`
- `BaseGameSupport.News_Turn02_HP_H3_Underhall`
- `BaseGameSupport.News_Turn02_ST_H3_SSC`
- `BaseGameSupport.News_Turn02_ST_H3_Taurus`
- `GameCondition.Turn02_InT_Contract`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 31

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Consistent`
- `BaseGame.GovernmentBudget`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Symon Holl): `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] = true; Variable["BaseGame.Turn...`
- Węzeł `[20]` (Symon Holl): `Variable["GameCondition.Turn02_InT_Contract"] = true;`
- Węzeł `[75]` (Symon Holl): `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] = true;`
- Węzeł `[83]` (Symon Holl): `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] = true;`
- Węzeł `[85]` (Symon Holl): `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- Węzeł `[107]` (Symon Holl): `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- Węzeł `[108]` (Symon Holl): `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- Węzeł `[142]` (Symon Holl): `Variable["BaseGame.Economy_Consistent"] = true;`
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
  - -> `[6]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction = true; BaseGame.Turn04_InT_HighwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] = true;
Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“The company will be notified today and construction work will begin immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[5]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group will be pleased. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[6]`
Mówca: **Narrator**
> "After a lengthy drive on cliffside roads, we arrived in Lenkurg. There, crowds of cheering citizens greeted us and the local government officials escorted us to the city hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "We were here for a significant meeting about the H-3 project. Several construction companies sent their representatives to the city hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Lileas Graf**
> "“We'll not let the people or ourselves down. I won't let that happen to any of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Gus Manger couldn't make the meeting due to his visit to Rizia, but I had Symon Holl and Lileas Graf by my side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Symon Holl**
> "“Besides starting our economic recovery, this project will cut the time it takes to get here by road in half, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Lileas Graf**
> "“More importantly, it will lead to improvement in Agnland. I have lived with these people and seen them suffer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Lileas Graf**
> "“I had to work with Underhall Construction before in Holsord. They accepted several contracts for the renovation of our central station and left much to be desired. The H-3 project shouldn't be left to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[17]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I would like to hear your thoughts, Symon.”"]** — Mówca: **Player**
> "“I would like to hear your thoughts, Symon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“I trust your plan, Symon.”"]** — Mówca: **Player**
> "“I trust your plan, Symon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I hope so, Lileas.”"]** — Mówca: **Player**
> "“I hope so, Lileas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
Mówca: **Lileas Graf**
> "“Well, one of our promises would be respected. We promised to focus on the planned economy to create jobs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“How was your experience with them?”"]** — Mówca: **Player**
> "“How was your experience with them?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Thank you. This concludes the meeting.”"]** — Mówca: **Player**
> "“Thank you. This concludes the meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[19]`
Mówca: **Lileas Graf**
> "“With the highway, we will be well on our way to economically strengthening this weak region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_InT_Contract = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_InT_Contract"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“I am glad to hear that. We should be able to slow down the recession if we finish this project successfully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Symon Holl**
> "“According to my estimations this project will give about 50.000 citizens from Agnland employment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[38]`
  - -> `[37]`
  - -> `[36]`

### Węzeł `[23]`
Mówca: **Lileas Graf**
> "“I look forward to a positive financial outcome. According to my sources, we'll lift many people in these areas out of poverty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[38]`
  - -> `[37]`
  - -> `[36]`

### Węzeł `[24]`
Mówca: **Narrator**
> "The meeting ended and we spent the remainder of the day attending events in Lenkurg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“If we are going to try a different company, this is the most unique.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[26]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[28]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“It would fit our election promises of switching to a free-market economy. Awarding contracts to privately owned corporations would be a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Symon Holl**
> "“Taurus has completed fewer projects than the other companies. However, they are slightly faster and cheaper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[31]`
Mówca: **Lileas Graf**
> "“This company is completely private and directed by a non-government board. Do we even remember if they worked on a mega-project at all?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[32]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[34]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Why should we pick Taurus?”"]** — Mówca: **Player**
> "“Why should we pick Taurus?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Do you need additional support?”"]** — Mówca: **Player**
> "“Do you need additional support?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Failure during this project is not an option.”"]** — Mówca: **Player**
> "“Failure during this project is not an option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“What kind of end results do we expect?”"]** — Mówca: **Player**
> "“What kind of end results do we expect?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“What will it take to stop the recession?”"]** — Mówca: **Player**
> "“What will it take to stop the recession?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Why shouldn't we go with Taurus?”"]** — Mówca: **Player**
> "“Why shouldn't we go with Taurus?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[41]`
Mówca: **Lileas Graf**
> "“Thank you for the offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“I am not too sure about trusting them with the contract but at least they have worked on several mega-projects and always delivered on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[43]`
Mówca: **Symon Holl**
> "“Our economic revitalization plan is set to be a success. Failure is indeed not an option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“Out of all three, this is the company I trust the least. They seem to fail at respecting the contract terms of their workers. They're likely to cause trouble.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
Mówca: **Lileas Graf**
> "“The underdeveloped cities of Lenkurg and Arvory will receive a lot more investment after this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“The SSC is one of our most trusted and honorable companies. They have served us a long time. I have worked with them on several occasions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“That depends on the government budget. We need to make sure we have enough money to fund critical ministries but still have enough left to invest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[48]`
Mówca: **Narrator**
> "It was time to decide which company would be awarded the H-3 Highway contract."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[106]`
  - -> `[67]`

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“Short-term employment and long-term economic development in the Nargis and Agnland regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“They were only involved in smaller-scale regional projects. This doesn't prove their capabilities for larger undertakings that are more complex.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“Nonetheless, they subjected their workers to conditions beneath our standards during the Holsord Central Station contract. Which is troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“I think that they have been doing relatively well in the private sector, where they are dominating the construction industry with successful projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[53]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[55]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“There are other things Taurus does very well, like providing consultants for state corporations. But I can't vouch for their infrastructure construction at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[40]`

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“Not as of right now. However, things might come up if the project doesn't go according to plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[58]`
Mówca: **Symon Holl**
> "“This is just the beginning. We will need to follow this project up with several other economic investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Underhall Construction.”"]** — Mówca: **Player**
> "“Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“Taurus Holding was founded in 1946 and is owned by the entrepreneur Geralt Fais.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[61]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[63]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Highway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“It would fulfill your initial election promise of using a state-dominant planned economy to improve Sordland's bleak economic prospects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[66]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Highway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I have settled on Taurus Holding.”"]** — Mówca: **Player**
> "“I have settled on Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[68]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Highway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Taurus is definitely worth considering.”"]** — Mówca: **Player**
> "“Taurus is definitely worth considering.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“I don't feel confident about Taurus Holding.”"]** — Mówca: **Player**
> "“I don't feel confident about Taurus Holdings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Symon Holl**
> "“It goes against your election promises of moving away from a state-planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[72]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[74]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[75]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[76]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this. But the contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“The Sordish State Corporation.”"]** — Mówca: **Player**
> "“The Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[78]`
Mówca: **Lileas Graf**
> "“I wish the outcome of this meeting was different. But at the end of the day, the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[79]`
Mówca: **Symon Holl**
> "“Most importantly the Sordish State Corporation uses outdated methods, resulting in slower construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[80]`
Mówca: **Lileas Graf**
> "“I wish you had chosen differently. But at the end of the day, the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[81]`
Mówca: **Symon Holl**
> "“Yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[82]`
Mówca: **Lileas Graf**
> "“I'm so glad that you have made this choice. I can tell from my experience that we will be very satisfied with this corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[83]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[84]`
Mówca: **Lileas Graf**
> "“They have the experience and the manpower to pull off a project like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[85]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[86]`
Mówca: **Symon Holl**
> "“The outdated construction methods that they use concern me. They are several decades behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“I don't agree with your negative statements, Symon. The SSC's record clearly shows completed contracts with thousands of employees who have more than 20 years of experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“I am on the fence about the SSC.”"]** — Mówca: **Player**
> "“I am on the fence about the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“I like the SSC, but want to hear about the others.”"]** — Mówca: **Player**
> "“I like the SSC, but want to hear about the others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Taurus Holding.”"]** — Mówca: **Player**
> "“Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[91]`
Mówca: **Symon Holl**
> "“I have the overview of the companies here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Symon handed the files over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Symon Holl**
> "“The respected Sordish State Corporation, also known as the SSC was founded in 1891.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "Look at the files."]** — Mówca: **Player_Italic**
> "I looked at the files. Three corporations were listed. The Sordish State Corporation, Underhall Construction and Taurus Holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[95]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[97]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
Mówca: **Symon Holl**
> "“The real estate and construction giant was founded in 1925 and expanded during the economic boom of the '30s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[99]`
Mówca: **Lileas Graf**
> "“According to them, the tight completion schedule necessitated such bad labor conditions. Which still doesn't justify the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-2 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[101]`
Mówca: **Lileas Graf**
> "“I reviewed them. I also took the liberty of asking the mayor of Arvory to give his opinion on the matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Symon Holl**
> "“Which corporation should we talk about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[103]`
Mówca: **Lileas Graf**
> "“But during the station project, we had to extensively negotiate with the union so as to not lose a serious labor law violation case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I am not sure about Underhall Construction.”"]** — Mówca: **Player**
> "“I am not sure about Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Underhall seems interesting, but let's hear about the others.”"]** — Mówca: **Player**
> "“Underhall seems interesting, but let's hear about the others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“I have settled on Underhall Construction. [-2 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[107]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[108]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[109]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Highway Companies Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[95]`
  - -> `[53]`
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[112]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WYBÓR GRACZA: "“That's great news.”"]** — Mówca: **Player**
> "“That is great news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Symon Holl**
> "“My expectations are that the grand opening ceremony will happen late next year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Lileas Graf**
> "“I'd better get back to work, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“I think we are off to a good start.”"]** — Mówca: **Player**
> "“I think we are off to a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Good luck to us.”"]** — Mówca: **Player**
> "“Good luck to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[118]`
Mówca: **Symon Holl**
> "“It is the main state corporation tasked with running the day-to-day construction services of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[119]`
Mówca: **Symon Holl**
> "“The CEO of Underhall is Kris Schar, the mayor of Conriat. He sold half of his shares a few years ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[120]`
Mówca: **Symon Holl**
> "“It is a new holding company whose subsidiaries use cutting-edge technology from Arcasia to reduce construction costs and prices. They are known to provide for their workers, who are part of the Labour Union of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Working conditions must be respected. This doesn't inspire confidence.”"]** — Mówca: **Player**
> "“Working conditions must be respected. This doesn't inspire confidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“We need to be able to trust the corporation. This is a base requirement for the contract.”"]** — Mówca: **Player**
> "“We need to be able to trust the corporation. This is a base requirement for the contract.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Lileas Graf**
> "“I agree. The workers were undocumented Agnolian and Wehzek immigrants with no papers. A clear violation of our laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[124]`
Mówca: **Lileas Graf**
> "“They indeed did work on three significant infrastructure projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“The experience they bring to the table is beneficial.”"]** — Mówca: **Player**
> "“The experience they bring to the table is beneficial.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“The lack of a modern attitude is disappointing.”"]** — Mówca: **Player**
> "“The lack of a modern attitude is disappointing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "“The regional highway system has no relation to this.”"]** — Mówca: **Player**
> "“The regional highway system has no relation to this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "“They do have a wealth of knowledge in infrastructure.”"]** — Mówca: **Player**
> "“They do have a wealth of knowledge in infrastructure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "“The innovative aspect is refreshing. Especially if they can deliver.”"]** — Mówca: **Player**
> "“The innovative aspect is refreshing. Especially if they can deliver.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“It seems like they lack the necessary experience.”"]** — Mówca: **Player**
> "“It seems like they lack the necessary experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“We shouldn't risk our first project. There is too much at stake here.”"]** — Mówca: **Player**
> "“We shouldn't risk our first project. There is too much at stake here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"]** — Mówca: **Player**
> "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[133]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Symon Holl**
> "“Picking this corporation would go against our planned economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[137]`
Mówca: **Symon Holl**
> "“Picking this corporation would fit our market economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[138]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[139]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[141]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[146]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[148]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[150]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[152]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[153]`
Mówca: **Narrator**
> "It was nice to enjoy the natural beauty of Agnland and to eat some good fish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[154]`
Mówca: **Lileas Graf**
> "“Secondly, they are the only company to have worked in the Agnland region out of all three corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[155]`
Mówca: **Symon Holl**
> "“A simple look at the regional highways shows us the problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[156]`
Mówca: **Symon Holl**
> "“It won several awards internationally for being one of the fastest growing and advanced companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[157]`
Mówca: **Lileas Graf**
> "“Choosing this company is too much of a risk for such an important project, especially when a proven candidate like the SSC exists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[158]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[161]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[162]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[165]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[166]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[168]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[170]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[171]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[172]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this, but the contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[174]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[176]`
Mówca: **Narrator**
> "Lileas sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[177]`
Mówca: **Symon Holl**
> "“They took a joint contract in Arcasia for restructuring the highway intersection of one of the major cities. It went well but it is their only large-scale success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Lileas paused for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[179]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Symon searched through the documents he was holding and found the one he was looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[181]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_H3_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_H3_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

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
  - -> `[188]`

### Węzeł `[184]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[185]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[187]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[188]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_H3_Underhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_H3_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[189]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_H3_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_H3_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_H3_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_H3_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[191]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_H3_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_H3_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[192]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_ConstructionSSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[193]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_ConstructionUnderhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionUnderhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[194]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_ConstructionTaurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionTaurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[195]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[196]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[197]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[198]`
Mówca: **Symon Holl**
> "“According to the preliminary calculations of the SSC, they would need more resources to finish a project of this size.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`
  - -> `[203]`

### Węzeł `[199]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[200]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[201]`
Mówca: **Symon Holl**
> "“Underhall has specifically mentioned their solid track record and highlighted that they do anticipate to go over budget, but that the project will be finished on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[106]`

### Węzeł `[202]`
Mówca: **Symon Holl**
> "“The project manager from Taurus Holding mentioned that they would be able to finish the project with the allocated funding. They are the only company who found the budget sufficient, making them a cheaper alternative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[69]`
  - -> `[67]`

### Węzeł `[203]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_ConstructionSSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[208]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[209]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`
  - -> `[203]`

### Węzeł `[211]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[212]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Highway", 25);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Highway", 25);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[113]`
  - -> `[117]`

### Węzeł `[213]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[214]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
