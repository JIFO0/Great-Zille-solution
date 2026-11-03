# Sordland/Turn01/EnT_EconomicOverview

- **ID konwersacji:** `1`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/001_EnT_EconomicOverview.md`
- **Liczba węzłów dialogowych:** 352
- **Liczba wyborów gracza:** 65

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.PersonalWealth`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_Economy_FreeMarket`
- `BaseGame.Promise_Economy_Planned`
- `BaseGameIsolated.Turn01_EnT_Listened_Alphonso`
- `BaseGameIsolated.Turn01_EnT_Listened_Examples`
- `BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP`
- `BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL`
- `BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP`
- `BaseGameIsolated.Turn01_EnT_Listened_Soll`
- `BaseGameIsolated.Turn01_EnT_Listened_Superpower`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Economy`
- `BaseGame.EconomyDirection_Scale`
- `BaseGame.Enable_Turn01InvestmentDecisionOption_Spend2`
- `BaseGame.Enable_Turn01InvestmentDecisionOption_Spend3`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Economy_Alphonsonomics`
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Sollist`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGameIsolated.Turn01_EnT_Listened_Alphonso`
- `BaseGameIsolated.Turn01_EnT_Listened_Examples`
- `BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP`
- `BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL`
- `BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP`
- `BaseGameIsolated.Turn01_EnT_Listened_Soll`
- `BaseGameIsolated.Turn01_EnT_Listened_Superpower`
- `BaseGameSupport.CountryReport_Turn01_Rizia_ElectionWinCongratulation`
- `BaseGameSupport.FactionReport_Turn01_CSP_AnrakaNAP`
- `BaseGameSupport.Journal_Turn01_PromotedMarketEconomy`
- `BaseGameSupport.Journal_Turn01_PromotedPlannedEconomy`
- `BaseGameSupport.News_Turn01_E_ArmadineElectronics`
- `BaseGameSupport.News_Turn01_HP_TourismBill_GNAWork`
- `BaseGameSupport.News_Turn01_LT_FreezingWeather`
- `BaseGameSupport.News_Turn01_R_AlphonsoLeavesLotherberg`
- `BaseGameSupport.News_Turn01_R_NationalistViolence`
- `BaseGameSupport.News_Turn01_ST_Abandoned_FreeMarket`
- `BaseGameSupport.News_Turn01_ST_Abandoned_Planned`
- `BaseGameSupport.News_Turn01_ST_GasomPromotion`
- `BaseGameSupport.News_Turn01_ST_Market_Economy`
- `BaseGameSupport.News_Turn01_ST_Planned_Economy`
- `BaseGameSupport.Report_Turn01_Borin_DemandForWines`
- `BaseGameSupport.Report_Turn01_Gelsord_Infrastructure`
- `BaseGameSupport.Report_Turn01_Lachaven_GasomSeaRig`
- `BaseGameSupport.Report_Turn01_Lenkurg_Infrastructure`
- `BaseGameSupport.Report_Turn01_Morna_IncreasingUnemployment`
- `BaseGameSupport.Report_Turn01_Sarna_AgricultureGrows`
- `GameCondition.Turn01_EnT_EconomicOverview`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 12
- **Węzły modyfikujące stan gry:** 34

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.EconomyDirection_Scale`
- `BaseGame.Policy_Economy_Alphonsonomics`
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Sollist`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGameIsolated.Turn01_EnT_Listened_Soll`
- `BaseGameSupport.Journal_Turn01_PromotedMarketEconomy`
- `BaseGameSupport.Journal_Turn01_PromotedPlannedEconomy`
- `BaseGameSupport.News_Turn01_ST_Market_Economy`
- *...oraz 1 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[105]` (Symon Holl): `Variable["GameCondition.Turn01_EnT_EconomicOverview"] = true;`
- Węzeł `[109]` (Symon Holl): `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] = true;`
- Węzeł `[110]` (Symon Holl): `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] = true;`
- Węzeł `[111]` (Symon Holl): `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] = true;`
- Węzeł `[127]` (Symon Holl): `Variable["BaseGame.Turn01_EnT_Economy_Market"] = true;`
- Węzeł `[128]` (Symon Holl): `Variable["BaseGame.Turn01_EnT_Economy_Planned"] = true;`
- Węzeł `[135]` (Symon Holl): `Variable["BaseGame.Policy_Economy_PromoteMarket"] = true;`
- Węzeł `[136]` (Symon Holl): `Variable["BaseGame.Policy_Economy_PromotePlanned"] = true;`
- *...oraz 26 innych węzłów ze skryptami.*

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
> "Symon Holl, Gus Manger and Lileas Graf were about to arrive at the White Room for our scheduled economy meeting. This was the room in the Maroon Palace where all important meetings were held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“My staff and I have comprehensively analyzed every aspect of--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Symon Holl**
> "“Oh. You can put that there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Narrator**
> "He was interrupted by a groan from one of the assistants by the door, both of whom were now visibly struggling to hold up the heavy projector."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[7]`
Mówca: **Narrator**
> "He pointed below the painting of President Soll. The assistants placed the projector next to the table and installed a white screen on the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“What is our GDP and debt situation?”"]** — Mówca: **Player**
> "“What is our GDP and debt situation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“What is our unemployment and inflation rate?”"]** — Mówca: **Player**
> "“What is our unemployment and inflation rate?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
Mówca: **Symon Holl**
> "“Since economics is your forte, Mr. Rayne, it is possible that you might already be aware of the data. I can still explain the current economic situation in better detail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“Mr. President? I'm about to explain some very serious data.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“I am sorry, go ahead.”"]** — Mówca: **Player**
> "“I am sorry, go ahead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent. Suddenly the mood in the room turned slightly sour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[14]`
Mówca: **Symon Holl**
> "“I am very well and motivated, Mr. Rayne. It seems our ministers are feeling the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[53]`
  - -> `[46]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“What is the status of the recession?”"]** — Mówca: **Player**
> "“What is the status of the recession?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“Our current GDP is 310 billion Sordish Ren and the national debt is 427 billion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[17]`
Mówca: **Symon Holl**
> "“The economy has been in a recession of about -6% in the past year. The average GDP has dropped from SR 15,454 per capita to SR 10,359 from 1951 to now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“Unemployment has skyrocketed and is now at a staggering 16% and the inflation is at a relative high of 10%.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Symon scattered the paper stack in front of him in an orderly manner and took a final look at his notes before clearing his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[20]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Economy Questions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[112]`
  - -> `[115]`
  - -> `[118]`

### Węzeł `[21]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Economy Questions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I have all the information needed. Let's move on to the economic strategy.”"]** — Mówca: **Player**
> "“I have all the information needed. Let's move on to the economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "Yawn."]** — Mówca: **Player_Italic**
> "I yawned. Symon stared at me disapprovingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "Wait."]** — Mówca: **Player_Italic**
> "Lileas leaned to the table and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[25]`
Mówca: **Gus Manger**
> ""Don't be an idiot, Lileas. What about the unemployment crisis the Greater Holsord and Gelsland regions are going through? These areas are our economic heartland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[26]`
Mówca: **Lileas Graf**
> "“Gus, do you really think that such an economically advanced area is more in need of investment than Agnland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“Good morning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Narrator**
> "From the hallway, I heard Lileas Graf's voice. She was using the patient, almost motherly tone she often took in heated arguments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Symon Holl quickly stepped between the two ministers without looking at either of them. He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“What is this debate about?”"]** — Mówca: **Player**
> "“What is this debate about?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Good morning, everyone.”"]** — Mówca: **Player**
> "“Good morning, everyone. How are you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[32]`
Mówca: **Lileas Graf**
> "“Just a disagreement in internal economic strategy, President Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Gus Manger**
> "“Not sure if I would call it just a disagreement, Lileas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Let's begin the presentation.""]** — Mówca: **Player**
> "“Let's begin the presentation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Lileas, can you explain the situation?”"]** — Mówca: **Player**
> "“Lileas, can you explain the situation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[36]`
Mówca: **Lileas Graf**
> "“We've already begun restructuring local governments and introducing new safety measures. Off to a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[37]`
Mówca: **Gus Manger**
> "“It's looking good, sir. Although there seems to be a lot of work that requires attention.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Just as expected. How is it going, Gus and Lileas?”"]** — Mówca: **Player**
> "“Just as expected of my cabinet. How is it going, Gus and Lileas?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[39]`
Mówca: **Lileas Graf**
> "“Meanwhile, many cities in Agnland like Lenkurg or Arvory still don't have basic commodities delivered in time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[63]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Could you enlighten me, Gus?”"]** — Mówca: **Player**
> "“Could you enlighten me, Gus?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Gus Manger**
> "“Ms. Graf seeks to focus our economic development in a region where we can't reap the financial benefits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[43]`
Mówca: **Symon Holl**
> "“Yes. I will move forward with my presentation if no one objects?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Gus Manger**
> "“Go ahead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Great to hear. Let's begin.”"]** — Mówca: **Player**
> "“Great to hear. Let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Good. I am confident in your abilities.""]** — Mówca: **Player**
> "“Good. I am confident in your abilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“If there is anything you need help with, reach out to me.”"]** — Mówca: **Player**
> "“If there is anything you need help with, reach out to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“Good to know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[51]`
Mówca: **Lileas Graf**
> "“That is appreciated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Gus Manger**
> "“We will not disappoint you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""I can clearly see that. What was that discussion about?""]** — Mówca: **Player**
> ""I can clearly see that. What was that discussion about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Gus Manger**
> "“We were having a discussion about the infrastructure plans. If I may, I would like to talk to you about the-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“Thank you, Mr. President. Now I would like to show you the latest economic situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Symon started looking for his slides. He always carried documentation around with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[23]`

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“Leave now. I mean, thank you and please leave now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Symon Holl**
> "“First, I would like to conduct my economy presentation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[90]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Gus, what's your take on this?”"]** — Mówca: **Player**
> "“Gus, what's your take on this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Narrator**
> "The assistants left the cabinet room. I was reminded that Symon had never quite had a way with people. But his facility with numbers had made him the most sought-after economic specialist in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“A wise idea, if your main agenda is to make money instead of developing the region and serving the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Gus Manger**
> "“Sir, I have some very good construction companies willing to take government contracts in Greater Holsord and Gelsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Lileas, could you elaborate?”"]** — Mówca: **Player**
> "“Lileas, could you elaborate?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Lileas, could you watch your tone?”"]** — Mówca: **Player**
> "“Lileas, could you watch your tone?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“Pardon me, Mr. President. I just want the best for the city of Arvory and the Agnland region in general.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[68]`
  - -> `[63]`

### Węzeł `[66]`
Mówca: **Lileas Graf**
> "“Of course. The argument is simple. Agnland is our weakest region both in terms of economic and social support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[67]`
Mówca: **Gus Manger**
> "“How impartial can you really be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I agree, Agnland needs investment.”"]** — Mówca: **Player**
> "“I agree, Agnland needs investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Why are you questioning her impartiality?”"]** — Mówca: **Player**
> "“Why are you questioning her impartiality?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Symon was observing the argument."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“What are your thoughts, Symon?”"]** — Mówca: **Player**
> "“What are your thoughts, Symon?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Symon Holl**
> "“I have to say that I agree with both of them. Agnland is in need of investment, and we can improve Greater Holsord and Gelsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Symon stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[74]`
Mówca: **Gus Manger**
> "“This snake of a woman is the former mayor of Arvory, and Eric Niel is her successor. Her argument could be biased.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“Gus, dear, my arguments are proven by simple economic data. Our poorest and least developed region is Agnland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Lileas Graf**
> "“The facts are clear. But it seems to me that you'd rather resort to name-calling to push your agenda.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Lileas smiled and folded her hands primly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[78]`
Mówca: **Symon Holl**
> "“I want to avoid this topic now since we will talk about it in the future. I would rather first fully brief you on our current economic situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[79]`
Mówca: **Gus Manger**
> "“The figures are being skewed in Nargis to make it look like a developed region, for example. In truth, it is the poorest region of all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[80]`
Mówca: **Symon Holl**
> "“I would like to put a stop to this debate. We will discuss it all calmly and logically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[81]`
Mówca: **Lileas Graf**
> "“Symon, what happened to the new police station construction in Estord?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "While going through his briefcase, he paused for a moment to answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Symon Holl**
> "“It got stalled due to a government property boundary issue. I have been meaning to look at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Lileas Graf**
> "“I can take a look at that one. Estord needs all the security help it can get.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Symon Holl**
> "“Sure. More time for me to spend on analyses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Narrator**
> "His eyes glittered when he finally found the slides he were looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[87]`
Mówca: **Gus Manger**
> "“It's still hard to fathom that we lost nearly 150 billion in wealth. The past three years were tough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[88]`
Mówca: **Lileas Graf**
> "“Unemployment is increasing crime and drug use. We need to get people off the streets. The inflation isn't helping our average citizen either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[89]`
Mówca: **Symon Holl**
> "“This administration's success depends on our ability to stop the recession. The sooner we can reach GDP growth the better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Let's begin.”"]** — Mówca: **Player**
> "“Let's begin. I am looking forward to this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“I am interested in what Gus has to say.”"]** — Mówca: **Player**
> "“I am interested in what Gus has to say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Symon Holl**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Gus Manger**
> "“Sir, I have some very good construction companies willing to take government contracts in the Greater Holsord and Gelsland regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Gus Manger**
> "“This would boost the rural economy. I think it would be wise to pick investments that will go through these regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“This seems like a good opportunity.”"]** — Mówca: **Player**
> "“This seems like a good opportunity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“No need to rush this, Gus. We will figure it out.”"]** — Mówca: **Player**
> "“No need to rush this, Gus. We will figure it out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[97]`
Mówca: **Gus Manger**
> "“This would boost the rural economy. I think it would be wise to pick investments that will go through these regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[71]`
  - -> `[104]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“I agree that the countryside needs investment.”"]** — Mówca: **Player**
> "“I agree that the Greater Holsord and Gelsland countryside needs investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "Gus smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Lileas and Gus went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[101]`
Mówca: **Gus Manger**
> "“Right? Additionally, we can...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Narrator**
> "Lileas interrupted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Lileas Graf: "“A wise idea, if your main agenda i..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Lileas, what are your thoughts on this proposition?”"]** — Mówca: **Player**
> "“Lileas, what are your thoughts on this proposition? Can you explain your point?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[105]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn01_EnT_EconomicOverview = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn01_EnT_EconomicOverview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[106]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[108]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[110]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[111]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[112]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[114]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[117]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[120]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[121]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[123]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Symon Holl**
> "“One of our main promises was to promote a planned economy to stop the recession. To be frank, I still don't think this was a good idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Promote a free-market economy.”"]** — Mówca: **Player**
> "“Promote a free-market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Promote a planned economy as we promised.”"]** — Mówca: **Player**
> "“Promote a planned economy as we promised.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[127]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[129]`
Mówca: **Symon Holl**
> "“So, what will our general economic plan promote?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[130]`
Mówca: **Lileas Graf**
> "“I still do not support it. Why promote the private sector when we have qualified state-owned enterprises?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[131]`
Mówca: **Gus Manger**
> "“We shouldn't go back to Sollonomics. It is the reason for the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[132]`
Mówca: **Lileas Graf**
> "“I can't say that I agree with this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“Not sure if we made the right decision here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[134]`
Mówca: **Symon Holl**
> "“Now that there is clarity on which direction we are heading. I will work on a good plan accordingly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromoteMarket = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[136]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[137]`
Mówca: **Narrator**
> "Symon nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[139]`
  - -> `[315]`
  - -> `[142]`
  - -> `[327]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Symon ignored the statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[139]`
  - -> `[315]`
  - -> `[142]`
  - -> `[327]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“What are the consequences of the free-market?”"]** — Mówca: **Player**
> "“What are some of the consequences of the free-market strategy?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“What's on our long-term economic schedule?”"]** — Mówca: **Player**
> "“What's on our long-term economic schedule?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“What's on our long-term economic schedule?”"]** — Mówca: **Player**
> "“What's on our long-term economic schedule?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“What are the downsides of the planned economy?”"]** — Mówca: **Player**
> "“What are the downsides of the planned economy strategy?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[143]`
Mówca: **Symon Holl**
> "“Choosing construction contractors, trade relations, tax reform and privatization initiatives would be some of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Symon Holl**
> "“There are not many but one could say that we are much more likely to be influenced by the world economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[145]`
Mówca: **Symon Holl**
> "“The structural problems of Sollonomics were going to lead to a recession according to the predictions at the time anyway. Either way, even if we pick one of the doctrines, we retain the option to make economic choices on a case-by-case basis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[146]`
Mówca: **Symon Holl**
> "“It is clear that most of the state corporations and other government controlled systems are less efficient.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[147]`
Mówca: **Symon Holl**
> "“Picking a construction company, trade relations, tax reform and welfare privatization or nationalization initiatives would be some of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
Mówca: **Lileas Graf**
> "“Sticking to a solid planned economy strategy will be the right call. The five-year plans were fruitful in the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[149]`
Mówca: **Gus Manger**
> "“It is important to think about this subject because the upswings of the world economy will reflect good on ours too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[150]`
Mówca: **Lileas Graf**
> "“That is, however, not recommended in my point of view. The last thing we need is a chaotic economic plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[151]`
Mówca: **Lileas Graf**
> "“The government of Sordland and its institutions or corporations have a solid history of delivering.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[152]`
Mówca: **Gus Manger**
> "“We must choose wisely and remember that the free-market economy in all forms is the future of the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Symon put forward a legal document outlining the possibilities with both economic doctrines listed. The cabinet members looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[154]`
Mówca: **Symon Holl**
> "“What are your final thoughts, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`
  - -> `[236]`
  - -> `[159]`
  - -> `[351]`

### Węzeł `[155]`
Mówca: **Lileas Graf**
> "“Self-sufficiency will help us in tough times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[156]`
Mówca: **Gus Manger**
> "“Because the lack of competition has made them inefficient.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[157]`
**[WYBÓR GRACZA: "“Critical institutions must remain in state control. We must be fully responsible in delivering services.”"]** — Mówca: **Player**
> "“Critical institutions must remain in state control. We must be fully responsible in delivering services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“We should look at opportunities like privatization to create financial resources.”"]** — Mówca: **Player**
> "“We should look at opportunities like privatization to create financial resources.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "“It is hard to fully agree or disagree with these options.”"]** — Mówca: **Player**
> "“It is hard to fully agree or disagree with these options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
Mówca: **Symon Holl**
> "“A market economy doesn't mean privatization of every single institution. But either way, you make the choices.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[161]`
Mówca: **Symon Holl**
> "“This is exactly my mentality. There are many possibilities that are waiting, like education or health privatization. It would be better to promote a market economy for these to have consistency with our plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[162]`
Mówca: **Symon Holl**
> "“It's a difficult position to be in, Mr. President. But your final say is what counts. Remember, this is the overall strategic direction. Our ability to make individual economic decisions still remains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Now that the economic direction was decided upon, the ministers dispersed for lunch at the Maroon Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Two assistants arrived first, carrying a heavy projector. They stood with it by the door, waiting for the ministers to enter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[165]`
Mówca: **Symon Holl**
> "“We will get there, Gus. No rush.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[166]`
Mówca: **Gus Manger**
> "“Especially about lifting people out of poverty. Certainly, a challenge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Lileas Graf**
> "“I am feeling fairly confident about the current state of affairs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[168]`
Mówca: **Narrator**
> "Symon interrupted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[169]`
Mówca: **Lileas Graf**
> "“Mr. Manger proposes that we should invest in already developed regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[170]`
Mówca: **Lileas Graf**
> "“We should support the city of Arvory and its respected mayor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[171]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[217]`

### Węzeł `[173]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[211]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Would a free-market focus bring us stronger allies?”"]** — Mówca: **Player**
> "“Would a free-market focus bring us stronger allies?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Would a planned economy focus bring us stronger allies?”"]** — Mówca: **Player**
> "“Would a planned economy focus bring us stronger allies?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "“We have to thank Soll and his planned economy for the boom. It clearly shows the success of the system.”"]** — Mówca: **Player**
> "“We have to thank Soll and his planned economy for the boom. It clearly shows the success of the system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[177]`
Mówca: **Symon Holl**
> "“This concludes our meeting. At our next gathering we will talk about the upcoming infrastructure investment plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[178]`
Mówca: **Lileas Graf**
> "“Diplomatically, it would make United Contana look at our country in a more positive light. They are proponents of the planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
Mówca: **Gus Manger**
> "“It would make Arcasia look at our country in a more positive light. They are proponents of the free-market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Symon Holl**
> "“The influence Arcasia has on the world economy is extensive. Our economic strategy should be based on internal reasoning though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[181]`
Mówca: **Symon Holl**
> "“Whatever that's worth. The influence Arcasia has on the world economy is extensive. Our economic strategy should be based on internal reasoning, though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "“Let's finish what Alphonso started with the capitalist free-market reforms. His path was going to enrich Sordland.”"]** — Mówca: **Player**
> "“Let's finish what Alphonso started with the capitalist free-market reforms. His path was going to enrich Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[183]`
Mówca: **Lileas Graf**
> "“Precisely the reason why we should stick to the old system. State planning and regulation both showed great success in the 30s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Gus Manger**
> "“History must note that the reason for the recession was because Ewald Alphonso was betrayed by his party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[185]`
Mówca: **Lileas Graf**
> "“The recession was the direct result of his free-market reforms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[186]`
Mówca: **Gus Manger**
> "“Only for a limited time, until even Tarquin Soll himself discovered the limits of the system. The slowdown began during his rule, remember?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[187]`
Mówca: **Narrator**
> "Gus looked worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Lileas looked displeased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[189]`
Mówca: **Lileas Graf**
> "“Yes... And when the global economy crashes, we go down with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[190]`
Mówca: **Lileas Graf**
> "“I wouldn't be so sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[191]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Economy Doctrine Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[205]`
  - -> `[171]`
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Superpower == true || BaseGameIsolated.Turn01_EnT_Listened_Examples == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Superpower == true || BaseGameIsolated.Turn01_EnT_Listened_Examples == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[194]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Superpower == true || BaseGameIsolated.Turn01_EnT_Listened_Examples == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[195]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Soll = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[196]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Alphonso = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[197]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Superpower = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[198]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Examples = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[199]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Examples = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Superpower = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Economy Doctrine Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[202]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[204]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[205]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[207]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Superpower == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Superpower == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[210]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Superpower == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[211]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Examples == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Examples == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[213]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Examples == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[214]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Examples == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Examples == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[216]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Examples == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[217]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Superpower == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn01_EnT_Listened_Superpower == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[219]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn01_EnT_Listened_Superpower == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[220]`
Mówca: **Gus Manger**
> "“Finally something we can both agree on, Lileas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[221]`
Mówca: **Lileas Graf**
> "“That is not true, there was plenty of time for him to do it. If you can't make change happen in two years then you are at fault.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[222]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[225]`
**[WYBÓR GRACZA: "“Promote a free-market economy as we promised.”"]** — Mówca: **Player**
> "“Promote a free-market economy as we promised.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[226]`
**[WYBÓR GRACZA: "“Promote a planned economy.”"]** — Mówca: **Player**
> "“Promote a planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[227]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[229]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Lachaven_Economics == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Symon Holl**
> "“What would you like to know about the current economic situation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[231]`
Mówca: **Narrator**
> "The Recession of '51 put enormous pressure on the economy, resulting in the collapse of the value of our currency. The entire situation was a significant cause of concern for our administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[232]`
Mówca: **Symon Holl**
> "“There have been some developments about the Sordish Ren losing further value today. We have been trying to stabilize it with the Central Bank.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[233]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist -= 3;
BaseGame.Malenyevist += 5;
BaseGame.Sollist += 3;
BaseGame.Economy += 1;
BaseGame.EconomyDirection_Scale -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 3;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 5;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 3;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[234]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist += 5;
BaseGame.Malenyevist -= 3;
BaseGame.Sollist -= 3;
BaseGame.EconomyDirection_Scale += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 5;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 3;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[235]`
Mówca: **Gus Manger**
> "“Business leaders are requesting better logistical links in order to contribute to the economy more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[236]`
**[WYBÓR GRACZA: "“A market economy doesn't require as much guidance and could help us attract foreign capital.”"]** — Mówca: **Player**
> "“A market economy doesn't require as much guidance and could help us attract foreign capital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Symon Holl**
> "“Especially from Arcasia. President Walker is always interested in expanding the economic zone of ATO. We could secure lucrative investments from capitalist countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[238]`
Mówca: **Narrator**
> "Lileas, my Interior Minister, strode in. She was clad in shades of brown and beige, the only spot of color a bright yellow Dastnurist cross on her necklace. Gus followed close behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[239]`
Mówca: **Narrator**
> "Gus curled his hands into fists. The Minister of Agriculture and Rural Development's temper hadn't changed since his days in the Alphonso administration, but neither had his reputation for getting things done. His far-reaching network of connections was unlike any other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[240]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Abandoned_FreeMarket = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Abandoned_FreeMarket"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[241]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Planned_Economy = true;
BaseGame.EconomyDirection_Scale -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Planned_Economy"] = true;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[242]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Abandoned_Planned = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Abandoned_Planned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[243]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_Market_Economy = true;
BaseGame.EconomyDirection_Scale += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Market_Economy"] = true;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[244]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_LT_FreezingWeather = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_LT_FreezingWeather"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[245]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_R_NationalistViolence = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_R_NationalistViolence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[246]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Gelsord_Infrastructure = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Gelsord_Infrastructure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Lenkurg_Infrastructure = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Lenkurg_Infrastructure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[248]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Sarna_AgricultureGrows = true;
BaseGameSupport.FactionReport_Turn01_CSP_AnrakaNAP = true;
BaseGameSupport.Report_Turn01_Morna_IncreasingUnemployment = true;
BaseGameSupport.CountryReport_Turn01_Rizia_ElectionWinCongratulation = true;
BaseGameSupport.News_Turn01_ST_GasomPromotion = true;
BaseGameSupport.News_Turn01_HP_TourismBill_GNAWork = true;
BaseGameSupport.News_Turn01_R_AlphonsoLeavesLotherberg = true;
BaseGameSupport.Report_Turn01_Borin_DemandForWines = true;
BaseGameSupport.Report_Turn01_Lachaven_GasomSeaRig = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Sarna_AgricultureGrows"] = true;
Variable["BaseGameSupport.FactionReport_Turn01_CSP_AnrakaNAP"] = true;
Variable["BaseGameSupport.Report_Turn01_Morna_IncreasingUnemployment"] = true;
Variable["BaseGameSupport.CountryReport_Turn01_Rizia_ElectionWinCongratulation"] = true;
Variable["BaseGameSupport.News_Turn01_ST_GasomPromotion"] = true;
Variable["BaseGameSupport.News_Turn01_HP_TourismBill_GNAWork"] = true;
Variable["BaseGameSupport.News_Turn01_R_AlphonsoLeavesLotherberg"] = true;
Variable["BaseGameSupport.Report_Turn01_Borin_DemandForWines"] = true;
Variable["BaseGameSupport.Report_Turn01_Lachaven_GasomSeaRig"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[249]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn01_PromotedMarketEconomy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_PromotedMarketEconomy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[250]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn01_PromotedPlannedEconomy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_PromotedPlannedEconomy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[251]`
Mówca: **Symon Holl**
> "“One of our main promises was to promote a free-market economy to stop the recession. To be frank, I believe it is the only way out of the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[252]`
Mówca: **Lileas Graf**
> "“There is another important factor which has a direct impact on our economy. Superpowers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[255]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[258]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[259]`
Mówca: **Lileas Graf**
> "“We might have won the election but I am still against aligning ourselves with the superpowers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[260]`
Mówca: **Lileas Graf**
> "“We might have won the election, but I am still against aligning ourselves with any superpowers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[261]`
Mówca: **Lileas Graf**
> "“I want you to reconsider your promise to align with Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[282]`
  - -> `[289]`

### Węzeł `[262]`
Mówca: **Lileas Graf**
> "“We have done well not aligning ourselves with any one of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[263]`
Mówca: **Lileas Graf**
> "“We must be very cautious. There are schemes being devised about Sordland. We can not give in to their wants now or in the future. Otherwise our country will turn into a pawn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`
  - -> `[305]`
  - -> `[298]`

### Węzeł `[264]`
**[WYBÓR GRACZA: "“Don't worry. I won't let United Contana control Sordland.”"]** — Mówca: **Player**
> "“Don't worry. I won't let United Contana control Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[265]`
**[WYBÓR GRACZA: "“I have made a promise to the people of Sordland. I won't back down.”"]** — Mówca: **Player**
> "“I have made a promise to the people of Sordland. I won't back down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[266]`
Mówca: **Lileas Graf**
> "“We must be very cautious. There are schemes being devised about Sordland. We can not give in to their wants now or in the future. Otherwise our country will turn into a pawn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Lileas Graf**
> "“I want you to reconsider your promise to align with United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[264]`
  - -> `[269]`
  - -> `[272]`

### Węzeł `[268]`
Mówca: **Lileas Graf**
> "“We must be very cautious. There are schemes being devised about Sordland. We can not give in to their wants now or in the future. Otherwise our country will turn into a pawn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[269]`
**[WYBÓR GRACZA: "“There is a revolution that was started by United Contana. A permanent revolution. And Sordland must be part of it.”"]** — Mówca: **Player**
> "“There is a revolution that was started by United Contana. A permanent revolution. And Sordland must be part of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[270]`
Mówca: **Gus Manger**
> "“I hope we can show and not tell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[271]`
Mówca: **Gus Manger**
> "“I must also insist. Nothing good will come out of siding with United Contana. Aligning with them may make us adversaries to Arcasia, a much more influential nation in my view.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
**[WYBÓR GRACZA: "“You may be right. Let's see what the future brings.”"]** — Mówca: **Player**
> "“You may be right. Let's see what the future brings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[273]`
Mówca: **Gus Manger**
> "“We will see how long it will last.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[274]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[275]`
Mówca: **Gus Manger**
> "“I am also with Lileas on this one. Nothing good will come out of siding with United Contana. Aligning with them may make us adversaries to Arcasia, a much more influential nation in my view.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
Mówca: **Lileas Graf**
> "“Although not for the same reasons, that's two things we are agreeing on today, Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[277]`
Mówca: **Narrator**
> "Symon cleared his throat again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Symon Holl**
> "“Let's not get ahead of ourselves. Minister Wisci will be in charge of informing you on those types of foreign policy decisions. We must first decide on our internal economic plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[279]`
Mówca: **Lileas Graf**
> "“Although not for the same reasons, that's two things we are agreeing on today, Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[280]`
**[WYBÓR GRACZA: "“I have made a promise to the people of Sordland. I won't back down.”"]** — Mówca: **Player**
> "“I have made a promise to the people of Sordland. I won't back down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[281]`
**[WYBÓR GRACZA: "“Don't worry. I won't let Arcasia control Sordland.”"]** — Mówca: **Player**
> "“Don't worry. I won't let Arcasia control Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[282]`
**[WYBÓR GRACZA: "“Entering the sphere of Arcasia will help boost our economy in many ways. They are wealthy and influential.”"]** — Mówca: **Player**
> "“Entering the sphere of Arcasia will help boost our economy in many ways. They are wealthy and influential.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[283]`
Mówca: **Gus Manger**
> "“Control? No, Mr. President, it's simply a partnership. And a very valuable one at that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[284]`
Mówca: **Lileas Graf**
> "“When the time comes, I hope you will make the right decision. For our own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[285]`
Mówca: **Gus Manger**
> "“Exactly. We have made a promise. People want to trust their President. What kind of an example we would set for the future generations if we were to back down on our promises?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[286]`
Mówca: **Gus Manger**
> "“Mr. President. We have made a promise. People want to trust their President. What kind of an example we would set for future generations if we were to back down on our promises?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
Mówca: **Gus Manger**
> "“Exactly. I like to think of it as a very valuable partnership. With the deals we will get by aligning ourselves with a strong country like Arcasia, recession would surely end in no time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[288]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[289]`
**[WYBÓR GRACZA: "“You may be right. Let's see what the future brings.”"]** — Mówca: **Player**
> "“You may be right. Let's see what the future brings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[290]`
Mówca: **Lileas Graf**
> "“I know you have campaigned for this in the party a long time, Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[291]`
Mówca: **Lileas Graf**
> "“Future generations would be thankful everyday for making the right decision when Sordland is the only nation in the region that is not a puppet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[292]`
Mówca: **Gus Manger**
> "“Also, in my opinion, aligning with a powerful country like Arcasia was an excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[293]`
Mówca: **Lileas Graf**
> "“Mr. President. This is exactly what being controlled looks like. Voluntarily or involuntarily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Gus eyed Lileas with distrust but didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[295]`
Mówca: **Lileas Graf**
> "“Valuable for Arcasia maybe. Not for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Gus Manger**
> "“That is simply untrue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[297]`
Mówca: **Lileas Graf**
> "“In return for what? Sordland's independence?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[298]`
**[WYBÓR GRACZA: "“Time will show if staying neutral will work out.”"]** — Mówca: **Player**
> "“Time will show if staying neutral will work out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[299]`
**[WYBÓR GRACZA: "“Sordland will not be controlled by any nations.”"]** — Mówca: **Player**
> "“Sordland will not be controlled by any nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[300]`
**[WYBÓR GRACZA: "“Exactly. Soll was right all along with his policies.”"]** — Mówca: **Player**
> "“Exactly. Soll was right all along with his policies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Lileas Graf**
> "“I am glad we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Gus Manger**
> "“I hope we won't regret this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[304]`
Mówca: **Lileas Graf**
> "“Precisely my point. We will stand strong and show an example to the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[305]`
**[WYBÓR GRACZA: "“I still haven't decided if they wish to come with a deal.”"]** — Mówca: **Player**
> "“I still haven't decided if they wish to come with a deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Lileas Graf**
> "“A deal that they would surely come out with more profit while our people suffered.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Gus Manger**
> "“We don't know that. We should wait and see. With the deals we could get by aligning ourselves with a strong country like Arcasia, recession would surely end in no time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[308]`
Mówca: **Lileas Graf**
> "“We must make it work to protect our country and our values. There is no other way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Gus Manger**
> "“We need to be open to other possibilities. Arcasia is a strong country and If we end up in their sphere, Sordland would increase its influence in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Gus Manger**
> "“The deals we would get would surely bring us out of recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Lileas Graf**
> "“In return for what? Our independence?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[312]`
Mówca: **Symon Holl**
> "“Economically speaking, we are much closer to Arcasia than United Contana, so a decision to align with the west makes more sense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[313]`
Mówca: **Symon Holl**
> "“Economically speaking, we aren't as tied to United Contana as we are to Arcasia, so a decision to align with the east is much more difficult to accomplish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[314]`
Mówca: **Symon Holl**
> "“Economically speaking, an isolationist policy overall could only work if we were to reap the benefits of both spheres and their rivalry. This is very dangerous to attempt but still possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[315]`
**[WYBÓR GRACZA: "“The more of the economy we control, the better we can manage the recession.”"]** — Mówca: **Player**
> "“The more of the economy we control, the better we can manage the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[316]`
**[WYBÓR GRACZA: "“Economic systems without regulation are bound to fail.”"]** — Mówca: **Player**
> "“Economic systems without regulation are bound to fail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[317]`
**[WYBÓR GRACZA: "“Humanity in the 20th century is thriving because of the rule of supply and demand.”"]** — Mówca: **Player**
> "“Humanity in the 20th century is thriving because of the rule of supply and demand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[318]`
Mówca: **Gus Manger**
> "“From taxes to the standard of goods, there are many elements that regulate all aspects of this system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Lileas Graf**
> "“But is it enough? I doubt it. If we can manage to plan more aspects of the economy, our chances of success would increase with a talented team like ours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[320]`
Mówca: **Symon Holl**
> "“Obviously there is some regulation in all of the existing systems, otherwise it would be anarchy. Nobody wants a chaotic society.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[321]`
Mówca: **Lileas Graf**
> "“One way to be remembered positively is to cause a recession and leave a few bills behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[322]`
Mówca: **Gus Manger**
> "“Say what you will about Alphonso, without his attempts our current coffers would be empty and the recession would be a depression.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[323]`
Mówca: **Symon Holl**
> "“That is a fair argument to be made. But if we reduce the freedom of people in the market place in general, it would hinder our innovation and dynamism in the supply and demand equation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[324]`
Mówca: **Lileas Graf**
> "“Integrating heavily in a market economy would work if we had extensive means of production. Our industry is lacking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[325]`
Mówca: **Gus Manger**
> "“Sordland has the potential to do so as well. Why don't we take our potential seriously?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[326]`
Mówca: **Symon Holl**
> "“Agreed. Look at how quickly Lespia and Arcasia have increased their prosperity by embracing these basic principles.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[327]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_FreeMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[329]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_FreeMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[330]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[332]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[333]`
Mówca: **Symon Holl**
> "“As you can see, the situation is alarming, but not everything is negative. The extensive privatization program of Alphonso and key foreign direct investments left us a large budget surplus which we can use to stabilize the crisis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Symon Holl**
> "“The primary subject we need to settle on is what general path we will take in our term. Sollonomics-based nationalization happened in the '30s and Alphonso's privatization began during the end of the '40s. What will our administration focus on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[335]`
Mówca: **Narrator**
> "Symon pulled a silk handkerchief out of his pocket and briefly wiped his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[336]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth < 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth < 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth < 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Turn01InvestmentDecisionOption_Spend3 = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_Turn01InvestmentDecisionOption_Spend3"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth < 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth < 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[343]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Turn01InvestmentDecisionOption_Spend2 = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_Turn01InvestmentDecisionOption_Spend2"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[344]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_E_ArmadineElectronics = true; BaseGame.Policy_Economy_Alphonsonomics = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_E_ArmadineElectronics"] = true;
Variable["BaseGame.Policy_Economy_Alphonsonomics"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[345]`
**[WYBÓR GRACZA: "“Let's move on to the conclusion.”"]** — Mówca: **Player**
> "“Let's move on to the conclusion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[346]`
Mówca: **Gus Manger**
> "“We should attract more foreign direct investment. Mr. President, we saved the country from a full-on depression in 1952 and 1953 by signing lucrative trade deals with nations such as Rizia, Lespia, and Qinal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[347]`
Mówca: **Narrator**
> "Lileas had a sip of water from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[348]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“No need for questions. I am well aware of the details. Let's move on to our strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Here's what we'll do...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You already know what we're going to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
