# Rizia/Turn 2/FPnT_SordlandTradeVisit

- **ID konwersacji:** `299`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/299_FPnT_SordlandTradeVisit.md`
- **Liczba węzłów dialogowych:** 427
- **Liczba wyborów gracza:** 107

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[65]** Ewald Alphonso (R)
- **[66]** Gus Manger (R)
- **[80]** Elena Werner
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Trait_SoberKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Country_Tourism`
- `RiziaDLC.Diplomacy_Sordland_NegotiatingPower`
- `RiziaDLC.Diplomacy_Sordland_WhiskeySurplus`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Drinking`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLCSupport.Journal_Turn02_Sordland_Resort`
- `RiziaDLCSupport.Journal_Turn02_Sordland_Whisky`
- `RiziaDLCSupport.News_Turn02_G_SordlandVisit_Deal`
- `RiziaDLCSupport.News_Turn02_G_SordlandVisit_NoDeal`
- `RiziaDLCSupport.News_Turn02_RH_SordishTrade_BothDeals`
- `RiziaDLCSupport.News_Turn02_RH_SordishTrade_NoDeals`
- `RiziaDLCSupport.News_Turn02_RH_SordishTrade_ResortDeal`
- `RiziaDLCSupport.News_Turn02_RH_SordishTrade_WineDeal`
- `RiziaDLCSupport.Reports_Terador_AzaroMilitaryExercise`
- `RiziaDLCSupport.Reports_Turn02_Monqiz_PortQueues`
- `RiziaDLCSupport.Reports_Turn02_Montaklar_LeisureClubShutDown`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"Show Alphonso the New Town."** | `[6]` **Narrator**: "The ship's horn let out a blast ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Ewald Alphonso (R)**: ""See, this is what I like about ..." |
| `[8]` | **"Show Alphonso the Old Town."** | `[6]` **Narrator**: "The ship's horn let out a blast ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Ewald Alphonso (R)**: ""Terrific, the way you've preser..." |
| `[11]` | **""Trust me, I know. I've got hundreds of years of history weighing on me every day.""** | `[10]` **Ewald Alphonso (R)**: ""Terrific, the way you've preser..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Ewald Alphonso (R)**: ""Light as a feather compared to ..." |
| `[12]` | **""If my grandmother hadn't made those trade deals between Rizia and Sordland, our c..."** | `[10]` **Ewald Alphonso (R)**: ""Terrific, the way you've preser..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Ewald Alphonso (R)**: ""But if my forward-thinking deve..." |
| `[13]` | **""I'm happy your country finally has a president who understands that.""** | `[10]` **Ewald Alphonso (R)**: ""Terrific, the way you've preser..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Ewald Alphonso (R)**: ""I owe a lot to Colonel Soll. Bu..." |
| `[14]` | **""I'm not one to look backwards. Neither are you, I hear.""** | `[9]` **Ewald Alphonso (R)**: ""See, this is what I like about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Ewald Alphonso (R)**: ""I owe a lot to Colonel Soll. Bu..." |
| `[15]` | **""Don't let the razzle-dazzle fool you. Rizia is as stuck in the past as it ever was.""** | `[9]` **Ewald Alphonso (R)**: ""See, this is what I like about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Ewald Alphonso (R)**: ""You and I are meeting, aren't w..." |
| `[16]` | **""Those skyscrapers are an eyesore.""** | `[9]` **Ewald Alphonso (R)**: ""See, this is what I like about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Ewald Alphonso (R)**: ""But the opportunity they repres..." |
| `[19]` | **"Drink without a toast."** | `[18]` **Narrator**: "We raised our glasses." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Ewald Alphonso (R)**: ""To hell with tradition, right?"" |
| `[21]` | **""A Morgna wes core!""** | `[18]` **Narrator**: "We raised our glasses." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "The two Sordish men smiled polit..." |
| `[23]` | **""To new beginnings.""** | `[18]` **Narrator**: "We raised our glasses." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Ewald Alphonso (R)**: ""And new prosperity."" |
| `[25]` | **""To our ancestors.""** | `[18]` **Narrator**: "We raised our glasses." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Gus Manger (R)**: ""May they rest in peace."" |
| `[28]` | **""That can't be the only reason you've traveled all this way.""** | `[27]` **Ewald Alphonso (R)**: ""Ah, yes. The free trade of Rizi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Gus Manger (R)**: ""Call it an aperitif."" |
| `[29]` | **""Sordish whiskey? I'd have to taste it first.""** | `[27]` **Ewald Alphonso (R)**: ""Ah, yes. The free trade of Rizi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Ewald Alphonso (R)**: ""I was saving this until after d..." |
| `[34]` | **""It's heavenly.""** | `[233]` **Narrator**: "The taste brought back memories ..."<br>`[400]` **Narrator**: "I relished the bite. I could alm..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`<br>`(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false` | *Brak zmian stanu* | `[38]` **Gus Manger (R)**: ""Like tasting the very soul of E..." |
| `[35]` | **""Disgusting. Why would anyone want a drink that tastes like trees?""** | `[233]` **Narrator**: "The taste brought back memories ..."<br>`[400]` **Narrator**: "I relished the bite. I could alm..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`<br>`(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false` | *Brak zmian stanu* | `[37]` **Gus Manger (R)**: ""And they say royals have sophis..." |
| `[36]` | **""It's great, but I'd better not have any more.""** | `[233]` **Narrator**: "The taste brought back memories ..."<br>`[400]` **Narrator**: "I relished the bite. I could alm..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`<br>`(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false` | *Brak zmian stanu* | `[39]` **Gus Manger (R)**: ""That's liquid gold you're leavi..." |
| `[41]` | **""Definitely. Expect to see all our bars serving Sordish whiskey by next year." [Tr..."** | `[40]` **Ewald Alphonso (R)**: ""So, is it a trade, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhisk...` | `[294]` **Narrator**: "Elena flipped open her ledger an..."<br>`[43]` **Ewald Alphonso (R)**: ""Excellent, Your Majesty. Anothe..." |
| `[42]` | **""No. Our wine is so superior to your whiskey that it wouldn't be fair to us.""** | `[40]` **Ewald Alphonso (R)**: ""So, is it a trade, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Narrator**: "Elena raised her eyebrows but st..."<br>`[98]` **Narrator**: "A series of looks passed between..." |
| `[47]` | **""My grandmother was definitely thinking ahead when she made those trade deals with..."** | `[9]` **Ewald Alphonso (R)**: ""See, this is what I like about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Ewald Alphonso (R)**: ""Lyza the Great. It's not easy, ..." |
| `[56]` | **""Mr. Montoro is not my friend. And I'd appreciate it if you didn't go rooting arou..."** | `[55]` **Gus Manger (R)**: ""Our mutual friend Russello ment..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Gus Manger (R)**: ""Forgive me, Your Majesty. But w..." |
| `[57]` | **""If you're that impressed by a Cantuavo, I hate to think of the swill they must be..."** | `[55]` **Gus Manger (R)**: ""Our mutual friend Russello ment..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Gus laughed delightedly." |
| `[58]` | **""A man of exquisite taste. I like you already.""** | `[55]` **Gus Manger (R)**: ""Our mutual friend Russello ment..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Gus Manger (R)**: ""A toast to exquisite taste, the..." |
| `[61]` | **""Rusty has certainly sampled enough wine to know what he's talking about.""** | `[55]` **Gus Manger (R)**: ""Our mutual friend Russello ment..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Gus Manger (R)**: ""I wouldn't mind gaining some fi..." |
| `[81]` | **""Rizians do not drink whiskey, Mr. President.""** | `[27]` **Ewald Alphonso (R)**: ""Ah, yes. The free trade of Rizi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Ewald Alphonso (R)**: ""That's because they've never tr..." |
| `[87]` | **""Just a small sip for me. To make sure my people aren't getting an inferior product.""** | `[83]` **Narrator**: "Pabel approached with three glas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Narrator**: "Pabel poured me a small amount w..."<br>`[225]` **Narrator**: "Pabel poured us each a small amo..." |
| `[88]` | **""Actually, I'll take your word for it. The wine's already gone to my head.""** | `[83]` **Narrator**: "Pabel approached with three glas..." | `Variable["RiziaDLC.Trait_SoberKing"] == true` | *Brak zmian stanu* | `[90]` **Ewald Alphonso (R)**: ""I really must insist."" |
| `[89]` | **""If I didn't know any better, I'd say you two were trying to get me drunk.""** | `[83]` **Narrator**: "Pabel approached with three glas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Ewald Alphonso (R)**: ""One does not get merely 'drunk'..." |
| `[92]` | **""I hope this is as good as you say.""** | `[83]` **Narrator**: "Pabel approached with three glas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Gus Manger (R)**: ""It's even better."" |
| `[100]` | **""Yes, sure. Now can we get to the real reason why you're here?" [Trade Deal]"** | `[40]` **Ewald Alphonso (R)**: ""So, is it a trade, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhisk...` | `[290]` **Narrator**: "Elena flipped open her ledger an..."<br>`[104]` **Ewald Alphonso (R)**: ""Excellent, Your Majesty. And ye..." |
| `[101]` | **""No, sorry. I'd rather not bring more hard liquor into this country.""** | `[40]` **Ewald Alphonso (R)**: ""So, is it a trade, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Narrator**: "Elena raised her eyebrows but st..."<br>`[98]` **Narrator**: "A series of looks passed between..." |
| `[108]` | **""I'm afraid our conflicts with our neighbors would scare off visitors.""** | `[107]` **Gus Manger (R)**: ""Have you thought about Rizia's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Gus Manger (R)**: ""Still, Your Majesty?"" |
| `[109]` | **""Yes, many times. Our beaches put Lespia's to shame, after all.""** | `[107]` **Gus Manger (R)**: ""Have you thought about Rizia's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Gus Manger (R)**: ""They're true diamonds in the ro..." |
| `[110]` | **""We only want the right kind of tourists, Mr. Manger. No riff-raff.""** | `[107]` **Gus Manger (R)**: ""Have you thought about Rizia's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Gus Manger (R)**: ""None indeed."" |
| `[111]` | **""I'm listening...""** | `[107]` **Gus Manger (R)**: ""Have you thought about Rizia's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Gus Manger (R)**: ""Porte Drazon is gorgeous enough..." |
| `[119]` | **""House Toras would never stand for this.""** | `[118]` **Narrator**: "Right on the coastline, the desi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Gus Manger (R)**: ""You are the head of House Toras..." |
| `[120]` | **""No. I'm not bringing Sordish new money to Rizia.""** | `[118]` **Narrator**: "Right on the coastline, the desi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Gus Manger (R)**: ""New money, old money -- it's al..." |
| `[122]` | **""It's missing a private pier.""** | `[118]` **Narrator**: "Right on the coastline, the desi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Gus Manger (R)**: ""It's only a rough sketch, Your ..." |
| `[123]` | **""Would that be the senior or the junior Koronti?""** | `[118]` **Narrator**: "Right on the coastline, the desi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Gus Manger (R)**: ""You've done your research, I se..." |
| `[130]` | **""Lyza wouldn't have wanted a bunch of fat, sunburned vulgarians blocking her ocean..."** | `[129]` **Ewald Alphonso (R)**: ""Change is not merely inevitable..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "Gus drew his breath in through h..." |
| `[131]` | **""We don't need Sordland's help to stay wealthy.""** | `[129]` **Ewald Alphonso (R)**: ""Change is not merely inevitable..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Ewald Alphonso (R)**: ""We know you've got Queen Beatri..." |
| `[132]` | **""I am the king. The nobles would have no choice but to acquiesce.""** | `[129]` **Ewald Alphonso (R)**: ""Change is not merely inevitable..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[135]` **Gus Manger (R)**: ""So that's a yes on the proposal?"" |
| `[133]` | **""Well said, Mr. President. My relatives could use a good shock to the system.""** | `[129]` **Ewald Alphonso (R)**: ""Change is not merely inevitable..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Gus Manger (R)**: ""So that's a yes on the proposal?"" |
| `[138]` | **""It is indeed. I hope I'm invited to the grand opening." [Resort Deal]"** | `[135]` **Gus Manger (R)**: ""So that's a yes on the proposal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Narrator**: "Gus laughed." |
| `[142]` | **""Well... I don't like it, but I'd be a fool to turn down your oligarchs' investmen..."** | `[139]` **Gus Manger (R)**: ""You too, eh? We'll assume that'..."<br>`[141]` **Gus Manger (R)**: ""But we'll assume that's a no on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Narrator**: "They glanced at each other in su..." |
| `[143]` | **""You're already getting our wine. That's enough wheeling and dealing for one day.""** | `[139]` **Gus Manger (R)**: ""You too, eh? We'll assume that'..."<br>`[141]` **Gus Manger (R)**: ""But we'll assume that's a no on..." | `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true` | *Brak zmian stanu* | `[155]` **Narrator**: "He shrugged." |
| `[147]` | **""No, indeed. Come back when you have better ideas.""** | `[139]` **Gus Manger (R)**: ""You too, eh? We'll assume that'..."<br>`[141]` **Gus Manger (R)**: ""But we'll assume that's a no on..." | `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false` | *Brak zmian stanu* | `[197]` **Narrator**: "Alphonso frowned." |
| `[150]` | **""Yes. As long as the final design is less gaudy." [Resort Deal]"** | `[135]` **Gus Manger (R)**: ""So that's a yes on the proposal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Ewald Alphonso (R)**: ""I'll pass that on to our partne..." |
| `[152]` | **""No. I do want to open Rizia up to the world, but I'd rather explore other avenues.""** | `[135]` **Gus Manger (R)**: ""So that's a yes on the proposal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Ewald Alphonso (R)**: ""I see."" |
| `[154]` | **""Your assumption is correct. Sorry to waste your time.""** | `[139]` **Gus Manger (R)**: ""You too, eh? We'll assume that'..."<br>`[141]` **Gus Manger (R)**: ""But we'll assume that's a no on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Narrator**: "Alphonso shrugged."<br>`[164]` **Ewald Alphonso (R)**: ""So the door between our countri..." |
| `[174]` | **""His name is Pabel Adria. Show some respect.""** | `[172]` **Gus Manger (R)**: ""There's only one opportunity th..."<br>`[173]` **Gus Manger (R)**: ""But no wine in Sordland means t..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[368]` **Gus Manger (R)**: ""I stand corrected. Mr. Adria, i..." |
| `[177]` | **""He's my butler, not yours. Pabel!""** | `[172]` **Gus Manger (R)**: ""There's only one opportunity th..."<br>`[173]` **Gus Manger (R)**: ""But no wine in Sordland means t..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "Pabel reappeared, another bottle..."<br>`[185]` **Narrator**: "Pabel reappeared, another bottle..." |
| `[178]` | **""You heard the man, Pabel.""** | `[172]` **Gus Manger (R)**: ""There's only one opportunity th..."<br>`[173]` **Gus Manger (R)**: ""But no wine in Sordland means t..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "Pabel reappeared, another bottle..."<br>`[185]` **Narrator**: "Pabel reappeared, another bottle..." |
| `[188]` | **""For such an anti-monarchist, he behaved an awful lot like a king.""** | `[187]` **Ewald Alphonso (R)**: ""The Colonel was no great fan of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Ewald Alphonso (R)**: ""By the end, maybe. I wish we'd ..." |
| `[189]` | **""The only difference between your republic and our monarchy is that the Rizian peo..."** | `[187]` **Ewald Alphonso (R)**: ""The Colonel was no great fan of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Ewald Alphonso (R)**: ""Are you sure that's not just be..." |
| `[190]` | **""Nor was my father keen on democracy. You and I have much in common.""** | `[187]` **Ewald Alphonso (R)**: ""The Colonel was no great fan of..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[192]` **Ewald Alphonso (R)**: ""Gus said he thought we'd get al..." |
| `[195]` | **""Countries with differing politics can still find common ground.""** | `[187]` **Ewald Alphonso (R)**: ""The Colonel was no great fan of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Ewald Alphonso (R)**: ""Exactly."" |
| `[199]` | **""That's enough, Mr. Manger. I'm cutting you off.""** | `[172]` **Gus Manger (R)**: ""There's only one opportunity th..."<br>`[173]` **Gus Manger (R)**: ""But no wine in Sordland means t..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Gus Manger (R)**: ""I'll see you in Sordland, then,..."<br>`[205]` **Gus Manger (R)**: ""I'll see you on our next visit,..." |
| `[215]` | **""You're in Rizia. Mr. Manger. We treat women like equals here.""** | `[211]` **Gus Manger (R)**: ""Last I saw, your treasury crone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "Alphonso gave Gus a look of warn..." |
| `[217]` | **""Don't call Ms. Werner a crone. She's one of my most capable councilors.""** | `[211]` **Gus Manger (R)**: ""Last I saw, your treasury crone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "Alphonso gave Gus a look of warn..." |
| `[218]` | **""Sorry I had to bring along the wet blanket. I would've preferred a men's night ou..."** | `[211]` **Gus Manger (R)**: ""Last I saw, your treasury crone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Ewald Alphonso (R)**: ""It could have been worse. Imagi..." |
| `[219]` | **""Yes, let's.""** | `[211]` **Gus Manger (R)**: ""Last I saw, your treasury crone..."<br>`[216]` **Gus Manger (R)**: ""Since your treasury crone isn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Narrator**: "Pabel ducked into the ship's cab..."<br>`[253]` **Narrator**: "Alphonso reopened his briefcase ..." |
| `[220]` | **""You're in Rizia. Mr. Manger. We treat women like equals here.""** | `[216]` **Gus Manger (R)**: ""Since your treasury crone isn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "Alphonso gave Gus a look of warn..." |
| `[234]` | **""Don't call Ms. Werner a crone. She's one of my most capable councilors.""** | `[216]` **Gus Manger (R)**: ""Since your treasury crone isn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "Alphonso gave Gus a look of warn..." |
| `[238]` | **""Yes, let's work this out between us men. No wet blanket necessary.""** | `[216]` **Gus Manger (R)**: ""Since your treasury crone isn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Ewald Alphonso (R)**: ""I'm glad you understand. Imagin..." |
| `[250]` | **""If demand for whiskey doesn't exist in Rizia, we'll just have to find a way to cr..."** | `[249]` **Elena Werner**: ""You're proposing an equal amoun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Gus Manger (R)**: ""It won't be difficult. This whi..." |
| `[251]` | **""See, this is why I brought her along.""** | `[249]` **Elena Werner**: ""You're proposing an equal amoun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Ewald Alphonso (R)**: ""Good catch, Ms. Werner."" |
| `[252]` | **""Is there another way we can rephrase this, Mr. President?""** | `[249]` **Elena Werner**: ""You're proposing an equal amoun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Ewald Alphonso (R)**: ""Good catch, Ms. Werner."" |
| `[255]` | **""Reopening trade channels to sell us useless whiskey. What a swindle.""** | `[249]` **Elena Werner**: ""You're proposing an equal amoun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Ewald Alphonso (R)**: ""Good catch, Ms. Werner."" |
| `[259]` | **""Sounds legitimate. No need to go on.""** | `[257]` **Ewald Alphonso (R)**: ""...conducted in a manner that i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Gus Manger (R)**: ""A wise move, Your Majesty. The ..." |
| `[260]` | **"Keep listening."** | `[257]` **Ewald Alphonso (R)**: ""...conducted in a manner that i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Ewald Alphonso (R)**: ""...the parties shall agree to c..." |
| `[261]` | **""Stop. I've made a decision.""** | `[258]` **Ewald Alphonso (R)**: ""...the parties shall agree to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Gus Manger (R)**: ""A wise move, Your Majesty. The ..." |
| `[262]` | **"Keep listening."** | `[258]` **Ewald Alphonso (R)**: ""...the parties shall agree to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Ewald Alphonso (R)**: ""...elimination of tariffs to be..." |
| `[264]` | **""Seems straightforward enough. Here's what I've decided.""** | `[263]` **Ewald Alphonso (R)**: ""...elimination of tariffs to be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Gus Manger (R)**: ""Phew. I thought that would neve..." |
| `[266]` | **"Keep listening."** | `[263]` **Ewald Alphonso (R)**: ""...elimination of tariffs to be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Ewald Alphonso (R)**: ""...ensuring that respective cus..." |
| `[267]` | **""I get the picture.""** | `[265]` **Ewald Alphonso (R)**: ""...ensuring that respective cus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Gus Manger (R)**: ""Phew. I thought that would neve..." |
| `[268]` | **"Keep listening."** | `[265]` **Ewald Alphonso (R)**: ""...ensuring that respective cus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Ewald Alphonso (R)**: ""...in equal amounts of 100 tons..." |
| `[270]` | **""Wait.""** | `[269]` **Ewald Alphonso (R)**: ""...in equal amounts of 100 tons..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Ewald Alphonso (R)**: ""Yes?"" |
| `[271]` | **""Okay. Here's what I want to do.""** | `[269]` **Ewald Alphonso (R)**: ""...in equal amounts of 100 tons..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Gus Manger (R)**: ""Phew. I thought that would neve..." |
| `[275]` | **""Equal amounts? Demand for Rizian wine in Sordland is far higher than that for Sor..."** | `[274]` **Ewald Alphonso (R)**: ""Yes?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Ewald Alphonso (R)**: ""Hrm. Good catch."" |
| `[276]` | **""I've heard enough.""** | `[274]` **Ewald Alphonso (R)**: ""Yes?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Gus Manger (R)**: ""A wise move, Your Majesty. The ..." |
| `[301]` | **""Yes, relations with *pall-ey* have been shaky for years.""** | `[302]` **Narrator**: "He pronounced the last word as "..." | `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false` | *Brak zmian stanu* | `[306]` **Narrator**: "He didn't seem to notice my corr..." |
| `[303]` | **""It's 'pall-ey'. Rhymes with 'ballet'.""** | `[302]` **Narrator**: "He pronounced the last word as "..." | `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false` | *Brak zmian stanu* | `[305]` **Gus Manger (R)**: ""Oh. Sorry, I've never had the o..." |
| `[304]` | **"Don't correct him."** | `[302]` **Narrator**: "He pronounced the last word as "..." | `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false` | *Brak zmian stanu* | `[307]` **Gus Manger (R)**: ""My point is that it might final..." |
| `[308]` | **""Not so fast. Let me confer with Elena.""** | `[135]` **Gus Manger (R)**: ""So that's a yes on the proposal?""<br>`[139]` **Gus Manger (R)**: ""You too, eh? We'll assume that'..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true` | *Brak zmian stanu* | `[313]` **Ewald Alphonso (R)**: ""As you wish, Your Majesty."" |
| `[314]` | **""So what do you think?""** | `[312]` **Narrator**: "The Sordish visitors waited outs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Elena Werner**: ""If I may speak freely... I don'..." |
| `[315]` | **""This is exactly what I was worried about. Sords waltzing in here and disrespectin..."** | `[312]` **Narrator**: "The Sordish visitors waited outs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Elena Werner**: ""Their attitude leaves something..." |
| `[316]` | **""You served under Queen Lyza. Would she have wanted this?""** | `[312]` **Narrator**: "The Sordish visitors waited outs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Elena Werner**: ""Well... Lyza did everything in ..." |
| `[322]` | **""Why not?""** | `[317]` **Elena Werner**: ""If I may speak freely... I don'..."<br>`[321]` **Elena Werner**: ""But if I may speak freely... I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Elena Werner**: ""You must remember that I'm from..." |
| `[323]` | **""Okay. That's all I wanted to know.""** | `[317]` **Elena Werner**: ""If I may speak freely... I don'..."<br>`[321]` **Elena Werner**: ""But if I may speak freely... I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Elena Werner**: ""Shall we get back out on deck?"" |
| `[324]` | **""You're not a Toras. You don't understand.""** | `[317]` **Elena Werner**: ""If I may speak freely... I don'..."<br>`[321]` **Elena Werner**: ""But if I may speak freely... I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Elena Werner**: ""I do, though. You must remember..." |
| `[328]` | **""Neither do I. But I wanted to hear your reasoning.""** | `[321]` **Elena Werner**: ""But if I may speak freely... I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Elena Werner**: ""You must remember that I'm from..." |
| `[333]` | **""Yes, I've made my decision.""** | `[332]` **Elena Werner**: ""Shall we get back out on deck?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Narrator**: "We stepped back out into the wan..." |
| `[334]` | **""We shall. Thank you for sharing your opinion.""** | `[332]` **Elena Werner**: ""Shall we get back out on deck?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Narrator**: "We stepped back out into the wan..." |
| `[335]` | **""If we must..""** | `[332]` **Elena Werner**: ""Shall we get back out on deck?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Narrator**: "We stepped back out into the wan..." |
| `[338]` | **""You have a deal. But does the resort have to be as gaudy as the one in the picture?""** | `[337]` **Ewald Alphonso (R)**: ""Well, Your Majesty? Are we maki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Gus Manger (R)**: ""Ha. I'm sure our architects can..." |
| `[339]` | **""Just remember to invite me to the grand opening of the Koronti Resort Valenqiris.""** | `[337]` **Ewald Alphonso (R)**: ""Well, Your Majesty? Are we maki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Gus Manger (R)**: ""You'll get a free stay in the l..." |
| `[340]` | **""One deal is enough for today, gentlemen.""** | `[337]` **Ewald Alphonso (R)**: ""Well, Your Majesty? Are we maki..." | `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true` | *Brak zmian stanu* | `[352]` **Narrator**: "Alphonso shrugged." |
| `[344]` | **""I'm afraid neither of your proposals appeal to me. Sorry to send you home with no..."** | `[337]` **Ewald Alphonso (R)**: ""Well, Your Majesty? Are we maki..." | `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false` | *Brak zmian stanu* | `[197]` **Narrator**: "Alphonso frowned." |
| `[345]` | **""No, our coastline shall stay the way it is. Untouched by foreign influence.""** | `[337]` **Ewald Alphonso (R)**: ""Well, Your Majesty? Are we maki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Narrator**: "Alphonso shrugged."<br>`[164]` **Ewald Alphonso (R)**: ""So the door between our countri..." |
| `[390]` | **""That's exactly what my relatives are worried about.""** | `[330]` **Elena Werner**: ""That resort wouldn't just open ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Elena Werner**: ""Yes, the rest of your house wou..." |
| `[391]` | **""The resort is still private property. Commoners would barely be able to afford it.""** | `[330]` **Elena Werner**: ""That resort wouldn't just open ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[394]` **Elena Werner**: ""But if they did have the money,..." |
| `[392]` | **""Unless we get back into another conflict with 'Pails.'""** | `[330]` **Elena Werner**: ""That resort wouldn't just open ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Narrator**: "She smiled wryly." |
| `[411]` | **""Well... I can't say no to Sordish hospitality. I'll just have a little taste.""** | `[90]` **Ewald Alphonso (R)**: ""I really must insist."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Narrator**: "Pabel poured me a small amount w..."<br>`[225]` **Narrator**: "Pabel poured us each a small amo..." |
| `[412]` | **""Sorry, President Alphonso. Maybe another time.""** | `[90]` **Ewald Alphonso (R)**: ""I really must insist."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Narrator**: "His gaze turned cool." |
| `[421]` | **""Sounds heavenly.""** | `[420]` **Gus Manger (R)**: ""That dark, woodsy flavor, that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Gus Manger (R)**: ""Like tasting the very soul of E..." |
| `[423]` | **""Just as well. If it's as good as you say, I'd never be able to stop drinking it.""** | `[420]` **Gus Manger (R)**: ""That dark, woodsy flavor, that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Gus Manger (R)**: ""Your countrymen will go crazy f..." |

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
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Talking trade on a boat with the Preside..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "My royal yacht, the Rizania, smoothly cleaved through the waters of the Zpana river delta."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I stood on the deck next to Ewald Alphonso, President of ..."*)

### Węzeł `[4]`
Mówca: **Ewald Alphonso (R)**
> ""What a great idea this boat tour was. It would have been a pity to spend our entire visit trapped in a stuffy old palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "He rushed to correct himself."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I stood on the deck next to Ewald Alphonso, President of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "After hours of diplomatic formalities in Palas Rezna, the..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The ship's horn let out a blast as we passed beneath the bridge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus_Italic: "Show Alphonso the New Town."*)
  - -> `[8]` (*Player_Romus_Italic: "Show Alphonso the Old Town."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "Show Alphonso the New Town."]** — Mówca: **Player_Romus_Italic**
> "I directed the Sordish president's attention to the glass skyscrapers of the New Town, where Rizia's banks and major corporations were headquartered."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Ewald Alphonso (R): ""See, this is what I like about your country. You're not ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "Show Alphonso the Old Town."]** — Mówca: **Player_Romus_Italic**
> "I led the Sordish president to the southern side of the deck for a better view of the Old Town. The late afternoon sun perfectly illuminated the spire of the Zilba Archsanctuary."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Ewald Alphonso (R): ""Terrific, the way you've preserved these historic buildi..."*)

### Węzeł `[9]`
Mówca: **Ewald Alphonso (R)**
> ""See, this is what I like about your country. You're not afraid of the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I'm not one to look backwards. Neither are you, I hear.""*)
  - -> `[47]` (*Player_Romus: ""My grandmother was definitely thinking ahead when she ma..."*)
  - -> `[15]` (*Player_Romus: ""Don't let the razzle-dazzle fool you. Rizia is as stuck ..."*)
  - -> `[16]` (*Player_Romus: ""Those skyscrapers are an eyesore.""*)

### Węzeł `[10]`
Mówca: **Ewald Alphonso (R)**
> ""Terrific, the way you've preserved these historic buildings. But sometimes the past can be a trap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""I'm happy your country finally has a president who under..."*)
  - -> `[12]` (*Player_Romus: ""If my grandmother hadn't made those trade deals between ..."*)
  - -> `[11]` (*Player_Romus: ""Trust me, I know. I've got hundreds of years of history ..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, I know. I've got hundreds of years of history weighing on me every day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Ewald Alphonso (R): ""Light as a feather compared to the legacy of one Colonel..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If my grandmother hadn't made those trade deals between Rizia and Sordland, our countries would still be strangers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Ewald Alphonso (R): ""But if my forward-thinking development minister hadn't r..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy your country finally has a president who understands that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Ewald Alphonso (R): ""I owe a lot to Colonel Soll. But it's high time Sordland..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not one to look backwards. Neither are you, I hear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Ewald Alphonso (R): ""I owe a lot to Colonel Soll. But it's high time Sordland..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't let the razzle-dazzle fool you. Rizia is as stuck in the past as it ever was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Ewald Alphonso (R): ""You and I are meeting, aren't we? That's already progress.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those skyscrapers are an eyesore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Ewald Alphonso (R): ""But the opportunity they represent? Beautiful.""*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Pabel smoothly appeared from behind us with three glasses. Gus handed him the bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Pabel Adria: ""Excellent choice, Mr. Manger. Please allow me.""*)

### Węzeł `[18]`
Mówca: **Narrator**
> "We raised our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""To our ancestors.""*)
  - -> `[23]` (*Player_Romus: ""To new beginnings.""*)
  - -> `[21]` (*Player_Romus: ""A Morgna wes core!""*)
  - -> `[19]` (*Player_Romus_Italic: "Drink without a toast."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "Drink without a toast."]** — Mówca: **Player_Romus_Italic**
> "I took a sip without bothering to toast. The two others gave me a puzzled look, then shrugged."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Ewald Alphonso (R): ""To hell with tradition, right?""*)

### Węzeł `[20]`
Mówca: **Ewald Alphonso (R)**
> ""To hell with tradition, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Gus Manger (R): ""Right!""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Morgna wes core!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "The two Sordish men smiled politely."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "The two Sordish men smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Ewald Alphonso (R): ""We don't usually toast with that phrase. But nice pronun..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To new beginnings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Ewald Alphonso (R): ""And new prosperity.""*)

### Węzeł `[24]`
Mówca: **Ewald Alphonso (R)**
> ""And new prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gus Manger (R): ""And new friends.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To our ancestors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Gus Manger (R): ""May they rest in peace.""*)

### Węzeł `[26]`
Mówca: **Gus Manger (R)**
> ""May they rest in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Ewald Alphonso (R): ""And stay buried.""*)

### Węzeł `[27]`
Mówca: **Ewald Alphonso (R)**
> ""Ah, yes. The free trade of Rizian wine for Sordish whiskey. As good a way as any to get our relations flowing again, if you'll pardon the pun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""That can't be the only reason you've traveled all this w..."*)
  - -> `[29]` (*Player_Romus: ""Sordish whiskey? I'd have to taste it first.""*)
  - -> `[81]` (*Player_Romus: ""Rizians do not drink whiskey, Mr. President.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That can't be the only reason you've traveled all this way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gus Manger (R): ""Call it an aperitif.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sordish whiskey? I'd have to taste it first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Ewald Alphonso (R): ""I was saving this until after dinner, but here you go.""*)

### Węzeł `[30]`
Mówca: **Ewald Alphonso (R)**
> ""I was saving this until after dinner, but here you go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He opened his attache and pulled out a bottle of Erlory M..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "He opened his attache and pulled out a bottle of Erlory Maroon 30-Year-Old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Gus Manger (R): ""Our turn to be the connoisseurs, Your Majesty. Butler! T..."*)

### Węzeł `[32]`
Mówca: **Ewald Alphonso (R)**
> ""I'll do the toast this time. How do you people say it? A proso!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Drinking += 1;"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "We drank. The flavor rushed over my tongue -- wood smoke and forest moss tapering off to a sweet, silky smooth finish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's heavenly.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false` AND `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[400]` (Narrator), `[229]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Gus Manger (R): ""Like tasting the very soul of Erlory itself.""*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disgusting. Why would anyone want a drink that tastes like trees?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false` AND `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[400]` (Narrator), `[420]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Gus Manger (R): ""And they say royals have sophisticated palates. Your cou..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's great, but I'd better not have any more.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false` AND `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[400]` (Narrator), `[229]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Gus Manger (R): ""That's liquid gold you're leaving in your glass.""*)

### Węzeł `[37]`
Mówca: **Gus Manger (R)**
> ""And they say royals have sophisticated palates. Your countrymen will go crazy for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[38]`
Mówca: **Gus Manger (R)**
> ""Like tasting the very soul of Erlory itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[39]`
Mówca: **Gus Manger (R)**
> ""That's liquid gold you're leaving in your glass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[40]`
Mówca: **Ewald Alphonso (R)**
> ""So, is it a trade, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""Definitely. Expect to see all our bars serving Sordish w..."*)
  - -> `[100]` (*Player_Romus: ""Yes, sure. Now can we get to the real reason why you're ..."*)
  - -> `[42]` (*Player_Romus: ""No. Our wine is so superior to your whiskey that it woul..."*)
  - -> `[101]` (*Player_Romus: ""No, sorry. I'd rather not bring more hard liquor into th..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Definitely. Expect to see all our bars serving Sordish whiskey by next year." [Trade Deal]"]** — Mówca: **Player_Romus**
> ""Definitely. Expect to see all our bars serving Sordish whiskey by next year.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Our wine is so superior to your whiskey that it wouldn't be fair to us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[43]`
Mówca: **Ewald Alphonso (R)**
> ""Excellent, Your Majesty. Another reason for me to return to this gem of a country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "The yacht lingered at the mouth of the Zpana delta as the..."*)

### Węzeł `[44]`
Mówca: **Ewald Alphonso (R)**
> ""But the opportunity they represent? Beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ewald Alphonso (R): ""The Colonel was no great fan of monarchies, as you'll re..."*)

### Węzeł `[45]`
Mówca: **Ewald Alphonso (R)**
> ""You and I are meeting, aren't we? That's already progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ewald Alphonso (R): ""The Colonel was no great fan of monarchies, as you'll re..."*)

### Węzeł `[46]`
Mówca: **Ewald Alphonso (R)**
> ""I owe a lot to Colonel Soll. But it's high time Sordland moved on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ewald Alphonso (R): ""The Colonel was no great fan of monarchies, as you'll re..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My grandmother was definitely thinking ahead when she made those trade deals with Sordland years ago.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Ewald Alphonso (R): ""Lyza the Great. It's not easy, living in the shadows of ..."*)

### Węzeł `[48]`
Mówca: **Ewald Alphonso (R)**
> ""Lyza the Great. It's not easy, living in the shadows of our predecessors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ewald Alphonso (R): ""The Colonel was no great fan of monarchies, as you'll re..."*)

### Węzeł `[49]`
Mówca: **Ewald Alphonso (R)**
> ""But if my forward-thinking development minister hadn't reconnected us, we'd still be estranged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ewald Alphonso (R): ""The Colonel was no great fan of monarchies, as you'll re..."*)

### Węzeł `[50]`
Mówca: **Ewald Alphonso (R)**
> ""Light as a feather compared to the legacy of one Colonel Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ewald Alphonso (R): ""The Colonel was no great fan of monarchies, as you'll re..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Gus Manger emerged from the ship's cabin, clutching a bottle and grinning triumphantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gus Manger (R): ""Ewald! They have it!""*)

### Węzeł `[52]`
Mówca: **Gus Manger (R)**
> ""Ewald! They have it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Gus Manger (R): ""I tried Cantuavo exactly once, from a Rizian chef in Hol..."*)

### Węzeł `[53]`
Mówca: **Gus Manger (R)**
> ""I tried Cantuavo exactly once, from a Rizian chef in Holsord who smuggled it over in his steamer trunk. Haven't stopped thinking about it ever since.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He turned to me apologetically."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He turned to me apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Gus Manger (R): ""Our mutual friend Russello mentioned your yacht had an e..."*)

### Węzeł `[55]`
Mówca: **Gus Manger (R)**
> ""Our mutual friend Russello mentioned your yacht had an excellent wine cellar, and, well, I couldn't help myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Mr. Montoro is not my friend. And I'd appreciate it if y..."*)
  - -> `[61]` (*Player_Romus: ""Rusty has certainly sampled enough wine to know what he'..."*)
  - -> `[57]` (*Player_Romus: ""If you're that impressed by a Cantuavo, I hate to think ..."*)
  - -> `[58]` (*Player_Romus: ""A man of exquisite taste. I like you already.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Montoro is not my friend. And I'd appreciate it if you didn't go rooting around in my ship's quarters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Gus Manger (R): ""Forgive me, Your Majesty. But we can't let this beautifu..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're that impressed by a Cantuavo, I hate to think of the swill they must be serving in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Gus laughed delightedly."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A man of exquisite taste. I like you already.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger (R): ""A toast to exquisite taste, then. Butler!""*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Gus laughed delightedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Gus Manger (R): ""You hear that, Ewald! Swill! Giralt of Ribery must be sp..."*)

### Węzeł `[60]`
Mówca: **Gus Manger (R)**
> ""You hear that, Ewald! Swill! Giralt of Ribery must be spinning in his grave. Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Pabel smoothly appeared from behind us with three glasses..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty has certainly sampled enough wine to know what he's talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger (R): ""I wouldn't mind gaining some firsthand knowledge myself...."*)

### Węzeł `[62]`
Mówca: **Gus Manger (R)**
> ""Forgive me, Your Majesty. But we can't let this beautiful bottle go to waste now that it's been exposed to sunlight, can we? Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Pabel smoothly appeared from behind us with three glasses..."*)

### Węzeł `[63]`
Mówca: **Gus Manger (R)**
> ""I wouldn't mind gaining some firsthand knowledge myself. Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Pabel smoothly appeared from behind us with three glasses..."*)

### Węzeł `[64]`
Mówca: **Gus Manger (R)**
> ""A toast to exquisite taste, then. Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Pabel smoothly appeared from behind us with three glasses..."*)

### Węzeł `[65]`
Mówca: **Pabel Adria**
> ""Excellent choice, Mr. Manger. Please allow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PourDrink");"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "He turned his back as he filled our glasses, secretly pouring a nonalcoholic wine substitute into mine. We were used to this routine by now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Pabel Adria: ""This should taste of cherry and black pepper, with a fai..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He turned his back as he filled our glasses, secretly pou..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "He filled the glasses and handed one to each of us."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "He filled the glasses and handed one to each of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Pabel Adria: ""This should taste of cherry and black pepper, with a fai..."*)

### Węzeł `[71]`
Mówca: **Pabel Adria**
> ""This should taste of cherry and black pepper, with a faint hint of leather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "We raised our glasses."*)

### Węzeł `[72]`
Mówca: **Ewald Alphonso (R)**
> ""And stay buried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We drank. Gus sighed with pure pleasure. Alphonso's expre..."*)

### Węzeł `[73]`
Mówca: **Gus Manger (R)**
> ""And new friends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We drank. Gus sighed with pure pleasure. Alphonso's expre..."*)

### Węzeł `[74]`
Mówca: **Ewald Alphonso (R)**
> ""We don't usually toast with that phrase. But nice pronunciation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Gus Manger (R): ""Yes, well done. Vectern sis da.""*)

### Węzeł `[75]`
Mówca: **Gus Manger (R)**
> ""Yes, well done. Vectern sis da.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We drank. Gus sighed with pure pleasure. Alphonso's expre..."*)

### Węzeł `[76]`
Mówca: **Gus Manger (R)**
> ""Right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We drank. Gus sighed with pure pleasure. Alphonso's expre..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "We drank. Gus sighed with pure pleasure. Alphonso's expression bordered on disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Ewald Alphonso (R): ""All apologies to Giralt of Ribery, but this is in fact t..."*)

### Węzeł `[78]`
Mówca: **Ewald Alphonso (R)**
> ""All apologies to Giralt of Ribery, but this is in fact the best wine I've ever tasted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Gus Manger (R): ""I told you! I know certain Sordish movers and shakers wh..."*)

### Węzeł `[79]`
Mówca: **Gus Manger (R)**
> ""I told you! I know certain Sordish movers and shakers who'd kill to have access to a beverage of this caliber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Gus Manger (R): ""Which brings me to that deal I suggested...""*)

### Węzeł `[80]`
Mówca: **Gus Manger (R)**
> ""Which brings me to that deal I suggested...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Ewald Alphonso (R): ""Ah, yes. The free trade of Rizian wine for Sordish whisk..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizians do not drink whiskey, Mr. President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Ewald Alphonso (R): ""That's because they've never tried this.""*)

### Węzeł `[82]`
Mówca: **Gus Manger (R)**
> ""Our turn to be the connoisseurs, Your Majesty. Butler! Three tumblers, no ice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Pabel approached with three glasses."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Pabel approached with three glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""Just a small sip for me. To make sure my people aren't g..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[89]` (*Player_Romus: ""If I didn't know any better, I'd say you two were trying..."*)
  - -> `[92]` (*Player_Romus: ""I hope this is as good as you say.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""Actually, I'll take your word for it. The wine's already..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just a small sip for me. To make sure my people aren't getting an inferior product.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I'll take your word for it. The wine's already gone to my head.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Ewald Alphonso (R): ""I really must insist.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I didn't know any better, I'd say you two were trying to get me drunk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Ewald Alphonso (R): ""One does not get merely 'drunk' on Erlory Maroon 30-Year..."*)

### Węzeł `[90]`
Mówca: **Ewald Alphonso (R)**
> ""I really must insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Player_Romus: ""Sorry, President Alphonso. Maybe another time.""*)
  - -> `[411]` (*Player_Romus: ""Well... I can't say no to Sordish hospitality. I'll just..."*)

### Węzeł `[91]`
Mówca: **Ewald Alphonso (R)**
> ""One does not get merely 'drunk' on Erlory Maroon 30-Year-Old. One floats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this is as good as you say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Gus Manger (R): ""It's even better.""*)

### Węzeł `[93]`
Mówca: **Ewald Alphonso (R)**
> ""That's because they've never tried this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He opened his attache and pulled out a bottle of Erlory M..."*)

### Węzeł `[94]`
Mówca: **Gus Manger (R)**
> ""Call it an aperitif.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Alphonso opened his attache and pulled out a bottle of Er..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Alphonso opened his attache and pulled out a bottle of Erlory Maroon 30-Year-Old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Gus Manger (R): ""Our turn to be the connoisseurs, Your Majesty. Butler! T..."*)

### Węzeł `[96]`
Mówca: **Gus Manger (R)**
> ""It's even better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "The yacht lingered at the mouth of the Zpana delta as the sun lowered in the sky, turning the water from turquoise to gold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Ewald Alphonso (R): ""As much as Sordland's most valued citizens would appreci..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "A series of looks passed between Gus and Alphonso. They turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gus Manger (R): ""A shame, Your Majesty. But I do have one more proposal f..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland = true;
RiziaDLC.Country_Tourism += 1;
RiziaDLC.Diplomacy_Sordland_NegotiatingPower += 1;
RiziaDLCSupport.Journal_Turn02_Sordland_Whisky = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland"] = true;
Variable["RiziaDLC.Country_Tourism"] = Variable["RiziaDLC.Country_Tourism"] + 1;
Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] + 1;
Variable["RiziaDLCSupport.Journal_Turn02_Sordland_Whisky"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Ewald Alphonso (R): ""Excellent, Your Majesty. Another reason for me to return..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Yes, sure. Now can we get to the real reason why you're here?" [Trade Deal]"]** — Mówca: **Player_Romus**
> ""Yes, sure. Now can we get to the real reason why you're here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, sorry. I'd rather not bring more hard liquor into this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[102]`
Mówca: **Gus Manger (R)**
> ""A shame, Your Majesty. But I do have one more proposal for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "The yacht lingered at the mouth of the Zpana delta as the..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland = true;
RiziaDLC.Diplomacy_Sordland_NegotiatingPower += 1;
RiziaDLC.Country_Tourism += 1;
RiziaDLCSupport.Journal_Turn02_Sordland_Whisky = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland"] = true;
Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] + 1;
Variable["RiziaDLC.Country_Tourism"] = Variable["RiziaDLC.Country_Tourism"] + 1;
Variable["RiziaDLCSupport.Journal_Turn02_Sordland_Whisky"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Ewald Alphonso (R): ""Excellent, Your Majesty. And yes, there is one more prop..."*)

### Węzeł `[104]`
Mówca: **Ewald Alphonso (R)**
> ""Excellent, Your Majesty. And yes, there is one more proposal we wanted to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "The yacht lingered at the mouth of the Zpana delta as the..."*)

### Węzeł `[105]`
Mówca: **Ewald Alphonso (R)**
> ""As much as Sordland's most valued citizens would appreciate your wine, we believe there's something else they'd find even more stunning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He gestured at his surroundings, then down at the short-s..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "He gestured at his surroundings, then down at the short-sleeved shirt he was wearing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Gus Manger (R): ""Have you thought about Rizia's untapped tourism potentia..."*)

### Węzeł `[107]`
Mówca: **Gus Manger (R)**
> ""Have you thought about Rizia's untapped tourism potential, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player_Romus: ""Yes, many times. Our beaches put Lespia's to shame, afte..."*)
  - -> `[108]` (*Player_Romus: ""I'm afraid our conflicts with our neighbors would scare ..."*)
  - -> `[110]` (*Player_Romus: ""We only want the right kind of tourists, Mr. Manger. No ..."*)
  - -> `[111]` (*Player_Romus: ""I'm listening...""*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid our conflicts with our neighbors would scare off visitors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Gus Manger (R): ""Still, Your Majesty?""*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, many times. Our beaches put Lespia's to shame, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Gus Manger (R): ""They're true diamonds in the rough.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We only want the right kind of tourists, Mr. Manger. No riff-raff.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger (R): ""None indeed.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm listening...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Gus Manger (R): ""Porte Drazon is gorgeous enough. But your beaches!""*)

### Węzeł `[112]`
Mówca: **Gus Manger (R)**
> ""I took the liberty of hiring a designer to draw this up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "He reached inside his jacket pocket and pulled out a shee..."*)

### Węzeł `[113]`
Mówca: **Gus Manger (R)**
> ""None indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Gus Manger (R): ""I know that for a long time, international tourists stay..."*)

### Węzeł `[114]`
Mówca: **Gus Manger (R)**
> ""Still, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Gus Manger (R): ""I know that for a long time, international tourists stay..."*)

### Węzeł `[115]`
Mówca: **Gus Manger (R)**
> ""They're true diamonds in the rough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Gus Manger (R): ""I know that for a long time, international tourists stay..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "He reached inside his jacket pocket and pulled out a sheet of paper with a sketch on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I recognized the beach it depicted. It was a picturesque ..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "I recognized the beach it depicted. It was a picturesque stretch of sand in Monqiz, not far from the palace where I'd grown up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Right on the coastline, the designer had placed a sprawli..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Right on the coastline, the designer had placed a sprawling complex with a swimming pool and tennis courts. On it was a sign: "Koronti Resort Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""House Toras would never stand for this.""*)
  - -> `[120]` (*Player_Romus: ""No. I'm not bringing Sordish new money to Rizia.""*)
  - -> `[122]` (*Player_Romus: ""It's missing a private pier.""*)
  - -> `[123]` (*Player_Romus: ""Would that be the senior or the junior Koronti?""*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras would never stand for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Gus Manger (R): ""You are the head of House Toras, are you not?""*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm not bringing Sordish new money to Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Gus Manger (R): ""New money, old money -- it's all money. And the investor..."*)

### Węzeł `[121]`
Mówca: **Gus Manger (R)**
> ""New money, old money -- it's all money. And the investors behind this proposal are itching to spend theirs here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ewald Alphonso (R): ""Our partners are considering significant investment alon..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's missing a private pier.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Gus Manger (R): ""It's only a rough sketch, Your Majesty. But yes, a priva..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would that be the senior or the junior Koronti?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Gus Manger (R): ""You've done your research, I see. This is Marcel's initi..."*)

### Węzeł `[124]`
Mówca: **Gus Manger (R)**
> ""It's only a rough sketch, Your Majesty. But yes, a private pier would go without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ewald Alphonso (R): ""Our partners are considering significant investment alon..."*)

### Węzeł `[125]`
Mówca: **Gus Manger (R)**
> ""You are the head of House Toras, are you not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ewald Alphonso (R): ""Our partners are considering significant investment alon..."*)

### Węzeł `[126]`
Mówca: **Gus Manger (R)**
> ""You've done your research, I see. This is Marcel's initiative. Along with certain other members of the Lotherberg Group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ewald Alphonso (R): ""Our partners are considering significant investment alon..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Alphonso swirled the last drops of whiskey around in his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ewald Alphonso (R): ""I'm aware of how your nobles see Sordish oligarchs. I'm ..."*)

### Węzeł `[128]`
Mówca: **Ewald Alphonso (R)**
> ""I'm aware of how your nobles see Sordish oligarchs. I'm also aware that their world-renowned riches have diminished with each successive generation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Ewald Alphonso (R): ""Change is not merely inevitable, Your Majesty -- it's th..."*)

### Węzeł `[129]`
Mówca: **Ewald Alphonso (R)**
> ""Change is not merely inevitable, Your Majesty -- it's the only way to preserve the lifestyle to which you're all so accustomed. Your grandmother understood that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: ""Lyza wouldn't have wanted a bunch of fat, sunburned vulg..."*)
  - -> `[131]` (*Player_Romus: ""We don't need Sordland's help to stay wealthy.""*)
  - -> `[132]` (*Player_Romus: ""I am the king. The nobles would have no choice but to ac..."*)
  - -> `[133]` (*Player_Romus: ""Well said, Mr. President. My relatives could use a good ..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lyza wouldn't have wanted a bunch of fat, sunburned vulgarians blocking her ocean views. No offense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Gus drew his breath in through his teeth."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need Sordland's help to stay wealthy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ewald Alphonso (R): ""We know you've got Queen Beatrice providing her protecti..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the king. The nobles would have no choice but to acquiesce.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well said, Mr. President. My relatives could use a good shock to the system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gus Manger (R): ""So that's a yes on the proposal?""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gus Manger (R): ""So that's a yes on the proposal?""*)

### Węzeł `[135]`
Mówca: **Gus Manger (R)**
> ""So that's a yes on the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[138]` (*Player_Romus: ""It is indeed. I hope I'm invited to the grand opening." ..."*)
  - -> `[150]` (*Player_Romus: ""Yes. As long as the final design is less gaudy." [Resort..."*)
  - -> `[152]` (*Player_Romus: ""No. I do want to open Rizia up to the world, but I'd rat..."*)

### Węzeł `[136]`
Mówca: **Ewald Alphonso (R)**
> ""Our partners are considering significant investment along the Valenqiris coast. If all went well, the Koronti resort would only be the first step.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Alphonso swirled the last drops of whiskey around in his ..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Gus drew his breath in through his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gus Manger (R): ""You too, eh? We'll assume that's a no on the proposal, t..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""It is indeed. I hope I'm invited to the grand opening." [Resort Deal]"]** — Mówca: **Player_Romus**
> ""It is indeed. I hope I'm invited to the grand opening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Gus laughed."*)

### Węzeł `[139]`
Mówca: **Gus Manger (R)**
> ""You too, eh? We'll assume that's a no on the proposal, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[142]` (*Player_Romus: ""Well... I don't like it, but I'd be a fool to turn down ..."*)
  - -> `[154]` (*Player_Romus: ""Your assumption is correct. Sorry to waste your time.""*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[140]`
Mówca: **Ewald Alphonso (R)**
> ""We know you've got Queen Beatrice providing her protection. We just wanted to offer you some extra insurance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Gus Manger (R): ""But we'll assume that's a no on the proposal, then?""*)

### Węzeł `[141]`
Mówca: **Gus Manger (R)**
> ""But we'll assume that's a no on the proposal, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[142]` (*Player_Romus: ""Well... I don't like it, but I'd be a fool to turn down ..."*)
  - -> `[154]` (*Player_Romus: ""Your assumption is correct. Sorry to waste your time.""*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Well... I don't like it, but I'd be a fool to turn down your oligarchs' investment. The answer is yes." [Resort Deal]"]** — Mówca: **Player_Romus**
> ""Well... I don't like it, but I'd be a fool to turn down your oligarchs' investment. The answer is yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Gus Manger (R)), `[141]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "They glanced at each other in surprise."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're already getting our wine. That's enough wheeling and dealing for one day.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Gus Manger (R)), `[141]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He shrugged."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: ""You're already getting our wine. That's enough wheeling ..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""No, indeed. Come back when you have better ideas.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, indeed. Come back when you have better ideas.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Gus Manger (R)), `[141]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "Alphonso frowned."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "Gus laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Gus Manger (R): ""The King will get a free stay in the largest suite. Anyt..."*)

### Węzeł `[149]`
Mówca: **Gus Manger (R)**
> ""The King will get a free stay in the largest suite. Anytime he likes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Alphonso rubbed his hands together."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Yes. As long as the final design is less gaudy." [Resort Deal]"]** — Mówca: **Player_Romus**
> ""Yes. As long as the final design is less gaudy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Ewald Alphonso (R): ""I'll pass that on to our partners.""*)

### Węzeł `[151]`
Mówca: **Ewald Alphonso (R)**
> ""I'll pass that on to our partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Alphonso rubbed his hands together."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I do want to open Rizia up to the world, but I'd rather explore other avenues.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Ewald Alphonso (R): ""I see.""*)

### Węzeł `[153]`
Mówca: **Ewald Alphonso (R)**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your assumption is correct. Sorry to waste your time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Gus Manger (R)), `[141]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Gus Manger (R): ""Fair enough.""*)

### Węzeł `[156]`
Mówca: **Gus Manger (R)**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Ewald Alphonso (R): ""One trade deal is already more than our predecessors man..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "They glanced at each other in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Ewald Alphonso (R): ""Well. I'm glad we have an understanding!""*)

### Węzeł `[158]`
Mówca: **Ewald Alphonso (R)**
> ""Well. I'm glad we have an understanding!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal = true; Ri..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Alphonso shrugged."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Ewald Alphonso (R): ""So the door between our countries will remain closed. Fo..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "Alphonso shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Ewald Alphonso (R): ""One trade deal is already more than our predecessors man..."*)

### Węzeł `[163]`
Mówca: **Ewald Alphonso (R)**
> ""One trade deal is already more than our predecessors managed in 30 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Gus Manger (R): ""Yes, that alone calls for a celebration. Butler! Another..."*)

### Węzeł `[164]`
Mówca: **Ewald Alphonso (R)**
> ""So the door between our countries will remain closed. For now, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Gus Manger (R): ""Rusty led me to believe you were more open-minded than y..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Alphonso rubbed his hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal = true; Ri..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Ewald Alphonso (R): ""In less than an hour, we've accomplished more for our co..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Ewald Alphonso (R): ""If the wine will not come to Sordland, Sordland will com..."*)

### Węzeł `[169]`
Mówca: **Ewald Alphonso (R)**
> ""In less than an hour, we've accomplished more for our countries than our predecessors managed in 30 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[170]`
Mówca: **Ewald Alphonso (R)**
> ""If the wine will not come to Sordland, Sordland will come to the wine. I'm satisfied with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[171]`
Mówca: **Gus Manger (R)**
> ""Rusty led me to believe you were more open-minded than your father. A shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[172]`
Mówca: **Gus Manger (R)**
> ""There's only one opportunity that matters to me right now. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""His name is Pabel Adria. Show some respect.""*)
  - -> `[199]` (*Player_Romus: ""That's enough, Mr. Manger. I'm cutting you off.""*)
  - -> `[177]` (*Player_Romus: ""He's my butler, not yours. Pabel!""*)
  - -> `[178]` (*Player_Romus: ""You heard the man, Pabel.""*)

### Węzeł `[173]`
Mówca: **Gus Manger (R)**
> ""But no wine in Sordland means that we'd better get our fill of Cantuavo while we're here. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""His name is Pabel Adria. Show some respect.""*)
  - -> `[199]` (*Player_Romus: ""That's enough, Mr. Manger. I'm cutting you off.""*)
  - -> `[177]` (*Player_Romus: ""He's my butler, not yours. Pabel!""*)
  - -> `[178]` (*Player_Romus: ""You heard the man, Pabel.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His name is Pabel Adria. Show some respect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Gus Manger (R)), `[173]` (Gus Manger (R)), `[175]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel += 1"*)

### Węzeł `[175]`
Mówca: **Gus Manger (R)**
> ""Yes, that alone calls for a celebration. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""His name is Pabel Adria. Show some respect.""*)
  - -> `[199]` (*Player_Romus: ""That's enough, Mr. Manger. I'm cutting you off.""*)
  - -> `[177]` (*Player_Romus: ""He's my butler, not yours. Pabel!""*)
  - -> `[178]` (*Player_Romus: ""You heard the man, Pabel.""*)

### Węzeł `[176]`
Mówca: **Gus Manger (R)**
> ""I'd say that calls for a celebration. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""His name is Pabel Adria. Show some respect.""*)
  - -> `[199]` (*Player_Romus: ""That's enough, Mr. Manger. I'm cutting you off.""*)
  - -> `[177]` (*Player_Romus: ""He's my butler, not yours. Pabel!""*)
  - -> `[178]` (*Player_Romus: ""You heard the man, Pabel.""*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's my butler, not yours. Pabel!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Gus Manger (R)), `[173]` (Gus Manger (R)), `[175]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You heard the man, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Gus Manger (R)), `[173]` (Gus Manger (R)), `[175]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Pabel reappeared, another bottle in his hands. He filled our glasses with a look of annoyance that only I could detect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Pabel reappeared, another bottle in his hands. He shot me a grateful look as he filled our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "The yacht began to turn back towards Porte Drazon as the ..."*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Gus Manger (R): ""I stand corrected. Mr. Adria, if you would be so kind.""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Pabel reappeared, another bottle in his hands. He filled ..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Pabel reappeared, another bottle in his hands. He filled ..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Pabel reappeared, another bottle in his hands. He filled our glasses, a neutral expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[186]`
Mówca: **Narrator**
> "The yacht began to turn back towards Porte Drazon as the sun disappeared over the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)

### Węzeł `[187]`
Mówca: **Ewald Alphonso (R)**
> ""The Colonel was no great fan of monarchies, as you'll recall. Me? I'm more flexible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""For such an anti-monarchist, he behaved an awful lot lik..."*)
  - -> `[189]` (*Player_Romus: ""The only difference between your republic and our monarc..."*)
  - -> `[190]` (*Player_Romus: ""Nor was my father keen on democracy. You and I have much..."*)
  - -> `[195]` (*Player_Romus: ""Countries with differing politics can still find common ..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For such an anti-monarchist, he behaved an awful lot like a king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Ewald Alphonso (R): ""By the end, maybe. I wish we'd parted ways on better ter..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only difference between your republic and our monarchy is that the Rizian people are happier.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Ewald Alphonso (R): ""Are you sure that's not just because of your splendid we..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor was my father keen on democracy. You and I have much in common.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[191]`
Mówca: **Ewald Alphonso (R)**
> ""Are you sure that's not just because of your splendid weather?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Ewald Alphonso (R): ""Or it could be the booze...""*)

### Węzeł `[192]`
Mówca: **Ewald Alphonso (R)**
> ""Gus said he thought we'd get along. Speak of the devil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Gus Manger emerged from the ship's cabin, clutching a bot..."*)

### Węzeł `[193]`
Mówca: **Ewald Alphonso (R)**
> ""By the end, maybe. I wish we'd parted ways on better terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Ewald Alphonso (R): ""I know one man who's happy for a clean break, though.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Ewald Alphonso (R): ""Gus said he thought we'd get along. Speak of the devil.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Countries with differing politics can still find common ground.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Ewald Alphonso (R): ""Exactly.""*)

### Węzeł `[196]`
Mówca: **Ewald Alphonso (R)**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Gus Manger emerged from the ship's cabin, clutching a bot..."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "Alphonso frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Ewald Alphonso (R): ""So the door between our countries will remain closed. Fo..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal = true; RiziaDLCSupport.Journal_Turn02_Sordland_Resort = true;
EnableCollectionItem("CollectionItem_KorontiResortPostcard");
RiziaDLC.Diplomacy_Sordland_NegotiatingPower += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Sordland_Resort"] = true;
EnableCollectionItem("CollectionItem_KorontiResortPostcard");
Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's enough, Mr. Manger. I'm cutting you off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Gus Manger (R)), `[173]` (Gus Manger (R)), `[175]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Gus Manger (R): ""I'll see you in Sordland, then, beautiful.""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Gus Manger (R): ""I'll see you on our next visit, then, beautiful.""*)

### Węzeł `[203]`
Mówca: **Gus Manger (R)**
> ""I'll see you in Sordland, then, beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He waved a wistful goodbye to the bottle Pabel was holdin..."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "He waved a wistful goodbye to the bottle Pabel was holding in his hands. My butler gave a brisk, professional nod and disappeared back into the cabin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "The yacht began to turn back towards Porte Drazon as the ..."*)

### Węzeł `[205]`
Mówca: **Gus Manger (R)**
> ""I'll see you on our next visit, then, beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He waved a wistful goodbye to the bottle Pabel was holdin..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "After hours of diplomatic formalities in Palas Rezna, the sea breeze felt amazing. Alphonso removed his jacket and looked up admiringly at the wide cable bridge that connected Porte Drazon's two halves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Ewald Alphonso (R): ""What a great idea this boat tour was. It would have been..."*)

### Węzeł `[207]`
Mówca: **Ewald Alphonso (R)**
> ""A beautiful, elegant old palace. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The ship's horn let out a blast as we passed beneath the ..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "He rushed to correct himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Ewald Alphonso (R): ""A beautiful, elegant old palace. Your Majesty.""*)

### Węzeł `[209]`
Mówca: **Ewald Alphonso (R)**
> ""I know one man who's happy for a clean break, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Gus Manger emerged from the ship's cabin, clutching a bot..."*)

### Węzeł `[210]`
Mówca: **Ewald Alphonso (R)**
> ""Or it could be the booze...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Gus Manger emerged from the ship's cabin, clutching a bot..."*)

### Węzeł `[211]`
Mówca: **Gus Manger (R)**
> ""Last I saw, your treasury crone was in the cabin reading over the terms of the proposal. Shall we haul her up and hash this out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player_Romus: ""You're in Rizia. Mr. Manger. We treat women like equals ..."*)
  - -> `[217]` (*Player_Romus: ""Don't call Ms. Werner a crone. She's one of my most capa..."*)
  - -> `[218]` (*Player_Romus: ""Sorry I had to bring along the wet blanket. I would've p..."*)
  - -> `[219]` (*Player_Romus: ""Yes, let's.""*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Gus Manger (R): ""Last I saw, your treasury crone was in the cabin reading..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Gus Manger (R): ""Since your treasury crone isn't here to put a damper on ..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're in Rizia. Mr. Manger. We treat women like equals here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Alphonso gave Gus a look of warning."*)

### Węzeł `[216]`
Mówca: **Gus Manger (R)**
> ""Since your treasury crone isn't here to put a damper on proceedings, should we get straight to it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player_Romus: ""Yes, let's.""*)
  - -> `[220]` (*Player_Romus: ""You're in Rizia. Mr. Manger. We treat women like equals ..."*)
  - -> `[234]` (*Player_Romus: ""Don't call Ms. Werner a crone. She's one of my most capa..."*)
  - -> `[238]` (*Player_Romus: ""Yes, let's work this out between us men. No wet blanket ..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't call Ms. Werner a crone. She's one of my most capable councilors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Alphonso gave Gus a look of warning."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry I had to bring along the wet blanket. I would've preferred a men's night out, too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Ewald Alphonso (R): ""It could have been worse. Imagine if Nia Morgna were her..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, let's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Gus Manger (R)), `[216]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're in Rizia. Mr. Manger. We treat women like equals here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Alphonso gave Gus a look of warning."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "Pabel poured me a small amount with an apologetic shrug."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "Pabel poured us each a small amount of the amber-colored ..."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "Pabel poured me a small amount with an apologetic shrug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ewald Alphonso (R): ""I'll do the toast this time. How do you people say it? A..."*)

### Węzeł `[225]`
Mówca: **Narrator**
> "Pabel poured us each a small amount of the amber-colored liquid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ewald Alphonso (R): ""I'll do the toast this time. How do you people say it? A..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "It was my first taste of alcohol since my wilder days. Visions of broken villa windows and weekend-long blackouts came to me unbidden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon = true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "The taste brought back memories of my wilder days. Vision..."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "The taste brought back memories of my wilder days. Visions of broken villa windows and weekend-long blackouts came to me unbidden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""It's heavenly.""*)
  - -> `[35]` (*Player_Romus: ""Disgusting. Why would anyone want a drink that tastes li..."*)
  - -> `[36]` (*Player_Romus: ""It's great, but I'd better not have any more.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't call Ms. Werner a crone. She's one of my most capable councilors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Alphonso gave Gus a look of warning."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "Alphonso gave Gus a look of warning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Ewald Alphonso (R): ""I apologize on behalf of my minister. I told him to leav..."*)

### Węzeł `[236]`
Mówca: **Ewald Alphonso (R)**
> ""I apologize on behalf of my minister. I told him to leave his baser impulses at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Ewald Alphonso (R): ""I assure you Sordland is making progress on the status o..."*)

### Węzeł `[237]`
Mówca: **Ewald Alphonso (R)**
> ""It could have been worse. Imagine if Nia Morgna were here, Gus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Gus laughed and shifted his voice to a higher register."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, let's work this out between us men. No wet blanket necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Ewald Alphonso (R): ""I'm glad you understand. Imagine if Nia Morgna were here..."*)

### Węzeł `[239]`
Mówca: **Gus Manger (R)**
> ""'You can't bring the King whiskey, Mr. President! That's bribery!'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Gus laughed and shifted his voice to a higher register."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Gus Manger (R): ""'You can't bring the King whiskey, Mr. President! That's..."*)

### Węzeł `[241]`
Mówca: **Ewald Alphonso (R)**
> ""I assure you Sordland is making progress on the status of women. Some of my most trusted ministers belong to the fairer sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[242]`
Mówca: **Ewald Alphonso (R)**
> ""I'm glad you understand. Imagine if Nia Morgna were here, Gus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Gus laughed and shifted his voice to a higher register."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "Pabel ducked into the ship's cabin and re-emerged with Elena. My treasury councilor looked slightly seasick."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Elena Werner: ""Pardon my absence, gentlemen. Despite my Valgish ancestr..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == tr..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Pabel ducked into the ship's cabin and re-emerged with El..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "Alphonso reopened his briefcase and took out some paperwork."*)

### Węzeł `[247]`
Mówca: **Elena Werner**
> ""Pardon my absence, gentlemen. Despite my Valgish ancestry, I never warmed up to boat travel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Elena Werner: ""The draft agreement seems sound. But I had a question ab..."*)

### Węzeł `[248]`
Mówca: **Elena Werner**
> ""The draft agreement seems sound. But I had a question about the section regarding quantities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Elena Werner: ""You're proposing an equal amount of wine and whiskey be ..."*)

### Węzeł `[249]`
Mówca: **Elena Werner**
> ""You're proposing an equal amount of wine and whiskey be traded per year, when more demand currently exists for the former than the latter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""If demand for whiskey doesn't exist in Rizia, we'll just..."*)
  - -> `[251]` (*Player_Romus: ""See, this is why I brought her along.""*)
  - -> `[255]` (*Player_Romus: ""Reopening trade channels to sell us useless whiskey. Wha..."*)
  - -> `[252]` (*Player_Romus: ""Is there another way we can rephrase this, Mr. President?""*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If demand for whiskey doesn't exist in Rizia, we'll just have to find a way to create it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Gus Manger (R): ""It won't be difficult. This whiskey speaks for itself.""*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See, this is why I brought her along.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Ewald Alphonso (R): ""Good catch, Ms. Werner.""*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there another way we can rephrase this, Mr. President?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Ewald Alphonso (R): ""Good catch, Ms. Werner.""*)

### Węzeł `[253]`
Mówca: **Narrator**
> "Alphonso reopened his briefcase and took out some paperwork."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Ewald Alphonso (R): ""It's all boilerplate, really.""*)

### Węzeł `[254]`
Mówca: **Ewald Alphonso (R)**
> ""It's all boilerplate, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Ewald Alphonso (R): ""The governments of Rizia and Sordland, recognizing the i..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reopening trade channels to sell us useless whiskey. What a swindle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Ewald Alphonso (R): ""Good catch, Ms. Werner.""*)

### Węzeł `[256]`
Mówca: **Ewald Alphonso (R)**
> ""The governments of Rizia and Sordland, recognizing the importance of promoting economic growth and cooperation and desiring to enhance their mutual interests...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Ewald Alphonso (R): ""...conducted in a manner that is consistent with their r..."*)

### Węzeł `[257]`
Mówca: **Ewald Alphonso (R)**
> ""...conducted in a manner that is consistent with their respective domestic laws and regulations...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player_Romus: ""Sounds legitimate. No need to go on.""*)
  - -> `[260]` (*Player_Romus_Italic: "Keep listening."*)

### Węzeł `[258]`
Mówca: **Ewald Alphonso (R)**
> ""...the parties shall agree to cooperate in the development and implementation of sanitary measures...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""Stop. I've made a decision.""*)
  - -> `[262]` (*Player_Romus_Italic: "Keep listening."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds legitimate. No need to go on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Gus Manger (R): ""A wise move, Your Majesty. The fine print goes on forever.""*)

### Węzeł `[260]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "He went on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Ewald Alphonso (R): ""...the parties shall agree to cooperate in the developme..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop. I've made a decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Gus Manger (R): ""A wise move, Your Majesty. The fine print goes on forever.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "He went on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Ewald Alphonso (R): ""...elimination of tariffs to be completed within six mon..."*)

### Węzeł `[263]`
Mówca: **Ewald Alphonso (R)**
> ""...elimination of tariffs to be completed within six months from the entry into force...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Player_Romus: ""Seems straightforward enough. Here's what I've decided.""*)
  - -> `[266]` (*Player_Romus_Italic: "Keep listening."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seems straightforward enough. Here's what I've decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Gus Manger (R): ""Phew. I thought that would never end.""*)

### Węzeł `[265]`
Mówca: **Ewald Alphonso (R)**
> ""...ensuring that respective customs procedures and other trade-related measures are transparent, efficient and predictable...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""I get the picture.""*)
  - -> `[268]` (*Player_Romus_Italic: "Keep listening."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "He went on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Ewald Alphonso (R): ""...ensuring that respective customs procedures and other..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get the picture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Gus Manger (R): ""Phew. I thought that would never end.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "He went on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Ewald Alphonso (R): ""...in equal amounts of 100 tons of wine and 50 barrels o..."*)

### Węzeł `[269]`
Mówca: **Ewald Alphonso (R)**
> ""...in equal amounts of 100 tons of wine and 50 barrels of whisky per year, subject to availability...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Okay. Here's what I want to do.""*)
  - -> `[270]` (*Player_Romus: ""Wait.""*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Ewald Alphonso (R): ""Yes?""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. Here's what I want to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Gus Manger (R): ""Phew. I thought that would never end.""*)

### Węzeł `[272]`
Mówca: **Gus Manger (R)**
> ""Phew. I thought that would never end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Sordland_WhiskeySurplus = true"*)

### Węzeł `[273]`
Mówca: **Gus Manger (R)**
> ""A wise move, Your Majesty. The fine print goes on forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Sordland_WhiskeySurplus = true"*)

### Węzeł `[274]`
Mówca: **Ewald Alphonso (R)**
> ""Yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""Equal amounts? Demand for Rizian wine in Sordland is far..."*)
  - -> `[276]` (*Player_Romus: ""I've heard enough.""*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Equal amounts? Demand for Rizian wine in Sordland is far higher than that for Sordish whiskey in Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Ewald Alphonso (R): ""Hrm. Good catch.""*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Gus Manger (R): ""A wise move, Your Majesty. The fine print goes on forever.""*)

### Węzeł `[277]`
Mówca: **Ewald Alphonso (R)**
> ""Good catch, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Ewald Alphonso (R): ""We can change that section if you like. 'Quantities subj..."*)

### Węzeł `[278]`
Mówca: **Ewald Alphonso (R)**
> ""We can change that section if you like. 'Quantities subject to market demand.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Gus Manger (R): ""Demand in Rizia will skyrocket once Erlory Maroon hits t..."*)

### Węzeł `[279]`
Mówca: **Gus Manger (R)**
> ""It won't be difficult. This whiskey speaks for itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Sordland_WhiskeySurplus = true"*)

### Węzeł `[280]`
Mówca: **Gus Manger (R)**
> ""Demand in Rizia will skyrocket once Erlory Maroon hits the market. Trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ewald Alphonso (R): ""So, is it a trade, Your Majesty?""*)

### Węzeł `[281]`
Mówca: **Ewald Alphonso (R)**
> ""Hrm. Good catch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Ewald Alphonso (R): ""We can change that section if you like. 'Quantities subj..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Sordland_WhiskeySurplus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Sordland_WhiskeySurplus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ewald Alphonso (R): ""So, is it a trade, Your Majesty?""*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Elena raised her eyebrows but stayed silent. Gus and Alph..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "A series of looks passed between Gus and Alphonso. They t..."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Elena raised her eyebrows but stayed silent. Gus and Alphonso exchanged a series of looks, then turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gus Manger (R): ""A shame, Your Majesty. But I do have one more proposal f..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Elena flipped open her ledger and made a quick note."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal = t..."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "Elena flipped open her ledger and made a quick note."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal = t..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Elena flipped open her ledger and made a quick note."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal = t..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Elena flipped open her ledger and made a quick note."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal = t..."*)

### Węzeł `[295]`
Mówca: **Gus Manger (R)**
> ""I know that for a long time, international tourists stayed away from the Valenqiris coast because of the delicate situation with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He pronounced the last word as "pails.""*)

### Węzeł `[296]`
Mówca: **Gus Manger (R)**
> ""Porte Drazon is gorgeous enough. But your beaches!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Gus Manger (R): ""I know that for a long time, international tourists stay..."*)

### Węzeł `[297]`
Mówca: **Elena Werner**
> ""It's 'Pall-ey', Mr. Manger. Rhymes with 'ballet'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Gus Manger (R): ""Oh. Sorry, I've never had the occasion to speak the name..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Elena Werner: ""It's 'Pall-ey', Mr. Manger. Rhymes with 'ballet'.""*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Player_Romus: ""Yes, relations with *pall-ey* have been shaky for years.""*)
  - -> `[303]` (*Player_Romus: ""It's 'pall-ey'. Rhymes with 'ballet'.""*)
  - -> `[304]` (*Player_Romus_Italic: "Don't correct him."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, relations with *pall-ey* have been shaky for years.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[302]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "He didn't seem to notice my correction."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "He pronounced the last word as "pails.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's 'pall-ey'. Rhymes with 'ballet'.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[302]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Gus Manger (R): ""Oh. Sorry, I've never had the occasion to speak the name..."*)

### Węzeł `[304]`
**[WYBÓR GRACZA: "Don't correct him."]** — Mówca: **Player_Romus_Italic**
> "I refrained from speaking up."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[302]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Gus Manger (R): ""My point is that it might finally be time to bring your ..."*)

### Węzeł `[305]`
Mówca: **Gus Manger (R)**
> ""Oh. Sorry, I've never had the occasion to speak the name aloud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Gus Manger (R): ""My point is that it might finally be time to bring your ..."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "He didn't seem to notice my correction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Gus Manger (R): ""My point is that it might finally be time to bring your ..."*)

### Węzeł `[307]`
Mówca: **Gus Manger (R)**
> ""My point is that it might finally be time to bring your underdeveloped shores to life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Gus Manger (R): ""I took the liberty of hiring a designer to draw this up.""*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not so fast. Let me confer with Elena.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Kontekst wejściowy (poprzednik):** `[135]` (Gus Manger (R)), `[139]` (Gus Manger (R)), `[141]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Ewald Alphonso (R): ""As you wish, Your Majesty.""*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""Not so fast. Let me confer with Elena.""*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[312]`
Mówca: **Narrator**
> "The Sordish visitors waited outside as Elena and I walked into the cabin to talk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: ""So what do you think?""*)
  - -> `[315]` (*Player_Romus: ""This is exactly what I was worried about. Sords waltzing..."*)
  - -> `[316]` (*Player_Romus: ""You served under Queen Lyza. Would she have wanted this?""*)

### Węzeł `[313]`
Mówca: **Ewald Alphonso (R)**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "The Sordish visitors waited outside as Elena and I walked..."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So what do you think?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Elena Werner: ""If I may speak freely... I don't think it's a bad idea.""*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is exactly what I was worried about. Sords waltzing in here and disrespecting our nobility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Elena Werner: ""Their attitude leaves something to be desired, yes.""*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You served under Queen Lyza. Would she have wanted this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Elena Werner: ""Well... Lyza did everything in her power to transform Ri..."*)

### Węzeł `[317]`
Mówca: **Elena Werner**
> ""If I may speak freely... I don't think it's a bad idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player_Romus: ""Why not?""*)
  - -> `[324]` (*Player_Romus: ""You're not a Toras. You don't understand.""*)
  - -> `[323]` (*Player_Romus: ""Okay. That's all I wanted to know.""*)

### Węzeł `[318]`
Mówca: **Elena Werner**
> ""Their attitude leaves something to be desired, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Elena Werner: ""But if I may speak freely... I don't think it's a bad id..."*)

### Węzeł `[319]`
Mówca: **Elena Werner**
> ""Well... Lyza did everything in her power to transform Rizia into a modern, enlightened nation. But she was also a proud Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Elena Werner: ""I'm not sure she would have wanted to see her house's pr..."*)

### Węzeł `[320]`
Mówca: **Elena Werner**
> ""I'm not sure she would have wanted to see her house's pride and joy become a stomping ground for Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Elena Werner: ""But if I may speak freely... I don't think it's a bad id..."*)

### Węzeł `[321]`
Mówca: **Elena Werner**
> ""But if I may speak freely... I don't think it's a bad idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player_Romus: ""Why not?""*)
  - -> `[324]` (*Player_Romus: ""You're not a Toras. You don't understand.""*)
  - -> `[328]` (*Player_Romus: ""Neither do I. But I wanted to hear your reasoning.""*)
  - -> `[323]` (*Player_Romus: ""Okay. That's all I wanted to know.""*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Elena Werner), `[321]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Elena Werner: ""You must remember that I'm from Valenqiris.""*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. That's all I wanted to know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Elena Werner), `[321]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Elena Werner: ""Shall we get back out on deck?""*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not a Toras. You don't understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Elena Werner), `[321]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Elena Werner: ""I do, though. You must remember that I'm from Valenqiris.""*)

### Węzeł `[325]`
Mówca: **Elena Werner**
> ""I do, though. You must remember that I'm from Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Elena Werner: ""I grew up just minutes away from those beaches, but it w..."*)

### Węzeł `[326]`
Mówca: **Elena Werner**
> ""You must remember that I'm from Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Elena Werner: ""I grew up just minutes away from those beaches, but it w..."*)

### Węzeł `[327]`
Mówca: **Elena Werner**
> ""I grew up just minutes away from those beaches, but it wasn't until I became a councilor that I had the pull to bring my family there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Elena Werner: ""That resort wouldn't just open the Valenqiris coast up t..."*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neither do I. But I wanted to hear your reasoning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Elena Werner: ""You must remember that I'm from Valenqiris.""*)

### Węzeł `[329]`
Mówca: **Elena Werner**
> ""Monqiz is far enough up the coast that it'd be insulated from any fighting. We might have a problem if the Sords take Pales' side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Elena Werner: ""Then again, the obscenely wealthy have never had a probl..."*)

### Węzeł `[330]`
Mówca: **Elena Werner**
> ""That resort wouldn't just open the Valenqiris coast up to Sordland. It'd open it up to the rest of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Elena Werner: ""Shall we get back out on deck?""*)
  - -> `[390]` (*Player_Romus: ""That's exactly what my relatives are worried about.""*)
  - -> `[391]` (*Player_Romus: ""The resort is still private property. Commoners would ba..."*)
  - -> `[392]` (*Player_Romus: ""Unless we get back into another conflict with 'Pails.'""*)

### Węzeł `[331]`
Mówca: **Elena Werner**
> ""Then again, the obscenely wealthy have never had a problem with going on holiday in politically objectionable territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Elena Werner: ""Shall we get back out on deck?""*)

### Węzeł `[332]`
Mówca: **Elena Werner**
> ""Shall we get back out on deck?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player_Romus: ""Yes, I've made my decision.""*)
  - -> `[334]` (*Player_Romus: ""We shall. Thank you for sharing your opinion.""*)
  - -> `[335]` (*Player_Romus: ""If we must..""*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I've made my decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "We stepped back out into the waning sunlight and rejoined..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shall. Thank you for sharing your opinion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "We stepped back out into the waning sunlight and rejoined..."*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we must..""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "We stepped back out into the waning sunlight and rejoined..."*)

### Węzeł `[336]`
Mówca: **Narrator**
> "We stepped back out into the waning sunlight and rejoined Alphonso and Gus Manger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Ewald Alphonso (R): ""Well, Your Majesty? Are we making history today?""*)

### Węzeł `[337]`
Mówca: **Ewald Alphonso (R)**
> ""Well, Your Majesty? Are we making history today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Player_Romus: ""You have a deal. But does the resort have to be as gaudy..."*)
  - -> `[339]` (*Player_Romus: ""Just remember to invite me to the grand opening of the K..."*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[345]` (*Player_Romus: ""No, our coastline shall stay the way it is. Untouched by..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have a deal. But does the resort have to be as gaudy as the one in the picture?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Gus Manger (R): ""Ha. I'm sure our architects can come up with something m..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just remember to invite me to the grand opening of the Koronti Resort Valenqiris.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Gus Manger (R): ""You'll get a free stay in the largest suite. Anytime you..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One deal is enough for today, gentlemen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[337]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Alphonso shrugged."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player_Romus: ""One deal is enough for today, gentlemen.""*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Player_Romus: ""I'm afraid neither of your proposals appeal to me. Sorry..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid neither of your proposals appeal to me. Sorry to send you home with nothing.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[337]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "Alphonso frowned."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, our coastline shall stay the way it is. Untouched by foreign influence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Ewald Alphonso (R): ""In less than an hour, we've accomplished more for our co..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Ewald Alphonso (R): ""If the wine will not come to Sordland, Sordland will com..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal = true; RiziaDLCSupport.Journal_Turn02_Sordland_Resort = true;
EnableCollectionItem("CollectionItem_KorontiResortPostcard");
RiziaDLC.Diplomacy_Sordland_NegotiatingPower += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Sordland_Resort"] = true;
EnableCollectionItem("CollectionItem_KorontiResortPostcard");
Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[350]`
Mówca: **Gus Manger (R)**
> ""Ha. I'm sure our architects can come up with something more subtle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal = true; Ri..."*)

### Węzeł `[351]`
Mówca: **Gus Manger (R)**
> ""You'll get a free stay in the largest suite. Anytime you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal = true; Ri..."*)

### Węzeł `[352]`
Mówca: **Narrator**
> "Alphonso shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Ewald Alphonso (R): ""That's still more than our predecessors managed in the p..."*)

### Węzeł `[353]`
Mówca: **Ewald Alphonso (R)**
> ""That's still more than our predecessors managed in the past 30 years. And it leaves the door open for more dialogue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Elena Werner: ""Yes, please do get in touch should further trade opportu..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Elena Werner: ""One trade deal is still quite the feat.""*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Gus Manger (R): ""But no wine in Sordland means that we'd better get our f..."*)

### Węzeł `[357]`
Mówca: **Elena Werner**
> ""One trade deal is still quite the feat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Gus Manger (R): ""But no wine in Sordland means that we'd better get our f..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Elena Werner: ""Quite the feat indeed.""*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Gus Manger (R): ""I'd say that calls for a celebration. Butler! Another bo..."*)

### Węzeł `[361]`
Mówca: **Elena Werner**
> ""Quite the feat indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Gus Manger (R): ""I'd say that calls for a celebration. Butler! Another bo..."*)

### Węzeł `[362]`
Mówca: **Elena Werner**
> ""Yes, please do get in touch should further trade opportunities arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Gus Manger (R): ""Yes, that alone calls for a celebration. Butler! Another..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Elena Werner: ""We're still open to other trade opportunities. Please ge..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Gus Manger (R): ""Nothing to do but drown our sorrows. Butler! Another bot..."*)

### Węzeł `[366]`
Mówca: **Elena Werner**
> ""We're still open to other trade opportunities. Please get in touch if any arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Gus Manger (R): ""There's only one opportunity that matters to me right no..."*)

### Węzeł `[367]`
Mówca: **Gus Manger (R)**
> ""Nothing to do but drown our sorrows. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""That's enough, Mr. Manger. I'm cutting you off.""*)
  - -> `[177]` (*Player_Romus: ""He's my butler, not yours. Pabel!""*)
  - -> `[178]` (*Player_Romus: ""You heard the man, Pabel.""*)

### Węzeł `[368]`
Mówca: **Gus Manger (R)**
> ""I stand corrected. Mr. Adria, if you would be so kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Pabel reappeared, another bottle in his hands. He shot me..."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "I tasted mine: nothing but juice. Somehow, he had still managed to perform the switch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "The yacht began to turn back towards Porte Drazon as the ..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "I tasted mine: nothing but juice. Somehow, he had still m..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "The yacht began to turn back towards Porte Drazon as the ..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_RH_SordishTrade_BothDeals = true"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_RH_SordishTrade_ResortDeal = ..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_RH_SordishTrade_WineDeal = true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_RH_SordishTrade_NoDeals = true"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_RH_SordishTrade_ResortDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SordishTrade_ResortDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_G_SordlandVisit_Deal = true"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_RH_SordishTrade_BothDeals = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SordishTrade_BothDeals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_G_SordlandVisit_Deal = true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_RH_SordishTrade_WineDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SordishTrade_WineDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_G_SordlandVisit_Deal = true"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_RH_SordishTrade_NoDeals = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SordishTrade_NoDeals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_G_SordlandVisit_NoDeal = true"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_G_SordlandVisit_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_SordlandVisit_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Pr..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_G_SordlandVisit_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_SordlandVisit_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Pr..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn02_Monqiz_PortQueues = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_Monqiz_PortQueues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Terador_AzaroMilitaryExercise = true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's exactly what my relatives are worried about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Elena Werner: ""Yes, the rest of your house wouldn't love it. But you'd ..."*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The resort is still private property. Commoners would barely be able to afford it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Elena Werner: ""But if they did have the money, they'd be able to get in..."*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unless we get back into another conflict with 'Pails.'""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "She smiled wryly."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "She smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Elena Werner: ""Monqiz is far enough up the coast that it'd be insulated..."*)

### Węzeł `[394]`
Mówca: **Elena Werner**
> ""But if they did have the money, they'd be able to get in. There's the difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Elena Werner: ""Shall we get back out on deck?""*)

### Węzeł `[395]`
Mówca: **Elena Werner**
> ""Yes, the rest of your house wouldn't love it. But you'd still have lots of coastline to call your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Elena Werner: ""Shall we get back out on deck?""*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Breather", "R_Breather_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "My royal yacht, the Rizania, smoothly cleaved through the..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon == true"*)
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValues_FellOffWagon == true)"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Narrator: "I relished the bite. I could almost feel myself slipping ..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValues_FellOffWagon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "It was my first taste of alcohol since my wilder days. Vi..."*)

### Węzeł `[400]`
Mówca: **Narrator**
> "I relished the bite. I could almost feel myself slipping back into my old, dangerous habits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""It's heavenly.""*)
  - -> `[35]` (*Player_Romus: ""Disgusting. Why would anyone want a drink that tastes li..."*)
  - -> `[36]` (*Player_Romus: ""It's great, but I'd better not have any more.""*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValu..."*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalVa..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "It was my first taste of alcohol in years. I was surprise..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""It's heavenly.""*)
  - -> `[35]` (*Player_Romus: ""Disgusting. Why would anyone want a drink that tastes li..."*)
  - -> `[36]` (*Player_Romus: ""It's great, but I'd better not have any more.""*)

### Węzeł `[404]`
Mówca: **Narrator**
> "It was my first taste of alcohol in years. I was surprised by how pleasurable it was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon = true"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Pr..."*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn02_Monqiz_PortQueues = true"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Terador_AzaroMilitaryExercise = true"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Terador_AzaroMilitaryExercise = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Terador_AzaroMilitaryExercise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn02_Montaklar_LeisureClubShutD..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn02_Montaklar_LeisureClubShutDown = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_Montaklar_LeisureClubShutDown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PourDrink");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PourDrink");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... I can't say no to Sordish hospitality. I'll just have a little taste.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, President Alphonso. Maybe another time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Ewald Alphonso (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Narrator: "His gaze turned cool."*)

### Węzeł `[413]`
Mówca: **Narrator**
> "His gaze turned cool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Ewald Alphonso (R): ""What do you you say, Gus?""*)

### Węzeł `[414]`
Mówca: **Ewald Alphonso (R)**
> ""What do you you say, Gus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Gus Manger (R): ""I say that means more for us, Ewald.""*)

### Węzeł `[415]`
Mówca: **Gus Manger (R)**
> ""I say that means more for us, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Sordland_NegotiatingPower -= 1;"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Sordland_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Narrator: "Pabel poured each of the two Sords a small amount of the ..."*)

### Węzeł `[417]`
Mówca: **Narrator**
> "Pabel poured each of the two Sords a small amount of the amber-colored liquid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Ewald Alphonso (R): ""I'll do the toast this time. How do you people say it? A..."*)

### Węzeł `[418]`
Mówca: **Ewald Alphonso (R)**
> ""I'll do the toast this time. How do you people say it? A proso!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "They drank. A smile spread across Gus' face."*)

### Węzeł `[419]`
Mówca: **Narrator**
> "They drank. A smile spread across Gus' face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Gus Manger (R): ""That dark, woodsy flavor, that silky-smooth finish. You'..."*)

### Węzeł `[420]`
Mówca: **Gus Manger (R)**
> ""That dark, woodsy flavor, that silky-smooth finish. You're really missing out, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player_Romus: ""Just as well. If it's as good as you say, I'd never be a..."*)
  - -> `[421]` (*Player_Romus: ""Sounds heavenly.""*)
  - -> `[35]` (*Player_Romus: ""Disgusting. Why would anyone want a drink that tastes li..."*)

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds heavenly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[420]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Gus Manger (R): ""Like tasting the very soul of Erlory itself.""*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Drinking += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Drinking"] = Variable["RiziaDLC.PersonalValue_Drinking"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "We drank. The flavor rushed over my tongue -- wood smoke ..."*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just as well. If it's as good as you say, I'd never be able to stop drinking it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[420]` (Gus Manger (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Gus Manger (R): ""Your countrymen will go crazy for it, I promise.""*)

### Węzeł `[424]`
Mówca: **Gus Manger (R)**
> ""Your countrymen will go crazy for it, I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Talking trade on a boat with the President of Sordland", "Royal Yacht", "Zpana River Delta");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Talking trade on a boat with the President of Sordland","Royal Yacht","Zpana River Delta");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Breather", "R_Breather_Loop");"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""It's heavenly.""*)
  - -> `[35]` (*Player_Romus: ""Disgusting. Why would anyone want a drink that tastes li..."*)
  - -> `[36]` (*Player_Romus: ""It's great, but I'd better not have any more.""*)
