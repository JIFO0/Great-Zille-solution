# Sordland/Turn08/InT_LateRailwayOpening

- **ID konwersacji:** `168`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/168_InT_LateRailwayOpening.md`
- **Liczba węzłów dialogowych:** 173
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
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGameIsolated.Turn06_InT_Show`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.Policy_Economy_RailwayProject`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGameIsolated.Turn06_InT_Show`
- `BaseGameSupport.Journal_Turn08_LateRailwayOpening`
- `BaseGameSupport.News_Turn08_E_L1_SSC_NoShow`
- `BaseGameSupport.News_Turn08_E_L1_SSC_Show`
- `BaseGameSupport.News_Turn08_E_L1_Taurus_NoShow`
- `BaseGameSupport.News_Turn08_E_L1_Taurus_Show`
- `BaseGameSupport.News_Turn08_HP_L1_SSC_NoShow`
- `BaseGameSupport.News_Turn08_HP_L1_SSC_Show`
- `BaseGameSupport.News_Turn08_HP_L1_Taurus_NoShow`
- `BaseGameSupport.News_Turn08_HP_L1_Taurus_Show`
- `GameCondition.Turn08_InT_LateOpening`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 35

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.Policy_Economy_RailwayProject`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[4]` (Symon Holl): `Variable["GameCondition.Turn08_InT_LateOpening"] = true;`
- Węzeł `[40]` (Symon Holl): `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- Węzeł `[98]` (Symon Holl): `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- Węzeł `[99]` (Symon Holl): `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- Węzeł `[100]` (Symon Holl): `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- Węzeł `[128]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn08_LateRailwayOpening"] = true; Variable["BaseGame.Policy_E...`
- Węzeł `[129]` (Symon Holl): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- Węzeł `[142]` (Symon Holl): `Variable["BaseGameSupport.News_Turn08_E_L1_Taurus_Show"] = true; Variable["BaseGameSupport.News_T...`
- *...oraz 27 innych węzłów ze skryptami.*

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
  - -> `[129]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The locomotive assistant flipped a few switches, and the train began pulling out of the central station. Lucian waved at the press photographers as I "drove"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[4]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_InT_LateOpening = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_InT_LateOpening"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[5]`
Mówca: **Narrator**
> "It was a great victory for my administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The railway officially opened to the public right after we left, and thousands began using it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

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
> "We walked towards the line where the first electric train was waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Cut the ribbon."]** — Mówca: **Player_Italic**
> "I cut the ribbon, triggering cheers from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Symon Holl**
> "“Congratulations to all. Hopefully this success will lead to many more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Gus Manger**
> "“It's a good moment indeed. We have helped so many in the countryside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“The train is prepared, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[15]`
Mówca: **Narrator**
> "A red ribbon was hanging by the door of the train."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[16]`
Mówca: **Gus Manger**
> "“Sounds fantastic. The President arriving to Lachaven in the driver's seat would make the headlines for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[17]`
Mówca: **Narrator**
> "It was finally happening. Tomorrow would be the grand opening ceremony of the L-1 High-speed rail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Symon and Gus, who had heavily assisted in the project, had come to discuss the ceremony plans with Lucian and myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“I don't support anything beyond the opening ceremony. The railway's completion speaks for itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Gus Manger**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[21]`
Mówca: **Gus Manger**
> "“I see your point. But involving the President further could be beneficial for the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Get in the train."]** — Mówca: **Player_Italic**
> "I entered the cab and took a seat with the assistant beside me. The crowd was trying to catch a glimpse of me through the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“Alright then. We have a lot of work to do. See you tomorrow morning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[60]`
  - -> `[115]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“It's been a long time since the last successful infrastructure project. From a public relations point of view, we can certainly capitalize on the occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

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
**[WYBÓR GRACZA: "“Lucian, I want you to ride with me.”"]** — Mówca: **Player**
> "“Lucian, I want you to ride with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Symon Holl**
> "“This isn't necessary, but I won't refuse. We can talk about future economic projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good journey. We can talk about the election campaign preparations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I agree. Get me on that train.""]** — Mówca: **Player**
> "“I agree. Get me on that train.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"]** — Mówca: **Player**
> "“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Sure. We will be in the other carriages. See you in Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Thanks to this railway, thousands of new jobs have been and will continue to be created.""]** — Mówca: **Player**
> "“Thanks to this railway, thousands of new jobs have been and will continue to be created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[46]`
  - -> `[68]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Gus sauntered over to the podium and leaned into the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[39]`
Mówca: **Narrator**
> "The locomotive assistant flipped a few switches, and the train began pulling out of the central station. Symon smiled awkwardly at the press photographers as I "drove"."
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
> "The locomotive assistant flipped a few switches, and the train began pulling out of the central station. Gus gave a thumbs-up to the press photographers as I "drove"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Thanks to this railway, travel between Holsord and Lachaven is now twice as fast and endlessly more comfortable.""]** — Mówca: **Player**
> ""Thanks to this railway, travel between Holsord and Lachaven is now twice as fast and endlessly more comfortable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[46]`
  - -> `[68]`

### Węzeł `[43]`
Mówca: **Narrator**
> "The locomotive assistant flipped a few switches, and the train began pulling out of the central station. I waved at the press photographers as I "drove"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“Of course. We'll hold the ceremony and open the upgraded railway to the public immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Ensuring the success of this project wasn't just one of my presidential goals -- it was my personal priority.""]** — Mówca: **Player**
> "“Ensuring the success of this project wasn't just one of my presidential goals -- it was my personal priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "Walk to the podium."]** — Mówca: **Player_Italic**
> "I walked up to the podium to address the crowd. The press was taking dozens of pictures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[71]`
  - -> `[64]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Lucian's voice echoed in the central station. Thousands of Sordland and USP flags began to wave as the loud cheers intensified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[49]`
Mówca: **Narrator**
> "The new train was in pristine condition. Its electric engine provided the smoothest ride I'd ever had."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“This railway project is a perfect example of how we can bring prosperity to the under-developed areas between our major cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“See you at the ceremony.”"]** — Mówca: **Player**
> "“See you at the ceremony.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“The people will be satisfied with their improved transportation service anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> "“Additionally, a large crowd has been invited to the ceremony and will be watching the opening speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[63]`
  - -> `[74]`
  - -> `[113]`

### Węzeł `[54]`
Mówca: **Narrator**
> "After an uneventful four hours on board, we were welcomed by a throng of citizens at Lachaven station."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Lucian took my place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“Once we cut that ribbon and the citizens of Holsord get on the train, I believe you'll agree we have succeeded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Signal for Lucian to begin the ceremony."]** — Mówca: **Player_Italic**
> "I gave the green light to Lucian, and the opening address began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Narrator**
> "The next morning, a stage had been erected inside the central station."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> "“Brothers and sisters of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Goodbye for now.”"]** — Mówca: **Player**
> "“Goodbye for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
Mówca: **Symon Holl**
> "“Thanks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[62]`
Mówca: **Narrator**
> "We took our places onstage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It will be a good opportunity for exposure.”"]** — Mówca: **Player**
> "“It will be a good opportunity for exposure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Narrator**
> "We all dispersed in order to prepare for the big day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“We built this railway to create economic growth throughout the Greater Holsord and Gelsland regions.""]** — Mówca: **Player**
> "“We built this railway to create economic growth throughout the Greater Holsord and Gelsland regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[37]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Without further ado, I invite the President of Sordland to the stage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I want to acknowledge the brilliant mind behind this project, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"]** — Mówca: **Player**
> "“I want to acknowledge the brilliant mind behind this project, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Nothing like a cheerful crowd. Looking forward to it.”"]** — Mówca: **Player**
> "“Nothing like a cheerful crowd. Looking forward to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

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
**[WYBÓR GRACZA: "“Holsordians! Welcome to the opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“Holsordians! Welcome to the opening ceremony of the L-1 High-speed railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“None of this would be possible without the sound advice of my cabinet member Gus Manger. Please come over here.”"]** — Mówca: **Player**
> "“None of this would be possible without the sound advice of my cabinet member Gus Manger. Please come over here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Like the good old campaign days.”"]** — Mówca: **Player**
> "“Like the good old campaign days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“We will show our best face tomorrow. Meanwhile, I'll make sure that our message about improving the countryside gets across.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[76]`
Mówca: **Narrator**
> "The chanting from the crowd continued. Some were yelling the motto of Holsord: High above all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“At the beginning of this journey, we promised jobs and opportunity. We kept our promise.”"]** — Mówca: **Player**
> "“At the beginning of this journey, we promised jobs and opportunity. We kept our promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[78]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Our intention with the L-1 Railway was to allow citizens to easily commute between the major cities of Holsord and Lachaven.”"]** — Mówca: **Player**
> "“Our intention with the L-1 Railway was to allow citizens to easily commute between the major cities of Holsord and Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[37]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Trust me, our work is far from over. This project is only the beginning.”"]** — Mówca: **Player**
> "“Trust me, our work is far from over. This project is only the beginning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“Things were certainly easier back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[81]`
Mówca: **Gus Manger**
> "“We had our disagreements, but the important thing was the outcome. The Sordish people have been waiting a long time for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“Agreed. Every single press outlet has of course been notified and they will be there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> "“I think all of us are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Symon, you deserve the credit. After all, it was you who came up with the project.”"]** — Mówca: **Player**
> "“Symon, you deserve the credit. After all, it was you who came up with the project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“Thank you for your kind words. It truly means a good deal.”"]** — Mówca: **Player**
> "“Thank you for your kind words. It truly means a good deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[86]`
Mówca: **Symon Holl**
> "“Beginning with the President who put his trust in me, I want to thank all who were involved in L-1.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`
  - -> `[114]`

### Węzeł `[87]`
Mówca: **Symon Holl**
> "“On another note. It goes without mentioning that this was a team effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Symon went on to explain how this railway was a crucial stepping stone on the way to a full Sordish economic recovery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Gus continued to explain the many benefits the upgraded railway would bring to the areas along its path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[90]`
Mówca: **Narrator**
> "The crowd began cheering my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[91]`
Mówca: **Narrator**
> "It was a sunny day in our usually cloudy capital city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "The crowd looked quite large. I spotted many party members."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> "“I welcome you Holsordians today as a proud servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[94]`
Mówca: **Symon Holl**
> "“Our aim with this project wasobvious: to improve the speed and efficiency of transportation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[95]`
Mówca: **Gus Manger**
> "“Holsord! It is great to be here in this beautiful capital that does so much good for this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Symon handed me an oversized pair of scissors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> "“The journey to Lachaven should take about four hours. The rest of us will be on the train as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[98]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_AverageTransportation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[99]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[100]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_WeakTransportation = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“I have a plan on how to do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“If the President accepts, driving the first high-speed train to Lachaven would be great for our image nationwide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[103]`
Mówca: **Narrator**
> "Lucian stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[104]`
Mówca: **Gus Manger**
> "“Well done, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Symon Holl**
> "“To many more projects like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“We couldn't have done this without our excellent team.”"]** — Mówca: **Player**
> "“We couldn't have done this without our excellent team.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I silently nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“Let's move on to our plans for the opening tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> "“What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
> "“I think so too. Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“I guess we can't avoid that.”"]** — Mówca: **Player**
> "“I guess we can't avoid that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Once again, good work everyone.”"]** — Mówca: **Player**
> "“Once again, good work everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Lucian took Gus' place after he was done with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Narrator**
> "Lucian took Symon's place after he was done with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“Citizens of Holsord! There you have it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“As promised, Anton Rayne, the 4th President of Sordland, has delivered!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[120]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“My fellow Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“My fellow Holsordians! I welcome you today to the opening ceremony of our L-1 High-speed railway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Though the construction delay had taken its toll on our morale, this was still a proud moment for all of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
> "“First of all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
> "“This day might have arrived later than expected, but it doesn't change the fact that we are here now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
> "“This is still a big success. Congratulations, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_LateRailwayOpening = true;
BaseGame.Policy_Economy_RailwayProject = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LateRailwayOpening"] = true;
Variable["BaseGame.Policy_Economy_RailwayProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[129]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[130]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[132]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_TaurusHolding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[136]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[138]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[139]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_E_L1_Taurus_Show = true;
BaseGameSupport.News_Turn08_HP_L1_Taurus_Show = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_E_L1_Taurus_Show"] = true;
Variable["BaseGameSupport.News_Turn08_HP_L1_Taurus_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_L1_Taurus_NoShow = true;
BaseGameSupport.News_Turn08_E_L1_Taurus_NoShow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_L1_Taurus_NoShow"] = true;
Variable["BaseGameSupport.News_Turn08_E_L1_Taurus_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_L1_SSC_NoShow = true;
BaseGameSupport.News_Turn08_E_L1_SSC_NoShow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_L1_SSC_NoShow"] = true;
Variable["BaseGameSupport.News_Turn08_E_L1_SSC_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[145]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_E_L1_SSC_Show = true;
BaseGameSupport.News_Turn08_HP_L1_SSC_Show = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_E_L1_SSC_Show"] = true;
Variable["BaseGameSupport.News_Turn08_HP_L1_SSC_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[146]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[147]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Holsord", "Progress_Railway");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","Progress_Railway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Holsord", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Holsord","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Holsord", "City_LogisticalIssues");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_LogisticalIssues");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Anrica", "City_AntiquatedRailway");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_AntiquatedRailway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Gelsord", "City_AntiquatedRailway");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Gelsord","City_AntiquatedRailway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Lachaven", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Lachaven","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Anrica", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Anrica","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Gelsord", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Gelsord","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[155]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[157]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[158]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_CeremonialScissors");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Holsord", "52.5");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Holsord","52.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Holsord", "5.25");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Holsord","5.25");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Erlory", "3.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Erlory","3.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Erlory", "0.55");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Erlory","0.55");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Anrica", "7.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Anrica","7.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Anrica", "1.65");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Anrica","1.65");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Gelsord", "18.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Gelsord","18.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Gelsord", "1.45");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Gelsord","1.45");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Lachaven", "83.5");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Lachaven","83.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Lachaven", "3.4");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Lachaven","3.4");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[170]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[171]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: PlaySoundEffect("RibbonCut");)*
- **Efekt (`userScript`):** `PlaySoundEffect("RibbonCut");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[172]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
