# Sordland/Turn10/Grander Plans

- **ID konwersacji:** `232`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/232_Grander_Plans.md`
- **Liczba węzłów dialogowych:** 132
- **Liczba wyborów gracza:** 23

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[12]** Moderator
- **[15]** Mansoun Leke
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Enable_LateOpenHighway`
- `BaseGame.Enable_LateOpenRailway`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Situation_Welfare_HousingAssistance`
- `BaseGame.Situation_Welfare_UnemploymentWage`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Debate_BasicIncomePromise`
- `BaseGameIsolated.Debate_NuclearPromise`
- `BaseGameIsolated.Debate_SpacePromise`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[233] Sordland/Turn10/Economy** (../Turn_10/233_Economy.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[109]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_SpacePromise"] = true;`
- Węzeł `[110]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_NuclearPromise"] = true;`
- Węzeł `[111]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] = true;`

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
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `233` (*Sordland/Turn10/Economy*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[6]`
Mówca: **Moderator**
> ""Very interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[7]`
Mówca: **Kesaro Kibener**
> ""Each Sordish citizen wants to contribute and work for their country. There is no need for such programs, the only necessity is opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[107]`
  - -> `[108]`
  - -> `[122]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Just kidding. We have too many problems to solve here at home before we can think of entering the space race.""]** — Mówca: **Player**
> ""Just kidding. We have too many problems to solve here at home before we can think of entering the space race.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[9]`
Mówca: **Moderator**
> ""Mr. President, just prior to tonight's debate your press office signaled there could be grander plans in store for your second term. Is that correct?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[18]`
  - -> `[87]`

### Węzeł `[10]`
Mówca: **Mansoun Leke**
> ""I'm happy some of our parties' so-called radical ideas are beginning to filter into the political mainstream.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true) || BaseGame.Enable_LateOpenRailway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true) || BaseGame.Enable_LateOpenRailway == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true)  or  Variable["BaseGame.Enable_LateOpenRailway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true) || BaseGame.Enable_LateOpenRailway == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true)  or  Variable["BaseGame.Enable_LateOpenRailway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Moderator**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Absolutely.""]** — Mówca: **Player**
> ""Absolutely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true) || BaseGame.Enable_LateOpenHighway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true) || BaseGame.Enable_LateOpenHighway == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true)  or  Variable["BaseGame.Enable_LateOpenHighway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true) || BaseGame.Enable_LateOpenHighway == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true)  or  Variable["BaseGame.Enable_LateOpenHighway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""We have an alliance. Aren't you supposed to be on my side?""]** — Mówca: **Player**
> ""We have an alliance. Aren't you supposed to be on my side?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Frens Ricter**
> ""Well, you didn't run this by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Laugh all you want. I'm going to make it happen.""]** — Mówca: **Player**
> ""Laugh all you want. I'm going to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[37]`
Mówca: **Kesaro Kibener**
> ""This has been a goal of the NFP for some time now. But Anton Rayne cannot be trusted with his finger on the nuclear button.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[38]`
Mówca: **Manoly Suheil**
> ""I've been pushing to include this in the next PFJP platform as well, but it's a hard sell with voters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[107]`
  - -> `[108]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Citizens will still work. My plan will only ensure nobody has to go homeless.""]** — Mówca: **Player**
> ""Citizens will still work. My plan will only ensure nobody has to go homeless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[40]`
Mówca: **Kesaro Kibener**
> ""As your alliance partner, I pledge the NFP will also strive to enhance our nuclear capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Sordland must develop a nuclear arsenal.""]** — Mówca: **Player**
> ""Sordland must develop a nuclear arsenal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""We will grant a basic living wage to every man and woman in Sordland. Unemployed or otherwise.""]** — Mówca: **Player**
> ""We will grant a basic living wage to every man and woman in Sordland. Unemployed or otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""I want Sordland to put a man on the moon.""]** — Mówca: **Player**
> ""I want Sordland to put a man on the moon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[47]`
Mówca: **Remus Holstron**
> ""You're mad. Sordish citizens want to work for their money. Handouts will only make them soft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[107]`
  - -> `[108]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[54]`
Mówca: **Frens Ricter**
> ""I agree, but you've already proven yourself incapable of managing basic infrastructure projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`
  - -> `[31]`

### Węzeł `[55]`
Mówca: **Frens Ricter**
> ""You're both mad. Disincentivizing work will crater this country's economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[117]`
  - -> `[39]`
  - -> `[107]`

### Węzeł `[56]`
Mówca: **Manoly Suheil**
> ""There are so many problems still to be solved in Sordland. Space is just a flashy distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[60]`
Mówca: **Frens Ricter**
> ""I agree with this plan in theory, but it would bankrupt our country in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`
  - -> `[31]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[67]`
Mówca: **Narrator**
> "The other candidates burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[8]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""I'm serious. Sordland is going into space.""]** — Mówca: **Player**
> ""I'm serious. Sordland is going into space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[78]`
Mówca: **Narrator**
> "The candidates around me gasped -- except Mansoun and Denis, who looked pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[79]`
Mówca: **Narrator**
> "The candidates around me gasped -- except for Remus, who looked intrigued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Narrator**
> "The candidates around me gasped -- except for Kesaro, who looked faintly intrigued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[81]`
Mówca: **Frens Ricter**
> ""You're insane. If we even attempt this, it's only a matter of time before Sordland becomes a crater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[31]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[82]`
Mówca: **Manoly Suheil**
> ""Perhaps, but you've already proven yourself incapable of managing basic infrastructure projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[91]`
  - -> `[92]`

### Węzeł `[83]`
Mówca: **Remus Holstron**
> ""I guess the USP has gotten it's hands on our new manifesto. In the new age nuclear power plays an important role. We need to position Sords as the dominant power in the region and our party is committed to such ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[84]`
Mówca: **Lileas Graf**
> ""You couldn't even open a highway on time, and now you're talking about building rockets?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[85]`
Mówca: **Manoly Suheil**
> ""You're insane. If we even attempt this, it's only a matter of time before Sordland becomes a crater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[86]`
Mówca: **Lileas Graf**
> ""You couldn't even open a railway on time, and now you're talking about building rockets?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""No, that release was sent out in error. I'm keeping my plans modest.""]** — Mówca: **Player**
> ""No, that release was sent out in error. I'm keeping my plans modest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[88]`
Mówca: **Moderator**
> ""Would you like to tell us what those are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[41]`
  - -> `[42]`
  - -> `[89]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""You'll find out once I get re-elected.""]** — Mówca: **Player**
> ""You'll find out once I get re-elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[90]`
Mówca: **Denis Stahler**
> ""There are so many problems still to be solved in Sordland. Space is just a flashy distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""With nuclear war an increasing possibility, survival on other planets is something we must consider.""]** — Mówca: **Player**
> ""With nuclear war an increasing possibility, survival on other planets is something we must consider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""If we want to be taken seriously by the superpowers, this is the only way.""]** — Mówca: **Player**
> ""If we want to be taken seriously by the superpowers, this is the only way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""A space program would create thousands of jobs while boosting our national morale.""]** — Mówca: **Player**
> ""A space program would create thousands of jobs while boosting our national morale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[94]`
Mówca: **Denis Stahler**
> ""You're insane. If we even attempt this, it's only a matter of time before Sordland becomes a crater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[98]`
Mówca: **Narrator**
> "The candidates around me gasped -- except for Lileas, who smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Lileas Graf**
> ""This was a longtime ambition of Tarquin Soll. However, Anton Rayne cannot be trusted to fulfill it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Only via mutually assured destruction can we achieve peace with our enemies.""]** — Mówca: **Player**
> ""Only via mutually assured destruction can we achieve peace with our enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""A nuclear program would create thousands of jobs and boost national morale.""]** — Mówca: **Player**
> ""A nuclear program would create thousands of jobs and boost national morale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "The candidates around me gasped -- except Denis, who raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Denis Stahler**
> ""If you think that kind of empty promise will win over my voters, you're dead wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""With a guaranteed income, Sordish people will spend as never before. The economy will thrive.""]** — Mówca: **Player**
> ""With a guaranteed income, Sordish people will spend as never before. The economy will thrive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""By removing the bureaucracy associated with the welfare system, my plan will save us millions.""]** — Mówca: **Player**
> ""By removing the bureaucracy associated with the welfare system, my plan will save us millions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_SpacePromise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_SpacePromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_NuclearPromise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_NuclearPromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_BasicIncomePromise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HousingAssistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HousingAssistance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_HousingAssistance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Yes, and I can't wait to unveil them.""]** — Mówca: **Player**
> ""Yes, and I can't wait to unveil them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Moderator**
> ""Please go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_UnemploymentWage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_UnemploymentWage == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_UnemploymentWage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_UnemploymentWage == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_UnemploymentWage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""My administration is already providing assistance to unemployed citizens. This is just a logical extension of that policy.""]** — Mówca: **Player**
> ""My administration is already providing assistance to unemployed citizens. This is just a logical extension of that policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""My administration is already providing housing assistance to low-income citizens. This is just a logical extension of that policy"]** — Mówca: **Player**
> ""My administration is already providing housing assistance to low-income citizens. This is just a logical extension of that policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
**[WYBÓR GRACZA: ""You're supposed to be my ally, Kesaro.""]** — Mówca: **Player**
> ""You're supposed to be my ally, Kesaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Kesaro Kibener**
> ""Well, you didn't run this by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Denis Stahler**
> ""I don't believe a word of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[107]`
  - -> `[108]`
  - -> `[131]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""All I have in mind is Sordish people and Sordish people alone.""]** — Mówca: **Player**
> ""All I have in mind is Sordish people and Sordish people alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
