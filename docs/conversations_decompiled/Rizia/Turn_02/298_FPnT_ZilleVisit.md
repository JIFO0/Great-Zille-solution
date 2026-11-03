# Rizia/Turn 2/FPnT_ZilleVisit

- **ID konwersacji:** `298`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/298_FPnT_ZilleVisit.md`
- **Liczba węzłów dialogowych:** 310
- **Liczba wyborów gracza:** 106

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[77]** Wiktor Smolak (R)
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Summer_Zille`
- `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel`
- `RiziaDLC.Turn01_ZilleVisit_HostileSpeech`
- `RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.Relations_Estela_TellAboutMurderCase`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Turn01_ZilleVisit_HostileSpeech`
- `RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse`
- `RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech`
- `RiziaDLCSupport.Journal_Turn02_Zille_HostileSpeech`
- `RiziaDLCSupport.News_Turn02_G_Bombing_HostileSpeech`
- `RiziaDLCSupport.News_Turn02_G_Bombing_Neutral`
- `RiziaDLCSupport.News_Turn02_RH_Bombing`
- `RiziaDLCSupport.Reports_Turn02_Zille_BombingReport`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 30

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Estela_TellAboutMurderCase`
- `RiziaDLC.Turn01_ZilleVisit_HostileSpeech`
- `RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse`
- `RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech`
- `RiziaDLCSupport.Journal_Turn02_Zille_HostileSpeech`
- `RiziaDLCSupport.Reports_Turn02_Zille_BombingReport`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[25]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse"] = true;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- Węzeł `[104]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- Węzeł `[149]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- Węzeł `[202]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTraditi...`
- Węzeł `[223]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] = true; Variable["RiziaDLCSupport.Journal_Tu...`
- Węzeł `[224]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- Węzeł `[284]` (Paskal Beniwoll): `PlayLoopedMusic("R_Stress","R_Stress_Loop"); ;`
- *...oraz 22 innych węzłów ze skryptami.*

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
  - -> `[309]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I couldn't tell if the sky was growing darker, or if it was just the tinted windows of the armored car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Our motorcade slowed as it approached the Zille border. A concrete barrier rose up in front of us, its top strung with barbed wire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "My mother had insisted on accompanying me to the Wehzek-Rizian Friendship Day festivities. She leaned against the window, uncharacteristically quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`
  - -> `[160]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you all right, Mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you thinking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing and kept my eyes fixed in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Estela Toras**
> ""I'm absolutely fine, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Estela Toras**
> ""I'm thinking you ought to have chosen a different jacket to go with those trousers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Estela Toras**
> ""Say, might we have time for a quick detour once we reach town?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[12]`
Mówca: **Narrator**
> "After a short while, she broke the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I want to get this over with as fast as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Estela Toras**
> ""That's perfectly fine. Mind if I smoke?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Narrator**
> "She leaned forward and gave the driver an address. He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Without waiting for an answer, she cracked open the window and lit a cigarette."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "At the border, we presented our identification documents and the official invitation from President Smolak. As we crossed, the road turned uneven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Estela Toras**
> ""Promise me you'll get these highways back up and running once Zille is returned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* Zille is returned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's at the top of my list.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Factory smokestacks rose up on either side of us. Through the haze, I spotted numerous shanty towns, built over the past few years to house miners and refinery workers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "We entered the city and drove on through a maze of tenement buildings, their facades hastily repainted to hide the damage from the war 20 years ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[26]`
Mówca: **Narrator**
> "As my mother had instructed him to, the driver veered down a side street that led toward the coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[30]`
Mówca: **Narrator**
> "We stopped in front of a small wooden building with a collapsed roof. The front porch was partly buried in sand; jagged teeth of broken glass lined the window frames."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Estela Toras**
> ""They say you can't go home again. Rarely do they mean it this literally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "She blinked back tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[34]`
  - -> `[38]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe this is the same place we used to go every summer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Zille))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be so dramatic, Mother. It's just a house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen will pay for what happened to your homeland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is where you grew up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Narrator**
> "She glared at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Estela Toras**
> ""I never brought my parents here after they fled to Rizia. I knew it would break their hearts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Narrator**
> "She put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[44]`
Mówca: **Estela Toras**
> ""I wish they could have seen it one last time. The way it used to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Narrator**
> "She swallowed hard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Narrator**
> "I thought back to my carefree summers in Zille. My grandparents had spent the last 10 years of their lives in Palas Rezna, surrounded by luxury, but they never seemed as happy as they did in this house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Zille))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "I tried to summon memories of my grandparents. They'd spent the last 10 years of their lives in Palas Rezna, surrounded by luxury, yet they always seemed ill at ease."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[51]`
Mówca: **Estela Toras**
> ""Enough dallying. Driver, step on it. We've got a date with a psychopath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "We returned to the main road and drove towards Smolak Square, a circular plaza in the center of town that had once been named after Duke Fedo Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[53]`
Mówca: **Narrator**
> "We both fell silent. After a few moments, she plastered a smile on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[54]`
Mówca: **Narrator**
> "We kept going in the direction of Smolak Square, a circular plaza in the center of town that had once been named after Duke Fedo Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They could have stayed. Plenty of Rizians did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You did everything you could for them. They should have been more grateful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll have it fixed up one day. It'll be our summer home again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[58]`
Mówca: **Estela Toras**
> ""No. Not after that horrible civil war. The only way they could have stayed is if I hadn't convinced Valero to get Wehlen involved in our affairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[59]`
Mówca: **Narrator**
> "A silver stretch limousine was parked just in front of the square. Our driver stopped and we exited the car, flanked by our guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[60]`
Mówca: **Wiktor Smolak (R)**
> ""Your Majesty King Romus! Queen Mother Estela!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "He made a sweeping, exaggerated bow and straightened up with a grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Wiktor Smolak (R)**
> ""Welcome to Wehlen. Please, make yourselves at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[195]`
  - -> `[66]`
  - -> `[191]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Mr. President, this *is* my home. I spent my childhood summers here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Wiktor Smolak (R)**
> ""Who is this Mr. President? Call me Wiktor. We're friends, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. President. I wish I could say I was happy to be here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Narrator**
> "He gestured out to the square, where a colorful banner reading '24 Years Of Wehzek-Rizian Friendship' hung above a trio of gleaming tanks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[77]`
  - -> `[74]`

### Węzeł `[68]`
Mówca: **Wiktor Smolak (R)**
> ""Of course, of course. My home is your home, your home is my home. We're friends!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[69]`
Mówca: **Wiktor Smolak (R)**
> ""Why so glum, Your Majesty? How could anyone not be happy on a day like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[70]`
Mówca: **Estela Toras**
> ""Say what you will about Smolak, he never makes a dull entrance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "A dozen uniformed soldiers hurriedly got into formation around us and the limo. The door opened, and Wiktor Smolak stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, yes. Nothing symbolizes friendship like heavy artillery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looks impressive. Where did you get those tanks?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's my first time at one of these ceremonies. What's going to happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Wiktor Smolak (R)**
> ""Exactly! Who doesn't love tanks? Today's audience certainly does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Wiktor Smolak (R)**
> ""The usual. I make a speech, you make a speech, the press takes pictures, everyone goes home happy. Listen to the crowd! They're already happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been wanting to speak with you about the terms of this *friendship.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Narrator**
> "The square was surrounded by grandstands -- one side decorated in the colors of Wehlen's flag, the other in Rizia's blue, orange and gold. I heard loud cheers emanating from them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Wiktor Smolak (R)**
> ""In due time, Your Majesty. First we have some speeches to get through. We can't let down our adoring public!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Wiktor Smolak (R)**
> ""Rizia isn't Wehlen's only friend, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[81]`
Mówca: **Wiktor Smolak (R)**
> ""I've invited the finest representatives from both of our countries to join us for this special occasion. Follow me, if you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[82]`
Mówca: **Estela Toras**
> ""Grateful for what? If I hadn't convinced Valero to get Wehlen involved in our affairs, they never would have had to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Estela Toras**
> ""That ship has sailed, child. Just think, If I hadn't convinced Valero to get Wehlen involved in our affairs, none of this would've happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Narrator**
> "She looked down at her hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Estela Toras**
> ""The Wehzek president back then was such an upstanding man. How could I have known he'd go and get himself killed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[151]`
  - -> `[152]`
  - -> `[189]`

### Węzeł `[86]`
Mówca: **Narrator**
> "A semicircular stage was set up in front of the tanks. The crowd roared as we crossed the square and made our way over to it. Looking up into the grandstands, I noticed armed guards standing on every level."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[87]`
Mówca: **Narrator**
> "My mother and I took our seats. Wiktor stepped up to the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Wiktor Smolak (R)**
> ""Wehzeks! Rizians! People of Zille!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Wiktor Smolak (R)**
> ""Two dozen years ago, the glorious country of Wehlen was given custody over this land. A great honor, and a tremendous responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Wiktor Smolak (R)**
> ""Wehlen didn't only gain new territory that day. We gained new friends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "He gestured meaningfully towards the Rizian side of the stands. After a few seconds, they broke out in scattered applause. My mother muttered a harsh-sounding curse in Zille dialect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`
  - -> `[113]`

### Węzeł `[92]`
Mówca: **Wiktor Smolak (R)**
> ""Together, we have overcome war, repaired our economy and made great strides in science and industry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[93]`
Mówca: **Wiktor Smolak (R)**
> ""I look forward to strengthening that bond for many, many years to come!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "He stepped to the side and pulled a rope attached to a flagpole. A massive Wehzek flag unfurled, then a much smaller Rizian one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[95]`
Mówca: **Estela Toras**
> ""A captive audience. That would explain the enthusiasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`
  - -> `[98]`
  - -> `[101]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disgusting. This whole ceremony is a sham.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nice idea. The crowd at my coronation sounded lackluster by comparison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe they're happy. They don't get many excuses for celebration around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at the sloppy way they're holding their guns. They have nothing on our recruits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "Interject."]** — Mówca: **Player_Romus_Italic**
> "I stood up and grabbed a microphone. I heard gasps and hushed whispers coming from the grandstands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "Let Wiktor finish his speech."]** — Mówca: **Player_Romus_Italic**
> "I sat back in my chair and kept silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I stand before you at the dawning of a new era. The reign of Valero Toras is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`
  - -> `[213]`
  - -> `[212]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not know it, but I am a grandson of Zille. The Queen Mother and I have deep ties to this land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`
  - -> `[213]`
  - -> `[212]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is an honor to be here in Zille on the anniversary of our historic treaty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`
  - -> `[213]`
  - -> `[212]`

### Węzeł `[110]`
Mówca: **Wiktor Smolak (R)**
> ""Today, I am especially delighted to be blessed with the presence of Rizia's new king. As well as the Queen Mother, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quiet. We're supposed to play nice, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know. I can't believe this guy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did you just say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Estela Toras**
> ""'May your testicles be stung by a thousand jellyfish.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[115]`
Mówca: **Wiktor Smolak (R)**
> ""Even the decision of the Toras family to ally with Rumburg, a nation that obviously wishes Wehlen harm, could not diminish the beautiful bond we have formed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[116]`
Mówca: **Wiktor Smolak (R)**
> ""They are heirs to a long, proud legacy. One that would have been shattered had Wehlen and Rizia not made the fateful decision to work hand in hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Wiktor Smolak (R)**
> ""On that note...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Wiktor Smolak (R)**
> ""Please give a warm welcome to King Romus Toras!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "Rise."]** — Mówca: **Player_Romus_Italic**
> "I stood up. The Rizian side of the stands immediately erupted in loud, authentic-sounding applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, President Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`
  - -> `[109]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Zille Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[122]`
  - -> `[209]`
  - -> `[123]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My fellow Rizians!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`
  - -> `[109]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Brothers and sisters!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`
  - -> `[109]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Long live our friendship!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[126]`
Mówca: **Narrator**
> ""Glory to Rizia!" echoed the Rizian side of the stands. Wiktor gave me an appraising glance, then readjusted the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All hail Wehlen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Both sides of the stands applauded. Wiktor gave me an appraising glance, then readjusted the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Loud applause broke out from the Wehzeks in the audience. Wiktor shot me an appraising glance, then turned back to his microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[130]`
Mówca: **Wiktor Smolak (R)**
> ""What a speech! The king's got charisma!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Wiktor Smolak (R)**
> ""We have a terrific evening of entertainment lined up. But first, we must commemorate this landmark meeting of world leaders with a traditional triple-tank salute!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "There was a rumbling from behind us as the three tanks aimed their barrels into the air. My mother and I looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`
  - -> `[137]`

### Węzeł `[133]`
Mówca: **Wiktor Smolak (R)**
> ""One!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[134]`
Mówca: **Narrator**
> "The tank on the left fired, sending a plume of gold-colored smoke high over the stands. The crowd gasped in excitement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the first time I've heard of this tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those really are some impressive tanks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure... After you, Mr. Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Estela Toras**
> ""A Wiktor Smolak special.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Estela Toras**
> ""We can thank his Eastern benefactors, I presume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Wiktor raised a finger up in the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[141]`
Mówca: **Wiktor Smolak (R)**
> ""Two!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[142]`
Mówca: **Narrator**
> "The gun mounted to the tank on the right went off. This time, the smoke was magenta."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Wiktor Smolak (R)**
> ""Thr--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Narrator**
> "His count was interrupted by an unidentified voice in the distance, shouting "For the King!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that part of the program?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who was that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[147]`
Mówca: **Narrator**
> "Wiktor whipped his head around in shock, a frenzied look in his eyes. I turned to my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`
  - -> `[188]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If he was so upstanding, he wouldn't have agreed to stomp out a democratic revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Estela Toras**
> ""What revolution? If those terrorists were acting on behalf of the Rizian people, they wouldn't have harmed innocents. Yourself included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your fault. Father should have reneged on the agreement immediately after the assassination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a period of instability across all of Merkopa. You were playing with fire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Estela Toras**
> ""And made outright enemies of Wehlen while our own country was still weak? Don't be foolish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[154]`
Mówca: **Estela Toras**
> ""Would you have done any differently if Vina was in danger?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[155]`
Mówca: **Estela Toras**
> ""I don't--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[156]`
Mówca: **Narrator**
> "A deafening blast, much louder than the two that had preceded it, echoed from the opposite end of the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[157]`
**[WYBÓR GRACZA: "Get down."]** — Mówca: **Player_Romus_Italic**
> "I dove from the dais and flung myself onto the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "Run towards the stands."]** — Mówca: **Player_Romus_Italic**
> "I rushed towards the stands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "Run away from the stands."]** — Mówca: **Player_Romus_Italic**
> "I rushed away from the stands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had an interesting talk with Pabel recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Estela Toras**
> ""Oh? I'm glad the two of you are still close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[177]`
  - -> `[171]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Estela Toras**
> ""He talks? I always saw him as a sort of walking hors d'oeuvre platter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[177]`
  - -> `[171]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was Father acting out of the ordinary the night of his death?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When was the last time you saw Father? Before he died, I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you know about mandragora?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[172]`
Mówca: **Narrator**
> "She arched an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Estela Toras**
> ""I told you, we had dinner together. After he made Pabel taste the food.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[174]`
Mówca: **Estela Toras**
> ""Any more out of the ordinary than ordinary, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Estela Toras**
> ""No. He went to bed early, as he'd been doing for months. A symptom of old age, for some.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[176]`
Mówca: **Estela Toras**
> ""I've never heard of her. Is she a noble?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[183]`
  - -> `[182]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me again. How did you discover Father had died?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Narrator**
> "She arched an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Estela Toras**
> ""I told you. I went to check on him a few hours after supper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Estela Toras**
> ""Why do you ask?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[183]`
  - -> `[182]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel thinks Father was poisoned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll tell you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Estela Toras**
> ""And they say butlers have no imaginations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Estela Toras**
> ""Your father had a long list of enemies, and an equally long list of safeguards against them. His worries were what stopped his heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Estela Toras**
> ""How cruel of you to pique my interest like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Narrator**
> "She folded her arms and was silent for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mother. What happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""None of this was Wehlen's fault. It was the superpowers trying to use the country as a pawn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Estela Toras**
> ""Nobody forced Wiktor Smolak to turn my homeland into his country's armpit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Zille == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Mr. President, this *is* my mother's home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's heartening to see that Zille remains in good hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Wiktor Smolak (R)**
> ""Yes, yes! This square used to be gray and boring. Now look at it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[197]`
Mówca: **Wiktor Smolak (R)**
> ""It'll be your turn to speak in a minute, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[199]`
  - -> `[198]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mistake. Please go on, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me, but your words were so inspiring I couldn't stay quiet for a moment longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've said more than enough already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Wiktor stared me down for a second. I suddenly became aware of how tall he was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_BrokeTradition += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[203]`
Mówca: **Wiktor Smolak (R)**
> ""By all means, then, continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
Mówca: **Narrator**
> "Wiktor stared me down for a second. I suddenly became aware of how tall he was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Wiktor Smolak (R)**
> ""I will. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Narrator**
> "He turned back to the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[207]`
Mówca: **Narrator**
> "I turned to face the crowd. The Rizian side of the stands erupted in loud, authentic-sounding applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Zille Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My loyal subjects!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`
  - -> `[109]`

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It pained me when my father signed away this beautiful part of Rizia. Yet I knew it was for the greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`
  - -> `[215]`
  - -> `[227]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today marks a chance to make a clean break with the past and begin looking towards the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`
  - -> `[215]`
  - -> `[214]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know none of the Rizians here today asked for their homeland to be governed by Wehlen. I myself had no choice in the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[215]`
  - -> `[222]`
  - -> `[214]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will never forget what Wehlen did for my family and my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`
  - -> `[215]`
  - -> `[227]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have come here to send Wiktor Smolak a warning. If Zille is not returned, he will face Rizia's full retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The past years have not been easy for any of you. But the time will soon come when we are reunited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`
  - -> `[216]`
  - -> `[230]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As ATO encroaches on our continent, it is vital that the nations of Southeastern Merkopa unite as one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[242]`
  - -> `[125]`
  - -> `[127]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In one year, Rizia will resume governorship of Zille. But I hope that will not mean an end to our countries' friendly cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`
  - -> `[216]`
  - -> `[230]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I commend Wiktor Smolak for his exemplary leadership in the face of war and terrorism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`
  - -> `[216]`
  - -> `[230]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the Rizians here today, I say: Do not forget your motherland. Be ready to defend her if necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pledge to support Rizians and Wehzeks alike through the upcoming peaceful transfer of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[242]`
  - -> `[125]`
  - -> `[127]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that I can count on the President of Wehlen to do what's best for Zille until it is back in Rizia's custody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[242]`
  - -> `[125]`
  - -> `[127]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet I commend Wiktor Smolak for his exemplary leadership in the face of war and terrorism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`
  - -> `[216]`
  - -> `[230]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech = true; RiziaDLCSupport.Journal_Turn02_Zille_HostileSpeech = true;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Zille_HostileSpeech"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pledge to support Rizians and Wehzeks alike through the upcoming transfer of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I call on the people of Rizia to resist your Wehzek oppressors. Remind them in whose country they reside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I have come here to send Wiktor Smolak a warning. If Zille is not returned, he will face Rizia's full retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[228]`
Mówca: **Narrator**
> "The crowd went completely silent. Wiktor's mouth hung open in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[219]`
  - -> `[225]`
  - -> `[226]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To my countrymen, I say: Be patient. A mere year from now, we will be reunited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite our political differences, Rizia and Wehlen have much in common. There's no limit to what we can accomplish together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[242]`
  - -> `[125]`
  - -> `[127]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wiktor, I know you are a man of honor. When the time comes, you will do what is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The president of Wehlen believes these tanks will intimidate us. We will show him how wrong he is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People of Wehlen, I invite you to stay in Zille once it is part of my kingdom again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On behalf of House Toras, there will be justice for what has been done to Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you and happy Friendship Day!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The King has spoken!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Narrator**
> "A few tentative claps came from the Rizian side of the stands. I looked back at my mother. She spoke through gritted teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Estela Toras**
> ""Romus, are you insane?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Wiktor's face remained placid. He readjusted his microphone, gripping it so tightly that his knuckles turned white."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Wiktor Smolak (R)**
> ""That was some speech, Your Majesty! And right in front of the international press, as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The King has spoken!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[243]`
Mówca: **Wiktor Smolak (R)**
> ""Let's not allow King Romus to spoil the mood on this fine day. It's time to commemorate the occasion with a traditional three-tank salute!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[244]`
Mówca: **Titus Gordion**
> ""YOUR MAJESTY!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[245]`
**[WYBÓR GRACZA: "Protect Estela."]** — Mówca: **Player_Romus_Italic**
> "I flung myself in front of my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[246]`
Mówca: **Titus Gordion**
> ""YOUR MAJESTY! GET DOWN!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Narrator**
> "Titus dove at me and tackled me to the ground. Screams of fear and confusion were rising up from all around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[249]`
  - -> `[253]`

### Węzeł `[248]`
Mówca: **Narrator**
> "Titus rushed to cover me, gun at the ready. Screams of fear and confusion were rising up from all around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[249]`
  - -> `[253]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's Mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[251]`
Mówca: **Titus Gordion**
> ""YOUR MAJESTY!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Narrator**
> "Titus rushed to our side, gun at the ready. Screams of fear and confusion were rising up from all around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's Smolak?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[254]`
Mówca: **Titus Gordion**
> ""Security breach, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get me over there, Titus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[256]`
Mówca: **Estela Toras**
> ""Romus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Narrator**
> "My mother and Wiktor were still on the podium, surrounded by a thick cordon of Wehzek guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Mother!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you lay a hand on her, Smolak!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[260]`
Mówca: **Narrator**
> "I turned towards the source of the sound and saw the Wehzek side of the stands engulfed in flames."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`
  - -> `[157]`
  - -> `[245]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's Smolak?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Titus Gordion**
> ""Security breach, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Wiktor Smolak (R)**
> ""Right here, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Narrator**
> "Wiktor stood beside us on the podium, his own gun drawn. He was surrounded by a thick cordon of Wehzek guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Titus Gordion**
> ""We've got to get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Narrator**
> "He and Smolak's guards exchanged a series of hand signals. The crowd had begun fleeing in every direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[268]`
Mówca: **Titus Gordion**
> ""They'll be fine. We have to get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Narrator**
> "He and Smolak's guards exchanged a series of hand signals. The crowd had begun fleeing in every direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Narrator**
> "Titus grabbed my arm and swiftly started ushering me away. I took one last look back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Narrator**
> "Smoke was now rising from the Wehzek grandstand. Part of the structure had collapsed, and soldiers were working to free the people trapped underneath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Narrator**
> "The next few moments were a blur as we made our way through the panicked hordes of civilians. Wiktor's limo pulled up and Titus roughly shoved me inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Estela Toras**
> ""Thank God you're safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Narrator**
> "My mother's voice shook. She and Wiktor were sitting across from me, looking dazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're going to get to the bottom of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What have you done, Smolak?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you hurt?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Wiktor Smolak (R)**
> ""Of course she isn't. It seemed like *no Rizian* was harmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[279]`
Mówca: **Wiktor Smolak (R)**
> ""It's no great mystery, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Wiktor Smolak (R)**
> ""What have *I* done, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Narrator**
> "Smolak had fire in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Wiktor Smolak (R)**
> ""If your people have anything to do with this, there will be a price to pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Narrator**
> "He kept his eyes on me as the car began pulling away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Stress", "R_Stress_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Stress","R_Stress_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Estela_TellAboutMurderCase = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2;
RiziaDLCSupport.News_Turn02_RH_Bombing = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 2;
Variable["RiziaDLCSupport.News_Turn02_RH_Bombing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_G_Bombing_HostileSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_Bombing_HostileSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_G_Bombing_Neutral = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_Bombing_Neutral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Alliances","R_Alliances_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("R_ZilleExplosion");)*
- **Efekt (`userScript`):** `PlaySoundEffect("R_ZilleExplosion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn02_Zille_BombingReport = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_Zille_BombingReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("StandApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("StandApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("StandApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("StandApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("StandApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("StandApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CannonLeft");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CannonLeft");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CannonRight");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CannonRight");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Rizia_Map_Music_Tense");)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Surviving a bombing during the Rizia-Zille Friendship Day", "Zille", "Republic of Wehlen");)*
- **Efekt (`userScript`):** `SetRichPresence("Surviving a bombing during the Rizia-Zille Friendship Day","Zille","Republic of Wehlen");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
