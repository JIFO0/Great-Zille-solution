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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **"Cut the ribbon."** | `[97]` **Narrator**: "Symon gave me a large pair of sc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Symon Holl**: "“Congratulations to all. It was ..." |
| `[22]` | **"Enter train."** | `[98]` **Lucian Galade**: "“The journey to Lachaven should ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." |
| `[25]` | **"“I'd like Gus with me.”"** | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Gus Manger**: "“I'm honored. It will be great t..." |
| `[26]` | **"“I will drive the train on my own.”"** | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lucian Galade**: "“Sure. We will be in the other c..." |
| `[29]` | **"“I want to have Symon in the cab.”"** | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Symon Holl**: "“This isn't necessary but I won'..." |
| `[31]` | **"“Lucian, you would be my preference.”"** | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucian Galade**: "“Thank you, Mr. President. It wi..." |
| `[34]` | **"“I agree. There is much to gain.”"** | `[115]` **Lucian Galade**: "“I think so too. Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;` | `[45]` **Lucian Galade**: "“Very well.”" |
| `[35]` | **"“I'd prefer we just do the opening ceremony. No need for senseless show.”"** | `[115]` **Lucian Galade**: "“I think so too. Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lucian Galade**: "“Of course. We'll do the ceremon..." |
| `[37]` | **"“This Railway brings thousands of new jobs! Many unemployed citizens have benefite..."** | `[66]` **Player**: "“The aim with the L-1 Railway wa..."<br>`[78]` **Player**: "“Our intention with the L-1 Rail..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Player**: "“None of this would be possible ..."<br>`[46]` **Player**: "“I took time off from my duties ..."<br>*(oraz 1 innych odgałęzień)* |
| `[42]` | **"“This railway brings down travel time by half! Travelling between Holsord and Lach..."** | `[66]` **Player**: "“The aim with the L-1 Railway wa..."<br>`[78]` **Player**: "“Our intention with the L-1 Rail..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Player**: "“None of this would be possible ..."<br>`[46]` **Player**: "“I took time off from my duties ..."<br>*(oraz 1 innych odgałęzień)* |
| `[46]` | **"“I took time off from my duties to personally manage the project to success.”"** | `[37]` **Player**: "“This Railway brings thousands o..."<br>`[42]` **Player**: "“This railway brings down travel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "The crowd began cheering my name." |
| `[47]` | **"Move up to the stage."** | `[67]` **Lucian Galade**: "“Without further ado, I invite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Player**: "“Citizens! Welcome to the openin..."<br>`[64]` **Player**: "“People of Sordland! Welcome to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[51]` | **"“See you at the ceremony.”"** | `[23]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "The team left, leaving the rest ..." |
| `[57]` | **"Signal Lucian to begin the ceremony."** | `[62]` **Narrator**: "We began moving towards the stag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Lucian Galade**: "“Brothers and sisters of Sordland!”" |
| `[60]` | **"“Goodbye for now.”"** | `[23]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "The team left, leaving the rest ..." |
| `[63]` | **"“It will be a good opportunity for exposure.”"** | `[53]` **Lucian Galade**: "“Additionally, a large crowd is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Lucian Galade**: "“Agreed. Every single press outl..." |
| `[64]` | **"“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"** | `[47]` **Player_Italic**: "I moved up to the stage to addre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "The chanting and excitement from..." |
| `[66]` | **"“The aim with the L-1 Railway was to improve development in rural areas and cities..."** | `[77]` **Player**: "“At the beginning of this journe..."<br>`[79]` **Player**: "“Trust me, our work is far from ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Player**: "“This railway brings down travel..."<br>`[37]` **Player**: "“This Railway brings thousands o..." |
| `[68]` | **"“We have to thank the mind behind the railway project for it all, the esteemed Min..."** | `[37]` **Player**: "“This Railway brings thousands o..."<br>`[42]` **Player**: "“This railway brings down travel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "Symon walked up beside me." |
| `[69]` | **"“Nothing like a cheerful crowd. Looking forward to it.”"** | `[53]` **Lucian Galade**: "“Additionally, a large crowd is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Lucian Galade**: "“I think all of us do.”" |
| `[71]` | **"“Citizens! Welcome to the opening ceremony of the L-1 High-speed railway!”"** | `[47]` **Player_Italic**: "I moved up to the stage to addre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "The chanting and excitement from..." |
| `[72]` | **"“Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed ra..."** | `[47]` **Player_Italic**: "I moved up to the stage to addre..." | `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false` | *Brak zmian stanu* | `[70]` **Narrator**: "The chanting and excitement from..." |
| `[73]` | **"“None of this would be possible without my colleague with sound advice, the Minist..."** | `[37]` **Player**: "“This Railway brings thousands o..."<br>`[42]` **Player**: "“This railway brings down travel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "Gus came to the podium with his ..." |
| `[74]` | **"“Like the good old campaign days.”"** | `[53]` **Lucian Galade**: "“Additionally, a large crowd is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lucian Galade**: "“Things were certainly easier ba..." |
| `[77]` | **"“At the beginning of this journey we promised jobs and opportunity. We kept our pr..."** | `[70]` **Narrator**: "The chanting and excitement from..."<br>`[76]` **Narrator**: "The chanting from the crowd cont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player**: "“The aim with the L-1 Railway wa..."<br>`[78]` **Player**: "“Our intention with the L-1 Rail..." |
| `[78]` | **"“Our intention with the L-1 Railway was to serve our citizens who were having a ha..."** | `[77]` **Player**: "“At the beginning of this journe..."<br>`[79]` **Player**: "“Trust me, our work is far from ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Player**: "“This railway brings down travel..."<br>`[37]` **Player**: "“This Railway brings thousands o..." |
| `[79]` | **"“Trust me, our work is far from over. This project is only the beginning of good t..."** | `[70]` **Narrator**: "The chanting and excitement from..."<br>`[76]` **Narrator**: "The chanting from the crowd cont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player**: "“The aim with the L-1 Railway wa..."<br>`[78]` **Player**: "“Our intention with the L-1 Rail..." |
| `[85]` | **"“Symon, you deserve a lot of credit. After all, it was you who came up with the pr..."** | `[87]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Gus Manger**: "“We had our disagreements, but t..." |
| `[86]` | **"“Thank you for your kind words. It truly means a good deal.”"** | `[87]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Gus Manger**: "“We had our disagreements, but t..." |
| `[109]` | **"“Good work.”"** | `[106]` **Gus Manger**: "“Well done, everyone.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lucian Galade**: "“Indeed.”" |
| `[110]` | **"“We couldn't have done this without our excellent team.”"** | `[106]` **Gus Manger**: "“Well done, everyone.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lucian Galade**: "“Indeed.”" |
| `[111]` | **"Nod."** | `[106]` **Gus Manger**: "“Well done, everyone.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Lucian Galade**: "“Let's move on to our plans for ..." |
| `[116]` | **"“I guess we can't help it.”"** | `[53]` **Lucian Galade**: "“Additionally, a large crowd is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Symon stepped in for a comment." |
| `[117]` | **"“Thank you.”"** | `[87]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Gus Manger**: "“We had our disagreements, but t..." |
| `[118]` | **"“Once again, good work everyone.”"** | `[23]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "The team left, leaving the rest ..." |
| `[126]` | **"“My fellow Holsordians! I welcome you today to our opening ceremony of the L-1 Hig..."** | `[47]` **Player_Italic**: "I moved up to the stage to addre..." | `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]` | *Brak zmian stanu* | `[76]` **Narrator**: "The chanting from the crowd cont..." |

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
  - -> `[17]` (*Narrator: "We arrived in Holsord for the grand opening ceremony of t..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "As we began driving the train out of the central station, the media took photos of me and Lucian who kept his usual cool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The new train was in pristine condition and the electric ..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_InT_Opening = true;
BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_InT_Opening"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Today was a great victory for the administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_OnTime = true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The railway officially opened to the public as soon as we arrived and thousands began utilising it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“The train is prepared and ready.”"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The railway officially opened to the public as soon as we..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "We moved towards the line where the first electric train was waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "A red ribbon was hanging by the door of the train."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Cut the ribbon."]** — Mówca: **Player_Italic**
> "I cut the ribbon which led to a huge wave of cheering from the crowd. Many flashes went off at the same time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Symon Holl: "“Congratulations to all. It was a solid and fruitful effo..."*)

### Węzeł `[12]`
Mówca: **Symon Holl**
> "“Congratulations to all. It was a solid and fruitful effort. Hopefully with much more to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Gus Manger: "“It's a good moment indeed. We have helped so many in the..."*)

### Węzeł `[13]`
Mówca: **Gus Manger**
> "“It's a good moment indeed. We have helped so many in the countryside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“The train is prepared and ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucian Galade: "“The journey to Lachaven should take about four hours and..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "A red ribbon was hanging by the door of the train."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Symon gave me a large pair of scissors to commence the op..."*)

### Węzeł `[16]`
Mówca: **Gus Manger**
> "“Sounds fantastic. The President arriving to Lachaven on the driver seat would make the headlines for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: "“Additionally, a large crowd is invited for the ceremony ..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "We arrived in Holsord for the grand opening ceremony of the L-1 High-speed rail. It was a proud moment for all of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Symon and Gus, who heavily assisted the project, were wit..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Symon and Gus, who heavily assisted the project, were with me along with Lucian to decide on how to proceed tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_CeremonialScissors");"*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“I don't support anything beyond the opening ceremony. Actions speak for themselves anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Gus Manger: "“I see your point. But involving the President further co..."*)

### Węzeł `[20]`
Mówca: **Gus Manger**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Gus Manger: "“Holsord! It is great to be here in this beautiful capita..."*)

### Węzeł `[21]`
Mówca: **Gus Manger**
> "“I see your point. But involving the President further could be beneficial for the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: "“I think so too. Mr. President?”"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Enter train."]** — Mówca: **Player_Italic**
> "I entered the cab and took a seat with the assistant beside me. The crowd was trying to catch a glimpse of me sitting as driver of the train."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: "“Who do you want to travel with in the cab, Mr. President?”"*)

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“Alright then. We have a lot of work to do tomorrow. See you in the morning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“See you at the ceremony.”"*)
  - -> `[60]` (*Player: "“Goodbye for now.”"*)
  - -> `[118]` (*Player: "“Once again, good work everyone.”"*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“It's been a long time since the last successful infrastructure project. There is good reason to capitalise on the occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“I have a plan on how to do that.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“I'd like Gus with me.”"]** — Mówca: **Player**
> "“I'd like Gus with me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gus Manger: "“I'm honored. It will be great to arrive in Lachaven with..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I will drive the train on my own.”"]** — Mówca: **Player**
> "“I will drive the train on my own.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: "“Sure. We will be in the other carriages. See you in Lach..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Symon walked up beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Symon Holl: "“Thanks, Mr. President.”"*)

### Węzeł `[28]`
Mówca: **Gus Manger**
> "“I'm honored. It will be great to arrive in Lachaven with the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "As we began driving the train out of the central station,..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I want to have Symon in the cab.”"]** — Mówca: **Player**
> "“I want to have Symon in the cab.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Symon Holl: "“This isn't necessary but I won't refuse. We can talk abo..."*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“Who do you want to travel with in the cab, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Lucian, you would be my preference.”"*)
  - -> `[29]` (*Player: "“I want to have Symon in the cab.”"*)
  - -> `[25]` (*Player: "“I'd like Gus with me.”"*)
  - -> `[26]` (*Player: "“I will drive the train on my own.”"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Lucian, you would be my preference.”"]** — Mówca: **Player**
> "“Lucian, you would be my preference.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: "“Thank you, Mr. President. It will be a good journey. We ..."*)

### Węzeł `[32]`
Mówca: **Symon Holl**
> "“This isn't necessary but I won't refuse. We can talk about future economic projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "As we began driving the train out of the central station,..."*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good journey. We can talk about the reforms on the way as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "As we began driving the train out of the central station,..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I agree. There is much to gain.”"]** — Mówca: **Player**
> "“I agree. There is much to gain.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show = true"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“I'd prefer we just do the opening ceremony. No need for senseless show.”"]** — Mówca: **Player**
> "“I'd prefer we just do the opening ceremony. No need for senseless show.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: "“Of course. We'll do the ceremony and open the upgraded r..."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Sure. We will be in the other carriages. See you in Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "As we began driving the train out of the central station,..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“This Railway brings thousands of new jobs! Many unemployed citizens have benefited and will benefit on the path of the railway.”"]** — Mówca: **Player**
> "“This Railway brings thousands of new jobs! Many unemployed citizens have benefited and will benefit on the path of the railway.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Player), `[78]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“None of this would be possible without my colleague with..."*)
  - -> `[46]` (*Player: "“I took time off from my duties to personally manage the ..."*)
  - -> `[68]` (*Player: "“We have to thank the mind behind the railway project for..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Gus came to the podium with his relaxed casual posture. He then leaned to the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Gus Manger: "“Thank you, Mr. President.”"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "As we began driving the train out of the central station, the media took photos of me and Symon who smiled to the cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The new train was in pristine condition and the electric ..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“Very well.”"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "As we began driving the train out of the central station, the media took photos of me and Gus who gave a thumbs up to the cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The new train was in pristine condition and the electric ..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“This railway brings down travel time by half! Travelling between Holsord and Lachaven is now faster and more comfortable.”"]** — Mówca: **Player**
> "“This railway brings down travel time by half! Travelling between Holsord and Lachaven is now faster and more comfortable.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Player), `[78]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“None of this would be possible without my colleague with..."*)
  - -> `[46]` (*Player: "“I took time off from my duties to personally manage the ..."*)
  - -> `[68]` (*Player: "“We have to thank the mind behind the railway project for..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "As we began driving the train out of the central station, the media took photos of me driving by myself with the locomotive assistant next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The new train was in pristine condition and the electric ..."*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“Of course. We'll do the ceremony and open the upgraded railway to the public immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“The people will be satisfied with the improved transport..."*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Gus Manger: "“Sounds fantastic. The President arriving to Lachaven on ..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“I took time off from my duties to personally manage the project to success.”"]** — Mówca: **Player**
> "“I took time off from my duties to personally manage the project to success.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "The crowd began cheering my name."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "Move up to the stage."]** — Mówca: **Player_Italic**
> "I moved up to the stage to address the crowd. The press was taking dozens of pictures."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle"*)
  - -> `[71]` (*Player: "“Citizens! Welcome to the opening ceremony of the L-1 Hig..."*)
  - -> `[64]` (*Player: "“People of Sordland! Welcome to the opening ceremony of t..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Lucian's voice echoed in the central station. Thousands of Sordland and USP flags began to wave as the loud cheers intensified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“Without further ado, I invite the President of Sordland ..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "The new train was in pristine condition and the electric engine made much faster acceleration possible while providing minimal noise and maximum comfort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "After the relaxing four hour drive to Lachaven, we were w..."*)

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“This railway project is a perfect example of how we can bring prosperity to the under-developed areas in between our major cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Gus continued to explain how this not only helps Holsord ..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“See you at the ceremony.”"]** — Mówca: **Player**
> "“See you at the ceremony.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "The team left, leaving the rest of the evening to prepare..."*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“The people will be satisfied with the improved transportation service anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: "“Additionally, a large crowd is invited for the ceremony ..."*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> "“Additionally, a large crowd is invited for the ceremony and will be watching the opening speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "“Nothing like a cheerful crowd. Looking forward to it.”"*)
  - -> `[63]` (*Player: "“It will be a good opportunity for exposure.”"*)
  - -> `[74]` (*Player: "“Like the good old campaign days.”"*)
  - -> `[116]` (*Player: "“I guess we can't help it.”"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "After the relaxing four hour drive to Lachaven, we were welcomed by celebratory citizens at Lachaven station."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The railway officially opened to the public as soon as we..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Lucian took my place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: "“Citizens of Holsord! There you have it!”"*)

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“I'm sure each one of you will be proud of the achievements made during the project once we cut that ribbon. And you can get on that train yourselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Symon mentioned the beginning of a Sordish economic recov..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Signal Lucian to begin the ceremony."]** — Mówca: **Player_Italic**
> "We were all ready to begin the ceremony. I gave the green-light and the opening address began."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: "“Brothers and sisters of Sordland!”"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "The next day, a stage had been erected inside the central station along the new electrified railway line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "The sunny weather created a positive mood in the usually ..."*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> "“Brothers and sisters of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: "“I welcome you Holsordians today as a proud servant of th..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Goodbye for now.”"]** — Mówca: **Player**
> "“Goodbye for now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "The team left, leaving the rest of the evening to prepare..."*)

### Węzeł `[61]`
Mówca: **Symon Holl**
> "“Thanks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Symon Holl: "“Our aim with this project is obvious: to improve the spe..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "We began moving towards the stage as the excitement was growing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Italic: "Signal Lucian to begin the ceremony."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It will be a good opportunity for exposure.”"]** — Mówca: **Player**
> "“It will be a good opportunity for exposure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: "“Agreed. Every single press outlet has of course been not..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "The chanting and excitement from the crowd intensified. A..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "The team left, leaving the rest of the evening to prepare for the big day tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "The next day, a stage had been erected inside the central..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“The aim with the L-1 Railway was to improve development in rural areas and cities in between Holsord and Lachaven to create economic growth in the Greater Holsord and Gelsland regions.”"]** — Mówca: **Player**
> "“The aim with the L-1 Railway was to improve development in rural areas and cities in between Holsord and Lachaven to create economic growth in the Greater Holsord and Gelsland regions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Player), `[79]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“This railway brings down travel time by half! Travelling..."*)
  - -> `[37]` (*Player: "“This Railway brings thousands of new jobs! Many unemploy..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Without further ado, I invite the President of Sordland to the stage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Italic: "Move up to the stage."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“We have to thank the mind behind the railway project for it all, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"]** — Mówca: **Player**
> "“We have to thank the mind behind the railway project for it all, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Symon walked up beside me."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Nothing like a cheerful crowd. Looking forward to it.”"]** — Mówca: **Player**
> "“Nothing like a cheerful crowd. Looking forward to it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucian Galade: "“I think all of us do.”"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "The chanting and excitement from the crowd intensified. A large group began singing the national anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“At the beginning of this journey we promised jobs and op..."*)
  - -> `[79]` (*Player: "“Trust me, our work is far from over. This project is onl..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Citizens! Welcome to the opening ceremony of the L-1 High-speed railway!”"]** — Mówca: **Player**
> "“Citizens! Welcome to the opening ceremony of the L-1 High-speed railway!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "The chanting and excitement from the crowd intensified. A..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“Holsordians! Welcome to the opening ceremony of the L-1 High-speed railway.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "The chanting and excitement from the crowd intensified. A..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“None of this would be possible without my colleague with sound advice, the Minister Gus Manger. Please come over here.”"]** — Mówca: **Player**
> "“None of this would be possible without my colleague with sound advice, the Minister Gus Manger. Please come over here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Gus came to the podium with his relaxed casual posture. H..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Like the good old campaign days.”"]** — Mówca: **Player**
> "“Like the good old campaign days.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“Things were certainly easier back then.”"*)

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“We will show our best face tomorrow. Meanwhile, I'll make sure that our message of improving the countryside will get across.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Symon Holl: "“Alright then. We have a lot of work to do tomorrow. See ..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "The chanting from the crowd continued. Some were yelling the motto of Holsord; High above all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“At the beginning of this journey we promised jobs and op..."*)
  - -> `[79]` (*Player: "“Trust me, our work is far from over. This project is onl..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“At the beginning of this journey we promised jobs and opportunity. We kept our promise.”"]** — Mówca: **Player**
> "“At the beginning of this journey we promised jobs and opportunity. We kept our promise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator), `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“The aim with the L-1 Railway was to improve development ..."*)
  - -> `[78]` (*Player: "“Our intention with the L-1 Railway was to serve our citi..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Our intention with the L-1 Railway was to serve our citizens who were having a hard time travelling between the major cities of Holsord and Lachaven.”"]** — Mówca: **Player**
> "“Our intention with the L-1 Railway was to serve our citizens who were having a hard time travelling between the major cities of Holsord and Lachaven.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Player), `[79]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“This railway brings down travel time by half! Travelling..."*)
  - -> `[37]` (*Player: "“This Railway brings thousands of new jobs! Many unemploy..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Trust me, our work is far from over. This project is only the beginning of good tidings.”"]** — Mówca: **Player**
> "“Trust me, our work is far from over. This project is only the beginning of good tidings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator), `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“The aim with the L-1 Railway was to improve development ..."*)
  - -> `[78]` (*Player: "“Our intention with the L-1 Railway was to serve our citi..."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“Things were certainly easier back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Symon stepped in for a comment."*)

### Węzeł `[81]`
Mówca: **Gus Manger**
> "“We had our disagreements, but the important thing was the outcome. Sordish people got what they needed for a long time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Gus Manger: "“We will show our best face tomorrow. Meanwhile, I'll mak..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Symon stepped in for a comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[83]`
Mówca: **Lucian Galade**
> "“Agreed. Every single press outlet has of course been notified and they will be there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Symon stepped in for a comment."*)

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“I think all of us do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Symon stepped in for a comment."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“Symon, you deserve a lot of credit. After all, it was you who came up with the project.”"]** — Mówca: **Player**
> "“Symon, you deserve a lot of credit. After all, it was you who came up with the project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gus Manger: "“We had our disagreements, but the important thing was th..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Thank you for your kind words. It truly means a good deal.”"]** — Mówca: **Player**
> "“Thank you for your kind words. It truly means a good deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gus Manger: "“We had our disagreements, but the important thing was th..."*)

### Węzeł `[87]`
Mówca: **Symon Holl**
> "“Beginning with the President who put his trust in me, I want to thank all who were involved in L-1.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "“Symon, you deserve a lot of credit. After all, it was yo..."*)
  - -> `[86]` (*Player: "“Thank you for your kind words. It truly means a good deal.”"*)
  - -> `[117]` (*Player: "“Thank you.”"*)

### Węzeł `[88]`
Mówca: **Symon Holl**
> "“On another note. It goes without mentioning that this was a team effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Symon Holl: "“Beginning with the President who put his trust in me, I ..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Symon mentioned the beginning of a Sordish economic recovery and the plans to stop the recession altogether."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Lucian took Symon's place after he was done with his speech."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Gus continued to explain how this not only helps Holsord but also many areas along the path of the upgraded railway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Lucian took Gus' place after he was done with his speech."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "The crowd began cheering my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Lucian took my place on the stage to close the ceremony."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "The sunny weather created a positive mood in the usually grey Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "The crowd looked quite large. I spotted many party member..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "The crowd looked quite large. I spotted many party members among them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "We began moving towards the stage as the excitement was g..."*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> "“I welcome you Holsordians today as a proud servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Lucian's voice echoed in the central station. Thousands o..."*)

### Węzeł `[95]`
Mówca: **Symon Holl**
> "“Our aim with this project is obvious: to improve the speed and efficiency of transportation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Symon Holl: "“I'm sure each one of you will be proud of the achievemen..."*)

### Węzeł `[96]`
Mówca: **Gus Manger**
> "“Holsord! It is great to be here in this beautiful capital that does so much good for this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gus Manger: "“This railway project is a perfect example of how we can ..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Symon gave me a large pair of scissors to commence the opening while the crowd was watching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("RibbonCut");"*)

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“The journey to Lachaven should take about four hours and the rest of us will be in the carriage with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Italic: "Enter train."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_AverageTransportation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Today was a great victory for the administration."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_WeakTransportation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_AverageTransportation = true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_OnTime = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_InT_OnTime"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_RailwayOpening = true; Bas..."*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“I have a plan on how to do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: "“If Mr. President accepts, driving the first high-speed t..."*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“If Mr. President accepts, driving the first high-speed train to Lachaven would be great for our image nationwide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: "“What are your thoughts?”"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Lucian stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: "“First of all...”"*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> "“First of all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucian Galade: "“Congratulations everyone.”"*)

### Węzeł `[106]`
Mówca: **Gus Manger**
> "“Well done, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "“Good work.”"*)
  - -> `[110]` (*Player: "“We couldn't have done this without our excellent team.”"*)
  - -> `[111]` (*Player_Italic: "Nod."*)

### Węzeł `[107]`
Mówca: **Symon Holl**
> "“To many more projects like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Gus Manger: "“Well done, everyone.”"*)

### Węzeł `[108]`
Mówca: **Lucian Galade**
> "“Congratulations everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Symon Holl: "“To many more projects like this.”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: "“Indeed.”"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“We couldn't have done this without our excellent team.”"]** — Mówca: **Player**
> "“We couldn't have done this without our excellent team.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: "“Indeed.”"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I silently nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lucian Galade: "“Let's move on to our plans for the opening tomorrow.”"*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lucian Galade: "“Let's move on to our plans for the opening tomorrow.”"*)

### Węzeł `[113]`
Mówca: **Lucian Galade**
> "“Let's move on to our plans for the opening tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: "“It's been a long time since the last successful infrastr..."*)

### Węzeł `[114]`
Mówca: **Lucian Galade**
> "“What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“I don't support anything beyond the opening ceremony. Ac..."*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“I think so too. Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“I agree. There is much to gain.”"*)
  - -> `[35]` (*Player: "“I'd prefer we just do the opening ceremony. No need for ..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“I guess we can't help it.”"]** — Mówca: **Player**
> "“I guess we can't help it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Symon stepped in for a comment."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gus Manger: "“We had our disagreements, but the important thing was th..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Once again, good work everyone.”"]** — Mówca: **Player**
> "“Once again, good work everyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "The team left, leaving the rest of the evening to prepare..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Lucian took Gus' place after he was done with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: "“Citizens of Holsord! There you have it!”"*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Lucian took Symon's place after he was done with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: "“Citizens of Holsord! There you have it!”"*)

### Węzeł `[121]`
Mówca: **Lucian Galade**
> "“Citizens of Holsord! There you have it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucian Galade: "“As promised, Anton Rayne—the 4th President of Sordland—h..."*)

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“As promised, Anton Rayne—the 4th President of Sordland—has delivered!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "We moved towards the line where the first electric train ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: "“My fellow Holsordians! I welcome you today to our openin..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“Holsordians! I welcome you today to our opening ceremony..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“My fellow Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“My fellow Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed railway.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "The chanting from the crowd continued. Some were yelling ..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_RailwayOpening = true;
BaseGame.Policy_Economy_RailwayProject = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_RailwayOpening"] = true;
Variable["BaseGame.Policy_Economy_RailwayProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_InT_Opening = true; BaseGame.Public_..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_Show = true;
BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_Show"] = true;
Variable["BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_Show = tr..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_NoShow = ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_NoShow = true;
BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_NoShow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_NoShow"] = true;
Variable["BaseGameSupport.News_Turn06_HP_L1_Opening_Underhall_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_Show = true;
BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_Show = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_Show"] = true;
Variable["BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_NoShow = true;
BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_NoShow = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_E_L1_Opening_Taurus_NoShow"] = true;
Variable["BaseGameSupport.News_Turn06_HP_L1_Opening_Taurus_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// filler node`
- **Efekt skryptowy (`userScript`):** `-- filler node;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_Show =..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_E_L1_Opening_Underhall_NoShow..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Holsord", "Progress_Railway");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","Progress_Railway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Holsord", "City_IncreasedBu..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Holsord", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Holsord","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Holsord", "City_Logistic..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Holsord", "City_LogisticalIssues");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_LogisticalIssues");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Anrica", "City_Antiquate..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Anrica", "City_AntiquatedRailway");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_AntiquatedRailway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Gelsord", "City_Antiquat..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Gelsord", "City_AntiquatedRailway");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Gelsord","City_AntiquatedRailway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Lachaven", "City_IncreasedB..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Lachaven", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Lachaven","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Anrica", "City_IncreasedBus..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Anrica", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Anrica","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Gelsord", "City_IncreasedBu..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Gelsord", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Gelsord","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("RibbonCut");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("RibbonCut");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Italic: "Cut the ribbon."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Lucian stood up."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Holsord", "52.5");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Holsord","52.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Holsord", "5.25");"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Holsord", "5.25");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Holsord","5.25");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Erlory", "3.1");"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Erlory", "3.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Erlory","3.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Erlory", "0.55");"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Erlory", "0.55");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Erlory","0.55");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Anrica", "7.1");"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Anrica", "7.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Anrica","7.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Anrica", "1.65");"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Anrica", "1.65");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Anrica","1.65");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Gelsord", "18.1");"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Gelsord", "18.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Gelsord","18.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Gelsord", "1.45");"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Gelsord", "1.45");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Gelsord","1.45");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Lachaven", "83.5");"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Lachaven", "83.5");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Lachaven","83.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Lachaven", "3.4");"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Lachaven", "3.4");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Lachaven","3.4");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Holsord", "52.5");"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Holsord", "Progress_Rail..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
