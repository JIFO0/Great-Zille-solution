# Sordland/Turn08/InT_LateHighwayOpening

- **ID konwersacji:** `169`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/169_InT_LateHighwayOpening.md`
- **Liczba węzłów dialogowych:** 182
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
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGameIsolated.Turn06_InT_Show`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.Policy_Economy_HighwayProject`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGameIsolated.Turn06_InT_Show`
- `BaseGameSupport.Journal_Turn08_LateHighwayOpening`
- `BaseGameSupport.News_Turn08_E_H3_SSC_NoShow`
- `BaseGameSupport.News_Turn08_E_H3_SSC_Show`
- `BaseGameSupport.News_Turn08_E_H3_Taurus_NoShow`
- `BaseGameSupport.News_Turn08_E_H3_Taurus_Show`
- `BaseGameSupport.News_Turn08_HP_H3_SSC_NoShow`
- `BaseGameSupport.News_Turn08_HP_H3_SSC_Show`
- `BaseGameSupport.News_Turn08_HP_H3_Taurus_NoShow`
- `BaseGameSupport.News_Turn08_HP_H3_Taurus_Show`
- `GameCondition.Turn08_InT_LateOpening`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 32

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.Policy_Economy_HighwayProject`
- `BaseGame.Situation_Economy_AverageTransportation`
- `BaseGame.Situation_Economy_WeakTransportation`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[7]` (Symon Holl): `Variable["GameCondition.Turn08_InT_LateOpening"] = true;`
- Węzeł `[22]` (Symon Holl): `Variable["BaseGameIsolated.Turn06_InT_Show"] = true;`
- Węzeł `[91]` (Symon Holl): `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- Węzeł `[92]` (Symon Holl): `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- Węzeł `[93]` (Symon Holl): `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- Węzeł `[127]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn08_LateHighwayOpening"] = true; Variable["BaseGame.Policy_E...`
- Węzeł `[128]` (Symon Holl): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- Węzeł `[138]` (Symon Holl): `Variable["BaseGameSupport.News_Turn08_E_H3_SSC_Show"] = true; Variable["BaseGameSupport.News_Turn...`
- *...oraz 24 innych węzłów ze skryptami.*

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
  - -> `[128]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian and I, together with project leads Symon and Lileas, met to discuss how to proceed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[4]`
Mówca: **Lileas Graf**
> "“Image is everything, Symon. I agree this would bolster the President's reputation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The day before the grand opening ceremony of the H-3 Highway, we arrived in Lachaven to begin preparations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[6]`
Mówca: **Symon Holl**
> "“I don't support anything beyond the opening ceremony. The highway speaks for itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_InT_LateOpening = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_InT_LateOpening"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[8]`
Mówca: **Narrator**
> "It was a great victory for my administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"]** — Mówca: **Player**
> "“I'd prefer we just do the opening ceremony. No need for senseless spectacle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I agree. I'll hit the road.""]** — Mówca: **Player**
> "“I agree. I'll hit the road.""
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
> "“Of course. We'll hold the ceremony and open the highway to the public immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Additionally, a large crowd has been invited to the ceremony and will be watching the opening speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[16]`
  - -> `[17]`
  - -> `[109]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“It will be a good opportunity for exposure.”"]** — Mówca: **Player**
> "“It will be a good opportunity for exposure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Like the good old campaign days.”"]** — Mówca: **Player**
> "“Like the good old campaign days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Nothing like a cheerful crowd. Looking forward to it.”"]** — Mówca: **Player**
> "“Nothing like a cheerful crowd. Looking forward to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Alright then. We have a lot of work to do. See you in the morning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[114]`

### Węzeł `[20]`
Mówca: **Narrator**
> "We dispersed to begin our individual preparations for the big day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "Signal for Lucian to begin the ceremony."]** — Mówca: **Player_Italic**
> "I gave Lucian the green light and the opening address began."
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
> "The next morning, a stage had been erected next to the entrance of the highway in downtown Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“Brothers and sisters of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[25]`
Mówca: **Lileas Graf**
> "“Thank you, Mr. President. Lachaven! It is great to be here today among you industrious people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[26]`
Mówca: **Symon Holl**
> "“Thanks, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[27]`
Mówca: **Narrator**
> "We took our places onstage."
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
**[WYBÓR GRACZA: "Walk up to the podium."]** — Mówca: **Player_Italic**
> "I walked to the podium to address the crowd. Cameras flashed around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[31]`
  - -> `[28]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The chanting from the crowd intensified. Some were yelling the motto of Lachaven: Liberty until eternity."
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
**[WYBÓR GRACZA: "“At the beginning of this journey, we promised jobs and opportunity. We kept our promise.”"]** — Mówca: **Player**
> "“At the beginning of this journey, we promised jobs and opportunity. We kept our promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Trust me, our work is far from over. This project is only the beginning.”"]** — Mówca: **Player**
> "“Trust me, our work is far from over. This project is only the beginning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“The aim with the H-3 was to create economic growth in East Nargis and Agnland.”"]** — Mówca: **Player**
> "“The aim with the H-3 was to create economic growth in East Nargis and Agnland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Our intention with the H-3 was to ensure citizens an easier commute between Lachaven and Arvory.”"]** — Mówca: **Player**
> "“Our intention with the H-3 was to ensure citizens an easier commute between Lachaven and Arvory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`

### Węzeł `[40]`
Mówca: **Narrator**
> "As soon as we left, the highway opened to the public and thousands began using it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

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
**[WYBÓR GRACZA: "“None of this would be possible without the sound advice of my Interior Minister Lileas Graf. Please come over here.”"]** — Mówca: **Player**
> "“None of this would be possible without the sound advice of my Interior Minister Lileas Graf. Please come over here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I must thank the brilliant mind behind the highway project, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"]** — Mówca: **Player**
> "“I must thank the brilliant mind behind the highway project, the esteemed Minister of Economy and Tax, Symon Holl. Please come over here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[46]`
Mówca: **Symon Holl**
> "“After we cut that ribbon and you drive on the highway, you can judge our success for yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“United we stand and divided we fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Ensuring the success of this project wasn't just one of my presidential goals. I made it my personal priority.""]** — Mówca: **Player**
> "“Ensuring the success of this project wasn't just one of my presidential goals. I made it my personal priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Lileas walked up to me and leaned into the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Symon walked up to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "Cut the ribbon."]** — Mówca: **Player_Italic**
> "I cut the ribbon, triggering cheers from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“Congratulations to all. Hopefully this is one of many successes to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Lileas Graf**
> "“It's a good moment indeed. It gives us pride as a nation. One big step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> "“Your car is ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[55]`
Mówca: **Narrator**
> "A 40-meter-long red ribbon stretched across it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“This highway has brought and will continue to bring thousands of new jobs.""]** — Mówca: **Player**
> "“This highway has brought and will continue to bring thousands of new jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[48]`
  - -> `[45]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“Thanks to this highway, travel between Lachaven and Arvory is twice as fast and infinitely more comfortable.""]** — Mówca: **Player**
> "“Thanks to this highway, travel between Lachaven and Arvory is twice as fast and infinitely more comfortable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[48]`
  - -> `[45]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "Enter the car."]** — Mówca: **Player_Italic**
> "I entered the car and sat in the driver's seat. The crowd was trying to catch a glimpse of me through the window."
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
  - -> `[66]`

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“I'm honored. It will be lovely to arrive in Arvory with the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

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
**[WYBÓR GRACZA: "“Lucian, come ride with me.”"]** — Mówca: **Player**
> "“Lucian, come ride with me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[65]`
Mówca: **Symon Holl**
> "“This isn't necessary, but I won't refuse. We can talk about future economic projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“As you wish. I'll see you in Arvory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[67]`
Mówca: **Narrator**
> "I revved the engine. Lucian waved at the press photographers as I drove us onto the new highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
Mówca: **Narrator**
> "I revved the engine. Symon smiled awkwardly at the press photographers as I drove us onto the new highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Narrator**
> "I revved the engine. Lileas waved to the press photographers as I drove us onto the new highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Narrator**
> "I revved the engine and waved to the press photographers as I drove onto the new highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "The new highway was in pristine condition. The ride to Arvory was the smoothest I'd ever had."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "After an uneventful four hours, we were welcomed by a throng of Arvory citizens and Mayor Eric Niel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[73]`
Mówca: **Symon Holl**
> "“On another note. It goes without mentioning that this was a team effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“I think all of us are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> "“Agreed. Every single press outlet has of course been notified and they will be there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“Things were certainly easier back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[77]`
Mówca: **Symon Holl**
> "“Beginning with the President who put his trust in me, I want to thank everyone involved in the H-3.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`
  - -> `[110]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Symon, you deserve the credit. After all, it was you who came up with the project.”"]** — Mówca: **Player**
> "“Symon, you deserve the credit. After all, it was you who came up with the project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Thank you for your kind words. It truly means a good deal.”"]** — Mówca: **Player**
> "“Thank you for your kind words. It truly means a good deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Lileas Graf**
> "“The people have been waiting a long time for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Lileas continued to speak about the strength that comes from unity and the positive change the highway would bring to Agnland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Symon continued to speak about how this project was a stepping stone towards a Sordish economic recovery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[83]`
Mówca: **Narrator**
> "The crowd began cheering my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[84]`
Mówca: **Narrator**
> "The weather was warm and unusually calm for the windy port city. Spirits were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Despite Lachaven's strong PFJP presence, a huge crowd of supporters had turned out. Lucian must have brought in some ringers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“I welcome you Lachaveners today as a proud servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“This project is a perfect example of the capacity and capabilities of Sordland as a nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[88]`
Mówca: **Symon Holl**
> "“Our aim with this project was obvious: to improve the speed and efficiency of transportation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Symon handed me a pair of oversized scissors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“The drive to Arvory should take about four hours. We'll be right behind you in the motorcade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[91]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_AverageTransportation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_AverageTransportation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[92]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[93]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_WeakTransportation = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_WeakTransportation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Lucian stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
> "“First of all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> "“This day may have arrived later than expected, but it doesn't change the fact that we are here now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“We couldn't have done this without our excellent team.”"]** — Mówca: **Player**
> "“We couldn't have done this without our excellent team.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I silently nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Symon Holl**
> "“To many more projects like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“I have a plan for how to do that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“It's been a long time since the last successful infrastructure project. From a public relations viewpoint, we can certainly capitalize on the occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
> "“Let's move on to our plans for the opening tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[105]`
Mówca: **Lileas Graf**
> "“Well done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[97]`
  - -> `[98]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“The president himself shall make the maiden voyage from Lachaven to Arvory along with his motorcade. If he agrees, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
> "“What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
> "“I think so too. Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“I guess we can't avoid that.”"]** — Mówca: **Player**
> "“I guess we can't avoid that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[111]`
Mówca: **Lileas Graf**
> "“We will need to show our best face tomorrow. I'll make sure that our focus on improving business and logistics is relayed by whatever means necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“See you at the ceremony.”"]** — Mówca: **Player**
> "“See you at the ceremony.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Goodbye for now.”"]** — Mówca: **Player**
> "“Goodbye for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Once again, good work everyone.”"]** — Mówca: **Player**
> "“Once again, good work everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[115]`
Mówca: **Narrator**
> "After he was done with his speech, Lucian took Symon's place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Lucian took my place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Narrator**
> "After she was done with her speech, Lucian took Lileas's place on the stage to close the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“Citizens of Lachaven! There you have it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“As promised, Anton Rayne -- the 4th President of Sordland -- has delivered!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Narrator**
> "We walked towards the entrance of the highway next to the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[121]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"]** — Mówca: **Player**
> "“Fellow Free Lachaveners! Welcome to the opening ceremony of the H-3 Highway!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[125]`
Mówca: **Narrator**
> "Although the delay had taken its toll on our morale, it was still a proud moment for all of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
> "“This is still a big success. Congratulations, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[127]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_LateHighwayOpening = true;
BaseGame.Policy_Economy_HighwayProject = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LateHighwayOpening"] = true;
Variable["BaseGame.Policy_Economy_HighwayProject"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[128]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[129]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[131]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[132]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_TaurusHolding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_InT_Show == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_InT_Show"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[137]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[138]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_E_H3_SSC_Show = true;
BaseGameSupport.News_Turn08_HP_H3_SSC_Show = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_E_H3_SSC_Show"] = true;
Variable["BaseGameSupport.News_Turn08_HP_H3_SSC_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

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
  - -> `[138]`

### Węzeł `[141]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_InT_Show == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_InT_Show"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[142]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_H3_Taurus_NoShow = true;
BaseGameSupport.News_Turn08_E_H3_Taurus_NoShow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_H3_Taurus_NoShow"] = true;
Variable["BaseGameSupport.News_Turn08_E_H3_Taurus_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[143]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_E_H3_Taurus_Show = true;
BaseGameSupport.News_Turn08_HP_H3_Taurus_Show = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_E_H3_Taurus_Show"] = true;
Variable["BaseGameSupport.News_Turn08_HP_H3_Taurus_Show"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[144]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_H3_SSC_NoShow = true;
BaseGameSupport.News_Turn08_E_H3_SSC_NoShow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_H3_SSC_NoShow"] = true;
Variable["BaseGameSupport.News_Turn08_E_H3_SSC_NoShow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
> "“Thank you, Mr. President. It will be a good opportunity to talk about the election campaign preparations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[146]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[147]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Lachaven", "Progress_Highway");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Lachaven","Progress_Highway");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Lenkurg", "City_LackofRoadNetwork");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Lenkurg","City_LackofRoadNetwork");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Arvory", "City_LogisticalIssues");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_LogisticalIssues");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[150]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Lenkurg", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Lenkurg","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[152]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Laren", "City_IncreasedBusinessTrade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[153]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  or  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[155]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true || BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  or  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[156]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[158]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[159]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Laren", "City_HighLevelsofPoverty");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_HighLevelsofPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[160]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

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
  - -> `[92]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true && BaseGame.Agnolia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[166]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[167]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[168]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[170]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[171]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_CeremonialScissors");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_CeremonialScissors");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[172]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Lenkurg", "2.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Lenkurg","2.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Lenkurg", "0.65");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Lenkurg","0.65");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[175]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Arvory", "5.1");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Arvory","5.1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Arvory", "1.35");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Arvory","1.35");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityGdp("Sordland_City_Lachaven", "83.5");)*
- **Efekt (`userScript`):** `UpdateCityGdp("Sordland_City_Lachaven","83.5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateCityPopulation("Sordland_City_Lachaven", "3.4");)*
- **Efekt (`userScript`):** `UpdateCityPopulation("Sordland_City_Lachaven","3.4");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[180]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: PlaySoundEffect("RibbonCut");)*
- **Efekt (`userScript`):** `PlaySoundEffect("RibbonCut");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[181]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
