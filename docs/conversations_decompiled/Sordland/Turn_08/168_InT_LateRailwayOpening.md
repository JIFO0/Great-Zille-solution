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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **"Cut the ribbon."** | `[96]` **Narrator**: "Symon handed me an oversized pai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Symon Holl**: "“Congratulations to all. Hopeful..." |
| `[22]` | **"Get in the train."** | `[97]` **Lucian Galade**: "“The journey to Lachaven should ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." |
| `[25]` | **"“I'd like Gus with me.”"** | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Gus Manger**: "“I'm honored. It will be great t..." |
| `[26]` | **"“I will drive the train on my own.”"** | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lucian Galade**: "“Sure. We will be in the other c..." |
| `[29]` | **"“I want to have Symon in the cab.”"** | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Symon Holl**: "“This isn't necessary, but I won..." |
| `[31]` | **"“Lucian, I want you to ride with me.”"** | `[30]` **Lucian Galade**: "“Who do you want to travel with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucian Galade**: "“Thank you, Mr. President. It wi..." |
| `[34]` | **"“I agree. Get me on that train.""** | `[112]` **Lucian Galade**: "“I think so too. Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;` | `[45]` **Lucian Galade**: "“Very well.”" |
| `[35]` | **"“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"** | `[112]` **Lucian Galade**: "“I think so too. Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lucian Galade**: "“Of course. We'll hold the cerem..." |
| `[37]` | **"“Thanks to this railway, thousands of new jobs have been and will continue to be c..."** | `[66]` **Player**: "“We built this railway to create..."<br>`[78]` **Player**: "“Our intention with the L-1 Rail..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Player**: "“None of this would be possible ..."<br>`[46]` **Player**: "“Ensuring the success of this pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[42]` | **""Thanks to this railway, travel between Holsord and Lachaven is now twice as fast ..."** | `[66]` **Player**: "“We built this railway to create..."<br>`[78]` **Player**: "“Our intention with the L-1 Rail..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Player**: "“None of this would be possible ..."<br>`[46]` **Player**: "“Ensuring the success of this pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[46]` | **"“Ensuring the success of this project wasn't just one of my presidential goals -- ..."** | `[37]` **Player**: "“Thanks to this railway, thousan..."<br>`[42]` **Player**: ""Thanks to this railway, travel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "The crowd began cheering my name." |
| `[47]` | **"Walk to the podium."** | `[67]` **Lucian Galade**: "“Without further ado, I invite t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Player**: "“Citizens! Welcome to the openin..."<br>`[64]` **Player**: "“People of Sordland! Welcome to ..."<br>*(oraz 2 innych odgałęzień)* |
| `[51]` | **"“See you at the ceremony.”"** | `[23]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We all dispersed in order to pre..." |
| `[57]` | **"Signal for Lucian to begin the ceremony."** | `[62]` **Narrator**: "We took our places onstage." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Lucian Galade**: "“Brothers and sisters of Sordland!”" |
| `[60]` | **"“Goodbye for now.”"** | `[23]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We all dispersed in order to pre..." |
| `[63]` | **"“It will be a good opportunity for exposure.”"** | `[53]` **Lucian Galade**: "“Additionally, a large crowd has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Lucian Galade**: "“Agreed. Every single press outl..." |
| `[64]` | **"“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"** | `[47]` **Player_Italic**: "I walked up to the podium to add..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "The chanting and excitement from..." |
| `[66]` | **"“We built this railway to create economic growth throughout the Greater Holsord an..."** | `[77]` **Player**: "“At the beginning of this journe..."<br>`[79]` **Player**: "“Trust me, our work is far from ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Player**: ""Thanks to this railway, travel ..."<br>`[37]` **Player**: "“Thanks to this railway, thousan..." |
| `[68]` | **"“I want to acknowledge the brilliant mind behind this project, the esteemed Minist..."** | `[37]` **Player**: "“Thanks to this railway, thousan..."<br>`[42]` **Player**: ""Thanks to this railway, travel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "Symon walked up beside me." |
| `[69]` | **"“Nothing like a cheerful crowd. Looking forward to it.”"** | `[53]` **Lucian Galade**: "“Additionally, a large crowd has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Lucian Galade**: "“I think all of us are.”" |
| `[71]` | **"“Citizens! Welcome to the opening ceremony of the L-1 High-speed railway!”"** | `[47]` **Player_Italic**: "I walked up to the podium to add..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "The chanting and excitement from..." |
| `[72]` | **"“Holsordians! Welcome to the opening ceremony of the L-1 High-speed railway.”"** | `[47]` **Player_Italic**: "I walked up to the podium to add..." | `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false` | *Brak zmian stanu* | `[70]` **Narrator**: "The chanting and excitement from..." |
| `[73]` | **"“None of this would be possible without the sound advice of my cabinet member Gus ..."** | `[37]` **Player**: "“Thanks to this railway, thousan..."<br>`[42]` **Player**: ""Thanks to this railway, travel ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "Gus sauntered over to the podium..." |
| `[74]` | **"“Like the good old campaign days.”"** | `[53]` **Lucian Galade**: "“Additionally, a large crowd has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lucian Galade**: "“Things were certainly easier ba..." |
| `[77]` | **"“At the beginning of this journey, we promised jobs and opportunity. We kept our p..."** | `[70]` **Narrator**: "The chanting and excitement from..."<br>`[76]` **Narrator**: "The chanting from the crowd cont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player**: "“We built this railway to create..."<br>`[78]` **Player**: "“Our intention with the L-1 Rail..." |
| `[78]` | **"“Our intention with the L-1 Railway was to allow citizens to easily commute betwee..."** | `[77]` **Player**: "“At the beginning of this journe..."<br>`[79]` **Player**: "“Trust me, our work is far from ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Player**: ""Thanks to this railway, travel ..."<br>`[37]` **Player**: "“Thanks to this railway, thousan..." |
| `[79]` | **"“Trust me, our work is far from over. This project is only the beginning.”"** | `[70]` **Narrator**: "The chanting and excitement from..."<br>`[76]` **Narrator**: "The chanting from the crowd cont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player**: "“We built this railway to create..."<br>`[78]` **Player**: "“Our intention with the L-1 Rail..." |
| `[84]` | **"“Symon, you deserve the credit. After all, it was you who came up with the project.”"** | `[86]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Gus Manger**: "“We had our disagreements, but t..." |
| `[85]` | **"“Thank you for your kind words. It truly means a good deal.”"** | `[86]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Gus Manger**: "“We had our disagreements, but t..." |
| `[106]` | **"“Good work.”"** | `[104]` **Gus Manger**: "“Well done, everyone.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lucian Galade**: "“Indeed.”" |
| `[107]` | **"“We couldn't have done this without our excellent team.”"** | `[104]` **Gus Manger**: "“Well done, everyone.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lucian Galade**: "“Indeed.”" |
| `[108]` | **"Nod."** | `[104]` **Gus Manger**: "“Well done, everyone.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Lucian Galade**: "“Let's move on to our plans for ..." |
| `[113]` | **"“I guess we can't avoid that.”"** | `[53]` **Lucian Galade**: "“Additionally, a large crowd has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Symon Holl**: "“On another note. It goes withou..." |
| `[114]` | **"“Thank you.”"** | `[86]` **Symon Holl**: "“Beginning with the President wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Gus Manger**: "“We had our disagreements, but t..." |
| `[115]` | **"“Once again, good work everyone.”"** | `[23]` **Symon Holl**: "“Alright then. We have a lot of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "We all dispersed in order to pre..." |
| `[123]` | **"“My fellow Holsordians! I welcome you today to our opening ceremony of the L-1 Hig..."** | `[47]` **Player_Italic**: "I walked up to the podium to add..." | `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]` | *Brak zmian stanu* | `[76]` **Narrator**: "The chanting from the crowd cont..." |

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
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The locomotive assistant flipped a few switches, and the train began pulling out of the central station. Lucian waved at the press photographers as I "drove"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The new train was in pristine condition. Its electric eng..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_InT_LateOpening = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_InT_LateOpening"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "It was a great victory for my administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_LateRailwayOpening = true;..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The railway officially opened to the public right after we left, and thousands began using it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "//"*)

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
  - -> `[14]` (*Lucian Galade: "“The train is prepared, sir.”"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The railway officially opened to the public right after w..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "We walked towards the line where the first electric train was waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "A red ribbon was hanging by the door of the train."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Cut the ribbon."]** — Mówca: **Player_Italic**
> "I cut the ribbon, triggering cheers from the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Symon Holl: "“Congratulations to all. Hopefully this success will lead..."*)

### Węzeł `[12]`
Mówca: **Symon Holl**
> "“Congratulations to all. Hopefully this success will lead to many more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Gus Manger: "“It's a good moment indeed. We have helped so many in the..."*)

### Węzeł `[13]`
Mówca: **Gus Manger**
> "“It's a good moment indeed. We have helped so many in the countryside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“The train is prepared, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucian Galade: "“The journey to Lachaven should take about four hours. Th..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "A red ribbon was hanging by the door of the train."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Symon handed me an oversized pair of scissors."*)

### Węzeł `[16]`
Mówca: **Gus Manger**
> "“Sounds fantastic. The President arriving to Lachaven in the driver's seat would make the headlines for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: "“Additionally, a large crowd has been invited to the cere..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "It was finally happening. Tomorrow would be the grand opening ceremony of the L-1 High-speed rail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Though the construction delay had taken its toll on our m..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Symon and Gus, who had heavily assisted in the project, had come to discuss the ceremony plans with Lucian and myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Lucian stood up."*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“I don't support anything beyond the opening ceremony. The railway's completion speaks for itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Gus Manger: "“I see your point. But involving the President further co..."*)

### Węzeł `[20]`
Mówca: **Gus Manger**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Gus Manger: "“Holsord! It is great to be here in this beautiful capita..."*)

### Węzeł `[21]`
Mówca: **Gus Manger**
> "“I see your point. But involving the President further could be beneficial for the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: "“I think so too. Mr. President?”"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Get in the train."]** — Mówca: **Player_Italic**
> "I entered the cab and took a seat with the assistant beside me. The crowd was trying to catch a glimpse of me through the window."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: "“Who do you want to travel with in the cab, Mr. President?”"*)

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“Alright then. We have a lot of work to do. See you tomorrow morning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“See you at the ceremony.”"*)
  - -> `[60]` (*Player: "“Goodbye for now.”"*)
  - -> `[115]` (*Player: "“Once again, good work everyone.”"*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“It's been a long time since the last successful infrastructure project. From a public relations point of view, we can certainly capitalize on the occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: "“I have a plan on how to do that.”"*)

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
  - -> `[41]` (*Narrator: "The locomotive assistant flipped a few switches, and the ..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I want to have Symon in the cab.”"]** — Mówca: **Player**
> "“I want to have Symon in the cab.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Symon Holl: "“This isn't necessary, but I won't refuse. We can talk ab..."*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“Who do you want to travel with in the cab, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Lucian, I want you to ride with me.”"*)
  - -> `[29]` (*Player: "“I want to have Symon in the cab.”"*)
  - -> `[25]` (*Player: "“I'd like Gus with me.”"*)
  - -> `[26]` (*Player: "“I will drive the train on my own.”"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Lucian, I want you to ride with me.”"]** — Mówca: **Player**
> "“Lucian, I want you to ride with me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: "“Thank you, Mr. President. It will be a good journey. We ..."*)

### Węzeł `[32]`
Mówca: **Symon Holl**
> "“This isn't necessary, but I won't refuse. We can talk about future economic projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "The locomotive assistant flipped a few switches, and the ..."*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good journey. We can talk about the election campaign preparations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The locomotive assistant flipped a few switches, and the ..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I agree. Get me on that train.""]** — Mówca: **Player**
> "“I agree. Get me on that train.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show = true"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"]** — Mówca: **Player**
> "“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: "“Of course. We'll hold the ceremony and open the upgraded..."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Sure. We will be in the other carriages. See you in Lachaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "The locomotive assistant flipped a few switches, and the ..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Thanks to this railway, thousands of new jobs have been and will continue to be created.""]** — Mówca: **Player**
> "“Thanks to this railway, thousands of new jobs have been and will continue to be created.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Player), `[78]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“None of this would be possible without the sound advice ..."*)
  - -> `[46]` (*Player: "“Ensuring the success of this project wasn't just one of ..."*)
  - -> `[68]` (*Player: "“I want to acknowledge the brilliant mind behind this pro..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Gus sauntered over to the podium and leaned into the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Gus Manger: "“Thank you, Mr. President.”"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "The locomotive assistant flipped a few switches, and the train began pulling out of the central station. Symon smiled awkwardly at the press photographers as I "drove"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The new train was in pristine condition. Its electric eng..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“Very well.”"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "The locomotive assistant flipped a few switches, and the train began pulling out of the central station. Gus gave a thumbs-up to the press photographers as I "drove"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The new train was in pristine condition. Its electric eng..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Thanks to this railway, travel between Holsord and Lachaven is now twice as fast and endlessly more comfortable.""]** — Mówca: **Player**
> ""Thanks to this railway, travel between Holsord and Lachaven is now twice as fast and endlessly more comfortable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Player), `[78]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“None of this would be possible without the sound advice ..."*)
  - -> `[46]` (*Player: "“Ensuring the success of this project wasn't just one of ..."*)
  - -> `[68]` (*Player: "“I want to acknowledge the brilliant mind behind this pro..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "The locomotive assistant flipped a few switches, and the train began pulling out of the central station. I waved at the press photographers as I "drove"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The new train was in pristine condition. Its electric eng..."*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“Of course. We'll hold the ceremony and open the upgraded railway to the public immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“The people will be satisfied with their improved transpo..."*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Gus Manger: "“Sounds fantastic. The President arriving to Lachaven in ..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Ensuring the success of this project wasn't just one of my presidential goals -- it was my personal priority.""]** — Mówca: **Player**
> "“Ensuring the success of this project wasn't just one of my presidential goals -- it was my personal priority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "The crowd began cheering my name."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "Walk to the podium."]** — Mówca: **Player_Italic**
> "I walked up to the podium to address the crowd. The press was taking dozens of pictures."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle"*)
  - -> `[71]` (*Player: "“Citizens! Welcome to the opening ceremony of the L-1 Hig..."*)
  - -> `[64]` (*Player: "“People of Sordland! Welcome to the opening ceremony of t..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Lucian's voice echoed in the central station. Thousands of Sordland and USP flags began to wave as the loud cheers intensified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“Without further ado, I invite the President of Sordland ..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "The new train was in pristine condition. Its electric engine provided the smoothest ride I'd ever had."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "After an uneventful four hours on board, we were welcomed..."*)

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“This railway project is a perfect example of how we can bring prosperity to the under-developed areas between our major cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Gus continued to explain the many benefits the upgraded r..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“See you at the ceremony.”"]** — Mówca: **Player**
> "“See you at the ceremony.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We all dispersed in order to prepare for the big day."*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“The people will be satisfied with their improved transportation service anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: "“Additionally, a large crowd has been invited to the cere..."*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> "“Additionally, a large crowd has been invited to the ceremony and will be watching the opening speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "“Nothing like a cheerful crowd. Looking forward to it.”"*)
  - -> `[63]` (*Player: "“It will be a good opportunity for exposure.”"*)
  - -> `[74]` (*Player: "“Like the good old campaign days.”"*)
  - -> `[113]` (*Player: "“I guess we can't avoid that.”"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "After an uneventful four hours on board, we were welcomed by a throng of citizens at Lachaven station."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The railway officially opened to the public right after w..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Lucian took my place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“Citizens of Holsord! There you have it!”"*)

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“Once we cut that ribbon and the citizens of Holsord get on the train, I believe you'll agree we have succeeded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Symon went on to explain how this railway was a crucial s..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Signal for Lucian to begin the ceremony."]** — Mówca: **Player_Italic**
> "I gave the green light to Lucian, and the opening address began."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: "“Brothers and sisters of Sordland!”"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "The next morning, a stage had been erected inside the central station."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "It was a sunny day in our usually cloudy capital city."*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> "“Brothers and sisters of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: "“I welcome you Holsordians today as a proud servant of th..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Goodbye for now.”"]** — Mówca: **Player**
> "“Goodbye for now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We all dispersed in order to prepare for the big day."*)

### Węzeł `[61]`
Mówca: **Symon Holl**
> "“Thanks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Symon Holl: "“Our aim with this project wasobvious: to improve the spe..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "We took our places onstage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Italic: "Signal for Lucian to begin the ceremony."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It will be a good opportunity for exposure.”"]** — Mówca: **Player**
> "“It will be a good opportunity for exposure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: "“Agreed. Every single press outlet has of course been not..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“People of Sordland! Welcome to the opening ceremony of the L-1 High-speed railway.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "The chanting and excitement from the crowd intensified. A..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "We all dispersed in order to prepare for the big day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "The next morning, a stage had been erected inside the cen..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“We built this railway to create economic growth throughout the Greater Holsord and Gelsland regions.""]** — Mówca: **Player**
> "“We built this railway to create economic growth throughout the Greater Holsord and Gelsland regions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Player), `[79]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Thanks to this railway, travel between Holsord and Lacha..."*)
  - -> `[37]` (*Player: "“Thanks to this railway, thousands of new jobs have been ..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Without further ado, I invite the President of Sordland to the stage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Italic: "Walk to the podium."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I want to acknowledge the brilliant mind behind this project, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"]** — Mówca: **Player**
> "“I want to acknowledge the brilliant mind behind this project, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"
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
  - -> `[83]` (*Lucian Galade: "“I think all of us are.”"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "The chanting and excitement from the crowd intensified. A large group began singing the national anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“At the beginning of this journey, we promised jobs and o..."*)
  - -> `[79]` (*Player: "“Trust me, our work is far from over. This project is onl..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Citizens! Welcome to the opening ceremony of the L-1 High-speed railway!”"]** — Mówca: **Player**
> "“Citizens! Welcome to the opening ceremony of the L-1 High-speed railway!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "The chanting and excitement from the crowd intensified. A..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“Holsordians! Welcome to the opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“Holsordians! Welcome to the opening ceremony of the L-1 High-speed railway.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "The chanting and excitement from the crowd intensified. A..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“None of this would be possible without the sound advice of my cabinet member Gus Manger. Please come over here.”"]** — Mówca: **Player**
> "“None of this would be possible without the sound advice of my cabinet member Gus Manger. Please come over here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Player), `[42]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Gus sauntered over to the podium and leaned into the micr..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Like the good old campaign days.”"]** — Mówca: **Player**
> "“Like the good old campaign days.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“Things were certainly easier back then.”"*)

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“We will show our best face tomorrow. Meanwhile, I'll make sure that our message about improving the countryside gets across.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Symon Holl: "“Alright then. We have a lot of work to do. See you tomor..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "The chanting from the crowd continued. Some were yelling the motto of Holsord: High above all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“At the beginning of this journey, we promised jobs and o..."*)
  - -> `[79]` (*Player: "“Trust me, our work is far from over. This project is onl..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“At the beginning of this journey, we promised jobs and opportunity. We kept our promise.”"]** — Mówca: **Player**
> "“At the beginning of this journey, we promised jobs and opportunity. We kept our promise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator), `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“We built this railway to create economic growth througho..."*)
  - -> `[78]` (*Player: "“Our intention with the L-1 Railway was to allow citizens..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Our intention with the L-1 Railway was to allow citizens to easily commute between the major cities of Holsord and Lachaven.”"]** — Mówca: **Player**
> "“Our intention with the L-1 Railway was to allow citizens to easily commute between the major cities of Holsord and Lachaven.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Player), `[79]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Thanks to this railway, travel between Holsord and Lacha..."*)
  - -> `[37]` (*Player: "“Thanks to this railway, thousands of new jobs have been ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Trust me, our work is far from over. This project is only the beginning.”"]** — Mówca: **Player**
> "“Trust me, our work is far from over. This project is only the beginning.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator), `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“We built this railway to create economic growth througho..."*)
  - -> `[78]` (*Player: "“Our intention with the L-1 Railway was to allow citizens..."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“Things were certainly easier back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[81]`
Mówca: **Gus Manger**
> "“We had our disagreements, but the important thing was the outcome. The Sordish people have been waiting a long time for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Gus Manger: "“We will show our best face tomorrow. Meanwhile, I'll mak..."*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“Agreed. Every single press outlet has of course been notified and they will be there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[83]`
Mówca: **Lucian Galade**
> "“I think all of us are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Symon, you deserve the credit. After all, it was you who came up with the project.”"]** — Mówca: **Player**
> "“Symon, you deserve the credit. After all, it was you who came up with the project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gus Manger: "“We had our disagreements, but the important thing was th..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“Thank you for your kind words. It truly means a good deal.”"]** — Mówca: **Player**
> "“Thank you for your kind words. It truly means a good deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gus Manger: "“We had our disagreements, but the important thing was th..."*)

### Węzeł `[86]`
Mówca: **Symon Holl**
> "“Beginning with the President who put his trust in me, I want to thank all who were involved in L-1.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“Symon, you deserve the credit. After all, it was you who..."*)
  - -> `[85]` (*Player: "“Thank you for your kind words. It truly means a good deal.”"*)
  - -> `[114]` (*Player: "“Thank you.”"*)

### Węzeł `[87]`
Mówca: **Symon Holl**
> "“On another note. It goes without mentioning that this was a team effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Symon Holl: "“Beginning with the President who put his trust in me, I ..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Symon went on to explain how this railway was a crucial stepping stone on the way to a full Sordish economic recovery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Lucian took Symon's place after he was done with his speech."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Gus continued to explain the many benefits the upgraded railway would bring to the areas along its path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Lucian took Gus' place after he was done with his speech."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "The crowd began cheering my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Lucian took my place on the stage to close the ceremony."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "It was a sunny day in our usually cloudy capital city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "The crowd looked quite large. I spotted many party members."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "The crowd looked quite large. I spotted many party members."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "We took our places onstage."*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> "“I welcome you Holsordians today as a proud servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Lucian's voice echoed in the central station. Thousands o..."*)

### Węzeł `[94]`
Mówca: **Symon Holl**
> "“Our aim with this project wasobvious: to improve the speed and efficiency of transportation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Symon Holl: "“Once we cut that ribbon and the citizens of Holsord get ..."*)

### Węzeł `[95]`
Mówca: **Gus Manger**
> "“Holsord! It is great to be here in this beautiful capital that does so much good for this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gus Manger: "“This railway project is a perfect example of how we can ..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Symon handed me an oversized pair of scissors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("RibbonCut");"*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> "“The journey to Lachaven should take about four hours. The rest of us will be on the train as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Italic: "Get in the train."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_AverageTransportation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == tru..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "It was a great victory for my administration."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_WeakTransportation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_AverageTransportation = true"*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“I have a plan on how to do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“If the President accepts, driving the first high-speed t..."*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“If the President accepts, driving the first high-speed train to Lachaven would be great for our image nationwide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucian Galade: "“What are your thoughts?”"*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Lucian stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucian Galade: "“First of all...”"*)

### Węzeł `[104]`
Mówca: **Gus Manger**
> "“Well done, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: "“Good work.”"*)
  - -> `[107]` (*Player: "“We couldn't have done this without our excellent team.”"*)
  - -> `[108]` (*Player_Italic: "Nod."*)

### Węzeł `[105]`
Mówca: **Symon Holl**
> "“To many more projects like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Gus Manger: "“Well done, everyone.”"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: "“Indeed.”"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“We couldn't have done this without our excellent team.”"]** — Mówca: **Player**
> "“We couldn't have done this without our excellent team.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: "“Indeed.”"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I silently nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: "“Let's move on to our plans for the opening tomorrow.”"*)

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: "“Let's move on to our plans for the opening tomorrow.”"*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“Let's move on to our plans for the opening tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: "“It's been a long time since the last successful infrastr..."*)

### Węzeł `[111]`
Mówca: **Lucian Galade**
> "“What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“I don't support anything beyond the opening ceremony. Th..."*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> "“I think so too. Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“I agree. Get me on that train.""*)
  - -> `[35]` (*Player: "“I'd prefer we just do the opening ceremony. No need for ..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“I guess we can't avoid that.”"]** — Mówca: **Player**
> "“I guess we can't avoid that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Symon Holl: "“On another note. It goes without mentioning that this wa..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gus Manger: "“We had our disagreements, but the important thing was th..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Once again, good work everyone.”"]** — Mówca: **Player**
> "“Once again, good work everyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We all dispersed in order to prepare for the big day."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Lucian took Gus' place after he was done with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“Citizens of Holsord! There you have it!”"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Lucian took Symon's place after he was done with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“Citizens of Holsord! There you have it!”"*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“Citizens of Holsord! There you have it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: "“As promised, Anton Rayne, the 4th President of Sordland,..."*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“As promised, Anton Rayne, the 4th President of Sordland, has delivered!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "We walked towards the line where the first electric train..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "“My fellow Holsordians! I welcome you today to our openin..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“Holsordians! Welcome to the opening ceremony of the L-1 ..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“My fellow Holsordians! I welcome you today to our opening ceremony of the L-1 High-speed railway.”"]** — Mówca: **Player**
> "“My fellow Holsordians! I welcome you today to the opening ceremony of our L-1 High-speed railway.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`
- **Kontekst wejściowy (poprzednik):** `[47]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "The chanting from the crowd continued. Some were yelling ..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Though the construction delay had taken its toll on our morale, this was still a proud moment for all of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_CeremonialScissors");"*)

### Węzeł `[125]`
Mówca: **Lucian Galade**
> "“First of all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucian Galade: "“This day might have arrived later than expected, but it ..."*)

### Węzeł `[126]`
Mówca: **Lucian Galade**
> "“This day might have arrived later than expected, but it doesn't change the fact that we are here now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucian Galade: "“This is still a big success. Congratulations, everyone.”"*)

### Węzeł `[127]`
Mówca: **Lucian Galade**
> "“This is still a big success. Congratulations, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Symon Holl: "“To many more projects like this.”"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_LateRailwayOpening = true;
BaseGame.Policy_Economy_RailwayProject = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LateRailwayOpening"] = true;
Variable["BaseGame.Policy_Economy_RailwayProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_InT_LateOpening = true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved = true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_E_L1_Taurus_Show = true; Base..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_L1_Taurus_NoShow = true; B..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_InT_Show == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_InT_Show == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_InT_Show == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_E_L1_SSC_Show = true; BaseGam..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_InT_Show == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_L1_SSC_NoShow = true; Base..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_E_L1_Taurus_Show = true;
BaseGameSupport.News_Turn08_HP_L1_Taurus_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_E_L1_Taurus_Show"] = true;
Variable["BaseGameSupport.News_Turn08_HP_L1_Taurus_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_L1_Taurus_NoShow = true;
BaseGameSupport.News_Turn08_E_L1_Taurus_NoShow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_L1_Taurus_NoShow"] = true;
Variable["BaseGameSupport.News_Turn08_E_L1_Taurus_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_L1_SSC_NoShow = true;
BaseGameSupport.News_Turn08_E_L1_SSC_NoShow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_L1_SSC_NoShow"] = true;
Variable["BaseGameSupport.News_Turn08_E_L1_SSC_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_E_L1_SSC_Show = true;
BaseGameSupport.News_Turn08_HP_L1_SSC_Show = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_E_L1_SSC_Show"] = true;
Variable["BaseGameSupport.News_Turn08_HP_L1_SSC_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_WeakTransportation = false"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "It was finally happening. Tomorrow would be the grand ope..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Holsord", "Progress_Railway");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","Progress_Railway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Holsord", "City_IncreasedBu..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Holsord", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Holsord","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Holsord", "City_Logistic..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Holsord", "City_LogisticalIssues");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_LogisticalIssues");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Anrica", "City_Antiquate..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Anrica", "City_AntiquatedRailway");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_AntiquatedRailway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Gelsord", "City_Antiquat..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Gelsord", "City_AntiquatedRailway");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Gelsord","City_AntiquatedRailway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Lachaven", "City_IncreasedB..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Lachaven", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Lachaven","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Anrica", "City_IncreasedBus..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Anrica", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Anrica","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Gelsord", "City_IncreasedBu..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Gelsord", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Gelsord","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == tru..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "It was a great victory for my administration."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Symon and Gus, who had heavily assisted in the project, h..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Holsord", "52.5");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Holsord","52.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Holsord", "5.25");"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Holsord", "5.25");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Holsord","5.25");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Erlory", "3.1");"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Erlory", "3.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Erlory","3.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Erlory", "0.55");"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Erlory", "0.55");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Erlory","0.55");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Anrica", "7.1");"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Anrica", "7.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Anrica","7.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Anrica", "1.65");"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Anrica", "1.65");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Anrica","1.65");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Gelsord", "18.1");"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Gelsord", "18.1");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Gelsord","18.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Gelsord", "1.45");"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Gelsord", "1.45");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Gelsord","1.45");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Lachaven", "83.5");"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityGdp("Sordland_City_Lachaven", "83.5");`
- **Efekt skryptowy (`userScript`):** `UpdateCityGdp("Sordland_City_Lachaven","83.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "UpdateCityPopulation("Sordland_City_Lachaven", "3.4");"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCityPopulation("Sordland_City_Lachaven", "3.4");`
- **Efekt skryptowy (`userScript`):** `UpdateCityPopulation("Sordland_City_Lachaven","3.4");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "UpdateCityGdp("Sordland_City_Holsord", "52.5");"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Holsord", "Progress_Rail..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("RibbonCut");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("RibbonCut");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Italic: "Cut the ribbon."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
