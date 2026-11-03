# Sordland/Turn06/InT_2ndCompanyChoice

- **ID konwersacji:** `85`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/085_InT_2ndCompanyChoice.md`
- **Liczba węzłów dialogowych:** 213
- **Liczba wyborów gracza:** 33

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
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Decision_Turn06_Megaproject_Benfi`
- `BaseGame.Decision_Turn06_Megaproject_Conriat`
- `BaseGame.Decision_Turn06_Megaproject_Morna`
- `BaseGame.Promise_Economy_FreeMarket`
- `BaseGame.Promise_Economy_Planned`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn06_InT_SordishState`
- `BaseGame.Turn06_InT_Underhall`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy_Consistent`
- `BaseGame.GovernmentBudget`
- `BaseGame.Turn06_InT_SordishState`
- `BaseGame.Turn06_InT_Taurus`
- `BaseGame.Turn06_InT_Underhall`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`
- `BaseGameSupport.Journal_Turn06_Company_SSC`
- `BaseGameSupport.Journal_Turn06_Company_Taurus`
- `BaseGameSupport.Journal_Turn06_Company_Underhall`
- `GameCondition.Turn06_InT_Investment2CompanyChoice`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 21

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Consistent`
- `BaseGame.GovernmentBudget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[15]` (Symon Holl): `Variable["BaseGame.Economy_Consistent"] = true;`
- Węzeł `[22]` (Symon Holl): `Variable["BaseGame.Economy_Consistent"] = true;`
- Węzeł `[23]` (Symon Holl): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- Węzeł `[28]` (Symon Holl): `Variable["BaseGame.Economy_Consistent"] = true;`
- Węzeł `[38]` (Symon Holl): `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- Węzeł `[58]` (Symon Holl): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- Węzeł `[79]` (Symon Holl): `Variable["GameCondition.Turn06_InT_Investment2CompanyChoice"] = true;`
- Węzeł `[114]` (Symon Holl): `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- *...oraz 13 innych węzłów ze skryptami.*

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
  - -> `[7]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Benfi International Airport was a massive investment, and many construction companies already wanted to take the contract for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "Look at the files."]** — Mówca: **Player_Italic**
> "I looked at the files. Three corporations were listed. The Sordish State Corporation, Underhall Construction and Taurus Holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[5]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[6]`
Mówca: **Symon Holl**
> "“Besides supporting our economic recovery and expanding our air network, this project will boost tourism in Benfi heavily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[7]`
Mówca: **Narrator**
> "We met with Symon and Gus to pick a company for our new government project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“That's great news.”"]** — Mówca: **Player**
> "“That is great news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Symon was ready to brief me about the top three contenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Underhall seems interesting but let's see the others.”"]** — Mówca: **Player**
> "“Underhall seems interesting but let's see the others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“They do have a wealth of knowledge in infrastructure.”"]** — Mówca: **Player**
> "“They do have a wealth of knowledge in infrastructure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[12]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[15]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“The experience they bring to the table is beneficial.”"]** — Mówca: **Player**
> "“The experience they bring to the table is beneficial.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“I have the overview of the companies here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Gus Manger**
> "“I reviewed the listed corporations. I also wrote down some notes and ideas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Symon handed the files over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[22]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[23]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[24]`
Mówca: **Symon Holl**
> "“Which corporation should we talk about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[28]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Consistent = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[30]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Railway Companies Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[41]`
  - -> `[48]`
  - -> `[59]`

### Węzeł `[31]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[33]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“The Sordish State Corporation.”"]** — Mówca: **Player**
> "“The Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[35]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[37]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Railway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“How was your experience with them?”"]** — Mówca: **Player**
> "“How was your experience with them?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[41]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Underhall Construction.”"]** — Mówca: **Player**
> "“Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[45]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[47]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“Picking this corporation would go against our planned economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“Taurus Holding.”"]** — Mówca: **Player**
> "“Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“Picking this corporation would fit our market economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[54]`
Mówca: **Symon Holl**
> "“The respected Sordish State Corporation also known as the SSC was founded in 1891.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“The real estate and construction giant was founded in 1925, they expanded during the economic boom of the 30's.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“The project manager from Taurus Holding mentioned that they would be able to finish the project with the allocated funding. They found the budget sufficient unlike Underhall, making them a cheaper alternative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“Taurus Holding was founded in 1946 and is owned by the entrepreneur Geralt Fais.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[58]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[59]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[61]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Symon Holl**
> "“Underhall has specifically mentioned their solid track record and highlighted that the costs of the project would be more than expected for a project of this scale, but finished on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[10]`
  - -> `[112]`

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“The SSC is the primary reason why our infrastructure is outdated as is. We need more adaptive construction companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[64]`
Mówca: **Symon Holl**
> "“According to the preliminary calculations of the SSC, they would need more resources to finish a project of this size.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`
  - -> `[105]`

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“I had the chance to work with Underhall Construction before in Holsord. They took several contracts for the central station renovation and excelled at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[40]`

### Węzeł `[66]`
Mówca: **Gus Manger**
> "“They are a very interesting corporation especially because of their innovative construction methods, but aren't suitable for large projects like these.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[100]`

### Węzeł `[67]`
Mówca: **Gus Manger**
> "“I wish the choice was different but at the end of the day the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[68]`
Mówca: **Gus Manger**
> "“Choosing this corporation is too risky for a project like this. If things were to go wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[75]`

### Węzeł `[69]`
Mówca: **Gus Manger**
> "“Look at the abysmal regional railway system!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[11]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Good luck to us.”"]** — Mówca: **Player**
> "“Good luck to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Symon Holl**
> "“They took a joint contract in Arcasia for restructuring the highway intersection of one of the major cities. It went well but it is their only large-scale success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[72]`
Mówca: **Symon Holl**
> "“My expectations for a grand opening ceremony are late next year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Gus Manger**
> "“I will be returning to my duties. See you soon, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I think we are off to a good start.”"]** — Mówca: **Player**
> "“I think we are off to a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"]** — Mówca: **Player**
> "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“We shouldn't put our first project at risk. There is too much at stake here.”"]** — Mówca: **Player**
> "“We shouldn't put our first project at risk. There is too much at stake here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“It seems like they lack the necessary experience.”"]** — Mówca: **Player**
> "“It seems like they lack the necessary experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“The innovative aspect is refreshing. Especially if they can deliver.”"]** — Mówca: **Player**
> "“The innovative aspect is refreshing. Especially if they can deliver.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[79]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_InT_Investment2CompanyChoice = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_InT_Investment2CompanyChoice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Thank you. This concludes the meeting.”"]** — Mówca: **Player**
> "“Thank you. This concludes the meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[81]`
Mówca: **Symon Holl**
> "“They have experience, knowledge and manpower for a project this size. I'm not so sure about their efficiency though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Gus Manger**
> "“The Sordish State Corporation lacks a modern way of thinking. They also under-perform with their slow construction methods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[83]`
Mówca: **Gus Manger**
> "“There is also the fact that construction times are long. Which are caused by outdated methods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[96]`

### Węzeł `[84]`
Mówca: **Symon Holl**
> "“I don't share a great admiration for the SSC but their track record clearly shows completed contracts with thousands of employees who have experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[85]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[87]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Gus Manger**
> "“The disadvantage would be going against your election promises of moving away from a state dominant economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[90]`
Mówca: **Gus Manger**
> "“I wish the outcome of the meeting was different but at the end of the day the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[91]`
Mówca: **Symon Holl**
> "“It would fulfil your initial election promise of using a state-dominant planned economy to improve the bleak recession situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“We need to be able to trust the corporation. This is a base requirement for the contract.”"]** — Mówca: **Player**
> "“We need to be able to trust the corporation. This is a base requirement for the contract.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“The regional railway system has no relation to this.”"]** — Mówca: **Player**
> "“The regional railway system has no relation to this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“I am on the fence about the SSC.”"]** — Mówca: **Player**
> "“I am on the fence about the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“I like the SSC, but want to hear about the others.”"]** — Mówca: **Player**
> "“I like the SSC, but want to hear about the others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“The lack of a dynamic attitude is disappointing.”"]** — Mówca: **Player**
> "“The lack of a dynamic attitude is disappointing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“I would like to hear your thoughts, Symon.”"]** — Mówca: **Player**
> "“I would like to hear your thoughts, Symon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Symon Holl**
> "“The company will be notified today and the construction work will begin immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[8]`
  - -> `[70]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Why shouldn't we go with, Taurus?”"]** — Mówca: **Player**
> "“Why shouldn't we go with, Taurus?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[101]`
Mówca: **Symon Holl**
> "“I think that they have been doing relatively well in the private sector, where they are dominating the construction industry with successful projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Symon Holl**
> "“Nonetheless, they treated their workers below our working standards during the Holsord Central Station contract. Which is troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[92]`

### Węzeł `[103]`
Mówca: **Gus Manger**
> "“Having worked on the renovation project, I can say that the working conditions were not bad. Extra effort was needed to finish it on time, which they did, that is all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[104]`
Mówca: **Gus Manger**
> "“Out of all three, this is the company I can trust. They work hard, long and fast to accomplish their contracts. They will get this done if we give it to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[106]`
Mówca: **Symon Holl**
> "“I am not so sure about trusting them with such a big contract. Especially after the workers issues but at least they have worked on several mega-projects and always delivered on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[92]`

### Węzeł `[107]`
Mówca: **Gus Manger**
> "“I think their capabilities are very suitable for a project like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Gus Manger**
> "“They worked on two infrastructure projects in Gelsland and one in Greater Holsord that were worth two billion Ren in total.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[109]`
Mówca: **Gus Manger**
> "Yes, but some of the workers were Agnolian and Wehzek thus not under Sordish Labour Laws but under the immigration act.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“I am not sure about Underhall Construction.”"]** — Mówca: **Player**
> "“I am not sure about Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I have settled on Underhall Construction. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[113]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Railway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[114]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[115]`
Mówca: **Symon Holl**
> "“It won several awards internationally for being one of the fastest growing and advanced companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[77]`

### Węzeł `[116]`
Mówca: **Gus Manger**
> "“Very glad that you have made this choice. I can tell from my experience that we will be very satisfied with this company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Why should we pick, Taurus?”"]** — Mówca: **Player**
> "“Why should we pick, Taurus?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Working conditions must be respected. This doesn't inspire confidence.”"]** — Mówca: **Player**
> "“Working conditions must be respected. This doesn't inspire confidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[120]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Gus Manger**
> "“To be frank, what was the largest mega-project they worked on? I don't even remember.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[124]`
Mówca: **Symon Holl**
> "“Taurus has completed fewer projects than the other companies. However, they are slightly faster and cheaper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[125]`
Mówca: **Symon Holl**
> "“It would fit our election promises of switching to a free-market economy. Awarding contracts to privately owned corporations would be a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[126]`
Mówca: **Symon Holl**
> "“It is a new holding company whose subsidiaries use cutting-edge technology from Arcasia to reduce construction costs and prices. They are known to provide for their workers who are part of the Labour Union of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Symon started searching the documents he was holding for a while. He spoke when he found the one he was looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Railway Companies Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[129]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“I don't feel confident about Taurus Holding.”"]** — Mówca: **Player**
> "“I don't feel confident about Taurus Holdings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Taurus is definitely worth considering.”"]** — Mówca: **Player**
> "“Taurus is definitely worth considering.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“I have settled on Taurus Holding.”"]** — Mówca: **Player**
> "“I have settled on Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[133]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[134]`
Mówca: **Gus Manger**
> "“Exactly. And why take such a risk now when we need to play it safer with companies like Underhall? They always delivered for the government on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Gus stopped and laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[136]`
Mówca: **Symon Holl**
> "“If we are going to try a different company this is the most unique.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[137]`
Mówca: **Symon Holl**
> "“The CEO of Underhall is Kris Schar, the mayor of Conriat. He sold half of his shares a few years ago but seemed very eager on our megaproject.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[138]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_Underhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_InT_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[139]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_InT_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Gus shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[141]`
Mówca: **Symon Holl**
> "“It is the main state corporation tasked with running the day to day construction services of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[142]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this, but the contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[143]`
Mówca: **Narrator**
> "It was time to make a decision about which company to award the contract to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[112]`
  - -> `[195]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[146]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Benfi == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[149]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Conriat == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Morna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Morna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Morna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Conriat Industrial Zone was a massive investment, and many construction companies already wanted to take the contract for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Port of Morna was a massive investment, and many construction companies already wanted to take the contract for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Sarna Agricultural Zone was a massive investment, and many construction companies already wanted to take the contract for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Symon was ready to brief me about the top three contenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Narrator**
> "Symon was ready to brief me about the top three contenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Symon was ready to brief me about the top three contenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure. Especially with the new L-1 line, Conriat and Greater Holsord will benefit enormously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[160]`
Mówca: **Symon Holl**
> "“Besides supporting our economic recovery and providing new jobs, this project will boost our industrial output in Conriat heavily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
Mówca: **Symon Holl**
> "“Besides supporting our economic recovery and expanding our sea network, this project will boost our trade heavily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[162]`
Mówca: **Symon Holl**
> "“Besides supporting our economic recovery and providing new jobs, this project will boost our agricultural input heavily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[165]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[167]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[170]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[172]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[173]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure. Especially with our massive investments in Lorren, the whole region will benefit a lot from this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[175]`
Mówca: **Gus Manger**
> ""This port can have the potential to be the next Lachaven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[176]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure. Especially with our massive investments in Bergia, the whole region will benefit a lot from this. Sarna may become the next big city in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure. The farmers in Sarna needed our help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Gus Manger**
> "“This was a good choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[179]`
Mówca: **Gus Manger**
> "“This was a good choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[180]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[182]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[183]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[186]`
Mówca: **Symon Holl**
> "“But, the project manager from Taurus Holding mentioned that they would need more funding for the project. They found the budget insufficient for such a massive construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[130]`
  - -> `[131]`

### Węzeł `[187]`
Mówca: **Symon Holl**
> "“According to the preliminary calculations of the SSC, they reported that they would be able to finish the project on time with the allocated funding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[94]`
  - -> `[95]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“I have settled on the SSC.”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_SordishState = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_InT_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[190]`
**[WYBÓR GRACZA: "“I have settled on Taurus Holding. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[192]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[194]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[195]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[197]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[198]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_InT_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_InT_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Company_Underhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Company_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[202]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_InT_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_InT_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Company_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Company_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[206]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Company_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Company_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[207]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Benfi", "Progress_InternationalAirport");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Benfi","Progress_InternationalAirport");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[208]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Conriat", "Progress_IndustrialZone");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Conriat","Progress_IndustrialZone");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[209]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Morna", "Progress_SeaPort");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Morna","Progress_SeaPort");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[210]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Sarna", "Progress_AgriculturalZone");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","Progress_AgriculturalZone");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[211]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[212]`
Mówca: **Gus Manger**
> "“But why take such a risk now? Especially when we know that Underhall has always delivered for the government on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
