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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 24

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[99]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] = true; Variable["RiziaDLC.Poli...`
- Węzeł `[103]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] = true; Variable["RiziaDLC.Poli...`
- Węzeł `[134]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- Węzeł `[181]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- Węzeł `[194]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- Węzeł `[198]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] = true; Variable["RiziaDLCSupport.Jour...`
- Węzeł `[282]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Sordland_WhiskeySurplus"] = true;`
- Węzeł `[349]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] = true; Variable["RiziaDLCSupport.Jour...`
- *...oraz 16 innych węzłów ze skryptami.*

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
  - -> `[425]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "My royal yacht, the Rizania, smoothly cleaved through the waters of the Zpana river delta."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Ewald Alphonso (R)**
> ""What a great idea this boat tour was. It would have been a pity to spend our entire visit trapped in a stuffy old palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I stood on the deck next to Ewald Alphonso, President of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The ship's horn let out a blast as we passed beneath the bridge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "Show Alphonso the New Town."]** — Mówca: **Player_Romus_Italic**
> "I directed the Sordish president's attention to the glass skyscrapers of the New Town, where Rizia's banks and major corporations were headquartered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "Show Alphonso the Old Town."]** — Mówca: **Player_Romus_Italic**
> "I led the Sordish president to the southern side of the deck for a better view of the Old Town. The late afternoon sun perfectly illuminated the spire of the Zilba Archsanctuary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Ewald Alphonso (R)**
> ""See, this is what I like about your country. You're not afraid of the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[47]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[10]`
Mówca: **Ewald Alphonso (R)**
> ""Terrific, the way you've preserved these historic buildings. But sometimes the past can be a trap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[12]`
  - -> `[11]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, I know. I've got hundreds of years of history weighing on me every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If my grandmother hadn't made those trade deals between Rizia and Sordland, our countries would still be strangers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy your country finally has a president who understands that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not one to look backwards. Neither are you, I hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't let the razzle-dazzle fool you. Rizia is as stuck in the past as it ever was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those skyscrapers are an eyesore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Pabel smoothly appeared from behind us with three glasses. Gus handed him the bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[18]`
Mówca: **Narrator**
> "We raised our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[23]`
  - -> `[21]`
  - -> `[19]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "Drink without a toast."]** — Mówca: **Player_Romus_Italic**
> "I took a sip without bothering to toast. The two others gave me a puzzled look, then shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Ewald Alphonso (R)**
> ""To hell with tradition, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Morgna wes core!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "The two Sordish men smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To new beginnings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Ewald Alphonso (R)**
> ""And new prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To our ancestors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Gus Manger (R)**
> ""May they rest in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[27]`
Mówca: **Ewald Alphonso (R)**
> ""Ah, yes. The free trade of Rizian wine for Sordish whiskey. As good a way as any to get our relations flowing again, if you'll pardon the pun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`
  - -> `[81]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That can't be the only reason you've traveled all this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sordish whiskey? I'd have to taste it first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Ewald Alphonso (R)**
> ""I was saving this until after dinner, but here you go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "He opened his attache and pulled out a bottle of Erlory Maroon 30-Year-Old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[32]`
Mówca: **Ewald Alphonso (R)**
> ""I'll do the toast this time. How do you people say it? A proso!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[33]`
Mówca: **Narrator**
> "We drank. The flavor rushed over my tongue -- wood smoke and forest moss tapering off to a sweet, silky smooth finish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's heavenly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disgusting. Why would anyone want a drink that tastes like trees?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's great, but I'd better not have any more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Gus Manger (R)**
> ""And they say royals have sophisticated palates. Your countrymen will go crazy for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[38]`
Mówca: **Gus Manger (R)**
> ""Like tasting the very soul of Erlory itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[39]`
Mówca: **Gus Manger (R)**
> ""That's liquid gold you're leaving in your glass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[40]`
Mówca: **Ewald Alphonso (R)**
> ""So, is it a trade, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[100]`
  - -> `[42]`
  - -> `[101]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Definitely. Expect to see all our bars serving Sordish whiskey by next year." [Trade Deal]"]** — Mówca: **Player_Romus**
> ""Definitely. Expect to see all our bars serving Sordish whiskey by next year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Our wine is so superior to your whiskey that it wouldn't be fair to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[43]`
Mówca: **Ewald Alphonso (R)**
> ""Excellent, Your Majesty. Another reason for me to return to this gem of a country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[44]`
Mówca: **Ewald Alphonso (R)**
> ""But the opportunity they represent? Beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[45]`
Mówca: **Ewald Alphonso (R)**
> ""You and I are meeting, aren't we? That's already progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[46]`
Mówca: **Ewald Alphonso (R)**
> ""I owe a lot to Colonel Soll. But it's high time Sordland moved on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My grandmother was definitely thinking ahead when she made those trade deals with Sordland years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Ewald Alphonso (R)**
> ""Lyza the Great. It's not easy, living in the shadows of our predecessors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[49]`
Mówca: **Ewald Alphonso (R)**
> ""But if my forward-thinking development minister hadn't reconnected us, we'd still be estranged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[50]`
Mówca: **Ewald Alphonso (R)**
> ""Light as a feather compared to the legacy of one Colonel Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Gus Manger emerged from the ship's cabin, clutching a bottle and grinning triumphantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Gus Manger (R)**
> ""Ewald! They have it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Gus Manger (R)**
> ""I tried Cantuavo exactly once, from a Rizian chef in Holsord who smuggled it over in his steamer trunk. Haven't stopped thinking about it ever since.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He turned to me apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Gus Manger (R)**
> ""Our mutual friend Russello mentioned your yacht had an excellent wine cellar, and, well, I couldn't help myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[61]`
  - -> `[57]`
  - -> `[58]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Montoro is not my friend. And I'd appreciate it if you didn't go rooting around in my ship's quarters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're that impressed by a Cantuavo, I hate to think of the swill they must be serving in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A man of exquisite taste. I like you already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Gus laughed delightedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Gus Manger (R)**
> ""You hear that, Ewald! Swill! Giralt of Ribery must be spinning in his grave. Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty has certainly sampled enough wine to know what he's talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Gus Manger (R)**
> ""Forgive me, Your Majesty. But we can't let this beautiful bottle go to waste now that it's been exposed to sunlight, can we? Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[63]`
Mówca: **Gus Manger (R)**
> ""I wouldn't mind gaining some firsthand knowledge myself. Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[64]`
Mówca: **Gus Manger (R)**
> ""A toast to exquisite taste, then. Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[65]`
Mówca: **Pabel Adria**
> ""Excellent choice, Mr. Manger. Please allow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[66]`
Mówca: **Narrator**
> "He turned his back as he filled our glasses, secretly pouring a nonalcoholic wine substitute into mine. We were used to this routine by now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "He filled the glasses and handed one to each of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Pabel Adria**
> ""This should taste of cherry and black pepper, with a faint hint of leather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[72]`
Mówca: **Ewald Alphonso (R)**
> ""And stay buried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Gus Manger (R)**
> ""And new friends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[74]`
Mówca: **Ewald Alphonso (R)**
> ""We don't usually toast with that phrase. But nice pronunciation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Gus Manger (R)**
> ""Yes, well done. Vectern sis da.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Gus Manger (R)**
> ""Right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "We drank. Gus sighed with pure pleasure. Alphonso's expression bordered on disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Ewald Alphonso (R)**
> ""All apologies to Giralt of Ribery, but this is in fact the best wine I've ever tasted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Gus Manger (R)**
> ""I told you! I know certain Sordish movers and shakers who'd kill to have access to a beverage of this caliber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Gus Manger (R)**
> ""Which brings me to that deal I suggested...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizians do not drink whiskey, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[82]`
Mówca: **Gus Manger (R)**
> ""Our turn to be the connoisseurs, Your Majesty. Butler! Three tumblers, no ice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Pabel approached with three glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[84]`
  - -> `[89]`
  - -> `[92]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just a small sip for me. To make sure my people aren't getting an inferior product.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I'll take your word for it. The wine's already gone to my head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I didn't know any better, I'd say you two were trying to get me drunk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Ewald Alphonso (R)**
> ""I really must insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[411]`

### Węzeł `[91]`
Mówca: **Ewald Alphonso (R)**
> ""One does not get merely 'drunk' on Erlory Maroon 30-Year-Old. One floats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this is as good as you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
Mówca: **Ewald Alphonso (R)**
> ""That's because they've never tried this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[94]`
Mówca: **Gus Manger (R)**
> ""Call it an aperitif.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Alphonso opened his attache and pulled out a bottle of Erlory Maroon 30-Year-Old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[96]`
Mówca: **Gus Manger (R)**
> ""It's even better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[97]`
Mówca: **Narrator**
> "The yacht lingered at the mouth of the Zpana delta as the sun lowered in the sky, turning the water from turquoise to gold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[98]`
Mówca: **Narrator**
> "A series of looks passed between Gus and Alphonso. They turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland = true;
RiziaDLC.Country_Tourism += 1;
RiziaDLC.Diplomacy_Sordland_NegotiatingPower += 1;
RiziaDLCSupport.Journal_Turn02_Sordland_Whisky = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland"] = true;
Variable["RiziaDLC.Country_Tourism"] = Variable["RiziaDLC.Country_Tourism"] + 1;
Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] + 1;
Variable["RiziaDLCSupport.Journal_Turn02_Sordland_Whisky"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Yes, sure. Now can we get to the real reason why you're here?" [Trade Deal]"]** — Mówca: **Player_Romus**
> ""Yes, sure. Now can we get to the real reason why you're here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, sorry. I'd rather not bring more hard liquor into this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[102]`
Mówca: **Gus Manger (R)**
> ""A shame, Your Majesty. But I do have one more proposal for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland = true;
RiziaDLC.Diplomacy_Sordland_NegotiatingPower += 1;
RiziaDLC.Country_Tourism += 1;
RiziaDLCSupport.Journal_Turn02_Sordland_Whisky = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Sordland"] = true;
Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] + 1;
Variable["RiziaDLC.Country_Tourism"] = Variable["RiziaDLC.Country_Tourism"] + 1;
Variable["RiziaDLCSupport.Journal_Turn02_Sordland_Whisky"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Ewald Alphonso (R)**
> ""Excellent, Your Majesty. And yes, there is one more proposal we wanted to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[105]`
Mówca: **Ewald Alphonso (R)**
> ""As much as Sordland's most valued citizens would appreciate your wine, we believe there's something else they'd find even more stunning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "He gestured at his surroundings, then down at the short-sleeved shirt he was wearing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Gus Manger (R)**
> ""Have you thought about Rizia's untapped tourism potential, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[108]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid our conflicts with our neighbors would scare off visitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, many times. Our beaches put Lespia's to shame, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We only want the right kind of tourists, Mr. Manger. No riff-raff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm listening...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[112]`
Mówca: **Gus Manger (R)**
> ""I took the liberty of hiring a designer to draw this up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[113]`
Mówca: **Gus Manger (R)**
> ""None indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[114]`
Mówca: **Gus Manger (R)**
> ""Still, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[115]`
Mówca: **Gus Manger (R)**
> ""They're true diamonds in the rough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[116]`
Mówca: **Narrator**
> "He reached inside his jacket pocket and pulled out a sheet of paper with a sketch on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> "I recognized the beach it depicted. It was a picturesque stretch of sand in Monqiz, not far from the palace where I'd grown up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Right on the coastline, the designer had placed a sprawling complex with a swimming pool and tennis courts. On it was a sign: "Koronti Resort Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[122]`
  - -> `[123]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras would never stand for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm not bringing Sordish new money to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Gus Manger (R)**
> ""New money, old money -- it's all money. And the investors behind this proposal are itching to spend theirs here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's missing a private pier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would that be the senior or the junior Koronti?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Gus Manger (R)**
> ""It's only a rough sketch, Your Majesty. But yes, a private pier would go without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[125]`
Mówca: **Gus Manger (R)**
> ""You are the head of House Toras, are you not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[126]`
Mówca: **Gus Manger (R)**
> ""You've done your research, I see. This is Marcel's initiative. Along with certain other members of the Lotherberg Group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Alphonso swirled the last drops of whiskey around in his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Ewald Alphonso (R)**
> ""I'm aware of how your nobles see Sordish oligarchs. I'm also aware that their world-renowned riches have diminished with each successive generation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Ewald Alphonso (R)**
> ""Change is not merely inevitable, Your Majesty -- it's the only way to preserve the lifestyle to which you're all so accustomed. Your grandmother understood that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`
  - -> `[132]`
  - -> `[133]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lyza wouldn't have wanted a bunch of fat, sunburned vulgarians blocking her ocean views. No offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need Sordland's help to stay wealthy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the king. The nobles would have no choice but to acquiesce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well said, Mr. President. My relatives could use a good shock to the system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Gus Manger (R)**
> ""So that's a yes on the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[138]`
  - -> `[150]`
  - -> `[152]`

### Węzeł `[136]`
Mówca: **Ewald Alphonso (R)**
> ""Our partners are considering significant investment along the Valenqiris coast. If all went well, the Koronti resort would only be the first step.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[137]`
Mówca: **Narrator**
> "Gus drew his breath in through his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""It is indeed. I hope I'm invited to the grand opening." [Resort Deal]"]** — Mówca: **Player_Romus**
> ""It is indeed. I hope I'm invited to the grand opening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[139]`
Mówca: **Gus Manger (R)**
> ""You too, eh? We'll assume that's a no on the proposal, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[142]`
  - -> `[154]`
  - -> `[144]`

### Węzeł `[140]`
Mówca: **Ewald Alphonso (R)**
> ""We know you've got Queen Beatrice providing her protection. We just wanted to offer you some extra insurance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Gus Manger (R)**
> ""But we'll assume that's a no on the proposal, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[142]`
  - -> `[154]`
  - -> `[144]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Well... I don't like it, but I'd be a fool to turn down your oligarchs' investment. The answer is yes." [Resort Deal]"]** — Mówca: **Player_Romus**
> ""Well... I don't like it, but I'd be a fool to turn down your oligarchs' investment. The answer is yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're already getting our wine. That's enough wheeling and dealing for one day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, indeed. Come back when you have better ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[148]`
Mówca: **Narrator**
> "Gus laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Gus Manger (R)**
> ""The King will get a free stay in the largest suite. Anytime he likes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Yes. As long as the final design is less gaudy." [Resort Deal]"]** — Mówca: **Player_Romus**
> ""Yes. As long as the final design is less gaudy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Ewald Alphonso (R)**
> ""I'll pass that on to our partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I do want to open Rizia up to the world, but I'd rather explore other avenues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Ewald Alphonso (R)**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your assumption is correct. Sorry to waste your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[155]`
Mówca: **Narrator**
> "He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Gus Manger (R)**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[157]`
Mówca: **Narrator**
> "They glanced at each other in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Ewald Alphonso (R)**
> ""Well. I'm glad we have an understanding!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[162]`
Mówca: **Narrator**
> "Alphonso shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Ewald Alphonso (R)**
> ""One trade deal is already more than our predecessors managed in 30 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[164]`
Mówca: **Ewald Alphonso (R)**
> ""So the door between our countries will remain closed. For now, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[165]`
Mówca: **Narrator**
> "Alphonso rubbed his hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Ewald Alphonso (R)**
> ""In less than an hour, we've accomplished more for our countries than our predecessors managed in 30 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[170]`
Mówca: **Ewald Alphonso (R)**
> ""If the wine will not come to Sordland, Sordland will come to the wine. I'm satisfied with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[171]`
Mówca: **Gus Manger (R)**
> ""Rusty led me to believe you were more open-minded than your father. A shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[172]`
Mówca: **Gus Manger (R)**
> ""There's only one opportunity that matters to me right now. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[199]`
  - -> `[177]`
  - -> `[178]`

### Węzeł `[173]`
Mówca: **Gus Manger (R)**
> ""But no wine in Sordland means that we'd better get our fill of Cantuavo while we're here. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[199]`
  - -> `[177]`
  - -> `[178]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His name is Pabel Adria. Show some respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[175]`
Mówca: **Gus Manger (R)**
> ""Yes, that alone calls for a celebration. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[199]`
  - -> `[177]`
  - -> `[178]`

### Węzeł `[176]`
Mówca: **Gus Manger (R)**
> ""I'd say that calls for a celebration. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[199]`
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's my butler, not yours. Pabel!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You heard the man, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[179]`
Mówca: **Narrator**
> "Pabel reappeared, another bottle in his hands. He filled our glasses with a look of annoyance that only I could detect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Pabel reappeared, another bottle in his hands. He shot me a grateful look as he filled our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[370]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Pabel reappeared, another bottle in his hands. He filled our glasses, a neutral expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[186]`
Mówca: **Narrator**
> "The yacht began to turn back towards Porte Drazon as the sun disappeared over the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[187]`
Mówca: **Ewald Alphonso (R)**
> ""The Colonel was no great fan of monarchies, as you'll recall. Me? I'm more flexible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`
  - -> `[190]`
  - -> `[195]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For such an anti-monarchist, he behaved an awful lot like a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only difference between your republic and our monarchy is that the Rizian people are happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor was my father keen on democracy. You and I have much in common.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[191]`
Mówca: **Ewald Alphonso (R)**
> ""Are you sure that's not just because of your splendid weather?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[192]`
Mówca: **Ewald Alphonso (R)**
> ""Gus said he thought we'd get along. Speak of the devil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[193]`
Mówca: **Ewald Alphonso (R)**
> ""By the end, maybe. I wish we'd parted ways on better terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Countries with differing politics can still find common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Ewald Alphonso (R)**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[197]`
Mówca: **Narrator**
> "Alphonso frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal = true; RiziaDLCSupport.Journal_Turn02_Sordland_Resort = true;
EnableCollectionItem("CollectionItem_KorontiResortPostcard");
RiziaDLC.Diplomacy_Sordland_NegotiatingPower += 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Sordland_Resort"] = true;
EnableCollectionItem("CollectionItem_KorontiResortPostcard");
Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's enough, Mr. Manger. I'm cutting you off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Gus Manger (R)**
> ""I'll see you in Sordland, then, beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Narrator**
> "He waved a wistful goodbye to the bottle Pabel was holding in his hands. My butler gave a brisk, professional nod and disappeared back into the cabin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[205]`
Mówca: **Gus Manger (R)**
> ""I'll see you on our next visit, then, beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[206]`
Mówca: **Narrator**
> "After hours of diplomatic formalities in Palas Rezna, the sea breeze felt amazing. Alphonso removed his jacket and looked up admiringly at the wide cable bridge that connected Porte Drazon's two halves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[207]`
Mówca: **Ewald Alphonso (R)**
> ""A beautiful, elegant old palace. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[208]`
Mówca: **Narrator**
> "He rushed to correct himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[209]`
Mówca: **Ewald Alphonso (R)**
> ""I know one man who's happy for a clean break, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[210]`
Mówca: **Ewald Alphonso (R)**
> ""Or it could be the booze...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[211]`
Mówca: **Gus Manger (R)**
> ""Last I saw, your treasury crone was in the cabin reading over the terms of the proposal. Shall we haul her up and hash this out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[217]`
  - -> `[218]`
  - -> `[219]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're in Rizia. Mr. Manger. We treat women like equals here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[216]`
Mówca: **Gus Manger (R)**
> ""Since your treasury crone isn't here to put a damper on proceedings, should we get straight to it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`
  - -> `[234]`
  - -> `[238]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't call Ms. Werner a crone. She's one of my most capable councilors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry I had to bring along the wet blanket. I would've preferred a men's night out, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, let's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're in Rizia. Mr. Manger. We treat women like equals here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Narrator**
> "Pabel poured me a small amount with an apologetic shrug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[225]`
Mówca: **Narrator**
> "Pabel poured us each a small amount of the amber-colored liquid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[229]`
Mówca: **Narrator**
> "It was my first taste of alcohol since my wilder days. Visions of broken villa windows and weekend-long blackouts came to me unbidden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Narrator**
> "The taste brought back memories of my wilder days. Visions of broken villa windows and weekend-long blackouts came to me unbidden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't call Ms. Werner a crone. She's one of my most capable councilors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Narrator**
> "Alphonso gave Gus a look of warning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Ewald Alphonso (R)**
> ""I apologize on behalf of my minister. I told him to leave his baser impulses at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[237]`
Mówca: **Ewald Alphonso (R)**
> ""It could have been worse. Imagine if Nia Morgna were here, Gus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, let's work this out between us men. No wet blanket necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
Mówca: **Gus Manger (R)**
> ""'You can't bring the King whiskey, Mr. President! That's bribery!'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Gus laughed and shifted his voice to a higher register."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[241]`
Mówca: **Ewald Alphonso (R)**
> ""I assure you Sordland is making progress on the status of women. Some of my most trusted ministers belong to the fairer sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
Mówca: **Ewald Alphonso (R)**
> ""I'm glad you understand. Imagine if Nia Morgna were here, Gus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[243]`
Mówca: **Narrator**
> "Pabel ducked into the ship's cabin and re-emerged with Elena. My treasury councilor looked slightly seasick."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[247]`
Mówca: **Elena Werner**
> ""Pardon my absence, gentlemen. Despite my Valgish ancestry, I never warmed up to boat travel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Elena Werner**
> ""The draft agreement seems sound. But I had a question about the section regarding quantities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Elena Werner**
> ""You're proposing an equal amount of wine and whiskey be traded per year, when more demand currently exists for the former than the latter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`
  - -> `[255]`
  - -> `[252]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If demand for whiskey doesn't exist in Rizia, we'll just have to find a way to create it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See, this is why I brought her along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there another way we can rephrase this, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[253]`
Mówca: **Narrator**
> "Alphonso reopened his briefcase and took out some paperwork."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Ewald Alphonso (R)**
> ""It's all boilerplate, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reopening trade channels to sell us useless whiskey. What a swindle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[256]`
Mówca: **Ewald Alphonso (R)**
> ""The governments of Rizia and Sordland, recognizing the importance of promoting economic growth and cooperation and desiring to enhance their mutual interests...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Ewald Alphonso (R)**
> ""...conducted in a manner that is consistent with their respective domestic laws and regulations...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[258]`
Mówca: **Ewald Alphonso (R)**
> ""...the parties shall agree to cooperate in the development and implementation of sanitary measures...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds legitimate. No need to go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[260]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "He went on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop. I've made a decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[262]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "He went on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Ewald Alphonso (R)**
> ""...elimination of tariffs to be completed within six months from the entry into force...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[266]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seems straightforward enough. Here's what I've decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[265]`
Mówca: **Ewald Alphonso (R)**
> ""...ensuring that respective customs procedures and other trade-related measures are transparent, efficient and predictable...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[266]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "He went on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get the picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[268]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "He went on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Ewald Alphonso (R)**
> ""...in equal amounts of 100 tons of wine and 50 barrels of whisky per year, subject to availability...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[270]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. Here's what I want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Gus Manger (R)**
> ""Phew. I thought that would never end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[273]`
Mówca: **Gus Manger (R)**
> ""A wise move, Your Majesty. The fine print goes on forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[274]`
Mówca: **Ewald Alphonso (R)**
> ""Yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Equal amounts? Demand for Rizian wine in Sordland is far higher than that for Sordish whiskey in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[277]`
Mówca: **Ewald Alphonso (R)**
> ""Good catch, Ms. Werner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Ewald Alphonso (R)**
> ""We can change that section if you like. 'Quantities subject to market demand.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Gus Manger (R)**
> ""It won't be difficult. This whiskey speaks for itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[280]`
Mówca: **Gus Manger (R)**
> ""Demand in Rizia will skyrocket once Erlory Maroon hits the market. Trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[281]`
Mówca: **Ewald Alphonso (R)**
> ""Hrm. Good catch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Sordland_WhiskeySurplus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Sordland_WhiskeySurplus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Elena raised her eyebrows but stayed silent. Gus and Alphonso exchanged a series of looks, then turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[290]`
Mówca: **Narrator**
> "Elena flipped open her ledger and made a quick note."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Elena flipped open her ledger and made a quick note."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[295]`
Mówca: **Gus Manger (R)**
> ""I know that for a long time, international tourists stayed away from the Valenqiris coast because of the delicate situation with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[296]`
Mówca: **Gus Manger (R)**
> ""Porte Drazon is gorgeous enough. But your beaches!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[297]`
Mówca: **Elena Werner**
> ""It's 'Pall-ey', Mr. Manger. Rhymes with 'ballet'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[303]`
  - -> `[304]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, relations with *pall-ey* have been shaky for years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[302]`
Mówca: **Narrator**
> "He pronounced the last word as "pails.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's 'pall-ey'. Rhymes with 'ballet'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
**[WYBÓR GRACZA: "Don't correct him."]** — Mówca: **Player_Romus_Italic**
> "I refrained from speaking up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[305]`
Mówca: **Gus Manger (R)**
> ""Oh. Sorry, I've never had the occasion to speak the name aloud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Narrator**
> "He didn't seem to notice my correction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Gus Manger (R)**
> ""My point is that it might finally be time to bring your underdeveloped shores to life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not so fast. Let me confer with Elena.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[312]`
Mówca: **Narrator**
> "The Sordish visitors waited outside as Elena and I walked into the cabin to talk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`
  - -> `[316]`

### Węzeł `[313]`
Mówca: **Ewald Alphonso (R)**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So what do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is exactly what I was worried about. Sords waltzing in here and disrespecting our nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You served under Queen Lyza. Would she have wanted this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[317]`
Mówca: **Elena Werner**
> ""If I may speak freely... I don't think it's a bad idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[324]`
  - -> `[323]`

### Węzeł `[318]`
Mówca: **Elena Werner**
> ""Their attitude leaves something to be desired, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[319]`
Mówca: **Elena Werner**
> ""Well... Lyza did everything in her power to transform Rizia into a modern, enlightened nation. But she was also a proud Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Elena Werner**
> ""I'm not sure she would have wanted to see her house's pride and joy become a stomping ground for Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Elena Werner**
> ""But if I may speak freely... I don't think it's a bad idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[324]`
  - -> `[328]`
  - -> `[323]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. That's all I wanted to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not a Toras. You don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Elena Werner**
> ""I do, though. You must remember that I'm from Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Elena Werner**
> ""You must remember that I'm from Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Elena Werner**
> ""I grew up just minutes away from those beaches, but it wasn't until I became a councilor that I had the pull to bring my family there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neither do I. But I wanted to hear your reasoning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[329]`
Mówca: **Elena Werner**
> ""Monqiz is far enough up the coast that it'd be insulated from any fighting. We might have a problem if the Sords take Pales' side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Elena Werner**
> ""That resort wouldn't just open the Valenqiris coast up to Sordland. It'd open it up to the rest of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[390]`
  - -> `[391]`
  - -> `[392]`

### Węzeł `[331]`
Mówca: **Elena Werner**
> ""Then again, the obscenely wealthy have never had a problem with going on holiday in politically objectionable territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Elena Werner**
> ""Shall we get back out on deck?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`
  - -> `[335]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I've made my decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shall. Thank you for sharing your opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we must..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Narrator**
> "We stepped back out into the waning sunlight and rejoined Alphonso and Gus Manger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Ewald Alphonso (R)**
> ""Well, Your Majesty? Are we making history today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`
  - -> `[341]`
  - -> `[345]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have a deal. But does the resort have to be as gaudy as the one in the picture?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just remember to invite me to the grand opening of the Koronti Resort Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One deal is enough for today, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid neither of your proposals appeal to me. Sorry to send you home with nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, our coastline shall stay the way it is. Untouched by foreign influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal = true; RiziaDLCSupport.Journal_Turn02_Sordland_Resort = true;
EnableCollectionItem("CollectionItem_KorontiResortPostcard");
RiziaDLC.Diplomacy_Sordland_NegotiatingPower += 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Sordland_Resort"] = true;
EnableCollectionItem("CollectionItem_KorontiResortPostcard");
Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[350]`
Mówca: **Gus Manger (R)**
> ""Ha. I'm sure our architects can come up with something more subtle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[351]`
Mówca: **Gus Manger (R)**
> ""You'll get a free stay in the largest suite. Anytime you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[352]`
Mówca: **Narrator**
> "Alphonso shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Ewald Alphonso (R)**
> ""That's still more than our predecessors managed in the past 30 years. And it leaves the door open for more dialogue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[357]`
Mówca: **Elena Werner**
> ""One trade deal is still quite the feat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[361]`
Mówca: **Elena Werner**
> ""Quite the feat indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[362]`
Mówca: **Elena Werner**
> ""Yes, please do get in touch should further trade opportunities arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_SordishDeal_IncludeElena"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Elena Werner**
> ""We're still open to other trade opportunities. Please get in touch if any arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[367]`
Mówca: **Gus Manger (R)**
> ""Nothing to do but drown our sorrows. Butler! Another bottle!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[177]`
  - -> `[178]`

### Węzeł `[368]`
Mówca: **Gus Manger (R)**
> ""I stand corrected. Mr. Adria, if you would be so kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[369]`
Mówca: **Narrator**
> "I tasted mine: nothing but juice. Somehow, he had still managed to perform the switch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_RH_SordishTrade_ResortDeal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SordishTrade_ResortDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_RH_SordishTrade_BothDeals = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SordishTrade_BothDeals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_RH_SordishTrade_WineDeal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SordishTrade_WineDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_RH_SordishTrade_NoDeals = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SordishTrade_NoDeals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_G_SordlandVisit_Deal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_SordlandVisit_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_G_SordlandVisit_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_SordlandVisit_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn02_Monqiz_PortQueues = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_Monqiz_PortQueues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's exactly what my relatives are worried about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The resort is still private property. Commoners would barely be able to afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unless we get back into another conflict with 'Pails.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Narrator**
> "She smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[394]`
Mówca: **Elena Werner**
> ""But if they did have the money, they'd be able to get in. There's the difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[395]`
Mówca: **Elena Werner**
> ""Yes, the rest of your house wouldn't love it. But you'd still have lots of coastline to call your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Breather", "R_Breather_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValues_FellOffWagon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[400]`
Mówca: **Narrator**
> "I relished the bite. I could almost feel myself slipping back into my old, dangerous habits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`

### Węzeł `[404]`
Mówca: **Narrator**
> "It was my first taste of alcohol in years. I was surprised by how pleasurable it was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Project"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Terador_AzaroMilitaryExercise = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Terador_AzaroMilitaryExercise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn02_Montaklar_LeisureClubShutDown = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_Montaklar_LeisureClubShutDown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PourDrink");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PourDrink");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... I can't say no to Sordish hospitality. I'll just have a little taste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, President Alphonso. Maybe another time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[413]`
Mówca: **Narrator**
> "His gaze turned cool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Ewald Alphonso (R)**
> ""What do you you say, Gus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Gus Manger (R)**
> ""I say that means more for us, Ewald.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Sordland_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Sordland_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Narrator**
> "Pabel poured each of the two Sords a small amount of the amber-colored liquid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Ewald Alphonso (R)**
> ""I'll do the toast this time. How do you people say it? A proso!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Narrator**
> "They drank. A smile spread across Gus' face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Gus Manger (R)**
> ""That dark, woodsy flavor, that silky-smooth finish. You're really missing out, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[421]`
  - -> `[35]`

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds heavenly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Drinking += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Drinking"] = Variable["RiziaDLC.PersonalValue_Drinking"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just as well. If it's as good as you say, I'd never be able to stop drinking it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Gus Manger (R)**
> ""Your countrymen will go crazy for it, I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Talking trade on a boat with the President of Sordland", "Royal Yacht", "Zpana River Delta");)*
- **Efekt (`userScript`):** `SetRichPresence("Talking trade on a boat with the President of Sordland","Royal Yacht","Zpana River Delta");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`
