# Sordland/Turn06/InT_RailwayOpening

- **ID konwersacji:** `79`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/079_InT_RailwayOpening.md`
- **Liczba węzłów dialogowych:** 168
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[38]** Lucian Galade
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn06_InT_Show`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Policy_Economy_RailwayProject`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`
- `BaseGame.Turn06_InT_OnTime`
- `BaseGameIsolated.Turn06_InT_Show`
- `BaseGameSupport.Journal_Turn06_RailwayOpening`
- `BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_NoShow`
- `BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_Show`
- `BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_NoShow`
- `BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_Show`
- `BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_NoShow`
- `BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_Show`
- `BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_NoShow`
- `BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_Show`
- `GameCondition.Turn06_InT_Opening`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 34

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Policy_Economy_RailwayProject`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[4]` (Symon Holl): `Variable["GameCondition.Turn06_InT_Opening"] = true; Variable["BaseGame.Public_Opinion"] = Variab...`
- Węzeł `[40]` (Symon Holl): `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- Węzeł `[99]` (Symon Holl): `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- Węzeł `[100]` (Symon Holl): `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- Węzeł `[101]` (Symon Holl): `Variable["BaseGame.Turn06_InT_OnTime"] = true;`
- Węzeł `[127]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn06_RailwayOpening"] = true; Variable["BaseGame.Policy_Econo...`
- Węzeł `[128]` (Symon Holl): `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_Show"] = true; Variable["BaseGameSup...`
- Węzeł `[135]` (Symon Holl): `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_NoShow"] = true; Variable["BaseGameS...`
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
  - -> `[17]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "As we began driving the train out of the central station, the media took photos of me and Lucian who kept his usual cool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[4]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_InT_Opening = true;
BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_InT_Opening"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Today was a great victory for the administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The railway officially opened to the public as soon as we arrived and thousands began utilising it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[9]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[10]`
Mówca: **Narrator**
> "We moved towards the line where the first electric train was waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Cut the ribbon."]** — Mówca: **Player_Italic**
> "I cut the ribbon which led to a huge wave of cheering from the crowd. Many flashes went off at the same time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Symon Holl**
> "“Congratulations to all. It was a solid and fruitful effort. Hopefully with much more to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Gus Manger**
> "“It's a good moment indeed. We have helped so many in the countryside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“The train is prepared and ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[15]`
Mówca: **Narrator**
> "A red ribbon was hanging by the door of the train."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[16]`
Mówca: **Gus Manger**
> "“Sounds fantastic. The President arriving to Lachaven on the driver seat would make the headlines for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[17]`
Mówca: **Narrator**
> "We arrived in Holsord for the grand opening ceremony of the L-1 High-speed rail. It was a proud moment for all of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Symon and Gus, who heavily assisted the project, were with me along with Lucian to decide on how to proceed tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“I don't support anything beyond the opening ceremony. Actions speak for themselves anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Gus Manger**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[21]`
Mówca: **Gus Manger**
> "“I see your point. But involving the President further could be beneficial for the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Enter train."]** — Mówca: **Player_Italic**
> "I entered the cab and took a seat with the assistant beside me. The crowd was trying to catch a glimpse of me sitting as driver of the train."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“Alright then. We have a lot of work to do tomorrow. See you in the morning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[60]`
  - -> `[118]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“It's been a long time since the last successful infrastructure project. There is good reason to capitalise on the occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“I'd like Gus with me.”"]** — Mówca: **Player**
> "“I'd like Gus with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I will drive the train on my own.”"]** — Mówca: **Player**
> "“I will drive the train on my own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Symon walked up beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[28]`
Mówca: **Gus Manger**
> "“I'm honored. It will be great to arrive in Lachaven with the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I want to have Symon in the cab.”"]** — Mówca: **Player**
> "“I want to have Symon in the cab.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“Who do you want to travel with in the cab, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[29]`
  - -> `[25]`
  - -> `[26]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Lucian, you would be my preference.”"]** — Mówca: **Player**
> "“Lucian, you would be my preference.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Symon Holl**
> "“This isn't necessary but I won't refuse. We can talk about future economic projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good journey. We can talk about the reforms on the way as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I agree. There is much to gain.”"]** — Mówca: **Player**
> "“I agree. There is much to gain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“I'd prefer we just do the opening ceremony. No need for senseless show.”"]** — Mówca: **Player**
> "“I'd prefer we just do the opening ceremony. No need for senseless show.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Sure. We will be in the other carriages. See you in Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“This Railway brings thousands of new jobs! Many unemployed citizens have benefited and will benefit on the path of the railway.”"]** — Mówca: **Player**
> "“This Railway brings thousands of new jobs! Many unemployed citizens have benefited and will benefit on the path of the railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[46]`
  - -> `[68]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Gus came to the podium with his relaxed casual posture. He then leaned to the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[39]`
Mówca: **Narrator**
> "As we began driving the train out of the central station, the media took photos of me and Symon who smiled to the cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[40]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Narrator**
> "As we began driving the train out of the central station, the media took photos of me and Gus who gave a thumbs up to the cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“This railway brings down travel time by half! Travelling between Holsord and Lachaven is now faster and more comfortable.”"]** — Mówca: **Player**
> "“This railway brings down travel time by half! Travelling between Holsord and Lachaven is now faster and more comfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[46]`
  - -> `[68]`

### Węzeł `[43]`
Mówca: **Narrator**
> "As we began driving the train out of the central station, the media took photos of me driving by myself with the locomotive assistant next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“Of course. We'll do the ceremony and open the upgraded railway to the public immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“I took time off from my duties to personally manage the project to success.”"]** — Mówca: **Player**
> "“I took time off from my duties to personally manage the project to success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "Move up to the stage."]** — Mówca: **Player_Italic**
> "I moved up to the stage to address the crowd. The press was taking dozens of pictures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[71]`
  - -> `[64]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Lucian's voice echoed in the central station. Thousands of Sordland and USP flags began to wave as the loud cheers intensified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[49]`
Mówca: **Narrator**
> "The new train was in pristine condition and the electric engine made much faster acceleration possible while providing minimal noise and maximum comfort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“This railway project is a perfect example of how we can bring prosperity to the under-developed areas in between our major cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“See you at the ceremony.”"]** — Mówca: **Player**
> "“See you at the ceremony.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“The people will be satisfied with the improved transportation service anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> "“Additionally, a large crowd is invited for the ceremony and will be watching the opening speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[63]`
  - -> `[74]`
  - -> `[116]`

### Węzeł `[54]`
Mówca: **Narrator**
> "After the relaxing four hour drive to Lachaven, we were welcomed by celebratory citizens at Lachaven station."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Lucian took my place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“I'm sure each one of you will be proud of the achievements made during the project once we cut that ribbon. And you can get on that train yourselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Signal Lucian to begin the ceremony."]** — Mówca: **Player_Italic**
> "We were all ready to begin the ceremony. I gave the green-light and the opening address began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Narrator**
> "The next day, a stage had been erected inside the central station along the new electrified railway line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> "“Brothers and sisters of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Goodbye for now.”"]** — Mówca: **Player**
> "“Goodbye for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
Mówca: **Symon Holl**
> "“Thanks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[62]`
Mówca: **Narrator**
> "We began moving towards the stage as the excitement was growing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It will be a good opportunity for exposure.”"]** — Mówca: **Player**
> "“It will be a good opportunity for exposure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Narrator**
> "The team left, leaving the rest of the evening to prepare for the big day tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“The aim with the L-1 Railway was to improve development in rural areas and cities in between Holsord and Lachaven to create economic growth in the Greater Holsord and Gelsland regions.”"]** — Mówca: **Player**
> "“The aim with the L-1 Railway was to improve development in rural areas and cities in between Holsord and Lachaven to create economic growth in the Greater Holsord and Gelsland regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[37]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Without further ado, I invite the President of Sordland to the stage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“We have to thank the mind behind the railway project for it all, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"]** — Mówca: **Player**
> "“We have to thank the mind behind the railway project for it all, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Nothing like a cheerful crowd. Looking forward to it.”"]** — Mówca: **Player**
> "“Nothing like a cheerful crowd. Looking forward to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[70]`
Mówca: **Narrator**
> "The chanting and excitement from the crowd intensified. A large group began singing the national anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[79]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Citizens! Welcome to the opening ceremony of the L-1 High-speed railway!”"]** — Mówca: **Player**
> "“Citizens! Welcome to the opening ceremony of the L-1 High-speed railway!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“Holsordians! Welcome to the opening ceremony of the L-1 High-speed railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“None of this would be possible without my colleague with sound advice, the Minister Gus Manger. Please come over here.”"]** — Mówca: **Player**
> "“None of this would be possible without my colleague with sound advice, the Minister Gus Manger. Please come over here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Like the good old campaign days.”"]** — Mówca: **Player**
> "“Like the good old campaign days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“We will show our best face tomorrow. Meanwhile, I'll make sure that our message of improving the countryside will get across.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[76]`
Mówca: **Narrator**
> "The chanting from the crowd continued. Some were yelling the motto of Holsord; High above all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“At the beginning of this journey we promised jobs and opportunity. We kept our promise.”"]** — Mówca: **Player**
> "“At the beginning of this journey we promised jobs and opportunity. We kept our promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[78]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Our intention with the L-1 Railway was to serve our citizens who were having a hard time travelling between the major cities of Holsord and Lachaven.”"]** — Mówca: **Player**
> "“Our intention with the L-1 Railway was to serve our citizens who were having a hard time travelling between the major cities of Holsord and Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[37]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Trust me, our work is far from over. This project is only the beginning of good tidings.”"]** — Mówca: **Player**
> "“Trust me, our work is far from over. This project is only the beginning of good tidings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“Things were certainly easier back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Gus Manger**
> "“We had our disagreements, but the important thing was the outcome. Sordish people got what they needed for a long time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Symon stepped in for a comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> "“Agreed. Every single press outlet has of course been notified and they will be there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“I think all of us do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“Symon, you deserve a lot of credit. After all, it was you who came up with the project.”"]** — Mówca: **Player**
> "“Symon, you deserve a lot of credit. After all, it was you who came up with the project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Thank you for your kind words. It truly means a good deal.”"]** — Mówca: **Player**
> "“Thank you for your kind words. It truly means a good deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[87]`
Mówca: **Symon Holl**
> "“Beginning with the President who put his trust in me, I want to thank all who were involved in L-1.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`
  - -> `[117]`

### Węzeł `[88]`
Mówca: **Symon Holl**
> "“On another note. It goes without mentioning that this was a team effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Symon mentioned the beginning of a Sordish economic recovery and the plans to stop the recession altogether."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Gus continued to explain how this not only helps Holsord but also many areas along the path of the upgraded railway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[91]`
Mówca: **Narrator**
> "The crowd began cheering my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[92]`
Mówca: **Narrator**
> "The sunny weather created a positive mood in the usually grey Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Narrator**
> "The crowd looked quite large. I spotted many party members among them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> "“I welcome you Holsordians today as a proud servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[95]`
Mówca: **Symon Holl**
> "“Our aim with this project is obvious: to improve the speed and efficiency of transportation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[96]`
Mówca: **Gus Manger**
> "“Holsord! It is great to be here in this beautiful capital that does so much good for this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Symon gave me a large pair of scissors to commence the opening while the crowd was watching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“The journey to Lachaven should take about four hours and the rest of us will be in the carriage with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[99]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_AverageTransportation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[100]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_WeakTransportation = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_OnTime = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_InT_OnTime"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“I have a plan on how to do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“If Mr. President accepts, driving the first high-speed train to Lachaven would be great for our image nationwide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Lucian stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> "“First of all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Gus Manger**
> "“Well done, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[107]`
Mówca: **Symon Holl**
> "“To many more projects like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
> "“Congratulations everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“We couldn't have done this without our excellent team.”"]** — Mówca: **Player**
> "“We couldn't have done this without our excellent team.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I silently nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Lucian Galade**
> "“Let's move on to our plans for the opening tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
> "“What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“I think so too. Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“I guess we can't help it.”"]** — Mówca: **Player**
> "“I guess we can't help it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Once again, good work everyone.”"]** — Mówca: **Player**
> "“Once again, good work everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Lucian took Gus' place after he was done with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Lucian took Symon's place after he was done with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
> "“Citizens of Holsord! There you have it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“As promised, Anton Rayne—the 4th President of Sordland—has delivered!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[123]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“My fellow Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“My fellow Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[127]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_RailwayOpening = true;
BaseGame.Policy_Economy_RailwayProject = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_RailwayOpening"] = true;
Variable["BaseGame.Policy_Economy_RailwayProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_Show = true;
BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_Show = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_Show"] = true;
Variable["BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

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
  - -> `[137]`

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
  - -> `[136]`

### Węzeł `[134]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_NoShow = true;
BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_NoShow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_NoShow"] = true;
Variable["BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[136]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_Show = true;
BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_Show = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_Show"] = true;
Variable["BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[137]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[139]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_NoShow = true;
BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_NoShow = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_NoShow"] = true;
Variable["BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // filler node)*
- **Efekt (`userScript`):** `-- filler node;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[145]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Holsord", "Progress_Railway");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","Progress_Railway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Holsord", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Holsord","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Holsord", "City_LogisticalIssues");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_LogisticalIssues");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Anrica", "City_AntiquatedRailway");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_AntiquatedRailway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Gelsord", "City_AntiquatedRailway");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Gelsord","City_AntiquatedRailway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Lachaven", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Lachaven","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Anrica", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Anrica","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Gelsord", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Gelsord","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[153]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: PlaySoundEffect("RibbonCut");)*
- **Efekt (`userScript`):** `PlaySoundEffect("RibbonCut");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[154]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_CeremonialScissors");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[155]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Holsord", "52.5");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Holsord","52.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Holsord", "5.25");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Holsord","5.25");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Erlory", "3.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Erlory","3.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Erlory", "0.55");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Erlory","0.55");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Anrica", "7.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Anrica","7.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Anrica", "1.65");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Anrica","1.65");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Gelsord", "18.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Gelsord","18.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Gelsord", "1.45");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Gelsord","1.45");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Lachaven", "83.5");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Lachaven","83.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Lachaven", "3.4");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Lachaven","3.4");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[166]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[167]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
