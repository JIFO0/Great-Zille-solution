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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“What is our GDP and debt situation?”"** | `[10]` **Symon Holl**: "“Since economics is your forte, ..."<br>`[230]` **Symon Holl**: "“What would you like to know abo..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == false` | *Brak zmian stanu* | `[16]` **Symon Holl**: "“Our current GDP is 310 billion ..." |
| `[9]` | **"“What is our unemployment and inflation rate?”"** | `[10]` **Symon Holl**: "“Since economics is your forte, ..."<br>`[230]` **Symon Holl**: "“What would you like to know abo..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == false` | *Brak zmian stanu* | `[18]` **Symon Holl**: "“Unemployment has skyrocketed an..." |
| `[12]` | **"“I am sorry, go ahead.”"** | `[11]` **Symon Holl**: "“Mr. President? I'm about to exp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Symon Holl**: "“There have been some developmen..." |
| `[13]` | **"Stay silent."** | `[11]` **Symon Holl**: "“Mr. President? I'm about to exp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Symon Holl**: "“There have been some developmen..." |
| `[15]` | **"“What is the status of the recession?”"** | `[10]` **Symon Holl**: "“Since economics is your forte, ..."<br>`[230]` **Symon Holl**: "“What would you like to know abo..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == false` | *Brak zmian stanu* | `[17]` **Symon Holl**: "“The economy has been in a reces..." |
| `[22]` | **"“I have all the information needed. Let's move on to the economic strategy.”"** | `[10]` **Symon Holl**: "“Since economics is your forte, ..."<br>`[230]` **Symon Holl**: "“What would you like to know abo..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == true` | *Brak zmian stanu* | `[19]` **Narrator**: "Symon scattered the paper stack ..." |
| `[23]` | **"Yawn."** | `[56]` **Narrator**: "Symon started looking for his sl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Symon Holl**: "“Mr. President? I'm about to exp..." |
| `[24]` | **"Wait."** | `[56]` **Narrator**: "Symon started looking for his sl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Lileas Graf**: "“Symon, what happened to the new..." |
| `[30]` | **"“What is this debate about?”"** | `[27]` **Symon Holl**: "“Good morning, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Lileas Graf**: "“Just a disagreement in internal..." |
| `[31]` | **"“Good morning, everyone.”"** | `[27]` **Symon Holl**: "“Good morning, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Symon Holl**: "“I am very well and motivated, M..." |
| `[34]` | **"“Let's begin the presentation.""** | `[33]` **Gus Manger**: "“Not sure if I would call it jus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Symon Holl**: "“Yes. I will move forward with m..." |
| `[35]` | **"“Lileas, can you explain the situation?”"** | `[33]` **Gus Manger**: "“Not sure if I would call it jus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Lileas Graf**: "“Mr. Manger proposes that we sho..." |
| `[38]` | **"“Just as expected. How is it going, Gus and Lileas?”"** | `[14]` **Symon Holl**: "“I am very well and motivated, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Gus Manger**: "“It's looking good, sir. Althoug..." |
| `[40]` | **"“Could you enlighten me, Gus?”"** | `[33]` **Gus Manger**: "“Not sure if I would call it jus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Gus Manger**: "“Ms. Graf seeks to focus our eco..." |
| `[46]` | **"“Great to hear. Let's begin.”"** | `[14]` **Symon Holl**: "“I am very well and motivated, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Symon Holl**: "“Of course, Mr. President.”" |
| `[47]` | **"“Good. I am confident in your abilities.""** | `[36]` **Lileas Graf**: "“We've already begun restructuri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lileas Graf**: "“That is appreciated.”" |
| `[48]` | **"“If there is anything you need help with, reach out to me.”"** | `[36]` **Lileas Graf**: "“We've already begun restructuri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Gus Manger**: "“Of course, Mr. President.”" |
| `[53]` | **""I can clearly see that. What was that discussion about?""** | `[14]` **Symon Holl**: "“I am very well and motivated, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Gus Manger**: "“We were having a discussion abo..." |
| `[59]` | **"“Gus, what's your take on this?”"** | `[39]` **Lileas Graf**: "“Meanwhile, many cities in Agnla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Gus Manger**: "“Sir, I have some very good cons..." |
| `[63]` | **"“Lileas, could you elaborate?”"** | `[39]` **Lileas Graf**: "“Meanwhile, many cities in Agnla..."<br>`[61]` **Lileas Graf**: "“A wise idea, if your main agend..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Lileas Graf**: "“Of course. The argument is simp..." |
| `[64]` | **"“Lileas, could you watch your tone?”"** | `[61]` **Lileas Graf**: "“A wise idea, if your main agend..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Lileas Graf**: "“Pardon me, Mr. President. I jus..." |
| `[68]` | **"“I agree, Agnland needs investment.”"** | `[65]` **Lileas Graf**: "“Pardon me, Mr. President. I jus..."<br>`[70]` **Narrator**: "Symon was observing the argument." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "Lileas smiled and folded her han..." |
| `[69]` | **"“Why are you questioning her impartiality?”"** | `[70]` **Narrator**: "Symon was observing the argument." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Gus Manger**: "“This snake of a woman is the fo..." |
| `[71]` | **"“What are your thoughts, Symon?”"** | `[65]` **Lileas Graf**: "“Pardon me, Mr. President. I jus..."<br>`[70]` **Narrator**: "Symon was observing the argument."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Symon Holl**: "“I have to say that I agree with..." |
| `[90]` | **"“Let's begin.”"** | `[58]` **Symon Holl**: "“First, I would like to conduct ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Narrator**: "Symon pulled a silk handkerchief..." |
| `[91]` | **"“I am interested in what Gus has to say.”"** | `[58]` **Symon Holl**: "“First, I would like to conduct ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Symon Holl**: "“Of course, Mr. President.”" |
| `[95]` | **"“This seems like a good opportunity.”"** | `[94]` **Gus Manger**: "“This would boost the rural econ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Gus Manger**: "“Right? Additionally, we can...”" |
| `[96]` | **"“No need to rush this, Gus. We will figure it out.”"** | `[94]` **Gus Manger**: "“This would boost the rural econ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Narrator**: "Symon pulled a silk handkerchief..." |
| `[98]` | **"“I agree that the countryside needs investment.”"** | `[97]` **Gus Manger**: "“This would boost the rural econ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "Gus smirked." |
| `[104]` | **"“Lileas, what are your thoughts on this proposition?”"** | `[97]` **Gus Manger**: "“This would boost the rural econ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Lileas Graf**: "“Of course. The argument is simp..." |
| `[125]` | **"“Promote a free-market economy.”"** | `[129]` **Symon Holl**: "“So, what will our general econo..."<br>`[350]` **Player**: "“Here's what we'll do...”"<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false` | `Variable["BaseGameSupport.News_Turn01_ST_Abandoned_Planne...`<br>`Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capi...`<br>*(+3 skryptów)* | `[132]` **Lileas Graf**: "“I can't say that I agree with t..." |
| `[126]` | **"“Promote a planned economy as we promised.”"** | `[129]` **Symon Holl**: "“So, what will our general econo..."<br>`[350]` **Player**: "“Here's what we'll do...”"<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false` | `Variable["BaseGameSupport.News_Turn01_ST_Planned_Economy"...`<br>`Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capi...`<br>*(+3 skryptów)* | `[133]` **Gus Manger**: "“Not sure if we made the right d..." |
| `[139]` | **"“What are the consequences of the free-market?”"** | `[137]` **Narrator**: "Symon nodded."<br>`[138]` **Narrator**: "Symon ignored the statement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Symon Holl**: "“There are not many but one coul..." |
| `[140]` | **"“What's on our long-term economic schedule?”"** | `[153]` **Narrator**: "Symon put forward a legal docume..." | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false`<br>`Variable["BaseGame.Promise_Economy_FreeMarket"] == true` | *Brak zmian stanu* | `[143]` **Symon Holl**: "“Choosing construction contracto..." |
| `[141]` | **"“What's on our long-term economic schedule?”"** | `[153]` **Narrator**: "Symon put forward a legal docume..." | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false`<br>`(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false` | *Brak zmian stanu* | `[147]` **Symon Holl**: "“Picking a construction company,..." |
| `[142]` | **"“What are the downsides of the planned economy?”"** | `[137]` **Narrator**: "Symon nodded."<br>`[138]` **Narrator**: "Symon ignored the statement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Symon Holl**: "“It is clear that most of the st..." |
| `[157]` | **"“Critical institutions must remain in state control. We must be fully responsible ..."** | `[154]` **Symon Holl**: "“What are your final thoughts, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Symon Holl**: "“A market economy doesn't mean p..." |
| `[158]` | **"“We should look at opportunities like privatization to create financial resources.”"** | `[154]` **Symon Holl**: "“What are your final thoughts, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Symon Holl**: "“This is exactly my mentality. T..." |
| `[159]` | **"“It is hard to fully agree or disagree with these options.”"** | `[154]` **Symon Holl**: "“What are your final thoughts, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Symon Holl**: "“It's a difficult position to be..." |
| `[174]` | **"“Would a free-market focus bring us stronger allies?”"** | `[153]` **Narrator**: "Symon put forward a legal docume..." | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false`<br>`Variable["BaseGame.Promise_Economy_FreeMarket"] == true` | *Brak zmian stanu* | `[179]` **Gus Manger**: "“It would make Arcasia look at o..." |
| `[175]` | **"“Would a planned economy focus bring us stronger allies?”"** | `[153]` **Narrator**: "Symon put forward a legal docume..." | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false`<br>`(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false` | *Brak zmian stanu* | `[178]` **Lileas Graf**: "“Diplomatically, it would make U..." |
| `[176]` | **"“We have to thank Soll and his planned economy for the boom. It clearly shows the ..."** | `[153]` **Narrator**: "Symon put forward a legal docume..."<br>`[186]` **Gus Manger**: "“Only for a limited time, until ..."<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false` | *Brak zmian stanu* | `[183]` **Lileas Graf**: "“Precisely the reason why we sho..." |
| `[182]` | **"“Let's finish what Alphonso started with the capitalist free-market reforms. His p..."** | `[153]` **Narrator**: "Symon put forward a legal docume..."<br>`[186]` **Gus Manger**: "“Only for a limited time, until ..."<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false` | *Brak zmian stanu* | `[185]` **Lileas Graf**: "“The recession was the direct re..." |
| `[225]` | **"“Promote a free-market economy as we promised.”"** | `[129]` **Symon Holl**: "“So, what will our general econo..."<br>`[350]` **Player**: "“Here's what we'll do...”"<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Promise_Economy_FreeMarket"] == true` | `Variable["BaseGameSupport.News_Turn01_ST_Market_Economy"]...`<br>`Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capi...`<br>*(+3 skryptów)* | `[132]` **Lileas Graf**: "“I can't say that I agree with t..." |
| `[226]` | **"“Promote a planned economy.”"** | `[129]` **Symon Holl**: "“So, what will our general econo..."<br>`[350]` **Player**: "“Here's what we'll do...”"<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Promise_Economy_FreeMarket"] == true` | `Variable["BaseGameSupport.News_Turn01_ST_Abandoned_FreeMa...`<br>`Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capi...`<br>*(+3 skryptów)* | `[133]` **Gus Manger**: "“Not sure if we made the right d..." |
| `[236]` | **"“A market economy doesn't require as much guidance and could help us attract forei..."** | `[154]` **Symon Holl**: "“What are your final thoughts, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Symon Holl**: "“Especially from Arcasia. Presid..." |
| `[264]` | **"“Don't worry. I won't let United Contana control Sordland.”"** | `[267]` **Lileas Graf**: "“I want you to reconsider your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Gus Manger**: "“I hope we can show and not tell.”" |
| `[265]` | **"“I have made a promise to the people of Sordland. I won't back down.”"** | `[267]` **Lileas Graf**: "“I want you to reconsider your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Gus Manger**: "“I must also insist. Nothing goo..." |
| `[269]` | **"“There is a revolution that was started by United Contana. A permanent revolution...."** | `[267]` **Lileas Graf**: "“I want you to reconsider your p..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Mal...` | `[273]` **Gus Manger**: "“We will see how long it will la..." |
| `[272]` | **"“You may be right. Let's see what the future brings.”"** | `[267]` **Lileas Graf**: "“I want you to reconsider your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Gus Manger**: "“I am also with Lileas on this o..." |
| `[280]` | **"“I have made a promise to the people of Sordland. I won't back down.”"** | `[261]` **Lileas Graf**: "“I want you to reconsider your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Gus Manger**: "“Exactly. We have made a promise..." |
| `[281]` | **"“Don't worry. I won't let Arcasia control Sordland.”"** | `[261]` **Lileas Graf**: "“I want you to reconsider your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Gus Manger**: "“Control? No, Mr. President, it'..." |
| `[282]` | **"“Entering the sphere of Arcasia will help boost our economy in many ways. They are..."** | `[261]` **Lileas Graf**: "“I want you to reconsider your p..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capi...` | `[287]` **Gus Manger**: "“Exactly. I like to think of it ..." |
| `[289]` | **"“You may be right. Let's see what the future brings.”"** | `[261]` **Lileas Graf**: "“I want you to reconsider your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Gus Manger**: "“Mr. President. We have made a p..." |
| `[298]` | **"“Time will show if staying neutral will work out.”"** | `[263]` **Lileas Graf**: "“We must be very cautious. There..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Lileas Graf**: "“We must make it work to protect..." |
| `[299]` | **"“Sordland will not be controlled by any nations.”"** | `[263]` **Lileas Graf**: "“We must be very cautious. There..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Lileas Graf**: "“Precisely my point. We will sta..." |
| `[300]` | **"“Exactly. Soll was right all along with his policies.”"** | `[263]` **Lileas Graf**: "“We must be very cautious. There..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...` | `[302]` **Lileas Graf**: "“I am glad we are on the same pa..." |
| `[305]` | **"“I still haven't decided if they wish to come with a deal.”"** | `[263]` **Lileas Graf**: "“We must be very cautious. There..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Lileas Graf**: "“A deal that they would surely c..." |
| `[315]` | **"“The more of the economy we control, the better we can manage the recession.”"** | `[137]` **Narrator**: "Symon nodded."<br>`[138]` **Narrator**: "Symon ignored the statement." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Symon Holl**: "“That is a fair argument to be m..." |
| `[316]` | **"“Economic systems without regulation are bound to fail.”"** | `[137]` **Narrator**: "Symon nodded."<br>`[138]` **Narrator**: "Symon ignored the statement." | `Variable["BaseGame.Promise_Economy_Planned"] == true` | *Brak zmian stanu* | `[320]` **Symon Holl**: "“Obviously there is some regulat..." |
| `[317]` | **"“Humanity in the 20th century is thriving because of the rule of supply and demand.”"** | `[137]` **Narrator**: "Symon nodded."<br>`[138]` **Narrator**: "Symon ignored the statement." | `Variable["BaseGame.Promise_Economy_FreeMarket"] == true` | *Brak zmian stanu* | `[326]` **Symon Holl**: "“Agreed. Look at how quickly Les..." |
| `[345]` | **"“Let's move on to the conclusion.”"** | `[153]` **Narrator**: "Symon put forward a legal docume..."<br>`[186]` **Gus Manger**: "“Only for a limited time, until ..."<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == true` | *Brak zmian stanu* | `[154]` **Symon Holl**: "“What are your final thoughts, M..." |
| `[349]` | **"“No need for questions. I am well aware of the details. Let's move on to our strat..."** | `[10]` **Symon Holl**: "“Since economics is your forte, ..."<br>`[230]` **Symon Holl**: "“What would you like to know abo..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == true) == false` | *Brak zmian stanu* | `[19]` **Narrator**: "Symon scattered the paper stack ..." |
| `[350]` | **"“Here's what we'll do...”"** | `[153]` **Narrator**: "Symon put forward a legal docume..."<br>`[186]` **Gus Manger**: "“Only for a limited time, until ..."<br>*(oraz 5 innych węzłów)* | `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == true) == false` | *Brak zmian stanu* | `[225]` **Player**: "“Promote a free-market economy a..."<br>`[226]` **Player**: "“Promote a planned economy.”"<br>*(oraz 2 innych odgałęzień)* |
| `[351]` | **""You already know what we're going to do.""** | `[154]` **Symon Holl**: "“What are your final thoughts, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Player**: "“Promote a free-market economy a..."<br>`[226]` **Player**: "“Promote a planned economy.”"<br>*(oraz 2 innych odgałęzień)* |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Symon Holl, Gus Manger and Lileas Graf were about to arri..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Symon Holl, Gus Manger and Lileas Graf were about to arrive at the White Room for our scheduled economy meeting. This was the room in the Maroon Palace where all important meetings were held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Gelsord_Infrastructure = true"*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“My staff and I have comprehensively analyzed every aspect of--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "He was interrupted by a groan from one of the assistants ..."*)

### Węzeł `[5]`
Mówca: **Symon Holl**
> "“Oh. You can put that there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "He pointed below the painting of President Soll. The assi..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "He was interrupted by a groan from one of the assistants by the door, both of whom were now visibly struggling to hold up the heavy projector."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Symon Holl: "“Oh. You can put that there.”"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "He pointed below the painting of President Soll. The assistants placed the projector next to the table and installed a white screen on the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Symon Holl: "“Leave now. I mean, thank you and please leave now.”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“What is our GDP and debt situation?”"]** — Mówca: **Player**
> "“What is our GDP and debt situation?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Symon Holl), `[230]` (Symon Holl), `[87]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Symon Holl: "“Our current GDP is 310 billion Sordish Ren and the natio..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“What is our unemployment and inflation rate?”"]** — Mówca: **Player**
> "“What is our unemployment and inflation rate?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Symon Holl), `[230]` (Symon Holl), `[87]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Symon Holl: "“Unemployment has skyrocketed and is now at a staggering ..."*)

### Węzeł `[10]`
Mówca: **Symon Holl**
> "“Since economics is your forte, Mr. Rayne, it is possible that you might already be aware of the data. I can still explain the current economic situation in better detail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "Economy Questions"*)

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“Mr. President? I'm about to explain some very serious data.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "“I am sorry, go ahead.”"*)
  - -> `[13]` (*Player_Italic: "Stay silent."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“I am sorry, go ahead.”"]** — Mówca: **Player**
> "“I am sorry, go ahead.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Symon Holl: "“There have been some developments about the Sordish Ren ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent. Suddenly the mood in the room turned slightly sour."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Symon Holl: "“There have been some developments about the Sordish Ren ..."*)

### Węzeł `[14]`
Mówca: **Symon Holl**
> "“I am very well and motivated, Mr. Rayne. It seems our ministers are feeling the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“Just as expected. How is it going, Gus and Lileas?”"*)
  - -> `[53]` (*Player: ""I can clearly see that. What was that discussion about?""*)
  - -> `[46]` (*Player: "“Great to hear. Let's begin.”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“What is the status of the recession?”"]** — Mówca: **Player**
> "“What is the status of the recession?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Symon Holl), `[230]` (Symon Holl), `[87]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Symon Holl: "“The economy has been in a recession of about -6% in the ..."*)

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“Our current GDP is 310 billion Sordish Ren and the national debt is 427 billion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Gus Manger: "“It's still hard to fathom that we lost nearly 150 billio..."*)

### Węzeł `[17]`
Mówca: **Symon Holl**
> "“The economy has been in a recession of about -6% in the past year. The average GDP has dropped from SR 15,454 per capita to SR 10,359 from 1951 to now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Symon Holl: "“This administration's success depends on our ability to ..."*)

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“Unemployment has skyrocketed and is now at a staggering 16% and the inflation is at a relative high of 10%.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: "“Unemployment is increasing crime and drug use. We need t..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Symon scattered the paper stack in front of him in an orderly manner and took a final look at his notes before clearing his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Symon Holl: "“As you can see, the situation is alarming, but not every..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Economy Questions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true || B..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Economy Questions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "Economy Questions"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I have all the information needed. Let's move on to the economic strategy.”"]** — Mówca: **Player**
> "“I have all the information needed. Let's move on to the economic strategy.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Symon Holl), `[230]` (Symon Holl), `[87]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Symon scattered the paper stack in front of him in an ord..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Yawn."]** — Mówca: **Player_Italic**
> "I yawned. Symon stared at me disapprovingly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Symon Holl: "“Mr. President? I'm about to explain some very serious da..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "Wait."]** — Mówca: **Player_Italic**
> "Lileas leaned to the table and spoke."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lileas Graf: "“Symon, what happened to the new police station construct..."*)

### Węzeł `[25]`
Mówca: **Gus Manger**
> ""Don't be an idiot, Lileas. What about the unemployment crisis the Greater Holsord and Gelsland regions are going through? These areas are our economic heartland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Gus curled his hands into fists. The Minister of Agricult..."*)

### Węzeł `[26]`
Mówca: **Lileas Graf**
> "“Gus, do you really think that such an economically advanced area is more in need of investment than Agnland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Lileas, my Interior Minister, strode in. She was clad in ..."*)

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“Good morning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Good morning, everyone.”"*)
  - -> `[30]` (*Player: "“What is this debate about?”"*)

### Węzeł `[28]`
Mówca: **Narrator**
> "From the hallway, I heard Lileas Graf's voice. She was using the patient, almost motherly tone she often took in heated arguments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lileas Graf: "“Gus, do you really think that such an economically advan..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Symon Holl quickly stepped between the two ministers without looking at either of them. He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Symon Holl: "“Good morning, Mr. President.”"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“What is this debate about?”"]** — Mówca: **Player**
> "“What is this debate about?"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lileas Graf: "“Just a disagreement in internal economic strategy, Presi..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Good morning, everyone.”"]** — Mówca: **Player**
> "“Good morning, everyone. How are you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Symon Holl: "“I am very well and motivated, Mr. Rayne. It seems our mi..."*)

### Węzeł `[32]`
Mówca: **Lileas Graf**
> "“Just a disagreement in internal economic strategy, President Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gus Manger: "“Not sure if I would call it just a disagreement, Lileas.”"*)

### Węzeł `[33]`
Mówca: **Gus Manger**
> "“Not sure if I would call it just a disagreement, Lileas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“Let's begin the presentation.""*)
  - -> `[35]` (*Player: "“Lileas, can you explain the situation?”"*)
  - -> `[40]` (*Player: "“Could you enlighten me, Gus?”"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Let's begin the presentation.""]** — Mówca: **Player**
> "“Let's begin the presentation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Symon Holl: "“Yes. I will move forward with my presentation if no one ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Lileas, can you explain the situation?”"]** — Mówca: **Player**
> "“Lileas, can you explain the situation?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lileas Graf: "“Mr. Manger proposes that we should invest in already dev..."*)

### Węzeł `[36]`
Mówca: **Lileas Graf**
> "“We've already begun restructuring local governments and introducing new safety measures. Off to a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: "“Good. I am confident in your abilities.""*)
  - -> `[48]` (*Player: "“If there is anything you need help with, reach out to me.”"*)

### Węzeł `[37]`
Mówca: **Gus Manger**
> "“It's looking good, sir. Although there seems to be a lot of work that requires attention.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gus Manger: "“Especially about lifting people out of poverty. Certainl..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Just as expected. How is it going, Gus and Lileas?”"]** — Mówca: **Player**
> "“Just as expected of my cabinet. How is it going, Gus and Lileas?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Gus Manger: "“It's looking good, sir. Although there seems to be a lot..."*)

### Węzeł `[39]`
Mówca: **Lileas Graf**
> "“Meanwhile, many cities in Agnland like Lenkurg or Arvory still don't have basic commodities delivered in time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“Gus, what's your take on this?”"*)
  - -> `[63]` (*Player: "“Lileas, could you elaborate?”"*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Could you enlighten me, Gus?”"]** — Mówca: **Player**
> "“Could you enlighten me, Gus?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gus Manger: "“Ms. Graf seeks to focus our economic development in a re..."*)

### Węzeł `[41]`
Mówca: **Gus Manger**
> "“Ms. Graf seeks to focus our economic development in a region where we can't reap the financial benefits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Gus Manger: "“Business leaders are requesting better logistical links ..."*)

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Symon pulled a silk handkerchief out of his pocket and br..."*)

### Węzeł `[43]`
Mówca: **Symon Holl**
> "“Yes. I will move forward with my presentation if no one objects?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: "“Please.”"*)

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“Please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Gus Manger: "“Go ahead.”"*)

### Węzeł `[45]`
Mówca: **Gus Manger**
> "“Go ahead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Symon pulled a silk handkerchief out of his pocket and br..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Great to hear. Let's begin.”"]** — Mówca: **Player**
> "“Great to hear. Let's begin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Symon Holl: "“Of course, Mr. President.”"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Good. I am confident in your abilities.""]** — Mówca: **Player**
> "“Good. I am confident in your abilities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lileas Graf: "“That is appreciated.”"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“If there is anything you need help with, reach out to me.”"]** — Mówca: **Player**
> "“If there is anything you need help with, reach out to me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Gus Manger: "“Of course, Mr. President.”"*)

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“Good to know.”"*)

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“Good to know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Symon Holl: "“Thank you, Mr. President. Now I would like to show you t..."*)

### Węzeł `[51]`
Mówca: **Lileas Graf**
> "“That is appreciated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gus Manger: "“We will not disappoint you.”"*)

### Węzeł `[52]`
Mówca: **Gus Manger**
> "“We will not disappoint you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Symon Holl: "“Thank you, Mr. President. Now I would like to show you t..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""I can clearly see that. What was that discussion about?""]** — Mówca: **Player**
> ""I can clearly see that. What was that discussion about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Gus Manger: "“We were having a discussion about the infrastructure pla..."*)

### Węzeł `[54]`
Mówca: **Gus Manger**
> "“We were having a discussion about the infrastructure plans. If I may, I would like to talk to you about the-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Symon interrupted."*)

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“Thank you, Mr. President. Now I would like to show you the latest economic situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Symon pulled a silk handkerchief out of his pocket and br..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Symon started looking for his slides. He always carried documentation around with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Italic: "Wait."*)
  - -> `[23]` (*Player_Italic: "Yawn."*)

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“Leave now. I mean, thank you and please leave now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "The assistants left the cabinet room. I was reminded that..."*)

### Węzeł `[58]`
Mówca: **Symon Holl**
> "“First, I would like to conduct my economy presentation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“I am interested in what Gus has to say.”"*)
  - -> `[90]` (*Player: "“Let's begin.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Gus, what's your take on this?”"]** — Mówca: **Player**
> "“Gus, what's your take on this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Gus Manger: "“Sir, I have some very good construction companies willin..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "The assistants left the cabinet room. I was reminded that Symon had never quite had a way with people. But his facility with numbers had made him the most sought-after economic specialist in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Symon started looking for his slides. He always carried d..."*)

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“A wise idea, if your main agenda is to make money instead of developing the region and serving the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“Lileas, could you watch your tone?”"*)
  - -> `[63]` (*Player: "“Lileas, could you elaborate?”"*)

### Węzeł `[62]`
Mówca: **Gus Manger**
> "“Sir, I have some very good construction companies willing to take government contracts in Greater Holsord and Gelsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Gus Manger: "“This would boost the rural economy. I think it would be ..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Lileas, could you elaborate?”"]** — Mówca: **Player**
> "“Lileas, could you elaborate?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lileas Graf), `[61]` (Lileas Graf), `[65]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lileas Graf: "“Of course. The argument is simple. Agnland is our weakes..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Lileas, could you watch your tone?”"]** — Mówca: **Player**
> "“Lileas, could you watch your tone?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lileas Graf: "“Pardon me, Mr. President. I just want the best for the c..."*)

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“Pardon me, Mr. President. I just want the best for the city of Arvory and the Agnland region in general.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "“What are your thoughts, Symon?”"*)
  - -> `[68]` (*Player: "“I agree, Agnland needs investment.”"*)
  - -> `[63]` (*Player: "“Lileas, could you elaborate?”"*)

### Węzeł `[66]`
Mówca: **Lileas Graf**
> "“Of course. The argument is simple. Agnland is our weakest region both in terms of economic and social support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lileas Graf: "“We should support the city of Arvory and its respected m..."*)

### Węzeł `[67]`
Mówca: **Gus Manger**
> "“How impartial can you really be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Symon was observing the argument."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I agree, Agnland needs investment.”"]** — Mówca: **Player**
> "“I agree, Agnland needs investment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Lileas Graf), `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Lileas smiled and folded her hands primly."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Why are you questioning her impartiality?”"]** — Mówca: **Player**
> "“Why are you questioning her impartiality?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Gus Manger: "“This snake of a woman is the former mayor of Arvory, and..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Symon was observing the argument."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "“What are your thoughts, Symon?”"*)
  - -> `[68]` (*Player: "“I agree, Agnland needs investment.”"*)
  - -> `[69]` (*Player: "“Why are you questioning her impartiality?”"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“What are your thoughts, Symon?”"]** — Mówca: **Player**
> "“What are your thoughts, Symon?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Lileas Graf), `[70]` (Narrator), `[97]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Symon Holl: "“I have to say that I agree with both of them. Agnland is..."*)

### Węzeł `[72]`
Mówca: **Symon Holl**
> "“I have to say that I agree with both of them. Agnland is in need of investment, and we can improve Greater Holsord and Gelsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Symon Holl: "“I want to avoid this topic now since we will talk about ..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Symon stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Symon Holl: "“I would like to put a stop to this debate. We will discu..."*)

### Węzeł `[74]`
Mówca: **Gus Manger**
> "“This snake of a woman is the former mayor of Arvory, and Eric Niel is her successor. Her argument could be biased.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: "“Gus, dear, my arguments are proven by simple economic da..."*)

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“Gus, dear, my arguments are proven by simple economic data. Our poorest and least developed region is Agnland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lileas Graf: "“The facts are clear. But it seems to me that you'd rathe..."*)

### Węzeł `[76]`
Mówca: **Lileas Graf**
> "“The facts are clear. But it seems to me that you'd rather resort to name-calling to push your agenda.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Gus Manger: "“The figures are being skewed in Nargis to make it look l..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Lileas smiled and folded her hands primly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Symon Holl: "“I have to say that I agree with both of them. Agnland is..."*)

### Węzeł `[78]`
Mówca: **Symon Holl**
> "“I want to avoid this topic now since we will talk about it in the future. I would rather first fully brief you on our current economic situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Symon pulled a silk handkerchief out of his pocket and br..."*)

### Węzeł `[79]`
Mówca: **Gus Manger**
> "“The figures are being skewed in Nargis to make it look like a developed region, for example. In truth, it is the poorest region of all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Symon stepped in."*)

### Węzeł `[80]`
Mówca: **Symon Holl**
> "“I would like to put a stop to this debate. We will discuss it all calmly and logically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Lileas and Gus went silent."*)

### Węzeł `[81]`
Mówca: **Lileas Graf**
> "“Symon, what happened to the new police station construction in Estord?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "While going through his briefcase, he paused for a moment..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "While going through his briefcase, he paused for a moment to answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Symon Holl: "“It got stalled due to a government property boundary iss..."*)

### Węzeł `[83]`
Mówca: **Symon Holl**
> "“It got stalled due to a government property boundary issue. I have been meaning to look at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lileas Graf: "“I can take a look at that one. Estord needs all the secu..."*)

### Węzeł `[84]`
Mówca: **Lileas Graf**
> "“I can take a look at that one. Estord needs all the security help it can get.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Symon Holl: "“Sure. More time for me to spend on analyses.”"*)

### Węzeł `[85]`
Mówca: **Symon Holl**
> "“Sure. More time for me to spend on analyses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "His eyes glittered when he finally found the slides he we..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "His eyes glittered when he finally found the slides he were looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Symon Holl: "“There have been some developments about the Sordish Ren ..."*)

### Węzeł `[87]`
Mówca: **Gus Manger**
> "“It's still hard to fathom that we lost nearly 150 billion in wealth. The past three years were tough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP = true"*)

### Węzeł `[88]`
Mówca: **Lileas Graf**
> "“Unemployment is increasing crime and drug use. We need to get people off the streets. The inflation isn't helping our average citizen either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP = true"*)

### Węzeł `[89]`
Mówca: **Symon Holl**
> "“This administration's success depends on our ability to stop the recession. The sooner we can reach GDP growth the better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL = true"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Let's begin.”"]** — Mówca: **Player**
> "“Let's begin. I am looking forward to this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Symon pulled a silk handkerchief out of his pocket and br..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“I am interested in what Gus has to say.”"]** — Mówca: **Player**
> "“I am interested in what Gus has to say.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Symon Holl: "“Of course, Mr. President.”"*)

### Węzeł `[92]`
Mówca: **Symon Holl**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Gus Manger: "“Sir, I have some very good construction companies willin..."*)

### Węzeł `[93]`
Mówca: **Gus Manger**
> "“Sir, I have some very good construction companies willing to take government contracts in the Greater Holsord and Gelsland regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gus Manger: "“This would boost the rural economy. I think it would be ..."*)

### Węzeł `[94]`
Mówca: **Gus Manger**
> "“This would boost the rural economy. I think it would be wise to pick investments that will go through these regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "“This seems like a good opportunity.”"*)
  - -> `[96]` (*Player: "“No need to rush this, Gus. We will figure it out.”"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“This seems like a good opportunity.”"]** — Mówca: **Player**
> "“This seems like a good opportunity.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Gus Manger: "“Right? Additionally, we can...”"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“No need to rush this, Gus. We will figure it out.”"]** — Mówca: **Player**
> "“No need to rush this, Gus. We will figure it out.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Symon pulled a silk handkerchief out of his pocket and br..."*)

### Węzeł `[97]`
Mówca: **Gus Manger**
> "“This would boost the rural economy. I think it would be wise to pick investments that will go through these regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player: "“I agree that the countryside needs investment.”"*)
  - -> `[71]` (*Player: "“What are your thoughts, Symon?”"*)
  - -> `[104]` (*Player: "“Lileas, what are your thoughts on this proposition?”"*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“I agree that the countryside needs investment.”"]** — Mówca: **Player**
> "“I agree that the Greater Holsord and Gelsland countryside needs investment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Gus smirked."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Gus smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Symon Holl: "“I have to say that I agree with both of them. Agnland is..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Lileas and Gus went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Symon pulled a silk handkerchief out of his pocket and br..."*)

### Węzeł `[101]`
Mówca: **Gus Manger**
> "“Right? Additionally, we can...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Lileas interrupted him."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Lileas interrupted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lileas Graf: "“A wise idea, if your main agenda..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lileas Graf: "“A wise idea, if your main agenda i..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lileas Graf: "“A wise idea, if your main agenda is to make money instea..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Lileas, what are your thoughts on this proposition?”"]** — Mówca: **Player**
> "“Lileas, what are your thoughts on this proposition? Can you explain your point?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lileas Graf: "“Of course. The argument is simple. Agnland is our weakes..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn01_EnT_EconomicOverview = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn01_EnT_EconomicOverview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_E_ArmadineElectronics = true;..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“What is our GDP and debt situation?”"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Questions]"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Questions]"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Questions]"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“What is our unemployment and inflation rate?”"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“What is the status of the recession?”"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true || B..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true ||..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“I have all the information needed. Let's move on to the ..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP == true || BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player: "“No need for questions. I am well aware of the details. L..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Symon Holl: "“One of our main promises was to promote a free-market ec..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Symon Holl: "“One of our main promises was to promote a planned econom..."*)

### Węzeł `[124]`
Mówca: **Symon Holl**
> "“One of our main promises was to promote a planned economy to stop the recession. To be frank, I still don't think this was a good idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gus Manger: "“We shouldn't go back to Sollonomics. It is the reason fo..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Promote a free-market economy.”"]** — Mówca: **Player**
> "“Promote a free-market economy.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Symon Holl), `[350]` (Player), `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Abandoned_Planned = true"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Promote a planned economy as we promised.”"]** — Mówca: **Player**
> "“Promote a planned economy as we promised.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Symon Holl), `[350]` (Player), `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Planned_Economy = true; Ba..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket = true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromotePlanned = true"*)

### Węzeł `[129]`
Mówca: **Symon Holl**
> "“So, what will our general economic plan promote?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[130]`
Mówca: **Lileas Graf**
> "“I still do not support it. Why promote the private sector when we have qualified state-owned enterprises?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Gus Manger: "“Because the lack of competition has made them inefficient.”"*)

### Węzeł `[131]`
Mówca: **Gus Manger**
> "“We shouldn't go back to Sollonomics. It is the reason for the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lileas Graf: "“Self-sufficiency will help us in tough times.”"*)

### Węzeł `[132]`
Mówca: **Lileas Graf**
> "“I can't say that I agree with this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Lileas looked displeased."*)

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“Not sure if we made the right decision here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Gus looked worried."*)

### Węzeł `[134]`
Mówca: **Symon Holl**
> "“Now that there is clarity on which direction we are heading. I will work on a good plan accordingly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Symon Holl: "“This concludes our meeting. At our next gathering we wil..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromoteMarket = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_PromotedMarketEconomy = true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromotePlanned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_PromotedPlannedEconomy = true"*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Symon nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)
  - -> `[139]` (*Player: "“What are the consequences of the free-market?”"*)
  - -> `[315]` (*Player: "“The more of the economy we control, the better we can ma..."*)
  - -> `[142]` (*Player: "“What are the downsides of the planned economy?”"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Symon ignored the statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)
  - -> `[139]` (*Player: "“What are the consequences of the free-market?”"*)
  - -> `[315]` (*Player: "“The more of the economy we control, the better we can ma..."*)
  - -> `[142]` (*Player: "“What are the downsides of the planned economy?”"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“What are the consequences of the free-market?”"]** — Mówca: **Player**
> "“What are some of the consequences of the free-market strategy?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator), `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Symon Holl: "“There are not many but one could say that we are much mo..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“What's on our long-term economic schedule?”"]** — Mówca: **Player**
> "“What's on our long-term economic schedule?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false` AND `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Symon Holl: "“Choosing construction contractors, trade relations, tax ..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“What's on our long-term economic schedule?”"]** — Mówca: **Player**
> "“What's on our long-term economic schedule?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false` AND `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Symon Holl: "“Picking a construction company, trade relations, tax ref..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“What are the downsides of the planned economy?”"]** — Mówca: **Player**
> "“What are the downsides of the planned economy strategy?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator), `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Symon Holl: "“It is clear that most of the state corporations and othe..."*)

### Węzeł `[143]`
Mówca: **Symon Holl**
> "“Choosing construction contractors, trade relations, tax reform and privatization initiatives would be some of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lileas Graf: "“Sticking to a solid planned economy strategy will be the..."*)

### Węzeł `[144]`
Mówca: **Symon Holl**
> "“There are not many but one could say that we are much more likely to be influenced by the world economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Gus Manger: "“It is important to think about this subject because the ..."*)

### Węzeł `[145]`
Mówca: **Symon Holl**
> "“The structural problems of Sollonomics were going to lead to a recession according to the predictions at the time anyway. Either way, even if we pick one of the doctrines, we retain the option to make economic choices on a case-by-case basis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lileas Graf: "“That is, however, not recommended in my point of view. T..."*)

### Węzeł `[146]`
Mówca: **Symon Holl**
> "“It is clear that most of the state corporations and other government controlled systems are less efficient.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lileas Graf: "“The government of Sordland and its institutions or corpo..."*)

### Węzeł `[147]`
Mówca: **Symon Holl**
> "“Picking a construction company, trade relations, tax reform and welfare privatization or nationalization initiatives would be some of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Gus Manger: "“We must choose wisely and remember that the free-market ..."*)

### Węzeł `[148]`
Mówca: **Lileas Graf**
> "“Sticking to a solid planned economy strategy will be the right call. The five-year plans were fruitful in the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Examples = true"*)

### Węzeł `[149]`
Mówca: **Gus Manger**
> "“It is important to think about this subject because the upswings of the world economy will reflect good on ours too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lileas Graf: "“Yes... And when the global economy crashes, we go down w..."*)

### Węzeł `[150]`
Mówca: **Lileas Graf**
> "“That is, however, not recommended in my point of view. The last thing we need is a chaotic economic plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Gus Manger: "“Finally something we can both agree on, Lileas.”"*)

### Węzeł `[151]`
Mówca: **Lileas Graf**
> "“The government of Sordland and its institutions or corporations have a solid history of delivering.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Symon Holl: "“The structural problems of Sollonomics were going to lea..."*)

### Węzeł `[152]`
Mówca: **Gus Manger**
> "“We must choose wisely and remember that the free-market economy in all forms is the future of the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lileas Graf: "“I wouldn't be so sure.”"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Symon put forward a legal document outlining the possibilities with both economic doctrines listed. The cabinet members looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "Economy Doctrine Hub"*)

### Węzeł `[154]`
Mówca: **Symon Holl**
> "“What are your final thoughts, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player: "“Critical institutions must remain in state control. We m..."*)
  - -> `[158]` (*Player: "“We should look at opportunities like privatization to cr..."*)
  - -> `[236]` (*Player: "“A market economy doesn't require as much guidance and co..."*)
  - -> `[159]` (*Player: "“It is hard to fully agree or disagree with these options.”"*)
  - -> `[351]` (*Player: ""You already know what we're going to do.""*)

### Węzeł `[155]`
Mówca: **Lileas Graf**
> "“Self-sufficiency will help us in tough times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Symon ignored the statement."*)

### Węzeł `[156]`
Mówca: **Gus Manger**
> "“Because the lack of competition has made them inefficient.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Symon nodded."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "“Critical institutions must remain in state control. We must be fully responsible in delivering services.”"]** — Mówca: **Player**
> "“Critical institutions must remain in state control. We must be fully responsible in delivering services.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Symon Holl: "“A market economy doesn't mean privatization of every sin..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“We should look at opportunities like privatization to create financial resources.”"]** — Mówca: **Player**
> "“We should look at opportunities like privatization to create financial resources.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Symon Holl: "“This is exactly my mentality. There are many possibiliti..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "“It is hard to fully agree or disagree with these options.”"]** — Mówca: **Player**
> "“It is hard to fully agree or disagree with these options.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Symon Holl: "“It's a difficult position to be in, Mr. President. But y..."*)

### Węzeł `[160]`
Mówca: **Symon Holl**
> "“A market economy doesn't mean privatization of every single institution. But either way, you make the choices.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Symon Holl: "“So, what will our general economic plan promote?”"*)

### Węzeł `[161]`
Mówca: **Symon Holl**
> "“This is exactly my mentality. There are many possibilities that are waiting, like education or health privatization. It would be better to promote a market economy for these to have consistency with our plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Symon Holl: "“So, what will our general economic plan promote?”"*)

### Węzeł `[162]`
Mówca: **Symon Holl**
> "“It's a difficult position to be in, Mr. President. But your final say is what counts. Remember, this is the overall strategic direction. Our ability to make individual economic decisions still remains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Symon Holl: "“So, what will our general economic plan promote?”"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Now that the economic direction was decided upon, the ministers dispersed for lunch at the Maroon Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Sarna_AgricultureGrows = tr..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Two assistants arrived first, carrying a heavy projector. They stood with it by the door, waiting for the ministers to enter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "From the hallway, I heard Lileas Graf's voice. She was us..."*)

### Węzeł `[165]`
Mówca: **Symon Holl**
> "“We will get there, Gus. No rush.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Symon Holl: "“First, I would like to conduct my economy presentation.”"*)

### Węzeł `[166]`
Mówca: **Gus Manger**
> "“Especially about lifting people out of poverty. Certainly, a challenge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lileas Graf: "“I am feeling fairly confident about the current state of..."*)

### Węzeł `[167]`
Mówca: **Lileas Graf**
> "“I am feeling fairly confident about the current state of affairs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lileas Graf: "“We've already begun restructuring local governments and ..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "Symon interrupted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Symon Holl: "“We will get there, Gus. No rush.”"*)

### Węzeł `[169]`
Mówca: **Lileas Graf**
> "“Mr. Manger proposes that we should invest in already developed regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lileas Graf: "“Meanwhile, many cities in Agnland like Lenkurg or Arvory..."*)

### Węzeł `[170]`
Mówca: **Lileas Graf**
> "“We should support the city of Arvory and its respected mayor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Gus Manger: "“How impartial can you really be?”"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Examples == false"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Superpower == false"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Superpower == false"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Examples == false"*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Would a free-market focus bring us stronger allies?”"]** — Mówca: **Player**
> "“Would a free-market focus bring us stronger allies?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false` AND `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Gus Manger: "“It would make Arcasia look at our country in a more posi..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Would a planned economy focus bring us stronger allies?”"]** — Mówca: **Player**
> "“Would a planned economy focus bring us stronger allies?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false` AND `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lileas Graf: "“Diplomatically, it would make United Contana look at our..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "“We have to thank Soll and his planned economy for the boom. It clearly shows the success of the system.”"]** — Mówca: **Player**
> "“We have to thank Soll and his planned economy for the boom. It clearly shows the success of the system.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator), `[186]` (Gus Manger), `[221]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lileas Graf: "“Precisely the reason why we should stick to the old syst..."*)

### Węzeł `[177]`
Mówca: **Symon Holl**
> "“This concludes our meeting. At our next gathering we will talk about the upcoming infrastructure investment plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Now that the economic direction was decided upon, the min..."*)

### Węzeł `[178]`
Mówca: **Lileas Graf**
> "“Diplomatically, it would make United Contana look at our country in a more positive light. They are proponents of the planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Symon Holl: "“Whatever that's worth. The influence Arcasia has on the ..."*)

### Węzeł `[179]`
Mówca: **Gus Manger**
> "“It would make Arcasia look at our country in a more positive light. They are proponents of the free-market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Symon Holl: "“The influence Arcasia has on the world economy is extens..."*)

### Węzeł `[180]`
Mówca: **Symon Holl**
> "“The influence Arcasia has on the world economy is extensive. Our economic strategy should be based on internal reasoning though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Superpower = true"*)

### Węzeł `[181]`
Mówca: **Symon Holl**
> "“Whatever that's worth. The influence Arcasia has on the world economy is extensive. Our economic strategy should be based on internal reasoning, though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Superpower = true"*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "“Let's finish what Alphonso started with the capitalist free-market reforms. His path was going to enrich Sordland.”"]** — Mówca: **Player**
> "“Let's finish what Alphonso started with the capitalist free-market reforms. His path was going to enrich Sordland.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator), `[186]` (Gus Manger), `[221]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Lileas Graf: "“The recession was the direct result of his free-market r..."*)

### Węzeł `[183]`
Mówca: **Lileas Graf**
> "“Precisely the reason why we should stick to the old system. State planning and regulation both showed great success in the 30s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Gus Manger: "“Only for a limited time, until even Tarquin Soll himself..."*)

### Węzeł `[184]`
Mówca: **Gus Manger**
> "“History must note that the reason for the recession was because Ewald Alphonso was betrayed by his party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lileas Graf: "“That is not true, there was plenty of time for him to do..."*)

### Węzeł `[185]`
Mówca: **Lileas Graf**
> "“The recession was the direct result of his free-market reforms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Gus Manger: "“History must note that the reason for the recession was ..."*)

### Węzeł `[186]`
Mówca: **Gus Manger**
> "“Only for a limited time, until even Tarquin Soll himself discovered the limits of the system. The slowdown began during his rule, remember?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Soll = true"*)

### Węzeł `[187]`
Mówca: **Narrator**
> "Gus looked worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Symon Holl: "“Now that there is clarity on which direction we are head..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Lileas looked displeased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Symon Holl: "“Now that there is clarity on which direction we are head..."*)

### Węzeł `[189]`
Mówca: **Lileas Graf**
> "“Yes... And when the global economy crashes, we go down with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Symon Holl: "“The structural problems of Sollonomics were going to lea..."*)

### Węzeł `[190]`
Mówca: **Lileas Graf**
> "“I wouldn't be so sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Examples = true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Economy Doctrine Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false &&..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false &&..."*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Superpower == true |..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Superpower == true || BaseGameIsolated.Turn01_EnT_Listened_Examples == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Superpower == true |..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Superpower == true..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Superpower == true || BaseGameIsolated.Turn01_EnT_Listened_Examples == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player: "“Let's move on to the conclusion.”"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Superpower == true || BaseGameIsolated.Turn01_EnT_Listened_Examples == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player: "“Here's what we'll do...”"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Soll = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Doctrine Hub]"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Alphonso = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Doctrine Hub]"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Superpower = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Doctrine Hub]"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Examples = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Doctrine Hub]"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Examples = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Doctrine Hub]"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Superpower = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [Economy Doctrine Hub]"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Economy Doctrine Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "Economy Doctrine Hub"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false &&..."*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false ..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: "“We have to thank Soll and his planned economy for the bo..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false &&..."*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: "“Let's finish what Alphonso started with the capitalist f..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Alphonso == false && BaseGameIsolated.Turn01_EnT_Listened_Soll == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Alphonso"] == false  and  Variable["BaseGameIsolated.Turn01_EnT_Listened_Soll"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Superpower == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Superpower == false"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Superpower == false)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Superpower == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: "“Would a planned economy focus bring us stronger allies?”"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Superpower == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Examples == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Examples == false"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Examples == false)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Examples == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“What's on our long-term economic schedule?”"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Examples == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Examples == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Examples == false"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Examples == false)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Examples == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: "“What's on our long-term economic schedule?”"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Examples == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Superpower == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Superpower == false"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_EnT_Listened_Superpower == false)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_EnT_Listened_Superpower == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "“Would a free-market focus bring us stronger allies?”"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_EnT_Listened_Superpower == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[220]`
Mówca: **Gus Manger**
> "“Finally something we can both agree on, Lileas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Lileas Graf: "“There is another important factor which has a direct imp..."*)

### Węzeł `[221]`
Mówca: **Lileas Graf**
> "“That is not true, there was plenty of time for him to do it. If you can't make change happen in two years then you are at fault.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_EnT_Listened_Alphonso = true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: "“Promote a free-market economy as we promised.”"*)
  - -> `[226]` (*Player: "“Promote a planned economy.”"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“Promote a free-market economy.”"*)
  - -> `[126]` (*Player: "“Promote a planned economy as we promised.”"*)

### Węzeł `[225]`
**[WYBÓR GRACZA: "“Promote a free-market economy as we promised.”"]** — Mówca: **Player**
> "“Promote a free-market economy as we promised.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Symon Holl), `[350]` (Player), `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Market_Economy = true; Bas..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "“Promote a planned economy.”"]** — Mówca: **Player**
> "“Promote a planned economy.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Symon Holl), `[350]` (Player), `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Abandoned_FreeMarket = true"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Symon Holl: "“Since economics is your forte, Mr. Rayne, it is possible..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Symon Holl: "“What would you like to know about the current economic s..."*)

### Węzeł `[230]`
Mówca: **Symon Holl**
> "“What would you like to know about the current economic situation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "Economy Questions"*)

### Węzeł `[231]`
Mówca: **Narrator**
> "The Recession of '51 put enormous pressure on the economy, resulting in the collapse of the value of our currency. The entire situation was a significant cause of concern for our administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)

### Węzeł `[232]`
Mówca: **Symon Holl**
> "“There have been some developments about the Sordish Ren losing further value today. We have been trying to stabilize it with the Central Bank.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_R_NationalistViolence = true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist -= 3;
BaseGame.Malenyevist += 5;
BaseGame.Sollist += 3;
BaseGame.Economy += 1;
BaseGame.EconomyDirection_Scale -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 3;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 5;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 3;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned = true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist += 5;
BaseGame.Malenyevist -= 3;
BaseGame.Sollist -= 3;
BaseGame.EconomyDirection_Scale += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 5;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 3;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market = true"*)

### Węzeł `[235]`
Mówca: **Gus Manger**
> "“Business leaders are requesting better logistical links in order to contribute to the economy more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lileas Graf: "“A wise idea, if your main agenda is to make money instea..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA: "“A market economy doesn't require as much guidance and could help us attract foreign capital.”"]** — Mówca: **Player**
> "“A market economy doesn't require as much guidance and could help us attract foreign capital.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Symon Holl: "“Especially from Arcasia. President Walker is always inte..."*)

### Węzeł `[237]`
Mówca: **Symon Holl**
> "“Especially from Arcasia. President Walker is always interested in expanding the economic zone of ATO. We could secure lucrative investments from capitalist countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Symon Holl: "“So, what will our general economic plan promote?”"*)

### Węzeł `[238]`
Mówca: **Narrator**
> "Lileas, my Interior Minister, strode in. She was clad in shades of brown and beige, the only spot of color a bright yellow Dastnurist cross on her necklace. Gus followed close behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Gus Manger: ""Don't be an idiot, Lileas. What about the unemployment c..."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "Gus curled his hands into fists. The Minister of Agriculture and Rural Development's temper hadn't changed since his days in the Alphonso administration, but neither had his reputation for getting things done. His far-reaching network of connections was unlike any other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Symon Holl quickly stepped between the two ministers with..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Abandoned_FreeMarket = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Abandoned_FreeMarket"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist -= 3; BaseGame.Malenyevist += 5; Base..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Planned_Economy = true;
BaseGame.EconomyDirection_Scale -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Planned_Economy"] = true;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist -= 3; BaseGame.Malenyevist += 5; Base..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Abandoned_Planned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Abandoned_Planned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 5; BaseGame.Malenyevist -= 3; Base..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Market_Economy = true;
BaseGame.EconomyDirection_Scale += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Market_Economy"] = true;
Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 5; BaseGame.Malenyevist -= 3; Base..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_LT_FreezingWeather = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_LT_FreezingWeather"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Two assistants arrived first, carrying a heavy projector...."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_R_NationalistViolence = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_R_NationalistViolence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "The Recession of '51 put enormous pressure on the economy..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Gelsord_Infrastructure = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Gelsord_Infrastructure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Lenkurg_Infrastructure = true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Lenkurg_Infrastructure = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Lenkurg_Infrastructure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_LT_FreezingWeather = true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Sarna_AgricultureGrows = true;
BaseGameSupport.FactionReport_Turn01_CSP_AnrakaNAP = true;
BaseGameSupport.Report_Turn01_Morna_IncreasingUnemployment = true;
BaseGameSupport.CountryReport_Turn01_Rizia_ElectionWinCongratulation = true;
BaseGameSupport.News_Turn01_ST_GasomPromotion = true;
BaseGameSupport.News_Turn01_HP_TourismBill_GNAWork = true;
BaseGameSupport.News_Turn01_R_AlphonsoLeavesLotherberg = true;
BaseGameSupport.Report_Turn01_Borin_DemandForWines = true;
BaseGameSupport.Report_Turn01_Lachaven_GasomSeaRig = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Sarna_AgricultureGrows"] = true;
Variable["BaseGameSupport.FactionReport_Turn01_CSP_AnrakaNAP"] = true;
Variable["BaseGameSupport.Report_Turn01_Morna_IncreasingUnemployment"] = true;
Variable["BaseGameSupport.CountryReport_Turn01_Rizia_ElectionWinCongratulation"] = true;
Variable["BaseGameSupport.News_Turn01_ST_GasomPromotion"] = true;
Variable["BaseGameSupport.News_Turn01_HP_TourismBill_GNAWork"] = true;
Variable["BaseGameSupport.News_Turn01_R_AlphonsoLeavesLotherberg"] = true;
Variable["BaseGameSupport.Report_Turn01_Borin_DemandForWines"] = true;
Variable["BaseGameSupport.Report_Turn01_Lachaven_GasomSeaRig"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth < 3"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_PromotedMarketEconomy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_PromotedMarketEconomy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lileas Graf: "“I can't say that I agree with this.”"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_PromotedPlannedEconomy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_PromotedPlannedEconomy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Gus Manger: "“Not sure if we made the right decision here.”"*)

### Węzeł `[251]`
Mówca: **Symon Holl**
> "“One of our main promises was to promote a free-market economy to stop the recession. To be frank, I believe it is the only way out of the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lileas Graf: "“I still do not support it. Why promote the private secto..."*)

### Węzeł `[252]`
Mówca: **Lileas Graf**
> "“There is another important factor which has a direct impact on our economy. Superpowers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Lileas Graf: "“We might have won the election but I am still against al..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Lileas Graf: "“We might have won the election, but I am still against a..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Lileas Graf: "“We have done well not aligning ourselves with any one of..."*)

### Węzeł `[259]`
Mówca: **Lileas Graf**
> "“We might have won the election but I am still against aligning ourselves with the superpowers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Symon Holl: "“Economically speaking, we aren't as tied to United Conta..."*)

### Węzeł `[260]`
Mówca: **Lileas Graf**
> "“We might have won the election, but I am still against aligning ourselves with any superpowers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Symon Holl: "“Economically speaking, we are much closer to Arcasia tha..."*)

### Węzeł `[261]`
Mówca: **Lileas Graf**
> "“I want you to reconsider your promise to align with Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: "“I have made a promise to the people of Sordland. I won't..."*)
  - -> `[281]` (*Player: "“Don't worry. I won't let Arcasia control Sordland.”"*)
  - -> `[282]` (*Player: "“Entering the sphere of Arcasia will help boost our econo..."*)
  - -> `[289]` (*Player: "“You may be right. Let's see what the future brings.”"*)

### Węzeł `[262]`
Mówca: **Lileas Graf**
> "“We have done well not aligning ourselves with any one of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Symon Holl: "“Economically speaking, an isolationist policy overall co..."*)

### Węzeł `[263]`
Mówca: **Lileas Graf**
> "“We must be very cautious. There are schemes being devised about Sordland. We can not give in to their wants now or in the future. Otherwise our country will turn into a pawn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player: "“Sordland will not be controlled by any nations.”"*)
  - -> `[300]` (*Player: "“Exactly. Soll was right all along with his policies.”"*)
  - -> `[305]` (*Player: "“I still haven't decided if they wish to come with a deal.”"*)
  - -> `[298]` (*Player: "“Time will show if staying neutral will work out.”"*)

### Węzeł `[264]`
**[WYBÓR GRACZA: "“Don't worry. I won't let United Contana control Sordland.”"]** — Mówca: **Player**
> "“Don't worry. I won't let United Contana control Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Gus Manger: "“I hope we can show and not tell.”"*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "“I have made a promise to the people of Sordland. I won't back down.”"]** — Mówca: **Player**
> "“I have made a promise to the people of Sordland. I won't back down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Gus Manger: "“I must also insist. Nothing good will come out of siding..."*)

### Węzeł `[266]`
Mówca: **Lileas Graf**
> "“We must be very cautious. There are schemes being devised about Sordland. We can not give in to their wants now or in the future. Otherwise our country will turn into a pawn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Lileas Graf: "“I want you to reconsider your promise to align with Unit..."*)

### Węzeł `[267]`
Mówca: **Lileas Graf**
> "“I want you to reconsider your promise to align with United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player: "“I have made a promise to the people of Sordland. I won't..."*)
  - -> `[264]` (*Player: "“Don't worry. I won't let United Contana control Sordland.”"*)
  - -> `[269]` (*Player: "“There is a revolution that was started by United Contana..."*)
  - -> `[272]` (*Player: "“You may be right. Let's see what the future brings.”"*)

### Węzeł `[268]`
Mówca: **Lileas Graf**
> "“We must be very cautious. There are schemes being devised about Sordland. We can not give in to their wants now or in the future. Otherwise our country will turn into a pawn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lileas Graf: "“I want you to reconsider your promise to align with Arca..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA: "“There is a revolution that was started by United Contana. A permanent revolution. And Sordland must be part of it.”"]** — Mówca: **Player**
> "“There is a revolution that was started by United Contana. A permanent revolution. And Sordland must be part of it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1"*)

### Węzeł `[270]`
Mówca: **Gus Manger**
> "“I hope we can show and not tell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[271]`
Mówca: **Gus Manger**
> "“I must also insist. Nothing good will come out of siding with United Contana. Aligning with them may make us adversaries to Arcasia, a much more influential nation in my view.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Lileas Graf: "“Although not for the same reasons, that's two things we ..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA: "“You may be right. Let's see what the future brings.”"]** — Mówca: **Player**
> "“You may be right. Let's see what the future brings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Gus Manger: "“I am also with Lileas on this one. Nothing good will com..."*)

### Węzeł `[273]`
Mówca: **Gus Manger**
> "“We will see how long it will last.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Gus Manger: "“We will see how long it will last.”"*)

### Węzeł `[275]`
Mówca: **Gus Manger**
> "“I am also with Lileas on this one. Nothing good will come out of siding with United Contana. Aligning with them may make us adversaries to Arcasia, a much more influential nation in my view.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Lileas Graf: "“Although not for the same reasons, that's two things we ..."*)

### Węzeł `[276]`
Mówca: **Lileas Graf**
> "“Although not for the same reasons, that's two things we are agreeing on today, Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Symon cleared his throat again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Symon Holl: "“Let's not get ahead of ourselves. Minister Wisci will be..."*)

### Węzeł `[278]`
Mówca: **Symon Holl**
> "“Let's not get ahead of ourselves. Minister Wisci will be in charge of informing you on those types of foreign policy decisions. We must first decide on our internal economic plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Symon put forward a legal document outlining the possibil..."*)

### Węzeł `[279]`
Mówca: **Lileas Graf**
> "“Although not for the same reasons, that's two things we are agreeing on today, Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA: "“I have made a promise to the people of Sordland. I won't back down.”"]** — Mówca: **Player**
> "“I have made a promise to the people of Sordland. I won't back down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Gus Manger: "“Exactly. We have made a promise. People want to trust th..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA: "“Don't worry. I won't let Arcasia control Sordland.”"]** — Mówca: **Player**
> "“Don't worry. I won't let Arcasia control Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Gus Manger: "“Control? No, Mr. President, it's simply a partnership. A..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA: "“Entering the sphere of Arcasia will help boost our economy in many ways. They are wealthy and influential.”"]** — Mówca: **Player**
> "“Entering the sphere of Arcasia will help boost our economy in many ways. They are wealthy and influential.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 1"*)

### Węzeł `[283]`
Mówca: **Gus Manger**
> "“Control? No, Mr. President, it's simply a partnership. And a very valuable one at that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Lileas Graf: "“Valuable for Arcasia maybe. Not for Sordland.”"*)

### Węzeł `[284]`
Mówca: **Lileas Graf**
> "“When the time comes, I hope you will make the right decision. For our own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Gus Manger: "“We should attract more foreign direct investment. Mr. Pr..."*)

### Węzeł `[285]`
Mówca: **Gus Manger**
> "“Exactly. We have made a promise. People want to trust their President. What kind of an example we would set for the future generations if we were to back down on our promises?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Gus Manger: "“Also, in my opinion, aligning with a powerful country li..."*)

### Węzeł `[286]`
Mówca: **Gus Manger**
> "“Mr. President. We have made a promise. People want to trust their President. What kind of an example we would set for future generations if we were to back down on our promises?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lileas Graf: "“Future generations would be thankful everyday for making..."*)

### Węzeł `[287]`
Mówca: **Gus Manger**
> "“Exactly. I like to think of it as a very valuable partnership. With the deals we will get by aligning ourselves with a strong country like Arcasia, recession would surely end in no time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lileas Graf: "“In return for what? Sordland's independence?”"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Gus Manger: "“Exactly. I like to think of it as a very valuable partne..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA: "“You may be right. Let's see what the future brings.”"]** — Mówca: **Player**
> "“You may be right. Let's see what the future brings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Gus Manger: "“Mr. President. We have made a promise. People want to tr..."*)

### Węzeł `[290]`
Mówca: **Lileas Graf**
> "“I know you have campaigned for this in the party a long time, Gus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Lileas Graf: "“Mr. President. This is exactly what being controlled loo..."*)

### Węzeł `[291]`
Mówca: **Lileas Graf**
> "“Future generations would be thankful everyday for making the right decision when Sordland is the only nation in the region that is not a puppet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[292]`
Mówca: **Gus Manger**
> "“Also, in my opinion, aligning with a powerful country like Arcasia was an excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Lileas Graf: "“I know you have campaigned for this in the party a long ..."*)

### Węzeł `[293]`
Mówca: **Lileas Graf**
> "“Mr. President. This is exactly what being controlled looks like. Voluntarily or involuntarily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Gus eyed Lileas with distrust but didn't say anything."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Gus eyed Lileas with distrust but didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[295]`
Mówca: **Lileas Graf**
> "“Valuable for Arcasia maybe. Not for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Gus Manger: "“That is simply untrue.”"*)

### Węzeł `[296]`
Mówca: **Gus Manger**
> "“That is simply untrue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[297]`
Mówca: **Lileas Graf**
> "“In return for what? Sordland's independence?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[298]`
**[WYBÓR GRACZA: "“Time will show if staying neutral will work out.”"]** — Mówca: **Player**
> "“Time will show if staying neutral will work out.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lileas Graf: "“We must make it work to protect our country and our valu..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA: "“Sordland will not be controlled by any nations.”"]** — Mówca: **Player**
> "“Sordland will not be controlled by any nations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lileas Graf: "“Precisely my point. We will stand strong and show an exa..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA: "“Exactly. Soll was right all along with his policies.”"]** — Mówca: **Player**
> "“Exactly. Soll was right all along with his policies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 1"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Lileas Graf: "“I am glad we are on the same page.”"*)

### Węzeł `[302]`
Mówca: **Lileas Graf**
> "“I am glad we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Gus Manger: "“I hope we won't regret this.”"*)

### Węzeł `[303]`
Mówca: **Gus Manger**
> "“I hope we won't regret this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Lileas had a sip of water from her glass."*)

### Węzeł `[304]`
Mówca: **Lileas Graf**
> "“Precisely my point. We will stand strong and show an example to the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Gus Manger: "“I hope we won't regret this.”"*)

### Węzeł `[305]`
**[WYBÓR GRACZA: "“I still haven't decided if they wish to come with a deal.”"]** — Mówca: **Player**
> "“I still haven't decided if they wish to come with a deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lileas Graf: "“A deal that they would surely come out with more profit ..."*)

### Węzeł `[306]`
Mówca: **Lileas Graf**
> "“A deal that they would surely come out with more profit while our people suffered.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Gus Manger: "“We don't know that. We should wait and see. With the dea..."*)

### Węzeł `[307]`
Mówca: **Gus Manger**
> "“We don't know that. We should wait and see. With the deals we could get by aligning ourselves with a strong country like Arcasia, recession would surely end in no time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Lileas had a sip of water from her glass."*)

### Węzeł `[308]`
Mówca: **Lileas Graf**
> "“We must make it work to protect our country and our values. There is no other way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Gus Manger: "“We need to be open to other possibilities. Arcasia is a ..."*)

### Węzeł `[309]`
Mówca: **Gus Manger**
> "“We need to be open to other possibilities. Arcasia is a strong country and If we end up in their sphere, Sordland would increase its influence in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Gus Manger: "“The deals we would get would surely bring us out of rece..."*)

### Węzeł `[310]`
Mówca: **Gus Manger**
> "“The deals we would get would surely bring us out of recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Lileas Graf: "“In return for what? Our independence?”"*)

### Węzeł `[311]`
Mówca: **Lileas Graf**
> "“In return for what? Our independence?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Lileas had a sip of water from her glass."*)

### Węzeł `[312]`
Mówca: **Symon Holl**
> "“Economically speaking, we are much closer to Arcasia than United Contana, so a decision to align with the west makes more sense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lileas Graf: "“We must be very cautious. There are schemes being devise..."*)

### Węzeł `[313]`
Mówca: **Symon Holl**
> "“Economically speaking, we aren't as tied to United Contana as we are to Arcasia, so a decision to align with the east is much more difficult to accomplish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lileas Graf: "“We must be very cautious. There are schemes being devise..."*)

### Węzeł `[314]`
Mówca: **Symon Holl**
> "“Economically speaking, an isolationist policy overall could only work if we were to reap the benefits of both spheres and their rivalry. This is very dangerous to attempt but still possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lileas Graf: "“We must be very cautious. There are schemes being devise..."*)

### Węzeł `[315]`
**[WYBÓR GRACZA: "“The more of the economy we control, the better we can manage the recession.”"]** — Mówca: **Player**
> "“The more of the economy we control, the better we can manage the recession.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator), `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Symon Holl: "“That is a fair argument to be made. But if we reduce the..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA: "“Economic systems without regulation are bound to fail.”"]** — Mówca: **Player**
> "“Economic systems without regulation are bound to fail.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator), `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Symon Holl: "“Obviously there is some regulation in all of the existin..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA: "“Humanity in the 20th century is thriving because of the rule of supply and demand.”"]** — Mówca: **Player**
> "“Humanity in the 20th century is thriving because of the rule of supply and demand.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator), `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Symon Holl: "“Agreed. Look at how quickly Lespia and Arcasia have incr..."*)

### Węzeł `[318]`
Mówca: **Gus Manger**
> "“From taxes to the standard of goods, there are many elements that regulate all aspects of this system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Lileas Graf: "“But is it enough? I doubt it. If we can manage to plan m..."*)

### Węzeł `[319]`
Mówca: **Lileas Graf**
> "“But is it enough? I doubt it. If we can manage to plan more aspects of the economy, our chances of success would increase with a talented team like ours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Symon Holl: "“The structural problems of Sollonomics were going to lea..."*)

### Węzeł `[320]`
Mówca: **Symon Holl**
> "“Obviously there is some regulation in all of the existing systems, otherwise it would be anarchy. Nobody wants a chaotic society.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Gus Manger: "“From taxes to the standard of goods, there are many elem..."*)

### Węzeł `[321]`
Mówca: **Lileas Graf**
> "“One way to be remembered positively is to cause a recession and leave a few bills behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Symon Holl: "“The structural problems of Sollonomics were going to lea..."*)

### Węzeł `[322]`
Mówca: **Gus Manger**
> "“Say what you will about Alphonso, without his attempts our current coffers would be empty and the recession would be a depression.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Lileas Graf: "“One way to be remembered positively is to cause a recess..."*)

### Węzeł `[323]`
Mówca: **Symon Holl**
> "“That is a fair argument to be made. But if we reduce the freedom of people in the market place in general, it would hinder our innovation and dynamism in the supply and demand equation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Gus Manger: "“Say what you will about Alphonso, without his attempts o..."*)

### Węzeł `[324]`
Mówca: **Lileas Graf**
> "“Integrating heavily in a market economy would work if we had extensive means of production. Our industry is lacking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Symon Holl: "“The structural problems of Sollonomics were going to lea..."*)

### Węzeł `[325]`
Mówca: **Gus Manger**
> "“Sordland has the potential to do so as well. Why don't we take our potential seriously?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Lileas Graf: "“Integrating heavily in a market economy would work if we..."*)

### Węzeł `[326]`
Mówca: **Symon Holl**
> "“Agreed. Look at how quickly Lespia and Arcasia have increased their prosperity by embracing these basic principles.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Gus Manger: "“Sordland has the potential to do so as well. Why don't w..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player: "“Humanity in the 20th century is thriving because of the ..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_Planned == true)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Player: "“Economic systems without regulation are bound to fail.”"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[333]`
Mówca: **Symon Holl**
> "“As you can see, the situation is alarming, but not everything is negative. The extensive privatization program of Alphonso and key foreign direct investments left us a large budget surplus which we can use to stabilize the crisis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Symon Holl: "“The primary subject we need to settle on is what general..."*)

### Węzeł `[334]`
Mówca: **Symon Holl**
> "“The primary subject we need to settle on is what general path we will take in our term. Sollonomics-based nationalization happened in the '30s and Alphonso's privatization began during the end of the '40s. What will our administration focus on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[335]`
Mówca: **Narrator**
> "Symon pulled a silk handkerchief out of his pocket and briefly wiped his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“My staff and I have comprehensively analyzed every aspec..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth < 3"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth < 3)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth < 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Turn01InvestmentDecisionOption_Spend3 = f..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth < 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth < 2"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Turn01InvestmentDecisionOption_Spend3 = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_Turn01InvestmentDecisionOption_Spend3"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth < 2"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth < 2"*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth < 2)"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Turn01InvestmentDecisionOption_Spend2 = f..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_EnT_EconomicOverview = true"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Turn01InvestmentDecisionOption_Spend2 = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_Turn01InvestmentDecisionOption_Spend2"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_EnT_EconomicOverview = true"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_E_ArmadineElectronics = true; BaseGame.Policy_Economy_Alphonsonomics = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_E_ArmadineElectronics"] = true;
Variable["BaseGame.Policy_Economy_Alphonsonomics"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[345]`
**[WYBÓR GRACZA: "“Let's move on to the conclusion.”"]** — Mówca: **Player**
> "“Let's move on to the conclusion.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == true`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator), `[186]` (Gus Manger), `[221]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Symon Holl: "“What are your final thoughts, Mr. President?”"*)

### Węzeł `[346]`
Mówca: **Gus Manger**
> "“We should attract more foreign direct investment. Mr. President, we saved the country from a full-on depression in 1952 and 1953 by signing lucrative trade deals with nations such as Rizia, Lespia, and Qinal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Symon cleared his throat again."*)

### Węzeł `[347]`
Mówca: **Narrator**
> "Lileas had a sip of water from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“When the time comes, I hope you will make the right deci..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“No need for questions. I am well aware of the details. Let's move on to our strategy.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_QOL"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_UNEMP"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Hub_GDP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Symon Holl), `[230]` (Symon Holl), `[87]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Symon scattered the paper stack in front of him in an ord..."*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Here's what we'll do...”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn01_EnT_Listened_Superpower"] == true  or  Variable["BaseGameIsolated.Turn01_EnT_Listened_Examples"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator), `[186]` (Gus Manger), `[221]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You already know what we're going to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
