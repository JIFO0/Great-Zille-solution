# Sordland/Turn06/InT_HighwayOpening

- **ID konwersacji:** `80`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/080_InT_HighwayOpening.md`
- **Liczba węzłów dialogowych:** 187
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn06_InT_Show`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy_Agnland`
- `BaseGame.Policy_Economy_HighwayProject`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`
- `BaseGame.Turn06_InT_OnTime`
- `BaseGameIsolated.Turn06_InT_Show`
- `BaseGameSupport.Journal_Turn06_HighwayOpening`
- `BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_NoShow`
- `BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_Show`
- `BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_NoShow`
- `BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_Show`
- `BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_NoShow`
- `BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_Show`
- `BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_NoShow`
- `BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_Show`
- `GameCondition.Turn06_InT_Opening`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 33

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Agnland`
- `BaseGame.Policy_Economy_HighwayProject`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[7]` (Symon Holl): `Variable["GameCondition.Turn06_InT_Opening"] = true; Variable["BaseGame.Public_Opinion"] = Variab...`
- Węzeł `[22]` (Symon Holl): `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- Węzeł `[94]` (Symon Holl): `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- Węzeł `[95]` (Symon Holl): `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- Węzeł `[96]` (Symon Holl): `Variable["BaseGame.Turn06_InT_OnTime"] = true;`
- Węzeł `[128]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn06_HighwayOpening"] = true; Variable["BaseGame.Policy_Econo...`
- Węzeł `[141]` (Symon Holl): `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_Show"] = true; Variable["BaseGameSuppor...`
- Węzeł `[142]` (Symon Holl): `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_Show"] = true; Variable["BaseGameSup...`
- *...oraz 25 innych węzłów ze skryptami.*

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
  - -> `[5]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Symon and Lileas who heavily assisted the project were with me alongside Lucian to decide on how to proceed tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[4]`
Mówca: **Lileas Graf**
> "“Involving the President could be beneficial for his image.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Arriving in Lachaven for the grand opening ceremony of the H-3 Highway was a proud moment for all of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Symon Holl**
> "“I don't support anything beyond the opening ceremony. Actions speak for themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_InT_Opening = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_InT_Opening"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Today was a great victory for the administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I'd prefer we just do the opening ceremony. No need for senseless show.”"]** — Mówca: **Player**
> "“I'd prefer we just do the opening ceremony. No need for senseless show.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I agree. There is much to gain.”"]** — Mówca: **Player**
> "“I agree. There is much to gain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“The people will be satisfied. More importantly, so will businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Lileas Graf**
> "“Sounds good. It would display unity and strength if we were all together in the convoy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“Of course. We'll do the ceremony and open the highway to the public immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Additionally, a large crowd is invited for the ceremony and will be watching the opening speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[16]`
  - -> `[17]`
  - -> `[112]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“It will be a good opportunity for exposure.”"]** — Mówca: **Player**
> "“It will be a good opportunity for exposure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Like the good campaign days.”"]** — Mówca: **Player**
> "“Like the good campaign days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Nothing like a cheerful crowd. Looking forward to it.”"]** — Mówca: **Player**
> "“Nothing like a cheerful crowd. Looking forward to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Alright then. We have a lot of work to do tomorrow. See you in the morning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`
  - -> `[117]`

### Węzeł `[20]`
Mówca: **Narrator**
> "The team left, leaving the rest of the evening to prepare for the big day tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "Signal Lucian to begin the ceremony."]** — Mówca: **Player_Italic**
> "We were all ready to begin the ceremony. I gave the green-light and the opening address began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[23]`
Mówca: **Narrator**
> "The next day a stage had been erected next to the entrance of the highway in the down-town."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“Brothers and sisters of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[25]`
Mówca: **Lileas Graf**
> "“Thank you, Mr. President. Lachaven! It is great to be here today among you industrious people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[26]`
Mówca: **Symon Holl**
> "“Thanks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[27]`
Mówca: **Narrator**
> "We began moving towards the stage as the excitement was growing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“People of Sordland! Welcome to the opening ceremony of the H-3 Highway!”"]** — Mówca: **Player**
> "“People of Sordland! Welcome to the opening ceremony of the H-3 Highway!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Lucian's voice echoed in the square next to the highway. Hundreds of Sordland and USP flags began to wave as the cheers intensified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“Without further ado, I invite the President of Sordland to the stage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Citizens! Welcome to the opening ceremony of the H-3 Highway.”"]** — Mówca: **Player**
> "“Citizens! Welcome to the opening ceremony of the H-3 Highway!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"]** — Mówca: **Player**
> "“Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Move up to the stage."]** — Mówca: **Player_Italic**
> "I moved up to the stage to address the crowd. The press were taking dozens of pictures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[31]`
  - -> `[28]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The chanting from the crowd intensified. Some were yelling the motto of Lachaven; Liberty until eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Narrator**
> "The chanting from the crowd continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“At the beginning of this journey we promised jobs and opportunity. We kept our promise.”"]** — Mówca: **Player**
> "“At the beginning of this journey we promised jobs and opportunity. We kept our promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Trust me, our work is far from over. This project is only the beginning of good tidings.”"]** — Mówca: **Player**
> "“Trust me, our work is far from over. This project is only the beginning of good tidings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“The aim with the H-3 was to improve logistics to aid businesses to create economic growth in East Nargis and Agnland.”"]** — Mówca: **Player**
> "“The aim with the H-3 was to improve logistics to aid businesses to create economic growth in East Nargis and Agnland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Our intention with the H-3 was to serve our citizens who were having a hard time travelling between Lachaven and Arvory.”"]** — Mówca: **Player**
> "“Our intention with the H-3 was to serve our citizens who were having a hard time travelling between Lachaven and Arvory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`

### Węzeł `[40]`
Mówca: **Narrator**
> "The highway officially opened to the public and thousands began utilising it as soon as we left the area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[41]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[43]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“None of this would be possible without my colleague with sound advice, the Minister of the Interior Lileas Graf. Please come over here.”"]** — Mówca: **Player**
> "“None of this would be possible without my colleague with sound advice, the Minister of the Interior Lileas Graf. Please come over here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“We have to thank the mind behind the highway project for it all, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"]** — Mówca: **Player**
> "“We have to thank the mind behind the highway project for it all, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[46]`
Mówca: **Symon Holl**
> "“I'm sure each one of you will be proud of the achievements made during the project once we cut that ribbon and you can drive or travel on the highway yourselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“United we stand and divided we fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“I took time off from my duties to personally manage the project to success.”"]** — Mówca: **Player**
> "“I took time off from my duties to personally manage the project to success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Lileas walked up to me and leaned on the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Symon walked up to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "Cut the ribbon."]** — Mówca: **Player_Italic**
> "I cut the ribbon which led to a huge wave of cheering from the crowd. Many flashes went off at the same time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“Congratulations to all. It was a solid and fruitful effort. Hopefully with much more to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Lileas Graf**
> "“It's a good moment indeed. It gives us pride as a nation. One big step behind us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> "“Your car is prepared and ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[55]`
Mówca: **Narrator**
> "A forty meter long red ribbon was hanging over it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“This highway brings thousands of new jobs! Many unemployed citizens have benefited and will benefit on the path of the highway.”"]** — Mówca: **Player**
> "“This highway brings thousands of new jobs! Many unemployed citizens have benefited and will benefit on the path of the highway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[48]`
  - -> `[45]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“This highway brings down travel time by half! Travelling between Lachaven and Arvory is now faster and more comfortable.”"]** — Mówca: **Player**
> "“This highway brings down travel time by half! Travelling between Lachaven and Arvory is now faster and more comfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[48]`
  - -> `[45]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "Enter car."]** — Mówca: **Player_Italic**
> "I entered the car and sat on the driver's seat. The crowd was trying to catch a glimpse of me sitting at the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“I'd like Lileas with me.”"]** — Mówca: **Player**
> "“I'd like Lileas with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I will drive the car on my own.”"]** — Mówca: **Player**
> "“I will drive the car on my own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“I'm honored. It will be great to arrive in Arvory with the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I want to have Symon in the lead car.”"]** — Mówca: **Player**
> "“I want to have Symon in the lead car.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“Who do you want to travel with, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[62]`
  - -> `[59]`
  - -> `[60]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Lucian, you would be my preference.”"]** — Mówca: **Player**
> "“Lucian, you would be my preference.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[65]`
Mówca: **Symon Holl**
> "“This isn't necessary but I won't refuse. We can talk about future economic projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good journey to talk about how the Supreme Court will react to the legal challenge by Mr. Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Sure. We will all be following in our vehicles. See you in Arvory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
Mówca: **Narrator**
> "As we began driving out of the opening ceremony area and into the new highway, the media took pictures of me and Lucian who looked serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
Mówca: **Narrator**
> "As we began driving out of the opening ceremony area and into the new highway, the media took pictures of me and Symon who smiled to the cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
Mówca: **Narrator**
> "As we began driving out of the opening ceremony area and into the new highway, the media took pictures of me and Lileas who waved to the cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Narrator**
> "As we began driving out of the opening ceremony area and into the new highway, the media took pictures of me driving by myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "The new highway was in pristine condition and quality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[73]`
Mówca: **Narrator**
> "After the relaxing four hour drive to Arvory, we were welcomed by celebratory citizens and Mayor Eric Niel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[74]`
Mówca: **Symon Holl**
> "“On another note. It goes without mentioning that this was a team effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> "“I think all of us do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“Agreed. Every single press outlet has of course been notified and they will be there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“Things were certainly easier back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Narrator**
> "Symon stepped in for a comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[79]`
Mówca: **Symon Holl**
> "“Beginning with the President who put trust in me, I want to thank all involved in H-3.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[113]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Symon, you deserve a lot of credit. After all, it was you who came up with the project.”"]** — Mówca: **Player**
> "“Symon, you deserve a lot of credit. After all, it was you who came up with the project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Thank you for your kind words. It truly means a good deal.”"]** — Mówca: **Player**
> "“Thank you for your kind words. It truly means a good deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Lileas Graf**
> "“Finally people got what they wanted for a long time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Lileas brought attention to the strength that comes from unity. She then mentioned the positive change the highway creates for Agnland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[84]`
Mówca: **Narrator**
> "Symon mentioned the beginning of a Sordish economic recovery and the plans to stop the recession altogether."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[85]`
Mówca: **Narrator**
> "The crowd began cheering my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[86]`
Mówca: **Narrator**
> "The calm and warm weather created a positive mood in the usually breezy Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Narrator**
> "The crowd was large but still smaller than some rallies due to the strong PFJP presence here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“I welcome you, Lachaveners today as a proud servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[89]`
Mówca: **Lileas Graf**
> "“This project is a perfect example of the capacity and capabilities of Sordland as a nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[90]`
Mówca: **Symon Holl**
> "“Our aim with this project is obvious, to improve the speed and efficiency of transportation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Symon gave me a pair of large scissors to commence the opening. The crowd was watching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“The drive to Arvory should take about four hours and the rest of the motorcade will follow you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[93]`
Mówca: **Narrator**
> "It was the best driving experience one could have nowadays while providing the best traction and least noise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[94]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_AverageTransportation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[95]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_WeakTransportation = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[96]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_OnTime = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_InT_OnTime"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Lucian stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“First of all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
> "“Congratulations everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“We couldn't have done this without our excellent team.”"]** — Mówca: **Player**
> "“We couldn't have done this without our excellent team.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I silently nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[102]`
Mówca: **Symon Holl**
> "“To many more projects like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“I have a plan on how to do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“It's been a long time since the last successful infrastructure project. There is good reason to capitalise on the occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
> "“Let's move on to our plans for the opening tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“Well done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“If Mr. President accepts, a drive from Lachaven to Arvory should do the trick. After the motorcade takes off, the road will be open to the public.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> "“I think so too. Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I guess we can't help it.”"]** — Mówca: **Player**
> "“I guess we can't help it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[114]`
Mówca: **Lileas Graf**
> "“We will need to show our best face tomorrow. I'll make sure that our focus on improving business and logistics is relayed to wherever necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“See you at the ceremony.”"]** — Mówca: **Player**
> "“See you at the ceremony.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Goodbye for now.”"]** — Mówca: **Player**
> "“Goodbye for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Once again, good work everyone.”"]** — Mówca: **Player**
> "“Once again, good work everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[118]`
Mówca: **Narrator**
> "After he was done with his speech, Lucian took Symon's place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Lucian took my place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Narrator**
> "After she was done with her speech, Lucian took Lileas's place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
> "“Citizens of Lachaven! There you have it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“As promised, Anton Rayne—the 4th President of Sordland—has delivered!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Narrator**
> "We moved towards the entrance of the highway next to the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[124]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"]** — Mówca: **Player**
> "“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_HighwayOpening = true;
BaseGame.Policy_Economy_HighwayProject = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_HighwayOpening"] = true;
Variable["BaseGame.Policy_Economy_HighwayProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[129]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_TaurusHolding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[134]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[138]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_Show = true;
BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_Show = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_Show"] = true;
Variable["BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_Show = true;
BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_Show = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_Show"] = true;
Variable["BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_NoShow = true;
BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_NoShow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Underhall_NoShow"] = true;
Variable["BaseGameSupport.News_Turn06_HP_H3_Opening_Underhall_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_NoShow = true;
BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_NoShow = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_H3_Opening_Taurus_NoShow"] = true;
Variable["BaseGameSupport.News_Turn06_HP_H3_Opening_Taurus_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // filler node)*
- **Efekt (`userScript`):** `-- filler node;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[146]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[148]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good journey to talk about the reforms and our efforts to pass both the assembly and the court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[150]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Agnland += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[151]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Lachaven", "Progress_Highway");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Lachaven","Progress_Highway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Lenkurg", "City_LackofRoadNetwork");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Lenkurg","City_LackofRoadNetwork");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Arvory", "City_LogisticalIssues");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_LogisticalIssues");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[154]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[155]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Lenkurg","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[156]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  or  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[158]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  or  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Laren", "City_HighLevelsofPoverty");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_HighLevelsofPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[160]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[161]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Laren", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[165]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[167]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[168]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[169]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[171]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[172]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[175]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Arvory", "City_RapidGrowth");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_RapidGrowth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[176]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: PlaySoundEffect("RibbonCut");)*
- **Efekt (`userScript`):** `PlaySoundEffect("RibbonCut");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[177]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_CeremonialScissors");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[178]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Lenkurg", "2.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Lenkurg","2.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Lenkurg", "0.65");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Lenkurg","0.65");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[180]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[181]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[182]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Arvory", "5.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Arvory","5.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Arvory", "1.35");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Arvory","1.35");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Lachaven", "83.5");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Lachaven","83.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Lachaven", "3.4");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Lachaven","3.4");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[186]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
